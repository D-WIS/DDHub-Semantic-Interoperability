# PhysicalLocation<!-- DEFINITION SET HEADER -->
- Description: 
this category contains the vocabulary necessary to specify the location of various items on a rig. Coordinate systems are the main element here.

# Nouns
## Class Inheritance for Nouns
Here is a class inheritance diagram for the nouns contained in this definition set.
```mermaid
classDiagram
DWISNoun <|-- Location
Location <|-- VerticalReferenceLocation
VerticalReferenceLocation <|-- WGS84VerticalLocation
VerticalReferenceLocation <|-- CasingFlangeVerticalLocation
VerticalReferenceLocation <|-- CrownValveVerticalLocation
VerticalReferenceLocation <|-- DerrickFloorVerticalLocation
VerticalReferenceLocation <|-- KellyBushingVerticalLocation
VerticalReferenceLocation <|-- RotaryTableVerticalLocation
VerticalReferenceLocation <|-- StickUpHeightVerticalLocation
VerticalReferenceLocation <|-- MinDrillHeightVerticalLocation
VerticalReferenceLocation <|-- WellHeadVerticalLocation
VerticalReferenceLocation <|-- GroundLevelVerticalLocation
VerticalReferenceLocation <|-- SeaFloorVerticalLocation
VerticalReferenceLocation <|-- LowestAstronomicalTideVerticalLocation
VerticalReferenceLocation <|-- MeanSeaLevelVerticalLocation
VerticalReferenceLocation <|-- MeanHigherHighWaterVerticalLocation
VerticalReferenceLocation <|-- MeanHighWaterVerticalLocation
VerticalReferenceLocation <|-- MeanLowerLowWaterVerticalLocation
VerticalReferenceLocation <|-- MeanLowWaterVerticalLocation
VerticalReferenceLocation <|-- MeanTideLevelVerticalLocation
VerticalReferenceLocation <|-- KickOffVerticalLocation
Location <|-- PositionReferenceLocation
PositionReferenceLocation <|-- WGS84PositionLocation
PositionReferenceLocation <|-- WellHeadPositionLocation
PositionReferenceLocation <|-- ClusterPositionLocation
PositionReferenceLocation <|-- LeaseLinePositionLocation
Location <|-- AxialReferenceLocation
AxialReferenceLocation <|-- BottomShoulderAxialLocation
AxialReferenceLocation <|-- TopShoulderAxialLocation
Location <|-- AbscissaReferenceLocation
AbscissaReferenceLocation <|-- BottomOfStringReferenceLocation
AbscissaReferenceLocation <|-- TopOfStringReferenceLocation
AbscissaReferenceLocation <|-- ToolJoint1ReferenceLocation
AbscissaReferenceLocation <|-- ToolJoint2ReferenceLocation
AbscissaReferenceLocation <|-- ToolJoint3ReferenceLocation
AbscissaReferenceLocation <|-- ToolJoint4ReferenceLocation
AbscissaReferenceLocation <|-- LastCasingShoeReferenceLocation
AbscissaReferenceLocation <|-- HoleBottomLocation
AbscissaReferenceLocation <|-- TopOfRatHoleLocation
AbscissaReferenceLocation <|-- LedgeLocation
AbscissaReferenceLocation <|-- CuttingsBedLocation
AbscissaReferenceLocation <|-- FormationFluidTransferLocation
AbscissaReferenceLocation <|-- DifferentialStickingLocation
AbscissaReferenceLocation <|-- FormationCollapseLocation
AbscissaReferenceLocation <|-- PipeWashoutLocation
AbscissaReferenceLocation <|-- FormationWashoutLocation
Location <|-- AngleReferenceLocation
AngleReferenceLocation <|-- ScribeLineAngleLocation
AngleReferenceLocation <|-- GravityHighSideAngleLocation
AngleReferenceLocation <|-- MagneticHighSideAngleLocation
AngleReferenceLocation <|-- UpperSideAngleLocation
Location <|-- AzimuthReferenceLocation
AzimuthReferenceLocation <|-- TrueNorthAzimuthLocation
AzimuthReferenceLocation <|-- MagneticNorthAzimuthLocation
AzimuthReferenceLocation <|-- GridNorthAzimuthLocation
DWISNoun <|-- ReferenceFrame
ReferenceFrame <|-- OneDimensionalReferenceFrame
OneDimensionalReferenceFrame <|-- AngleReferenceFrame
OneDimensionalReferenceFrame <|-- OneDimensionalCartesianReferenceFrame
OneDimensionalCartesianReferenceFrame <|-- VerticalDepthFrame
OneDimensionalReferenceFrame <|-- OneDimensionalCurviLinearReferenceFrame
OneDimensionalCurviLinearReferenceFrame <|-- DrillStringCenterLineFrame
OneDimensionalCurviLinearReferenceFrame <|-- WellboreCenterLineFrame
ReferenceFrame <|-- DepthAndAngleFrame
ReferenceFrame <|-- TwoDimensionalReferenceFrame
TwoDimensionalReferenceFrame <|-- CartesianTwoDimensionalReferenceFrame
CartesianTwoDimensionalReferenceFrame <|-- NorthEastFrame
TwoDimensionalReferenceFrame <|-- PolarReferenceFrame
TwoDimensionalReferenceFrame <|-- RiemannianManifoldTwoDimensionalReferenceFrame
ReferenceFrame <|-- ThreeDimensionalReferenceFrame
ThreeDimensionalReferenceFrame <|-- CartesianThreeDimensionalReferenceFrame
CartesianThreeDimensionalReferenceFrame <|-- NorthEastTVDFrame
ThreeDimensionalReferenceFrame <|-- FrenetSerretReferenceFrame
ThreeDimensionalReferenceFrame <|-- RiemannianManifoldThreeDimensionalReferenceFrame
ThreeDimensionalReferenceFrame <|-- CylindricalReferenceFrame
ThreeDimensionalReferenceFrame <|-- SphericalReferenceFrame
ReferenceFrame <|-- FourDimensionalReferenceFrame
FourDimensionalReferenceFrame <|-- CartesianFourDimensionalReferenceFrame
FourDimensionalReferenceFrame <|-- RiemannianManifoldFourDimensionalReferenceFrame
```
## Location <!-- NOUN -->
- Display name: Location
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Description: 
Physical location for a signal. Refers to: 1) a reference frame (via the HasReferenceFrame relation), that works as a system of coordinates 2) an origin (of type Location) via the HasReferenceFrameOrigin relation.
 - some coordinates
