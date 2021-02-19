using System.Collections.Generic;
// force github commit

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private string _filename;
        private string _guidAge;
        private string _symbolServer;
        private string _cacheFolder;
        private string _destinationFolder;
        private string _pdbFile;
        private List<string> _todoList = new List<string>();

        private const string _userAgent = @"Microsoft-Symbol-Server/10.0.10522.521";
        private List<string> _errorList = new List<string>();

        public bool RetrieveSymbolFile(string filename, string guidAge, string cacheFolder, string server = "http://msdl.microsoft.com/download/symbols")
        {
            _filename = filename;
            _guidAge = guidAge.ToUpper();
            _symbolServer = server;
            _cacheFolder = cacheFolder;

            return FetchSymbolFile();
        }
        public bool ParseSymbolFile(string pdbName, string destinationFolder, string[] todoList)
        {
            _pdbFile = pdbName;
            if (todoList == null || todoList.Length == 0)
            {
                _errorList.Add("You didn't specify any structures to process.");
                return false;
            }
            _todoList.Clear();
            _todoSymbolList.Clear();
            _doneList.Clear();
            _accessBlock.Clear();
            _bodyList.Clear();            
            foreach (string item in todoList)
                _todoList.Add(item);

            _destinationFolder = destinationFolder;
            return ProcessSymbolFile();
        }
        public bool ParseAllSymbols(string pdbName, string destinationFolder)
        {
            _pdbFile = pdbName;
            _doneList.Clear();
            _accessBlock.Clear();
            _bodyList.Clear();
            _todoList = null;
            _destinationFolder = destinationFolder;
            return ProcessSymbolFile();
        }
        public string[] GetErrorList()
        {
            return _errorList.ToArray();
        }
    }
}
