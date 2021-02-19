using Dia2Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdb_Magician
{
    public class Symbol
    {
        private IDiaSymbol _symbol;
        internal Symbol(IDiaSymbol diaSymbol)
        {
            _symbol = diaSymbol;
        }


        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Name, this.Kind);
        }
        public IDiaSymbol RootSymbol { get { return _symbol; } }
        protected IDiaSymbol DiaSymbol
        {
            get { return _symbol; }
        }
        public Symbol InspectType()
        {
            IDiaSymbol test = _symbol.type;
            Symbol another = new Symbol(test);
            return another;
        }
        public ulong Length { get { return _symbol.length; } }
        /* DispID 0 */
        public uint ID { get { return this.DiaSymbol.symIndexId; } }
        /* DispID 1 */
        public SymbolKind Kind { get { return (SymbolKind)this.DiaSymbol.symTag; } }
        /* DispID 2 */
        public string Name
        {
            get
            {
                string testName = DiaSymbol.name;
                if (testName == "<unnamed-tag>")
                    testName = "<unnamed-" + ID.ToString() + ">";
                return testName;
            }
        }
        /* DispID 74 */
        public string UndecoratedName { get { return this.DiaSymbol.undecoratedName; } }

        /* DispID 19 */
        uint access { get { return this.DiaSymbol.access; } }
        /* DispID 78 */
        int addressTaken { get { return this.DiaSymbol.addressTaken; } }
        /* DispID 50 */
        IDiaSymbol arrayIndexType { get { return this.DiaSymbol.arrayIndexType; } }
        /* DispID 67 */
        uint arrayIndexTypeId { get { return this.DiaSymbol.arrayIndexTypeId; } }
        /* DispID 29 */
        uint backEndBuild { get { return this.DiaSymbol.backEndBuild; } }
        /* DispID 27 */
        uint backEndMajor { get { return this.DiaSymbol.backEndMajor; } }
        /* DispID 28 */
        uint backEndMinor { get { return this.DiaSymbol.backEndMinor; } }
        /* DispID 127 */
        uint backEndQFE { get { return this.DiaSymbol.backEndQFE; } }
        /* DispID 40 */
        uint baseType { get { return this.DiaSymbol.baseType; } }
        /* DispID 49 */
        uint bitPosition { get { return this.DiaSymbol.bitPosition; } }
        /* DispID 38 */
        uint callingConvention { get { return this.DiaSymbol.callingConvention; } }
        /* DispID 4 */
        IDiaSymbol classParent { get { return this.DiaSymbol.classParent; } }
        /* DispID 65 */
        uint classParentId { get { return this.DiaSymbol.classParentId; } }
        /* DispID 77 */
        int compilerGenerated { get { return this.DiaSymbol.compilerGenerated; } }
        /* DispID 105 */
        string compilerName { get { return this.DiaSymbol.compilerName; } }
        /* DispID 52 */
        int constructor { get { return this.DiaSymbol.constructor; } }
        /* DispID 17 */
        int constType { get { return this.DiaSymbol.constType; } }
        /* DispID 116 */
        IDiaSymbol container { get { return this.DiaSymbol.container; } }
        /* DispID 47 */
        uint count { get { return this.DiaSymbol.count; } }
        /* DispID 143 */
        uint countLiveRanges { get { return this.DiaSymbol.countLiveRanges; } }
        /* DispID 94 */
        int customCallingConvention { get { return this.DiaSymbol.customCallingConvention; } }
        /* DispID 6 */
        uint dataKind { get { return this.DiaSymbol.dataKind; } }
        /* DispID 99 */
        int farReturn { get { return this.DiaSymbol.farReturn; } }
        /* DispID 134 */
        int framePointerPresent { get { return this.DiaSymbol.framePointerPresent; } }
        /* DispID 26 */
        uint frontEndBuild { get { return this.DiaSymbol.frontEndBuild; } }
        /* DispID 24 */
        uint frontEndMajor { get { return this.DiaSymbol.frontEndMajor; } }
        /* DispID 25 */
        uint frontEndMinor { get { return this.DiaSymbol.frontEndMinor; } }
        /* DispID 126 */
        uint frontEndQFE { get { return this.DiaSymbol.frontEndQFE; } }
        /* DispID 106 */
        int hasAlloca { get { return this.DiaSymbol.hasAlloca; } }
        /* DispID 56 */
        int hasAssignmentOperator { get { return this.DiaSymbol.hasAssignmentOperator; } }
        /* DispID 57 */
        int hasCastOperator { get { return this.DiaSymbol.hasCastOperator; } }
        /* DispID 101 */
        int hasDebugInfo { get { return this.DiaSymbol.hasDebugInfo; } }
        /* DispID 110 */
        int hasEH { get { return this.DiaSymbol.hasEH; } }
        /* DispID 112 */
        int hasEHa { get { return this.DiaSymbol.hasEHa; } }
        /* DispID 109 */
        int hasInlAsm { get { return this.DiaSymbol.hasInlAsm; } }
        /* DispID 108 */
        int hasLongJump { get { return this.DiaSymbol.hasLongJump; } }
        /* DispID 120 */
        int hasManagedCode { get { return this.DiaSymbol.hasManagedCode; } }
        /* DispID 55 */
        int hasNestedTypes { get { return this.DiaSymbol.hasNestedTypes; } }
        /* DispID 104 */
        int hasSecurityChecks { get { return this.DiaSymbol.hasSecurityChecks; } }
        /* DispID 111 */
        int hasSEH { get { return this.DiaSymbol.hasSEH; } }
        /* DispID 107 */
        int hasSetJump { get { return this.DiaSymbol.hasSetJump; } }
        /* DispID 139 */
        int hfaDouble { get { return this.DiaSymbol.hfaDouble; } }
        /* DispID 138 */
        int hfaFloat { get { return this.DiaSymbol.hfaFloat; } }
        /* DispID 60 */
        int indirectVirtualBaseClass { get { return this.DiaSymbol.indirectVirtualBaseClass; } }
        /* DispID 117 */
        int inlSpec { get { return this.DiaSymbol.inlSpec; } }
        /* DispID 98 */
        int interruptReturn { get { return this.DiaSymbol.interruptReturn; } }
        /* DispID 136 */
        int intrinsic { get { return this.DiaSymbol.intrinsic; } }
        /* DispID 36 */
        int intro { get { return this.DiaSymbol.intro; } }
        /* DispID 114 */
        int isAggregated { get { return this.DiaSymbol.isAggregated; } }
        /* DispID 131 */
        int isConstructorVirtualBase { get { return this.DiaSymbol.isConstructorVirtualBase; } }
        /* DispID 122 */
        int isCVTCIL { get { return this.DiaSymbol.isCVTCIL; } }
        /* DispID 130 */
        int isCxxReturnUdt { get { return this.DiaSymbol.isCxxReturnUdt; } }
        /* DispID 103 */
        int isDataAligned { get { return this.DiaSymbol.isDataAligned; } }
        /* DispID 121 */
        int isHotpatchable { get { return this.DiaSymbol.isHotpatchable; } }
        /* DispID 102 */
        int isLTCG { get { return this.DiaSymbol.isLTCG; } }
        /* DispID 123 */
        int isMSILNetmodule { get { return this.DiaSymbol.isMSILNetmodule; } }
        /* DispID 113 */
        int isNaked { get { return this.DiaSymbol.isNaked; } }
        /* DispID 135 */
        int isSafeBuffers { get { return this.DiaSymbol.isSafeBuffers; } }
        /* DispID 115 */
        int isSplitted { get { return this.DiaSymbol.isSplitted; } }
        /* DispID 100 */
        int isStatic { get { return this.DiaSymbol.isStatic; } }
        /* DispID 22 */
        uint language { get { return this.DiaSymbol.language; } }
        /* DispID 144 */
        ulong liveRangeLength { get { return this.DiaSymbol.liveRangeLength; } }
        /* DispID 141 */
        uint liveRangeStartAddressOffset { get { return this.DiaSymbol.liveRangeStartAddressOffset; } }
        /* DispID 140 */
        uint liveRangeStartAddressSection { get { return this.DiaSymbol.liveRangeStartAddressSection; } }
        /* DispID 142 */
        uint liveRangeStartRelativeVirtualAddress { get { return this.DiaSymbol.liveRangeStartRelativeVirtualAddress; } }
        /* DispID 147 */
        uint localBasePointerRegisterId { get { return this.DiaSymbol.localBasePointerRegisterId; } }
        /* DispID 80 */
        IDiaSymbol lowerBound { get { return this.DiaSymbol.lowerBound; } }
        /* DispID 82 */
        uint lowerBoundId { get { return this.DiaSymbol.lowerBoundId; } }
        /* DispID 54 */
        int nested { get { return this.DiaSymbol.nested; } }
        /* DispID 95 */
        int noInline { get { return this.DiaSymbol.noInline; } }
        /* DispID 93 */
        int noReturn { get { return this.DiaSymbol.noReturn; } }
        /* DispID 118 */
        int noStackOrdering { get { return this.DiaSymbol.noStackOrdering; } }
        /* DispID 97 */
        int notReached { get { return this.DiaSymbol.notReached; } }
        /* DispID 91 */
        IDiaSymbol objectPointerType { get { return this.DiaSymbol.objectPointerType; } }
        /* DispID 89 */
        uint oemId { get { return this.DiaSymbol.oemId; } }
        /* DispID 90 */
        uint oemSymbolId { get { return this.DiaSymbol.oemSymbolId; } }
        /* DispID 13 */
        int offset { get { return this.DiaSymbol.offset; } }
        /* DispID 145 */
        uint offsetInUdt { get { return this.DiaSymbol.offsetInUdt; } }
        /* DispID 96 */
        int optimizedCodeDebugInfo { get { return this.DiaSymbol.optimizedCodeDebugInfo; } }
        /* DispID 53 */
        int overloadedOperator { get { return this.DiaSymbol.overloadedOperator; } }
        /* DispID 51 */
        int packed { get { return this.DiaSymbol.packed; } }
        /* DispID 146 */
        uint paramBasePointerRegisterId { get { return this.DiaSymbol.paramBasePointerRegisterId; } }
        /* DispID 21 */
        uint platform { get { return this.DiaSymbol.platform; } }
        /* DispID 37 */
        int pure { get { return this.DiaSymbol.pure; } }
        /* DispID 79 */
        uint rank { get { return this.DiaSymbol.rank; } }
        /* DispID 46 */
        int reference { get { return this.DiaSymbol.reference; } }
        /* DispID 12 */
        uint registerId { get { return this.DiaSymbol.registerId; } }
        /* DispID 132 */
        int RValueReference { get { return this.DiaSymbol.RValueReference; } }
        /* DispID 58 */
        int scoped { get { return this.DiaSymbol.scoped; } }
        /* DispID 137 */
        int @sealed { get { return this.DiaSymbol.@sealed; } }
        /* DispID 15 */
        uint slot { get { return this.DiaSymbol.slot; } }
        /* DispID 129 */
        int strictGSCheck { get { return this.DiaSymbol.strictGSCheck; } }
        /* DispID 85 */
        uint targetOffset { get { return this.DiaSymbol.targetOffset; } }
        /* DispID 86 */
        uint targetRelativeVirtualAddress { get { return this.DiaSymbol.targetRelativeVirtualAddress; } }
        /* DispID 84 */
        uint targetSection { get { return this.DiaSymbol.targetSection; } }
        /* DispID 87 */
        ulong targetVirtualAddress { get { return this.DiaSymbol.targetVirtualAddress; } }
        /* DispID 33 */
        int thisAdjust { get { return this.DiaSymbol.thisAdjust; } }
        /* DispID 32 */
        uint thunkOrdinal { get { return this.DiaSymbol.thunkOrdinal; } }
        /* DispID 42 */
        uint timeStamp { get { return this.DiaSymbol.timeStamp; } }
        /* DispID 41 */
        uint token { get { return this.DiaSymbol.token; } }
        /* DispID 5 */
        IDiaSymbol type { get { return this.DiaSymbol.type; } }
        /* DispID 66 */
        uint typeId { get { return this.DiaSymbol.typeId; } }
        /* DispID 92 */
        uint udtKind { get { return this.DiaSymbol.udtKind; } }
        /* DispID 18 */
        int unalignedType { get { return this.DiaSymbol.unalignedType; } }
        /* DispID 133 */
        IDiaSymbol unmodifiedType { get { return this.DiaSymbol.unmodifiedType; } }
        /* DispID 31 */
        string unused { get { return this.DiaSymbol.unused; } }
        /* DispID 81 */
        IDiaSymbol upperBound { get { return this.DiaSymbol.upperBound; } }
        /* DispID 83 */
        uint upperBoundId { get { return this.DiaSymbol.upperBoundId; } }
        /* DispID 39 */
        object value { get { return this.DiaSymbol.value; } }
        /* DispID 35 */
        int @virtual { get { return this.DiaSymbol.@virtual; } }
        /* DispID 11 */
        ulong virtualAddress { get { return this.DiaSymbol.virtualAddress; } }
        /* DispID 59 */
        int virtualBaseClass { get { return this.DiaSymbol.virtualBaseClass; } }
        /* DispID 73 */
        uint virtualBaseDispIndex { get { return this.DiaSymbol.virtualBaseDispIndex; } }
        /* DispID 34 */
        uint virtualBaseOffset { get { return this.DiaSymbol.virtualBaseOffset; } }
        /* DispID 61 */
        int virtualBasePointerOffset { get { return this.DiaSymbol.virtualBasePointerOffset; } }
        /* DispID 119 */
        IDiaSymbol virtualBaseTableType { get { return this.DiaSymbol.virtualBaseTableType; } }
        /* DispID 62 */
        IDiaSymbol virtualTableShape { get { return this.DiaSymbol.virtualTableShape; } }
        /* DispID 68 */
        uint virtualTableShapeId { get { return this.DiaSymbol.virtualTableShapeId; } }
        /* DispID 16 */
        int volatileType { get { return this.DiaSymbol.volatileType; } }
        /* DispID 128 */
        int wasInlined { get { return this.DiaSymbol.wasInlined; } }

        public IDiaEnumSymbols TryChildren()
        {
            try
            {
                IDiaEnumSymbols children;
                _symbol.findChildren(SymTagEnum.SymTagNull, null, 0, out children);
                return children;
            }
            catch
            {
                return null;
            }
        }
    }
}
