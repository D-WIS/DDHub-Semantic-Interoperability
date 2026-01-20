- Description: this category contains the vocabulary necessary to specify the location of various items on a rig. Coordinate systems are the main element here.

# NOUNS
## Location <!-- NOUN -->
- Display name: Location
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Physical location for a signal. Refers to: 1) a reference frame (via the HasReferenceFrame relation), that works as a system of coordinates 2) an origin (of type Location) via the HasReferenceFrameOrigin relation. 
 - some coordinates
- Examples:
```dwis location
Location:location
location BelongsToClass Location
```
This example declares the Location reference location.
## VerticalReferenceLocation <!-- NOUN -->
- Display name: VerticalReferenceLocation
- Parent class: Location
- Attributes:
- Specialization:
- Description: Reference location for VerticalReferenceLocation.
- Examples:
```dwis verticalReferenceLocation
Location:verticalReferenceLocation
verticalReferenceLocation BelongsToClass VerticalReferenceLocation
```
This example declares the VerticalReferenceLocation reference location.
## WGS84VerticalLocation <!-- NOUN -->
- Display name: WGS84VerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for WGS84VerticalLocation.
- Examples:
```dwis wGS84VerticalLocation
Location:wGS84VerticalLocation
wGS84VerticalLocation BelongsToClass WGS84VerticalLocation
```
This example declares the WGS84VerticalLocation reference location.
## CasingFlangeVerticalLocation <!-- NOUN -->
- Display name: CasingFlangeVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for CasingFlangeVerticalLocation.
- Examples:
```dwis casingFlangeVerticalLocation
Location:casingFlangeVerticalLocation
casingFlangeVerticalLocation BelongsToClass CasingFlangeVerticalLocation
```
This example declares the CasingFlangeVerticalLocation reference location.
## CrownValveVerticalLocation <!-- NOUN -->
- Display name: CrownValveVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for CrownValveVerticalLocation.
- Examples:
```dwis crownValveVerticalLocation
Location:crownValveVerticalLocation
crownValveVerticalLocation BelongsToClass CrownValveVerticalLocation
```
This example declares the CrownValveVerticalLocation reference location.
## DerrickFloorVerticalLocation <!-- NOUN -->
- Display name: DerrickFloorVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for DerrickFloorVerticalLocation.
- Examples:
```dwis derrickFloorVerticalLocation
Location:derrickFloorVerticalLocation
derrickFloorVerticalLocation BelongsToClass DerrickFloorVerticalLocation
```
This example declares the DerrickFloorVerticalLocation reference location.
## KellyBushingVerticalLocation <!-- NOUN -->
- Display name: KellyBushingVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for KellyBushingVerticalLocation.
- Examples:
```dwis kellyBushingVerticalLocation
Location:kellyBushingVerticalLocation
kellyBushingVerticalLocation BelongsToClass KellyBushingVerticalLocation
```
This example declares the KellyBushingVerticalLocation reference location.
## RotaryTableVerticalLocation <!-- NOUN -->
- Display name: RotaryTableVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for RotaryTableVerticalLocation.
- Examples:
```dwis rotaryTableVerticalLocation
Location:rotaryTableVerticalLocation
rotaryTableVerticalLocation BelongsToClass RotaryTableVerticalLocation
```
This example declares the RotaryTableVerticalLocation reference location.
## StickUpHeightVerticalLocation <!-- NOUN -->
- Display name: StickUpHeightVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for StickUpHeightVerticalLocation.
- Examples:
```dwis stickUpHeightVerticalLocation
Location:stickUpHeightVerticalLocation
stickUpHeightVerticalLocation BelongsToClass StickUpHeightVerticalLocation
```
This example declares the StickUpHeightVerticalLocation reference location.
## MinDrillHeightVerticalLocation <!-- NOUN -->
- Display name: MinDrillHeightVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MinDrillHeightVerticalLocation.
- Examples:
```dwis minDrillHeightVerticalLocation
Location:minDrillHeightVerticalLocation
minDrillHeightVerticalLocation BelongsToClass MinDrillHeightVerticalLocation
```
This example declares the MinDrillHeightVerticalLocation reference location.
## WellHeadVerticalLocation <!-- NOUN -->
- Display name: WellHeadVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for WellHeadVerticalLocation.
- Examples:
```dwis wellHeadVerticalLocation
Location:wellHeadVerticalLocation
wellHeadVerticalLocation BelongsToClass WellHeadVerticalLocation
```
This example declares the WellHeadVerticalLocation reference location.
## GroundLevelVerticalLocation <!-- NOUN -->
- Display name: GroundLevelVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for GroundLevelVerticalLocation.
- Examples:
```dwis groundLevelVerticalLocation
Location:groundLevelVerticalLocation
groundLevelVerticalLocation BelongsToClass GroundLevelVerticalLocation
```
This example declares the GroundLevelVerticalLocation reference location.
## SeaFloorVerticalLocation <!-- NOUN -->
- Display name: SeaFloorVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for SeaFloorVerticalLocation.
- Examples:
```dwis seaFloorVerticalLocation
Location:seaFloorVerticalLocation
seaFloorVerticalLocation BelongsToClass SeaFloorVerticalLocation
```
This example declares the SeaFloorVerticalLocation reference location.
## LowestAstronomicalTideVerticalLocation <!-- NOUN -->
- Display name: LowestAstronomicalTideVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for LowestAstronomicalTideVerticalLocation.
- Examples:
```dwis lowestAstronomicalTideVerticalLocation
Location:lowestAstronomicalTideVerticalLocation
lowestAstronomicalTideVerticalLocation BelongsToClass LowestAstronomicalTideVerticalLocation
```
This example declares the LowestAstronomicalTideVerticalLocation reference location.
## MeanSeaLevelVerticalLocation <!-- NOUN -->
- Display name: MeanSeaLevelVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MeanSeaLevelVerticalLocation.
- Examples:
```dwis meanSeaLevelVerticalLocation
Location:meanSeaLevelVerticalLocation
meanSeaLevelVerticalLocation BelongsToClass MeanSeaLevelVerticalLocation
```
This example declares the MeanSeaLevelVerticalLocation reference location.
## MeanHigherHighWaterVerticalLocation <!-- NOUN -->
- Display name: MeanHigherHighWaterVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MeanHigherHighWaterVerticalLocation.
- Examples:
```dwis meanHigherHighWaterVerticalLocation
Location:meanHigherHighWaterVerticalLocation
meanHigherHighWaterVerticalLocation BelongsToClass MeanHigherHighWaterVerticalLocation
```
This example declares the MeanHigherHighWaterVerticalLocation reference location.
## MeanHighWaterVerticalLocation <!-- NOUN -->
- Display name: MeanHighWaterVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MeanHighWaterVerticalLocation.
- Examples:
```dwis meanHighWaterVerticalLocation
Location:meanHighWaterVerticalLocation
meanHighWaterVerticalLocation BelongsToClass MeanHighWaterVerticalLocation
```
This example declares the MeanHighWaterVerticalLocation reference location.
## MeanLowerLowWaterVerticalLocation <!-- NOUN -->
- Display name: MeanLowerLowWaterVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MeanLowerLowWaterVerticalLocation.
- Examples:
```dwis meanLowerLowWaterVerticalLocation
Location:meanLowerLowWaterVerticalLocation
meanLowerLowWaterVerticalLocation BelongsToClass MeanLowerLowWaterVerticalLocation
```
This example declares the MeanLowerLowWaterVerticalLocation reference location.
## MeanLowWaterVerticalLocation <!-- NOUN -->
- Display name: MeanLowWaterVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MeanLowWaterVerticalLocation.
- Examples:
```dwis meanLowWaterVerticalLocation
Location:meanLowWaterVerticalLocation
meanLowWaterVerticalLocation BelongsToClass MeanLowWaterVerticalLocation
```
This example declares the MeanLowWaterVerticalLocation reference location.
## MeanTideLevelVerticalLocation <!-- NOUN -->
- Display name: MeanTideLevelVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MeanTideLevelVerticalLocation.
- Examples:
```dwis meanTideLevelVerticalLocation
Location:meanTideLevelVerticalLocation
meanTideLevelVerticalLocation BelongsToClass MeanTideLevelVerticalLocation
```
This example declares the MeanTideLevelVerticalLocation reference location.
## KickOffVerticalLocation <!-- NOUN -->
- Display name: KickOffVerticalLocation
- Parent class: VerticalReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for KickOffVerticalLocation.
- Examples:
```dwis kickOffVerticalLocation
Location:kickOffVerticalLocation
kickOffVerticalLocation BelongsToClass KickOffVerticalLocation
```
This example declares the KickOffVerticalLocation reference location.
## PositionReferenceLocation <!-- NOUN -->
- Display name: PositionReferenceLocation
- Parent class: Location
- Attributes:
- Specialization:
- Description: Reference location for PositionReferenceLocation.
- Examples:
```dwis positionReferenceLocation
Location:positionReferenceLocation
positionReferenceLocation BelongsToClass PositionReferenceLocation
```
This example declares the PositionReferenceLocation reference location.
## WGS84PositionLocation <!-- NOUN -->
- Display name: WGS84PositionLocation
- Parent class: PositionReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for WGS84PositionLocation.
- Examples:
```dwis wGS84PositionLocation
Location:wGS84PositionLocation
wGS84PositionLocation BelongsToClass WGS84PositionLocation
```
This example declares the WGS84PositionLocation reference location.
## WellHeadPositionLocation <!-- NOUN -->
- Display name: WellHeadPositionLocation
- Parent class: PositionReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for WellHeadPositionLocation.
- Examples:
```dwis wellHeadPositionLocation
Location:wellHeadPositionLocation
wellHeadPositionLocation BelongsToClass WellHeadPositionLocation
```
This example declares the WellHeadPositionLocation reference location.
## ClusterPositionLocation <!-- NOUN -->
- Display name: ClusterPositionLocation
- Parent class: PositionReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for ClusterPositionLocation.
- Examples:
```dwis clusterPositionLocation
Location:clusterPositionLocation
clusterPositionLocation BelongsToClass ClusterPositionLocation
```
This example declares the ClusterPositionLocation reference location.
## LeaseLinePositionLocation <!-- NOUN -->
- Display name: LeaseLinePositionLocation
- Parent class: PositionReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for LeaseLinePositionLocation.
- Examples:
```dwis leaseLinePositionLocation
Location:leaseLinePositionLocation
leaseLinePositionLocation BelongsToClass LeaseLinePositionLocation
```
This example declares the LeaseLinePositionLocation reference location.
## AxialReferenceLocation <!-- NOUN -->
- Display name: AxialReferenceLocation
- Parent class: Location
- Attributes:
- Specialization:
- Description: Reference location for AxialReferenceLocation.
- Examples:
```dwis axialReferenceLocation
Location:axialReferenceLocation
axialReferenceLocation BelongsToClass AxialReferenceLocation
```
This example declares the AxialReferenceLocation reference location.
## BottomShoulderAxialLocation <!-- NOUN -->
- Display name: BottomShoulderAxialLocation
- Parent class: AxialReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for BottomShoulderAxialLocation.
- Examples:
```dwis bottomShoulderAxialLocation
Location:bottomShoulderAxialLocation
bottomShoulderAxialLocation BelongsToClass BottomShoulderAxialLocation
```
This example declares the BottomShoulderAxialLocation reference location.
## TopShoulderAxialLocation <!-- NOUN -->
- Display name: TopShoulderAxialLocation
- Parent class: AxialReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for TopShoulderAxialLocation.
- Examples:
```dwis topShoulderAxialLocation
Location:topShoulderAxialLocation
topShoulderAxialLocation BelongsToClass TopShoulderAxialLocation
```
This example declares the TopShoulderAxialLocation reference location.
## AbscissaReferenceLocation <!-- NOUN -->
- Display name: AbscissaReferenceLocation
- Parent class: Location
- Attributes:
- Specialization:
- Description: Reference location for AbscissaReferenceLocation.
- Examples:
```dwis abscissaReferenceLocation
Location:abscissaReferenceLocation
abscissaReferenceLocation BelongsToClass AbscissaReferenceLocation
```
This example declares the AbscissaReferenceLocation reference location.
## BottomOfStringReferenceLocation <!-- NOUN -->
- Display name: BottomOfStringReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for BottomOfStringReferenceLocation.
- Examples:
```dwis bottomOfStringReferenceLocation
Location:bottomOfStringReferenceLocation
bottomOfStringReferenceLocation BelongsToClass BottomOfStringReferenceLocation
```
This example declares the BottomOfStringReferenceLocation reference location.
```dwis 
DynamicDrillingSignal:lagDepth
PhysicalData:lagDepth#01
lagDepth#01 BelongsToClass ContinuousDataType
lagDepth#01 HasDynamicValue lagDepth
lagDepth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverage
lagDepth#01 IsTransformationOutput movingAverage
CuttingsComponent:cuttings
lagDepth#01 ConcernsAFluidComponent cuttings
BottomOfStringReferenceLocation:bos#01
ReturnFlowLine:returnFlowLine#01
lagDepth#01 IsDependentOn bos#01
lagDepth#01 IsDependentOn returnFlowLine#01
lagDepth#01 IsHydraulicallyLocatedAt returnFlowLine#01
```
This example defines a drilling data point as being the lag depth measured at the bottom of the drill string and dependent on the return flow line.
## TangencyLength<!-- NOUN -->
- Display name: Tangency length
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: the position along the drill-string, counted from the bit, from which we can consider that the pipes direction is tangential with the borehole direction.
- Examples: 
```dwis tangencyLengthExample
DrillStemMechanicalModel:stiffTorqueDragModel
MechanicalStiffModel:stiffModel
stiffTorqueDragModel IsOfMechanicalStiffnessType stiffModel
DynamicDrillingSignal:tangencyLengthSignal
DrillingDataPoint:tangencyLengthSignal_01
tangencyLengthSignal_01 BelongsToClass ContinuousDataType
tangencyLengthSignal_01 HasDynamicValue tangencyLengthSignal
tangencyLengthSignal_01 IsOfMeasurableQuantity LengthDrilling
tangencyLengthSignal_01 IsComputedBy stiffTorqueDragModel
TangencyLength:tangencyLengthLocation
tangencyLengthSignal_01 IsPhysicallyLocatedAt tangencyLengthLocation
```
This example defines a drilling data point as being the tangency length calculated by a stiff torque and drag model.
## RotatingDriveSystemLocation <!-- NOUN -->
- Display name: RotatingDriveSystemLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for rotating drive system, i.e., a generic denomination for the top-drive,
a power swivel, a rotary table with a kelly.
- Examples:
```dwis RotatingDriveSystemLocation
DynamicDrillingSignal:surfaceTorque
PhysicalData:surfaceTorque_01
ContinuousDataType:surfaceTorque_01
surfaceTorque_01 HasDynamicValue surfaceTorque
surfaceTorque_01 IsOfMeasurableQuantity TorqueDrilling
MovingAverage:movingAverage
surfaceTorque_01 IsTransformationOutput movingAverage
RotatingDriveSystemLocation:rotatingDriveSystem
surfaceTorque_01 IsPhysicallyLocatedAt rotatingDriveSystem
```
This example hows how the RotatingDriveSystemLocation is used to define a rotating drive system torque.
## TopOfStringReferenceLocation <!-- NOUN -->
- Display name: TopOfStringReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for TopOfStringReferenceLocation.
- Examples:
```dwis topOfStringReferenceLocation
Location:topOfStringReferenceLocation
topOfStringReferenceLocation BelongsToClass TopOfStringReferenceLocation
```
This example declares the TopOfStringReferenceLocation reference location.
```dwis surfaceROPExample
DynamicDrillingSignal:ROP
PhysicalData:ROP#01
ROP#01 BelongsToClass ContinuousDataType
ROP#01 HasDynamicValue ROP
ROP#01 IsOfMeasurableQuantity RateOfPenetrationDrilling
MovingAverage:movingAverage
ROP#01 IsTransformationOutput movingAverage
TopOfStringReferenceLocation:tos#01
ROP#01 IsPhysicallyLocatedAt tos#01
HoleBottomLocation:bh#01
ROP#01 IsDependentOn bh#01
```
This example defines a drilling data point as being the surface rate of penetration measured at the top of the drill string and dependent on the hole bottom location.
## ToolJoint1ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint1ReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for ToolJoint1ReferenceLocation.
- Examples:
```dwis toolJoint1ReferenceLocation
Location:toolJoint1ReferenceLocation
toolJoint1ReferenceLocation BelongsToClass ToolJoint1ReferenceLocation
```
This example declares the ToolJoint1ReferenceLocation reference location.
## ToolJoint2ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint2ReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for ToolJoint2ReferenceLocation.
- Examples:
```dwis toolJoint2ReferenceLocation
Location:toolJoint2ReferenceLocation
toolJoint2ReferenceLocation BelongsToClass ToolJoint2ReferenceLocation
```
This example declares the ToolJoint2ReferenceLocation reference location.
## ToolJoint3ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint3ReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for ToolJoint3ReferenceLocation.
- Examples:
```dwis toolJoint3ReferenceLocation
Location:toolJoint3ReferenceLocation
toolJoint3ReferenceLocation BelongsToClass ToolJoint3ReferenceLocation
```
This example declares the ToolJoint3ReferenceLocation reference location.
## ToolJoint4ReferenceLocation <!-- NOUN -->
- Display name: ToolJoint4ReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for ToolJoint4ReferenceLocation.
- Examples:
```dwis toolJoint4ReferenceLocation
Location:toolJoint4ReferenceLocation
toolJoint4ReferenceLocation BelongsToClass ToolJoint4ReferenceLocation
```
This example declares the ToolJoint4ReferenceLocation reference location.
## LastCasingShoeReferenceLocation <!-- NOUN -->
- Display name: LastCasingShoeReferenceLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for LastCasingShoeReferenceLocation.
- Examples:
```dwis lastCasingShoeReferenceLocation
Location:lastCasingShoeReferenceLocation
lastCasingShoeReferenceLocation BelongsToClass LastCasingShoeReferenceLocation
```
This example declares the LastCasingShoeReferenceLocation reference location.
## HoleBottomLocation <!-- NOUN -->
- Display name: HoleBottomLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for HoleBottomLocation.
- Examples:
```dwis holeBottomLocation
Location:holeBottomLocation
holeBottomLocation BelongsToClass HoleBottomLocation
```
This example declares the HoleBottomLocation reference location.
## TopOfRatHoleLocation <!-- NOUN -->
- Display name: TopOfRatHoleLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for TopOfRatHoleLocation.
- Examples:
```dwis topOfRatHoleLocation
Location:topOfRatHoleLocation
topOfRatHoleLocation BelongsToClass TopOfRatHoleLocation
```
This example declares the TopOfRatHoleLocation reference location.
## LedgeLocation <!-- NOUN -->
- Display name: LedgeLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for LedgeLocation.
- Examples:
```dwis ledgeLocation
Location:ledgeLocation
ledgeLocation BelongsToClass LedgeLocation
```
This example declares the LedgeLocation reference location.
## CuttingsBedLocation <!-- NOUN -->
- Display name: CuttingsBedLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for CuttingsBedLocation.
- Examples:
```dwis cuttingsBedLocation
Location:cuttingsBedLocation
cuttingsBedLocation BelongsToClass CuttingsBedLocation
```
This example declares the CuttingsBedLocation reference location.
## FormationFluidTransferLocation <!-- NOUN -->
- Display name: FormationFluidTransferLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for FormationFluidTransferLocation.
- Examples:
```dwis formationFluidTransferLocation
Location:formationFluidTransferLocation
formationFluidTransferLocation BelongsToClass FormationFluidTransferLocation
```
This example declares the FormationFluidTransferLocation reference location.
## DifferentialStickingLocation <!-- NOUN -->
- Display name: DifferentialStickingLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for DifferentialStickingLocation.
- Examples:
```dwis differentialStickingLocation
Location:differentialStickingLocation
differentialStickingLocation BelongsToClass DifferentialStickingLocation
```
This example declares the DifferentialStickingLocation reference location.
## FormationCollapseLocation <!-- NOUN -->
- Display name: FormationCollapseLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for FormationCollapseLocation.
- Examples:
```dwis formationCollapseLocation
Location:formationCollapseLocation
formationCollapseLocation BelongsToClass FormationCollapseLocation
```
This example declares the FormationCollapseLocation reference location.
## PipeWashoutLocation <!-- NOUN -->
- Display name: PipeWashoutLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for PipeWashoutLocation.
- Examples:
```dwis pipeWashoutLocation
Location:pipeWashoutLocation
pipeWashoutLocation BelongsToClass PipeWashoutLocation
```
This example declares the PipeWashoutLocation reference location.
## FormationWashoutLocation <!-- NOUN -->
- Display name: FormationWashoutLocation
- Parent class: AbscissaReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for FormationWashoutLocation.
- Examples:
```dwis formationWashoutLocation
Location:formationWashoutLocation
formationWashoutLocation BelongsToClass FormationWashoutLocation
```
This example declares the FormationWashoutLocation reference location.
## AngleReferenceLocation <!-- NOUN -->
- Display name: AngleReferenceLocation
- Parent class: Location
- Attributes:
- Specialization:
- Description: Reference location for AngleReferenceLocation.
- Examples:
```dwis angleReferenceLocation
Location:angleReferenceLocation
angleReferenceLocation BelongsToClass AngleReferenceLocation
```
This example declares the AngleReferenceLocation reference location.
## ScribeLineAngleLocation <!-- NOUN -->
- Display name: ScribeLineAngleLocation
- Parent class: AngleReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for ScribeLineAngleLocation.
- Examples:
```dwis scribeLineAngleLocation
Location:scribeLineAngleLocation
scribeLineAngleLocation BelongsToClass ScribeLineAngleLocation
```
This example declares the ScribeLineAngleLocation reference location.
## GravityHighSideAngleLocation <!-- NOUN -->
- Display name: GravityHighSideAngleLocation
- Parent class: AngleReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for GravityHighSideAngleLocation.
- Examples:
```dwis gravityHighSideAngleLocation
Location:gravityHighSideAngleLocation
gravityHighSideAngleLocation BelongsToClass GravityHighSideAngleLocation
```
This example declares the GravityHighSideAngleLocation reference location.
## MagneticHighSideAngleLocation <!-- NOUN -->
- Display name: MagneticHighSideAngleLocation
- Parent class: AngleReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MagneticHighSideAngleLocation.
- Examples:
```dwis magneticHighSideAngleLocation
Location:magneticHighSideAngleLocation
magneticHighSideAngleLocation BelongsToClass MagneticHighSideAngleLocation
```
This example declares the MagneticHighSideAngleLocation reference location.
## UpperSideAngleLocation <!-- NOUN -->
- Display name: UpperSideAngleLocation
- Parent class: AngleReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for UpperSideAngleLocation.
- Examples:
```dwis upperSideAngleLocation
Location:upperSideAngleLocation
upperSideAngleLocation BelongsToClass UpperSideAngleLocation
```
This example declares the UpperSideAngleLocation reference location.
## AzimuthReferenceLocation <!-- NOUN -->
- Display name: AzimuthReferenceLocation
- Parent class: Location
- Attributes:
- Specialization:
- Description: Reference location for AzimuthReferenceLocation.
- Examples:
```dwis azimuthReferenceLocation
Location:azimuthReferenceLocation
azimuthReferenceLocation BelongsToClass AzimuthReferenceLocation
```
This example declares the AzimuthReferenceLocation reference location.
## TrueNorthAzimuthLocation <!-- NOUN -->
- Display name: TrueNorthAzimuthLocation
- Parent class: AzimuthReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for TrueNorthAzimuthLocation.
- Examples:
```dwis trueNorthAzimuthLocation
Location:trueNorthAzimuthLocation
trueNorthAzimuthLocation BelongsToClass TrueNorthAzimuthLocation
```
This example declares the TrueNorthAzimuthLocation reference location.
## MagneticNorthAzimuthLocation <!-- NOUN -->
- Display name: MagneticNorthAzimuthLocation
- Parent class: AzimuthReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for MagneticNorthAzimuthLocation.
- Examples:
```dwis magneticNorthAzimuthLocation
Location:magneticNorthAzimuthLocation
magneticNorthAzimuthLocation BelongsToClass MagneticNorthAzimuthLocation
```
This example declares the MagneticNorthAzimuthLocation reference location.
## GridNorthAzimuthLocation <!-- NOUN -->
- Display name: GridNorthAzimuthLocation
- Parent class: AzimuthReferenceLocation
- Attributes:
- Specialization:
- Description: Reference location for GridNorthAzimuthLocation.
- Examples:
```dwis gridNorthAzimuthLocation
Location:gridNorthAzimuthLocation
gridNorthAzimuthLocation BelongsToClass GridNorthAzimuthLocation
```
This example declares the GridNorthAzimuthLocation reference location.
## Axis <!-- NOUN -->
- Display name: Axis
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Represents an axis in a coordinate system
- Examples:
```dwis AxisExample
Axis:axis
ReferenceFrame:referenceFrame
referenceFrame HasAxis axis
```
This example declares that a reference frame has an axis.
## XAxis <!-- NOUN -->
- Display name: XAxis
- Parent class: Axis
- Attributes:
- Specialization:
- Description: Represents the first axis in a coordinate system with at least one dimension
- Examples:
```dwis XAxisExample
XAxis:xAxis
ReferenceFrame:referenceFrame
referenceFrame HasAxis xAxis
DrillingDataPoint:xCoordinate
xCoordinate HasReferenceFrame referenceFrame
xCoordinate IsComponentAlongAxis xAxis
```
This example declares that a drilling data point has a reference frame and that it is a component along the x-axis.
```dwis MeasuredBendingMomentXExample
DynamicDrillingSignal:OmniViewMeasuredBendingMomentX
DirectMeasurement:OmniViewMeasuredBendingMomentX#01
OmniViewMeasuredBendingMomentX#01 BelongsToClass ContinuousDataType
OmniViewMeasuredBendingMomentX#01 HasDynamicValue OmniViewMeasuredBendingMomentX
OmniViewMeasuredBendingMomentX#01 IsOfMeasurableQuantity BendingMomentDrilling
TopSideTelemetry:topSideTelemetry
OmniViewMeasuredBendingMomentX#01 IsTransmittedBy topSideTelemetry
DynamicDrillingSignal:Sigma_OmniViewMeasuredBendingMomentX
DrillingDataPoint:Sigma_OmniViewMeasuredBendingMomentX#01
Sigma_OmniViewMeasuredBendingMomentX#01 BelongsToClass ContinuousDataType
Sigma_OmniViewMeasuredBendingMomentX#01 IsOfMeasurableQuantity BendingMomentDrilling
Sigma_OmniViewMeasuredBendingMomentX#01 HasDynamicValue Sigma_OmniViewMeasuredBendingMomentX
GaussianUncertainty:OmniViewMeasuredBendingMomentXGaussianUncertainty#01
OmniViewMeasuredBendingMomentX#01 HasUncertainty OmniViewMeasuredBendingMomentXGaussianUncertainty#01
OmniViewMeasuredBendingMomentXGaussianUncertainty#01 HasUncertaintyMean OmniViewMeasuredBendingMomentX#01
OmniViewMeasuredBendingMomentXGaussianUncertainty#01 HasUncertaintyStandardDeviation Sigma_OmniViewMeasuredBendingMomentX#01
XAxis:xAxis#01
OmniViewMeasuredBendingMomentX#01 IsComponentAlongAxis xAxis#01
SwivelSub:SwivelSub#01
OmniViewMeasuredBendingMomentX#01 IsMechanicallyLocatedAt SwivelSub#01
RotatingDriveSystemLocation:rotatingDriveSystem
OmniViewMeasuredBendingMomentX#01 IsPhysicallyLocatedAt rotatingDriveSystem
InstrumentationCompany:Petromar#01
OmniViewMeasuredBendingMomentX#01 IsProvidedBy Petromar#01
```
This example defines a drilling data point as being the x-component of the measured bending moment at the rotating drive system location.
## YAxis <!-- NOUN -->
- Display name: YAxis
- Parent class: Axis
- Attributes:
- Specialization:
- Description: Represents the second axis in a coordinate system with at least two dimensions
- Examples:
```dwis YAxisExample
YAxis:yAxis
ReferenceFrame:referenceFrame
referenceFrame HasAxis yAxis
DrillingDataPoint:yCoordinate
yCoordinate HasReferenceFrame referenceFrame
yCoordinate IsComponentAlongAxis yAxis
```
This example declares that a drilling data point has a reference frame and that it is a component along the y-axis.
```dwis MeasuredMagneticFieldYExample
DynamicDrillingSignal:OmniViewMeasuredMagneticFieldY
DirectMeasurement:OmniViewMeasuredMagneticFieldY#01
OmniViewMeasuredMagneticFieldY#01 BelongsToClass ContinuousDataType
OmniViewMeasuredMagneticFieldY#01 HasDynamicValue OmniViewMeasuredMagneticFieldY
OmniViewMeasuredMagneticFieldY#01 IsOfMeasurableQuantity EarthMagneticFluxDensity
TopSideTelemetry:topSideTelemetry
OmniViewMeasuredMagneticFieldY#01 IsTransmittedBy topSideTelemetry
DynamicDrillingSignal:Sigma_OmniViewMeasuredMagneticFieldY
DrillingDataPoint:Sigma_OmniViewMeasuredMagneticFieldY#01
Sigma_OmniViewMeasuredMagneticFieldY#01 BelongsToClass ContinuousDataType
Sigma_OmniViewMeasuredMagneticFieldY#01 IsOfMeasurableQuantity EarthMagneticFluxDensity
Sigma_OmniViewMeasuredMagneticFieldY#01 HasDynamicValue Sigma_OmniViewMeasuredMagneticFieldY
GaussianUncertainty:OmniViewMeasuredMagneticFieldYGaussianUncertainty#01
OmniViewMeasuredMagneticFieldY#01 HasUncertainty OmniViewMeasuredMagneticFieldYGaussianUncertainty#01
OmniViewMeasuredMagneticFieldYGaussianUncertainty#01 HasUncertaintyMean OmniViewMeasuredMagneticFieldY#01
OmniViewMeasuredMagneticFieldYGaussianUncertainty#01 HasUncertaintyStandardDeviation Sigma_OmniViewMeasuredMagneticFieldY#01
YAxis:yAxis#01
OmniViewMeasuredMagneticFieldY#01 IsComponentAlongAxis yAxis#01
SwivelSub:SwivelSub#01
OmniViewMeasuredMagneticFieldY#01 IsMechanicallyLocatedAt SwivelSub#01
RotatingDriveSystemLocation:rotatingDriveSystem
OmniViewMeasuredMagneticFieldY#01 IsPhysicallyLocatedAt rotatingDriveSystem
InstrumentationCompany:Petromar#01
OmniViewMeasuredMagneticFieldY#01 IsProvidedBy Petromar#011
```
This example defines a drilling data point as being the y-component of the measured magnetic field at the rotating drive system location.
## ZAxis <!-- NOUN -->
- Display name: ZAxis
- Parent class: Axis
- Attributes:
- Specialization:
- Description: Represents the third axis in a coordinate system with at least three dimensions
- Examples:
```dwis ZAxisExample
ZAxis:zAxis
ReferenceFrame:referenceFrame
referenceFrame HasAxis zAxis
DrillingDataPoint:zCoordinate
zCoordinate HasReferenceFrame referenceFrame
zCoordinate IsComponentAlongAxis zAxis
```
This example declares that a drilling data point has a reference frame and that it is a component along the z-axis.
## ReferenceFrame <!-- NOUN -->
- Display name: ReferenceFrame
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Represents a system of coordinates
- Examples:
```dwis referenceFrame
Location:referenceFrame
referenceFrame BelongsToClass ReferenceFrame
```
This example declares the ReferenceFrame reference location.
## OneDimensionalReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalReferenceFrame
- Parent class: ReferenceFrame
- Attributes:
  - PostiveUpward
    - Type: bool
    - Description: 
