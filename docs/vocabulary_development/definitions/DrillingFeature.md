- Description: this definition set refers various drilling features that something may support. 

# NOUNS
## Feature <!-- NOUN -->
- Display name: Feature
- Parent class: DWISNoun
- Attributes:
- Description: A feature is a characteristic of something.
- Examples:
## DataTransmissionFeature <!-- NOUN -->
- Display name: Data Transmission Feature
- Parent class: Feature
- Attributes:
- Description: A data transmission feature is a characteristic about how data is transferred from one place to another.
- Examples:
## LookupTableFeature <!-- NOUN -->
- Display name: Lookup Table Feature
- Parent class: DataTransmissionFeature
- Attributes:
- Description: Such a feature indicates that something accounts for lookup table.
- Examples:
## ModellingFeature <!-- NOUN -->
- Display name: Modelling Feature
- Parent class: Feature
- Attributes:
- Description: A modelling feature is a characteristic about how system is modelled.
- Examples:
## SteadyStateFeature <!-- NOUN -->
- Display name: Steady State Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A steady state feature is a characteristic about a model that only accounts for steady state conditions.
- Examples:
## TransientFeature <!-- NOUN -->
- Display name: Transient Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A transient feature is a characteristic about a model that accounts for transient effects.
- Examples:
## GelledStateFeature <!-- NOUN -->
- Display name: Gelled State Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A gelled state feature is a characteristic about a model that accounts for the gelled state of a fluid.
- Examples:
## StaticFrictionFeature <!-- NOUN -->
- Display name: Static Friction Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A static friction feature is a characteristic about a model that accounts for the static friction along the string.
- Examples:
## HydraulicallyInducedForceFeature <!-- NOUN -->
- Display name: Hydraulically Induced Force Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A hydraulically induced force feature is a characteristic about a model that accounts for hydraulically induced force on the string.
- Examples:
## ShockedModellingFeature <!-- NOUN -->
- Display name: Shock Modelling Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A shock modelling feature is a characteristic about a model that accounts for shocks along the string.
- Examples:
## FluidCompressibilityFeature <!-- NOUN -->
- Display name: Fluid Compressibility Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A fluid compressibility feature is a characteristic about a model that accounts for fluid compressibility.
- Examples:
## StringElasticityFeature <!-- NOUN -->
- Display name: String Elasticity Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A string elasticity feature is a characteristic about a model that accounts for string elasticity.
- Examples:
## FluidThermalExpansionFeature <!-- NOUN -->
- Display name: Fluid Thermal Expansion Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A fluid thermal expansion feature is a characteristic about a model that accounts for the fluid thermal expansion.
- Examples:
## StringThermalExpansionFeature <!-- NOUN -->
- Display name: String Thermal Expansion Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A string thermal expansion feature is a characteristic about a model that accounts for the string thermal expansion.
- Examples:
## StringPressureBallooningFeature <!-- NOUN -->
- Display name: String Pressure Ballooning Feature
- Parent class: ModellingFeature
- Attributes:
- Description: A string pressure ballooning feature is a characteristic about a model that accounts for the string pressure ballooning.
- Examples:
## AirGapInStringFeature <!-- NOUN -->
- Display name: Air Gap In String Feature
- Parent class: ModellingFeature
- Attributes:
- Description: An air gap in string feature is a characteristic about a model that accounts for the possible air gap at the top of the liquid column in the string.
- Examples:
## DrillingManagementFeature <!-- NOUN -->
- Display name: Drilling Management Feature
- Parent class: Feature
- Attributes:
- Description: A drilling management feature is a drilling management characteristic that is supported by something. For instance
an advisory system may provide ROP management parameters accounting for cuttings transport.
- Examples:
## FillPipeFeature <!-- NOUN -->
- Display name: Fill Pipe Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A fill pipe feature indicates that something accounts for filling the pipe when there is an air gap.
- Examples:
## GelBreakingFeature <!-- NOUN -->
- Display name: Gel Breaking Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A gel breaking feature indicates that something accounts for breaking the gel in a drilling fluid that has stayed
quiet for some time.
- Examples:
## CirculationFeature <!-- NOUN -->
- Display name: Circulation Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A circulation feature indicates that something accounts for circulation.
- Examples:
## DrillingFluidDisplacementFeature <!-- NOUN -->
- Display name: Drilling Fluid Displacement Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A drilling fluid displacement feature indicates that something accounts for displacing a drilling fluid with another.
- Examples:
## DrillingFluidSweepFeature <!-- NOUN -->
- Display name: Drilling Fluid Sweep Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A drilling fluid sweep feature indicates that something accounts for sweeping the borehole with one or several fluids of 
different densities and/or viscosities.
- Examples:
## CementingFeature <!-- NOUN -->
- Display name: Cementing Feature
- Parent class: DrillingFluidDisplacementFeature
- Attributes:
- Description: A cementing feature indicates that something accounts for displacing a train of drilling fluids and cement slurries to perform
a cement operation.
- Examples:
## FormationWashoutFeature <!-- NOUN -->
- Display name: Formation Washout Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A formation washout feature indicates that something accounts for formation washout while circulating.
- Examples:
## CuttingsTransportFeature <!-- NOUN -->
- Display name: Cuttings Transport Feature
- Parent class: CirculationFeature
- Attributes:
- Description: A cuttings transport feature indicates that something accounts for cuttings transport while circulating.
- Examples:
## PackOffFeature <!-- NOUN -->
- Display name: Pack-off Feature
- Parent class: CuttingsTransportFeature
- Attributes:
- Description: A pack-off feature indicates that something accounts for the possibility to pack-off while circulating cuttings.
- Examples:
## DrillStemMovementFeature <!-- NOUN -->
- Display name: Drill-stem Movement Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A drill-stem movement feature indicates that something accounts for the drill-stem movement.
- Examples:
## DrillStemAxialMovementFeature <!-- NOUN -->
- Display name: Drill-stem Axial Movement Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A drill-stem axial movement feature indicates that something accounts for drill-stem axial movement.
- Examples:
## DrillStemRotationalMovementFeature <!-- NOUN -->
- Display name: Drill-stem Rotational Movement Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A drill-stem rotational movement feature indicates that something accounts for drill-stem rotational movement.
- Examples:
## StuckPipeFeature <!-- NOUN -->
- Display name: Stuck-pipe Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A stuck-pipe feature indicates that something accounts for stuck-pipes.
- Examples:
## DrillStemAxialImpedimentFeature <!-- NOUN -->
- Display name: Drill-stem Axial Impediment Feature
- Parent class: StuckPipeFeature
- Attributes:
- Description: A drill-stem axial impediment feature indicates that something accounts for drill-stem axial impediment.
- Examples:
## DrillStemRotationalImpedimentFeature <!-- NOUN -->
- Display name: Drill-stem Rotational Impediment Feature
- Parent class: StuckPipeFeature
- Attributes:
- Description: A drill-stem rotational impediment feature indicates that something accounts for drill-stem rotational impediment.
- Examples:
## DrillStemVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Vibration Feature
- Parent class: DrillStemMovementFeature
- Attributes:
- Description: A drill-stem vibration feature indicates that something accounts for drill-stem vibrations.
- Examples:
## DrillStemAxialVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Axial Vibration Feature
- Parent class: DrillStemVibrationFeature
- Attributes:
- Description: A drill-stem axial vibration feature indicates that something accounts for in particular axial drill-stem vibrations.
- Examples:
## DrillStemAxialStickSlipFeature <!-- NOUN -->
- Display name: Drill-stem Axial Stick-Slip Feature
- Parent class: DrillStemAxialVibrationFeature
- Attributes:
- Description: A drill-stem axial stick-slip feature indicates that something acconts for in particular axial stick-slip drill-stem vibrations.
- Examples:
## DrillStemTorsionalVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Torsional Vibration Feature
- Parent class: DrillStemVibrationFeature
- Attributes:
- Description: A drill-stem torsional vibration feature indicates that something acconts for in particular torsional drill-stem vibrations.
- Examples:
## DrillStemTorsionalStickSlipFeature <!-- NOUN -->
- Display name: Drill-stem Torsional Stick-Slip Feature
- Parent class: DrillStemTorsionalVibrationFeature
- Attributes:
- Description: A drill-stem torsional stick-slip feature indicates that something acconts for in particular torsional stick-slip drill-stem vibrations.
- Examples:
## DrillStemLateralVibrationFeature <!-- NOUN -->
- Display name: Drill-stem Lateral Vibration Feature
- Parent class: DrillStemVibrationFeature
- Attributes:
- Description: A drill-stem lateral vibration feature indicates that something accounts for in particular lateral drill-stem vibrations.
- Examples:
## DrillStemWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Whirling Feature
- Parent class: DrillStemLateralVibrationFeature
- Attributes:
- Description: A drill-stem whirling feature indicates that something accounts for in particular drill-stem whirling.
- Examples:
## DrillStemForwardWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Forward Whirling Feature
- Parent class: DrillStemWhirlingFeature
- Attributes:
- Description: A drill-stem forward whirling feature indicates that something accounts for in particular drill-stem forward whirling.
- Examples:
## DrillStemBackwardWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Backward Whirling Feature
- Parent class: DrillStemWhirlingFeature
- Attributes:
- Description: A drill-stem backward whirling feature indicates that something accounts for in particular drill-stem backward whirling.
- Examples:
## DrillStemChaoticWhirlingFeature <!-- NOUN -->
- Display name: Drill-stem Chaotic Whirling Feature
- Parent class: DrillStemWhirlingFeature
- Attributes:
- Description: A drill-stem chaotic whirling feature indicates that something accounts for in particular drill-stem chaotic whirling.
- Examples:
## DownholePressureFeature <!-- NOUN -->
- Display name: Downhole Pressure Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A downhole pressure feature indicates that something accounts for downhole pressure.
- Examples:
## SwabSurgeFeature <!-- NOUN -->
- Display name: Swab and Surge Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A swab and surge feature indicates that something accounts for swab and surge pressure variations.
- Examples:
## ManagedDownholePressureFeature <!-- NOUN -->
- Display name: Managed Downhole Pressure Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A managed downhole pressure feature indicates that something manages downhole pressure.
- Examples:
## UnderBalanceFeature <!-- NOUN -->
- Display name: Under-balance Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: An under-balance feature indicates that something accounts for under-balance conditions.
- Examples:
## GasAbsorptionFeature <!-- NOUN -->
- Display name: Gas Absorption Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A gas absorption feature indicates that something accounts for conditions by which gas can be absorbed by the drilling fluid.
- Examples:
## FormationFracturingFeature <!-- NOUN -->
- Display name: Formation Fracturing Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A formation fracturing feature indicates that something accounts for formation fracturing pressure limits.
- Examples:
## FormationFluidInfluxFeature <!-- NOUN -->
- Display name: Formation Fluid Influx Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A formation fluid influx feature indicates that something accounts for formation pore pressure limits.
- Examples:
## FormationCollapseFeature <!-- NOUN -->
- Display name: Formation Collapse Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A formation collapse feature indicates that something accounts for formation collapse pressure limits.
- Examples:
## HeaveFeature <!-- NOUN -->
- Display name: Heave Feature
- Parent class: DownholePressureFeature
- Attributes:
- Description: A heave feature indicates that something accounts for the heave movement on downhole pressure effects.
- Examples:
## OnBottomDrillingFeature <!-- NOUN -->
- Display name: On Bottom Drilling Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: An on bottom drilling feature indicates that something accounts for on bottom drilling.
- Examples:
## HoleOpeningFeature <!-- NOUN -->
- Display name: Hole Opening Feature
- Parent class: OnBottomDrillingFeature
- Attributes:
- Description: An hole opening feature indicates that something accounts for opening the borehole diameter.
- Examples:
## UnderReamingFeature <!-- NOUN -->
- Display name: Under-reaming Feature
- Parent class: HoleOpeningFeature
- Attributes:
- Description: An under-reaming feature indicates that something accounts for under-reaming a borehole.
- Examples:
## DrillStemBucklingFeature <!-- NOUN -->
- Display name: Drill-stem Buckling Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A drill-stem buckling feature indicates that something accounts for drill-stem buckling.
- Examples:
## HeatTransferFeature <!-- NOUN -->
- Display name: Heat Transfer Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A heat transfer feature indicates that something accounts for heat transfer.
- Examples:
## RigActionPlanFeature <!-- NOUN -->
- Display name: Rig Action Plan Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A rig action plan feature indicates that something accounts for the rig action plan.
- Examples:
## DrillingProgramFeature <!-- NOUN -->
- Display name: Drilling Program Feature
- Parent class: DrillingManagementFeature
- Attributes:
- Description: A drilling program feature indicates that something accounts for the drilling program.
- Examples:

# VERBS
## AccountsFor <!-- VERB -->
- Display name: Accounts For  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DrillingManagementFeature
- Description: This verb is used to indicate something accounts for a drilling management feature.
- Examples:
