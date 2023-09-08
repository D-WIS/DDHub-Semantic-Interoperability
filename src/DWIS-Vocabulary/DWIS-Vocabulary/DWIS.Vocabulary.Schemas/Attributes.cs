using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Attributes
{
	public static string RunnableFunction_MainFunction = "MainFunction";
	public static string RunnableFunction_MainFunction_Type = "string";
	public static string RunnableFunction_AuxiliaryFunction = "AuxiliaryFunction";
	public static string RunnableFunction_AuxiliaryFunction_Type = "string";
	public static string ProcedureFunction_Tag = "Tag";
	public static string ProcedureFunction_Tag_Type = "string";
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
	public static string DrillStringCenterLineFrame_PositiveUpward = "PositiveUpward";
	public static string DrillStringCenterLineFrame_PositiveUpward_Type = "bool";
	public static string WellboreCenterLineFrame_PositiveUpward = "PositiveUpward";
	public static string WellboreCenterLineFrame_PositiveUpward_Type = "bool";
	public static string MeasurableQuantity_MeaningfulPrecision = "MeaningfulPrecision";
	public static string MeasurableQuantity_MeaningfulPrecision_Type = "double";
	public static string Quantity_L = "L";
	public static string Quantity_L_Type = "int";
	public static string Quantity_M = "M";
	public static string Quantity_M_Type = "int";
	public static string Quantity_T = "T";
	public static string Quantity_T_Type = "int";
	public static string Quantity_I = "I";
	public static string Quantity_I_Type = "int";
	public static string Quantity_ThT = "ThT";
	public static string Quantity_ThT_Type = "int";
	public static string Quantity_N = "N";
	public static string Quantity_N_Type = "int";
	public static string Quantity_J = "J";
	public static string Quantity_J_Type = "int";
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
	public static string SensorUncertainty_Accuracy = "Accuracy";
	public static string SensorUncertainty_Accuracy_Type = "double";
	public static string SensorUncertainty_Precision = "Precision";
	public static string SensorUncertainty_Precision_Type = "double";
}
}
