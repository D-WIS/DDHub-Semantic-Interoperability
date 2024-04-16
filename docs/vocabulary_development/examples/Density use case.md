# Density use case
- DensityIn:DensityIn_0
- TemperatureIn:TemperatureIn_0
- DrillingDataPoint:DrillingDataPoint_0
- DensityIn:DensityIn_1
- SPP:SPP_0
- TemperatureIn:TemperatureIn_1
- ActiveDrillingSystem:ActiveDrillingSystem_0
- MudMixing:MudMixing_0
- Standpipe:Standpipe_0
- FluidTemperatureInQuantity:FluidTemperatureInQuantity_0
- PressureQuantity:PressureQuantity_0
- FluidDensityInQuantity:FluidDensityInQuantity_0
- DensityIn_0 IsDependentOn TemperatureIn_0
- DensityIn_0 IsDependentOn DrillingDataPoint_0
- DensityIn_1 IsDependentOn SPP_0
- DensityIn_1 IsDependentOn TemperatureIn_1
- TemperatureIn_0 IsHydraulicallyLocatedAt ActiveDrillingSystem_0
- DensityIn_0 IsHydraulicallyLocatedAt MudMixing_0
- DensityIn_1 IsHydraulicallyLocatedAt Standpipe_0
- TemperatureIn_0 IsOfMeasurableQuantity FluidTemperatureInQuantity_0
- DrillingDataPoint_0 IsOfMeasurableQuantity PressureQuantity_0
- DensityIn_0 IsOfMeasurableQuantity FluidDensityInQuantity_0
- DensityIn_1 IsOfMeasurableQuantity FluidDensityInQuantity_0
- TemperatureIn_1 IsOfMeasurableQuantity FluidTemperatureInQuantity_0
```mermaid
flowchart TD
	DensityIn_0([DensityIn_0]) --> DensityIn[[DensityIn]]
	TemperatureIn_0([TemperatureIn_0]) --> TemperatureIn[[TemperatureIn]]
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint[[DrillingDataPoint]]
	DensityIn_1([DensityIn_1]) --> DensityIn[[DensityIn]]
	SPP_0([SPP_0]) --> SPP[[SPP]]
	TemperatureIn_1([TemperatureIn_1]) --> TemperatureIn[[TemperatureIn]]
	ActiveDrillingSystem_0([ActiveDrillingSystem_0]) --> ActiveDrillingSystem[[ActiveDrillingSystem]]
	MudMixing_0([MudMixing_0]) --> MudMixing[[MudMixing]]
	Standpipe_0([Standpipe_0]) --> Standpipe[[Standpipe]]
	FluidTemperatureInQuantity_0([FluidTemperatureInQuantity_0]) --> FluidTemperatureInQuantity[[FluidTemperatureInQuantity]]
	PressureQuantity_0([PressureQuantity_0]) --> PressureQuantity[[PressureQuantity]]
	FluidDensityInQuantity_0([FluidDensityInQuantity_0]) --> FluidDensityInQuantity[[FluidDensityInQuantity]]
	 DensityIn_0 -- IsDependentOn --> TemperatureIn_0 
	 DensityIn_0 -- IsDependentOn --> DrillingDataPoint_0 
	 DensityIn_1 -- IsDependentOn --> SPP_0 
	 DensityIn_1 -- IsDependentOn --> TemperatureIn_1 
	 TemperatureIn_0 -- IsHydraulicallyLocatedAt --> ActiveDrillingSystem_0 
	 DensityIn_0 -- IsHydraulicallyLocatedAt --> MudMixing_0 
	 DensityIn_1 -- IsHydraulicallyLocatedAt --> Standpipe_0 
	 TemperatureIn_0 -- IsOfMeasurableQuantity --> FluidTemperatureInQuantity_0 
	 DrillingDataPoint_0 -- IsOfMeasurableQuantity --> PressureQuantity_0 
	 DensityIn_0 -- IsOfMeasurableQuantity --> FluidDensityInQuantity_0 
	 DensityIn_1 -- IsOfMeasurableQuantity --> FluidDensityInQuantity_0 
	 TemperatureIn_1 -- IsOfMeasurableQuantity --> FluidTemperatureInQuantity_0 
```
