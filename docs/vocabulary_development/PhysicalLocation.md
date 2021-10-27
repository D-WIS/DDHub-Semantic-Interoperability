# Location <!-- NOUN -->
- Display name: Location
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Description: Physical location for a signal. 
Refers to:
 - a reference frame (via the HasReferenceFrame relation), that works as a system of coordinates
 - an origin (of type Location) via the HasReferenceFrameOrigin relation. 
 - some coordinates
- Examples:
# BitReferenceLocation <!-- NOUN -->
- Display name: BitReferenceLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Description: 
- Examples:
# CasingShoeLocation <!-- NOUN -->
- Display name: CasingShoeLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Description: 
- Examples:
# DrillFloorReferenceLocation <!-- NOUN -->
- Display name: DrillFloorReferenceLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Description: 
- Examples:
# HoleBottomLocation <!-- NOUN -->
- Display name: HoleBottomLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Description: 
- Examples:
# LWDLocation <!-- NOUN -->
- Display name: LWDLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Description: 
- Examples:
# ReferenceLocation <!-- NOUN -->
- Display name: ReferenceLocation
- Parent class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Attributes:
- Description: 
- Examples:
# ReferenceFrame <!-- NOUN -->
- Display name: ReferenceFrame
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Description: Represents a system of coordinates
- Examples:
# DepthAndAngleFrame <!-- NOUN -->
- Display name: DepthAndAngleFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Description: 
- Examples:
# FourDimensionalReferenceFrame <!-- NOUN -->
- Display name: FourDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Description: 
- Examples:
# CurviLinearFrenetSerretReferenceFrame <!-- NOUN -->
- Display name: CurviLinearFrenetSerretReferenceFrame
- Parent class: [FourDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#FourDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# OneDimensionalReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Description: 
- Examples:
# OneDimensionalCartesianReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCartesianReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# VerticalDepthFrame <!-- NOUN -->
- Display name: VerticalDepthFrame
- Parent class: [OneDimensionalCartesianReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCartesianReferenceFrame)
- Attributes:
- Description: 
- Examples:
# OneDimensionalCurviLinearReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCurviLinearReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# DrillStringCenterLineFrame <!-- NOUN -->
- Display name: DrillStringCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
  - PositiveUpward
    - Type: bool
    - Description: 
- Description: 
- Examples:
# OpenHoleCenterLineFrame <!-- NOUN -->
- Display name: OpenHoleCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
- Description: 
- Examples:
# WellboreCenterLineFrame <!-- NOUN -->
- Display name: WellboreCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
  - PositiveUpward
    - Type: bool
    - Description: 
- Description: 
- Examples:
# ThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: ThreeDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Description: 
- Examples:
# CartesianThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianThreeDimensionalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# FrenetSerretReferenceFrame <!-- NOUN -->
- Display name: FrenetSerretReferenceFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#CartesianThreeDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# NorthEastTVDFrame <!-- NOUN -->
- Display name: NorthEastTVDFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#CartesianThreeDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# CylindricalReferenceFrame <!-- NOUN -->
- Display name: CylindricalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# SphericalReferenceFrame <!-- NOUN -->
- Display name: SphericalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# TwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: TwoDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Attributes:
- Description: 
- Examples:
# CartesianTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianTwoDimensionalReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# NorthEastFrame <!-- NOUN -->
- Display name: NorthEastFrame
- Parent class: [CartesianTwoDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#CartesianTwoDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# PolarReferenceFrame <!-- NOUN -->
- Display name: PolarReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Attributes:
- Description: 
- Examples:
# HasCoordinates <!-- VERB -->
- Display name: HasCoordinates
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Description: 
- Examples: 
# HasReferenceFrame <!-- VERB -->
- Display name: HasReferenceFrame
- Subject class: [Location](#C:\temp\ddhubMD\PhysicalLocation.md#Location)
- Object class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Description: 
- Examples: 
# HasReferenceFrameOrigin <!-- VERB -->
- Display name: HasReferenceFrameOrigin
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsPhysicallyLocatedAt <!-- VERB -->
- Display name: IsPhysicallyLocatedAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
