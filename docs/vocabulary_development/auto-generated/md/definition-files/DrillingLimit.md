# DrillingLimit<!-- DEFINITION SET HEADER -->
- Description: 
this category refers mostly to the description of drilling limits.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
DWISNoun <|-- DrillingLimit
DrillingLimit <|-- OnlyLimits
DrillingLimit <|-- AxialVelocityLimit
DrillingLimit <|-- RotationalVelocityLimit
DrillingLimit <|-- FlowrateLimit
DrillingLimit <|-- ROPLimit
DrillingLimit <|-- WOBLimit
DrillingLimit <|-- DifferentialPressureLimit
DrillingLimit <|-- TorqueLimit
```
## DrillingLimit <!-- NOUN -->
- Display name: Drilling Limit
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Description: 
This is the parent class for drilling limits. A limit applies typically on a desired value as controlled by a controller.
- Definition set: DrillingLimit
## OnlyLimits <!-- NOUN -->
- Display name: Only Limits
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This noun states that something works with only limits, for example excluding the relation to set-points, etc.
- Definition set: DrillingLimit
- Examples:
```dwis isUsedAutoDrillerWithOnlyLimit
DrillingSignal:isUsedAutoDrillerWithOnlyLimit
ProcessFeature:isUsedAutoDrillerWithOnlyLimit#01
BooleanDataType:isUsedAutoDrillerWithOnlyLimit#01
isUsedAutoDrillerWithOnlyLimit#01 HasStaticValue isUsedAutoDrillerWithOnlyLimit
ControllerFunction:AutoDriller
StableAxialVelocityObjective:stableROP
StableAxialForceObjective:stableWOB
AutoDriller ImplementsObjective stableROP
AutoDriller ImplementsObjective stableWOB
isUsedAutoDrillerWithOnlyLimit#01 IsFeatureSignalFor AutoDriller
OnlyLimits:onlyLimits
isUsedAutoDrillerWithOnlyLimit#01 IsRelatedToDrillingLimit onlyLimits
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[isUsedAutoDrillerWithOnlyLimit] -->|BelongsToClass| N0001(DrillingSignal) 
	N0002[isUsedAutoDrillerWithOnlyLimit#01] -->|BelongsToClass| N0003(ProcessFeature) 
	N0002[isUsedAutoDrillerWithOnlyLimit#01] -->|BelongsToClass| N0004(BooleanDataType) 
	N0002[isUsedAutoDrillerWithOnlyLimit#01] -->|HasStaticValue| N0000[isUsedAutoDrillerWithOnlyLimit] 
	N0005[AutoDriller] -->|BelongsToClass| N0006(ControllerFunction) 
	N0007[stableROP] -->|BelongsToClass| N0008(StableAxialVelocityObjective) 
	N0009[stableWOB] -->|BelongsToClass| N0010(StableAxialForceObjective) 
	N0005[AutoDriller] -->|ImplementsObjective| N0007[stableROP] 
	N0005[AutoDriller] -->|ImplementsObjective| N0009[stableWOB] 
	N0002[isUsedAutoDrillerWithOnlyLimit#01] -->|IsFeatureSignalFor| N0005[AutoDriller] 
	N0011[onlyLimits] -->|BelongsToClass| N0012(OnlyLimits) 
	N0002[isUsedAutoDrillerWithOnlyLimit#01] -->|IsRelatedToDrillingLimit| N0011[onlyLimits] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?isUsedAutoDrillerWithOnlyLimit
WHERE {
	?isUsedAutoDrillerWithOnlyLimit rdf:type ddhub:DrillingSignal .
	?isUsedAutoDrillerWithOnlyLimit#01 rdf:type ddhub:ProcessFeature .
	?isUsedAutoDrillerWithOnlyLimit#01 rdf:type ddhub:BooleanDataType .
	?isUsedAutoDrillerWithOnlyLimit#01 ddhub:HasStaticValue ?isUsedAutoDrillerWithOnlyLimit .
	?AutoDriller rdf:type ddhub:ControllerFunction .
	?stableROP rdf:type ddhub:StableAxialVelocityObjective .
	?stableWOB rdf:type ddhub:StableAxialForceObjective .
	?AutoDriller ddhub:ImplementsObjective ?stableROP .
	?AutoDriller ddhub:ImplementsObjective ?stableWOB .
	?isUsedAutoDrillerWithOnlyLimit#01 ddhub:IsFeatureSignalFor ?AutoDriller .
	?onlyLimits rdf:type ddhub:OnlyLimits .
	?isUsedAutoDrillerWithOnlyLimit#01 ddhub:IsRelatedToDrillingLimit ?onlyLimits .
}
```
## AxialVelocityLimit <!-- NOUN -->
- Display name: Axial Velocity Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to an axial velocity limit.
- Definition set: DrillingLimit
- Examples:
``` dwis minMaxAxialVelocitySOEInfo
DynamicDrillingSignal:minMaxAxialVelocitySOEInfo
DrillingSafeOperatingEnvelopeAdvice:minMaxAxialVelocitySOEInfo_1
minMaxAxialVelocitySOEInfo_1 HasDynamicValue minMaxAxialVelocitySOEInfo
AxialVelocityLimit:axialVelocityLimit
minMaxAxialVelocitySOEInfo_1 IsRelatedToDrillingLimit axialVelocityLimit
ServiceCompany:serviceCompany
minMaxAxialVelocitySOEInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
minMaxAxialVelocitySOEInfo_1 IsRecommendedBy computationUnit
SOEFunction:soeFunction
soeFunction ImplementsLimit axialVelocityLimit
minMaxAxialVelocitySOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer:adviceComposer
minMaxAxialVelocitySOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
minMaxAxialVelocitySOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxAxialVelocitySOEInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|BelongsToClass| N0003(DrillingSafeOperatingEnvelopeAdvice) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|HasDynamicValue| N0000[minMaxAxialVelocitySOEInfo] 
	N0004[axialVelocityLimit] -->|BelongsToClass| N0005(AxialVelocityLimit) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsRelatedToDrillingLimit| N0004[axialVelocityLimit] 
	N0006[serviceCompany] -->|BelongsToClass| N0007(ServiceCompany) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedBy| N0006[serviceCompany] 
	N0008[computationUnit] -->|BelongsToClass| N0009(Advisor) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsRecommendedBy| N0008[computationUnit] 
	N0010[soeFunction] -->|BelongsToClass| N0011(SOEFunction) 
	N0010[soeFunction] -->|ImplementsLimit| N0004[axialVelocityLimit] 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsRecommendedFor| N0010[soeFunction] 
	N0012[adviceComposer] -->|BelongsToClass| N0013(DWISAdviceComposer) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedTo| N0012[adviceComposer] 
	N0014[scheduler] -->|BelongsToClass| N0015(DWISScheduler) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedTo| N0014[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxAxialVelocitySOEInfo
WHERE {
	?minMaxAxialVelocitySOEInfo rdf:type ddhub:DynamicDrillingSignal .
	?minMaxAxialVelocitySOEInfo_1 rdf:type ddhub:DrillingSafeOperatingEnvelopeAdvice .
	?minMaxAxialVelocitySOEInfo_1 ddhub:HasDynamicValue ?minMaxAxialVelocitySOEInfo .
	?axialVelocityLimit rdf:type ddhub:AxialVelocityLimit .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRelatedToDrillingLimit ?axialVelocityLimit .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction rdf:type ddhub:SOEFunction .
	?soeFunction ddhub:ImplementsLimit ?axialVelocityLimit .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## RotationalVelocityLimit <!-- NOUN -->
- Display name: Rotational Velocity Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to a rotational velocity limit.
- Definition set: DrillingLimit
- Examples:
``` dwis minMaxRotationalSpeedSOEInfo
DynamicDrillingSignal:minMaxRotationalSpeedSOEInfo
DrillingSafeOperatingEnvelopeAdvice:minMaxRotationalSpeedSOEInfo_1
minMaxRotationalSpeedSOEInfo_1 HasDynamicValue minMaxRotationalSpeedSOEInfo
RotationalVelocityLimit:rotationalVelocityLimit
minMaxRotationalSpeedSOEInfo_1 IsRelatedToDrillingLimit rotationalVelocityLimit
ServiceCompany:serviceCompany
minMaxRotationalSpeedSOEInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
minMaxRotationalSpeedSOEInfo_1 IsRecommendedBy computationUnit
SOEFunction:soeFunction
soeFunction ImplementsLimit rotationalVelocityLimit
minMaxRotationalSpeedSOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer:adviceComposer
minMaxRotationalSpeedSOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
minMaxRotationalSpeedSOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxRotationalSpeedSOEInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|BelongsToClass| N0003(DrillingSafeOperatingEnvelopeAdvice) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|HasDynamicValue| N0000[minMaxRotationalSpeedSOEInfo] 
	N0004[rotationalVelocityLimit] -->|BelongsToClass| N0005(RotationalVelocityLimit) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|IsRelatedToDrillingLimit| N0004[rotationalVelocityLimit] 
	N0006[serviceCompany] -->|BelongsToClass| N0007(ServiceCompany) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|IsProvidedBy| N0006[serviceCompany] 
	N0008[computationUnit] -->|BelongsToClass| N0009(Advisor) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|IsRecommendedBy| N0008[computationUnit] 
	N0010[soeFunction] -->|BelongsToClass| N0011(SOEFunction) 
	N0010[soeFunction] -->|ImplementsLimit| N0004[rotationalVelocityLimit] 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|IsRecommendedFor| N0010[soeFunction] 
	N0012[adviceComposer] -->|BelongsToClass| N0013(DWISAdviceComposer) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|IsProvidedTo| N0012[adviceComposer] 
	N0014[scheduler] -->|BelongsToClass| N0015(DWISScheduler) 
	N0002[minMaxRotationalSpeedSOEInfo_1] -->|IsProvidedTo| N0014[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxRotationalSpeedSOEInfo
WHERE {
	?minMaxRotationalSpeedSOEInfo rdf:type ddhub:DynamicDrillingSignal .
	?minMaxRotationalSpeedSOEInfo_1 rdf:type ddhub:DrillingSafeOperatingEnvelopeAdvice .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:HasDynamicValue ?minMaxRotationalSpeedSOEInfo .
	?rotationalVelocityLimit rdf:type ddhub:RotationalVelocityLimit .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsRelatedToDrillingLimit ?rotationalVelocityLimit .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction rdf:type ddhub:SOEFunction .
	?soeFunction ddhub:ImplementsLimit ?rotationalVelocityLimit .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?minMaxRotationalSpeedSOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## FlowrateLimit <!-- NOUN -->
- Display name: Flowrate Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to a flowrate limit.
- Definition set: DrillingLimit
- Examples:
``` dwis minMaxFlowRateSOEInfo
DynamicDrillingSignal:minMaxFlowRateSOEInfo
DrillingSafeOperatingEnvelopeAdvice:minMaxFlowRateSOEInfo_1
minMaxFlowRateSOEInfo_1 HasDynamicValue minMaxFlowRateSOEInfo
FlowrateLimit:flowrateLimit
minMaxFlowRateSOEInfo_1 IsRelatedToDrillingLimit flowrateLimit
ServiceCompany:serviceCompany
minMaxFlowRateSOEInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
minMaxFlowRateSOEInfo_1 IsRecommendedBy computationUnit
SOEFunction:soeFunction
soeFunction ImplementsLimit flowrateLimit
minMaxFlowRateSOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer:adviceComposer
minMaxFlowRateSOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
minMaxFlowRateSOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxFlowRateSOEInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[minMaxFlowRateSOEInfo_1] -->|BelongsToClass| N0003(DrillingSafeOperatingEnvelopeAdvice) 
	N0002[minMaxFlowRateSOEInfo_1] -->|HasDynamicValue| N0000[minMaxFlowRateSOEInfo] 
	N0004[flowrateLimit] -->|BelongsToClass| N0005(FlowrateLimit) 
	N0002[minMaxFlowRateSOEInfo_1] -->|IsRelatedToDrillingLimit| N0004[flowrateLimit] 
	N0006[serviceCompany] -->|BelongsToClass| N0007(ServiceCompany) 
	N0002[minMaxFlowRateSOEInfo_1] -->|IsProvidedBy| N0006[serviceCompany] 
	N0008[computationUnit] -->|BelongsToClass| N0009(Advisor) 
	N0002[minMaxFlowRateSOEInfo_1] -->|IsRecommendedBy| N0008[computationUnit] 
	N0010[soeFunction] -->|BelongsToClass| N0011(SOEFunction) 
	N0010[soeFunction] -->|ImplementsLimit| N0004[flowrateLimit] 
	N0002[minMaxFlowRateSOEInfo_1] -->|IsRecommendedFor| N0010[soeFunction] 
	N0012[adviceComposer] -->|BelongsToClass| N0013(DWISAdviceComposer) 
	N0002[minMaxFlowRateSOEInfo_1] -->|IsProvidedTo| N0012[adviceComposer] 
	N0014[scheduler] -->|BelongsToClass| N0015(DWISScheduler) 
	N0002[minMaxFlowRateSOEInfo_1] -->|IsProvidedTo| N0014[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxFlowRateSOEInfo
WHERE {
	?minMaxFlowRateSOEInfo rdf:type ddhub:DynamicDrillingSignal .
	?minMaxFlowRateSOEInfo_1 rdf:type ddhub:DrillingSafeOperatingEnvelopeAdvice .
	?minMaxFlowRateSOEInfo_1 ddhub:HasDynamicValue ?minMaxFlowRateSOEInfo .
	?flowrateLimit rdf:type ddhub:FlowrateLimit .
	?minMaxFlowRateSOEInfo_1 ddhub:IsRelatedToDrillingLimit ?flowrateLimit .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?minMaxFlowRateSOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?minMaxFlowRateSOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction rdf:type ddhub:SOEFunction .
	?soeFunction ddhub:ImplementsLimit ?flowrateLimit .
	?minMaxFlowRateSOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?minMaxFlowRateSOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?minMaxFlowRateSOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
## ROPLimit <!-- NOUN -->
- Display name: ROP Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to a rate of penetration limit.
- Definition set: DrillingLimit
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
## WOBLimit <!-- NOUN -->
- Display name: WOB Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to a weight on bit limit.
- Definition set: DrillingLimit
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
## DifferentialPressureLimit <!-- NOUN -->
- Display name: Differential Pressure Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to a differential pressure limit.
- Definition set: DrillingLimit
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
## TorqueLimit <!-- NOUN -->
- Display name: Torque Limit
- Parent class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Description: 
This Noun is used to refer to a torque limit.
- Definition set: DrillingLimit
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsRelatedToDrillingLimit
DWISVerb <|-- ImplementsLimit
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
DrillingDataPoint ||--o{ DrillingLimit : IsRelatedToDrillingLimit
SOEFunction ||--o{ DrillingLimit : ImplementsLimit
```
## IsRelatedToDrillingLimit <!-- VERB -->
- Display name: Is Related to Drilling Limit
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Definition set: DrillingLimit
- Description: 
This Verb is used to indicate that a drilling data point is related to a drilling incident.
- Examples:
``` dwis motorStallFDIRInfo
DynamicDrillingSignal:motorStallFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice:motorStallFDIRInfo_1
motorStallFDIRInfo_1 HasDynamicValue motorStallFDIRInfo
MotorStall:motorStallIncident
motorStallFDIRInfo_1 IsRelatedToDrillingIncident motorStallIncident
ServiceCompany:serviceCompany
motorStallFDIRInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
motorStallFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction:FDIRFunction_1
FDIRFunction_1.HasFunction = "MotorStallFDIR"
motorStallFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer:adviceComposer
motorStallFDIRInfo_1 IsProvidedTo adviceComposer
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[motorStallFDIRInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[motorStallFDIRInfo_1] -->|BelongsToClass| N0003(DrillingFaultDetectionIsolationAndRecoveryAdvice) 
	N0002[motorStallFDIRInfo_1] -->|HasDynamicValue| N0000[motorStallFDIRInfo] 
	N0004[motorStallIncident] -->|BelongsToClass| N0005(MotorStall) 
	N0002[motorStallFDIRInfo_1] -->|IsRelatedToDrillingIncident| N0004[motorStallIncident] 
	N0006[serviceCompany] -->|BelongsToClass| N0007(ServiceCompany) 
	N0002[motorStallFDIRInfo_1] -->|IsProvidedBy| N0006[serviceCompany] 
	N0008[computationUnit] -->|BelongsToClass| N0009(Advisor) 
	N0002[motorStallFDIRInfo_1] -->|IsRecommendedBy| N0008[computationUnit] 
	N0010[FDIRFunction_1] -->|BelongsToClass| N0011(FDIRFunction) 
	N0010[FDIRFunction_1] -->|HasFunction| N0012["MotorStallFDIR"] 
	N0002[motorStallFDIRInfo_1] -->|IsRecommendedFor| N0010[FDIRFunction_1] 
	N0013[adviceComposer] -->|BelongsToClass| N0014(DWISAdviceComposer) 
	N0002[motorStallFDIRInfo_1] -->|IsProvidedTo| N0013[adviceComposer] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?motorStallFDIRInfo
WHERE {
	?motorStallFDIRInfo rdf:type ddhub:DynamicDrillingSignal .
	?motorStallFDIRInfo_1 rdf:type ddhub:DrillingFaultDetectionIsolationAndRecoveryAdvice .
	?motorStallFDIRInfo_1 ddhub:HasDynamicValue ?motorStallFDIRInfo .
	?motorStallIncident rdf:type ddhub:MotorStall .
	?motorStallFDIRInfo_1 ddhub:IsRelatedToDrillingIncident ?motorStallIncident .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?motorStallFDIRInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?motorStallFDIRInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?FDIRFunction_1 rdf:type ddhub:FDIRFunction .
	?FDIRFunction_1 ddhub:HasFunction ?Attribute000 .
	?motorStallFDIRInfo_1 ddhub:IsRecommendedFor ?FDIRFunction_1 .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?motorStallFDIRInfo_1 ddhub:IsProvidedTo ?adviceComposer .
  FILTER (
	?Attribute000 = "MotorStallFDIR"
  )
}
```
## ImplementsLimit <!-- VERB -->
- Display name: Implements Limit
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [SOEFunction](./ADCS.md#SOEFunction)
- Object class: [DrillingLimit](./DrillingLimit.md#DrillingLimit)
- Definition set: DrillingLimit
- Description: 
This Verb is used to indicate that a safe operating envelope function implements a drilling limit.
- Examples:
``` dwis minMaxAxialVelocitySOEInfo
DynamicDrillingSignal:minMaxAxialVelocitySOEInfo
DrillingSafeOperatingEnvelopeAdvice:minMaxAxialVelocitySOEInfo_1
minMaxAxialVelocitySOEInfo_1 HasDynamicValue minMaxAxialVelocitySOEInfo
AxialVelocityLimit:axialVelocityLimit
minMaxAxialVelocitySOEInfo_1 IsRelatedToDrillingLimit axialVelocityLimit
ServiceCompany:serviceCompany
minMaxAxialVelocitySOEInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
minMaxAxialVelocitySOEInfo_1 IsRecommendedBy computationUnit
SOEFunction:soeFunction
soeFunction ImplementsLimit axialVelocityLimit
minMaxAxialVelocitySOEInfo_1 IsRecommendedFor soeFunction
DWISAdviceComposer:adviceComposer
minMaxAxialVelocitySOEInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
minMaxAxialVelocitySOEInfo_1 IsProvidedTo scheduler
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[minMaxAxialVelocitySOEInfo] -->|BelongsToClass| N0001(DynamicDrillingSignal) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|BelongsToClass| N0003(DrillingSafeOperatingEnvelopeAdvice) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|HasDynamicValue| N0000[minMaxAxialVelocitySOEInfo] 
	N0004[axialVelocityLimit] -->|BelongsToClass| N0005(AxialVelocityLimit) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsRelatedToDrillingLimit| N0004[axialVelocityLimit] 
	N0006[serviceCompany] -->|BelongsToClass| N0007(ServiceCompany) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedBy| N0006[serviceCompany] 
	N0008[computationUnit] -->|BelongsToClass| N0009(Advisor) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsRecommendedBy| N0008[computationUnit] 
	N0010[soeFunction] -->|BelongsToClass| N0011(SOEFunction) 
	N0010[soeFunction] -->|ImplementsLimit| N0004[axialVelocityLimit] 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsRecommendedFor| N0010[soeFunction] 
	N0012[adviceComposer] -->|BelongsToClass| N0013(DWISAdviceComposer) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedTo| N0012[adviceComposer] 
	N0014[scheduler] -->|BelongsToClass| N0015(DWISScheduler) 
	N0002[minMaxAxialVelocitySOEInfo_1] -->|IsProvidedTo| N0014[scheduler] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?minMaxAxialVelocitySOEInfo
WHERE {
	?minMaxAxialVelocitySOEInfo rdf:type ddhub:DynamicDrillingSignal .
	?minMaxAxialVelocitySOEInfo_1 rdf:type ddhub:DrillingSafeOperatingEnvelopeAdvice .
	?minMaxAxialVelocitySOEInfo_1 ddhub:HasDynamicValue ?minMaxAxialVelocitySOEInfo .
	?axialVelocityLimit rdf:type ddhub:AxialVelocityLimit .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRelatedToDrillingLimit ?axialVelocityLimit .
	?serviceCompany rdf:type ddhub:ServiceCompany .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedBy ?serviceCompany .
	?computationUnit rdf:type ddhub:Advisor .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRecommendedBy ?computationUnit .
	?soeFunction rdf:type ddhub:SOEFunction .
	?soeFunction ddhub:ImplementsLimit ?axialVelocityLimit .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsRecommendedFor ?soeFunction .
	?adviceComposer rdf:type ddhub:DWISAdviceComposer .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedTo ?adviceComposer .
	?scheduler rdf:type ddhub:DWISScheduler .
	?minMaxAxialVelocitySOEInfo_1 ddhub:IsProvidedTo ?scheduler .
}
```
