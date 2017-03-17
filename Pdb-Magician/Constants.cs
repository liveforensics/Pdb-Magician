using Dia2Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private bool ExportConstants()
        {
            try
            {
                string outputFile = Path.Combine(_destinationFolder, "PdbConstants.cs");
                _enumPublicSymbols.Reset();
                Dictionary<string, uint> Entries = new Dictionary<string, uint>();
                foreach (IDiaSymbol sym in _enumPublicSymbols)
                {
                    PublicSymbol ps = new PublicSymbol(sym);
                    if (ps.name.StartsWith("?"))
                        continue;
                    if (ps.name.StartsWith("$$"))
                        continue;
                    if (ps.name.Contains("@"))
                        continue;
                    Entries.Add(ps.undecoratedName, ps.relativeVirtualAddress);
                }
                var list = Entries.Keys.ToList();
                list.Sort();
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("using System.Collections.Generic;");
                    writer.WriteLine("");
                    writer.WriteLine("namespace MemoryExplorer.Symbols");
                    writer.WriteLine("{");
                    writer.WriteLine("\tpublic class MxConstants");
                    writer.WriteLine("\t{");
                    writer.WriteLine("\t\tprivate Dictionary<string, uint> _lookup = new Dictionary<string, uint>();");

                    writer.WriteLine("\t\tpublic uint? Lookup(string key)");
                    writer.WriteLine("\t\t{");
                    writer.WriteLine("\t\t\tif(_lookup.ContainsKey(key))");
                    writer.WriteLine("\t\t\t\treturn _lookup[key];");
                    writer.WriteLine("\t\t\treturn null;");
                    writer.WriteLine("\t\t}");

                    writer.WriteLine("\t\tpublic MxConstants()");
                    writer.WriteLine("\t\t{");
                    foreach (var key in list)
                    {
                        writer.WriteLine("\t\t\t_lookup.Add(\"" + key + "\", " + Entries[key] + ");");
                    }
                    writer.WriteLine("\t\t}");
                    writer.WriteLine("\t}");
                    writer.WriteLine("}");
                }
                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while processing constants (Public Symbols)..");
                _errorList.Add(ex.Message);
                return false;
            }
        }
    }
}