- Specialization:
- Description: Reference location for OneDimensionalReferenceFrame.
- Examples:
```dwis oneDimensionalReferenceFrame
Location:oneDimensionalReferenceFrame
oneDimensionalReferenceFrame BelongsToClass OneDimensionalReferenceFrame
```
This example declares the OneDimensionalReferenceFrame reference location.
## AngleReferenceFrame <!-- NOUN -->
- Display name: AngleReferenceFrame
- Parent class: OneDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference frame for angles.
- Examples:
```dwis angleReferenceFrame
Location:angleReferenceFrame
angleReferenceFrame BelongsToClass AngleReferenceFrame
```
This example declares the AngleReferenceFrame reference location.
## RadialReferenceFrame <!-- NOUN -->
- Display name: Radial Reference Frame
- Parent class: OneDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame for radial values.
- Examples:
```dwis RadialReferenceFrameExample
DrillingDataPoint:bitDiameter
RadialReferenceFrame:radialReferenceFrame
bitDiameter HasReferenceFrame radialReferenceFrame
```
This example declares bit diameter that is measured in a radial reference frame.
```dwis BitDiameterSignalExample
DynamicDrillingSignal:BitDiameter
PhysicalData:BitDiameter#01
BitDiameter#01 BelongsToClass ContinuousDataType
BitDiameter#01 HasDynamicValue BitDiameter
BitDiameter#01 IsOfMeasurableQuantity DiameterPipeDrilling
MovingAverage:movingAverage
BitDiameter#01 IsTransformationOutput movingAverage
RadialReferenceFrame:radialReferenceFrame#01
BitDiameter#01 HasReferenceFrame radialReferenceFrame#01
BottomOfStringReferenceLocation:bos#01
BitDiameter#01 IsPhysicallyLocatedAt bos#01
```
This example defines a drilling data point as being the bit diameter measured at the bottom of the drill string in a radial reference frame.
```dwis MeasuredAccelerationRadialExample
DynamicDrillingSignal:OmniViewMeasuredAccelerationRadial
DirectMeasurement:OmniViewMeasuredAccelerationRadial#01
OmniViewMeasuredAccelerationRadial#01 BelongsToClass ContinuousDataType
OmniViewMeasuredAccelerationRadial#01 HasDynamicValue OmniViewMeasuredAccelerationRadial
OmniViewMeasuredAccelerationRadial#01 IsOfMeasurableQuantity AccelerationDrilling
TopSideTelemetry:topSideTelemetry
OmniViewMeasuredAccelerationRadial#01 IsTransmittedBy topSideTelemetry
DynamicDrillingSignal:Sigma_OmniViewMeasuredAccelerationRadial
DrillingDataPoint:Sigma_OmniViewMeasuredAccelerationRadial#01
Sigma_OmniViewMeasuredAccelerationRadial#01 BelongsToClass ContinuousDataType
Sigma_OmniViewMeasuredAccelerationRadial#01 IsOfMeasurableQuantity AccelerationDrilling
Sigma_OmniViewMeasuredAccelerationRadial#01 HasDynamicValue Sigma_OmniViewMeasuredAccelerationRadial
GaussianUncertainty:OmniViewMeasuredAccelerationRadialGaussianUncertainty#01
OmniViewMeasuredAccelerationRadial#01 HasUncertainty OmniViewMeasuredAccelerationRadialGaussianUncertainty#01
OmniViewMeasuredAccelerationRadialGaussianUncertainty#01 HasUncertaintyMean OmniViewMeasuredAccelerationRadial#01
OmniViewMeasuredAccelerationRadialGaussianUncertainty#01 HasUncertaintyStandardDeviation Sigma_OmniViewMeasuredAccelerationRadial#01
RadialReferenceFrame:RadialReferenceFrame#01
OmniViewMeasuredAccelerationRadial#01 HasReferenceFrame RadialReferenceFrame#01
SwivelSub:SwivelSub#01
OmniViewMeasuredAccelerationRadial#01 IsMechanicallyLocatedAt SwivelSub#01
RotatingDriveSystemLocation:rotatingDriveSystem
OmniViewMeasuredAccelerationRadial#01 IsPhysicallyLocatedAt rotatingDriveSystem
InstrumentationCompany:Petromar#01
OmniViewMeasuredAccelerationRadial#01 IsProvidedBy Petromar#01
```
This example defines a drilling data point as being the radial component of the measured acceleration at the rotating drive system location.
## TangentialReferenceFrame <!-- NOUN -->
- Display name: Tangential Reference Frame
- Parent class: OneDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame for tangential values.
- Examples:
```dwis TangentialReferenceFrameExample
DrillingDataPoint:tangentialAcceleration
TangentialReferenceFrame:tangentialReferenceFrame
tangentialAcceleration HasReferenceFrame tangentialReferenceFrame
```
This example declares the tangentialAcceleration drilling data point is measured in a tangential reference frame.
```dwis MeasuredAccelerationTangentialExample
DynamicDrillingSignal:OmniViewMeasuredAccelerationTangential
DirectMeasurement:OmniViewMeasuredAccelerationTangential#01
OmniViewMeasuredAccelerationTangential#01 BelongsToClass ContinuousDataType
OmniViewMeasuredAccelerationTangential#01 HasDynamicValue OmniViewMeasuredAccelerationTangential
OmniViewMeasuredAccelerationTangential#01 IsOfMeasurableQuantity AccelerationDrilling
TopSideTelemetry:topSideTelemetry
OmniViewMeasuredAccelerationTangential#01 IsTransmittedBy topSideTelemetry
DynamicDrillingSignal:Sigma_OmniViewMeasuredAccelerationTangential
DrillingDataPoint:Sigma_OmniViewMeasuredAccelerationTangential#01
Sigma_OmniViewMeasuredAccelerationTangential#01 BelongsToClass ContinuousDataType
Sigma_OmniViewMeasuredAccelerationTangential#01 IsOfMeasurableQuantity AccelerationDrilling
Sigma_OmniViewMeasuredAccelerationTangential#01 HasDynamicValue Sigma_OmniViewMeasuredAccelerationTangential
GaussianUncertainty:OmniViewMeasuredAccelerationTangentialGaussianUncertainty#01
OmniViewMeasuredAccelerationTangential#01 HasUncertainty OmniViewMeasuredAccelerationTangentialGaussianUncertainty#01
OmniViewMeasuredAccelerationTangentialGaussianUncertainty#01 HasUncertaintyMean OmniViewMeasuredAccelerationTangential#01
OmniViewMeasuredAccelerationTangentialGaussianUncertainty#01 HasUncertaintyStandardDeviation Sigma_OmniViewMeasuredAccelerationTangential#01
TangentialReferenceFrame:TangentialReferenceFrame#01
OmniViewMeasuredAccelerationTangential#01 HasReferenceFrame TangentialReferenceFrame#01
SwivelSub:SwivelSub#01
OmniViewMeasuredAccelerationTangential#01 IsMechanicallyLocatedAt SwivelSub#01
RotatingDriveSystemLocation:rotatingDriveSystem
OmniViewMeasuredAccelerationTangential#01 IsPhysicallyLocatedAt rotatingDriveSystem
InstrumentationCompany:Petromar#01
```
This example defines a drilling data point as being the tangential component of the measured acceleration at the rotating drive system location.
## AxialReferenceFrame <!-- NOUN -->
- Display name: Axial Reference Frame
- Parent class: OneDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame for axial values.
- Examples:
```dwis AxialReferenceFrameExample
DrillingDataPoint:axialAcceleration
AxialReferenceFrame:axialReferenceFrame
axialAcceleration HasReferenceFrame axialReferenceFrame
```
This example declares the axialAcceleration drilling data point is measured in a axial reference frame.
```dwis MeasuredAccelerationAxialExample
DynamicDrillingSignal:OmniViewMeasuredAccelerationAxial
DirectMeasurement:OmniViewMeasuredAccelerationAxial#01
OmniViewMeasuredAccelerationAxial#01 BelongsToClass ContinuousDataType
OmniViewMeasuredAccelerationAxial#01 HasDynamicValue OmniViewMeasuredAccelerationAxial
OmniViewMeasuredAccelerationAxial#01 IsOfMeasurableQuantity AccelerationDrilling
TopSideTelemetry:topSideTelemetry
OmniViewMeasuredAccelerationAxial#01 IsTransmittedBy topSideTelemetry
DynamicDrillingSignal:Sigma_OmniViewMeasuredAccelerationAxial
DrillingDataPoint:Sigma_OmniViewMeasuredAccelerationAxial#01
Sigma_OmniViewMeasuredAccelerationAxial#01 BelongsToClass ContinuousDataType
Sigma_OmniViewMeasuredAccelerationAxial#01 IsOfMeasurableQuantity AccelerationDrilling
Sigma_OmniViewMeasuredAccelerationAxial#01 HasDynamicValue Sigma_OmniViewMeasuredAccelerationAxial
GaussianUncertainty:OmniViewMeasuredAccelerationAxialGaussianUncertainty#01
OmniViewMeasuredAccelerationAxial#01 HasUncertainty OmniViewMeasuredAccelerationAxialGaussianUncertainty#01
OmniViewMeasuredAccelerationAxialGaussianUncertainty#01 HasUncertaintyMean OmniViewMeasuredAccelerationAxial#01
OmniViewMeasuredAccelerationAxialGaussianUncertainty#01 HasUncertaintyStandardDeviation Sigma_OmniViewMeasuredAccelerationAxial#01
AxialReferenceFrame:AxialReferenceFrame#01
OmniViewMeasuredAccelerationAxial#01 HasReferenceFrame AxialReferenceFrame#01
SwivelSub:SwivelSub#01
OmniViewMeasuredAccelerationAxial#01 IsMechanicallyLocatedAt SwivelSub#01
RotatingDriveSystemLocation:rotatingDriveSystem
OmniViewMeasuredAccelerationAxial#01 IsPhysicallyLocatedAt rotatingDriveSystem
InstrumentationCompany:Petromar#01
OmniViewMeasuredAccelerationAxial#01 IsProvidedBy Petromar#01
```
This example defines a drilling data point as being the axial component of the measured acceleration at the rotating drive system location.
## OneDimensionalCartesianReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCartesianReferenceFrame
- Parent class: OneDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for OneDimensionalCartesianReferenceFrame.
- Examples:
```dwis oneDimensionalCartesianReferenceFrame
Location:oneDimensionalCartesianReferenceFrame
oneDimensionalCartesianReferenceFrame BelongsToClass OneDimensionalCartesianReferenceFrame
```
This example declares the OneDimensionalCartesianReferenceFrame reference location.
## HorizontalDirectionFrame <!-- NOUN -->
- Display name: HorizontalDirectionFrame
- Parent class: OneDimensionalCartesianReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame that is horizontal but without privileged azimuthal direction.
- Examples:
```dwis HorizontalDirectionFrameExample
DrillingDataPoint:horizontalLength
HorizontalDirectionFrame:horizontalDirectionFrame
horizontalLength HasReferenceFrame horizontalDirectionFrame
```
This example declares the horizontal length is a measure of the horizontal length of something.
## VerticalDirectionFrame <!-- NOUN -->
- Display name: VerticalDirectionFrame
- Parent class: OneDimensionalCartesianReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame that is vertical but without privileged upward or downward direction.
- Examples:
```dwis VerticalDirectionFrameExample
DrillingDataPoint:verticalHeight
VerticalDirectionFrame:verticalDirectionFrame
verticalHeight HasReferenceFrame verticalDirectionFrame
```
This example declares the value vertical height is a measure of the vertical height of something.
## VerticalDepthFrame <!-- NOUN -->
- Display name: VerticalDepthFrame
- Parent class: VerticalDirectionFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the downward vertical.
- Examples:
```dwis verticalDepthFrame
DrillingDataPoint:inclination
VerticalDepthFrame:verticalDepthFrame
inclination IsMeasuredFromReferenceFrame verticalDepthFrame
```
This example declares an inclination that is measured from the downward vertical.
```dwis VerticalDepthSignalExample
DynamicDrillingSignal:BOS_VerticalDepth
PhysicalData:BOS_VerticalDepth#01
BOS_VerticalDepth#01 BelongsToClass ContinuousDataType
BOS_VerticalDepth#01 HasDynamicValue BOS_VerticalDepth
BOS_VerticalDepth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverage
BOS_VerticalDepth#01 IsTransformationOutput movingAverage
VerticalDepthFrame:verticalDirection#01
BOS_VerticalDepth#01 HasReferenceFrame verticalDirection#01
BottomOfStringReferenceLocation:bos#01
BOS_VerticalDepth#01 IsPhysicallyLocatedAt bos#01
```
This example defines a drilling data point as being the vertical depth at the bottom of the drill string in a vertical depth reference frame.
## VerticalElevationFrame <!-- NOUN -->
- Display name: VerticalElevationFrame
- Parent class: VerticalDirectionFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the upward vertical.
- Examples:
```dwis verticalDepthFrame
DrillingDataPoint:toolface
VerticalElevationFrame:highSideReferenceFrame
toolface IsMeasuredFromReferenceFrame highSideReferenceFrame
```
This example declares an inclination that is measured from the downward vertical.
## NorthDirectionFrame <!-- NOUN -->
- Display name: NorthDirectionFrame
- Parent class: HorizontalDirectionFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the north direction.
- Examples:
```dwis NorthDirectionFrame
DrillingDataPoint:azimuth
NorthDirectionFrame:northDirectionFrame
azimuth IsMeasuredFromReferenceFrame northDirectionFrame
```
This example declares an azimuth that is measured from the north direction.
## EastDirectionFrame <!-- NOUN -->
- Display name: EastDirectionFrame
- Parent class: HorizontalDirectionFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the east direction.
- Examples:
```dwis EastDirectionFrameExample
DrillingDataPoint:eastCoordinate
EastDirectionFrame:eastDirectionFrame
eastCoordinate HasReferenceFrame eastDirectionFrame
```
This example declares an east coordinate is measured along the east direction.
## LengthDirectionFrame <!-- NOUN -->
- Display name: LengthDirectionFrame
- Parent class: OneDimensionalCartesianReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the length direction.
- Examples:
```dwis LengthDirectionFrameExample
DrillingDataPoint:length
LengthDirectionFrame:lengthDirectionFrame
length HasReferenceFrame lengthDirectionFrame
```
This example declares the value length is a measure of the length of something.
## WidthDirectionFrame <!-- NOUN -->
- Display name: WidthDirectionFrame
- Parent class: OneDimensionalCartesianReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the width direction.
- Examples:
```dwis WidthDirectionFrameExample
DrillingDataPoint:width
WidthDirectionFrame:widthDirectionFrame
width HasReferenceFrame widthDirectionFrame
```
This example declares the value width is a measure of the width of something.
## HeightDirectionFrame <!-- NOUN -->
- Display name: HeightDirectionFrame
- Parent class: OneDimensionalCartesianReferenceFrame
- Attributes:
- Specialization:
- Description: A reference frame that follows the height direction.
- Examples:
```dwis HeightDirectionFrameExample
DrillingDataPoint:height
HeightDirectionFrame:heightDirectionFrame
height HasReferenceFrame heightDirectionFrame
```
This example declares the value height is a measure of the height of something.
## OneDimensionalCurviLinearReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCurviLinearReferenceFrame
- Parent class: OneDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for OneDimensionalCurviLinearReferenceFrame.
- Examples:
```dwis oneDimensionalCurviLinearReferenceFrame
DynamicDrillingSignal:BH_depth
PhysicalData:BH_depth#01
BH_depth#01 BelongsToClass ContinuousDataType
BH_depth#01 HasDynamicValue BH_depth
BH_depth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverage
BH_depth#01 IsTransformationOutput movingAverage
OneDimensionalCurviLinearReferenceFrame:curvilinearAbscissaFrame#01
BH_depth#01 HasReferenceFrame curvilinearAbscissaFrame#01
HoleBottomLocation:bh#01
BH_depth#01 IsPhysicallyLocatedAt bh#01
```
This example defines a drilling data point as being the hole bottom depth measured in a curvilinear abscissa reference frame.
## DrillStringCenterLineFrame <!-- NOUN -->
- Display name: DrillStringCenterLineFrame
- Parent class: OneDimensionalCurviLinearReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for DrillStringCenterLineFrame.
- Examples:
```dwis drillStringCenterLineFrame
Location:drillStringCenterLineFrame
drillStringCenterLineFrame BelongsToClass DrillStringCenterLineFrame
```
This example declares the DrillStringCenterLineFrame reference location.
## WellboreCenterLineFrame <!-- NOUN -->
- Display name: WellboreCenterLineFrame
- Parent class: OneDimensionalCurviLinearReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for WellboreCenterLineFrame.
- Examples:
```dwis wellboreCenterLineFrame
Location:wellboreCenterLineFrame
wellboreCenterLineFrame BelongsToClass WellboreCenterLineFrame
```
This example declares the WellboreCenterLineFrame reference location.
## DepthAndAngleFrame <!-- NOUN -->
- Display name: DepthAndAngleFrame
- Parent class: ReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for DepthAndAngleFrame.
- Examples:
```dwis depthAndAngleFrame
Location:depthAndAngleFrame
depthAndAngleFrame BelongsToClass DepthAndAngleFrame
```
This example declares the DepthAndAngleFrame reference location.
## TwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: TwoDimensionalReferenceFrame
- Parent class: ReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for TwoDimensionalReferenceFrame.
- Examples:
```dwis twoDimensionalReferenceFrame
Location:twoDimensionalReferenceFrame
twoDimensionalReferenceFrame BelongsToClass TwoDimensionalReferenceFrame
```
This example declares the TwoDimensionalReferenceFrame reference location.
## CartesianTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianTwoDimensionalReferenceFrame
- Parent class: TwoDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for CartesianTwoDimensionalReferenceFrame.
- Examples:
```dwis cartesianTwoDimensionalReferenceFrame
Location:cartesianTwoDimensionalReferenceFrame
cartesianTwoDimensionalReferenceFrame BelongsToClass CartesianTwoDimensionalReferenceFrame
```
This example declares the CartesianTwoDimensionalReferenceFrame reference location.
## NorthEastFrame <!-- NOUN -->
- Display name: NorthEastFrame
- Parent class: CartesianTwoDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for NorthEastFrame.
- Examples:
```dwis northEastFrame
Location:northEastFrame
northEastFrame BelongsToClass NorthEastFrame
```
This example declares the NorthEastFrame reference location.
## PolarReferenceFrame <!-- NOUN -->
- Display name: PolarReferenceFrame
- Parent class: TwoDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for PolarReferenceFrame.
- Examples:
```dwis polarReferenceFrame
Location:polarReferenceFrame
polarReferenceFrame BelongsToClass PolarReferenceFrame
```
This example declares the PolarReferenceFrame reference location.
## RiemannianManifoldTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: RiemannianManifoldTwoDimensionalReferenceFrame
- Parent class: TwoDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for RiemannianManifoldTwoDimensionalReferenceFrame.
- Examples:
```dwis riemannianManifoldTwoDimensionalReferenceFrame
Location:riemannianManifoldTwoDimensionalReferenceFrame
riemannianManifoldTwoDimensionalReferenceFrame BelongsToClass RiemannianManifoldTwoDimensionalReferenceFrame
```
This example declares the RiemannianManifoldTwoDimensionalReferenceFrame reference location.
## ThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: ThreeDimensionalReferenceFrame
- Parent class: ReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for ThreeDimensionalReferenceFrame.
- Examples:
```dwis threeDimensionalReferenceFrame
Location:threeDimensionalReferenceFrame
threeDimensionalReferenceFrame BelongsToClass ThreeDimensionalReferenceFrame
```
This example declares the ThreeDimensionalReferenceFrame reference location.
## CartesianThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianThreeDimensionalReferenceFrame
- Parent class: ThreeDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for CartesianThreeDimensionalReferenceFrame.
- Examples:
```dwis cartesianThreeDimensionalReferenceFrame
Location:cartesianThreeDimensionalReferenceFrame
cartesianThreeDimensionalReferenceFrame BelongsToClass CartesianThreeDimensionalReferenceFrame
```
This example declares the CartesianThreeDimensionalReferenceFrame reference location.
## NorthEastTVDFrame <!-- NOUN -->
- Display name: NorthEastTVDFrame
- Parent class: CartesianThreeDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for NorthEastTVDFrame.
- Examples:
```dwis northEastTVDFrame
Location:northEastTVDFrame
northEastTVDFrame BelongsToClass NorthEastTVDFrame
```
This example declares the NorthEastTVDFrame reference location.
## FrenetSerretReferenceFrame <!-- NOUN -->
- Display name: FrenetSerretReferenceFrame
- Parent class: ThreeDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for FrenetSerretReferenceFrame.
- Examples:
```dwis frenetSerretReferenceFrame
Location:frenetSerretReferenceFrame
frenetSerretReferenceFrame BelongsToClass FrenetSerretReferenceFrame
```
This example declares the FrenetSerretReferenceFrame reference location.
## RiemannianManifoldThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: RiemannianManifoldThreeDimensionalReferenceFrame
- Parent class: ThreeDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for RiemannianManifoldThreeDimensionalReferenceFrame.
- Examples:
```dwis riemannianManifoldThreeDimensionalReferenceFrame
Location:riemannianManifoldThreeDimensionalReferenceFrame
riemannianManifoldThreeDimensionalReferenceFrame BelongsToClass RiemannianManifoldThreeDimensionalReferenceFrame
```
This example declares the RiemannianManifoldThreeDimensionalReferenceFrame reference location.
## CylindricalReferenceFrame <!-- NOUN -->
- Display name: CylindricalReferenceFrame
- Parent class: ThreeDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for CylindricalReferenceFrame.
- Examples:
```dwis cylindricalReferenceFrame
Location:cylindricalReferenceFrame
cylindricalReferenceFrame BelongsToClass CylindricalReferenceFrame
```
This example declares the CylindricalReferenceFrame reference location.
## SphericalReferenceFrame <!-- NOUN -->
- Display name: SphericalReferenceFrame
- Parent class: ThreeDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for SphericalReferenceFrame.
- Examples:
```dwis sphericalReferenceFrame
Location:sphericalReferenceFrame
sphericalReferenceFrame BelongsToClass SphericalReferenceFrame
```
This example declares the SphericalReferenceFrame reference location.
## FourDimensionalReferenceFrame <!-- NOUN -->
- Display name: FourDimensionalReferenceFrame
- Parent class: ReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for FourDimensionalReferenceFrame.
- Examples:
```dwis fourDimensionalReferenceFrame
Location:fourDimensionalReferenceFrame
fourDimensionalReferenceFrame BelongsToClass FourDimensionalReferenceFrame
```
This example declares the FourDimensionalReferenceFrame reference location.
## CartesianFourDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianFourDimensionalReferenceFrame
- Parent class: FourDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for CartesianFourDimensionalReferenceFrame.
- Examples:
```dwis cartesianFourDimensionalReferenceFrame
Location:cartesianFourDimensionalReferenceFrame
cartesianFourDimensionalReferenceFrame BelongsToClass CartesianFourDimensionalReferenceFrame
```
This example declares the CartesianFourDimensionalReferenceFrame reference location.
## RiemannianManifoldFourDimensionalReferenceFrame <!-- NOUN -->
- Display name: RiemannianManifoldFourDimensionalReferenceFrame
- Parent class: FourDimensionalReferenceFrame
- Attributes:
- Specialization:
- Description: Reference location for RiemannianManifoldFourDimensionalReferenceFrame.
- Examples:
```dwis riemannianManifoldFourDimensionalReferenceFrame
Location:riemannianManifoldFourDimensionalReferenceFrame
riemannianManifoldFourDimensionalReferenceFrame BelongsToClass RiemannianManifoldFourDimensionalReferenceFrame
```
This example declares the RiemannianManifoldFourDimensionalReferenceFrame reference location.

