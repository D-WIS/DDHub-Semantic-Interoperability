# Flow-rate In
- FlowRateIn:FlowRateIn_0
- DrillingDataPoint:DrillingDataPoint_0
- Derivation:Derivation_0
- DrillingDataPoint:DrillingDataPoint_1
- DrillingDataPoint:DrillingDataPoint_2
- MudStandpipe:StandPipe_0
- DrillingDataPoint_0 IsTransformationInput Derivation_0
- DrillingDataPoint_1 IsTransformationInput Derivation_0
- DrillingDataPoint_2 IsTransformationInput Derivation_0
- Derivation_0 IsTransformationOutput FlowRateIn_0
- FlowRateIn_0 IsHydraulicallyLocatedAt StandPipe_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	FlowRateIn_0([FlowRateIn_0]) --> FlowRateIn[[FlowRateIn]]:::typeClass
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	Derivation_0([Derivation_0]) --> Derivation[[Derivation]]:::typeClass
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	StandPipe_0([StandPipe_0]) --> MudStandpipe[[MudStandpipe]]:::typeClass
	 DrillingDataPoint_0 -- IsTransformationInput --> Derivation_0 
	 DrillingDataPoint_1 -- IsTransformationInput --> Derivation_0 
	 DrillingDataPoint_2 -- IsTransformationInput --> Derivation_0 
	 Derivation_0 -- IsTransformationOutput --> FlowRateIn_0 
	 FlowRateIn_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
```
