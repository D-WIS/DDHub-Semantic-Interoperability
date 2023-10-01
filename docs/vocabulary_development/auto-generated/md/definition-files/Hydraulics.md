# Hydraulics<!-- DEFINITION SET HEADER -->
- Description: this part refers to the hydraulic circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.
# Nouns
## HydraulicElementState <!-- NOUN -->
- Display name: HydraulicElementState
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicConnectedState <!-- NOUN -->
- Display name: HydraulicConnectedState
- Parent class: [HydraulicElementState](./Hydraulics.md#HydraulicElementState)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicLogicalElement <!-- NOUN -->
- Display name: HydraulicLogicalElement
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicBranch <!-- NOUN -->
- Display name: HydraulicBranch
- Parent class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## Annular <!-- NOUN -->
- Display name: Annular
- Parent class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## BHAAnnular <!-- NOUN -->
- Display name: BHAAnnular
- Parent class: [Annular](./Hydraulics.md#Annular)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DrillPipesAnnular <!-- NOUN -->
- Display name: DrillPipesAnnular
- Parent class: [Annular](./Hydraulics.md#Annular)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## OpenChannel <!-- NOUN -->
- Display name: OpenChannel
- Parent class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## RectangularChannel <!-- NOUN -->
- Display name: RectangularChannel
- Parent class: [OpenChannel](./Hydraulics.md#OpenChannel)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## SemiCircularChannel <!-- NOUN -->
- Display name: SemiCircularChannel
- Parent class: [OpenChannel](./Hydraulics.md#OpenChannel)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## Pipe <!-- NOUN -->
- Display name: Pipe
- Parent class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## BHAInner <!-- NOUN -->
- Display name: BHAInner
- Parent class: [Pipe](./Hydraulics.md#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DrillPipesInner <!-- NOUN -->
- Display name: DrillPipesInner
- Parent class: [Pipe](./Hydraulics.md#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## OpenHole <!-- NOUN -->
- Display name: OpenHole
- Parent class: [Pipe](./Hydraulics.md#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## ReturnFlowLine <!-- NOUN -->
- Display name: ReturnFlowLine
- Parent class: [Pipe](./Hydraulics.md#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicJunction <!-- NOUN -->
- Display name: HydraulicJunction
- Parent class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
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
- Definition set: Hydraulics
## MudMixing <!-- NOUN -->
- Display name: MudMixing
- Parent class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicNetwork <!-- NOUN -->
- Display name: HydraulicNetwork
- Parent class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DownholeHydraulicNetwork <!-- NOUN -->
- Display name: DownholeHydraulicNetwork
- Parent class: [HydraulicNetwork](./Hydraulics.md#HydraulicNetwork)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## TopsideHydraulicNetwork <!-- NOUN -->
- Display name: TopsideHydraulicNetwork
- Parent class: [HydraulicNetwork](./Hydraulics.md#HydraulicNetwork)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
# Verbs
## EndsHydraulicBranchDecomposition <!-- VERB -->
- Display name: EndsHydraulicBranchDecomposition
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsAHydraulicRepresentationFor <!-- VERB -->
- Display name: IsAHydraulicRepresentationFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Object class: [DrillingEquipment](./DrillingEquipment.md#DrillingEquipment)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasBranchComponent <!-- VERB -->
- Display name: HasBranchComponent
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicNetwork](./Hydraulics.md#HydraulicNetwork)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasBranchCoordinateSystem <!-- VERB -->
- Display name: HasBranchCoordinateSystem
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Object class: [ReferenceFrame](./PhysicalLocation.md#ReferenceFrame)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasHydraulicState <!-- VERB -->
- Display name: HasHydraulicState
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Object class: [HydraulicElementState](./Hydraulics.md#HydraulicElementState)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasHydraulicStateValueFrom <!-- VERB -->
- Display name: HasHydraulicStateValueFrom
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasLeftBranchCoordinates <!-- VERB -->
- Display name: HasLeftBranchCoordinates
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasRightBranchCoordinates <!-- VERB -->
- Display name: HasRightBranchCoordinates
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicallyLocatedAt <!-- VERB -->
- Display name: IsHydraulicallyLocatedAt
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsEquivalentCirculationDensityAt <!-- VERB -->
- Display name: IsEquivalentCirculationDensityAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsFluidDensityAt <!-- VERB -->
- Display name: IsFluidDensityAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsFluidTemperatureAt <!-- VERB -->
- Display name: IsFluidTemperatureAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsFluidVelocityAt <!-- VERB -->
- Display name: IsFluidVelocityAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsOpeningRatioAt <!-- VERB -->
- Display name: IsOpeningRatioAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicEstimationAt <!-- VERB -->
- Display name: IsHydraulicEstimationAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicMaximumAllowedRateOfChangeAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedRateOfChangeAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicMaximumAllowedValueAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedValueAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicMeasurementAt <!-- VERB -->
- Display name: IsHydraulicMeasurementAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsMassFlowRateAt <!-- VERB -->
- Display name: IsMassFlowRateAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsPressureAt <!-- VERB -->
- Display name: IsPressureAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsPressureGradientAt <!-- VERB -->
- Display name: IsPressureGradientAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsVolumetricFlowRateAt <!-- VERB -->
- Display name: IsVolumetricFlowRateAt
- Parent verb: [IsHydraulicallyLocatedAt](./Hydraulics.md#IsHydraulicallyLocatedAt)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicConnectedTo <!-- VERB -->
- Display name: IsHydraulicConnectedTo
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Object class: [HydraulicLogicalElement](./Hydraulics.md#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasEndJunction <!-- VERB -->
- Display name: HasEndJunction
- Parent verb: [IsHydraulicConnectedTo](./Hydraulics.md#IsHydraulicConnectedTo)
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Object class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasLeftBranch <!-- VERB -->
- Display name: HasLeftBranch
- Parent verb: [IsHydraulicConnectedTo](./Hydraulics.md#IsHydraulicConnectedTo)
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasRightBranch <!-- VERB -->
- Display name: HasRightBranch
- Parent verb: [IsHydraulicConnectedTo](./Hydraulics.md#IsHydraulicConnectedTo)
- Subject class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Object class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasStartJunction <!-- VERB -->
- Display name: HasStartJunction
- Parent verb: [IsHydraulicConnectedTo](./Hydraulics.md#IsHydraulicConnectedTo)
- Subject class: [HydraulicBranch](./Hydraulics.md#HydraulicBranch)
- Object class: [HydraulicJunction](./Hydraulics.md#HydraulicJunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## StartsHydraulicBranchDecomposition <!-- VERB -->
- Display name: StartsHydraulicBranchDecomposition
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
