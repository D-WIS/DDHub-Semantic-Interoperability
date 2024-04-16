# Flow-rate aggregation
- FlowRateIn:FlowRateIn_0
- Standpipe:Standpipe_0
- FlowRateQuantity:FlowRateQuantity_0
- DrillingDataPoint:DrillingDataPoint_0
- Transformation:Transformation_0
- DrillingDataPoint:DrillingDataPoint_1
- DrillingDataPoint:DrillingDataPoint_2
- FlowRateIn_0 IsHydraulicallyLocatedAt Standpipe_0
- FlowRateIn_0 IsOfMeasurableQuantity FlowRateQuantity_0
- DrillingDataPoint_0 IsTransformationInput Transformation_0
- DrillingDataPoint_1 IsTransformationInput Transformation_0
- DrillingDataPoint_2 IsTransformationInput Transformation_0
- Transformation_0 IsTransformationOutput FlowRateIn_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	FlowRateIn_0([FlowRateIn_0]) --> FlowRateIn[[FlowRateIn]]:::typeClass
	Standpipe_0([Standpipe_0]) --> Standpipe[[Standpipe]]:::typeClass
	FlowRateQuantity_0([FlowRateQuantity_0]) --> FlowRateQuantity[[FlowRateQuantity]]:::typeClass
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	Transformation_0([Transformation_0]) --> Transformation[[Transformation]]:::typeClass
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	 FlowRateIn_0 -- IsHydraulicallyLocatedAt --> Standpipe_0 
	 FlowRateIn_0 -- IsOfMeasurableQuantity --> FlowRateQuantity_0 
	 DrillingDataPoint_0 -- IsTransformationInput --> Transformation_0 
	 DrillingDataPoint_1 -- IsTransformationInput --> Transformation_0 
	 DrillingDataPoint_2 -- IsTransformationInput --> Transformation_0 
	 Transformation_0 -- IsTransformationOutput --> FlowRateIn_0 
```
