# TimeManagement<!-- DEFINITION SET HEADER -->
- Description: this category referes mostly to the description of the various clocks that can be encoutered on a rig, and their synchronization status with respect to each other.
# Nouns
## Clock <!-- NOUN -->
- Display name: Clock
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
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
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
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
## TimeReference <!-- NOUN -->
- Display name: TimeReference
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## AbsoluteTimeReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: [TimeReference](./TimeManagement.md#TimeReference)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## RelativeTimeReference <!-- NOUN -->
- Display name: RelativeTimeReference
- Parent class: [TimeReference](./TimeManagement.md#TimeReference)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## GPSReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: [TimeReference](./TimeManagement.md#TimeReference)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## UTCReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: [TimeReference](./TimeManagement.md#TimeReference)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## LocalTimeReference <!-- NOUN -->
- Display name: LocalTimeReference
- Parent class: [RelativeTimeReference](./TimeManagement.md#RelativeTimeReference)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## TimeSpanReference <!-- NOUN -->
- Display name: TimeSpanReference
- Parent class: [RelativeTimeReference](./TimeManagement.md#RelativeTimeReference)
- Attributes:
- Specialization:
- Description: 
- Examples:
  
- Definition set: TimeManagement
# Verbs
## BelongsToSynchronizationGroup <!-- VERB -->
- Display name: BelongsToSynchronizationGroup
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [Resampling](./DataFlow.md#Resampling)
- Object class: [SynchronizationGroup](./TimeManagement.md#SynchronizationGroup)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
## HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Clock](./TimeManagement.md#Clock)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
## HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Clock](./TimeManagement.md#Clock)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
## HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
## IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [SynchronizationGroup](./TimeManagement.md#SynchronizationGroup)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
## IsSynchronizationGroupOutput <!-- VERB -->
- Display name: IsSynchronizationGroupOutput
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [SynchronizationGroup](./TimeManagement.md#SynchronizationGroup)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
## HasTimeReference <!-- VERB -->
- Display name: HasTimeReference
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [TimeReference](./TimeManagement.md#TimeReference)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: TimeManagement
