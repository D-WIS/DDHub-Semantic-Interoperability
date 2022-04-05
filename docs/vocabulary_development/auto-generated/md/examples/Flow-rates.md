# Flow-rates
- DrillingDataPoint:DrillingDataPoint_0
- FlowRateQuantity:FlowRateQuantity_0
- DrillingDataPoint:DrillingDataPoint_1
- DrillingDataPoint:DrillingDataPoint_2
- PumpRate:PumpRate_0
- PumpRateQuantity:PumpRateQuantity_0
- PumpRate:PumpRate_1
- PumpRate:PumpRate_2
- DrillingDataPoint:DrillingDataPoint_3
- VolumeQuantity:VolumeQuantity_0
- DrillingDataPoint:DrillingDataPoint_4
- DrillingDataPoint:DrillingDataPoint_5
- DrillingDataPoint:DrillingDataPoint_6
- ProportionQuantity:ProportionQuantity_0
- DrillingDataPoint:DrillingDataPoint_7
- DrillingDataPoint:DrillingDataPoint_8
- DrillingDataPoint:DrillingDataPoint_9
- Derivation:Derivation_0
- DrillingDataPoint:DrillingDataPoint_10
- Derivation:Derivation_1
- DrillingDataPoint:DrillingDataPoint_11
- Derivation:Derivation_2
- Transformation:Transformation_0
- Transformation:Transformation_1
- Transformation:Transformation_2
- MudPump:MudPump_0
- MudPump:MudPump_1
- CementPump:CementPump_0
- DrillingDataPoint_0 IsOfMeasurableQuantity FlowRateQuantity_0
- DrillingDataPoint_1 IsOfMeasurableQuantity FlowRateQuantity_0
- DrillingDataPoint_2 IsOfMeasurableQuantity FlowRateQuantity_0
- PumpRate_0 IsOfMeasurableQuantity PumpRateQuantity_0
- PumpRate_1 IsOfMeasurableQuantity PumpRateQuantity_0
- PumpRate_2 IsOfMeasurableQuantity PumpRateQuantity_0
- DrillingDataPoint_3 IsOfMeasurableQuantity VolumeQuantity_0
- DrillingDataPoint_4 IsOfMeasurableQuantity VolumeQuantity_0
- DrillingDataPoint_5 IsOfMeasurableQuantity VolumeQuantity_0
- DrillingDataPoint_6 IsOfMeasurableQuantity ProportionQuantity_0
- DrillingDataPoint_7 IsOfMeasurableQuantity ProportionQuantity_0
- DrillingDataPoint_8 IsOfMeasurableQuantity ProportionQuantity_0
- DrillingDataPoint_9 IsTransformationInput Derivation_0
- DrillingDataPoint_10 IsTransformationInput Derivation_1
- DrillingDataPoint_11 IsTransformationInput Derivation_2
- Derivation_0 IsTransformationOutput PumpRate_0
- Derivation_1 IsTransformationOutput PumpRate_1
- Derivation_2 IsTransformationOutput PumpRate_2
- PumpRate_0 IsTransformationInput Transformation_0
- PumpRate_1 IsTransformationInput Transformation_1
- PumpRate_2 IsTransformationInput Transformation_2
- DrillingDataPoint_6 IsTransformationInput Transformation_0
- DrillingDataPoint_7 IsTransformationInput Transformation_1
- DrillingDataPoint_8 IsTransformationInput Transformation_2
- DrillingDataPoint_3 IsTransformationInput Transformation_0
- DrillingDataPoint_4 IsTransformationInput Transformation_1
- DrillingDataPoint_5 IsTransformationInput Transformation_2
- Transformation_0 IsTransformationOutput DrillingDataPoint_0
- Transformation_1 IsTransformationOutput DrillingDataPoint_1
- Transformation_2 IsTransformationOutput DrillingDataPoint_2
- DrillingDataPoint_0 IsDependentOn DrillingDataPoint_6
- DrillingDataPoint_1 IsDependentOn DrillingDataPoint_7
- DrillingDataPoint_2 IsDependentOn DrillingDataPoint_8
- DrillingDataPoint_0 IsDependentOn DrillingDataPoint_3
- DrillingDataPoint_1 IsDependentOn DrillingDataPoint_4
- DrillingDataPoint_2 IsDependentOn DrillingDataPoint_5
- DrillingDataPoint_0 IsHydraulicallyLocatedAt MudPump_0
- PumpRate_0 IsHydraulicallyLocatedAt MudPump_0
- DrillingDataPoint_9 IsHydraulicallyLocatedAt MudPump_0
- DrillingDataPoint_6 IsHydraulicallyLocatedAt MudPump_0
- DrillingDataPoint_3 IsHydraulicallyLocatedAt MudPump_0
- DrillingDataPoint_1 IsHydraulicallyLocatedAt MudPump_1
- PumpRate_1 IsHydraulicallyLocatedAt MudPump_1
- DrillingDataPoint_10 IsHydraulicallyLocatedAt MudPump_1
- DrillingDataPoint_7 IsHydraulicallyLocatedAt MudPump_1
- DrillingDataPoint_4 IsHydraulicallyLocatedAt MudPump_1
- DrillingDataPoint_2 IsHydraulicallyLocatedAt CementPump_0
- PumpRate_2 IsHydraulicallyLocatedAt CementPump_0
- DrillingDataPoint_11 IsHydraulicallyLocatedAt CementPump_0
- DrillingDataPoint_8 IsHydraulicallyLocatedAt CementPump_0
- DrillingDataPoint_5 IsHydraulicallyLocatedAt CementPump_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	FlowRateQuantity_0([FlowRateQuantity_0]) --> FlowRateQuantity:::classDef[[FlowRateQuantity]]
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	PumpRate_0([PumpRate_0]) --> PumpRate:::classDef[[PumpRate]]
	PumpRateQuantity_0([PumpRateQuantity_0]) --> PumpRateQuantity:::classDef[[PumpRateQuantity]]
	PumpRate_1([PumpRate_1]) --> PumpRate:::classDef[[PumpRate]]
	PumpRate_2([PumpRate_2]) --> PumpRate:::classDef[[PumpRate]]
	DrillingDataPoint_3([DrillingDataPoint_3]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	VolumeQuantity_0([VolumeQuantity_0]) --> VolumeQuantity:::classDef[[VolumeQuantity]]
	DrillingDataPoint_4([DrillingDataPoint_4]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_5([DrillingDataPoint_5]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_6([DrillingDataPoint_6]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	ProportionQuantity_0([ProportionQuantity_0]) --> ProportionQuantity:::classDef[[ProportionQuantity]]
	DrillingDataPoint_7([DrillingDataPoint_7]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_8([DrillingDataPoint_8]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	DrillingDataPoint_9([DrillingDataPoint_9]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	Derivation_0([Derivation_0]) --> Derivation:::classDef[[Derivation]]
	DrillingDataPoint_10([DrillingDataPoint_10]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	Derivation_1([Derivation_1]) --> Derivation:::classDef[[Derivation]]
	DrillingDataPoint_11([DrillingDataPoint_11]) --> DrillingDataPoint:::classDef[[DrillingDataPoint]]
	Derivation_2([Derivation_2]) --> Derivation:::classDef[[Derivation]]
	Transformation_0([Transformation_0]) --> Transformation:::classDef[[Transformation]]
	Transformation_1([Transformation_1]) --> Transformation:::classDef[[Transformation]]
	Transformation_2([Transformation_2]) --> Transformation:::classDef[[Transformation]]
	MudPump_0([MudPump_0]) --> MudPump:::classDef[[MudPump]]
	MudPump_1([MudPump_1]) --> MudPump:::classDef[[MudPump]]
	CementPump_0([CementPump_0]) --> CementPump:::classDef[[CementPump]]
	 DrillingDataPoint_0 -- IsOfMeasurableQuantity --> FlowRateQuantity_0 
	 DrillingDataPoint_1 -- IsOfMeasurableQuantity --> FlowRateQuantity_0 
	 DrillingDataPoint_2 -- IsOfMeasurableQuantity --> FlowRateQuantity_0 
	 PumpRate_0 -- IsOfMeasurableQuantity --> PumpRateQuantity_0 
	 PumpRate_1 -- IsOfMeasurableQuantity --> PumpRateQuantity_0 
	 PumpRate_2 -- IsOfMeasurableQuantity --> PumpRateQuantity_0 
	 DrillingDataPoint_3 -- IsOfMeasurableQuantity --> VolumeQuantity_0 
	 DrillingDataPoint_4 -- IsOfMeasurableQuantity --> VolumeQuantity_0 
	 DrillingDataPoint_5 -- IsOfMeasurableQuantity --> VolumeQuantity_0 
	 DrillingDataPoint_6 -- IsOfMeasurableQuantity --> ProportionQuantity_0 
	 DrillingDataPoint_7 -- IsOfMeasurableQuantity --> ProportionQuantity_0 
	 DrillingDataPoint_8 -- IsOfMeasurableQuantity --> ProportionQuantity_0 
	 DrillingDataPoint_9 -- IsTransformationInput --> Derivation_0 
	 DrillingDataPoint_10 -- IsTransformationInput --> Derivation_1 
	 DrillingDataPoint_11 -- IsTransformationInput --> Derivation_2 
	 Derivation_0 -- IsTransformationOutput --> PumpRate_0 
	 Derivation_1 -- IsTransformationOutput --> PumpRate_1 
	 Derivation_2 -- IsTransformationOutput --> PumpRate_2 
	 PumpRate_0 -- IsTransformationInput --> Transformation_0 
	 PumpRate_1 -- IsTransformationInput --> Transformation_1 
	 PumpRate_2 -- IsTransformationInput --> Transformation_2 
	 DrillingDataPoint_6 -- IsTransformationInput --> Transformation_0 
	 DrillingDataPoint_7 -- IsTransformationInput --> Transformation_1 
	 DrillingDataPoint_8 -- IsTransformationInput --> Transformation_2 
	 DrillingDataPoint_3 -- IsTransformationInput --> Transformation_0 
	 DrillingDataPoint_4 -- IsTransformationInput --> Transformation_1 
	 DrillingDataPoint_5 -- IsTransformationInput --> Transformation_2 
	 Transformation_0 -- IsTransformationOutput --> DrillingDataPoint_0 
	 Transformation_1 -- IsTransformationOutput --> DrillingDataPoint_1 
	 Transformation_2 -- IsTransformationOutput --> DrillingDataPoint_2 
	 DrillingDataPoint_0 -- IsDependentOn --> DrillingDataPoint_6 
	 DrillingDataPoint_1 -- IsDependentOn --> DrillingDataPoint_7 
	 DrillingDataPoint_2 -- IsDependentOn --> DrillingDataPoint_8 
	 DrillingDataPoint_0 -- IsDependentOn --> DrillingDataPoint_3 
	 DrillingDataPoint_1 -- IsDependentOn --> DrillingDataPoint_4 
	 DrillingDataPoint_2 -- IsDependentOn --> DrillingDataPoint_5 
	 DrillingDataPoint_0 -- IsHydraulicallyLocatedAt --> MudPump_0 
	 PumpRate_0 -- IsHydraulicallyLocatedAt --> MudPump_0 
	 DrillingDataPoint_9 -- IsHydraulicallyLocatedAt --> MudPump_0 
	 DrillingDataPoint_6 -- IsHydraulicallyLocatedAt --> MudPump_0 
	 DrillingDataPoint_3 -- IsHydraulicallyLocatedAt --> MudPump_0 
	 DrillingDataPoint_1 -- IsHydraulicallyLocatedAt --> MudPump_1 
	 PumpRate_1 -- IsHydraulicallyLocatedAt --> MudPump_1 
	 DrillingDataPoint_10 -- IsHydraulicallyLocatedAt --> MudPump_1 
	 DrillingDataPoint_7 -- IsHydraulicallyLocatedAt --> MudPump_1 
	 DrillingDataPoint_4 -- IsHydraulicallyLocatedAt --> MudPump_1 
	 DrillingDataPoint_2 -- IsHydraulicallyLocatedAt --> CementPump_0 
	 PumpRate_2 -- IsHydraulicallyLocatedAt --> CementPump_0 
	 DrillingDataPoint_11 -- IsHydraulicallyLocatedAt --> CementPump_0 
	 DrillingDataPoint_8 -- IsHydraulicallyLocatedAt --> CementPump_0 
	 DrillingDataPoint_5 -- IsHydraulicallyLocatedAt --> CementPump_0 
```
