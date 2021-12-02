- Description: this category refers to the data processing. It should probably be renamed accordingly. It should define and organize the different types of processing encountered during drilling operations. A Thursday session was devoted to those items. Note that in the current version, control flow is also included: a controller is seen as a special type of processing unit, that generates commands based on measurements and set-points. This can of course be modified if deemed necessary. Note also that transmission is included there as well. A telemetry system is seen as a processing unit that only duplicates a signal, and a delay is associated to the duplication process. While this is a useful way of looking at telemetry, it is probably not intuitive enough.

# NOUNS
## DataFlowNode <!-- NOUN -->
- Display name: DataFlowNode
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## ComputationUnit <!-- NOUN -->
- Display name: ComputationUnit
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
## Controller <!-- NOUN -->
- Display name: Controller
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: 
- Examples:
## ControlSystem <!-- NOUN -->
- Display name: ControlSystem
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrawWorksControlSystem <!-- NOUN -->
- Display name: DrawWorksControlSystem
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## MudPumpsControlSystem <!-- NOUN -->
- Display name: MudPumpsControlSystem
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopDriveControlSystem <!-- NOUN -->
- Display name: TopDriveControlSystem
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasurementDevice <!-- NOUN -->
- Display name: MeasurementDevice
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Denotes a physical sensor
- Examples:
## Transformation <!-- NOUN -->
- Display name: Transformation
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Represents a transformation applied to some signals that produces other signals
- Examples:
## DirectTransformation <!-- NOUN -->
- Display name: DirectTransformation
- Parent class: Transformation
- Attributes:
- Specialization:
- Description: Direct transformations are performed using only the current value of their inputs, time is not involved
- Examples:
## Aggregation <!-- NOUN -->
- Display name: Aggregation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## ForceFromLoadPinsTransformation <!-- NOUN -->
- Display name: ForceFromLoadPinsTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## ForceToLoadTransformation <!-- NOUN -->
- Display name: ForceToLoadTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: MeasuredDepthToTrueVerticalDepthTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasuredDepthTranslation <!-- NOUN -->
- Display name: MeasuredDepthTranslation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: PressureToEquivalentDensityTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## PressureToForceTransformation <!-- NOUN -->
- Display name: PressureToForceTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## TorqueToForceTransformation <!-- NOUN -->
- Display name: TorqueToForceTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## SignalProcessingUnit <!-- NOUN -->
- Display name: SignalProcessingUnit
- Parent class: Transformation
- Attributes:
- Specialization:
- Description: Represent any signal processing applied prior to the distribution of the considered signal. Signal processing refers to e.g. noise removal, filtering,..
- Examples:
## Filter <!-- NOUN -->
- Display name: Filter
- Parent class: SignalProcessingUnit
- Attributes:
- Specialization:
- Description: 
- Examples:
## BandPassFilter <!-- NOUN -->
- Display name: BandPassFilter
- Parent class: Filter
- Attributes:
  - MinFrequency
    - Type: double
    - Description: 
  - MaxFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## HighPassFilter <!-- NOUN -->
- Display name: HighPassFilter
- Parent class: Filter
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## LowPassFilter <!-- NOUN -->
- Display name: LowPassFilter
- Parent class: Filter
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## MovingAverage <!-- NOUN -->
- Display name: MovingAverage
- Parent class: Filter
- Attributes:
- Specialization:
- Description: 
- Examples:
## NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: NumberOfSampleMovingAverage
- Parent class: MovingAverage
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeWindowMovingAverage <!-- NOUN -->
- Display name: TimeWindowMovingAverage
- Parent class: MovingAverage
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeBasedTransformation <!-- NOUN -->
- Display name: TimeBasedTransformation
- Parent class: Transformation
- Attributes:
- Specialization:
- Description: Transformations that apply only to time series: time derivations, time integration, averaging...
- Examples:
## Buffering <!-- NOUN -->
- Display name: Buffering
- Parent class: TimeBasedTransformation
- Attributes:
  - BufferingInterval
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## Derivation <!-- NOUN -->
- Display name: Derivation
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## Integration <!-- NOUN -->
- Display name: Integration
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## RangeExtraction <!-- NOUN -->
- Display name: RangeExtraction
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: NumberOfItemsRangeExtraction
- Parent class: RangeExtraction
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeWindowRangeExtraction <!-- NOUN -->
- Display name: TimeWindowRangeExtraction
- Parent class: RangeExtraction
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## Resampling <!-- NOUN -->
- Display name: Resampling
- Parent class: TimeBasedTransformation
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
- Specialization:
- Description: 
- Examples:
## TransmissionLine <!-- NOUN -->
- Display name: TransmissionLine
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: 
- Examples:
## UserInterface <!-- NOUN -->
- Display name: UserInterface
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: 
- Examples:


