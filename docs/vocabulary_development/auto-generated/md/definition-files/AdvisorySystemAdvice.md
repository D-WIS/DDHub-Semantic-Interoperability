# AdvisorySystemAdvice<!-- DEFINITION SET HEADER -->
- Description: 
this is the part associated to advices provided by advisory systems.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
JSonDataType <|-- AdvisorySystemAdvice
AdvisorySystemAdvice <|-- DigitalTwinAdvice
AdvisorySystemAdvice <|-- DrillingStandardProcedureAdvice
AdvisorySystemAdvice <|-- DrillingControlAdvice
AdvisorySystemAdvice <|-- DrillingSafeOperatingEnvelopeAdvice
AdvisorySystemAdvice <|-- DrillingFaultDetectionIsolationAndRecoveryAdvice
```
## AdvisorySystemAdvice <!-- NOUN -->
- Display name: Advisory System Advice
- Parent class: [JSonDataType](./DrillingDataSemantics.md#JSonDataType)
- Description: 
An advisory system provides one or several advices. These advices are structured data that are stored as a JSon
string. 
- Definition set: AdvisorySystemAdvice
- Examples:
``` dwis adviceInfo
DynamicDrillingSignal: adviceInfo
AdvisorySystemAdvice: adviceInfo_1
adviceInfo_1 HasDynamicValue adviceInfo
ServiceCompany: serviceCompany
adviceInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
adviceInfo_1 IsRecommendedBy computationUnit
ActivableFunction: activableFunction
adviceInfo_1 IsRecommendedFor activableFunction
DWISAdviceComposer: adviceComposer
adviceInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
adviceInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[adviceInfo_1] -->|HasDynamicValue| N0001[adviceInfo] 
	N0000[adviceInfo_1] -->|IsProvidedBy| N0002[serviceCompany] 
	N0000[adviceInfo_1] -->|IsRecommendedBy| N0003[computationUnit] 
	N0000[adviceInfo_1] -->|IsRecommendedFor| N0004[activableFunction] 
	N0000[adviceInfo_1] -->|IsProvidedTo| N0005[adviceComposer] 
	N0000[adviceInfo_1] -->|IsProvidedTo| N0006[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?adviceInfo
WHERE {
	?adviceInfo_1 ddhub:HasDynamicValue ?adviceInfo .
	?adviceInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?adviceInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?adviceInfo_1 ddhub:IsRecommendedFor ?activableFunction .
	?adviceInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?adviceInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## DigitalTwinAdvice <!-- NOUN -->
- Display name: Digital Twin Advice
- Parent class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Description: 
A digital twin simulates the drilling operation using the boundary conditions applied to the drilling system.
It provides information about the plausible values that can be expected anywhere along the drilling system. These results
are stored in a DigitalTwinAdvice.
- Definition set: AdvisorySystemAdvice
- Examples:
``` dwis digitalTwinAdvice
DynamicDrillingSignal: digitalTwinAdvice
DigitalTwinAdvice: digitalTwinAdvice_1
digitalTwinAdvice_1 HasDynamicValue digitalTwinAdvice
OperatingCompany: operatingCompany
digitalTwinAdvice_1 IsProvidedBy operatingCompany
Simulator: simulator
digitalTwinAdvice_1 IsRecommendedBy simulator
DWISDrillingProcessStateInterpreter: microStateInterpreter
digitalTwinAdvice_1 IsProvidedTo microStateInterpreter
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[digitalTwinAdvice_1] -->|HasDynamicValue| N0001[digitalTwinAdvice] 
	N0000[digitalTwinAdvice_1] -->|IsProvidedBy| N0002[operatingCompany] 
	N0000[digitalTwinAdvice_1] -->|IsRecommendedBy| N0003[simulator] 
	N0000[digitalTwinAdvice_1] -->|IsProvidedTo| N0004[microStateInterpreter] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?digitalTwinAdvice
WHERE {
	?digitalTwinAdvice_1 ddhub:HasDynamicValue ?digitalTwinAdvice .
	?digitalTwinAdvice_1 ddhub:IsProvidedBy ?operatingCompany .
	?digitalTwinAdvice_1 ddhub:IsRecommendedBy ?simulator .
	?digitalTwinAdvice_1 ddhub:IsProvidedTo ?microStateInterpreter .
}
```
## DrillingStandardProcedureAdvice <!-- NOUN -->
- Display name: Drilling Standard Procedure Advice
- Parent class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Description: 
A drilling standard procedure advisor provides parameters for a standard procedure like starting the mud pumps or
running a friction test.
- Definition set: AdvisorySystemAdvice
- Examples:
The circulation startup procedure defines how to start the mud pumps in order to fill the pipes, break circulation and 
establish a suitable flowrate in the drill-stem.
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
The circulation stop procedure defines how to stop the mud pumps in a way that limit potential bull-heading effects 
that could result in undesired downhole pressure conditions with regards to the geo-pressure window.
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
The rotation startup procedure controls the steps to start the rotation of the drill-stem to reach a target rotational
speed while attempting to avoid having too large torsional oscillations.
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
The rotation stop procedure controls the path for stopping the rotation of the drill-stem and remove as much torque 
along the drill-stem as possible.
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
The hoist procedure is used to move the top of the drill-stem from one elevation to another elevation while minimizing
the side effects of swab and surge.
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
The tag bottom procedure is used to tag the bottom hole and establish the drilling parameters.
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
procedureFunction ImplementsProcedure tagBottomProcedure
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
	N0005[procedureFunction] -->|ImplementsProcedure| N0002[tagBottomProcedure] 
	N0000[tagBottomProcedureInfo_1] -->|IsRecommendedFor| N0005[procedureFunction] 
	N0000[tagBottomProcedureInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[tagBottomProcedureInfo_1] -->|IsProvidedTo| N0007[scheduler] 
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
	?procedureFunction ddhub:ImplementsProcedure ?tagBottomProcedure .
	?tagBottomProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?tagBottomProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?tagBottomProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
The reciprocation procedure is used to ream up and down with the same stand. The main purpose is often to clean the hole
while avoiding to wash out the formation.
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
A friction test procedure is used to measure the free rotating weight and torque and the pick-up and slack-off weights.
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
The slow circulation rate procedure is used to measure the pressure losses of the drilling system in conditions close
to what would be necessary while circulating out a kick.
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
The pressure integrity test procedure is used to either check that the formation can hold the maximum expected downhole
pressure (formation integrity test) or to test the strength of the formation and the minimum horizontal stress (leak-off test and 
extended leakoff test).
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
The flow-check procedure is used to check the well is stable (no influx of formation fluids) while ensuring that the
drill-stem will not get stuck during the test.
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
The cementing procedure is used to displace the correct amount of cement at the right position while cleaning the borehole
to ensure good conditions for the cement setting.
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
The downlinking procedure is used to manipulate the flowrate/pressure or rotational speed to send a coded message to 
the rotary steerable system.
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
The toolface orientation procedure is used to manipulate the top of string angular position to ensure that the downhole
motor toolface is set to a desired set-point.
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
## DrillingControlAdvice <!-- NOUN -->
- Display name: Drilling Control Advice
- Parent class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Description: 
A drilling control advisor provides information on how to control a part of the drilling process to stay as close
as possible to one or several desired values.
- Definition set: AdvisorySystemAdvice
- Examples:
A ROP management controller adjusts the parameters of the auto-driller to manage the ROP. The ROP management may concern
potential problems with drill-string buckling, passing the bit founder point, vibration and cuttings transport.
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal: ROPManagementControllerInfo
DrillingControlAdvice: ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit: ROPLimit
ROPManagementControllerInfo_1 HasControlLimit ROPLimit
WOBLimit: WOBLimit
ROPManagementControllerInfo_1 HasControlLimit WOBLimit
DifferentialPressureLimit: differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
StableAxialVelocityObjective: stableAxialVelocityObjective
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective: stableWOBObjective
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective: stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany: serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction: autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer: adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ROPManagementControllerInfo_1] -->|HasDynamicValue| N0001[ROPManagementControllerInfo] 
	N0000[ROPManagementControllerInfo_1] -->|HasControlLimit| N0002[ROPLimit] 
	N0000[ROPManagementControllerInfo_1] -->|HasControlLimit| N0003[WOBLimit] 
	N0000[ROPManagementControllerInfo_1] -->|HasControlLimit| N0004[differentialPressureLimit] 
	N0000[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0005[stableAxialVelocityObjective] 
	N0000[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0006[stableWOBObjective] 
	N0000[ROPManagementControllerInfo_1] -->|IsRelatedToDrillingObjective| N0007[stableDifferentialPressure] 
	N0000[ROPManagementControllerInfo_1] -->|IsProvidedBy| N0008[serviceCompany] 
	N0000[ROPManagementControllerInfo_1] -->|IsRecommendedBy| N0009[computationUnit] 
	N0010[autoDriller] -->|ImplementsObjective| N0005[stableAxialVelocityObjective] 
	N0010[autoDriller] -->|ImplementsObjective| N0006[stableWOBObjective] 
	N0010[autoDriller] -->|ImplementsObjective| N0007[stableDifferentialPressure] 
	N0000[ROPManagementControllerInfo_1] -->|IsRecommendedFor| N0010[autoDriller] 
	N0000[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0011[adviceComposer] 
	N0000[ROPManagementControllerInfo_1] -->|IsProvidedTo| N0012[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?ROPManagementControllerInfo
WHERE {
	?ROPManagementControllerInfo_1 ddhub:HasDynamicValue ?ROPManagementControllerInfo .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?ROPLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?WOBLimit .
	?ROPManagementControllerInfo_1 ddhub:HasControlLimit ?differentialPressureLimit .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableAxialVelocityObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableWOBObjective .
	?ROPManagementControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?autoDriller ddhub:ImplementsObjective ?stableAxialVelocityObjective .
	?autoDriller ddhub:ImplementsObjective ?stableWOBObjective .
	?autoDriller ddhub:ImplementsObjective ?stableDifferentialPressure .
	?ROPManagementControllerInfo_1 ddhub:IsRecommendedFor ?autoDriller .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?ROPManagementControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
When using a downhole motor for directional drilling, pipe rocking is used to assist with weight transmission during
slide periods.
``` dwis pipeRockingControllerInfo
DynamicDrillingSignal: pipeRockingControllerInfo
DrillingControlAdvice: pipeRockingControllerInfo_1
pipeRockingControllerInfo_1 HasDynamicValue pipeRockingControllerInfo
WeightTransferObjective: weightTransferObjective
pipeRockingControllerInfo_1 IsRelatedToDrillingObjective weightTransferObjective
ServiceCompany: serviceCompany
pipeRockingControllerInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
pipeRockingControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction: pipeRocking
pipeRocking ImplementsObjective weightTransferObjective
pipeRockingControllerInfo_1 IsRecommendedFor pipeRocking
DWISAdviceComposer: adviceComposer
pipeRockingControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
pipeRockingControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[pipeRockingControllerInfo_1] -->|HasDynamicValue| N0001[pipeRockingControllerInfo] 
	N0000[pipeRockingControllerInfo_1] -->|IsRelatedToDrillingObjective| N0002[weightTransferObjective] 
	N0000[pipeRockingControllerInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[pipeRockingControllerInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[pipeRocking] -->|ImplementsObjective| N0002[weightTransferObjective] 
	N0000[pipeRockingControllerInfo_1] -->|IsRecommendedFor| N0005[pipeRocking] 
	N0000[pipeRockingControllerInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[pipeRockingControllerInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?pipeRockingControllerInfo
WHERE {
	?pipeRockingControllerInfo_1 ddhub:HasDynamicValue ?pipeRockingControllerInfo .
	?pipeRockingControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?weightTransferObjective .
	?pipeRockingControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?pipeRockingControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?pipeRocking ddhub:ImplementsObjective ?weightTransferObjective .
	?pipeRockingControllerInfo_1 ddhub:IsRecommendedFor ?pipeRocking .
	?pipeRockingControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?pipeRockingControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
A stick-slip mitigation controller attempts at damping stick-slip oscillations by controlling the drill-string rotation 
system.
``` dwis stickSlipMitigationControllerInfo
DynamicDrillingSignal: stickSlipMitigationControllerInfo
DrillingControlAdvice: stickSlipMitigationControllerInfo_1
stickSlipMitigationControllerInfo_1 HasDynamicValue stickSlipMitigationControllerInfo
StableRotationalVelocityObjective: stableRotationalVelocityObjective
stickSlipMitigationControllerInfo_1 IsRelatedToDrillingObjective stableRotationalVelocityObjective
ServiceCompany: serviceCompany
stickSlipMitigationControllerInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
stickSlipMitigationControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction: stickSlipMitigation
stickSlipMitigation ImplementsObjective stableRotationalVelocityObjective
stickSlipMitigationControllerInfo_1 IsRecommendedFor stickSlipMitigation
DWISAdviceComposer: adviceComposer
stickSlipMitigationControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
stickSlipMitigationControllerInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[stickSlipMitigationControllerInfo_1] -->|HasDynamicValue| N0001[stickSlipMitigationControllerInfo] 
	N0000[stickSlipMitigationControllerInfo_1] -->|IsRelatedToDrillingObjective| N0002[stableRotationalVelocityObjective] 
	N0000[stickSlipMitigationControllerInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[stickSlipMitigationControllerInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[stickSlipMitigation] -->|ImplementsObjective| N0002[stableRotationalVelocityObjective] 
	N0000[stickSlipMitigationControllerInfo_1] -->|IsRecommendedFor| N0005[stickSlipMitigation] 
	N0000[stickSlipMitigationControllerInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[stickSlipMitigationControllerInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?stickSlipMitigationControllerInfo
WHERE {
	?stickSlipMitigationControllerInfo_1 ddhub:HasDynamicValue ?stickSlipMitigationControllerInfo .
	?stickSlipMitigationControllerInfo_1 ddhub:IsRelatedToDrillingObjective ?stableRotationalVelocityObjective .
	?stickSlipMitigationControllerInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?stickSlipMitigationControllerInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?stickSlipMitigation ddhub:ImplementsObjective ?stableRotationalVelocityObjective .
	?stickSlipMitigationControllerInfo_1 ddhub:IsRecommendedFor ?stickSlipMitigation .
	?stickSlipMitigationControllerInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?stickSlipMitigationControllerInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## DrillingSafeOperatingEnvelopeAdvice <!-- NOUN -->
- Display name: Drilling Safe Operating Envelope Advice
- Parent class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Description: 
A safe operating envelope (SOE) advisor provides information on the limits that shall be used when controlling the drilling
process to avoid possible drilling incidents.
- Definition set: AdvisorySystemAdvice
- Examples:
The min-max axial velocity SOE is used to limit the axial drill-strem velocity to avoid generating swab and surge 
pressures that exceeds the geo-pressure window.
``` dwis minMaxAxialVelocitySOEInfo
DynamicDrillingSignal: minMaxAxialVelocitySOEInfo
DrillingSafeOperatingEnvelopeAdvice: minMaxAxialVelocitySOEInfo_1
minMaxAxialVelocitySOEInfo_1 HasDynamicValue minMaxAxialVelocitySOEInfo
AxialVelocityLimit: axialVelocityLimit
minMaxAxialVelocitySOEInfo_1 IsRelatedToDrillingLimit axialVelocityLimit
ServiceCompany: serviceCompany
minMaxAxialVelocitySOEInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
minMaxAxialVelocitySOEInfo_1 IsRecommendedBy computationUnit
SOEFunction: soeFunction
soeFunction ImplementsLimit axialVelocityLimit
minMaxAxialVelocitySOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer: adviceComposer
minMaxAxialVelocitySOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
minMaxAxialVelocitySOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxAxialVelocitySOEInfo_1] -->|HasDynamicValue| N0001[minMaxAxialVelocitySOEInfo] 
	N0000[minMaxAxialVelocitySOEInfo_1] -->|IsRelatedToDrillingLimit| N0002[axialVelocityLimit] 
	N0000[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[minMaxAxialVelocitySOEInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[soeFunction] -->|ImplementsLimit| N0002[axialVelocityLimit] 
	N0000[minMaxAxialVelocitySOEInfo_1] -->|IsRecommendedFor| N0005[soeFunction] 
	N0000[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxAxialVelocitySOEInfo
WHERE {
	?minMaxAxialVelocitySOEInfo_1 ddhub:HasDynamicValue ?minMaxAxialVelocitySOEInfo .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRelatedToDrillingLimit ?axialVelocityLimit .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction ddhub:ImplementsLimit ?axialVelocityLimit .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
The min-max flowrate SOE is used to limit the flowrate in order to stay below the fracturing pressure limit of the open
hole formation and have a sufficient flowrate to transport cuttings to the surface.
``` dwis minMaxFlowRateSOEInfo
DynamicDrillingSignal: minMaxFlowRateSOEInfo
DrillingSafeOperatingEnvelopeAdvice: minMaxFlowRateSOEInfo_1
minMaxFlowRateSOEInfo_1 HasDynamicValue minMaxFlowRateSOEInfo
FlowrateLimit: flowrateLimit
minMaxFlowRateSOEInfo_1 IsRelatedToDrillingLimit flowrateLimit
ServiceCompany: serviceCompany
minMaxFlowRateSOEInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
minMaxFlowRateSOEInfo_1 IsRecommendedBy computationUnit
SOEFunction: soeFunction
soeFunction ImplementsLimit flowrateLimit
minMaxFlowRateSOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer: adviceComposer
minMaxFlowRateSOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
minMaxFlowRateSOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxFlowRateSOEInfo_1] -->|HasDynamicValue| N0001[minMaxFlowRateSOEInfo] 
	N0000[minMaxFlowRateSOEInfo_1] -->|IsRelatedToDrillingLimit| N0002[flowrateLimit] 
	N0000[minMaxFlowRateSOEInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[minMaxFlowRateSOEInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[soeFunction] -->|ImplementsLimit| N0002[flowrateLimit] 
	N0000[minMaxFlowRateSOEInfo_1] -->|IsRecommendedFor| N0005[soeFunction] 
	N0000[minMaxFlowRateSOEInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[minMaxFlowRateSOEInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxFlowRateSOEInfo
WHERE {
	?minMaxFlowRateSOEInfo_1 ddhub:HasDynamicValue ?minMaxFlowRateSOEInfo .
	?minMaxFlowRateSOEInfo_1 ddhub:IsRelatedToDrillingLimit ?flowrateLimit .
	?minMaxFlowRateSOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?minMaxFlowRateSOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction ddhub:ImplementsLimit ?flowrateLimit .
	?minMaxFlowRateSOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?minMaxFlowRateSOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?minMaxFlowRateSOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
The min-max rotational speed SOE limits the drill-stem rotational speed to avoid unwanted drill-stem vibrations while at
the same time be sufficient to facilitate cuttings transport.
``` dwis minMaxRotationalSpeedSOEInfo
DynamicDrillingSignal: minMaxRotationalSpeedSOEInfo
DrillingSafeOperatingEnvelopeAdvice: minMaxRotationalSpeedSOEInfo_1
minMaxRotationalSpeedSOEInfo_1 HasDynamicValue minMaxRotationalSpeedSOEInfo
RotationalVelocityLimit: rotationalVelocityLimit
minMaxRotationalSpeedSOEInfo_1 IsRelatedToDrillingLimit rotationalVelocityLimit
ServiceCompany: serviceCompany
minMaxRotationalSpeedSOEInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
minMaxRotationalSpeedSOEInfo_1 IsRecommendedBy computationUnit
SOEFunction: soeFunction
soeFunction ImplementsLimit rotationalVelocityLimit
minMaxRotationalSpeedSOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer: adviceComposer
minMaxRotationalSpeedSOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler: scheduler
minMaxRotationalSpeedSOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|HasDynamicValue| N0001[minMaxRotationalSpeedSOEInfo] 
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|IsRelatedToDrillingLimit| N0002[rotationalVelocityLimit] 
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[soeFunction] -->|ImplementsLimit| N0002[rotationalVelocityLimit] 
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|IsRecommendedFor| N0005[soeFunction] 
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
	N0000[minMaxRotationalSpeedSOEInfo_1] -->|IsProvidedTo| N0007[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxRotationalSpeedSOEInfo
WHERE {
	?minMaxRotationalSpeedSOEInfo_1 ddhub:HasDynamicValue ?minMaxRotationalSpeedSOEInfo .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsRelatedToDrillingLimit ?rotationalVelocityLimit .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction ddhub:ImplementsLimit ?rotationalVelocityLimit .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## DrillingFaultDetectionIsolationAndRecoveryAdvice <!-- NOUN -->
- Display name: Drilling Fault Detection Isolation and Recovery Advice
- Parent class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Description: 
A fault detection, isolation and recovery (FDIR) advisor provides information on how to detect an drilling incident
and parameters to procedure that is executed when a drilling incident is detected in order to first to isolate the drilling incident
and then possibly recover from that incident.
- Definition set: AdvisorySystemAdvice
- Examples:
A pack-off FDIR function detects an abornormal dowhole pressure and executes a procedure to avoid fracturing the
open hole formation and possibly continues with a procedure to remediate the cause of the pack-off and return to normal conditions.
``` dwis PackOffFDIRInfo
DynamicDrillingSignal: PackOffFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: PackOffFDIRInfo_1
PackOffFDIRInfo_1 HasDynamicValue PackOffFDIRInfo
PackOff: packOffIncident
PackOffFDIRInfo_1 IsRelatedToDrillingIncident packOffIncident
ServiceCompany: serviceCompany
PackOffFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
PackOffFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident packOffIncident
PackOffFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
PackOffFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[PackOffFDIRInfo_1] -->|HasDynamicValue| N0001[PackOffFDIRInfo] 
	N0000[PackOffFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[packOffIncident] 
	N0000[PackOffFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[PackOffFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[packOffIncident] 
	N0000[PackOffFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[PackOffFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?PackOffFDIRInfo
WHERE {
	?PackOffFDIRInfo_1 ddhub:HasDynamicValue ?PackOffFDIRInfo .
	?PackOffFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?packOffIncident .
	?PackOffFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?PackOffFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?packOffIncident .
	?PackOffFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?PackOffFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
An overpull/underpull function detects an abnormal hook-load either while moving upward (overpull) or downward (underpull).
It reacts to the situation by stopping the axial movement and possibly starts other actions to remediate for the cause of the abnormal
hook-load with the objective to return to normal conditions.
``` dwis overpullUnderpullFDIRInfo
DynamicDrillingSignal: overpullUnderpullFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: overpullUnderpullFDIRInfo_1
overpullUnderpullFDIRInfo_1 HasDynamicValue overpullUnderpullFDIRInfo
Overpull: overpullIncident
overpullUnderpullFDIRInfo_1 IsRelatedToDrillingIncident overpullIncident
Underpull: underpullIncident
overpullUnderpullFDIRInfo_1 IsRelatedToDrillingIncident underpullIncident
ServiceCompany: serviceCompany
overpullUnderpullFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
overpullUnderpullFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident overpullIncident
FDIRFunction_1 ManagesIncident underpullIncident
overpullUnderpullFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
overpullUnderpullFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[overpullUnderpullFDIRInfo_1] -->|HasDynamicValue| N0001[overpullUnderpullFDIRInfo] 
	N0000[overpullUnderpullFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[overpullIncident] 
	N0000[overpullUnderpullFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0003[underpullIncident] 
	N0000[overpullUnderpullFDIRInfo_1] -->|IsProvidedBy| N0004[serviceCompany] 
	N0000[overpullUnderpullFDIRInfo_1] -->|IsRecommendedBy| N0005[computationUnit] 
	N0006[FDIRFunction_1] -->|ManagesIncident| N0002[overpullIncident] 
	N0006[FDIRFunction_1] -->|ManagesIncident| N0003[underpullIncident] 
	N0000[overpullUnderpullFDIRInfo_1] -->|IsRecommendedFor| N0006[FDIRFunction_1] 
	N0000[overpullUnderpullFDIRInfo_1] -->|IsProvidedTo| N0007[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?overpullUnderpullFDIRInfo
WHERE {
	?overpullUnderpullFDIRInfo_1 ddhub:HasDynamicValue ?overpullUnderpullFDIRInfo .
	?overpullUnderpullFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?overpullIncident .
	?overpullUnderpullFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?underpullIncident .
	?overpullUnderpullFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?overpullUnderpullFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?overpullIncident .
	?FDIRFunction_1 ddhub:ManagesIncident ?underpullIncident .
	?overpullUnderpullFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?overpullUnderpullFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
This is the same as for an OverpullUnderpullFDIRAdvice but only deals with overpulls.
``` dwis overpullFDIRInfo
DynamicDrillingSignal: overpullFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: overpullFDIRInfo_1
overpullFDIRInfo_1 HasDynamicValue overpullFDIRInfo
Overpull: overpullIncident
overpullFDIRInfo_1 IsRelatedToDrillingIncident overpullIncident
ServiceCompany: serviceCompany
overpullFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
overpullFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident overpullIncident
overpullFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
overpullFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[overpullFDIRInfo_1] -->|HasDynamicValue| N0001[overpullFDIRInfo] 
	N0000[overpullFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[overpullIncident] 
	N0000[overpullFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[overpullFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[overpullIncident] 
	N0000[overpullFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[overpullFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?overpullFDIRInfo
WHERE {
	?overpullFDIRInfo_1 ddhub:HasDynamicValue ?overpullFDIRInfo .
	?overpullFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?overpullIncident .
	?overpullFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?overpullFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?overpullIncident .
	?overpullFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?overpullFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
This is the same as for an OverpullUnderpullFDIRAdvice but only deals with underpulls.
``` dwis underpullFDIRInfo
DynamicDrillingSignal: underpullFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: underpullFDIRInfo_1
underpullFDIRInfo_1 HasDynamicValue underpullFDIRInfo
Underpull: underpullIncident
underpullFDIRInfo_1 IsRelatedToDrillingIncident underpullIncident
ServiceCompany: serviceCompany
underpullFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
underpullFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident underpullIncident
underpullFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
underpullFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[underpullFDIRInfo_1] -->|HasDynamicValue| N0001[underpullFDIRInfo] 
	N0000[underpullFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[underpullIncident] 
	N0000[underpullFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[underpullFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[underpullIncident] 
	N0000[underpullFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[underpullFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?underpullFDIRInfo
WHERE {
	?underpullFDIRInfo_1 ddhub:HasDynamicValue ?underpullFDIRInfo .
	?underpullFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?underpullIncident .
	?underpullFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?underpullFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?underpullIncident .
	?underpullFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?underpullFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
An overtorque FDIR function reacts to abnormal torque conditions. The rotation is stopped and possibly counter measures
are applied to remediate the cause of the overtorque with the objective to return to normal conditions.
``` dwis overtorqueFDIRInfo
DynamicDrillingSignal: overtorqueFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: overtorqueFDIRInfo_1
overtorqueFDIRInfo_1 HasDynamicValue overtorqueFDIRInfo
OverTorque: overTorqueIncident
overtorqueFDIRInfo_1 IsRelatedToDrillingIncident overTorqueIncident
ServiceCompany: serviceCompany
overtorqueFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
overtorqueFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident overTorqueIncident
overtorqueFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
overtorqueFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[overtorqueFDIRInfo_1] -->|HasDynamicValue| N0001[overtorqueFDIRInfo] 
	N0000[overtorqueFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[overTorqueIncident] 
	N0000[overtorqueFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[overtorqueFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[overTorqueIncident] 
	N0000[overtorqueFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[overtorqueFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?overtorqueFDIRInfo
WHERE {
	?overtorqueFDIRInfo_1 ddhub:HasDynamicValue ?overtorqueFDIRInfo .
	?overtorqueFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?overTorqueIncident .
	?overtorqueFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?overtorqueFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?overTorqueIncident .
	?overtorqueFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?overtorqueFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A gain-loss FDIR reacts to influx of formation fluids in the borehole or losses of drilling fluids to the formation. 
After detection, procedures may be applied to control the gain or loss situation.
``` dwis gainLossFDIRInfo
DynamicDrillingSignal: gainLossFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: gainLossFDIRInfo_1
gainLossFDIRInfo_1 HasDynamicValue gainLossFDIRInfo
Influx: influxIncident
gainLossFDIRInfo_1 IsRelatedToDrillingIncident influxIncident
LossCirculation: lossCirculationIncident
gainLossFDIRInfo_1 IsRelatedToDrillingIncident lossCirculationIncident
ServiceCompany: serviceCompany
gainLossFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
gainLossFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident influxIncident
FDIRFunction_1 ManagesIncident lossCirculationIncident
gainLossFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
gainLossFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[gainLossFDIRInfo_1] -->|HasDynamicValue| N0001[gainLossFDIRInfo] 
	N0000[gainLossFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[influxIncident] 
	N0000[gainLossFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0003[lossCirculationIncident] 
	N0000[gainLossFDIRInfo_1] -->|IsProvidedBy| N0004[serviceCompany] 
	N0000[gainLossFDIRInfo_1] -->|IsRecommendedBy| N0005[computationUnit] 
	N0006[FDIRFunction_1] -->|ManagesIncident| N0002[influxIncident] 
	N0006[FDIRFunction_1] -->|ManagesIncident| N0003[lossCirculationIncident] 
	N0000[gainLossFDIRInfo_1] -->|IsRecommendedFor| N0006[FDIRFunction_1] 
	N0000[gainLossFDIRInfo_1] -->|IsProvidedTo| N0007[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?gainLossFDIRInfo
WHERE {
	?gainLossFDIRInfo_1 ddhub:HasDynamicValue ?gainLossFDIRInfo .
	?gainLossFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?influxIncident .
	?gainLossFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?lossCirculationIncident .
	?gainLossFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?gainLossFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?influxIncident .
	?FDIRFunction_1 ddhub:ManagesIncident ?lossCirculationIncident .
	?gainLossFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?gainLossFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
It is similar to the gain-loss FDIR advice but only focuses on a kick situation.
``` dwis kickFDIRInfo
DynamicDrillingSignal: kickFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: kickFDIRInfo_1
kickFDIRInfo_1 HasDynamicValue kickFDIRInfo
Influx: influxIncident
kickFDIRInfo_1 IsRelatedToDrillingIncident influxIncident
ServiceCompany: serviceCompany
kickFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
kickFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident influxIncident
kickFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
kickFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[kickFDIRInfo_1] -->|HasDynamicValue| N0001[kickFDIRInfo] 
	N0000[kickFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[influxIncident] 
	N0000[kickFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[kickFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[influxIncident] 
	N0000[kickFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[kickFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?kickFDIRInfo
WHERE {
	?kickFDIRInfo_1 ddhub:HasDynamicValue ?kickFDIRInfo .
	?kickFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?influxIncident .
	?kickFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?kickFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?influxIncident .
	?kickFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?kickFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
It is similar to the gain-loss FDIR advice but only focuses on a loss circulation situation.
``` dwis lossCirculationFDIRInfo
DynamicDrillingSignal: lossCirculationFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: lossCirculationFDIRInfo_1
lossCirculationFDIRInfo_1 HasDynamicValue lossCirculationFDIRInfo
LossCirculation: lossCirculationIncident
lossCirculationFDIRInfo_1 IsRelatedToDrillingIncident lossCirculationIncident
ServiceCompany: serviceCompany
lossCirculationFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
lossCirculationFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident lossCirculationIncident
lossCirculationFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
lossCirculationFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[lossCirculationFDIRInfo_1] -->|HasDynamicValue| N0001[lossCirculationFDIRInfo] 
	N0000[lossCirculationFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[lossCirculationIncident] 
	N0000[lossCirculationFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[lossCirculationFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[lossCirculationIncident] 
	N0000[lossCirculationFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[lossCirculationFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?lossCirculationFDIRInfo
WHERE {
	?lossCirculationFDIRInfo_1 ddhub:HasDynamicValue ?lossCirculationFDIRInfo .
	?lossCirculationFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?lossCirculationIncident .
	?lossCirculationFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?lossCirculationFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?lossCirculationIncident .
	?lossCirculationFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?lossCirculationFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A hole collapse FDIR detects whether a formation collapse is occurring. Possibly counter measures are applied to contain
the side effects of the hole collapse.
``` dwis HoleCollapseFDIRInfo
DynamicDrillingSignal: HoleCollapseFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: HoleCollapseFDIRInfo_1
HoleCollapseFDIRInfo_1 HasDynamicValue HoleCollapseFDIRInfo
HoleCollapse: holeCollapseIncident
HoleCollapseFDIRInfo_1 IsRelatedToDrillingIncident holeCollapseIncident
ServiceCompany: serviceCompany
HoleCollapseFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
HoleCollapseFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident holeCollapseIncident
HoleCollapseFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
HoleCollapseFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[HoleCollapseFDIRInfo_1] -->|HasDynamicValue| N0001[HoleCollapseFDIRInfo] 
	N0000[HoleCollapseFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[holeCollapseIncident] 
	N0000[HoleCollapseFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[HoleCollapseFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[holeCollapseIncident] 
	N0000[HoleCollapseFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[HoleCollapseFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?HoleCollapseFDIRInfo
WHERE {
	?HoleCollapseFDIRInfo_1 ddhub:HasDynamicValue ?HoleCollapseFDIRInfo .
	?HoleCollapseFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?holeCollapseIncident .
	?HoleCollapseFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?HoleCollapseFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?holeCollapseIncident .
	?HoleCollapseFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?HoleCollapseFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A pipe washout FDIR reacts to a situation during which a leak between the drill-string and the annulus is detected. Possible
remedial actions may be applied to limit the side effects of the pipe washout.
``` dwis pipeWashoutFDIRInfo
DynamicDrillingSignal: pipeWashoutFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: pipeWashoutFDIRInfo_1
pipeWashoutFDIRInfo_1 HasDynamicValue pipeWashoutFDIRInfo
PipeWashout: pipeWashoutIncident
pipeWashoutFDIRInfo_1 IsRelatedToDrillingIncident pipeWashoutIncident
ServiceCompany: serviceCompany
pipeWashoutFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
pipeWashoutFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident pipeWashoutIncident
pipeWashoutFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
pipeWashoutFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[pipeWashoutFDIRInfo_1] -->|HasDynamicValue| N0001[pipeWashoutFDIRInfo] 
	N0000[pipeWashoutFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[pipeWashoutIncident] 
	N0000[pipeWashoutFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[pipeWashoutFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[pipeWashoutIncident] 
	N0000[pipeWashoutFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[pipeWashoutFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?pipeWashoutFDIRInfo
WHERE {
	?pipeWashoutFDIRInfo_1 ddhub:HasDynamicValue ?pipeWashoutFDIRInfo .
	?pipeWashoutFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?pipeWashoutIncident .
	?pipeWashoutFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?pipeWashoutFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?pipeWashoutIncident .
	?pipeWashoutFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?pipeWashoutFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A twist-off FDIR reacts to the case of the undesired separation of part of the drill-stem. Possibly, a procedure may
be applied to remediate the parting of the drill-stem, like trying to reconnect if the cause of the separation was a back-off at the
level of one connection.
``` dwis twistOffFDIRInfo
DynamicDrillingSignal: twistOffFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: twistOffFDIRInfo_1
twistOffFDIRInfo_1 HasDynamicValue twistOffFDIRInfo
TwistOff: twistOffIncident
twistOffFDIRInfo_1 IsRelatedToDrillingIncident twistOffIncident
ServiceCompany: serviceCompany
twistOffFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
twistOffFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident twistOffIncident
twistOffFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
twistOffFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[twistOffFDIRInfo_1] -->|HasDynamicValue| N0001[twistOffFDIRInfo] 
	N0000[twistOffFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[twistOffIncident] 
	N0000[twistOffFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[twistOffFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[twistOffIncident] 
	N0000[twistOffFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[twistOffFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?twistOffFDIRInfo
WHERE {
	?twistOffFDIRInfo_1 ddhub:HasDynamicValue ?twistOffFDIRInfo .
	?twistOffFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?twistOffIncident .
	?twistOffFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?twistOffFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?twistOffIncident .
	?twistOffFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?twistOffFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A motor stall FDIR detects when a downhole motor stalls. A procedure is applied to regain rotation of the rotor of the
downhole motor.
``` dwis motorStallFDIRInfo
DynamicDrillingSignal: motorStallFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: motorStallFDIRInfo_1
motorStallFDIRInfo_1 HasDynamicValue motorStallFDIRInfo
MotorStall: motorStallIncident
motorStallFDIRInfo_1 IsRelatedToDrillingIncident motorStallIncident
ServiceCompany: serviceCompany
motorStallFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
motorStallFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident motorStallIncident
motorStallFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
motorStallFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[motorStallFDIRInfo_1] -->|HasDynamicValue| N0001[motorStallFDIRInfo] 
	N0000[motorStallFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[motorStallIncident] 
	N0000[motorStallFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[motorStallFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[motorStallIncident] 
	N0000[motorStallFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[motorStallFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?motorStallFDIRInfo
WHERE {
	?motorStallFDIRInfo_1 ddhub:HasDynamicValue ?motorStallFDIRInfo .
	?motorStallFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?motorStallIncident .
	?motorStallFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?motorStallFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?motorStallIncident .
	?motorStallFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?motorStallFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A whirl FDIR reacts to situation during which there is possibly harming whirling along the drill-stem. Counter-measures
may be applied to stop the whirling and return to normal conditions.
``` dwis whirlFDIRInfo
DynamicDrillingSignal: whirlFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: whirlFDIRInfo_1
whirlFDIRInfo_1 HasDynamicValue whirlFDIRInfo
Whirling: whirlingIncident
whirlFDIRInfo_1 IsRelatedToDrillingIncident whirlingIncident
ServiceCompany: serviceCompany
whirlFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
whirlFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident whirlingIncident
whirlFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
whirlFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[whirlFDIRInfo_1] -->|HasDynamicValue| N0001[whirlFDIRInfo] 
	N0000[whirlFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[whirlingIncident] 
	N0000[whirlFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[whirlFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[whirlingIncident] 
	N0000[whirlFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[whirlFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?whirlFDIRInfo
WHERE {
	?whirlFDIRInfo_1 ddhub:HasDynamicValue ?whirlFDIRInfo .
	?whirlFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?whirlingIncident .
	?whirlFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?whirlFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?whirlingIncident .
	?whirlFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?whirlFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
A differential sticking FDIR detects when the drill-stem is differentially stuck. It possibly applies counter-measures 
to free the drill-stem.
``` dwis differentialStickingFDIRInfo
DynamicDrillingSignal: differentialStickingFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: differentialStickingFDIRInfo_1
differentialStickingFDIRInfo_1 HasDynamicValue differentialStickingFDIRInfo
DifferentiallyStuck: differentiallyStuckIncident
differentialStickingFDIRInfo_1 IsRelatedToDrillingIncident differentiallyStuckIncident
ServiceCompany: serviceCompany
differentialStickingFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
differentialStickingFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident differentiallyStuckIncident
differentialStickingFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
differentialStickingFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[differentialStickingFDIRInfo_1] -->|HasDynamicValue| N0001[differentialStickingFDIRInfo] 
	N0000[differentialStickingFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0002[differentiallyStuckIncident] 
	N0000[differentialStickingFDIRInfo_1] -->|IsProvidedBy| N0003[serviceCompany] 
	N0000[differentialStickingFDIRInfo_1] -->|IsRecommendedBy| N0004[computationUnit] 
	N0005[FDIRFunction_1] -->|ManagesIncident| N0002[differentiallyStuckIncident] 
	N0000[differentialStickingFDIRInfo_1] -->|IsRecommendedFor| N0005[FDIRFunction_1] 
	N0000[differentialStickingFDIRInfo_1] -->|IsProvidedTo| N0006[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?differentialStickingFDIRInfo
WHERE {
	?differentialStickingFDIRInfo_1 ddhub:HasDynamicValue ?differentialStickingFDIRInfo .
	?differentialStickingFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?differentiallyStuckIncident .
	?differentialStickingFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?differentialStickingFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 ddhub:ManagesIncident ?differentiallyStuckIncident .
	?differentialStickingFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?differentialStickingFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
}
```
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsRecommendedBy
DWISVerb <|-- IsRecommendedFor
IsRelatedToDrillingLimit <|-- HasControlLimit
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
AdvisorySystemAdvice ||--o{ ComputationUnit : IsRecommendedBy
AdvisorySystemAdvice ||--o{ ActivableFunction : IsRecommendedFor
DrillingDataPoint ||--o{ DrillingLimit : HasControlLimit
```
## IsRecommendedBy <!-- VERB -->
- Display name: Is Recommended By
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Object class: [ComputationUnit](./DataFlow.md#ComputationUnit)
- Definition set: AdvisorySystemAdvice
- Description: 
Indicates that the AdvisorySystemAdvice is recommended by an Advisor
- Examples:
``` dwis toolfaceOrientationProcedureInfo
DynamicDrillingSignal: toolfaceOrientationProcedureInfo
ToolfaceOrientationProcedureAdvice: toolfaceOrientationProcedureInfo_1
toolfaceOrientationProcedureInfo_1 HasDynamicValue toolfaceOrientationProcedureInfo
ServiceCompany: serviceCompany
toolfaceOrientationProcedureInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
toolfaceOrientationProcedureInfo_1 IsRecommendedBy computationUnit
ProcedureFunction: procedureFunction
procedureFunction.HasFunction = "ToolfaceOrientationProcedure"
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
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsProvidedBy| N0002[serviceCompany] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsRecommendedBy| N0003[computationUnit] 
	N0004[procedureFunction] -->|HasFunction| N0005["ToolfaceOrientationProcedure"] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsRecommendedFor| N0004[procedureFunction] 
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
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?procedureFunction ddhub:HasFunction ?Attribute000 .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedTo ?scheduler .
  FILTER (
	?Attribute000 = "ToolfaceOrientationProcedure"
  )
}
```
## IsRecommendedFor <!-- VERB -->
- Display name: Is Recommended For
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [AdvisorySystemAdvice](./AdvisorySystemAdvice.md#AdvisorySystemAdvice)
- Object class: [ActivableFunction](./ADCS.md#ActivableFunction)
- Definition set: AdvisorySystemAdvice
- Description: 
Indicates that the AdvisorySystemAdvice is recommended for an ADCS Activable Function
- Examples:
``` dwis toolfaceOrientationProcedureInfo
DynamicDrillingSignal: toolfaceOrientationProcedureInfo
ToolfaceOrientationProcedureAdvice: toolfaceOrientationProcedureInfo_1
toolfaceOrientationProcedureInfo_1 HasDynamicValue toolfaceOrientationProcedureInfo
ProcedureFunction: procedureFunction
procedureFunction.HasFunction = "ToolfaceOrientationProcedure"
toolfaceOrientationProcedureInfo_1 IsRecommendedFor procedureFunction
DWISADCSInterface: ADCSInterface
toolfaceOrientationProcedureInfo_1 IsProvidedTo ADCSInterface
DWISAdviceComposer: adviceComposer
toolfaceOrientationProcedureInfo_1 IsProvidedBy adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[toolfaceOrientationProcedureInfo_1] -->|HasDynamicValue| N0001[toolfaceOrientationProcedureInfo] 
	N0002[procedureFunction] -->|HasFunction| N0003["ToolfaceOrientationProcedure"] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsRecommendedFor| N0002[procedureFunction] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsProvidedTo| N0004[ADCSInterface] 
	N0000[toolfaceOrientationProcedureInfo_1] -->|IsProvidedBy| N0005[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?toolfaceOrientationProcedureInfo
WHERE {
	?toolfaceOrientationProcedureInfo_1 ddhub:HasDynamicValue ?toolfaceOrientationProcedureInfo .
	?procedureFunction ddhub:HasFunction ?Attribute000 .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsRecommendedFor ?procedureFunction .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedTo ?ADCSInterface .
	?toolfaceOrientationProcedureInfo_1 ddhub:IsProvidedBy ?adviceComposer .
  FILTER (
	?Attribute000 = "ToolfaceOrientationProcedure"
  )
}
```
## HasControlLimit <!-- VERB -->
- Display name: Has Control Limit
- Parent verb: [IsRelatedToDrillingLimit](./DrillingLimit.md#IsRelatedToDrillingLimit)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Definition set: AdvisorySystemAdvice
- Description: 
This Verb is used to indicate that a drilling data point has a control limit.
