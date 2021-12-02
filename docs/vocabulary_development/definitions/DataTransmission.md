- Description:  this category contains all nouns and verbs used to describe the rig's telemetry, for each signal. Downhole telemetry has focus.

# NOUNS
## Telemetry <!-- NOUN -->
- Display name: Telemetry
- Parent class: DWISNoun
- Attributes:
  - NumberOfRepeaters
    - Type: int
    - Description: 
  - AverageDelayByRepeaters
    - Type: double
    - Description: 
- Specialization:
- Description: Technology used for transferring the data from its main origin. 
- Examples:
## DownHoleTelemetry <!-- NOUN -->
- Display name: DownHoleTelemetry
- Parent class: Telemetry
- Attributes:
- Specialization:
- Description: 
- Examples: Technology that allows transfer of downhole data to the surface.
## MudPulseTelemetry <!-- NOUN -->
- Display name: MudPulseTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via pressure pulses sent trough the drilling fluid.
- Examples: NOV BlackStar II dual-telemetry MWD
## ElectromagneticTelemetry <!-- NOUN -->
- Display name: ElectromagneticTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electromagnetic waves sent trough the drilling formation.
- Examples: APS SureShot-EM, NOV BlackStar II EM MWD
## WiredPipeTelemetry <!-- NOUN -->
- Display name: WiredPipeTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electrical connections through the drill string.
- Examples: Intelliserv Wired Drill Pipe, Reelwell DualLink
## TopSideTelemetry <!-- NOUN -->
- Display name: TopSideTelemetry
- Parent class: Telemetry
- Attributes:
- Specialization:
- Description: Method that allows transfer of data from surface systems.
- Examples: NOVOS, Cyberbase, DEAL


# VERBS
## IsTransmittedBy <!-- VERB -->
- Display name: IsTransmittedBy
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Telemetry
- Description: 
- Examples: EMS DWOB is transmitted by WiredPipeTelemetry
