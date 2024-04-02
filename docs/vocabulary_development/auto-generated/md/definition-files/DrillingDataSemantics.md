# DrillingDataSemantics<!-- DEFINITION SET HEADER -->
- Description: this is the part associated to the signal's description themselves. Dimensionality, data type are the main items to be described.
# Nouns
## DataType <!-- NOUN -->
- Display name: DataType
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ContinuousDataType <!-- NOUN -->
- Display name: ContinuousDataType
- Parent class: [DataType](./DrillingDataSemantics.md#DataType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## NormalizedDataType <!-- NOUN -->
- Display name: NormalizedDataType
- Parent class: [ContinuousDataType](./DrillingDataSemantics.md#ContinuousDataType)
- Attributes:
- Specialization:
- Description: between 0 and 1
- Examples:
- Definition set: DrillingDataSemantics
## DiscreteDataType <!-- NOUN -->
- Display name: DiscreteDataType
- Parent class: [DataType](./DrillingDataSemantics.md#DataType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## EnumerationDataType <!-- NOUN -->
- Display name: EnumerationDataType
- Parent class: [DiscreteDataType](./DrillingDataSemantics.md#DiscreteDataType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BooleanDataType <!-- NOUN -->
- Display name: BooleanDataType
- Parent class: [EnumerationDataType](./DrillingDataSemantics.md#EnumerationDataType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DrillingDataPoint <!-- NOUN -->
- Display name: DrillingDataPoint
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - IsValid
    - Type: bool
    - Description: 
- Specialization:
- Description: Main type of DDHub data. Represents a drilling signal.
- Examples:
- Definition set: DrillingDataSemantics
## PrototypeData <!-- NOUN -->
- Display name: PrototypeData
- Parent class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ActiveVolume <!-- NOUN -->
- Display name: ActiveVolume
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Azimuth <!-- NOUN -->
- Display name: Azimuth
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BitDepth <!-- NOUN -->
- Display name: BitDepth
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: Curvilinear abscissa of the bottom of the bit, in the reference frame centered in the wellbore.
- Examples:
- Definition set: DrillingDataSemantics
## DensityIn <!-- NOUN -->
- Display name: DensityIn
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DensityOut <!-- NOUN -->
- Display name: DensityOut
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeECD <!-- NOUN -->
- Display name: DownholeECD
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholePressure <!-- NOUN -->
- Display name: DownholePressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeRPM <!-- NOUN -->
- Display name: DownholeRPM
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeTemperature <!-- NOUN -->
- Display name: DownholeTemperature
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeTorque <!-- NOUN -->
- Display name: DownholeTorque
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FlowRateIn <!-- NOUN -->
- Display name: FlowRateIn
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FlowRateOut <!-- NOUN -->
- Display name: FlowRateOut
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HoleDepth <!-- NOUN -->
- Display name: HoleDepth
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookLoad <!-- NOUN -->
- Display name: HookLoad
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookPosition <!-- NOUN -->
- Display name: HookPosition
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookVelocity <!-- NOUN -->
- Display name: HookVelocity
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Inclination <!-- NOUN -->
- Display name: Inclination
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MeasuredDepth <!-- NOUN -->
- Display name: MeasuredDepth
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PumpRate <!-- NOUN -->
- Display name: PumpRate
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ROP <!-- NOUN -->
- Display name: ROP
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SPP <!-- NOUN -->
- Display name: SPP
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SurfaceRPM <!-- NOUN -->
- Display name: SurfaceRPM
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SurfaceTorque <!-- NOUN -->
- Display name: SurfaceTorque
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TemperatureIn <!-- NOUN -->
- Display name: TemperatureIn
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TemperatureOut <!-- NOUN -->
- Display name: TemperatureOut
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TopOfStringPosition <!-- NOUN -->
- Display name: TopOfStringPosition
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## WOB <!-- NOUN -->
- Display name: WOB
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PorePressure <!-- NOUN -->
- Display name: PorePressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PorePressureGradient <!-- NOUN -->
- Display name: PorePressureGradient
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FracturingPressure <!-- NOUN -->
- Display name: FracturingPressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FracturingPressureGradient <!-- NOUN -->
- Display name: FracturingPressureGradient
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## CollapsePressure <!-- NOUN -->
- Display name: CollapsePressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## CollapsePressureGradient <!-- NOUN -->
- Display name: CollapsePressureGradient
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ShearRate <!-- NOUN -->
- Display name: Shear rate
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ShearStress <!-- NOUN -->
- Display name: Shear stress
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MinimumHorizontalStress <!-- NOUN -->
- Display name: MinimumHorizontalStress
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MinimumHorizontalStressGradient <!-- NOUN -->
- Display name: MinimumHorizontalStressGradient
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## OverburdenPressure <!-- NOUN -->
- Display name: OverburdenPressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## OverburdenPressureGradient <!-- NOUN -->
- Display name: OverburdenPressureGradient
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BOPOpening <!-- NOUN -->
- Display name: BOPOpening
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BOPPressure <!-- NOUN -->
- Display name: BOPPressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDChokeOpening <!-- NOUN -->
- Display name: MPDChokeOpening
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDChokePressure <!-- NOUN -->
- Display name: MPDChokePressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDPumpRate <!-- NOUN -->
- Display name: MPDPumpRate
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDPumpFlowRate <!-- NOUN -->
- Display name: MPDPumpFlowRate
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## GasFlowRate <!-- NOUN -->
- Display name: GasFlowRate
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BackPressurePumpPressure <!-- NOUN -->
- Display name: BackPressurePumpPressure
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MechanicalSpecificEnergy <!-- NOUN -->
- Display name: Mechanical Specific Energy
- Parent class: [PrototypeData](./DrillingDataSemantics.md#PrototypeData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ProcessData <!-- NOUN -->
- Display name: ProcessData
- Parent class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SetPoint <!-- NOUN -->
- Display name: Set-point
- Parent class: [ProcessData](./DrillingDataSemantics.md#ProcessData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Command <!-- NOUN -->
- Display name: Command
- Parent class: [ProcessData](./DrillingDataSemantics.md#ProcessData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Recommendation <!-- NOUN -->
- Display name: Recommendation
- Parent class: [ProcessData](./DrillingDataSemantics.md#ProcessData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## RecommendedTarget <!-- NOUN -->
- Display name: RecommendedTarget
- Parent class: [Recommendation](./DrillingDataSemantics.md#Recommendation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## RecommendedMinimum <!-- NOUN -->
- Display name: RecommendedMinimum
- Parent class: [Recommendation](./DrillingDataSemantics.md#Recommendation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## RecommendedMaximum <!-- NOUN -->
- Display name: RecommendedMaximum
- Parent class: [Recommendation](./DrillingDataSemantics.md#Recommendation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Advice <!-- NOUN -->
- Display name: Advice
- Parent class: [ProcessData](./DrillingDataSemantics.md#ProcessData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## AdvisedTarget <!-- NOUN -->
- Display name: AdvisedTarget
- Parent class: [Advice](./DrillingDataSemantics.md#Advice)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## AdvisedMinimum <!-- NOUN -->
- Display name: AdvisedMinimum
- Parent class: [Advice](./DrillingDataSemantics.md#Advice)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## AdvisedMaximum <!-- NOUN -->
- Display name: AdvisedMaximum
- Parent class: [Advice](./DrillingDataSemantics.md#Advice)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Limit <!-- NOUN -->
- Display name: Limit
- Parent class: [ProcessData](./DrillingDataSemantics.md#ProcessData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MinimumLimit <!-- NOUN -->
- Display name: Minimum Limit
- Parent class: [Limit](./DrillingDataSemantics.md#Limit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MaximumLimit <!-- NOUN -->
- Display name: Maximum Limit
- Parent class: [Limit](./DrillingDataSemantics.md#Limit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PhysicalData <!-- NOUN -->
- Display name: PhysicalData
- Parent class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Measurement <!-- NOUN -->
- Display name: Measurement
- Parent class: [PhysicalData](./DrillingDataSemantics.md#PhysicalData)
- Attributes:
- Specialization:
- Description: The noun Measurement represents individuals that are measured by some instrument and which value can be compared with another measurement.
- Examples:
- Definition set: DrillingDataSemantics
## DerivedMeasurement <!-- NOUN -->
- Display name: DerivedMeasurement
- Parent class: [Measurement](./DrillingDataSemantics.md#Measurement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## CorrectedMeasurement <!-- NOUN -->
- Display name: CorrectedMeasurement
- Parent class: [Measurement](./DrillingDataSemantics.md#Measurement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ComputedData <!-- NOUN -->
- Display name: ComputedData
- Parent class: [PhysicalData](./DrillingDataSemantics.md#PhysicalData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DrillingSignal <!-- NOUN -->
- Display name: DrillingSignal
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - Value
    - Type: object
    - Description: 
- Specialization:
- Description: Data structure used to store the streaming drilling data.
- Examples:
- Definition set: DrillingDataSemantics
## DynamicDrillingSignal <!-- NOUN -->
- Display name: DynamicDrillingSignal
- Parent class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Attributes:
  - TimeStampAtSource
    - Type: DateTime
    - Description: this is a UTC date-time value corresponding to the time at which the value has been taken.
  - TimeStampAcquisition
    - Type: DateTime
    - Description: this is a UTC date-time value at which the value has been acquired by the data acquisition system.
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
# Verbs
## HasDomain <!-- VERB -->
- Display name: HasDomain
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasTimeIntervalDomain <!-- VERB -->
- Display name: HasTimeIntervalDomain
- Parent verb: [HasDomain](./DrillingDataSemantics.md#HasDomain)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasValue <!-- VERB -->
- Display name: HasValue
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasDynamicValue <!-- VERB -->
- Display name: HasDynamicValue
- Parent verb: [HasValue](./DrillingDataSemantics.md#HasValue)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DynamicDrillingSignal](./DrillingDataSemantics.md#DynamicDrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasStaticValue <!-- VERB -->
- Display name: HasStaticValue
- Parent verb: [HasValue](./DrillingDataSemantics.md#HasValue)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## IsToBeComparedWith <!-- VERB -->
- Display name: IsToBeComparedWith
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
