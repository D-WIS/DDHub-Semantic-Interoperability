# Mechanics<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## MechanicalElementState <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: [DWISNoun](#./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: [MechanicalElementState](#./Mechanics.md#MechanicalElementState)
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
- Parent class: [MechanicalElementState](#./Mechanics.md#MechanicalElementState)
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
- Parent class: [DWISNoun](#./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
# Verbs
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: [DWISVerb](#./.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](#./Mechanics.md#MechanicalLogicalElement)
- Object class: [MechanicalElementState](#./Mechanics.md#MechanicalElementState)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: [DWISVerb](#./.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](#./Mechanics.md#MechanicalLogicalElement)
- Object class: [DrillingData](#./DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## IsMechanicallyConnectTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: [DWISVerb](#./.md#DWISVerb)
- Subject class: [DWISNoun](#./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](#./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
