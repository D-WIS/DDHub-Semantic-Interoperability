- Description: this part refers to the hydraulic circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.

# NOUNS
## HydraulicElementState <!-- NOUN -->
- Display name: HydraulicElementState
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicConnectedState <!-- NOUN -->
- Display name: HydraulicConnectedState
- Parent class: HydraulicElementState
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
## HydraulicLogicalElement <!-- NOUN -->
- Display name: HydraulicLogicalElement
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicBranch <!-- NOUN -->
- Display name: HydraulicBranch
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: 
- Examples:
## Annular <!-- NOUN -->
- Display name: Annular
- Parent class: HydraulicBranch
- Attributes:
- Specialization:
- Description: 
- Examples:
## BHAAnnular <!-- NOUN -->
- Display name: BHAAnnular
- Parent class: Annular
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillPipesAnnular <!-- NOUN -->
- Display name: DrillPipesAnnular
- Parent class: Annular
- Attributes:
- Specialization:
- Description: 
- Examples:
## OpenChannel <!-- NOUN -->
- Display name: OpenChannel
- Parent class: HydraulicBranch
- Attributes:
- Specialization:
- Description: 
- Examples:
## RectangularChannel <!-- NOUN -->
- Display name: RectangularChannel
- Parent class: OpenChannel
- Attributes:
- Specialization:
- Description: 
- Examples:
## SemiCircularChannel <!-- NOUN -->
- Display name: SemiCircularChannel
- Parent class: OpenChannel
- Attributes:
- Specialization:
- Description: 
- Examples:
## Pipe <!-- NOUN -->
- Display name: Pipe
- Parent class: HydraulicBranch
- Attributes:
- Specialization:
- Description: 
- Examples:
## BHAInner <!-- NOUN -->
- Display name: BHAInner
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillPipesInner <!-- NOUN -->
- Display name: DrillPipesInner
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: 
- Examples:
## OpenHole <!-- NOUN -->
- Display name: OpenHole
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: 
- Examples:
## ReturnFlowLine <!-- NOUN -->
- Display name: ReturnFlowLine
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicJunction <!-- NOUN -->
- Display name: HydraulicJunction
- Parent class: HydraulicLogicalElement
- Attributes:
  - LeftToRight
    - Type: bool
    - Description: Indicates whether the fluid can flow from the left branch to the right branch though the junction
  - RightToLeft
    - Type: bool
    - Description: Indicates whether the fluid can flow from the right branch to the left branch though the junction
- Specialization:
  - LeftToRight = true
  - RightToLeft = true
- Description: 
- Examples:
## Tank <!-- NOUN -->
- Display name: Tank
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: 
- Examples:
## MudMixing <!-- NOUN -->
- Display name: MudMixing
- Parent class: HydraulicJunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicNetwork <!-- NOUN -->
- Display name: HydraulicNetwork
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeHydraulicNetwork <!-- NOUN -->
- Display name: DownholeHydraulicNetwork
- Parent class: HydraulicNetwork
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopsideHydraulicNetwork <!-- NOUN -->
- Display name: TopsideHydraulicNetwork
- Parent class: HydraulicNetwork
- Attributes:
- Specialization:
- Description: 
- Examples:
## FluidComponent <!-- NOUN -->
- Display name: FluidComponent
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## LiquidComponent <!-- NOUN -->
- Display name: LiquidComponent
- Parent class: FluidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## OilComponent <!-- NOUN -->
- Display name: OilComponent
- Parent class: LiquidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## WaterComponent <!-- NOUN -->
- Display name: WaterComponent
- Parent class: LiquidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## GasComponent <!-- NOUN -->
- Display name: GasComponent
- Parent class: FluidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## FormationGasComponent <!-- NOUN -->
- Display name: FormationGasComponent
- Parent class: GasComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillingFluidGasComponent <!-- NOUN -->
- Display name: DrillingFluidGasComponent
- Parent class: GasComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## SolidComponent <!-- NOUN -->
- Display name: SolidComponent
- Parent class: FluidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillingFluidSolidComponent <!-- NOUN -->
- Display name: DrillingFluidSolidComponent
- Parent class: SolidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## HighGravitySolidComponent <!-- NOUN -->
- Display name: HighGravitySolidComponent
- Parent class: DrillingFluidSolidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## LowGravitySolidComponent <!-- NOUN -->
- Display name: LowGravitySolidComponent
- Parent class: DrillingFluidSolidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## FormationSolidComponent <!-- NOUN -->
- Display name: FormationSolidComponent
- Parent class: SolidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## CuttingsComponent <!-- NOUN -->
- Display name: CuttingsComponent
- Parent class: FormationSolidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
## CavingsComponent <!-- NOUN -->
- Display name: CavingsComponent
- Parent class: FormationSolidComponent
- Attributes:
- Specialization:
- Description: 
- Examples:
  
