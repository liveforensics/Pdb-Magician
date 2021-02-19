using Dia2Lib;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
// force github commit

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private bool ProcessStructure(string structureName)
        {
            List<string> accessBlock = new List<string>();
            List<string> variablesBlock = new List<string>();
            List<FunctionRecord> entries = new List<FunctionRecord>();
            JArray manifest = new JArray();

            _enumUTDs.Reset();
            foreach (IDiaSymbol sym in _enumUTDs)
            {
                if (sym.name == structureName)
                {
                    Symbol s = new Symbol(sym);
                    return ProcessSymbol(s);
                }
            }
            return false;
        }
        private bool ProcessAllStructures()
        {
            int count = 0;
            List<string> accessBlock = new List<string>();
            List<string> variablesBlock = new List<string>();
            List<FunctionRecord> entries = new List<FunctionRecord>();
            JArray manifest = new JArray();
            _todoList = new List<string>();
            _enumUTDs.Reset();
            foreach (IDiaSymbol sym in _enumUTDs)
            {                
                Symbol s = new Symbol(sym);
                if (s.Name == "<anonymous-tag>")
                    count++;
                ProcessSymbol(s);                
            }
            return true;
        }
    }
}
