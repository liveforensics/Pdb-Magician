using System;

namespace LiveForensics.Symbols
{
	public enum _PP_NPAGED_LOOKASIDE_NUMBER
	{
		LookasideSmallIrpList = 0,
		LookasideLargeIrpList = 1,
		LookasideMdlList = 2,
		LookasideCreateInfoList = 3,
		LookasideNameBufferList = 4,
		LookasideTwilightList = 5,
		LookasideCompletionList = 6,
		LookasideMaximumList = 7
	}
	public enum _POOL_TYPE
	{
		NonPagedPool = 0,
		PagedPool = 1,
		NonPagedPoolMustSucceed = 2,
		DontUseThisType = 3,
		NonPagedPoolCacheAligned = 4,
		PagedPoolCacheAligned = 5,
		NonPagedPoolCacheAlignedMustS = 6,
		MaxPoolType = 7,
		NonPagedPoolSession = 32,
		PagedPoolSession = 33,
		NonPagedPoolMustSucceedSession = 34,
		DontUseThisTypeSession = 35,
		NonPagedPoolCacheAlignedSession = 36,
		PagedPoolCacheAlignedSession = 37,
		NonPagedPoolCacheAlignedMustSSession = 38
	}
	public enum _MEMORY_CACHING_TYPE
	{
		MmNonCached = 0,
		MmCached = 1,
		MmWriteCombined = 2,
		MmHardwareCoherentCached = 3,
		MmNonCachedUnordered = 4,
		MmUSWCCached = 5,
		MmMaximumCacheType = 6
	}
	public enum _MI_PFN_CACHE_ATTRIBUTE
	{
		MiNonCached = 0,
		MiCached = 1,
		MiWriteCombined = 2,
		MiNotMapped = 3
	}
	public enum _PF_SCENARIO_TYPE
	{
		PfApplicationLaunchScenarioType = 0,
		PfSystemBootScenarioType = 1,
		PfMaxScenarioType = 2
	}
	public enum _SYSTEM_POWER_STATE
	{
		PowerSystemUnspecified = 0,
		PowerSystemWorking = 1,
		PowerSystemSleeping1 = 2,
		PowerSystemSleeping2 = 3,
		PowerSystemSleeping3 = 4,
		PowerSystemHibernate = 5,
		PowerSystemShutdown = 6,
		PowerSystemMaximum = 7
	}
	public enum _DEVICE_POWER_STATE
	{
		PowerDeviceUnspecified = 0,
		PowerDeviceD0 = 1,
		PowerDeviceD1 = 2,
		PowerDeviceD2 = 3,
		PowerDeviceD3 = 4,
		PowerDeviceMaximum = 5
	}
	public enum _MMLISTS
	{
		ZeroedPageList = 0,
		FreePageList = 1,
		StandbyPageList = 2,
		ModifiedPageList = 3,
		ModifiedNoWritePageList = 4,
		BadPageList = 5,
		ActiveAndValid = 6,
		TransitionPage = 7
	}
	public enum _SECURITY_IMPERSONATION_LEVEL
	{
		SecurityAnonymous = 0,
		SecurityIdentification = 1,
		SecurityImpersonation = 2,
		SecurityDelegation = 3
	}
	public enum _PNP_DEVNODE_STATE
	{
		DeviceNodeUnspecified = 768,
		DeviceNodeUninitialized = 769,
		DeviceNodeInitialized = 770,
		DeviceNodeDriversAdded = 771,
		DeviceNodeResourcesAssigned = 772,
		DeviceNodeStartPending = 773,
		DeviceNodeStartCompletion = 774,
		DeviceNodeStartPostWork = 775,
		DeviceNodeStarted = 776,
		DeviceNodeQueryStopped = 777,
		DeviceNodeStopped = 778,
		DeviceNodeRestartCompletion = 779,
		DeviceNodeEnumeratePending = 780,
		DeviceNodeEnumerateCompletion = 781,
		DeviceNodeAwaitingQueuedDeletion = 782,
		DeviceNodeAwaitingQueuedRemoval = 783,
		DeviceNodeQueryRemoved = 784,
		DeviceNodeRemovePendingCloses = 785,
		DeviceNodeRemoved = 786,
		DeviceNodeDeletePendingCloses = 787,
		DeviceNodeDeleted = 788
	}
	public enum _INTERFACE_TYPE
	{
		InterfaceTypeUndefined = -1,
		Internal = 0,
		Isa = 1,
		Eisa = 2,
		MicroChannel = 3,
		TurboChannel = 4,
		PCIBus = 5,
		VMEBus = 6,
		NuBus = 7,
		PCMCIABus = 8,
		CBus = 9,
		MPIBus = 10,
		MPSABus = 11,
		ProcessorInternal = 12,
		InternalPowerBus = 13,
		PNPISABus = 14,
		PNPBus = 15,
		MaximumInterfaceType = 16
	}
	public enum PROFILE_STATUS
	{
		DOCK_NOTDOCKDEVICE = 0,
		DOCK_QUIESCENT = 1,
		DOCK_ARRIVING = 2,
		DOCK_DEPARTING = 3,
		DOCK_EJECTIRP_COMPLETED = 4
	}
	public enum CPU_VENDORS
	{
		CPU_NONE = 0,
		CPU_INTEL = 1,
		CPU_AMD = 2,
		CPU_CYRIX = 3,
		CPU_TRANSMETA = 4,
		CPU_CENTAUR = 5,
		CPU_RISE = 6,
		CPU_UNKNOWN = 7
	}
	public enum LSA_FOREST_TRUST_RECORD_TYPE
	{
		ForestTrustTopLevelName = 0,
		ForestTrustTopLevelNameEx = 1,
		ForestTrustDomainInfo = 2,
		ForestTrustRecordTypeLast = 2
	}
	public enum POWER_ACTION
	{
		PowerActionNone = 0,
		PowerActionReserved = 1,
		PowerActionSleep = 2,
		PowerActionHibernate = 3,
		PowerActionShutdown = 4,
		PowerActionShutdownReset = 5,
		PowerActionShutdownOff = 6,
		PowerActionWarmEject = 7
	}
	public enum _KWAIT_REASON
	{
		Executive = 0,
		FreePage = 1,
		PageIn = 2,
		PoolAllocation = 3,
		DelayExecution = 4,
		Suspended = 5,
		UserRequest = 6,
		WrExecutive = 7,
		WrFreePage = 8,
		WrPageIn = 9,
		WrPoolAllocation = 10,
		WrDelayExecution = 11,
		WrSuspended = 12,
		WrUserRequest = 13,
		WrEventPair = 14,
		WrQueue = 15,
		WrLpcReceive = 16,
		WrLpcReply = 17,
		WrVirtualMemory = 18,
		WrPageOut = 19,
		WrRendezvous = 20,
		Spare2 = 21,
		Spare3 = 22,
		Spare4 = 23,
		Spare5 = 24,
		Spare6 = 25,
		WrKernel = 26,
		MaximumWaitReason = 27
	}
	public enum _NT_PRODUCT_TYPE
	{
		NtProductWinNt = 1,
		NtProductLanManNt = 2,
		NtProductServer = 3
	}
	public enum _ALTERNATIVE_ARCHITECTURE_TYPE
	{
		StandardDesign = 0,
		NEC98x86 = 1,
		EndAlternatives = 2
	}
	public enum _OB_OPEN_REASON
	{
		ObCreateHandle = 0,
		ObOpenHandle = 1,
		ObDuplicateHandle = 2,
		ObInheritHandle = 3,
		ObMaxOpenReason = 4
	}
	public enum _SECURITY_OPERATION_CODE
	{
		SetSecurityDescriptor = 0,
		QuerySecurityDescriptor = 1,
		DeleteSecurityDescriptor = 2,
		AssignSecurityDescriptor = 3
	}
	public enum _MEMORY_CACHING_TYPE_ORIG
	{
		MmFrameBufferCached = 2
	}
	public enum _EXCEPTION_DISPOSITION
	{
		ExceptionContinueExecution = 0,
		ExceptionContinueSearch = 1,
		ExceptionNestedException = 2,
		ExceptionCollidedUnwind = 3
	}
	public enum PCI_SIGNATURE
	{
		PciPdoExtensionType = 1768116272,
		PciFdoExtensionType = 1768116273,
		PciArb_Io = 1768116274,
		PciArb_Memory = 1768116275,
		PciArb_Interrupt = 1768116276,
		PciArb_BusNumber = 1768116277,
		PciTrans_Interrupt = 1768116278,
		PciInterface_BusHandler = 1768116279,
		PciInterface_IntRouteHandler = 1768116280,
		PciInterface_PciCb = 1768116281,
		PciInterface_LegacyDeviceDetection = 1768116282,
		PciInterface_PmeHandler = 1768116283,
		PciInterface_DevicePresent = 1768116284,
		PciInterface_NativeIde = 1768116285,
		PciInterface_AgpTarget = 1768116286
	}
	public enum _MODE
	{
		KernelMode = 0,
		UserMode = 1,
		MaximumMode = 2
	}
	public enum _IO_ALLOCATION_ACTION
	{
		KeepObject = 1,
		DeallocateObject = 2,
		DeallocateObjectKeepRegisters = 3
	}
	public enum POP_POLICY_DEVICE_TYPE
	{
		PolicyDeviceSystemButton = 0,
		PolicyDeviceThermalZone = 1,
		PolicyDeviceBattery = 2,
		PolicyInitiatePowerActionAPI = 3,
		PolicySetPowerStateAPI = 4,
		PolicyImmediateDozeS4 = 5,
		PolicySystemIdle = 6
	}
	public enum _POLICY_AUDIT_EVENT_TYPE
	{
		AuditCategorySystem = 0,
		AuditCategoryLogon = 1,
		AuditCategoryObjectAccess = 2,
		AuditCategoryPrivilegeUse = 3,
		AuditCategoryDetailedTracking = 4,
		AuditCategoryPolicyChange = 5,
		AuditCategoryAccountManagement = 6,
		AuditCategoryDirectoryServiceAccess = 7,
		AuditCategoryAccountLogon = 8
	}
	public enum _VI_DEADLOCK_RESOURCE_TYPE
	{
		VfDeadlockUnknown = 0,
		VfDeadlockMutex = 1,
		VfDeadlockFastMutex = 2,
		VfDeadlockFastMutexUnsafe = 3,
		VfDeadlockSpinLock = 4,
		VfDeadlockQueuedSpinLock = 5,
		VfDeadlockTypeMaximum = 6
	}
	public enum _KINTERRUPT_MODE
	{
		LevelSensitive = 0,
		Latched = 1
	}
	public enum _PCI_DISPATCH_STYLE
	{
		IRP_COMPLETE = 0,
		IRP_DOWNWARD = 1,
		IRP_UPWARD = 2,
		IRP_DISPATCH = 3
	}
	public enum ReplacesCorHdrNumericDefines
	{
		COMIMAGE_FLAGS_ILONLY = 1,
		COMIMAGE_FLAGS_32BITREQUIRED = 2,
		COMIMAGE_FLAGS_IL_LIBRARY = 4,
		COMIMAGE_FLAGS_STRONGNAMESIGNED = 8,
		COMIMAGE_FLAGS_TRACKDEBUGDATA = 65536,
		COR_VERSION_MAJOR_V2 = 2,
		COR_VERSION_MAJOR = 2,
		COR_VERSION_MINOR = 0,
		COR_DELETED_NAME_LENGTH = 8,
		COR_VTABLEGAP_NAME_LENGTH = 8,
		NATIVE_TYPE_MAX_CB = 1,
		COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 255,
		IMAGE_COR_MIH_METHODRVA = 1,
		IMAGE_COR_MIH_EHRVA = 2,
		IMAGE_COR_MIH_BASICBLOCK = 8,
		COR_VTABLE_32BIT = 1,
		COR_VTABLE_64BIT = 2,
		COR_VTABLE_FROM_UNMANAGED = 4,
		COR_VTABLE_CALL_MOST_DERIVED = 16,
		IMAGE_COR_EATJ_THUNK_SIZE = 32,
		MAX_CLASS_NAME = 1024,
		MAX_PACKAGE_NAME = 1024
	}
	public enum _MEMORY_TYPE
	{
		MemoryExceptionBlock = 0,
		MemorySystemBlock = 1,
		MemoryFree = 2,
		MemoryBad = 3,
		MemoryLoadedProgram = 4,
		MemoryFirmwareTemporary = 5,
		MemoryFirmwarePermanent = 6,
		MemoryFreeContiguous = 7,
		MemorySpecialMemory = 8,
		MemoryMaximum = 9
	}
	public enum _ARBITER_ACTION
	{
		ArbiterActionTestAllocation = 0,
		ArbiterActionRetestAllocation = 1,
		ArbiterActionCommitAllocation = 2,
		ArbiterActionRollbackAllocation = 3,
		ArbiterActionQueryAllocatedResources = 4,
		ArbiterActionWriteReservedResources = 5,
		ArbiterActionQueryConflict = 6,
		ArbiterActionQueryArbitrate = 7,
		ArbiterActionAddReserved = 8,
		ArbiterActionBootAllocation = 9
	}
	public enum _TOKEN_TYPE
	{
		TokenPrimary = 1,
		TokenImpersonation = 2
	}
	public enum _PS_QUOTA_TYPE
	{
		PsNonPagedPool = 0,
		PsPagedPool = 1,
		PsPageFile = 2,
		PsQuotaTypes = 3
	}
	public enum _PNP_VETO_TYPE
	{
		PNP_VetoTypeUnknown = 0,
		PNP_VetoLegacyDevice = 1,
		PNP_VetoPendingClose = 2,
		PNP_VetoWindowsApp = 3,
		PNP_VetoWindowsService = 4,
		PNP_VetoOutstandingOpen = 5,
		PNP_VetoDevice = 6,
		PNP_VetoDriver = 7,
		PNP_VetoIllegalDeviceRequest = 8,
		PNP_VetoInsufficientPower = 9,
		PNP_VetoNonDisableable = 10,
		PNP_VetoLegacyDriver = 11,
		PNP_VetoInsufficientRights = 12
	}
	public enum _BUS_DATA_TYPE
	{
		ConfigurationSpaceUndefined = -1,
		Cmos = 0,
		EisaConfiguration = 1,
		Pos = 2,
		CbusConfiguration = 3,
		PCIConfiguration = 4,
		VMEConfiguration = 5,
		NuBusConfiguration = 6,
		PCMCIAConfiguration = 7,
		MPIConfiguration = 8,
		MPSAConfiguration = 9,
		PNPISAConfiguration = 10,
		SgiInternalConfiguration = 11,
		MaximumBusDataType = 12
	}
	public enum _MMSYSTEM_PTE_POOL_TYPE
	{
		SystemPteSpace = 0,
		NonPagedPoolExpansion = 1,
		MaximumPtePoolTypes = 2
	}
	public enum _PROXY_CLASS
	{
		ProxyFull = 0,
		ProxyService = 1,
		ProxyTree = 2,
		ProxyDirectory = 3
	}
	public enum _FILE_INFORMATION_CLASS
	{
		FileDirectoryInformation = 1,
		FileFullDirectoryInformation = 2,
		FileBothDirectoryInformation = 3,
		FileBasicInformation = 4,
		FileStandardInformation = 5,
		FileInternalInformation = 6,
		FileEaInformation = 7,
		FileAccessInformation = 8,
		FileNameInformation = 9,
		FileRenameInformation = 10,
		FileLinkInformation = 11,
		FileNamesInformation = 12,
		FileDispositionInformation = 13,
		FilePositionInformation = 14,
		FileFullEaInformation = 15,
		FileModeInformation = 16,
		FileAlignmentInformation = 17,
		FileAllInformation = 18,
		FileAllocationInformation = 19,
		FileEndOfFileInformation = 20,
		FileAlternateNameInformation = 21,
		FileStreamInformation = 22,
		FilePipeInformation = 23,
		FilePipeLocalInformation = 24,
		FilePipeRemoteInformation = 25,
		FileMailslotQueryInformation = 26,
		FileMailslotSetInformation = 27,
		FileCompressionInformation = 28,
		FileObjectIdInformation = 29,
		FileCompletionInformation = 30,
		FileMoveClusterInformation = 31,
		FileQuotaInformation = 32,
		FileReparsePointInformation = 33,
		FileNetworkOpenInformation = 34,
		FileAttributeTagInformation = 35,
		FileTrackingInformation = 36,
		FileIdBothDirectoryInformation = 37,
		FileIdFullDirectoryInformation = 38,
		FileValidDataLengthInformation = 39,
		FileShortNameInformation = 40,
		FileMaximumInformation = 41
	}
	public enum _FSINFOCLASS
	{
		FileFsVolumeInformation = 1,
		FileFsLabelInformation = 2,
		FileFsSizeInformation = 3,
		FileFsDeviceInformation = 4,
		FileFsAttributeInformation = 5,
		FileFsControlInformation = 6,
		FileFsFullSizeInformation = 7,
		FileFsObjectIdInformation = 8,
		FileFsDriverPathInformation = 9,
		FileFsMaximumInformation = 10
	}
	public enum _DEVICE_RELATION_TYPE
	{
		BusRelations = 0,
		EjectionRelations = 1,
		PowerRelations = 2,
		RemovalRelations = 3,
		TargetDeviceRelation = 4,
		SingleBusRelations = 5
	}
	public enum BUS_QUERY_ID_TYPE
	{
		BusQueryDeviceID = 0,
		BusQueryHardwareIDs = 1,
		BusQueryCompatibleIDs = 2,
		BusQueryInstanceID = 3,
		BusQueryDeviceSerialNumber = 4
	}
	public enum DEVICE_TEXT_TYPE
	{
		DeviceTextDescription = 0,
		DeviceTextLocationInformation = 1
	}
	public enum _DEVICE_USAGE_NOTIFICATION_TYPE
	{
		DeviceUsageTypeUndefined = 0,
		DeviceUsageTypePaging = 1,
		DeviceUsageTypeHibernation = 2,
		DeviceUsageTypeDumpFile = 3
	}
	public enum _POWER_STATE_TYPE
	{
		SystemPowerState = 0,
		DevicePowerState = 1
	}
	public enum _PLUGPLAY_EVENT_CATEGORY
	{
		HardwareProfileChangeEvent = 0,
		TargetDeviceChangeEvent = 1,
		DeviceClassChangeEvent = 2,
		CustomDeviceEvent = 3,
		DeviceInstallEvent = 4,
		DeviceArrivalEvent = 5,
		PowerEvent = 6,
		VetoEvent = 7,
		BlockedDriverEvent = 8,
		MaxPlugEventCategory = 9
	}
	public enum _ARBITER_REQUEST_SOURCE
	{
		ArbiterRequestUndefined = -1,
		ArbiterRequestLegacyReported = 0,
		ArbiterRequestHalReported = 1,
		ArbiterRequestLegacyAssigned = 2,
		ArbiterRequestPnpDetected = 3,
		ArbiterRequestPnpEnumerated = 4
	}
	public enum _ARBITER_RESULT
	{
		ArbiterResultUndefined = -1,
		ArbiterResultSuccess = 0,
		ArbiterResultExternalConflict = 1,
		ArbiterResultNullRequest = 2
	}
	public enum _FS_FILTER_SECTION_SYNC_TYPE
	{
		SyncTypeOther = 0,
		SyncTypeCreateSection = 1
	}
}