# VERBS
## EndsHydraulicBranchDecomposition <!-- VERB -->
- Display name: EndsHydraulicBranchDecomposition
- Parent verb: DWISVerb
- Subject class: HydraulicBranch
- Object class: HydraulicBranch
- Description: 
- Examples: 
## IsAHydraulicRepresentationFor <!-- VERB -->
- Display name: IsAHydraulicRepresentationFor
- Parent verb: DWISVerb
- Subject class: HydraulicLogicalElement
- Object class: DrillingEquipment
- Description: 
- Examples: 
## HasBranchComponent <!-- VERB -->
- Display name: HasBranchComponent
- Parent verb: DWISVerb
- Subject class: HydraulicNetwork
- Object class: HydraulicBranch
- Description: 
- Examples: 
## HasBranchCoordinateSystem <!-- VERB -->
- Display name: HasBranchCoordinateSystem
- Parent verb: DWISVerb
- Subject class: HydraulicBranch
- Object class: ReferenceFrame
- Description: 
- Examples: 
## HasHydraulicState <!-- VERB -->
- Display name: HasHydraulicState
- Parent verb: DWISVerb
- Subject class: HydraulicJunction
- Object class: HydraulicElementState
- Description: 
- Examples: 
## HasHydraulicStateValueFrom <!-- VERB -->
- Display name: HasHydraulicStateValueFrom
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## HasLeftBranchCoordinates <!-- VERB -->
- Display name: HasLeftBranchCoordinates
- Parent verb: DWISVerb
- Subject class: HydraulicJunction
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## HasRightBranchCoordinates <!-- VERB -->
- Display name: HasRightBranchCoordinates
- Parent verb: DWISVerb
- Subject class: HydraulicJunction
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## IsHydraulicallyLocatedAt <!-- VERB -->
- Display name: IsHydraulicallyLocatedAt
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsEquivalentCirculationDensityAt <!-- VERB -->
- Display name: IsEquivalentCirculationDensityAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsFluidDensityAt <!-- VERB -->
- Display name: IsFluidDensityAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsFluidTemperatureAt <!-- VERB -->
- Display name: IsFluidTemperatureAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsFluidVelocityAt <!-- VERB -->
- Display name: IsFluidVelocityAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsOpeningRatioAt <!-- VERB -->
- Display name: IsOpeningRatioAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsVolumeAt <!-- VERB -->
- Display name: IsVolumeAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: Tank
- Description: 
- Examples: 
## IsHydraulicEstimationAt <!-- VERB -->
- Display name: IsHydraulicEstimationAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsHydraulicMaximumAllowedRateOfChangeAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedRateOfChangeAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsHydraulicMaximumAllowedValueAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedValueAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsHydraulicMeasurementAt <!-- VERB -->
- Display name: IsHydraulicMeasurementAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsMassFlowRateAt <!-- VERB -->
- Display name: IsMassFlowRateAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsPressureAt <!-- VERB -->
- Display name: IsPressureAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsPressureGradientAt <!-- VERB -->
- Display name: IsPressureGradientAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsVolumetricFlowRateAt <!-- VERB -->
- Display name: IsVolumetricFlowRateAt
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## IsHydraulicConnectedTo <!-- VERB -->
- Display name: IsHydraulicConnectedTo
- Parent verb: DWISVerb
- Subject class: HydraulicLogicalElement
- Object class: HydraulicLogicalElement
- Description: 
- Examples: 
## HasEndJunction <!-- VERB -->
- Display name: HasEndJunction
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicBranch
- Object class: HydraulicJunction
- Description: 
- Examples: 
## HasLeftBranch <!-- VERB -->
- Display name: HasLeftBranch
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicJunction
- Object class: HydraulicBranch
- Description: 
- Examples: 
## HasRightBranch <!-- VERB -->
- Display name: HasRightBranch
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicJunction
- Object class: HydraulicBranch
- Description: 
- Examples: 
## HasStartJunction <!-- VERB -->
- Display name: HasStartJunction
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicBranch
- Object class: HydraulicJunction
- Description: 
- Examples: 
## StartsHydraulicBranchDecomposition <!-- VERB -->
- Display name: StartsHydraulicBranchDecomposition
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples:
## ConcernsAFluidComponent <!-- VERB -->
- Display name: ConcernsAFluidComponent
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: FluidComponent
- Description: 
- Examples:
