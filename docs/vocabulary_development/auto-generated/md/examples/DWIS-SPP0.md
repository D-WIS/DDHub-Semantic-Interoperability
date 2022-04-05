# DWIS-SPP0
- DrillingDataPoint:SPP_0
- StandPipe:StandPipe_0
- SPPQuantity:SPPQuantity_0
- SensorUncertainty:SPPUncertainty_0
- LowPassFilter:SPP_LowPassFilter
- DataProvider:DrillingControlSystem_0
- Location:StandPipeLocation
- DrillFloorReferenceLocation:DrillFloorLocation
- DrillingDataPoint:StandPipeElevation
- VerticalElevationReferenceFrame:ElevationReferenceFrame
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
- ElevationReferenceFrame HasReferenceFrameOrigin DrillFloorLocation
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	SPP_0([SPP_0]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	StandPipe_0([StandPipe_0]) --> StandPipe:::typeClass[[StandPipe]]
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity:::typeClass[[SPPQuantity]]
	SPPUncertainty_0([SPPUncertainty_0]) --> SensorUncertainty:::typeClass[[SensorUncertainty]]
	SPP_LowPassFilter([SPP_LowPassFilter]) --> LowPassFilter:::typeClass[[LowPassFilter]]
	DrillingControlSystem_0([DrillingControlSystem_0]) --> DataProvider:::typeClass[[DataProvider]]
	StandPipeLocation([StandPipeLocation]) --> Location:::typeClass[[Location]]
	DrillFloorLocation([DrillFloorLocation]) --> DrillFloorReferenceLocation:::typeClass[[DrillFloorReferenceLocation]]
	StandPipeElevation([StandPipeElevation]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	ElevationReferenceFrame([ElevationReferenceFrame]) --> VerticalElevationReferenceFrame:::typeClass[[VerticalElevationReferenceFrame]]
	 SPP_0 -- IsProvidedBy --> DrillingControlSystem_0 
	 SPP_0 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 SPP_0 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_0 -- IsGeneratedBy --> SPP_LowPassFilter 
	 SPP_0 -- HasUncertainty --> SPPUncertainty_0 
	 SPP_0 -- HasElevationReference --> StandPipeLocation 
	 SPP_0 -- IsPhysicallyLocatedAt --> StandPipeLocation 
	 StandPipeLocation -- HasCoordinates --> StandPipeElevation 
	 StandPipeLocation -- HasReferenceFrame --> ElevationReferenceFrame 
	 ElevationReferenceFrame -- HasReferenceFrameOrigin --> DrillFloorLocation 
	 SPP_0 -- BelongsToClass --> SPP((SPP)) 
	 SPP_0 -- BelongsToClass --> Measurement((Measurement)) 
```
