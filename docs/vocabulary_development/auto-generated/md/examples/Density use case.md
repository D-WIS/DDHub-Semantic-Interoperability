# Density use case
- DensityIn:DensityIn_0
- TemperatureIn:TemperatureIn_0
- DrillingDataPoint:DrillingDataPoint_0
- DensityIn:DensityIn_1
- SPP:SPP_0
- TemperatureIn:TemperatureIn_1
- ActivePit:ActivePit_0
- MudMixing:MudMixing_0
- StandPipe:StandPipe_0
- FluidTemperatureInQuantity:FluidTemperatureInQuantity_0
- PressureQuantity:PressureQuantity_0
- FluidDensityInQuantity:FluidDensityInQuantity_0
- DensityIn_0 IsDependentOn TemperatureIn_0
- DensityIn_0 IsDependentOn DrillingDataPoint_0
- DensityIn_1 IsDependentOn SPP_0
- DensityIn_1 IsDependentOn TemperatureIn_1
- TemperatureIn_0 IsHydraulicallyLocatedAt ActivePit_0
- DensityIn_0 IsHydraulicallyLocatedAt MudMixing_0
- DensityIn_1 IsHydraulicallyLocatedAt StandPipe_0
- TemperatureIn_0 IsOfMeasurableQuantity FluidTemperatureInQuantity_0
- DrillingDataPoint_0 IsOfMeasurableQuantity PressureQuantity_0
- DensityIn_0 IsOfMeasurableQuantity FluidDensityInQuantity_0
- DensityIn_1 IsOfMeasurableQuantity FluidDensityInQuantity_0
- TemperatureIn_1 IsOfMeasurableQuantity FluidTemperatureInQuantity_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	DensityIn_0([DensityIn_0]) --> DensityIn:::typeClass[[DensityIn]]
	TemperatureIn_0([TemperatureIn_0]) --> TemperatureIn:::typeClass[[TemperatureIn]]
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DensityIn_1([DensityIn_1]) --> DensityIn:::typeClass[[DensityIn]]
	SPP_0([SPP_0]) --> SPP:::typeClass[[SPP]]
	TemperatureIn_1([TemperatureIn_1]) --> TemperatureIn:::typeClass[[TemperatureIn]]
	ActivePit_0([ActivePit_0]) --> ActivePit:::typeClass[[ActivePit]]
	MudMixing_0([MudMixing_0]) --> MudMixing:::typeClass[[MudMixing]]
	StandPipe_0([StandPipe_0]) --> StandPipe:::typeClass[[StandPipe]]
	FluidTemperatureInQuantity_0([FluidTemperatureInQuantity_0]) --> FluidTemperatureInQuantity:::typeClass[[FluidTemperatureInQuantity]]
	PressureQuantity_0([PressureQuantity_0]) --> PressureQuantity:::typeClass[[PressureQuantity]]
	FluidDensityInQuantity_0([FluidDensityInQuantity_0]) --> FluidDensityInQuantity:::typeClass[[FluidDensityInQuantity]]
	 DensityIn_0 -- IsDependentOn --> TemperatureIn_0 
	 DensityIn_0 -- IsDependentOn --> DrillingDataPoint_0 
	 DensityIn_1 -- IsDependentOn --> SPP_0 
	 DensityIn_1 -- IsDependentOn --> TemperatureIn_1 
	 TemperatureIn_0 -- IsHydraulicallyLocatedAt --> ActivePit_0 
	 DensityIn_0 -- IsHydraulicallyLocatedAt --> MudMixing_0 
	 DensityIn_1 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 TemperatureIn_0 -- IsOfMeasurableQuantity --> FluidTemperatureInQuantity_0 
	 DrillingDataPoint_0 -- IsOfMeasurableQuantity --> PressureQuantity_0 
	 DensityIn_0 -- IsOfMeasurableQuantity --> FluidDensityInQuantity_0 
	 DensityIn_1 -- IsOfMeasurableQuantity --> FluidDensityInQuantity_0 
	 TemperatureIn_1 -- IsOfMeasurableQuantity --> FluidTemperatureInQuantity_0 
```
