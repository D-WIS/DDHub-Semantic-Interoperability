# Flow-rate In
- FlowRateIn:FlowRateIn_0
- FlowRateQuantity:FlowRateQuantity_0
- DrillingDataPoint:DrillingDataPoint_0
- Derivation:Derivation_0
- DrillingDataPoint:DrillingDataPoint_1
- DrillingDataPoint:DrillingDataPoint_2
- StandPipe:StandPipe_0
- FlowRateIn_0 IsOfMeasurableQuantity FlowRateQuantity_0
- DrillingDataPoint_0 IsTransformationInput Derivation_0
- DrillingDataPoint_1 IsTransformationInput Derivation_0
- DrillingDataPoint_2 IsTransformationInput Derivation_0
- Derivation_0 IsTransformationOutput FlowRateIn_0
- FlowRateIn_0 IsHydraulicallyLocatedAt StandPipe_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	FlowRateIn_0([FlowRateIn_0]) --> FlowRateIn:::typeClass[[FlowRateIn]]
	FlowRateQuantity_0([FlowRateQuantity_0]) --> FlowRateQuantity:::typeClass[[FlowRateQuantity]]
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	Derivation_0([Derivation_0]) --> Derivation:::typeClass[[Derivation]]
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	StandPipe_0([StandPipe_0]) --> StandPipe:::typeClass[[StandPipe]]
	 FlowRateIn_0 -- IsOfMeasurableQuantity --> FlowRateQuantity_0 
	 DrillingDataPoint_0 -- IsTransformationInput --> Derivation_0 
	 DrillingDataPoint_1 -- IsTransformationInput --> Derivation_0 
	 DrillingDataPoint_2 -- IsTransformationInput --> Derivation_0 
	 Derivation_0 -- IsTransformationOutput --> FlowRateIn_0 
	 FlowRateIn_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
```
