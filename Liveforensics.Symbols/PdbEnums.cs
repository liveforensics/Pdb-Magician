using System;

namespace LiveForensics.Symbols
{
	public enum SE_WS_APPX_SIGNATURE_ORIGIN
	{
		SE_WS_APPX_SIGNATURE_ORIGIN_NOT_VALIDATED = 0,
		SE_WS_APPX_SIGNATURE_ORIGIN_UNKNOWN = 1,
		SE_WS_APPX_SIGNATURE_ORIGIN_APPSTORE = 2,
		SE_WS_APPX_SIGNATURE_ORIGIN_WINDOWS = 3,
		SE_WS_APPX_SIGNATURE_ORIGIN_ENTERPRISE = 4
	}
	public enum _PS_MITIGATION_OPTION
	{
		PS_MITIGATION_OPTION_NX = 0,
		PS_MITIGATION_OPTION_SEHOP = 1,
		PS_MITIGATION_OPTION_FORCE_RELOCATE_IMAGES = 2,
		PS_MITIGATION_OPTION_HEAP_TERMINATE = 3,
		PS_MITIGATION_OPTION_BOTTOM_UP_ASLR = 4,
		PS_MITIGATION_OPTION_HIGH_ENTROPY_ASLR = 5,
		PS_MITIGATION_OPTION_STRICT_HANDLE_CHECKS = 6,
		PS_MITIGATION_OPTION_WIN32K_SYSTEM_CALL_DISABLE = 7,
		PS_MITIGATION_OPTION_EXTENSION_POINT_DISABLE = 8,
		PS_MITIGATION_OPTION_PROHIBIT_DYNAMIC_CODE = 9,
		PS_MITIGATION_OPTION_CONTROL_FLOW_GUARD = 10,
		PS_MITIGATION_OPTION_BLOCK_NON_MICROSOFT_BINARIES = 11,
		PS_MITIGATION_OPTION_FONT_DISABLE = 12,
		PS_MITIGATION_OPTION_IMAGE_LOAD_NO_REMOTE = 13,
		PS_MITIGATION_OPTION_IMAGE_LOAD_NO_LOW_LABEL = 14,
		PS_MITIGATION_OPTION_IMAGE_LOAD_PREFER_SYSTEM32 = 15,
		PS_MITIGATION_OPTION_RETURN_FLOW_GUARD = 16,
		PS_MITIGATION_OPTION_LOADER_INTEGRITY_CONTINUITY = 17,
		PS_MITIGATION_OPTION_STRICT_CONTROL_FLOW_GUARD = 18,
		PS_MITIGATION_OPTION_RESTRICT_SET_THREAD_CONTEXT = 19
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
	public enum _TP_CALLBACK_PRIORITY
	{
		TP_CALLBACK_PRIORITY_HIGH = 0,
		TP_CALLBACK_PRIORITY_NORMAL = 1,
		TP_CALLBACK_PRIORITY_LOW = 2,
		TP_CALLBACK_PRIORITY_INVALID = 3,
		TP_CALLBACK_PRIORITY_COUNT = 3
	}
	public enum _MODE
	{
		KernelMode = 0,
		UserMode = 1,
		MaximumMode = 2
	}
	public enum _EVENT_TYPE
	{
		NotificationEvent = 0,
		SynchronizationEvent = 1
	}
	public enum _POOL_TYPE
	{
		NonPagedPool = 0,
		NonPagedPoolExecute = 0,
		PagedPool = 1,
		NonPagedPoolMustSucceed = 2,
		DontUseThisType = 3,
		NonPagedPoolCacheAligned = 4,
		PagedPoolCacheAligned = 5,
		NonPagedPoolCacheAlignedMustS = 6,
		MaxPoolType = 7,
		NonPagedPoolBase = 0,
		NonPagedPoolBaseMustSucceed = 2,
		NonPagedPoolBaseCacheAligned = 4,
		NonPagedPoolBaseCacheAlignedMustS = 6,
		NonPagedPoolSession = 32,
		PagedPoolSession = 33,
		NonPagedPoolMustSucceedSession = 34,
		DontUseThisTypeSession = 35,
		NonPagedPoolCacheAlignedSession = 36,
		PagedPoolCacheAlignedSession = 37,
		NonPagedPoolCacheAlignedMustSSession = 38,
		NonPagedPoolNx = 512,
		NonPagedPoolNxCacheAligned = 516,
		NonPagedPoolSessionNx = 544
	}
	public enum _PP_NPAGED_LOOKASIDE_NUMBER
	{
		LookasideSmallIrpList = 0,
		LookasideMediumIrpList = 1,
		LookasideLargeIrpList = 2,
		LookasideMdlList = 3,
		LookasideCreateInfoList = 4,
		LookasideNameBufferList = 5,
		LookasideTwilightList = 6,
		LookasideCompletionList = 7,
		LookasideScratchBufferList = 8,
		LookasideMaximumList = 9
	}
	public enum _EX_GEN_RANDOM_DOMAIN
	{
		ExGenRandomDomainKernel = 0,
		ExGenRandomDomainFirst = 0,
		ExGenRandomDomainUserVisible = 1,
		ExGenRandomDomainMax = 2
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
		FileIoCompletionNotificationInformation = 41,
		FileIoStatusBlockRangeInformation = 42,
		FileIoPriorityHintInformation = 43,
		FileSfioReserveInformation = 44,
		FileSfioVolumeInformation = 45,
		FileHardLinkInformation = 46,
		FileProcessIdsUsingFileInformation = 47,
		FileNormalizedNameInformation = 48,
		FileNetworkPhysicalNameInformation = 49,
		FileIdGlobalTxDirectoryInformation = 50,
		FileIsRemoteDeviceInformation = 51,
		FileUnusedInformation = 52,
		FileNumaNodeInformation = 53,
		FileStandardLinkInformation = 54,
		FileRemoteProtocolInformation = 55,
		FileRenameInformationBypassAccessCheck = 56,
		FileLinkInformationBypassAccessCheck = 57,
		FileVolumeNameInformation = 58,
		FileIdInformation = 59,
		FileIdExtdDirectoryInformation = 60,
		FileReplaceCompletionInformation = 61,
		FileHardLinkFullIdInformation = 62,
		FileIdExtdBothDirectoryInformation = 63,
		FileDispositionInformationEx = 64,
		FileRenameInformationEx = 65,
		FileRenameInformationExBypassAccessCheck = 66,
		FileDesiredStorageClassInformation = 67,
		FileStatInformation = 68,
		FileMaximumInformation = 69
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
		FileFsVolumeFlagsInformation = 10,
		FileFsSectorSizeInformation = 11,
		FileFsDataCopyInformation = 12,
		FileFsMetadataSizeInformation = 13,
		FileFsMaximumInformation = 14
	}
	public enum _DEVICE_RELATION_TYPE
	{
		BusRelations = 0,
		EjectionRelations = 1,
		PowerRelations = 2,
		RemovalRelations = 3,
		TargetDeviceRelation = 4,
		SingleBusRelations = 5,
		TransportRelations = 6
	}
	public enum BUS_QUERY_ID_TYPE
	{
		BusQueryDeviceID = 0,
		BusQueryHardwareIDs = 1,
		BusQueryCompatibleIDs = 2,
		BusQueryInstanceID = 3,
		BusQueryDeviceSerialNumber = 4,
		BusQueryContainerID = 5
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
		DeviceUsageTypeDumpFile = 3,
		DeviceUsageTypeBoot = 4,
		DeviceUsageTypePostDisplay = 5
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
	public enum _POWER_STATE_TYPE
	{
		SystemPowerState = 0,
		DevicePowerState = 1
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
		PowerActionWarmEject = 7,
		PowerActionDisplayOff = 8
	}
	public enum _IO_PRIORITY_HINT
	{
		IoPriorityVeryLow = 0,
		IoPriorityLow = 1,
		IoPriorityNormal = 2,
		IoPriorityHigh = 3,
		IoPriorityCritical = 4,
		MaxIoPriorityTypes = 5
	}
	public enum _MEMORY_CACHING_TYPE
	{
		MmNonCached = 0,
		MmCached = 1,
		MmWriteCombined = 2,
		MmHardwareCoherentCached = 3,
		MmNonCachedUnordered = 4,
		MmUSWCCached = 5,
		MmMaximumCacheType = 6,
		MmNotMapped = -1
	}
	public enum _MM_PAGE_ACCESS_TYPE
	{
		MmPteAccessType = 0,
		MmCcReadAheadType = 1,
		MmPfnRepurposeType = 2,
		MmMaximumPageAccessType = 3
	}
	public enum _PF_FILE_ACCESS_TYPE
	{
		PfFileAccessTypeRead = 0,
		PfFileAccessTypeWrite = 1,
		PfFileAccessTypeMax = 2
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
	public enum _DEVICE_WAKE_DEPTH
	{
		DeviceWakeDepthNotWakeable = 0,
		DeviceWakeDepthD0 = 1,
		DeviceWakeDepthD1 = 2,
		DeviceWakeDepthD2 = 3,
		DeviceWakeDepthD3hot = 4,
		DeviceWakeDepthD3cold = 5,
		DeviceWakeDepthMaximum = 6
	}
	public enum _WHEA_ERROR_TYPE
	{
		WheaErrTypeProcessor = 0,
		WheaErrTypeMemory = 1,
		WheaErrTypePCIExpress = 2,
		WheaErrTypeNMI = 3,
		WheaErrTypePCIXBus = 4,
		WheaErrTypePCIXDevice = 5,
		WheaErrTypeGeneric = 6
	}
	public enum _WHEA_ERROR_SEVERITY
	{
		WheaErrSevRecoverable = 0,
		WheaErrSevFatal = 1,
		WheaErrSevCorrected = 2,
		WheaErrSevInformational = 3
	}
	public enum _WHEA_ERROR_SOURCE_TYPE
	{
		WheaErrSrcTypeMCE = 0,
		WheaErrSrcTypeCMC = 1,
		WheaErrSrcTypeCPE = 2,
		WheaErrSrcTypeNMI = 3,
		WheaErrSrcTypePCIe = 4,
		WheaErrSrcTypeGeneric = 5,
		WheaErrSrcTypeINIT = 6,
		WheaErrSrcTypeBOOT = 7,
		WheaErrSrcTypeSCIGeneric = 8,
		WheaErrSrcTypeIPFMCA = 9,
		WheaErrSrcTypeIPFCMC = 10,
		WheaErrSrcTypeIPFCPE = 11,
		WheaErrSrcTypeGenericV2 = 12,
		WheaErrSrcTypeSCIGenericV2 = 13,
		WheaErrSrcTypeMax = 14
	}
	public enum _WHEA_ERROR_PACKET_DATA_FORMAT
	{
		WheaDataFormatIPFSalRecord = 0,
		WheaDataFormatXPFMCA = 1,
		WheaDataFormatMemory = 2,
		WheaDataFormatPCIExpress = 3,
		WheaDataFormatNMIPort = 4,
		WheaDataFormatPCIXBus = 5,
		WheaDataFormatPCIXDevice = 6,
		WheaDataFormatGeneric = 7,
		WheaDataFormatMax = 8
	}
	public enum _EVENT_INFO_CLASS
	{
		EventProviderBinaryTrackInfo = 0,
		EventProviderSetEnableAllKeywords = 1,
		EventProviderSetTraits = 2,
		EventProviderUseDescriptorType = 3,
		MaxEventInfo = 4
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
	public enum _MI_PFN_CACHE_ATTRIBUTE
	{
		MiNonCached = 0,
		MiCached = 1,
		MiWriteCombined = 2,
		MiNotMapped = 3
	}
	public enum _MI_SYSTEM_VA_TYPE
	{
		MiVaUnused = 0,
		MiVaSessionSpace = 1,
		MiVaProcessSpace = 2,
		MiVaBootLoaded = 3,
		MiVaPfnDatabase = 4,
		MiVaNonPagedPool = 5,
		MiVaPagedPool = 6,
		MiVaSpecialPoolPaged = 7,
		MiVaSystemCache = 8,
		MiVaSystemPtes = 9,
		MiVaHal = 10,
		MiVaSessionGlobalSpace = 11,
		MiVaDriverImages = 12,
		MiVaSpecialPoolNonPaged = 13,
		MiVaMaximumType = 14,
		MiVaSystemPtesLarge = 15
	}
	public enum _CM_LOAD_FAILURE_TYPE
	{
		_None = 0,
		_CmInitializeHive = 1,
		_HvInitializeHive = 2,
		_HvpBuildMap = 3,
		_HvpBuildMapForLoaderHive = 4,
		_HvpInitMap = 5,
		_HvLoadHive = 6,
		_HvpMapHiveImage = 7,
		_HvpRecoverData = 8,
		_CmpValidateHiveSecurityDescriptors = 9,
		_HvpEnlistBinInMap = 10,
		_CmCheckRegistry = 11,
		_CmRegistryIO = 12,
		_CmCheckRegistry2 = 13,
		_CmpCheckKey = 14,
		_CmpCheckValueList = 15,
		_HvCheckHive = 16,
		_HvCheckBin = 17,
		_HvpGetLogEntryDirtyVector = 18,
		_HvpReadLogEntryHeader = 19,
		_HvpReadLogEntry = 20,
		_CmpMountPreloadedHives = 21,
		_CmpLoadHiveThread = 22,
		_CmpCheckLeaf = 23
	}
	public enum UoWActionType
	{
		UoWAddThisKey = 0,
		UoWAddChildKey = 1,
		UoWDeleteThisKey = 2,
		UoWDeleteChildKey = 3,
		UoWSetValueNew = 4,
		UoWSetValueExisting = 5,
		UoWDeleteValue = 6,
		UoWSetKeyUserFlags = 7,
		UoWSetLastWriteTime = 8,
		UoWSetSecurityDescriptor = 9,
		UoWRenameSubKey = 10,
		UoWRenameOldSubKey = 11,
		UoWRenameNewSubKey = 12,
		UoWIsolation = 13,
		UoWInvalid = 14
	}
	public enum HSTORAGE_TYPE
	{
		Stable = 0,
		Volatile = 1,
		InvalidStorage = 2
	}
	public enum _CMP_FAILURE_INJECTION_POINT
	{
		CmpFailurePointPoolAllocation = 0,
		CmpFailurePointViewMapping = 1,
		CmpFailurePointViewPinning = 2,
		CmpFailurePointResourceCharging = 3,
		CmpFailurePointFileWrite = 4,
		CmpFailurePointFileRead = 5,
		CmpFailurePointCacheFlush = 6,
		CmpFailurePointFlush = 7,
		CmpFailurePointFlushAndPurge = 8,
		CmpFailurePointForceLargeBin = 9,
		CmpFailurePointDontFixAlignment = 10,
		CmpFailurePointAllocateCell = 11,
		CmpFailurePointMarkDirty = 12,
		CmpFailurePointAllocateKcb = 13,
		CmpFailurePointCreateKeyBody = 14,
		CmpFailurePointForcePoolAllocateKcb = 15,
		CmpFailurePointForceFreeKcb = 16,
		CmpFailureInjectionPointCount = 17
	}
	public enum _PCW_CALLBACK_TYPE
	{
		PcwCallbackAddCounter = 0,
		PcwCallbackRemoveCounter = 1,
		PcwCallbackEnumerateInstances = 2,
		PcwCallbackCollectData = 3
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
		DeviceNodeDeleted = 788,
		MaxDeviceNodeState = 789
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
		Vmcs = 16,
		ACPIBus = 17,
		MaximumInterfaceType = 18
	}
	public enum PROFILE_STATUS
	{
		DOCK_NOTDOCKDEVICE = 0,
		DOCK_QUIESCENT = 1,
		DOCK_ARRIVING = 2,
		DOCK_DEPARTING = 3,
		DOCK_EJECTIRP_COMPLETED = 4
	}
	public enum _TOKEN_INFORMATION_CLASS
	{
		TokenUser = 1,
		TokenGroups = 2,
		TokenPrivileges = 3,
		TokenOwner = 4,
		TokenPrimaryGroup = 5,
		TokenDefaultDacl = 6,
		TokenSource = 7,
		TokenType = 8,
		TokenImpersonationLevel = 9,
		TokenStatistics = 10,
		TokenRestrictedSids = 11,
		TokenSessionId = 12,
		TokenGroupsAndPrivileges = 13,
		TokenSessionReference = 14,
		TokenSandBoxInert = 15,
		TokenAuditPolicy = 16,
		TokenOrigin = 17,
		TokenElevationType = 18,
		TokenLinkedToken = 19,
		TokenElevation = 20,
		TokenHasRestrictions = 21,
		TokenAccessInformation = 22,
		TokenVirtualizationAllowed = 23,
		TokenVirtualizationEnabled = 24,
		TokenIntegrityLevel = 25,
		TokenUIAccess = 26,
		TokenMandatoryPolicy = 27,
		TokenLogonSid = 28,
		TokenIsAppContainer = 29,
		TokenCapabilities = 30,
		TokenAppContainerSid = 31,
		TokenAppContainerNumber = 32,
		TokenUserClaimAttributes = 33,
		TokenDeviceClaimAttributes = 34,
		TokenRestrictedUserClaimAttributes = 35,
		TokenRestrictedDeviceClaimAttributes = 36,
		TokenDeviceGroups = 37,
		TokenRestrictedDeviceGroups = 38,
		TokenSecurityAttributes = 39,
		TokenIsRestricted = 40,
		TokenProcessTrustLevel = 41,
		TokenPrivateNameSpace = 42,
		TokenSingletonAttributes = 43,
		TokenBnoIsolation = 44,
		MaxTokenInfoClass = 45
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
	public enum _POWER_REQUEST_TYPE
	{
		PowerRequestDisplayRequired = 0,
		PowerRequestSystemRequired = 1,
		PowerRequestAwayModeRequired = 2,
		PowerRequestExecutionRequired = 3
	}
	public enum _POWER_REQUEST_TYPE_INTERNAL
	{
		PowerRequestDisplayRequiredInternal = 0,
		PowerRequestSystemRequiredInternal = 1,
		PowerRequestAwayModeRequiredInternal = 2,
		PowerRequestExecutionRequiredInternal = 3,
		PowerRequestPerfBoostRequiredInternal = 4,
		PowerRequestActiveLockScreenInternal = 5,
		PowerRequestInternalInvalid = 6
	}
	public enum _PEP_ACPI_RESOURCE_TYPE
	{
		PepAcpiMemory = 0,
		PepAcpiIoPort = 1,
		PepAcpiInterrupt = 2,
		PepAcpiGpioIo = 3,
		PepAcpiGpioInt = 4,
		PepAcpiSpbI2c = 5,
		PepAcpiSpbSpi = 6,
		PepAcpiSpbUart = 7,
		PepAcpiExtendedMemory = 8,
		PepAcpiExtendedIo = 9
	}
	public enum _KINTERRUPT_MODE
	{
		LevelSensitive = 0,
		Latched = 1
	}
	public enum _KINTERRUPT_POLARITY
	{
		InterruptPolarityUnknown = 0,
		InterruptActiveHigh = 1,
		InterruptRisingEdge = 1,
		InterruptActiveLow = 2,
		InterruptFallingEdge = 2,
		InterruptActiveBoth = 3,
		InterruptActiveBothTriggerLow = 3,
		InterruptActiveBothTriggerHigh = 4
	}
	public enum _GPIO_PIN_CONFIG_TYPE
	{
		PullDefault = 0,
		PullUp = 1,
		PullDown = 2,
		PullNone = 3
	}
	public enum _GPIO_PIN_IORESTRICTION_TYPE
	{
		IoRestrictionNone = 0,
		IoRestrictionInputOnly = 1,
		IoRestrictionOutputOnly = 2,
		IoRestrictionNoneAndPreserve = 3
	}
	public enum SYSTEM_POWER_CONDITION
	{
		PoAc = 0,
		PoDc = 1,
		PoHot = 2,
		PoConditionMaximum = 3
	}
	public enum _SERVERSILO_STATE
	{
		SERVERSILO_INITING = 0,
		SERVERSILO_STARTED = 1,
		SERVERSILO_SHUTTING_DOWN = 2,
		SERVERSILO_TERMINATING = 3,
		SERVERSILO_TERMINATED = 4
	}
	public enum _HEAP_FAILURE_TYPE
	{
		heap_failure_internal = 0,
		heap_failure_unknown = 1,
		heap_failure_generic = 2,
		heap_failure_entry_corruption = 3,
		heap_failure_multiple_entries_corruption = 4,
		heap_failure_virtual_block_corruption = 5,
		heap_failure_buffer_overrun = 6,
		heap_failure_buffer_underrun = 7,
		heap_failure_block_not_busy = 8,
		heap_failure_invalid_argument = 9,
		heap_failure_usage_after_free = 10,
		heap_failure_cross_heap_operation = 11,
		heap_failure_freelists_corruption = 12,
		heap_failure_listentry_corruption = 13,
		heap_failure_lfh_bitmap_mismatch = 14,
		heap_failure_segment_lfh_bitmap_corruption = 15,
		heap_failure_segment_lfh_double_free = 16,
		heap_failure_vs_subsegment_corruption = 17,
		heap_failure_null_heap = 18
	}
	public enum _BLOB_ID
	{
		BLOB_TYPE_UNKNOWN = 0,
		BLOB_TYPE_CONNECTION_INFO = 1,
		BLOB_TYPE_MESSAGE = 2,
		BLOB_TYPE_SECURITY_CONTEXT = 3,
		BLOB_TYPE_SECTION = 4,
		BLOB_TYPE_REGION = 5,
		BLOB_TYPE_VIEW = 6,
		BLOB_TYPE_RESERVE = 7,
		BLOB_TYPE_DIRECT_TRANSFER = 8,
		BLOB_TYPE_HANDLE_DATA = 9,
		BLOB_TYPE_MAX_ID = 10
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
		WrSpare0 = 14,
		WrQueue = 15,
		WrLpcReceive = 16,
		WrLpcReply = 17,
		WrVirtualMemory = 18,
		WrPageOut = 19,
		WrRendezvous = 20,
		WrKeyedEvent = 21,
		WrTerminated = 22,
		WrProcessInSwap = 23,
		WrCpuRateControl = 24,
		WrCalloutStack = 25,
		WrKernel = 26,
		WrResource = 27,
		WrPushLock = 28,
		WrMutex = 29,
		WrQuantumEnd = 30,
		WrDispatchInt = 31,
		WrPreempted = 32,
		WrYieldExecution = 33,
		WrFastMutex = 34,
		WrGuardedMutex = 35,
		WrRundown = 36,
		WrAlertByThreadId = 37,
		WrDeferredPreempt = 38,
		MaximumWaitReason = 39
	}
	public enum _EX_POOL_PRIORITY
	{
		LowPoolPriority = 0,
		LowPoolPrioritySpecialPoolOverrun = 8,
		LowPoolPrioritySpecialPoolUnderrun = 9,
		NormalPoolPriority = 16,
		NormalPoolPrioritySpecialPoolOverrun = 24,
		NormalPoolPrioritySpecialPoolUnderrun = 25,
		HighPoolPriority = 32,
		HighPoolPrioritySpecialPoolOverrun = 40,
		HighPoolPrioritySpecialPoolUnderrun = 41
	}
	public enum _LOCK_OPERATION
	{
		IoReadAccess = 0,
		IoWriteAccess = 1,
		IoModifyAccess = 2
	}
	public enum _IOP_PRIORITY_HINT
	{
		IopIoPriorityNotSet = 0,
		IopIoPriorityVeryLow = 1,
		IopIoPriorityLow = 2,
		IopIoPriorityNormal = 3,
		IopIoPriorityHigh = 4,
		IopIoPriorityCritical = 5,
		MaxIopIoPriorityTypes = 6
	}
	public enum _TRANSFER_TYPE
	{
		ReadTransfer = 0,
		WriteTransfer = 1,
		OtherTransfer = 2
	}
	public enum _CREATE_FILE_TYPE
	{
		CreateFileTypeNone = 0,
		CreateFileTypeNamedPipe = 1,
		CreateFileTypeMailslot = 2
	}
	public enum _ETW_BUFFER_STATE
	{
		EtwBufferStateFree = 0,
		EtwBufferStateGeneralLogging = 1,
		EtwBufferStateCSwitch = 2,
		EtwBufferStateFlush = 3,
		EtwBufferStatePendingCompression = 4,
		EtwBufferStateCompressed = 5,
		EtwBufferStatePlaceholder = 6,
		EtwBufferStateMaximum = 7
	}
	public enum _ETW_RT_EVENT_LOSS
	{
		EtwRtEventNoLoss = 0,
		EtwRtEventLost = 1,
		EtwRtBufferLost = 2,
		EtwRtBackupLost = 3,
		EtwRtEventLossMax = 4
	}
	public enum _ETW_PERIODIC_TIMER_STATE
	{
		EtwpPeriodicTimerUnset = 0,
		EtwpPeriodicTimerSet = 1
	}
	public enum ETW_COMPRESSION_RESUMPTION_MODE
	{
		EtwCompressionModeRestart = 0,
		EtwCompressionModeNoDisable = 1,
		EtwCompressionModeNoRestart = 2
	}
	public enum _KPROFILE_SOURCE
	{
		ProfileTime = 0,
		ProfileAlignmentFixup = 1,
		ProfileTotalIssues = 2,
		ProfilePipelineDry = 3,
		ProfileLoadInstructions = 4,
		ProfilePipelineFrozen = 5,
		ProfileBranchInstructions = 6,
		ProfileTotalNonissues = 7,
		ProfileDcacheMisses = 8,
		ProfileIcacheMisses = 9,
		ProfileCacheMisses = 10,
		ProfileBranchMispredictions = 11,
		ProfileStoreInstructions = 12,
		ProfileFpInstructions = 13,
		ProfileIntegerInstructions = 14,
		Profile2Issue = 15,
		Profile3Issue = 16,
		Profile4Issue = 17,
		ProfileSpecialInstructions = 18,
		ProfileTotalCycles = 19,
		ProfileIcacheIssues = 20,
		ProfileDcacheAccesses = 21,
		ProfileMemoryBarrierCycles = 22,
		ProfileLoadLinkedIssues = 23,
		ProfileMaximum = 24
	}
	public enum _TOKEN_TYPE
	{
		TokenPrimary = 1,
		TokenImpersonation = 2
	}
	public enum _SECURITY_IMPERSONATION_LEVEL
	{
		SecurityAnonymous = 0,
		SecurityIdentification = 1,
		SecurityImpersonation = 2,
		SecurityDelegation = 3
	}
	public enum _IO_RATE_CONTROL_TYPE
	{
		IoRateControlTypeCapMin = 0,
		IoRateControlTypeIopsCap = 0,
		IoRateControlTypeBandwidthCap = 1,
		IoRateControlTypeTimePercentCap = 2,
		IoRateControlTypeCapMax = 2,
		IoRateControlTypeReservationMin = 3,
		IoRateControlTypeIopsReservation = 3,
		IoRateControlTypeBandwidthReservation = 4,
		IoRateControlTypeTimePercentReservation = 5,
		IoRateControlTypeReservationMax = 5,
		IoRateControlTypeCriticalReservationMin = 6,
		IoRateControlTypeIopsCriticalReservation = 6,
		IoRateControlTypeBandwidthCriticalReservation = 7,
		IoRateControlTypeTimePercentCriticalReservation = 8,
		IoRateControlTypeCriticalReservationMax = 8,
		IoRateControlTypeSoftCapMin = 9,
		IoRateControlTypeIopsSoftCap = 9,
		IoRateControlTypeBandwidthSoftCap = 10,
		IoRateControlTypeTimePercentSoftCap = 11,
		IoRateControlTypeSoftCapMax = 11,
		IoRateControlTypeLimitExcessNotifyMin = 12,
		IoRateControlTypeIopsLimitExcessNotify = 12,
		IoRateControlTypeBandwidthLimitExcessNotify = 13,
		IoRateControlTypeTimePercentLimitExcessNotify = 14,
		IoRateControlTypeLimitExcessNotifyMax = 14,
		IoRateControlTypeMax = 15
	}
	public enum _JOBOBJECTINFOCLASS
	{
		JobObjectBasicAccountingInformation = 1,
		JobObjectBasicLimitInformation = 2,
		JobObjectBasicProcessIdList = 3,
		JobObjectBasicUIRestrictions = 4,
		JobObjectSecurityLimitInformation = 5,
		JobObjectEndOfJobTimeInformation = 6,
		JobObjectAssociateCompletionPortInformation = 7,
		JobObjectBasicAndIoAccountingInformation = 8,
		JobObjectExtendedLimitInformation = 9,
		JobObjectJobSetInformation = 10,
		JobObjectGroupInformation = 11,
		JobObjectNotificationLimitInformation = 12,
		JobObjectLimitViolationInformation = 13,
		JobObjectGroupInformationEx = 14,
		JobObjectCpuRateControlInformation = 15,
		JobObjectCompletionFilter = 16,
		JobObjectCompletionCounter = 17,
		JobObjectFreezeInformation = 18,
		JobObjectExtendedAccountingInformation = 19,
		JobObjectWakeInformation = 20,
		JobObjectBackgroundInformation = 21,
		JobObjectSchedulingRankBiasInformation = 22,
		JobObjectTimerVirtualizationInformation = 23,
		JobObjectCycleTimeNotification = 24,
		JobObjectClearEvent = 25,
		JobObjectInterferenceInformation = 26,
		JobObjectClearPeakJobMemoryUsed = 27,
		JobObjectMemoryUsageInformation = 28,
		JobObjectSharedCommit = 29,
		JobObjectContainerId = 30,
		JobObjectIoRateControlInformation = 31,
		JobObjectSiloRootDirectory = 37,
		JobObjectServerSiloBasicInformation = 38,
		JobObjectServerSiloUserSharedData = 39,
		JobObjectServerSiloInitialize = 40,
		JobObjectServerSiloRunningState = 41,
		JobObjectIoAttribution = 42,
		JobObjectMemoryPartitionInformation = 43,
		JobObjectContainerTelemetryId = 44,
		JobObjectSiloSystemRoot = 45,
		JobObjectEnergyTrackingState = 46,
		JobObjectThreadImpersonationInformation = 47,
		JobObjectReserved1Information = 18,
		JobObjectReserved2Information = 19,
		JobObjectReserved3Information = 20,
		JobObjectReserved4Information = 21,
		JobObjectReserved5Information = 22,
		JobObjectReserved6Information = 23,
		JobObjectReserved7Information = 24,
		JobObjectReserved8Information = 25,
		JobObjectReserved9Information = 26,
		JobObjectReserved10Information = 27,
		JobObjectReserved11Information = 28,
		JobObjectReserved12Information = 29,
		JobObjectReserved13Information = 30,
		JobObjectReserved14Information = 31,
		JobObjectNetRateControlInformation = 32,
		JobObjectNotificationLimitInformation2 = 33,
		JobObjectLimitViolationInformation2 = 34,
		JobObjectCreateSilo = 35,
		JobObjectSiloBasicInformation = 36,
		JobObjectReserved15Information = 37,
		JobObjectReserved16Information = 38,
		JobObjectReserved17Information = 39,
		JobObjectReserved18Information = 40,
		JobObjectReserved19Information = 41,
		JobObjectReserved20Information = 42,
		JobObjectReserved21Information = 43,
		JobObjectReserved22Information = 44,
		JobObjectReserved23Information = 45,
		JobObjectReserved24Information = 46,
		JobObjectReserved25Information = 47,
		MaxJobObjectInfoClass = 48
	}
	public enum _OBJECT_INFORMATION_CLASS
	{
		ObjectBasicInformation = 0,
		ObjectNameInformation = 1,
		ObjectTypeInformation = 2,
		ObjectTypesInformation = 3,
		ObjectHandleFlagInformation = 4,
		ObjectSessionInformation = 5,
		ObjectSessionObjectInformation = 6,
		MaxObjectInfoClass = 7
	}
	public enum PPM_IDLE_BUCKET_TIME_TYPE
	{
		PpmIdleBucketTimeInQpc = 0,
		PpmIdleBucketTimeIn100ns = 1,
		PpmIdleBucketTimeMaximum = 2
	}
	public enum _FILE_OBJECT_EXTENSION_TYPE
	{
		FoExtTypeTransactionParams = 0,
		FoExtTypeInternal = 1,
		FoExtTypeIosbRange = 2,
		FoExtTypeGeneric = 3,
		FoExtTypeSfio = 4,
		FoExtTypeSymlink = 5,
		FoExtTypeOplockKey = 6,
		FoExtTypeSilo = 7,
		MaxFoExtTypes = 8
	}
	public enum _IO_SESSION_STATE
	{
		IoSessionStateCreated = 1,
		IoSessionStateInitialized = 2,
		IoSessionStateConnected = 3,
		IoSessionStateDisconnected = 4,
		IoSessionStateDisconnectedLoggedOn = 5,
		IoSessionStateLoggedOn = 6,
		IoSessionStateLoggedOff = 7,
		IoSessionStateTerminated = 8,
		IoSessionStateMax = 9
	}
	public enum _PROCESS_SECTION_TYPE
	{
		ProcessSectionData = 0,
		ProcessSectionImage = 1,
		ProcessSectionImageNx = 2,
		ProcessSectionPagefileBacked = 3,
		ProcessSectionMax = 4
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
	public enum _MM_POOL_TYPES
	{
		MmNonPagedPool = 0,
		MmPagedPool = 1,
		MmSessionPagedPool = 2,
		MmMaximumPoolType = 3
	}
	public enum _DEVPROP_OPERATOR
	{
		DEVPROP_OPERATOR_MODIFIER_NOT = 65536,
		DEVPROP_OPERATOR_MODIFIER_IGNORE_CASE = 131072,
		DEVPROP_OPERATOR_NONE = 0,
		DEVPROP_OPERATOR_EXISTS = 1,
		DEVPROP_OPERATOR_NOT_EXISTS = 65537,
		DEVPROP_OPERATOR_EQUALS = 2,
		DEVPROP_OPERATOR_NOT_EQUALS = 65538,
		DEVPROP_OPERATOR_GREATER_THAN = 3,
		DEVPROP_OPERATOR_LESS_THAN = 4,
		DEVPROP_OPERATOR_GREATER_THAN_EQUALS = 5,
		DEVPROP_OPERATOR_LESS_THAN_EQUALS = 6,
		DEVPROP_OPERATOR_EQUALS_IGNORE_CASE = 131074,
		DEVPROP_OPERATOR_NOT_EQUALS_IGNORE_CASE = 196610,
		DEVPROP_OPERATOR_BITWISE_AND = 7,
		DEVPROP_OPERATOR_BITWISE_OR = 8,
		DEVPROP_OPERATOR_BEGINS_WITH = 9,
		DEVPROP_OPERATOR_ENDS_WITH = 10,
		DEVPROP_OPERATOR_CONTAINS = 11,
		DEVPROP_OPERATOR_BEGINS_WITH_IGNORE_CASE = 131081,
		DEVPROP_OPERATOR_ENDS_WITH_IGNORE_CASE = 131082,
		DEVPROP_OPERATOR_CONTAINS_IGNORE_CASE = 131083,
		DEVPROP_OPERATOR_LIST_CONTAINS = 4096,
		DEVPROP_OPERATOR_LIST_ELEMENT_BEGINS_WITH = 8192,
		DEVPROP_OPERATOR_LIST_ELEMENT_ENDS_WITH = 12288,
		DEVPROP_OPERATOR_LIST_ELEMENT_CONTAINS = 16384,
		DEVPROP_OPERATOR_LIST_CONTAINS_IGNORE_CASE = 135168,
		DEVPROP_OPERATOR_LIST_ELEMENT_BEGINS_WITH_IGNORE_CASE = 139264,
		DEVPROP_OPERATOR_LIST_ELEMENT_ENDS_WITH_IGNORE_CASE = 143360,
		DEVPROP_OPERATOR_LIST_ELEMENT_CONTAINS_IGNORE_CASE = 147456,
		DEVPROP_OPERATOR_AND_OPEN = 1048576,
		DEVPROP_OPERATOR_AND_CLOSE = 2097152,
		DEVPROP_OPERATOR_OR_OPEN = 3145728,
		DEVPROP_OPERATOR_OR_CLOSE = 4194304,
		DEVPROP_OPERATOR_NOT_OPEN = 5242880,
		DEVPROP_OPERATOR_NOT_CLOSE = 6291456,
		DEVPROP_OPERATOR_ARRAY_CONTAINS = 268435456,
		DEVPROP_OPERATOR_MASK_EVAL = 4095,
		DEVPROP_OPERATOR_MASK_LIST = 61440,
		DEVPROP_OPERATOR_MASK_MODIFIER = 983040,
		DEVPROP_OPERATOR_MASK_NOT_LOGICAL = -267386881,
		DEVPROP_OPERATOR_MASK_LOGICAL = 267386880,
		DEVPROP_OPERATOR_MASK_ARRAY = -268435456
	}
	public enum _KWAIT_BLOCK_STATE
	{
		WaitBlockBypassStart = 0,
		WaitBlockBypassComplete = 1,
		WaitBlockSuspendBypassStart = 2,
		WaitBlockSuspendBypassComplete = 3,
		WaitBlockActive = 4,
		WaitBlockInactive = 5,
		WaitBlockSuspended = 6,
		WaitBlockAllStates = 7
	}
	public enum _WHEA_ERROR_SOURCE_STATE
	{
		WheaErrSrcStateStopped = 1,
		WheaErrSrcStateStarted = 2
	}
	public enum _VI_DEADLOCK_RESOURCE_TYPE
	{
		VfDeadlockUnknown = 0,
		VfDeadlockMutex = 1,
		VfDeadlockMutexAbandoned = 2,
		VfDeadlockFastMutex = 3,
		VfDeadlockFastMutexUnsafe = 4,
		VfDeadlockSpinLock = 5,
		VfDeadlockInStackQueuedSpinLock = 6,
		VfDeadlockUnusedSpinLock = 7,
		VfDeadlockEresource = 8,
		VfDeadlockTypeMaximum = 9
	}
	public enum _POWER_INFORMATION_LEVEL_INTERNAL
	{
		PowerInternalAcpiInterfaceRegister = 0,
		PowerInternalS0LowPowerIdleInfo = 1,
		PowerInternalReapplyBrightnessSettings = 2,
		PowerInternalUserAbsencePrediction = 3,
		PowerInternalUserAbsencePredictionCapability = 4,
		PowerInternalPoProcessorLatencyHint = 5,
		PowerInternalStandbyNetworkRequest = 6,
		PowerInternalDirtyTransitionInformation = 7,
		PowerInternalSetBackgroundTaskState = 8,
		PowerInternalTtmOpenTerminal = 9,
		PowerInformationInternalTtmFirst = 9,
		PowerInternalTtmCreateTerminal = 10,
		PowerInternalTtmEvacuateDevices = 11,
		PowerInternalTtmCreateTerminalEventQueue = 12,
		PowerInternalTtmGetTerminalEvent = 13,
		PowerInternalTtmSetDefaultDeviceAssignment = 14,
		PowerInternalTtmAssignDevice = 15,
		PowerInternalTtmSetDisplayState = 16,
		PowerInternalTtmSetDisplayTimeouts = 17,
		PowerInformationInternalTtmLast = 17,
		PowerInternalBootSessionStandbyActivationInformation = 18,
		PowerInternalSessionPowerState = 19,
		PowerInternalSessionTerminalInput = 20,
		PowerInternalSetWatchdog = 21,
		PowerInternalPhysicalPowerButtonPressInfoAtBoot = 22,
		PowerInternalExternalMonitorConnected = 23,
		PowerInternalHighPrecisionBrightnessSettings = 24,
		PowerInternalWinrtScreenToggle = 25,
		PowerInternalVirtualHeterogeneityDisable = 26,
		PowerInternalTransitionCheckpoint = 27,
		PowerInternalInputControllerState = 28,
		PowerInternalFirmwareResetReason = 29,
		PowerInternalVirtualHeterogeneitySupport = 30,
		PowerInformationInternalMaximum = 31
	}
	public enum _KHETERO_CPU_POLICY
	{
		KHeteroCpuPolicyAll = 0,
		KHeteroCpuPolicyLarge = 1,
		KHeteroCpuPolicyLargeOrIdle = 2,
		KHeteroCpuPolicySmall = 3,
		KHeteroCpuPolicySmallOrIdle = 4,
		KHeteroCpuPolicyDynamic = 5,
		KHeteroCpuPolicyStaticMax = 5,
		KHeteroCpuPolicyBiasedSmall = 6,
		KHeteroCpuPolicyBiasedLarge = 7,
		KHeteroCpuPolicyDefault = 8,
		KHeteroCpuPolicyMax = 9
	}
	public enum _POP_SLEEP_CHECKPOINT
	{
		PopSleepCheckpointInvalid = 0,
		PopSleepCheckpointPowerTransitionStart = 1,
		PopSleepCheckpointSuspendAppsBefore = 2,
		PopSleepCheckpointSuspendAppsAfter = 3,
		PopSleepCheckpointSuspendServicesBefore = 4,
		PopSleepCheckpointSuspendServicesAfter = 5,
		PopSleepCheckpointNotifySuperfetchBefore = 6,
		PopSleepCheckpointNotifySuperfetchAfter = 7,
		PopSleepCheckpointNotifyCallbacksBefore = 8,
		PopSleepCheckpointNotifyCallbacksAfter = 9,
		PopSleepCheckpointSleepTransactionCommitted = 10,
		PopSleepCheckpointQueryDriversBefore = 11,
		PopSleepCheckpointQueryDriversAfter = 12,
		PopSleepCheckpointAllocatingHiberContext = 13,
		PopSleepCheckpointSuspendDriversBefore = 14,
		PopSleepCheckpointPreSleepNotification = 16,
		PopSleepCheckpointInterruptsDisabledBegin = 17,
		PopSleepCheckpointInvokeHandlerBefore = 18,
		PopSleepCheckpointSaveHiberContextBegin = 19,
		PopSleepCheckpointInitializeDumpStackFailed = 20,
		PopSleepCheckpointHiberWriteFailed = 21,
		PopSleepCheckpointHiberFileTooSmall = 22,
		PopSleepCheckpointSaveHiberContextFailed = 23,
		PopSleepCheckpointSaveHiberContextEnd = 24,
		PopSleepCheckpointHiberKernelHandoff = 25,
		PopSleepCheckpointInvokeHandlerAfter = 26,
		PopSleepCheckpointReadHiberfileBefore = 27,
		PopSleepCheckpointInitializeDumpStackForReadFailed = 28,
		PopSleepCheckpointHiberReadFailed = 29,
		PopSleepCheckpointChecksumFailure = 30,
		PopSleepCheckpointDecompressionFailed = 31,
		PopSleepCheckpointReadHiberfileAfter = 32,
		PopSleepCheckpointInterruptsDisabledEnd = 33,
		PopSleepCheckpointWakeDriversAfter = 36,
		PopSleepCheckpointResumeAppsBefore = 37,
		PopSleepCheckpointResumeAppsAfter = 38,
		PopSleepCheckpointResumeServicesBefore = 39,
		PopSleepCheckpointResumeServicesAfter = 40,
		PopSleepCheckpointPowerTransitionEnd = 41,
		PopSleepCheckpointMaximum = 42
	}
	public enum _MI_MEMORY_EVENT_TYPES
	{
		LowPagedPoolEvent = 0,
		HighPagedPoolEvent = 1,
		LowNonPagedPoolEvent = 2,
		HighNonPagedPoolEvent = 3,
		LowAvailablePagesEvent = 4,
		HighAvailablePagesEvent = 5,
		LowCommitEvent = 6,
		HighCommitEvent = 7,
		MaximumCommitEvent = 8,
		BadMemoryDetectedEvent = 9,
		PhysicalMemoryChangeEvent = 10,
		TotalNumberOfMemoryEvents = 11
	}
	public enum JOB_OBJECT_IO_RATE_CONTROL_FLAGS
	{
		JOB_OBJECT_IO_RATE_CONTROL_ENABLE = 1,
		JOB_OBJECT_IO_RATE_CONTROL_STANDALONE_VOLUME = 2,
		JOB_OBJECT_IO_RATE_CONTROL_VALID_FLAGS = 3
	}
	public enum _KOBJECTS
	{
		EventNotificationObject = 0,
		EventSynchronizationObject = 1,
		MutantObject = 2,
		ProcessObject = 3,
		QueueObject = 4,
		SemaphoreObject = 5,
		ThreadObject = 6,
		GateObject = 7,
		TimerNotificationObject = 8,
		TimerSynchronizationObject = 9,
		Spare2Object = 10,
		Spare3Object = 11,
		Spare4Object = 12,
		Spare5Object = 13,
		Spare6Object = 14,
		Spare7Object = 15,
		Spare8Object = 16,
		ProfileCallbackObject = 17,
		ApcObject = 18,
		DpcObject = 19,
		DeviceQueueObject = 20,
		PriQueueObject = 21,
		InterruptObject = 22,
		ProfileObject = 23,
		Timer2NotificationObject = 24,
		Timer2SynchronizationObject = 25,
		ThreadedDpcObject = 26,
		MaximumKernelObject = 27
	}
	public enum TlgIn_t
	{
		TlgInNULL = 0,
		TlgInUNICODESTRING = 1,
		TlgInANSISTRING = 2,
		TlgInINT8 = 3,
		TlgInUINT8 = 4,
		TlgInINT16 = 5,
		TlgInUINT16 = 6,
		TlgInINT32 = 7,
		TlgInUINT32 = 8,
		TlgInINT64 = 9,
		TlgInUINT64 = 10,
		TlgInFLOAT = 11,
		TlgInDOUBLE = 12,
		TlgInBOOL32 = 13,
		TlgInBINARY = 14,
		TlgInGUID = 15,
		_TlgInPOINTER_unsupported = 16,
		TlgInFILETIME = 17,
		TlgInSYSTEMTIME = 18,
		TlgInSID = 19,
		TlgInHEXINT32 = 20,
		TlgInHEXINT64 = 21,
		TlgInCOUNTEDSTRING = 22,
		TlgInCOUNTEDANSISTRING = 23,
		_TlgInSTRUCT = 24,
		_TlgInMax = 25,
		TlgInINTPTR = 9,
		TlgInUINTPTR = 10,
		TlgInPOINTER = 21,
		_TlgInCcount = 32,
		TlgInVcount = 64,
		_TlgInChain = 128,
		_TlgInCustom = 96,
		_TlgInTypeMask = 31,
		_TlgInCountMask = 96,
		_TlgInFlagMask = 224
	}
	public enum _PS_STD_HANDLE_STATE
	{
		PsNeverDuplicate = 0,
		PsRequestDuplicate = 1,
		PsAlwaysDuplicate = 2,
		PsMaxStdHandleStates = 3
	}
	public enum _PS_WAKE_REASON
	{
		PsWakeReasonUser = 0,
		PsWakeReasonExecutionRequired = 1,
		PsWakeReasonKernel = 2,
		PsWakeReasonInstrumentation = 3,
		PsWakeReasonPreserveProcess = 4,
		PsWakeReasonActivityReference = 5,
		PsWakeReasonWorkOnBehalf = 6,
		PsMaxWakeReasons = 7
	}
	public enum _HARDWARE_COUNTER_TYPE
	{
		PMCCounter = 0,
		MaxHardwareCounterType = 1
	}
	public enum _REG_NOTIFY_CLASS
	{
		RegNtDeleteKey = 0,
		RegNtPreDeleteKey = 0,
		RegNtSetValueKey = 1,
		RegNtPreSetValueKey = 1,
		RegNtDeleteValueKey = 2,
		RegNtPreDeleteValueKey = 2,
		RegNtSetInformationKey = 3,
		RegNtPreSetInformationKey = 3,
		RegNtRenameKey = 4,
		RegNtPreRenameKey = 4,
		RegNtEnumerateKey = 5,
		RegNtPreEnumerateKey = 5,
		RegNtEnumerateValueKey = 6,
		RegNtPreEnumerateValueKey = 6,
		RegNtQueryKey = 7,
		RegNtPreQueryKey = 7,
		RegNtQueryValueKey = 8,
		RegNtPreQueryValueKey = 8,
		RegNtQueryMultipleValueKey = 9,
		RegNtPreQueryMultipleValueKey = 9,
		RegNtPreCreateKey = 10,
		RegNtPostCreateKey = 11,
		RegNtPreOpenKey = 12,
		RegNtPostOpenKey = 13,
		RegNtKeyHandleClose = 14,
		RegNtPreKeyHandleClose = 14,
		RegNtPostDeleteKey = 15,
		RegNtPostSetValueKey = 16,
		RegNtPostDeleteValueKey = 17,
		RegNtPostSetInformationKey = 18,
		RegNtPostRenameKey = 19,
		RegNtPostEnumerateKey = 20,
		RegNtPostEnumerateValueKey = 21,
		RegNtPostQueryKey = 22,
		RegNtPostQueryValueKey = 23,
		RegNtPostQueryMultipleValueKey = 24,
		RegNtPostKeyHandleClose = 25,
		RegNtPreCreateKeyEx = 26,
		RegNtPostCreateKeyEx = 27,
		RegNtPreOpenKeyEx = 28,
		RegNtPostOpenKeyEx = 29,
		RegNtPreFlushKey = 30,
		RegNtPostFlushKey = 31,
		RegNtPreLoadKey = 32,
		RegNtPostLoadKey = 33,
		RegNtPreUnLoadKey = 34,
		RegNtPostUnLoadKey = 35,
		RegNtPreQueryKeySecurity = 36,
		RegNtPostQueryKeySecurity = 37,
		RegNtPreSetKeySecurity = 38,
		RegNtPostSetKeySecurity = 39,
		RegNtCallbackObjectContextCleanup = 40,
		RegNtPreRestoreKey = 41,
		RegNtPostRestoreKey = 42,
		RegNtPreSaveKey = 43,
		RegNtPostSaveKey = 44,
		RegNtPreReplaceKey = 45,
		RegNtPostReplaceKey = 46,
		RegNtPreQueryKeyName = 47,
		RegNtPostQueryKeyName = 48,
		MaxRegNtNotifyClass = 49
	}
	public enum _MM_POOL_PRIORITIES
	{
		MmHighPriority = 0,
		MmNormalPriority = 1,
		MmLowPriority = 2,
		MmMaximumPoolPriority = 3
	}
	public enum _KTHREAD_TAG
	{
		KThreadTagNone = 0,
		KThreadTagMediaBuffering = 1,
		KThreadTagMax = 2
	}
	public enum _ETW_PERFECT_HASH_FUNCTION_TYPE
	{
		ETW_PHF_EVENT_ID = 0,
		ETW_PHF_STACK_WALK = 1,
		ETW_PHF_MAX_COUNT = 2
	}
	public enum _TYPE_OF_MEMORY
	{
		LoaderExceptionBlock = 0,
		LoaderSystemBlock = 1,
		LoaderFree = 2,
		LoaderBad = 3,
		LoaderLoadedProgram = 4,
		LoaderFirmwareTemporary = 5,
		LoaderFirmwarePermanent = 6,
		LoaderOsloaderHeap = 7,
		LoaderOsloaderStack = 8,
		LoaderSystemCode = 9,
		LoaderHalCode = 10,
		LoaderBootDriver = 11,
		LoaderConsoleInDriver = 12,
		LoaderConsoleOutDriver = 13,
		LoaderStartupDpcStack = 14,
		LoaderStartupKernelStack = 15,
		LoaderStartupPanicStack = 16,
		LoaderStartupPcrPage = 17,
		LoaderStartupPdrPage = 18,
		LoaderRegistryData = 19,
		LoaderMemoryData = 20,
		LoaderNlsData = 21,
		LoaderSpecialMemory = 22,
		LoaderBBTMemory = 23,
		LoaderZero = 24,
		LoaderXIPRom = 25,
		LoaderHALCachedMemory = 26,
		LoaderLargePageFiller = 27,
		LoaderErrorLogMemory = 28,
		LoaderVsmMemory = 29,
		LoaderFirmwareCode = 30,
		LoaderFirmwareData = 31,
		LoaderFirmwareReserved = 32,
		LoaderEnclaveMemory = 33,
		LoaderFirmwareKsr = 34,
		LoaderEnclaveKsr = 35,
		LoaderMaximum = 36
	}
	public enum _MM_PREEMPTIVE_TRIMS
	{
		MmPreemptForNonPaged = 0,
		MmPreemptForPaged = 1,
		MmPreemptForNonPagedPriority = 2,
		MmPreemptForPagedPriority = 3,
		MmMaximumPreempt = 4
	}
	public enum _KTIMER2_COLLECTION_INDEX
	{
		KTimer2CollectionNoWake = 0,
		KTimer2CollectionHr = 1,
		KTimer2CollectionFinite = 2,
		KTimer2CollectionIr = 3,
		KTimer2CollectionNotInserted = 16,
		KTimer2CollectionInvalid = 20,
		KTimer2CollectionOptional = 32,
		KTimer2CollectionMin = 0,
		KTimer2CollectionMax = 4,
		KTimer2CollectionNode1 = 2
	}
	public enum _PS_PROTECTED_TYPE
	{
		PsProtectedTypeNone = 0,
		PsProtectedTypeProtectedLight = 1,
		PsProtectedTypeProtected = 2,
		PsProtectedTypeMax = 3
	}
	public enum _MI_CFG_BITMAP_TYPE
	{
		CfgBitMapNative = 0,
		CfgBitMapWow64 = 1,
		CfgBitMapMax = 2
	}
	public enum _PROCESS_VA_TYPE
	{
		ProcessVAImage = 0,
		ProcessVASection = 1,
		ProcessVAPrivate = 2,
		ProcessVAMax = 3
	}
	public enum _PS_RESOURCE_TYPE
	{
		PsResourceNonPagedPool = 0,
		PsResourcePagedPool = 1,
		PsResourcePageFile = 2,
		PsResourceWorkingSet = 3,
		PsResourceMax = 4
	}
	public enum _PERFINFO_KERNELMEMORY_USAGE_TYPE
	{
		PerfInfoMemUsagePfnMetadata = 0,
		PerfInfoMemUsageMax = 1
	}
	public enum _EX_BALANCE_OBJECT
	{
		ExTimerExpiration = 0,
		ExThreadSetManagerEvent = 1,
		ExThreadReaperEvent = 2,
		ExMaximumBalanceObject = 3
	}
	public enum IRPLOCK
	{
		IRPLOCK_CANCELABLE = 0,
		IRPLOCK_CANCEL_STARTED = 1,
		IRPLOCK_CANCEL_COMPLETE = 2,
		IRPLOCK_COMPLETED = 3
	}
	public enum _PNP_DEVICE_DELETE_TYPE
	{
		QueryRemoveDevice = 0,
		CancelRemoveDevice = 1,
		RemoveDevice = 2,
		SurpriseRemoveDevice = 3,
		EjectDevice = 4,
		RemoveFailedDevice = 5,
		RemoveUnstartedFailedDevice = 6,
		MaxDeviceDeleteType = 7
	}
	public enum _IO_ALLOCATION_ACTION
	{
		KeepObject = 1,
		DeallocateObject = 2,
		DeallocateObjectKeepRegisters = 3
	}
	public enum _EXQUEUEINDEX
	{
		ExPoolUntrusted = 0,
		IoPoolUntrusted = 1,
		ExPoolTrusted = 2,
		ExPoolMax = 8
	}
	public enum _MI_MEMORY_HIGHLOW
	{
		MiMemoryHigh = 0,
		MiMemoryLow = 1,
		MiMemoryHighLow = 2
	}
	public enum _PS_PROTECTED_SIGNER
	{
		PsProtectedSignerNone = 0,
		PsProtectedSignerAuthenticode = 1,
		PsProtectedSignerCodeGen = 2,
		PsProtectedSignerAntimalware = 3,
		PsProtectedSignerLsa = 4,
		PsProtectedSignerWindows = 5,
		PsProtectedSignerWinTcb = 6,
		PsProtectedSignerWinSystem = 7,
		PsProtectedSignerApp = 8,
		PsProtectedSignerMax = 9
	}
	public enum POWER_POLICY_DEVICE_TYPE
	{
		PolicyDeviceSystemButton = 0,
		PolicyDeviceThermalZone = 1,
		PolicyDeviceBattery = 2,
		PolicyDeviceMemory = 3,
		PolicyInitiatePowerActionAPI = 4,
		PolicySetPowerStateAPI = 5,
		PolicyImmediateDozeS4 = 6,
		PolicySystemIdle = 7,
		PolicyDeviceWakeAlarm = 8,
		PolicyDeviceFan = 9,
		PolicyCsBatterySaver = 10,
		PolicyImmediateDozeS4Predicted = 11,
		PolicyImmediateDozeS4PredictedNoWake = 12,
		PolicyImmediateDozeS4AdaptiveBudget = 13,
		PolicyImmediateDozeS4AdaptiveReserveNoWake = 14,
		PolicyDeviceMax = 15
	}
	public enum _WORKING_SET_TYPE
	{
		WorkingSetTypeUser = 0,
		WorkingSetTypeSession = 1,
		WorkingSetTypeSystemTypes = 2,
		WorkingSetTypeSystemCache = 2,
		WorkingSetTypePagedPool = 3,
		WorkingSetTypeSystemPtes = 4,
		WorkingSetTypeMaximum = 5
	}
	public enum _ETW_STRING_TOKEN_TYPE
	{
		ETW_STRING_TOKEN_EXE = 0,
		ETW_STRING_TOKEN_PACKAGE_ID = 1,
		ETW_STRING_TOKEN_PKG_APP_ID = 2,
		ETW_STRING_TOKEN_MAX_COUNT = 3
	}
	public enum PS_CREATE_STATE
	{
		PsCreateInitialState = 0,
		PsCreateFailOnFileOpen = 1,
		PsCreateFailOnSectionCreate = 2,
		PsCreateFailExeFormat = 3,
		PsCreateFailMachineMismatch = 4,
		PsCreateFailExeName = 5,
		PsCreateSuccess = 6,
		PsCreateMaximumStates = 7
	}
	public enum _KE_HETERO_SYSTEM
	{
		KeHeteroSystemNone = 0,
		KeHeteroSystemVirtualOff = 1,
		KeHeteroSystemVirtualOn = 2,
		KeHeteroSystemNative = 3,
		KeHeteroSystemMaximum = 4
	}
	public enum _KPROCESS_PPM_POLICY
	{
		ProcessPpmDefault = 0,
		ProcessPpmThrottle = 1,
		ProcessPpmNoThrottle = 2,
		MaxProcessPpmPolicy = 3
	}
	public enum _MEMORY_CACHING_TYPE_ORIG
	{
		MmFrameBufferCached = 2
	}
	public enum _TlgBlob_t
	{
		_TlgBlobNone = 0,
		_TlgBlobEnd = 1,
		_TlgBlobProvider = 2,
		_TlgBlobEvent3 = 3,
		_TlgBlobProvider3 = 4,
		_TlgBlobEvent2 = 5,
		_TlgBlobMax = 6
	}
	public enum _KTHREAD_STATE
	{
		Initialized = 0,
		Ready = 1,
		Running = 2,
		Standby = 3,
		Terminated = 4,
		Waiting = 5,
		Transition = 6,
		DeferredReady = 7,
		GateWaitObsolete = 8,
		WaitingForProcessInSwap = 9
	}
	public enum _MI_DYNAMICBASE_BITMAP
	{
		DynamicBaseBitMap32 = 0,
		DynamicBaseBitMap64Low = 1,
		DynamicBaseBitMap64High = 2,
		DynamicBaseBitMapWow64Dll = 3,
		LastDynamicBaseBitMap = 4
	}
	public enum _MI_NODE_NONPAGED_POOL_BITMAP
	{
		NonPagedPoolLargePdeNx = 0,
		NonPagedPoolSmallPde = 1,
		NonPagedPoolPerPage = 2
	}
	public enum _INTERLOCKED_RESULT
	{
		ResultNegative = 1,
		ResultZero = 0,
		ResultPositive = 2
	}
	public enum _PNP_DEVICE_ACTION_REQUEST
	{
		AssignResources = 0,
		ClearDeviceProblem = 1,
		ClearProblem = 2,
		ClearEjectProblem = 3,
		HaltDevice = 4,
		QueryPowerRelations = 5,
		Rebalance = 6,
		ReenumerateBootDevices = 7,
		ReenumerateDeviceOnly = 8,
		ReenumerateDeviceTree = 9,
		ReenumerateRootDevices = 10,
		RequeryDeviceState = 11,
		ResetDevice = 12,
		ResourceRequirementsChanged = 13,
		RestartEnumeration = 14,
		SetDeviceProblem = 15,
		StartDevice = 16,
		StartSystemDevicesPass0 = 17,
		StartSystemDevicesPass1 = 18,
		NotifyTransportRelationsChange = 19,
		NotifyEjectionRelationsChange = 20,
		ConfigureDevice = 21,
		ConfigureDeviceClass = 22,
		ConfigureDeviceExtensions = 23,
		ConfigureDeviceReset = 24
	}
	public enum _PO_HIBER_FORCE_DISABLE_REASON
	{
		PoHiberForceDisableReasonPolicy = 0,
		PoHiberForceDisableReasonGuardedHost = 1,
		PoHiberForceDisableReasonMax = 2
	}
	public enum _WOW64_SHARED_INFORMATION
	{
		SharedNtdll32LdrInitializeThunk = 0,
		SharedNtdll32KiUserExceptionDispatcher = 1,
		SharedNtdll32KiUserApcDispatcher = 2,
		SharedNtdll32KiUserCallbackDispatcher = 3,
		SharedNtdll32RtlUserThreadStart = 4,
		SharedNtdll32pQueryProcessDebugInformationRemote = 5,
		SharedNtdll32BaseAddress = 6,
		SharedNtdll32LdrSystemDllInitBlock = 7,
		Wow64SharedPageEntriesCount = 8
	}
	public enum _PROCESSOR_CACHE_TYPE
	{
		CacheUnified = 0,
		CacheInstruction = 1,
		CacheData = 2,
		CacheTrace = 3
	}
	public enum _MI_KSTACK_TYPE
	{
		MiRegularKstack = 0,
		MiShortLivedKstack = 1,
		MiMaximumKstack = 2
	}
	public enum _ETW_GUID_TYPE
	{
		EtwTraceGuidType = 0,
		EtwNotificationGuidType = 1,
		EtwGroupGuidType = 2,
		EtwGuidTypeMax = 3
	}
	public enum _KI_CALLBACK
	{
		KiCallbackNmi = 0,
		KiCallbackBound = 1,
		KiCallbackCount = 2,
		KiFirstCallback = 0
	}
	public enum _KWAIT_STATE
	{
		WaitInProgress = 0,
		WaitCommitted = 1,
		WaitAborted = 2,
		WaitSuspendInProgress = 3,
		WaitSuspended = 4,
		WaitResumeInProgress = 5,
		WaitResumeAborted = 6,
		WaitFirstSuspendState = 3,
		WaitLastSuspendState = 6,
		MaximumWaitState = 7
	}
	public enum _MI_SUBVAD_LISTS
	{
		MiSubVadPebTebAny = 0,
		MiSubVadPebTebBelow2gb = 1,
		MiSubVadPebTebBelow4gb = 2,
		MiSubVadRfg = 3,
		MiSubVadMaximum = 4
	}
	public enum _MI_ASSIGNED_REGION_TYPES
	{
		AssignedRegionNonPagedPool = 0,
		AssignedRegionPagedPool = 1,
		AssignedRegionSystemCache = 2,
		AssignedRegionSystemPtes = 3,
		AssignedRegionUltraZero = 4,
		AssignedRegionPfnDatabase = 5,
		AssignedRegionCfg = 6,
		AssignedRegionHyperSpace = 7,
		AssignedRegionPageTables = 8,
		AssignedRegionSpecialPoolPaged = 9,
		AssignedRegionSpecialPoolNonPaged = 10,
		AssignedRegionSession = 11,
		AssignedRegionSystemImages = 12,
		AssignedRegionMaximum = 13
	}
	public enum _MI_WORKING_SET_TYPE
	{
		MiWorkingSetTypeSystemCache = 0,
		MiWorkingSetTypeSystemPtes = 1,
		MiWorkingSetTypePartitionMaximum = 1,
		MiWorkingSetTypePagedPool = 2,
		MiWorkingSetTypeMaximum = 3
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
	public enum _USER_ACTIVITY_PRESENCE
	{
		PowerUserPresent = 0,
		PowerUserNotPresent = 1,
		PowerUserInactive = 2,
		PowerUserMaximum = 3,
		PowerUserInvalid = 3
	}
	public enum _PO_CS_DEVICE_NOTIFICATION_TYPE
	{
		PoCsDeviceNotificationStorage = 0,
		PoCsDeviceNotificationWiFi = 1,
		PoCsDeviceNotificationMbn = 2,
		PoCsDeviceNotificationAudio = 3,
		PoCsDeviceNotificationEthernet = 4,
		PoCsDeviceNotificationMaximum = 5
	}
	public enum _MI_VAD_64K_TYPES
	{
		MiVad64KPrivate = 0,
		MiVad64KShared = 1,
		MiVad64KTypes = 2
	}
	public enum _KPROCESS_STATE
	{
		ProcessInMemory = 0,
		ProcessOutOfMemory = 1,
		ProcessInTransition = 2,
		ProcessOutTransition = 3,
		ProcessInSwap = 4,
		ProcessOutSwap = 5,
		ProcessRetryOutSwap = 6,
		ProcessAllSwapStates = 7
	}
	public enum _KENLISTMENT_STATE
	{
		KEnlistmentUninitialized = 0,
		KEnlistmentActive = 256,
		KEnlistmentPreparing = 257,
		KEnlistmentPrepared = 258,
		KEnlistmentInDoubt = 259,
		KEnlistmentCommitted = 260,
		KEnlistmentCommittedNotify = 261,
		KEnlistmentCommitRequested = 262,
		KEnlistmentAborted = 263,
		KEnlistmentDelegated = 264,
		KEnlistmentDelegatedDisconnected = 265,
		KEnlistmentPrePreparing = 266,
		KEnlistmentForgotten = 267,
		KEnlistmentRecovering = 268,
		KEnlistmentAborting = 269,
		KEnlistmentReadOnly = 270,
		KEnlistmentOutcomeUnavailable = 271,
		KEnlistmentOffline = 272,
		KEnlistmentPrePrepared = 273,
		KEnlistmentInitialized = 274
	}
	public enum TlgOut_t
	{
		TlgOutNULL = 0,
		TlgOutNOPRINT = 1,
		TlgOutSTRING = 2,
		TlgOutBOOLEAN = 3,
		TlgOutHEX = 4,
		TlgOutPID = 5,
		TlgOutTID = 6,
		TlgOutPORT = 7,
		TlgOutIPV4 = 8,
		TlgOutIPV6 = 9,
		TlgOutSOCKETADDRESS = 10,
		TlgOutXML = 11,
		TlgOutJSON = 12,
		TlgOutWIN32ERROR = 13,
		TlgOutNTSTATUS = 14,
		TlgOutHRESULT = 15,
		TlgOutFILETIME = 16,
		TlgOutSIGNED = 17,
		TlgOutUNSIGNED = 18,
		TlgOutUTF8 = 35,
		TlgOutPKCS7_WITH_TYPE_INFO = 36,
		_TlgOutMax = 37,
		_TlgOutChain = 128,
		_TlgOutTypeMask = 127
	}
	public enum _MI_IO_PFN_TYPE
	{
		MiIoPfnProbes = 0,
		MiIoPfnMaps = 1,
		MiIoPfnUnmapped = 2,
		MiMaximumIoPfnType = 3
	}
	public enum _TRACE_INFORMATION_CLASS
	{
		TraceIdClass = 0,
		TraceHandleClass = 1,
		TraceEnableFlagsClass = 2,
		TraceEnableLevelClass = 3,
		GlobalLoggerHandleClass = 4,
		EventLoggerHandleClass = 5,
		AllLoggerHandlesClass = 6,
		TraceHandleByNameClass = 7,
		LoggerEventsLostClass = 8,
		TraceSessionSettingsClass = 9,
		LoggerEventsLoggedClass = 10,
		DiskIoNotifyRoutinesClass = 11,
		TraceInformationClassReserved1 = 12,
		AllPossibleNotifyRoutinesClass = 12,
		FltIoNotifyRoutinesClass = 13,
		TraceInformationClassReserved2 = 14,
		WdfNotifyRoutinesClass = 15,
		MaxTraceInformationClass = 16
	}
	public enum _EXCEPTION_DISPOSITION
	{
		ExceptionContinueExecution = 0,
		ExceptionContinueSearch = 1,
		ExceptionNestedException = 2,
		ExceptionCollidedUnwind = 3
	}
	public enum _MI_PARTITION_THREAD
	{
		MiZeroPageThreadSlot = 0,
		MiPartitionWorkingSetManagerSlot = 1,
		MiDereferenceSegmentThreadSlot = 2,
		MiModifiedPageWriterSlot = 3,
		MiMappedPageWriterSlot = 4,
		MiNumberOfPartitionThreads = 5
	}
	public enum _PERFINFO_MM_STAT
	{
		PerfInfoMMStatNotUsed = 0,
		PerfInfoMMStatAggregatePageCombine = 1,
		PerfInfoMMStatIterationPageCombine = 2,
		PerfInfoMMStatMax = 3
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
	public enum _PROC_HYPERVISOR_STATE
	{
		ProcHypervisorNone = 0,
		ProcHypervisorPresent = 1,
		ProcHypervisorPower = 2,
		ProcHypervisorHvCounters = 3
	}
	public enum _KRESOURCEMANAGER_STATE
	{
		KResourceManagerUninitialized = 0,
		KResourceManagerOffline = 1,
		KResourceManagerOnline = 2
	}
	public enum _SEP_CACHED_HANDLES_ENTRY_TYPE
	{
		SepCachedHandlesEntryLowbox = 0,
		SepCachedHandlesEntryBnoIsolation = 1
	}
	public enum _POP_DEVICE_IDLE_TYPE
	{
		DeviceIdleNormal = 0,
		DeviceIdleDisk = 1
	}
	public enum _MI_CROSS_PARTITION_CHARGE_TYPE
	{
		MiCrossPartitionSectionResAvailCharge = 0,
		MiCrossPartitionSectionCommitCharge = 1,
		MiCrossPartitionPageCombineResAvailCharge = 2,
		MiCrossPartitionPageCombineCommitCharge = 3,
		MiCrossPartitionMaximumCharge = 4
	}
	public enum _PNP_REBALANCE_REASON
	{
		RebalanceReasonUnknown = 0,
		RebalanceReasonRequirementsChanged = 1,
		RebalanceReasonNewDevice = 2
	}
	public enum _PNP_REBALANCE_FAILURE
	{
		RebalanceFailureNone = 0,
		RebalanceFailureDisabled = 1,
		RebalanceFailureNoMemory = 2,
		RebalanceFailureQueryStopUnexpectedVeto = 3,
		RebalanceFailureNoRequirements = 4,
		RebalanceFailureNoCandidates = 5,
		RebalanceFailureNoConfiguration = 6
	}
	public enum _PNP_DEVNODE_QUERY_REBALANCE_VETO_REASON
	{
		DeviceQueryRebalanceSucceeded = 0,
		DeviceQueryStopFailed = 1,
		DeviceFailedGetNewResourceRequirement = 2,
		DeviceInUnexpectedState = 3,
		DeviceNotSupportQueryRebalance = 4
	}
	public enum _PS_ATTRIBUTE_NUM
	{
		PsAttributeParentProcess = 0,
		PsAttributeDebugObject = 1,
		PsAttributeToken = 2,
		PsAttributeClientId = 3,
		PsAttributeTebAddress = 4,
		PsAttributeImageName = 5,
		PsAttributeImageInfo = 6,
		PsAttributeMemoryReserve = 7,
		PsAttributePriorityClass = 8,
		PsAttributeErrorMode = 9,
		PsAttributeStdHandleInfo = 10,
		PsAttributeHandleList = 11,
		PsAttributeGroupAffinity = 12,
		PsAttributePreferredNode = 13,
		PsAttributeIdealProcessor = 14,
		PsAttributeUmsThread = 15,
		PsAttributeMitigationOptions = 16,
		PsAttributeProtectionLevel = 17,
		PsAttributeSecureProcess = 18,
		PsAttributeJobList = 19,
		PsAttributeChildProcessPolicy = 20,
		PsAttributeAllApplicationPackagesPolicy = 21,
		PsAttributeWin32kFilter = 22,
		PsAttributeSafeOpenPromptOriginClaim = 23,
		PsAttributeBnoIsolation = 24,
		PsAttributeDesktopAppPolicy = 25,
		PsAttributeMax = 26
	}
	public enum _MI_VAD_ALLOCATION_CELL_TYPE
	{
		MiVadBottomUp = 0,
		MiVadStackPebTeb = 1,
		MiVadAllocationCellMaximum = 2
	}
	public enum _ConnectionResourceConsumerDesc
	{
		ConnectionResourceConsumerDescIsUndefined = 0,
		ConnectionResourceConsumerDescIsDevice = 1,
		ConnectionResourceConsumerDescIsOpregion = 2,
		ConnectionResourceConsumerDescMax = 3
	}
	public enum _PROCESS_TERMINATE_REQUEST_REASON
	{
		ProcessTerminateRequestReasonNone = 0,
		ProcessTerminateCommitFail = 1,
		ProcessTerminateRfgViolation = 2,
		ProcessTerminateRfgAttachedViolation = 3,
		ProcessTerminateRequestReasonMax = 4
	}
	public enum _REQUESTER_TYPE
	{
		KernelRequester = 0,
		UserProcessRequester = 1,
		UserSharedServiceRequester = 2
	}
	public enum _KERNEL_STACK_LIMITS
	{
		BugcheckStackLimits = 0,
		DPCStackLimits = 1,
		ExpandedStackLimits = 2,
		NormalStackLimits = 3,
		Win32kStackLimits = 4,
		SwapBusyStackLimits = 5,
		IsrStackLimits = 6,
		DebuggerStackLimits = 7,
		MaximumStackLimits = 8
	}
	public enum PDCCLIENTID
	{
		PDC_INVALID_CLIENT = 0,
		PDC_PLM_CLIENT = 1,
		PDC_NQM_CLIENT = 2,
		PDC_WNS_CLIENT = 3,
		PDC_DAM_CLIENT = 4,
		PDC_WCM_CLIENT = 5,
		PDC_NCSI_CLIENT = 7,
		PDC_DHCP_CLIENT = 8,
		PDC_TCPIP_CLIENT = 9,
		PDC_WU_CLIENT = 11,
		PDC_GP_CLIENT = 12,
		PDC_NCA_CLIENT = 14,
		PDC_BI_CLIENT = 15,
		PDC_MSCHED_CLIENT = 16,
		PDC_SUSPENDRESUME_CLIENT = 17,
		PDC_ACTIVATION_CLIENT = 18,
		PDC_ACTIVATION_TEST_CLIENT = 19,
		PDC_PLM_PHASE_TEST_CLIENT = 20,
		PDC_DAM_PHASE_TEST_CLIENT = 21,
		PDC_LOW_POWER_PHASE_TEST_CLIENT = 22,
		PDC_RESILIENCY_NOTIFICATION_PHASE_TEST_CLIENT = 23,
		PDC_NQM_RESILIENCY_TEST_CLIENT = 24,
		PDC_DAM_RESILIENCY_TEST_CLIENT = 25,
		PDC_DAM_KM_TEST_CLIENT = 26,
		PDC_DAM_UM_TEST_CLIENT = 27,
		PDC_SINGLETON_TEST_CLIENT = 28,
		PDC_NETWORK_SERVICE_TEST_CLIENT = 29,
		PDC_NETWORK_SERVICE2_TEST_CLIENT = 30,
		PDC_SYSTEM_SERVICE_TEST_CLIENT = 31,
		PDC_ACTIV_NOTIF_DAM_RESIL_TEST_CLIENT = 32,
		PDC_ACTIV_NOTIF_NET_RESIL_TEST_CLIENT = 33,
		PDC_SHELL_CLIENT = 34,
		PDC_MAINTENANCE_CLIENT = 35,
		PDC_SYNC_CLIENT = 36,
		PDC_IDM_CLIENT = 37,
		PDC_CORTANA_VOICE_ACTIVATION_CLIENT = 38,
		PDC_TETHERING_CLIENT = 39,
		PDC_AUDIO_CLIENT = 40,
		PDC_LOCK_SCREEN = 41,
		PDC_LREC_CLIENT = 42,
		PDC_WP_BW_CLIENT = 43,
		PDC_WP_MEDIA_STREAMING_CLIENT = 44,
		PDC_WP_MAPS_CLIENT = 46,
		PDC_WP_SYNC_CLIENT = 47,
		PDC_SETTING_SYNC_CLIENT = 48,
		PDC_WP_EDM_CLIENT = 49,
		PDC_WP_WALLET_CLIENT = 50,
		PDC_WP_LOCATION_CLIENT = 51,
		PDC_WP_CM_CLIENT = 53,
		PDC_WP_DCP_CLIENT = 54,
		PDC_WP_WIFIAUTO_CLIENT = 55,
		PDC_MDM_CERTINSTALLER_CLIENT = 57,
		PDC_WP_IM_CLIENT = 58,
		PDC_WP_MMS_CLIENT = 59,
		PDC_DEVICEENROLLER_CLIENT = 60,
		PDC_WP_WIFI_SCANNING_CLIENT = 61,
		PDC_WP_OMADM_CLIENT = 62,
		PDC_WP_TELEMETRY_CHECK_CLIENT = 63,
		PDC_WP_DIS_CLIENT = 64,
		PDC_BITS_CLIENT = 65,
		PDC_WP_VOIP_EXECUTION_CLIENT = 66,
		PDC_WP_RESERVED_CLIENT3 = 67,
		PDC_SLEEP_STUDY_CLIENT = 68,
		PDC_WP_AUTOTIMEUPDATE_CLIENT = 69,
		PDC_HYPERV_CLIENT = 70,
		PDC_KM_SIGNAL_CLIENT = 71,
		PDC_UM_SIGNAL_CLIENT = 72,
		PDC_DEVICE_HEALTH_ATTESTATION_CLIENT = 73,
		PDC_XB_SYSTEM_CLIENT = 74,
		PDC_XB_HOST_CLIENT = 75,
		PDC_PRINT_JOB_MANAGER_CLIENT = 76,
		PDC_TELEMETRY_CLIENT = 77,
		PDC_ERROR_REPORTING_CLIENT = 78,
		PDC_XBOX_NTM = 79,
		PDC_CBE_CLIENT = 80,
		PDC_FIND_MY_PHONE_CLIENT = 81,
		PDC_COMMAND_CHANNEL_CLIENT = 82,
		PDC_PPM_PROFILES_CLIENT = 83,
		PDC_WIFI_CALLING_CLIENT = 84,
		PDC_WU_REBOOT_CLIENT = 85,
		PDC_SYSMAIN_CLIENT = 86,
		PDC_XBOX_UPDATE_CLIENT = 87,
		PDC_CHAT_SERVICE_CLIENT = 88,
		PDC_FIND_MY_DEVICE_CLIENT = 89,
		PDC_NOTIFICATION_FORWARDING_AND_ACTION_CLIENT = 90,
		PDC_INSTALL_AGENT_CLIENT = 91,
		PDC_XBOX_WAKE_ON_VOICE = 92,
		PDC_PLM_AUDIO_CLIENT = 93,
		PDC_WP_BCKAUDIO_CLIENT = 94,
		PDC_WAKE_ON_LAN_CLIENT = 95,
		PDC_WP_CLOUD_MESSAGING_CLIENT = 96,
		PDC_DATA_MIGRATION_MANAGER = 97,
		PDC_EVENT_SOUND_MANAGER_CLIENT = 98,
		PDC_WWAN_DORMANCY_HINT_CLIENT = 99,
		PDC_NUMBER_OF_CLIENTS = 100
	}
	public enum SLEEPSTUDY_SPM_SCENARIO_CS_EXIT
	{
		SpmScenarioStopReasonUnspecified = 16,
		SpmScenarioStopReasonCsExit = 17,
		SpmScenarioStopReasonMax = 18
	}
	public enum PROFILE_DEPARTURE_STYLE
	{
		PDS_UPDATE_DEFAULT = 1,
		PDS_UPDATE_ON_REMOVE = 2,
		PDS_UPDATE_ON_INTERFACE = 3,
		PDS_UPDATE_ON_EJECT = 4
	}
	public enum LSA_FOREST_TRUST_RECORD_TYPE
	{
		ForestTrustTopLevelName = 0,
		ForestTrustTopLevelNameEx = 1,
		ForestTrustDomainInfo = 2,
		ForestTrustRecordTypeLast = 2
	}
	public enum ReplacesCorHdrNumericDefines
	{
		COMIMAGE_FLAGS_ILONLY = 1,
		COMIMAGE_FLAGS_32BITREQUIRED = 2,
		COMIMAGE_FLAGS_IL_LIBRARY = 4,
		COMIMAGE_FLAGS_STRONGNAMESIGNED = 8,
		COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 16,
		COMIMAGE_FLAGS_TRACKDEBUGDATA = 65536,
		COMIMAGE_FLAGS_32BITPREFERRED = 131072,
		COR_VERSION_MAJOR_V2 = 2,
		COR_VERSION_MAJOR = 2,
		COR_VERSION_MINOR = 5,
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
		COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 8,
		COR_VTABLE_CALL_MOST_DERIVED = 16,
		IMAGE_COR_EATJ_THUNK_SIZE = 32,
		MAX_CLASS_NAME = 1024,
		MAX_PACKAGE_NAME = 1024
	}
	public enum _ARBITER_RESULT
	{
		ArbiterResultUndefined = -1,
		ArbiterResultSuccess = 0,
		ArbiterResultExternalConflict = 1,
		ArbiterResultNullRequest = 2
	}
	public enum PDC_ACTIVITY_TYPE
	{
		PdcNetwork = 0,
		PdcSystem = 1,
		PdcTimer = 2,
		PdcAllNetworks = 3,
		PdcInvalidActivity = 4,
		PdcMaxActivity = 4
	}
	public enum JOB_OBJECT_NET_RATE_CONTROL_FLAGS
	{
		JOB_OBJECT_NET_RATE_CONTROL_ENABLE = 1,
		JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH = 2,
		JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG = 4,
		JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS = 7
	}
	public enum _MI_MIRROR_BITMAP_TYPES
	{
		MirrorBitmapTypeNormal = 0,
		MirrorBitmapTypeInterlocked = 1,
		MirrorBitmapTypeMaximum = 2
	}
	public enum _POP_IO_STATUS
	{
		IoReady = 0,
		IoPending = 1,
		IoDone = 2
	}
	public enum KTM_STATE
	{
		KKtmUninitialized = 0,
		KKtmInitialized = 1,
		KKtmRecovering = 2,
		KKtmOnline = 3,
		KKtmRecoveryFailed = 4,
		KKtmOffline = 5
	}
	public enum _LDR_DLL_LOAD_REASON
	{
		LoadReasonStaticDependency = 0,
		LoadReasonStaticForwarderDependency = 1,
		LoadReasonDynamicForwarderDependency = 2,
		LoadReasonDelayloadDependency = 3,
		LoadReasonDynamicLoad = 4,
		LoadReasonAsImageLoad = 5,
		LoadReasonAsDataLoad = 6,
		LoadReasonUnknown = -1
	}
	public enum _RTL_GENERIC_COMPARE_RESULTS
	{
		GenericLessThan = 0,
		GenericGreaterThan = 1,
		GenericEqual = 2
	}
	public enum _PO_MODERN_SLEEP_ACTION
	{
		PoModernSleepActionGlobalActivatorsVeto = 0,
		PoModernSleepActionNonBlockingPhases = 1,
		PoModernSleepActionForceIdle = 2,
		PoModernSleepActionMinimalBlockingNotificationClients = 3,
		PoModernSleepActionMax = 4
	}
	public enum _DMA_WIDTH
	{
		Width8Bits = 0,
		Width16Bits = 1,
		Width32Bits = 2,
		Width64Bits = 3,
		WidthNoWrap = 4,
		MaximumDmaWidth = 5
	}
	public enum _DMA_SPEED
	{
		Compatible = 0,
		TypeA = 1,
		TypeB = 2,
		TypeC = 3,
		TypeF = 4,
		MaximumDmaSpeed = 5
	}
	public enum _MI_AVAILABLE_PAGE_WAIT_TYPES
	{
		AvailablePagesWaitLow = 0,
		AvailablePagesWaitHigh = 1,
		AvailablePagesWaitVeryHigh = 2,
		AvailablePagesWaitMaximum = 3
	}
	public enum _ETW_HEADER_TYPE
	{
		EtwHeaderTypeNative = 0,
		EtwHeaderTypeWow = 1,
		EtwHeaderTypeMax = 2
	}
	public enum _FUNCTION_TABLE_TYPE
	{
		RF_SORTED = 0,
		RF_UNSORTED = 1,
		RF_CALLBACK = 2,
		RF_KERNEL_DYNAMIC = 3
	}
	public enum _CM_SHARE_DISPOSITION
	{
		CmResourceShareUndetermined = 0,
		CmResourceShareDeviceExclusive = 1,
		CmResourceShareDriverExclusive = 2,
		CmResourceShareShared = 3
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
	public enum _IRQ_PRIORITY
	{
		IrqPriorityUndefined = 0,
		IrqPriorityLow = 1,
		IrqPriorityNormal = 2,
		IrqPriorityHigh = 3
	}
	public enum _KTRANSACTION_STATE
	{
		KTransactionUninitialized = 0,
		KTransactionActive = 1,
		KTransactionPreparing = 2,
		KTransactionPrepared = 3,
		KTransactionInDoubt = 4,
		KTransactionCommitted = 5,
		KTransactionAborted = 6,
		KTransactionDelegated = 7,
		KTransactionPrePreparing = 8,
		KTransactionForgotten = 9,
		KTransactionRecovering = 10,
		KTransactionPrePrepared = 11
	}
	public enum _KTRANSACTION_OUTCOME
	{
		KTxOutcomeUninitialized = 0,
		KTxOutcomeUndetermined = 1,
		KTxOutcomeCommitted = 2,
		KTxOutcomeAborted = 3,
		KTxOutcomeUnavailable = 4
	}
	public enum INTERRUPT_CONNECTION_TYPE
	{
		InterruptTypeControllerInput = 0,
		InterruptTypeXapicMessage = 1,
		InterruptTypeHypertransport = 2,
		InterruptTypeMessageRequest = 3
	}
	public enum HAL_APIC_DESTINATION_MODE
	{
		ApicDestinationModePhysical = 1,
		ApicDestinationModeLogicalFlat = 2,
		ApicDestinationModeLogicalClustered = 3,
		ApicDestinationModeUnknown = 4
	}
	public enum _LDR_DDAG_STATE
	{
		LdrModulesMerged = -5,
		LdrModulesInitError = -4,
		LdrModulesSnapError = -3,
		LdrModulesUnloaded = -2,
		LdrModulesUnloading = -1,
		LdrModulesPlaceHolder = 0,
		LdrModulesMapping = 1,
		LdrModulesMapped = 2,
		LdrModulesWaitingForDependencies = 3,
		LdrModulesSnapping = 4,
		LdrModulesSnapped = 5,
		LdrModulesCondensed = 6,
		LdrModulesReadyToInit = 7,
		LdrModulesInitializing = 8,
		LdrModulesReadyToRun = 9
	}
	public enum _PLUGPLAY_EVENT_CATEGORY
	{
		HardwareProfileChangeEvent = 0,
		TargetDeviceChangeEvent = 1,
		DeviceClassChangeEvent = 2,
		CustomDeviceEvent = 3,
		DeviceInstallEvent = 4,
		DeviceArrivalEvent = 5,
		VetoEvent = 6,
		BlockedDriverEvent = 7,
		InvalidIDEvent = 8,
		DevicePropertyChangeEvent = 9,
		DeviceInstanceRemovalEvent = 10,
		DeviceInstanceStartedEvent = 11,
		MaxPlugEventCategory = 12
	}
	public enum _DUMP_EVENTS
	{
		DUMP_EVENT_NONE = 0,
		DUMP_EVENT_HIBER_RESUME = 1,
		DUMP_EVENT_HIBER_RESUME_END = 2
	}
	public enum _CM_DIRTY_VECTOR_OPERATION
	{
		DirtyVectorModified = 0,
		DirtyDataCaptureStart = 1,
		DirtyDataCaptureEnd = 2
	}
	public enum _UNNAMED_ENUM_KTMOH_COMMITTRANSACTION_RESULT
	{
		KTMOH_CommitTransaction_Result = 1,
		KTMOH_RollbackTransaction_Result = 2
	}
	public enum _ETW_NOTIFICATION_TYPE
	{
		EtwNotificationTypeNoReply = 1,
		EtwNotificationTypeLegacyEnable = 2,
		EtwNotificationTypeEnable = 3,
		EtwNotificationTypePrivateLogger = 4,
		EtwNotificationTypePerflib = 5,
		EtwNotificationTypeAudio = 6,
		EtwNotificationTypeSession = 7,
		EtwNotificationTypeReserved = 8,
		EtwNotificationTypeCredentialUI = 9,
		EtwNotificationTypeInProcSession = 10,
		EtwNotificationTypeFilteredPrivateLogger = 11,
		EtwNotificationTypeMax = 12
	}
	public enum _PO_FX_PERF_STATE_UNIT
	{
		PoFxPerfStateUnitOther = 0,
		PoFxPerfStateUnitFrequency = 1,
		PoFxPerfStateUnitBandwidth = 2,
		PoFxPerfStateUnitMaximum = 3
	}
	public enum _PO_FX_PERF_STATE_TYPE
	{
		PoFxPerfStateTypeDiscrete = 0,
		PoFxPerfStateTypeRange = 1,
		PoFxPerfStateTypeMaximum = 2
	}
	public enum _FS_FILTER_SECTION_SYNC_TYPE
	{
		SyncTypeOther = 0,
		SyncTypeCreateSection = 1
	}
	public enum _FS_FILTER_STREAM_FO_NOTIFICATION_TYPE
	{
		NotifyTypeCreate = 0,
		NotifyTypeRetired = 1
	}
}
