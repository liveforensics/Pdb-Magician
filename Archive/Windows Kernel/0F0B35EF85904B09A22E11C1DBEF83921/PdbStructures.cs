using System;

namespace LiveForensics.Symbols
{
	#region HEADER
	public class CatalogueInformation
	{
		 public Guid Guid { get { return new Guid("0F0B35EF-8590-4B09-A22E-11C1DBEF8392"); } }
		 public uint Age { get { return 1; } }
		 public string MachineType { get { return @"Amd64"; } }
		 public string SymbolsFileName { get { return @"ntkrnlmp.pdb"; } }
		 public uint Signature { get { return 1459204968; } }
		 public string Contents { get { return @"[])"; } }
		 public string Created { get { return "20-02-2021T11:32:04"; } }
	}
	#endregion
}
