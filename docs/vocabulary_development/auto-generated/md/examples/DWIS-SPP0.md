# DWIS-SPP0
- DrillingDataPoint:SPP_0
- MudStandpipe:StandPipe_0
- PressureDrillingQuantity:SPPQuantity_0
- SensorUncertainty:SPPUncertainty_0
- LowPassFilter:SPP_LowPassFilter
- DataProvider:DrillingControlSystem_0
- Location:StandPipeLocation
- DerrickFloorVerticalLocation:DerrickFloorVerticalLocation
- DrillingDataPoint:StandPipeElevation
- VerticalDepthFrame:ElevationReferenceFrame
- SPP_0 BelongsToClass SPP
- SPP_0 BelongsToClass Measurement
- SPP_0 IsProvidedBy DrillingControlSystem_0
- SPP_0 IsHydraulicallyLocatedAt StandPipe_0
- SPP_0 IsOfMeasurableQuantity SPPQuantity_0
- SPP_0 IsGeneratedBy SPP_LowPassFilter
- SPP_0 HasUncertainty SPPUncertainty_0
- SPP_0 HasElevationReference StandPipeLocation
- SPP_0 IsPhysicallyLocatedAt StandPipeLocation
- StandPipeLocation HasCoordinates StandPipeElevation
- StandPipeLocation HasReferenceFrame ElevationReferenceFrame
- ElevationReferenceFrame HasReferenceFrameOrigin DerrickFloorVerticalLocation
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	SPP_0([SPP_0]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	StandPipe_0([StandPipe_0]) --> MudStandpipe[[MudStandpipe]]:::typeClass
	SPPQuantity_0([SPPQuantity_0]) --> PressureDrillingQuantity[[PressureDrillingQuantity]]:::typeClass
	SPPUncertainty_0([SPPUncertainty_0]) --> SensorUncertainty[[SensorUncertainty]]:::typeClass
	SPP_LowPassFilter([SPP_LowPassFilter]) --> LowPassFilter[[LowPassFilter]]:::typeClass
	DrillingControlSystem_0([DrillingControlSystem_0]) --> DataProvider[[DataProvider]]:::typeClass
	StandPipeLocation([StandPipeLocation]) --> Location[[Location]]:::typeClass
	DerrickFloorVerticalLocation([DerrickFloorVerticalLocation]) --> DerrickFloorVerticalLocation[[DerrickFloorVerticalLocation]]:::typeClass
	StandPipeElevation([StandPipeElevation]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	ElevationReferenceFrame([ElevationReferenceFrame]) --> VerticalDepthFrame[[VerticalDepthFrame]]:::typeClass
	 SPP_0 -- IsProvidedBy --> DrillingControlSystem_0 
	 SPP_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 SPP_0 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_0 -- IsGeneratedBy --> SPP_LowPassFilter 
	 SPP_0 -- HasUncertainty --> SPPUncertainty_0 
	 SPP_0 -- HasElevationReference --> StandPipeLocation 
	 SPP_0 -- IsPhysicallyLocatedAt --> StandPipeLocation 
	 StandPipeLocation -- HasCoordinates --> StandPipeElevation 
	 StandPipeLocation -- HasReferenceFrame --> ElevationReferenceFrame 
	 ElevationReferenceFrame -- HasReferenceFrameOrigin --> DerrickFloorVerticalLocation 
	 SPP_0 -- BelongsToClass --> SPP((SPP)):::classClass
	 SPP_0 -- BelongsToClass --> Measurement((Measurement)):::classClass
```
