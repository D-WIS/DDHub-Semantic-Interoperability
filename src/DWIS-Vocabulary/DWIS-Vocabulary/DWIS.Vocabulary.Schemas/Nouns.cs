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
AdvisorySystemAdvice,
DigitalTwinAdvice,
DrillingStandardProcedureAdvice,
DrillingControlAdvice,
DrillingSafeOperatingEnvelopeAdvice,
DrillingFaultDetectionIsolationAndRecoveryAdvice,
ContextualData,
Plan,
OperationalPlan,
DrillingProgram,
RigActionPlan,
ConfigurationData,
WellBoreData,
TrajectoryDescription,
FluidDescription,
DrillingFluidDescription,
CementFluidDescription,
CompletionFluidDescription,
WellboreArchitectureDescription,
DrillStemDescription,
DrillStringDescription,
CasingStringDescription,
LinerStringDescription,
ProductionStringDescription,
GeoPressuresDescription,
GeoThermalDescription,
FormationStrengthDescription,
StratigraphyDescription,
RigDescription,
WellBoreDataCharateristic,
Planned,
Prognosed,
Measured,
Current,
Extrapolated,
DataFlowNode,
ComputedState,
ProceduralState,
ProcessState,
PhysicalState,
ComputationUnit,
Advisor,
Simulator,
Interpreter,
Controller,
ControlSystem,
HoistingControlSystem,
CirculationControlSystem,
RotationControlSystem,
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
CompletionServiceCompany,
DataAnalysisServiceCompany,
DrillingContractor,
DWISInternalService,
DWISBlackboard,
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
AcousticTelemetry,
WiredPipeTelemetry,
InductionCouplingDownholeTelemetry,
ElectromagneticCouplingDownholeTelemetry,
GalvanicCouplingDownholeTelemetry,
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
JSonDataType,
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
DifferentiallyStuck,
PipeWashout,
FormationWashout,
OverTorque,
Plugged,
PackOff,
MotorStall,
DrillingLimit,
AxialVelocityLimit,
RotationalVelocityLimit,
FlowrateLimit,
ROPLimit,
WOBLimit,
DifferentialPressureLimit,
DrillingObjective,
StableAxialVelocityObjective,
StableRotationalVelocityObjective,
StablePressureObjective,
StableTorqueObjective,
StableAxialForceObjective,
WeightTransferObjective,
DrillingProcedure,
CirculationStartupProcedure,
CirculationStopProcedure,
RotationStartupProcedure,
RotationStopProcedure,
HoistProcedure,
TagBottomProcedure,
ReciprocationProcedure,
FrictionTestProcedure,
SlowCirculationRateProcedure,
PressureIntegrityTestProcedure,
FlowCheckProcedure,
CementingProcedure,
DownlinkingProcedure,
ToolfaceOrientationProcedure,
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
ConsistencyIndexRheologyQuantity,
ElectricTensionQuantity,
ImageScaleQuantity,
DiameterSmallQuantity,
DimensionLessStandardQuantity,
EarthMagneticFluxDensityQuantity,
ElasticModulusQuantity,
LengthSmallQuantity,
RotationalFrequencyQuantity,
VolumeLargeQuantity,
ProportionStandardQuantity,
LengthStandardQuantity,
FluidShearRateQuantity,
FluidShearStressQuantity,
TorqueSmallQuantity,
RotationalFrequencySmallQuantity,
ProportionSmallQuantity,
PorosityQuantity,
StrokeFrequencyQuantity,
ShockRateQuantity,
AccelerationDrillingQuantity,
AngleGradientPerLengthDrillingQuantity,
AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity,
AngularAccelerationDrillingQuantity,
AngularVelocityDrillingQuantity,
AngularVelocitySurveyInstrumentDrillingQuantity,
AreaDrillingQuantity,
AxialVelocityDrillingQuantity,
BlockVelocityDrillingQuantity,
CableDiameterDrillingQuantity,
CapillaryPressureDrillingQuantity,
CompressibilityDrillingQuantity,
CurvatureDrillingQuantity,
DepthDrillingQuantity,
DiameterPipeDrillingQuantity,
DiameterPoreDrillingQuantity,
DrillStemMaterialStrengthDrillingQuantity,
DrillStringMagneticFluxDrillingQuantity,
DurationDrillingQuantity,
DynamicViscosityDrillingQuantity,
ElongationGradientPerLengthDrillingQuantity,
EnergyDensityDrillingQuantity,
MassDensityRateOfChangeDrillingQuantity,
MassDensityGradientPerTemperatureDrillingQuantity,
MassDensityGradientPerLengthDrillingQuantity,
MassDensityDrillingQuantity,
FluidVelocityDrillingQuantity,
ForceGradientPerLengthDrillingQuantity,
ForceDrillingQuantity,
HeatTransferCoefficientDrillingQuantity,
HydraulicConductivityDrillingQuantity,
InterfacialTensionDrillingQuantity,
MassGradientPerLengthDrillingQuantity,
MassDrillingQuantity,
MassRateDrillingQuantity,
PlaneAngleDrillingQuantity,
PowerDrillingQuantity,
PressureGradientPerLengthDrillingQuantity,
PressureLossConstantDrillingQuantity,
PressureDrillingQuantity,
RandomWalkDrillingQuantity,
RotationalFrequencyRateOfChangeDrillingQuantity,
IsobaricSpecificHeatCapacityDrillingQuantity,
IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity,
StickDurationDrillingQuantity,
ReciprocalLengthSurveyInstrumentDrillingQuantity,
TemperatureGradientPerLengthDrillingQuantity,
TemperatureDrillingQuantity,
TensionDrillingQuantity,
ThermalConductivityDrillingQuantity,
TorqueDrillingQuantity,
VolumeDrillingQuantity,
VolumetricFlowRateOfChangeDrillingQuantity,
VolumetricFlowrateDrillingQuantity,
FormationResistivityDrillingQuantity,
FormationStrengthDrillingQuantity,
GammaRayIndexDrillingQuantity,
GasShowDrillingQuantity,
GasVolumetricFlowRateDrillingQuantity,
HeightDrillingQuantity,
HookLoadDrillingQuantity,
NozzleDiameterDrillingQuantity,
SurfacePoreDrillingQuantity,
PositionDrillingQuantity,
RateOfPenetrationDrillingQuantity,
WeightOnBitDrillingQuantity,
ThermalConductivityGradientPerTemperatureDrillingQuantity,
TorqueGradientPerLengthDrillingQuantity,
PorousMediumPermeabilityDrillingQuantity,
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
TemporalBehaviorModel,
SteadyStateModel,
TransientModel,
ModelingApproach,
ForwardModel,
InversionModel,
HybridAnalysisModel,
ModelingParadigm,
EmpiricalModel,
MechanisticModel,
PhysicsInformedDataDrivenModel,
MathematicalFormulation,
AlgebraicModel,
OrdinaryDifferentialEquationModel,
PartialDifferentialEquationModel,
IntegralModel,
ModelingObjective,
PredictiveModel,
DescriptiveModel,
CalibrationModel,
ControlModel,
ModelScope,
GeneralModel,
SpecializedModel,
ModelTransparency,
BlackBoxModel,
GrayBoxModel,
WhiteBoxModel,
DataIntegrationStrategy,
DataLevelIntegationModel,
FeatureLevelIntegationModel,
DecisionLevelIntegationModel,
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
AngleGradientPerLengthQuantity,
AngleMagneticFluxDensityQuantity,
AngularAccelerationQuantity,
AngularVelocityQuantity,
AreaQuantity,
CompressibilityQuantity,
CurvatureQuantity,
MassDensityGradientPerLengthQuantity,
MassDensityGradientPerTemperatureQuantity,
MassDensityQuantity,
MassDensityRateOfChangeQuantity,
DimensionlessQuantity,
DynamicViscosityQuantity,
ElectricCapacitanceQuantity,
ElectricCurrentQuantity,
ElongationGradientPerLengthQuantity,
EnergyDensityQuantity,
ForceGradientPerLengthQuantity,
ForceQuantity,
FrequencyQuantity,
FrequencyRateOfChangeQuantity,
HeatTransferCoefficientQuantity,
InterfacialTensionQuantity,
LengthQuantity,
LuminousIntensityQuantity,
MagneticFluxDensityQuantity,
MagneticFluxQuantity,
MassGradientPerLengthQuantity,
MassRateQuantity,
MaterialStrengthQuantity,
PorousMediumPermeabilityQuantity,
PlaneAngleQuantity,
PowerQuantity,
PressureGradientPerLengthQuantity,
PressureLossConstantQuantity,
PressureQuantity,
ProportionQuantity,
RandomWalkQuantity,
RelativeTemperatureQuantity,
ElectricResistivityQuantity,
SolidAngleQuantity,
IsobaricSpecificHeatCapacityQuantity,
IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity,
StressQuantity,
TemperatureGradientPerLengthQuantity,
TemperatureQuantity,
ThermalConductivityQuantity,
ThermalConductivityGradientPerTemperatureQuantity,
TimeQuantity,
TorqueGradientPerLengthQuantity,
TorqueQuantity,
VelocityQuantity,
VolumeQuantity,
VolumetricFlowRateOfChangeQuantity,
VolumetricFlowRateQuantity,
WaveNumberQuantity,
MassQuantity,
EnergyQuantity,
GravitationalLoadQuantity,
HydraulicConductivityQuantity,
RotationalFrequencyRateOfChangeQuantity,
TensionQuantity,
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
SensorUncertainty,
MetrePerSecondSquared,
FootPerSecondSquared,
CentimetrePerSecondSquared,
CentimetrePerHourPerSecond,
CentimetrePerMinutePerSecond,
FootPerHourPerSecond,
FootPerMinutePerSecond,
Galileo,
GravityStandard,
InchPerHourPerSecond,
InchPerMinutePerSecond,
InchPerSecondSquared,
KnotPerSecond,
MetrePerSecondPerMillisecond,
MilePerHourPerSecond,
MilePerMinutePerSecond,
MilePerSecondSquared,
KilometrePerSecondSquared,
KilometrePerHourPerSecond,
KilometrePerMinutePerSecond,
Mole,
Decimole,
Centimole,
Millimole,
Micromole,
Nanomole,
Picomole,
Kilomole,
RadianPerMetre,
DegreePerMetre,
DegreePerCentimetre,
DegreePerFoot,
DegreePerInch,
DegreePerDecimetre,
DegreePerMillimetre,
RadianPerMillimetre,
RadianPerCentimetre,
RadianPerDecimetre,
RadianPerFoot,
RadianPerInch,
RadianTesla,
RadianGauss,
RadianMilligauss,
RadianMillitesla,
RadianMicrotesla,
RadianNanotesla,
RadianMaxwellPerSquareCentimetre,
RadianWeberPerSquareMetre,
DegreeTesla,
DegreeGauss,
DegreeMilligauss,
DegreeMillitesla,
DegreeMicrotesla,
DegreeNanotesla,
DegreeMaxwellPerSquareCentimetre,
DegreeWeberPerSquareMetre,
RadianPerSecondSquared,
DegreePerSecondSquared,
RadianPerDayPerSecond,
RadianPerHourPerSecond,
RadianPerMinutePerSecond,
DegreePerDayPerSecond,
DegreePerHourPerSecond,
DegreePerMinutePerSecond,
RadianPerSecondPerMinute,
DegreePerSecondPerMinute,
RadianPerDayPerMinute,
RadianPerHourPerMinute,
RadianPerMinuteSquared,
DegreePerDayPerMinute,
DegreePerHourPerMinute,
DegreePerMinuteSquared,
RadianPerSecondPerHour,
DegreePerSecondPerHour,
RadianPerDayPerHour,
RadianPerHourSquared,
RadianPerMinutePerHour,
DegreePerDayPerHour,
DegreePerHourSquared,
DegreePerMinutePerHour,
RadianPerSecondPerDay,
DegreePerSecondPerDay,
RadianPerDaySquared,
RadianPerHourPerDay,
RadianPerMinutePerDay,
DegreePerDaySquared,
DegreePerHourPerDay,
DegreePerMinutePerDay,
RadianPerSecond,
DegreePerSecond,
RadianPerDay,
RadianPerHour,
RadianPerMinute,
DegreePerDay,
DegreePerHour,
DegreePerMinute,
SquareMetre,
SquareKilometre,
Hectare,
SquareDecametre,
SquareDecimetre,
SquareCentimetre,
SquareMillimetre,
SquareMicrometre,
SquareFoot,
SquareInch,
SquareYard,
Acre,
SquareMile,
InversePascal,
InverseBar,
InversePoundPerSquareInch,
InverseAtmosphere,
PascalSecond,
MicropascalSecond,
Centipoise,
Micropoise,
PoundSecondPer100SquareFoot,
DyneSecondPerSquareCentimetre,
DegreePer10m,
DegreePer30m,
DegreePer30ft,
DegreePer100ft,
DegreePerDecimeter,
DegreePerCentimeter,
DegreePerMillimeter,
DegreePerMicrometer,
DegreePerNanometer,
DegreePerDecameter,
DegreePerHectometer,
DegreePerKilometer,
RadianPerDecimeter,
RadianPerCentimeter,
RadianPerMillimeter,
RadianPerMicrometer,
RadianPerNanometer,
RadianPerDecameter,
RadianPerHectometer,
RadianPerKilometer,
DegreePerYard,
DegreePerMile,
RadianPerYard,
RadianPerMile,
KilogramPerCubicMetrePerMetre,
SpecificGravityPerMetre,
SpecificGravityPer10Metre,
SpecificGravityPer30Metre,
SpecificGravityPer100Metre,
GramPerCubicCentimetrePer100Metre,
PoundPerGallonUkPerFoot,
PoundPerGallonUkPer30Foot,
PoundPerGallonUkPer100Foot,
PoundPerGallonUsPerFoot,
PoundPerGallonUsPer30Foot,
PoundPerGallonUsPer100Foot,
KilogramPerCubicMetrePer10Metre,
KilogramPerCubicMetrePer30Metre,
KilogramPerCubicMetrePer100Metre,
GramPerCubicCentimetrePerMetre,
GramPerCubicCentimetrePer10Metre,
GramPerCubicCentimetrePer30Metre,
PoundPerCubicFootPerFoot,
PoundPerCubicFootPer30Foot,
PoundPerCubicFootPer100Foot,
PoundPerCubicInchPerFoot,
PoundPerCubicInchPer30Foot,
PoundPerCubicInchPer100Foot,
PoundPerCubicYardPerFoot,
PoundPerCubicYardPer30Foot,
PoundPerCubicYardPer100Foot,
KilogramPerCubicMetrePerKelvin,
SpecificGravityPerCelsius,
GramPerCubicCentimetrePerCelsius,
PoundPerGallonUkPerCelsius,
PoundPerGallonUsPerFahrenheit,
PoundPerGallonUkPerFahrenheit,
PoundPerGallonUsPerCelsius,
PoundPerCubicFootPerCelsius,
PoundPerCubicFootPerFahrenheit,
PoundPerCubicInchPerCelsius,
PoundPerCubicInchPerFahrenheit,
PoundPerCubicYardPerCelsius,
PoundPerCubicYeardPerFahrenheit,
KilogramPerCubicMetre,
GramPerCubicMetre,
SpecificGravity,
GramPerCubicCentimetre,
PoundPerGallonUk,
PoundPerGallonUs,
PoundPerCubicFoot,
PoundPerCubicInch,
PoundPerCubicYard,
KilogramPerCubicMetrePerSecond,
SpecificGravityPerSecond,
SpecificGravityPerMinute,
SpecificGravityPerHour,
GramPerCubicCentimetrePerSecond,
GramPerCubicCentimetrePerMinute,
GramPerCubicCentimetrePerHour,
PoundPerGallonUkPerSecond,
PoundPerGallonUkPerMinute,
PoundPerGallonUkPerHour,
PoundPerGallonUsPerSecond,
PoundPerGallonUsPerMinute,
PoundPerGallonUsPerHour,
Dimensionless,
MillipascalSecond,
Poise,
Millipoise,
PoundSecondPerSquareFoot,
PoundSecondPerSquareInch,
Farad,
CoulombPerVolt,
Millifarad,
Microfarad,
Nanofarad,
Picofarad,
Ampere,
CoulombPerSecond,
SiemensVolt,
VoltPerOhm,
WattPerVolt,
WeberPerHenry,
Deciampere,
Centiampere,
Milliampere,
Microampere,
Nanoampere,
Picoampere,
Biot,
Abampere,
Kiloampere,
Megaampere,
Gigaampere,
Teraampere,
Statampere,
Volt,
Millivolt,
Centivolt,
Microvolt,
Nanovolt,
Picovolt,
Kilovolt,
Megavolt,
Gigavolt,
MetrePerMetre,
DecimetrePerMetre,
CentimetrePerMetre,
MillimetrePerMetre,
MicrometrePerMetre,
MetrePerKilometre,
DecimetrePerKilometre,
CentimetrePerKilometre,
MillimetrePerKilometre,
MicrometrePerKilometre,
InchPerFoot,
InchPerYard,
InchPerMile,
FootPerFoot,
FootPerYard,
FootPerMile,
YardPerFoot,
YardPerYard,
YardPerMile,
JoulePerCubicMetre,
JoulePerLitre,
KilojoulePerCubicMetre,
KilojoulePerLitre,
MegajoulePerCubicMetre,
MegajoulePerLitre,
GigajoulePerCubicMetre,
GigajoulePerLitre,
CaloriePerCubicMetre,
CaloriePerLitre,
KilocaloriePerCubicMetre,
KilocaloriePerLitre,
JoulePerCubicFoot,
KilojoulePerCubicFoot,
MegajoulePerCubicFoot,
GigajoulePerCubicFoot,
CaloriePerCubicFoot,
KilocaloriePerCubicFoot,
JoulePerCubicInch,
KilojoulePerCubicInch,
MegajoulePerCubicInch,
GigajoulePerCubicInch,
CaloriePerCubicInch,
KilocaloriePerCubicInch,
JoulePerGallonUk,
KilojoulePerGallonUk,
MegajoulePerGallonUk,
GigajoulePerGallonUk,
CaloriePerGallonUk,
KilocaloriePerGallonUk,
JoulePerGallonUs,
KilojoulePerGallonUs,
MegajoulePerGallonUs,
GigajoulePerGallonUs,
CaloriePerGallonUs,
KilocaloriePerGallonUs,
BritishThermalUnitPerCubicMetre,
BritishThermalUnitPerLitre,
BritishThermalUnitPerCubicFoot,
BritishThermalUnitPerCubicInch,
BritishThermalUnitPerGallonUk,
BritishThermalUnitPerGallonUs,
KiloBritishThermalUnitPerCubicMetre,
KiloBritishThermalUnitPerLitre,
KiloBritishThermalUnitPerCubicFoot,
KiloBritishThermalUnitPerCubicInch,
KiloBritishThermalUnitPerGallonUk,
KiloBritishThermalUnitPerGallonUs,
NewtonPerMetre,
NewtonPer30Metre,
NewtonPer10Metre,
NewtonPerDecimetre,
NewtonPerCentimetre,
NewtonPerMillimetre,
DecanewtonPerMetre,
DecanewtonPer30Metre,
DecanewtonPer10Metre,
DecanewtonPerDecimetre,
DecanewtonPerCentimetre,
DecanewtonPerMillimetre,
KilonewtonPerMetre,
KilonewtonPer30Metre,
KilonewtonPer10Metre,
KilonewtonPerDecimetre,
KilonewtonPerCentimetre,
KilonewtonPerMillimetre,
PoundPerFoot,
PoundPerInch,
KilopoundPerFoot,
KilopoundPerInch,
PoundPer30Foot,
PoundPer100Foot,
KilopoundPer30Foot,
KilopoundPer100Foot,
Newton,
Decanewton,
Kilonewton,
Kilodecanewton,
KilogramForce,
PoundForce,
KilopoundForce,
Hertz,
ReciprocalSecond,
Kilohertz,
Megahertz,
Gigahertz,
Terahertz,
Rpm,
Spm,
RotationPerSecond,
StrokePerSecond,
StrokePerHour,
RotationPerHour,
ShockPerSecond,
ShockPerMinute,
ShockPerHour,
HertzPerSecond,
KiloHertzPerSecond,
MegaHertzPerSecond,
GigaHertzPerSecond,
HertzPerMinute,
KiloHertzPerMinute,
MegaHertzPerMinute,
GigaHertzPerMinute,
HertzPerHour,
KiloHertzPerHour,
MegaHertzPerHour,
GigaHertzPerHour,
HertzPerDay,
KiloHertzPerDay,
MegaHertzPerDay,
GigaHertzPerDay,
HertzPerYear,
KiloHertzPerYear,
MegaHertzPerYear,
GigaHertzPerYear,
RpmPerSecond,
SpmPerSecond,
WattPerSquareMetrePerKelvin,
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit,
DotPerMetre,
DotPerInch,
DotPerMillimetre,
DotPerMicrometre,
MillinewtonPerMetre,
DynePerCentimetre,
PoundPerSecondSquared,
Metre,
Decimetre,
Centimetre,
Millimetre,
Micrometre,
Nanometre,
Aangstroem,
Picometre,
Decametre,
Hectometre,
Kilometre,
AstronomicalUnit,
LightYear,
Parsec,
Foot,
UsSurveyFoot,
Inch,
Yard,
Fathom,
SurveyorSChain,
Mile,
InternationalNauticalMile,
UkNauticalMile,
ScandinavianMile,
InchPer32,
Mil,
Thou,
Hand,
Furlong,
Candela,
LumenPerSteradian,
Millicandela,
Kilocandela,
Hefnerkerze,
InternationalCandle,
DecimalCandle,
BerlinerLichteinheit,
DvwgCandle,
Violle,
Carcel,
Tesla,
Gauss,
Milligauss,
Millitesla,
Microtesla,
Nanotesla,
MaxwellPerSquareCentimetre,
WeberPerSquareMetre,
Weber,
Milliweber,
Microweber,
VoltSecond,
UnitPole,
Megaline,
Kiloline,
Line,
Maxwell,
TeslaSquareMetre,
TeslaSquareCentimetre,
GaussSquareCentimetre,
MagneticFluxQuantum,
KilogramPerMetre,
GramPerMetre,
KilogramPerSecond,
KilogramPerMinute,
KilogramPerHour,
KilogramPerYear,
PoundPerSecond,
PoundPerMinute,
PoundPerHour,
PoundPerYear,
Pascal,
Megapascal,
Gigapascal,
Psi,
PoundPer100SquareFoot,
MegapoundPerSquareInch,
Darcy,
Millidarcy,
Microdarcy,
Nanodarcy,
Radian,
Milliradian,
Degree,
Grad,
Gon,
Circle,
Revolution,
Quadrant,
Sextant,
Octant,
ArcMinute,
ArcSecond,
Watt,
Decawatt,
Hectowatt,
Kilowatt,
Megawatt,
Gigawatt,
Terawatt,
Petawatt,
Exawatt,
Deciwatt,
Centiwatt,
Milliwatt,
Microwatt,
Nanowatt,
Picowatt,
Femtowatt,
Attowatt,
PascalPerMetre,
BarPerMetre,
PsiPerMetre,
PsiPerFoot,
PressureLossConstantSi,
PressureLossConstantMetric,
PressureLossConstantUk,
PressureLossConstantUs,
Kilopascal,
Bar,
Millibar,
Microbar,
PoundPerSquareInch,
KilopoundPerSquareInch,
StandardAtmosphere,
PoundPerSquareFoot,
NewtonPerSquareMetre,
NewtonPerSquareCentimetre,
NewtonPerSquareMillimetre,
KilonewtonPerSquareMetre,
Torr,
CentimetreMercuryAtZeroDegreeCelsius,
MillimetreMercuryAtZeroDegreeCelsius,
InchMercuryAt32DegreeFahrenheit,
InchMercuryAt60DegreeFahrenheit,
CentimetreWaterAt4DegreeCelsius,
MillimetreWaterAt4DegreeCelsius,
InchWaterAt4DegreeCelsius,
FootWaterAt4DegreeCelsius,
DynePerSquareCentimetre,
Proportion,
Percent,
PerThousand,
PartPerMillion,
RadianPerSquareRootSecond,
RadianPerSquareRootMinute,
RadianPerSquareRootHour,
RadianPerSquareRootDay,
DegreePerSquareRootSecond,
DegreePerSquareRootMinute,
DegreePerSquareRootHour,
DegreePerSquareRootDay,
Kelvin,
RelativeCelsius,
Rankine,
OhmMetre,
KiloOhmMetre,
MegaOhmMetre,
GigaOhmMetre,
Steradian,
Spat,
DegreeSquared,
JoulePerKilogramKelvin,
JoulePerGramKelvin,
JoulePerGramDegreeCelsius,
CaloriePerGramDegreeCelsius,
BritishThermalUnitPerPoundDegreeFahrenheit,
KilocaloriePerGramDegreeCelsius,
JoulePerKilogramSquaredKelvin,
JoulePerGramSquaredKelvin,
JoulePerGramDegreeSquaredCelsius,
CaloriePerGramDegreeSquaredCelsius,
BritishThermalUnitPerPoundSquaredDegreeFahrenheit,
KelvinPerMetre,
CelsiusPerMetre,
CelsiusPer10Metre,
CelsiusPer30Metre,
CelsiusPer100Metre,
CelsiusPerFoot,
CelsiusPer30Foot,
CelsiusPer100Foot,
FahrenheitPerFoot,
FahrenheitPer30Foot,
FahrenheitPer100Foot,
Celsius,
Fahrenheit,
Réaumur,
WattPerMetreKelvin,
CaloriePerMetreSecondDegreeCelsius,
CaloriePerCentimetreSecondDegreeCelsius,
BritishThermalUnitPerHourFootDegreeFahrenheit,
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit,
WattPerMetreKelvinPerKelvin,
CaloriePerMetreSecondDegreeCelsiusSquared,
CaloriePerCentimetreSecondDegreeCelsiusSquared,
BritishThermalUnitPerHourFootDegreeFahrenheitSquared,
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared,
Second,
Millisecond,
Microsecond,
Shake,
Nanosecond,
Picosecond,
Minute,
Hour,
Day,
Week,
Fortnight,
MonthCommon,
MonthSideral,
MonthSynodic,
QuarterCommon,
YearCommon,
YearAverageGregorian,
YearJulian,
YearLeap,
YearTropical,
Decade,
Century,
Millenia,
MillionYear,
NewtonMetrePerMetre,
DecanewtonMetrePerMetre,
KilogramForceMetrePerMetre,
KilonewtonMetrePerMetre,
FootPoundPerMetre,
KilofootPoundPerMetre,
NewtonDecimetrePerMetre,
NewtonCentimetrePerMetre,
NewtonMillimetrePerMetre,
InchPoundPerMetre,
NewtonMetrePerDecimetre,
DecanewtonMetrePerDecimetre,
KilogramForceMetrePerDecimetre,
KilonewtonMetrePerDecimetre,
FootPoundPerDecimetre,
KilofootPoundPerDecimetre,
NewtonDecimetrePerDecimetre,
NewtonCentimetrePerDecimetre,
NewtonMillimetrePerDecimetre,
InchPoundPerDecimetre,
NewtonMetrePerCentimetre,
DecanewtonMetrePerCentimetre,
KilogramForceMetrePerCentimetre,
KilonewtonMetrePerCentimetre,
FootPoundPerCentimetre,
KilofootPoundPerCentimetre,
NewtonDecimetrePerCentimetre,
NewtonCentimetrePerCentimetre,
NewtonMillimetrePerCentimetre,
InchPoundPerCentimetre,
NewtonMetrePerMillimetre,
DecanewtonMetrePerMillimetre,
KilogramForceMetrePerMillimetre,
KilonewtonMetrePerMillimetre,
FootPoundPerMillimetre,
KilofootPoundPerMillimetre,
NewtonDecimetrePerMillimetre,
NewtonCentimetrePerMillimetre,
NewtonMillimetrePerMillimetre,
InchPoundPerMillimetre,
NewtonMetrePerFoot,
DecanewtonMetrePerFoot,
KilogramForceMetrePerFoot,
KilonewtonMetrePerFoot,
FootPoundPerFoot,
KilofootPoundPerFoot,
NewtonDecimetrePerFoot,
NewtonCentimetrePerFoot,
NewtonMillimetrePerFoot,
InchPoundPerFoot,
NewtonMetrePerInch,
DecanewtonMetrePerInch,
KilogramForceMetrePerInch,
KilonewtonMetrePerInch,
FootPoundPerInch,
KilofootPoundPerInch,
NewtonDecimetrePerInch,
NewtonCentimetrePerInch,
NewtonMillimetrePerInch,
InchPoundPerInch,
NewtonMetre,
DecanewtonMetre,
KilogramForceMetre,
KilonewtonMetre,
FootPound,
KilofootPound,
NewtonDecimetre,
NewtonCentimetre,
NewtonMillimetre,
InchPound,
MetrePerSecond,
MetrePerMinute,
CentimetrePerSecond,
MetrePerHour,
MetrePerDay,
FootPerHour,
FootPerDay,
FootPerMinute,
FootPerSecond,
InchPerSecond,
MilePerHour,
KilometrePerHour,
KilometrePerMinute,
KilometrePerSecond,
KilometrePerDay,
MilePerMinute,
MilePerSecond,
MilePerDay,
InchPerMinute,
InchPerHour,
InchPerDay,
CentimetrePerMinute,
CentimetrePerHour,
CentimetrePerDay,
MillimetrePerSecond,
MillimetrePerMinute,
MillimetrePerHour,
MillimetrePerDay,
DecimetrePerSecond,
DecimetrePerMinute,
DecimetrePerHour,
DecimetrePerDay,
FurlongPerFortnight,
CubicMetre,
Litre,
Decilitre,
Centilitre,
Millilitre,
UsGallon,
UkGallon,
Barrel,
MillionCubicMetre,
MillionLitre,
MillionUkGallon,
MillionBarrel,
ThousandStandardCubicFoot,
MillionStandardCubicFoot,
CubicFoot,
CubicInch,
MillionUsGallon,
CubicMetrePerSecondSquared,
LitrePerMinuteSquared,
LitrePerMinutePerSecond,
LitrePerSecondSquared,
UkGallonPerMinuteSquared,
UkGallonPerMinutePerSecond,
UsGallonPerMinuteSquared,
UsGallonPerMinutePerSecond,
CubicMetrePerSecond,
LitrePerSecond,
CubicFootPerSecond,
UkGallonPerSecond,
UsGallonPerSecond,
BarrelPerSecond,
CubicMetrePerMinute,
LitrePerMinute,
CubicFootPerMinute,
UkGallonPerMinute,
UsGallonPerMinute,
BarrelPerMinute,
CubicMetrePerHour,
LitrePerHour,
CubicFootPerHour,
UkGallonPerHour,
UsGallonPerHour,
BarrelPerHour,
CubicMetrePerDay,
MillionCubicMetrePerDay,
UkGallonPerDay,
UsGallonPerDay,
MillionUkGallonPerDay,
MillionUsGallonPerDay,
LitrePerDay,
MillionLiterPerDay,
CubicFootPerDay,
ThousandStandardCubicFootPerDay,
MillionStandardCubicFootPerDay,
BarrelPerDay,
CubicMetrePerYear,
LitrePerYear,
CubicFootPerYear,
UkGallonPerYear,
UsGallonPerYear,
BarrelPerYear,
ReciprocalMetre,
ReciprocalDecimetre,
ReciprocalCentimetre,
ReciprocalMillimetre,
ReciprocalMicrometre,
ReciprocalNanometre,
ReciprocalAangstroem,
ReciprocalPicometre,
ReciprocalDecametre,
ReciprocalHectometre,
ReciprocalKilometre,
ReciprocalAstronomicalUnit,
ReciprocalLightYear,
ReciprocalParsec,
ReciprocalFoot,
ReciprocalUsSurveyFoot,
ReciprocalInch,
ReciprocalYard,
ReciprocalFathom,
ReciprocalSurveyorsChain,
ReciprocalMile,
ReciprocalInternationalNauticalMile,
ReciprocalUkNauticalMile,
ReciprocalScandinavianMile,
ReciprocalInchPer32,
ReciprocalMil,
ReciprocalThou,
ReciprocalHand,
ReciprocalFurlong,
Kilogram,
Hectogram,
Decagram,
Gram,
Centigram,
Milligram,
Microgram,
Nanogram,
AtomMassUnit,
TonneMetric,
Kilotonne,
Megatonne,
Gigatonne,
Pound,
Kilopound,
Ounce,
Stone,
TonUk,
TonUs,
SolarMass,
EarthMass,
Grain,
HundredWeights,
Joule,
Kilojoule,
Megajoule,
Gigajoule,
Calorie,
Kilocalorie,
BritishThermalUnit,
KiloBritishThermalUnit,
MegaBritishThermalUnit
}
	public static string ActivableFunction = "ActivableFunction";
	public static string RunnableFunction = "RunnableFunction";
	public static string ControllerFunction = "ControllerFunction";
	public static string ProcedureFunction = "ProcedureFunction";
	public static string ProtectionFunction = "ProtectionFunction";
	public static string FDIRFunction = "FDIRFunction";
	public static string SOEFunction = "SOEFunction";
	public static string AdvisorySystemAdvice = "AdvisorySystemAdvice";
	public static string DigitalTwinAdvice = "DigitalTwinAdvice";
	public static string DrillingStandardProcedureAdvice = "DrillingStandardProcedureAdvice";
	public static string DrillingControlAdvice = "DrillingControlAdvice";
	public static string DrillingSafeOperatingEnvelopeAdvice = "DrillingSafeOperatingEnvelopeAdvice";
	public static string DrillingFaultDetectionIsolationAndRecoveryAdvice = "DrillingFaultDetectionIsolationAndRecoveryAdvice";
	public static string ContextualData = "ContextualData";
	public static string Plan = "Plan";
	public static string OperationalPlan = "OperationalPlan";
	public static string DrillingProgram = "DrillingProgram";
	public static string RigActionPlan = "RigActionPlan";
	public static string ConfigurationData = "ConfigurationData";
	public static string WellBoreData = "WellBoreData";
	public static string TrajectoryDescription = "TrajectoryDescription";
	public static string FluidDescription = "FluidDescription";
	public static string DrillingFluidDescription = "DrillingFluidDescription";
	public static string CementFluidDescription = "CementFluidDescription";
	public static string CompletionFluidDescription = "CompletionFluidDescription";
	public static string WellboreArchitectureDescription = "WellboreArchitectureDescription";
	public static string DrillStemDescription = "DrillStemDescription";
	public static string DrillStringDescription = "DrillStringDescription";
	public static string CasingStringDescription = "CasingStringDescription";
	public static string LinerStringDescription = "LinerStringDescription";
	public static string ProductionStringDescription = "ProductionStringDescription";
	public static string GeoPressuresDescription = "GeoPressuresDescription";
	public static string GeoThermalDescription = "GeoThermalDescription";
	public static string FormationStrengthDescription = "FormationStrengthDescription";
	public static string StratigraphyDescription = "StratigraphyDescription";
	public static string RigDescription = "RigDescription";
	public static string WellBoreDataCharateristic = "WellBoreDataCharateristic";
	public static string Planned = "Planned";
	public static string Prognosed = "Prognosed";
	public static string Measured = "Measured";
	public static string Current = "Current";
	public static string Extrapolated = "Extrapolated";
	public static string DataFlowNode = "DataFlowNode";
	public static string ComputedState = "ComputedState";
	public static string ProceduralState = "ProceduralState";
	public static string ProcessState = "ProcessState";
	public static string PhysicalState = "PhysicalState";
	public static string ComputationUnit = "ComputationUnit";
	public static string Advisor = "Advisor";
	public static string Simulator = "Simulator";
	public static string Interpreter = "Interpreter";
	public static string Controller = "Controller";
	public static string ControlSystem = "ControlSystem";
	public static string HoistingControlSystem = "HoistingControlSystem";
	public static string CirculationControlSystem = "CirculationControlSystem";
	public static string RotationControlSystem = "RotationControlSystem";
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
	public static string CompletionServiceCompany = "CompletionServiceCompany";
	public static string DataAnalysisServiceCompany = "DataAnalysisServiceCompany";
	public static string DrillingContractor = "DrillingContractor";
	public static string DWISInternalService = "DWISInternalService";
	public static string DWISBlackboard = "DWISBlackboard";
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
	public static string AcousticTelemetry = "AcousticTelemetry";
	public static string WiredPipeTelemetry = "WiredPipeTelemetry";
	public static string InductionCouplingDownholeTelemetry = "InductionCouplingDownholeTelemetry";
	public static string ElectromagneticCouplingDownholeTelemetry = "ElectromagneticCouplingDownholeTelemetry";
	public static string GalvanicCouplingDownholeTelemetry = "GalvanicCouplingDownholeTelemetry";
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
	public static string JSonDataType = "JSonDataType";
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
	public static string DifferentiallyStuck = "DifferentiallyStuck";
	public static string PipeWashout = "PipeWashout";
	public static string FormationWashout = "FormationWashout";
	public static string OverTorque = "OverTorque";
	public static string Plugged = "Plugged";
	public static string PackOff = "PackOff";
	public static string MotorStall = "MotorStall";
	public static string DrillingLimit = "DrillingLimit";
	public static string AxialVelocityLimit = "AxialVelocityLimit";
	public static string RotationalVelocityLimit = "RotationalVelocityLimit";
	public static string FlowrateLimit = "FlowrateLimit";
	public static string ROPLimit = "ROPLimit";
	public static string WOBLimit = "WOBLimit";
	public static string DifferentialPressureLimit = "DifferentialPressureLimit";
	public static string DrillingObjective = "DrillingObjective";
	public static string StableAxialVelocityObjective = "StableAxialVelocityObjective";
	public static string StableRotationalVelocityObjective = "StableRotationalVelocityObjective";
	public static string StablePressureObjective = "StablePressureObjective";
	public static string StableTorqueObjective = "StableTorqueObjective";
	public static string StableAxialForceObjective = "StableAxialForceObjective";
	public static string WeightTransferObjective = "WeightTransferObjective";
	public static string DrillingProcedure = "DrillingProcedure";
	public static string CirculationStartupProcedure = "CirculationStartupProcedure";
	public static string CirculationStopProcedure = "CirculationStopProcedure";
	public static string RotationStartupProcedure = "RotationStartupProcedure";
	public static string RotationStopProcedure = "RotationStopProcedure";
	public static string HoistProcedure = "HoistProcedure";
	public static string TagBottomProcedure = "TagBottomProcedure";
	public static string ReciprocationProcedure = "ReciprocationProcedure";
	public static string FrictionTestProcedure = "FrictionTestProcedure";
	public static string SlowCirculationRateProcedure = "SlowCirculationRateProcedure";
	public static string PressureIntegrityTestProcedure = "PressureIntegrityTestProcedure";
	public static string FlowCheckProcedure = "FlowCheckProcedure";
	public static string CementingProcedure = "CementingProcedure";
	public static string DownlinkingProcedure = "DownlinkingProcedure";
	public static string ToolfaceOrientationProcedure = "ToolfaceOrientationProcedure";
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
	public static string ConsistencyIndexRheologyQuantity = "ConsistencyIndexRheologyQuantity";
	public static string ElectricTensionQuantity = "ElectricTensionQuantity";
	public static string ImageScaleQuantity = "ImageScaleQuantity";
	public static string DiameterSmallQuantity = "DiameterSmallQuantity";
	public static string DimensionLessStandardQuantity = "DimensionLessStandardQuantity";
	public static string EarthMagneticFluxDensityQuantity = "EarthMagneticFluxDensityQuantity";
	public static string ElasticModulusQuantity = "ElasticModulusQuantity";
	public static string LengthSmallQuantity = "LengthSmallQuantity";
	public static string RotationalFrequencyQuantity = "RotationalFrequencyQuantity";
	public static string VolumeLargeQuantity = "VolumeLargeQuantity";
	public static string ProportionStandardQuantity = "ProportionStandardQuantity";
	public static string LengthStandardQuantity = "LengthStandardQuantity";
	public static string FluidShearRateQuantity = "FluidShearRateQuantity";
	public static string FluidShearStressQuantity = "FluidShearStressQuantity";
	public static string TorqueSmallQuantity = "TorqueSmallQuantity";
	public static string RotationalFrequencySmallQuantity = "RotationalFrequencySmallQuantity";
	public static string ProportionSmallQuantity = "ProportionSmallQuantity";
	public static string PorosityQuantity = "PorosityQuantity";
	public static string StrokeFrequencyQuantity = "StrokeFrequencyQuantity";
	public static string ShockRateQuantity = "ShockRateQuantity";
	public static string AccelerationDrillingQuantity = "AccelerationDrillingQuantity";
	public static string AngleGradientPerLengthDrillingQuantity = "AngleGradientPerLengthDrillingQuantity";
	public static string AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity = "AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity";
	public static string AngularAccelerationDrillingQuantity = "AngularAccelerationDrillingQuantity";
	public static string AngularVelocityDrillingQuantity = "AngularVelocityDrillingQuantity";
	public static string AngularVelocitySurveyInstrumentDrillingQuantity = "AngularVelocitySurveyInstrumentDrillingQuantity";
	public static string AreaDrillingQuantity = "AreaDrillingQuantity";
	public static string AxialVelocityDrillingQuantity = "AxialVelocityDrillingQuantity";
	public static string BlockVelocityDrillingQuantity = "BlockVelocityDrillingQuantity";
	public static string CableDiameterDrillingQuantity = "CableDiameterDrillingQuantity";
	public static string CapillaryPressureDrillingQuantity = "CapillaryPressureDrillingQuantity";
	public static string CompressibilityDrillingQuantity = "CompressibilityDrillingQuantity";
	public static string CurvatureDrillingQuantity = "CurvatureDrillingQuantity";
	public static string DepthDrillingQuantity = "DepthDrillingQuantity";
	public static string DiameterPipeDrillingQuantity = "DiameterPipeDrillingQuantity";
	public static string DiameterPoreDrillingQuantity = "DiameterPoreDrillingQuantity";
	public static string DrillStemMaterialStrengthDrillingQuantity = "DrillStemMaterialStrengthDrillingQuantity";
	public static string DrillStringMagneticFluxDrillingQuantity = "DrillStringMagneticFluxDrillingQuantity";
	public static string DurationDrillingQuantity = "DurationDrillingQuantity";
	public static string DynamicViscosityDrillingQuantity = "DynamicViscosityDrillingQuantity";
	public static string ElongationGradientPerLengthDrillingQuantity = "ElongationGradientPerLengthDrillingQuantity";
	public static string EnergyDensityDrillingQuantity = "EnergyDensityDrillingQuantity";
	public static string MassDensityRateOfChangeDrillingQuantity = "MassDensityRateOfChangeDrillingQuantity";
	public static string MassDensityGradientPerTemperatureDrillingQuantity = "MassDensityGradientPerTemperatureDrillingQuantity";
	public static string MassDensityGradientPerLengthDrillingQuantity = "MassDensityGradientPerLengthDrillingQuantity";
	public static string MassDensityDrillingQuantity = "MassDensityDrillingQuantity";
	public static string FluidVelocityDrillingQuantity = "FluidVelocityDrillingQuantity";
	public static string ForceGradientPerLengthDrillingQuantity = "ForceGradientPerLengthDrillingQuantity";
	public static string ForceDrillingQuantity = "ForceDrillingQuantity";
	public static string HeatTransferCoefficientDrillingQuantity = "HeatTransferCoefficientDrillingQuantity";
	public static string HydraulicConductivityDrillingQuantity = "HydraulicConductivityDrillingQuantity";
	public static string InterfacialTensionDrillingQuantity = "InterfacialTensionDrillingQuantity";
	public static string MassGradientPerLengthDrillingQuantity = "MassGradientPerLengthDrillingQuantity";
	public static string MassDrillingQuantity = "MassDrillingQuantity";
	public static string MassRateDrillingQuantity = "MassRateDrillingQuantity";
	public static string PlaneAngleDrillingQuantity = "PlaneAngleDrillingQuantity";
	public static string PowerDrillingQuantity = "PowerDrillingQuantity";
	public static string PressureGradientPerLengthDrillingQuantity = "PressureGradientPerLengthDrillingQuantity";
	public static string PressureLossConstantDrillingQuantity = "PressureLossConstantDrillingQuantity";
	public static string PressureDrillingQuantity = "PressureDrillingQuantity";
	public static string RandomWalkDrillingQuantity = "RandomWalkDrillingQuantity";
	public static string RotationalFrequencyRateOfChangeDrillingQuantity = "RotationalFrequencyRateOfChangeDrillingQuantity";
	public static string IsobaricSpecificHeatCapacityDrillingQuantity = "IsobaricSpecificHeatCapacityDrillingQuantity";
	public static string IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity = "IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity";
	public static string StickDurationDrillingQuantity = "StickDurationDrillingQuantity";
	public static string ReciprocalLengthSurveyInstrumentDrillingQuantity = "ReciprocalLengthSurveyInstrumentDrillingQuantity";
	public static string TemperatureGradientPerLengthDrillingQuantity = "TemperatureGradientPerLengthDrillingQuantity";
	public static string TemperatureDrillingQuantity = "TemperatureDrillingQuantity";
	public static string TensionDrillingQuantity = "TensionDrillingQuantity";
	public static string ThermalConductivityDrillingQuantity = "ThermalConductivityDrillingQuantity";
	public static string TorqueDrillingQuantity = "TorqueDrillingQuantity";
	public static string VolumeDrillingQuantity = "VolumeDrillingQuantity";
	public static string VolumetricFlowRateOfChangeDrillingQuantity = "VolumetricFlowRateOfChangeDrillingQuantity";
	public static string VolumetricFlowrateDrillingQuantity = "VolumetricFlowrateDrillingQuantity";
	public static string FormationResistivityDrillingQuantity = "FormationResistivityDrillingQuantity";
	public static string FormationStrengthDrillingQuantity = "FormationStrengthDrillingQuantity";
	public static string GammaRayIndexDrillingQuantity = "GammaRayIndexDrillingQuantity";
	public static string GasShowDrillingQuantity = "GasShowDrillingQuantity";
	public static string GasVolumetricFlowRateDrillingQuantity = "GasVolumetricFlowRateDrillingQuantity";
	public static string HeightDrillingQuantity = "HeightDrillingQuantity";
	public static string HookLoadDrillingQuantity = "HookLoadDrillingQuantity";
	public static string NozzleDiameterDrillingQuantity = "NozzleDiameterDrillingQuantity";
	public static string SurfacePoreDrillingQuantity = "SurfacePoreDrillingQuantity";
	public static string PositionDrillingQuantity = "PositionDrillingQuantity";
	public static string RateOfPenetrationDrillingQuantity = "RateOfPenetrationDrillingQuantity";
	public static string WeightOnBitDrillingQuantity = "WeightOnBitDrillingQuantity";
	public static string ThermalConductivityGradientPerTemperatureDrillingQuantity = "ThermalConductivityGradientPerTemperatureDrillingQuantity";
	public static string TorqueGradientPerLengthDrillingQuantity = "TorqueGradientPerLengthDrillingQuantity";
	public static string PorousMediumPermeabilityDrillingQuantity = "PorousMediumPermeabilityDrillingQuantity";
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
	public static string TemporalBehaviorModel = "TemporalBehaviorModel";
	public static string SteadyStateModel = "SteadyStateModel";
	public static string TransientModel = "TransientModel";
	public static string ModelingApproach = "ModelingApproach";
	public static string ForwardModel = "ForwardModel";
	public static string InversionModel = "InversionModel";
	public static string HybridAnalysisModel = "HybridAnalysisModel";
	public static string ModelingParadigm = "ModelingParadigm";
	public static string EmpiricalModel = "EmpiricalModel";
	public static string MechanisticModel = "MechanisticModel";
	public static string PhysicsInformedDataDrivenModel = "PhysicsInformedDataDrivenModel";
	public static string MathematicalFormulation = "MathematicalFormulation";
	public static string AlgebraicModel = "AlgebraicModel";
	public static string OrdinaryDifferentialEquationModel = "OrdinaryDifferentialEquationModel";
	public static string PartialDifferentialEquationModel = "PartialDifferentialEquationModel";
	public static string IntegralModel = "IntegralModel";
	public static string ModelingObjective = "ModelingObjective";
	public static string PredictiveModel = "PredictiveModel";
	public static string DescriptiveModel = "DescriptiveModel";
	public static string CalibrationModel = "CalibrationModel";
	public static string ControlModel = "ControlModel";
	public static string ModelScope = "ModelScope";
	public static string GeneralModel = "GeneralModel";
	public static string SpecializedModel = "SpecializedModel";
	public static string ModelTransparency = "ModelTransparency";
	public static string BlackBoxModel = "BlackBoxModel";
	public static string GrayBoxModel = "GrayBoxModel";
	public static string WhiteBoxModel = "WhiteBoxModel";
	public static string DataIntegrationStrategy = "DataIntegrationStrategy";
	public static string DataLevelIntegationModel = "DataLevelIntegationModel";
	public static string FeatureLevelIntegationModel = "FeatureLevelIntegationModel";
	public static string DecisionLevelIntegationModel = "DecisionLevelIntegationModel";
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
	public static string AngleGradientPerLengthQuantity = "AngleGradientPerLengthQuantity";
	public static string AngleMagneticFluxDensityQuantity = "AngleMagneticFluxDensityQuantity";
	public static string AngularAccelerationQuantity = "AngularAccelerationQuantity";
	public static string AngularVelocityQuantity = "AngularVelocityQuantity";
	public static string AreaQuantity = "AreaQuantity";
	public static string CompressibilityQuantity = "CompressibilityQuantity";
	public static string CurvatureQuantity = "CurvatureQuantity";
	public static string MassDensityGradientPerLengthQuantity = "MassDensityGradientPerLengthQuantity";
	public static string MassDensityGradientPerTemperatureQuantity = "MassDensityGradientPerTemperatureQuantity";
	public static string MassDensityQuantity = "MassDensityQuantity";
	public static string MassDensityRateOfChangeQuantity = "MassDensityRateOfChangeQuantity";
	public static string DimensionlessQuantity = "DimensionlessQuantity";
	public static string DynamicViscosityQuantity = "DynamicViscosityQuantity";
	public static string ElectricCapacitanceQuantity = "ElectricCapacitanceQuantity";
	public static string ElectricCurrentQuantity = "ElectricCurrentQuantity";
	public static string ElongationGradientPerLengthQuantity = "ElongationGradientPerLengthQuantity";
	public static string EnergyDensityQuantity = "EnergyDensityQuantity";
	public static string ForceGradientPerLengthQuantity = "ForceGradientPerLengthQuantity";
	public static string ForceQuantity = "ForceQuantity";
	public static string FrequencyQuantity = "FrequencyQuantity";
	public static string FrequencyRateOfChangeQuantity = "FrequencyRateOfChangeQuantity";
	public static string HeatTransferCoefficientQuantity = "HeatTransferCoefficientQuantity";
	public static string InterfacialTensionQuantity = "InterfacialTensionQuantity";
	public static string LengthQuantity = "LengthQuantity";
	public static string LuminousIntensityQuantity = "LuminousIntensityQuantity";
	public static string MagneticFluxDensityQuantity = "MagneticFluxDensityQuantity";
	public static string MagneticFluxQuantity = "MagneticFluxQuantity";
	public static string MassGradientPerLengthQuantity = "MassGradientPerLengthQuantity";
	public static string MassRateQuantity = "MassRateQuantity";
	public static string MaterialStrengthQuantity = "MaterialStrengthQuantity";
	public static string PorousMediumPermeabilityQuantity = "PorousMediumPermeabilityQuantity";
	public static string PlaneAngleQuantity = "PlaneAngleQuantity";
	public static string PowerQuantity = "PowerQuantity";
	public static string PressureGradientPerLengthQuantity = "PressureGradientPerLengthQuantity";
	public static string PressureLossConstantQuantity = "PressureLossConstantQuantity";
	public static string PressureQuantity = "PressureQuantity";
	public static string ProportionQuantity = "ProportionQuantity";
	public static string RandomWalkQuantity = "RandomWalkQuantity";
	public static string RelativeTemperatureQuantity = "RelativeTemperatureQuantity";
	public static string ElectricResistivityQuantity = "ElectricResistivityQuantity";
	public static string SolidAngleQuantity = "SolidAngleQuantity";
	public static string IsobaricSpecificHeatCapacityQuantity = "IsobaricSpecificHeatCapacityQuantity";
	public static string IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity = "IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity";
	public static string StressQuantity = "StressQuantity";
	public static string TemperatureGradientPerLengthQuantity = "TemperatureGradientPerLengthQuantity";
	public static string TemperatureQuantity = "TemperatureQuantity";
	public static string ThermalConductivityQuantity = "ThermalConductivityQuantity";
	public static string ThermalConductivityGradientPerTemperatureQuantity = "ThermalConductivityGradientPerTemperatureQuantity";
	public static string TimeQuantity = "TimeQuantity";
	public static string TorqueGradientPerLengthQuantity = "TorqueGradientPerLengthQuantity";
	public static string TorqueQuantity = "TorqueQuantity";
	public static string VelocityQuantity = "VelocityQuantity";
	public static string VolumeQuantity = "VolumeQuantity";
	public static string VolumetricFlowRateOfChangeQuantity = "VolumetricFlowRateOfChangeQuantity";
	public static string VolumetricFlowRateQuantity = "VolumetricFlowRateQuantity";
	public static string WaveNumberQuantity = "WaveNumberQuantity";
	public static string MassQuantity = "MassQuantity";
	public static string EnergyQuantity = "EnergyQuantity";
	public static string GravitationalLoadQuantity = "GravitationalLoadQuantity";
	public static string HydraulicConductivityQuantity = "HydraulicConductivityQuantity";
	public static string RotationalFrequencyRateOfChangeQuantity = "RotationalFrequencyRateOfChangeQuantity";
	public static string TensionQuantity = "TensionQuantity";
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
	public static string MetrePerSecondSquared = "MetrePerSecondSquared";
	public static string FootPerSecondSquared = "FootPerSecondSquared";
	public static string CentimetrePerSecondSquared = "CentimetrePerSecondSquared";
	public static string CentimetrePerHourPerSecond = "CentimetrePerHourPerSecond";
	public static string CentimetrePerMinutePerSecond = "CentimetrePerMinutePerSecond";
	public static string FootPerHourPerSecond = "FootPerHourPerSecond";
	public static string FootPerMinutePerSecond = "FootPerMinutePerSecond";
	public static string Galileo = "Galileo";
	public static string GravityStandard = "GravityStandard";
	public static string InchPerHourPerSecond = "InchPerHourPerSecond";
	public static string InchPerMinutePerSecond = "InchPerMinutePerSecond";
	public static string InchPerSecondSquared = "InchPerSecondSquared";
	public static string KnotPerSecond = "KnotPerSecond";
	public static string MetrePerSecondPerMillisecond = "MetrePerSecondPerMillisecond";
	public static string MilePerHourPerSecond = "MilePerHourPerSecond";
	public static string MilePerMinutePerSecond = "MilePerMinutePerSecond";
	public static string MilePerSecondSquared = "MilePerSecondSquared";
	public static string KilometrePerSecondSquared = "KilometrePerSecondSquared";
	public static string KilometrePerHourPerSecond = "KilometrePerHourPerSecond";
	public static string KilometrePerMinutePerSecond = "KilometrePerMinutePerSecond";
	public static string Mole = "Mole";
	public static string Decimole = "Decimole";
	public static string Centimole = "Centimole";
	public static string Millimole = "Millimole";
	public static string Micromole = "Micromole";
	public static string Nanomole = "Nanomole";
	public static string Picomole = "Picomole";
	public static string Kilomole = "Kilomole";
	public static string RadianPerMetre = "RadianPerMetre";
	public static string DegreePerMetre = "DegreePerMetre";
	public static string DegreePerCentimetre = "DegreePerCentimetre";
	public static string DegreePerFoot = "DegreePerFoot";
	public static string DegreePerInch = "DegreePerInch";
	public static string DegreePerDecimetre = "DegreePerDecimetre";
	public static string DegreePerMillimetre = "DegreePerMillimetre";
	public static string RadianPerMillimetre = "RadianPerMillimetre";
	public static string RadianPerCentimetre = "RadianPerCentimetre";
	public static string RadianPerDecimetre = "RadianPerDecimetre";
	public static string RadianPerFoot = "RadianPerFoot";
	public static string RadianPerInch = "RadianPerInch";
	public static string RadianTesla = "RadianTesla";
	public static string RadianGauss = "RadianGauss";
	public static string RadianMilligauss = "RadianMilligauss";
	public static string RadianMillitesla = "RadianMillitesla";
	public static string RadianMicrotesla = "RadianMicrotesla";
	public static string RadianNanotesla = "RadianNanotesla";
	public static string RadianMaxwellPerSquareCentimetre = "RadianMaxwellPerSquareCentimetre";
	public static string RadianWeberPerSquareMetre = "RadianWeberPerSquareMetre";
	public static string DegreeTesla = "DegreeTesla";
	public static string DegreeGauss = "DegreeGauss";
	public static string DegreeMilligauss = "DegreeMilligauss";
	public static string DegreeMillitesla = "DegreeMillitesla";
	public static string DegreeMicrotesla = "DegreeMicrotesla";
	public static string DegreeNanotesla = "DegreeNanotesla";
	public static string DegreeMaxwellPerSquareCentimetre = "DegreeMaxwellPerSquareCentimetre";
	public static string DegreeWeberPerSquareMetre = "DegreeWeberPerSquareMetre";
	public static string RadianPerSecondSquared = "RadianPerSecondSquared";
	public static string DegreePerSecondSquared = "DegreePerSecondSquared";
	public static string RadianPerDayPerSecond = "RadianPerDayPerSecond";
	public static string RadianPerHourPerSecond = "RadianPerHourPerSecond";
	public static string RadianPerMinutePerSecond = "RadianPerMinutePerSecond";
	public static string DegreePerDayPerSecond = "DegreePerDayPerSecond";
	public static string DegreePerHourPerSecond = "DegreePerHourPerSecond";
	public static string DegreePerMinutePerSecond = "DegreePerMinutePerSecond";
	public static string RadianPerSecondPerMinute = "RadianPerSecondPerMinute";
	public static string DegreePerSecondPerMinute = "DegreePerSecondPerMinute";
	public static string RadianPerDayPerMinute = "RadianPerDayPerMinute";
	public static string RadianPerHourPerMinute = "RadianPerHourPerMinute";
	public static string RadianPerMinuteSquared = "RadianPerMinuteSquared";
	public static string DegreePerDayPerMinute = "DegreePerDayPerMinute";
	public static string DegreePerHourPerMinute = "DegreePerHourPerMinute";
	public static string DegreePerMinuteSquared = "DegreePerMinuteSquared";
	public static string RadianPerSecondPerHour = "RadianPerSecondPerHour";
	public static string DegreePerSecondPerHour = "DegreePerSecondPerHour";
	public static string RadianPerDayPerHour = "RadianPerDayPerHour";
	public static string RadianPerHourSquared = "RadianPerHourSquared";
	public static string RadianPerMinutePerHour = "RadianPerMinutePerHour";
	public static string DegreePerDayPerHour = "DegreePerDayPerHour";
	public static string DegreePerHourSquared = "DegreePerHourSquared";
	public static string DegreePerMinutePerHour = "DegreePerMinutePerHour";
	public static string RadianPerSecondPerDay = "RadianPerSecondPerDay";
	public static string DegreePerSecondPerDay = "DegreePerSecondPerDay";
	public static string RadianPerDaySquared = "RadianPerDaySquared";
	public static string RadianPerHourPerDay = "RadianPerHourPerDay";
	public static string RadianPerMinutePerDay = "RadianPerMinutePerDay";
	public static string DegreePerDaySquared = "DegreePerDaySquared";
	public static string DegreePerHourPerDay = "DegreePerHourPerDay";
	public static string DegreePerMinutePerDay = "DegreePerMinutePerDay";
	public static string RadianPerSecond = "RadianPerSecond";
	public static string DegreePerSecond = "DegreePerSecond";
	public static string RadianPerDay = "RadianPerDay";
	public static string RadianPerHour = "RadianPerHour";
	public static string RadianPerMinute = "RadianPerMinute";
	public static string DegreePerDay = "DegreePerDay";
	public static string DegreePerHour = "DegreePerHour";
	public static string DegreePerMinute = "DegreePerMinute";
	public static string SquareMetre = "SquareMetre";
	public static string SquareKilometre = "SquareKilometre";
	public static string Hectare = "Hectare";
	public static string SquareDecametre = "SquareDecametre";
	public static string SquareDecimetre = "SquareDecimetre";
	public static string SquareCentimetre = "SquareCentimetre";
	public static string SquareMillimetre = "SquareMillimetre";
	public static string SquareMicrometre = "SquareMicrometre";
	public static string SquareFoot = "SquareFoot";
	public static string SquareInch = "SquareInch";
	public static string SquareYard = "SquareYard";
	public static string Acre = "Acre";
	public static string SquareMile = "SquareMile";
	public static string InversePascal = "InversePascal";
	public static string InverseBar = "InverseBar";
	public static string InversePoundPerSquareInch = "InversePoundPerSquareInch";
	public static string InverseAtmosphere = "InverseAtmosphere";
	public static string PascalSecond = "PascalSecond";
	public static string MicropascalSecond = "MicropascalSecond";
	public static string Centipoise = "Centipoise";
	public static string Micropoise = "Micropoise";
	public static string PoundSecondPer100SquareFoot = "PoundSecondPer100SquareFoot";
	public static string DyneSecondPerSquareCentimetre = "DyneSecondPerSquareCentimetre";
	public static string DegreePer10m = "DegreePer10m";
	public static string DegreePer30m = "DegreePer30m";
	public static string DegreePer30ft = "DegreePer30ft";
	public static string DegreePer100ft = "DegreePer100ft";
	public static string DegreePerDecimeter = "DegreePerDecimeter";
	public static string DegreePerCentimeter = "DegreePerCentimeter";
	public static string DegreePerMillimeter = "DegreePerMillimeter";
	public static string DegreePerMicrometer = "DegreePerMicrometer";
	public static string DegreePerNanometer = "DegreePerNanometer";
	public static string DegreePerDecameter = "DegreePerDecameter";
	public static string DegreePerHectometer = "DegreePerHectometer";
	public static string DegreePerKilometer = "DegreePerKilometer";
	public static string RadianPerDecimeter = "RadianPerDecimeter";
	public static string RadianPerCentimeter = "RadianPerCentimeter";
	public static string RadianPerMillimeter = "RadianPerMillimeter";
	public static string RadianPerMicrometer = "RadianPerMicrometer";
	public static string RadianPerNanometer = "RadianPerNanometer";
	public static string RadianPerDecameter = "RadianPerDecameter";
	public static string RadianPerHectometer = "RadianPerHectometer";
	public static string RadianPerKilometer = "RadianPerKilometer";
	public static string DegreePerYard = "DegreePerYard";
	public static string DegreePerMile = "DegreePerMile";
	public static string RadianPerYard = "RadianPerYard";
	public static string RadianPerMile = "RadianPerMile";
	public static string KilogramPerCubicMetrePerMetre = "KilogramPerCubicMetrePerMetre";
	public static string SpecificGravityPerMetre = "SpecificGravityPerMetre";
	public static string SpecificGravityPer10Metre = "SpecificGravityPer10Metre";
	public static string SpecificGravityPer30Metre = "SpecificGravityPer30Metre";
	public static string SpecificGravityPer100Metre = "SpecificGravityPer100Metre";
	public static string GramPerCubicCentimetrePer100Metre = "GramPerCubicCentimetrePer100Metre";
	public static string PoundPerGallonUkPerFoot = "PoundPerGallonUkPerFoot";
	public static string PoundPerGallonUkPer30Foot = "PoundPerGallonUkPer30Foot";
	public static string PoundPerGallonUkPer100Foot = "PoundPerGallonUkPer100Foot";
	public static string PoundPerGallonUsPerFoot = "PoundPerGallonUsPerFoot";
	public static string PoundPerGallonUsPer30Foot = "PoundPerGallonUsPer30Foot";
	public static string PoundPerGallonUsPer100Foot = "PoundPerGallonUsPer100Foot";
	public static string KilogramPerCubicMetrePer10Metre = "KilogramPerCubicMetrePer10Metre";
	public static string KilogramPerCubicMetrePer30Metre = "KilogramPerCubicMetrePer30Metre";
	public static string KilogramPerCubicMetrePer100Metre = "KilogramPerCubicMetrePer100Metre";
	public static string GramPerCubicCentimetrePerMetre = "GramPerCubicCentimetrePerMetre";
	public static string GramPerCubicCentimetrePer10Metre = "GramPerCubicCentimetrePer10Metre";
	public static string GramPerCubicCentimetrePer30Metre = "GramPerCubicCentimetrePer30Metre";
	public static string PoundPerCubicFootPerFoot = "PoundPerCubicFootPerFoot";
	public static string PoundPerCubicFootPer30Foot = "PoundPerCubicFootPer30Foot";
	public static string PoundPerCubicFootPer100Foot = "PoundPerCubicFootPer100Foot";
	public static string PoundPerCubicInchPerFoot = "PoundPerCubicInchPerFoot";
	public static string PoundPerCubicInchPer30Foot = "PoundPerCubicInchPer30Foot";
	public static string PoundPerCubicInchPer100Foot = "PoundPerCubicInchPer100Foot";
	public static string PoundPerCubicYardPerFoot = "PoundPerCubicYardPerFoot";
	public static string PoundPerCubicYardPer30Foot = "PoundPerCubicYardPer30Foot";
	public static string PoundPerCubicYardPer100Foot = "PoundPerCubicYardPer100Foot";
	public static string KilogramPerCubicMetrePerKelvin = "KilogramPerCubicMetrePerKelvin";
	public static string SpecificGravityPerCelsius = "SpecificGravityPerCelsius";
	public static string GramPerCubicCentimetrePerCelsius = "GramPerCubicCentimetrePerCelsius";
	public static string PoundPerGallonUkPerCelsius = "PoundPerGallonUkPerCelsius";
	public static string PoundPerGallonUsPerFahrenheit = "PoundPerGallonUsPerFahrenheit";
	public static string PoundPerGallonUkPerFahrenheit = "PoundPerGallonUkPerFahrenheit";
	public static string PoundPerGallonUsPerCelsius = "PoundPerGallonUsPerCelsius";
	public static string PoundPerCubicFootPerCelsius = "PoundPerCubicFootPerCelsius";
	public static string PoundPerCubicFootPerFahrenheit = "PoundPerCubicFootPerFahrenheit";
	public static string PoundPerCubicInchPerCelsius = "PoundPerCubicInchPerCelsius";
	public static string PoundPerCubicInchPerFahrenheit = "PoundPerCubicInchPerFahrenheit";
	public static string PoundPerCubicYardPerCelsius = "PoundPerCubicYardPerCelsius";
	public static string PoundPerCubicYeardPerFahrenheit = "PoundPerCubicYeardPerFahrenheit";
	public static string KilogramPerCubicMetre = "KilogramPerCubicMetre";
	public static string GramPerCubicMetre = "GramPerCubicMetre";
	public static string SpecificGravity = "SpecificGravity";
	public static string GramPerCubicCentimetre = "GramPerCubicCentimetre";
	public static string PoundPerGallonUk = "PoundPerGallonUk";
	public static string PoundPerGallonUs = "PoundPerGallonUs";
	public static string PoundPerCubicFoot = "PoundPerCubicFoot";
	public static string PoundPerCubicInch = "PoundPerCubicInch";
	public static string PoundPerCubicYard = "PoundPerCubicYard";
	public static string KilogramPerCubicMetrePerSecond = "KilogramPerCubicMetrePerSecond";
	public static string SpecificGravityPerSecond = "SpecificGravityPerSecond";
	public static string SpecificGravityPerMinute = "SpecificGravityPerMinute";
	public static string SpecificGravityPerHour = "SpecificGravityPerHour";
	public static string GramPerCubicCentimetrePerSecond = "GramPerCubicCentimetrePerSecond";
	public static string GramPerCubicCentimetrePerMinute = "GramPerCubicCentimetrePerMinute";
	public static string GramPerCubicCentimetrePerHour = "GramPerCubicCentimetrePerHour";
	public static string PoundPerGallonUkPerSecond = "PoundPerGallonUkPerSecond";
	public static string PoundPerGallonUkPerMinute = "PoundPerGallonUkPerMinute";
	public static string PoundPerGallonUkPerHour = "PoundPerGallonUkPerHour";
	public static string PoundPerGallonUsPerSecond = "PoundPerGallonUsPerSecond";
	public static string PoundPerGallonUsPerMinute = "PoundPerGallonUsPerMinute";
	public static string PoundPerGallonUsPerHour = "PoundPerGallonUsPerHour";
	public static string Dimensionless = "Dimensionless";
	public static string MillipascalSecond = "MillipascalSecond";
	public static string Poise = "Poise";
	public static string Millipoise = "Millipoise";
	public static string PoundSecondPerSquareFoot = "PoundSecondPerSquareFoot";
	public static string PoundSecondPerSquareInch = "PoundSecondPerSquareInch";
	public static string Farad = "Farad";
	public static string CoulombPerVolt = "CoulombPerVolt";
	public static string Millifarad = "Millifarad";
	public static string Microfarad = "Microfarad";
	public static string Nanofarad = "Nanofarad";
	public static string Picofarad = "Picofarad";
	public static string Ampere = "Ampere";
	public static string CoulombPerSecond = "CoulombPerSecond";
	public static string SiemensVolt = "SiemensVolt";
	public static string VoltPerOhm = "VoltPerOhm";
	public static string WattPerVolt = "WattPerVolt";
	public static string WeberPerHenry = "WeberPerHenry";
	public static string Deciampere = "Deciampere";
	public static string Centiampere = "Centiampere";
	public static string Milliampere = "Milliampere";
	public static string Microampere = "Microampere";
	public static string Nanoampere = "Nanoampere";
	public static string Picoampere = "Picoampere";
	public static string Biot = "Biot";
	public static string Abampere = "Abampere";
	public static string Kiloampere = "Kiloampere";
	public static string Megaampere = "Megaampere";
	public static string Gigaampere = "Gigaampere";
	public static string Teraampere = "Teraampere";
	public static string Statampere = "Statampere";
	public static string Volt = "Volt";
	public static string Millivolt = "Millivolt";
	public static string Centivolt = "Centivolt";
	public static string Microvolt = "Microvolt";
	public static string Nanovolt = "Nanovolt";
	public static string Picovolt = "Picovolt";
	public static string Kilovolt = "Kilovolt";
	public static string Megavolt = "Megavolt";
	public static string Gigavolt = "Gigavolt";
	public static string MetrePerMetre = "MetrePerMetre";
	public static string DecimetrePerMetre = "DecimetrePerMetre";
	public static string CentimetrePerMetre = "CentimetrePerMetre";
	public static string MillimetrePerMetre = "MillimetrePerMetre";
	public static string MicrometrePerMetre = "MicrometrePerMetre";
	public static string MetrePerKilometre = "MetrePerKilometre";
	public static string DecimetrePerKilometre = "DecimetrePerKilometre";
	public static string CentimetrePerKilometre = "CentimetrePerKilometre";
	public static string MillimetrePerKilometre = "MillimetrePerKilometre";
	public static string MicrometrePerKilometre = "MicrometrePerKilometre";
	public static string InchPerFoot = "InchPerFoot";
	public static string InchPerYard = "InchPerYard";
	public static string InchPerMile = "InchPerMile";
	public static string FootPerFoot = "FootPerFoot";
	public static string FootPerYard = "FootPerYard";
	public static string FootPerMile = "FootPerMile";
	public static string YardPerFoot = "YardPerFoot";
	public static string YardPerYard = "YardPerYard";
	public static string YardPerMile = "YardPerMile";
	public static string JoulePerCubicMetre = "JoulePerCubicMetre";
	public static string JoulePerLitre = "JoulePerLitre";
	public static string KilojoulePerCubicMetre = "KilojoulePerCubicMetre";
	public static string KilojoulePerLitre = "KilojoulePerLitre";
	public static string MegajoulePerCubicMetre = "MegajoulePerCubicMetre";
	public static string MegajoulePerLitre = "MegajoulePerLitre";
	public static string GigajoulePerCubicMetre = "GigajoulePerCubicMetre";
	public static string GigajoulePerLitre = "GigajoulePerLitre";
	public static string CaloriePerCubicMetre = "CaloriePerCubicMetre";
	public static string CaloriePerLitre = "CaloriePerLitre";
	public static string KilocaloriePerCubicMetre = "KilocaloriePerCubicMetre";
	public static string KilocaloriePerLitre = "KilocaloriePerLitre";
	public static string JoulePerCubicFoot = "JoulePerCubicFoot";
	public static string KilojoulePerCubicFoot = "KilojoulePerCubicFoot";
	public static string MegajoulePerCubicFoot = "MegajoulePerCubicFoot";
	public static string GigajoulePerCubicFoot = "GigajoulePerCubicFoot";
	public static string CaloriePerCubicFoot = "CaloriePerCubicFoot";
	public static string KilocaloriePerCubicFoot = "KilocaloriePerCubicFoot";
	public static string JoulePerCubicInch = "JoulePerCubicInch";
	public static string KilojoulePerCubicInch = "KilojoulePerCubicInch";
	public static string MegajoulePerCubicInch = "MegajoulePerCubicInch";
	public static string GigajoulePerCubicInch = "GigajoulePerCubicInch";
	public static string CaloriePerCubicInch = "CaloriePerCubicInch";
	public static string KilocaloriePerCubicInch = "KilocaloriePerCubicInch";
	public static string JoulePerGallonUk = "JoulePerGallonUk";
	public static string KilojoulePerGallonUk = "KilojoulePerGallonUk";
	public static string MegajoulePerGallonUk = "MegajoulePerGallonUk";
	public static string GigajoulePerGallonUk = "GigajoulePerGallonUk";
	public static string CaloriePerGallonUk = "CaloriePerGallonUk";
	public static string KilocaloriePerGallonUk = "KilocaloriePerGallonUk";
	public static string JoulePerGallonUs = "JoulePerGallonUs";
	public static string KilojoulePerGallonUs = "KilojoulePerGallonUs";
	public static string MegajoulePerGallonUs = "MegajoulePerGallonUs";
	public static string GigajoulePerGallonUs = "GigajoulePerGallonUs";
	public static string CaloriePerGallonUs = "CaloriePerGallonUs";
	public static string KilocaloriePerGallonUs = "KilocaloriePerGallonUs";
	public static string BritishThermalUnitPerCubicMetre = "BritishThermalUnitPerCubicMetre";
	public static string BritishThermalUnitPerLitre = "BritishThermalUnitPerLitre";
	public static string BritishThermalUnitPerCubicFoot = "BritishThermalUnitPerCubicFoot";
	public static string BritishThermalUnitPerCubicInch = "BritishThermalUnitPerCubicInch";
	public static string BritishThermalUnitPerGallonUk = "BritishThermalUnitPerGallonUk";
	public static string BritishThermalUnitPerGallonUs = "BritishThermalUnitPerGallonUs";
	public static string KiloBritishThermalUnitPerCubicMetre = "KiloBritishThermalUnitPerCubicMetre";
	public static string KiloBritishThermalUnitPerLitre = "KiloBritishThermalUnitPerLitre";
	public static string KiloBritishThermalUnitPerCubicFoot = "KiloBritishThermalUnitPerCubicFoot";
	public static string KiloBritishThermalUnitPerCubicInch = "KiloBritishThermalUnitPerCubicInch";
	public static string KiloBritishThermalUnitPerGallonUk = "KiloBritishThermalUnitPerGallonUk";
	public static string KiloBritishThermalUnitPerGallonUs = "KiloBritishThermalUnitPerGallonUs";
	public static string NewtonPerMetre = "NewtonPerMetre";
	public static string NewtonPer30Metre = "NewtonPer30Metre";
	public static string NewtonPer10Metre = "NewtonPer10Metre";
	public static string NewtonPerDecimetre = "NewtonPerDecimetre";
	public static string NewtonPerCentimetre = "NewtonPerCentimetre";
	public static string NewtonPerMillimetre = "NewtonPerMillimetre";
	public static string DecanewtonPerMetre = "DecanewtonPerMetre";
	public static string DecanewtonPer30Metre = "DecanewtonPer30Metre";
	public static string DecanewtonPer10Metre = "DecanewtonPer10Metre";
	public static string DecanewtonPerDecimetre = "DecanewtonPerDecimetre";
	public static string DecanewtonPerCentimetre = "DecanewtonPerCentimetre";
	public static string DecanewtonPerMillimetre = "DecanewtonPerMillimetre";
	public static string KilonewtonPerMetre = "KilonewtonPerMetre";
	public static string KilonewtonPer30Metre = "KilonewtonPer30Metre";
	public static string KilonewtonPer10Metre = "KilonewtonPer10Metre";
	public static string KilonewtonPerDecimetre = "KilonewtonPerDecimetre";
	public static string KilonewtonPerCentimetre = "KilonewtonPerCentimetre";
	public static string KilonewtonPerMillimetre = "KilonewtonPerMillimetre";
	public static string PoundPerFoot = "PoundPerFoot";
	public static string PoundPerInch = "PoundPerInch";
	public static string KilopoundPerFoot = "KilopoundPerFoot";
	public static string KilopoundPerInch = "KilopoundPerInch";
	public static string PoundPer30Foot = "PoundPer30Foot";
	public static string PoundPer100Foot = "PoundPer100Foot";
	public static string KilopoundPer30Foot = "KilopoundPer30Foot";
	public static string KilopoundPer100Foot = "KilopoundPer100Foot";
	public static string Newton = "Newton";
	public static string Decanewton = "Decanewton";
	public static string Kilonewton = "Kilonewton";
	public static string Kilodecanewton = "Kilodecanewton";
	public static string KilogramForce = "KilogramForce";
	public static string PoundForce = "PoundForce";
	public static string KilopoundForce = "KilopoundForce";
	public static string Hertz = "Hertz";
	public static string ReciprocalSecond = "ReciprocalSecond";
	public static string Kilohertz = "Kilohertz";
	public static string Megahertz = "Megahertz";
	public static string Gigahertz = "Gigahertz";
	public static string Terahertz = "Terahertz";
	public static string Rpm = "Rpm";
	public static string Spm = "Spm";
	public static string RotationPerSecond = "RotationPerSecond";
	public static string StrokePerSecond = "StrokePerSecond";
	public static string StrokePerHour = "StrokePerHour";
	public static string RotationPerHour = "RotationPerHour";
	public static string ShockPerSecond = "ShockPerSecond";
	public static string ShockPerMinute = "ShockPerMinute";
	public static string ShockPerHour = "ShockPerHour";
	public static string HertzPerSecond = "HertzPerSecond";
	public static string KiloHertzPerSecond = "KiloHertzPerSecond";
	public static string MegaHertzPerSecond = "MegaHertzPerSecond";
	public static string GigaHertzPerSecond = "GigaHertzPerSecond";
	public static string HertzPerMinute = "HertzPerMinute";
	public static string KiloHertzPerMinute = "KiloHertzPerMinute";
	public static string MegaHertzPerMinute = "MegaHertzPerMinute";
	public static string GigaHertzPerMinute = "GigaHertzPerMinute";
	public static string HertzPerHour = "HertzPerHour";
	public static string KiloHertzPerHour = "KiloHertzPerHour";
	public static string MegaHertzPerHour = "MegaHertzPerHour";
	public static string GigaHertzPerHour = "GigaHertzPerHour";
	public static string HertzPerDay = "HertzPerDay";
	public static string KiloHertzPerDay = "KiloHertzPerDay";
	public static string MegaHertzPerDay = "MegaHertzPerDay";
	public static string GigaHertzPerDay = "GigaHertzPerDay";
	public static string HertzPerYear = "HertzPerYear";
	public static string KiloHertzPerYear = "KiloHertzPerYear";
	public static string MegaHertzPerYear = "MegaHertzPerYear";
	public static string GigaHertzPerYear = "GigaHertzPerYear";
	public static string RpmPerSecond = "RpmPerSecond";
	public static string SpmPerSecond = "SpmPerSecond";
	public static string WattPerSquareMetrePerKelvin = "WattPerSquareMetrePerKelvin";
	public static string BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit = "BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit";
	public static string DotPerMetre = "DotPerMetre";
	public static string DotPerInch = "DotPerInch";
	public static string DotPerMillimetre = "DotPerMillimetre";
	public static string DotPerMicrometre = "DotPerMicrometre";
	public static string MillinewtonPerMetre = "MillinewtonPerMetre";
	public static string DynePerCentimetre = "DynePerCentimetre";
	public static string PoundPerSecondSquared = "PoundPerSecondSquared";
	public static string Metre = "Metre";
	public static string Decimetre = "Decimetre";
	public static string Centimetre = "Centimetre";
	public static string Millimetre = "Millimetre";
	public static string Micrometre = "Micrometre";
	public static string Nanometre = "Nanometre";
	public static string Aangstroem = "Aangstroem";
	public static string Picometre = "Picometre";
	public static string Decametre = "Decametre";
	public static string Hectometre = "Hectometre";
	public static string Kilometre = "Kilometre";
	public static string AstronomicalUnit = "AstronomicalUnit";
	public static string LightYear = "LightYear";
	public static string Parsec = "Parsec";
	public static string Foot = "Foot";
	public static string UsSurveyFoot = "UsSurveyFoot";
	public static string Inch = "Inch";
	public static string Yard = "Yard";
	public static string Fathom = "Fathom";
	public static string SurveyorSChain = "SurveyorSChain";
	public static string Mile = "Mile";
	public static string InternationalNauticalMile = "InternationalNauticalMile";
	public static string UkNauticalMile = "UkNauticalMile";
	public static string ScandinavianMile = "ScandinavianMile";
	public static string InchPer32 = "InchPer32";
	public static string Mil = "Mil";
	public static string Thou = "Thou";
	public static string Hand = "Hand";
	public static string Furlong = "Furlong";
	public static string Candela = "Candela";
	public static string LumenPerSteradian = "LumenPerSteradian";
	public static string Millicandela = "Millicandela";
	public static string Kilocandela = "Kilocandela";
	public static string Hefnerkerze = "Hefnerkerze";
	public static string InternationalCandle = "InternationalCandle";
	public static string DecimalCandle = "DecimalCandle";
	public static string BerlinerLichteinheit = "BerlinerLichteinheit";
	public static string DvwgCandle = "DvwgCandle";
	public static string Violle = "Violle";
	public static string Carcel = "Carcel";
	public static string Tesla = "Tesla";
	public static string Gauss = "Gauss";
	public static string Milligauss = "Milligauss";
	public static string Millitesla = "Millitesla";
	public static string Microtesla = "Microtesla";
	public static string Nanotesla = "Nanotesla";
	public static string MaxwellPerSquareCentimetre = "MaxwellPerSquareCentimetre";
	public static string WeberPerSquareMetre = "WeberPerSquareMetre";
	public static string Weber = "Weber";
	public static string Milliweber = "Milliweber";
	public static string Microweber = "Microweber";
	public static string VoltSecond = "VoltSecond";
	public static string UnitPole = "UnitPole";
	public static string Megaline = "Megaline";
	public static string Kiloline = "Kiloline";
	public static string Line = "Line";
	public static string Maxwell = "Maxwell";
	public static string TeslaSquareMetre = "TeslaSquareMetre";
	public static string TeslaSquareCentimetre = "TeslaSquareCentimetre";
	public static string GaussSquareCentimetre = "GaussSquareCentimetre";
	public static string MagneticFluxQuantum = "MagneticFluxQuantum";
	public static string KilogramPerMetre = "KilogramPerMetre";
	public static string GramPerMetre = "GramPerMetre";
	public static string KilogramPerSecond = "KilogramPerSecond";
	public static string KilogramPerMinute = "KilogramPerMinute";
	public static string KilogramPerHour = "KilogramPerHour";
	public static string KilogramPerYear = "KilogramPerYear";
	public static string PoundPerSecond = "PoundPerSecond";
	public static string PoundPerMinute = "PoundPerMinute";
	public static string PoundPerHour = "PoundPerHour";
	public static string PoundPerYear = "PoundPerYear";
	public static string Pascal = "Pascal";
	public static string Megapascal = "Megapascal";
	public static string Gigapascal = "Gigapascal";
	public static string Psi = "Psi";
	public static string PoundPer100SquareFoot = "PoundPer100SquareFoot";
	public static string MegapoundPerSquareInch = "MegapoundPerSquareInch";
	public static string Darcy = "Darcy";
	public static string Millidarcy = "Millidarcy";
	public static string Microdarcy = "Microdarcy";
	public static string Nanodarcy = "Nanodarcy";
	public static string Radian = "Radian";
	public static string Milliradian = "Milliradian";
	public static string Degree = "Degree";
	public static string Grad = "Grad";
	public static string Gon = "Gon";
	public static string Circle = "Circle";
	public static string Revolution = "Revolution";
	public static string Quadrant = "Quadrant";
	public static string Sextant = "Sextant";
	public static string Octant = "Octant";
	public static string ArcMinute = "ArcMinute";
	public static string ArcSecond = "ArcSecond";
	public static string Watt = "Watt";
	public static string Decawatt = "Decawatt";
	public static string Hectowatt = "Hectowatt";
	public static string Kilowatt = "Kilowatt";
	public static string Megawatt = "Megawatt";
	public static string Gigawatt = "Gigawatt";
	public static string Terawatt = "Terawatt";
	public static string Petawatt = "Petawatt";
	public static string Exawatt = "Exawatt";
	public static string Deciwatt = "Deciwatt";
	public static string Centiwatt = "Centiwatt";
	public static string Milliwatt = "Milliwatt";
	public static string Microwatt = "Microwatt";
	public static string Nanowatt = "Nanowatt";
	public static string Picowatt = "Picowatt";
	public static string Femtowatt = "Femtowatt";
	public static string Attowatt = "Attowatt";
	public static string PascalPerMetre = "PascalPerMetre";
	public static string BarPerMetre = "BarPerMetre";
	public static string PsiPerMetre = "PsiPerMetre";
	public static string PsiPerFoot = "PsiPerFoot";
	public static string PressureLossConstantSi = "PressureLossConstantSi";
	public static string PressureLossConstantMetric = "PressureLossConstantMetric";
	public static string PressureLossConstantUk = "PressureLossConstantUk";
	public static string PressureLossConstantUs = "PressureLossConstantUs";
	public static string Kilopascal = "Kilopascal";
	public static string Bar = "Bar";
	public static string Millibar = "Millibar";
	public static string Microbar = "Microbar";
	public static string PoundPerSquareInch = "PoundPerSquareInch";
	public static string KilopoundPerSquareInch = "KilopoundPerSquareInch";
	public static string StandardAtmosphere = "StandardAtmosphere";
	public static string PoundPerSquareFoot = "PoundPerSquareFoot";
	public static string NewtonPerSquareMetre = "NewtonPerSquareMetre";
	public static string NewtonPerSquareCentimetre = "NewtonPerSquareCentimetre";
	public static string NewtonPerSquareMillimetre = "NewtonPerSquareMillimetre";
	public static string KilonewtonPerSquareMetre = "KilonewtonPerSquareMetre";
	public static string Torr = "Torr";
	public static string CentimetreMercuryAtZeroDegreeCelsius = "CentimetreMercuryAtZeroDegreeCelsius";
	public static string MillimetreMercuryAtZeroDegreeCelsius = "MillimetreMercuryAtZeroDegreeCelsius";
	public static string InchMercuryAt32DegreeFahrenheit = "InchMercuryAt32DegreeFahrenheit";
	public static string InchMercuryAt60DegreeFahrenheit = "InchMercuryAt60DegreeFahrenheit";
	public static string CentimetreWaterAt4DegreeCelsius = "CentimetreWaterAt4DegreeCelsius";
	public static string MillimetreWaterAt4DegreeCelsius = "MillimetreWaterAt4DegreeCelsius";
	public static string InchWaterAt4DegreeCelsius = "InchWaterAt4DegreeCelsius";
	public static string FootWaterAt4DegreeCelsius = "FootWaterAt4DegreeCelsius";
	public static string DynePerSquareCentimetre = "DynePerSquareCentimetre";
	public static string Proportion = "Proportion";
	public static string Percent = "Percent";
	public static string PerThousand = "PerThousand";
	public static string PartPerMillion = "PartPerMillion";
	public static string RadianPerSquareRootSecond = "RadianPerSquareRootSecond";
	public static string RadianPerSquareRootMinute = "RadianPerSquareRootMinute";
	public static string RadianPerSquareRootHour = "RadianPerSquareRootHour";
	public static string RadianPerSquareRootDay = "RadianPerSquareRootDay";
	public static string DegreePerSquareRootSecond = "DegreePerSquareRootSecond";
	public static string DegreePerSquareRootMinute = "DegreePerSquareRootMinute";
	public static string DegreePerSquareRootHour = "DegreePerSquareRootHour";
	public static string DegreePerSquareRootDay = "DegreePerSquareRootDay";
	public static string Kelvin = "Kelvin";
	public static string RelativeCelsius = "RelativeCelsius";
	public static string Rankine = "Rankine";
	public static string OhmMetre = "OhmMetre";
	public static string KiloOhmMetre = "KiloOhmMetre";
	public static string MegaOhmMetre = "MegaOhmMetre";
	public static string GigaOhmMetre = "GigaOhmMetre";
	public static string Steradian = "Steradian";
	public static string Spat = "Spat";
	public static string DegreeSquared = "DegreeSquared";
	public static string JoulePerKilogramKelvin = "JoulePerKilogramKelvin";
	public static string JoulePerGramKelvin = "JoulePerGramKelvin";
	public static string JoulePerGramDegreeCelsius = "JoulePerGramDegreeCelsius";
	public static string CaloriePerGramDegreeCelsius = "CaloriePerGramDegreeCelsius";
	public static string BritishThermalUnitPerPoundDegreeFahrenheit = "BritishThermalUnitPerPoundDegreeFahrenheit";
	public static string KilocaloriePerGramDegreeCelsius = "KilocaloriePerGramDegreeCelsius";
	public static string JoulePerKilogramSquaredKelvin = "JoulePerKilogramSquaredKelvin";
	public static string JoulePerGramSquaredKelvin = "JoulePerGramSquaredKelvin";
	public static string JoulePerGramDegreeSquaredCelsius = "JoulePerGramDegreeSquaredCelsius";
	public static string CaloriePerGramDegreeSquaredCelsius = "CaloriePerGramDegreeSquaredCelsius";
	public static string BritishThermalUnitPerPoundSquaredDegreeFahrenheit = "BritishThermalUnitPerPoundSquaredDegreeFahrenheit";
	public static string KelvinPerMetre = "KelvinPerMetre";
	public static string CelsiusPerMetre = "CelsiusPerMetre";
	public static string CelsiusPer10Metre = "CelsiusPer10Metre";
	public static string CelsiusPer30Metre = "CelsiusPer30Metre";
	public static string CelsiusPer100Metre = "CelsiusPer100Metre";
	public static string CelsiusPerFoot = "CelsiusPerFoot";
	public static string CelsiusPer30Foot = "CelsiusPer30Foot";
	public static string CelsiusPer100Foot = "CelsiusPer100Foot";
	public static string FahrenheitPerFoot = "FahrenheitPerFoot";
	public static string FahrenheitPer30Foot = "FahrenheitPer30Foot";
	public static string FahrenheitPer100Foot = "FahrenheitPer100Foot";
	public static string Celsius = "Celsius";
	public static string Fahrenheit = "Fahrenheit";
	public static string Réaumur = "Réaumur";
	public static string WattPerMetreKelvin = "WattPerMetreKelvin";
	public static string CaloriePerMetreSecondDegreeCelsius = "CaloriePerMetreSecondDegreeCelsius";
	public static string CaloriePerCentimetreSecondDegreeCelsius = "CaloriePerCentimetreSecondDegreeCelsius";
	public static string BritishThermalUnitPerHourFootDegreeFahrenheit = "BritishThermalUnitPerHourFootDegreeFahrenheit";
	public static string BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit = "BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit";
	public static string WattPerMetreKelvinPerKelvin = "WattPerMetreKelvinPerKelvin";
	public static string CaloriePerMetreSecondDegreeCelsiusSquared = "CaloriePerMetreSecondDegreeCelsiusSquared";
	public static string CaloriePerCentimetreSecondDegreeCelsiusSquared = "CaloriePerCentimetreSecondDegreeCelsiusSquared";
	public static string BritishThermalUnitPerHourFootDegreeFahrenheitSquared = "BritishThermalUnitPerHourFootDegreeFahrenheitSquared";
	public static string BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared = "BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared";
	public static string Second = "Second";
	public static string Millisecond = "Millisecond";
	public static string Microsecond = "Microsecond";
	public static string Shake = "Shake";
	public static string Nanosecond = "Nanosecond";
	public static string Picosecond = "Picosecond";
	public static string Minute = "Minute";
	public static string Hour = "Hour";
	public static string Day = "Day";
	public static string Week = "Week";
	public static string Fortnight = "Fortnight";
	public static string MonthCommon = "MonthCommon";
	public static string MonthSideral = "MonthSideral";
	public static string MonthSynodic = "MonthSynodic";
	public static string QuarterCommon = "QuarterCommon";
	public static string YearCommon = "YearCommon";
	public static string YearAverageGregorian = "YearAverageGregorian";
	public static string YearJulian = "YearJulian";
	public static string YearLeap = "YearLeap";
	public static string YearTropical = "YearTropical";
	public static string Decade = "Decade";
	public static string Century = "Century";
	public static string Millenia = "Millenia";
	public static string MillionYear = "MillionYear";
	public static string NewtonMetrePerMetre = "NewtonMetrePerMetre";
	public static string DecanewtonMetrePerMetre = "DecanewtonMetrePerMetre";
	public static string KilogramForceMetrePerMetre = "KilogramForceMetrePerMetre";
	public static string KilonewtonMetrePerMetre = "KilonewtonMetrePerMetre";
	public static string FootPoundPerMetre = "FootPoundPerMetre";
	public static string KilofootPoundPerMetre = "KilofootPoundPerMetre";
	public static string NewtonDecimetrePerMetre = "NewtonDecimetrePerMetre";
	public static string NewtonCentimetrePerMetre = "NewtonCentimetrePerMetre";
	public static string NewtonMillimetrePerMetre = "NewtonMillimetrePerMetre";
	public static string InchPoundPerMetre = "InchPoundPerMetre";
	public static string NewtonMetrePerDecimetre = "NewtonMetrePerDecimetre";
	public static string DecanewtonMetrePerDecimetre = "DecanewtonMetrePerDecimetre";
	public static string KilogramForceMetrePerDecimetre = "KilogramForceMetrePerDecimetre";
	public static string KilonewtonMetrePerDecimetre = "KilonewtonMetrePerDecimetre";
	public static string FootPoundPerDecimetre = "FootPoundPerDecimetre";
	public static string KilofootPoundPerDecimetre = "KilofootPoundPerDecimetre";
	public static string NewtonDecimetrePerDecimetre = "NewtonDecimetrePerDecimetre";
	public static string NewtonCentimetrePerDecimetre = "NewtonCentimetrePerDecimetre";
	public static string NewtonMillimetrePerDecimetre = "NewtonMillimetrePerDecimetre";
	public static string InchPoundPerDecimetre = "InchPoundPerDecimetre";
	public static string NewtonMetrePerCentimetre = "NewtonMetrePerCentimetre";
	public static string DecanewtonMetrePerCentimetre = "DecanewtonMetrePerCentimetre";
	public static string KilogramForceMetrePerCentimetre = "KilogramForceMetrePerCentimetre";
	public static string KilonewtonMetrePerCentimetre = "KilonewtonMetrePerCentimetre";
	public static string FootPoundPerCentimetre = "FootPoundPerCentimetre";
	public static string KilofootPoundPerCentimetre = "KilofootPoundPerCentimetre";
	public static string NewtonDecimetrePerCentimetre = "NewtonDecimetrePerCentimetre";
	public static string NewtonCentimetrePerCentimetre = "NewtonCentimetrePerCentimetre";
	public static string NewtonMillimetrePerCentimetre = "NewtonMillimetrePerCentimetre";
	public static string InchPoundPerCentimetre = "InchPoundPerCentimetre";
	public static string NewtonMetrePerMillimetre = "NewtonMetrePerMillimetre";
	public static string DecanewtonMetrePerMillimetre = "DecanewtonMetrePerMillimetre";
	public static string KilogramForceMetrePerMillimetre = "KilogramForceMetrePerMillimetre";
	public static string KilonewtonMetrePerMillimetre = "KilonewtonMetrePerMillimetre";
	public static string FootPoundPerMillimetre = "FootPoundPerMillimetre";
	public static string KilofootPoundPerMillimetre = "KilofootPoundPerMillimetre";
	public static string NewtonDecimetrePerMillimetre = "NewtonDecimetrePerMillimetre";
	public static string NewtonCentimetrePerMillimetre = "NewtonCentimetrePerMillimetre";
	public static string NewtonMillimetrePerMillimetre = "NewtonMillimetrePerMillimetre";
	public static string InchPoundPerMillimetre = "InchPoundPerMillimetre";
	public static string NewtonMetrePerFoot = "NewtonMetrePerFoot";
	public static string DecanewtonMetrePerFoot = "DecanewtonMetrePerFoot";
	public static string KilogramForceMetrePerFoot = "KilogramForceMetrePerFoot";
	public static string KilonewtonMetrePerFoot = "KilonewtonMetrePerFoot";
	public static string FootPoundPerFoot = "FootPoundPerFoot";
	public static string KilofootPoundPerFoot = "KilofootPoundPerFoot";
	public static string NewtonDecimetrePerFoot = "NewtonDecimetrePerFoot";
	public static string NewtonCentimetrePerFoot = "NewtonCentimetrePerFoot";
	public static string NewtonMillimetrePerFoot = "NewtonMillimetrePerFoot";
	public static string InchPoundPerFoot = "InchPoundPerFoot";
	public static string NewtonMetrePerInch = "NewtonMetrePerInch";
	public static string DecanewtonMetrePerInch = "DecanewtonMetrePerInch";
	public static string KilogramForceMetrePerInch = "KilogramForceMetrePerInch";
	public static string KilonewtonMetrePerInch = "KilonewtonMetrePerInch";
	public static string FootPoundPerInch = "FootPoundPerInch";
	public static string KilofootPoundPerInch = "KilofootPoundPerInch";
	public static string NewtonDecimetrePerInch = "NewtonDecimetrePerInch";
	public static string NewtonCentimetrePerInch = "NewtonCentimetrePerInch";
	public static string NewtonMillimetrePerInch = "NewtonMillimetrePerInch";
	public static string InchPoundPerInch = "InchPoundPerInch";
	public static string NewtonMetre = "NewtonMetre";
	public static string DecanewtonMetre = "DecanewtonMetre";
	public static string KilogramForceMetre = "KilogramForceMetre";
	public static string KilonewtonMetre = "KilonewtonMetre";
	public static string FootPound = "FootPound";
	public static string KilofootPound = "KilofootPound";
	public static string NewtonDecimetre = "NewtonDecimetre";
	public static string NewtonCentimetre = "NewtonCentimetre";
	public static string NewtonMillimetre = "NewtonMillimetre";
	public static string InchPound = "InchPound";
	public static string MetrePerSecond = "MetrePerSecond";
	public static string MetrePerMinute = "MetrePerMinute";
	public static string CentimetrePerSecond = "CentimetrePerSecond";
	public static string MetrePerHour = "MetrePerHour";
	public static string MetrePerDay = "MetrePerDay";
	public static string FootPerHour = "FootPerHour";
	public static string FootPerDay = "FootPerDay";
	public static string FootPerMinute = "FootPerMinute";
	public static string FootPerSecond = "FootPerSecond";
	public static string InchPerSecond = "InchPerSecond";
	public static string MilePerHour = "MilePerHour";
	public static string KilometrePerHour = "KilometrePerHour";
	public static string KilometrePerMinute = "KilometrePerMinute";
	public static string KilometrePerSecond = "KilometrePerSecond";
	public static string KilometrePerDay = "KilometrePerDay";
	public static string MilePerMinute = "MilePerMinute";
	public static string MilePerSecond = "MilePerSecond";
	public static string MilePerDay = "MilePerDay";
	public static string InchPerMinute = "InchPerMinute";
	public static string InchPerHour = "InchPerHour";
	public static string InchPerDay = "InchPerDay";
	public static string CentimetrePerMinute = "CentimetrePerMinute";
	public static string CentimetrePerHour = "CentimetrePerHour";
	public static string CentimetrePerDay = "CentimetrePerDay";
	public static string MillimetrePerSecond = "MillimetrePerSecond";
	public static string MillimetrePerMinute = "MillimetrePerMinute";
	public static string MillimetrePerHour = "MillimetrePerHour";
	public static string MillimetrePerDay = "MillimetrePerDay";
	public static string DecimetrePerSecond = "DecimetrePerSecond";
	public static string DecimetrePerMinute = "DecimetrePerMinute";
	public static string DecimetrePerHour = "DecimetrePerHour";
	public static string DecimetrePerDay = "DecimetrePerDay";
	public static string FurlongPerFortnight = "FurlongPerFortnight";
	public static string CubicMetre = "CubicMetre";
	public static string Litre = "Litre";
	public static string Decilitre = "Decilitre";
	public static string Centilitre = "Centilitre";
	public static string Millilitre = "Millilitre";
	public static string UsGallon = "UsGallon";
	public static string UkGallon = "UkGallon";
	public static string Barrel = "Barrel";
	public static string MillionCubicMetre = "MillionCubicMetre";
	public static string MillionLitre = "MillionLitre";
	public static string MillionUkGallon = "MillionUkGallon";
	public static string MillionBarrel = "MillionBarrel";
	public static string ThousandStandardCubicFoot = "ThousandStandardCubicFoot";
	public static string MillionStandardCubicFoot = "MillionStandardCubicFoot";
	public static string CubicFoot = "CubicFoot";
	public static string CubicInch = "CubicInch";
	public static string MillionUsGallon = "MillionUsGallon";
	public static string CubicMetrePerSecondSquared = "CubicMetrePerSecondSquared";
	public static string LitrePerMinuteSquared = "LitrePerMinuteSquared";
	public static string LitrePerMinutePerSecond = "LitrePerMinutePerSecond";
	public static string LitrePerSecondSquared = "LitrePerSecondSquared";
	public static string UkGallonPerMinuteSquared = "UkGallonPerMinuteSquared";
	public static string UkGallonPerMinutePerSecond = "UkGallonPerMinutePerSecond";
	public static string UsGallonPerMinuteSquared = "UsGallonPerMinuteSquared";
	public static string UsGallonPerMinutePerSecond = "UsGallonPerMinutePerSecond";
	public static string CubicMetrePerSecond = "CubicMetrePerSecond";
	public static string LitrePerSecond = "LitrePerSecond";
	public static string CubicFootPerSecond = "CubicFootPerSecond";
	public static string UkGallonPerSecond = "UkGallonPerSecond";
	public static string UsGallonPerSecond = "UsGallonPerSecond";
	public static string BarrelPerSecond = "BarrelPerSecond";
	public static string CubicMetrePerMinute = "CubicMetrePerMinute";
	public static string LitrePerMinute = "LitrePerMinute";
	public static string CubicFootPerMinute = "CubicFootPerMinute";
	public static string UkGallonPerMinute = "UkGallonPerMinute";
	public static string UsGallonPerMinute = "UsGallonPerMinute";
	public static string BarrelPerMinute = "BarrelPerMinute";
	public static string CubicMetrePerHour = "CubicMetrePerHour";
	public static string LitrePerHour = "LitrePerHour";
	public static string CubicFootPerHour = "CubicFootPerHour";
	public static string UkGallonPerHour = "UkGallonPerHour";
	public static string UsGallonPerHour = "UsGallonPerHour";
	public static string BarrelPerHour = "BarrelPerHour";
	public static string CubicMetrePerDay = "CubicMetrePerDay";
	public static string MillionCubicMetrePerDay = "MillionCubicMetrePerDay";
	public static string UkGallonPerDay = "UkGallonPerDay";
	public static string UsGallonPerDay = "UsGallonPerDay";
	public static string MillionUkGallonPerDay = "MillionUkGallonPerDay";
	public static string MillionUsGallonPerDay = "MillionUsGallonPerDay";
	public static string LitrePerDay = "LitrePerDay";
	public static string MillionLiterPerDay = "MillionLiterPerDay";
	public static string CubicFootPerDay = "CubicFootPerDay";
	public static string ThousandStandardCubicFootPerDay = "ThousandStandardCubicFootPerDay";
	public static string MillionStandardCubicFootPerDay = "MillionStandardCubicFootPerDay";
	public static string BarrelPerDay = "BarrelPerDay";
	public static string CubicMetrePerYear = "CubicMetrePerYear";
	public static string LitrePerYear = "LitrePerYear";
	public static string CubicFootPerYear = "CubicFootPerYear";
	public static string UkGallonPerYear = "UkGallonPerYear";
	public static string UsGallonPerYear = "UsGallonPerYear";
	public static string BarrelPerYear = "BarrelPerYear";
	public static string ReciprocalMetre = "ReciprocalMetre";
	public static string ReciprocalDecimetre = "ReciprocalDecimetre";
	public static string ReciprocalCentimetre = "ReciprocalCentimetre";
	public static string ReciprocalMillimetre = "ReciprocalMillimetre";
	public static string ReciprocalMicrometre = "ReciprocalMicrometre";
	public static string ReciprocalNanometre = "ReciprocalNanometre";
	public static string ReciprocalAangstroem = "ReciprocalAangstroem";
	public static string ReciprocalPicometre = "ReciprocalPicometre";
	public static string ReciprocalDecametre = "ReciprocalDecametre";
	public static string ReciprocalHectometre = "ReciprocalHectometre";
	public static string ReciprocalKilometre = "ReciprocalKilometre";
	public static string ReciprocalAstronomicalUnit = "ReciprocalAstronomicalUnit";
	public static string ReciprocalLightYear = "ReciprocalLightYear";
	public static string ReciprocalParsec = "ReciprocalParsec";
	public static string ReciprocalFoot = "ReciprocalFoot";
	public static string ReciprocalUsSurveyFoot = "ReciprocalUsSurveyFoot";
	public static string ReciprocalInch = "ReciprocalInch";
	public static string ReciprocalYard = "ReciprocalYard";
	public static string ReciprocalFathom = "ReciprocalFathom";
	public static string ReciprocalSurveyorsChain = "ReciprocalSurveyorsChain";
	public static string ReciprocalMile = "ReciprocalMile";
	public static string ReciprocalInternationalNauticalMile = "ReciprocalInternationalNauticalMile";
	public static string ReciprocalUkNauticalMile = "ReciprocalUkNauticalMile";
	public static string ReciprocalScandinavianMile = "ReciprocalScandinavianMile";
	public static string ReciprocalInchPer32 = "ReciprocalInchPer32";
	public static string ReciprocalMil = "ReciprocalMil";
	public static string ReciprocalThou = "ReciprocalThou";
	public static string ReciprocalHand = "ReciprocalHand";
	public static string ReciprocalFurlong = "ReciprocalFurlong";
	public static string Kilogram = "Kilogram";
	public static string Hectogram = "Hectogram";
	public static string Decagram = "Decagram";
	public static string Gram = "Gram";
	public static string Centigram = "Centigram";
	public static string Milligram = "Milligram";
	public static string Microgram = "Microgram";
	public static string Nanogram = "Nanogram";
	public static string AtomMassUnit = "AtomMassUnit";
	public static string TonneMetric = "TonneMetric";
	public static string Kilotonne = "Kilotonne";
	public static string Megatonne = "Megatonne";
	public static string Gigatonne = "Gigatonne";
	public static string Pound = "Pound";
	public static string Kilopound = "Kilopound";
	public static string Ounce = "Ounce";
	public static string Stone = "Stone";
	public static string TonUk = "TonUk";
	public static string TonUs = "TonUs";
	public static string SolarMass = "SolarMass";
	public static string EarthMass = "EarthMass";
	public static string Grain = "Grain";
	public static string HundredWeights = "HundredWeights";
	public static string Joule = "Joule";
	public static string Kilojoule = "Kilojoule";
	public static string Megajoule = "Megajoule";
	public static string Gigajoule = "Gigajoule";
	public static string Calorie = "Calorie";
	public static string Kilocalorie = "Kilocalorie";
	public static string BritishThermalUnit = "BritishThermalUnit";
	public static string KiloBritishThermalUnit = "KiloBritishThermalUnit";
	public static string MegaBritishThermalUnit = "MegaBritishThermalUnit";
}
}
