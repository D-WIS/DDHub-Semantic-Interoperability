using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Nouns
{
public enum Enum
{
ActivableFunction,
RunnableFunction,
ControllerFunction,
ProcedureFunction,
ProtectionFunction,
FDIRFunction,
SOEFunction,
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
DWISDDHub,
DWISDrillingProcessStateInterpreter,
DWISAdviceComposer,
DWISScheduler,
DWISContextualDataBuilder,
DWISLogger,
DWISADCSInterface,
DWISADCSCapabilityDescriptor,
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
DataType,
ContinuousDataType,
NormalizedDataType,
DiscreteDataType,
EnumerationDataType,
BooleanDataType,
StringDataType,
DrillingDataPoint,
PrototypeData,
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
Equipment,
RigEquipment,
PowerGenerationSystem,
PowerGenerators,
ElectricalControlSystem,
PowerScrSystem,
HoistingSystem,
RackAndPinionHoistingSystem,
RamHoistingSystem,
Derrick,
ConventionalDerrick,
SlantDerrick,
QuadristandDerrick,
TripleStandDerrick,
DoubleStandDerrick,
SingleJointDerrick,
Drawworks,
StandardElectricalDrawworks,
MechanicalDrawworks,
DieselElectricalDrawworks,
RamRig,
MechanicalBlock,
TravellingBlock,
CrownBlock,
Hook,
DrillLine,
ActiveLine,
DeadLine,
SupportLine,
DrillLineFastener,
DeadLineAnchor,
SurfaceRotationSystem,
TopDrive,
TorqueTrack,
TorqueBushing,
SwivelSub,
ExtendFrame,
Quill,
MainframeAssembly,
LoadNut,
RotaryTable,
RotaryTableBushings,
Kelly,
KellyHose,
KellyBushing,
KellyJoint,
KellySwivel,
WellControlSystem,
BellNipple,
Accumulator,
BopStack,
SurfaceBop,
LandBop,
SubseaBop,
BopElement,
AnnularPreventer,
PipeRam,
ShearRam,
BlindRam,
AdapterSpool,
SpacingSpool,
ChokeManifold,
ChokeValve,
ChokeValveGatevalve,
KillLine,
ChokeLine,
ControlLines,
Diverter,
DiverterLine,
DiverterLineHanger,
VentOverboardLine,
ControlManifold,
Ibop,
KellyValve,
FloatValveNonreturnValve,
PlungerFloatValvesF,
PortedPlungerValvesFa,
FlapperFloatValvesG,
MpdChoke,
WellheadXmasTree,
CirculationSystem,
MudPump,
PistonMudPump,
PulsationDampener,
Piston,
Liner,
Cylinders,
Action,
SingleActing,
DualActing,
PlungerMudPump,
CentrifugalMudPump,
HydraulicMudPump,
DiaphragmMudPump,
PeristalticMudPump,
RiserLiftPump,
FillPump,
BackPressurePump,
BoosterPump,
DrillingFluid,
DrillWater,
PotableWater,
SeaWater,
OilBasedMudObm,
WaterBasedMudWbm,
SyntheticOilBasedMudSobm,
SpudMud,
MudPits,
ActiveDrillingSystem,
TripTank,
MixingTank,
ReservePit,
SlugSettlingPit,
SurgeTank,
StorageTank,
SandTrap,
ChemicalTank,
BulkTank,
ShaleShakers,
ShakerHopper,
ShakerDecks,
ShakerScreens,
ShakerScreenMeshSize,
ShakerCascadeLevels,
Centrifuge,
Degasser,
CentrifugalDegasser,
VacuumDegasser,
AfmAutofluidMeasSkid,
Hydrocyclones,
MudLines,
MudStandpipeManifold,
MudStandpipe,
MudHose,
Gooseneck,
FlowLine,
MarineSystem,
DrillingRiser,
MarineRiser,
SurfaceRiser,
LowPressureRiser,
HighPressureRiser,
BallJoint,
CompletionWorkoverRiser,
LowerMarineRiserPackageLmrp,
BoosterLine,
SlipJoint,
SpiderGimbal,
MarineRiserTensionerMrtRing,
RiserTensioners,
ConductorTensioners,
RiserRecoilSystem,
LandingJoint,
Rov,
BallastSystem,
Beacons,
JackupLegs,
MooringSystem,
MooringLines,
Anchors,
MarineFuel,
MudLineSystem,
StormLoop,
HeaveCompensationSystem,
DrillFloorSystems,
DrillFloorStructure,
DogHouse,
RigFloor,
Mousehole,
DrillFloorSubstructure,
DrillFloorEquipment,
DrillersConsole,
IronRoughneck,
DrillPipeElevator,
ElevatorBailsLinks,
DrillPipeTongs,
ManualPipeTongs,
PowerPipeTongs,
CasingTongs,
RotarySlips,
ManualSlips,
PowerSlips,
PneumaticSlips,
StabbingGuide,
SafetyClamps,
RotatingControlDeviceRcd,
Dolly,
DollyRail,
SlickLine,
CementingEquipment,
CementPump,
CementSlurry,
CementSpacer,
CementStand,
CementStinger,
CementUnit,
CementHead,
CementLines,
CementManifold,
WellTestingEquipment,
TestingTools,
TestPlug,
SubseaTestTree,
TestTools,
Seperator,
SafetyEquipment,
FireSafetySystems,
GasSafetySystems,
ThirdPartyRigEquipment,
ThirdPartyTools,
MudLoggingEquipment,
CuttingsSamplingEquipment,
CuttingsAnalysisEquipmnet,
GasAnalysisEquipment,
FlowAnalysisEquipment,
Tubulars,
DrillString,
BottomholeAssembly,
DrillPipe,
CompressiveDrillPipe,
DrillCollars,
NonmagneticCollars,
ShortDc,
Heavyweight,
PupJoints,
Stabilizers,
BladeShape,
Dynamic,
Melon,
Spiral,
Straight,
Variable,
BladeType,
Clampon,
Integral,
Sleeve,
BladeTypeWelded,
BladeDiameter,
BladeLength,
Nonmagnetic,
NearBit,
Nonrotating,
Steerable,
Grouping,
Stands,
Doubles,
Singles,
MiscSubs,
Subbent,
Subbit,
Subbumper,
Subcatcher,
Subcirculation,
Subcone,
Subcrossover,
Subdart,
Subfilter,
Subfloat,
Subjetting,
Subjunk,
Suborienting,
Subported,
SubpressureRelief,
SubpumpOut,
Subrestrictor,
Subsaver,
Subshock,
SubsideEntry,
Substop,
CasingString,
ConductorDrivePipe,
Casing,
Liners,
Centralizers,
Crossover,
Connection,
Box,
Flange,
Mandrel,
Pin,
ConnectionWelded,
Selfsealingthreaded,
Expandables,
TubingString,
ScreenString,
TubularConnection,
TubularConfiguration,
PinDown,
PinUp,
Boxbox,
Pinpin,
DownholeEquipment,
DrillingEquipment,
DrillstemTerminator,
DrillingBit,
RollingCutter,
Milltooth,
InsertTci,
FixedCutter,
Pdc,
Diamond,
PdcCore,
DiamondCore,
HybridKymera,
Nozzles,
BullNose,
Reamers,
RollerReamers,
RfidReamers,
NearbitReamers,
FixedBladeReamers,
BicenterReamerBit,
ExpandableReamers,
HoleOpener,
Underreamers,
FixedBlade,
CoringTool,
InnerBarrel,
OuterBarrel,
DownholeMotor,
TurbineMotor,
PositiveDisplacementMotor,
OilBearing,
MudLubeBearing,
SteerableMotor,
InstrumentedMotor,
AdjustableKickoffSub,
RotarySteerableSystems,
Pointthebit,
Pushthebit,
ContinuousProportional,
JettingAssembly,
HammerAssembly,
JarringAssembly,
JarAction,
MechanicalJar,
HydraulicJar,
HydromechanicalJar,
Accelerator,
Casingwhiledrilling,
DirectionalCasingWhileDrilling,
LinerDrilling,
SteerableLinerDrilling,
CirculationSub,
Whipstock,
FishingTools,
Overshot,
Spear,
JunkBasket,
Thruster,
ActiveVibrationTools,
BhaVibrationDampers,
VibrationIsolators,
NearBitVibrationDampers,
IsolationSeal,
CasingEquipment,
CasingMillingTools,
MillCasingCutting,
MillDress,
MillFlatBottom,
MillHollow,
MillPackerPickerAssembly,
MillPilot,
MillPolish,
MillSection,
MillTaper,
MillWashover,
MillWatermelon,
CasingLinerEquipment,
CasingHead,
ShoeTrack,
FloatCollar,
FloatShoe,
LinerPacker,
DownholeValveAssembly,
PerforatingGuns,
Hangers,
TubingHanger,
CasingHanger,
LinerHanger,
Plugs,
InnerString,
LandingString,
CasingShoe,
CasingCutter,
LoggingEquipment,
EquipmentTelemetry,
MudPulse,
WiredPipe,
Electromagnetic,
Acoustic,
Hybrid,
WireCable,
PowerSystems,
DownholeAlternator,
DownholeBatteries,
SurfacePower,
LoggingWhileDrillingTools,
LoggingWhileDrillingToolsAcoustictools,
AzimuthalTools,
LoggingWhileDrillingToolsElectricalpropagation,
LoggingWhileDrillingToolsElectricalresistivity,
FormationTestTools,
ImagingTools,
LoggingWhileDrillingToolsNmrtools,
LoggingWhileDrillingToolsNucleartools,
LoggingWhileDrillingToolsSeismictools,
MeasurementWhileDrillingTools,
DirectionalTool,
MechanicsAndVibrationTools,
PwdPressure,
WirelineLoggingTools,
OpenholeTools,
CasedHoleTools,
ProductionTools,
WirelineLoggingToolsElectricalresistivity,
WirelineLoggingToolsElectricalpropagation,
SpontaneousPotential,
WirelineLoggingToolsNucleartools,
WirelineLoggingToolsNmrtools,
WirelineLoggingToolsAcoustictools,
DipmeterAndImagingTools,
FormationTestingAndSampling,
WirelineLoggingToolsSeismictools,
CasingCollarLocator,
FluidDensityTools,
FlowmeterTools,
CementBondLoggingTools,
PressureLoggingTools,
CoiledTubingEquipment,
CoiledTubingReel,
InjectorHead,
TubingGuideArch,
PowerSupply,
ControlConsole,
ControlAndMonitoringEquipment,
DownholeCtConnectors,
CtBhaComponents,
WellcontrolStackEquipment,
GenericEquipment,
GenericEquipmentGatevalve,
ThreeWayManifold,
ThreeWayValve,
DrillingIncident,
AbnormalOscillation,
AbnormalAxialOscillation,
AbnormalTorsionalOscillation,
AbnormalLateralOscillation,
StickSlip,
HFTO,
Whirling,
ForwardWhirl,
BackwardWhirl,
ChaoticWhirl,
Shock,
TwistOff,
Overpull,
Underpull,
Influx,
LossCirculation,
HoleCollapse,
StuckPipe,
PipeWashout,
FormationWashout,
OverTorque,
Plugged,
DWISNoun,
DataEndPoint,
WitsMLTimeBasedLogEndPoint,
EndPointMapping,
PressureReference,
AbsolutePressureReference,
RelativePressureReference,
GaugePressureReference,
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
MPDMainFlowPath,
MPDAlternateFlowPath,
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
EarthMagneticFluxDensityQuantity,
ElectricTensionQuantity,
ImageScaleQuantity,
SmallLengthQuantity,
RotationFrequencyQuantity,
LargeVolumeQuantity,
PermeabilityQuantity,
YoungModulusQuantity,
StandardProportionQuantity,
StandardDimensionlessQuantity,
StandardLengthQuantity,
FluidShearRateQuantity,
FluidShearStressQuantity,
RheologyConsistencyIndexQuantity,
SmallDiameterQuantity,
SmallTorqueQuantity,
SmallRotationFrequencyQuantity,
SmallProportionQuantity,
PorosityQuantity,
BlockVelocityQuantity,
CableDiameterQuantity,
CapillaryPressureQuantity,
DepthQuantity,
DrillingAccelerationQuantity,
DrillingAngleVariationGradientQuantity,
DrillingAngularVelocityQuantity,
DrillingAreaQuantity,
DrillingAxialVelocityQuantity,
DrillingCompressibilityQuantity,
DrillingCurvatureQuantity,
DrillingDensityGradientDepthQuantity,
DrillingDensityGradientTemperatureQuantity,
DrillingDensityQuantity,
DrillingDensityRateOfChangeQuantity,
DrillingDrillStringMagneticFluxQuantity,
DrillingDurationQuantity,
DrillingDynamicViscosityQuantity,
DrillingElongationGradientQuantity,
DrillingFluidVelocityQuantity,
DrillingForceGradientQuantity,
DrillingForceQuantity,
DrillingHeatTransferCoefficientQuantity,
DrillingHydraulicConductivityQuantity,
DrillingInterfacialTensionQuantity,
DrillingMassGradientQuantity,
DrillingMassQuantity,
DrillingMassRateQuantity,
DrillingPlaneAngleQuantity,
DrillingPressureGradientQuantity,
DrillingPressureLossConstantQuantity,
DrillingPressureQuantity,
DrillingRandomWalkQuantity,
DrillingRotationFrequencyRateOfChangeQuantity,
DrillingSpecificHeatCapacityQuantity,
DrillingSpecificHeatCapacityTemperatureGradientQuantity,
DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity,
DrillingSurveyInstrumentAngularVelocityQuantity,
DrillingSurveyInstrumentReciprocalLengthQuantity,
DrillingTemperatureGradientQuantity,
DrillingTemperatureQuantity,
DrillingTensionQuantity,
DrillingThermalConductivityQuantity,
DrillingThermalConductivityTemperatureGradientQuantity,
DrillingTorqueQuantity,
DrillingVolumeQuantity,
DrillingVolumetricFlowRateOfChangeQuantity,
DrillingVolumetricFlowrateQuantity,
DrillStemMaterialStrengthQuantity,
FormationResistivityQuantity,
FormationStrengthQuantity,
GammaRayQuantity,
GasShowQuantity,
GasVolumetricFlowRateQuantity,
HeightQuantity,
HookLoadQuantity,
NozzleDiameterQuantity,
PipeDiameterQuantity,
PoreDiameterQuantity,
PoreSurfaceQuantity,
PositionQuantity,
RateOfPenetrationQuantity,
WeightOnBitQuantity,
DrillStemMechanicalModel,
MechanicalStiffnessType,
MechanicalSoftModel,
MechanicalStiffModel,
MechanicalStiffModelAssumedContacts,
MechanicalStiffModelEstimatedContacts,
TangencyLength,
MechanicalElementState,
MechanicallyClosedState,
MechanicallyOpenState,
MechanicallyActiveState,
MechanicallyInactiveState,
MechanicallyConnectedState,
MechanicalLogicalElement,
MotionType,
AxialMotionType,
TorsionalMotionType,
LateralMotionType,
ModelType,
DeterministicModel,
StochasticModel,
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
StickUpHeightVerticalLocation,
MinDrillHeightVerticalLocation,
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
ToolJoint1ReferenceLocation,
ToolJoint2ReferenceLocation,
ToolJoint3ReferenceLocation,
ToolJoint4ReferenceLocation,
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
MeasurableQuantityUnitAssociation,
Quantity,
Unit,
UnitSystem,
AccelerationQuantity,
AmountSubstanceQuantity,
AngleMagneticFluxDensityQuantity,
AngleVariationGradientQuantity,
AngularVelocityQuantity,
AreaQuantity,
CompressibilityQuantity,
CurvatureQuantity,
DensityGradientDepthQuantity,
DensityGradientTemperatureQuantity,
DensityQuantity,
DensityRateOfChangeQuantity,
DimensionlessQuantity,
DynamicViscosityQuantity,
ElectricalCapacitanceQuantity,
ElectricCurrentQuantity,
ElongationGradientQuantity,
EnergyQuantity,
LengthQuantity,
LuminousIntensityQuantity,
MassQuantity,
PlaneAngleQuantity,
RelativeTemperatureQuantity,
SolidAngleQuantity,
TemperatureQuantity,
TimeQuantity,
PressureQuantity,
VolumetricFlowRateQuantity,
VolumetricFlowRateOfChangeQuantity,
VelocityQuantity,
ForceGradientQuantity,
ForceQuantity,
MaterialStrengthQuantity,
FrequencyQuantity,
ProportionQuantity,
HeatTransferCoefficientQuantity,
GravitationalLoadQuantity,
HydraulicConductivityQuantity,
InterfacialTensionQuantity,
VolumeQuantity,
MagneticFluxDensityQuantity,
MassRateQuantity,
PressureGradientQuantity,
PressureLossConstantQuantity,
ResistivityQuantity,
FrequencyRateOfChangeQuantity,
RotationFrequencyRateOfChangeQuantity,
SpecificHeatCapacityQuantity,
SpecificHeatCapacityTemperatureGradientQuantity,
TemperatureGradientQuantity,
TensionQuantity,
ThermalConductivityQuantity,
MassGradientQuantity,
ThermalConductivityTemperatureGradientQuantity,
TorqueQuantity,
MagneticFluxQuantity,
RandomWalkQuantity,
WaveNumberQuantity,
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
Clock,
SynchronizationGroup,
TimeReference,
AbsoluteTimeReference,
RelativeTimeReference,
GPSReference,
UTCReference,
LocalTimeReference,
TimeSpanReference,
SignalUncertainty,
GaussianUncertainty,
GenericUncertainty,
MinMaxUncertainty,
FullScaleUncertainty,
SensorUncertainty
}
	public static string ActivableFunction = "ActivableFunction";
	public static string RunnableFunction = "RunnableFunction";
	public static string ControllerFunction = "ControllerFunction";
	public static string ProcedureFunction = "ProcedureFunction";
	public static string ProtectionFunction = "ProtectionFunction";
	public static string FDIRFunction = "FDIRFunction";
	public static string SOEFunction = "SOEFunction";
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
	public static string DWISDDHub = "DWISDDHub";
	public static string DWISDrillingProcessStateInterpreter = "DWISDrillingProcessStateInterpreter";
	public static string DWISAdviceComposer = "DWISAdviceComposer";
	public static string DWISScheduler = "DWISScheduler";
	public static string DWISContextualDataBuilder = "DWISContextualDataBuilder";
	public static string DWISLogger = "DWISLogger";
	public static string DWISADCSInterface = "DWISADCSInterface";
	public static string DWISADCSCapabilityDescriptor = "DWISADCSCapabilityDescriptor";
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
	public static string DataType = "DataType";
	public static string ContinuousDataType = "ContinuousDataType";
	public static string NormalizedDataType = "NormalizedDataType";
	public static string DiscreteDataType = "DiscreteDataType";
	public static string EnumerationDataType = "EnumerationDataType";
	public static string BooleanDataType = "BooleanDataType";
	public static string StringDataType = "StringDataType";
	public static string DrillingDataPoint = "DrillingDataPoint";
	public static string PrototypeData = "PrototypeData";
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
	public static string Equipment = "Equipment";
	public static string RigEquipment = "RigEquipment";
	public static string PowerGenerationSystem = "PowerGenerationSystem";
	public static string PowerGenerators = "PowerGenerators";
	public static string ElectricalControlSystem = "ElectricalControlSystem";
	public static string PowerScrSystem = "PowerScrSystem";
	public static string HoistingSystem = "HoistingSystem";
	public static string RackAndPinionHoistingSystem = "RackAndPinionHoistingSystem";
	public static string RamHoistingSystem = "RamHoistingSystem";
	public static string Derrick = "Derrick";
	public static string ConventionalDerrick = "ConventionalDerrick";
	public static string SlantDerrick = "SlantDerrick";
	public static string QuadristandDerrick = "QuadristandDerrick";
	public static string TripleStandDerrick = "TripleStandDerrick";
	public static string DoubleStandDerrick = "DoubleStandDerrick";
	public static string SingleJointDerrick = "SingleJointDerrick";
	public static string Drawworks = "Drawworks";
	public static string StandardElectricalDrawworks = "StandardElectricalDrawworks";
	public static string MechanicalDrawworks = "MechanicalDrawworks";
	public static string DieselElectricalDrawworks = "DieselElectricalDrawworks";
	public static string RamRig = "RamRig";
	public static string MechanicalBlock = "MechanicalBlock";
	public static string TravellingBlock = "TravellingBlock";
	public static string CrownBlock = "CrownBlock";
	public static string Hook = "Hook";
	public static string DrillLine = "DrillLine";
	public static string ActiveLine = "ActiveLine";
	public static string DeadLine = "DeadLine";
	public static string SupportLine = "SupportLine";
	public static string DrillLineFastener = "DrillLineFastener";
	public static string DeadLineAnchor = "DeadLineAnchor";
	public static string SurfaceRotationSystem = "SurfaceRotationSystem";
	public static string TopDrive = "TopDrive";
	public static string TorqueTrack = "TorqueTrack";
	public static string TorqueBushing = "TorqueBushing";
	public static string SwivelSub = "SwivelSub";
	public static string ExtendFrame = "ExtendFrame";
	public static string Quill = "Quill";
	public static string MainframeAssembly = "MainframeAssembly";
	public static string LoadNut = "LoadNut";
	public static string RotaryTable = "RotaryTable";
	public static string RotaryTableBushings = "RotaryTableBushings";
	public static string Kelly = "Kelly";
	public static string KellyHose = "KellyHose";
	public static string KellyBushing = "KellyBushing";
	public static string KellyJoint = "KellyJoint";
	public static string KellySwivel = "KellySwivel";
	public static string WellControlSystem = "WellControlSystem";
	public static string BellNipple = "BellNipple";
	public static string Accumulator = "Accumulator";
	public static string BopStack = "BopStack";
	public static string SurfaceBop = "SurfaceBop";
	public static string LandBop = "LandBop";
	public static string SubseaBop = "SubseaBop";
	public static string BopElement = "BopElement";
	public static string AnnularPreventer = "AnnularPreventer";
	public static string PipeRam = "PipeRam";
	public static string ShearRam = "ShearRam";
	public static string BlindRam = "BlindRam";
	public static string AdapterSpool = "AdapterSpool";
	public static string SpacingSpool = "SpacingSpool";
	public static string ChokeManifold = "ChokeManifold";
	public static string ChokeValve = "ChokeValve";
	public static string ChokeValveGatevalve = "ChokeValveGatevalve";
	public static string KillLine = "KillLine";
	public static string ChokeLine = "ChokeLine";
	public static string ControlLines = "ControlLines";
	public static string Diverter = "Diverter";
	public static string DiverterLine = "DiverterLine";
	public static string DiverterLineHanger = "DiverterLineHanger";
	public static string VentOverboardLine = "VentOverboardLine";
	public static string ControlManifold = "ControlManifold";
	public static string Ibop = "Ibop";
	public static string KellyValve = "KellyValve";
	public static string FloatValveNonreturnValve = "FloatValveNonreturnValve";
	public static string PlungerFloatValvesF = "PlungerFloatValvesF";
	public static string PortedPlungerValvesFa = "PortedPlungerValvesFa";
	public static string FlapperFloatValvesG = "FlapperFloatValvesG";
	public static string MpdChoke = "MpdChoke";
	public static string WellheadXmasTree = "WellheadXmasTree";
	public static string CirculationSystem = "CirculationSystem";
	public static string MudPump = "MudPump";
	public static string PistonMudPump = "PistonMudPump";
	public static string PulsationDampener = "PulsationDampener";
	public static string Piston = "Piston";
	public static string Liner = "Liner";
	public static string Cylinders = "Cylinders";
	public static string Action = "Action";
	public static string SingleActing = "SingleActing";
	public static string DualActing = "DualActing";
	public static string PlungerMudPump = "PlungerMudPump";
	public static string CentrifugalMudPump = "CentrifugalMudPump";
	public static string HydraulicMudPump = "HydraulicMudPump";
	public static string DiaphragmMudPump = "DiaphragmMudPump";
	public static string PeristalticMudPump = "PeristalticMudPump";
	public static string RiserLiftPump = "RiserLiftPump";
	public static string FillPump = "FillPump";
	public static string BackPressurePump = "BackPressurePump";
	public static string BoosterPump = "BoosterPump";
	public static string DrillingFluid = "DrillingFluid";
	public static string DrillWater = "DrillWater";
	public static string PotableWater = "PotableWater";
	public static string SeaWater = "SeaWater";
	public static string OilBasedMudObm = "OilBasedMudObm";
	public static string WaterBasedMudWbm = "WaterBasedMudWbm";
	public static string SyntheticOilBasedMudSobm = "SyntheticOilBasedMudSobm";
	public static string SpudMud = "SpudMud";
	public static string MudPits = "MudPits";
	public static string ActiveDrillingSystem = "ActiveDrillingSystem";
	public static string TripTank = "TripTank";
	public static string MixingTank = "MixingTank";
	public static string ReservePit = "ReservePit";
	public static string SlugSettlingPit = "SlugSettlingPit";
	public static string SurgeTank = "SurgeTank";
	public static string StorageTank = "StorageTank";
	public static string SandTrap = "SandTrap";
	public static string ChemicalTank = "ChemicalTank";
	public static string BulkTank = "BulkTank";
	public static string ShaleShakers = "ShaleShakers";
	public static string ShakerHopper = "ShakerHopper";
	public static string ShakerDecks = "ShakerDecks";
	public static string ShakerScreens = "ShakerScreens";
	public static string ShakerScreenMeshSize = "ShakerScreenMeshSize";
	public static string ShakerCascadeLevels = "ShakerCascadeLevels";
	public static string Centrifuge = "Centrifuge";
	public static string Degasser = "Degasser";
	public static string CentrifugalDegasser = "CentrifugalDegasser";
	public static string VacuumDegasser = "VacuumDegasser";
	public static string AfmAutofluidMeasSkid = "AfmAutofluidMeasSkid";
	public static string Hydrocyclones = "Hydrocyclones";
	public static string MudLines = "MudLines";
	public static string MudStandpipeManifold = "MudStandpipeManifold";
	public static string MudStandpipe = "MudStandpipe";
	public static string MudHose = "MudHose";
	public static string Gooseneck = "Gooseneck";
	public static string FlowLine = "FlowLine";
	public static string MarineSystem = "MarineSystem";
	public static string DrillingRiser = "DrillingRiser";
	public static string MarineRiser = "MarineRiser";
	public static string SurfaceRiser = "SurfaceRiser";
	public static string LowPressureRiser = "LowPressureRiser";
	public static string HighPressureRiser = "HighPressureRiser";
	public static string BallJoint = "BallJoint";
	public static string CompletionWorkoverRiser = "CompletionWorkoverRiser";
	public static string LowerMarineRiserPackageLmrp = "LowerMarineRiserPackageLmrp";
	public static string BoosterLine = "BoosterLine";
	public static string SlipJoint = "SlipJoint";
	public static string SpiderGimbal = "SpiderGimbal";
	public static string MarineRiserTensionerMrtRing = "MarineRiserTensionerMrtRing";
	public static string RiserTensioners = "RiserTensioners";
	public static string ConductorTensioners = "ConductorTensioners";
	public static string RiserRecoilSystem = "RiserRecoilSystem";
	public static string LandingJoint = "LandingJoint";
	public static string Rov = "Rov";
	public static string BallastSystem = "BallastSystem";
	public static string Beacons = "Beacons";
	public static string JackupLegs = "JackupLegs";
	public static string MooringSystem = "MooringSystem";
	public static string MooringLines = "MooringLines";
	public static string Anchors = "Anchors";
	public static string MarineFuel = "MarineFuel";
	public static string MudLineSystem = "MudLineSystem";
	public static string StormLoop = "StormLoop";
	public static string HeaveCompensationSystem = "HeaveCompensationSystem";
	public static string DrillFloorSystems = "DrillFloorSystems";
	public static string DrillFloorStructure = "DrillFloorStructure";
	public static string DogHouse = "DogHouse";
	public static string RigFloor = "RigFloor";
	public static string Mousehole = "Mousehole";
	public static string DrillFloorSubstructure = "DrillFloorSubstructure";
	public static string DrillFloorEquipment = "DrillFloorEquipment";
	public static string DrillersConsole = "DrillersConsole";
	public static string IronRoughneck = "IronRoughneck";
	public static string DrillPipeElevator = "DrillPipeElevator";
	public static string ElevatorBailsLinks = "ElevatorBailsLinks";
	public static string DrillPipeTongs = "DrillPipeTongs";
	public static string ManualPipeTongs = "ManualPipeTongs";
	public static string PowerPipeTongs = "PowerPipeTongs";
	public static string CasingTongs = "CasingTongs";
	public static string RotarySlips = "RotarySlips";
	public static string ManualSlips = "ManualSlips";
	public static string PowerSlips = "PowerSlips";
	public static string PneumaticSlips = "PneumaticSlips";
	public static string StabbingGuide = "StabbingGuide";
	public static string SafetyClamps = "SafetyClamps";
	public static string RotatingControlDeviceRcd = "RotatingControlDeviceRcd";
	public static string Dolly = "Dolly";
	public static string DollyRail = "DollyRail";
	public static string SlickLine = "SlickLine";
	public static string CementingEquipment = "CementingEquipment";
	public static string CementPump = "CementPump";
	public static string CementSlurry = "CementSlurry";
	public static string CementSpacer = "CementSpacer";
	public static string CementStand = "CementStand";
	public static string CementStinger = "CementStinger";
	public static string CementUnit = "CementUnit";
	public static string CementHead = "CementHead";
	public static string CementLines = "CementLines";
	public static string CementManifold = "CementManifold";
	public static string WellTestingEquipment = "WellTestingEquipment";
	public static string TestingTools = "TestingTools";
	public static string TestPlug = "TestPlug";
	public static string SubseaTestTree = "SubseaTestTree";
	public static string TestTools = "TestTools";
	public static string Seperator = "Seperator";
	public static string SafetyEquipment = "SafetyEquipment";
	public static string FireSafetySystems = "FireSafetySystems";
	public static string GasSafetySystems = "GasSafetySystems";
	public static string ThirdPartyRigEquipment = "ThirdPartyRigEquipment";
	public static string ThirdPartyTools = "ThirdPartyTools";
	public static string MudLoggingEquipment = "MudLoggingEquipment";
	public static string CuttingsSamplingEquipment = "CuttingsSamplingEquipment";
	public static string CuttingsAnalysisEquipmnet = "CuttingsAnalysisEquipmnet";
	public static string GasAnalysisEquipment = "GasAnalysisEquipment";
	public static string FlowAnalysisEquipment = "FlowAnalysisEquipment";
	public static string Tubulars = "Tubulars";
	public static string DrillString = "DrillString";
	public static string BottomholeAssembly = "BottomholeAssembly";
	public static string DrillPipe = "DrillPipe";
	public static string CompressiveDrillPipe = "CompressiveDrillPipe";
	public static string DrillCollars = "DrillCollars";
	public static string NonmagneticCollars = "NonmagneticCollars";
	public static string ShortDc = "ShortDc";
	public static string Heavyweight = "Heavyweight";
	public static string PupJoints = "PupJoints";
	public static string Stabilizers = "Stabilizers";
	public static string BladeShape = "BladeShape";
	public static string Dynamic = "Dynamic";
	public static string Melon = "Melon";
	public static string Spiral = "Spiral";
	public static string Straight = "Straight";
	public static string Variable = "Variable";
	public static string BladeType = "BladeType";
	public static string Clampon = "Clampon";
	public static string Integral = "Integral";
	public static string Sleeve = "Sleeve";
	public static string BladeTypeWelded = "BladeTypeWelded";
	public static string BladeDiameter = "BladeDiameter";
	public static string BladeLength = "BladeLength";
	public static string Nonmagnetic = "Nonmagnetic";
	public static string NearBit = "NearBit";
	public static string Nonrotating = "Nonrotating";
	public static string Steerable = "Steerable";
	public static string Grouping = "Grouping";
	public static string Stands = "Stands";
	public static string Doubles = "Doubles";
	public static string Singles = "Singles";
	public static string MiscSubs = "MiscSubs";
	public static string Subbent = "Subbent";
	public static string Subbit = "Subbit";
	public static string Subbumper = "Subbumper";
	public static string Subcatcher = "Subcatcher";
	public static string Subcirculation = "Subcirculation";
	public static string Subcone = "Subcone";
	public static string Subcrossover = "Subcrossover";
	public static string Subdart = "Subdart";
	public static string Subfilter = "Subfilter";
	public static string Subfloat = "Subfloat";
	public static string Subjetting = "Subjetting";
	public static string Subjunk = "Subjunk";
	public static string Suborienting = "Suborienting";
	public static string Subported = "Subported";
	public static string SubpressureRelief = "SubpressureRelief";
	public static string SubpumpOut = "SubpumpOut";
	public static string Subrestrictor = "Subrestrictor";
	public static string Subsaver = "Subsaver";
	public static string Subshock = "Subshock";
	public static string SubsideEntry = "SubsideEntry";
	public static string Substop = "Substop";
	public static string CasingString = "CasingString";
	public static string ConductorDrivePipe = "ConductorDrivePipe";
	public static string Casing = "Casing";
	public static string Liners = "Liners";
	public static string Centralizers = "Centralizers";
	public static string Crossover = "Crossover";
	public static string Connection = "Connection";
	public static string Box = "Box";
	public static string Flange = "Flange";
	public static string Mandrel = "Mandrel";
	public static string Pin = "Pin";
	public static string ConnectionWelded = "ConnectionWelded";
	public static string Selfsealingthreaded = "Selfsealingthreaded";
	public static string Expandables = "Expandables";
	public static string TubingString = "TubingString";
	public static string ScreenString = "ScreenString";
	public static string TubularConnection = "TubularConnection";
	public static string TubularConfiguration = "TubularConfiguration";
	public static string PinDown = "PinDown";
	public static string PinUp = "PinUp";
	public static string Boxbox = "Boxbox";
	public static string Pinpin = "Pinpin";
	public static string DownholeEquipment = "DownholeEquipment";
	public static string DrillingEquipment = "DrillingEquipment";
	public static string DrillstemTerminator = "DrillstemTerminator";
	public static string DrillingBit = "DrillingBit";
	public static string RollingCutter = "RollingCutter";
	public static string Milltooth = "Milltooth";
	public static string InsertTci = "InsertTci";
	public static string FixedCutter = "FixedCutter";
	public static string Pdc = "Pdc";
	public static string Diamond = "Diamond";
	public static string PdcCore = "PdcCore";
	public static string DiamondCore = "DiamondCore";
	public static string HybridKymera = "HybridKymera";
	public static string Nozzles = "Nozzles";
	public static string BullNose = "BullNose";
	public static string Reamers = "Reamers";
	public static string RollerReamers = "RollerReamers";
	public static string RfidReamers = "RfidReamers";
	public static string NearbitReamers = "NearbitReamers";
	public static string FixedBladeReamers = "FixedBladeReamers";
	public static string BicenterReamerBit = "BicenterReamerBit";
	public static string ExpandableReamers = "ExpandableReamers";
	public static string HoleOpener = "HoleOpener";
	public static string Underreamers = "Underreamers";
	public static string FixedBlade = "FixedBlade";
	public static string CoringTool = "CoringTool";
	public static string InnerBarrel = "InnerBarrel";
	public static string OuterBarrel = "OuterBarrel";
	public static string DownholeMotor = "DownholeMotor";
	public static string TurbineMotor = "TurbineMotor";
	public static string PositiveDisplacementMotor = "PositiveDisplacementMotor";
	public static string OilBearing = "OilBearing";
	public static string MudLubeBearing = "MudLubeBearing";
	public static string SteerableMotor = "SteerableMotor";
	public static string InstrumentedMotor = "InstrumentedMotor";
	public static string AdjustableKickoffSub = "AdjustableKickoffSub";
	public static string RotarySteerableSystems = "RotarySteerableSystems";
	public static string Pointthebit = "Pointthebit";
	public static string Pushthebit = "Pushthebit";
	public static string ContinuousProportional = "ContinuousProportional";
	public static string JettingAssembly = "JettingAssembly";
	public static string HammerAssembly = "HammerAssembly";
	public static string JarringAssembly = "JarringAssembly";
	public static string JarAction = "JarAction";
	public static string MechanicalJar = "MechanicalJar";
	public static string HydraulicJar = "HydraulicJar";
	public static string HydromechanicalJar = "HydromechanicalJar";
	public static string Accelerator = "Accelerator";
	public static string Casingwhiledrilling = "Casingwhiledrilling";
	public static string DirectionalCasingWhileDrilling = "DirectionalCasingWhileDrilling";
	public static string LinerDrilling = "LinerDrilling";
	public static string SteerableLinerDrilling = "SteerableLinerDrilling";
	public static string CirculationSub = "CirculationSub";
	public static string Whipstock = "Whipstock";
	public static string FishingTools = "FishingTools";
	public static string Overshot = "Overshot";
	public static string Spear = "Spear";
	public static string JunkBasket = "JunkBasket";
	public static string Thruster = "Thruster";
	public static string ActiveVibrationTools = "ActiveVibrationTools";
	public static string BhaVibrationDampers = "BhaVibrationDampers";
	public static string VibrationIsolators = "VibrationIsolators";
	public static string NearBitVibrationDampers = "NearBitVibrationDampers";
	public static string IsolationSeal = "IsolationSeal";
	public static string CasingEquipment = "CasingEquipment";
	public static string CasingMillingTools = "CasingMillingTools";
	public static string MillCasingCutting = "MillCasingCutting";
	public static string MillDress = "MillDress";
	public static string MillFlatBottom = "MillFlatBottom";
	public static string MillHollow = "MillHollow";
	public static string MillPackerPickerAssembly = "MillPackerPickerAssembly";
	public static string MillPilot = "MillPilot";
	public static string MillPolish = "MillPolish";
	public static string MillSection = "MillSection";
	public static string MillTaper = "MillTaper";
	public static string MillWashover = "MillWashover";
	public static string MillWatermelon = "MillWatermelon";
	public static string CasingLinerEquipment = "CasingLinerEquipment";
	public static string CasingHead = "CasingHead";
	public static string ShoeTrack = "ShoeTrack";
	public static string FloatCollar = "FloatCollar";
	public static string FloatShoe = "FloatShoe";
	public static string LinerPacker = "LinerPacker";
	public static string DownholeValveAssembly = "DownholeValveAssembly";
	public static string PerforatingGuns = "PerforatingGuns";
	public static string Hangers = "Hangers";
	public static string TubingHanger = "TubingHanger";
	public static string CasingHanger = "CasingHanger";
	public static string LinerHanger = "LinerHanger";
	public static string Plugs = "Plugs";
	public static string InnerString = "InnerString";
	public static string LandingString = "LandingString";
	public static string CasingShoe = "CasingShoe";
	public static string CasingCutter = "CasingCutter";
	public static string LoggingEquipment = "LoggingEquipment";
	public static string EquipmentTelemetry = "EquipmentTelemetry";
	public static string MudPulse = "MudPulse";
	public static string WiredPipe = "WiredPipe";
	public static string Electromagnetic = "Electromagnetic";
	public static string Acoustic = "Acoustic";
	public static string Hybrid = "Hybrid";
	public static string WireCable = "WireCable";
	public static string PowerSystems = "PowerSystems";
	public static string DownholeAlternator = "DownholeAlternator";
	public static string DownholeBatteries = "DownholeBatteries";
	public static string SurfacePower = "SurfacePower";
	public static string LoggingWhileDrillingTools = "LoggingWhileDrillingTools";
	public static string LoggingWhileDrillingToolsAcoustictools = "LoggingWhileDrillingToolsAcoustictools";
	public static string AzimuthalTools = "AzimuthalTools";
	public static string LoggingWhileDrillingToolsElectricalpropagation = "LoggingWhileDrillingToolsElectricalpropagation";
	public static string LoggingWhileDrillingToolsElectricalresistivity = "LoggingWhileDrillingToolsElectricalresistivity";
	public static string FormationTestTools = "FormationTestTools";
	public static string ImagingTools = "ImagingTools";
	public static string LoggingWhileDrillingToolsNmrtools = "LoggingWhileDrillingToolsNmrtools";
	public static string LoggingWhileDrillingToolsNucleartools = "LoggingWhileDrillingToolsNucleartools";
	public static string LoggingWhileDrillingToolsSeismictools = "LoggingWhileDrillingToolsSeismictools";
	public static string MeasurementWhileDrillingTools = "MeasurementWhileDrillingTools";
	public static string DirectionalTool = "DirectionalTool";
	public static string MechanicsAndVibrationTools = "MechanicsAndVibrationTools";
	public static string PwdPressure = "PwdPressure";
	public static string WirelineLoggingTools = "WirelineLoggingTools";
	public static string OpenholeTools = "OpenholeTools";
	public static string CasedHoleTools = "CasedHoleTools";
	public static string ProductionTools = "ProductionTools";
	public static string WirelineLoggingToolsElectricalresistivity = "WirelineLoggingToolsElectricalresistivity";
	public static string WirelineLoggingToolsElectricalpropagation = "WirelineLoggingToolsElectricalpropagation";
	public static string SpontaneousPotential = "SpontaneousPotential";
	public static string WirelineLoggingToolsNucleartools = "WirelineLoggingToolsNucleartools";
	public static string WirelineLoggingToolsNmrtools = "WirelineLoggingToolsNmrtools";
	public static string WirelineLoggingToolsAcoustictools = "WirelineLoggingToolsAcoustictools";
	public static string DipmeterAndImagingTools = "DipmeterAndImagingTools";
	public static string FormationTestingAndSampling = "FormationTestingAndSampling";
	public static string WirelineLoggingToolsSeismictools = "WirelineLoggingToolsSeismictools";
	public static string CasingCollarLocator = "CasingCollarLocator";
	public static string FluidDensityTools = "FluidDensityTools";
	public static string FlowmeterTools = "FlowmeterTools";
	public static string CementBondLoggingTools = "CementBondLoggingTools";
	public static string PressureLoggingTools = "PressureLoggingTools";
	public static string CoiledTubingEquipment = "CoiledTubingEquipment";
	public static string CoiledTubingReel = "CoiledTubingReel";
	public static string InjectorHead = "InjectorHead";
	public static string TubingGuideArch = "TubingGuideArch";
	public static string PowerSupply = "PowerSupply";
	public static string ControlConsole = "ControlConsole";
	public static string ControlAndMonitoringEquipment = "ControlAndMonitoringEquipment";
	public static string DownholeCtConnectors = "DownholeCtConnectors";
	public static string CtBhaComponents = "CtBhaComponents";
	public static string WellcontrolStackEquipment = "WellcontrolStackEquipment";
	public static string GenericEquipment = "GenericEquipment";
	public static string GenericEquipmentGatevalve = "GenericEquipmentGatevalve";
	public static string ThreeWayManifold = "ThreeWayManifold";
	public static string ThreeWayValve = "ThreeWayValve";
	public static string DrillingIncident = "DrillingIncident";
	public static string AbnormalOscillation = "AbnormalOscillation";
	public static string AbnormalAxialOscillation = "AbnormalAxialOscillation";
	public static string AbnormalTorsionalOscillation = "AbnormalTorsionalOscillation";
	public static string AbnormalLateralOscillation = "AbnormalLateralOscillation";
	public static string StickSlip = "StickSlip";
	public static string HFTO = "HFTO";
	public static string Whirling = "Whirling";
	public static string ForwardWhirl = "ForwardWhirl";
	public static string BackwardWhirl = "BackwardWhirl";
	public static string ChaoticWhirl = "ChaoticWhirl";
	public static string Shock = "Shock";
	public static string TwistOff = "TwistOff";
	public static string Overpull = "Overpull";
	public static string Underpull = "Underpull";
	public static string Influx = "Influx";
	public static string LossCirculation = "LossCirculation";
	public static string HoleCollapse = "HoleCollapse";
	public static string StuckPipe = "StuckPipe";
	public static string PipeWashout = "PipeWashout";
	public static string FormationWashout = "FormationWashout";
	public static string OverTorque = "OverTorque";
	public static string Plugged = "Plugged";
	public static string DWISNoun = "DWISNoun";
	public static string DataEndPoint = "DataEndPoint";
	public static string WitsMLTimeBasedLogEndPoint = "WitsMLTimeBasedLogEndPoint";
	public static string EndPointMapping = "EndPointMapping";
	public static string PressureReference = "PressureReference";
	public static string AbsolutePressureReference = "AbsolutePressureReference";
	public static string RelativePressureReference = "RelativePressureReference";
	public static string GaugePressureReference = "GaugePressureReference";
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
	public static string MPDMainFlowPath = "MPDMainFlowPath";
	public static string MPDAlternateFlowPath = "MPDAlternateFlowPath";
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
	public static string EarthMagneticFluxDensityQuantity = "EarthMagneticFluxDensityQuantity";
	public static string ElectricTensionQuantity = "ElectricTensionQuantity";
	public static string ImageScaleQuantity = "ImageScaleQuantity";
	public static string SmallLengthQuantity = "SmallLengthQuantity";
	public static string RotationFrequencyQuantity = "RotationFrequencyQuantity";
	public static string LargeVolumeQuantity = "LargeVolumeQuantity";
	public static string PermeabilityQuantity = "PermeabilityQuantity";
	public static string YoungModulusQuantity = "YoungModulusQuantity";
	public static string StandardProportionQuantity = "StandardProportionQuantity";
	public static string StandardDimensionlessQuantity = "StandardDimensionlessQuantity";
	public static string StandardLengthQuantity = "StandardLengthQuantity";
	public static string FluidShearRateQuantity = "FluidShearRateQuantity";
	public static string FluidShearStressQuantity = "FluidShearStressQuantity";
	public static string RheologyConsistencyIndexQuantity = "RheologyConsistencyIndexQuantity";
	public static string SmallDiameterQuantity = "SmallDiameterQuantity";
	public static string SmallTorqueQuantity = "SmallTorqueQuantity";
	public static string SmallRotationFrequencyQuantity = "SmallRotationFrequencyQuantity";
	public static string SmallProportionQuantity = "SmallProportionQuantity";
	public static string PorosityQuantity = "PorosityQuantity";
	public static string BlockVelocityQuantity = "BlockVelocityQuantity";
	public static string CableDiameterQuantity = "CableDiameterQuantity";
	public static string CapillaryPressureQuantity = "CapillaryPressureQuantity";
	public static string DepthQuantity = "DepthQuantity";
	public static string DrillingAccelerationQuantity = "DrillingAccelerationQuantity";
	public static string DrillingAngleVariationGradientQuantity = "DrillingAngleVariationGradientQuantity";
	public static string DrillingAngularVelocityQuantity = "DrillingAngularVelocityQuantity";
	public static string DrillingAreaQuantity = "DrillingAreaQuantity";
	public static string DrillingAxialVelocityQuantity = "DrillingAxialVelocityQuantity";
	public static string DrillingCompressibilityQuantity = "DrillingCompressibilityQuantity";
	public static string DrillingCurvatureQuantity = "DrillingCurvatureQuantity";
	public static string DrillingDensityGradientDepthQuantity = "DrillingDensityGradientDepthQuantity";
	public static string DrillingDensityGradientTemperatureQuantity = "DrillingDensityGradientTemperatureQuantity";
	public static string DrillingDensityQuantity = "DrillingDensityQuantity";
	public static string DrillingDensityRateOfChangeQuantity = "DrillingDensityRateOfChangeQuantity";
	public static string DrillingDrillStringMagneticFluxQuantity = "DrillingDrillStringMagneticFluxQuantity";
	public static string DrillingDurationQuantity = "DrillingDurationQuantity";
	public static string DrillingDynamicViscosityQuantity = "DrillingDynamicViscosityQuantity";
	public static string DrillingElongationGradientQuantity = "DrillingElongationGradientQuantity";
	public static string DrillingFluidVelocityQuantity = "DrillingFluidVelocityQuantity";
	public static string DrillingForceGradientQuantity = "DrillingForceGradientQuantity";
	public static string DrillingForceQuantity = "DrillingForceQuantity";
	public static string DrillingHeatTransferCoefficientQuantity = "DrillingHeatTransferCoefficientQuantity";
	public static string DrillingHydraulicConductivityQuantity = "DrillingHydraulicConductivityQuantity";
	public static string DrillingInterfacialTensionQuantity = "DrillingInterfacialTensionQuantity";
	public static string DrillingMassGradientQuantity = "DrillingMassGradientQuantity";
	public static string DrillingMassQuantity = "DrillingMassQuantity";
	public static string DrillingMassRateQuantity = "DrillingMassRateQuantity";
	public static string DrillingPlaneAngleQuantity = "DrillingPlaneAngleQuantity";
	public static string DrillingPressureGradientQuantity = "DrillingPressureGradientQuantity";
	public static string DrillingPressureLossConstantQuantity = "DrillingPressureLossConstantQuantity";
	public static string DrillingPressureQuantity = "DrillingPressureQuantity";
	public static string DrillingRandomWalkQuantity = "DrillingRandomWalkQuantity";
	public static string DrillingRotationFrequencyRateOfChangeQuantity = "DrillingRotationFrequencyRateOfChangeQuantity";
	public static string DrillingSpecificHeatCapacityQuantity = "DrillingSpecificHeatCapacityQuantity";
	public static string DrillingSpecificHeatCapacityTemperatureGradientQuantity = "DrillingSpecificHeatCapacityTemperatureGradientQuantity";
	public static string DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity = "DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity";
	public static string DrillingSurveyInstrumentAngularVelocityQuantity = "DrillingSurveyInstrumentAngularVelocityQuantity";
	public static string DrillingSurveyInstrumentReciprocalLengthQuantity = "DrillingSurveyInstrumentReciprocalLengthQuantity";
	public static string DrillingTemperatureGradientQuantity = "DrillingTemperatureGradientQuantity";
	public static string DrillingTemperatureQuantity = "DrillingTemperatureQuantity";
	public static string DrillingTensionQuantity = "DrillingTensionQuantity";
	public static string DrillingThermalConductivityQuantity = "DrillingThermalConductivityQuantity";
	public static string DrillingThermalConductivityTemperatureGradientQuantity = "DrillingThermalConductivityTemperatureGradientQuantity";
	public static string DrillingTorqueQuantity = "DrillingTorqueQuantity";
	public static string DrillingVolumeQuantity = "DrillingVolumeQuantity";
	public static string DrillingVolumetricFlowRateOfChangeQuantity = "DrillingVolumetricFlowRateOfChangeQuantity";
	public static string DrillingVolumetricFlowrateQuantity = "DrillingVolumetricFlowrateQuantity";
	public static string DrillStemMaterialStrengthQuantity = "DrillStemMaterialStrengthQuantity";
	public static string FormationResistivityQuantity = "FormationResistivityQuantity";
	public static string FormationStrengthQuantity = "FormationStrengthQuantity";
	public static string GammaRayQuantity = "GammaRayQuantity";
	public static string GasShowQuantity = "GasShowQuantity";
	public static string GasVolumetricFlowRateQuantity = "GasVolumetricFlowRateQuantity";
	public static string HeightQuantity = "HeightQuantity";
	public static string HookLoadQuantity = "HookLoadQuantity";
	public static string NozzleDiameterQuantity = "NozzleDiameterQuantity";
	public static string PipeDiameterQuantity = "PipeDiameterQuantity";
	public static string PoreDiameterQuantity = "PoreDiameterQuantity";
	public static string PoreSurfaceQuantity = "PoreSurfaceQuantity";
	public static string PositionQuantity = "PositionQuantity";
	public static string RateOfPenetrationQuantity = "RateOfPenetrationQuantity";
	public static string WeightOnBitQuantity = "WeightOnBitQuantity";
	public static string DrillStemMechanicalModel = "DrillStemMechanicalModel";
	public static string MechanicalStiffnessType = "MechanicalStiffnessType";
	public static string MechanicalSoftModel = "MechanicalSoftModel";
	public static string MechanicalStiffModel = "MechanicalStiffModel";
	public static string MechanicalStiffModelAssumedContacts = "MechanicalStiffModelAssumedContacts";
	public static string MechanicalStiffModelEstimatedContacts = "MechanicalStiffModelEstimatedContacts";
	public static string TangencyLength = "TangencyLength";
	public static string MechanicalElementState = "MechanicalElementState";
	public static string MechanicallyClosedState = "MechanicallyClosedState";
	public static string MechanicallyOpenState = "MechanicallyOpenState";
	public static string MechanicallyActiveState = "MechanicallyActiveState";
	public static string MechanicallyInactiveState = "MechanicallyInactiveState";
	public static string MechanicallyConnectedState = "MechanicallyConnectedState";
	public static string MechanicalLogicalElement = "MechanicalLogicalElement";
	public static string MotionType = "MotionType";
	public static string AxialMotionType = "AxialMotionType";
	public static string TorsionalMotionType = "TorsionalMotionType";
	public static string LateralMotionType = "LateralMotionType";
	public static string ModelType = "ModelType";
	public static string DeterministicModel = "DeterministicModel";
	public static string StochasticModel = "StochasticModel";
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
	public static string StickUpHeightVerticalLocation = "StickUpHeightVerticalLocation";
	public static string MinDrillHeightVerticalLocation = "MinDrillHeightVerticalLocation";
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
	public static string ToolJoint1ReferenceLocation = "ToolJoint1ReferenceLocation";
	public static string ToolJoint2ReferenceLocation = "ToolJoint2ReferenceLocation";
	public static string ToolJoint3ReferenceLocation = "ToolJoint3ReferenceLocation";
	public static string ToolJoint4ReferenceLocation = "ToolJoint4ReferenceLocation";
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
	public static string MeasurableQuantityUnitAssociation = "MeasurableQuantityUnitAssociation";
	public static string Quantity = "Quantity";
	public static string Unit = "Unit";
	public static string UnitSystem = "UnitSystem";
	public static string AccelerationQuantity = "AccelerationQuantity";
	public static string AmountSubstanceQuantity = "AmountSubstanceQuantity";
	public static string AngleMagneticFluxDensityQuantity = "AngleMagneticFluxDensityQuantity";
	public static string AngleVariationGradientQuantity = "AngleVariationGradientQuantity";
	public static string AngularVelocityQuantity = "AngularVelocityQuantity";
	public static string AreaQuantity = "AreaQuantity";
	public static string CompressibilityQuantity = "CompressibilityQuantity";
	public static string CurvatureQuantity = "CurvatureQuantity";
	public static string DensityGradientDepthQuantity = "DensityGradientDepthQuantity";
	public static string DensityGradientTemperatureQuantity = "DensityGradientTemperatureQuantity";
	public static string DensityQuantity = "DensityQuantity";
	public static string DensityRateOfChangeQuantity = "DensityRateOfChangeQuantity";
	public static string DimensionlessQuantity = "DimensionlessQuantity";
	public static string DynamicViscosityQuantity = "DynamicViscosityQuantity";
	public static string ElectricalCapacitanceQuantity = "ElectricalCapacitanceQuantity";
	public static string ElectricCurrentQuantity = "ElectricCurrentQuantity";
	public static string ElongationGradientQuantity = "ElongationGradientQuantity";
	public static string EnergyQuantity = "EnergyQuantity";
	public static string LengthQuantity = "LengthQuantity";
	public static string LuminousIntensityQuantity = "LuminousIntensityQuantity";
	public static string MassQuantity = "MassQuantity";
	public static string PlaneAngleQuantity = "PlaneAngleQuantity";
	public static string RelativeTemperatureQuantity = "RelativeTemperatureQuantity";
	public static string SolidAngleQuantity = "SolidAngleQuantity";
	public static string TemperatureQuantity = "TemperatureQuantity";
	public static string TimeQuantity = "TimeQuantity";
	public static string PressureQuantity = "PressureQuantity";
	public static string VolumetricFlowRateQuantity = "VolumetricFlowRateQuantity";
	public static string VolumetricFlowRateOfChangeQuantity = "VolumetricFlowRateOfChangeQuantity";
	public static string VelocityQuantity = "VelocityQuantity";
	public static string ForceGradientQuantity = "ForceGradientQuantity";
	public static string ForceQuantity = "ForceQuantity";
	public static string MaterialStrengthQuantity = "MaterialStrengthQuantity";
	public static string FrequencyQuantity = "FrequencyQuantity";
	public static string ProportionQuantity = "ProportionQuantity";
	public static string HeatTransferCoefficientQuantity = "HeatTransferCoefficientQuantity";
	public static string GravitationalLoadQuantity = "GravitationalLoadQuantity";
	public static string HydraulicConductivityQuantity = "HydraulicConductivityQuantity";
	public static string InterfacialTensionQuantity = "InterfacialTensionQuantity";
	public static string VolumeQuantity = "VolumeQuantity";
	public static string MagneticFluxDensityQuantity = "MagneticFluxDensityQuantity";
	public static string MassRateQuantity = "MassRateQuantity";
	public static string PressureGradientQuantity = "PressureGradientQuantity";
	public static string PressureLossConstantQuantity = "PressureLossConstantQuantity";
	public static string ResistivityQuantity = "ResistivityQuantity";
	public static string FrequencyRateOfChangeQuantity = "FrequencyRateOfChangeQuantity";
	public static string RotationFrequencyRateOfChangeQuantity = "RotationFrequencyRateOfChangeQuantity";
	public static string SpecificHeatCapacityQuantity = "SpecificHeatCapacityQuantity";
	public static string SpecificHeatCapacityTemperatureGradientQuantity = "SpecificHeatCapacityTemperatureGradientQuantity";
	public static string TemperatureGradientQuantity = "TemperatureGradientQuantity";
	public static string TensionQuantity = "TensionQuantity";
	public static string ThermalConductivityQuantity = "ThermalConductivityQuantity";
	public static string MassGradientQuantity = "MassGradientQuantity";
	public static string ThermalConductivityTemperatureGradientQuantity = "ThermalConductivityTemperatureGradientQuantity";
	public static string TorqueQuantity = "TorqueQuantity";
	public static string MagneticFluxQuantity = "MagneticFluxQuantity";
	public static string RandomWalkQuantity = "RandomWalkQuantity";
	public static string WaveNumberQuantity = "WaveNumberQuantity";
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
	public static string Clock = "Clock";
	public static string SynchronizationGroup = "SynchronizationGroup";
	public static string TimeReference = "TimeReference";
	public static string AbsoluteTimeReference = "AbsoluteTimeReference";
	public static string RelativeTimeReference = "RelativeTimeReference";
	public static string GPSReference = "GPSReference";
	public static string UTCReference = "UTCReference";
	public static string LocalTimeReference = "LocalTimeReference";
	public static string TimeSpanReference = "TimeSpanReference";
	public static string SignalUncertainty = "SignalUncertainty";
	public static string GaussianUncertainty = "GaussianUncertainty";
	public static string GenericUncertainty = "GenericUncertainty";
	public static string MinMaxUncertainty = "MinMaxUncertainty";
	public static string FullScaleUncertainty = "FullScaleUncertainty";
	public static string SensorUncertainty = "SensorUncertainty";
}
}
