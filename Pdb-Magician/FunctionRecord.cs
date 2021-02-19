using Dia2Lib;
using System;
using System.Diagnostics;

namespace Pdb_Magician
{
    class FunctionRecord
    {
        public int offset;
        public string access;
        public string type;
        public string name;
        public int length;
        public int startBit;
        public int endBit;
        public string alias;
        public string structureType;
        public string symbolType;
        public string friendlySymbolType;
        public bool isPointer;
        public bool isBitField = false;
        public bool isArray = false;
        public bool isEnum = false;
        public bool isBuiltinType = false;
        public bool isMultiDimensionalArray = false;
        private int _pointerSize;
        public UInt64 bitMask;
        public string arrayType;
        public int arrayCount;
        public int arraySize;
        public int innerArraySize;
        public int enumLength;
        public string targetArg = "";
        public string enumName = "";
        public string enumTarget = "";
        public SymbolKind arrayTarget;

        public FunctionRecord(Symbol child, Members member, Symbol grandChild, int pointerSize)
        {
            if (child.Name == "LargePages")
                Debug.WriteLine("");

            _pointerSize = pointerSize;
            symbolType = GetSymbolType(grandChild.RootSymbol);
            friendlySymbolType = GetUsefulSymbolType(symbolType);
            Symbol greatGrandChild = grandChild.InspectType();
            isPointer = symbolType.EndsWith("*");
            isEnum = (grandChild.Kind == SymbolKind.Enum);
            isBuiltinType = TestType(friendlySymbolType);
            offset = member.offset;
            access = SymbolWrapper.rgAccess[(int)member.access];
            name = child.Name;
            length = (int)grandChild.Length;
            alias = "alias_" + (member.offset).ToString();
            isBitField = ((LocationType)member.locationType == LocationType.LocIsBitField);
            if(isBitField)
            {
                startBit = (int)member.bitPosition;
                endBit = (int)(member.bitPosition + member.length);
                bitMask = GetMask(startBit, endBit);
                type = "BitField";
            }
            else if(isEnum)
            {
                enumTarget = GetEnumType(grandChild);
                enumName = grandChild.Name;
                if(enumName.StartsWith("<unnamed"))
                {
                    enumName = enumName.ToUpper().Replace("-", "_").Replace("<", "_").Replace(">", "");
                    friendlySymbolType = enumName;
                }
                type = "Enumeration";
            }
            else if (friendlySymbolType != null && friendlySymbolType.EndsWith("]"))
            {
                string[] parts = friendlySymbolType.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                if(parts.Length == 2)
                {
                    try
                    {
                        arrayType = parts[0];
                        arrayCount = int.Parse(parts[1]);
                        structureType = arrayType + "[]";
                        isArray = true;
                        isBuiltinType = TestType(arrayType);
                        arrayTarget = (SymbolKind)greatGrandChild.Kind;
                        enumLength = (int)greatGrandChild.Length;
                        enumName = greatGrandChild.Name;
                        enumTarget = GetEnumType(greatGrandChild);
                    }
                    catch { }
                }
                else if(parts.Length == 3)
                {
                    try
                    {
                        isMultiDimensionalArray = true;
                        isArray = true;
                        arraySize = (int)grandChild.Length;
                        arrayType = parts[0];
                        arrayCount = int.Parse(parts[1]);
                        int s = int.Parse(parts[2]);
                        enumLength = arrayCount * s; // just using enumLength for convenience
                        friendlySymbolType = arrayType + "[" + enumLength + "]";
                        structureType = arrayType + "[]";
                        isBuiltinType = TestType(arrayType);
                        arrayTarget = (SymbolKind)greatGrandChild.Kind;
                    }
                    catch { }
                }
                else if(parts.Length == 4) // I can't keep doing this. Need to rewrite to handle any number of dimensions.
                {
                    try
                    {
                        isMultiDimensionalArray = true;
                        arraySize = (int)grandChild.Length;
                        innerArraySize = (int)greatGrandChild.Length;
                        arrayType = parts[0];
                        arrayCount = int.Parse(parts[1]);
                        int s = int.Parse(parts[2]);
                        int t = int.Parse(parts[3]);
                        enumLength = arrayCount * s * t; // just using enumLength for convenience
                        friendlySymbolType = arrayType + "[" + enumLength + "]";
                        structureType = arrayType + "[]";
                        isBuiltinType = TestType(arrayType);
                        arrayTarget = (SymbolKind)greatGrandChild.Kind;
                        isArray = true;
                    }
                    catch { }
                }
            }
        }
        private bool TestType(string arrayType)
        {
            if (arrayType == "Byte" || arrayType == "UInt16" || arrayType == "UInt32" || arrayType == "UInt64")
                return true;
            if (arrayType == "Int16" || arrayType == "Int32" || arrayType == "Int64")
                return true;
            if (arrayType == "float" || arrayType == "Double" || arrayType == "Char")
                return true;

            return false;
        }
        private UInt64 GetMask(int start, int end)
        {
            int counter = 1;
            UInt64 value = 0;
            for (int i = 0; i < end; i++)
            {
                if (i == start)
                {
                    value += (uint)counter;
                    start++;
                }
                counter *= 2;
            }
            return value;
        }
        private string GetEnumType(Symbol symbol)
        {
            switch (symbol.Length)
            {
                case 1:
                    return "Byte";
                case 2:
                    return "UInt16";
                case 4:
                    return "UInt32";
                case 8:
                    return "UInt64";
            }
            return "unknown";
        }
        private string GetSymbolType(IDiaSymbol symbol)
        {
            string answer = "";
            var checkme = (SymTagEnum)symbol.symTag;
            switch ((SymTagEnum)symbol.symTag)
            {
                case SymTagEnum.SymTagPointerType:
                    PointerType pointer = new PointerType(symbol);
                    answer += GetSymbolType(pointer.type);
                    answer += pointer.reference ? "&" : "*";
                    break;
                case SymTagEnum.SymTagBaseType:
                    BaseType baseType = new BaseType(symbol);
                    switch (baseType.baseType)
                    {
                        case (int)BasicType.btUInt:
                            switch (baseType.length)
                            {
                                case 1: answer += "Byte"; break;
                                case 2: answer += "UInt16"; break;
                                case 4: answer += "UInt32"; break;
                                case 8: answer += "UInt64"; break;
                            }
                            break;
                        case (int)BasicType.btInt:
                            switch (baseType.length)
                            {
                                case 1: answer += "Byte"; break;
                                case 2: answer += "Int16"; break;
                                case 4: answer += "Int32"; break;
                                case 8: answer += "Int64"; break;
                            }
                            break;
                        case (int)BasicType.btFloat:
                            switch (baseType.length)
                            {
                                case 4: answer += "float"; break;
                                case 8: answer += "Double"; break;
                            }
                            break;
                        default:
                            answer += SymbolWrapper.rgBaseType[baseType.baseType];
                            break;
                    }
                    break;
                case SymTagEnum.SymTagUDT:
                    Structure utd = new Structure(symbol);
                    if (utd.name.StartsWith("<unnamed-"))
                        utd.name = "_UNNAMED_" + utd.symIndexId.ToString();
                    answer += utd.name;
                    break;
                case SymTagEnum.SymTagFunctionType:
                    answer += "void";
                    break;
                case SymTagEnum.SymTagFunctionArgType:
                    FunctionArgType arg = new FunctionArgType(symbol);
                    answer += GetSymbolType(arg.type);
                    break;
                case SymTagEnum.SymTagArrayType:
                    ArrayType array = new ArrayType(symbol);                    
                    answer += GetSymbolType(array.type);
                    answer += "[" + array.count + "]";
                    break;
                case SymTagEnum.SymTagEnum:
                    Enumerator e = new Enumerator(symbol);
                    answer += e.name;
                    break;
                default:
                    Debug.WriteLine("PROCESSING ERROR: GetSymbol Type didn't handle " + symbol.name);
                    break;
            }

            return answer;
        }
        private string GetUsefulSymbolType(string st)
        {
            string pointer = _pointerSize == 4 ? "UInt32" : "UInt64";
            if (st.EndsWith("*"))
            {
                return pointer;
            }
            
            if (st.EndsWith("]"))
            {
                if(st.Contains("*["))
                {
                    int index = st.IndexOf('*');
                    targetArg = st.Substring(0, index+1);
                    return st.Replace(targetArg, pointer);
                }
                if (st.StartsWith("unsigned long"))
                    return st.Replace("unsigned long", "UInt32");
                if (st.StartsWith("unsigned long long"))
                    return st.Replace("unsigned long long", "UInt64");
                if (st.StartsWith("long"))
                    return st.Replace("long", "Int32");
                if (st.StartsWith("char"))
                    return st.Replace("char", "Char");
                if (st.StartsWith("wchar_t"))
                    return st.Replace("wchar_t", "UInt16");
                if (st.StartsWith("long long"))
                    return st.Replace("long long", "Int64");
            }
            switch (st)
            {
                case "unsigned long":
                    return "UInt32";
                case "long":
                    return "Int32";
                case "char":
                    return "Char";
                case "byte":
                    return "Byte";
                case "wchar_t":
                    return "UInt16";
                default:
                    return st;
            }
        }
    }
}
