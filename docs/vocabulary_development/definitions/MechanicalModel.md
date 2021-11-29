# NOUNS
## DrillStemMechanicalModel <!-- NOUN -->
- Display name: Drill-stem mechanical model
- Parent class: MathematicalModel
- Attributes:
- Specialization: 
- Description: A mechanical model for a drill-stem. Another name for drill-stem mechanical models is a torque and drag model.
- Examples:
## MechanicalStiffnessType <!-- NOUN -->
- Display name: Mechanical stiffness type
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A description of how the drill-stem stiffness is modelled.
- Examples:
## MechanicalSoftModel <!-- NOUN -->
- Display name: Mechanical soft model
- Parent class: MechanicalStiffnessType
- Attributes:
- Specialization: 
- Description: An infinitively soft model assumes that the drill-stem deforms without any resistance when compressive loads are applied.
- Examples:
## MechanicalStiffModel <!-- NOUN -->
- Display name: Mechanical stiff model
- Parent class: MechanicalStiffnessType
- Attributes:
- Specialization:
- Description: A stiff mechanical model considers that the drill-stem can deform laterally when put in compression.
- Examples:
## MechanicalStiffModelAssumedContacts<!-- NOUN -->
- Display name: Mechanical stiff model with assumed contacts
- Parent class: MechanicalStiffModel
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model presuposes the position of the contact points.
- Examples:
## MechanicalStiffModelEstimatedContacts<!-- NOUN -->
- Display name: Mechanical stiff model with estimated contacts
- Parent class: MechanicalStiffModel
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model estimates the position of the contact points.
- Examples:


# VERBS
## IsOfMechanicalStiffnessType <!-- VERB -->
- Display name: Is of mechanical stiffness type
- Subject class: MechanicalModel
- Object class: MechanicalStiffnessType
- Description: A relation to describe how the drill-stem mechanical model manage stiffness.
- Examples: 
