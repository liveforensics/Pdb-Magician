using Dia2Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private long _fileLength;
        private IDiaSession _session;
        private IDiaEnumSymbols _enumUTDs;
        private IDiaEnumSymbols _enumPublicSymbols;
        private IDiaEnumSymbols _enumEnums;
        private int _pointerSize;
        private List<Symbol> _todoSymbolList = new List<Symbol>(); // I need this to process <unnamed-tag> blocks
        

        private bool ProcessSymbolFile()
        {
            if (!ParsePdbFile())
                return false;

            _pointerSize = GetPointerSize();
            if (_pointerSize == 0)
            {
                _errorList.Add("Could't find LIST_ENTRY to determine pointer size.");
                return false;
            }
            if (!ExportClassFile())
                return false;

            if (!ExportConstants())
                return false;

            if (!ExportEnums())
                return false;

            int overallCount = _todoList.Count + _todoSymbolList.Count;
            while (overallCount > 0)
            {
                if (_todoList.Count > 0)
                {
                    string next = _todoList[0];
                    _todoList.RemoveAt(0);
                    ProcessStructure(next);
                }
                if (_todoSymbolList.Count > 0)
                {
                    Symbol next = _todoSymbolList[0];
                    _todoSymbolList.RemoveAt(0);
                    ProcessSymbol(next);
                }
                overallCount = _todoList.Count + _todoSymbolList.Count;
            }
            if (!ExportStructures())
                return false;

            List<string> sourceFiles = new List<string>();
            sourceFiles.Add(Path.Combine(_destinationFolder, "MxSymbols.cs"));
            sourceFiles.Add(Path.Combine(_destinationFolder, "PdbConstants.cs"));
            sourceFiles.Add(Path.Combine(_destinationFolder, "PdbEnums.cs"));
            sourceFiles.Add(Path.Combine(_destinationFolder, "PdbStructures.cs"));

            LibraryBuilder builder = new LibraryBuilder(sourceFiles.ToArray(), _destinationFolder);
            bool result = builder.Build();
            if(!result)
            {
                string[] errors = builder.GetErrorList();
                foreach (string s in errors)
                    _errorList.Add(s);
                return false;
            }

            return true;
        }


        private int GetPointerSize()
        {
            _enumUTDs.Reset();
            foreach (IDiaSymbol sym in _enumUTDs)
            {
                if (sym.name == "_LIST_ENTRY")
                {
                    Symbol s = new Symbol(sym);
                    return (int)s.Length / 2;
                }
            }
            // since it isn't possible for a pointer size to be zero, this indicates a failure
            return 0;
        }
        private bool ParsePdbFile()
        {
            FileInfo fi = new FileInfo(_pdbFile);
            if (!fi.Exists)
            {
                _errorList.Add("The PDB file doesn't exist: " + _pdbFile);
                return false;
            }
            _fileLength = fi.Length;
            DiaSource source = new DiaSource();
            source.loadDataFromPdb(_pdbFile);
            source.openSession(out _session);
            _session.globalScope.findChildren(SymTagEnum.SymTagUDT, null, 0, out _enumUTDs);
            _session.globalScope.findChildren(SymTagEnum.SymTagPublicSymbol, null, 0, out _enumPublicSymbols);
            _session.globalScope.findChildren(SymTagEnum.SymTagEnum, null, 0, out _enumEnums);

            return true;
        }
    }
}
