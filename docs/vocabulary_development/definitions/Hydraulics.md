# NOUNS
## HydraulicElementState <!-- NOUN -->
- Display name: HydraulicElementState
- Parent class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicConnectedState <!-- NOUN -->
- Display name: HydraulicConnectedState
- Parent class: [HydraulicElementState](./Hydraulics.md#HydraulicElementState-)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
## HydraulicLogicalElement <!-- NOUN -->
- Display name: HydraulicLogicalElement
- Parent class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicBranch <!-- NOUN -->
- Display name: HydraulicBranch
- Parent class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## Annular <!-- NOUN -->
- Display name: Annular
- Parent class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## BHAAnnular <!-- NOUN -->
- Display name: BHAAnnular
- Parent class: [Annular](./Hydraulics.md#Annular-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillPipesAnnular <!-- NOUN -->
- Display name: DrillPipesAnnular
- Parent class: [Annular](./Hydraulics.md#Annular-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## OpenChannel <!-- NOUN -->
- Display name: OpenChannel
- Parent class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## RectangularChannel <!-- NOUN -->
- Display name: RectangularChannel
- Parent class: [OpenChannel](./Hydraulics.md#OpenChannel-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## SemiCircularChannel <!-- NOUN -->
- Display name: SemiCircularChannel
- Parent class: [OpenChannel](./Hydraulics.md#OpenChannel-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## Pipe <!-- NOUN -->
- Display name: Pipe
- Parent class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## BHAInner <!-- NOUN -->
- Display name: BHAInner
- Parent class: [Pipe](./Hydraulics.md#Pipe-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## DrillPipesInner <!-- NOUN -->
- Display name: DrillPipesInner
- Parent class: [Pipe](./Hydraulics.md#Pipe-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## OpenHole <!-- NOUN -->
- Display name: OpenHole
- Parent class: [Pipe](./Hydraulics.md#Pipe-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## ReturnFlowLine <!-- NOUN -->
- Display name: ReturnFlowLine
- Parent class: [Pipe](./Hydraulics.md#Pipe-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicJunction <!-- NOUN -->
- Display name: HydraulicJunction
- Parent class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement-)
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
## MudMixing <!-- NOUN -->
- Display name: MudMixing
- Parent class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## HydraulicNetwork <!-- NOUN -->
- Display name: HydraulicNetwork
- Parent class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholeHydraulicNetwork <!-- NOUN -->
- Display name: DownholeHydraulicNetwork
- Parent class: [HydraulicNetwork](./Hydraulics.md#HydraulicNetwork-)
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopsideHydraulicNetwork <!-- NOUN -->
- Display name: TopsideHydraulicNetwork
- Parent class: [HydraulicNetwork](./Hydraulics.md#HydraulicNetwork-)
- Attributes:
- Specialization:
- Description: 
- Examples:


# VERBS
## EndsHydraulicBranchDecomposition <!-- VERB -->
- Display name: EndsHydraulicBranchDecomposition
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Description: 
- Examples: 
## HasBranchComponent <!-- VERB -->
- Display name: HasBranchComponent
- Subject class: [HydraulicNetwork](./Hydraulics.md#HydraulicNetwork-)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Description: 
- Examples: 
## HasBranchCoordinateSystem <!-- VERB -->
- Display name: HasBranchCoordinateSystem
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Object class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame-)
- Description: 
- Examples: 
## HasHydraulicState <!-- VERB -->
- Display name: HasHydraulicState
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Object class: [HydraulicElementState](./Hydraulics.md#HydraulicElementState-)
- Description: 
- Examples: 
## HasHydraulicStateValueFrom <!-- VERB -->
- Display name: HasHydraulicStateValueFrom
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## HasLeftBranchCoordinates <!-- VERB -->
- Display name: HasLeftBranchCoordinates
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Description: 
- Examples: 
## HasRightBranchCoordinates <!-- VERB -->
- Display name: HasRightBranchCoordinates
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Object class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Description: 
- Examples: 
## IsHydraulicallyLocatedAt <!-- VERB -->
- Display name: IsHydraulicallyLocatedAt
- Subject class: [DrillingData](./DrillingDataSemantics.md#DrillingData-)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement-)
- Description: 
- Examples: 
## IsEquivalentCirculationDensityAt <!-- VERB -->
- Display name: IsEquivalentCirculationDensityAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsFluidDensityAt <!-- VERB -->
- Display name: IsFluidDensityAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsFluidTemperatureAt <!-- VERB -->
- Display name: IsFluidTemperatureAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsFluidVelocityAt <!-- VERB -->
- Display name: IsFluidVelocityAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsHydraulicEstimationAt <!-- VERB -->
- Display name: IsHydraulicEstimationAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsHydraulicMaximumAllowedRateOfChangeAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedRateOfChangeAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsHydraulicMaximumAllowedValueAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedValueAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsHydraulicMeasurementAt <!-- VERB -->
- Display name: IsHydraulicMeasurementAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsMassFlowRateAt <!-- VERB -->
- Display name: IsMassFlowRateAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsPressureAt <!-- VERB -->
- Display name: IsPressureAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsPressureGradientAt <!-- VERB -->
- Display name: IsPressureGradientAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsVolumetricFlowRateAt <!-- VERB -->
- Display name: IsVolumetricFlowRateAt
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
## IsHydraulicConnectedTo <!-- VERB -->
- Display name: IsHydraulicConnectedTo
- Subject class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement-)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement-)
- Description: 
- Examples: 
## HasEndJunction <!-- VERB -->
- Display name: HasEndJunction
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Object class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Description: 
- Examples: 
## HasLeftBranch <!-- VERB -->
- Display name: HasLeftBranch
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Description: 
- Examples: 
## HasRightBranch <!-- VERB -->
- Display name: HasRightBranch
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Description: 
- Examples: 
## HasStartJunction <!-- VERB -->
- Display name: HasStartJunction
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch-)
- Object class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction-)
- Description: 
- Examples: 
## StartsHydraulicBranchDecomposition <!-- VERB -->
- Display name: StartsHydraulicBranchDecomposition
- Subject class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Object class: [DDHubNode](./DrillingDataSemantics.md#DDHubNode-)
- Description: 
- Examples: 
