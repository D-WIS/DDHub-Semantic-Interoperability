# DrillingObjective<!-- DEFINITION SET HEADER -->
- Description: 
this category refers mostly to the description of drilling objectives.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
DWISNoun <|-- DrillingObjective
DrillingObjective <|-- StableAxialVelocityObjective
DrillingObjective <|-- StableRotationalVelocityObjective
DrillingObjective <|-- StablePressureObjective
DrillingObjective <|-- StableTorqueObjective
DrillingObjective <|-- StableAxialForceObjective
DrillingObjective <|-- WeightTransferObjective
```
## DrillingObjective <!-- NOUN -->
- Display name: Drilling Objective
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Description: 
This is the parent class for drilling objectives.
- Definition set: DrillingObjective
## StableAxialVelocityObjective <!-- NOUN -->
- Display name: Stable Axial Velocity Objective
- Parent class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Description: 
This Noun is used to refer to the objective of obtaining stable axial velocity.
- Definition set: DrillingObjective
- Examples:
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal:ROPManagementControllerInfo
DrillingControlAdvice:ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit:ROPLimit_1
ROPManagementControllerInfo_1 HasControlLimit ROPLimit_1
WOBLimit:WOBLimit_1
ROPManagementControllerInfo_1 HasControlLimit WOBLimit_1
DifferentialPressureLimit:differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
BottomOfStringReferenceLocation:bottomOfStringLocation
StableAxialVelocityObjective:stableAxialVelocityObjective
stableAxialVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective:stableWOBObjective
stableWOBObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective:stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany:serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer:adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ROPManagementControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[ROPManagementControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[ROPManagementControllerInfo_1] -->|HasDynamicValue| N0000[ROPManagementControllerInfo] 
	N0004[ROPLimit_1] -->|BelongsToClass| N0005(ROPLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0004[ROPLimit_1] 
	N0006[WOBLimit_1] -->|BelongsToClass| N0007(WOBLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0006[WOBLimit_1] 
	N0008[differentialPressureLimit] -->|BelongsToClass| N0009(DifferentialPressureLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0008[differentialPressureLimit] 
	N0010[bottomOfStringLocation] -->|BelongsToClass| N0011(BottomOfStringReferenceLocation) 
	N0012[stableAxialVelocityObjective] -->|BelongsToClass| N0013(StableAxialVelocityObjective) 
	N0012[stableAxialVelocityObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0012[stableAxialVelocityObjective] 
	N0014[stableWOBObjective] -->|BelongsToClass| N0015(StableAxialForceObjective) 
	N0014[stableWOBObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0014[stableWOBObjective] 
	N0016[stableDifferentialPressure] -->|BelongsToClass| N0017(StablePressureObjective) 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0016[stableDifferentialPressure] 
	N0018[serviceCompany] -->|BelongsToClass| N0019(ServiceCompany) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedBy| N0018[serviceCompany] 
	N0020[computationUnit] -->|BelongsToClass| N0021(Advisor) 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedBy| N0020[computationUnit] 
	N0022[autoDriller] -->|BelongsToClass| N0023(ControllerFunction) 
	N0022[autoDriller] -->|ImplementsObjective| N0012[stableAxialVelocityObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0014[stableWOBObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0016[stableDifferentialPressure] 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedFor| N0022[autoDriller] 
	N0024[adviceComposer] -->|BelongsToClass| N0025(DWISAdviceComposer) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0024[adviceComposer] 
	N0026[scheduler] -->|BelongsToClass| N0027(DWISScheduler) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0026[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?ROPManagementControllerInfo
WHERE {
	?ROPManagementControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?ROPManagementControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?ROPManagementControllerInfo_1 ddhub:HasDynamicValue ?ROPManagementControllerInfo .
	?ROPLimit_1 rdf:type ddhub:ROPLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?ROPLimit_1 .
	?WOBLimit_1 rdf:type ddhub:WOBLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?WOBLimit_1 .
	?differentialPressureLimit rdf:type ddhub:DifferentialPressureLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?differentialPressureLimit .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?stableAxialVelocityObjective rdf:type ddhub:StableAxialVelocityObjective .
	?stableAxialVelocityObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableAxialVelocityObjective .
	?stableWOBObjective rdf:type ddhub:StableAxialForceObjective .
	?stableWOBObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableWOBObjective .
	?stableDifferentialPressure rdf:type ddhub:StablePressureObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableDifferentialPressure .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?autoDriller rdf:type ddhub:ControllerFunction .
	?autoDriller ddhub:ImplementsObjective ?stableAxialVelocityObjective .
	?autoDriller ddhub:ImplementsObjective ?stableWOBObjective .
	?autoDriller ddhub:ImplementsObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedFor ?autoDriller .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## StableRotationalVelocityObjective <!-- NOUN -->
- Display name: Stable Rotational Velocity Objective
- Parent class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Description: 
This Noun is used to refer to the objective of obtaining stable rotational velocity.
- Definition set: DrillingObjective
- Examples:
``` dwis stickSlipMitigationControllerInfo
DynamicDrillingSignal:stickSlipMitigationControllerInfo
DrillingControlAdvice:stickSlipMitigationControllerInfo_1
stickSlipMitigationControllerInfo_1 HasDynamicValue stickSlipMitigationControllerInfo
BottomOfStringReferenceLocation:bottomOfStringLocation
StableRotationalVelocityObjective:stableRotationalVelocityObjective
stableRotationalVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
stickSlipMitigationControllerInfo_1 IsRelatedToDrillingObjective stableRotationalVelocityObjective
ServiceCompany:serviceCompany
stickSlipMitigationControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
stickSlipMitigationControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:stickSlipMitigation
stickSlipMitigation ImplementsObjective stableRotationalVelocityObjective
stickSlipMitigationControllerInfo_1 IsRecommendedFor stickSlipMitigation
DWISAdviceComposer:adviceComposer
stickSlipMitigationControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
stickSlipMitigationControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[stickSlipMitigationControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[stickSlipMitigationControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[stickSlipMitigationControllerInfo_1] -->|HasDynamicValue| N0000[stickSlipMitigationControllerInfo] 
	N0004[bottomOfStringLocation] -->|BelongsToClass| N0005(BottomOfStringReferenceLocation) 
	N0006[stableRotationalVelocityObjective] -->|BelongsToClass| N0007(StableRotationalVelocityObjective) 
	N0006[stableRotationalVelocityObjective] -->|IsPhysicallyLocatedAt| N0004[bottomOfStringLocation] 
	N0002[stickSlipMitigationControllerInfo_1] -->|IsRelatedToDrillingObjective| N0006[stableRotationalVelocityObjective] 
	N0008[serviceCompany] -->|BelongsToClass| N0009(ServiceCompany) 
	N0002[stickSlipMitigationControllerInfo_1] -->|IsProvidedBy| N0008[serviceCompany] 
	N0010[computationUnit] -->|BelongsToClass| N0011(Advisor) 
	N0002[stickSlipMitigationControllerInfo_1] -->|IsRecommendedBy| N0010[computationUnit] 
	N0012[stickSlipMitigation] -->|BelongsToClass| N0013(ControllerFunction) 
	N0012[stickSlipMitigation] -->|ImplementsObjective| N0006[stableRotationalVelocityObjective] 
	N0002[stickSlipMitigationControllerInfo_1] -->|IsRecommendedFor| N0012[stickSlipMitigation] 
	N0014[adviceComposer] -->|BelongsToClass| N0015(DWISAdviceComposer) 
	N0002[stickSlipMitigationControllerInfo_1] -->|IsProvidedTo| N0014[adviceComposer] 
	N0016[scheduler] -->|BelongsToClass| N0017(DWISScheduler) 
	N0002[stickSlipMitigationControllerInfo_1] -->|IsProvidedTo| N0016[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?stickSlipMitigationControllerInfo
WHERE {
	?stickSlipMitigationControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?stickSlipMitigationControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?stickSlipMitigationControllerInfo_1 ddhub:HasDynamicValue ?stickSlipMitigationControllerInfo .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?stableRotationalVelocityObjective rdf:type ddhub:StableRotationalVelocityObjective .
	?stableRotationalVelocityObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?stickSlipMitigationControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableRotationalVelocityObjective .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?stickSlipMitigationControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?stickSlipMitigationControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?stickSlipMitigation rdf:type ddhub:ControllerFunction .
	?stickSlipMitigation ddhub:ImplementsObjective ?stableRotationalVelocityObjective .
	?stickSlipMitigationControllerInfo_1 ddhub:IsRecommendedFor ?stickSlipMitigation .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?stickSlipMitigationControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?stickSlipMitigationControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## StablePressureObjective <!-- NOUN -->
- Display name: Stable Pressure Objective
- Parent class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Description: 
This Noun is used to refer to the objective of obtaining stable pressure.
- Definition set: DrillingObjective
- Examples:
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal:ROPManagementControllerInfo
DrillingControlAdvice:ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit:ROPLimit_1
ROPManagementControllerInfo_1 HasControlLimit ROPLimit_1
WOBLimit:WOBLimit_1
ROPManagementControllerInfo_1 HasControlLimit WOBLimit_1
DifferentialPressureLimit:differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
BottomOfStringReferenceLocation:bottomOfStringLocation
StableAxialVelocityObjective:stableAxialVelocityObjective
stableAxialVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective:stableWOBObjective
stableWOBObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective:stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany:serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer:adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ROPManagementControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[ROPManagementControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[ROPManagementControllerInfo_1] -->|HasDynamicValue| N0000[ROPManagementControllerInfo] 
	N0004[ROPLimit_1] -->|BelongsToClass| N0005(ROPLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0004[ROPLimit_1] 
	N0006[WOBLimit_1] -->|BelongsToClass| N0007(WOBLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0006[WOBLimit_1] 
	N0008[differentialPressureLimit] -->|BelongsToClass| N0009(DifferentialPressureLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0008[differentialPressureLimit] 
	N0010[bottomOfStringLocation] -->|BelongsToClass| N0011(BottomOfStringReferenceLocation) 
	N0012[stableAxialVelocityObjective] -->|BelongsToClass| N0013(StableAxialVelocityObjective) 
	N0012[stableAxialVelocityObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0012[stableAxialVelocityObjective] 
	N0014[stableWOBObjective] -->|BelongsToClass| N0015(StableAxialForceObjective) 
	N0014[stableWOBObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0014[stableWOBObjective] 
	N0016[stableDifferentialPressure] -->|BelongsToClass| N0017(StablePressureObjective) 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0016[stableDifferentialPressure] 
	N0018[serviceCompany] -->|BelongsToClass| N0019(ServiceCompany) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedBy| N0018[serviceCompany] 
	N0020[computationUnit] -->|BelongsToClass| N0021(Advisor) 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedBy| N0020[computationUnit] 
	N0022[autoDriller] -->|BelongsToClass| N0023(ControllerFunction) 
	N0022[autoDriller] -->|ImplementsObjective| N0012[stableAxialVelocityObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0014[stableWOBObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0016[stableDifferentialPressure] 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedFor| N0022[autoDriller] 
	N0024[adviceComposer] -->|BelongsToClass| N0025(DWISAdviceComposer) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0024[adviceComposer] 
	N0026[scheduler] -->|BelongsToClass| N0027(DWISScheduler) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0026[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?ROPManagementControllerInfo
WHERE {
	?ROPManagementControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?ROPManagementControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?ROPManagementControllerInfo_1 ddhub:HasDynamicValue ?ROPManagementControllerInfo .
	?ROPLimit_1 rdf:type ddhub:ROPLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?ROPLimit_1 .
	?WOBLimit_1 rdf:type ddhub:WOBLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?WOBLimit_1 .
	?differentialPressureLimit rdf:type ddhub:DifferentialPressureLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?differentialPressureLimit .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?stableAxialVelocityObjective rdf:type ddhub:StableAxialVelocityObjective .
	?stableAxialVelocityObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableAxialVelocityObjective .
	?stableWOBObjective rdf:type ddhub:StableAxialForceObjective .
	?stableWOBObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableWOBObjective .
	?stableDifferentialPressure rdf:type ddhub:StablePressureObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableDifferentialPressure .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?autoDriller rdf:type ddhub:ControllerFunction .
	?autoDriller ddhub:ImplementsObjective ?stableAxialVelocityObjective .
	?autoDriller ddhub:ImplementsObjective ?stableWOBObjective .
	?autoDriller ddhub:ImplementsObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedFor ?autoDriller .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## StableTorqueObjective <!-- NOUN -->
- Display name: Stable Torque Objective
- Parent class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Description: 
This Noun is used to refer to the objective of obtaining stable torque.
- Definition set: DrillingObjective
## StableAxialForceObjective <!-- NOUN -->
- Display name: Stable Axial Force Objective
- Parent class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Description: 
This Noun is used to refer to the objective of obtaining stable axial force.
- Definition set: DrillingObjective
- Examples:
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal:ROPManagementControllerInfo
DrillingControlAdvice:ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit:ROPLimit_1
ROPManagementControllerInfo_1 HasControlLimit ROPLimit_1
WOBLimit:WOBLimit_1
ROPManagementControllerInfo_1 HasControlLimit WOBLimit_1
DifferentialPressureLimit:differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
BottomOfStringReferenceLocation:bottomOfStringLocation
StableAxialVelocityObjective:stableAxialVelocityObjective
stableAxialVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective:stableWOBObjective
stableWOBObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective:stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany:serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer:adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ROPManagementControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[ROPManagementControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[ROPManagementControllerInfo_1] -->|HasDynamicValue| N0000[ROPManagementControllerInfo] 
	N0004[ROPLimit_1] -->|BelongsToClass| N0005(ROPLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0004[ROPLimit_1] 
	N0006[WOBLimit_1] -->|BelongsToClass| N0007(WOBLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0006[WOBLimit_1] 
	N0008[differentialPressureLimit] -->|BelongsToClass| N0009(DifferentialPressureLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0008[differentialPressureLimit] 
	N0010[bottomOfStringLocation] -->|BelongsToClass| N0011(BottomOfStringReferenceLocation) 
	N0012[stableAxialVelocityObjective] -->|BelongsToClass| N0013(StableAxialVelocityObjective) 
	N0012[stableAxialVelocityObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0012[stableAxialVelocityObjective] 
	N0014[stableWOBObjective] -->|BelongsToClass| N0015(StableAxialForceObjective) 
	N0014[stableWOBObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0014[stableWOBObjective] 
	N0016[stableDifferentialPressure] -->|BelongsToClass| N0017(StablePressureObjective) 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0016[stableDifferentialPressure] 
	N0018[serviceCompany] -->|BelongsToClass| N0019(ServiceCompany) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedBy| N0018[serviceCompany] 
	N0020[computationUnit] -->|BelongsToClass| N0021(Advisor) 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedBy| N0020[computationUnit] 
	N0022[autoDriller] -->|BelongsToClass| N0023(ControllerFunction) 
	N0022[autoDriller] -->|ImplementsObjective| N0012[stableAxialVelocityObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0014[stableWOBObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0016[stableDifferentialPressure] 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedFor| N0022[autoDriller] 
	N0024[adviceComposer] -->|BelongsToClass| N0025(DWISAdviceComposer) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0024[adviceComposer] 
	N0026[scheduler] -->|BelongsToClass| N0027(DWISScheduler) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0026[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?ROPManagementControllerInfo
WHERE {
	?ROPManagementControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?ROPManagementControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?ROPManagementControllerInfo_1 ddhub:HasDynamicValue ?ROPManagementControllerInfo .
	?ROPLimit_1 rdf:type ddhub:ROPLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?ROPLimit_1 .
	?WOBLimit_1 rdf:type ddhub:WOBLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?WOBLimit_1 .
	?differentialPressureLimit rdf:type ddhub:DifferentialPressureLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?differentialPressureLimit .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?stableAxialVelocityObjective rdf:type ddhub:StableAxialVelocityObjective .
	?stableAxialVelocityObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableAxialVelocityObjective .
	?stableWOBObjective rdf:type ddhub:StableAxialForceObjective .
	?stableWOBObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableWOBObjective .
	?stableDifferentialPressure rdf:type ddhub:StablePressureObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableDifferentialPressure .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?autoDriller rdf:type ddhub:ControllerFunction .
	?autoDriller ddhub:ImplementsObjective ?stableAxialVelocityObjective .
	?autoDriller ddhub:ImplementsObjective ?stableWOBObjective .
	?autoDriller ddhub:ImplementsObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedFor ?autoDriller .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## WeightTransferObjective <!-- NOUN -->
- Display name: Weight Transfer Objective
- Parent class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Description: 
This Noun is used to refer to the objective of transferring weight to the bottom of the drill-stem.
- Definition set: DrillingObjective
- Examples:
``` dwis pipeRockingControllerInfo
DynamicDrillingSignal:pipeRockingControllerInfo
DrillingControlAdvice:pipeRockingControllerInfo_1
pipeRockingControllerInfo_1 HasDynamicValue pipeRockingControllerInfo
BottomOfStringReferenceLocation:bottomOfStringLocation
WeightTransferObjective:weightTransferObjective
weightTransferObjective IsPhysicallyLocatedAt bottomOfStringLocation
pipeRockingControllerInfo_1 IsRelatedToDrillingObjective weightTransferObjective
ServiceCompany:serviceCompany
pipeRockingControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
pipeRockingControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:pipeRocking
pipeRocking ImplementsObjective weightTransferObjective
pipeRockingControllerInfo_1 IsRecommendedFor pipeRocking
DWISAdviceComposer:adviceComposer
pipeRockingControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
pipeRockingControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[pipeRockingControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[pipeRockingControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[pipeRockingControllerInfo_1] -->|HasDynamicValue| N0000[pipeRockingControllerInfo] 
	N0004[bottomOfStringLocation] -->|BelongsToClass| N0005(BottomOfStringReferenceLocation) 
	N0006[weightTransferObjective] -->|BelongsToClass| N0007(WeightTransferObjective) 
	N0006[weightTransferObjective] -->|IsPhysicallyLocatedAt| N0004[bottomOfStringLocation] 
	N0002[pipeRockingControllerInfo_1] -->|IsRelatedToDrillingObjective| N0006[weightTransferObjective] 
	N0008[serviceCompany] -->|BelongsToClass| N0009(ServiceCompany) 
	N0002[pipeRockingControllerInfo_1] -->|IsProvidedBy| N0008[serviceCompany] 
	N0010[computationUnit] -->|BelongsToClass| N0011(Advisor) 
	N0002[pipeRockingControllerInfo_1] -->|IsRecommendedBy| N0010[computationUnit] 
	N0012[pipeRocking] -->|BelongsToClass| N0013(ControllerFunction) 
	N0012[pipeRocking] -->|ImplementsObjective| N0006[weightTransferObjective] 
	N0002[pipeRockingControllerInfo_1] -->|IsRecommendedFor| N0012[pipeRocking] 
	N0014[adviceComposer] -->|BelongsToClass| N0015(DWISAdviceComposer) 
	N0002[pipeRockingControllerInfo_1] -->|IsProvidedTo| N0014[adviceComposer] 
	N0016[scheduler] -->|BelongsToClass| N0017(DWISScheduler) 
	N0002[pipeRockingControllerInfo_1] -->|IsProvidedTo| N0016[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?pipeRockingControllerInfo
WHERE {
	?pipeRockingControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?pipeRockingControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?pipeRockingControllerInfo_1 ddhub:HasDynamicValue ?pipeRockingControllerInfo .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?weightTransferObjective rdf:type ddhub:WeightTransferObjective .
	?weightTransferObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?pipeRockingControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?weightTransferObjective .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?pipeRockingControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?pipeRockingControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?pipeRocking rdf:type ddhub:ControllerFunction .
	?pipeRocking ddhub:ImplementsObjective ?weightTransferObjective .
	?pipeRockingControllerInfo_1 ddhub:IsRecommendedFor ?pipeRocking .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?pipeRockingControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?pipeRockingControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsRelatedToDrillingObjective
DWISVerb <|-- ImplementsObjective
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
DrillingDataPoint ||--o{ DrillingObjective : IsRelatedToDrillingObjective
ControllerFunction ||--o{ DrillingObjective : ImplementsObjective
```
## IsRelatedToDrillingObjective <!-- VERB -->
- Display name: Is Related To Drilling Objective
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Definition set: DrillingObjective
- Description: 
This Verb is used to indicate that a drilling data point is related to a drilling objective.
- Examples:
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal:ROPManagementControllerInfo
DrillingControlAdvice:ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit:ROPLimit_1
ROPManagementControllerInfo_1 HasControlLimit ROPLimit_1
WOBLimit:WOBLimit_1
ROPManagementControllerInfo_1 HasControlLimit WOBLimit_1
DifferentialPressureLimit:differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
BottomOfStringReferenceLocation:bottomOfStringLocation
StableAxialVelocityObjective:stableAxialVelocityObjective
stableAxialVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective:stableWOBObjective
stableWOBObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective:stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany:serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer:adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ROPManagementControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[ROPManagementControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[ROPManagementControllerInfo_1] -->|HasDynamicValue| N0000[ROPManagementControllerInfo] 
	N0004[ROPLimit_1] -->|BelongsToClass| N0005(ROPLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0004[ROPLimit_1] 
	N0006[WOBLimit_1] -->|BelongsToClass| N0007(WOBLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0006[WOBLimit_1] 
	N0008[differentialPressureLimit] -->|BelongsToClass| N0009(DifferentialPressureLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0008[differentialPressureLimit] 
	N0010[bottomOfStringLocation] -->|BelongsToClass| N0011(BottomOfStringReferenceLocation) 
	N0012[stableAxialVelocityObjective] -->|BelongsToClass| N0013(StableAxialVelocityObjective) 
	N0012[stableAxialVelocityObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0012[stableAxialVelocityObjective] 
	N0014[stableWOBObjective] -->|BelongsToClass| N0015(StableAxialForceObjective) 
	N0014[stableWOBObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0014[stableWOBObjective] 
	N0016[stableDifferentialPressure] -->|BelongsToClass| N0017(StablePressureObjective) 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0016[stableDifferentialPressure] 
	N0018[serviceCompany] -->|BelongsToClass| N0019(ServiceCompany) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedBy| N0018[serviceCompany] 
	N0020[computationUnit] -->|BelongsToClass| N0021(Advisor) 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedBy| N0020[computationUnit] 
	N0022[autoDriller] -->|BelongsToClass| N0023(ControllerFunction) 
	N0022[autoDriller] -->|ImplementsObjective| N0012[stableAxialVelocityObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0014[stableWOBObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0016[stableDifferentialPressure] 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedFor| N0022[autoDriller] 
	N0024[adviceComposer] -->|BelongsToClass| N0025(DWISAdviceComposer) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0024[adviceComposer] 
	N0026[scheduler] -->|BelongsToClass| N0027(DWISScheduler) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0026[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?ROPManagementControllerInfo
WHERE {
	?ROPManagementControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?ROPManagementControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?ROPManagementControllerInfo_1 ddhub:HasDynamicValue ?ROPManagementControllerInfo .
	?ROPLimit_1 rdf:type ddhub:ROPLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?ROPLimit_1 .
	?WOBLimit_1 rdf:type ddhub:WOBLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?WOBLimit_1 .
	?differentialPressureLimit rdf:type ddhub:DifferentialPressureLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?differentialPressureLimit .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?stableAxialVelocityObjective rdf:type ddhub:StableAxialVelocityObjective .
	?stableAxialVelocityObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableAxialVelocityObjective .
	?stableWOBObjective rdf:type ddhub:StableAxialForceObjective .
	?stableWOBObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableWOBObjective .
	?stableDifferentialPressure rdf:type ddhub:StablePressureObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableDifferentialPressure .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?autoDriller rdf:type ddhub:ControllerFunction .
	?autoDriller ddhub:ImplementsObjective ?stableAxialVelocityObjective .
	?autoDriller ddhub:ImplementsObjective ?stableWOBObjective .
	?autoDriller ddhub:ImplementsObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedFor ?autoDriller .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## ImplementsObjective <!-- VERB -->
- Display name: Implements Objective
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [ControllerFunction](./ADCS.md#ControllerFunction)
- Object class: [DrillingObjective](./DrillingObjective.md#DrillingObjective)
- Definition set: DrillingObjective
- Description: 
This Verb is used to indicate that a control function implements a drilling objective.
- Examples:
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal:ROPManagementControllerInfo
DrillingControlAdvice:ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit:ROPLimit_1
ROPManagementControllerInfo_1 HasControlLimit ROPLimit_1
WOBLimit:WOBLimit_1
ROPManagementControllerInfo_1 HasControlLimit WOBLimit_1
DifferentialPressureLimit:differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
BottomOfStringReferenceLocation:bottomOfStringLocation
StableAxialVelocityObjective:stableAxialVelocityObjective
stableAxialVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective:stableWOBObjective
stableWOBObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective:stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany:serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer:adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ROPManagementControllerInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[ROPManagementControllerInfo_1] -->|BelongsToClass| N0003(DrillingControlAdvice) 
	N0002[ROPManagementControllerInfo_1] -->|HasDynamicValue| N0000[ROPManagementControllerInfo] 
	N0004[ROPLimit_1] -->|BelongsToClass| N0005(ROPLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0004[ROPLimit_1] 
	N0006[WOBLimit_1] -->|BelongsToClass| N0007(WOBLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0006[WOBLimit_1] 
	N0008[differentialPressureLimit] -->|BelongsToClass| N0009(DifferentialPressureLimit) 
	N0002[ROPManagementControllerInfo_1] -->|HasControlLimit| N0008[differentialPressureLimit] 
	N0010[bottomOfStringLocation] -->|BelongsToClass| N0011(BottomOfStringReferenceLocation) 
	N0012[stableAxialVelocityObjective] -->|BelongsToClass| N0013(StableAxialVelocityObjective) 
	N0012[stableAxialVelocityObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0012[stableAxialVelocityObjective] 
	N0014[stableWOBObjective] -->|BelongsToClass| N0015(StableAxialForceObjective) 
	N0014[stableWOBObjective] -->|IsPhysicallyLocatedAt| N0010[bottomOfStringLocation] 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0014[stableWOBObjective] 
	N0016[stableDifferentialPressure] -->|BelongsToClass| N0017(StablePressureObjective) 
	N0002[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0016[stableDifferentialPressure] 
	N0018[serviceCompany] -->|BelongsToClass| N0019(ServiceCompany) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedBy| N0018[serviceCompany] 
	N0020[computationUnit] -->|BelongsToClass| N0021(Advisor) 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedBy| N0020[computationUnit] 
	N0022[autoDriller] -->|BelongsToClass| N0023(ControllerFunction) 
	N0022[autoDriller] -->|ImplementsObjective| N0012[stableAxialVelocityObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0014[stableWOBObjective] 
	N0022[autoDriller] -->|ImplementsObjective| N0016[stableDifferentialPressure] 
	N0002[ROPManagementControllerInfo_1] -->|IsRecommendedFor| N0022[autoDriller] 
	N0024[adviceComposer] -->|BelongsToClass| N0025(DWISAdviceComposer) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0024[adviceComposer] 
	N0026[scheduler] -->|BelongsToClass| N0027(DWISScheduler) 
	N0002[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0026[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?ROPManagementControllerInfo
WHERE {
	?ROPManagementControllerInfo rdf:type ddhub:DynamicDrillingSignal .
	?ROPManagementControllerInfo_1 rdf:type ddhub:DrillingControlAdvice .
	?ROPManagementControllerInfo_1 ddhub:HasDynamicValue ?ROPManagementControllerInfo .
	?ROPLimit_1 rdf:type ddhub:ROPLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?ROPLimit_1 .
	?WOBLimit_1 rdf:type ddhub:WOBLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?WOBLimit_1 .
	?differentialPressureLimit rdf:type ddhub:DifferentialPressureLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?differentialPressureLimit .
	?bottomOfStringLocation rdf:type ddhub:BottomOfStringReferenceLocation .
	?stableAxialVelocityObjective rdf:type ddhub:StableAxialVelocityObjective .
	?stableAxialVelocityObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableAxialVelocityObjective .
	?stableWOBObjective rdf:type ddhub:StableAxialForceObjective .
	?stableWOBObjective ddhub:IsPhysicallyLocatedAt ?bottomOfStringLocation .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableWOBObjective .
	?stableDifferentialPressure rdf:type ddhub:StablePressureObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableDifferentialPressure .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?autoDriller rdf:type ddhub:ControllerFunction .
	?autoDriller ddhub:ImplementsObjective ?stableAxialVelocityObjective .
	?autoDriller ddhub:ImplementsObjective ?stableWOBObjective .
	?autoDriller ddhub:ImplementsObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedFor ?autoDriller .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
