# HydraulicElementState <!-- NOUN -->
- Display name: HydraulicElementState
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Description: 
- Examples:
# HydraulicConnectedState <!-- NOUN -->
- Display name: HydraulicConnectedState
- Parent class: [HydraulicElementState](#C:\temp\ddhubMD\Hydraulics.md#HydraulicElementState)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Description: 
- Examples:
# HydraulicLogicalElement <!-- NOUN -->
- Display name: HydraulicLogicalElement
- Parent class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Attributes:
- Description: 
- Examples:
# HydraulicBranch <!-- NOUN -->
- Display name: HydraulicBranch
- Parent class: [HydraulicLogicalElement](#C:\temp\ddhubMD\Hydraulics.md#HydraulicLogicalElement)
- Attributes:
- Description: 
- Examples:
# Annular <!-- NOUN -->
- Display name: Annular
- Parent class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Attributes:
- Description: 
- Examples:
# BHAAnnular <!-- NOUN -->
- Display name: BHAAnnular
- Parent class: [Annular](#C:\temp\ddhubMD\Hydraulics.md#Annular)
- Attributes:
- Description: 
- Examples:
# DrillPipesAnnular <!-- NOUN -->
- Display name: DrillPipesAnnular
- Parent class: [Annular](#C:\temp\ddhubMD\Hydraulics.md#Annular)
- Attributes:
- Description: 
- Examples:
# OpenChannel <!-- NOUN -->
- Display name: OpenChannel
- Parent class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Attributes:
- Description: 
- Examples:
# RectangularChannel <!-- NOUN -->
- Display name: RectangularChannel
- Parent class: [OpenChannel](#C:\temp\ddhubMD\Hydraulics.md#OpenChannel)
- Attributes:
- Description: 
- Examples:
# SemiCircularChannel <!-- NOUN -->
- Display name: SemiCircularChannel
- Parent class: [OpenChannel](#C:\temp\ddhubMD\Hydraulics.md#OpenChannel)
- Attributes:
- Description: 
- Examples:
# Pipe <!-- NOUN -->
- Display name: Pipe
- Parent class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Attributes:
- Description: 
- Examples:
# BHAInner <!-- NOUN -->
- Display name: BHAInner
- Parent class: [Pipe](#C:\temp\ddhubMD\Hydraulics.md#Pipe)
- Attributes:
- Description: 
- Examples:
# DrillPipesInner <!-- NOUN -->
- Display name: DrillPipesInner
- Parent class: [Pipe](#C:\temp\ddhubMD\Hydraulics.md#Pipe)
- Attributes:
- Description: 
- Examples:
# OpenHole <!-- NOUN -->
- Display name: OpenHole
- Parent class: [Pipe](#C:\temp\ddhubMD\Hydraulics.md#Pipe)
- Attributes:
- Description: 
- Examples:
# ReturnFlowLine <!-- NOUN -->
- Display name: ReturnFlowLine
- Parent class: [Pipe](#C:\temp\ddhubMD\Hydraulics.md#Pipe)
- Attributes:
- Description: 
- Examples:
# HydraulicJunction <!-- NOUN -->
- Display name: HydraulicJunction
- Parent class: [HydraulicLogicalElement](#C:\temp\ddhubMD\Hydraulics.md#HydraulicLogicalElement)
- Attributes:
  - LeftToRight
    - Type: bool
    - Description: Indicates whether the fluid can flow from the left branch to the right branch though the junction
  - RightToLeft
    - Type: bool
    - Description: Indicates whether the fluid can flow from the right branch to the left branch though the junction
- Description: 
- Examples:
# MudMixing <!-- NOUN -->
- Display name: MudMixing
- Parent class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Attributes:
- Description: 
- Examples:
# HydraulicNetwork <!-- NOUN -->
- Display name: HydraulicNetwork
- Parent class: [HydraulicLogicalElement](#C:\temp\ddhubMD\Hydraulics.md#HydraulicLogicalElement)
- Attributes:
- Description: 
- Examples:
# DownholeHydraulicNetwork <!-- NOUN -->
- Display name: DownholeHydraulicNetwork
- Parent class: [HydraulicNetwork](#C:\temp\ddhubMD\Hydraulics.md#HydraulicNetwork)
- Attributes:
- Description: 
- Examples:
# TopsideHydraulicNetwork <!-- NOUN -->
- Display name: TopsideHydraulicNetwork
- Parent class: [HydraulicNetwork](#C:\temp\ddhubMD\Hydraulics.md#HydraulicNetwork)
- Attributes:
- Description: 
- Examples:
# EndsHydraulicBranchDecomposition <!-- VERB -->
- Display name: EndsHydraulicBranchDecomposition
- Subject class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Object class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Description: 
- Examples: 
# HasBranchComponent <!-- VERB -->
- Display name: HasBranchComponent
- Subject class: [HydraulicNetwork](#C:\temp\ddhubMD\Hydraulics.md#HydraulicNetwork)
- Object class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Description: 
- Examples: 
# HasBranchCoordinateSystem <!-- VERB -->
- Display name: HasBranchCoordinateSystem
- Subject class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Object class: [ReferenceFrame](#C:\temp\ddhubMD\PhysicalLocation.md#ReferenceFrame)
- Description: 
- Examples: 
# HasHydraulicState <!-- VERB -->
- Display name: HasHydraulicState
- Subject class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Object class: [HydraulicElementState](#C:\temp\ddhubMD\Hydraulics.md#HydraulicElementState)
- Description: 
- Examples: 
# HasHydraulicStateValueFrom <!-- VERB -->
- Display name: HasHydraulicStateValueFrom
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# HasLeftBranchCoordinates <!-- VERB -->
- Display name: HasLeftBranchCoordinates
- Subject class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Object class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Description: 
- Examples: 
# HasRightBranchCoordinates <!-- VERB -->
- Display name: HasRightBranchCoordinates
- Subject class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Object class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Description: 
- Examples: 
# IsHydraulicallyLocatedAt <!-- VERB -->
- Display name: IsHydraulicallyLocatedAt
- Subject class: [DrillingData](#C:\temp\ddhubMD\DrillingDataSemantics.md#DrillingData)
- Object class: [HydraulicLogicalElement](#C:\temp\ddhubMD\Hydraulics.md#HydraulicLogicalElement)
- Description: 
- Examples: 
# IsEquivalentCirculationDensityAt <!-- VERB -->
- Display name: IsEquivalentCirculationDensityAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsFluidDensityAt <!-- VERB -->
- Display name: IsFluidDensityAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsFluidTemperatureAt <!-- VERB -->
- Display name: IsFluidTemperatureAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsFluidVelocityAt <!-- VERB -->
- Display name: IsFluidVelocityAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsHydraulicEstimationAt <!-- VERB -->
- Display name: IsHydraulicEstimationAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsHydraulicMaximumAllowedRateOfChangeAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedRateOfChangeAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsHydraulicMaximumAllowedValueAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedValueAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsHydraulicMeasurementAt <!-- VERB -->
- Display name: IsHydraulicMeasurementAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsMassFlowRateAt <!-- VERB -->
- Display name: IsMassFlowRateAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsPressureAt <!-- VERB -->
- Display name: IsPressureAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsPressureGradientAt <!-- VERB -->
- Display name: IsPressureGradientAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsVolumetricFlowRateAt <!-- VERB -->
- Display name: IsVolumetricFlowRateAt
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
# IsHydraulicConnectedTo <!-- VERB -->
- Display name: IsHydraulicConnectedTo
- Subject class: [HydraulicLogicalElement](#C:\temp\ddhubMD\Hydraulics.md#HydraulicLogicalElement)
- Object class: [HydraulicLogicalElement](#C:\temp\ddhubMD\Hydraulics.md#HydraulicLogicalElement)
- Description: 
- Examples: 
# HasEndJunction <!-- VERB -->
- Display name: HasEndJunction
- Subject class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Object class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Description: 
- Examples: 
# HasLeftBranch <!-- VERB -->
- Display name: HasLeftBranch
- Subject class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Object class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Description: 
- Examples: 
# HasRightBranch <!-- VERB -->
- Display name: HasRightBranch
- Subject class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Object class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Description: 
- Examples: 
# HasStartJunction <!-- VERB -->
- Display name: HasStartJunction
- Subject class: [HydraulicBranch](#C:\temp\ddhubMD\Hydraulics.md#HydraulicBranch)
- Object class: [HydraulicJunction](#C:\temp\ddhubMD\Hydraulics.md#HydraulicJunction)
- Description: 
- Examples: 
# StartsHydraulicBranchDecomposition <!-- VERB -->
- Display name: StartsHydraulicBranchDecomposition
- Subject class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Object class: [DDHubNode](#C:\temp\ddhubMD\DrillingDataSemantics.md#DDHubNode)
- Description: 
- Examples: 
