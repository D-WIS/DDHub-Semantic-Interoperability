using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Verbs
{
public enum Enum
{
IsEnablingSignalFor,
IsActivatedSignalFor,
AllowEnablementSignalFor,
IsIdlingSignalFor,
IsUserControllableExtraMarginSignalFor,
IsUsedExtraMarginSignalFor,
IsArmedSignalFor,
IsTriggeredSignalFor,
IsIdlingAfterTriggeredSignalFor,
IsImpactDescriptionSignalFor,
IsRecommendedBy,
IsRecommendedFor,
HasControlLimit,
IsCharacterizedBy,
HasOperationalStep,
IsAnActionOf,
IsATaskOf,
IsAContextOf,
IsDependentOn,
IsObservableFrom,
HasPressureReference,
HasTemperatureReference,
HasElevationReference,
Controls,
HasFunction,
IsCommandFor,
IsComputationInput,
IsLimitFor,
IsMinimumLimitFor,
IsMaximumLimitFor,
IsSetPointFor,
IsSetPointRecommendationFor,
IsSetPointAdviceFor,
IsSetPointMinimumRecommendationFor,
IsSetPointMinimumAdviceFor,
IsSetPointMaximumRecommendationFor,
IsSetPointMaximumAdviceFor,
IsTransformationInput,
IsBufferingInput,
IsDerivationInput,
IsResamplingInput,
IsTransmissionInput,
IsGeneratedBy,
IsComputedBy,
IsMeasuredBy,
IsRecordedFrom,
IsTransformationOutput,
IsBufferingOutput,
IsDerivedFrom,
IsIntegratedFrom,
IsResampledBy,
IsTransmissionOutput,
IsProcessedBy,
IsProvidedBy,
IsProvidedTo,
IsTransmittedBy,
IsConditionedBy,
IsConditionInput,
IsConditionLeft,
IsConditionRight,
IsValidBy,
HasDomain,
HasTimeIntervalDomain,
HasValue,
HasDynamicValue,
HasStaticValue,
IsToBeComparedWith,
IsToBeGreaterThan,
IsToBeGreaterOrEqualThan,
IsToBeStrictlyGreaterThan,
IsToBeSmallerThan,
IsToBeSmallerOrEqualThan,
IsToBeStrictlySmallerThan,
IsToBeEqualTo,
IsToBeDifferentFrom,
IsSubPartOf,
IsRelatedToDrillingIncident,
ManagesIncident,
IsRelatedToDrillingLimit,
ImplementsLimit,
IsRelatedToDrillingObjective,
ImplementsObjective,
IsRelatedToDrillingProcedure,
ImplementsProcedure,
DWISVerb,
BelongsToClass,
HasEndPoint,
HasPressureReferenceType,
EndsHydraulicBranchDecomposition,
IsAHydraulicRepresentationFor,
HasBranchComponent,
HasBranchCoordinateSystem,
HasHydraulicState,
HasHydraulicStateValueFrom,
HasLeftBranchCoordinates,
HasRightBranchCoordinates,
IsHydraulicallyLocatedAt,
IsEquivalentCirculationDensityAt,
IsFluidDensityAt,
IsFluidTemperatureAt,
IsFluidVelocityAt,
IsOpeningRatioAt,
IsVolumeAt,
IsHydraulicEstimationAt,
IsHydraulicMaximumAllowedRateOfChangeAt,
IsHydraulicMaximumAllowedValueAt,
IsHydraulicMeasurementAt,
IsMassFlowRateAt,
IsPressureAt,
IsPressureGradientAt,
IsVolumetricFlowRateAt,
IsHydraulicConnectedTo,
HasEndJunction,
HasLeftBranch,
HasRightBranch,
HasStartJunction,
StartsHydraulicBranchDecomposition,
ConcernsAFluidComponent,
IsOfMechanicalStiffnessType,
IsAMechanicalRepresentationFor,
HasMechanicalState,
HasMechanicalStateValueFrom,
IsMechanicallyConnectedTo,
IsMechanicallyLocatedAt,
IsForMotionType,
HasMotionType,
HasCoordinates,
HasReferenceFrame,
HasReferenceFrameOrigin,
IsPhysicallyLocatedAt,
AssociatesMeasurableQuantity,
AssociatesUnit,
HasUnitAssociation,
HasMeasurableQuantity,
IsOfBaseQuantity,
IsOfMeasurableQuantity,
IsUnitForQuantity,
HasSIUnit,
HasUnitOfMeasure,
BelongsToSynchronizationGroup,
HasAcquisitionClock,
HasSourceClock,
HasSourceTime,
HasAcquisitionTime,
HasTransmissionDelay,
IsSynchronizationGroupInput,
IsSynchronizationGroupOutput,
HasTimeReference,
HasUncertainty,
HasUncertaintyAccuracy,
HasUncertaintyPrecision,
HasUncertaintyMin,
HasUncertaintyMax,
HasUncertaintyMean,
HasUncertaintyStandardDeviation,
HasProportionError,
HasFullScale,
HasUncertaintyHistogram
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
