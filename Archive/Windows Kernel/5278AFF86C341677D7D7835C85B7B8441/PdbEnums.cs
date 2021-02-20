using System;

namespace LiveForensics.Symbols
{
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
	public enum _EVENT_TYPE
	{
		NotificationEvent = 0,
		SynchronizationEvent = 1
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
		FileMemoryPartitionInformation = 69,
		FileStatLxInformation = 70,
		FileCaseSensitiveInformation = 71,
		FileLinkInformationEx = 72,
		FileLinkInformationExBypassAccessCheck = 73,
		FileStorageReserveIdInformation = 74,
		FileCaseSensitiveInformationForceAccessCheck = 75,
		FileMaximumInformation = 76
	}
	public enum _DIRECTORY_NOTIFY_INFORMATION_CLASS
	{
		DirectoryNotifyInformation = 1,
		DirectoryNotifyExtendedInformation = 2
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
		FileFsFullSizeInformationEx = 14,
		FileFsMaximumInformation = 15
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
		DeviceUsageTypePostDisplay = 5,
		DeviceUsageTypeGuestAssigned = 6
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
		WheaErrSrcTypeBMC = 14,
		WheaErrSrcTypePMEM = 15,
		WheaErrSrcTypeDeviceDriver = 16,
		WheaErrSrcTypeMax = 17
	}
	public enum _WHEA_ERROR_SOURCE_STATE
	{
		WheaErrSrcStateStopped = 1,
		WheaErrSrcStateStarted = 2,
		WheaErrSrcStateRemoved = 3,
		WheaErrSrcStateRemovePending = 4
	}
	public enum _WHEA_EVENT_LOG_ENTRY_TYPE
	{
		WheaEventLogEntryTypeInformational = 0,
		WheaEventLogEntryTypeWarning = 1,
		WheaEventLogEntryTypeError = 2
	}
	public enum _WHEA_EVENT_LOG_ENTRY_ID
	{
		WheaEventLogEntryIdCmcPollingTimeout = -2147483647,
		WheaEventLogEntryIdWheaInit = -2147483646,
		WheaEventLogEntryIdCmcSwitchToPolling = -2147483645,
		WheaEventLogEntryIdDroppedCorrectedError = -2147483644,
		WheaEventLogEntryIdStartedReportHwError = -2147483643,
		WheaEventLogEntryIdPFAMemoryOfflined = -2147483642,
		WheaEventLogEntryIdPFAMemoryRemoveMonitor = -2147483641,
		WheaEventLogEntryIdPFAMemoryPolicy = -2147483640,
		WheaEventLogEntryIdPshedInjectError = -2147483639,
		WheaEventLogEntryIdOscCapabilities = -2147483638,
		WheaEventLogEntryIdPshedPluginRegister = -2147483637,
		WheaEventLogEntryIdAddRemoveErrorSource = -2147483636,
		WheaEventLogEntryIdWorkQueueItem = -2147483635,
		WheaEventLogEntryIdAttemptErrorRecovery = -2147483634,
		WheaEventLogEntryIdMcaFoundErrorInBank = -2147483633,
		WheaEventLogEntryIdMcaStuckErrorCheck = -2147483632,
		WheaEventLogEntryIdMcaErrorCleared = -2147483631,
		WheaEventLogEntryIdClearedPoison = -2147483630,
		WheaEventLogEntryIdProcessEINJ = -2147483629,
		WheaEventLogEntryIdProcessHEST = -2147483628,
		WheaEventLogEntryIdCreateGenericRecord = -2147483627,
		WheaEventLogEntryIdErrorRecord = -2147483626,
		WheaEventLogEntryIdErrorRecordLimit = -2147483625,
		WheaEventLogEntryIdErrSrcArrayInvalid = -2147483623,
		WheaEventLogEntryIdAcpiTimeOut = -2147483622,
		WheaEventLogCmciRestart = -2147483621,
		WheaEventLogCmciFinalRestart = -2147483620,
		WheaEventLogEntryEtwOverFlow = -2147483619,
		WheaEventLogAzccRootBusSearchErr = -2147483618,
		WheaEventLogAzccRootBusList = -2147483617,
		WheaEventLogEntryIdErrSrcInvalid = -2147483616,
		WheaEventLogEntryIdGenericErrMemMap = -2147483615,
		WheaEventLogEntryIdPshedCallbackCollision = -2147483614,
		WheaEventLogEntryIdSELBugCheckProgress = -2147483613,
		WheaEventLogEntryIdPshedPluginLoad = -2147483612,
		WheaEventLogEntryIdPshedPluginUnload = -2147483611,
		WheaEventLogEntryIdPshedPluginSupported = -2147483610,
		WheaEventLogEntryIdDeviceDriver = -2147483609,
		WheaEventLogEntryIdCmciImplPresent = -2147483608,
		WheaEventLogEntryIdCmciInitError = -2147483607,
		WheaEventLogEntryIdSELBugCheckRecovery = -2147483606,
		WheaEventLogEntryIdDrvErrSrcInvalid = -2147483605,
		WheaEventLogEntryIdDrvHandleBusy = -2147483604,
		WheaEventLogEntryIdWheaHeartbeat = -2147483603,
		WheaEventLogAzccRootBusPoisonSet = -2147483602,
		WheaEventLogEntryIdSELBugCheckInfo = -2147483601,
		WheaEventLogEntryIdErrDimmInfoMismatch = -2147483600,
		WheaEventLogEntryIdeDpcEnabled = -2147483599
	}
	public enum _WHEA_ERROR_TYPE
	{
		WheaErrTypeProcessor = 0,
		WheaErrTypeMemory = 1,
		WheaErrTypePCIExpress = 2,
		WheaErrTypeNMI = 3,
		WheaErrTypePCIXBus = 4,
		WheaErrTypePCIXDevice = 5,
		WheaErrTypeGeneric = 6,
		WheaErrTypePmem = 7
	}
	public enum _WHEA_ERROR_SEVERITY
	{
		WheaErrSevRecoverable = 0,
		WheaErrSevFatal = 1,
		WheaErrSevCorrected = 2,
		WheaErrSevInformational = 3
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
	public enum _KINTERRUPT_MODE
	{
		LevelSensitive = 0,
		Latched = 1
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
	public enum _HALP_DMA_MAP_BUFFER_TYPE
	{
		HalpDmaContiguousMapBuffer = 0,
		HalpDmaNonContiguousMapBuffer = 1,
		HalpDmaMaximumMapBufferType = 2
	}
	public enum _KNOWN_CONTROLLER_TYPE
	{
		InterruptControllerInvalid = 0,
		InterruptControllerPic = 1,
		InterruptControllerApic = 2,
		InterruptControllerGic = 3,
		InterruptControllerGicV3 = 4,
		InterruptControllerGicV4 = 5,
		InterruptControllerBcm = 6,
		InterruptControllerUnknown = 4096
	}
	public enum _INTERRUPT_PROBLEM
	{
		InterruptProblemNone = 0,
		InterruptProblemMadtParsingFailure = 1,
		InterruptProblemNoControllersFound = 2,
		InterruptProblemFailedDiscovery = 3,
		InterruptProblemInitializeLocalUnitFailed = 4,
		InterruptProblemInitializeIoUnitFailed = 5,
		InterruptProblemSetLogicalIdFailed = 6,
		InterruptProblemSetLineStateFailed = 7,
		InterruptProblemGenerateMessageFailed = 8,
		InterruptProblemConvertIdFailed = 9,
		InterruptProblemCmciSetupFailed = 10,
		InterruptProblemQueryMaxProcessorsCalledTooEarly = 11,
		InterruptProblemProcessorReset = 12,
		InterruptProblemStartProcessorFailed = 13,
		InterruptProblemProcessorNotAlive = 14,
		InterruptProblemLowerIrqlViolation = 15,
		InterruptProblemInvalidIrql = 16,
		InterruptProblemNoSuchController = 17,
		InterruptProblemNoSuchLines = 18,
		InterruptProblemBadConnectionData = 19,
		InterruptProblemBadRoutingData = 20,
		InterruptProblemInvalidProcessor = 21,
		InterruptProblemFailedToAttainTarget = 22,
		InterruptProblemUnsupportedWiringConfiguration = 23,
		InterruptProblemSpareAlreadyStarted = 24,
		InterruptProblemClusterNotFullyReplaced = 25,
		InterruptProblemNewClusterAlreadyActive = 26,
		InterruptProblemNewClusterTooLarge = 27,
		InterruptProblemCannotHardwareQuiesce = 28,
		InterruptProblemIpiDestinationUpdateFailed = 29,
		InterruptProblemNoMemory = 30,
		InterruptProblemNoIrtEntries = 31,
		InterruptProblemConnectionDataBaitAndSwitch = 32,
		InterruptProblemInvalidLogicalFlatId = 33,
		InterruptProblemDeinitializeLocalUnitFailed = 34,
		InterruptProblemDeinitializeIoUnitFailed = 35,
		InterruptProblemMismatchedThermalLvtIsr = 36,
		InterruptProblemHvRetargetFailed = 37,
		InterruptProblemDeferredErrorSetupFailed = 38
	}
	public enum _IO_ALLOCATION_ACTION
	{
		KeepObject = 1,
		DeallocateObject = 2,
		DeallocateObjectKeepRegisters = 3
	}
	public enum _MODE
	{
		KernelMode = 0,
		UserMode = 1,
		MaximumMode = 2
	}
	public enum _MEMORY_CACHING_TYPE_ORIG
	{
		MmFrameBufferCached = 2
	}
	public enum _INTERLOCKED_RESULT
	{
		ResultNegative = 1,
		ResultZero = 0,
		ResultPositive = 2
	}
	public enum _WHEA_CPU_VENDOR
	{
		WheaCpuVendorOther = 0,
		WheaCpuVendorIntel = 1,
		WheaCpuVendorAmd = 2
	}
	public enum _HAL_INIT_PHASE
	{
		HalInitPhaseBspProcEarly = 0,
		HalInitPhaseBspProcEarlyMmReady = 1,
		HalInitPhaseBspProcEarlyTimerReady = 2,
		HalInitPhaseBspProcEarlyEnd = 3,
		HalInitPhasePnProcEarly = 4,
		HalInitPhasePnProcEarlyInterruptsReady = 5,
		HalInitPhasePnProcEarlyEnd = 6,
		HalInitPhaseBspSystemEarly = 7,
		HalInitPhaseBspSystemEarlyAcpiReady = 8,
		HalInitPhaseBspSystemEarlyHalExtensionsReady = 9,
		HalInitPhaseBspSystemEarlyInterruptsAlmostReady = 10,
		HalInitPhaseBspSystemEarlyIommusReady = 11,
		HalInitPhaseBspSystemEarlyInterruptsReady = 12,
		HalInitPhaseBspSystemEarlyDmaReady = 12,
		HalInitPhaseBspSystemEarlyProcReady = 13,
		HalInitPhaseBspSystemEarlyHwPerfCntReady = 14,
		HalInitPhaseBspSystemEarlyAllocationDone = 15,
		HalInitPhaseBspSystemEarlyEnd = 16,
		HalInitPhaseBspSystemLate = 17,
		HalInitPhaseBspSystemLateEnd = 18,
		HalInitPhasePnSystemLate = 19,
		HalInitPhasePnSystemLateEnd = 20,
		HalInitPhaseAllProcStartComplete = 21,
		HalInitPhaseAllProcStartCompleteEnd = 22,
		HalInitPhaseExPhase1Ready = 23,
		HalInitPhaseExPhase1ReadyEnd = 24,
		HalInitPhaseAcpiPdoStarted = 25,
		HalInitPhaseAcpiPdoStartedEnd = 26,
		HalInitPhaseReportResources = 27,
		HalInitPhaseReportResourcesEnd = 28,
		HalInitPhaseReportCoreSystemResources = 29,
		HalInitPhaseReportCoreSystemResourcesEnd = 30,
		HalInitPhaseLateSystemActions = 31,
		HalInitPhaseLateSystemActionsTelemetryReady = 32,
		HalInitPhaseLateSystemActionsEnd = 33
	}
	public enum _USER_ACTIVITY_PRESENCE
	{
		PowerUserPresent = 0,
		PowerUserNotPresent = 1,
		PowerUserInactive = 2,
		PowerUserMaximum = 3,
		PowerUserInvalid = 3
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
	public enum _EXCEPTION_DISPOSITION
	{
		ExceptionContinueExecution = 0,
		ExceptionContinueSearch = 1,
		ExceptionNestedException = 2,
		ExceptionCollidedUnwind = 3
	}
	public enum _SECURITY_IMPERSONATION_LEVEL
	{
		SecurityAnonymous = 0,
		SecurityIdentification = 1,
		SecurityImpersonation = 2,
		SecurityDelegation = 3
	}
	public enum _INTERRUPT_RESULT
	{
		InterruptBeginFatalError = 0,
		InterruptBeginLine = 1,
		InterruptBeginSpurious = 2,
		InterruptBeginVector = 3,
		InterruptBeginNone = 4
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
	public enum _EXT_IOMMU_TRANSLATION_TYPE
	{
		ExtTranslationTypePassThrough = 0,
		ExtTranslationTypeBlocked = 1,
		ExtTranslationTypeTranslate = 2,
		ExtTranslationTypeSafePassThrough = 3,
		ExtTranslationTypeInvalid = 4
	}
	public enum _HALP_DMA_ADAPTER_ALLOCATION_STATE
	{
		HalpDmaAdapterAllocationStateNone = 0,
		HalpDmaAdapterAllocateChannel = 1,
		HalpDmaAdapterAllocateMapRegisters = 2,
		HalpDmaAdapterAllocateChannelRemapResources = 3,
		HalpDmaAdapterAllocationStateComplete = 4,
		HalpDmaAdapterAllocationStateMax = 5
	}
	public enum _HAL_DMA_CRASH_DUMP_REGISTER_TYPE
	{
		HalDmaCrashDumpRegisterSet1 = 0,
		HalDmaCrashDumpRegisterSet2 = 1,
		HalDmaCrashDumpRegisterSetMax = 2
	}
	public enum DMA_COMPLETION_STATUS
	{
		DmaComplete = 0,
		DmaAborted = 1,
		DmaError = 2,
		DmaCancelled = 3
	}
	public enum _DMA_INTERRUPT_TYPE
	{
		InterruptTypeCompletion = 0,
		InterruptTypeError = 1,
		InterruptTypeCancelled = 2
	}
	public enum _INTERRUPT_TARGET_TYPE
	{
		InterruptTargetInvalid = 0,
		InterruptTargetAllIncludingSelf = 1,
		InterruptTargetAllExcludingSelf = 2,
		InterruptTargetSelfOnly = 3,
		InterruptTargetPhysical = 4,
		InterruptTargetLogicalFlat = 5,
		InterruptTargetLogicalClustered = 6,
		InterruptTargetRemapIndex = 7,
		InterruptTargetHypervisor = 8
	}
	public enum _IRQ_PRIORITY
	{
		IrqPriorityUndefined = 0,
		IrqPriorityLow = 1,
		IrqPriorityNormal = 2,
		IrqPriorityHigh = 3
	}
	public enum _HALP_EMERGENCY_LA_QUEUE_TYPE
	{
		HalpDmaLegacyLaQueueEntry = 0,
		HalpDmaThinLaQueueEntry = 1,
		HalpDmaLaQueueEntryMax = 2
	}
	public enum _WHEA_RECOVERY_CONTEXT_ERROR_TYPE
	{
		WheaRecoveryContextErrorTypeMemory = 1,
		WheaRecoveryContextErrorTypePmem = 2,
		WheaRecoveryContextErrorTypeMax = 3
	}
	public enum _EXT_IOMMU_DEVICE_TYPE
	{
		EXT_IOMMU_DEVICE_TYPE_INVALID = 0,
		EXT_IOMMU_DEVICE_TYPE_PCI = 1,
		EXT_IOMMU_DEVICE_TYPE_ACPI = 2,
		EXT_IOMMU_DEVICE_TYPE_IOAPIC = 3,
		EXT_IOMMU_DEVICE_TYPE_LOGICAL = 4,
		EXT_IOMMU_DEVICE_TYPE_GIC = 5,
		EXT_IOMMU_DEVICE_TYPE_TEST = 6,
		EXT_IOMMU_DEVICE_TYPE_MAX = 7
	}
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
		PS_MITIGATION_OPTION_RESTRICT_SET_THREAD_CONTEXT = 19,
		PS_MITIGATION_OPTION_ROP_STACKPIVOT = 20,
		PS_MITIGATION_OPTION_ROP_CALLER_CHECK = 21,
		PS_MITIGATION_OPTION_ROP_SIMEXEC = 22,
		PS_MITIGATION_OPTION_EXPORT_ADDRESS_FILTER = 23,
		PS_MITIGATION_OPTION_EXPORT_ADDRESS_FILTER_PLUS = 24,
		PS_MITIGATION_OPTION_RESTRICT_CHILD_PROCESS_CREATION = 25,
		PS_MITIGATION_OPTION_IMPORT_ADDRESS_FILTER = 26,
		PS_MITIGATION_OPTION_MODULE_TAMPERING_PROTECTION = 27,
		PS_MITIGATION_OPTION_RESTRICT_INDIRECT_BRANCH_PREDICTION = 28,
		PS_MITIGATION_OPTION_SPECULATIVE_STORE_BYPASS_DISABLE = 29,
		PS_MITIGATION_OPTION_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY = 30,
		PS_MITIGATION_OPTION_CET_USER_SHADOW_STACKS = 31,
		PS_MITIGATION_OPTION_USER_CET_SET_CONTEXT_IP_VALIDATION = 32,
		PS_MITIGATION_OPTION_BLOCK_NON_CET_BINARIES = 33,
		PS_MITIGATION_OPTION_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY = 36
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
	public enum _SYSTEM_DLL_TYPE
	{
		PsNativeSystemDll = 0,
		PsWowX86SystemDll = 1,
		PsWowArm32SystemDll = 2,
		PsWowAmd64SystemDll = 3,
		PsWowChpeX86SystemDll = 4,
		PsVsmEnclaveRuntimeDll = 5,
		PsSystemDllTotalTypes = 6
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
	public enum _EVENT_INFO_CLASS
	{
		EventProviderBinaryTrackInfo = 0,
		EventProviderSetReserved1 = 1,
		EventProviderSetTraits = 2,
		EventProviderUseDescriptorType = 3,
		MaxEventInfo = 4
	}
	public enum wil_ReportingKind
	{
		wil_ReportingKind_None = 0,
		wil_ReportingKind_UniqueUsage = 1,
		wil_ReportingKind_UniqueOpportunity = 2,
		wil_ReportingKind_DeviceUsage = 3,
		wil_ReportingKind_DeviceOpportunity = 4,
		wil_ReportingKind_TotalDuration = 5,
		wil_ReportingKind_PausedDuration = 6
	}
	public enum wil_details_ServiceReportingKind
	{
		wil_details_ServiceReportingKind_UniqueUsage = 0,
		wil_details_ServiceReportingKind_UniqueOpportunity = 1,
		wil_details_ServiceReportingKind_DeviceUsage = 2,
		wil_details_ServiceReportingKind_DeviceOpportunity = 3,
		wil_details_ServiceReportingKind_PotentialUniqueUsage = 4,
		wil_details_ServiceReportingKind_PotentialUniqueOpportunity = 5,
		wil_details_ServiceReportingKind_PotentialDeviceUsage = 6,
		wil_details_ServiceReportingKind_PotentialDeviceOpportunity = 7,
		wil_details_ServiceReportingKind_EnabledTotalDuration = 8,
		wil_details_ServiceReportingKind_EnabledPausedDuration = 9,
		wil_details_ServiceReportingKind_DisabledTotalDuration = 10,
		wil_details_ServiceReportingKind_DisabledPausedDuration = 11,
		wil_details_ServiceReportingKind_CustomEnabledBase = 100,
		wil_details_ServiceReportingKind_CustomDisabledBase = 150,
		wil_details_ServiceReportingKind_Store = 254,
		wil_details_ServiceReportingKind_None = 255,
		wil_details_ServiceReportingKind_VariantDevicePotentialBase = 256,
		wil_details_ServiceReportingKind_VariantDeviceUsageBase = 320,
		wil_details_ServiceReportingKind_VariantUniquePotentialBase = 384,
		wil_details_ServiceReportingKind_VariantUniqueUsageBase = 448
	}
	public enum wil_VariantReportingKind
	{
		wil_VariantReportingKind_None = 0,
		wil_VariantReportingKind_UniqueUsage = 1,
		wil_VariantReportingKind_DeviceUsage = 2
	}
	public enum wil_FeatureEnabledStateOptions
	{
		wil_FeatureEnabledStateOptions_None = 0,
		wil_FeatureEnabledStateOptions_VariantConfig = 1
	}
	public enum wil_FeatureEnabledStateKind
	{
		wil_FeatureEnabledStateKind_Service = 1,
		wil_FeatureEnabledStateKind_User = 2,
		wil_FeatureEnabledStateKind_Test = 3
	}
	public enum wil_FeatureEnabledState
	{
		wil_FeatureEnabledState_Default = 0,
		wil_FeatureEnabledState_Disabled = 1,
		wil_FeatureEnabledState_Enabled = 2
	}
	public enum wil_details_StagingConfigFeatureFields
	{
		wil_details_StagingConfigFeatureFields_None = 0,
		wil_details_StagingConfigFeatureFields_ServiceState = 1,
		wil_details_StagingConfigFeatureFields_UserState = 2,
		wil_details_StagingConfigFeatureFields_TestState = 4,
		wil_details_StagingConfigFeatureFields_Variant = 8
	}
	public enum wil_FeatureStore
	{
		wil_FeatureStore_Machine = 0,
		wil_FeatureStore_User = 1,
		wil_FeatureStore_All = 2
	}
	public enum wil_FeatureVariantPayloadKind
	{
		wil_FeatureVariantPayloadKind_None = 0,
		wil_FeatureVariantPayloadKind_Resident = 1,
		wil_FeatureVariantPayloadKind_External = 2
	}
	public enum wil_FeatureChangeTime
	{
		wil_FeatureChangeTime_OnRead = 0,
		wil_FeatureChangeTime_OnReload = 1,
		wil_FeatureChangeTime_OnSession = 2,
		wil_FeatureChangeTime_OnReboot = 3
	}
	public enum _RTL_FEATURE_CONFIGURATION_TYPE
	{
		RtlFeatureConfigurationBoot = 0,
		RtlFeatureConfigurationRuntime = 1,
		RtlFeatureConfigurationCount = 2
	}
	public enum wil_details_ServiceReportingOptions
	{
		wil_details_ServiceReportingOptions_None = 0,
		wil_details_ServiceReportingOptions_VariantConfig = 1
	}
	public enum wil_details_FeatureTestStateKind
	{
		wil_details_FeatureTestStateKind_EnabledState = 0,
		wil_details_FeatureTestStateKind_Variant = 1
	}
	public enum wil_UsageReportingMode
	{
		wil_UsageReportingMode_Default = 0,
		wil_UsageReportingMode_SuppressPotential = 1,
		wil_UsageReportingMode_SuppressImplicit = 2
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
		MiVaSystemPtesLarge = 13,
		MiVaKernelStacks = 14,
		MiVaSecureNonPagedPool = 15,
		MiVaMaximumType = 16
	}
	public enum _CM_LOAD_FAILURE_TYPE
	{
		_None = 0,
		_CmpCreateHive = 1,
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
		_CmpCheckLeaf = 23,
		_HvHiveStartFileBacked = 24,
		_HvStartHiveMemoryBacked = 25,
		_HvpEnlistFreeCells = 26,
		_HvpPerformLogFileRecovery = 27,
		_CmpInitHiveFromFile = 28,
		_CmpLoadKeyCommon = 29,
		_CmpLinkHiveToMaster = 30,
		_CmLoadKey = 31,
		_CmLoadAppKey = 32,
		_CmpResolveHiveLoadConflict = 33
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
		CmpFailurePointForceMultiLevelMap = 13,
		CmpFailurePointAllocateContiguousLogEntry = 14,
		CmpFailurePointAllocateKcb = 15,
		CmpFailurePointCreateKeyBody = 16,
		CmpFailurePointForceFreeKcb = 17,
		CmpFailurePointKcbLockUpgrade = 18,
		CmpFailurePointKcbLockUpgradeDelay = 19,
		CmpFailurePointKeyEnumResumeContextVerification = 20,
		CmpFailurePointKeyEnumForceRetry = 21,
		CmpFailurePointForceReorganization = 22,
		CmpFailurePointForceLazyCOWByPolicy = 23,
		CmpFailureInjectionPointCount = 24
	}
	public enum _PCW_CALLBACK_TYPE
	{
		PcwCallbackAddCounter = 0,
		PcwCallbackRemoveCounter = 1,
		PcwCallbackEnumerateInstances = 2,
		PcwCallbackCollectData = 3
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
	public enum PROFILE_STATUS
	{
		DOCK_NOTDOCKDEVICE = 0,
		DOCK_QUIESCENT = 1,
		DOCK_ARRIVING = 2,
		DOCK_DEPARTING = 3,
		DOCK_EJECTIRP_COMPLETED = 4
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
	public enum _OPENCOUNT_REASON
	{
		OpenCount_SkipLogging = 0,
		OpenCount_AsyncRead = 1,
		OpenCount_FlushCache = 2,
		OpenCount_GetDirtyPage = 3,
		OpenCount_GetFlushedVDL = 4,
		OpenCount_InitCachemap1 = 5,
		OpenCount_InitCachemap2 = 6,
		OpenCount_InitCachemap3 = 7,
		OpenCount_InitCachemap4 = 8,
		OpenCount_InitCachemap5 = 9,
		OpenCount_MdlWrite = 10,
		OpenCount_MdlWriteAbort = 11,
		OpenCount_NotifyMappedWrite = 12,
		OpenCount_NotifyMappedWriteCompCallback = 13,
		OpenCount_PurgeCache = 14,
		OpenCount_PurgeCacheActiveViews = 15,
		OpenCount_ReadAhead = 16,
		OpenCount_SetFileSize = 17,
		OpenCount_SetFileSizeSection = 18,
		OpenCount_UninitCachemapReadAhead = 19,
		OpenCount_UninitCachemapReg = 20,
		OpenCount_UnmapInactiveViews = 21,
		OpenCount_UnmapInactiveViews1 = 22,
		OpenCount_UnmapInactiveViews2 = 23,
		OpenCount_UnmapInactiveViews3 = 24,
		OpenCount_WriteBehind = 25,
		OpenCount_WriteBehindComplete = 26,
		OpenCount_WriteBehindFailAcquire = 27
	}
	public enum RTLP_CSPARSE_BITMAP_STATE
	{
		CommitBitmapInvalid = 0,
		UserBitmapInvalid = 1,
		UserBitmapValid = 2
	}
	public enum _RTLP_HP_ADDRESS_SPACE_TYPE
	{
		HeapAddressUser = 0,
		HeapAddressKernel = 1,
		HeapAddressSession = 2,
		HeapAddressSecureKernel = 3,
		HeapAddressTypeMax = 4
	}
	public enum _RTLP_HP_LOCK_TYPE
	{
		HeapLockPaged = 0,
		HeapLockNonPaged = 1,
		HeapLockTypeMax = 2
	}
	public enum _HEAP_LFH_LOCKMODE
	{
		HeapLockNotHeld = 0,
		HeapLockShared = 1,
		HeapLockExclusive = 2
	}
	public enum _HEAP_SEG_RANGE_TYPE
	{
		HeapSegRangeUser = 0,
		HeapSegRangeInternal = 1,
		HeapSegRangeLFH = 2,
		HeapSegRangeVS = 3,
		HeapSegRangeTypeMax = 3
	}
	public enum _RTLP_HP_ALLOCATOR
	{
		RtlpHpSegmentSm = 0,
		RtlpHpSegmentLg = 1,
		RtlpHpSegmentTypes = 2,
		RtlpHpHugeAllocator = 2,
		RtlpHpAllocatorMax = 3
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
		heap_failure_invalid_allocation_type = 10,
		heap_failure_usage_after_free = 11,
		heap_failure_cross_heap_operation = 12,
		heap_failure_freelists_corruption = 13,
		heap_failure_listentry_corruption = 14,
		heap_failure_lfh_bitmap_mismatch = 15,
		heap_failure_segment_lfh_bitmap_corruption = 16,
		heap_failure_segment_lfh_double_free = 17,
		heap_failure_vs_subsegment_corruption = 18,
		heap_failure_null_heap = 19,
		heap_failure_allocation_limit = 20,
		heap_failure_commit_limit = 21,
		heap_failure_invalid_va_mgr_query = 22
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
		WrPhysicalFault = 39,
		MaximumWaitReason = 40
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
	public enum _WNF_STATE_NAME_LIFETIME
	{
		WnfWellKnownStateName = 0,
		WnfPermanentStateName = 1,
		WnfPersistentStateName = 2,
		WnfTemporaryStateName = 3
	}
	public enum _WNF_DATA_SCOPE
	{
		WnfDataScopeSystem = 0,
		WnfDataScopeSession = 1,
		WnfDataScopeUser = 2,
		WnfDataScopeProcess = 3,
		WnfDataScopeMachine = 4,
		WnfDataScopePhysicalMachine = 5
	}
	public enum _WNF_SUBSCRIPTION_STATE
	{
		WNF_SUB_STATE_QUIESCENT = 0,
		WNF_SUB_STATE_READY_TO_DELIVER = 1,
		WNF_SUB_STATE_IN_DELIVERY = 2,
		WNF_SUB_STATE_RETRY = 3
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
		FoExtTypeMemoryPartitionInfo = 8,
		MaxFoExtTypes = 9
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
	public enum _POP_DIRECTED_DRIPS_PROBLEM_DEVICE_REASON
	{
		DirectedDripsProblemDeviceReasonSpecialDevice = 0,
		DirectedDripsProblemDeviceReasonNoDfx = 1,
		DirectedDripsProblemDeviceReasonNoPs4 = 2,
		DirectedDripsProblemDeviceReasonNoPs4Root = 3,
		DirectedDripsProblemDeviceReasonComponentContraint = 4,
		DirectedDripsProblemDeviceReasonDfxFailure = 5,
		DirectedDripsProblemDeviceReasonPagingDevice = 6,
		DirectedDripsProblemDeviceReasonDebuggingDevice = 7,
		DirectedDripsProblemDeviceReasonDfxNotAllowed = 8,
		DirectedDripsProblemDeviceReasonMax = 9
	}
	public enum FEATURE_CHANGE_TIME
	{
		FEATURE_CHANGE_TIME_READ = 0,
		FEATURE_CHANGE_TIME_MODULE_RELOAD = 1,
		FEATURE_CHANGE_TIME_SESSION = 2,
		FEATURE_CHANGE_TIME_REBOOT = 3,
		FEATURE_CHANGE_TIME_USER_FLAG = 128
	}
	public enum _EX_HEAP_TYPE
	{
		ExHeapTypeNonPagedMin = 0,
		ExHeapTypeNonPaged = 0,
		ExHeapTypeNonPagedMax = 1,
		ExHeapTypeNonPagedNx = 1,
		ExHeapTypePagedMin = 2,
		ExHeapTypePaged = 2,
		ExHeapTypePagedMax = 3,
		ExHeapTypeMmSt = 3,
		ExHeapTypeMax = 4,
		ExHeapTypeSpecialMax = 4
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
	public enum _RTL_FEATURE_ENABLED_STATE_OPTIONS
	{
		FeatureEnabledStateOptionsNone = 0,
		FeatureEnabledStateOptionsWexpConfig = 1
	}
	public enum _POP_PEP_NOTIFY_DEVICE_DSTATE_REASON
	{
		PepNotifyDeviceDStateReasonNone = 0,
		PepNotifyDeviceDStateReasonSystemTransition = 1,
		PepNotifyDeviceDStateReasonDfx = 2,
		PepNotifyDeviceDStateReasonMax = 3
	}
	public enum _RTLP_HP_MEMORY_TYPE
	{
		HeapMemoryPaged = 0,
		HeapMemoryNonPaged = 1,
		HeapMemoryLargePage = 2,
		HeapMemoryHugePage = 3,
		HeapMemoryTypeMax = 4
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
	public enum _MI_ALTERNATE_LOCK_VA_TYPE
	{
		AlternateLockVaTypeSystemPtes = 0,
		AlternateLockVaTypeNonPagedPool = 1,
		AlternateLockVaTypeUser = 2,
		AlternateLockVaTypeSystem = 3,
		AlternateLockVaTypeMaximum = 4
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
		PopSleepCheckpointAllocatingHiberContextNoFileObject = 42,
		PopSleepCheckpointAllocatingHiberContextGetDumpStackFailed = 43,
		PopSleepCheckpointAllocatingHiberContextLoadResumeContextFailed = 44,
		PopSleepCheckpointAllocatingHiberContextBcdOpenFailed = 45,
		PopSleepCheckpointAllocatingHiberContextEstablishResumeObjectFailed = 46,
		PopSleepCheckpointAllocatingHiberContextSetPendingResumeFailed = 47,
		PopSleepCheckpointAllocatingHiberContextAllocateIoPagesPagesFailed = 48,
		PopSleepCheckpointAllocatingHiberContextAdapterBuffersInvalid1 = 49,
		PopSleepCheckpointAllocatingHiberContextAllocateDumpPagesFailed = 50,
		PopSleepCheckpointAllocatingHiberContextAdapterBuffersInvalid2 = 51,
		PopSleepCheckpointAllocatingHiberContextUnHibernatedMdlFailed = 52,
		PopSleepCheckpointAllocatingHiberContextSecureResourcesFailed = 53,
		PopSleepCheckpointPrepareSleepBefore = 54,
		PopSleepCheckpointPrepareSleepAfter = 55,
		PopSleepCheckpointBootstatAvailable = 56,
		PopSleepCheckpointMax = 57
	}
	public enum PDC_CS_PHASE
	{
		PdcNoCsPhase = 0,
		PdcConnectionPhase = 1,
		PdcShellPhase = 2,
		PdcPlmPhase = 3,
		PdcMaintenancePhase = 4,
		PdcDamPhase = 5,
		PdcLowPowerPhase = 6,
		PdcResiliencyNotificationPhase = 7,
		PdcResiliencyPhase = 8,
		PdcInvalidPhase = 9,
		PdcMaxPhase = 9
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
		JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ALL = 4,
		JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ON_SOFT_CAP = 8,
		JOB_OBJECT_IO_RATE_CONTROL_VALID_FLAGS = 15
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
	public enum _POP_SLEEP_CHECKPOINT_STATUS
	{
		PopSleepCheckpointStatusDisabled = 0,
		PopSleepCheckpointStatusEnabledDueToDirtyShutdown = 1,
		PopSleepCheckpointStatusEnabledManually = 4,
		PopSleepCheckpointStatusEnabledExperiment = 4,
		PopSleepCheckpointStatusEnabledMax = 7,
		PopSleepCheckpointStatusFailedNotEfiSystem = 8,
		PopSleepCheckpointStatusFailedInsufficientSpace = 9,
		PopSleepCheckpointStatusFailedTooSlow = 10,
		PopSleepCheckpointStatusFailedOtherError = 15,
		PopSleepCheckpointStatusMax = 15
	}
	public enum PDC_RESOURCE
	{
		PdcResourceSystemForeground = 0,
		PdcResourceUniversalApplications = 1,
		PdcResourceWin32 = 2,
		PdcResourceNetwork = 3,
		PdcResourceSystemBackground = 4,
		PdcResourceMin = 0,
		PdcResourceMax = 4
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
		TlgInCOUNTEDBINARY = 25,
		_TlgInMax = 26,
		TlgInINTPTR = 9,
		TlgInUINTPTR = 10,
		TlgInPOINTER = 21,
		TlgInLONG = 7,
		TlgInULONG = 8,
		TlgInHEXLONG = 20,
		_TlgInCcount = 32,
		TlgInVcount = 64,
		_TlgInChain = 128,
		_TlgInCustom = 96,
		_TlgInTypeMask = 31,
		_TlgInCountMask = 96,
		_TlgInFlagMask = 224
	}
	public enum _BUGCHECK_RECOVERY_LOG_EVENT
	{
		RecoveryEventStart = 0,
		RecoveryEventPhase1Status = 1,
		RecoveryEventPhase2Status = 2,
		RecoveryEventMax = 3
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
		PowerInternalReservedDoNotUseEnum9 = 9,
		PowerInternalReservedDoNotUseEnum10 = 10,
		PowerInternalReservedDoNotUseEnum11 = 11,
		PowerInternalReservedDoNotUseEnum12 = 12,
		PowerInternalReservedDoNotUseEnum13 = 13,
		PowerInternalReservedDoNotUseEnum14 = 14,
		PowerInternalReservedDoNotUseEnum15 = 15,
		PowerInternalReservedDoNotUseEnum16 = 16,
		PowerInternalReservedDoNotUseEnum17 = 17,
		PowerInternalBootSessionStandbyActivationInformation = 18,
		PowerInternalSessionPowerState = 19,
		PowerInternalSessionTerminalInput = 20,
		PowerInternalSetWatchdog = 21,
		PowerInternalPhysicalPowerButtonPressInfoAtBoot = 22,
		PowerInternalExternalMonitorConnected = 23,
		PowerInternalHighPrecisionBrightnessSettings = 24,
		PowerInternalWinrtScreenToggle = 25,
		PowerInternalPpmQosDisable = 26,
		PowerInternalTransitionCheckpoint = 27,
		PowerInternalInputControllerState = 28,
		PowerInternalFirmwareResetReason = 29,
		PowerInternalPpmSchedulerQosSupport = 30,
		PowerInternalBootStatGet = 31,
		PowerInternalBootStatSet = 32,
		PowerInternalCallHasNotReturnedWatchdog = 33,
		PowerInternalBootStatCheckIntegrity = 34,
		PowerInternalBootStatRestoreDefaults = 35,
		PowerInternalHostEsStateUpdate = 36,
		PowerInternalGetPowerActionState = 37,
		PowerInternalBootStatUnlock = 38,
		PowerInternalWakeOnVoiceState = 39,
		PowerInternalDeepSleepBlock = 40,
		PowerInternalIsPoFxDevice = 41,
		PowerInternalPowerTransitionExtensionAtBoot = 42,
		PowerInternalProcessorBrandedFrequency = 43,
		PowerInternalTimeBrokerExpirationReason = 44,
		PowerInternalNotifyUserShutdownStatus = 45,
		PowerInternalPowerRequestTerminalCoreWindow = 46,
		PowerInternalProcessorIdleVeto = 47,
		PowerInternalPlatformIdleVeto = 48,
		PowerInternalIsLongPowerButtonBugcheckEnabled = 49,
		PowerInternalAutoChkCausedReboot = 50,
		PowerInternalSetWakeAlarmOverride = 51,
		PowerInternalDirectedFxAddTestDevice = 53,
		PowerInternalDirectedFxRemoveTestDevice = 54,
		PowerInternalDirectedFxSetMode = 56,
		PowerInternalRegisterPowerPlane = 57,
		PowerInternalSetDirectedDripsFlags = 58,
		PowerInternalClearDirectedDripsFlags = 59,
		PowerInternalRetrieveHiberFileResumeContext = 60,
		PowerInternalReadHiberFilePage = 61,
		PowerInternalLastBootSucceeded = 62,
		PowerInternalQuerySleepStudyHelperRoutineBlock = 63,
		PowerInternalDirectedDripsQueryCapabilities = 64,
		PowerInternalClearConstraints = 65,
		PowerInternalSoftParkVelocityEnabled = 66,
		PowerInternalQueryIntelPepCapabilities = 67,
		PowerInformationInternalMaximum = 68
	}
	public enum _PS_STD_HANDLE_STATE
	{
		PsNeverDuplicate = 0,
		PsRequestDuplicate = 1,
		PsAlwaysDuplicate = 2,
		PsMaxStdHandleStates = 3
	}
	public enum _MEMORY_PHYSICAL_CONTIGUITY_UNIT_STATE
	{
		MemoryNotContiguous = 0,
		MemoryAlignedAndContiguous = 1,
		MemoryNotResident = 2,
		MemoryNotEligibleToMakeContiguous = 3,
		MemoryContiguityStateMax = 4
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
	public enum _RTL_MEMORY_TYPE
	{
		MemoryTypePaged = 0,
		MemoryTypeNonPaged = 1,
		MemoryTypeLargePage = 2,
		MemoryTypeHugePage = 3,
		MemoryTypeMax = 4
	}
	public enum wil_FeatureStage
	{
		wil_FeatureStage_AlwaysDisabled = 0,
		wil_FeatureStage_DisabledByDefault = 1,
		wil_FeatureStage_EnabledByDefault = 2,
		wil_FeatureStage_AlwaysEnabled = 3
	}
	public enum _KHETERO_RUNNING_TYPE
	{
		KHeteroShortRunning = 0,
		KHeteroLongRunning = 1,
		KHeteroRunningTypeMax = 2
	}
	public enum _HARDWARE_COUNTER_TYPE
	{
		PMCCounter = 0,
		MaxHardwareCounterType = 1
	}
	public enum _MI_SLAB_ALLOCATOR_PROTECTION
	{
		MiSlabAllocatorProtectionReadExecute = 0,
		MiSlabAllocatorProtectionReadOnly = 1,
		MiSlabAllocatorProtectionNoAccess = 2,
		MiSlabAllocatorProtectionReadWrite = 3,
		MiSlabAllocatorProtectionMax = 4
	}
	public enum _KTHREAD_TAG
	{
		KThreadTagNone = 0,
		KThreadTagMediaBuffering = 1,
		KThreadTagDeadline = 2,
		KThreadTagMax = 3
	}
	public enum _ETW_PERFECT_HASH_FUNCTION_TYPE
	{
		ETW_PHF_EVENT_ID = 0,
		ETW_PHF_STACK_WALK = 1,
		ETW_PHF_MAX_COUNT = 2
	}
	public enum _MI_ENCLAVE_TYPE
	{
		MiEnclaveNone = 0,
		MiEnclaveHardware = 1,
		MiEnclaveVsm = 2,
		MiEnclaveMax = 3
	}
	public enum _POWER_INFORMATION_LEVEL_INTERNAL_TTMTCAPI
	{
		PowerInformationInternalTtmFirst = 4096,
		PowerInternalTtmOpenTerminal = 4096,
		PowerInternalTtmCreateTerminal = 4097,
		PowerInternalTtmEvacuateDevices = 4098,
		PowerInternalTtmCreateTerminalEventQueue = 4099,
		PowerInternalTtmGetTerminalEvent = 4100,
		PowerInternalTtmSetDefaultDeviceAssignment = 4101,
		PowerInternalTtmAssignDevice = 4102,
		PowerInternalTtmSetDisplayState = 4103,
		PowerInternalTtmSetDisplayTimeouts = 4104,
		PowerInternalTtmSetDisplayPowerRequest = 4105,
		PowerInternalTtmSetInputWakeCapability = 4106,
		PowerInformationInternalTtmLast = 4106
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
		LoaderSkMemory = 36,
		LoaderSkFirmwareReserved = 37,
		LoaderIoSpaceMemoryZeroed = 38,
		LoaderIoSpaceMemoryFree = 39,
		LoaderIoSpaceMemoryKsr = 40,
		LoaderMaximum = 41
	}
	public enum _VRF_RULE_CLASS_ID
	{
		VrfSpecialPoolRuleClass = 0,
		VrfForceIrqlRuleClass = 1,
		VrfAllocationFailuresRuleClass = 2,
		VrfTrackingPoolAllocationsRuleClass = 3,
		VrfIORuleClass = 4,
		VrfDeadlockPreventionRuleClass = 5,
		VrfEnhancedIORuleClass = 6,
		VrfDMARuleClass = 7,
		VrfSecurityRuleClass = 8,
		VrfForcePendingIORequestRuleClass = 9,
		VrfIRPTrackingRuleClass = 10,
		VrfMiscellaneousRuleClass = 11,
		VrfMoreDebuggingRuleClass = 12,
		VrfMDLInvariantStackRuleClass = 13,
		VrfMDLInvariantDriverRuleClass = 14,
		VrfPowerDelayFuzzingRuleClass = 15,
		VrfPortMiniportRuleClass = 16,
		VrfStandardDDIRuleClass = 17,
		VrfAutoFailRuleClass = 18,
		VrfAdditionalDDIRuleClass = 19,
		VrfRuleClassBase = 20,
		VrfNdisWifiRuleClass = 21,
		VrfDriverLoggingRuleClass = 22,
		VrfSyncDelayFuzzingRuleClass = 23,
		VrfVMSwitchingRuleClass = 24,
		VrfCodeIntegrityRuleClass = 25,
		VrfBelow4GBAllocationRuleClass = 26,
		VrfProcessorBranchTraceRuleClass = 27,
		VrfAdvancedMMRuleClass = 28,
		VrfExtendingXDVTimeLimit = 29,
		VrfSystemBIOSRuleClass = 30,
		VrfHardwareRuleClass = 31,
		VrfStateSepRuleClass = 32,
		VrfWDFRuleClass = 33,
		VrfMoreIrqlRuleClass = 34,
		VrfXDVPlatformMode = 35,
		VrfStandalonePlatformMode = 36,
		VrfPlatformModeTest = 37,
		VrfInfoDisclosureIRPRule = 38,
		VrfLwSpecialPool = 39,
		VrfAVXCorruption = 40,
		VrfAccessModeMismatch = 41,
		ReservedForDVRF42 = 42,
		ReservedForDVRF43 = 43,
		ReservedForDVRF44 = 44,
		ReservedForDVRF45 = 45,
		ReservedForDVRF46 = 46,
		ReservedForDVRF47 = 47,
		ReservedForDVRF48 = 48,
		ReservedForDVRF49 = 49,
		ReservedForDVRF50 = 50,
		ReservedForDVRF51 = 51,
		ReservedForDVRF52 = 52,
		ReservedForDVRF53 = 53,
		ReservedForDVRF54 = 54,
		ReservedForDVRF55 = 55,
		ReservedForDVRF56 = 56,
		ReservedForDVRF57 = 57,
		ReservedForDVRF58 = 58,
		ReservedForDVRF59 = 59,
		ReservedForDVRF60 = 60,
		ReservedForDVRF61 = 61,
		ReservedForDVRF62 = 62,
		ReservedForDVRF63 = 63,
		VrfRuleClassSizeMax = 64
	}
	public enum _KE_WAKE_SOURCE_TYPE
	{
		KeWakeSourceTypeSpuriousWake = 0,
		KeWakeSourceTypeSpuriousClock = 1,
		KeWakeSourceTypeSpuriousInterrupt = 2,
		KeWakeSourceTypeQueryFailure = 3,
		KeWakeSourceTypeAccountingFailure = 4,
		KeWakeSourceTypeStaticSourceMax = 4,
		KeWakeSourceTypeInterrupt = 5,
		KeWakeSourceTypeIRTimer = 6,
		KeWakeSourceTypeMax = 7
	}
	public enum _MI_WORKING_SET_TYPE
	{
		MiWorkingSetTypeSystemCache = 0,
		MiWorkingSetTypeSystemViews = 1,
		MiWorkingSetTypePartitionMaximum = 1,
		MiWorkingSetTypePagedPool = 2,
		MiWorkingSetTypePagableMaximum = 2,
		MiWorkingSetTypeSystemPtes = 3,
		MiWorkingSetTypeKernelStacks = 4,
		MiWorkingSetTypeNonPagedPool = 5,
		MiWorkingSetTypeMaximum = 6
	}
	public enum _KTIMER2_COLLECTION_INDEX
	{
		KTimer2CollectionNoWake = 0,
		KTimer2CollectionHr = 1,
		KTimer2CollectionPseudoHr = 2,
		KTimer2CollectionFinite = 3,
		KTimer2CollectionIr = 4,
		KTimer2CollectionNotInserted = 16,
		KTimer2CollectionInvalid = 21,
		KTimer2CollectionOptional = 32,
		KTimer2CollectionMin = 0,
		KTimer2CollectionMax = 5,
		KTimer2CollectionNode1 = 2
	}
	public enum _SKSERVICE
	{
		SECURESERVICE_NONE = 0,
		SECURESERVICE_PHASE4_INIT = 1,
		SECURESERVICE_START_PROCESSOR = 2,
		SECURESERVICE_FINISH_START_PROCESSOR = 3,
		SECURESERVICE_REGISTER_SYSTEM_DLLS = 4,
		SECURESERVICE_REGISTER_SYSTEM_PROCESS = 5,
		SECURESERVICE_CREATE_PROCESS = 6,
		SECURESERVICE_INITIALIZE_PROCESS = 7,
		SECURESERVICE_CREATE_THREAD = 8,
		SECURESERVICE_REQUEST_THREAD_EXIT = 9,
		SECURESERVICE_TERMINATE_THREAD = 10,
		SECURESERVICE_RUNDOWN_PROCESS = 11,
		SECURESERVICE_DEBUG_PROCESS = 12,
		SECURESERVICE_GET_TEB_ADDRESS = 13,
		SECURESERVICE_GET_CONTEXT = 14,
		SECURESERVICE_SET_CONTEXT = 15,
		SECURESERVICE_SEND_ATTACH_NOTIFICATIONS = 16,
		SECURESERVICE_GET_ETW_DEBUG_ID = 17,
		SECURESERVICE_GET_ON_DEMAND_DEBUG_CHALLENGE = 18,
		SECURESERVICE_ENABLE_ON_DEMAND_DEBUG_WITH_RESPONSE = 19,
		SECURESERVICE_RETRIEVE_MAILBOX = 20,
		SECURESERVICE_IS_TRUSTLET_RUNNING = 21,
		SECURESERVICE_CREATE_SECURE_ALLOCATION = 22,
		SECURESERVICE_FILL_SECURE_ALLOCATION = 23,
		SECURESERVICE_MAKE_CODE_CATALOG = 24,
		SECURESERVICE_CREATE_SECURE_IMAGE = 25,
		SECURESERVICE_FINALIZE_SECURE_IMAGE_HASH = 26,
		SECURESERVICE_FINISH_SECURE_IMAGE_VALIDATION = 27,
		SECURESERVICE_PREPARE_IMAGE_RELOCATIONS = 28,
		SECURESERVICE_RELOCATE_IMAGE = 29,
		SECURESERVICE_CLOSE_SECURE_HANDLE = 30,
		SECURESERVICE_VALIDATE_DYNAMIC_CODE = 31,
		SECURESERVICE_TRANSFER_IMAGE_VERSION_RESOURCE = 32,
		SECURESERVICE_SET_CODE_INTEGRITY_POLICY = 33,
		SECURESERVICE_EXCHANGE_ENTROPY = 34,
		SECURESERVICE_ALLOCATE_HIBERNATE_RESOURCES = 35,
		SECURESERVICE_FREE_HIBERNATE_RESOURCES = 36,
		SECURESERVICE_CONFIGURE_DYNAMIC_MEMORY = 37,
		SECURESERVICE_DEBUG_PROTECT_MEMORY = 38,
		SECURESERVICE_DEBUG_READ_WRITE_MEMORY = 39,
		SECURESERVICE_QUERY_VIRTUAL_MEMORY = 40,
		SECURESERVICE_CAPTURE_IMAGE_IAT = 41,
		SECURESERVICE_FREE_IMAGE_IAT = 42,
		SECURESERVICE_APPLY_FIXUPS = 43,
		SECURESERVICE_MARK_IMAGE_PROTECTED = 44,
		SECURESERVICE_CREATE_ENCLAVE = 45,
		SECURESERVICE_LOAD_ENCLAVE_DATA = 46,
		SECURESERVICE_LOAD_ENCLAVE_MODULE = 47,
		SECURESERVICE_INITIALIZE_ENCLAVE = 48,
		SECURESERVICE_TERMINATE_ENCLAVE = 49,
		SECURESERVICE_DELETE_ENCLAVE = 50,
		SECURESERVICE_CONNECT_SW_INTERRUPT = 51,
		SECURESERVICE_RELAX_HYPERGUARD_QUOTA = 52,
		SECURESERVICE_LIVEDUMP_QUERY_SECONDARYDATA_SIZE = 53,
		SECURESERVICE_LIVEDUMP_START = 54,
		SECURESERVICE_LIVEDUMP_ADD_BUFFER = 55,
		SECURESERVICE_LIVEDUMP_SETUP_BUFFER = 56,
		SECURESERVICE_LIVEDUMP_FINALIZE = 57,
		SECURESERVICE_LIVEDUMP_ABORT = 58,
		SECURESERVICE_LIVEDUMP_CAPTURE_PROCESS = 59,
		SECURESERVICE_NOTIFY_POWER_STATE = 60,
		SECURESERVICE_QUERY_PROFILE_INFORMATION = 61,
		SECURESERVICE_UPDATE_FREEZE_BIAS = 62,
		SECURESERVICE_CREATE_SECURE_SECTION = 63,
		SECURESERVICE_DELETE_SECURE_SECTION = 64,
		SECURESERVICE_QUERY_SECURE_DEVICE = 65,
		SECURESERVICE_UNPROTECT_SECURE_DEVICE = 66,
		SECURESERVICE_DETERMINE_HOT_PATCH_TYPE = 67,
		SECURESERVICE_OBTAIN_PATCH_UNDO_TABLE_SIZE = 68,
		SECURESERVICE_OBTAIN_PATCH_UNDO_TABLE = 69,
		SECURESERVICE_APPLY_HOT_PATCH = 70,
		SECURESERVICE_REVERT_HOT_PATCH = 71,
		SECURESERVICE_PREPARE_DRIVER_FOR_PATCH = 72,
		SECURESERVICE_PROVISION_DUMP_KEYS = 73,
		SECURESERVICE_CAPTURE_PGO_DATA = 74,
		SECURESERVICE_START_PROFILE = 75,
		SECURESERVICE_STOP_PROFILE = 76,
		SECURESERVICE_SET_TRACEPOINT = 77,
		SECURESERVICE_NO_TRACING_FIRST = 191,
		SECURESERVICE_GET_PEB_ADDRESS = 192,
		SECURESERVICE_VALIDATE_SECURE_IMAGE_PAGES = 193,
		SECURESERVICE_PRE_INIT_FIRST = 207,
		SECURESERVICE_PHASE3_INIT = 208,
		SECURESERVICE_PERIODIC = 209,
		SECURESERVICE_WORK_QUEUE = 210,
		SECURESERVICE_RESERVE_PROTECTED_PAGES = 211,
		SECURESERVICE_APPLY_DYNAMIC_RELOCATIONS = 212,
		SECURESERVICE_ETW_ENABLE_CALLBACK = 213,
		SECURESERVICE_INITIALIZE_SECURE_POOL = 214,
		SECURESERVICE_INITIALIZE_KERNEL_CFG = 215,
		SECURESERVICE_LOAD_DRIVER = 216,
		SECURESERVICE_UNLOAD_DRIVER = 217,
		SECURESERVICE_ENABLE_CFG_TARGET = 218,
		SECURESERVICE_COMPLETE_SLAB_CONFIGURATION = 219,
		SECURESERVICE_INITIALIZE_RETPOLINE = 220,
		SECURESERVICE_PERFORM_RETPOLINE_RELOCATIONS = 221,
		SECURESERVICE_UPDATE_IMPORT_RELOCATIONS = 222,
		SECURESERVICE_DISPATCH_LEVEL_FIRST = 239,
		SECURESERVICE_FLUSH_ADDRESS_SPACE = 240,
		SECURESERVICE_FAST_FLUSH_RANGE_LIST = 241,
		SECURESERVICE_SLOW_FLUSH_RANGE_LIST = 242,
		SECURESERVICE_REMOVE_PROTECTED_PAGE = 243,
		SECURESERVICE_COPY_PROTECTED_PAGE = 244,
		SECURESERVICE_REGISTER_PROTECTED_PAGE = 245,
		SECURESERVICE_DISAMBIGUATE_PROTECTED_PAGE = 246,
		SECURESERVICE_MAKE_PROTECTED_PAGE_WRITABLE = 247,
		SECURESERVICE_MAKE_PROTECTED_PAGE_EXECUTABLE = 248,
		SECURESERVICE_QUERY_STRONG_CODE_FEATURES = 249,
		SECURESERVICE_INVOKE_EFI_RUNTIME_SERVICE = 250,
		SECURESERVICE_LIVEDUMP_COLLECT_LIVE_DUMP = 251,
		SECURESERVICE_REGISTER_LOG_PAGES = 252,
		SECURESERVICE_RECLAIM_PARTITION_PAGES = 253,
		SECURESERVICE_BIND_NT_KERNEL_IMPORTS = 254,
		SECURESERVICE_SET_PLACEHOLDER_PAGES = 255,
		SECURESERVICE_QUERY_SPECULATION_CONTROL_FEATURES = 256,
		SECURESERVICE_PROTECT_KERNEL_DATA_PAGE = 257,
		SECURESERVICE_VERIFY_PAGE = 258,
		SECURESERVICE_PREPARE_FOR_HIBERNATION = 259,
		SECURESERVICE_PREPARE_FOR_CRASHDUMP = 260,
		SECURESERVICE_REPORT_BUGCHECK_PROGRESS = 261,
		SECURESERVICE_SHUTDOWN = 262,
		SECURESERVICE_QUERY_SECURE_PCI_INFO = 263,
		SECURESERVICE_ACCESS_PCI_DEVICE = 264,
		SECURESERVICE_REINITIALIZE_DEBUGGER_TRANSPORT = 265,
		SECURESERVICE_KSR_CALL = 266,
		SECURESERVICE_SVC_CALL = 267,
		SECURESERVICE_BUGCHECK = 1792,
		SECURESERVICE_LIMITED_MODE_SERVICE_START = 2048
	}
	public enum _PS_PROTECTED_TYPE
	{
		PsProtectedTypeNone = 0,
		PsProtectedTypeProtectedLight = 1,
		PsProtectedTypeProtected = 2,
		PsProtectedTypeMax = 3
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
	public enum KD_CALLBACK_ACTION
	{
		KdConfigureDeviceAndContinue = 0,
		KdSkipDeviceAndContinue = 1,
		KdConfigureDeviceAndStop = 2,
		KdSkipDeviceAndStop = 3
	}
	public enum _HAL_CLOCK_TIMER_MODE
	{
		HalClockTimerModePeriodic = 0,
		HalClockTimerModeOneShot = 1,
		HalClockTimerModeMax = 2
	}
	public enum _HAL_PROCESSOR_STAT_TYPE
	{
		HalProcessorStatResidency = 0,
		HalProcessorStatCount = 1,
		HalProcessorStatMax = 2
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
	public enum _HEAP_SEGMGR_LARGE_PAGE_POLICY
	{
		HeapSegMgrNoLargePages = 0,
		HeapSegMgrEnableLargePages = 1,
		HeapSegMgrNormalPolicy = 1,
		HeapSegMgrForceSmall = 2,
		HeapSegMgrForceLarge = 3,
		HeapSegMgrForceRandom = 4,
		HeapSegMgrLargePagePolicyMax = 5
	}
	public enum _RTL_FEATURE_CONFIGURATION_PRIORITY
	{
		FeatureConfigurationPriorityImageDefault = 0,
		FeatureConfigurationPriorityService = 4,
		FeatureConfigurationPriorityUser = 8,
		FeatureConfigurationPriorityUserPolicy = 10,
		FeatureConfigurationPriorityTest = 12,
		FeatureConfigurationPriorityImageOverride = 15,
		FeatureConfigurationPriorityMax = 15
	}
	public enum _PERFINFO_KERNELMEMORY_USAGE_TYPE
	{
		PerfInfoMemUsagePfnMetadata = 0,
		PerfInfoMemUsageMax = 1
	}
	public enum FEATURE_ENABLED_STATE
	{
		FEATURE_ENABLED_STATE_DEFAULT = 0,
		FEATURE_ENABLED_STATE_DISABLED = 1,
		FEATURE_ENABLED_STATE_ENABLED = 2,
		FEATURE_ENABLED_STATE_HAS_NOTIFICATION = 128,
		FEATURE_ENABLED_STATE_HAS_VARIANT_CONFIGURATION = 64
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
		PolicySystemInitiatedShutdown = 15,
		PolicyDeviceMax = 16
	}
	public enum _PCI_BUSMASTER_RID_TYPE
	{
		BusmasterRidFromDeviceRid = 0,
		BusmasterRidFromBridgeRid = 1,
		BusmasterRidFromMultipleBridges = 2
	}
	public enum _WORKING_SET_TYPE
	{
		WorkingSetTypeUser = 0,
		WorkingSetTypeSession = 1,
		WorkingSetTypeSystemTypes = 2,
		WorkingSetTypeSystemCache = 2,
		WorkingSetTypePagedPool = 3,
		WorkingSetTypeSystemViews = 4,
		WorkingSetTypePagableMaximum = 4,
		WorkingSetTypeSystemPtes = 5,
		WorkingSetTypeKernelStacks = 6,
		WorkingSetTypeNonPagedPool = 7,
		WorkingSetTypeMaximum = 8
	}
	public enum _DEVICE_RELATION_LEVEL
	{
		RELATION_LEVEL_REMOVE_EJECT = 0,
		RELATION_LEVEL_DEPENDENT = 1,
		RELATION_LEVEL_DIRECT_DESCENDANT = 2
	}
	public enum _ETW_STRING_TOKEN_TYPE
	{
		ETW_STRING_TOKEN_EXE = 0,
		ETW_STRING_TOKEN_PACKAGE_ID = 1,
		ETW_STRING_TOKEN_PKG_APP_ID = 2,
		ETW_STRING_TOKEN_CONTAINER = 3,
		ETW_STRING_TOKEN_MAX_COUNT = 4
	}
	public enum _POP_FX_WORK_POOL_QUEUE
	{
		PopFxWorkPoolQueueEmergency = 0,
		PopFxWorkPoolQueuePlugin = 1,
		PopFxWorkPoolQueueMax = 2
	}
	public enum _POP_SYSTEM_IDLE_EVENT_TYPE
	{
		PopSystemIdleEventTypeMonitorOffUserInput = 0,
		PopSystemIdleEventTypeMonitorOnUserInput = 1,
		PopSystemIdleEventTypeUserPresence = 2,
		PopSystemIdleEventTypeResumeFromSxSystemPowerState = 3,
		PopSystemIdleEventTypeMax = 4,
		PopSystemIdleEventTypeInvalid = 4
	}
	public enum _MI_DYNAMICBASE_BITMAP
	{
		DynamicBaseBitMapNative = 0,
		DynamicBaseBitMap64Low = 1,
		DynamicBaseBitMap64LowWow = 2,
		DynamicBaseBitMap32WowFirst = 3,
		DynamicBaseBitMap32WowLast = 3,
		DynamicBaseBitMapInvalid = 4,
		DynamicBaseBitMapMax = 4
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
	public enum _KTHREAD_PPM_POLICY
	{
		ThreadPpmDefault = 0,
		ThreadPpmThrottle = 1,
		ThreadPpmSemiThrottle = 2,
		ThreadPpmNoThrottle = 3,
		MaxThreadPpmPolicy = 4
	}
	public enum _KPROCESS_PPM_POLICY
	{
		ProcessPpmDefault = 0,
		ProcessPpmThrottle = 1,
		ProcessPpmSemiThrottle = 2,
		ProcessPpmNoThrottle = 3,
		ProcessPpmWindowMinimized = 4,
		ProcessPpmWindowOccluded = 5,
		ProcessPpmWindowVisible = 6,
		ProcessPpmWindowInFocus = 7,
		MaxProcessPpmPolicy = 8
	}
	public enum _MI_SHARED_USER_PAGE_TYPES
	{
		MiSharedUserPageKernel = 0,
		MiSharedUserPageHypervisor = 1,
		MiSharedUserPageMaximum = 2
	}
	public enum _TlgBlob_t
	{
		_TlgBlobNone = 0,
		_TlgBlobEnd = 1,
		_TlgBlobProvider = 2,
		_TlgBlobEvent3 = 3,
		_TlgBlobProvider3 = 4,
		_TlgBlobEvent2 = 5,
		_TlgBlobEvent4 = 6,
		_TlgBlobMax = 7
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
	public enum _CM_DIRTY_VECTOR_OPERATION
	{
		DirtyVectorModified = 0,
		DirtyDataCaptureStart = 1,
		DirtyDataCaptureEnd = 2
	}
	public enum _SYSTEM_PROCESS_CLASSIFICATION
	{
		SystemProcessClassificationNormal = 0,
		SystemProcessClassificationSystem = 1,
		SystemProcessClassificationSecureSystem = 2,
		SystemProcessClassificationMemCompression = 3,
		SystemProcessClassificationRegistry = 4,
		SystemProcessClassificationMaximum = 5
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
		ConfigureDeviceReset = 24,
		ClearDmaGuardProblem = 25,
		PnpDeviceActionRequestMax = 26
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
		SharedNtdll32RtlpFreezeTimeBias = 8,
		Wow64SharedPageEntriesCount = 9
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
	public enum _POP_DEEP_SLEEP_DISENGAGE_REASON
	{
		PopDeepSleepDisengageReasonInactive = 0,
		PopDeepSleepDisengageReasonNonAoAc = 1,
		PopDeepSleepDisengageReasonPendingIrps = 2,
		PopDeepSleepDisengageReasonPowerSettings = 3,
		PopDeepSleepDisengageReasonDozeS4WorkerQueued = 4,
		PopDeepSleepDisengageReasonSystemPowerTransition = 5,
		PopDeepSleepDisengageReasonDeviceBlockingDrips = 6,
		PopDeepSleepDisengageReasonAcpi = 7,
		PopDeepSleepDisengageReasonDirectedDripsTransition = 8,
		PopDeepSleepDisengageReasonPepPreVeto = 9,
		PopDeepSleepDisengageReasonMax = 10
	}
	public enum _KI_CALLBACK
	{
		KiCallbackNmi = 0,
		KiCallbackBound = 1,
		KiCallbackSx = 2,
		KiCallbackCount = 3,
		KiFirstCallback = 0
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
		MiSubVadPebTebBelow4gb = 1,
		MiSubVadMaximum = 2
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
		AssignedRegionKernelStacks = 8,
		AssignedRegionPageTables = 9,
		AssignedRegionSession = 10,
		AssignedRegionSecureNonPagedPool = 11,
		AssignedRegionSystemImages = 12,
		AssignedRegionMaximum = 13
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
	public enum KD_NAMESPACE_ENUM
	{
		KdNameSpacePCI = 0,
		KdNameSpaceACPI = 1,
		KdNameSpaceAny = 2,
		KdNameSpaceNone = 3,
		KdNameSpaceMax = 4
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
	public enum _EXQUEUEINDEX
	{
		ExPoolUntrusted = 0,
		IoPoolUntrusted = 1,
		ExPoolMax = 8
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
	public enum _ADD_DRIVER_STAGE
	{
		ClassConfigFilters = 0,
		LowerDeviceFilters = 1,
		LowerClassFilters = 2,
		DeviceService = 3,
		UpperDeviceFilters = 4,
		UpperClassFilters = 5,
		MaximumAddStage = 6
	}
	public enum _INVPCID_TYPE
	{
		InvpcidIndividualAddress = 0,
		InvpcidSingleContext = 1,
		InvpcidAllContextAndGlobals = 2,
		InvpcidAllContext = 3
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
		TlgOutCODE_POINTER = 37,
		TlgOutDATETIME_UTC = 38,
		_TlgOutMax = 39,
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
	public enum _MI_PARTITION_THREAD
	{
		MiZeroPageThreadSlot = 0,
		MiRebuildLargePagesThreadSlot = 1,
		MiPartitionWorkingSetManagerSlot = 2,
		MiDereferenceSegmentThreadSlot = 3,
		MiModifiedPageWriterSlot = 4,
		MiMappedPageWriterSlot = 5,
		MiNumberOfPartitionThreads = 6
	}
	public enum _PERFINFO_MM_STAT
	{
		PerfInfoMMStatNotUsed = 0,
		PerfInfoMMStatAggregatePageCombine = 1,
		PerfInfoMMStatIterationPageCombine = 2,
		PerfInfoMMStatMax = 3
	}
	public enum _MI_WRITE_TYPES
	{
		WriteTypeCached = 0,
		WriteTypeNonTemporal = 1,
		WriteTypeMaximum = 2
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
		PNP_VetoInsufficientRights = 12,
		PNP_VetoAlreadyRemoved = 13
	}
	public enum _MI_SLAB_ALLOCATOR_TYPE
	{
		MiSlabAllocatorTypeSlatProtected = 0,
		MiSlabAllocatorTypeUnprotected = 1,
		MiSlabAllocatorTypeMax = 2
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
		PDC_INTERNAL_CLIENT = 18,
		PDC_DEFAULT_KM_TEST_CLIENT_EXEMPTED = 19,
		PDC_DEFAULT_UM_TEST_CLIENT_EXEMPTED = 20,
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
		PDC_BITLOCKER_CLIENT = 56,
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
		PDC_HAM_CLIENT = 100,
		PDC_FILESHARINGSERVER_CLIENT = 101,
		PDC_DIRECTED_DRIPS_TASK_CLIENT = 102,
		PDC_DIRECTED_DRIPS_LPE_CLIENT = 103,
		PDC_DIRECTED_DRIPS_PLM_CLIENT = 104,
		PDC_HTTPSDATASOURCE_CLIENT = 105,
		PDC_TERMINALSERVER_CONNECTION_CLIENT = 106,
		PDC_TERMINALSERVER_SESSION_CLIENT = 107,
		PDC_ANYNETWORK_RESILIENCY_CLIENT = 108,
		PDC_XBOX_NUI_CLIENT = 110,
		PDC_WIFI_CALLING_IMS_CLIENT = 111,
		PDC_SLEEPSTUDY_HELPER_USER_CLIENT = 112,
		PDC_SLEEPSTUDY_HELPER_KERNEL_CLIENT = 113,
		PDC_CONTAINER_MANAGER_CLIENT = 114,
		PDC_NUMBER_OF_CLIENTS = 115
	}
	public enum SLEEPSTUDY_SPM_SCENARIO_CS_EXIT
	{
		SpmScenarioStopReasonUnspecified = 16,
		SpmScenarioStopReasonCsExit = 17,
		SpmScenarioStopReasonInternalSegmentTransition = 18,
		SpmScenarioStopReasonMax = 19
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
	public enum _PROC_HYPERVISOR_STATE
	{
		ProcHypervisorNone = 0,
		ProcHypervisorPresent = 1,
		ProcHypervisorPower = 2,
		ProcHypervisorHvCounters = 3
	}
	public enum _KHETERO_CPU_QOS
	{
		KHeteroCpuQosDefault = 0,
		KHeteroCpuQosHigh = 0,
		KHeteroCpuQosMedium = 1,
		KHeteroCpuQosLow = 2,
		KHeteroCpuQosMultimedia = 3,
		KHeteroCpuQosDeadline = 4,
		KHeteroCpuQosDynamic = 5,
		KHeteroCpuQosMax = 5
	}
	public enum _KRESOURCEMANAGER_STATE
	{
		KResourceManagerUninitialized = 0,
		KResourceManagerOffline = 1,
		KResourceManagerOnline = 2
	}
	public enum _THREAD_WORKLOAD_CLASS
	{
		ThreadWorkloadClassDefault = 0,
		ThreadWorkloadClassGraphics = 1,
		MaxThreadWorkloadClass = 2
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
		MiCrossPartitionLargePageResAvailCharge = 4,
		MiCrossPartitionLargePageCommitCharge = 5,
		MiCrossPartitionPageCloneResAvailCharge = 6,
		MiCrossPartitionMaximumCharge = 7
	}
	public enum _HV_EXT_EPF_MODE
	{
		HvExtEpfModeMin = 0,
		HvExtEpfModeNt = 0,
		HvExtEpfModeMax = 1
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
	public enum _POP_POWER_ACTION_WATCHDOG_STATE
	{
		PopPowerActionWatchdogStateDisabled = 0,
		PopPowerActionWatchdogStateTransitioning = 1,
		PopPowerActionWatchdogStateResuming = 2,
		PopPowerActionWatchdogStateMax = 3
	}
	public enum _SYSTEM_FEATURE_CONFIGURATION_SECTION_TYPE
	{
		SystemFeatureConfigurationSectionTypeBoot = 0,
		SystemFeatureConfigurationSectionTypeRuntime = 1,
		SystemFeatureConfigurationSectionTypeUsageTriggers = 2,
		SystemFeatureConfigurationSectionTypeCount = 3
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
		PsAttributeChpe = 26,
		PsAttributeMitigationAuditOptions = 27,
		PsAttributeMax = 28
	}
	public enum _PPM_PERF_QOS_DISABLE_REASON
	{
		PpmPerfQosDisableInternal = 0,
		PpmPerfQosDisableNoProfile = 1,
		PpmPerfQosDisableNoPolicy = 2,
		PpmPerfQosDisableInsufficientPolicy = 3,
		PpmPerfQosDisableMaxOverride = 4,
		PpmPerfQosDisableLowLatency = 5,
		PpmPerfQosDisableSmtScheduler = 6,
		PpmPerfQosDisableNoHardwareSupport = 7,
		PpmPerfQosDisableGroupPolicy = 8,
		PpmPerfQosDisableMax = 9
	}
	public enum _MI_VAD_ALLOCATION_CELL_TYPE
	{
		MiVadBottomUp = 0,
		MiVadStackPebTeb = 1,
		MiVadReserved64 = 2,
		MiVadAllocationCellMaximum = 3
	}
	public enum _ConnectionResourceConsumerDesc
	{
		ConnectionResourceConsumerDescIsUndefined = 0,
		ConnectionResourceConsumerDescIsDevice = 1,
		ConnectionResourceConsumerDescIsOpregion = 2,
		ConnectionResourceConsumerDescMax = 3
	}
	public enum _SYSTEM_INFORMATION_CLASS
	{
		SystemBasicInformation = 0,
		SystemProcessorInformation = 1,
		SystemPerformanceInformation = 2,
		SystemTimeOfDayInformation = 3,
		SystemPathInformation = 4,
		SystemProcessInformation = 5,
		SystemCallCountInformation = 6,
		SystemDeviceInformation = 7,
		SystemProcessorPerformanceInformation = 8,
		SystemFlagsInformation = 9,
		SystemCallTimeInformation = 10,
		SystemModuleInformation = 11,
		SystemLocksInformation = 12,
		SystemStackTraceInformation = 13,
		SystemPagedPoolInformation = 14,
		SystemNonPagedPoolInformation = 15,
		SystemHandleInformation = 16,
		SystemObjectInformation = 17,
		SystemPageFileInformation = 18,
		SystemVdmInstemulInformation = 19,
		SystemVdmBopInformation = 20,
		SystemFileCacheInformation = 21,
		SystemPoolTagInformation = 22,
		SystemInterruptInformation = 23,
		SystemDpcBehaviorInformation = 24,
		SystemFullMemoryInformation = 25,
		SystemLoadGdiDriverInformation = 26,
		SystemUnloadGdiDriverInformation = 27,
		SystemTimeAdjustmentInformation = 28,
		SystemSummaryMemoryInformation = 29,
		SystemMirrorMemoryInformation = 30,
		SystemPerformanceTraceInformation = 31,
		SystemObsolete0 = 32,
		SystemExceptionInformation = 33,
		SystemCrashDumpStateInformation = 34,
		SystemKernelDebuggerInformation = 35,
		SystemContextSwitchInformation = 36,
		SystemRegistryQuotaInformation = 37,
		SystemExtendServiceTableInformation = 38,
		SystemPrioritySeperation = 39,
		SystemVerifierAddDriverInformation = 40,
		SystemVerifierRemoveDriverInformation = 41,
		SystemProcessorIdleInformation = 42,
		SystemLegacyDriverInformation = 43,
		SystemCurrentTimeZoneInformation = 44,
		SystemLookasideInformation = 45,
		SystemTimeSlipNotification = 46,
		SystemSessionCreate = 47,
		SystemSessionDetach = 48,
		SystemSessionInformation = 49,
		SystemRangeStartInformation = 50,
		SystemVerifierInformation = 51,
		SystemVerifierThunkExtend = 52,
		SystemSessionProcessInformation = 53,
		SystemLoadGdiDriverInSystemSpace = 54,
		SystemNumaProcessorMap = 55,
		SystemPrefetcherInformation = 56,
		SystemExtendedProcessInformation = 57,
		SystemRecommendedSharedDataAlignment = 58,
		SystemComPlusPackage = 59,
		SystemNumaAvailableMemory = 60,
		SystemProcessorPowerInformation = 61,
		SystemEmulationBasicInformation = 62,
		SystemEmulationProcessorInformation = 63,
		SystemExtendedHandleInformation = 64,
		SystemLostDelayedWriteInformation = 65,
		SystemBigPoolInformation = 66,
		SystemSessionPoolTagInformation = 67,
		SystemSessionMappedViewInformation = 68,
		SystemHotpatchInformation = 69,
		SystemObjectSecurityMode = 70,
		SystemWatchdogTimerHandler = 71,
		SystemWatchdogTimerInformation = 72,
		SystemLogicalProcessorInformation = 73,
		SystemWow64SharedInformationObsolete = 74,
		SystemRegisterFirmwareTableInformationHandler = 75,
		SystemFirmwareTableInformation = 76,
		SystemModuleInformationEx = 77,
		SystemVerifierTriageInformation = 78,
		SystemSuperfetchInformation = 79,
		SystemMemoryListInformation = 80,
		SystemFileCacheInformationEx = 81,
		SystemThreadPriorityClientIdInformation = 82,
		SystemProcessorIdleCycleTimeInformation = 83,
		SystemVerifierCancellationInformation = 84,
		SystemProcessorPowerInformationEx = 85,
		SystemRefTraceInformation = 86,
		SystemSpecialPoolInformation = 87,
		SystemProcessIdInformation = 88,
		SystemErrorPortInformation = 89,
		SystemBootEnvironmentInformation = 90,
		SystemHypervisorInformation = 91,
		SystemVerifierInformationEx = 92,
		SystemTimeZoneInformation = 93,
		SystemImageFileExecutionOptionsInformation = 94,
		SystemCoverageInformation = 95,
		SystemPrefetchPatchInformation = 96,
		SystemVerifierFaultsInformation = 97,
		SystemSystemPartitionInformation = 98,
		SystemSystemDiskInformation = 99,
		SystemProcessorPerformanceDistribution = 100,
		SystemNumaProximityNodeInformation = 101,
		SystemDynamicTimeZoneInformation = 102,
		SystemCodeIntegrityInformation = 103,
		SystemProcessorMicrocodeUpdateInformation = 104,
		SystemProcessorBrandString = 105,
		SystemVirtualAddressInformation = 106,
		SystemLogicalProcessorAndGroupInformation = 107,
		SystemProcessorCycleTimeInformation = 108,
		SystemStoreInformation = 109,
		SystemRegistryAppendString = 110,
		SystemAitSamplingValue = 111,
		SystemVhdBootInformation = 112,
		SystemCpuQuotaInformation = 113,
		SystemNativeBasicInformation = 114,
		SystemErrorPortTimeouts = 115,
		SystemLowPriorityIoInformation = 116,
		SystemBootEntropyInformation = 117,
		SystemVerifierCountersInformation = 118,
		SystemPagedPoolInformationEx = 119,
		SystemSystemPtesInformationEx = 120,
		SystemNodeDistanceInformation = 121,
		SystemAcpiAuditInformation = 122,
		SystemBasicPerformanceInformation = 123,
		SystemQueryPerformanceCounterInformation = 124,
		SystemSessionBigPoolInformation = 125,
		SystemBootGraphicsInformation = 126,
		SystemScrubPhysicalMemoryInformation = 127,
		SystemBadPageInformation = 128,
		SystemProcessorProfileControlArea = 129,
		SystemCombinePhysicalMemoryInformation = 130,
		SystemEntropyInterruptTimingInformation = 131,
		SystemConsoleInformation = 132,
		SystemPlatformBinaryInformation = 133,
		SystemPolicyInformation = 134,
		SystemHypervisorProcessorCountInformation = 135,
		SystemDeviceDataInformation = 136,
		SystemDeviceDataEnumerationInformation = 137,
		SystemMemoryTopologyInformation = 138,
		SystemMemoryChannelInformation = 139,
		SystemBootLogoInformation = 140,
		SystemProcessorPerformanceInformationEx = 141,
		SystemCriticalProcessErrorLogInformation = 142,
		SystemSecureBootPolicyInformation = 143,
		SystemPageFileInformationEx = 144,
		SystemSecureBootInformation = 145,
		SystemEntropyInterruptTimingRawInformation = 146,
		SystemPortableWorkspaceEfiLauncherInformation = 147,
		SystemFullProcessInformation = 148,
		SystemKernelDebuggerInformationEx = 149,
		SystemBootMetadataInformation = 150,
		SystemSoftRebootInformation = 151,
		SystemElamCertificateInformation = 152,
		SystemOfflineDumpConfigInformation = 153,
		SystemProcessorFeaturesInformation = 154,
		SystemRegistryReconciliationInformation = 155,
		SystemEdidInformation = 156,
		SystemManufacturingInformation = 157,
		SystemEnergyEstimationConfigInformation = 158,
		SystemHypervisorDetailInformation = 159,
		SystemProcessorCycleStatsInformation = 160,
		SystemVmGenerationCountInformation = 161,
		SystemTrustedPlatformModuleInformation = 162,
		SystemKernelDebuggerFlags = 163,
		SystemCodeIntegrityPolicyInformation = 164,
		SystemIsolatedUserModeInformation = 165,
		SystemHardwareSecurityTestInterfaceResultsInformation = 166,
		SystemSingleModuleInformation = 167,
		SystemAllowedCpuSetsInformation = 168,
		SystemVsmProtectionInformation = 169,
		SystemInterruptCpuSetsInformation = 170,
		SystemSecureBootPolicyFullInformation = 171,
		SystemCodeIntegrityPolicyFullInformation = 172,
		SystemAffinitizedInterruptProcessorInformation = 173,
		SystemRootSiloInformation = 174,
		SystemCpuSetInformation = 175,
		SystemCpuSetTagInformation = 176,
		SystemWin32WerStartCallout = 177,
		SystemSecureKernelProfileInformation = 178,
		SystemCodeIntegrityPlatformManifestInformation = 179,
		SystemInterruptSteeringInformation = 180,
		SystemSupportedProcessorArchitectures = 181,
		SystemMemoryUsageInformation = 182,
		SystemCodeIntegrityCertificateInformation = 183,
		SystemPhysicalMemoryInformation = 184,
		SystemControlFlowTransition = 185,
		SystemKernelDebuggingAllowed = 186,
		SystemActivityModerationExeState = 187,
		SystemActivityModerationUserSettings = 188,
		SystemCodeIntegrityPoliciesFullInformation = 189,
		SystemCodeIntegrityUnlockInformation = 190,
		SystemIntegrityQuotaInformation = 191,
		SystemFlushInformation = 192,
		SystemProcessorIdleMaskInformation = 193,
		SystemSecureDumpEncryptionInformation = 194,
		SystemWriteConstraintInformation = 195,
		SystemKernelVaShadowInformation = 196,
		SystemHypervisorSharedPageInformation = 197,
		SystemFirmwareBootPerformanceInformation = 198,
		SystemCodeIntegrityVerificationInformation = 199,
		SystemFirmwarePartitionInformation = 200,
		SystemSpeculationControlInformation = 201,
		SystemDmaGuardPolicyInformation = 202,
		SystemEnclaveLaunchControlInformation = 203,
		SystemWorkloadAllowedCpuSetsInformation = 204,
		SystemCodeIntegrityUnlockModeInformation = 205,
		SystemLeapSecondInformation = 206,
		SystemFlags2Information = 207,
		SystemSecurityModelInformation = 208,
		SystemCodeIntegritySyntheticCacheInformation = 209,
		SystemFeatureConfigurationInformation = 210,
		SystemFeatureConfigurationSectionInformation = 211,
		SystemFeatureUsageSubscriptionInformation = 212,
		SystemSecureSpeculationControlInformation = 213,
		SystemSpacesBootInformation = 214,
		SystemFwRamdiskInformation = 215,
		SystemWheaIpmiHardwareInformation = 216,
		SystemDifSetRuleClassInformation = 217,
		SystemDifClearRuleClassInformation = 218,
		SystemDifApplyPluginVerificationOnDriver = 219,
		SystemDifRemovePluginVerificationOnDriver = 220,
		SystemShadowStackInformation = 221,
		SystemBuildVersionInformation = 222,
		SystemPoolLimitInformation = 223,
		SystemCodeIntegrityAddDynamicStore = 224,
		SystemCodeIntegrityClearDynamicStores = 225,
		SystemPoolZeroingInformation = 227,
		MaxSystemInfoClass = 228
	}
	public enum _PROCESS_TERMINATE_REQUEST_REASON
	{
		ProcessTerminateRequestReasonNone = 0,
		ProcessTerminateCommitFail = 1,
		ProcessTerminateWriteToExecuteMemory = 2,
		ProcessTerminateAttachedWriteToExecuteMemory = 3,
		ProcessTerminateRequestReasonMax = 4
	}
	public enum _VRF_TRIAGE_CONTEXT
	{
		VRF_TRIAGE_CONTEXT_NONE = 0,
		VRF_TRIAGE_CONTEXT_DEFAULT = 1,
		VRF_TRIAGE_CONTEXT_DEVELOPMENT = 1,
		VRF_TRIAGE_CONTEXT_CERTIFICATION = 2,
		VRF_TRIAGE_CONTEXT_FLIGHT_TARGETED = 3,
		VRF_TRIAGE_CONTEXT_FLIGHT_DIAGNOSTICS = 4,
		VRF_TRIAGE_CONTEXT_FLIGHT_MONITORING = 5,
		NUM_VRF_TRIAGE_CONTEXTS = 6
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
		NmiStackLimits = 8,
		MachineCheckStackLimits = 9,
		ExceptionStackLimits = 10,
		MaximumStackLimits = 11
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
		PdcAnyNetwork = 4,
		PdcInvalidActivity = 5,
		PdcMaxActivity = 5
	}
	public enum JOB_OBJECT_NET_RATE_CONTROL_FLAGS
	{
		JOB_OBJECT_NET_RATE_CONTROL_ENABLE = 1,
		JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH = 2,
		JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG = 4,
		JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS = 7
	}
	public enum _MI_INPAGE_SUPPORT_TYPES
	{
		MiInPageSupportExpanded = 0,
		MiInPageSupportRegular = 1,
		MiInPageSupportMaximum = 2
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
		LoadReasonEnclavePrimary = 7,
		LoadReasonEnclaveDependency = 8,
		LoadReasonUnknown = -1
	}
	public enum _KCONTINUE_TYPE
	{
		KCONTINUE_UNWIND = 0,
		KCONTINUE_RESUME = 1,
		KCONTINUE_LONGJUMP = 2,
		KCONTINUE_SET = 3,
		KCONTINUE_LAST = 4
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
	public enum _FAULT_INFORMATION_ARCH
	{
		FaultInformationInvalid = 0,
		FaultInformationArm64 = 1,
		FaultInformationX64 = 2
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
	public enum _DOMAIN_CONFIGURATION_ARCH
	{
		DomainConfigurationArm64 = 0,
		DomainConfigurationInvalid = 1
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
	public enum _PROCESSOR_PRESENCE
	{
		ProcessorPresenceNt = 0,
		ProcessorPresenceHv = 1,
		ProcessorPresenceHidden = 2
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
	public enum _MACHINE_CHECK_NESTING_LEVEL
	{
		McheckNormal = 0,
		McheckNmi = 1,
		McheckNestingLevels = 2
	}
	public enum _FAULT_INFORMATION_ARM64_TYPE
	{
		UnsupportedUpstreamTransaction = 0,
		AddressSizeFault = 1,
		TlbMatchConflict = 2,
		ExternalFault = 3,
		PermissionFault = 4,
		AccessFlagFault = 5,
		TranslationFault = 6,
		MaxFaultType = 7
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
	public enum _PNP_WATCHDOG_TYPE
	{
		PNP_EVENT_WORKER_WATCHDOG = 1,
		PNP_DEVICE_COMPLETION_QUEUE_WATCHDOG = 2,
		PNP_DELAYED_REMOVE_WORKER_WATCHDOG = 3,
		PNP_ADD_DEVICE_WATCHDOG = 4,
		PNP_DRIVER_ENTRY_WATCHDOG = 5
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
	public enum _PEP_WORK_TYPE
	{
		PepWorkActiveComplete = 0,
		PepWorkRequestIdleState = 1,
		PepWorkDevicePower = 2,
		PepWorkRequestPowerControl = 3,
		PepWorkDeviceIdle = 4,
		PepWorkCompleteIdleState = 5,
		PepWorkCompletePerfState = 6,
		PepWorkAcpiNotify = 7,
		PepWorkAcpiEvaluateControlMethodComplete = 8,
		PepWorkMax = 9
	}
	public enum _CONFIGURATION_CLASS
	{
		SystemClass = 0,
		ProcessorClass = 1,
		CacheClass = 2,
		AdapterClass = 3,
		ControllerClass = 4,
		PeripheralClass = 5,
		MemoryClass = 6,
		MaximumClass = 7
	}
	public enum _CONFIGURATION_TYPE
	{
		ArcSystem = 0,
		CentralProcessor = 1,
		FloatingPointProcessor = 2,
		PrimaryIcache = 3,
		PrimaryDcache = 4,
		SecondaryIcache = 5,
		SecondaryDcache = 6,
		SecondaryCache = 7,
		EisaAdapter = 8,
		TcAdapter = 9,
		ScsiAdapter = 10,
		DtiAdapter = 11,
		MultiFunctionAdapter = 12,
		DiskController = 13,
		TapeController = 14,
		CdromController = 15,
		WormController = 16,
		SerialController = 17,
		NetworkController = 18,
		DisplayController = 19,
		ParallelController = 20,
		PointerController = 21,
		KeyboardController = 22,
		AudioController = 23,
		OtherController = 24,
		DiskPeripheral = 25,
		FloppyDiskPeripheral = 26,
		TapePeripheral = 27,
		ModemPeripheral = 28,
		MonitorPeripheral = 29,
		PrinterPeripheral = 30,
		PointerPeripheral = 31,
		KeyboardPeripheral = 32,
		TerminalPeripheral = 33,
		OtherPeripheral = 34,
		LinePeripheral = 35,
		NetworkPeripheral = 36,
		SystemMemory = 37,
		DockingInformation = 38,
		RealModeIrqRoutingTable = 39,
		RealModePCIEnumeration = 40,
		MaximumType = 41
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
	public enum _BOOT_ENTROPY_SOURCE_ID
	{
		BootEntropySourceNone = 0,
		BootEntropySourceSeedfile = 1,
		BootEntropySourceExternal = 2,
		BootEntropySourceTpm = 3,
		BootEntropySourceRdrand = 4,
		BootEntropySourceTime = 5,
		BootEntropySourceAcpiOem0 = 6,
		BootEntropySourceUefi = 7,
		BootEntropySourceCng = 8,
		BootEntropySourceTcbTpm = 9,
		BootEntropySourceTcbRdrand = 10,
		BootMaxEntropySources = 10
	}
	public enum _BOOT_ENTROPY_SOURCE_RESULT_CODE
	{
		BootEntropySourceStructureUninitialized = 0,
		BootEntropySourceDisabledByPolicy = 1,
		BootEntropySourceNotPresent = 2,
		BootEntropySourceError = 3,
		BootEntropySourceSuccess = 4
	}
	public enum _FS_FILTER_SECTION_SYNC_TYPE
	{
		SyncTypeOther = 0,
		SyncTypeCreateSection = 1
	}
}
