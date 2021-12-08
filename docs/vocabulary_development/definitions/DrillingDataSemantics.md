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
## DrillingDataPoint <!-- NOUN -->
- Display name: DrillingDataPoint
- Parent class: DWISNoun
- Attributes:
  - IsValid
    - Type: bool
    - Description: 
- Specialization:
- Description: Main type of DDHub data. Represents a drilling signal.
Can be a dynamic signal (linked to a ValueNode) or a static parameter. 
- Examples:
## ActiveVolume <!-- NOUN -->
- Display name: ActiveVolume
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## BitDepth <!-- NOUN -->
- Display name: BitDepth
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DensityIn <!-- NOUN -->
- Display name: DensityIn
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DensityOut <!-- NOUN -->
- Display name: DensityOut
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeECD <!-- NOUN -->
- Display name: DownholeECD
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholePressure <!-- NOUN -->
- Display name: DownholePressure
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeRPM <!-- NOUN -->
- Display name: DownholeRPM
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeTemperature <!-- NOUN -->
- Display name: DownholeTemperature
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeTorque <!-- NOUN -->
- Display name: DownholeTorque
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## FlowRateIn <!-- NOUN -->
- Display name: FlowRateIn
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## FlowRateOut <!-- NOUN -->
- Display name: FlowRateOut
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## HoleDepth <!-- NOUN -->
- Display name: HoleDepth
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookLoad <!-- NOUN -->
- Display name: HookLoad
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookPosition <!-- NOUN -->
- Display name: HookPosition
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookVelocity <!-- NOUN -->
- Display name: HookVelocity
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## PumpRate <!-- NOUN -->
- Display name: PumpRate
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## ROP <!-- NOUN -->
- Display name: ROP
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## SPP <!-- NOUN -->
- Display name: SPP
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## SurfaceRPM <!-- NOUN -->
- Display name: SurfaceRPM
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## SurfaceTorque <!-- NOUN -->
- Display name: SurfaceTorque
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## TemperatureIn <!-- NOUN -->
- Display name: TemperatureIn
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## TemperatureOut <!-- NOUN -->
- Display name: TemperatureOut
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopOfStringPosition <!-- NOUN -->
- Display name: TopOfStringPosition
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## WOB <!-- NOUN -->
- Display name: WOB
- Parent class: DrillingDataPoint
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
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## HasTimeIntervalDomain <!-- VERB -->
- Display name: HasTimeIntervalDomain
- Parent verb: HasDomain
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
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
- Subject class: DrillingDataPoint
- Object class: DrillingSignal
- Description: 
- Examples: 
## HasDynamicValue <!-- VERB -->
- Display name: HasDynamicValue
- Parent verb: HasValue
- Subject class: DrillingDataPoint
- Object class: DynamicDrillingSignal
- Description: 
- Examples: 
## HasStaticValue <!-- VERB -->
- Display name: HasStaticValue
- Parent verb: HasValue
- Subject class: DrillingDataPoint
- Object class: DrillingSignal
- Description: 
- Examples: 
## IsDependentOn <!-- VERB -->
- Display name: IsDependentOn
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## HasPressureReference <!-- VERB -->
- Display name: HasPressureReference
- Parent verb: IsDependentOn
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## HasTemperatureReference <!-- VERB -->
- Display name: HasTemperatureReference
- Parent verb: IsDependentOn
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: 
- Examples: 
