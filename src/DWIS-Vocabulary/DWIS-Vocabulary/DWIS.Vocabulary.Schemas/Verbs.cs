using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Verbs
{
public enum Enum
{
IsEnablingSignalFor = 343847670,
IsActivatedSignalFor = 1488517201,
AllowEnablementSignalFor = 518749376,
IsIdlingSignalFor = -1372153056,
IsUserControllableExtraMarginSignalFor = 797510916,
IsUsedExtraMarginSignalFor = 2127314556,
IsArmedSignalFor = 400557478,
IsTriggeredSignalFor = 464369001,
IsIdlingAfterTriggeredSignalFor = -34167852,
IsImpactDescriptionSignalFor = -330615082,
IsFeatureSignalFor = -209835230,
IsRecommendedBy = 284699613,
IsRecommendedFor = 760779299,
HasControlLimit = -1568921271,
IsCharacterizedBy = 1542500113,
HasOperationalStep = 2140974528,
IsAnActionOf = -531816183,
IsATaskOf = 1541447450,
IsAContextOf = 552064966,
IsDependentOn = -1939469224,
IsObservableFrom = -1416385038,
HasPressureReference = 1600460120,
HasTemperatureReference = -318524550,
HasElevationReference = 276543057,
Controls = -481880560,
HasFunction = -807100228,
IsCommandFor = 1655192464,
IsComputationInput = -1493324355,
IsLimitFor = 1737738620,
IsMinimumLimitFor = -168143340,
IsMaximumLimitFor = -561699040,
IsSetPointFor = 281201621,
IsSetPointRecommendationFor = -775654554,
IsSetPointAdviceFor = -1938064032,
IsSetPointMinimumRecommendationFor = -1829784955,
IsSetPointMinimumAdviceFor = 61132955,
IsSetPointMaximumRecommendationFor = 395497982,
IsSetPointMaximumAdviceFor = -1951817154,
IsTransformationInput = 1267282446,
IsBufferingInput = -60488948,
IsDerivationInput = -676366470,
IsResamplingInput = -2015384976,
IsTransmissionInput = -2109101273,
IsGeneratedBy = 765234685,
IsComputedBy = -256347420,
IsMeasuredBy = -859242700,
IsRecordedFrom = -861739144,
IsTransformationOutput = 1976378110,
IsBufferingOutput = 1011660150,
IsDerivedFrom = -1666663855,
IsIntegratedFrom = -2092242858,
IsResampledBy = -1192466130,
IsTransmissionOutput = 1155138477,
IsProcessedBy = -1246570585,
IsProvidedBy = -1536922559,
IsProvidedTo = -1677396721,
IsTransmittedBy = 1951863707,
IsConditionedBy = -446923227,
IsConditionInput = -136579855,
IsConditionLeft = -95064714,
IsConditionRight = 1850438856,
IsValidBy = -439324670,
HasDomain = -1836956538,
HasTimeIntervalDomain = -1926808763,
HasValue = 490736009,
HasDynamicValue = 1948754118,
HasStaticValue = 1531250346,
IsToBeComparedWith = -1147277796,
IsToBeGreaterThan = 181786065,
IsToBeGreaterOrEqualThan = 1879345278,
IsToBeStrictlyGreaterThan = 323981564,
IsToBeSmallerThan = -958025594,
IsToBeSmallerOrEqualThan = -3924428,
IsToBeStrictlySmallerThan = -581756965,
IsToBeEqualTo = 588150190,
IsToBeDifferentFrom = -418351691,
IsSubPartOf = -1796871858,
AccountsFor = 2093260564,
IsRelatedToDrillingIncident = -1392003404,
ManagesIncident = -1617892777,
IsRelatedToDrillingLimit = 59422482,
ImplementsLimit = 1623624681,
IsRelatedToDrillingObjective = 633497905,
ImplementsObjective = -1722021204,
IsRelatedToDrillingProcedure = 1028108010,
ImplementsProcedure = 2015808968,
DWISVerb = -53726255,
BelongsToClass = 88113086,
HasEndPoint = 638537693,
HasPressureReferenceType = 396531120,
EndsHydraulicBranchDecomposition = -114711941,
IsAHydraulicRepresentationFor = 345963939,
HasBranchComponent = -55617351,
HasBranchCoordinateSystem = 1618392276,
HasHydraulicState = 499720272,
HasHydraulicStateValueFrom = 1937059249,
HasLeftBranchCoordinates = 360694007,
HasRightBranchCoordinates = 1561830124,
IsHydraulicallyLocatedAt = -1584752352,
IsEquivalentCirculationDensityAt = -101139028,
IsFluidDensityAt = 2073938455,
IsFluidTemperatureAt = -798775364,
IsFluidVelocityAt = 1523006231,
IsOpeningRatioAt = 76419080,
IsVolumeAt = 397799030,
IsHydraulicEstimationAt = 711383248,
IsHydraulicMaximumAllowedRateOfChangeAt = 1126829895,
IsHydraulicMaximumAllowedValueAt = -943677501,
IsHydraulicMeasurementAt = 1966728192,
IsMassFlowRateAt = 434478459,
IsPressureAt = 1800808483,
IsPressureGradientAt = -583526713,
IsVolumetricFlowRateAt = -1193688559,
IsHydraulicConnectedTo = -1796033904,
HasEndJunction = -940936382,
HasLeftBranch = -1585212291,
HasRightBranch = -1664020285,
HasStartJunction = 1863430239,
StartsHydraulicBranchDecomposition = -2135224537,
ConcernsAFluidComponent = 185016156,
IsOfMechanicalStiffnessType = -468546966,
IsAMechanicalRepresentationFor = -654721682,
HasMechanicalState = 161650775,
HasMechanicalStateValueFrom = -1913326709,
IsMechanicallyConnectedTo = 97805427,
IsMechanicallyLocatedAt = 1830323987,
IsForMotionType = -1524041677,
HasMotionType = -1203782200,
HasCoordinates = -1857629393,
HasReferenceFrame = 377539917,
HasReferenceFrameOrigin = -2004282465,
IsPhysicallyLocatedAt = -292024450,
AssociatesMeasurableQuantity = 1618411535,
AssociatesUnit = -490584427,
HasUnitAssociation = -5728801,
HasMeasurableQuantity = -1398801835,
IsOfBaseQuantity = -683261147,
IsOfMeasurableQuantity = 1918487525,
IsUnitForQuantity = -983291467,
HasSIUnit = -1705716532,
HasUnitOfMeasure = -82712869,
BelongsToSynchronizationGroup = 1576824275,
HasAcquisitionClock = 1172142882,
HasSourceClock = 643653078,
HasSourceTime = 1259785205,
HasAcquisitionTime = 1031216530,
HasTransmissionDelay = 192963308,
IsSynchronizationGroupInput = 1772628500,
IsSynchronizationGroupOutput = -374841331,
HasTimeReference = 625594099,
HasUncertainty = -1564216575,
HasUncertaintyAccuracy = 526670551,
HasUncertaintyPrecision = -1994699754,
HasUncertaintyMin = 1216043010,
HasUncertaintyMax = -571293946,
HasUncertaintyMean = 1698370988,
HasUncertaintyStandardDeviation = 16163942,
HasProportionError = -1288857931,
HasFullScale = -93456749,
HasUncertaintyHistogram = -1435416439
}
	public static string IsEnablingSignalFor = "IsEnablingSignalFor";
	public static string IsActivatedSignalFor = "IsActivatedSignalFor";
	public static string AllowEnablementSignalFor = "AllowEnablementSignalFor";
	public static string IsIdlingSignalFor = "IsIdlingSignalFor";
	public static string IsUserControllableExtraMarginSignalFor = "IsUserControllableExtraMarginSignalFor";
	public static string IsUsedExtraMarginSignalFor = "IsUsedExtraMarginSignalFor";
	public static string IsArmedSignalFor = "IsArmedSignalFor";
	public static string IsTriggeredSignalFor = "IsTriggeredSignalFor";
	public static string IsIdlingAfterTriggeredSignalFor = "IsIdlingAfterTriggeredSignalFor";
	public static string IsImpactDescriptionSignalFor = "IsImpactDescriptionSignalFor";
	public static string IsFeatureSignalFor = "IsFeatureSignalFor";
	public static string IsRecommendedBy = "IsRecommendedBy";
	public static string IsRecommendedFor = "IsRecommendedFor";
	public static string HasControlLimit = "HasControlLimit";
	public static string IsCharacterizedBy = "IsCharacterizedBy";
	public static string HasOperationalStep = "HasOperationalStep";
	public static string IsAnActionOf = "IsAnActionOf";
	public static string IsATaskOf = "IsATaskOf";
	public static string IsAContextOf = "IsAContextOf";
	public static string IsDependentOn = "IsDependentOn";
	public static string IsObservableFrom = "IsObservableFrom";
	public static string HasPressureReference = "HasPressureReference";
	public static string HasTemperatureReference = "HasTemperatureReference";
	public static string HasElevationReference = "HasElevationReference";
	public static string Controls = "Controls";
	public static string HasFunction = "HasFunction";
	public static string IsCommandFor = "IsCommandFor";
	public static string IsComputationInput = "IsComputationInput";
	public static string IsLimitFor = "IsLimitFor";
	public static string IsMinimumLimitFor = "IsMinimumLimitFor";
	public static string IsMaximumLimitFor = "IsMaximumLimitFor";
	public static string IsSetPointFor = "IsSetPointFor";
	public static string IsSetPointRecommendationFor = "IsSetPointRecommendationFor";
	public static string IsSetPointAdviceFor = "IsSetPointAdviceFor";
	public static string IsSetPointMinimumRecommendationFor = "IsSetPointMinimumRecommendationFor";
	public static string IsSetPointMinimumAdviceFor = "IsSetPointMinimumAdviceFor";
	public static string IsSetPointMaximumRecommendationFor = "IsSetPointMaximumRecommendationFor";
	public static string IsSetPointMaximumAdviceFor = "IsSetPointMaximumAdviceFor";
	public static string IsTransformationInput = "IsTransformationInput";
	public static string IsBufferingInput = "IsBufferingInput";
	public static string IsDerivationInput = "IsDerivationInput";
	public static string IsResamplingInput = "IsResamplingInput";
	public static string IsTransmissionInput = "IsTransmissionInput";
	public static string IsGeneratedBy = "IsGeneratedBy";
	public static string IsComputedBy = "IsComputedBy";
	public static string IsMeasuredBy = "IsMeasuredBy";
	public static string IsRecordedFrom = "IsRecordedFrom";
	public static string IsTransformationOutput = "IsTransformationOutput";
	public static string IsBufferingOutput = "IsBufferingOutput";
	public static string IsDerivedFrom = "IsDerivedFrom";
	public static string IsIntegratedFrom = "IsIntegratedFrom";
	public static string IsResampledBy = "IsResampledBy";
	public static string IsTransmissionOutput = "IsTransmissionOutput";
	public static string IsProcessedBy = "IsProcessedBy";
	public static string IsProvidedBy = "IsProvidedBy";
	public static string IsProvidedTo = "IsProvidedTo";
	public static string IsTransmittedBy = "IsTransmittedBy";
	public static string IsConditionedBy = "IsConditionedBy";
	public static string IsConditionInput = "IsConditionInput";
	public static string IsConditionLeft = "IsConditionLeft";
	public static string IsConditionRight = "IsConditionRight";
	public static string IsValidBy = "IsValidBy";
	public static string HasDomain = "HasDomain";
	public static string HasTimeIntervalDomain = "HasTimeIntervalDomain";
	public static string HasValue = "HasValue";
	public static string HasDynamicValue = "HasDynamicValue";
	public static string HasStaticValue = "HasStaticValue";
	public static string IsToBeComparedWith = "IsToBeComparedWith";
	public static string IsToBeGreaterThan = "IsToBeGreaterThan";
	public static string IsToBeGreaterOrEqualThan = "IsToBeGreaterOrEqualThan";
	public static string IsToBeStrictlyGreaterThan = "IsToBeStrictlyGreaterThan";
	public static string IsToBeSmallerThan = "IsToBeSmallerThan";
	public static string IsToBeSmallerOrEqualThan = "IsToBeSmallerOrEqualThan";
	public static string IsToBeStrictlySmallerThan = "IsToBeStrictlySmallerThan";
	public static string IsToBeEqualTo = "IsToBeEqualTo";
	public static string IsToBeDifferentFrom = "IsToBeDifferentFrom";
	public static string IsSubPartOf = "IsSubPartOf";
	public static string AccountsFor = "AccountsFor";
	public static string IsRelatedToDrillingIncident = "IsRelatedToDrillingIncident";
	public static string ManagesIncident = "ManagesIncident";
	public static string IsRelatedToDrillingLimit = "IsRelatedToDrillingLimit";
	public static string ImplementsLimit = "ImplementsLimit";
	public static string IsRelatedToDrillingObjective = "IsRelatedToDrillingObjective";
	public static string ImplementsObjective = "ImplementsObjective";
	public static string IsRelatedToDrillingProcedure = "IsRelatedToDrillingProcedure";
	public static string ImplementsProcedure = "ImplementsProcedure";
	public static string DWISVerb = "DWISVerb";
	public static string BelongsToClass = "BelongsToClass";
	public static string HasEndPoint = "HasEndPoint";
	public static string HasPressureReferenceType = "HasPressureReferenceType";
	public static string EndsHydraulicBranchDecomposition = "EndsHydraulicBranchDecomposition";
	public static string IsAHydraulicRepresentationFor = "IsAHydraulicRepresentationFor";
	public static string HasBranchComponent = "HasBranchComponent";
	public static string HasBranchCoordinateSystem = "HasBranchCoordinateSystem";
	public static string HasHydraulicState = "HasHydraulicState";
	public static string HasHydraulicStateValueFrom = "HasHydraulicStateValueFrom";
	public static string HasLeftBranchCoordinates = "HasLeftBranchCoordinates";
	public static string HasRightBranchCoordinates = "HasRightBranchCoordinates";
	public static string IsHydraulicallyLocatedAt = "IsHydraulicallyLocatedAt";
	public static string IsEquivalentCirculationDensityAt = "IsEquivalentCirculationDensityAt";
	public static string IsFluidDensityAt = "IsFluidDensityAt";
	public static string IsFluidTemperatureAt = "IsFluidTemperatureAt";
	public static string IsFluidVelocityAt = "IsFluidVelocityAt";
	public static string IsOpeningRatioAt = "IsOpeningRatioAt";
	public static string IsVolumeAt = "IsVolumeAt";
	public static string IsHydraulicEstimationAt = "IsHydraulicEstimationAt";
	public static string IsHydraulicMaximumAllowedRateOfChangeAt = "IsHydraulicMaximumAllowedRateOfChangeAt";
	public static string IsHydraulicMaximumAllowedValueAt = "IsHydraulicMaximumAllowedValueAt";
	public static string IsHydraulicMeasurementAt = "IsHydraulicMeasurementAt";
	public static string IsMassFlowRateAt = "IsMassFlowRateAt";
	public static string IsPressureAt = "IsPressureAt";
	public static string IsPressureGradientAt = "IsPressureGradientAt";
	public static string IsVolumetricFlowRateAt = "IsVolumetricFlowRateAt";
	public static string IsHydraulicConnectedTo = "IsHydraulicConnectedTo";
	public static string HasEndJunction = "HasEndJunction";
	public static string HasLeftBranch = "HasLeftBranch";
	public static string HasRightBranch = "HasRightBranch";
	public static string HasStartJunction = "HasStartJunction";
	public static string StartsHydraulicBranchDecomposition = "StartsHydraulicBranchDecomposition";
	public static string ConcernsAFluidComponent = "ConcernsAFluidComponent";
	public static string IsOfMechanicalStiffnessType = "IsOfMechanicalStiffnessType";
	public static string IsAMechanicalRepresentationFor = "IsAMechanicalRepresentationFor";
	public static string HasMechanicalState = "HasMechanicalState";
	public static string HasMechanicalStateValueFrom = "HasMechanicalStateValueFrom";
	public static string IsMechanicallyConnectedTo = "IsMechanicallyConnectedTo";
	public static string IsMechanicallyLocatedAt = "IsMechanicallyLocatedAt";
	public static string IsForMotionType = "IsForMotionType";
	public static string HasMotionType = "HasMotionType";
	public static string HasCoordinates = "HasCoordinates";
	public static string HasReferenceFrame = "HasReferenceFrame";
	public static string HasReferenceFrameOrigin = "HasReferenceFrameOrigin";
	public static string IsPhysicallyLocatedAt = "IsPhysicallyLocatedAt";
	public static string AssociatesMeasurableQuantity = "AssociatesMeasurableQuantity";
	public static string AssociatesUnit = "AssociatesUnit";
	public static string HasUnitAssociation = "HasUnitAssociation";
	public static string HasMeasurableQuantity = "HasMeasurableQuantity";
	public static string IsOfBaseQuantity = "IsOfBaseQuantity";
	public static string IsOfMeasurableQuantity = "IsOfMeasurableQuantity";
	public static string IsUnitForQuantity = "IsUnitForQuantity";
	public static string HasSIUnit = "HasSIUnit";
	public static string HasUnitOfMeasure = "HasUnitOfMeasure";
	public static string BelongsToSynchronizationGroup = "BelongsToSynchronizationGroup";
	public static string HasAcquisitionClock = "HasAcquisitionClock";
	public static string HasSourceClock = "HasSourceClock";
	public static string HasSourceTime = "HasSourceTime";
	public static string HasAcquisitionTime = "HasAcquisitionTime";
	public static string HasTransmissionDelay = "HasTransmissionDelay";
	public static string IsSynchronizationGroupInput = "IsSynchronizationGroupInput";
	public static string IsSynchronizationGroupOutput = "IsSynchronizationGroupOutput";
	public static string HasTimeReference = "HasTimeReference";
	public static string HasUncertainty = "HasUncertainty";
	public static string HasUncertaintyAccuracy = "HasUncertaintyAccuracy";
	public static string HasUncertaintyPrecision = "HasUncertaintyPrecision";
	public static string HasUncertaintyMin = "HasUncertaintyMin";
	public static string HasUncertaintyMax = "HasUncertaintyMax";
	public static string HasUncertaintyMean = "HasUncertaintyMean";
	public static string HasUncertaintyStandardDeviation = "HasUncertaintyStandardDeviation";
	public static string HasProportionError = "HasProportionError";
	public static string HasFullScale = "HasFullScale";
	public static string HasUncertaintyHistogram = "HasUncertaintyHistogram";
}
}
