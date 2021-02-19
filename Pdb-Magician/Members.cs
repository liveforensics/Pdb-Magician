using Dia2Lib;
// force github commit

namespace Pdb_Magician
{
    public class Members
    {
        private Symbol _symbol;

        public CV_access_e access;
        public uint addressOffset;
        public uint addressSection;
        public bool addressTaken;
        public uint bitPosition;
        public IDiaSymbol classParent;
        public uint classParentId;
        public bool compilerGenerated;
        public bool constType;
        public uint dataKind;
        public bool isAggregated;
        public bool isSplitted;
        public ulong length;
        public IDiaSymbol lexicalParent;
        public uint lexicalParentId;
        public uint locationType;
        public string name;
        public int offset;
        public uint registerId;
        public uint relativeVirtualAddress;
        public uint slot;
        public uint symIndexId;
        public uint symTag;
        public uint token;
        public IDiaSymbol type;
        public uint typeId;
        public bool unalignedType;
        public dynamic value;
        public ulong virtualAddress;
        public bool volatileType;

        public Members(Symbol symbol)
        {
            _symbol = symbol;
            IDiaSymbol sym = symbol.RootSymbol;

            access = (CV_access_e)sym.access;
            addressOffset = sym.addressOffset;
            addressSection = sym.addressSection;
            addressTaken = sym.addressTaken != 0;
            bitPosition = sym.bitPosition;
            classParent = sym.classParent;
            classParentId = sym.classParentId;
            compilerGenerated = sym.compilerGenerated != 0;
            constType = sym.constType != 0;
            dataKind = sym.dataKind;
            isAggregated = sym.isAggregated != 0;
            isSplitted = sym.isSplitted != 0;
            length = sym.length;
            lexicalParent = sym.lexicalParent;
            lexicalParentId = sym.lexicalParentId;
            locationType = sym.locationType;
            name = sym.name;
            offset = sym.offset;
            registerId = sym.registerId;
            relativeVirtualAddress = sym.relativeVirtualAddress;
            slot = sym.slot;
            symIndexId = sym.symIndexId;
            symTag = sym.symTag;
            token = sym.token;
            type = sym.type;
            typeId = sym.typeId;
            unalignedType = sym.unalignedType != 0;
            value = sym.value;
            virtualAddress = sym.virtualAddress;
            volatileType = sym.volatileType != 0;

        }
    }
}
