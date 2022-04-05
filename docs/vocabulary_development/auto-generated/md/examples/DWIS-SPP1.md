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
	StandPipe_0([StandPipe_0]) --> StandPipe[[StandPipe]]
	SPPQuantity_0([SPPQuantity_0]) --> SPPQuantity[[SPPQuantity]]
	StandPipeLocation([StandPipeLocation]) --> Location[[Location]]
	DrillFloorLocation([DrillFloorLocation]) --> DrillFloorReferenceLocation[[DrillFloorReferenceLocation]]
	StandPipeElevation([StandPipeElevation]) --> DrillingDataPoint[[DrillingDataPoint]]
	ElevationReferenceFrame([ElevationReferenceFrame]) --> VerticalElevationReferenceFrame[[VerticalElevationReferenceFrame]]
	SPP_1([SPP_1]) --> DrillingDataPoint[[DrillingDataPoint]]
	DrillingOptimizingService_0([DrillingOptimizingService_0]) --> DataProvider[[DataProvider]]
	MovingAverage1([MovingAverage1]) --> MovingAverage[[MovingAverage]]
	SPP1_Uncertainty([SPP1_Uncertainty]) --> GaussianUncertainty[[GaussianUncertainty]]
	SPPComputationUnit_0([SPPComputationUnit_0]) --> ComputationUnit[[ComputationUnit]]
	InstantComputedSPP([InstantComputedSPP]) --> DrillingDataPoint[[DrillingDataPoint]]
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
