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
            string guidAge = "1453BDA99D224237ABDDB806A482DDF41";
            //string guidAge = "864170751E2F4E98A60091F60CA538D11";
            string filename = "ntkrnlmp.pdb";
            //string filename = "ntoskrnl.pdb";
            //12 / 02 / 2021 16:49:30 - RSDS Filename ntoskrnl.pdb GuidAge 864170751E2F4E98A60091F60CA538D11



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

            string pdbLocation = Path.Combine(Path.Combine(@"c:\temp\magician", guidAge), filename);
            List<string> todoList = new List<string>();

            FileInfo fi = new FileInfo(@"C:\temp\magician\" + guidAge + @"\" + guidAge + ".json");
            if (!fi.Exists)
                return;
            byte[] json = null;
            using (FileStream original = fi.OpenRead())
            {
                using (BinaryReader reader = new BinaryReader(original))
                {
                    json = reader.ReadBytes((int)fi.Length);
                }
            }
            List<string> testList = new List<string>();
            string theJson = Encoding.UTF8.GetString(json);
            var parsedJson = JObject.Parse(theJson);
            todoList.Clear();
            foreach (dynamic item in parsedJson["$STRUCTS"])
            {
                if (item.Name.StartsWith("<unnamed"))
                    continue;
                
                todoList.Add(item.Name);
            }
            result = myLib.ParseSymbolFile(pdbLocation, @"E:\Code\github\Pdb-Magician\MemoryExplorer.Symbols", todoList.ToArray());
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
