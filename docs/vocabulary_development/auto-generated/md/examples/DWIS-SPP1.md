# DWIS-SPP1
- StandPipe:StandPipe_0
- SPPQuantity:SPPQuantity_0
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
- SPP_1 BelongsToClass SPP
- SPP_1 BelongsToClass ComputedData
- SPP_1 BelongsToClass Limit
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
	StandPipe_0([StandPipe_0]) --> StandPipe[[StandPipe]]:::typeClass
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity[[SPPQuantity]]:::typeClass
	StandPipeLocation([StandPipeLocation]) --> Location[[Location]]:::typeClass
	DrillFloorLocation([DrillFloorLocation]) --> DrillFloorReferenceLocation[[DrillFloorReferenceLocation]]:::typeClass
	StandPipeElevation([StandPipeElevation]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	ElevationReferenceFrame([ElevationReferenceFrame]) --> VerticalElevationReferenceFrame[[VerticalElevationReferenceFrame]]:::typeClass
	SPP_1([SPP_1]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
	DrillingOptimizingService_0([DrillingOptimizingService_0]) --> DataProvider[[DataProvider]]:::typeClass
	MovingAverage1([MovingAverage1]) --> MovingAverage[[MovingAverage]]:::typeClass
	SPP1_Uncertainty([SPP1_Uncertainty]) --> GaussianUncertainty[[GaussianUncertainty]]:::typeClass
	SPPComputationUnit_0([SPPComputationUnit_0]) --> ComputationUnit[[ComputationUnit]]:::typeClass
	InstantComputedSPP([InstantComputedSPP]) --> DrillingDataPoint[[DrillingDataPoint]]:::typeClass
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
	 SPP_1 -- BelongsToClass --> SPP((SPP)) 
	 SPP_1 -- BelongsToClass --> ComputedData((ComputedData)) 
	 SPP_1 -- BelongsToClass --> Limit((Limit)) 
```
