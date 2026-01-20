- Description: this part refers to the mechanical circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.

# NOUNS
## MechanicalElementState <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: DWISNoun
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: Represents the state of a mechanical element such as open/closed or active/inactive.
- Examples:
```dwis mechState
MechanicalElementState:mechanicalState
MechanicalLogicalElement:topDriveClutch
topDriveClutch HasMechanicalState mechanicalState
```
This example assigns a state to a mechanical element.
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: A state indicating a mechanical closure (e.g., valve closed).
- Examples:
```dwis closedState
MechanicallyClosedState:closedState
MechanicalLogicalElement:blowoutPreventer
blowoutPreventer HasMechanicalState closedState
```
This example denotes a closed state on a BOP element.
## MechanicallyOpenState <!-- NOUN -->
- Display name: MechanicallyOpenState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: A state indicating a mechanical opening.
- Examples:
```dwis openState
MechanicallyOpenState:openState
MechanicalLogicalElement:annularPreventer
annularPreventer HasMechanicalState openState
```
This example sets an open state on an annular preventer.
## MechanicallyActiveState <!-- NOUN -->
- Display name: MechanicallyActiveState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: Indicates that a mechanical element is active/engaged.
- Examples:
```dwis activeState
MechanicallyActiveState:activeState
MechanicalLogicalElement:topDrive
topDrive HasMechanicalState activeState
```
This example marks a top drive as active.
## MechanicallyInactiveState <!-- NOUN -->
- Display name: MechanicallyInactiveState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: Indicates that a mechanical element is inactive/disengaged.
- Examples:
```dwis inactiveState
MechanicallyInactiveState:inactiveState
MechanicalLogicalElement:topDrive
topDrive HasMechanicalState inactiveState
```
This example marks a top drive as inactive.
## MechanicallyConnectedState <!-- NOUN -->
- Display name: MechanicallyConnectedState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: Indicates whether two mechanical elements are connected.
- Examples:
```dwis connectedState
MechanicallyConnectedState:connectedState
MechanicalLogicalElement:pipeConnection
pipeConnection HasMechanicalState connectedState
```
This example records a connection state for a pipe joint.
## MechanicalLogicalElement <!-- NOUN -->
- Display name: Mechanical Logical Element
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Abstract mechanical element used to model kinematic or connection relationships.
- Examples:
```dwis mechanicalElementExample
MechanicalLogicalElement:topDrive
DrillingEquipment:topDriveEquipment
topDrive IsAMechanicalRepresentationFor topDriveEquipment
```
This example represents a top drive as a mechanical logical element.
## TopSideMechanicalLogicalElement <!-- NOUN -->
- Display name: Top Side Mechanical Logical Element
- Parent class: MechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical element concerning the top-side mechanical infrastructure like for instance the top-drive, the rotary table, the kelly.
- Examples:
```dwis TopSideMechanicalLogicalElementExample
TopSideMechanicalLogicalElement:topDriveLogical
TopDrive:topDriveEquipment
topDriveLogical IsAMechanicalRepresentationFor topDriveEquipment
```
This example represents a top drive as a mechanical logical element.
## DrillStemMechanicalLogicalElement <!-- NOUN -->
- Display name: Drill-stem Mechanical Logical Element
- Parent class: MechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of a drill-stem, e.g., a drill-string, a casing-string, a tubing-string.
- Examples:
```dwis DrillStemMechanicalLogicalElementExample
TopSideMechanicalLogicalElement:topSideHoistingAndRotationLogical
DrillStemMechanicalLogicalElement:drillStemLogical
topSideHoistingAndRotationLogical IsMechanicallyConnectedTo drillStemLogical
```
This example describes that the top-drive or kelly is mechanically connected to the drill-stem.
## DrillStringMechanicalLogicalElement <!-- NOUN -->
- Display name: Drill-string Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of a drill-string, i.e., a drill-stem that is used during a drilling operation.
- Examples:
```dwis DrillStringMechanicalLogicalElementExample
TopSideMechanicalLogicalElement:topSideHoistingAndRotationLogical
DrillStemMechanicalLogicalElement:drillStemLogical
topSideHoistingAndRotationLogical IsMechanicallyConnectedTo drillStemLogical
```
This example describes that the top-drive or kelly is mechanically connected to the drill-stem.
## CasingStringMechanicalLogicalElement <!-- NOUN -->
- Display name: Casing-string Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of a casing-string, i.e., a drill-stem that is composed of casing joints, a casing shoe and similar elements.
- Examples:
```dwis CasingStringMechanicalLogicalElementExample
TopSideMechanicalLogicalElement:topSideHoistingAndRotationLogical
CasingStringMechanicalLogicalElement:casingStringLogical
topSideHoistingAndRotationLogical IsMechanicallyConnectedTo casingStringLogical
```
This example describes that the top-drive or kelly is mechanically connected to a casing string.
## LinerStringMechanicalLogicalElement <!-- NOUN -->
- Display name: Liner-string Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of a liner-string, i.e., a drill-stem that is composed of a pipe section first and casing joints, a casing shoe and similar elements below.
- Examples:
```dwis LinerStringMechanicalLogicalElementExample
TopSideMechanicalLogicalElement:topSideHoistingAndRotationLogical
LinerStringMechanicalLogicalElement:linerStringLogical
topSideHoistingAndRotationLogical IsMechanicallyConnectedTo linerStringLogical
```
This example describes that the top-drive or kelly is mechanically connected to a liner string.
## TubingStringMechanicalLogicalElement <!-- NOUN -->
- Display name: Tubing-string Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of a tubing-string, i.e., a drill-stem that is composed of a tubings, expansion joint, packers and similar elements.
- Examples:
```dwis TubingStringMechanicalLogicalElementExample
TopSideMechanicalLogicalElement:topSideHoistingAndRotationLogical
TubingStringMechanicalLogicalElement:tubingStringLogical
topSideHoistingAndRotationLogical IsMechanicallyConnectedTo tubingStringLogical
```
This example describes that the top-side hoisting system is mechanically connected to a tubing string.
## PipeSectionMechanicalLogicalElement <!-- NOUN -->
- Display name: Pipe Section Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of the pipe section of a drill-stem. The pipe section contains drill-pipe, 
heavy-weight drill-pipe, jar, accelerator and other similar components.
- Examples:
```dwis PipeSectionMechanicalLogicalElementExample
PipeSectionMechanicalLogicalElement:pipeSectionLogical
BHAMechanicalLogicalElement:BHALogical
pipeSectionLogical IsMechanicallyConnectedTo BHALogical
```
This example describes that the pipe section is mechanically connected to the BHA.
## BHAMechanicalLogicalElement <!-- NOUN -->
- Display name: BHA Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of the BHA portion of a drill-string.
- Examples:
```dwis BHAMechanicalLogicalElementExample
PipeSectionMechanicalLogicalElement:pipeSectionLogical
BHAMechanicalLogicalElement:BHALogical
pipeSectionLogical IsMechanicallyConnectedTo BHALogical
```
This example describes that the pipe section is mechanically connected to the BHA.
## EndOfStringMechanicalLogicalElement <!-- NOUN -->
- Display name: End Of String Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of the end of the drill-stem, e.g., bit, bull-nose, casing shoe, etc.
- Examples:
```dwis EndOfStringMechanicalLogicalElementExample
BHAMechanicalLogicalElement:BHALogical
EndOfStringMechanicalLogicalElement:BitLogical
BHALogical IsMechanicallyConnectedTo BitLogical
```
This example describes that the BHA is mechanically connected to the Bit.
## CasingSectionMechanicalLogicalElement <!-- NOUN -->
- Display name: Casing-section Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of the casing-section portion of a casing or liner string.
- Examples:
```dwis CasingSectionMechanicalLogicalElementExample
PipeSectionMechanicalLogicalElement:pipeSectionLogical
CasingSectionMechanicalLogicalElement:casingSectionLogical
ShoeTrackMechanicalLogicalElement:shoeTrackLogical
pipeSectionLogical IsMechanicallyConnectedTo casingSectionLogical
casingSectionLogical IsMechanicallyConnectedTo shoeTrackLogical
```
This example describes that the logical decomposition of a liner-string in a pipe section attached to a casing section attached to a shoe-track.
## ShoeTrackMechanicalLogicalElement <!-- NOUN -->
- Display name: Shoe-track Mechanical Logical Element
- Parent class: DrillStemMechanicalLogicalElement
- Attributes:
- Specialization:
- Description: Abstract mechanical representation of the show-track portion of a casing or liner string.
- Examples:
```dwis ShoeTrackMechanicalLogicalElementExample
CasingSectionMechanicalLogicalElement:casingSectionLogical
ShoeTrackMechanicalLogicalElement:shoeTrackLogical
casingSectionLogical IsMechanicallyConnectedTo shoeTrackLogical
```
This example describes that a casing-string that is composed of a casing-sectiond attached to a shoe-track.
## MotionType <!-- NOUN -->
- Display name: MotionType
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Classifies the type of motion considered (axial, torsional, lateral).
- Examples:
```dwis motionType
MotionType:motion
DrillingDataPoint:hookload
hookload IsForMotionType motion
```
This example relates a signal to a motion type.
## AxialMotionType <!-- NOUN -->
- Display name: AxialMotionType
- Parent class: MotionType
- Attributes:
- Specialization:
- Description: Motion along the string axis.
- Examples:
```dwis axialMotion
AxialMotionType:axialMotion
MechanicalLogicalElement:drillString
drillString HasMotionType axialMotion
```
This example tags axial motion for a drill string element.
## TorsionalMotionType <!-- NOUN -->
- Display name: TorsionalMotionType
- Parent class: MotionType
- Attributes:
- Specialization:
- Description: Rotational motion around the axis.
- Examples:
```dwis torsionalMotion
TorsionalMotionType:torsionalMotion
MechanicalLogicalElement:drillString
drillString HasMotionType torsionalMotion
```
This example tags torsional motion for a drill string element.
## LateralMotionType <!-- NOUN -->
- Display name: LateralMotionType
- Parent class: MotionType
- Attributes:
- Specialization:
- Description: Motion perpendicular to the string axis.
- Examples:
```dwis lateralMotion
LateralMotionType:lateralMotion
MechanicalLogicalElement:drillString
drillString HasMotionType lateralMotion
```
This example tags lateral motion for a drill string element.

