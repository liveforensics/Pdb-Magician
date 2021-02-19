using Dia2Lib;
// force github commit

namespace Pdb_Magician
{
    class BaseType
    {
        public IDiaSymbol symbol;

        public uint baseType;
        public bool constType;
        public ulong length;
        public IDiaSymbol lexicalParent;
        public uint lexicalParentId;
        public uint symIndexId;
        public uint symTag;
        public bool unalignedType;
        public bool volatileType;

        public BaseType(IDiaSymbol sym)
        {
            symbol = sym;

            baseType = sym.baseType;
            constType = sym.constType != 0;
            length = sym.length;
            lexicalParent = sym.lexicalParent;
            lexicalParentId = sym.lexicalParentId;
            symIndexId = sym.symIndexId;
            symTag = sym.symTag;
            unalignedType = sym.unalignedType != 0;
            volatileType = sym.volatileType != 0;
        }
    }
}
