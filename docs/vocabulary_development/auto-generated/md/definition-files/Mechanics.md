# Mechanics<!-- DEFINITION SET HEADER -->
- Description: 
this part refers to the mechanical circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
DWISNoun <|-- MechanicalElementState
MechanicalElementState <|-- MechanicallyClosedState
MechanicalElementState <|-- MechanicallyOpenState
MechanicalElementState <|-- MechanicallyActiveState
MechanicalElementState <|-- MechanicallyInactiveState
MechanicalElementState <|-- MechanicallyConnectedState
DWISNoun <|-- MechanicalLogicalElement
DWISNoun <|-- MotionType
MotionType <|-- AxialMotionType
MotionType <|-- TorsionalMotionType
MotionType <|-- LateralMotionType
```
## MechanicalElementState <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Definition set: Mechanics
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Definition set: Mechanics
## MechanicallyOpenState <!-- NOUN -->
- Display name: MechanicallyOpenState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Definition set: Mechanics
## MechanicallyActiveState <!-- NOUN -->
- Display name: MechanicallyActiveState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Definition set: Mechanics
## MechanicallyInactiveState <!-- NOUN -->
- Display name: MechanicallyInactiveState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Definition set: Mechanics
## MechanicallyConnectedState <!-- NOUN -->
- Display name: MechanicallyConnectedState
- Parent class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Definition set: Mechanics
## MechanicalLogicalElement <!-- NOUN -->
- Display name: MechanicalLogicalElement
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Definition set: Mechanics
## MotionType <!-- NOUN -->
- Display name: MotionType
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Definition set: Mechanics
## AxialMotionType <!-- NOUN -->
- Display name: AxialMotionType
- Parent class: [MotionType](./Mechanics.md#MotionType)
- Definition set: Mechanics
## TorsionalMotionType <!-- NOUN -->
- Display name: TorsionalMotionType
- Parent class: [MotionType](./Mechanics.md#MotionType)
- Definition set: Mechanics
## LateralMotionType <!-- NOUN -->
- Display name: LateralMotionType
- Parent class: [MotionType](./Mechanics.md#MotionType)
- Definition set: Mechanics
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsAMechanicalRepresentationFor
DWISVerb <|-- HasMechanicalState
DWISVerb <|-- HasMechanicalStateValueFrom
DWISVerb <|-- IsMechanicallyConnectedTo
DWISVerb <|-- IsMechanicallyLocatedAt
DWISVerb <|-- IsForMotionType
DWISVerb <|-- HasMotionType
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
MechanicalLogicalElement ||--o{ DrillingEquipment : IsAMechanicalRepresentationFor
MechanicalLogicalElement ||--o{ MechanicalElementState : HasMechanicalState
MechanicalElementState ||--o{ DrillingDataPoint : HasMechanicalStateValueFrom
MechanicalLogicalElement ||--o{ MechanicalLogicalElement : IsMechanicallyConnectedTo
DrillingDataPoint ||--o{ MechanicalLogicalElement : IsMechanicallyLocatedAt
DrillingDataPoint ||--o{ MotionType : IsForMotionType
MechanicalLogicalElement ||--o{ MotionType : HasMotionType
```
## IsAMechanicalRepresentationFor <!-- VERB -->
- Display name: IsAMechanicalRepresentationFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [DrillingEquipment](./DrillingEquipment.md#DrillingEquipment)
- Definition set: Mechanics
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Definition set: Mechanics
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalElementState](./Mechanics.md#MechanicalElementState)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Definition set: Mechanics
## IsMechanicallyConnectedTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Definition set: Mechanics
## IsMechanicallyLocatedAt <!-- VERB -->
- Display name: IsMechanicallyLocatedAt
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Definition set: Mechanics
## IsForMotionType <!-- VERB -->
- Display name: IsForMotionType
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [MotionType](./Mechanics.md#MotionType)
- Definition set: Mechanics
## HasMotionType <!-- VERB -->
- Display name: HasMotionType
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MechanicalLogicalElement](./Mechanics.md#MechanicalLogicalElement)
- Object class: [MotionType](./Mechanics.md#MotionType)
- Definition set: Mechanics