# VERBS
## IsAMechanicalRepresentationFor <!-- VERB -->
- Display name: IsAMechanicalRepresentationFor
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: DrillingEquipment
- Description: Links a mechanical logical element to the equipment it represents.
- Examples: 
```dwis mechRepresentation
MechanicalLogicalElement:topDrive
DrillingEquipment:topDriveEquipment
topDrive IsAMechanicalRepresentationFor topDriveEquipment
```
This example maps a logical element to the top drive equipment.
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: MechanicalElementState
- Description: Assigns a mechanical state to an element.
- Examples: 
```dwis mechStateExample
MechanicalLogicalElement:topDrive
MechanicalElementState:mechanicalState
topDrive HasMechanicalState mechanicalState
```
This example attaches a state to the top drive.
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: DWISVerb
- Subject class: MechanicalElementState
- Object class: DrillingDataPoint
- Description: Indicates the data point providing the state value.
- Examples: 
```dwis stateValue
MechanicalElementState:mechanicalState
DrillingDataPoint:topDriveStatusSignal
mechanicalState HasMechanicalStateValueFrom topDriveStatusSignal
```
This example sets the state value from a status signal.
## IsMechanicallyConnectedTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: MechanicalLogicalElement
- Description: Indicates a mechanical connection between two elements.
- Examples: 
```dwis mechanicalConnection
MechanicalLogicalElement:drillString
MechanicalLogicalElement:topDrive
drillString IsMechanicallyConnectedTo topDrive
```
This example connects the drill string to the top drive.
## IsMechanicallyLocatedAt <!-- VERB -->
- Display name: IsMechanicallyLocatedAt
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: MechanicalLogicalElement
- Description: Places a mechanical measurement at a specific element.
- Examples: 
```dwis IsMechanicallyLocatedAtExample
DrillingDataPoint:torqueAtBit
MechanicalLogicalElement:bit
torqueAtBit IsMechanicallyLocatedAt bit
```
This example locates torque measurement at the bit.
```dwis ASMInsidePressureExample
DynamicDrillingSignal:BlackStreamMeasuredStringPressure
DerivedMeasurement:BlackStreamMeasuredStringPressure#01
BlackStreamMeasuredStringPressure#01 BelongsToClass JSonDataType
BlackStreamMeasuredStringPressure#01 HasDynamicValue BlackStreamMeasuredStringPressure
BlackStreamMeasuredStringPressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageBlackStreamMeasuredStringPressure
BlackStreamMeasuredStringPressure#01 IsTransformationOutput movingAverageBlackStreamMeasuredStringPressure
WiredPipeTelemetry:wiredPipeTelemetry
BlackStreamMeasuredStringPressure#01 IsTransmittedBy wiredPipeTelemetry
DynamicDrillingSignal:BlackStreamMeasuredStringPressureUncertainty
DrillingDataPoint:BlackStreamMeasuredStringPressureUncertainty#01
BlackStreamMeasuredStringPressureUncertainty#01 BelongsToClass ContinuousDataType
BlackStreamMeasuredStringPressureUncertainty#01 IsOfMeasurableQuantity PressureDrilling
BlackStreamMeasuredStringPressureUncertainty#01 HasDynamicValue BlackStreamMeasuredStringPressureUncertainty
GaussianUncertainty:BlackStreamMeasuredStringPressureGaussianUncertainty#01
BlackStreamMeasuredStringPressureGaussianUncertainty#01 HasUncertaintyStandardDeviation BlackStreamMeasuredStringPressureUncertainty#01
BlackStreamMeasuredStringPressure#01 HasUncertainty BlackStreamMeasuredStringPressureGaussianUncertainty#01
TopOfStringJunction:topOfStringJunction#01
HydraulicBranch:stringHydraulicBranch#01
topOfStringJunction#01 HasDownstreamBranch stringHydraulicBranch#01
BlackStreamMeasuredStringPressure#01 IsAssociatedToHydraulicBranch stringHydraulicBranch#01
PipeSectionMechanicalLogicalElement:pipeSection#01
BlackStreamMeasuredStringPressure#01 IsMechanicallyLocatedAt pipeSection#01
InstrumentationCompany:NOV#01
BlackStreamMeasuredStringPressure#01 IsProvidedBy NOV#01
```
This example describes a pressure signal that is measured inside the drill string and located at the drill string element.
## IsForMotionType <!-- VERB -->
- Display name: IsForMotionType
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: MotionType
- Description: Indicates that a data point relates to a specific motion type.
- Examples:
```dwis motionTypeSignal
DrillingDataPoint:axialVelocity
AxialMotionType:axialMotion
axialVelocity IsForMotionType axialMotion
```
This example tags axial velocity with an axial motion type.
## HasMotionType <!-- VERB -->
- Display name: HasMotionType
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: MotionType
- Description: Declares the types of motion a mechanical element can exhibit or model.
- Examples: 
```dwis elementMotionType
MechanicalLogicalElement:drillString
TorsionalMotionType:torsionalMotion
drillString HasMotionType torsionalMotion
```
This example notes torsional motion for the drill string.
