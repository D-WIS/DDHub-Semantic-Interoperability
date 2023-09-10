# DataFlow<!-- DEFINITION SET HEADER -->
- Description: this category refers to the data processing. It should probably be renamed accordingly. It should define and organize the different types of processing encountered during drilling operations. A Thursday session was devoted to those items. Note that in the current version, control flow is also included: a controller is seen as a special type of processing unit, that generates commands based on measurements and set-points. This can of course be modified if deemed necessary. Note also that transmission is included there as well. A telemetry system is seen as a processing unit that only duplicates a signal, and a delay is associated to the duplication process. While this is a useful way of looking at telemetry, it is probably not intuitive enough.
# Nouns
## DataFlowNode <!-- NOUN -->
- Display name: DataFlowNode
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Plan <!-- NOUN -->
- Display name: Plan
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## OperationalPlan <!-- NOUN -->
- Display name: OperationalPlan
- Parent class: [Plan](./DataFlow.md#Plan)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## DrillingProgram <!-- NOUN -->
- Display name: DrillingProgram
- Parent class: [Plan](./DataFlow.md#Plan)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## RigActionPlan <!-- NOUN -->
- Display name: RigActionPlan
- Parent class: [Plan](./DataFlow.md#Plan)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ComputedState <!-- NOUN -->
- Display name: ComputedState
- Parent class: [ComputationUnit](./DataFlow.md#ComputationUnit)
- Attributes:
- Specialization:
- Description: A state represents the current configuation of a system.
- Examples:
- Definition set: DataFlow
## ProceduralState <!-- NOUN -->
- Display name: ComputedProceduralState
- Parent class: [ComputedState](./DataFlow.md#ComputedState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ProcessState <!-- NOUN -->
- Display name: ComputedProcessState
- Parent class: [ComputedState](./DataFlow.md#ComputedState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## PhysicalState <!-- NOUN -->
- Display name: ComputedPhysicalState
- Parent class: [ComputedState](./DataFlow.md#ComputedState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ComputationUnit <!-- NOUN -->
- Display name: ComputationUnit
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
- Definition set: DataFlow
## Advisor <!-- NOUN -->
- Display name: Advisor
- Parent class: [ComputationUnit](./DataFlow.md#ComputationUnit)
- Attributes:
  - AdviceType
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Simulator <!-- NOUN -->
- Display name: Simulator
- Parent class: [ComputationUnit](./DataFlow.md#ComputationUnit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Controller <!-- NOUN -->
- Display name: Controller
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ControlSystem <!-- NOUN -->
- Display name: ControlSystem
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## DrawWorksControlSystem <!-- NOUN -->
- Display name: DrawWorksControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MudPumpsControlSystem <!-- NOUN -->
- Display name: MudPumpsControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TopDriveControlSystem <!-- NOUN -->
- Display name: TopDriveControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## BOPControlSystem <!-- NOUN -->
- Display name: BOPControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## RigChokeControlSystem <!-- NOUN -->
- Display name: RigChokeControlSystem
- Parent class: [ControlSystem](./DataFlow.md#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MeasurementDevice <!-- NOUN -->
- Display name: MeasurementDevice
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: Denotes a physical sensor
- Examples:
- Definition set: DataFlow
## Transformation <!-- NOUN -->
- Display name: Transformation
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: Represents a transformation applied to some signals that produces other signals
- Examples:
- Definition set: DataFlow
## DirectTransformation <!-- NOUN -->
- Display name: DirectTransformation
- Parent class: [Transformation](./DataFlow.md#Transformation)
- Attributes:
- Specialization:
- Description: Direct transformations are performed using only the current value of their inputs, time is not involved
- Examples:
- Definition set: DataFlow
## Aggregation <!-- NOUN -->
- Display name: Aggregation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ForceFromLoadPinsTransformation <!-- NOUN -->
- Display name: ForceFromLoadPinsTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ForceToLoadTransformation <!-- NOUN -->
- Display name: ForceToLoadTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: MeasuredDepthToTrueVerticalDepthTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MeasuredDepthTranslation <!-- NOUN -->
- Display name: MeasuredDepthTranslation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: PressureToEquivalentDensityTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## PressureToForceTransformation <!-- NOUN -->
- Display name: PressureToForceTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TorqueToForceTransformation <!-- NOUN -->
- Display name: TorqueToForceTransformation
- Parent class: [DirectTransformation](./DataFlow.md#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## SignalProcessingUnit <!-- NOUN -->
- Display name: SignalProcessingUnit
- Parent class: [Transformation](./DataFlow.md#Transformation)
- Attributes:
- Specialization:
- Description: Represent any signal processing applied prior to the distribution of the considered signal. Signal processing refers to e.g. noise removal, filtering,..
- Examples:
- Definition set: DataFlow
## Filter <!-- NOUN -->
- Display name: Filter
- Parent class: [SignalProcessingUnit](./DataFlow.md#SignalProcessingUnit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## BandPassFilter <!-- NOUN -->
- Display name: BandPassFilter
- Parent class: [Filter](./DataFlow.md#Filter)
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
- Definition set: DataFlow
## HighPassFilter <!-- NOUN -->
- Display name: HighPassFilter
- Parent class: [Filter](./DataFlow.md#Filter)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## LowPassFilter <!-- NOUN -->
- Display name: LowPassFilter
- Parent class: [Filter](./DataFlow.md#Filter)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MovingAverage <!-- NOUN -->
- Display name: MovingAverage
- Parent class: [Filter](./DataFlow.md#Filter)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: NumberOfSampleMovingAverage
- Parent class: [MovingAverage](./DataFlow.md#MovingAverage)
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TimeWindowMovingAverage <!-- NOUN -->
- Display name: TimeWindowMovingAverage
- Parent class: [MovingAverage](./DataFlow.md#MovingAverage)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TimeBasedTransformation <!-- NOUN -->
- Display name: TimeBasedTransformation
- Parent class: [Transformation](./DataFlow.md#Transformation)
- Attributes:
- Specialization:
- Description: Transformations that apply only to time series: time derivations, time integration, averaging...
- Examples:
- Definition set: DataFlow
## Buffering <!-- NOUN -->
- Display name: Buffering
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation)
- Attributes:
  - BufferingInterval
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Derivation <!-- NOUN -->
- Display name: Derivation
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Integration <!-- NOUN -->
- Display name: Integration
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## RangeExtraction <!-- NOUN -->
- Display name: RangeExtraction
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: NumberOfItemsRangeExtraction
- Parent class: [RangeExtraction](./DataFlow.md#RangeExtraction)
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TimeWindowRangeExtraction <!-- NOUN -->
- Display name: TimeWindowRangeExtraction
- Parent class: [RangeExtraction](./DataFlow.md#RangeExtraction)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Resampling <!-- NOUN -->
- Display name: Resampling
- Parent class: [TimeBasedTransformation](./DataFlow.md#TimeBasedTransformation)
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
- Definition set: DataFlow
## TransmissionLine <!-- NOUN -->
- Display name: TransmissionLine
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## UserInterface <!-- NOUN -->
- Display name: UserInterface
- Parent class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
# Verbs
## Controls <!-- VERB -->
- Display name: Controls
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## HasFunction <!-- VERB -->
- Display name: HasFunction
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsCommandFor <!-- VERB -->
- Display name: IsCommandFor
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsComputationInput <!-- VERB -->
- Display name: Is Computation Input
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ComputationUnit](./DataFlow.md#ComputationUnit)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsLimitFor <!-- VERB -->
- Display name: Is Limit For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsMinimumLimitFor <!-- VERB -->
- Display name: Is Minimum Limit For
- Parent verb: [IsLimitFor](./DataFlow.md#IsLimitFor)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsMaximumLimitFor <!-- VERB -->
- Display name: Is Maximum Limit For
- Parent verb: [IsLimitFor](./DataFlow.md#IsLimitFor)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointFor <!-- VERB -->
- Display name: Is Set-Point For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Controller](./DataFlow.md#Controller)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Recommendation For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointAdviceFor <!-- VERB -->
- Display name: Is Set-Point Advice For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMinimumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Minimum Recommendation For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMinimumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Minimum Advice For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMaximumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Maximum Recommendation For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMaximumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Maximum Advice For
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ControlSystem](./DataFlow.md#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransformationInput <!-- VERB -->
- Display name: IsTransformationInput
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Transformation](./DataFlow.md#Transformation)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsBufferingInput <!-- VERB -->
- Display name: IsBufferingInput
- Parent verb: [IsTransformationInput](./DataFlow.md#IsTransformationInput)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Buffering](./DataFlow.md#Buffering)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsDerivationInput <!-- VERB -->
- Display name: IsDerivationInput
- Parent verb: [IsTransformationInput](./DataFlow.md#IsTransformationInput)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsResamplingInput <!-- VERB -->
- Display name: IsResamplingInput
- Parent verb: [IsTransformationInput](./DataFlow.md#IsTransformationInput)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Resampling](./DataFlow.md#Resampling)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransmissionInput <!-- VERB -->
- Display name: IsTransmissionInput
- Parent verb: [HasFunction](./DataFlow.md#HasFunction)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [TransmissionLine](./DataFlow.md#TransmissionLine)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsGeneratedBy <!-- VERB -->
- Display name: IsGeneratedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsComputedBy <!-- VERB -->
- Display name: IsComputedBy
- Parent verb: [IsGeneratedBy](./DataFlow.md#IsGeneratedBy)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsMeasuredBy <!-- VERB -->
- Display name: IsMeasuredBy
- Parent verb: [IsGeneratedBy](./DataFlow.md#IsGeneratedBy)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsRecordedFrom <!-- VERB -->
- Display name: IsRecordedFrom
- Parent verb: [IsGeneratedBy](./DataFlow.md#IsGeneratedBy)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransformationOutput <!-- VERB -->
- Display name: IsTransformationOutput
- Parent verb: [IsGeneratedBy](./DataFlow.md#IsGeneratedBy)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DataFlowNode](./DataFlow.md#DataFlowNode)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsBufferingOutput <!-- VERB -->
- Display name: IsBufferingOutput
- Parent verb: [IsTransformationOutput](./DataFlow.md#IsTransformationOutput)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Buffering](./DataFlow.md#Buffering)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsDerivedFrom <!-- VERB -->
- Display name: IsDerivedFrom
- Parent verb: [IsTransformationOutput](./DataFlow.md#IsTransformationOutput)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsIntegratedFrom <!-- VERB -->
- Display name: IsIntegratedFrom
- Parent verb: [IsTransformationOutput](./DataFlow.md#IsTransformationOutput)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsResampledBy <!-- VERB -->
- Display name: IsResampledBy
- Parent verb: [IsTransformationOutput](./DataFlow.md#IsTransformationOutput)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Resampling](./DataFlow.md#Resampling)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransmissionOutput <!-- VERB -->
- Display name: IsTransmissionOutput
- Parent verb: [IsGeneratedBy](./DataFlow.md#IsGeneratedBy)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [TransmissionLine](./DataFlow.md#TransmissionLine)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsProcessedBy <!-- VERB -->
- Display name: IsProcessedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