# VERBS
## HasCoordinates <!-- VERB -->
- Display name: HasCoordinates
- Parent verb: DWISVerb
- Subject class: Location
- Object class: DrillingDataPoint
- Description: Reference location for HasCoordinates.
- Examples: 
```dwis hasCoordinates
DrillingDataPoint:bitCoordinates
Location:bitLocation
bitLocation HasCoordinates bitCoordinates
```
This example ties bit location to its coordinate values.
## HasAxis <!-- VERB -->
- Display name: Has Axis
- Parent verb: DWISVerb
- Subject class: ReferenceFrame
- Object class: Axis
- Description: Associate an axis with a reference frame.
- Examples: 
```dwis HasAxis
Axis:axis
ReferenceFrame:referenceFrame
referenceFrame HasAxis axis
```
This example associates an axis to a reference frame.
## IsComponentAlongAxis <!-- VERB -->
- Display name: Is Component Along Axis
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Axis
- Description: Stipulate that a drilling data point is a component along an axis.
- Examples: 
```dwis IsComponentAlongAxis
XAxis:xAxis
DrillingDataPoint:xCoordinate
xCoordinate IsComponentAlongAxis xAxis
```
This example states that the drilling data point xCoordinate is a component along the xAxis.
## HasReferenceFrame <!-- VERB -->
- Display name: HasReferenceFrame
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: ReferenceFrame
- Description: Indicates the reference frame used to express a measurement.
- Examples: 
```dwis referenceFrameExample
DrillingDataPoint:bitDepth
ReferenceFrame:verticalDepthFrame
bitDepth HasReferenceFrame verticalDepthFrame
```
This example sets the reference frame for bit depth.
## HasReferenceFrameOrigin <!-- VERB -->
- Display name: HasReferenceFrameOrigin
- Parent verb: DWISVerb
- Subject class: ReferenceFrame
- Object class: Location
- Description: Specifies the origin location of a reference frame.
- Examples: 
```dwis frameOrigin
ReferenceFrame:verticalDepthFrame
Location:kellyBushing
verticalDepthFrame HasReferenceFrameOrigin kellyBushing
```
This example defines the kelly bushing as origin of the vertical depth frame.
## IsPhysicallyLocatedAt <!-- VERB -->
- Display name: IsPhysicallyLocatedAt
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: Location
- Description: Places an object at a given physical location.
- Examples: 
```dwis physicalLocationExample
DWISNoun:measurementSensor
Location:standpipeLocation
measurementSensor IsPhysicallyLocatedAt standpipeLocation
```
This example places a sensor at the standpipe location.
## IsMeasuredFromReferenceFrame <!-- VERB -->
- Display name: IsMeasuredFromReferenceFrame
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: ReferenceFrame
- Description: Indicates that the signal is measured from a given reference frame.
- Examples: 
```dwis IsMeasuredFromReferenceFrameExample
DrillingDataPoint:toolface
VerticalElevationFrame:highSideReferenceFrame
toolface IsMeasuredFromReferenceFrame highSideReferenceFrame
```
This example indicates that the toolface is measured from the high side reference frame.
```dwis InclinationSignalExample
DynamicDrillingSignal:BOS_Inclination
PhysicalData:BOS_Inclination#01
BOS_Inclination#01 BelongsToClass ContinuousDataType
BOS_Inclination#01 HasDynamicValue BOS_Inclination
BOS_Inclination#01 IsOfMeasurableQuantity PlaneAngleDrilling
VerticalDepthFrame:verticalDirection#01
BOS_Inclination#01 IsMeasuredFromReferenceFrame verticalDirection#01
MovingAverage:movingAverage
BOS_Inclination#01 IsTransformationOutput movingAverage
BottomOfStringReferenceLocation:bos#01
BOS_Inclination#01 IsPhysicallyLocatedAt bos#01
```
This example defines a drilling data point as being the inclination measured at the bottom of the drill string from the vertical depth reference frame.
