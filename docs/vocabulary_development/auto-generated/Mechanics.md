# Mechanics<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## MechanicalElementState <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: [DWISNoun](#./DWISSemantics.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: [MechanicalElementState](#./Mechanics.md)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyConnectedState <!-- NOUN -->
- Display name: MechanicallyConnectedState
- Parent class: [MechanicalElementState](#./Mechanics.md)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicalLogicalElement <!-- NOUN -->
- Display name: MechanicalLogicalElement
- Parent class: [DWISNoun](#./DWISSemantics.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
# Verbs
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: [DWISVerb](#./.md)
- Subject class: [MechanicalLogicalElement](#./Mechanics.md)
- Object class: [MechanicalElementState](#./Mechanics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: [DWISVerb](#./.md)
- Subject class: [MechanicalLogicalElement](#./Mechanics.md)
- Object class: [DrillingData](#./DrillingDataSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## IsMechanicallyConnectTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DWISNoun](#./DWISSemantics.md)
- Object class: [DWISNoun](#./DWISSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
