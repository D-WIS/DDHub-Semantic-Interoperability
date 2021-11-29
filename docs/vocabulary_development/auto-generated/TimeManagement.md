# TimeManagement<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## Clock <!-- NOUN -->
- Display name: Clock
- Parent class: [DWISNoun](#./DWISSemantics.md)
- Attributes:
  - LeapSeconds
    - Type: int
    - Description: 
  - Stratum
    - Type: int
    - Description: 
  - NetworkSynchronizationLatencyAverage
    - Type: double
    - Description: 
  - NetworkSynchronizationLatencyStandardDeviation
    - Type: double
    - Description: 
  - Resolution
    - Type: double
    - Description: 
  - MaximumFluctuations
    - Type: double
    - Description: 
- Specialization:
- Description: Represents a clock
- Examples:
- Definition set: TimeManagement
## SynchronizationGroup <!-- NOUN -->
- Display name: SynchronizationGroup
- Parent class: [DWISNoun](#./DWISSemantics.md)
- Attributes:
  - SynchronizationDelay
    - Type: double
    - Description: 
  - SamplingRate
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
# Verbs
## BelongsToSynchronizationGroup <!-- VERB -->
- Display name: BelongsToSynchronizationGroup
- Parent verb: [DWISVerb](#./.md)
- Subject class: [Resampling](#./DataFlow.md)
- Object class: [SynchronizationGroup](#./TimeManagement.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DrillingData](#./DrillingDataSemantics.md)
- Object class: [Clock](#./TimeManagement.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DrillingData](#./DrillingDataSemantics.md)
- Object class: [Clock](#./TimeManagement.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DrillingData](#./DrillingDataSemantics.md)
- Object class: [DrillingData](#./DrillingDataSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DrillingData](#./DrillingDataSemantics.md)
- Object class: [SynchronizationGroup](#./TimeManagement.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
