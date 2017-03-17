using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private List<string> _bodyList = new List<string>();

        private void AddToBody(string line, int indent)
        {
            string newLine = "";
            for (int i = 0; i < indent; i++)
            {
                newLine += "\t";
            }
            newLine += line;
            _bodyList.Add(newLine);
        }

        private bool ExportStructures()
        {
            try
            {
                string outputFile = Path.Combine(_destinationFolder, "PdbStructures.cs");

                string Contents = JsonConvert.SerializeObject(_doneList).Replace("\"", "\"\"");
                /// start by writing out the header part
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("");
                    writer.WriteLine("namespace MemoryExplorer.Symbols");
                    writer.WriteLine("{");
                }
                /// write out the header function
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    writer.WriteLine("\t#region HEADER");
                    writer.WriteLine("\tpublic static class CatalogueInformation");
                    writer.WriteLine("\t{");
                    Guid g = _session.globalScope.guid;
                    writer.WriteLine("\t\t public static Guid Guid { get { return new Guid(\"" + g.ToString().ToUpper() + "\"); } }");
                    uint age = _session.globalScope.age;
                    writer.WriteLine("\t\t public static uint Age { get { return " + age.ToString() + "; } }");
                    Machine m = (Machine)_session.globalScope.machineType;
                    writer.WriteLine("\t\t public static string MachineType { get { return @\"" + m.ToString() + "\"; } }");
                    writer.WriteLine("\t\t public static string SymbolsFileName { get { return @\"" + _session.globalScope.name + ".pdb\"; } }");
                    writer.WriteLine("\t\t public static uint Signature { get { return " + _session.globalScope.signature.ToString() + "; } }");
                    writer.WriteLine("\t\t public static string Contents { get { return @\"" + Contents + ")\"; } }");
                    writer.WriteLine("\t\t public static string Created { get { return \"" + DateTime.Now.ToString("dd-MM-yyyyTHH:mm:ss") + "\"; } }");
                    writer.WriteLine("\t}");
                    writer.WriteLine("\t#endregion");
                }
                /// now write out all the structures
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    foreach (string line in _bodyList)
                        writer.WriteLine(line);
                }
                /// and finally write the closing tags
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    writer.WriteLine("}");
                }
                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while processing structures..");
                _errorList.Add(ex.Message);
                return false;
            }

        }
    }
}
