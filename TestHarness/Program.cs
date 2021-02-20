using Newtonsoft.Json.Linq;
using Pdb_Magician;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestHarness
{
    /// <summary>
    /// For my testing, I've used some rekall profiles (github rekall-profile)
    /// Unzip the file and rename the output to .json extension.
    /// Put it in the same folder as your pdb file.
    /// The test harness parses out the structure names and feeds them to magician.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //string guidAge = "0F0B35EF85904B09A22E11C1DBEF83921";
            //string guidAge = "afcb4fd7b7a844acaa1a4154cc1091871";
            //string guidAge = "3D4400784115718818EFC898413F36C41";
            //string guidAge = "5278AFF86C341677D7D7835C85B7B8441";
            string guidAge = "864170751E2F4E98A60091F60CA538D11";
            string filename = "ntkrnlmp.pdb";
            //string filename = "ntoskrnl.pdb";
            //12 / 02 / 2021 16:49:30 - RSDS Filename ntoskrnl.pdb GuidAge 864170751E2F4E98A60091F60CA538D11



            // start by retrieving the Symbol file (PDB)
            PdbMagician myLib = new PdbMagician();
            bool result = myLib.RetrieveSymbolFile(filename, guidAge, @"c:\temp\magician");
            if (!result)
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
            string pdbLocation = Path.Combine(@"c:\temp\magician", guidAge, filename);
            //result = myLib.ParseAllSymbols(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge));
            //if (!result)
            //{
            //    Console.WriteLine("One or more errors occurred..");
            //    string[] errors = myLib.GetErrorList();
            //    foreach (string s in errors)
            //        Console.WriteLine(s);
            //}
            //else
            //    Console.WriteLine("Successfully Built: ");

            // selected symbols option
            List<string> todoList = new List<string>();
            todoList.Add("_MI_FREE_LARGE_PAGES");
            //todoList.Add("_EPROCESS");
            //todoList.Add("_LIST_ENTRY");
            result = myLib.ParseSymbolFile(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge), todoList.ToArray());
            //result = myLib.ParseAllSymbols(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge));
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
