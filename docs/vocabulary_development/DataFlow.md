# DataFlowNode <!-- NOUN -->
- Display name: DataFlowNode
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Description: 
- Examples:
# ComputationUnit <!-- NOUN -->
- Display name: ComputationUnit
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
# Controller <!-- NOUN -->
- Display name: Controller
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: 
- Examples:
# ControlSystem <!-- NOUN -->
- Display name: ControlSystem
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: 
- Examples:
# DrawWorksControlSystem <!-- NOUN -->
- Display name: DrawWorksControlSystem
- Parent class: [ControlSystem](#C:\temp\ddhubMD\DataFlow.md#ControlSystem)
- Attributes:
- Description: 
- Examples:
# MudPumpsControlSystem <!-- NOUN -->
- Display name: MudPumpsControlSystem
- Parent class: [ControlSystem](#C:\temp\ddhubMD\DataFlow.md#ControlSystem)
- Attributes:
- Description: 
- Examples:
# TopDriveControlSystem <!-- NOUN -->
- Display name: TopDriveControlSystem
- Parent class: [ControlSystem](#C:\temp\ddhubMD\DataFlow.md#ControlSystem)
- Attributes:
- Description: 
- Examples:
# MeasurementDevice <!-- NOUN -->
- Display name: MeasurementDevice
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: Denotes a physical sensor
- Examples:
# Transformation <!-- NOUN -->
- Display name: Transformation
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: Represents a transformation applied to some signals that produces other signals
- Examples:
# DirectTransformation <!-- NOUN -->
- Display name: DirectTransformation
- Parent class: [Transformation](#C:\temp\ddhubMD\DataFlow.md#Transformation)
- Attributes:
- Description: Direct transformations are performed using only the current value of their inputs, time is not involved
- Examples:
# Aggregation <!-- NOUN -->
- Display name: Aggregation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# ForceFromLoadPinsTransformation <!-- NOUN -->
- Display name: ForceFromLoadPinsTransformation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# ForceToLoadTransformation <!-- NOUN -->
- Display name: ForceToLoadTransformation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: MeasuredDepthToTrueVerticalDepthTransformation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# MeasuredDepthTranslation <!-- NOUN -->
- Display name: MeasuredDepthTranslation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: PressureToEquivalentDensityTransformation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# PressureToForceTransformation <!-- NOUN -->
- Display name: PressureToForceTransformation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# TorqueToForceTransformation <!-- NOUN -->
- Display name: TorqueToForceTransformation
- Parent class: [DirectTransformation](#C:\temp\ddhubMD\DataFlow.md#DirectTransformation)
- Attributes:
- Description: 
- Examples:
# SignalProcessingUnit <!-- NOUN -->
- Display name: SignalProcessingUnit
- Parent class: [Transformation](#C:\temp\ddhubMD\DataFlow.md#Transformation)
- Attributes:
- Description: Represent any signal processing applied prior to the distribution of the considered signal. Signal processing refers to e.g. noise removal, filtering,..
- Examples:
# Filter <!-- NOUN -->
- Display name: Filter
- Parent class: [SignalProcessingUnit](#C:\temp\ddhubMD\DataFlow.md#SignalProcessingUnit)
- Attributes:
- Description: 
- Examples:
# BandPassFilter <!-- NOUN -->
- Display name: BandPassFilter
- Parent class: [Filter](#C:\temp\ddhubMD\DataFlow.md#Filter)
- Attributes:
  - MinFrequency
    - Type: double
    - Description: 
  - MaxFrequency
    - Type: double
    - Description: 
- Description: 
- Examples:
# HighPassFilter <!-- NOUN -->
- Display name: HighPassFilter
- Parent class: [Filter](#C:\temp\ddhubMD\DataFlow.md#Filter)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Description: 
- Examples:
# LowPassFilter <!-- NOUN -->
- Display name: LowPassFilter
- Parent class: [Filter](#C:\temp\ddhubMD\DataFlow.md#Filter)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Description: 
- Examples:
# MovingAverage <!-- NOUN -->
- Display name: MovingAverage
- Parent class: [Filter](#C:\temp\ddhubMD\DataFlow.md#Filter)
- Attributes:
- Description: 
- Examples:
# NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: NumberOfSampleMovingAverage
- Parent class: [MovingAverage](#C:\temp\ddhubMD\DataFlow.md#MovingAverage)
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Description: 
- Examples:
# TimeWindowMovingAverage <!-- NOUN -->
- Display name: TimeWindowMovingAverage
- Parent class: [MovingAverage](#C:\temp\ddhubMD\DataFlow.md#MovingAverage)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Description: 
- Examples:
# TimeBasedTransformation <!-- NOUN -->
- Display name: TimeBasedTransformation
- Parent class: [Transformation](#C:\temp\ddhubMD\DataFlow.md#Transformation)
- Attributes:
- Description: Transformations that apply only to time series: time derivations, time integration, averaging...
- Examples:
# Buffering <!-- NOUN -->
- Display name: Buffering
- Parent class: [TimeBasedTransformation](#C:\temp\ddhubMD\DataFlow.md#TimeBasedTransformation)
- Attributes:
  - BufferingInterval
    - Type: double
    - Description: 
- Description: 
- Examples:
# Derivation <!-- NOUN -->
- Display name: Derivation
- Parent class: [TimeBasedTransformation](#C:\temp\ddhubMD\DataFlow.md#TimeBasedTransformation)
- Attributes:
- Description: 
- Examples:
# Integration <!-- NOUN -->
- Display name: Integration
- Parent class: [TimeBasedTransformation](#C:\temp\ddhubMD\DataFlow.md#TimeBasedTransformation)
- Attributes:
- Description: 
- Examples:
# RangeExtraction <!-- NOUN -->
- Display name: RangeExtraction
- Parent class: [TimeBasedTransformation](#C:\temp\ddhubMD\DataFlow.md#TimeBasedTransformation)
- Attributes:
- Description: 
- Examples:
# NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: NumberOfItemsRangeExtraction
- Parent class: [RangeExtraction](#C:\temp\ddhubMD\DataFlow.md#RangeExtraction)
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Description: 
- Examples:
# TimeWindowRangeExtraction <!-- NOUN -->
- Display name: TimeWindowRangeExtraction
- Parent class: [RangeExtraction](#C:\temp\ddhubMD\DataFlow.md#RangeExtraction)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Description: 
- Examples:
# Resampling <!-- NOUN -->
- Display name: Resampling
- Parent class: [TimeBasedTransformation](#C:\temp\ddhubMD\DataFlow.md#TimeBasedTransformation)
- Attributes:
  - ResamplingRate
    - Type: double
    - Description: 
  - ResamplingDelay
    - Type: double
    - Description: 
  - Validity
    - Type: double
    - Description: 
- Description: 
- Examples:
# TransmissionLine <!-- NOUN -->
- Display name: TransmissionLine
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: 
- Examples:
# UserInterface <!-- NOUN -->
- Display name: UserInterface
- Parent class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Attributes:
- Description: 
- Examples:
# Controls <!-- VERB -->
- Display name: Controls
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# HasFunction <!-- VERB -->
- Display name: HasFunction
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Description: 
- Examples: 
# IsCommandFor <!-- VERB -->
- Display name: IsCommandFor
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsComputationInput <!-- VERB -->
- Display name: IsComputationInput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [ComputationUnit](#C:\temp\ddhubMD\DataFlow.md#ComputationUnit)
- Description: 
- Examples: 
# IsLimitFor <!-- VERB -->
- Display name: IsLimitFor
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [ControlSystem](#C:\temp\ddhubMD\DataFlow.md#ControlSystem)
- Description: 
- Examples: 
# IsSetPointFor <!-- VERB -->
- Display name: IsSetPointFor
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Controller](#C:\temp\ddhubMD\DataFlow.md#Controller)
- Description: 
- Examples: 
# IsSetPointRecommendationFor <!-- VERB -->
- Display name: IsSetPointRecommendationFor
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [ControlSystem](#C:\temp\ddhubMD\DataFlow.md#ControlSystem)
- Description: 
- Examples: 
# IsTransformationInput <!-- VERB -->
- Display name: IsTransformationInput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Transformation](#C:\temp\ddhubMD\DataFlow.md#Transformation)
- Description: 
- Examples: 
# IsBufferingInput <!-- VERB -->
- Display name: IsBufferingInput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Buffering](#C:\temp\ddhubMD\DataFlow.md#Buffering)
- Description: 
- Examples: 
# IsDerivationInput <!-- VERB -->
- Display name: IsDerivationInput
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsResamplingInput <!-- VERB -->
- Display name: IsResamplingInput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Resampling](#C:\temp\ddhubMD\DataFlow.md#Resampling)
- Description: 
- Examples: 
# IsTransmissionInput <!-- VERB -->
- Display name: IsTransmissionInput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [TransmissionLine](#C:\temp\ddhubMD\DataFlow.md#TransmissionLine)
- Description: 
- Examples: 
# IsGeneratedBy <!-- VERB -->
- Display name: IsGeneratedBy
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Description: 
- Examples: 
# IsComputedBy <!-- VERB -->
- Display name: IsComputedBy
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsMeasuredBy <!-- VERB -->
- Display name: IsMeasuredBy
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsRecordedFrom <!-- VERB -->
- Display name: IsRecordedFrom
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsTransformationOutput <!-- VERB -->
- Display name: IsTransformationOutput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DataFlowNode](#C:\temp\ddhubMD\DataFlow.md#DataFlowNode)
- Description: 
- Examples: 
# IsBufferingOutput <!-- VERB -->
- Display name: IsBufferingOutput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Buffering](#C:\temp\ddhubMD\DataFlow.md#Buffering)
- Description: 
- Examples: 
# IsDerivedFrom <!-- VERB -->
- Display name: IsDerivedFrom
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsIntegratedFrom <!-- VERB -->
- Display name: IsIntegratedFrom
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsResampledBy <!-- VERB -->
- Display name: IsResampledBy
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Resampling](#C:\temp\ddhubMD\DataFlow.md#Resampling)
- Description: 
- Examples: 
# IsTransmissionOutput <!-- VERB -->
- Display name: IsTransmissionOutput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [TransmissionLine](#C:\temp\ddhubMD\DataFlow.md#TransmissionLine)
- Description: 
- Examples: 
# IsProcessedBy <!-- VERB -->
- Display name: IsProcessedBy
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
