# DrillingDataSemantics<!-- DEFINITION SET HEADER -->
- Description: this is the part associated to the signal's description themselves. Dimensionality, data type are the main items to be described.
# Nouns
## DataEndPoint <!-- NOUN -->
- Display name: DataEndPoint
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - EndPointDescription
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## WitsMLTimeBasedLogEndPoint <!-- NOUN -->
- Display name: WitsMLTimeBasedLogEndPoint
- Parent class: [DataEndPoint](./DrillingDataSemantics.md#DataEndPoint)
- Attributes:
  - WellUID
    - Type: string
    - Description: 
  - WellName
    - Type: string
    - Description: 
  - WellboreUID
    - Type: string
    - Description: 
  - WellboreName
    - Type: string
    - Description: 
  - LogUID
    - Type: string
    - Description: 
  - LogName
    - Type: string
    - Description: 
  - Mnemonic
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DataProvider <!-- NOUN -->
- Display name: DataProvider
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DrillingData <!-- NOUN -->
- Display name: DrillingData
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - IsValid
    - Type: bool
    - Description: 
  - RefreshRate
    - Type: double
    - Description: 
  - DomainOrder
    - Type: int
    - Description: 
  - DataType
    - Type: string
    - Description: 
  - Dimensions
    - Type: int[]
    - Description: 
  - Order
    - Type: int
    - Description: 
  - DomainDimensions
    - Type: int[]
    - Description: 
  - EndPoint
    - Type: string
    - Description: 
- Specialization:
  - DataType = double
  - Order = 0
  - DomainOrder = 0
- Description: Main type of DDHub data. Represents a drilling signal.
- Examples:
- Definition set: DrillingDataSemantics
## ActiveVolume <!-- NOUN -->
- Display name: ActiveVolume
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BitDepth <!-- NOUN -->
- Display name: BitDepth
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DensityIn <!-- NOUN -->
- Display name: DensityIn
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DensityOut <!-- NOUN -->
- Display name: DensityOut
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeECD <!-- NOUN -->
- Display name: DownholeECD
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholePressure <!-- NOUN -->
- Display name: DownholePressure
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeRPM <!-- NOUN -->
- Display name: DownholeRPM
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeTemperature <!-- NOUN -->
- Display name: DownholeTemperature
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeTorque <!-- NOUN -->
- Display name: DownholeTorque
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FlowRateIn <!-- NOUN -->
- Display name: FlowRateIn
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FlowRateOut <!-- NOUN -->
- Display name: FlowRateOut
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HoleDepth <!-- NOUN -->
- Display name: HoleDepth
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookLoad <!-- NOUN -->
- Display name: HookLoad
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookPosition <!-- NOUN -->
- Display name: HookPosition
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookVelocity <!-- NOUN -->
- Display name: HookVelocity
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PumpRate <!-- NOUN -->
- Display name: PumpRate
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ROP <!-- NOUN -->
- Display name: ROP
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SPP <!-- NOUN -->
- Display name: SPP
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SurfaceRPM <!-- NOUN -->
- Display name: SurfaceRPM
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SurfaceTorque <!-- NOUN -->
- Display name: SurfaceTorque
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TemperatureIn <!-- NOUN -->
- Display name: TemperatureIn
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TemperatureOut <!-- NOUN -->
- Display name: TemperatureOut
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TopOfStringPosition <!-- NOUN -->
- Display name: TopOfStringPosition
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## WOB <!-- NOUN -->
- Display name: WOB
- Parent class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
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
- Description: Data structure used to store the steaming drilling data.
- Examples:
- Definition set: DrillingDataSemantics
## DynamicDrillingSignal <!-- NOUN -->
- Display name: DynamicDrillingSignal
- Parent class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Attributes:
  - TimeStampAcquisition
    - Type: DateTime
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## EndPointMapping <!-- NOUN -->
- Display name: EndPointMapping
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - FixedIndices
    - Type: int[]
    - Description: 
  - ValuesIndices
    - Type: int[]
    - Description: 
  - MeasurementIndex
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
# Verbs
## HasDomain <!-- VERB -->
- Display name: HasDomain
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasTimeIntervalDomain <!-- VERB -->
- Display name: HasTimeIntervalDomain
- Parent verb: [HasDomain](./DrillingDataSemantics.md#HasDomain)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasEndPoint <!-- VERB -->
- Display name: HasEndPoint
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Object class: [DataEndPoint](./DrillingDataSemantics.md#DataEndPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasSIUnit <!-- VERB -->
- Display name: HasSIUnit
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [Quantity](./Quantities.md#Quantity)
- Object class: [Unit](./Quantities.md#Unit)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasValue <!-- VERB -->
- Display name: HasValue
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasDynamicValue <!-- VERB -->
- Display name: HasDynamicValue
- Parent verb: [HasValue](./DrillingDataSemantics.md#HasValue)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DynamicDrillingSignal](./DrillingDataSemantics.md#DynamicDrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasStaticValue <!-- VERB -->
- Display name: HasStaticValue
- Parent verb: [HasValue](./DrillingDataSemantics.md#HasValue)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingSignal](./DrillingDataSemantics.md#DrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## IsDependentOn <!-- VERB -->
- Display name: IsDependentOn
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasPressureReference <!-- VERB -->
- Display name: HasPressureReference
- Parent verb: [IsDependentOn](./DrillingDataSemantics.md#IsDependentOn)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasTemperatureReference <!-- VERB -->
- Display name: HasTemperatureReference
- Parent verb: [IsDependentOn](./DrillingDataSemantics.md#IsDependentOn)
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DataProvider](./DrillingDataSemantics.md#DataProvider)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
