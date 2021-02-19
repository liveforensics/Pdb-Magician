using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
// force github commit

namespace Pdb_Magician
{
    class LibraryBuilder
    {
        private List<FileInfo> _sourceFiles = new List<FileInfo>();
        private string _destinationFolder;
        private List<string> _errorList = new List<string>();

        public LibraryBuilder(string[] sourceFiles, string destinationFolder)
        {
            foreach (string s in sourceFiles)
            {
                FileInfo fi = new FileInfo(s);
                if (!fi.Exists)
                    throw new ArgumentException("Source File " + fi.Name + " is missing.");
                _sourceFiles.Add(fi);
            }
            _destinationFolder = destinationFolder;
        }
        public string[] GetErrorList()
        {
            return _errorList.ToArray();
        }
        public bool Build()
        {
            try
            {
                CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
                if (provider != null)
                {
                    string dllName = Path.Combine(_destinationFolder, "LiveForensics.Symbols.dll");
                    CompilerParameters cp = new CompilerParameters();
                    // Generate a dll instead of an executable.
                    cp.GenerateExecutable = false;
                    // Specify the assembly file name to generate.
                    cp.OutputAssembly = dllName;
                    // Save the assembly as a physical file.
                    cp.GenerateInMemory = false;
                    // Set whether to treat all warnings as errors.
                    cp.TreatWarningsAsErrors = false;
                    // don't include debug information
                    cp.IncludeDebugInformation = false;

                    string info = CreateAssemblyInfoFile();

                    string[] sourceFiles = new string[_sourceFiles.Count + 1];
                    int i = 0;
                    foreach (FileInfo f in _sourceFiles)
                        sourceFiles[i++] = f.FullName;
                    sourceFiles[i] = info;

                    // Invoke compilation of the source file.
                    CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceFiles);
                    if (cr.Errors.Count > 0)
                    {
                        // Display compilation errors.
                        foreach (CompilerError ce in cr.Errors)
                        {
                            _errorList.Add(ce.ToString());
                        }
                        RemoveAssemblyFile();
                        return false;
                    }
                    else
                    {
                        RemoveAssemblyFile();
                        return true;
                    }
                }
                else
                {
                    _errorList.Add("Error: Couldn't find CSharp build provider.");
                    RemoveAssemblyFile();
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while building library..");
                _errorList.Add(ex.Message);
                RemoveAssemblyFile();
                return false;
            }
        }
        private string CreateAssemblyInfoFile()
        {
            string year = DateTime.Now.Year.ToString();
            string outputFile = Path.Combine(_destinationFolder, "AssemblyInfo.cs");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("using System.Reflection;");
                writer.WriteLine("using System.Runtime.InteropServices;");
                writer.WriteLine("[assembly: AssemblyTitle(\"PDB Symbol Translation Helper\")]");
                writer.WriteLine("[assembly: AssemblyDescription(\"PDB Symbol Translation Helper\")]");
                writer.WriteLine("[assembly: AssemblyCompany(\"LiveForensics\")]");
                writer.WriteLine("[assembly: AssemblyProduct(\"LiveForensics.Symbols\")]");
                writer.WriteLine("[assembly: AssemblyCopyright(\"Copyright ©LiveForensics " + year + "\")]");
                writer.WriteLine("[assembly: ComVisible(false)]");
                writer.WriteLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
                writer.WriteLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");
            }
            return outputFile;
        }
        private void RemoveAssemblyFile()
        {
            string outputFile = Path.Combine(_destinationFolder, "AssemblyInfo.cs");
            FileInfo fi = new FileInfo(outputFile);
            if (fi.Exists)
                fi.Delete();
        }
    }
}
