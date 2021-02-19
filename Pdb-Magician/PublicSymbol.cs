using Dia2Lib;
// force github commit

namespace Pdb_Magician
{
    class PublicSymbol
    {
        public IDiaSymbol symbol;

        public uint addressOffset;
        public uint addressSection;
        public bool code;
        public bool function;
        public ulong length;
        public IDiaSymbol lexicalParent;
        public uint lexicalParentId;
        public uint locationType;
        public bool managed;
        public bool msil;
        public string name;
        public uint symIndexId;
        public uint relativeVirtualAddress;
        public uint symTag;
        public string undecoratedName;
        public string undecoratedNameEx;

        public PublicSymbol(IDiaSymbol sym)
        {
            symbol = sym;

            addressOffset = sym.addressOffset;
            addressSection = sym.addressSection;
            code = sym.code != 0;
            function = sym.function != 0;
            length = sym.length;
            lexicalParent = sym.lexicalParent;
            lexicalParentId = sym.lexicalParentId;
            locationType = sym.locationType;
            managed = sym.managed != 0;
            msil = sym.msil != 0;
            name = sym.name;
            symIndexId = sym.symIndexId;
            relativeVirtualAddress = sym.relativeVirtualAddress;
            symTag = sym.symTag;
            undecoratedName = sym.undecoratedName;
            sym.get_undecoratedNameEx(0, out undecoratedNameEx);
        }
    }
}
