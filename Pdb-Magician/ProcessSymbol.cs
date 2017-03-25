using Dia2Lib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private List<string> _doneList = new List<string>();
        private JObject _manifestRootNodes;
        JArray _manifestRootArray;
        List<string> _accessBlock = new List<string>();


        private bool ProcessSymbol(Symbol s)
        {
            _accessBlock.Clear();
            List<string> variablesBlock = new List<string>(); // used for global variables
            List<FunctionRecord> entries = new List<FunctionRecord>();
            string structureName = s.Name;
            // unnamed is a special case and I want the function names to be in the same form as the others i.e. _FUNCTION_NAME
            if (structureName.StartsWith("<unnamed-"))
            {
                structureName = structureName.Replace("<unnamed-", "_UNNAMED_");
                structureName = structureName.TrimEnd(new char[] { '>' });
            }
            // just make sure it hasn't been done already
            if (_doneList.Contains(structureName))
                return true;
            // create the top of the source file
            AddToBody("#region " + structureName, 1);
            variablesBlock.Add("private Byte[] _StructureData;");
            variablesBlock.Add("private int _BufferOffset;");
            // start a new manifest file
            CreateNewManifest((int)s.Length);
            // get the symbol children
            IDiaEnumSymbols children = s.TryChildren();
            // process each child
            FunctionRecord fr;
            Debug.WriteLine("PROCESSING: " + structureName);
            foreach (IDiaSymbol child in children)
            {
                fr = ProcessChild(child);
                entries.Add(fr);
            }
            foreach (FunctionRecord entry in entries)
            {
                if (!entry.isBuiltinType && structureName != entry.type && !_doneList.Contains(entry.type) && !_todoList.Contains(entry.type) && !entry.type.StartsWith("_UNNAMED"))
                {
                    if (entry.isArray)
                    {
                        _todoList.Add(entry.arrayType);
                        Debug.WriteLine("Adding: " + entry.arrayType);
                    }
                    else
                    {
                        _todoList.Add(entry.type);
                        Debug.WriteLine("Adding: " + entry.type);
                    }
                }
            }
            string[] manifestParts = TidyManifest(structureName);
            // write out the body
            AddToBody(" ", 0);
            AddToBody("public class " + structureName, 1);
            AddToBody("{", 1);
            foreach (string a in variablesBlock)
                AddToBody(a, 2);
            AddToBody("public " + structureName + "(Byte[] Buffer, int PartitionOffset)", 2);
            AddToBody("{", 2);
            AddToBody("_StructureData = Buffer;", 3);
            AddToBody("_BufferOffset = PartitionOffset;", 3);
            AddToBody("}", 2);
            AddToBody("public int MxStructureSize { get { return " + s.Length.ToString() + "; } }", 2);

            AddToBody("public string manifest", 2);
            AddToBody("{", 2);
            AddToBody("get", 3);
            AddToBody("{", 3);
            AddToBody("return @\"(", 4);
            foreach (string line in manifestParts)
                AddToBody(line, 4);
            AddToBody(")\";", 4);
            AddToBody("}", 3);
            AddToBody("}", 2);

            foreach (String a in _accessBlock)
                AddToBody(a, 2);

            AddToBody("}", 1);
            AddToBody("#endregion", 1);

            _doneList.Add(structureName);
            return true;
        }
        private FunctionRecord ProcessChild(IDiaSymbol child)
        {
            Symbol c = new Symbol(child);
            Members member = new Members(c);
            Symbol grandChild = c.InspectType();
            Symbol greatGrandChild = grandChild.InspectType();
            if ("RecordType" == c.Name)
            {
                Debug.WriteLine("");
            }

            // I'm specifically looking for the unnamed types here since this is the best opportunity
            // the record where they are and queue them up for processing
            if (grandChild.Name != null && grandChild.Kind != SymbolKind.Enum && grandChild.Name.StartsWith("<unnamed-"))
            {
                _todoSymbolList.Add(grandChild);
            }
            if (greatGrandChild.RootSymbol != null && greatGrandChild.Kind != SymbolKind.Enum && greatGrandChild.Name != null && greatGrandChild.Name.StartsWith("<unnamed-"))
            {
                _todoSymbolList.Add(greatGrandChild);
            }
            // create a FunctionRecord helper
            FunctionRecord fr = new FunctionRecord(c, member, grandChild, _pointerSize);
            LocationType location = (LocationType)member.locationType;
            // bitfields need special processing so look for those first
            if(location == LocationType.LocIsBitField)
            {
                ProcessBitfield(fr, member, grandChild, c);
            }
            else
            {
                ProcessTheRest(fr, member, grandChild, c);
            }
            return fr;
        }

        private void ProcessTheRest(FunctionRecord fr, Members member, Symbol grandChild, Symbol child)
        {
            fr.type = fr.friendlySymbolType;
            if(fr.isEnum)
            {
                AddEnumToAccessBlock(fr);
                AddEnumToManifest(fr);
            }
            // am I pointing to another structure which should always begin with an underscore (I hope)
            else if (!fr.isBuiltinType && !fr.isArray)
            {
                AddStructureToAccessBlock(fr);
                AddStructureToManifest(fr);
            }
            else
            {
                // am I dealing with an array of some kind?
                if (fr.isArray || fr.isMultiDimensionalArray)
                {
                    AddArrayToAccessBlock(fr);
                    AddArrayToManifest(fr);
                }
                else
                {
                    // we should be down to regular inbuilt types now
                    // we need to treat bytes differently
                    if (fr.friendlySymbolType == "Byte")
                    {
                        AddByteTypeToAccessBlock(fr);
                    }
                    else
                    {
                        AddTypeToAccessBlock(fr);
                    }
                    // and then the manifest part
                    if(fr.isPointer)
                    {
                        AddPointerToManifest(fr);
                    }
                    else
                    {
                        AddSimpleTypeToManifest(fr);
                    }
                }
            }
        }

        private void ProcessBitfield(FunctionRecord fr, Members member, Symbol grandChild, Symbol child)
        {
            UpdateType(ref fr);

            AddBitfieldToAccessBlock(fr);

            AddBitfieldToManifest(fr);
        }
        #region MANIFEST
        private void AddEnumToManifest(FunctionRecord fr)
        {
            Dictionary<string, object> loaded = new Dictionary<string, object>();
            loaded.Add("enum_name", fr.enumName);
            loaded.Add("target", fr.enumTarget);
            JArray section = GetJsonSection("Enumeration", fr.offset, loaded);
            _manifestRootNodes.Add(new JProperty(fr.name, section));

        }
        private void CreateNewManifest(int structureLength)
        {
            _manifestRootNodes = new JObject();
            _manifestRootArray = new JArray();
            _manifestRootArray.Add(structureLength);
            _manifestRootArray.Add(_manifestRootNodes);
        }
        private void AddBitfieldToManifest(FunctionRecord fr)
        {
            Dictionary<string, object> loaded = new Dictionary<string, object>();
            loaded.Add("end_bit", fr.endBit);
            loaded.Add("start_bit", fr.startBit);
            loaded.Add("target", fr.friendlySymbolType);
            JArray section = GetJsonSection("BitField", fr.offset, loaded);
            _manifestRootNodes.Add(new JProperty(fr.name, section));
        }
        private void AddStructureToManifest(FunctionRecord fr)
        {
            JArray section = GetJsonSection(fr.friendlySymbolType, fr.offset);
            _manifestRootNodes.Add(new JProperty(fr.name, section));
        }
        private void AddArrayToManifest(FunctionRecord fr)
        {
            if (fr.arrayTarget == SymbolKind.BaseType)
            {
                Dictionary<string, object> loaded = new Dictionary<string, object>();
                loaded.Add("count", fr.arrayCount);
                loaded.Add("target", fr.arrayType);
                if (fr.targetArg != "")
                    loaded.Add("targetType", fr.targetArg);
                JArray section = GetJsonSection("Array", fr.offset, loaded);
                _manifestRootNodes.Add(new JProperty(fr.name, section));
            }
            else if (fr.arrayTarget == SymbolKind.Enum)
            {
                Dictionary<string, object> inner = new Dictionary<string, object>();
                inner.Add("enum_name", fr.enumName);
                inner.Add("target", fr.enumTarget);
                Dictionary<string, object> loaded = new Dictionary<string, object>();
                loaded.Add("size", fr.arrayCount * fr.enumLength);
                loaded.Add("target", "Enumeration");
                loaded.Add("target_args", inner);
                JArray section = GetJsonSection("Array", fr.offset, loaded);
                _manifestRootNodes.Add(new JProperty(fr.name, section));

            }
            else if(fr.isMultiDimensionalArray)
            {
                string[] parts = fr.symbolType.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 3)
                {
                    Dictionary<string, object> inner = new Dictionary<string, object>();
                    inner.Add("count", fr.arrayCount);
                    inner.Add("target", fr.arrayType);
                    Dictionary<string, object> loaded = new Dictionary<string, object>();
                    loaded.Add("size", fr.arraySize);
                    loaded.Add("target", "Array");
                    loaded.Add("target_args", inner);
                    JArray section = GetJsonSection("Array", fr.offset, loaded);
                    _manifestRootNodes.Add(new JProperty(fr.name, section));
                }
                if (parts.Length == 4)
                {
                    Dictionary<string, object> inner = new Dictionary<string, object>();
                    inner.Add("count", fr.arrayCount);
                    inner.Add("target", fr.arrayType);
                    Dictionary<string, object> middle = new Dictionary<string, object>();
                    middle.Add("size", fr.innerArraySize);
                    middle.Add("target", "Array");
                    middle.Add("target_args", inner);
                    Dictionary<string, object> loaded = new Dictionary<string, object>();
                    loaded.Add("size", fr.arraySize);
                    loaded.Add("target", "Array");
                    loaded.Add("target_args", middle);
                    JArray section = GetJsonSection("Array", fr.offset, loaded);
                    _manifestRootNodes.Add(new JProperty(fr.name, section));
                }

            }
        }
        private void AddPointerToManifest(FunctionRecord fr)
        {
            Dictionary<string, object> loaded = new Dictionary<string, object>();
            loaded.Add("target", fr.symbolType.Substring(0, fr.symbolType.Length - 1));
            JArray section = GetJsonSection("Pointer", fr.offset, loaded);
            _manifestRootNodes.Add(new JProperty(fr.name, section));
        }
        private void AddSimpleTypeToManifest(FunctionRecord fr)
        {
            JArray section = GetJsonSection(fr.friendlySymbolType, fr.offset);
            _manifestRootNodes.Add(new JProperty(fr.name, section));
        }
        private string[] TidyManifest(string structureName)
        {            
            JObject root = new JObject(new JProperty(structureName, _manifestRootArray));
            string manifest = root.ToString().Replace('\n', ' ').Replace('\r', ' ').Replace("],", "],\n   ");
            for (int r = 0; r < 8; r++)
                manifest = manifest.Replace("  ", " ");
            manifest = manifest.Replace("} ]", "}]");
            manifest = manifest.Replace("] ]", "]]");
            manifest = manifest.Replace("\"", "\"\"");
            int index = 0;
            for (int t = 0; t < 2; t++)
            {
                index = manifest.IndexOf('{', index) + 1;
                manifest = manifest.Insert(index, "\n");
            }
            manifest = manifest.Insert(manifest.Length - 2, "\n");
            string[] manifestParts = manifest.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return manifestParts;
        }
        #endregion
        #region ACCESS BLOCK
        private void AddEnumToAccessBlock(FunctionRecord fr)
        {
            _accessBlock.Add("public " + fr.friendlySymbolType + " " + fr.name + " { get { return (" + fr.friendlySymbolType + ")BitConverter.To" + fr.enumTarget + "(_StructureData, _BufferOffset + " + fr.offset + "); } }");
        }
        private void AddBitfieldToAccessBlock(FunctionRecord fr)
        {
            int max = 16 > fr.endBit ? 16 : fr.endBit;
            _accessBlock.Add("public " + fr.structureType + " " + fr.name);
            _accessBlock.Add("{");
            _accessBlock.Add("\tget");
            _accessBlock.Add("\t{");
            _accessBlock.Add("\t\t// start: " + fr.startBit + "  end: " + fr.endBit + "  Mask: " + Convert.ToString((int)fr.bitMask, 2).PadLeft(max, '0'));
            if (fr.friendlySymbolType == "Byte")
                _accessBlock.Add("\t\t" + fr.structureType + " value = _StructureData[_BufferOffset + " + fr.offset + "];");
            else
                _accessBlock.Add("\t\tvar value = BitConverter.To" + fr.structureType + "(_StructureData, _BufferOffset + " + fr.offset + ");");

            _accessBlock.Add("\t\tvar value2 = (value & " + fr.bitMask + ") >> " + fr.startBit + ";");
            _accessBlock.Add("\t\treturn (" + fr.structureType + ")value2;");

            _accessBlock.Add("\t}");
            _accessBlock.Add("}");
        }
        private void AddStructureToAccessBlock(FunctionRecord fr)
        {
            _accessBlock.Add("public " + fr.friendlySymbolType + " " + fr.name);
            _accessBlock.Add("{");
            _accessBlock.Add("\tget");
            _accessBlock.Add("\t{");
            _accessBlock.Add("\t\t" + fr.friendlySymbolType + " returnValue = new " + fr.friendlySymbolType + "(_StructureData, _BufferOffset + " + fr.offset + ");");
            _accessBlock.Add("\t\treturn returnValue;");
            _accessBlock.Add("\t}");
            _accessBlock.Add("}");
        }
        private void AddArrayToAccessBlock(FunctionRecord fr)
        {
            _accessBlock.Add("public " + fr.structureType + " " + fr.name);
            _accessBlock.Add("{");
            _accessBlock.Add("\tget");
            _accessBlock.Add("\t{");
            _accessBlock.Add("\t\t" + fr.structureType + " returnValue = new " + fr.type + ";");

            if (fr.arrayTarget == SymbolKind.BaseType)
            {
                if (!fr.isBuiltinType)
                    _accessBlock.Add("\t\tint size = returnValue[0].MxStructureSize;");
                _accessBlock.Add("\t\tfor(int i=0; i<" + fr.arrayCount + "; i++ )");
                if (!fr.isBuiltinType)
                    _accessBlock.Add("\t\t\treturnValue[i] = new " + fr.arrayType + "(_StructureData, (i * size) + _BufferOffset + " + fr.offset + ");");
                else if (fr.arrayType == "Byte")
                    _accessBlock.Add("\t\t\treturnValue[i] = _StructureData[i + _BufferOffset + " + fr.offset + "];");
                else
                    _accessBlock.Add("\t\t\treturnValue[i] = BitConverter.To" + fr.arrayType + "(_StructureData, (i * sizeof(" + fr.arrayType + ")) + _BufferOffset + " + fr.offset + ");");
            }
            else if (fr.arrayTarget == SymbolKind.Enum)
            {
                _accessBlock.Add("\t\tint size = " + fr.enumLength + ";");
                _accessBlock.Add("\t\tfor(int i=0; i<" + fr.arrayCount + "; i++ )");
                _accessBlock.Add("\t\t\treturnValue[i] = (" + fr.arrayType + ")BitConverter.To" + fr.enumTarget + "(_StructureData, (i * size) + _BufferOffset + " + fr.offset + ");");

            }
            else if (fr.arrayTarget == SymbolKind.UDT)
            {
                _accessBlock.Add("\t\tint size = returnValue[0].MxStructureSize;");
                _accessBlock.Add("\t\tfor(int i=0; i<" + fr.arrayCount + "; i++ )");
                _accessBlock.Add("\t\t\treturnValue[i] = new " + fr.arrayType + "(_StructureData, (i * size) + _BufferOffset + " + fr.offset + ");");
            }
            else if(fr.isMultiDimensionalArray)
            {
                if (!fr.isBuiltinType)
                    _accessBlock.Add("\t\tint size = returnValue[0].MxStructureSize;");
                else
                    _accessBlock.Add("\t\tint size = " + fr.enumLength + ";");
                _accessBlock.Add("\t\tfor(int i=0; i<" + fr.enumLength + "; i++ )");
                if (!fr.isBuiltinType)
                    _accessBlock.Add("\t\t\treturnValue[i] = new " + fr.arrayType + "(_StructureData, (i * size) + _BufferOffset + " + fr.offset + ");");
                else
                    _accessBlock.Add("\t\t\treturnValue[i] = (" + fr.arrayType + ")BitConverter.To" + fr.arrayType + "(_StructureData, (i * size) + _BufferOffset + " + fr.offset + ");");

            }
            _accessBlock.Add("\t\treturn returnValue;");
            _accessBlock.Add("\t}");
            _accessBlock.Add("}");

        }
        private void AddByteTypeToAccessBlock(FunctionRecord fr)
        {
            _accessBlock.Add("public " + fr.friendlySymbolType + " " + fr.name + "{ get { return _StructureData[_BufferOffset +" + fr.offset + "]; } }");
        }
        private void AddTypeToAccessBlock(FunctionRecord fr)
        {
            _accessBlock.Add("public " + fr.friendlySymbolType + " " + fr.name + " { get { return BitConverter.To" + fr.friendlySymbolType + "(_StructureData, _BufferOffset + " + fr.offset + "); } }");
        }
        #endregion
        /// <summary>
        ///  this is still too big and needs to be broken down
        ///  
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private void UpdateType(ref FunctionRecord record)
        {
            string originalType = record.type;
            if (originalType.EndsWith("*"))
            {
                record.structureType = (record.length == 8) ? "UInt64" : "UInt32";
                return;
            }
            if (originalType.EndsWith("]"))
            {
                string[] parts = originalType.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                record.structureType = parts[0] + "[]";
                return;
            }
            if (originalType.StartsWith("_"))
            {
                record.structureType = "Byte[]";
                return;
            }
            if (originalType == "BitField")
            {
                if (record.length == 1)
                    record.structureType = "Byte";
                else if (record.length == 2)
                    record.structureType = "UInt16";
                else if (record.length == 4)
                    record.structureType = "UInt32";
                else if (record.length == 8)
                    record.structureType = "UInt64";
                return;
            }

            record.structureType = originalType;
        }
        
        private JArray GetJsonSection(string name, int length, Dictionary<string, object> members = null)
        {
            JArray j = new JArray();
            JArray inner = new JArray();
            var body = JsonConvert.SerializeObject(members);
            inner.Add(name);
            inner.Add(body);
            j.Add(length);
            j.Add(inner);
            return j;
        }
    }
}
