using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// force github commit

namespace Pdb_Magician
{
    class SymbolWrapper
    {
        #region String constants
        #region Basic types
        static public string[] rgBaseType = new string[]
        {
          "<NoType>",                         // btNoType = 0,
          "void",                             // btpublic void = 1,
          "char",                             // btChar = 2,
          "wchar_t",                          // btWChar = 3,
          "signed char",
          "unsigned char",
          "int",                              // btInt = 6,
          "unsigned int",                     // btUInt = 7,
          "float",                            // btFloat = 8,
          "<BCD>",                            // btBCD = 9,
          "bool",                             // btbool = 10,
          "short",
          "unsigned short",
          "long",                             // btLong = 13,
          "unsigned long",                    // btulong = 14,
          "__int8",
          "__int16",
          "__int32",
          "__int64",
          "__int128",
          "unsigned __int8",
          "unsigned __int16",
          "unsigned __int32",
          "unsigned __int64",
          "unsigned __int128",
          "<currency>",                       // btCurrency = 25,
          "<date>",                           // btDate = 26,
          "VARIANT",                          // btVariant = 27,
          "<complex>",                        // btComplex = 28,
          "<bit>",                            // btBit = 29,
          "string",                             // btstring = 30,
          "HRESULT"                           // btHresult = 31
        };
        #endregion

        #region Tags returned by Dia
        string[] rgTags = new string[]
        {
          "(SymTagnull)",                     // SymTagnull
          "Executable (Global)",              // SymTagExe
          "Compiland",                        // SymTagCompiland
          "CompilandDetails",                 // SymTagCompilandDetails
          "CompilandEnv",                     // SymTagCompilandEnv
          "Function",                         // SymTagFunction
          "Block",                            // SymTagBlock
          "Data",                             // SymTagData
          "Annotation",                       // SymTagAnnotation
          "Label",                            // SymTagLabel
          "PublicSymbol",                     // SymTagPublicSymbol
          "UserDefinedType",                  // SymTagUDT
          "Enum",                             // SymTagEnum
          "FunctionType",                     // SymTagFunctionType
          "PointerType",                      // SymTagPointerType
          "ArrayType",                        // SymTagArrayType
          "BaseType",                         // SymTagBaseType
          "Typedef",                          // SymTagTypedef
          "BaseClass",                        // SymTagBaseClass
          "Friend",                           // SymTagFriend
          "FunctionArgType",                  // SymTagFunctionArgType
          "FuncDebugStart",                   // SymTagFuncDebugStart
          "FuncDebugEnd",                     // SymTagFuncDebugEnd
          "UsingNamespace",                   // SymTagUsingNamespace
          "VTableShape",                      // SymTagVTableShape
          "VTable",                           // SymTagVTable
          "Custom",                           // SymTagCustom
          "Thunk",                            // SymTagThunk
          "CustomType",                       // SymTagCustomType
          "ManagedType",                      // SymTagManagedType
          "Dimension",                        // SymTagDimension
          "CallSite",                         // SymTagCallSite
        };
        #endregion

        #region Processors
        string[] rgFloatPackageStrings = new string[]
        {
          "hardware processor (80x87 for Intel processors)",    // CV_CFL_NDP
          "emulator",                                           // CV_CFL_EMU
          "altmath",                                            // CV_CFL_ALT
          "???"
        };
        #endregion

