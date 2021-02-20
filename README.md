# Pdb-Magician
Parse PDB Files and generates C# class library which helps with interpreting memory images.

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


See the TestHarness project for a working implementation of the above.

The essential thing you should know is that you have to provide the ParseSymbolFile function with a list
of the structures you want to extract from the Symbol file. The parser will work out the dependencies 
and automatically include additional functions that are referenced.

So for example you could just ask the parser to extract "_EPROCESS" and it will do just that with its dependancies.

The parser always extracts all the constants and enums.

If all went well you should see MxSymbols.cs, PbdConstants.cs, PdbEnums.cs and PdbStructures.cs in your
specified output folder along with the LiveForensics.Symbols.dll library.

## Building The Library

I've already built the library for you, but if you want to do it yourself, you can copy the 4 .cs files into the LiveForensics.Symbols
project, overwriting the originals and build it from there.

This is useful when the conversion hasn't quite worked and you may need to fix some of the .cs files.

## Using The Class Library

I find it most useful to be able to load the appropriate version of the class library at runtime.

```CS
    Assembly _profileDll = Assembly.LoadFile(dllLocation);
```

### Structures

To access one of the structures, I do this. Notice I'm passing in a buffer containing the data I want to interpret as the structure.

```CS
    public dynamic GetStructure(string name, byte[] buffer, int offset)
    {
        try
        {
            string target = "LiveForensics.Symbols." + name;
            if (buffer == null)
                return null;
            if (offset > buffer.Length)
                return null;
            foreach (Type type in _profileDll.GetExportedTypes())
            {
                if (type.FullName == target)
                {
                    dynamic c = Activator.CreateInstance(type, buffer, offset);
                    int size = c.MxStructureSize;
                    if ((buffer.Length - offset) < size)
                        return null;
                    return c;
                }
            }
            return null;
        }
        catch
        {
            return null;
        }
    }
```
and call it like this:

```CS
    dynamic _dynamicObject = GetStructure("_EPROCESS", buffer, 0);
```

You can now access the (in this case) _EPROCESS members directly from the _dynamicObject, but I like to wrap them to take account of the fact that 
the member you call in your code might not exist:

```CS
    public uint Pid
    {
        get
        {
            try
            {
                return (uint)_dynamicObject.UniqueProcessId;
            }
            catch (Exception)
            {
                throw new ArgumentException("Couldn't extract UniqueProcessId from current EPROCESS structure.");
            }
        }
    }
```

### Catalogue

The CatalogueInformation class contains some useful information:

```CS
    dynamic _catalogueHelper = null;

    private void InitialiseCatalogue()
    {
        foreach (Type type in _profileDll.GetExportedTypes())
        {
            if (type.FullName == @"LiveForensics.Symbols.CatalogueInformation")
            {
                _catalogueHelper = Activator.CreateInstance(type);
                return;
            }
        }
    }
```

Use it like this:

```CS
    public Guid Guid
    {
        get
        {
            if (_catalogueHelper == null)
                return Guid.Empty;
            return _catalogueHelper.Guid;
        }
    }
```

### Constants

You can access the constants like this:

```CS
    dynamic _constantHelper = null;
    private void InitialiseConstants()
    {
        foreach (Type type in _profileDll.GetExportedTypes())
        {
            if (type.FullName == @"LiveForensics.Symbols.MxSymbols")
            {
                _constantHelper = Activator.CreateInstance(type);
                return;
            }
        }
    }
    public uint GetConstant(string name)
    {
        if (_constantHelper == null)
            throw new ArgumentException("Profile couldn't load constants.");
        uint constant;
        string testName = name;
        try
        {
            constant = _constantHelper.LookupConstant(name);
        }
        catch (Exception)
        {
            try
            {
                if (name.StartsWith("_"))
                    testName = name.TrimStart(new char[] { '_' });
                else
                    testName = "_" + name;
                constant = _constantHelper.LookupConstant(testName);
            }
            catch (Exception)
            {
                throw new ArgumentException("Profile couldn't find constant: " + name);
            }
                
        }
        return constant;
    }
```
In this example, I've included a trick to try both the original requested name and if that fails
to also try the leading underscore version as well, which was common on older images.

### Manifests

Each structure function contains a manifest member which will return a JSON string detailing the structure's 
structure in a similar way to the rekall profiles.

Note that I pretty printed the manifest in the PdbStructure.cs file, so I need to clean up the string before converting
it to a JSON object.

Also, it doesn't matter what's in the buffer, since we're only interested in the manifest. But the buffer needs to be real and at 
least as big as the structure you're targetting. (I just use an empty 4096 byte buffer).

```CS
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    private Dictionary<string, JToken> GetDictionary(string structure)
    {
        try
        {
            dynamic st = GetStructure(structure, _dummyBuffer, 0);
            string manifest = st.manifest;
            manifest = manifest.Replace("\r", "");
            manifest = manifest.Replace("\t", "");
            manifest = manifest.Replace("\n", "");
            manifest = manifest.Replace("(", "");
            manifest = manifest.Replace(")", "");

            object parsedObject = JsonConvert.DeserializeObject(manifest);
            var dict = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(parsedObject.ToString());
            return dict;
        }
        catch
        {
            return null;
        }
    }
```

## Warning, I've done limited testing which seems to work, but I can't possibly have covered all the possibilites, so I won't claim it'll work everytime.
