- Description: this is the part associated to the signal's description themselves. Dimensionality, data type are the main items to be described.

# NOUNS
## DataEndPoint <!-- NOUN -->
- Display name: DataEndPoint
- Parent class: DWISNoun
- Attributes:
  - EndPointDescription
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
## WitsMLTimeBasedLogEndPoint <!-- NOUN -->
- Display name: WitsMLTimeBasedLogEndPoint
- Parent class: DataEndPoint
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
## DataProvider <!-- NOUN -->
- Display name: DataProvider
- Parent class: DWISNoun
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
## DrillingData <!-- NOUN -->
- Display name: DrillingData
- Parent class: DWISNoun
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
Can be a dynamic signal (linked to a ValueNode) or a static parameter. 
- Examples:
## ActiveVolume <!-- NOUN -->
- Display name: ActiveVolume
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## BitDepth <!-- NOUN -->
- Display name: BitDepth
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DensityIn <!-- NOUN -->
- Display name: DensityIn
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DensityOut <!-- NOUN -->
- Display name: DensityOut
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeECD <!-- NOUN -->
- Display name: DownholeECD
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholePressure <!-- NOUN -->
- Display name: DownholePressure
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeRPM <!-- NOUN -->
- Display name: DownholeRPM
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeTemperature <!-- NOUN -->
- Display name: DownholeTemperature
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeTorque <!-- NOUN -->
- Display name: DownholeTorque
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## FlowRateIn <!-- NOUN -->
- Display name: FlowRateIn
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## FlowRateOut <!-- NOUN -->
- Display name: FlowRateOut
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## HoleDepth <!-- NOUN -->
- Display name: HoleDepth
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookLoad <!-- NOUN -->
- Display name: HookLoad
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookPosition <!-- NOUN -->
- Display name: HookPosition
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookVelocity <!-- NOUN -->
- Display name: HookVelocity
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## PumpRate <!-- NOUN -->
- Display name: PumpRate
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## ROP <!-- NOUN -->
- Display name: ROP
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## SPP <!-- NOUN -->
- Display name: SPP
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## SurfaceRPM <!-- NOUN -->
- Display name: SurfaceRPM
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## SurfaceTorque <!-- NOUN -->
- Display name: SurfaceTorque
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## TemperatureIn <!-- NOUN -->
- Display name: TemperatureIn
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## TemperatureOut <!-- NOUN -->
- Display name: TemperatureOut
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopOfStringPosition <!-- NOUN -->
- Display name: TopOfStringPosition
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## WOB <!-- NOUN -->
- Display name: WOB
- Parent class: DrillingData
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillingSignal <!-- NOUN -->
- Display name: DrillingSignal
- Parent class: DWISNoun
- Attributes:
  - Value
    - Type: object
    - Description: 
- Specialization:
- Description: Data structure used to store the steaming drilling data. 
- Examples:
## DynamicDrillingSignal <!-- NOUN -->
- Display name: DynamicDrillingSignal
- Parent class: DrillingSignal
- Attributes:
  - TimeStampAcquisition
    - Type: DateTime
    - Description: 
- Specialization:
- Description: 
- Examples:
## EndPointMapping <!-- NOUN -->
- Display name: EndPointMapping
- Parent class: DWISNoun
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


# VERBS
## HasDomain <!-- VERB -->
- Display name: HasDomain
- Parent verb: DWISVerb
- Subject class: DrillingData
- Object class: DrillingData
- Description: 
- Examples: 
## HasTimeIntervalDomain <!-- VERB -->
- Display name: HasTimeIntervalDomain
- Parent verb: HasDomain
- Subject class: DrillingData
- Object class: DrillingData
- Description: 
- Examples: 
## HasEndPoint <!-- VERB -->
- Display name: HasEndPoint
- Parent verb: DWISVerb
- Subject class: DrillingSignal
- Object class: DataEndPoint
- Description: 
- Examples: 
## HasSIUnit <!-- VERB -->
- Display name: HasSIUnit
- Parent verb: DWISVerb
- Subject class: Quantity
- Object class: Unit
- Description: 
- Examples: 
## HasValue <!-- VERB -->
- Display name: HasValue
- Parent verb: DWISVerb
- Subject class: DrillingData
- Object class: DrillingSignal
- Description: 
- Examples: 
## HasDynamicValue <!-- VERB -->
- Display name: HasDynamicValue
- Parent verb: HasValue
- Subject class: DrillingData
- Object class: DynamicDrillingSignal
- Description: 
- Examples: 
## HasStaticValue <!-- VERB -->
- Display name: HasStaticValue
- Parent verb: HasValue
- Subject class: DrillingData
- Object class: DrillingSignal
- Description: 
- Examples: 
## IsDependentOn <!-- VERB -->
- Display name: IsDependentOn
- Parent verb: DWISVerb
- Subject class: DrillingData
- Object class: DrillingData
- Description: 
- Examples: 
## HasPressureReference <!-- VERB -->
- Display name: HasPressureReference
- Parent verb: IsDependentOn
- Subject class: DrillingData
- Object class: DrillingData
- Description: 
- Examples: 
## HasTemperatureReference <!-- VERB -->
- Display name: HasTemperatureReference
- Parent verb: IsDependentOn
- Subject class: DrillingData
- Object class: DrillingData
- Description: 
- Examples: 
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: 
- Examples: 
