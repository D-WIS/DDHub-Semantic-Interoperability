- Description: this category refers to the data processing. It should probably be renamed accordingly. It should define and organize the different types of processing encountered during drilling operations. A Thursday session was devoted to those items. Note that in the current version, control flow is also included: a controller is seen as a special type of processing unit, that generates commands based on measurements and set-points. This can of course be modified if deemed necessary. Note also that transmission is included there as well. A telemetry system is seen as a processing unit that only duplicates a signal, and a delay is associated to the duplication process. While this is a useful way of looking at telemetry, it is probably not intuitive enough.

# NOUNS
## DataFlowNode <!-- NOUN -->
- Display name: Data Flow Node
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## ComputedState <!-- NOUN -->
- Display name: Computed State
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: A state represents the current configuation of a system.
- Examples:
## ProceduralState <!-- NOUN -->
- Display name: Procedural State
- Parent class: ComputedState
- Attributes:
- Specialization: A procedural state describes the state of a running procedure.
- Description: 
- Examples:
## EnablementState <!-- NOUN -->
- Display name: Enablement State
- Parent class: ProceduralState
- Attributes:
- Specialization: This noun describes some information about the state of enablement of a procedure.
- Description: 
- Examples:
## ActivationState <!-- NOUN -->
- Display name: Activation State
- Parent class: ProceduralState
- Attributes:
- Specialization: This noun describes some information about the state of activation of a procedure.
- Description: 
- Examples:
## IdlingState <!-- NOUN -->
- Display name: Idling State
- Parent class: ProceduralState
- Attributes:
- Specialization: This noun describes some information about the idling state of a procedure.
- Description: 
- Examples:
## ProcessState <!-- NOUN -->
- Display name: Process State
- Parent class: ComputedState
- Attributes:
- Specialization: A process state describes the state of a process.
- Description: 
- Examples:
## PhysicalState <!-- NOUN -->
- Display name: Physical State
- Parent class: ComputedState
- Attributes:
- Specialization: A physical state describes the phyiscal state of a system.
- Description: 
- Examples:
## ComputationUnit <!-- NOUN -->
- Display name: Computation Unit
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
## Advisor <!-- NOUN -->
- Display name: Advisor
- Parent class: ComputationUnit
- Attributes:
  - AdviceType
    - Type: string
    - Description: 
