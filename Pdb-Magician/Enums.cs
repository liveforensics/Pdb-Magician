using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// force github commit

namespace Pdb_Magician
{
    public enum Machine : ushort
    {
        Unknown = 0,
        I386 = 0x014c,  // Intel 386.
        R3000 = 0x0162,  // MIPS little-endian, 0x160 big-endian
        R4000 = 0x0166,  // MIPS little-endian
        R10000 = 0x0168,  // MIPS little-endian
        WceMipsV2 = 0x0169,  // MIPS little-endian WCE v2
        Alpha = 0x0184,  // Alpha_AXP
        Sh3 = 0x01a2,  // SH3 little-endian
        Sh3Dsp = 0x01a3,
        Sh3E = 0x01a4,  // SH3E little-endian
        Sh4 = 0x01a6,  // SH4 little-endian
        Sh5 = 0x01a8,  // SH5
        Arm = 0x01c0,  // ARM Little-Endian
        Thumb = 0x01c2,
        Am33 = 0x01d3,
        PowerPc = 0x01F0,  // IBM PowerPC Little-Endian
        PowerPcFp = 0x01f1,
        Ia64 = 0x0200,  // Intel 64
        Mips16 = 0x0266,  // MIPS
        Alpha64 = 0x0284,  // ALPHA64
        MipsFpu = 0x0366,  // MIPS
        MipsFpu16 = 0x0466,  // MIPS
        Axp64 = Alpha64,
        Tricore = 0x0520,  // Infineon
        Cef = 0x0CEF,
        Ebc = 0x0EBC,  // EFI Byte Code
        Amd64 = 0x8664,  // AMD64 (K8)
        M32R = 0x9041,  // M32R little-endian
        Cee = 0xC0EE
    }
    enum LocationType
    {
        LocIsNull,
        LocIsStatic,
        LocIsTLS,
        LocIsRegRel,
        LocIsThisRel,
        LocIsEnregistered,
        LocIsBitField,
        LocIsSlot,
        LocIsIlRel,
        LocInMetaData,
        LocIsConstant,
        LocTypeMax
    }
    public enum SymbolKind
    {
        Null,
        Module,
        Compiland,
        CompilandDetails,
        CompilandEnv,
        Function,
        Block,
        Data,
        Annotation,
        Label,
        PublicSymbol,
        UDT,
        Enum,
        FunctionType,
        PointerType,
        ArrayType,
        BaseType,
        Typedef,
        BaseClass,
        Friend,
        FunctionArgType,
        FuncDebugStart,
        FuncDebugEnd,
        UsingNamespace,
        VTableShape,
        VTable,
        Custom,
        Thunk,
        CustomType,
        ManagedType,
        Dimension
    }
    public enum CV_access_e
    {
        CV_private = 1,
        CV_protected = 2,
        CV_public = 3
    }
    enum BasicType
    {
        btNoType = 0,
        btvoid = 1,
        btChar = 2,
        btWChar = 3,
        btInt = 6,
        btUInt = 7,
        btFloat = 8,
        btBCD = 9,
        btBool = 10,
        btLong = 13,
        btULong = 14,
        btCurrency = 25,
        btDate = 26,
        btVariant = 27,
        btComplex = 28,
        btBit = 29,
        btBSTR = 30,
        btHresult = 31
    }
}
