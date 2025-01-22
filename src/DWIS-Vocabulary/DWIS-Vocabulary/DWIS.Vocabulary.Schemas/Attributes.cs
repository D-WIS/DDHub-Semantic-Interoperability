using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Attributes
{
public enum Enum
{
RunnableFunction_IsAuxiliary = 386892209,
Advisor_AdviceType = -298660993,
BandPassFilter_MinFrequency = -1573337362,
BandPassFilter_MaxFrequency = 214720599,
HighPassFilter_CutOffFrequency = -432040970,
LowPassFilter_CutOffFrequency = -727363629,
NumberOfSampleMovingAverage_NumberOfSamples = 905432212,
TimeWindowMovingAverage_TimeWindow = -779241911,
Buffering_BufferingInterval = 1494794480,
NumberOfItemsRangeExtraction_NumberOfItems = -1450242834,
TimeWindowRangeExtraction_TimeWindow = -1774188005,
Resampling_ResamplingRate = -1498172494,
Resampling_ResamplingDelay = -1883127423,
Resampling_Validity = 1559540191,
DataProvider_ProviderName = -513038702,
OperatingCompany_ProviderName = -1393730412,
ServiceCompany_ProviderName = -109747645,
DirectionalServiceCompany_ProviderName = -2034488374,
DrillingFluidProvider_ProviderName = 896624797,
LoggingServiceCompany_ProviderName = -1720798858,
CementingServiceCompany_ProviderName = -1464912513,
CompletionServiceCompany_ProviderName = -1740271609,
DataAnalysisServiceCompany_ProviderName = 2099276260,
DrillingContractor_ProviderName = -982204017,
DWISInternalService_ProviderName = 1435747507,
Telemetry_NumberOfRepeaters = -498174223,
Telemetry_DistanceBetweenRepeaters = -1065736121,
Telemetry_AverageDelayByRepeater = 289012689,
DrillingDataPoint_IsValid = 1014803472,
DrillingSignal_Value = 811772311,
DynamicDrillingSignal_TimeStampAtSource = -879201429,
DynamicDrillingSignal_TimeStampAcquisition = 1138190009,
DataEndPoint_EndPointDescription = 974334857,
WitsMLTimeBasedLogEndPoint_WellUID = -142502114,
WitsMLTimeBasedLogEndPoint_WellName = -516416180,
WitsMLTimeBasedLogEndPoint_WellboreUID = 179261297,
WitsMLTimeBasedLogEndPoint_WellboreName = -967281273,
WitsMLTimeBasedLogEndPoint_LogUID = -1873364050,
WitsMLTimeBasedLogEndPoint_LogName = -779750036,
WitsMLTimeBasedLogEndPoint_Mnemonic = -634521182,
EndPointMapping_FixedIndices = 1598477018,
EndPointMapping_ValuesIndices = -1547158905,
EndPointMapping_MeasurementIndex = -1915354177,
HydraulicConnectedState_Value = 1028510713,
HydraulicJunction_LeftToRight = -707747372,
HydraulicJunction_RightToLeft = 1557848713,
MechanicalElementState_Value = -98318585,
OneDimensionalReferenceFrame_PostiveUpward = -484235666,
MeasurableQuantity_MeaningfulPrecision = -649780614,
Quantity_L = 1120594035,
Quantity_M = -1270194908,
Quantity_T = 1337657913,
Quantity_I = 1189124438,
Quantity_ThT = 708559068,
Quantity_N = -1967098106,
Quantity_J = 1942410335,
Quantity_Theta = 689819143,
Quantity_Omega = 1480029387,
Quantity_SIUnit = 971992233,
Unit_Symbol = -378555109,
Unit_ConversionFactorA = 1901085336,
Unit_ConversionFactorB = 1920476708,
Clock_LeapSeconds = -314007694,
Clock_Stratum = -1509914957,
Clock_NetworkSynchronizationLatencyAverage = 2060659385,
Clock_NetworkSynchronizationLatencyStandardDeviation = -664147470,
Clock_Resolution = 11366117,
Clock_MaximumFluctuations = 786148250,
SynchronizationGroup_SynchronizationDelay = 854006240,
SynchronizationGroup_SamplingRate = -123748552,
FullScaleUncertainty_FullScale = -1941451839,
FullScaleUncertainty_ProportionError = 481277971,
SensorUncertainty_Accuracy = -1096535330,
SensorUncertainty_Precision = 2066518233
}
	public static string RunnableFunction_IsAuxiliary = "IsAuxiliary";
	public static string RunnableFunction_IsAuxiliary_Type = "boolean";
	public static string Advisor_AdviceType = "AdviceType";
	public static string Advisor_AdviceType_Type = "string";
	public static string BandPassFilter_MinFrequency = "MinFrequency";
	public static string BandPassFilter_MinFrequency_Type = "double";
	public static string BandPassFilter_MaxFrequency = "MaxFrequency";
	public static string BandPassFilter_MaxFrequency_Type = "double";
	public static string HighPassFilter_CutOffFrequency = "CutOffFrequency";
	public static string HighPassFilter_CutOffFrequency_Type = "double";
	public static string LowPassFilter_CutOffFrequency = "CutOffFrequency";
	public static string LowPassFilter_CutOffFrequency_Type = "double";
	public static string NumberOfSampleMovingAverage_NumberOfSamples = "NumberOfSamples";
	public static string NumberOfSampleMovingAverage_NumberOfSamples_Type = "int";
	public static string TimeWindowMovingAverage_TimeWindow = "TimeWindow";
	public static string TimeWindowMovingAverage_TimeWindow_Type = "double";
	public static string Buffering_BufferingInterval = "BufferingInterval";
	public static string Buffering_BufferingInterval_Type = "double";
	public static string NumberOfItemsRangeExtraction_NumberOfItems = "NumberOfItems";
	public static string NumberOfItemsRangeExtraction_NumberOfItems_Type = "int";
	public static string TimeWindowRangeExtraction_TimeWindow = "TimeWindow";
	public static string TimeWindowRangeExtraction_TimeWindow_Type = "double";
	public static string Resampling_ResamplingRate = "ResamplingRate";
	public static string Resampling_ResamplingRate_Type = "double";
	public static string Resampling_ResamplingDelay = "ResamplingDelay";
	public static string Resampling_ResamplingDelay_Type = "double";
	public static string Resampling_Validity = "Validity";
	public static string Resampling_Validity_Type = "double";
	public static string DataProvider_ProviderName = "ProviderName";
	public static string DataProvider_ProviderName_Type = "string";
	public static string Telemetry_NumberOfRepeaters = "NumberOfRepeaters";
	public static string Telemetry_NumberOfRepeaters_Type = "int";
	public static string Telemetry_DistanceBetweenRepeaters = "DistanceBetweenRepeaters";
	public static string Telemetry_DistanceBetweenRepeaters_Type = "double";
	public static string Telemetry_AverageDelayByRepeater = "AverageDelayByRepeater";
	public static string Telemetry_AverageDelayByRepeater_Type = "double";
	public static string DrillingDataPoint_IsValid = "IsValid";
	public static string DrillingDataPoint_IsValid_Type = "bool";
	public static string DrillingSignal_Value = "Value";
	public static string DrillingSignal_Value_Type = "object";
	public static string DynamicDrillingSignal_TimeStampAtSource = "TimeStampAtSource";
	public static string DynamicDrillingSignal_TimeStampAtSource_Type = "DateTime";
	public static string DynamicDrillingSignal_TimeStampAcquisition = "TimeStampAcquisition";
	public static string DynamicDrillingSignal_TimeStampAcquisition_Type = "DateTime";
	public static string DataEndPoint_EndPointDescription = "EndPointDescription";
	public static string DataEndPoint_EndPointDescription_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_WellUID = "WellUID";
	public static string WitsMLTimeBasedLogEndPoint_WellUID_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_WellName = "WellName";
	public static string WitsMLTimeBasedLogEndPoint_WellName_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_WellboreUID = "WellboreUID";
	public static string WitsMLTimeBasedLogEndPoint_WellboreUID_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_WellboreName = "WellboreName";
	public static string WitsMLTimeBasedLogEndPoint_WellboreName_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_LogUID = "LogUID";
	public static string WitsMLTimeBasedLogEndPoint_LogUID_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_LogName = "LogName";
	public static string WitsMLTimeBasedLogEndPoint_LogName_Type = "string";
	public static string WitsMLTimeBasedLogEndPoint_Mnemonic = "Mnemonic";
	public static string WitsMLTimeBasedLogEndPoint_Mnemonic_Type = "string";
	public static string EndPointMapping_FixedIndices = "FixedIndices";
	public static string EndPointMapping_FixedIndices_Type = "int[]";
	public static string EndPointMapping_ValuesIndices = "ValuesIndices";
	public static string EndPointMapping_ValuesIndices_Type = "int[]";
	public static string EndPointMapping_MeasurementIndex = "MeasurementIndex";
	public static string EndPointMapping_MeasurementIndex_Type = "int";
	public static string HydraulicConnectedState_Value = "Value";
	public static string HydraulicConnectedState_Value_Type = "bool";
	public static string HydraulicJunction_LeftToRight = "LeftToRight";
	public static string HydraulicJunction_LeftToRight_Type = "bool";
	public static string HydraulicJunction_RightToLeft = "RightToLeft";
	public static string HydraulicJunction_RightToLeft_Type = "bool";
	public static string MechanicalElementState_Value = "Value";
	public static string MechanicalElementState_Value_Type = "bool";
	public static string OneDimensionalReferenceFrame_PostiveUpward = "PostiveUpward";
	public static string OneDimensionalReferenceFrame_PostiveUpward_Type = "bool";
	public static string MeasurableQuantity_MeaningfulPrecision = "MeaningfulPrecision";
	public static string MeasurableQuantity_MeaningfulPrecision_Type = "double";
	public static string Quantity_L = "L";
	public static string Quantity_L_Type = "double";
	public static string Quantity_M = "M";
	public static string Quantity_M_Type = "double";
	public static string Quantity_T = "T";
	public static string Quantity_T_Type = "double";
	public static string Quantity_I = "I";
	public static string Quantity_I_Type = "double";
	public static string Quantity_ThT = "ThT";
	public static string Quantity_ThT_Type = "double";
	public static string Quantity_N = "N";
	public static string Quantity_N_Type = "double";
	public static string Quantity_J = "J";
	public static string Quantity_J_Type = "double";
	public static string Quantity_Theta = "Theta";
	public static string Quantity_Theta_Type = "double";
	public static string Quantity_Omega = "Omega";
	public static string Quantity_Omega_Type = "double";
	public static string Quantity_SIUnit = "SIUnit";
	public static string Quantity_SIUnit_Type = "string";
	public static string Unit_Symbol = "Symbol";
	public static string Unit_Symbol_Type = "string";
	public static string Unit_ConversionFactorA = "ConversionFactorA";
	public static string Unit_ConversionFactorA_Type = "double";
	public static string Unit_ConversionFactorB = "ConversionFactorB";
	public static string Unit_ConversionFactorB_Type = "double";
	public static string Clock_LeapSeconds = "LeapSeconds";
	public static string Clock_LeapSeconds_Type = "int";
	public static string Clock_Stratum = "Stratum";
	public static string Clock_Stratum_Type = "int";
	public static string Clock_NetworkSynchronizationLatencyAverage = "NetworkSynchronizationLatencyAverage";
	public static string Clock_NetworkSynchronizationLatencyAverage_Type = "double";
	public static string Clock_NetworkSynchronizationLatencyStandardDeviation = "NetworkSynchronizationLatencyStandardDeviation";
	public static string Clock_NetworkSynchronizationLatencyStandardDeviation_Type = "double";
	public static string Clock_Resolution = "Resolution";
	public static string Clock_Resolution_Type = "double";
	public static string Clock_MaximumFluctuations = "MaximumFluctuations";
	public static string Clock_MaximumFluctuations_Type = "double";
	public static string SynchronizationGroup_SynchronizationDelay = "SynchronizationDelay";
	public static string SynchronizationGroup_SynchronizationDelay_Type = "double";
	public static string SynchronizationGroup_SamplingRate = "SamplingRate";
	public static string SynchronizationGroup_SamplingRate_Type = "double";
	public static string FullScaleUncertainty_FullScale = "FullScale";
	public static string FullScaleUncertainty_FullScale_Type = "double";
	public static string FullScaleUncertainty_ProportionError = "ProportionError";
	public static string FullScaleUncertainty_ProportionError_Type = "double";
	public static string SensorUncertainty_Accuracy = "Accuracy";
	public static string SensorUncertainty_Accuracy_Type = "double";
	public static string SensorUncertainty_Precision = "Precision";
	public static string SensorUncertainty_Precision_Type = "double";
}
}
