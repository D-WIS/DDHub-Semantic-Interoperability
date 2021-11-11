# NOUNS
## Location <!-- NOUN -->
- Display name: Location
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Specialization:
- Description: Physical location for a signal. 
Refers to:
 - a reference frame (via the HasReferenceFrame relation), that works as a system of coordinates
 - an origin (of type Location) via the HasReferenceFrameOrigin relation. 
 - some coordinates
- Examples:
## BitReferenceLocation <!-- NOUN -->
- Display name: BitReferenceLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
## CasingShoeLocation <!-- NOUN -->
- Display name: CasingShoeLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillFloorReferenceLocation <!-- NOUN -->
- Display name: DrillFloorReferenceLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
## HoleBottomLocation <!-- NOUN -->
- Display name: HoleBottomLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
## LWDLocation <!-- NOUN -->
- Display name: LWDLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ReferenceLocation <!-- NOUN -->
- Display name: ReferenceLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ReferenceFrame <!-- NOUN -->
- Display name: ReferenceFrame
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Specialization:
- Description: Represents a system of coordinates
- Examples:
## DepthAndAngleFrame <!-- NOUN -->
- Display name: DepthAndAngleFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## FourDimensionalReferenceFrame <!-- NOUN -->
- Display name: FourDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## CurviLinearFrenetSerretReferenceFrame <!-- NOUN -->
- Display name: CurviLinearFrenetSerretReferenceFrame
- Parent class: [FourDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#FourDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## OneDimensionalReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## OneDimensionalCartesianReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCartesianReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## VerticalDepthFrame <!-- NOUN -->
- Display name: VerticalDepthFrame
- Parent class: [OneDimensionalCartesianReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCartesianReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## OneDimensionalCurviLinearReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCurviLinearReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillStringCenterLineFrame <!-- NOUN -->
- Display name: DrillStringCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
  - PositiveUpward
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
## OpenHoleCenterLineFrame <!-- NOUN -->
- Display name: OpenHoleCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## WellboreCenterLineFrame <!-- NOUN -->
- Display name: WellboreCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
  - PositiveUpward
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
## ThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: ThreeDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## CartesianThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianThreeDimensionalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## FrenetSerretReferenceFrame <!-- NOUN -->
- Display name: FrenetSerretReferenceFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#CartesianThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## NorthEastTVDFrame <!-- NOUN -->
- Display name: NorthEastTVDFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#CartesianThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## CylindricalReferenceFrame <!-- NOUN -->
- Display name: CylindricalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## SphericalReferenceFrame <!-- NOUN -->
- Display name: SphericalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## TwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: TwoDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## CartesianTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianTwoDimensionalReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## NorthEastFrame <!-- NOUN -->
- Display name: NorthEastFrame
- Parent class: [CartesianTwoDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#CartesianTwoDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
## PolarReferenceFrame <!-- NOUN -->
- Display name: PolarReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:


# VERBS
## HasCoordinates <!-- VERB -->
- Display name: HasCoordinates
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Description: 
- Examples: 
## HasReferenceFrame <!-- VERB -->
- Display name: HasReferenceFrame
- Subject class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Object class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Description: 
- Examples: 
## HasReferenceFrameOrigin <!-- VERB -->
- Display name: HasReferenceFrameOrigin
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
## IsPhysicallyLocatedAt <!-- VERB -->
- Display name: IsPhysicallyLocatedAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
