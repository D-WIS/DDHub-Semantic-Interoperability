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
```dwis rigClock
Clock:rigClock
rigClock.Resolution = "0.01"
```
This example defines a rig clock with 10 ms resolution.
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
- Description: A group of signals that share a synchronization scheme and sampling characteristics.
- Examples:
```dwis syncGroup
SynchronizationGroup:rigSyncGroup
rigSyncGroup.SynchronizationDelay = "0.5"
rigSyncGroup.SamplingRate = "10.0"
```
This example defines a synchronization group with 0.5 s delay and 10 Hz sampling.
## TimeReference <!-- NOUN -->
- Display name: TimeReference
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Base time reference used to interpret timestamps.
- Examples:
```dwis timeRef
TimeReference:timeRef
```
This example declares a generic time reference.
## AbsoluteTimeReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: Time reference tied to an absolute standard such as UTC or GPS.
- Examples:
```dwis absoluteRef
AbsoluteTimeReference:absoluteRef
```
This example defines an absolute time reference.
## RelativeTimeReference <!-- NOUN -->
- Display name: RelativeTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: Time reference relative to a local origin or offset.
- Examples:
```dwis relativeRef
RelativeTimeReference:relativeRef
```
This example defines a relative time reference.
## GPSReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: Time reference derived from GPS.
- Examples:
```dwis gpsRef
GPSReference:gpsTime
```
This example defines a GPS time reference.
## UTCReference <!-- NOUN -->
- Display name: AbsoluteTimeReference
- Parent class: TimeReference
- Attributes:
- Specialization:
- Description: Time reference based on coordinated universal time.
- Examples:
```dwis utcRef
UTCReference:utcTime
```
This example defines a UTC time reference.
## LocalTimeReference <!-- NOUN -->
- Display name: LocalTimeReference
- Parent class: RelativeTimeReference
- Attributes:
- Specialization:
- Description: Time reference with respect to local clock or time zone.
- Examples:
```dwis localRef
LocalTimeReference:localTime
```
This example defines a local time reference.
## TimeSpanReference <!-- NOUN -->
- Display name: TimeSpanReference
- Parent class: RelativeTimeReference
- Attributes:
- Specialization:
- Description: Reference representing elapsed time from a defined event.
- Examples:
```dwis spanRef
TimeSpanReference:elapsedSinceSpud
```
This example defines a time span reference since spud.
  
# VERBS
## BelongsToSynchronizationGroup <!-- VERB -->
- Display name: BelongsToSynchronizationGroup
- Parent verb: DWISVerb
- Subject class: Resampling
- Object class: SynchronizationGroup
- Description: Associates a resampling process with a synchronization group.
- Examples: 
```dwis resamplingSync
Resampling:resampleHookload
SynchronizationGroup:rigSyncGroup
resampleHookload BelongsToSynchronizationGroup rigSyncGroup
```
This example ties a resampling step to the rig synchronization group.
## HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Clock
- Description: Indicates which clock timestamped the acquisition of a signal.
- Examples: 
```dwis acquisitionClock
DrillingDataPoint:standpipePressure
Clock:rigClock
standpipePressure HasAcquisitionClock rigClock
```
This example links standpipe pressure acquisition to the rig clock.
## HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Clock
- Description: Indicates the source clock at the origin of a signal.
- Examples: 
```dwis sourceClock
DrillingDataPoint:downholePressure
Clock:downholeClock
downholePressure HasSourceClock downholeClock
```
This example connects downhole pressure to its source clock.
## HasSourceTime <!-- VERB -->
- Display name: HasSourceTime
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Provides the timestamp at the source for a data point.
- Examples:
```dwis sourceTime
DrillingDataPoint:downholePressure
DrillingDataPoint:downholePressureSourceTime
downholePressure HasSourceTime downholePressureSourceTime
```
This example records the source time for downhole pressure.
## HasAcquisitionTime <!-- VERB -->
- Display name: HasAcquisitionTime
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Provides the acquisition system timestamp for a data point.
- Examples:
```dwis acquisitionTime
DrillingDataPoint:standpipePressure
DrillingDataPoint:standpipePressureAcqTime
standpipePressure HasAcquisitionTime standpipePressureAcqTime
```
This example sets the acquisition time for standpipe pressure.
## HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates the transmission delay associated with a data point.
- Examples: 
```dwis transmissionDelay
DrillingDataPoint:downholePressure
DrillingDataPoint:downholePressureDelay
downholePressure HasTransmissionDelay downholePressureDelay
```
This example records telemetry delay for downhole pressure.
## IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SynchronizationGroup
- Description: Marks a signal as input to a synchronization group.
- Examples: 
```dwis syncInput
DrillingDataPoint:hookload
SynchronizationGroup:rigSyncGroup
hookload IsSynchronizationGroupInput rigSyncGroup
```
This example includes hookload as a sync group input.
## IsSynchronizationGroupOutput <!-- VERB -->
- Display name: IsSynchronizationGroupOutput
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SynchronizationGroup
- Description: Marks a signal as output from a synchronization group.
- Examples: 
```dwis syncOutput
DrillingDataPoint:resampledHookload
SynchronizationGroup:rigSyncGroup
resampledHookload IsSynchronizationGroupOutput rigSyncGroup
```
This example marks a resampled hookload as sync group output.
## HasTimeReference <!-- VERB -->
- Display name: HasTimeReference
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: TimeReference
- Description: Associates a data point with the time reference used for its timestamps.
- Examples:
```dwis timeReference
DrillingDataPoint:standpipePressure
UTCReference:utcTime
standpipePressure HasTimeReference utcTime
```
This example ties standpipe pressure to UTC time reference.
