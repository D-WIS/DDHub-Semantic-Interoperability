- Description: this category referes mostly to the description of the various clocks that can be encoutered on a rig, and their synchronization status with respect to each other.

# NOUNS
## Clock <!-- NOUN -->
- Display name: Clock
- Parent class: DWISNoun
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
- Parent class: DWISNoun
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
- Parent verb: DWISVerb
- Subject class: Resampling
- Object class: SynchronizationGroup
- Description: 
- Examples: 
## HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Clock
- Description: 
- Examples: 
## HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Clock
- Description: 
- Examples: 
## HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SynchronizationGroup
- Description: 
- Examples: 
## IsSynchronizationGroupOutput <!-- VERB -->
- Display name: IsSynchronizationGroupOutput
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SynchronizationGroup
- Description: 
- Examples: 
