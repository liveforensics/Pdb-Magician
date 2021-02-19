using Dia2Lib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
