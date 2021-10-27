# Clock <!-- NOUN -->
- Display name: Clock
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
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
- Description: Represents a clock
- Examples:
# SynchronizationGroup <!-- NOUN -->
- Display name: SynchronizationGroup
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
  - SynchronizationDelay
    - Type: double
    - Description: 
  - SamplingRate
    - Type: double
    - Description: 
- Description: 
- Examples:
# BelongsToSynchronizationGroup <!-- VERB -->
- Display name: BelongsToSynchronizationGroup
- Subject class: [Resampling](#C:\temp\ddhubMD\DataFlow.md#Resampling)
- Object class: [SynchronizationGroup](#C:\temp\ddhubMD\TimeManagement.md#SynchronizationGroup)
- Description: 
- Examples: 
# HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Clock](#C:\temp\ddhubMD\TimeManagement.md#Clock)
- Description: 
- Examples: 
# HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [Clock](#C:\temp\ddhubMD\TimeManagement.md#Clock)
- Description: 
- Examples: 
# HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Description: 
- Examples: 
# IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [SynchronizationGroup](#C:\temp\ddhubMD\TimeManagement.md#SynchronizationGroup)
- Description: 
- Examples: 
# IsSynchronizationGroupOutput <!-- VERB -->
- Display name: IsSynchronizationGroupOutput
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [SynchronizationGroup](#C:\temp\ddhubMD\TimeManagement.md#SynchronizationGroup)
- Description: 
- Examples: 
