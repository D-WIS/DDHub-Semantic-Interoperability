- Description:  this category contains all nouns and verbs used to describe the rig's telemetry, for each signal. Downhole telemetry has focus.

# NOUNS
## Telemetry <!-- NOUN -->
- Display name: Telemetry
- Parent class: DWISNoun
- Attributes:
  - NumberOfRepeaters
    - Type: int
    - Description: The number of repeaters between the source of the signal and the receiver.
  - DistanceBetweenRepeaters
    - Type: double
    - Description: The average distance between two repeaters. The physical quantity is Length and the unit is metre.
  - AverageDelayByRepeater
    - Type: double
    - Description: The average delay caused by each repeater. The physical quantity is Time and the unit is second.
- Specialization:
- Description: Technology used for transferring the data from its main origin. 
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
AcousticTelemetry: acousticTelemetry
acousticTelemetry.NumberOfRepeaters = 3
acousticTelemetry.DistanceBetweenRepeaters = 2000
acousticTelemetry.AverageDelayByRepeater = 1
downholePressure_1 IsTransmittedBy acousticTelemetry
```
## DownHoleTelemetry <!-- NOUN -->
- Display name: DownHoleTelemetry
- Parent class: Telemetry
- Attributes:
- Specialization:
- Description: Technology that allows transfer of downhole data to the surface.
- Examples: 
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
DownHoleTelemetry: downholeTelemetry
downholePressure_1 IsTransmittedBy downholeTelemetry
```
## MudPulseTelemetry <!-- NOUN -->
- Display name: MudPulseTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via pressure pulses sent through the drilling fluid.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
MudPulseTelemetry: mudPulseTelemetry
downholePressure_1 IsTransmittedBy mudPulseTelemetry
```
## ElectromagneticTelemetry <!-- NOUN -->
- Display name: ElectromagneticTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electromagnetic waves sent through the drilling formation.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
ElectromagneticTelemetry: electromagneticTelemetry
downholePressure_1 IsTransmittedBy electromagneticTelemetry
```
## AcousticTelemetry <!-- NOUN -->
- Display name: AcousticTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via acoustic waves along the drill-string.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
AcousticTelemetry: acousticTelemetry
downholePressure_1 IsTransmittedBy acousticTelemetry
```
## WiredPipeTelemetry <!-- NOUN -->
- Display name: WiredPipeTelemetry
- Parent class: DownHoleTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electrical connections along the drill string.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
WiredPipeTelemetry: wiredPipeTelemetry
downholePressure_1 IsTransmittedBy wiredPipeTelemetry
```
## InductionCouplingDownholeTelemetry <!-- NOUN -->
- Display name: InductionCouplingDownholeTelemetry
- Parent class: WiredPipeTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via induction coupling between pipes along the drill-string.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
InductionCouplingDownholeTelemetry: inductionCouplingTelemetry
downholePressure_1 IsTransmittedBy inductionCouplingTelemetry
```
## ElectromagneticCouplingDownholeTelemetry <!-- NOUN -->
- Display name: ElectromagneticCouplingDownholeTelemetry
- Parent class: WiredPipeTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electromagnetic coupling between pipes along the drill-string.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
ElectromagneticCouplingDownholeTelemetry: electromagneticCouplingTelemetry
downholePressure_1 IsTransmittedBy electromagneticCouplingTelemetry
```
## GalvanicCouplingDownholeTelemetry <!-- NOUN -->
- Display name: GalvanicCouplingDownholeTelemetry
- Parent class: WiredPipeTelemetry
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via galvanic coupling between pipes along the drill-string.
- Examples:
``` dwis downholePressure_1
DrillingDataPoint: downholePressure_1
downholePressure_1 BelongsToClass DownholePressure
downholePressure_1 IsOfMeasurableQuantity PressureDrillingQuantity
GalvanicCouplingDownholeTelemetry: galvanicCouplingTelemetry
downholePressure_1 IsTransmittedBy galvanicCouplingTelemetry
```
## TopSideTelemetry <!-- NOUN -->
- Display name: TopSideTelemetry
- Parent class: Telemetry
- Attributes:
- Specialization:
- Description: Method that allows transfer of data from surface systems.
- Examples: 
``` dwis SPP_1
DrillingDataPoint: SPP_1
SPP_1 BelongsToClass SPP
SPP_1 IsOfMeasurableQuantity PressureDrillingQuantity
TopSideTelemetry: topSideTelemetry
SPP_1 IsTransmittedBy topSideTelemetry
```

# VERBS
## IsTransmittedBy <!-- VERB -->
- Display name: IsTransmittedBy
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Telemetry
- Description: Expresses that a signal is transmitted by some given telemetry system
- Examples:
``` dwis downholeWOB_1
DrillingDataPoint: downholeWOB_1
downholeWOB_1 BelongsToClass WOB
downholeWOB_1 IsOfMeasurableQuantity ForceQuantity
InductionCouplingDownholeTelemetry: inductionCouplingTelemetry
downholeWOB_1 IsTransmittedBy inductionCouplingTelemetry
```
