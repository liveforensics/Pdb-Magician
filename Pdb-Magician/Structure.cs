using Dia2Lib;
// force github commit

namespace Pdb_Magician
{
    class Structure
    {
        public IDiaSymbol symbol;

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
        public uint udtKind;
        public bool unalignedType;
        public IDiaSymbol virtualTableShape;
        public uint virtualTableShapeId;
        public bool volatileType;

        public Structure(IDiaSymbol sym)
        {
            symbol = sym;

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
            udtKind = sym.udtKind;
            unalignedType = sym.unalignedType != 0;
            virtualTableShape = sym.virtualTableShape;
            virtualTableShapeId = sym.virtualTableShapeId;
            volatileType = sym.volatileType != 0;
        }
    }
}
