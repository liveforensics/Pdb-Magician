using Pdb_Magician;
using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// First time you run this stuff, you probably need to register the DIA dll
/// regsvr32.exe "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\DIA SDK\bin\msdia140.dll"
/// </summary>


namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a GUIDAGE from my Windows 10 x64 box.          
            //string guidAge = "AA6BC31F61F7415F8C06994099933BBD1"; 93D178D59F755B803E7780CB3A795671
            string guidAge = "3A79567180CB3E77805B759FD578D1931";
            string filename = "ntkrnlmp.pdb";

            // start by retrieving the Symbol file (PDB)
            PdbMagician myLib = new PdbMagician();
            bool result = myLib.RetrieveSymbolFile(filename, guidAge, @"c:\temp\magician");
            if(!result)
            {
                Console.WriteLine("One or more errors occurred..");
                string[] errors = myLib.GetErrorList();
                foreach (string s in errors)
                    Console.WriteLine(s);
            }
            else
                Console.WriteLine("Got It!");

            // now you have 2 choices, process all the symbols or just the ones you need for your project
            //
            // ALL symbols option
            string pdbLocation = Path.Combine(Path.Combine(@"c:\temp\magician", guidAge), filename);
            result = myLib.ParseAllSymbols(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge));
            if (!result)
            {
                Console.WriteLine("One or more errors occurred..");
                string[] errors = myLib.GetErrorList();
                foreach (string s in errors)
                    Console.WriteLine(s);
            }
            else
                Console.WriteLine("Successfully Built: ");

            // selected symbols option
            List<string> todoList = new List<string>();
            todoList.Add("_OBJECT_DIRECTORY");
            todoList.Add("_EPROCESS");
            todoList.Add("_LIST_ENTRY");
            result = myLib.ParseSymbolFile(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge), todoList.ToArray());
            if (!result)
            {
                Console.WriteLine("One or more errors occurred..");
                string[] errors = myLib.GetErrorList();
                foreach (string s in errors)
                    Console.WriteLine(s);
            }
            else
                Console.WriteLine("Successfully Built: ");

        }
    }
}
