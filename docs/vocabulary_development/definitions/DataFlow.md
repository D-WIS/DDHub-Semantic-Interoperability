# NOUNS
## DataFlowNode <!-- NOUN -->
- Display name: DataFlowNode
- Parent class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ComputationUnit <!-- NOUN -->
- Display name: ComputationUnit
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
## Controller <!-- NOUN -->
- Display name: Controller
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ControlSystem <!-- NOUN -->
- Display name: ControlSystem
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrawWorksControlSystem <!-- NOUN -->
- Display name: DrawWorksControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## MudPumpsControlSystem <!-- NOUN -->
- Display name: MudPumpsControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopDriveControlSystem <!-- NOUN -->
- Display name: TopDriveControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasurementDevice <!-- NOUN -->
- Display name: MeasurementDevice
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: Denotes a physical sensor
- Examples:
## Transformation <!-- NOUN -->
- Display name: Transformation
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: Represents a transformation applied to some signals that produces other signals
- Examples:
## DirectTransformation <!-- NOUN -->
- Display name: DirectTransformation
- Parent class: [Transformation](./DataFlow.md#Transformation-)
- Attributes:
- Specialization:
- Description: Direct transformations are performed using only the current value of their inputs, time is not involved
- Examples:
## Aggregation <!-- NOUN -->
- Display name: Aggregation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ForceFromLoadPinsTransformation <!-- NOUN -->
- Display name: ForceFromLoadPinsTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ForceToLoadTransformation <!-- NOUN -->
- Display name: ForceToLoadTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: MeasuredDepthToTrueVerticalDepthTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasuredDepthTranslation <!-- NOUN -->
- Display name: MeasuredDepthTranslation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: PressureToEquivalentDensityTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## PressureToForceTransformation <!-- NOUN -->
- Display name: PressureToForceTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## TorqueToForceTransformation <!-- NOUN -->
- Display name: TorqueToForceTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## SignalProcessingUnit <!-- NOUN -->
- Display name: SignalProcessingUnit
- Parent class: [Transformation](./DataFlow.md#Transformation-)
- Attributes:
- Specialization:
- Description: Represent any signal processing applied prior to the distribution of the considered signal. Signal processing refers to e.g. noise removal, filtering,..
- Examples:
## Filter <!-- NOUN -->
- Display name: Filter
- Parent class: [SignalProcessingUnit](./DataFlow.md#SignalProcessingUnit-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## BandPassFilter <!-- NOUN -->
- Display name: BandPassFilter
- Parent class: [Filter](./DataFlow.md#Filter-)
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
- Parent class: [Filter](./DataFlow.md#Filter-)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## LowPassFilter <!-- NOUN -->
- Display name: LowPassFilter
- Parent class: [Filter](./DataFlow.md#Filter-)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## MovingAverage <!-- NOUN -->
- Display name: MovingAverage
- Parent class: [Filter](./DataFlow.md#Filter-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: NumberOfSampleMovingAverage
- Parent class: [MovingAverage](./DataFlow.md#MovingAverage-)
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeWindowMovingAverage <!-- NOUN -->
- Display name: TimeWindowMovingAverage
- Parent class: [MovingAverage](./DataFlow.md#MovingAverage-)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeBasedTransformation <!-- NOUN -->
- Display name: TimeBasedTransformation
- Parent class: [Transformation](./DataFlow.md#Transformation-)
- Attributes:
- Specialization:
- Description: Transformations that apply only to time series: time derivations, time integration, averaging...
- Examples:
## Buffering <!-- NOUN -->
- Display name: Buffering
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation-)
- Attributes:
  - BufferingInterval
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## Derivation <!-- NOUN -->
- Display name: Derivation
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## Integration <!-- NOUN -->
- Display name: Integration
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## RangeExtraction <!-- NOUN -->
- Display name: RangeExtraction
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: NumberOfItemsRangeExtraction
- Parent class: [RangeExtraction](./DataFlow.md#RangeExtraction-)
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeWindowRangeExtraction <!-- NOUN -->
- Display name: TimeWindowRangeExtraction
- Parent class: [RangeExtraction](./DataFlow.md#RangeExtraction-)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## Resampling <!-- NOUN -->
- Display name: Resampling
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation-)
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
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## UserInterface <!-- NOUN -->
- Display name: UserInterface
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Attributes:
- Specialization:
- Description: 
- Examples:


# VERBS
## Controls <!-- VERB -->
- Display name: Controls
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## HasFunction <!-- VERB -->
- Display name: HasFunction
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Description: 
- Examples: 
## IsCommandFor <!-- VERB -->
- Display name: IsCommandFor
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsComputationInput <!-- VERB -->
- Display name: IsComputationInput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [ComputationUnit](./DataFlow.md#ComputationUnit-)
- Description: 
- Examples: 
## IsLimitFor <!-- VERB -->
- Display name: IsLimitFor
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem-)
- Description: 
- Examples: 
## IsSetPointFor <!-- VERB -->
- Display name: IsSetPointFor
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Controller](./DataFlow.md#Controller-)
- Description: 
- Examples: 
## IsSetPointRecommendationFor <!-- VERB -->
- Display name: IsSetPointRecommendationFor
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem-)
- Description: 
- Examples: 
## IsTransformationInput <!-- VERB -->
- Display name: IsTransformationInput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Transformation](./DataFlow.md#Transformation-)
- Description: 
- Examples: 
## IsBufferingInput <!-- VERB -->
- Display name: IsBufferingInput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Buffering](./DataFlow.md#Buffering-)
- Description: 
- Examples: 
## IsDerivationInput <!-- VERB -->
- Display name: IsDerivationInput
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsResamplingInput <!-- VERB -->
- Display name: IsResamplingInput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Resampling](./DataFlow.md#Resampling-)
- Description: 
- Examples: 
## IsTransmissionInput <!-- VERB -->
- Display name: IsTransmissionInput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [TransmissionLine](./DataFlow.md#TransmissionLine-)
- Description: 
- Examples: 
## IsGeneratedBy <!-- VERB -->
- Display name: IsGeneratedBy
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Description: 
- Examples: 
## IsComputedBy <!-- VERB -->
- Display name: IsComputedBy
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsMeasuredBy <!-- VERB -->
- Display name: IsMeasuredBy
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsRecordedFrom <!-- VERB -->
- Display name: IsRecordedFrom
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsTransformationOutput <!-- VERB -->
- Display name: IsTransformationOutput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [DataFlowNode](./DataFlow.md#DataFlowNode-)
- Description: 
- Examples: 
## IsBufferingOutput <!-- VERB -->
- Display name: IsBufferingOutput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Buffering](./DataFlow.md#Buffering-)
- Description: 
- Examples: 
## IsDerivedFrom <!-- VERB -->
- Display name: IsDerivedFrom
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsIntegratedFrom <!-- VERB -->
- Display name: IsIntegratedFrom
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
## IsResampledBy <!-- VERB -->
- Display name: IsResampledBy
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Resampling](./DataFlow.md#Resampling-)
- Description: 
- Examples: 
## IsTransmissionOutput <!-- VERB -->
- Display name: IsTransmissionOutput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [TransmissionLine](./DataFlow.md#TransmissionLine-)
- Description: 
- Examples: 
## IsProcessedBy <!-- VERB -->
- Display name: IsProcessedBy
- Subject class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Object class: [DWISNoun](./DrillingDataSemantics.md#DWISNoun-)
- Description: 
- Examples: 
