# Pdb-Magician
Parse PDB Files and generates C# class library which helps with interpreting memory images.

This is research code, so it's a bit hacky but it seems to work.

In support of the memory forensics work I'm doing, I wanted to be able to grab the appropriate PDB file
from the Microsoft Symbol Server based on the GUIDAGE of the kernel file.

Next, I parse the file using the SIA SDK and produce a C# class library that allows me
to pass in a byte buffer from the memory image and to interpret the data as strongly typed
member variables for each given structure.

I've also parsed out the Public Symbols which include the constants and the function addresses, 
plus I've parsed the enums.

There are essentially 3 functions

* RetrieveSymbolFile
* ParseSymbolFile
* ParseAllSymbols

RetrieveSymbolFile takes the pdb filename and the guid age and will retrieve the PDB symbol file from the Microsoft Symbol Server.

```CS
	string guidAge = "AA6BC31F61F7415F8C06994099933BBD1";
    string filename = "ntkrnlmp.pdb";

    PdbMagician myLib = new PdbMagician();
    bool result = myLib.RetrieveSymbolFile(filename, guidAge, @"c:\temp\magician");
```

ParseSymbolFile will then turn that PDB Symbol file into a C# class library containing structures that you've selected.

```CS
    string pdbLocation = Path.Combine(Path.Combine(@"c:\temp\magician", guidAge), filename);
    List<string> todoList = new List<string>();
    todoList.Add("_OBJECT_DIRECTORY");
    todoList.Add("_EPROCESS");
    todoList.Add("_LIST_ENTRY");
    result = myLib.ParseSymbolFile(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge), todoList.ToArray());
```

ParseAllSymbols just converts all the structures it can find.

```CS
    string pdbLocation = Path.Combine(Path.Combine(@"c:\temp\magician", guidAge), filename);
    result = myLib.ParseAllSymbols(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge));
```


Use the test harness to see how to call the library.

The essential thing you should know is that you have to provide the ParseSymbolFile function with a list
of the structures you want to extract from the Symbol file. The parser will work out the dependencies 
and automatically include additional functions that are referenced.

So for example you could just ask the parser to extract "_EPROCESS" and it will do just that with its dependancies.

The parser always extracts all the constants and enums.

If all went well you should see PbdConstants.cs, PdbEnums.cs and PdbStructures.cs in your
specified output folder along with the LiveForensics.Symbols.dll library.


## The Class Library

Start with the CatalogueInformation class, it contains some useful information including Contents
which will return a JSON string with a list of all the structures captured in the class library.

You can then access each structure by passing in a byte buffer containing the data and accessing
the structure members via the types.

Each structure function contains a manifest member which will return a JSON string detailing the structure's 
structure in a similar way to the rekall profiles.

## Warning, I've done limited testing which seems to work, but I can't possibly have covered all the possibilites, so I won't claim it'll work everytime.
