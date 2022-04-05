# DWIS-SPPs
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
- DrillingDataPoint:SPP_1
- DataProvider:DrillingOptimizingService_0
- MovingAverage:MovingAverage1
- GaussianUncertainty:SPP1_Uncertainty
- ComputationUnit:SPPComputationUnit_0
- DrillingDataPoint:InstantComputedSPP
- SPP_0 BelongsToClass SPP
- SPP_0 BelongsToClass Measurement
- SPP_1 BelongsToClass SPP
- SPP_1 BelongsToClass ComputedData
- SPP_1 BelongsToClass Limit
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
- SPP_1 IsProvidedBy DrillingOptimizingService_0
- SPP_1 IsGeneratedBy MovingAverage1
- SPP_1 IsHydraulicallyLocatedAt StandPipe_0
- SPP_1 IsOfMeasurableQuantity SPPQuantity_0
- SPP_1 HasUncertainty SPP1_Uncertainty
- SPP_1 HasElevationReference StandPipeLocation
- SPP_1 IsPhysicallyLocatedAt StandPipeLocation
- InstantComputedSPP IsComputedBy SPPComputationUnit_0
- InstantComputedSPP IsTransmissionInput MovingAverage1
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
	SPP_1([SPP_1]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DrillingOptimizingService_0([DrillingOptimizingService_0]) --> DataProvider:::typeClass[[DataProvider]]
	MovingAverage1([MovingAverage1]) --> MovingAverage:::typeClass[[MovingAverage]]
	SPP1_Uncertainty([SPP1_Uncertainty]) --> GaussianUncertainty:::typeClass[[GaussianUncertainty]]
	SPPComputationUnit_0([SPPComputationUnit_0]) --> ComputationUnit:::typeClass[[ComputationUnit]]
	InstantComputedSPP([InstantComputedSPP]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
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
	 SPP_1 -- IsProvidedBy --> DrillingOptimizingService_0 
	 SPP_1 -- IsGeneratedBy --> MovingAverage1 
	 SPP_1 -- IsHydraulicallyLocatedAt --> StandPipe_0 
	 SPP_1 -- IsOfMeasurableQuantity --> SPPQuantity_0 
	 SPP_1 -- HasUncertainty --> SPP1_Uncertainty 
	 SPP_1 -- HasElevationReference --> StandPipeLocation 
	 SPP_1 -- IsPhysicallyLocatedAt --> StandPipeLocation 
	 InstantComputedSPP -- IsComputedBy --> SPPComputationUnit_0 
	 InstantComputedSPP -- IsTransmissionInput --> MovingAverage1 
	 SPP_0 -- BelongsToClass --> SPP((SPP)) 
	 SPP_0 -- BelongsToClass --> Measurement((Measurement)) 
	 SPP_1 -- BelongsToClass --> SPP((SPP)) 
	 SPP_1 -- BelongsToClass --> ComputedData((ComputedData)) 
	 SPP_1 -- BelongsToClass --> Limit((Limit)) 
```
