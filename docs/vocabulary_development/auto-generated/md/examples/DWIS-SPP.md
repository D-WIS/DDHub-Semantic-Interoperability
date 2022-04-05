# DWIS-SPP
- DrillingDataPoint:SPP_0
- StandPipe:StandPipe_0
- SPPQuantity:SPPQuantity_0
- SensorUncertainty:SPPUncertainty_0
- LowPassFilter:SPP_LowPassFilter
- DataProvider:DrillingControlSystem_0
- SPP_0 IsProvidedBy DrillingControlSystem_0
- SPP_0 IsHydraulicallyLocatedAt StandPipe_0
- SPP_0 IsOfMeasurableQuantity SPPQuantity_0
- SPP_0 IsProvidedBy DrillingControlSystem_0
- SPP_0 IsGeneratedBy SPP_LowPassFilter
```mermaid
flowchart TD
	SPP_0([SPP_0]) --> DrillingDataPoint[[DrillingDataPoint]]
	StandPipe_0([StandPipe_0]) --> StandPipe[[StandPipe]]
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity[[SPPQuantity]]
	SPPUncertainty_0([SPPUncertainty_0]) --> SensorUncertainty[[SensorUncertainty]]
	SPP_LowPassFilter([SPP_LowPassFilter]) --> LowPassFilter[[LowPassFilter]]
	DrillingControlSystem_0([DrillingControlSystem_0]) --> DataProvider[[DataProvider]]
	 SPP_0 -- IsProvidedBy --> DrillingControlSystem_0 
	 SPP_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 SPP_0 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_0 -- IsProvidedBy --> DrillingControlSystem_0 
	 SPP_0 -- IsGeneratedBy --> SPP_LowPassFilter 
```
