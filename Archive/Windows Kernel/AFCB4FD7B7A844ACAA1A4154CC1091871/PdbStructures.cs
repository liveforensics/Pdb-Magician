using System;

namespace LiveForensics.Symbols
{
	#region HEADER
	public class CatalogueInformation
	{
		 public Guid Guid { get { return new Guid("AFCB4FD7-B7A8-44AC-AA1A-4154CC109187"); } }
		 public uint Age { get { return 1; } }
		 public string MachineType { get { return @"Amd64"; } }
		 public string SymbolsFileName { get { return @"ntkrnlmp.pdb"; } }
		 public uint Signature { get { return 1456230214; } }
		 public string Contents { get { return @"[])"; } }
		 public string Created { get { return "20-02-2021T11:31:11"; } }
	}
	#endregion
}
