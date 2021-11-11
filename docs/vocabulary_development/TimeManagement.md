# NOUNS
## Clock <!-- NOUN -->
- Display name: Clock
- Parent class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
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
## SynchronizationGroup <!-- NOUN -->
- Display name: SynchronizationGroup
- Parent class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
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


# VERBS
## BelongsToSynchronizationGroup <!-- VERB -->
- Display name: BelongsToSynchronizationGroup
- Subject class: [Resampling](./DataFlow.md#Resampling-)
- Object class: [SynchronizationGroup](./TimeManagement.md#SynchronizationGroup-)
- Description: 
- Examples: 
## HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Clock](./TimeManagement.md#Clock-)
- Description: 
- Examples: 
## HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [Clock](./TimeManagement.md#Clock-)
- Description: 
- Examples: 
## HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Description: 
- Examples: 
## IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [SynchronizationGroup](./TimeManagement.md#SynchronizationGroup-)
- Description: 
- Examples: 
## IsSynchronizationGroupOutput <!-- VERB -->
- Display name: IsSynchronizationGroupOutput
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [SynchronizationGroup](./TimeManagement.md#SynchronizationGroup-)
- Description: 
- Examples: 