- Specialization:
- Description: An advisor is a computation unit that produces an advice on how to control a process. Its output is typically
an AdvisorySystemAdvice.
- Examples:
## Simulator <!-- NOUN -->
- Display name: Simulator
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: A simulator is a computation unit that tries to replicate the outputs of a process. Its output is typically 
a set of ComputedData, i.e., a specialisation of DrillingDataPoint.
- Examples:
## Interpreter <!-- NOUN -->
- Display name: Interpreter
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: An interpreter is a computation unit that interprets the state of a process. Its output is typically a 
ComputedState.
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
## HoistingControlSystem <!-- NOUN -->
- Display name: Hoisting Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## CirculationControlSystem <!-- NOUN -->
- Display name: Circulation Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## RotationControlSystem <!-- NOUN -->
- Display name: Rotation Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## BOPControlSystem <!-- NOUN -->
- Display name: BOP Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## RigChokeControlSystem <!-- NOUN -->
- Display name: Rig Choke Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasurementDevice <!-- NOUN -->
- Display name: Measurement Device
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
- Display name: Direct Transformation
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
- Display name: Force From Load Pins Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## ForceToLoadTransformation <!-- NOUN -->
- Display name: Force To Load Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: Measured Depth To True Vertical Depth Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## MeasuredDepthTranslation <!-- NOUN -->
- Display name: Measured Depth Translation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: Pressure To Equivalent Density Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## PressureToForceTransformation <!-- NOUN -->
- Display name: Pressure To Force Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## TorqueToForceTransformation <!-- NOUN -->
- Display name: Torque To Force Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## SignalProcessingUnit <!-- NOUN -->
- Display name: Signal Processing Unit
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
- Display name: Band Pass Filter
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
- Display name: High Pass Filter
- Parent class: Filter
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## LowPassFilter <!-- NOUN -->
- Display name: Low Pass Filter
- Parent class: Filter
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## MovingAverage <!-- NOUN -->
- Display name: Moving Average
- Parent class: Filter
- Attributes:
- Specialization:
- Description: 
- Examples:
## MovingStandardDeviation <!-- NOUN -->
- Display name: Moving Standard Deviation
- Parent class: Filter
- Attributes:
- Specialization:
- Description: 
- Examples:
## MovingMin <!-- NOUN -->
- Display name: Moving Min
- Parent class: Filter
- Attributes:
- Specialization:
- Description: 
- Examples:
## MovingMax <!-- NOUN -->
- Display name: Moving Max
- Parent class: Filter
- Attributes:
- Specialization:
- Description: 
- Examples:
## NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: Number Of Sample Moving Average
- Parent class: MovingAverage
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeWindowMovingAverage <!-- NOUN -->
- Display name: Time Window Moving Average
- Parent class: MovingAverage
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeBasedTransformation <!-- NOUN -->
- Display name: Time Based Transformation
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
- Display name: Range Extraction
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: 
- Examples:
## NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: Number Of Items Range Extraction
- Parent class: RangeExtraction
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
## TimeWindowRangeExtraction <!-- NOUN -->
- Display name: Time Window Range Extraction
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
- Display name: Transmission Line
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: 
- Examples:
## UserInterface <!-- NOUN -->
- Display name: User Interface
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
- Display name: Has Function
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: 
- Examples: 
## IsCommandFor <!-- VERB -->
- Display name: Is Command For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: 
- Examples: 
## IsComputationInput <!-- VERB -->
- Display name: Is Computation Input
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ComputationUnit
- Description: 
- Examples: 
## IsLimitFor <!-- VERB -->
- Display name: Is Limit For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: 
- Examples: 
## IsMinimumLimitFor <!-- VERB -->
- Display name: Is Minimum Limit For
- Parent verb: IsLimitFor
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: 
- Examples: 
## IsMaximumLimitFor <!-- VERB -->
- Display name: Is Maximum Limit For
- Parent verb: IsLimitFor
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: 
- Examples: 
## IsSetPointFor <!-- VERB -->
- Display name: Is Set-Point For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: Controller
- Description: 
- Examples: 
## IsSetPointRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Recommendation For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsSetPointAdviceFor <!-- VERB -->
- Display name: Is Set-Point Advice For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsSetPointMinimumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Minimum Recommendation For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsSetPointMinimumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Minimum Advice For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsSetPointMaximumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Maximum Recommendation For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsSetPointMaximumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Maximum Advice For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: 
- Examples: 
## IsTransformationInput <!-- VERB -->
- Display name: Is Transformation Input
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: Transformation
- Description: 
- Examples: 
## IsBufferingInput <!-- VERB -->
- Display name: Is Buffering Input
- Parent verb: IsTransformationInput
- Subject class: DrillingDataPoint
- Object class: Buffering
- Description: 
- Examples: 
## IsDerivationInput <!-- VERB -->
- Display name: Is Derivation Input
- Parent verb: IsTransformationInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsResamplingInput <!-- VERB -->
- Display name: Is Resampling Input
- Parent verb: IsTransformationInput
- Subject class: DrillingDataPoint
- Object class: Resampling
- Description: 
- Examples: 
## IsTransmissionInput <!-- VERB -->
- Display name: Is Transmission Input
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: TransmissionLine
- Description: 
- Examples: 
## IsGeneratedBy <!-- VERB -->
- Display name: Is Generated By
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: 
- Examples: 
## IsComputedBy <!-- VERB -->
- Display name: Is Computed By
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsMeasuredBy <!-- VERB -->
- Display name: Is Measured By
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsRecordedFrom <!-- VERB -->
- Display name: Is Recorded From
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsTransformationOutput <!-- VERB -->
- Display name: Is Transformation Output
- Parent verb: IsGeneratedBy
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: 
- Examples: 
## IsBufferingOutput <!-- VERB -->
- Display name: Is Buffering Output
- Parent verb: IsTransformationOutput
- Subject class: DrillingDataPoint
- Object class: Buffering
- Description: 
- Examples: 
## IsDerivedFrom <!-- VERB -->
- Display name: Is Derived From
- Parent verb: IsTransformationOutput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsIntegratedFrom <!-- VERB -->
- Display name: Is Integrated From
- Parent verb: IsTransformationOutput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsResampledBy <!-- VERB -->
- Display name: Is Resampled By
- Parent verb: IsTransformationOutput
- Subject class: DrillingDataPoint
- Object class: Resampling
- Description: 
- Examples: 
## IsTransmissionOutput <!-- VERB -->
- Display name: Is Transmission Output
- Parent verb: IsGeneratedBy
- Subject class: DrillingDataPoint
- Object class: TransmissionLine
- Description: 
- Examples: 
## IsProcessedBy <!-- VERB -->
- Display name: Is Processed By
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
