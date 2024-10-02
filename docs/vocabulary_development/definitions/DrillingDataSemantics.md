- Description: this is the part associated to the signal's description themselves. Dimensionality, data type are the main items to be described.

# NOUNS
## DataType <!-- NOUN -->
- Display name: Data Type
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## ContinuousDataType <!-- NOUN -->
- Display name: Continuous Data Type
- Parent class: DataType
- Attributes:
- Specialization:
- Description: 
- Examples:
## NormalizedDataType <!-- NOUN -->
- Display name: Normalized Data Type
- Parent class: ContinuousDataType
- Attributes:
- Specialization:
- Description: between 0 and 1
- Examples:
## DiscreteDataType <!-- NOUN -->
- Display name: Discrete Data Type
- Parent class: DataType
- Attributes:
- Specialization:
- Description: 
- Examples:
## EnumerationDataType <!-- NOUN -->
- Display name: Enumeration Data Type
- Parent class: DiscreteDataType
- Attributes:
- Specialization:
- Description: 
- Examples:
## BooleanDataType <!-- NOUN -->
- Display name: Boolean Data Type
- Parent class: EnumerationDataType
- Attributes:
- Specialization:
- Description: 
- Examples:
## StringDataType <!-- NOUN -->
- Display name: String Data Type
- Parent class: DataType
- Attributes:
- Specialization:
- Description: 
- Examples:
## JSonDataType <!-- NOUN -->
- Display name: JSon Data Type
- Parent class: StringDataType
- Attributes:
- Specialization:
- Description: A string that contained the serialization in Json of an object.
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
## PrototypeData <!-- NOUN -->
- Display name: PrototypeData
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## ProcessData <!-- NOUN -->
- Display name: ProcessData
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## SetPoint <!-- NOUN -->
- Display name: Set-point
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: 
- Examples:
## Command <!-- NOUN -->
- Display name: Command
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: 
- Examples:
## Recommendation <!-- NOUN -->
- Display name: Recommendation
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: 
- Examples:
## RecommendedTarget <!-- NOUN -->
- Display name: RecommendedTarget
- Parent class: Recommendation
- Attributes:
- Specialization:
- Description: 
- Examples:
## RecommendedMinimum <!-- NOUN -->
- Display name: RecommendedMinimum
- Parent class: Recommendation
- Attributes:
- Specialization:
- Description: 
- Examples:
## RecommendedMaximum <!-- NOUN -->
- Display name: RecommendedMaximum
- Parent class: Recommendation
- Attributes:
- Specialization:
- Description: 
- Examples:
## Advice <!-- NOUN -->
- Display name: Advice
- Parent class: ProcessData
- Attributes: 
- Specialization:
- Description: 
- Examples:
## AdvisedTarget <!-- NOUN -->
- Display name: AdvisedTarget
- Parent class: Advice
- Attributes: 
- Specialization:
- Description: 
- Examples:
## AdvisedMinimum <!-- NOUN -->
- Display name: AdvisedMinimum
- Parent class: Advice
- Attributes: 
- Specialization:
- Description: 
- Examples:
## AdvisedMaximum <!-- NOUN -->
- Display name: AdvisedMaximum
- Parent class: Advice
- Attributes: 
- Specialization:
- Description: 
- Examples:
## Limit <!-- NOUN -->
- Display name: Limit
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: 
- Examples:
## MinimumLimit <!-- NOUN -->
- Display name: Minimum Limit
- Parent class: Limit
- Attributes:
- Specialization:
- Description: 
- Examples:
## MaximumLimit <!-- NOUN -->
- Display name: Maximum Limit
- Parent class: Limit
- Attributes:
- Specialization:
- Description: 
- Examples:
## PhysicalData <!-- NOUN -->
- Display name: PhysicalData
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: 
- Examples:
## Measurement <!-- NOUN -->
- Display name: Measurement
- Parent class: PhysicalData
- Attributes:
- Specialization:
- Description: The noun Measurement represents individuals that are measured by some instrument and which value can be compared with another measurement.
- Examples:
## DerivedMeasurement <!-- NOUN -->
- Display name: DerivedMeasurement
- Parent class: Measurement
- Attributes:
- Specialization:
- Description: 
- Examples:
## CorrectedMeasurement <!-- NOUN -->
- Display name: CorrectedMeasurement
- Parent class: Measurement
- Attributes:
- Specialization:
- Description: 
- Examples:
## ComputedData <!-- NOUN -->
- Display name: ComputedData
- Parent class: PhysicalData
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
- Description: Data structure used to store the streaming drilling data. 
- Examples:
## DynamicDrillingSignal <!-- NOUN -->
- Display name: DynamicDrillingSignal
- Parent class: DrillingSignal
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
## IsToBeComparedWith <!-- VERB -->
- Display name: IsToBeComparedWith
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeGreaterThan <!-- VERB -->
- Display name: IsToBeGreaterThan
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeGreaterOrEqualThan <!-- VERB -->
- Display name: IsToBeGreaterOrEqualThan
- Parent verb: IsToBeGreaterThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeStrictlyGreaterThan <!-- VERB -->
- Display name: IsToBeStrictlyGreaterThan
- Parent verb: IsToBeGreaterThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeSmallerThan <!-- VERB -->
- Display name: IsToBeSmallerThan
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeSmallerOrEqualThan <!-- VERB -->
- Display name: IsToBeSmallerOrEqualThan
- Parent verb: IsToBeSmallerThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeStrictlySmallerThan <!-- VERB -->
- Display name: IsToBeStrictlySmallerThan
- Parent verb: IsToBeSmallerThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeEqualTo <!-- VERB -->
- Display name: IsToBeEqualTo
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## IsToBeDifferentFrom <!-- VERB -->
- Display name: IsToBeDifferentFrom
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
