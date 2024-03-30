using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Nouns
{
public enum Enum
{
ActivableFunction,
RunnableFunction,
ProtectionFunction,
FDIRFunction,
SOEFunction,
ControllerFunction,
ProcedureFunction,
DataFlowNode,
Plan,
OperationalPlan,
DrillingProgram,
RigActionPlan,
ComputedState,
ProceduralState,
ProcessState,
PhysicalState,
ComputationUnit,
Advisor,
Simulator,
Controller,
ControlSystem,
DrawWorksControlSystem,
MudPumpsControlSystem,
TopDriveControlSystem,
BOPControlSystem,
RigChokeControlSystem,
MeasurementDevice,
Transformation,
DirectTransformation,
Aggregation,
ForceFromLoadPinsTransformation,
ForceToLoadTransformation,
MeasuredDepthToTrueVerticalDepthTransformation,
MeasuredDepthTranslation,
PressureToEquivalentDensityTransformation,
PressureToForceTransformation,
TorqueToForceTransformation,
SignalProcessingUnit,
Filter,
BandPassFilter,
HighPassFilter,
LowPassFilter,
MovingAverage,
MovingStandardDeviation,
MovingMin,
MovingMax,
NumberOfSampleMovingAverage,
TimeWindowMovingAverage,
TimeBasedTransformation,
Buffering,
Derivation,
Integration,
RangeExtraction,
NumberOfItemsRangeExtraction,
TimeWindowRangeExtraction,
Resampling,
TransmissionLine,
UserInterface,
DataProvider,
OperatingCompany,
ServiceCompany,
DirectionalServiceCompany,
DrillingFluidProvider,
LoggingServiceCompany,
CementingServiceCompany,
DataAnalysisServiceCompany,
DrillingContractor,
DWISInternalService,
Telemetry,
DownHoleTelemetry,
MudPulseTelemetry,
ElectromagneticTelemetry,
WiredPipeTelemetry,
TopSideTelemetry,
ValidityCondition,
ConnectedCondition,
EQ,
GT,
LT,
DrillingDataPoint,
PrototypeData,
ActiveVolume,
Azimuth,
BitDepth,
DensityIn,
DensityOut,
DownholeECD,
DownholePressure,
DownholeRPM,
DownholeTemperature,
DownholeTorque,
FlowRateIn,
FlowRateOut,
HoleDepth,
HookLoad,
HookPosition,
HookVelocity,
Inclination,
MeasuredDepth,
PumpRate,
ROP,
SPP,
SurfaceRPM,
SurfaceTorque,
TemperatureIn,
TemperatureOut,
TopOfStringPosition,
WOB,
PorePressure,
PorePressureGradient,
FracturingPressure,
FracturingPressureGradient,
CollapsePressure,
CollapsePressureGradient,
ShearRate,
ShearStress,
MinimumHorizontalStress,
MinimumHorizontalStressGradient,
OverburdenPressure,
OverburdenPressureGradient,
BOPOpening,
BOPPressure,
MPDChokeOpening,
MPDChokePressure,
MPDPumpRate,
MPDPumpFlowRate,
GasFlowRate,
BackPressurePumpPressure,
MechanicalSpecificEnergy,
ProcessData,
SetPoint,
Command,
Recommendation,
RecommendedTarget,
RecommendedMinimum,
RecommendedMaximum,
Advice,
AdvisedTarget,
AdvisedMinimum,
AdvisedMaximum,
Limit,
MinimumLimit,
MaximumLimit,
PhysicalData,
Measurement,
DerivedMeasurement,
CorrectedMeasurement,
ComputedData,
DrillingSignal,
DynamicDrillingSignal,
DrillingEquipment,
Pit,
ActivePit,
ReservePit,
SlugPit,
TripTank,
AnnulusTerminator,
Riser,
MarineRiser,
SurfaceRiser,
LowPressureRiser,
HighPressureRiser,
SlipJoint,
BellNipple,
Diverter,
FlowLine,
BlowOutPreventerStack,
BlowOutPreventerElement,
AnnularPreventer,
BOPRam,
BOPShearRam,
DrillStemTerminator,
Bit,
BullNose,
CasingShoe,
Dolly,
DollyRail,
DrillLine,
ActiveLine,
DeadLine,
SupportLine,
DrillLineFastener,
DeadLineAnchor,
DrawWorks,
RackAndPinionHoistingSystem,
RamHoistingSystem,
DrillStem,
DrillString,
CasingString,
Liner,
TubingString,
ScreenString,
CoiledTubing,
Elevator,
GateValve,
Choke,
RigChoke,
MPDChoke,
MechanicalBlock,
CrownBlock,
TravellingBlock,
Pump,
CementPump,
MudPump,
BoosterPump,
BackPressurePump,
ShaleShakers,
Slips,
SurfacePipe,
StandPipe,
MudHose,
ThreeWayManifold,
ThreeWayValve,
ThreeWayValveInternalValve,
StringRotationSystem,
RotaryTable,
Kelly,
TopDrive,
TopDriveBody,
TopDriveHook,
TopDriveShaft,
HoleEnlargementElement,
UnderReamer,
HoleOpener,
HoistingSystem,
Rig,
Sea,
Ground,
DWISNoun,
DataEndPoint,
WitsMLTimeBasedLogEndPoint,
EndPointMapping,
HydraulicElementState,
HydraulicConnectedState,
HydraulicLogicalElement,
HydraulicBranch,
Annular,
BHAAnnular,
DrillPipesAnnular,
OpenChannel,
RectangularChannel,
SemiCircularChannel,
Pipe,
BHAInner,
DrillPipesInner,
OpenHole,
ReturnFlowLine,
HydraulicJunction,
Tank,
MudMixing,
HydraulicNetwork,
DownholeHydraulicNetwork,
TopsideHydraulicNetwork,
FluidComponent,
LiquidComponent,
FormationLiquidComponent,
DrillingFluidLiquidComponent,
DrillingFluidOilComponent,
DrillingFluidWaterComponent,
GasComponent,
FormationGasComponent,
DrillingFluidGasComponent,
SolidComponent,
DrillingFluidSolidComponent,
HighGravitySolidComponent,
LowGravitySolidComponent,
FormationSolidComponent,
CuttingsComponent,
CavingsComponent,
DrillStemMechanicalModel,
MechanicalStiffnessType,
MechanicalSoftModel,
MechanicalStiffModel,
MechanicalStiffModelAssumedContacts,
MechanicalStiffModelEstimatedContacts,
TangencyLength,
MechanicalElementState,
MechanicallyClosedState,
MechanicallyConnectedState,
MechanicalLogicalElement,
MathematicalModel,
SteadyStateModel,
TransientModel,
ModelledDegreeOfFreedom,
AxialModelling,
RotationalModelling,
LateralModelling,
RadialModelling,
AngularLateralModelling,
TangentialModelling,
VerticalOndulationModelling,
HorizontalOndulationModelling,
ModellingDimensions,
OneDModelling,
TwoDModelling,
ThreeDModelling,
ModellingDiscretization,
BoundaryDiscretization,
StrainWaveBasedDiscretization,
MassTransferBasedDiscretization,
Location,
VerticalReferenceLocation,
WGS84VerticalLocation,
CasingFlangeVerticalLocation,
CrownValveVerticalLocation,
DerrickFloorVerticalLocation,
KellyBushingVerticalLocation,
RotaryTableVerticalLocation,
WellHeadVerticalLocation,
GroundLevelVerticalLocation,
SeaFloorVerticalLocation,
LowestAstronomicalTideVerticalLocation,
MeanSeaLevelVerticalLocation,
MeanHigherHighWaterVerticalLocation,
MeanHighWaterVerticalLocation,
MeanLowerLowWaterVerticalLocation,
MeanLowWaterVerticalLocation,
MeanTideLevelVerticalLocation,
KickOffVerticalLocation,
PositionReferenceLocation,
WGS84PositionLocation,
WellHeadPositionLocation,
ClusterPositionLocation,
LeaseLinePositionLocation,
AxialReferenceLocation,
BottomShoulderAxialLocation,
TopShoulderAxialLocation,
AbscissaReferenceLocation,
BottomOfStringReferenceLocation,
TopOfStringReferenceLocation,
LastCasingShoeReferenceLocation,
HoleBottomLocation,
TopOfRatHoleLocation,
LedgeLocation,
CuttingsBedLocation,
FormationFluidTransferLocation,
DifferentialStickingLocation,
FormationCollapseLocation,
PipeWashoutLocation,
FormationWashoutLocation,
AngleReferenceLocation,
ScribeLineAngleLocation,
GravityHighSideAngleLocation,
MagneticHighSideAngleLocation,
UpperSideAngleLocation,
AzimuthReferenceLocation,
TrueNorthAzimuthLocation,
MagneticNorthAzimuthLocation,
GridNorthAzimuthLocation,
ReferenceFrame,
OneDimensionalReferenceFrame,
AngleReferenceFrame,
OneDimensionalCartesianReferenceFrame,
VerticalDepthFrame,
OneDimensionalCurviLinearReferenceFrame,
DrillStringCenterLineFrame,
WellboreCenterLineFrame,
DepthAndAngleFrame,
TwoDimensionalReferenceFrame,
CartesianTwoDimensionalReferenceFrame,
NorthEastFrame,
PolarReferenceFrame,
RiemannianManifoldTwoDimensionalReferenceFrame,
ThreeDimensionalReferenceFrame,
CartesianThreeDimensionalReferenceFrame,
NorthEastTVDFrame,
FrenetSerretReferenceFrame,
RiemannianManifoldThreeDimensionalReferenceFrame,
CylindricalReferenceFrame,
SphericalReferenceFrame,
FourDimensionalReferenceFrame,
CartesianFourDimensionalReferenceFrame,
RiemannianManifoldFourDimensionalReferenceFrame,
MeasurableQuantity,
BitTorqueQuantity,
BlockAccelerationQuantity,
BlockPositionQuantity,
BlockVelocityQuantity,
DepthQuantity,
DownholePressureQuantity,
EMWQuantity,
FlowRateQuantity,
FluidDensityInQuantity,
FluidTemperatureInQuantity,
FormationPorosityQuantity,
HookloadQuantity,
PumpRateQuantity,
Resistivity,
RockDensityQuantity,
SPPQuantity,
SurfaceRPMQuantity,
SurfaceTorqueQuantity,
TopOfStringForceQuantity,
TVDQuantity,
WOBQuantity,
MeasurableQuantityUnitAssociation,
Quantity,
AccelerationQuantity,
AreaQuantity,
ElectricResistivityQuantity,
ForceQuantity,
FrequencyQuantity,
LengthQuantity,
MassDensityQuantity,
MassQuantity,
MassRate,
PowerQuantity,
PressureQuantity,
ProportionQuantity,
TemperatureQuantity,
TorqueQuantity,
VelocityQuantity,
VolumeQuantity,
VolumetricRateQuantity,
VolumetricFlowateRateOfChangeQuantity,
Unit,
UnitSystem,
Clock,
SynchronizationGroup,
SignalUncertainty,
GaussianUncertainty,
GenericUncertainty,
MinMaxUncertainty,
FullScaleUncertainty,
SensorUncertainty
}
	public static string ActivableFunction = "ActivableFunction";
	public static string RunnableFunction = "RunnableFunction";
	public static string ProtectionFunction = "ProtectionFunction";
	public static string FDIRFunction = "FDIRFunction";
	public static string SOEFunction = "SOEFunction";
	public static string ControllerFunction = "ControllerFunction";
	public static string ProcedureFunction = "ProcedureFunction";
	public static string DataFlowNode = "DataFlowNode";
	public static string Plan = "Plan";
	public static string OperationalPlan = "OperationalPlan";
	public static string DrillingProgram = "DrillingProgram";
	public static string RigActionPlan = "RigActionPlan";
	public static string ComputedState = "ComputedState";
	public static string ProceduralState = "ProceduralState";
	public static string ProcessState = "ProcessState";
	public static string PhysicalState = "PhysicalState";
	public static string ComputationUnit = "ComputationUnit";
	public static string Advisor = "Advisor";
	public static string Simulator = "Simulator";
	public static string Controller = "Controller";
	public static string ControlSystem = "ControlSystem";
	public static string DrawWorksControlSystem = "DrawWorksControlSystem";
	public static string MudPumpsControlSystem = "MudPumpsControlSystem";
	public static string TopDriveControlSystem = "TopDriveControlSystem";
	public static string BOPControlSystem = "BOPControlSystem";
	public static string RigChokeControlSystem = "RigChokeControlSystem";
	public static string MeasurementDevice = "MeasurementDevice";
	public static string Transformation = "Transformation";
	public static string DirectTransformation = "DirectTransformation";
	public static string Aggregation = "Aggregation";
	public static string ForceFromLoadPinsTransformation = "ForceFromLoadPinsTransformation";
	public static string ForceToLoadTransformation = "ForceToLoadTransformation";
	public static string MeasuredDepthToTrueVerticalDepthTransformation = "MeasuredDepthToTrueVerticalDepthTransformation";
	public static string MeasuredDepthTranslation = "MeasuredDepthTranslation";
	public static string PressureToEquivalentDensityTransformation = "PressureToEquivalentDensityTransformation";
	public static string PressureToForceTransformation = "PressureToForceTransformation";
	public static string TorqueToForceTransformation = "TorqueToForceTransformation";
	public static string SignalProcessingUnit = "SignalProcessingUnit";
	public static string Filter = "Filter";
	public static string BandPassFilter = "BandPassFilter";
	public static string HighPassFilter = "HighPassFilter";
	public static string LowPassFilter = "LowPassFilter";
	public static string MovingAverage = "MovingAverage";
	public static string MovingStandardDeviation = "MovingStandardDeviation";
	public static string MovingMin = "MovingMin";
	public static string MovingMax = "MovingMax";
	public static string NumberOfSampleMovingAverage = "NumberOfSampleMovingAverage";
	public static string TimeWindowMovingAverage = "TimeWindowMovingAverage";
	public static string TimeBasedTransformation = "TimeBasedTransformation";
	public static string Buffering = "Buffering";
	public static string Derivation = "Derivation";
	public static string Integration = "Integration";
	public static string RangeExtraction = "RangeExtraction";
	public static string NumberOfItemsRangeExtraction = "NumberOfItemsRangeExtraction";
	public static string TimeWindowRangeExtraction = "TimeWindowRangeExtraction";
	public static string Resampling = "Resampling";
	public static string TransmissionLine = "TransmissionLine";
	public static string UserInterface = "UserInterface";
	public static string DataProvider = "DataProvider";
	public static string OperatingCompany = "OperatingCompany";
	public static string ServiceCompany = "ServiceCompany";
	public static string DirectionalServiceCompany = "DirectionalServiceCompany";
	public static string DrillingFluidProvider = "DrillingFluidProvider";
	public static string LoggingServiceCompany = "LoggingServiceCompany";
	public static string CementingServiceCompany = "CementingServiceCompany";
	public static string DataAnalysisServiceCompany = "DataAnalysisServiceCompany";
	public static string DrillingContractor = "DrillingContractor";
	public static string DWISInternalService = "DWISInternalService";
	public static string Telemetry = "Telemetry";
	public static string DownHoleTelemetry = "DownHoleTelemetry";
	public static string MudPulseTelemetry = "MudPulseTelemetry";
	public static string ElectromagneticTelemetry = "ElectromagneticTelemetry";
	public static string WiredPipeTelemetry = "WiredPipeTelemetry";
	public static string TopSideTelemetry = "TopSideTelemetry";
	public static string ValidityCondition = "ValidityCondition";
	public static string ConnectedCondition = "ConnectedCondition";
	public static string EQ = "EQ";
	public static string GT = "GT";
	public static string LT = "LT";
	public static string DrillingDataPoint = "DrillingDataPoint";
	public static string PrototypeData = "PrototypeData";
	public static string ActiveVolume = "ActiveVolume";
	public static string Azimuth = "Azimuth";
	public static string BitDepth = "BitDepth";
	public static string DensityIn = "DensityIn";
	public static string DensityOut = "DensityOut";
	public static string DownholeECD = "DownholeECD";
	public static string DownholePressure = "DownholePressure";
	public static string DownholeRPM = "DownholeRPM";
	public static string DownholeTemperature = "DownholeTemperature";
	public static string DownholeTorque = "DownholeTorque";
	public static string FlowRateIn = "FlowRateIn";
	public static string FlowRateOut = "FlowRateOut";
	public static string HoleDepth = "HoleDepth";
	public static string HookLoad = "HookLoad";
	public static string HookPosition = "HookPosition";
	public static string HookVelocity = "HookVelocity";
	public static string Inclination = "Inclination";
	public static string MeasuredDepth = "MeasuredDepth";
	public static string PumpRate = "PumpRate";
	public static string ROP = "ROP";
	public static string SPP = "SPP";
	public static string SurfaceRPM = "SurfaceRPM";
	public static string SurfaceTorque = "SurfaceTorque";
	public static string TemperatureIn = "TemperatureIn";
	public static string TemperatureOut = "TemperatureOut";
	public static string TopOfStringPosition = "TopOfStringPosition";
	public static string WOB = "WOB";
	public static string PorePressure = "PorePressure";
	public static string PorePressureGradient = "PorePressureGradient";
	public static string FracturingPressure = "FracturingPressure";
	public static string FracturingPressureGradient = "FracturingPressureGradient";
	public static string CollapsePressure = "CollapsePressure";
	public static string CollapsePressureGradient = "CollapsePressureGradient";
	public static string ShearRate = "ShearRate";
	public static string ShearStress = "ShearStress";
	public static string MinimumHorizontalStress = "MinimumHorizontalStress";
	public static string MinimumHorizontalStressGradient = "MinimumHorizontalStressGradient";
	public static string OverburdenPressure = "OverburdenPressure";
	public static string OverburdenPressureGradient = "OverburdenPressureGradient";
	public static string BOPOpening = "BOPOpening";
	public static string BOPPressure = "BOPPressure";
	public static string MPDChokeOpening = "MPDChokeOpening";
	public static string MPDChokePressure = "MPDChokePressure";
	public static string MPDPumpRate = "MPDPumpRate";
	public static string MPDPumpFlowRate = "MPDPumpFlowRate";
	public static string GasFlowRate = "GasFlowRate";
	public static string BackPressurePumpPressure = "BackPressurePumpPressure";
	public static string MechanicalSpecificEnergy = "MechanicalSpecificEnergy";
	public static string ProcessData = "ProcessData";
	public static string SetPoint = "SetPoint";
	public static string Command = "Command";
	public static string Recommendation = "Recommendation";
	public static string RecommendedTarget = "RecommendedTarget";
	public static string RecommendedMinimum = "RecommendedMinimum";
	public static string RecommendedMaximum = "RecommendedMaximum";
	public static string Advice = "Advice";
	public static string AdvisedTarget = "AdvisedTarget";
	public static string AdvisedMinimum = "AdvisedMinimum";
	public static string AdvisedMaximum = "AdvisedMaximum";
	public static string Limit = "Limit";
	public static string MinimumLimit = "MinimumLimit";
	public static string MaximumLimit = "MaximumLimit";
	public static string PhysicalData = "PhysicalData";
	public static string Measurement = "Measurement";
	public static string DerivedMeasurement = "DerivedMeasurement";
	public static string CorrectedMeasurement = "CorrectedMeasurement";
	public static string ComputedData = "ComputedData";
	public static string DrillingSignal = "DrillingSignal";
	public static string DynamicDrillingSignal = "DynamicDrillingSignal";
	public static string DrillingEquipment = "DrillingEquipment";
	public static string Pit = "Pit";
	public static string ActivePit = "ActivePit";
	public static string ReservePit = "ReservePit";
	public static string SlugPit = "SlugPit";
	public static string TripTank = "TripTank";
	public static string AnnulusTerminator = "AnnulusTerminator";
	public static string Riser = "Riser";
	public static string MarineRiser = "MarineRiser";
	public static string SurfaceRiser = "SurfaceRiser";
	public static string LowPressureRiser = "LowPressureRiser";
	public static string HighPressureRiser = "HighPressureRiser";
	public static string SlipJoint = "SlipJoint";
	public static string BellNipple = "BellNipple";
	public static string Diverter = "Diverter";
	public static string FlowLine = "FlowLine";
	public static string BlowOutPreventerStack = "BlowOutPreventerStack";
	public static string BlowOutPreventerElement = "BlowOutPreventerElement";
	public static string AnnularPreventer = "AnnularPreventer";
	public static string BOPRam = "BOPRam";
	public static string BOPShearRam = "BOPShearRam";
	public static string DrillStemTerminator = "DrillStemTerminator";
	public static string Bit = "Bit";
	public static string BullNose = "BullNose";
	public static string CasingShoe = "CasingShoe";
	public static string Dolly = "Dolly";
	public static string DollyRail = "DollyRail";
	public static string DrillLine = "DrillLine";
	public static string ActiveLine = "ActiveLine";
	public static string DeadLine = "DeadLine";
	public static string SupportLine = "SupportLine";
	public static string DrillLineFastener = "DrillLineFastener";
	public static string DeadLineAnchor = "DeadLineAnchor";
	public static string DrawWorks = "DrawWorks";
	public static string RackAndPinionHoistingSystem = "RackAndPinionHoistingSystem";
	public static string RamHoistingSystem = "RamHoistingSystem";
	public static string DrillStem = "DrillStem";
	public static string DrillString = "DrillString";
	public static string CasingString = "CasingString";
	public static string Liner = "Liner";
	public static string TubingString = "TubingString";
	public static string ScreenString = "ScreenString";
	public static string CoiledTubing = "CoiledTubing";
	public static string Elevator = "Elevator";
	public static string GateValve = "GateValve";
	public static string Choke = "Choke";
	public static string RigChoke = "RigChoke";
	public static string MPDChoke = "MPDChoke";
	public static string MechanicalBlock = "MechanicalBlock";
	public static string CrownBlock = "CrownBlock";
	public static string TravellingBlock = "TravellingBlock";
	public static string Pump = "Pump";
	public static string CementPump = "CementPump";
	public static string MudPump = "MudPump";
	public static string BoosterPump = "BoosterPump";
	public static string BackPressurePump = "BackPressurePump";
	public static string ShaleShakers = "ShaleShakers";
	public static string Slips = "Slips";
	public static string SurfacePipe = "SurfacePipe";
	public static string StandPipe = "StandPipe";
	public static string MudHose = "MudHose";
	public static string ThreeWayManifold = "ThreeWayManifold";
	public static string ThreeWayValve = "ThreeWayValve";
	public static string ThreeWayValveInternalValve = "ThreeWayValveInternalValve";
	public static string StringRotationSystem = "StringRotationSystem";
	public static string RotaryTable = "RotaryTable";
	public static string Kelly = "Kelly";
	public static string TopDrive = "TopDrive";
	public static string TopDriveBody = "TopDriveBody";
	public static string TopDriveHook = "TopDriveHook";
	public static string TopDriveShaft = "TopDriveShaft";
	public static string HoleEnlargementElement = "HoleEnlargementElement";
	public static string UnderReamer = "UnderReamer";
	public static string HoleOpener = "HoleOpener";
	public static string HoistingSystem = "HoistingSystem";
	public static string Rig = "Rig";
	public static string Sea = "Sea";
	public static string Ground = "Ground";
	public static string DWISNoun = "DWISNoun";
	public static string DataEndPoint = "DataEndPoint";
	public static string WitsMLTimeBasedLogEndPoint = "WitsMLTimeBasedLogEndPoint";
	public static string EndPointMapping = "EndPointMapping";
	public static string HydraulicElementState = "HydraulicElementState";
	public static string HydraulicConnectedState = "HydraulicConnectedState";
	public static string HydraulicLogicalElement = "HydraulicLogicalElement";
	public static string HydraulicBranch = "HydraulicBranch";
	public static string Annular = "Annular";
	public static string BHAAnnular = "BHAAnnular";
	public static string DrillPipesAnnular = "DrillPipesAnnular";
	public static string OpenChannel = "OpenChannel";
	public static string RectangularChannel = "RectangularChannel";
	public static string SemiCircularChannel = "SemiCircularChannel";
	public static string Pipe = "Pipe";
	public static string BHAInner = "BHAInner";
	public static string DrillPipesInner = "DrillPipesInner";
	public static string OpenHole = "OpenHole";
	public static string ReturnFlowLine = "ReturnFlowLine";
	public static string HydraulicJunction = "HydraulicJunction";
	public static string Tank = "Tank";
	public static string MudMixing = "MudMixing";
	public static string HydraulicNetwork = "HydraulicNetwork";
	public static string DownholeHydraulicNetwork = "DownholeHydraulicNetwork";
	public static string TopsideHydraulicNetwork = "TopsideHydraulicNetwork";
	public static string FluidComponent = "FluidComponent";
	public static string LiquidComponent = "LiquidComponent";
	public static string FormationLiquidComponent = "FormationLiquidComponent";
	public static string DrillingFluidLiquidComponent = "DrillingFluidLiquidComponent";
	public static string DrillingFluidOilComponent = "DrillingFluidOilComponent";
	public static string DrillingFluidWaterComponent = "DrillingFluidWaterComponent";
	public static string GasComponent = "GasComponent";
	public static string FormationGasComponent = "FormationGasComponent";
	public static string DrillingFluidGasComponent = "DrillingFluidGasComponent";
	public static string SolidComponent = "SolidComponent";
	public static string DrillingFluidSolidComponent = "DrillingFluidSolidComponent";
	public static string HighGravitySolidComponent = "HighGravitySolidComponent";
	public static string LowGravitySolidComponent = "LowGravitySolidComponent";
	public static string FormationSolidComponent = "FormationSolidComponent";
	public static string CuttingsComponent = "CuttingsComponent";
	public static string CavingsComponent = "CavingsComponent";
	public static string DrillStemMechanicalModel = "DrillStemMechanicalModel";
	public static string MechanicalStiffnessType = "MechanicalStiffnessType";
	public static string MechanicalSoftModel = "MechanicalSoftModel";
	public static string MechanicalStiffModel = "MechanicalStiffModel";
	public static string MechanicalStiffModelAssumedContacts = "MechanicalStiffModelAssumedContacts";
	public static string MechanicalStiffModelEstimatedContacts = "MechanicalStiffModelEstimatedContacts";
	public static string TangencyLength = "TangencyLength";
	public static string MechanicalElementState = "MechanicalElementState";
	public static string MechanicallyClosedState = "MechanicallyClosedState";
	public static string MechanicallyConnectedState = "MechanicallyConnectedState";
	public static string MechanicalLogicalElement = "MechanicalLogicalElement";
	public static string MathematicalModel = "MathematicalModel";
	public static string SteadyStateModel = "SteadyStateModel";
	public static string TransientModel = "TransientModel";
	public static string ModelledDegreeOfFreedom = "ModelledDegreeOfFreedom";
	public static string AxialModelling = "AxialModelling";
	public static string RotationalModelling = "RotationalModelling";
	public static string LateralModelling = "LateralModelling";
	public static string RadialModelling = "RadialModelling";
	public static string AngularLateralModelling = "AngularLateralModelling";
	public static string TangentialModelling = "TangentialModelling";
	public static string VerticalOndulationModelling = "VerticalOndulationModelling";
	public static string HorizontalOndulationModelling = "HorizontalOndulationModelling";
	public static string ModellingDimensions = "ModellingDimensions";
	public static string OneDModelling = "OneDModelling";
	public static string TwoDModelling = "TwoDModelling";
	public static string ThreeDModelling = "ThreeDModelling";
	public static string ModellingDiscretization = "ModellingDiscretization";
	public static string BoundaryDiscretization = "BoundaryDiscretization";
	public static string StrainWaveBasedDiscretization = "StrainWaveBasedDiscretization";
	public static string MassTransferBasedDiscretization = "MassTransferBasedDiscretization";
	public static string Location = "Location";
	public static string VerticalReferenceLocation = "VerticalReferenceLocation";
	public static string WGS84VerticalLocation = "WGS84VerticalLocation";
	public static string CasingFlangeVerticalLocation = "CasingFlangeVerticalLocation";
	public static string CrownValveVerticalLocation = "CrownValveVerticalLocation";
	public static string DerrickFloorVerticalLocation = "DerrickFloorVerticalLocation";
	public static string KellyBushingVerticalLocation = "KellyBushingVerticalLocation";
	public static string RotaryTableVerticalLocation = "RotaryTableVerticalLocation";
	public static string WellHeadVerticalLocation = "WellHeadVerticalLocation";
	public static string GroundLevelVerticalLocation = "GroundLevelVerticalLocation";
	public static string SeaFloorVerticalLocation = "SeaFloorVerticalLocation";
	public static string LowestAstronomicalTideVerticalLocation = "LowestAstronomicalTideVerticalLocation";
	public static string MeanSeaLevelVerticalLocation = "MeanSeaLevelVerticalLocation";
	public static string MeanHigherHighWaterVerticalLocation = "MeanHigherHighWaterVerticalLocation";
	public static string MeanHighWaterVerticalLocation = "MeanHighWaterVerticalLocation";
	public static string MeanLowerLowWaterVerticalLocation = "MeanLowerLowWaterVerticalLocation";
	public static string MeanLowWaterVerticalLocation = "MeanLowWaterVerticalLocation";
	public static string MeanTideLevelVerticalLocation = "MeanTideLevelVerticalLocation";
	public static string KickOffVerticalLocation = "KickOffVerticalLocation";
	public static string PositionReferenceLocation = "PositionReferenceLocation";
	public static string WGS84PositionLocation = "WGS84PositionLocation";
	public static string WellHeadPositionLocation = "WellHeadPositionLocation";
	public static string ClusterPositionLocation = "ClusterPositionLocation";
	public static string LeaseLinePositionLocation = "LeaseLinePositionLocation";
	public static string AxialReferenceLocation = "AxialReferenceLocation";
	public static string BottomShoulderAxialLocation = "BottomShoulderAxialLocation";
	public static string TopShoulderAxialLocation = "TopShoulderAxialLocation";
	public static string AbscissaReferenceLocation = "AbscissaReferenceLocation";
	public static string BottomOfStringReferenceLocation = "BottomOfStringReferenceLocation";
	public static string TopOfStringReferenceLocation = "TopOfStringReferenceLocation";
	public static string LastCasingShoeReferenceLocation = "LastCasingShoeReferenceLocation";
	public static string HoleBottomLocation = "HoleBottomLocation";
	public static string TopOfRatHoleLocation = "TopOfRatHoleLocation";
	public static string LedgeLocation = "LedgeLocation";
	public static string CuttingsBedLocation = "CuttingsBedLocation";
	public static string FormationFluidTransferLocation = "FormationFluidTransferLocation";
	public static string DifferentialStickingLocation = "DifferentialStickingLocation";
	public static string FormationCollapseLocation = "FormationCollapseLocation";
	public static string PipeWashoutLocation = "PipeWashoutLocation";
	public static string FormationWashoutLocation = "FormationWashoutLocation";
	public static string AngleReferenceLocation = "AngleReferenceLocation";
	public static string ScribeLineAngleLocation = "ScribeLineAngleLocation";
	public static string GravityHighSideAngleLocation = "GravityHighSideAngleLocation";
	public static string MagneticHighSideAngleLocation = "MagneticHighSideAngleLocation";
	public static string UpperSideAngleLocation = "UpperSideAngleLocation";
	public static string AzimuthReferenceLocation = "AzimuthReferenceLocation";
	public static string TrueNorthAzimuthLocation = "TrueNorthAzimuthLocation";
	public static string MagneticNorthAzimuthLocation = "MagneticNorthAzimuthLocation";
	public static string GridNorthAzimuthLocation = "GridNorthAzimuthLocation";
	public static string ReferenceFrame = "ReferenceFrame";
	public static string OneDimensionalReferenceFrame = "OneDimensionalReferenceFrame";
	public static string AngleReferenceFrame = "AngleReferenceFrame";
	public static string OneDimensionalCartesianReferenceFrame = "OneDimensionalCartesianReferenceFrame";
	public static string VerticalDepthFrame = "VerticalDepthFrame";
	public static string OneDimensionalCurviLinearReferenceFrame = "OneDimensionalCurviLinearReferenceFrame";
	public static string DrillStringCenterLineFrame = "DrillStringCenterLineFrame";
	public static string WellboreCenterLineFrame = "WellboreCenterLineFrame";
	public static string DepthAndAngleFrame = "DepthAndAngleFrame";
	public static string TwoDimensionalReferenceFrame = "TwoDimensionalReferenceFrame";
	public static string CartesianTwoDimensionalReferenceFrame = "CartesianTwoDimensionalReferenceFrame";
	public static string NorthEastFrame = "NorthEastFrame";
	public static string PolarReferenceFrame = "PolarReferenceFrame";
	public static string RiemannianManifoldTwoDimensionalReferenceFrame = "RiemannianManifoldTwoDimensionalReferenceFrame";
	public static string ThreeDimensionalReferenceFrame = "ThreeDimensionalReferenceFrame";
	public static string CartesianThreeDimensionalReferenceFrame = "CartesianThreeDimensionalReferenceFrame";
	public static string NorthEastTVDFrame = "NorthEastTVDFrame";
	public static string FrenetSerretReferenceFrame = "FrenetSerretReferenceFrame";
	public static string RiemannianManifoldThreeDimensionalReferenceFrame = "RiemannianManifoldThreeDimensionalReferenceFrame";
	public static string CylindricalReferenceFrame = "CylindricalReferenceFrame";
	public static string SphericalReferenceFrame = "SphericalReferenceFrame";
	public static string FourDimensionalReferenceFrame = "FourDimensionalReferenceFrame";
	public static string CartesianFourDimensionalReferenceFrame = "CartesianFourDimensionalReferenceFrame";
	public static string RiemannianManifoldFourDimensionalReferenceFrame = "RiemannianManifoldFourDimensionalReferenceFrame";
	public static string MeasurableQuantity = "MeasurableQuantity";
	public static string BitTorqueQuantity = "BitTorqueQuantity";
	public static string BlockAccelerationQuantity = "BlockAccelerationQuantity";
	public static string BlockPositionQuantity = "BlockPositionQuantity";
	public static string BlockVelocityQuantity = "BlockVelocityQuantity";
	public static string DepthQuantity = "DepthQuantity";
	public static string DownholePressureQuantity = "DownholePressureQuantity";
	public static string EMWQuantity = "EMWQuantity";
	public static string FlowRateQuantity = "FlowRateQuantity";
	public static string FluidDensityInQuantity = "FluidDensityInQuantity";
	public static string FluidTemperatureInQuantity = "FluidTemperatureInQuantity";
	public static string FormationPorosityQuantity = "FormationPorosityQuantity";
	public static string HookloadQuantity = "HookloadQuantity";
	public static string PumpRateQuantity = "PumpRateQuantity";
	public static string Resistivity = "Resistivity";
	public static string RockDensityQuantity = "RockDensityQuantity";
	public static string SPPQuantity = "SPPQuantity";
	public static string SurfaceRPMQuantity = "SurfaceRPMQuantity";
	public static string SurfaceTorqueQuantity = "SurfaceTorqueQuantity";
	public static string TopOfStringForceQuantity = "TopOfStringForceQuantity";
	public static string TVDQuantity = "TVDQuantity";
	public static string WOBQuantity = "WOBQuantity";
	public static string MeasurableQuantityUnitAssociation = "MeasurableQuantityUnitAssociation";
	public static string Quantity = "Quantity";
	public static string AccelerationQuantity = "AccelerationQuantity";
	public static string AreaQuantity = "AreaQuantity";
	public static string ElectricResistivityQuantity = "ElectricResistivityQuantity";
	public static string ForceQuantity = "ForceQuantity";
	public static string FrequencyQuantity = "FrequencyQuantity";
	public static string LengthQuantity = "LengthQuantity";
	public static string MassDensityQuantity = "MassDensityQuantity";
	public static string MassQuantity = "MassQuantity";
	public static string MassRate = "MassRate";
	public static string PowerQuantity = "PowerQuantity";
	public static string PressureQuantity = "PressureQuantity";
	public static string ProportionQuantity = "ProportionQuantity";
	public static string TemperatureQuantity = "TemperatureQuantity";
	public static string TorqueQuantity = "TorqueQuantity";
	public static string VelocityQuantity = "VelocityQuantity";
	public static string VolumeQuantity = "VolumeQuantity";
	public static string VolumetricRateQuantity = "VolumetricRateQuantity";
	public static string VolumetricFlowateRateOfChangeQuantity = "VolumetricFlowateRateOfChangeQuantity";
	public static string Unit = "Unit";
	public static string UnitSystem = "UnitSystem";
	public static string Clock = "Clock";
	public static string SynchronizationGroup = "SynchronizationGroup";
	public static string SignalUncertainty = "SignalUncertainty";
	public static string GaussianUncertainty = "GaussianUncertainty";
	public static string GenericUncertainty = "GenericUncertainty";
	public static string MinMaxUncertainty = "MinMaxUncertainty";
	public static string FullScaleUncertainty = "FullScaleUncertainty";
	public static string SensorUncertainty = "SensorUncertainty";
}
}
