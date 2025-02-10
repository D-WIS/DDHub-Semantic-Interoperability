using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Verbs
{
public enum Enum
{
IsEnablingSignalFor = 2065203459,
IsActivatedSignalFor = -517912987,
AllowEnablementSignalFor = 740286565,
IsIdlingSignalFor = 20576771,
IsUserControllableExtraMarginSignalFor = -1714648037,
IsUsedExtraMarginSignalFor = 333196400,
IsArmedSignalFor = 942079434,
IsTriggeredSignalFor = 1332908317,
IsIdlingAfterTriggeredSignalFor = -1440158102,
IsImpactDescriptionSignalFor = 1631120542,
IsFeatureSignalFor = -1626466872,
IsRecommendedBy = -1191292156,
IsRecommendedFor = -1042666993,
HasControlLimit = -1231050762,
IsCharacterizedBy = -781373872,
HasOperationalStep = 1311392225,
IsAnActionOf = 326263776,
IsATaskOf = -1408053724,
IsAContextOf = 67253666,
IsDependentOn = 1543668477,
IsObservableFrom = -1204754846,
HasPressureReference = 995490411,
HasTemperatureReference = -966651122,
HasElevationReference = -720227740,
Controls = -176261995,
HasFunction = 388341210,
IsCommandFor = -207865925,
IsComputationInput = -597148566,
IsLimitFor = 927703556,
IsMinimumLimitFor = 1502083894,
IsMaximumLimitFor = -241553257,
IsSetPointFor = -555799759,
IsSetPointRecommendationFor = -458191482,
IsSetPointAdviceFor = 1274343856,
IsSetPointMinimumRecommendationFor = -802273413,
IsSetPointMinimumAdviceFor = 1042279833,
IsSetPointMaximumRecommendationFor = -2109068802,
IsSetPointMaximumAdviceFor = 412118410,
IsTransformationInput = -909804643,
IsBufferingInput = 1567994602,
IsDerivationInput = 240064790,
IsResamplingInput = 1985265397,
IsTransmissionInput = -655194770,
IsGeneratedBy = 2017742981,
IsComputedBy = -1414893810,
IsMeasuredBy = 1956008813,
IsRecordedFrom = 172603902,
IsTransformationOutput = -609711970,
IsBufferingOutput = 1588661969,
IsDerivedFrom = -1592873305,
IsIntegratedFrom = -89542855,
IsResampledBy = -1478125434,
IsTransmissionOutput = -783880517,
IsProcessedBy = 2140703615,
IsProvidedBy = 1139905558,
IsProvidedTo = 1575026888,
IsTransmittedBy = -1028578269,
IsConditionedBy = 172245735,
IsConditionInput = 923389230,
IsConditionLeft = 2091806606,
IsConditionRight = -2030849404,
IsValidBy = 1882721076,
HasDomain = -2070551785,
HasTimeIntervalDomain = -2066401806,
HasValue = -2104248717,
HasDynamicValue = 136265963,
HasStaticValue = -677833184,
IsToBeComparedWith = -1396799774,
IsToBeGreaterThan = 1227479584,
IsToBeGreaterOrEqualThan = 421786436,
IsToBeStrictlyGreaterThan = -296911725,
IsToBeSmallerThan = 1948521962,
IsToBeSmallerOrEqualThan = 866944268,
IsToBeStrictlySmallerThan = 1997751074,
IsToBeEqualTo = -1928012590,
IsToBeDifferentFrom = -2036970570,
IsSubPartOf = 219837321,
AccountsFor = -1708276419,
IsRelatedToDrillingIncident = -143353095,
ManagesIncident = 1100342064,
IsRelatedToDrillingLimit = -2043474692,
ImplementsLimit = 138976157,
IsRelatedToDrillingObjective = -2035749188,
ImplementsObjective = -695486963,
IsRelatedToDrillingProcedure = 381842161,
ImplementsProcedure = 772302173,
DWISVerb = 1868864478,
BelongsToClass = 655142646,
HasEndPoint = 422279717,
HasPressureReferenceType = 904091590,
EndsHydraulicBranchDecomposition = -582128286,
IsAHydraulicRepresentationFor = -1789567342,
HasBranchComponent = -278874951,
HasBranchCoordinateSystem = 489289208,
HasHydraulicState = -1426623882,
HasHydraulicStateValueFrom = -43236955,
HasLeftBranchCoordinates = 719030802,
HasRightBranchCoordinates = 706324804,
IsHydraulicallyLocatedAt = 2041130110,
IsEquivalentCirculationDensityAt = 1002566364,
IsFluidDensityAt = 969569737,
IsFluidTemperatureAt = -1146875461,
IsFluidVelocityAt = 657453933,
IsOpeningRatioAt = 159686010,
IsVolumeAt = -625191631,
IsHydraulicEstimationAt = -1175747162,
IsHydraulicMaximumAllowedRateOfChangeAt = 1847533522,
IsHydraulicMaximumAllowedValueAt = 1959872659,
IsHydraulicMeasurementAt = -248201350,
IsMassFlowRateAt = -651850365,
IsPressureAt = -145849228,
IsPressureGradientAt = -752269375,
IsVolumetricFlowRateAt = -1378071280,
IsHydraulicConnectedTo = -1425239157,
HasEndJunction = 570097503,
HasLeftBranch = 517923977,
HasRightBranch = -381207032,
HasStartJunction = -1249037343,
StartsHydraulicBranchDecomposition = 899294731,
ConcernsAFluidComponent = -1094943903,
IsOfMechanicalStiffnessType = -726414417,
IsAMechanicalRepresentationFor = -1740141494,
HasMechanicalState = -249588726,
HasMechanicalStateValueFrom = -1192208679,
IsMechanicallyConnectedTo = -1351077044,
IsMechanicallyLocatedAt = -674445235,
IsForMotionType = 238459841,
HasMotionType = 1860412433,
HasCoordinates = -207523374,
HasReferenceFrame = 1486531061,
HasReferenceFrameOrigin = -585891493,
IsPhysicallyLocatedAt = -347891148,
AssociatesMeasurableQuantity = -1573185761,
AssociatesUnit = 1116161440,
HasUnitAssociation = 499795045,
HasMeasurableQuantity = 1843615753,
IsOfBaseQuantity = -73262767,
IsOfMeasurableQuantity = -1639410410,
IsUnitForQuantity = 473828390,
HasSIUnit = -1930538455,
HasUnitOfMeasure = 380821531,
BelongsToSynchronizationGroup = 41879606,
HasAcquisitionClock = 82358460,
HasSourceClock = -1263135859,
HasSourceTime = -1344506103,
HasAcquisitionTime = -131162619,
HasTransmissionDelay = 1127029033,
IsSynchronizationGroupInput = -892001916,
IsSynchronizationGroupOutput = -371298419,
HasTimeReference = -446475165,
HasUncertainty = -141174039,
HasUncertaintyAccuracy = 1347840798,
HasUncertaintyPrecision = -175598841,
HasUncertaintyMin = -1482863142,
HasUncertaintyMax = 1547279499,
HasUncertaintyMean = 1897500500,
HasUncertaintyStandardDeviation = -2132913,
HasProportionError = -522698932,
HasFullScale = -1125933739,
HasUncertaintyHistogram = 579152728
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
