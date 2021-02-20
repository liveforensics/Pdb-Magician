using System;

namespace LiveForensics.Symbols
{
	#region HEADER
	public class CatalogueInformation
	{
		 public Guid Guid { get { return new Guid("3D440078-4115-7188-18EF-C898413F36C4"); } }
		 public uint Age { get { return 1; } }
		 public string MachineType { get { return @"Amd64"; } }
		 public string SymbolsFileName { get { return @"ntkrnlmp.pdb"; } }
		 public uint Signature { get { return 4111912310; } }
		 public string Contents { get { return @"[""_MI_FREE_LARGE_PAGES"",""_MI_FREE_LARGE_PAGE_LIST"",""_LIST_ENTRY""])"; } }
		 public string Created { get { return "20-02-2021T11:29:53"; } }
	}
	#endregion
	#region _MI_FREE_LARGE_PAGES
 
	public class _MI_FREE_LARGE_PAGES
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _MI_FREE_LARGE_PAGES(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 1072; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_MI_FREE_LARGE_PAGES"": [ 1072, {
				 ""LargePageFreeCount"": [ 0, [ ""Array"", ""{\""count\"":2,\""target\"":\""UInt64\""}"" ]],
				 ""LargePageFreeCountHiLow"": [ 16, [ ""Array"", ""{\""count\"":4,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""UInt64\""}}"" ]],
				 ""LargePagesCount"": [ 48, [ ""Array"", ""{\""count\"":64,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""UInt64\""}}"" ]],
				 ""LargePageEntries"": [ 560, [ ""Array"", ""{\""count\"":64,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""_MI_FREE_LARGE_PAGE_LIST\""}}"" ]] }]
				 }
				)";
			}
		}
		public UInt64[] LargePageFreeCount
		{
			get
			{
				UInt64[] returnValue = new UInt64[2];
				for(int i=0; i<2; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * sizeof(UInt64)) + _BufferOffset + 0);
				return returnValue;
			}
		}
		public UInt64[] LargePageFreeCountHiLow
		{
			get
			{
				UInt64[] returnValue = new UInt64[4];
				int size = 8;
				for(int i=0; i<4; i++ )
					returnValue[i] = (UInt64)BitConverter.ToUInt64(_StructureData, (i * size) + _BufferOffset + 16);
				return returnValue;
			}
		}
		public UInt64[] LargePagesCount
		{
			get
			{
				UInt64[] returnValue = new UInt64[64];
				int size = 8;
				for(int i=0; i<64; i++ )
					returnValue[i] = (UInt64)BitConverter.ToUInt64(_StructureData, (i * size) + _BufferOffset + 48);
				return returnValue;
			}
		}
		public _MI_FREE_LARGE_PAGE_LIST[] LargePageEntries
		{
			get
			{
				_MI_FREE_LARGE_PAGE_LIST[] returnValue = new _MI_FREE_LARGE_PAGE_LIST[64];
				int size = returnValue[0].MxStructureSize;
				for(int i=0; i<64; i++ )
					returnValue[i] = new _MI_FREE_LARGE_PAGE_LIST(_StructureData, (i * size) + _BufferOffset + 560);
				return returnValue;
			}
		}
	}
	#endregion
	#region _MI_FREE_LARGE_PAGE_LIST
 
	public class _MI_FREE_LARGE_PAGE_LIST
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _MI_FREE_LARGE_PAGE_LIST(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 24; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_MI_FREE_LARGE_PAGE_LIST"": [ 24, {
				 ""ListHead"": [ 0, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""EntryCount"": [ 16, [ ""UInt64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _LIST_ENTRY ListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public UInt64 EntryCount { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 16); } }
	}
	#endregion
	#region _LIST_ENTRY
 
	public class _LIST_ENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _LIST_ENTRY(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_LIST_ENTRY"": [ 16, {
				 ""Flink"": [ 0, [ ""Pointer"", ""{\""target\"":\""_LIST_ENTRY\""}"" ]],
				 ""Blink"": [ 8, [ ""Pointer"", ""{\""target\"":\""_LIST_ENTRY\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Flink { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Blink { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
}
