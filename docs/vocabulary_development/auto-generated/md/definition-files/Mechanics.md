# Mechanics<!-- DEFINITION SET HEADER -->
- Description: this part refers to the mechanical circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.
# Nouns
## MechanicalElementState <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyOpenState <!-- NOUN -->
- Display name: MechanicallyOpenState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyActiveState <!-- NOUN -->
- Display name: MechanicallyActiveState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyInactiveState <!-- NOUN -->
- Display name: MechanicallyInactiveState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyConnectedState <!-- NOUN -->
- Display name: MechanicallyConnectedState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicalLogicalElement <!-- NOUN -->
- Display name: MechanicalLogicalElement
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MotionType <!-- NOUN -->
- Display name: MotionType
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## AxialMotionType <!-- NOUN -->
- Display name: AxialMotionType
- Parent class: [MotionType](./Mechanics.md#MotionType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## TorsionalMotionType <!-- NOUN -->
- Display name: TorsionalMotionType
- Parent class: [MotionType](./Mechanics.md#MotionType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## LateralMotionType <!-- NOUN -->
- Display name: LateralMotionType
- Parent class: [MotionType](./Mechanics.md#MotionType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
# Verbs
## IsAMechanicalRepresentationFor <!-- VERB -->
- Display name: IsAMechanicalRepresentationFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [DrillingEquipment](./DrillingEquipment.md#DrillingEquipment)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
## IsMechanicallyConnectedTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
## IsMechanicallyLocatedAt <!-- VERB -->
- Display name: IsMechanicallyLocatedAt
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
## IsForMotionType <!-- VERB -->
- Display name: IsForMotionType
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [MotionType](./Mechanics.md#MotionType)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
## HasMotionType <!-- VERB -->
- Display name: HasMotionType
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [MotionType](./Mechanics.md#MotionType)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: Mechanics
