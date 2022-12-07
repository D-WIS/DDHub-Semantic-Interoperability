# DataTransmission<!-- DEFINITION SET HEADER -->
- Description: this category contains all nouns and verbs used to describe the rig's telemetry, for each signal. Downhole telemetry has focus.
# Nouns
## Telemetry <!-- NOUN -->
- Display name: Telemetry
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - NumberOfRepeaters
    - Type: int
    - Description: 
  - DistanceBetweenRepeaters
    - Type: double
    - Description: 
  - AverageDelayByRepeater
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
- Description: Represents the transmission of down-hole signals to the surface. 
- Examples:
- Definition set: DataTransmission
## MudPulseTelemetry <!-- NOUN -->
- Display name: MudPulseTelemetry
- Parent class: [DownHoleTelemetry](./DataTransmission.md#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via pressure pulses sent trough the drilling fluid.
- Examples:
- Definition set: DataTransmission
## ElectromagneticTelemetry <!-- NOUN -->
- Display name: ElectromagneticTelemetry
- Parent class: [DownHoleTelemetry](./DataTransmission.md#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electromagnetic waves sent trough the drilling formation.
- Examples:
- Definition set: DataTransmission
## WiredPipeTelemetry <!-- NOUN -->
- Display name: WiredPipeTelemetry
- Parent class: [DownHoleTelemetry](./DataTransmission.md#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electrical connections through the drill string.
- Examples:
- Definition set: DataTransmission
## TopSideTelemetry <!-- NOUN -->
- Display name: TopSideTelemetry
- Parent class: [Telemetry](./DataTransmission.md#Telemetry)
- Attributes:
- Specialization:
- Description: Method that allows transfer of data from surface systems.
- Examples:
- Definition set: DataTransmission
# Verbs
## IsTransmittedBy <!-- VERB -->
- Display name: IsTransmittedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Telemetry](./DataTransmission.md#Telemetry)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: EMS DWOB is transmitted by WiredPipeTelemetry
- Definition set: DataTransmission
