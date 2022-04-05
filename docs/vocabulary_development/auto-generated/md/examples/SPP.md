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
	SPP_0([SPP_0]) --> SPP:::classDef[[SPP]]
	StandPipe_0([StandPipe_0]) --> StandPipe:::classDef[[StandPipe]]
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity:::classDef[[SPPQuantity]]
	TimeWindowMovingAverage_0([TimeWindowMovingAverage_0]) --> TimeWindowMovingAverage:::classDef[[TimeWindowMovingAverage]]
	TopSideTelemetry_0([TopSideTelemetry_0]) --> TopSideTelemetry:::classDef[[TopSideTelemetry]]
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode:::classDef[[DataFlowNode]]
	 SPP_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 SPP_0 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_0 -- IsProcessedBy --> TimeWindowMovingAverage_0 
	 SPP_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 SPP_0 -- IsProvidedBy --> DataFlowNode_0 
```
