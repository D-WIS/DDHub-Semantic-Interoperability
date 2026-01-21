- Description: specialized vocabulary for the modelling of the drilling mechanics. Covers in particular torque and drag models

# NOUNS
## DrillStemMechanicalModel <!-- NOUN -->
- Display name: Drill-stem mechanical model
- Parent class: ModelType
- Attributes:
- Specialization: 
- Description: A mechanical model for a drill-stem. Another standard name for drill-stem mechanical models is a torque and drag model.
- Examples:
```dwis torqueDragModelExample
DrillStemMechanicalModel:torqueAndDragModel
DynamicDrillingSignal:topOfStringForceSignal
DrillingDataPoint:topOfStringForce_01
topOfStringForce_01 BelongsToClass ContinuousDataType
topOfStringForce_01 HasDynamicValue topOfStringForceSignal
topOfStringForce_01 IsOfMeasurableQuantity AxialForceDrilling
topOfStringForce_01 IsComputedBy torqueAndDragModel
TopOfStringReferenceLocation:topOfString
topOfStringForce_01 IsPhysicallyLocatedAt topOfString
```
This example defines a torque and drag model and links it to a computed top-of-string force data point.
## MechanicalStiffnessType <!-- NOUN -->
- Display name: Mechanical stiffness type
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A description of how the drill-stem stiffness is modelled.
- Examples:
```dwis stiffnessTypeExample
MechanicalStiffnessType:stiffnessAssumption
DrillStemMechanicalModel:torqueDragModel
torqueDragModel IsOfMechanicalStiffnessType stiffnessAssumption
```
This example attaches a stiffness assumption to a drill-stem mechanical model.
## MechanicalSoftModel <!-- NOUN -->
- Display name: Mechanical soft model
- Parent class: MechanicalStiffnessType
- Attributes:
- Specialization: 
- Description: An infinitively soft model assumes that the drill-stem deforms without any resistance when compressive loads are applied.
- Examples:
```dwis softModelExample
MechanicalSoftModel:softModel
DrillStemMechanicalModel:torqueDragModel
torqueDragModel IsOfMechanicalStiffnessType softModel
```
This example sets a soft stiffness assumption.
## MechanicalStiffModel <!-- NOUN -->
- Display name: Mechanical stiff model
- Parent class: MechanicalStiffnessType
- Attributes:
- Specialization:
- Description: A stiff mechanical model considers that the drill-stem can deform laterally when put in compression.
- Examples:
```dwis stiffModelExample
MechanicalStiffModel:stiffModel
DrillStemMechanicalModel:torqueDragModel
torqueDragModel IsOfMechanicalStiffnessType stiffModel
```
This example sets a stiff stiffness assumption.
## MechanicalStiffModelAssumedContacts<!-- NOUN -->
- Display name: Mechanical stiff model with assumed contacts
- Parent class: MechanicalStiffModel
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model presuposes the position of the contact points.
- Examples:
```dwis stiffAssumedContactsExample
MechanicalStiffModelAssumedContacts:assumedContactsModel
DrillStemMechanicalModel:torqueDragModel
torqueDragModel IsOfMechanicalStiffnessType assumedContactsModel
```
This example uses assumed contact points.
## MechanicalStiffModelEstimatedContacts<!-- NOUN -->
- Display name: Mechanical stiff model with estimated contacts
- Parent class: MechanicalStiffModel
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model estimates the position of the contact points.
- Examples:
```dwis stiffEstimatedContactsExample
MechanicalStiffModelEstimatedContacts:estimatedContactsModel
DrillStemMechanicalModel:torqueDragModel
torqueDragModel IsOfMechanicalStiffnessType estimatedContactsModel
```
This example uses estimated contact points.
# VERBS
## IsOfMechanicalStiffnessType <!-- VERB -->
- Display name: Is of mechanical stiffness type
- Parent class: DWISVerb
- Subject class: DrillStemMechanicalModel
- Object class: MechanicalStiffnessType
- Description: A relation to describe how the drill-stem mechanical model manage stiffness.
- Examples: 
```dwis stiffnessRelationExample
DrillStemMechanicalModel:torqueDragModel
MechanicalStiffModel:stiffModel
torqueDragModel IsOfMechanicalStiffnessType stiffModel
```
This example links a torque and drag model to a stiff stiffness assumption.
