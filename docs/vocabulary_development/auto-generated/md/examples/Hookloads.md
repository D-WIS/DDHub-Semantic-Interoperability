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
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DeadLine_0([DeadLine_0]) --> DeadLine:::classDef[[DeadLine]]
	HookLoad_0([HookLoad_0]) --> HookLoad:::classDef[[HookLoad]]
	TravellingBlock_0([TravellingBlock_0]) --> TravellingBlock:::classDef[[TravellingBlock]]
	HookLoad_1([HookLoad_1]) --> HookLoad:::classDef[[HookLoad]]
	TopDriveShaft_0([TopDriveShaft_0]) --> TopDriveShaft:::classDef[[TopDriveShaft]]
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	HookloadQuantity_0([HookloadQuantity_0]) --> HookloadQuantity:::classDef[[HookloadQuantity]]
	Transformation_0([Transformation_0]) --> Transformation:::classDef[[Transformation]]
	ForceToLoadTransformation_0([ForceToLoadTransformation_0]) --> ForceToLoadTransformation:::classDef[[ForceToLoadTransformation]]
	ForceToLoadTransformation_1([ForceToLoadTransformation_1]) --> ForceToLoadTransformation:::classDef[[ForceToLoadTransformation]]
	DrillingDataPoint_3([DrillingDataPoint_3]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	TopSideTelemetry_0([TopSideTelemetry_0]) --> TopSideTelemetry:::classDef[[TopSideTelemetry]]
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode:::classDef[[DataFlowNode]]
	TimeWindowMovingAverage_0([TimeWindowMovingAverage_0]) --> TimeWindowMovingAverage:::classDef[[TimeWindowMovingAverage]]
	TimeWindowMovingAverage_1([TimeWindowMovingAverage_1]) --> TimeWindowMovingAverage:::classDef[[TimeWindowMovingAverage]]
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
