using Dia2Lib;

// force github commit

namespace Pdb_Magician
{
    class ArrayType
    {
        public IDiaSymbol symbol;

        public IDiaSymbol arrayIndexType;
        public uint arrayIndexTypeId;
        public bool constType;
        public uint count;
        public ulong length;
        public IDiaSymbol lexicalParent;
        public uint lexicalParentId;
        public uint rank;
        public uint symIndexId;
        public uint symTag;
        public IDiaSymbol type;
        public uint typeId;
        public bool unalignedType;
        public bool volatileType;

        public ArrayType(IDiaSymbol sym)
        {
            symbol = sym;

            arrayIndexType = sym.arrayIndexType;
            arrayIndexTypeId = sym.arrayIndexTypeId;
            constType = sym.constType != 0;
            count = sym.count;
            length = sym.length;
            lexicalParent = sym.lexicalParent;
            lexicalParentId = sym.lexicalParentId;
            rank = sym.rank;
            symIndexId = sym.symIndexId;
            symTag = sym.symTag;
            type = sym.type;
            typeId = sym.typeId;
            unalignedType = sym.unalignedType != 0;
            volatileType = sym.volatileType != 0;
        }
    }
}
