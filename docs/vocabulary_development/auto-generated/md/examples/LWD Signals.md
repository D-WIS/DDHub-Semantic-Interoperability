# LWD Signals
- DrillingDataPoint:DrillingDataPoint_0
- Resistivity:Resistivity_0
- Location:Location_0
- MudPulseTelemetry:MudPulseTelemetry_0
- DataFlowNode:DataFlowNode_0
- DrillingDataPoint:DrillingDataPoint_1
- RockDensityQuantity:RockDensityQuantity_0
- Location:Location_1
- DrillingDataPoint:DrillingDataPoint_2
- DrillingDataPoint:DrillingDataPoint_3
- DepthQuantity:DepthQuantity_0
- DrillingDataPoint:DrillingDataPoint_4
- FormationPorosityQuantity:FormationPorosityQuantity_0
- DrillingDataPoint:DrillingDataPoint_5
- DrillingDataPoint:DrillingDataPoint_6
- Location:Location_2
- DrillingDataPoint:DrillingDataPoint_7
- MassDensityQuantity:MassDensityQuantity_0
- DrillingDataPoint_0 IsOfMeasurableQuantity Resistivity_0
- DrillingDataPoint_0 IsPhysicallyLocatedAt Location_0
- DrillingDataPoint_0 IsTransmittedBy MudPulseTelemetry_0
- DrillingDataPoint_0 IsProvidedBy DataFlowNode_0
- DrillingDataPoint_1 IsOfMeasurableQuantity RockDensityQuantity_0
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
- RockDensityQuantity_0 IsObservableFrom MassDensityQuantity_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	Resistivity_0([Resistivity_0]) --> Resistivity:::classDef[[Resistivity]]
	Location_0([Location_0]) --> Location:::classDef[[Location]]
	MudPulseTelemetry_0([MudPulseTelemetry_0]) --> MudPulseTelemetry:::classDef[[MudPulseTelemetry]]
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode:::classDef[[DataFlowNode]]
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	RockDensityQuantity_0([RockDensityQuantity_0]) --> RockDensityQuantity:::classDef[[RockDensityQuantity]]
	Location_1([Location_1]) --> Location:::classDef[[Location]]
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_3([DrillingDataPoint_3]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DepthQuantity_0([DepthQuantity_0]) --> DepthQuantity:::classDef[[DepthQuantity]]
	DrillingDataPoint_4([DrillingDataPoint_4]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	FormationPorosityQuantity_0([FormationPorosityQuantity_0]) --> FormationPorosityQuantity:::classDef[[FormationPorosityQuantity]]
	DrillingDataPoint_5([DrillingDataPoint_5]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_6([DrillingDataPoint_6]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	Location_2([Location_2]) --> Location:::classDef[[Location]]
	DrillingDataPoint_7([DrillingDataPoint_7]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	MassDensityQuantity_0([MassDensityQuantity_0]) --> MassDensityQuantity:::classDef[[MassDensityQuantity]]
	 DrillingDataPoint_0 -- IsOfMeasurableQuantity --> Resistivity_0 
	 DrillingDataPoint_0 -- IsPhysicallyLocatedAt --> Location_0 
	 DrillingDataPoint_0 -- IsTransmittedBy --> MudPulseTelemetry_0 
	 DrillingDataPoint_0 -- IsProvidedBy --> DataFlowNode_0 
	 DrillingDataPoint_1 -- IsOfMeasurableQuantity --> RockDensityQuantity_0 
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
	 RockDensityQuantity_0 -- IsObservableFrom --> MassDensityQuantity_0 
```
