# LWD Signals
- DrillingDataPoint:DrillingDataPoint_0
- FormationResistivityDrillingQuantity:Resistivity_0
- Location:Location_0
- MudPulseTelemetry:MudPulseTelemetry_0
- DataFlowNode:DataFlowNode_0
- DrillingDataPoint:DrillingDataPoint_1
- Location:Location_1
- DrillingDataPoint:DrillingDataPoint_2
- DrillingDataPoint:DrillingDataPoint_3
- DepthDrillingQuantity:DepthQuantity_0
- DrillingDataPoint:DrillingDataPoint_4
- PorosityQuantity:FormationPorosityQuantity_0
- DrillingDataPoint:DrillingDataPoint_5
- DrillingDataPoint:DrillingDataPoint_6
- Location:Location_2
- DrillingDataPoint:DrillingDataPoint_7
- DrillingDataPoint_0 IsOfMeasurableQuantity Resistivity_0
- DrillingDataPoint_0 IsPhysicallyLocatedAt Location_0
- DrillingDataPoint_0 IsTransmittedBy MudPulseTelemetry_0
- DrillingDataPoint_0 IsProvidedBy DataFlowNode_0
- DrillingDataPoint_1 IsPhysicallyLocatedAt Location_1
- DrillingDataPoint_1 IsTransmittedBy MudPulseTelemetry_0
- DrillingDataPoint_1 IsProvidedBy DataFlowNode_0
- Location_0 HasCoordinates DrillingDataPoint_2
- Location_1 HasCoordinates DrillingDataPoint_3
- DrillingDataPoint_2 IsOfMeasurableQuantity DepthQuantity_0
- DrillingDataPoint_3 IsOfMeasurableQuantity DepthQuantity_0
- DrillingDataPoint_4 IsOfMeasurableQuantity FormationPorosityQuantity_0
- DrillingDataPoint_5 IsOfMeasurableQuantity FormationPorosityQuantity_0
- DrillingDataPoint_6 IsOfMeasurableQuantity FormationPorosityQuantity_0
- DrillingDataPoint_4 IsPhysicallyLocatedAt Location_2
- DrillingDataPoint_5 IsPhysicallyLocatedAt Location_2
- DrillingDataPoint_6 IsPhysicallyLocatedAt Location_2
- Location_2 HasCoordinates DrillingDataPoint_7
- DrillingDataPoint_5 IsTransmittedBy MudPulseTelemetry_0
- DrillingDataPoint_6 IsTransmittedBy MudPulseTelemetry_0
- DrillingDataPoint_4 IsTransmittedBy MudPulseTelemetry_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	Resistivity_0([Resistivity_0]) --> FormationResistivityDrillingQuantity[[FormationResistivityDrillingQuantity]]:::typeClass
	Location_0([Location_0]) --> Location[[Location]]:::typeClass
	MudPulseTelemetry_0([MudPulseTelemetry_0]) --> MudPulseTelemetry[[MudPulseTelemetry]]:::typeClass
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode[[DataFlowNode]]:::typeClass
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	Location_1([Location_1]) --> Location[[Location]]:::typeClass
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	DrillingDataPoint_3([DrillingDataPoint_3]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	DepthQuantity_0([DepthQuantity_0]) --> DepthDrillingQuantity[[DepthDrillingQuantity]]:::typeClass
	DrillingDataPoint_4([DrillingDataPoint_4]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	FormationPorosityQuantity_0([FormationPorosityQuantity_0]) --> PorosityQuantity[[PorosityQuantity]]:::typeClass
	DrillingDataPoint_5([DrillingDataPoint_5]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	DrillingDataPoint_6([DrillingDataPoint_6]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	Location_2([Location_2]) --> Location[[Location]]:::typeClass
	DrillingDataPoint_7([DrillingDataPoint_7]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	 DrillingDataPoint_0 -- IsOfMeasurableQuantity --> Resistivity_0 
	 DrillingDataPoint_0 -- IsPhysicallyLocatedAt --> Location_0 
	 DrillingDataPoint_0 -- IsTransmittedBy --> MudPulseTelemetry_0 
	 DrillingDataPoint_0 -- IsProvidedBy --> DataFlowNode_0 
	 DrillingDataPoint_1 -- IsPhysicallyLocatedAt --> Location_1 
	 DrillingDataPoint_1 -- IsTransmittedBy --> MudPulseTelemetry_0 
	 DrillingDataPoint_1 -- IsProvidedBy --> DataFlowNode_0 
	 Location_0 -- HasCoordinates --> DrillingDataPoint_2 
	 Location_1 -- HasCoordinates --> DrillingDataPoint_3 
	 DrillingDataPoint_2 -- IsOfMeasurableQuantity --> DepthQuantity_0 
	 DrillingDataPoint_3 -- IsOfMeasurableQuantity --> DepthQuantity_0 
	 DrillingDataPoint_4 -- IsOfMeasurableQuantity --> FormationPorosityQuantity_0 
	 DrillingDataPoint_5 -- IsOfMeasurableQuantity --> FormationPorosityQuantity_0 
	 DrillingDataPoint_6 -- IsOfMeasurableQuantity --> FormationPorosityQuantity_0 
	 DrillingDataPoint_4 -- IsPhysicallyLocatedAt --> Location_2 
	 DrillingDataPoint_5 -- IsPhysicallyLocatedAt --> Location_2 
	 DrillingDataPoint_6 -- IsPhysicallyLocatedAt --> Location_2 
	 Location_2 -- HasCoordinates --> DrillingDataPoint_7 
	 DrillingDataPoint_5 -- IsTransmittedBy --> MudPulseTelemetry_0 
	 DrillingDataPoint_6 -- IsTransmittedBy --> MudPulseTelemetry_0 
	 DrillingDataPoint_4 -- IsTransmittedBy --> MudPulseTelemetry_0 
```