- Definition set: PhysicalLocation
## VerticalReferenceLocation <!-- NOUN -->
- Display name: VerticalReferenceLocation
- Parent class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## WGS84VerticalLocation <!-- NOUN -->
- Display name: WGS84VerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## CasingFlangeVerticalLocation <!-- NOUN -->
- Display name: CasingFlangeVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## CrownValveVerticalLocation <!-- NOUN -->
- Display name: CrownValveVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## DerrickFloorVerticalLocation <!-- NOUN -->
- Display name: DerrickFloorVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## KellyBushingVerticalLocation <!-- NOUN -->
- Display name: KellyBushingVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## RotaryTableVerticalLocation <!-- NOUN -->
- Display name: RotaryTableVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## StickUpHeightVerticalLocation <!-- NOUN -->
- Display name: StickUpHeightVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MinDrillHeightVerticalLocation <!-- NOUN -->
- Display name: MinDrillHeightVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## WellHeadVerticalLocation <!-- NOUN -->
- Display name: WellHeadVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## GroundLevelVerticalLocation <!-- NOUN -->
- Display name: GroundLevelVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## SeaFloorVerticalLocation <!-- NOUN -->
- Display name: SeaFloorVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## LowestAstronomicalTideVerticalLocation <!-- NOUN -->
- Display name: LowestAstronomicalTideVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MeanSeaLevelVerticalLocation <!-- NOUN -->
- Display name: MeanSeaLevelVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MeanHigherHighWaterVerticalLocation <!-- NOUN -->
- Display name: MeanHigherHighWaterVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MeanHighWaterVerticalLocation <!-- NOUN -->
- Display name: MeanHighWaterVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MeanLowerLowWaterVerticalLocation <!-- NOUN -->
- Display name: MeanLowerLowWaterVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MeanLowWaterVerticalLocation <!-- NOUN -->
- Display name: MeanLowWaterVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## MeanTideLevelVerticalLocation <!-- NOUN -->
- Display name: MeanTideLevelVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## KickOffVerticalLocation <!-- NOUN -->
- Display name: KickOffVerticalLocation
- Parent class: [VerticalReferenceLocation](./PhysicalLocation.md#VerticalReferenceLocation)
- Definition set: PhysicalLocation
## PositionReferenceLocation <!-- NOUN -->
- Display name: PositionReferenceLocation
- Parent class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## WGS84PositionLocation <!-- NOUN -->
- Display name: WGS84PositionLocation
- Parent class: [PositionReferenceLocation](./PhysicalLocation.md#PositionReferenceLocation)
- Definition set: PhysicalLocation
## WellHeadPositionLocation <!-- NOUN -->
- Display name: WellHeadPositionLocation
- Parent class: [PositionReferenceLocation](./PhysicalLocation.md#PositionReferenceLocation)
- Definition set: PhysicalLocation
## ClusterPositionLocation <!-- NOUN -->
- Display name: ClusterPositionLocation
- Parent class: [PositionReferenceLocation](./PhysicalLocation.md#PositionReferenceLocation)
- Definition set: PhysicalLocation
## LeaseLinePositionLocation <!-- NOUN -->
- Display name: LeaseLinePositionLocation
- Parent class: [PositionReferenceLocation](./PhysicalLocation.md#PositionReferenceLocation)
- Definition set: PhysicalLocation
## AxialReferenceLocation <!-- NOUN -->
- Display name: AxialReferenceLocation
- Parent class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## BottomShoulderAxialLocation <!-- NOUN -->
- Display name: BottomShoulderAxialLocation
- Parent class: [AxialReferenceLocation](./PhysicalLocation.md#AxialReferenceLocation)
- Definition set: PhysicalLocation
## TopShoulderAxialLocation <!-- NOUN -->
- Display name: TopShoulderAxialLocation
- Parent class: [AxialReferenceLocation](./PhysicalLocation.md#AxialReferenceLocation)
- Definition set: PhysicalLocation
## AbscissaReferenceLocation <!-- NOUN -->
- Display name: AbscissaReferenceLocation
- Parent class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## BottomOfStringReferenceLocation <!-- NOUN -->
- Display name: BottomOfStringReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## TopOfStringReferenceLocation <!-- NOUN -->
- Display name: TopOfStringReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## ToolJoint1ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint1ReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## ToolJoint2ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint2ReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## ToolJoint3ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint3ReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## ToolJoint4ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint4ReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## LastCasingShoeReferenceLocation <!-- NOUN -->
- Display name: LastCasingShoeReferenceLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## HoleBottomLocation <!-- NOUN -->
- Display name: HoleBottomLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## TopOfRatHoleLocation <!-- NOUN -->
- Display name: TopOfRatHoleLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## LedgeLocation <!-- NOUN -->
- Display name: LedgeLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## CuttingsBedLocation <!-- NOUN -->
- Display name: CuttingsBedLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## FormationFluidTransferLocation <!-- NOUN -->
- Display name: FormationFluidTransferLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## DifferentialStickingLocation <!-- NOUN -->
- Display name: DifferentialStickingLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## FormationCollapseLocation <!-- NOUN -->
- Display name: FormationCollapseLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## PipeWashoutLocation <!-- NOUN -->
- Display name: PipeWashoutLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## FormationWashoutLocation <!-- NOUN -->
- Display name: FormationWashoutLocation
- Parent class: [AbscissaReferenceLocation](./PhysicalLocation.md#AbscissaReferenceLocation)
- Definition set: PhysicalLocation
## AngleReferenceLocation <!-- NOUN -->
- Display name: AngleReferenceLocation
- Parent class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## ScribeLineAngleLocation <!-- NOUN -->
- Display name: ScribeLineAngleLocation
- Parent class: [AngleReferenceLocation](./PhysicalLocation.md#AngleReferenceLocation)
- Definition set: PhysicalLocation
## GravityHighSideAngleLocation <!-- NOUN -->
- Display name: GravityHighSideAngleLocation
- Parent class: [AngleReferenceLocation](./PhysicalLocation.md#AngleReferenceLocation)
- Definition set: PhysicalLocation
## MagneticHighSideAngleLocation <!-- NOUN -->
- Display name: MagneticHighSideAngleLocation
- Parent class: [AngleReferenceLocation](./PhysicalLocation.md#AngleReferenceLocation)
- Definition set: PhysicalLocation
## UpperSideAngleLocation <!-- NOUN -->
- Display name: UpperSideAngleLocation
- Parent class: [AngleReferenceLocation](./PhysicalLocation.md#AngleReferenceLocation)
- Definition set: PhysicalLocation
## AzimuthReferenceLocation <!-- NOUN -->
- Display name: AzimuthReferenceLocation
- Parent class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## TrueNorthAzimuthLocation <!-- NOUN -->
- Display name: TrueNorthAzimuthLocation
- Parent class: [AzimuthReferenceLocation](./PhysicalLocation.md#AzimuthReferenceLocation)
- Definition set: PhysicalLocation
## MagneticNorthAzimuthLocation <!-- NOUN -->
- Display name: MagneticNorthAzimuthLocation
- Parent class: [AzimuthReferenceLocation](./PhysicalLocation.md#AzimuthReferenceLocation)
- Definition set: PhysicalLocation
## GridNorthAzimuthLocation <!-- NOUN -->
- Display name: GridNorthAzimuthLocation
- Parent class: [AzimuthReferenceLocation](./PhysicalLocation.md#AzimuthReferenceLocation)
- Definition set: PhysicalLocation
## ReferenceFrame <!-- NOUN -->
- Display name: ReferenceFrame
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Description: 
Represents a system of coordinates
- Definition set: PhysicalLocation
## OneDimensionalReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalReferenceFrame
- Parent class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Attributes:
  - PostiveUpward
    - Type: bool
    - Description: 
- Definition set: PhysicalLocation
## AngleReferenceFrame <!-- NOUN -->
- Display name: AngleReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](./PhysicalLocation.md#OneDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## OneDimensionalCartesianReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCartesianReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](./PhysicalLocation.md#OneDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## VerticalDepthFrame <!-- NOUN -->
- Display name: VerticalDepthFrame
- Parent class: [OneDimensionalCartesianReferenceFrame](./PhysicalLocation.md#OneDimensionalCartesianReferenceFrame)
- Definition set: PhysicalLocation
## OneDimensionalCurviLinearReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCurviLinearReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](./PhysicalLocation.md#OneDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## DrillStringCenterLineFrame <!-- NOUN -->
- Display name: DrillStringCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](./PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Definition set: PhysicalLocation
## WellboreCenterLineFrame <!-- NOUN -->
- Display name: WellboreCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](./PhysicalLocation.md#OneDimensionalCurviLinearReferenceFrame)
- Definition set: PhysicalLocation
## DepthAndAngleFrame <!-- NOUN -->
- Display name: DepthAndAngleFrame
- Parent class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Definition set: PhysicalLocation
## TwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: TwoDimensionalReferenceFrame
- Parent class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Definition set: PhysicalLocation
## CartesianTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianTwoDimensionalReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](./PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## NorthEastFrame <!-- NOUN -->
- Display name: NorthEastFrame
- Parent class: [CartesianTwoDimensionalReferenceFrame](./PhysicalLocation.md#CartesianTwoDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## PolarReferenceFrame <!-- NOUN -->
- Display name: PolarReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](./PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## RiemannianManifoldTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: RiemannianManifoldTwoDimensionalReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](./PhysicalLocation.md#TwoDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## ThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: ThreeDimensionalReferenceFrame
- Parent class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Definition set: PhysicalLocation
## CartesianThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianThreeDimensionalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](./PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## NorthEastTVDFrame <!-- NOUN -->
- Display name: NorthEastTVDFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](./PhysicalLocation.md#CartesianThreeDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## FrenetSerretReferenceFrame <!-- NOUN -->
- Display name: FrenetSerretReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](./PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## RiemannianManifoldThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: RiemannianManifoldThreeDimensionalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](./PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## CylindricalReferenceFrame <!-- NOUN -->
- Display name: CylindricalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](./PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## SphericalReferenceFrame <!-- NOUN -->
- Display name: SphericalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](./PhysicalLocation.md#ThreeDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## FourDimensionalReferenceFrame <!-- NOUN -->
- Display name: FourDimensionalReferenceFrame
- Parent class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Definition set: PhysicalLocation
## CartesianFourDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianFourDimensionalReferenceFrame
- Parent class: [FourDimensionalReferenceFrame](./PhysicalLocation.md#FourDimensionalReferenceFrame)
- Definition set: PhysicalLocation
## RiemannianManifoldFourDimensionalReferenceFrame <!-- NOUN -->
- Display name: RiemannianManifoldFourDimensionalReferenceFrame
- Parent class: [FourDimensionalReferenceFrame](./PhysicalLocation.md#FourDimensionalReferenceFrame)
- Definition set: PhysicalLocation
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- HasCoordinates
DWISVerb <|-- HasReferenceFrame
DWISVerb <|-- HasReferenceFrameOrigin
DWISVerb <|-- IsPhysicallyLocatedAt
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
Location ||--o{ DrillingDataPoint : HasCoordinates
DrillingDataPoint ||--o{ ReferenceFrame : HasReferenceFrame
ReferenceFrame ||--o{ Location : HasReferenceFrameOrigin
DrillingDataPoint ||--o{ Location : IsPhysicallyLocatedAt
```
## HasCoordinates <!-- VERB -->
- Display name: HasCoordinates
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [Location](./PhysicalLocation.md#Location)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Definition set: PhysicalLocation
## HasReferenceFrame <!-- VERB -->
- Display name: HasReferenceFrame
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Definition set: PhysicalLocation
## HasReferenceFrameOrigin <!-- VERB -->
- Display name: HasReferenceFrameOrigin
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Object class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
## IsPhysicallyLocatedAt <!-- VERB -->
- Display name: IsPhysicallyLocatedAt
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Location](./PhysicalLocation.md#Location)
- Definition set: PhysicalLocation
