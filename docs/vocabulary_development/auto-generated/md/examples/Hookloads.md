# Hookloads
- DrillingDataPoint:DrillingDataPoint_0
- DeadLine:DeadLine_0
- HookLoad:HookLoad_0
- TravellingBlock:TravellingBlock_0
- HookLoad:HookLoad_1
- TopDriveShaft:TopDriveShaft_0
- DrillingDataPoint:DrillingDataPoint_1
- DrillingDataPoint:DrillingDataPoint_2
- HookloadQuantity:HookloadQuantity_0
- Transformation:Transformation_0
- ForceToLoadTransformation:ForceToLoadTransformation_0
- ForceToLoadTransformation:ForceToLoadTransformation_1
- DrillingDataPoint:DrillingDataPoint_3
- TopSideTelemetry:TopSideTelemetry_0
- DataFlowNode:DataFlowNode_0
- TimeWindowMovingAverage:TimeWindowMovingAverage_0
- TimeWindowMovingAverage:TimeWindowMovingAverage_1
- DrillingDataPoint_0 IsMechanicallyLocatedAt DeadLine_0
- HookLoad_0 IsMechanicallyLocatedAt TravellingBlock_0
- HookLoad_1 IsMechanicallyLocatedAt TopDriveShaft_0
- DrillingDataPoint_1 IsMechanicallyLocatedAt TopDriveShaft_0
- DrillingDataPoint_2 IsMechanicallyLocatedAt TravellingBlock_0
- HookLoad_0 IsOfMeasurableQuantity HookloadQuantity_0
- HookLoad_1 IsOfMeasurableQuantity HookloadQuantity_0
- DrillingDataPoint_0 IsTransformationInput Transformation_0
- DrillingDataPoint_1 IsTransformationInput ForceToLoadTransformation_0
- DrillingDataPoint_2 IsTransformationInput ForceToLoadTransformation_1
- ForceToLoadTransformation_1 IsTransformationOutput HookLoad_0
- ForceToLoadTransformation_0 IsTransformationOutput HookLoad_1
- Transformation_0 IsTransformationOutput DrillingDataPoint_2
- HookLoad_1 IsValidBy DrillingDataPoint_3
- DrillingDataPoint_0 IsTransmittedBy TopSideTelemetry_0
- DrillingDataPoint_1 IsTransmittedBy TopSideTelemetry_0
- HookLoad_0 IsTransmittedBy TopSideTelemetry_0
- HookLoad_1 IsTransmittedBy TopSideTelemetry_0
- DrillingDataPoint_2 IsTransmittedBy TopSideTelemetry_0
- DrillingDataPoint_0 IsProvidedBy DataFlowNode_0
- DrillingDataPoint_1 IsProvidedBy DataFlowNode_0
- HookLoad_0 IsProvidedBy DataFlowNode_0
- HookLoad_1 IsProvidedBy DataFlowNode_0
- DrillingDataPoint_2 IsProvidedBy DataFlowNode_0
- HookLoad_0 IsProcessedBy TimeWindowMovingAverage_0
- HookLoad_1 IsProcessedBy TimeWindowMovingAverage_1
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DeadLine_0([DeadLine_0]) --> DeadLine:::typeClass[[DeadLine]]
	HookLoad_0([HookLoad_0]) --> HookLoad:::typeClass[[HookLoad]]
	TravellingBlock_0([TravellingBlock_0]) --> TravellingBlock:::typeClass[[TravellingBlock]]
	HookLoad_1([HookLoad_1]) --> HookLoad:::typeClass[[HookLoad]]
	TopDriveShaft_0([TopDriveShaft_0]) --> TopDriveShaft:::typeClass[[TopDriveShaft]]
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	HookloadQuantity_0([HookloadQuantity_0]) --> HookloadQuantity:::typeClass[[HookloadQuantity]]
	Transformation_0([Transformation_0]) --> Transformation:::typeClass[[Transformation]]
	ForceToLoadTransformation_0([ForceToLoadTransformation_0]) --> ForceToLoadTransformation:::typeClass[[ForceToLoadTransformation]]
	ForceToLoadTransformation_1([ForceToLoadTransformation_1]) --> ForceToLoadTransformation:::typeClass[[ForceToLoadTransformation]]
	DrillingDataPoint_3([DrillingDataPoint_3]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	TopSideTelemetry_0([TopSideTelemetry_0]) --> TopSideTelemetry:::typeClass[[TopSideTelemetry]]
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode:::typeClass[[DataFlowNode]]
	TimeWindowMovingAverage_0([TimeWindowMovingAverage_0]) --> TimeWindowMovingAverage:::typeClass[[TimeWindowMovingAverage]]
	TimeWindowMovingAverage_1([TimeWindowMovingAverage_1]) --> TimeWindowMovingAverage:::typeClass[[TimeWindowMovingAverage]]
	 DrillingDataPoint_0 -- IsMechanicallyLocatedAt --> DeadLine_0 
	 HookLoad_0 -- IsMechanicallyLocatedAt --> TravellingBlock_0 
	 HookLoad_1 -- IsMechanicallyLocatedAt --> TopDriveShaft_0 
	 DrillingDataPoint_1 -- IsMechanicallyLocatedAt --> TopDriveShaft_0 
	 DrillingDataPoint_2 -- IsMechanicallyLocatedAt --> TravellingBlock_0 
	 HookLoad_0 -- IsOfMeasurableQuantity --> HookloadQuantity_0 
	 HookLoad_1 -- IsOfMeasurableQuantity --> HookloadQuantity_0 
	 DrillingDataPoint_0 -- IsTransformationInput --> Transformation_0 
	 DrillingDataPoint_1 -- IsTransformationInput --> ForceToLoadTransformation_0 
	 DrillingDataPoint_2 -- IsTransformationInput --> ForceToLoadTransformation_1 
	 ForceToLoadTransformation_1 -- IsTransformationOutput --> HookLoad_0 
	 ForceToLoadTransformation_0 -- IsTransformationOutput --> HookLoad_1 
	 Transformation_0 -- IsTransformationOutput --> DrillingDataPoint_2 
	 HookLoad_1 -- IsValidBy --> DrillingDataPoint_3 
	 DrillingDataPoint_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 DrillingDataPoint_1 -- IsTransmittedBy --> TopSideTelemetry_0 
	 HookLoad_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 HookLoad_1 -- IsTransmittedBy --> TopSideTelemetry_0 
	 DrillingDataPoint_2 -- IsTransmittedBy --> TopSideTelemetry_0 
	 DrillingDataPoint_0 -- IsProvidedBy --> DataFlowNode_0 
	 DrillingDataPoint_1 -- IsProvidedBy --> DataFlowNode_0 
	 HookLoad_0 -- IsProvidedBy --> DataFlowNode_0 
	 HookLoad_1 -- IsProvidedBy --> DataFlowNode_0 
	 DrillingDataPoint_2 -- IsProvidedBy --> DataFlowNode_0 
	 HookLoad_0 -- IsProcessedBy --> TimeWindowMovingAverage_0 
	 HookLoad_1 -- IsProcessedBy --> TimeWindowMovingAverage_1 
```
