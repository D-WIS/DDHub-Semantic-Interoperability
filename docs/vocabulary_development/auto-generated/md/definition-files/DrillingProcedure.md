# DrillingProcedure<!-- DEFINITION SET HEADER -->
- Description: 
this category refers mostly to the description of drilling procedures.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
DWISNoun <|-- DrillingProcedure
DrillingProcedure <|-- CirculationStartupProcedure
DrillingProcedure <|-- CirculationStopProcedure
DrillingProcedure <|-- RotationStartupProcedure
DrillingProcedure <|-- RotationStopProcedure
DrillingProcedure <|-- HoistProcedure
DrillingProcedure <|-- TagBottomProcedure
DrillingProcedure <|-- ReciprocationProcedure
DrillingProcedure <|-- FrictionTestProcedure
DrillingProcedure <|-- SlowCirculationRateProcedure
DrillingProcedure <|-- PressureIntegrityTestProcedure
DrillingProcedure <|-- FlowCheckProcedure
DrillingProcedure <|-- CementingProcedure
DrillingProcedure <|-- DownlinkingProcedure
DrillingProcedure <|-- ToolfaceOrientationProcedure
```
## DrillingProcedure <!-- NOUN -->
- Display name: Drilling Procedure
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Description: 
This is the parent class for drilling procedures.
- Definition set: DrillingProcedure
## CirculationStartupProcedure <!-- NOUN -->
- Display name: Circulation Startup Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The circulation stop procedure defines how to stop the mud pumps in a way that limit potential bull-heading effects
that could result in undesired downhole pressure conditions with regards to the geo-pressure window.
- Definition set: DrillingProcedure
- Examples:
``` dwis circulationStartupProcedureInfo
DynamicDrillingSignal: circulationStartupProcedureInfo
DrillingStandardProcedureAdvice: circulationStartupProcedureInfo_1
circulationStartupProcedureInfo_1 HasDynamicValue circulationStartupProcedureInfo
CirculationStartupProcedure: circulationStartupProcedure
circulationStartupProcedureInfo_1 IsRelatedToDrillingProcedure circulationStartupProcedure
ServiceCompany: serviceCompany
circulationStartupProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
circulationStartupProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure circulationStartupProcedure
circulationStartupProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
circulationStartupProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
circulationStartupProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[circulationStartupProcedureInfo_1] -->|HasDynamicValue| N0001[circulationStartupProcedureInfo] 
	N0000[circulationStartupProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[circulationStartupProcedure] 
	N0000[circulationStartupProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[circulationStartupProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[circulationStartupProcedure] 
	N0000[circulationStartupProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[circulationStartupProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[circulationStartupProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?circulationStartupProcedureInfo
WHERE {
	?circulationStartupProcedureInfo_1 ddhub:HasDynamicValue ?circulationStartupProcedureInfo .
	?circulationStartupProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?circulationStartupProcedure .
	?circulationStartupProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?circulationStartupProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?circulationStartupProcedure .
	?circulationStartupProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?circulationStartupProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?circulationStartupProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## CirculationStopProcedure <!-- NOUN -->
- Display name: Circulation Stop Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The rotation startup procedure controls the steps to start the rotation of the drill-stem to reach a target rotational
speed while attempting to avoid having too large torsional oscillations.
- Definition set: DrillingProcedure
- Examples:
``` dwis circulationStopProcedureInfo
DynamicDrillingSignal: circulationStopProcedureInfo
DrillingStandardProcedureAdvice: circulationStopProcedureInfo_1
circulationStopProcedureInfo_1 HasDynamicValue circulationStopProcedureInfo
CirculationStopProcedure: circulationStopProcedure
circulationStopProcedureInfo_1 IsRelatedToDrillingProcedure circulationStopProcedure
ServiceCompany: serviceCompany
circulationStopProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
circulationStopProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure circulationStopProcedure
circulationStopProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
circulationStopProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
circulationStopProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[circulationStopProcedureInfo_1] -->|HasDynamicValue| N0001[circulationStopProcedureInfo] 
	N0000[circulationStopProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[circulationStopProcedure] 
	N0000[circulationStopProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[circulationStopProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[circulationStopProcedure] 
	N0000[circulationStopProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[circulationStopProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[circulationStopProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?circulationStopProcedureInfo
WHERE {
	?circulationStopProcedureInfo_1 ddhub:HasDynamicValue ?circulationStopProcedureInfo .
	?circulationStopProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?circulationStopProcedure .
	?circulationStopProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?circulationStopProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?circulationStopProcedure .
	?circulationStopProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?circulationStopProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?circulationStopProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## RotationStartupProcedure <!-- NOUN -->
- Display name: Rotation Startup Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The rotation startup procedure controls the steps to start the rotation of the drill-stem to reach a target rotational
speed while attempting to avoid having too large torsional oscillations.
- Definition set: DrillingProcedure
- Examples:
``` dwis rotationStartupProcedureInfo
DynamicDrillingSignal: rotationStartupProcedureInfo
DrillingStandardProcedureAdvice: rotationStartupProcedureInfo_1
rotationStartupProcedureInfo_1 HasDynamicValue rotationStartupProcedureInfo
RotationStartupProcedure: rotationStartupProcedure
rotationStartupProcedureInfo_1 IsRelatedToDrillingProcedure rotationStartupProcedure
ServiceCompany: serviceCompany
rotationStartupProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
rotationStartupProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure rotationStartupProcedure
rotationStartupProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
rotationStartupProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
rotationStartupProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[rotationStartupProcedureInfo_1] -->|HasDynamicValue| N0001[rotationStartupProcedureInfo] 
	N0000[rotationStartupProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[rotationStartupProcedure] 
	N0000[rotationStartupProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[rotationStartupProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[rotationStartupProcedure] 
	N0000[rotationStartupProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[rotationStartupProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[rotationStartupProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?rotationStartupProcedureInfo
WHERE {
	?rotationStartupProcedureInfo_1 ddhub:HasDynamicValue ?rotationStartupProcedureInfo .
	?rotationStartupProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?rotationStartupProcedure .
	?rotationStartupProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?rotationStartupProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?rotationStartupProcedure .
	?rotationStartupProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?rotationStartupProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?rotationStartupProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## RotationStopProcedure <!-- NOUN -->
- Display name: Rotation Stop Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The rotation stop procedure controls the path for stopping the rotation of the drill-stem and remove as much torque
along the drill-stem as possible.
- Definition set: DrillingProcedure
- Examples:
``` dwis rotationStopProcedureInfo
DynamicDrillingSignal: rotationStopProcedureInfo
DrillingStandardProcedureAdvice: rotationStopProcedureInfo_1
rotationStopProcedureInfo_1 HasDynamicValue rotationStopProcedureInfo
RotationStopProcedure: rotationStopProcedure
rotationStopProcedureInfo_1 IsRelatedToDrillingProcedure rotationStopProcedure
ServiceCompany: serviceCompany
rotationStopProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
rotationStopProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure rotationStopProcedure
rotationStopProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
rotationStopProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
rotationStopProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[rotationStopProcedureInfo_1] -->|HasDynamicValue| N0001[rotationStopProcedureInfo] 
	N0000[rotationStopProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[rotationStopProcedure] 
	N0000[rotationStopProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[rotationStopProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[rotationStopProcedure] 
	N0000[rotationStopProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[rotationStopProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[rotationStopProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?rotationStopProcedureInfo
WHERE {
	?rotationStopProcedureInfo_1 ddhub:HasDynamicValue ?rotationStopProcedureInfo .
	?rotationStopProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?rotationStopProcedure .
	?rotationStopProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?rotationStopProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?rotationStopProcedure .
	?rotationStopProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?rotationStopProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?rotationStopProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## HoistProcedure <!-- NOUN -->
- Display name: Hoist Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The hoist procedure is used to move the top of the drill-stem from one elevation to another elevation while minimizing
the side effects of swab and surge. 
- Definition set: DrillingProcedure
- Examples:
``` dwis hoistProcedureInfo
DynamicDrillingSignal: hoistProcedureInfo
DrillingStandardProcedureAdvice: hoistProcedureInfo_1
hoistProcedureInfo_1 HasDynamicValue hoistProcedureInfo
HoistProcedure: hoistProcedure
hoistProcedureInfo_1 IsRelatedToDrillingProcedure hoistProcedure
ServiceCompany: serviceCompany
hoistProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
hoistProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure hoistProcedure
hoistProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
hoistProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
hoistProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[hoistProcedureInfo_1] -->|HasDynamicValue| N0001[hoistProcedureInfo] 
	N0000[hoistProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[hoistProcedure] 
	N0000[hoistProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[hoistProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[hoistProcedure] 
	N0000[hoistProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[hoistProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[hoistProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?hoistProcedureInfo
WHERE {
	?hoistProcedureInfo_1 ddhub:HasDynamicValue ?hoistProcedureInfo .
	?hoistProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?hoistProcedure .
	?hoistProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?hoistProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?hoistProcedure .
	?hoistProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?hoistProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?hoistProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## TagBottomProcedure <!-- NOUN -->
- Display name: Tag Bottom Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The tag bottom procedure is used to tag the bottom hole and establish the drilling parameters.
- Definition set: DrillingProcedure
- Examples:
``` dwis tagBottomProcedureInfo
DynamicDrillingSignal: tagBottomProcedureInfo
DrillingStandardProcedureAdvice: tagBottomProcedureInfo_1
tagBottomProcedureInfo_1 HasDynamicValue tagBottomProcedureInfo
TagBottomProcedure: tagBottomProcedure
tagBottomProcedureInfo_1 IsRelatedToDrillingProcedure tagBottomProcedure
ServiceCompany: serviceCompany
tagBottomProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
tagBottomProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure tagBottomProcedure"
tagBottomProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
tagBottomProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
tagBottomProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[tagBottomProcedureInfo_1] -->|HasDynamicValue| N0001[tagBottomProcedureInfo] 
	N0000[tagBottomProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[tagBottomProcedure] 
	N0000[tagBottomProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[tagBottomProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0006[tagBottomProcedure"] 
	N0000[tagBottomProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[tagBottomProcedureInfo_1] -->|IsProvidedTo| N0007[adviceComposer] 
	N0000[tagBottomProcedureInfo_1] -->|IsProvidedTo| N0008[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?tagBottomProcedureInfo
WHERE {
	?tagBottomProcedureInfo_1 ddhub:HasDynamicValue ?tagBottomProcedureInfo .
	?tagBottomProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?tagBottomProcedure .
	?tagBottomProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?tagBottomProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?tagBottomProcedure" .
	?tagBottomProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?tagBottomProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?tagBottomProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## ReciprocationProcedure <!-- NOUN -->
- Display name: Reciprocation Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The reciprocation procedure is used to ream up and down with the same stand. The main purpose is often to clean the hole
while avoiding to wash out the formation. 
- Definition set: DrillingProcedure
- Examples:
``` dwis reciprocationProcedureInfo
DynamicDrillingSignal: reciprocationProcedureInfo
DrillingStandardProcedureAdvice: reciprocationProcedureInfo_1
reciprocationProcedureInfo_1 HasDynamicValue reciprocationProcedureInfo
ReciprocationProcedure: reciprocationProcedure
reciprocationProcedureInfo_1 IsRelatedToDrillingProcedure reciprocationProcedure
ServiceCompany: serviceCompany
reciprocationProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
reciprocationProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure reciprocationProcedure
reciprocationProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
reciprocationProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
reciprocationProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[reciprocationProcedureInfo_1] -->|HasDynamicValue| N0001[reciprocationProcedureInfo] 
	N0000[reciprocationProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[reciprocationProcedure] 
	N0000[reciprocationProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[reciprocationProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[reciprocationProcedure] 
	N0000[reciprocationProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[reciprocationProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[reciprocationProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?reciprocationProcedureInfo
WHERE {
	?reciprocationProcedureInfo_1 ddhub:HasDynamicValue ?reciprocationProcedureInfo .
	?reciprocationProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?reciprocationProcedure .
	?reciprocationProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?reciprocationProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?reciprocationProcedure .
	?reciprocationProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?reciprocationProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?reciprocationProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## FrictionTestProcedure <!-- NOUN -->
- Display name: Friction Test Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
A friction test procedure is used to measure the free rotating weight and torque and the pick-up and slack-off weights.
- Definition set: DrillingProcedure
- Examples:
``` dwis frictionTestProcedureInfo
DynamicDrillingSignal: frictionTestProcedureInfo
DrillingStandardProcedureAdvice: frictionTestProcedureInfo_1
frictionTestProcedureInfo_1 HasDynamicValue frictionTestProcedureInfo
FrictionTestProcedure: frictionTestProcedure
frictionTestProcedureInfo_1 IsRelatedToDrillingProcedure frictionTestProcedure
ServiceCompany: serviceCompany
frictionTestProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
frictionTestProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure frictionTestProcedure
frictionTestProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
frictionTestProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
frictionTestProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[frictionTestProcedureInfo_1] -->|HasDynamicValue| N0001[frictionTestProcedureInfo] 
	N0000[frictionTestProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[frictionTestProcedure] 
	N0000[frictionTestProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[frictionTestProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[frictionTestProcedure] 
	N0000[frictionTestProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[frictionTestProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[frictionTestProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?frictionTestProcedureInfo
WHERE {
	?frictionTestProcedureInfo_1 ddhub:HasDynamicValue ?frictionTestProcedureInfo .
	?frictionTestProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?frictionTestProcedure .
	?frictionTestProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?frictionTestProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?frictionTestProcedure .
	?frictionTestProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?frictionTestProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?frictionTestProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## SlowCirculationRateProcedure <!-- NOUN -->
- Display name: Slow Circulation Rate Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The slow circulation rate procedure is used to measure the pressure losses of the drilling system in conditions close
to what would be necessary while circulating out a kick.
- Definition set: DrillingProcedure
- Examples:
``` dwis slowCirculationRateProcedureInfo
DynamicDrillingSignal: slowCirculationRateProcedureInfo
DrillingStandardProcedureAdvice: slowCirculationRateProcedureInfo_1
slowCirculationRateProcedureInfo_1 HasDynamicValue slowCirculationRateProcedureInfo
SlowCirculationRateProcedure: slowCirculationRateProcedure
slowCirculationRateProcedureInfo_1 IsRelatedToDrillingProcedure slowCirculationRateProcedure
ServiceCompany: serviceCompany
slowCirculationRateProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
slowCirculationRateProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure slowCirculationRateProcedure
slowCirculationRateProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
slowCirculationRateProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
slowCirculationRateProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[slowCirculationRateProcedureInfo_1] -->|HasDynamicValue| N0001[slowCirculationRateProcedureInfo] 
	N0000[slowCirculationRateProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[slowCirculationRateProcedure] 
	N0000[slowCirculationRateProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[slowCirculationRateProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[slowCirculationRateProcedure] 
	N0000[slowCirculationRateProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[slowCirculationRateProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[slowCirculationRateProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?slowCirculationRateProcedureInfo
WHERE {
	?slowCirculationRateProcedureInfo_1 ddhub:HasDynamicValue ?slowCirculationRateProcedureInfo .
	?slowCirculationRateProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?slowCirculationRateProcedure .
	?slowCirculationRateProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?slowCirculationRateProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?slowCirculationRateProcedure .
	?slowCirculationRateProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?slowCirculationRateProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?slowCirculationRateProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## PressureIntegrityTestProcedure <!-- NOUN -->
- Display name: Pressure Integrity Test Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The pressure integrity test procedure is used to either check that the formation can hold the maximum expected downhole
pressure (formation integrity test) or to test the strength of the formation and the minimum horizontal stress (leak-off test and 
extended leakoff test). 
- Definition set: DrillingProcedure
- Examples:
``` dwis pressureIntegrityTestProcedureInfo
DynamicDrillingSignal: pressureIntegrityTestProcedureInfo
DrillingStandardProcedureAdvice: pressureIntegrityTestProcedureInfo_1
pressureIntegrityTestProcedureInfo_1 HasDynamicValue pressureIntegrityTestProcedureInfo
PressureIntegrityTestProcedure: pressureIntegrityTestProcedure
pressureIntegrityTestProcedureInfo_1 IsRelatedToDrillingProcedure pressureIntegrityTestProcedure
ServiceCompany: serviceCompany
pressureIntegrityTestProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
pressureIntegrityTestProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure pressureIntegrityTestProcedure
pressureIntegrityTestProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
pressureIntegrityTestProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
pressureIntegrityTestProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[pressureIntegrityTestProcedureInfo_1] -->|HasDynamicValue| N0001[pressureIntegrityTestProcedureInfo] 
	N0000[pressureIntegrityTestProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[pressureIntegrityTestProcedure] 
	N0000[pressureIntegrityTestProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[pressureIntegrityTestProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[pressureIntegrityTestProcedure] 
	N0000[pressureIntegrityTestProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[pressureIntegrityTestProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[pressureIntegrityTestProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?pressureIntegrityTestProcedureInfo
WHERE {
	?pressureIntegrityTestProcedureInfo_1 ddhub:HasDynamicValue ?pressureIntegrityTestProcedureInfo .
	?pressureIntegrityTestProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?pressureIntegrityTestProcedure .
	?pressureIntegrityTestProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?pressureIntegrityTestProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?pressureIntegrityTestProcedure .
	?pressureIntegrityTestProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?pressureIntegrityTestProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?pressureIntegrityTestProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## FlowCheckProcedure <!-- NOUN -->
- Display name: Flow Check Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The flow-check procedure is used to check the well is stable (no influx of formation fluids) while ensuring that the
drill-stem will not get stuck during the test.
- Definition set: DrillingProcedure
- Examples:
``` dwis flowCheckProcedureInfo
DynamicDrillingSignal: flowCheckProcedureInfo
DrillingStandardProcedureAdvice: flowCheckProcedureInfo_1
flowCheckProcedureInfo_1 HasDynamicValue flowCheckProcedureInfo
FlowCheckProcedure: flowCheckProcedure
flowCheckProcedureInfo_1 IsRelatedToDrillingProcedure flowCheckProcedure
ServiceCompany: serviceCompany
flowCheckProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
flowCheckProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure flowCheckProcedure
flowCheckProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
flowCheckProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
flowCheckProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[flowCheckProcedureInfo_1] -->|HasDynamicValue| N0001[flowCheckProcedureInfo] 
	N0000[flowCheckProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[flowCheckProcedure] 
	N0000[flowCheckProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[flowCheckProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[flowCheckProcedure] 
	N0000[flowCheckProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[flowCheckProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[flowCheckProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?flowCheckProcedureInfo
WHERE {
	?flowCheckProcedureInfo_1 ddhub:HasDynamicValue ?flowCheckProcedureInfo .
	?flowCheckProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?flowCheckProcedure .
	?flowCheckProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?flowCheckProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?flowCheckProcedure .
	?flowCheckProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?flowCheckProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?flowCheckProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## CementingProcedure <!-- NOUN -->
- Display name: Cementing Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The cementing procedure is used to displace the correct amount of cement at the right position while cleaning the borehole
to ensure good conditions for the cement setting.
- Definition set: DrillingProcedure
- Examples:
``` dwis cementProcedureInfo
DynamicDrillingSignal: cementProcedureInfo
DrillingStandardProcedureAdvice: cementProcedureInfo_1
cementProcedureInfo_1 HasDynamicValue cementProcedureInfo
CementingProcedure: cementingProcedure
cementProcedureInfo_1 IsRelatedToDrillingProcedure cementingProcedure
ServiceCompany: serviceCompany
cementProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
cementProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure cementingProcedure
cementProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
cementProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
cementProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[cementProcedureInfo_1] -->|HasDynamicValue| N0001[cementProcedureInfo] 
	N0000[cementProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[cementingProcedure] 
	N0000[cementProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[cementProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[cementingProcedure] 
	N0000[cementProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[cementProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[cementProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?cementProcedureInfo
WHERE {
	?cementProcedureInfo_1 ddhub:HasDynamicValue ?cementProcedureInfo .
	?cementProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?cementingProcedure .
	?cementProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?cementProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?cementingProcedure .
	?cementProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?cementProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?cementProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## DownlinkingProcedure <!-- NOUN -->
- Display name: Downlinking Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The downlinking procedure is used to manipulate the flowrate/pressure or rotational speed to send a coded message to
the rotary steerable system.
- Definition set: DrillingProcedure
- Examples:
``` dwis downlinkProcedureInfo
DynamicDrillingSignal: downlinkProcedureInfo
DrillingStandardProcedureAdvice: downlinkProcedureInfo_1
downlinkProcedureInfo_1 HasDynamicValue downlinkProcedureInfo
DownlinkingProcedure: downlinkingProcedure
downlinkProcedureInfo_1 IsRelatedToDrillingProcedure downlinkingProcedure
ServiceCompany: serviceCompany
downlinkProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
downlinkProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure downlinkingProcedure
downlinkProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
downlinkProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
downlinkProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[downlinkProcedureInfo_1] -->|HasDynamicValue| N0001[downlinkProcedureInfo] 
	N0000[downlinkProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[downlinkingProcedure] 
	N0000[downlinkProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[downlinkProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[downlinkingProcedure] 
	N0000[downlinkProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[downlinkProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[downlinkProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?downlinkProcedureInfo
WHERE {
	?downlinkProcedureInfo_1 ddhub:HasDynamicValue ?downlinkProcedureInfo .
	?downlinkProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?downlinkingProcedure .
	?downlinkProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?downlinkProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?downlinkingProcedure .
	?downlinkProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?downlinkProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?downlinkProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## ToolfaceOrientationProcedure <!-- NOUN -->
- Display name: Toolface Orientation Procedure
- Parent class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Description: 
The toolface orientation procedure is used to manipulate the top of string angular position to ensure that the downhole
motor toolface is set to a desired set-point.
- Definition set: DrillingProcedure
- Examples:
``` dwis toolfaceOrientationProcedureInfo
DynamicDrillingSignal: toolfaceOrientationProcedureInfo
DrillingStandardProcedureAdvice: toolfaceOrientationProcedureInfo_1
toolfaceOrientationProcedureInfo_1 HasDynamicValue toolfaceOrientationProcedureInfo
ToolfaceOrientationProcedure: toolfaceOrientationProcedure
toolfaceOrientationProcedureInfo_1 IsRelatedToDrillingProcedure toolfaceOrientationProcedure
ServiceCompany: serviceCompany
toolfaceOrientationProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
toolfaceOrientationProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction ImplementsProcedure toolfaceOrientationProcedure
toolfaceOrientationProcedureInfo_1 IsRecommendedFor procedureFunction
DWISAdviceComposer: adviceComposer
toolfaceOrientationProcedureInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
toolfaceOrientationProcedureInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[toolfaceOrientationProcedureInfo_1] -->|HasDynamicValue| N0001[toolfaceOrientationProcedureInfo] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsRelatedToDrillingProcedure| N0002[toolfaceOrientationProcedure] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[toolfaceOrientationProcedure] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?toolfaceOrientationProcedureInfo
WHERE {
	?toolfaceOrientationProcedureInfo_1 ddhub:HasDynamicValue ?toolfaceOrientationProcedureInfo .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsRelatedToDrillingProcedure ?toolfaceOrientationProcedure .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:ImplementsProcedure ?toolfaceOrientationProcedure .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsRelatedToDrillingProcedure
DWISVerb <|-- ImplementsProcedure
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
DrillingDataPoint ||--o{ DrillingProcedure : IsRelatedToDrillingProcedure
ProcedureFunction ||--o{ DrillingProcedure : ImplementsProcedure
```
## IsRelatedToDrillingProcedure <!-- VERB -->
- Display name: Is Related to Drilling Procedure
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Definition set: DrillingProcedure
- Description: 
This Verb is used to indicate that a drilling data point is related to a drilling procedure.
## ImplementsProcedure <!-- VERB -->
- Display name: Implements Procedure
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [ProcedureFunction](./ADCS.md#ProcedureFunction)
- Object class: [DrillingProcedure](./DrillingProcedure.md#DrillingProcedure)
- Definition set: DrillingProcedure
- Description: 
This Verb is used to indicate that a Procedure Function implements a drilling procedure.
