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
- Description: 
- Examples:
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: 
- Examples:
## MechanicallyConnectedState <!-- NOUN -->
- Display name: MechanicallyConnectedState
- Parent class: MechanicalElementState
- Attributes:
- Specialization:
- Description: 
- Examples:
## MechanicalLogicalElement <!-- NOUN -->
- Display name: MechanicalLogicalElement
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## MotionType <!-- NOUN -->
- Display name: MotionType
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## AxialMotionType <!-- NOUN -->
- Display name: AxialMotionType
- Parent class: MotionType
- Attributes:
- Specialization:
- Description: 
- Examples:
## TorsionalMotionType <!-- NOUN -->
- Display name: TorsionalMotionType
- Parent class: MotionType
- Attributes:
- Specialization:
- Description: 
- Examples:
## LateralMotionType <!-- NOUN -->
- Display name: LateralMotionType
- Parent class: MotionType
- Attributes:
- Specialization:
- Description: 
- Examples:

# VERBS
## IsAMechanicalRepresentationFor <!-- VERB -->
- Display name: IsAMechanicalRepresentationFor
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: DrillingEquipment
- Description: 
- Examples: 
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: MechanicalElementState
- Description: 
- Examples: 
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: DWISVerb
- Subject class: MechanicalElementState
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## IsMechanicallyConnectedTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: MechanicalLogicalElement
- Description: 
- Examples: 
## IsMechanicallyLocatedAt <!-- VERB -->
- Display name: IsMechanicallyLocatedAt
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: MechanicalLogicalElement
- Description: 
- Examples: 
## IsForMotionType <!-- VERB -->
- Display name: IsForMotionType
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: MotionType
- Description: 
- Examples:
## HasMotionType <!-- VERB -->
- Display name: HasMotionType
- Parent verb: DWISVerb
- Subject class: MechanicalLogicalElement
- Object class: MotionType
- Description: 
- Examples: 
