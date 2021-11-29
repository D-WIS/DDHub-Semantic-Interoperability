# DataTransmission<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## Telemetry <!-- NOUN -->
- Display name: Telemetry
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - RefreshRate
    - Type: double
    - Description: 
  - NumberOfRepeaters
    - Type: int
    - Description: 
  - AverageDelayByRepeaters
    - Type: double
    - Description: 
- Specialization:
- Description: Technology used for transferring the data from its main origin.
- Examples:
- Definition set: DataTransmission
## DownHoleTelemetry <!-- NOUN -->
- Display name: DownHoleTelemetry
- Parent class: [Telemetry](./DataTransmission.md#Telemetry)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataTransmission
## MudPulseTelemetry <!-- NOUN -->
- Display name: MudPulseTelemetry
- Parent class: [DownHoleTelemetry](./DataTransmission.md#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataTransmission
## WiredPipeTelemetry <!-- NOUN -->
- Display name: WiredPipeTelemetry
- Parent class: [DownHoleTelemetry](./DataTransmission.md#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataTransmission
## TopSideTelemetry <!-- NOUN -->
- Display name: TopSideTelemetry
- Parent class: [Telemetry](./DataTransmission.md#Telemetry)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataTransmission
# Verbs
## IsTransmittedBy <!-- VERB -->
- Display name: IsTransmittedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataTransmission
