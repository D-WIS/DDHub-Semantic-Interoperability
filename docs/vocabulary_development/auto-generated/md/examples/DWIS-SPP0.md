# DWIS-SPP0
- DrillingDataPoint:SPP_0
- Standpipe:Standpipe_0
- SPPQuantity:SPPQuantity_0
- SensorUncertainty:SPPUncertainty_0
- LowPassFilter:SPP_LowPassFilter
- DataProvider:DrillingControlSystem_0
- Location:StandpipeLocation
- DerrickFloorVerticalLocation:DerrickFloorVerticalLocation
- DrillingDataPoint:StandpipeElevation
- VerticalDepthFrame:ElevationReferenceFrame
- SPP_0 BelongsToClass SPP
- SPP_0 BelongsToClass Measurement
- SPP_0 IsProvidedBy DrillingControlSystem_0
- SPP_0 IsHydraulicallyLocatedAt Standpipe_0
- SPP_0 IsOfMeasurableQuantity SPPQuantity_0
- SPP_0 IsGeneratedBy SPP_LowPassFilter
- SPP_0 HasUncertainty SPPUncertainty_0
- SPP_0 HasElevationReference StandpipeLocation
- SPP_0 IsPhysicallyLocatedAt StandpipeLocation
- StandpipeLocation HasCoordinates StandpipeElevation
- StandpipeLocation HasReferenceFrame ElevationReferenceFrame
- ElevationReferenceFrame HasReferenceFrameOrigin DerrickFloorVerticalLocation
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	SPP_0([SPP_0]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	Standpipe_0([Standpipe_0]) --> Standpipe[[Standpipe]]:::typeClass
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity[[SPPQuantity]]:::typeClass
	SPPUncertainty_0([SPPUncertainty_0]) --> SensorUncertainty[[SensorUncertainty]]:::typeClass
	SPP_LowPassFilter([SPP_LowPassFilter]) --> LowPassFilter[[LowPassFilter]]:::typeClass
	DrillingControlSystem_0([DrillingControlSystem_0]) --> DataProvider[[DataProvider]]:::typeClass
	StandpipeLocation([StandpipeLocation]) --> Location[[Location]]:::typeClass
	DerrickFloorVerticalLocation([DerrickFloorVerticalLocation]) --> DerrickFloorVerticalLocation[[DerrickFloorVerticalLocation]]:::typeClass
	StandpipeElevation([StandpipeElevation]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	ElevationReferenceFrame([ElevationReferenceFrame]) --> VerticalDepthFrame[[VerticalDepthFrame]]:::typeClass
	 SPP_0 -- IsProvidedBy --> DrillingControlSystem_0 
	 SPP_0 -- IsHydraulicallyLocatedAt --> Standpipe_0 
	 SPP_0 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_0 -- IsGeneratedBy --> SPP_LowPassFilter 
	 SPP_0 -- HasUncertainty --> SPPUncertainty_0 
	 SPP_0 -- HasElevationReference --> StandpipeLocation 
	 SPP_0 -- IsPhysicallyLocatedAt --> StandpipeLocation 
	 StandpipeLocation -- HasCoordinates --> StandpipeElevation 
	 StandpipeLocation -- HasReferenceFrame --> ElevationReferenceFrame 
	 ElevationReferenceFrame -- HasReferenceFrameOrigin --> DerrickFloorVerticalLocation 
	 SPP_0 -- BelongsToClass --> SPP((SPP)):::classClass
	 SPP_0 -- BelongsToClass --> Measurement((Measurement)):::classClass
```
