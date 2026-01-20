# Typical Semantic for Retrieving Standard Drilling Signals
These examples of semantic definitions are adapated to retrieve standard drilling signals used in the drilling industry.
Note that defining the semantics for these signals would typically differ.
## Bottom Of String Depth
```dwis BottomOfStringDepthExample
DynamicDrillingSignal:BOS_depth
PhysicalData:BOS_depth#01
BOS_depth#01 BelongsToClass ContinuousDataType
BOS_depth#01 HasDynamicValue BOS_depth
BOS_depth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverageBOS_depth
BOS_depth#01 IsTransformationOutput movingAverageBOS_depth
OneDimensionalCurviLinearReferenceFrame:curvilinearAbscissaFrame#01
BOS_depth#01 HasReferenceFrame curvilinearAbscissaFrame#01
BottomOfStringReferenceLocation:bos#01
BOS_depth#01 IsPhysicallyLocatedAt bos#01
```
This example defines the semantics for retrieving the Bottom Of String Depth drilling signal.
## Bottom Hole Depth
```dwis BottomHoleDepthExample
DynamicDrillingSignal:BH_depth
PhysicalData:BH_depth#01
BH_depth#01 BelongsToClass ContinuousDataType
BH_depth#01 HasDynamicValue BH_depth
BH_depth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverageBH_depth
BH_depth#01 IsTransformationOutput movingAverageBH_depth
OneDimensionalCurviLinearReferenceFrame:curvilinearAbscissaFrame#01
BH_depth#01 HasReferenceFrame curvilinearAbscissaFrame#01
HoleBottomLocation:bh#01
BH_depth#01 IsPhysicallyLocatedAt bh#01
```
This example defines the semantics for retrieving the Bottom Hole Depth drilling signal.
## Flowrate In
```dwis FlowrateInExample
DynamicDrillingSignal:Q_tos
PhysicalData:Q_tos#01
Q_tos#01 BelongsToClass ContinuousDataType
Q_tos#01 HasDynamicValue Q_tos
Q_tos#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
MovingAverage:movingAverageQ_tos
Q_tos#01 IsTransformationOutput movingAverageQ_tos
TopOfStringJunction:topOfStringJunction#01
HydraulicBranch:inletHydraulicBranch#01
topOfStringJunction#01 HasUpstreamBranch inletHydraulicBranch#01
Q_tos#01 IsAssociatedToHydraulicBranch inletHydraulicBranch#01
```
This example defines the semantics for retrieving the Flowrate In drilling signal.
## Flowrate Out
```dwis FlowrateOutExample
DynamicDrillingSignal:flowRateOut
PhysicalData:flowRateOut#01
flowRateOut#01 BelongsToClass ContinuousDataType
flowRateOut#01 HasDynamicValue flowRateOut
flowRateOut#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
MovingAverage:movingAverageFlowRateOut
flowRateOut#01 IsTransformationOutput movingAverageFlowRateOut
AnnulusOutletJunction:annulusOutletJunction#01
HydraulicBranch:outletHydraulicBranch#01
annulusOutletJunction#01 HasDownstreamBranch outletHydraulicBranch#01
flowRateOut#01 IsAssociatedToHydraulicBranch outletHydraulicBranch#01
```
This example defines the semantics for retrieving the Flowrate Out drilling signal.
## Flowrate Out Proportion
```dwis FlowrateOutProportionExample
DynamicDrillingSignal:flowRateOutProportion
PhysicalData:flowRateOutProportion#01
flowRateOutProportion#01 BelongsToClass ContinuousDataType
flowRateOutProportion#01 HasDynamicValue flowRateOutProportion
flowRateOutProportion#01 IsOfMeasurableQuantity ProportionStandard
MovingAverage:movingAverageFlowRateOutProportion
flowRateOutProportion#01 IsTransformationOutput movingAverageFlowRateOutProportion
AnnulusOutletJunction:annulusOutletJunction#01
HydraulicBranch:outletHydraulicBranch#01
annulusOutletJunction#01 HasDownstreamBranch outletHydraulicBranch#01
flowRateOutProportion#01 IsAssociatedToHydraulicBranch outletHydraulicBranch#01
```
This example defines the semantics for retrieving the Flowrate Out Proportion drilling signal.
## Block Position
```dwis BlockPositionExample
DynamicDrillingSignal:blockPosition
PhysicalData:blockPosition#01
blockPosition#01 BelongsToClass ContinuousDataType
blockPosition#01 HasDynamicValue blockPosition
blockPosition#01 IsOfMeasurableQuantity HeightDrilling
MovingAverage:movingAverageBlockPosition
blockPosition#01 IsTransformationOutput movingAverageBlockPosition
DrillPipeElevator:elevator#01
blockPosition#01 IsPhysicallyLocatedAt elevator#01
```
This example defines the semantics for retrieving the Block Position drilling signal.
## Drilling Fluid Density In
```dwis DrillingFluidDensityInExample
DynamicDrillingSignal:densityIn
PhysicalData:densityIn#01
densityIn#01 BelongsToClass ContinuousDataType
densityIn#01 HasDynamicValue densityIn
densityIn#01 IsOfMeasurableQuantity MassDensityDrilling
MovingAverage:movingAverageDensityIn
densityIn#01 IsTransformationOutput movingAverageDensityIn
TopOfStringJunction:topOfStringJunction#01
HydraulicBranch:inletHydraulicBranch#01
topOfStringJunction#01 HasUpstreamBranch inletHydraulicBranch#01
densityIn#01 IsAssociatedToHydraulicBranch inletHydraulicBranch#01
```
This example defines the semantics for retrieving the Drilling Fluid Density In drilling signal.
## Drilling Fluid Density Out
```dwis DrillingFluidDensityOutExample
DynamicDrillingSignal:densityOut
PhysicalData:densityOut#01
densityOut#01 BelongsToClass ContinuousDataType
densityOut#01 HasDynamicValue densityOut
densityOut#01 IsOfMeasurableQuantity MassDensityDrilling
MovingAverage:movingAverageDensityOut
densityOut#01 IsTransformationOutput movingAverageDensityOut
ReturnFlowLine:returnFlowLine#01
densityOut#01 IsPhysicallyLocatedAt returnFlowLine#01
AnnulusOutletJunction:annulusOutletJunction#01
HydraulicBranch:outletHydraulicBranch#01
annulusOutletJunction#01 HasDownstreamBranch outletHydraulicBranch#01
densityOut#01 IsAssociatedToHydraulicBranch outletHydraulicBranch#01
```
This example defines the semantics for retrieving the Drilling Fluid Density Out drilling signal.
## Downhole Equivalent Circulation Density
```dwis DownholeEquivalentCirculationDensityExample
DynamicDrillingSignal:downholeECD
PhysicalData:downholeECD#01
downholeECD#01 BelongsToClass ContinuousDataType
downholeECD#01 HasDynamicValue downholeECD
downholeECD#01 IsOfMeasurableQuantity MassDensityDrilling
Measurement:downholePressure#01
downholePressure#01 BelongsToClass ContinuousDataType
downholePressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageDownholeECD
downholePressure#01 IsTransformationOutput movingAverageDownholeECD
PressureToEquivalentDensityTransformation:pressureToDownholeECD
downholePressure#01 IsTransformationInput pressureToDownholeECD
downholeECD#01 IsTransformationOutput pressureToDownholeECD
DownholeHydraulicNetwork:downholeNetwork
BHAAnnular:bhaAnnulus
downholeNetwork HasBranchComponent bhaAnnulus
downholeECD#01 IsEquivalentCirculationDensityAt bhaAnnulus
downholePressure#01 IsPressureAt bhaAnnulus
HydraulicCirculationCondition:circulating
circulating IsHydraulicConditionFor bhaAnnulus
```
This example defines the semantics for retrieving the Downhole Equivalent Circulation Density drilling signal.
## Downhole Equivalent Static Density
```dwis DownholeEquivalentStaticDensityExample
DynamicDrillingSignal:downholeESD
PhysicalData:downholeESD#01
downholeESD#01 BelongsToClass ContinuousDataType
downholeESD#01 HasDynamicValue downholeESD
downholeESD#01 IsOfMeasurableQuantity MassDensityDrilling
Measurement:downholePressure#01
downholePressure#01 BelongsToClass ContinuousDataType
downholePressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageDownholeESD
downholePressure#01 IsTransformationOutput movingAverageDownholeESD
PressureToEquivalentDensityTransformation:pressureToDownholeESD
downholePressure#01 IsTransformationInput pressureToDownholeESD
downholeESD#01 IsTransformationOutput pressureToDownholeESD
DownholeHydraulicNetwork:downholeNetwork
BHAAnnular:bhaAnnulus
downholeNetwork HasBranchComponent bhaAnnulus
downholeESD#01 IsEquivalentCirculationDensityAt bhaAnnulus
downholePressure#01 IsPressureAt bhaAnnulus
HydraulicStaticCondition:static
static IsHydraulicConditionFor bhaAnnulus
```
This example defines the semantics for retrieving the Downhole Equivalent Static Density drilling signal.
## Active Pit Volume
```dwis ActivePitVolumeExample
DynamicDrillingSignal:activeVolume
PhysicalData:activeVolume#01
activeVolume#01 BelongsToClass ContinuousDataType
activeVolume#01 HasDynamicValue activeVolume
activeVolume#01 IsOfMeasurableQuantity VolumeDrilling
MovingAverage:movingAverageActiveVolume
activeVolume#01 IsTransformationOutput movingAverageActiveVolume
ActiveDrillingSystem:activeDrillingSystem#01
activeVolume#01 IsPhysicallyLocatedAt activeDrillingSystem#01
```
This example defines the semantics for retrieving the Active Pit Volume drilling signal.
## Stand Pipe Pressure
```dwis StandPipePressureExample
DynamicDrillingSignal:SPP
PhysicalData:SPP#01
SPP#01 BelongsToClass ContinuousDataType
SPP#01 HasDynamicValue SPP
SPP#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageSPP
SPP#01 IsTransformationOutput movingAverageSPP
MudStandpipe:standPipe#01
SPP#01 IsPhysicallyLocatedAt standPipe#01
```
This example defines the semantics for retrieving the Stand Pipe Pressure drilling signal.
## Downhole Gamma Ray
```dwis DownholeGammaRayExample
DynamicDrillingSignal:downholeGammaRay
PhysicalData:downholeGammaRay#01
downholeGammaRay#01 BelongsToClass ContinuousDataType
downholeGammaRay#01 HasDynamicValue downholeGammaRay
downholeGammaRay#01 IsOfMeasurableQuantity GammaRayIndexDrilling
MovingAverage:movingAverageDownholeGammaRay
downholeGammaRay#01 IsTransformationOutput movingAverageDownholeGammaRay
BHAAnnular:bhaAnnulus
downholeGammaRay#01 IsPhysicallyLocatedAt bhaAnnulus
```
This example defines the semantics for retrieving the Downhole Gamma Ray drilling signal.
## Surface Rate Of Penetration
```dwis SurfaceRateOfPenetrationExample
DynamicDrillingSignal:ROP
PhysicalData:ROP#01
ROP#01 BelongsToClass ContinuousDataType
ROP#01 HasDynamicValue ROP
ROP#01 IsOfMeasurableQuantity RateOfPenetrationDrilling
MovingAverage:movingAverageROP
ROP#01 IsTransformationOutput movingAverageROP
TopOfStringReferenceLocation:tos#01
ROP#01 IsPhysicallyLocatedAt tos#01
HoleBottomLocation:bh#01
ROP#01 IsDependentOn bh#01
```
This example defines the semantics for retrieving the Surface Rate Of Penetration drilling signal.
## Hook Load
```dwis HookLoadExample
DynamicDrillingSignal:hookLoad
PhysicalData:hookLoad#01
hookLoad#01 BelongsToClass ContinuousDataType
hookLoad#01 HasDynamicValue hookLoad
hookLoad#01 IsOfMeasurableQuantity HookLoadDrilling
MovingAverage:movingAverageHookLoad
hookLoad#01 IsTransformationOutput movingAverageHookLoad
Hook:hook#01
hookLoad#01 IsPhysicallyLocatedAt hook#01
```
This example defines the semantics for retrieving the Hook Load drilling signal.
## Rotating Drive System Torque
```dwis RotatingDriveSystemTorqueExample
DynamicDrillingSignal:surfaceTorque
PhysicalData:surfaceTorque#01
surfaceTorque#01 BelongsToClass ContinuousDataType
surfaceTorque#01 HasDynamicValue surfaceTorque
surfaceTorque#01 IsOfMeasurableQuantity TorqueDrilling
MovingAverage:movingAverageSurfaceTorque
surfaceTorque#01 IsTransformationOutput movingAverageSurfaceTorque
RotatingDriveSystemLocation:rotatingDriveSystem
surfaceTorque#01 IsPhysicallyLocatedAt rotatingDriveSystem
```
This example defines the semantics for retrieving the Rotating Drive System Torque drilling signal.
## Rotating Drive System Rotational Speed
```dwis RotatingDriveSystemRotationalSpeedExample
DynamicDrillingSignal:surfaceRotationalSpeed
PhysicalData:surfaceRotationalSpeed#01
surfaceRotationalSpeed#01 BelongsToClass ContinuousDataType
surfaceRotationalSpeed#01 HasDynamicValue surfaceRotationalSpeed
surfaceRotationalSpeed#01 IsOfMeasurableQuantity AngularVelocityDrilling
MovingAverage:movingAverageSurfaceRotationalSpeed
surfaceRotationalSpeed#01 IsTransformationOutput movingAverageSurfaceRotationalSpeed
RotatingDriveSystemLocation:rotatingDriveSystem
surfaceRotationalSpeed#01 IsPhysicallyLocatedAt rotatingDriveSystem
```
This example defines the semantics for retrieving the Rotating Drive System Rotational Speed drilling signal.
## Lag Depth
```dwis LagDepthExample
DynamicDrillingSignal:lagDepth
PhysicalData:lagDepth#01
lagDepth#01 BelongsToClass ContinuousDataType
lagDepth#01 HasDynamicValue lagDepth
lagDepth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverageLagDepth
lagDepth#01 IsTransformationOutput movingAverageLagDepth
CuttingsComponent:cuttings
lagDepth#01 ConcernsAFluidComponent cuttings
BottomOfStringReferenceLocation:bos#01
ReturnFlowLine:returnFlowLine#01
lagDepth#01 IsDependentOn bos#01
lagDepth#01 IsDependentOn returnFlowLine#01
lagDepth#01 IsHydraulicallyLocatedAt returnFlowLine#01
```
This example defines the semantics for retrieving the Lag Depth drilling signal.
## Lag Time
```dwis LagTimeExample
DynamicDrillingSignal:lagTime
PhysicalData:lagTime#01
lagTime#01 BelongsToClass ContinuousDataType
lagTime#01 HasDynamicValue lagTime
lagTime#01 IsOfMeasurableQuantity DurationDrilling
MovingAverage:movingAverageLagTime
lagTime#01 IsTransformationOutput movingAverageLagTime
CuttingsComponent:cuttings
lagTime#01 ConcernsAFluidComponent cuttings
BottomOfStringReferenceLocation:bos#01
ReturnFlowLine:returnFlowLine#01
lagTime#01 IsDependentOn bos#01
lagTime#01 IsDependentOn returnFlowLine#01
lagTime#01 IsHydraulicallyLocatedAt returnFlowLine#01
```
This example defines the semantics for retrieving the Lag Time drilling signal.
## Surface Weight On Bit
```dwis SurfaceWeightOnBitExample
DynamicDrillingSignal:WOB
PhysicalData:WOB#01
WOB#01 BelongsToClass ContinuousDataType
WOB#01 HasDynamicValue WOB
WOB#01 IsOfMeasurableQuantity WeightOnBitDrilling
MovingAverage:movingAverageWOB
WOB#01 IsTransformationOutput movingAverageWOB
TopOfStringReferenceLocation:tos#01
WOB#01 IsPhysicallyLocatedAt tos#01
BottomOfStringReferenceLocation:bos#01
HoleBottomLocation:bh#01
WOB#01 IsDependentOn bos#01
WOB#01 IsDependentOn bh#01
```
This example defines the semantics for retrieving the Surface Weight On Bit drilling signal.
## Gas Proportion Flow Out
```dwis GasProportionFlowOutExample
DynamicDrillingSignal:gasProportionFlowOutProportion
PhysicalData:gasProportionFlowOutProportion#01
gasProportionFlowOutProportion#01 BelongsToClass ContinuousDataType
gasProportionFlowOutProportion#01 HasDynamicValue gasProportionFlowOutProportion
gasProportionFlowOutProportion#01 IsOfMeasurableQuantity ProportionStandard
MovingAverage:movingAverageGasProportionFlowOutProportion
gasProportionFlowOutProportion#01 IsTransformationOutput movingAverageGasProportionFlowOutProportion
FlowLine:returnFlowLine#01
gasProportionFlowOutProportion#01 IsPhysicallyLocatedAt returnFlowLine#01
GasComponent:GasComponent#01
gasProportionFlowOutProportion#01 ConcernsAFluidComponent GasComponent#01
```
This example defines the semantics for retrieving the Gas Proportion Flow Out drilling signal.
## Bottom Of String Inclination
```dwis BottomOfStringInclinationExample
DynamicDrillingSignal:BOS_Inclination
PhysicalData:BOS_Inclination#01
BOS_Inclination#01 BelongsToClass ContinuousDataType
BOS_Inclination#01 HasDynamicValue BOS_Inclination
BOS_Inclination#01 IsOfMeasurableQuantity PlaneAngleDrilling
VerticalDepthFrame:verticalDirection#01
BOS_Inclination#01 IsMeasuredFromReferenceFrame verticalDirection#01
MovingAverage:movingAverageBOS_Inclination
BOS_Inclination#01 IsTransformationOutput movingAverageBOS_Inclination
BottomOfStringReferenceLocation:bos#01
BOS_Inclination#01 IsPhysicallyLocatedAt bos#01
```
This example defines the semantics for retrieving the Bottom Of String Inclination drilling signal.
## Bottom Of String Vertical Depth
```dwis BottomOfStringVerticalDepthExample
DynamicDrillingSignal:BOS_VerticalDepth
PhysicalData:BOS_VerticalDepth#01
BOS_VerticalDepth#01 BelongsToClass ContinuousDataType
BOS_VerticalDepth#01 HasDynamicValue BOS_VerticalDepth
BOS_VerticalDepth#01 IsOfMeasurableQuantity DepthDrilling
MovingAverage:movingAverageBOS_VerticalDepth
BOS_VerticalDepth#01 IsTransformationOutput movingAverageBOS_VerticalDepth
VerticalDepthFrame:verticalDirection#01
BOS_VerticalDepth#01 HasReferenceFrame verticalDirection#01
BottomOfStringReferenceLocation:bos#01
BOS_VerticalDepth#01 IsPhysicallyLocatedAt bos#01
```
This example defines the semantics for retrieving the Bottom Of String Vertical Depth drilling signal.
## Plastic Viscosity At Inlet
```dwis PlasticViscosityAtInletExample
DynamicDrillingSignal:PlasticViscosityInlet
PhysicalData:PlasticViscosityInlet#01
PlasticViscosityInlet#01 BelongsToClass ContinuousDataType
PlasticViscosityInlet#01 HasDynamicValue PlasticViscosityInlet
PlasticViscosityInlet#01 IsOfMeasurableQuantity DynamicViscosityDrilling
MovingAverage:movingAveragePlasticViscosityInlet
PlasticViscosityInlet#01 IsTransformationOutput movingAveragePlasticViscosityInlet
TopOfStringJunction:topOfStringJunction#01
HydraulicBranch:inletHydraulicBranch#01
topOfStringJunction#01 HasUpstreamBranch inletHydraulicBranch#01
PlasticViscosityInlet#01 IsAssociatedToHydraulicBranch inletHydraulicBranch#01
BinghamPlastic:BinghamPlasticFluid#01
BinghamPlasticFluid#01 HasPlasticViscosity PlasticViscosityInlet#01
```
This example defines the semantics for retrieving the Plastic Viscosity At Inlet drilling signal.
## Yield Point At Inlet
```dwis YieldPointAtInletExample
DynamicDrillingSignal:YieldPointInlet
PhysicalData:YieldPointInlet#01
YieldPointInlet#01 BelongsToClass ContinuousDataType
YieldPointInlet#01 HasDynamicValue YieldPointInlet
YieldPointInlet#01 IsOfMeasurableQuantity FluidShearStress
MovingAverage:movingAverageYieldPointInlet
YieldPointInlet#01 IsTransformationOutput movingAverageYieldPointInlet
TopOfStringJunction:topOfStringJunction#01
HydraulicBranch:inletHydraulicBranch#01
topOfStringJunction#01 HasUpstreamBranch inletHydraulicBranch#01
YieldPointInlet#01 IsAssociatedToHydraulicBranch inletHydraulicBranch#01
BinghamPlastic:BinghamPlasticFluid#01
BinghamPlasticFluid#01 HasYieldPoint YieldPointInlet#01
```
This example defines the semantics for retrieving the Yield Point At Inlet drilling signal.
## Bit Diameter
```dwis BitDiameterExample
DynamicDrillingSignal:BitDiameter
PhysicalData:BitDiameter#01
BitDiameter#01 BelongsToClass ContinuousDataType
BitDiameter#01 HasDynamicValue BitDiameter
BitDiameter#01 IsOfMeasurableQuantity DiameterPipeDrilling
MovingAverage:movingAverageBitDiameter
BitDiameter#01 IsTransformationOutput movingAverageBitDiameter
RadialReferenceFrame:RadialReferenceFrame#01
BitDiameter#01 HasReferenceFrame RadialReferenceFrame#01
BottomOfStringReferenceLocation:bos#01
BitDiameter#01 IsPhysicallyLocatedAt bos#01
```
This example defines the semantics for retrieving the Bit Diameter drilling signal.


