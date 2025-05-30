using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Attributes
{
public enum Enum
{
RunnableFunction_IsAuxiliary = -2063998118,
Advisor_AdviceType = 1119322868,
BandPassFilter_MinFrequency = 2130893816,
BandPassFilter_MaxFrequency = -603123580,
HighPassFilter_CutOffFrequency = 2084079197,
LowPassFilter_CutOffFrequency = 1462797068,
NumberOfSampleMovingAverage_NumberOfSamples = 2040418706,
TimeWindowMovingAverage_TimeWindow = -911071149,
Buffering_BufferingInterval = 313381433,
NumberOfItemsRangeExtraction_NumberOfItems = 2041030683,
TimeWindowRangeExtraction_TimeWindow = 1085733991,
Resampling_ResamplingRate = -149136369,
Resampling_ResamplingDelay = 1752808561,
Resampling_Validity = 1122634897,
DataProvider_ProviderName = 485622120,
OperatingCompany_ProviderName = -829131230,
ServiceCompany_ProviderName = 253139784,
DirectionalServiceCompany_ProviderName = 1747301166,
DrillingFluidProvider_ProviderName = 531900314,
LoggingServiceCompany_ProviderName = 1369713730,
CementingServiceCompany_ProviderName = 1239769520,
CompletionServiceCompany_ProviderName = -26917208,
DataAnalysisServiceCompany_ProviderName = -1685847133,
DrillingContractor_ProviderName = 1134700248,
DWISInternalService_ProviderName = -1465148749,
Telemetry_NumberOfRepeaters = -954680134,
Telemetry_DistanceBetweenRepeaters = -1192540267,
Telemetry_AverageDelayByRepeater = 380150302,
DrillingDataPoint_IsValid = 1959819129,
DrillingSignal_Value = -299749053,
DynamicDrillingSignal_TimeStampAtSource = 1558613875,
DynamicDrillingSignal_TimeStampAcquisition = -935264174,
DataEndPoint_EndPointDescription = -968925733,
WitsMLTimeBasedLogEndPoint_WellUID = -608066517,
WitsMLTimeBasedLogEndPoint_WellName = -604559850,
WitsMLTimeBasedLogEndPoint_WellboreUID = 15161007,
WitsMLTimeBasedLogEndPoint_WellboreName = -2140646413,
WitsMLTimeBasedLogEndPoint_LogUID = -2034702697,
WitsMLTimeBasedLogEndPoint_LogName = -1234846399,
WitsMLTimeBasedLogEndPoint_Mnemonic = 1429287018,
EndPointMapping_FixedIndices = 438049263,
EndPointMapping_ValuesIndices = 1542700943,
EndPointMapping_MeasurementIndex = 520147400,
HydraulicConnectedState_Value = -1789122708,
HydraulicJunction_LeftToRight = -1316621262,
HydraulicJunction_RightToLeft = 1823850378,
MechanicalElementState_Value = 868018065,
OneDimensionalReferenceFrame_PostiveUpward = 1880448666,
MeasurableQuantity_MeaningfulPrecision = -1099829417,
Quantity_L = 524012872,
Quantity_M = -1620334449,
Quantity_T = 1870509730,
Quantity_I = -251347970,
Quantity_ThT = -1845825940,
Quantity_N = -1571098099,
Quantity_J = -794979872,
Quantity_Theta = -640930536,
Quantity_Omega = -709576468,
Quantity_SIUnit = 1943893003,
Unit_Symbol = -533070104,
Unit_ConversionFactorA = -1287157022,
Unit_ConversionFactorB = -1634053112,
Clock_LeapSeconds = 655245674,
Clock_Stratum = -1781284458,
Clock_NetworkSynchronizationLatencyAverage = 1853649663,
Clock_NetworkSynchronizationLatencyStandardDeviation = 31775975,
Clock_Resolution = -1222078635,
Clock_MaximumFluctuations = -277011325,
SynchronizationGroup_SynchronizationDelay = 1414981425,
SynchronizationGroup_SamplingRate = 367098117,
FullScaleUncertainty_FullScale = 1487102208,
FullScaleUncertainty_ProportionError = -1456856141,
SensorUncertainty_Accuracy = 1354310316,
SensorUncertainty_Precision = -1679955584
}
	public const string RunnableFunction_IsAuxiliary = "IsAuxiliary";
	public const string RunnableFunction_IsAuxiliary_Type = "boolean";
	public const string Advisor_AdviceType = "AdviceType";
	public const string Advisor_AdviceType_Type = "string";
	public const string BandPassFilter_MinFrequency = "MinFrequency";
	public const string BandPassFilter_MinFrequency_Type = "double";
	public const string BandPassFilter_MaxFrequency = "MaxFrequency";
	public const string BandPassFilter_MaxFrequency_Type = "double";
	public const string HighPassFilter_CutOffFrequency = "CutOffFrequency";
	public const string HighPassFilter_CutOffFrequency_Type = "double";
	public const string LowPassFilter_CutOffFrequency = "CutOffFrequency";
	public const string LowPassFilter_CutOffFrequency_Type = "double";
	public const string NumberOfSampleMovingAverage_NumberOfSamples = "NumberOfSamples";
	public const string NumberOfSampleMovingAverage_NumberOfSamples_Type = "int";
	public const string TimeWindowMovingAverage_TimeWindow = "TimeWindow";
	public const string TimeWindowMovingAverage_TimeWindow_Type = "double";
	public const string Buffering_BufferingInterval = "BufferingInterval";
	public const string Buffering_BufferingInterval_Type = "double";
	public const string NumberOfItemsRangeExtraction_NumberOfItems = "NumberOfItems";
	public const string NumberOfItemsRangeExtraction_NumberOfItems_Type = "int";
	public const string TimeWindowRangeExtraction_TimeWindow = "TimeWindow";
	public const string TimeWindowRangeExtraction_TimeWindow_Type = "double";
	public const string Resampling_ResamplingRate = "ResamplingRate";
	public const string Resampling_ResamplingRate_Type = "double";
	public const string Resampling_ResamplingDelay = "ResamplingDelay";
	public const string Resampling_ResamplingDelay_Type = "double";
	public const string Resampling_Validity = "Validity";
	public const string Resampling_Validity_Type = "double";
	public const string DataProvider_ProviderName = "ProviderName";
	public const string DataProvider_ProviderName_Type = "string";
	public const string Telemetry_NumberOfRepeaters = "NumberOfRepeaters";
	public const string Telemetry_NumberOfRepeaters_Type = "int";
	public const string Telemetry_DistanceBetweenRepeaters = "DistanceBetweenRepeaters";
	public const string Telemetry_DistanceBetweenRepeaters_Type = "double";
	public const string Telemetry_AverageDelayByRepeater = "AverageDelayByRepeater";
	public const string Telemetry_AverageDelayByRepeater_Type = "double";
	public const string DrillingDataPoint_IsValid = "IsValid";
	public const string DrillingDataPoint_IsValid_Type = "bool";
	public const string DrillingSignal_Value = "Value";
	public const string DrillingSignal_Value_Type = "object";
	public const string DynamicDrillingSignal_TimeStampAtSource = "TimeStampAtSource";
	public const string DynamicDrillingSignal_TimeStampAtSource_Type = "DateTime";
	public const string DynamicDrillingSignal_TimeStampAcquisition = "TimeStampAcquisition";
	public const string DynamicDrillingSignal_TimeStampAcquisition_Type = "DateTime";
	public const string DataEndPoint_EndPointDescription = "EndPointDescription";
	public const string DataEndPoint_EndPointDescription_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_WellUID = "WellUID";
	public const string WitsMLTimeBasedLogEndPoint_WellUID_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_WellName = "WellName";
	public const string WitsMLTimeBasedLogEndPoint_WellName_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_WellboreUID = "WellboreUID";
	public const string WitsMLTimeBasedLogEndPoint_WellboreUID_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_WellboreName = "WellboreName";
	public const string WitsMLTimeBasedLogEndPoint_WellboreName_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_LogUID = "LogUID";
	public const string WitsMLTimeBasedLogEndPoint_LogUID_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_LogName = "LogName";
	public const string WitsMLTimeBasedLogEndPoint_LogName_Type = "string";
	public const string WitsMLTimeBasedLogEndPoint_Mnemonic = "Mnemonic";
	public const string WitsMLTimeBasedLogEndPoint_Mnemonic_Type = "string";
	public const string EndPointMapping_FixedIndices = "FixedIndices";
	public const string EndPointMapping_FixedIndices_Type = "int[]";
	public const string EndPointMapping_ValuesIndices = "ValuesIndices";
	public const string EndPointMapping_ValuesIndices_Type = "int[]";
	public const string EndPointMapping_MeasurementIndex = "MeasurementIndex";
	public const string EndPointMapping_MeasurementIndex_Type = "int";
	public const string HydraulicConnectedState_Value = "Value";
	public const string HydraulicConnectedState_Value_Type = "bool";
	public const string HydraulicJunction_LeftToRight = "LeftToRight";
	public const string HydraulicJunction_LeftToRight_Type = "bool";
	public const string HydraulicJunction_RightToLeft = "RightToLeft";
	public const string HydraulicJunction_RightToLeft_Type = "bool";
	public const string MechanicalElementState_Value = "Value";
	public const string MechanicalElementState_Value_Type = "bool";
	public const string OneDimensionalReferenceFrame_PostiveUpward = "PostiveUpward";
	public const string OneDimensionalReferenceFrame_PostiveUpward_Type = "bool";
	public const string MeasurableQuantity_MeaningfulPrecision = "MeaningfulPrecision";
	public const string MeasurableQuantity_MeaningfulPrecision_Type = "double";
	public const string Quantity_L = "L";
	public const string Quantity_L_Type = "double";
	public const string Quantity_M = "M";
	public const string Quantity_M_Type = "double";
	public const string Quantity_T = "T";
	public const string Quantity_T_Type = "double";
	public const string Quantity_I = "I";
	public const string Quantity_I_Type = "double";
	public const string Quantity_ThT = "ThT";
	public const string Quantity_ThT_Type = "double";
	public const string Quantity_N = "N";
	public const string Quantity_N_Type = "double";
	public const string Quantity_J = "J";
	public const string Quantity_J_Type = "double";
	public const string Quantity_Theta = "Theta";
	public const string Quantity_Theta_Type = "double";
	public const string Quantity_Omega = "Omega";
	public const string Quantity_Omega_Type = "double";
	public const string Quantity_SIUnit = "SIUnit";
	public const string Quantity_SIUnit_Type = "string";
	public const string Unit_Symbol = "Symbol";
	public const string Unit_Symbol_Type = "string";
	public const string Unit_ConversionFactorA = "ConversionFactorA";
	public const string Unit_ConversionFactorA_Type = "double";
	public const string Unit_ConversionFactorB = "ConversionFactorB";
	public const string Unit_ConversionFactorB_Type = "double";
	public const string Clock_LeapSeconds = "LeapSeconds";
	public const string Clock_LeapSeconds_Type = "int";
	public const string Clock_Stratum = "Stratum";
	public const string Clock_Stratum_Type = "int";
	public const string Clock_NetworkSynchronizationLatencyAverage = "NetworkSynchronizationLatencyAverage";
	public const string Clock_NetworkSynchronizationLatencyAverage_Type = "double";
	public const string Clock_NetworkSynchronizationLatencyStandardDeviation = "NetworkSynchronizationLatencyStandardDeviation";
	public const string Clock_NetworkSynchronizationLatencyStandardDeviation_Type = "double";
	public const string Clock_Resolution = "Resolution";
	public const string Clock_Resolution_Type = "double";
	public const string Clock_MaximumFluctuations = "MaximumFluctuations";
	public const string Clock_MaximumFluctuations_Type = "double";
	public const string SynchronizationGroup_SynchronizationDelay = "SynchronizationDelay";
	public const string SynchronizationGroup_SynchronizationDelay_Type = "double";
	public const string SynchronizationGroup_SamplingRate = "SamplingRate";
	public const string SynchronizationGroup_SamplingRate_Type = "double";
	public const string FullScaleUncertainty_FullScale = "FullScale";
	public const string FullScaleUncertainty_FullScale_Type = "double";
	public const string FullScaleUncertainty_ProportionError = "ProportionError";
	public const string FullScaleUncertainty_ProportionError_Type = "double";
	public const string SensorUncertainty_Accuracy = "Accuracy";
	public const string SensorUncertainty_Accuracy_Type = "double";
	public const string SensorUncertainty_Precision = "Precision";
	public const string SensorUncertainty_Precision_Type = "double";
}
}