        #region ProcessorsNames
        string[] rgProcessorStrings = new string[]
        {
          "8080",                             //  CV_CFL_8080
          "8086",                             //  CV_CFL_8086
          "80286",                            //  CV_CFL_80286
          "80386",                            //  CV_CFL_80386
          "80486",                            //  CV_CFL_80486
          "Pentium",                          //  CV_CFL_PENTIUM
          "Pentium Pro/Pentium II",           //  CV_CFL_PENTIUMII/CV_CFL_PENTIUMPRO
          "Pentium III",                      //  CV_CFL_PENTIUMIII
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "MIPS (Generic)",                   //  CV_CFL_MIPSR4000
          "MIPS16",                           //  CV_CFL_MIPS16
          "MIPS32",                           //  CV_CFL_MIPS32
          "MIPS64",                           //  CV_CFL_MIPS64
          "MIPS I",                           //  CV_CFL_MIPSI
          "MIPS II",                          //  CV_CFL_MIPSII
          "MIPS III",                         //  CV_CFL_MIPSIII
          "MIPS IV",                          //  CV_CFL_MIPSIV
          "MIPS V",                           //  CV_CFL_MIPSV
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "M68000",                           //  CV_CFL_M68000
          "M68010",                           //  CV_CFL_M68010
          "M68020",                           //  CV_CFL_M68020
          "M68030",                           //  CV_CFL_M68030
          "M68040",                           //  CV_CFL_M68040
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "Alpha 21064",                      // CV_CFL_ALPHA, CV_CFL_ALPHA_21064
          "Alpha 21164",                      // CV_CFL_ALPHA_21164
          "Alpha 21164A",                     // CV_CFL_ALPHA_21164A
          "Alpha 21264",                      // CV_CFL_ALPHA_21264
          "Alpha 21364",                      // CV_CFL_ALPHA_21364
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "PPC 601",                          // CV_CFL_PPC601
          "PPC 603",                          // CV_CFL_PPC603
          "PPC 604",                          // CV_CFL_PPC604
          "PPC 620",                          // CV_CFL_PPC620
          "PPC w/FP",                         // CV_CFL_PPCFP
          "PPC (Big Endian)",                 // CV_CFL_PPCBE
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "SH3",                              // CV_CFL_SH3
          "SH3E",                             // CV_CFL_SH3E
          "SH3DSP",                           // CV_CFL_SH3DSP
          "SH4",                              // CV_CFL_SH4
          "SHmedia",                          // CV_CFL_SHMEDIA
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "ARM3",                             // CV_CFL_ARM3
          "ARM4",                             // CV_CFL_ARM4
          "ARM4T",                            // CV_CFL_ARM4T
          "ARM5",                             // CV_CFL_ARM5
          "ARM5T",                            // CV_CFL_ARM5T
          "ARM6",                             // CV_CFL_ARM6
          "ARM (XMAC)",                       // CV_CFL_ARM_XMAC
          "ARM (WMMX)",                       // CV_CFL_ARM_WMMX
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "Omni",                             // CV_CFL_OMNI
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "Itanium",                          // CV_CFL_IA64, CV_CFL_IA64_1
          "Itanium (McKinley)",               // CV_CFL_IA64_2
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "CEE",                              // CV_CFL_CEE
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "AM33",                             // CV_CFL_AM33
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "M32R",                             // CV_CFL_M32R
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "TriCore",                          // CV_CFL_TRICORE
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "x64",                              // CV_CFL_X64
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "EBC",                              // CV_CFL_EBC
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "???",
          "Thumb",                            // CV_CFL_THUMB
        };
        #endregion

        string[] rgDataKind = new string[]
        {
          "Unknown",
          "Local",
          "Static Local",
          "Param",
          "Object Ptr",
          "File Static",
          "Global",
          "Member",
          "Static Member",
          "Constant",
        };

        string[] rgUdtKind = new string[]
        {
          "struct",
          "class",
          "union",
          "enum",
        };

        static public string[] rgAccess = new string[]
        {
          "",                     // No access specifier
          "private",
          "protected",
          "public"
        };

        public static string[] rgCallingConvention = new string[]
        {
          "__cdecl",
          "CV_CALL_FAR_C",
          "CV_CALL_NEAR_PASCAL",
          "CV_CALL_FAR_PASCAL",
          "CV_CALL_NEAR_FAST",
          "CV_CALL_FAR_FAST",
          "CV_CALL_SKIPPED",
          "__stdcall",
          "CV_CALL_FAR_STD",
          "CV_CALL_NEAR_SYS",
          "CV_CALL_FAR_SYS",
          "__thiscall",
          "CV_CALL_MIPSCALL",
          "CV_CALL_GENERIC",
          "CV_CALL_ALPHACALL",
          "CV_CALL_PPCCALL",
          "CV_CALL_SHCALL",
          "CV_CALL_ARMCALL",
          "CV_CALL_AM33CALL",
          "CV_CALL_TRICALL",
          "CV_CALL_SH5CALL",
          "CV_CALL_M32RCALL",
          "CV_CALL_RESERVED"
        };

        string[] rgLanguage = new string[]
        {
          "C",                                // CV_CFL_C
          "C++",                              // CV_CFL_CXX
          "FORTRAN",                          // CV_CFL_FORTRAN
          "MASM",                             // CV_CFL_MASM
          "Pascal",                           // CV_CFL_PASCAL
          "Basic",                            // CV_CFL_BASIC
          "COBOL",                            // CV_CFL_COBOL
          "LINK",                             // CV_CFL_LINK
          "CVTRES",                           // CV_CFL_CVTRES
          "CVTPGD",                           // CV_CFL_CVTPGD
          "C#",                               // CV_CFL_CSHARP
          "Visual Basic",                     // CV_CFL_VB
          "ILASM",                            // CV_CFL_ILASM
          "Java",                             // CV_CFL_JAVA
          "JScript",                          // CV_CFL_JSCRIPT
          "MSIL",                             // CV_CFL_MSIL
        };

        string[] rgLocationTypeString = new string[]
        {
              "null",
              "static",
              "TLS",
              "RegRel",
              "ThisRel",
              "Enregistered",
              "BitField",
              "Slot",
              "IL Relative",
              "In MetaData",
              "Constant"
        };
        #endregion

    }
}
