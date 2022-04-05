# SPP
- SPP:SPP_0
- StandPipe:StandPipe_0
- SPPQuantity:SPPQuantity_0
- TimeWindowMovingAverage:TimeWindowMovingAverage_0
- TopSideTelemetry:TopSideTelemetry_0
- DataFlowNode:DataFlowNode_0
- SPP_0 IsHydraulicallyLocatedAt StandPipe_0
- SPP_0 IsOfMeasurableQuantity SPPQuantity_0
- SPP_0 IsProcessedBy TimeWindowMovingAverage_0
- SPP_0 IsTransmittedBy TopSideTelemetry_0
- SPP_0 IsProvidedBy DataFlowNode_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	SPP_0([SPP_0]) --> SPP[[SPP]]:::typeClass
	StandPipe_0([StandPipe_0]) --> StandPipe[[StandPipe]]:::typeClass
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity[[SPPQuantity]]:::typeClass
	TimeWindowMovingAverage_0([TimeWindowMovingAverage_0]) --> TimeWindowMovingAverage[[TimeWindowMovingAverage]]:::typeClass
	TopSideTelemetry_0([TopSideTelemetry_0]) --> TopSideTelemetry[[TopSideTelemetry]]:::typeClass
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode[[DataFlowNode]]:::typeClass
	 SPP_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 SPP_0 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_0 -- IsProcessedBy --> TimeWindowMovingAverage_0 
	 SPP_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 SPP_0 -- IsProvidedBy --> DataFlowNode_0 
```
