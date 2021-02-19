using Dia2Lib;
// force github commit

namespace Pdb_Magician
{
    class PointerType
    {
        public IDiaSymbol symbol;

        public bool constType;
        public ulong length;
        public IDiaSymbol lexicalParent;
        public uint lexicalParentId;
        public bool reference;
        public uint symIndexId;
        public uint symTag;
        public IDiaSymbol type;
        public uint typeId;
        public bool unalignedType;
        public bool volatileType;

        public PointerType(IDiaSymbol sym)
        {
            symbol = sym;

            constType = sym.constType != 0;
            length = sym.length;
            lexicalParent = sym.lexicalParent;
            lexicalParentId = sym.lexicalParentId;
            reference = sym.reference != 0;
            symIndexId = sym.symIndexId;
            symTag = sym.symTag;
            type = sym.type;
            typeId = sym.typeId;
            unalignedType = sym.unalignedType != 0;
            volatileType = sym.volatileType != 0;
        }
    }
}
