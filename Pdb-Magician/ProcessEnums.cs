using Dia2Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
// force github commit

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private bool ExportEnums()
        {
            try
            {
                string outputFile = Path.Combine(_destinationFolder, "PdbEnums.cs");
                _enumEnums.Reset();
                _enumList.Clear();
                //List<string> done = new List<string>();

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("");
                    writer.WriteLine("namespace LiveForensics.Symbols");
                    writer.WriteLine("{");
                    foreach (IDiaSymbol sym in _enumEnums)
                    {
                        Enumerator enumerator = new Enumerator();
                        enumerator.name = sym.name;
                        enumerator.id = sym.symIndexId;
                        IDiaEnumSymbols children;
                        sym.findChildren(SymTagEnum.SymTagNull, null, 0, out children);
                        enumerator.values = new SubEnumerator[children.count];
                        int j = 0;
                        if (enumerator.name.Contains("-"))
                        {
                            if (enumerator.name.StartsWith("<unnamed"))
                            {
                                enumerator.name = enumerator.name.Replace("tag", enumerator.id.ToString());
                                enumerator.name = enumerator.name.ToUpper().Replace("-", "_").Replace("<", "_").Replace(">", "");
                            }
                            else
                            {
                                enumerator.name = enumerator.name.Replace("-", "_");
                            }

                        }
                        if (_enumList.Contains(enumerator.name))
                            continue;
                        _enumList.Add(enumerator.name);
                        writer.WriteLine("\tpublic enum " + enumerator.name);
                        writer.WriteLine("\t{");
                        foreach (IDiaSymbol c in children)
                        {
                            enumerator.values[j] = new SubEnumerator();
                            enumerator.values[j].value = c.value;
                            enumerator.values[j].name = c.name;
                            enumerator.values[j].id = c.symIndexId;
                            j++;
                            if (j == children.count)
                                writer.WriteLine("\t\t" + c.name + " = " + c.value);
                            else
                                writer.WriteLine("\t\t" + c.name + " = " + c.value + ",");
                        }
                        writer.WriteLine("\t}");
                    }
                    writer.WriteLine("}");
                }
                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while processing enums..");
                _errorList.Add(ex.Message);
                return false;
            }
        }
    }
}
