# MechanicalModel<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## DrillStemMechanicalModel <!-- NOUN -->
- Display name: DrillStemMechanicalModel
- Parent class: [MathematicalModel](./Model.md#MathematicalModel)
- Attributes:
- Specialization:
- Description: A mechanical model for a drill-stem. Another name for drill-stem mechanical models is a torque and drag model.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffnessType <!-- NOUN -->
- Display name: MechanicalStiffnessType
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: A description of how the drill-stem stiffness is modelled.
- Examples:
- Definition set: MechanicalModel
## MechanicalSoftModel <!-- NOUN -->
- Display name: MechanicalSoftModel
- Parent class: [MechanicalStiffnessType](./MechanicalModel.md#MechanicalStiffnessType)
- Attributes:
- Specialization:
- Description: An infinitively soft model assumes that the drill-stem deforms without any resistance when compressive loads are applied.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffModel <!-- NOUN -->
- Display name: MechanicalStiffModel
- Parent class: [MechanicalStiffnessType](./MechanicalModel.md#MechanicalStiffnessType)
- Attributes:
- Specialization:
- Description: A stiff mechanical model considers that the drill-stem can deform laterally when put in compression.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffModelAssumedContacts <!-- NOUN -->
- Display name: MechanicalStiffModelAssumedContacts
- Parent class: [MechanicalStiffModel](./MechanicalModel.md#MechanicalStiffModel)
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model presuposes the position of the contact points.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffModelEstimatedContacts <!-- NOUN -->
- Display name: MechanicalStiffModelEstimatedContacts
- Parent class: [MechanicalStiffModel](./MechanicalModel.md#MechanicalStiffModel)
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model estimates the position of the contact points.
- Examples:
- Definition set: MechanicalModel
# Verbs
## IsOfMechanicalStiffnessType <!-- VERB -->
- Display name: IsOfMechanicalStiffnessType
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalModel](./.md#MechanicalModel)
- Object class: [MechanicalStiffnessType](./MechanicalModel.md#MechanicalStiffnessType)
- Min cardinality: -1
- Max cardinality: -1
- Description: A relation to describe how the drill-stem mechanical model manage stiffness.
- Examples: 
- Definition set: MechanicalModel