# VERBS
## Controls <!-- VERB -->
- Display name: Controls
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## HasFunction <!-- VERB -->
- Display name: HasFunction
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: 
- Examples: 
## IsCommandFor <!-- VERB -->
- Display name: IsCommandFor
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: 
- Examples: 
## IsComputationInput <!-- VERB -->
- Display name: IsComputationInput
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ComputationUnit
- Description: 
- Examples: 
## IsLimitFor <!-- VERB -->
- Display name: IsLimitFor
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsSetPointFor <!-- VERB -->
- Display name: IsSetPointFor
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: Controller
- Description: 
- Examples: 
## IsSetPointRecommendationFor <!-- VERB -->
- Display name: IsSetPointRecommendationFor
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsTransformationInput <!-- VERB -->
- Display name: IsTransformationInput
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: Transformation
- Description: 
- Examples: 
## IsBufferingInput <!-- VERB -->
- Display name: IsBufferingInput
- Parent verb: IsTransformationInput
- Subject class: DrillingDataPoint
- Object class: Buffering
- Description: 
- Examples: 
## IsDerivationInput <!-- VERB -->
- Display name: IsDerivationInput
- Parent verb: IsTransformationInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsResamplingInput <!-- VERB -->
- Display name: IsResamplingInput
- Parent verb: IsTransformationInput
- Subject class: DrillingDataPoint
- Object class: Resampling
- Description: 
- Examples: 
## IsTransmissionInput <!-- VERB -->
- Display name: IsTransmissionInput
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: TransmissionLine
- Description: 
- Examples: 
## IsGeneratedBy <!-- VERB -->
- Display name: IsGeneratedBy
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: 
- Examples: 
## IsComputedBy <!-- VERB -->
- Display name: IsComputedBy
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsMeasuredBy <!-- VERB -->
- Display name: IsMeasuredBy
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsRecordedFrom <!-- VERB -->
- Display name: IsRecordedFrom
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsTransformationOutput <!-- VERB -->
- Display name: IsTransformationOutput
- Parent verb: IsGeneratedBy
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: 
- Examples: 
## IsBufferingOutput <!-- VERB -->
- Display name: IsBufferingOutput
- Parent verb: IsTransformationOutput
- Subject class: DrillingDataPoint
- Object class: Buffering
- Description: 
- Examples: 
## IsDerivedFrom <!-- VERB -->
- Display name: IsDerivedFrom
- Parent verb: IsTransformationOutput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsIntegratedFrom <!-- VERB -->
- Display name: IsIntegratedFrom
- Parent verb: IsTransformationOutput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsResampledBy <!-- VERB -->
- Display name: IsResampledBy
- Parent verb: IsTransformationOutput
- Subject class: DrillingDataPoint
- Object class: Resampling
- Description: 
- Examples: 
## IsTransmissionOutput <!-- VERB -->
- Display name: IsTransmissionOutput
- Parent verb: IsGeneratedBy
- Subject class: DrillingDataPoint
- Object class: TransmissionLine
- Description: 
- Examples: 
## IsProcessedBy <!-- VERB -->
- Display name: IsProcessedBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
