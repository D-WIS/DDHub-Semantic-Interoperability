- Description: this definition set refers various drilling features that something may support. 

# NOUNS
## Feature <!-- NOUN -->
- Display name: Feature
- Parent class: DWISNoun
- Attributes:
- Description: A feature is a characteristic of something.
- Examples:
```dwis genericFeature
Feature:dataFeature
DWISNoun:drillingSystem
drillingSystem BelongsToClass DWISNoun
dataFeature BelongsToClass Feature
```
This example declares a generic feature associated with a drilling system.
## DataTransmissionFeature <!-- NOUN -->
- Display name: Data Transmission Feature
- Parent class: Feature
- Attributes:
- Description: A data transmission feature is a characteristic about how data is transferred from one place to another.
- Examples:
```dwis telemetryFeature
DataTransmissionFeature:telemetryLatencySupport
TransmissionLine:mudPulseTelemetry
telemetryLatencySupport BelongsToClass DataTransmissionFeature
mudPulseTelemetry BelongsToClass TransmissionLine
```
This example notes that mud-pulse telemetry supports a data transmission feature.
## LookupTableFeature <!-- NOUN -->
- Display name: Lookup Table Feature
- Parent class: DataTransmissionFeature
- Attributes:
- Description: Such a feature indicates that something accounts for lookup table.
- Examples:
```dwis lookupTable
LookupTableFeature:lookupTable
TransmissionLine:rigToDownholeTelemetry
rigToDownholeTelemetry BelongsToClass TransmissionLine
lookupTable BelongsToClass LookupTableFeature
```
This example highlights telemetry that uses lookup tables.
## ModellingFeature <!-- NOUN -->
- Display name: Modelling Feature
- Parent class: Feature
- Attributes:
- Description: A modelling feature is a characteristic about how system is modelled.
- Examples:
```dwis modellingApproach
ModellingFeature:modellingApproach
Simulator:hydraulicsSimulator
modellingApproach BelongsToClass ModellingFeature
hydraulicsSimulator BelongsToClass Simulator
```
This example links a modelling feature to a hydraulics simulator.
## SteadyStateFeature <!-- NOUN -->
- Display name: Steady State Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A steady state feature is a characteristic about a model that only accounts for steady state conditions.
- Examples:
```dwis steadyStateModel
SteadyStateFeature:steadyStateAssumption
Simulator:hydraulicsSimulator
steadyStateAssumption BelongsToClass SteadyStateFeature
hydraulicsSimulator BelongsToClass Simulator
```
This example marks that the hydraulics simulator assumes steady-state behavior.
## TransientFeature <!-- NOUN -->
- Display name: Transient Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A transient feature is a characteristic about a model that accounts for transient effects.
- Examples:
```dwis transientModel
TransientFeature:transientEffects
Simulator:surgeSwabSimulator
transientEffects BelongsToClass TransientFeature
surgeSwabSimulator BelongsToClass Simulator
```
This example marks that a surge/swab simulator accounts for transient effects.
## GelledStateFeature <!-- NOUN -->
- Display name: Gelled State Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A gelled state feature is a characteristic about a model that accounts for the gelled state of a fluid.
- Examples:
```dwis gelledState
GelledStateFeature:gelledState
Simulator:fluidModel
gelledState BelongsToClass GelledStateFeature
fluidModel BelongsToClass Simulator
```
This example notes that a fluid model captures gelled-state behavior.
## StaticFrictionFeature <!-- NOUN -->
- Display name: Static Friction Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A static friction feature is a characteristic about a model that accounts for the static friction along the string.
- Examples:
```dwis staticFriction
StaticFrictionFeature:staticFriction
Simulator:stringMechanicsModel
staticFriction BelongsToClass StaticFrictionFeature
stringMechanicsModel BelongsToClass Simulator
```
This example captures static friction in a string mechanics model.
## HydraulicallyInducedForceFeature <!-- NOUN -->
- Display name: Hydraulically Induced Force Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A hydraulically induced force feature is a characteristic about a model that accounts for hydraulically induced force on the string.
- Examples:
```dwis hydraulicForce
HydraulicallyInducedForceFeature:hydraulicForce
Simulator:hydraulicsSimulator
hydraulicForce BelongsToClass HydraulicallyInducedForceFeature
hydraulicsSimulator BelongsToClass Simulator
```
This example shows hydraulically induced forces included in a simulator.
## ShockedModellingFeature <!-- NOUN -->
- Display name: Shock Modelling Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A shock modelling feature is a characteristic about a model that accounts for shocks along the string.
- Examples:
```dwis shockModel
ShockedModellingFeature:shockEffects
Simulator:vibrationSimulator
shockEffects BelongsToClass ShockedModellingFeature
vibrationSimulator BelongsToClass Simulator
```
This example indicates shock effects are modelled in a vibration simulator.
## FluidCompressibilityFeature <!-- NOUN -->
- Display name: Fluid Compressibility Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A fluid compressibility feature is a characteristic about a model that accounts for fluid compressibility.
- Examples:
```dwis fluidCompressibility
FluidCompressibilityFeature:fluidCompressibility
Simulator:hydraulicsSimulator
fluidCompressibility BelongsToClass FluidCompressibilityFeature
hydraulicsSimulator BelongsToClass Simulator
```
This example notes fluid compressibility captured in hydraulics simulation.
## StringElasticityFeature <!-- NOUN -->
- Display name: String Elasticity Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A string elasticity feature is a characteristic about a model that accounts for string elasticity.
- Examples:
```dwis stringElasticity
StringElasticityFeature:stringElasticity
Simulator:stringMechanicsModel
stringElasticity BelongsToClass StringElasticityFeature
stringMechanicsModel BelongsToClass Simulator
```
This example shows string elasticity represented in a mechanics model.
## FluidThermalExpansionFeature <!-- NOUN -->
- Display name: Fluid Thermal Expansion Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A fluid thermal expansion feature is a characteristic about a model that accounts for the fluid thermal expansion.
- Examples:
```dwis fluidThermalExpansion
FluidThermalExpansionFeature:fluidThermalExpansion
Simulator:hydraulicsSimulator
fluidThermalExpansion BelongsToClass FluidThermalExpansionFeature
hydraulicsSimulator BelongsToClass Simulator
```
This example captures fluid thermal expansion in a hydraulics model.
## StringThermalExpansionFeature <!-- NOUN -->
- Display name: String Thermal Expansion Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A string thermal expansion feature is a characteristic about a model that accounts for the string thermal expansion.
- Examples:
```dwis stringThermalExpansion
StringThermalExpansionFeature:stringThermalExpansion
Simulator:stringMechanicsModel
stringThermalExpansion BelongsToClass StringThermalExpansionFeature
stringMechanicsModel BelongsToClass Simulator
```
This example captures string thermal expansion in a mechanics model.
## StringPressureBallooningFeature <!-- NOUN -->
- Display name: String Pressure Ballooning Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A string pressure ballooning feature is a characteristic about a model that accounts for the string pressure ballooning.
- Examples:
```dwis pressureBallooning
StringPressureBallooningFeature:pressureBallooning
Simulator:stringMechanicsModel
pressureBallooning BelongsToClass StringPressureBallooningFeature
stringMechanicsModel BelongsToClass Simulator
```
This example shows pressure ballooning effects included in a mechanics model.
## AirGapInStringFeature <!-- NOUN -->
- Display name: Air Gap In String Feature
- Parent class: ModellingFeature
- Attributes:
- Description: An air gap in string feature is a characteristic about a model that accounts for the possible air gap at the top of the liquid column in the string.
- Examples:
```dwis airGapFeature
AirGapInStringFeature:airGap
Simulator:hydraulicsSimulator
airGap BelongsToClass AirGapInStringFeature
hydraulicsSimulator BelongsToClass Simulator
```
This example notes air-gap effects captured in a hydraulics model.
## DrillingManagementFeature <!-- NOUN -->
- Display name: Drilling Management Feature
- Parent class: Feature
- Attributes:
- Description: A drilling management feature is a drilling management characteristic that is supported by something. For instance
an advisory system may provide ROP management parameters accounting for cuttings transport.
- Examples:
```dwis drillingManagement
DrillingManagementFeature:drillingManagement
Advisor:drillingAdvisor
drillingAdvisor AccountsFor drillingManagement
```
This example shows an advisor accounting for a drilling management feature.
## FillPipeFeature <!-- NOUN -->
- Display name: Fill Pipe Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A fill pipe feature indicates that something accounts for filling the pipe when there is an air gap.
- Examples:
```dwis fillPipeFeature
FillPipeFeature:fillPipe
ControlSystem:circulationDCS
circulationDCS AccountsFor fillPipe
```
This example shows a circulation control system accounting for pipe filling.
## GelBreakingFeature <!-- NOUN -->
- Display name: Gel Breaking Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A gel breaking feature indicates that something accounts for breaking the gel in a drilling fluid that has stayed
quiet for some time.
- Examples:
```dwis gelBreakFeature
GelBreakingFeature:gelBreak
Advisor:fluidAdvisor
fluidAdvisor AccountsFor gelBreak
```
This example shows an advisor accounting for gel breaking.
## CirculationFeature <!-- NOUN -->
- Display name: Circulation Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A circulation feature indicates that something accounts for circulation.
- Examples:
```dwis circulationFeature
CirculationFeature:circulationSupport
ControlSystem:circulationDCS
circulationDCS AccountsFor circulationSupport
```
This example shows a control system accounting for circulation.
## DrillingFluidDisplacementFeature <!-- NOUN -->
- Display name: Drilling Fluid Displacement Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A drilling fluid displacement feature indicates that something accounts for displacing a drilling fluid with another.
- Examples:
```dwis displacementFeature
DrillingFluidDisplacementFeature:fluidDisplacement
ControlSystem:circulationDCS
circulationDCS AccountsFor fluidDisplacement
```
This example shows support for displacing drilling fluids.
## DrillingFluidSweepFeature <!-- NOUN -->
- Display name: Drilling Fluid Sweep Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A drilling fluid sweep feature indicates that something accounts for sweeping the borehole with one or several fluids of 
different densities and/or viscosities.
- Examples:
```dwis sweepFeature
DrillingFluidSweepFeature:fluidSweep
Advisor:drillingAdvisor
drillingAdvisor AccountsFor fluidSweep
```
This example shows advisory support for fluid sweeps.
## CementingFeature <!-- NOUN -->
- Display name: Cementing Feature
- Parent class: DrillingFluidDisplacementFeature
- Attributes:
- Description: A cementing feature indicates that something accounts for displacing a train of drilling fluids and cement slurries to perform
a cement operation.
- Examples:
```dwis cementingFeature
CementingFeature:cementing
Advisor:cementingAdvisor
cementingAdvisor AccountsFor cementing
```
This example shows a system accounting for cementing operations.
## FormationWashoutFeature <!-- NOUN -->
- Display name: Formation Washout Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A formation washout feature indicates that something accounts for formation washout while circulating.
- Examples:
```dwis washoutFeature
FormationWashoutFeature:washout
Advisor:circulationAdvisor
circulationAdvisor AccountsFor washout
```
This example captures formation washout considerations.
## CuttingsTransportFeature <!-- NOUN -->
- Display name: Cuttings Transport Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A cuttings transport feature indicates that something accounts for cuttings transport while circulating.
- Examples:
```dwis cuttingsTransport
CuttingsTransportFeature:cuttingsTransport
Advisor:drillingAdvisor
drillingAdvisor AccountsFor cuttingsTransport
```
This example shows accounting for cuttings transport.
## PackOffFeature <!-- NOUN -->
- Display name: Pack-off Feature
- Parent class: CuttingsTransportFeature
- Attributes:
- Description: A pack-off feature indicates that something accounts for the possibility to pack-off while circulating cuttings.
- Examples:
```dwis packOffFeature
PackOffFeature:packOff
Advisor:drillingAdvisor
drillingAdvisor AccountsFor packOff
```
This example shows a system accounting for pack-off risk.
## DrillStemMovementFeature <!-- NOUN -->
- Display name: Drill-stem Movement Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A drill-stem movement feature indicates that something accounts for the drill-stem movement.
- Examples:
```dwis movementFeature
DrillStemMovementFeature:movement
ControlSystem:dcs
dcs AccountsFor movement
```
This example shows a control system accounting for drill-stem movement.
## DrillStemAxialMovementFeature <!-- NOUN -->
- Display name: Drill-stem Axial Movement Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A drill-stem axial movement feature indicates that something accounts for drill-stem axial movement.
- Examples:
```dwis axialMovementFeature
DrillStemAxialMovementFeature:axialMovement
ControlSystem:dcs
dcs AccountsFor axialMovement
```
This example shows accounting for axial movement.
## DrillStemRotationalMovementFeature <!-- NOUN -->
- Display name: Drill-stem Rotational Movement Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A drill-stem rotational movement feature indicates that something accounts for drill-stem rotational movement.
- Examples:
```dwis rotationalMovementFeature
DrillStemRotationalMovementFeature:rotationalMovement
ControlSystem:rotationDCS
rotationDCS AccountsFor rotationalMovement
```
This example shows accounting for rotational movement.
## StuckPipeFeature <!-- NOUN -->
- Display name: Stuck-pipe Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A stuck-pipe feature indicates that something accounts for stuck-pipes.
- Examples:
```dwis stuckPipeFeature
StuckPipeFeature:stuckPipe
Advisor:drillingAdvisor
drillingAdvisor AccountsFor stuckPipe
```
This example shows an advisor considering stuck-pipe risk.
## DrillStemAxialImpedimentFeature <!-- NOUN -->
- Display name: Drill-stem Axial Impediment Feature
- Parent class: StuckPipeFeature
- Attributes:
- Description: A drill-stem axial impediment feature indicates that something accounts for drill-stem axial impediment.
- Examples:
```dwis axialImpedimentFeature
DrillStemAxialImpedimentFeature:axialImpediment
Advisor:drillingAdvisor
drillingAdvisor AccountsFor axialImpediment
```
This example shows accounting for axial impediment.
## DrillStemRotationalImpedimentFeature <!-- NOUN -->
- Display name: Drill-stem Rotational Impediment Feature
- Parent class: StuckPipeFeature
- Attributes:
- Description: A drill-stem rotational impediment feature indicates that something accounts for drill-stem rotational impediment.
- Examples:
```dwis rotationalImpedimentFeature
DrillStemRotationalImpedimentFeature:rotationalImpediment
Advisor:drillingAdvisor
drillingAdvisor AccountsFor rotationalImpediment
```
This example shows accounting for rotational impediment.
## DrillStemVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Vibration Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A drill-stem vibration feature indicates that something accounts for drill-stem vibrations.
- Examples:
```dwis vibrationFeature
DrillStemVibrationFeature:vibration
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor vibration
```
This example shows accounting for drill-stem vibrations.
## DrillStemAxialVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Axial Vibration Feature
- Parent class: DrillStemVibrationFeature
- Attributes:
- Description: A drill-stem axial vibration feature indicates that something accounts for in particular axial drill-stem vibrations.
- Examples:
```dwis axialVibrationFeature
DrillStemAxialVibrationFeature:axialVibration
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor axialVibration
```
This example shows axial vibration coverage.
## DrillStemAxialStickSlipFeature <!-- NOUN -->
- Display name: Drill-stem Axial Stick-Slip Feature
- Parent class: DrillStemAxialVibrationFeature
- Attributes:
- Description: A drill-stem axial stick-slip feature indicates that something acconts for in particular axial stick-slip drill-stem vibrations.
- Examples:
```dwis axialStickSlipFeature
DrillStemAxialStickSlipFeature:axialStickSlip
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor axialStickSlip
```
This example notes axial stick-slip is considered.
## DrillStemTorsionalVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Torsional Vibration Feature
- Parent class: DrillStemVibrationFeature
- Attributes:
- Description: A drill-stem torsional vibration feature indicates that something acconts for in particular torsional drill-stem vibrations.
- Examples:
```dwis torsionalVibrationFeature
DrillStemTorsionalVibrationFeature:torsionalVibration
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor torsionalVibration
```
This example shows torsional vibrations covered.
## DrillStemTorsionalStickSlipFeature <!-- NOUN -->
- Display name: Drill-stem Torsional Stick-Slip Feature
- Parent class: DrillStemTorsionalVibrationFeature
- Attributes:
- Description: A drill-stem torsional stick-slip feature indicates that something acconts for in particular torsional stick-slip drill-stem vibrations.
- Examples:
```dwis torsionalStickSlipFeature
DrillStemTorsionalStickSlipFeature:torsionalStickSlip
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor torsionalStickSlip
```
This example shows torsional stick-slip considered.
## DrillStemLateralVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Lateral Vibration Feature
- Parent class: DrillStemVibrationFeature
- Attributes:
- Description: A drill-stem lateral vibration feature indicates that something accounts for in particular lateral drill-stem vibrations.
- Examples:
```dwis lateralVibrationFeature
DrillStemLateralVibrationFeature:lateralVibration
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor lateralVibration
```
This example shows lateral vibrations accounted for.
## DrillStemWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Whirling Feature
- Parent class: DrillStemLateralVibrationFeature
- Attributes:
- Description: A drill-stem whirling feature indicates that something accounts for in particular drill-stem whirling.
- Examples:
```dwis whirlingFeature
DrillStemWhirlingFeature:whirling
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor whirling
```
This example shows whirling considered.
## DrillStemForwardWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Forward Whirling Feature
- Parent class: DrillStemWhirlingFeature
- Attributes:
- Description: A drill-stem forward whirling feature indicates that something accounts for in particular drill-stem forward whirling.
- Examples:
```dwis forwardWhirlingFeature
DrillStemForwardWhirlingFeature:forwardWhirling
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor forwardWhirling
```
This example shows forward whirling covered.
## DrillStemBackwardWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Backward Whirling Feature
- Parent class: DrillStemWhirlingFeature
- Attributes:
- Description: A drill-stem backward whirling feature indicates that something accounts for in particular drill-stem backward whirling.
- Examples:
```dwis backwardWhirlingFeature
DrillStemBackwardWhirlingFeature:backwardWhirling
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor backwardWhirling
```
This example shows backward whirling covered.
## DrillStemChaoticWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Chaotic Whirling Feature
- Parent class: DrillStemWhirlingFeature
- Attributes:
- Description: A drill-stem chaotic whirling feature indicates that something accounts for in particular drill-stem chaotic whirling.
- Examples:
```dwis chaoticWhirlingFeature
DrillStemChaoticWhirlingFeature:chaoticWhirling
Advisor:vibrationAdvisor
vibrationAdvisor AccountsFor chaoticWhirling
```
This example shows chaotic whirling covered.
## DownholePressureFeature <!-- NOUN -->
- Display name: Downhole Pressure Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A downhole pressure feature indicates that something accounts for downhole pressure.
- Examples:
```dwis downholePressureFeature
DownholePressureFeature:downholePressure
Advisor:pressureAdvisor
pressureAdvisor AccountsFor downholePressure
```
This example shows downhole pressure management considered.
## SwabSurgeFeature <!-- NOUN -->
- Display name: Swab and Surge Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A swab and surge feature indicates that something accounts for swab and surge pressure variations.
- Examples:
```dwis swabSurgeFeature
SwabSurgeFeature:swabSurge
Advisor:pressureAdvisor
pressureAdvisor AccountsFor swabSurge
```
This example shows swab/surge variations considered.
## ManagedDownholePressureFeature <!-- NOUN -->
- Display name: Managed Downhole Pressure Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A managed downhole pressure feature indicates that something manages downhole pressure.
- Examples:
```dwis managedPressureFeature
ManagedDownholePressureFeature:managedPressure
Advisor:pressureAdvisor
pressureAdvisor AccountsFor managedPressure
```
This example shows managed pressure support.
## UnderBalanceFeature <!-- NOUN -->
- Display name: Under-balance Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: An under-balance feature indicates that something accounts for under-balance conditions.
- Examples:
```dwis underBalanceFeature
UnderBalanceFeature:underBalance
Advisor:pressureAdvisor
pressureAdvisor AccountsFor underBalance
```
This example shows under-balance conditions considered.
## GasAbsorptionFeature <!-- NOUN -->
- Display name: Gas Absorption Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A gas absorption feature indicates that something accounts for conditions by which gas can be absorbed by the drilling fluid.
- Examples:
```dwis gasAbsorptionFeature
GasAbsorptionFeature:gasAbsorption
Advisor:pressureAdvisor
pressureAdvisor AccountsFor gasAbsorption
```
This example shows gas absorption considered.
## FormationFracturingFeature <!-- NOUN -->
- Display name: Formation Fracturing Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A formation fracturing feature indicates that something accounts for formation fracturing pressure limits.
- Examples:
```dwis formationFractureFeature
FormationFracturingFeature:formationFracture
Advisor:pressureAdvisor
pressureAdvisor AccountsFor formationFracture
```
This example shows fracture pressure limits considered.
## FormationFluidInfluxFeature <!-- NOUN -->
- Display name: Formation Fluid Influx Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A formation fluid influx feature indicates that something accounts for formation pore pressure limits.
- Examples:
```dwis influxFeature
FormationFluidInfluxFeature:fluidInflux
Advisor:pressureAdvisor
pressureAdvisor AccountsFor fluidInflux
```
This example shows pore pressure/influx considered.
## FormationCollapseFeature <!-- NOUN -->
- Display name: Formation Collapse Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A formation collapse feature indicates that something accounts for formation collapse pressure limits.
- Examples:
```dwis collapseFeature
FormationCollapseFeature:collapse
Advisor:pressureAdvisor
pressureAdvisor AccountsFor collapse
```
This example shows formation collapse limits considered.
## HeaveFeature <!-- NOUN -->
- Display name: Heave Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A heave feature indicates that something accounts for the heave movement on downhole pressure effects.
- Examples:
```dwis heaveFeature
HeaveFeature:heave
Advisor:pressureAdvisor
pressureAdvisor AccountsFor heave
```
This example shows heave effects considered.
## OnBottomDrillingFeature <!-- NOUN -->
- Display name: On Bottom Drilling Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: An on bottom drilling feature indicates that something accounts for on bottom drilling.
- Examples:
```dwis onBottomFeature
OnBottomDrillingFeature:onBottomDrilling
ControlSystem:dcs
dcs AccountsFor onBottomDrilling
```
This example shows on-bottom drilling coverage.
## HoleOpeningFeature <!-- NOUN -->
- Display name: Hole Opening Feature
- Parent class: OnBottomDrillingFeature
- Attributes:
- Description: An hole opening feature indicates that something accounts for opening the borehole diameter.
- Examples:
```dwis holeOpeningFeature
HoleOpeningFeature:holeOpening
Advisor:drillingAdvisor
drillingAdvisor AccountsFor holeOpening
```
This example shows hole opening considered.
## UnderReamingFeature <!-- NOUN -->
- Display name: Under-reaming Feature
- Parent class: HoleOpeningFeature
- Attributes:
- Description: An under-reaming feature indicates that something accounts for under-reaming a borehole.
- Examples:
```dwis underReamingFeature
UnderReamingFeature:underReaming
Advisor:drillingAdvisor
drillingAdvisor AccountsFor underReaming
```
This example shows under-reaming considered.
## DrillStemBucklingFeature <!-- NOUN -->
- Display name: Drill-stem Buckling Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A drill-stem buckling feature indicates that something accounts for drill-stem buckling.
- Examples:
```dwis bucklingFeature
DrillStemBucklingFeature:buckling
Advisor:drillingAdvisor
drillingAdvisor AccountsFor buckling
```
This example shows buckling risk considered.
## HeatTransferFeature <!-- NOUN -->
- Display name: Heat Transfer Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A heat transfer feature indicates that something accounts for heat transfer.
- Examples:
```dwis heatTransferFeature
HeatTransferFeature:heatTransfer
Advisor:thermalAdvisor
thermalAdvisor AccountsFor heatTransfer
```
This example shows heat transfer considered.
## RigActionPlanFeature <!-- NOUN -->
- Display name: Rig Action Plan Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A rig action plan feature indicates that something accounts for the rig action plan.
- Examples:
```dwis rigActionPlanFeature
RigActionPlanFeature:rigActionPlan
ControlSystem:dcs
dcs AccountsFor rigActionPlan
```
This example shows accounting for rig action plans.
## DrillingProgramFeature <!-- NOUN -->
- Display name: Drilling Program Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A drilling program feature indicates that something accounts for the drilling program.
- Examples:
```dwis drillingProgramFeature
DrillingProgramFeature:drillingProgram
Advisor:drillingAdvisor
drillingAdvisor AccountsFor drillingProgram
```
This example shows coverage of a drilling program.

# VERBS
## AccountsFor <!-- VERB -->
- Display name: Accounts For  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DrillingManagementFeature
- Description: This verb is used to indicate something accounts for a drilling management feature.
- Examples:
```dwis accountsForExample
Advisor:drillingAdvisor
DrillingManagementFeature:cuttingsTransport
drillingAdvisor AccountsFor cuttingsTransport
```
This example shows an advisor accounting for cuttings transport.
