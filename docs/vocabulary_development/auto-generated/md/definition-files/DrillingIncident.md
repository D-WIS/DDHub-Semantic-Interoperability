# DrillingIncident<!-- DEFINITION SET HEADER -->
- Description: 
this category refers mostly to the description of drilling incidents.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
DWISNoun <|-- DrillingIncident
DrillingIncident <|-- AbnormalOscillation
AbnormalOscillation <|-- AbnormalAxialOscillation
AbnormalOscillation <|-- AbnormalTorsionalOscillation
AbnormalOscillation <|-- AbnormalLateralOscillation
AbnormalTorsionalOscillation <|-- StickSlip
AbnormalTorsionalOscillation <|-- HFTO
AbnormalLateralOscillation <|-- Whirling
Whirling <|-- ForwardWhirl
Whirling <|-- BackwardWhirl
Whirling <|-- ChaoticWhirl
AbnormalLateralOscillation <|-- Shock
DrillingIncident <|-- TwistOff
DrillingIncident <|-- Overpull
DrillingIncident <|-- Underpull
DrillingIncident <|-- Influx
DrillingIncident <|-- LossCirculation
DrillingIncident <|-- HoleCollapse
DrillingIncident <|-- StuckPipe
DrillingIncident <|-- PipeWashout
DrillingIncident <|-- FormationWashout
DrillingIncident <|-- OverTorque
DrillingIncident <|-- Plugged
```
## DrillingIncident <!-- NOUN -->
- Display name: DrillingIncident
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Definition set: DrillingIncident
## AbnormalOscillation <!-- NOUN -->
- Display name: Abnormal Oscillation
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## AbnormalAxialOscillation <!-- NOUN -->
- Display name: Abnormal Axial Oscillation
- Parent class: [AbnormalOscillation](./DrillingIncident.md#AbnormalOscillation)
- Definition set: DrillingIncident
## AbnormalTorsionalOscillation <!-- NOUN -->
- Display name: Abnormal Torsional Oscillation
- Parent class: [AbnormalOscillation](./DrillingIncident.md#AbnormalOscillation)
- Definition set: DrillingIncident
## AbnormalLateralOscillation <!-- NOUN -->
- Display name: Abnormal Lateral Oscillation
- Parent class: [AbnormalOscillation](./DrillingIncident.md#AbnormalOscillation)
- Definition set: DrillingIncident
## StickSlip <!-- NOUN -->
- Display name: Stick-slip
- Parent class: [AbnormalTorsionalOscillation](./DrillingIncident.md#AbnormalTorsionalOscillation)
- Definition set: DrillingIncident
## HFTO <!-- NOUN -->
- Display name: High Frequency Torsional Oscillation
- Parent class: [AbnormalTorsionalOscillation](./DrillingIncident.md#AbnormalTorsionalOscillation)
- Definition set: DrillingIncident
## Whirling <!-- NOUN -->
- Display name: Whirling
- Parent class: [AbnormalLateralOscillation](./DrillingIncident.md#AbnormalLateralOscillation)
- Definition set: DrillingIncident
## ForwardWhirl <!-- NOUN -->
- Display name: Forward Whirl
- Parent class: [Whirling](./DrillingIncident.md#Whirling)
- Definition set: DrillingIncident
## BackwardWhirl <!-- NOUN -->
- Display name: Backward Whirl
- Parent class: [Whirling](./DrillingIncident.md#Whirling)
- Definition set: DrillingIncident
## ChaoticWhirl <!-- NOUN -->
- Display name: Chaotic Whirl
- Parent class: [Whirling](./DrillingIncident.md#Whirling)
- Definition set: DrillingIncident
## Shock <!-- NOUN -->
- Display name: Shock
- Parent class: [AbnormalLateralOscillation](./DrillingIncident.md#AbnormalLateralOscillation)
- Definition set: DrillingIncident
## TwistOff <!-- NOUN -->
- Display name: TwistOff
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## Overpull <!-- NOUN -->
- Display name: Overpull
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## Underpull <!-- NOUN -->
- Display name: Underpull
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## Influx <!-- NOUN -->
- Display name: Influx
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## LossCirculation <!-- NOUN -->
- Display name: LossCirculation
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## HoleCollapse <!-- NOUN -->
- Display name: HoleCollapse
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## StuckPipe <!-- NOUN -->
- Display name: StuckPipe
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## PipeWashout <!-- NOUN -->
- Display name: PipeWashout
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## FormationWashout <!-- NOUN -->
- Display name: FormationWashout
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## OverTorque <!-- NOUN -->
- Display name: OverTorque
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
## Plugged <!-- NOUN -->
- Display name: Plugged
- Parent class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsRelatedToDrillingIncident
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
DrillingDataPoint ||--o{ DrillingIncident : IsRelatedToDrillingIncident
```
## IsRelatedToDrillingIncident <!-- VERB -->
- Display name: IsRelatedToDrillingIncident
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingIncident](./DrillingIncident.md#DrillingIncident)
- Definition set: DrillingIncident
