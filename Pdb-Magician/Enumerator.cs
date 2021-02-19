using Dia2Lib;
// force github commit

namespace Pdb_Magician
{
    class Enumerator
    {
        public IDiaSymbol symbol;

        public uint baseType;
        public IDiaSymbol classParent;
        public uint classParentId;
        public bool constructor;
        public bool constType;
        public bool hasAssignmentOperator;
        public bool hasCastOperator;
        public bool hasNestedTypes;
        public ulong length;
        public IDiaSymbol lexicalParent;
        public uint lexicalParentId;
        public string name;
        public bool nested;
        public bool overloadedOperator;
        public bool packed;
        public bool scoped;
        public uint symIndexId;
        public uint symTag;
        public IDiaSymbol type;
        public uint typeId;
        public bool unalignedType;
        public bool volatileType;

        public Enumerator(IDiaSymbol sym)
        {
            symbol = sym;

            baseType = sym.baseType;
            classParent = sym.classParent;
            classParentId = sym.classParentId;
            constructor = sym.constructor != 0;
            constType = sym.constType != 0;
            hasAssignmentOperator = sym.hasAssignmentOperator != 0;
            hasCastOperator = sym.hasCastOperator != 0;
            hasNestedTypes = sym.hasNestedTypes != 0;
            length = sym.length;
            lexicalParent = sym.lexicalParent;
            lexicalParentId = sym.lexicalParentId;
            name = sym.name;
            nested = sym.nested != 0;
            overloadedOperator = sym.overloadedOperator != 0;
            packed = sym.packed != 0;
            scoped = sym.scoped != 0;
            symIndexId = sym.symIndexId;
            symTag = sym.symTag;
            type = sym.type;
            typeId = sym.typeId;
            unalignedType = sym.unalignedType != 0;
            volatileType = sym.volatileType != 0;
        }
    }
}
