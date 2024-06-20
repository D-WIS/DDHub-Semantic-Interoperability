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
## TimeReference <!-- NOUN -->
- Display name: TimeReference
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## AbsoluteTimeReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: 
- Examples:
## RelativeTimeReference <!-- NOUN -->
- Display name: RelativeTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: 
- Examples:
## GPSReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: 
- Examples:
## UTCReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: 
- Examples:
## LocalTimeReference <!-- NOUN -->
- Display name: LocalTimeReference
- Parent class: RelativeTimeReference
- Attributes:
- Specialization:
- Description: 
- Examples:
## TimeSpanReference <!-- NOUN -->
- Display name: TimeSpanReference
- Parent class: RelativeTimeReference
- Attributes:
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
## HasSourceTime <!-- VERB -->
- Display name: HasSourceTime
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: 
- Examples:
## HasAcquisitionTime <!-- VERB -->
- Display name: HasAcquisitionTime
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
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
## HasTimeReference <!-- VERB -->
- Display name: HasTimeReference
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: TimeReference
- Description: 
- Examples:
