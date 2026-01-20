- Description: Describes abstract hydraulic concepts used to model drilling circulation systems and fluids.

# NOUNS
## PressureReference <!-- NOUN -->
- Display name: PressureReference
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Indicates the reference basis used to express a pressure measurement.
- Examples:
```dwis pressureRef
PressureReference:pressureReference
DrillingDataPoint:standpipePressure
standpipePressure HasPressureReferenceType pressureReference
```
This example shows a standpipe pressure tagged with a pressure reference.
## AbsolutePressureReference <!-- NOUN -->
- Display name: AbsolutePressureReference
- Parent class: PressureReference
- Attributes:
- Specialization:
- Description: Pressure expressed relative to absolute vacuum.
- Examples:
```dwis absoluteRef
AbsolutePressureReference:absolutePressure
DrillingDataPoint:annulusPressure
annulusPressure HasPressureReferenceType absolutePressure
```
This example sets annulus pressure to absolute reference.
## RelativePressureReference <!-- NOUN -->
- Display name: RelativePressureReference
- Parent class: PressureReference
- Attributes:
- Specialization:
- Description: Pressure expressed relative to another reference pressure.
- Examples:
```dwis relativeRef
RelativePressureReference:relativePressure
DrillingDataPoint:chokePressure
chokePressure HasPressureReferenceType relativePressure
```
This example marks choke pressure as relative.
## GaugePressureReference <!-- NOUN -->
- Display name: GaugePressureReference
- Parent class: RelativePressureReference
- Attributes:
- Specialization:
- Description: Pressure expressed relative to atmospheric pressure.
- Examples:
```dwis gaugeRef
GaugePressureReference:gaugePressure
DrillingDataPoint:standpipePressure
standpipePressure HasPressureReferenceType gaugePressure
```
This example sets standpipe pressure to gauge reference.
## HydraulicElementState <!-- NOUN -->
- Display name: HydraulicElementState
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Represents the state of a hydraulic element such as open/closed or connected/disconnected.
- Examples:
```dwis elementState
HydraulicElementState:elementState
HydraulicJunction:standpipeJunction
standpipeJunction HasHydraulicState elementState
```
This example attaches a state to a junction.
## HydraulicConnectedState <!-- NOUN -->
- Display name: HydraulicConnectedState
- Parent class: HydraulicElementState
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: Boolean state indicating if two hydraulic branches are connected.
- Examples:
```dwis connectedState
HydraulicConnectedState:connectedState
connectedState.Value = "true"
HydraulicJunction:standpipeJunction
standpipeJunction HasHydraulicState connectedState
```
This example records a connected state for a junction.
## HydraulicLogicalElement <!-- NOUN -->
- Display name: HydraulicLogicalElement
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Abstract element in a hydraulic network (branch, junction, tank, etc.).
- Examples:
```dwis logicalElement

HydraulicLogicalElement:logicalElement1
HydraulicLogicalElement:logicalElement2
logicalElement1 IsHydraulicConnectedTo logicalElement2
```
This example shows hydraulic logical element 1 is hydraulically connected to hydraulic logical element 2.
## HydraulicBranch <!-- NOUN -->
- Display name: HydraulicBranch
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: A flow path segment in the hydraulic circuit.
- Examples:
```dwis branch
HydraulicBranch:standpipeBranch
HydraulicNetwork:topsideNetwork
topsideNetwork HasBranchComponent standpipeBranch
```
This example defines a standpipe branch in the topside network.
```dwis flowRateOutProportionExample
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
This example describes flow rate proportion in the outlet hydraulic branch.
## Annular <!-- NOUN -->
- Display name: Annular
- Parent class: HydraulicBranch
- Attributes:
- Specialization:
- Description: A branch representing the annular space between two cylindrical elements.
- Examples:
```dwis annularBranch
Annular:annulus
HydraulicNetwork:downholeNetwork
downholeNetwork HasBranchComponent annulus
```
This example adds an annular branch to a downhole network.
## BHAAnnular <!-- NOUN -->
- Display name: BHAAnnular
- Parent class: Annular
- Attributes:
- Specialization:
- Description: Annular space around the bottom-hole assembly.
- Examples:
```dwis bhaAnnular
BHAAnnular:bhaAnnulus
HydraulicNetwork:downholeNetwork
downholeNetwork HasBranchComponent bhaAnnulus
```
This example represents the BHA annulus in the downhole network.
```dwis downholeGammaRayExample
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
This example describes downhole gamma ray located at the BHA annulus.
## DrillPipesAnnular <!-- NOUN -->
- Display name: DrillPipesAnnular
- Parent class: Annular
- Attributes:
- Specialization:
- Description: Annular space around the drill pipe string.
- Examples:
```dwis dpAnnular
DrillPipesAnnular:dpAnnulus
HydraulicNetwork:downholeNetwork
downholeNetwork HasBranchComponent dpAnnulus
```
This example represents the drill pipe annulus.
## OpenChannel <!-- NOUN -->
- Display name: OpenChannel
- Parent class: HydraulicBranch
- Attributes:
- Specialization:
- Description: A branch representing an open-channel flow path.
- Examples:
```dwis openChannel
OpenChannel:openChannel
HydraulicNetwork:surfaceNetwork
surfaceNetwork HasBranchComponent openChannel
```
This example adds an open channel to a surface network.
## RectangularChannel <!-- NOUN -->
- Display name: RectangularChannel
- Parent class: OpenChannel
- Attributes:
- Specialization:
- Description: An open channel with a rectangular cross-section.
- Examples:
```dwis rectangularChannel
RectangularChannel:rectChannel
HydraulicNetwork:surfaceNetwork
surfaceNetwork HasBranchComponent rectChannel
```
This example defines a rectangular channel branch.
## SemiCircularChannel <!-- NOUN -->
- Display name: SemiCircularChannel
- Parent class: OpenChannel
- Attributes:
- Specialization:
- Description: An open channel with a semi-circular cross-section.
- Examples:
```dwis semiCircularChannel
SemiCircularChannel:semiChannel
HydraulicNetwork:surfaceNetwork
surfaceNetwork HasBranchComponent semiChannel
```
This example defines a semi-circular channel branch.
## Pipe <!-- NOUN -->
- Display name: Pipe
- Parent class: HydraulicBranch
- Attributes:
- Specialization:
- Description: A closed conduit branch used to transport fluid.
- Examples:
```dwis pipeBranch
Pipe:standpipe
HydraulicNetwork:surfaceNetwork
surfaceNetwork HasBranchComponent standpipe
```
This example adds a standpipe branch.
## BHAInner <!-- NOUN -->
- Display name: BHAInner
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: Inner flow path through the bottom-hole assembly.
- Examples:
```dwis bhaInner
BHAInner:bhaInner
HydraulicNetwork:downholeNetwork
downholeNetwork HasBranchComponent bhaInner
```
This example represents the inner BHA flow path.
## DrillPipesInner <!-- NOUN -->
- Display name: DrillPipesInner
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: Inner flow path through the drill pipes.
- Examples:
```dwis dpInner
DrillPipesInner:dpInner
HydraulicNetwork:downholeNetwork
downholeNetwork HasBranchComponent dpInner
```
This example represents the drill pipe inner flow path.
## OpenHole <!-- NOUN -->
- Display name: OpenHole
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: Flow path within the uncased borehole section.
- Examples:
```dwis openHoleBranch
OpenHole:openHole
HydraulicNetwork:downholeNetwork
downholeNetwork HasBranchComponent openHole
```
This example models the open hole as a hydraulic branch.
## ReturnFlowLine <!-- NOUN -->
- Display name: ReturnFlowLine
- Parent class: Pipe
- Attributes:
- Specialization:
- Description: Surface return line carrying mud back to tanks.
- Examples:
```dwis returnLine
ReturnFlowLine:returnLine
HydraulicNetwork:surfaceNetwork
surfaceNetwork HasBranchComponent returnLine
```
This example adds a return flow line to the surface network.
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
- Description: Connection point where branches meet and flow can pass based on allowed directions.
- Examples:
```dwis junction
HydraulicJunction:flowJunction
HydraulicBranch:standpipe
HydraulicBranch:returnLine
flowJunction HasUpstreamBranch standpipe
flowJunction HasDownstreamBranch returnLine
```
This example defines a junction connecting standpipe and return line.
## SwivelLogical <!-- NOUN -->
- Display name: Swivel Logical
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: A logical representation of a swivel like the one used for a top-drive or with a kelly.
- Examples:
```dwis SwivelLogicalExample
SwivelLogical:swivelLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent swivelLogical
```
This example represents a swivel logical element in the surface network.
## FlowLineLogical <!-- NOUN -->
- Display name: Flow Line Logical
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: A logical representation of a flow line.
- Examples:
```dwis FlowLineLogicalExample
FlowLineLogical:flowLineLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent flowLineLogical
```
This example represents a flow-line logical element in the surface network.
## SolidSeparatorLogical <!-- NOUN -->
- Display name: Solid Separator
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: A logical element to separate solid components from the drilling fluid within the hydraulic system.
- Examples:
```dwis SolidSeparatorLogicalExample
SolidSeparatorLogical:SolidSeparatorLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent SolidSeparatorLogical
```
This example represents a solid separator logical element in the surface network.
## CuttingSeparatorLogical <!-- NOUN -->
- Display name: Cutting Separator
- Parent class: SolidSeparatorLogical
- Attributes:
- Specialization:
- Description: A logical element to separate cuttings from the drilling fluid within the hydraulic system.
- Examples:
```dwis CuttingSeparatorLogicalExample
CuttingSeparatorLogical:CuttingSeparatorLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent CuttingSeparatorLogical
```
This example represents a cuttings separator, i.e., a shale shaker, logical element in the surface network.
## SandSeparatorLogical <!-- NOUN -->
- Display name: Sand Separator
- Parent class: SolidSeparatorLogical
- Attributes:
- Specialization:
- Description: A logical element to separate sand particles from the drilling fluid within the hydraulic system.
- Examples:
```dwis SandSeparatorLogicalExample
SandSeparatorLogical:SandSeparatorLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent SandSeparatorLogical
```
This example represents a sand separator, i.e., a desander, logical element in the surface network.
## SiltSeparatorLogical <!-- NOUN -->
- Display name: Silt Separator
- Parent class: SolidSeparatorLogical
- Attributes:
- Specialization:
- Description: A logical element to separate silt particles from the drilling fluid within the hydraulic system.
- Examples:
```dwis SiltSeparatorLogicalExample
SiltSeparatorLogical:SiltSeparatorLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent SiltSeparatorLogical
```
This example represents a sand separator, i.e., a desander, logical element in the surface network.
## TankLogical <!-- NOUN -->
- Display name: TankLogical
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: A storage element for drilling fluid within the hydraulic system.
- Examples:
```dwis mudTankLogicalExample
TankLogical:mudTankLogical
TopsideHydraulicNetwork:surfaceNetwork
surfaceNetwork HasLogicalElementComponent mudTankLogical
```
This example represents a mud tank in the surface network.
## ActivePitLogical <!-- NOUN -->
- Display name: Active Pit
- Parent class: TankLogical
- Attributes:
- Specialization:
- Description: The active pit that is used during the drilling operation.
- Examples:
```dwis ActivePitLogicalExample
ActivePitLogical:ActivePitLogical
TopsideHydraulicNetwork:topsideHydraulicNetwork
topsideHydraulicNetwork HasLogicalElementComponent ActivePitLogical
```
This example indicates that the top side hydraulic network has an active pit.
## ReservePitLogical <!-- NOUN -->
- Display name: Reserve Pit
- Parent class: TankLogical
- Attributes:
- Specialization:
- Description: The reserve pit that is used during the drilling operation.
- Examples:
```dwis ReservePitLogicalExample
ReservePitLogical:ReservePitLogical
TopsideHydraulicNetwork:topsideHydraulicNetwork
topsideHydraulicNetwork HasLogicalElementComponent ReservePitLogical
```
This example indicates that the top side hydraulic network has an reserve pit.
## SlugPitLogical <!-- NOUN -->
- Display name: Slug Pit
- Parent class: TankLogical
- Attributes:
- Specialization:
- Description: The slug pit that is used during the drilling operation.
- Examples:
```dwis SlugPitLogicalExample
SlugPitLogical:SlugPitLogical
TopsideHydraulicNetwork:topsideHydraulicNetwork
topsideHydraulicNetwork HasLogicalElementComponent SlugPitLogical
```
This example indicates that the top side hydraulic network has an slug pit.
## TripTankLogical <!-- NOUN -->
- Display name: Trip-tank
- Parent class: TankLogical
- Attributes:
- Specialization:
- Description: The trip TankLogical that is used during the drilling operation.
- Examples:
```dwis TripTankLogicalExample
TripTankLogical:TripTankLogical
TopsideHydraulicNetwork:topsideHydraulicNetwork
topsideHydraulicNetwork HasLogicalElementComponent TripTankLogical
```
This example indicates that the top side hydraulic network has an trip tank.
## MudMixing <!-- NOUN -->
- Display name: MudMixing
- Parent class: HydraulicJunction
- Attributes:
- Specialization:
- Description: Junction where fluids are blended to create or condition drilling mud.
- Examples:
```dwis mixingJunction
MudMixing:mudMixingJunction
HydraulicBranch:returnLine
HydraulicBranch:mudTankInlet
mudMixingJunction HasLeftBranch returnLine
mudMixingJunction HasRightBranch mudTankInlet
```
This example shows a mud mixing junction between return line and tank inlet.
## TopOfStringJunction <!-- NOUN -->
- Display name: Top Of String Junction
- Parent class: HydraulicJunction
- Attributes:
- Specialization:
- Description: the hydraulic junction at the top of the drill string where flow can enter the string.
- Examples:
```dwis TopOfStringJunctionExample
TopOfStringJunction:topOfStringJunction
HydraulicBranch:inletBranch
topOfStringJunction HasUpstreamBranch inletBranch
```
This example shows top of string junction with an inlet branch.
```dwis densityInExample
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
This example describes the density of the fluid entering the drill string.
## AnnulusOutletJunction <!-- NOUN -->
- Display name: Annulus Outlet Junction
- Parent class: HydraulicJunction
- Attributes:
- Specialization:
- Description: the hydraulic junction at the end of the annulus where flow can exit the annulus.
- Examples:
```dwis AnnulusOutletJunctionExample
AnnulusOutletJunction:annulusOutletJunction
HydraulicBranch:outletBranch
annulusOutletJunction HasDownstreamBranch outletBranch
```
This example shows annulus outlet junction with an outlet branch.
```dwis densityOutExample
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
This example describes the density of the fluid exiting the annulus.
## HydraulicNetwork <!-- NOUN -->
- Display name: HydraulicNetwork
- Parent class: HydraulicLogicalElement
- Attributes:
- Specialization:
- Description: A collection of hydraulic elements representing a portion of the circulation system.
- Examples:
```dwis HydraulicNetworkExample
HydraulicNetwork:overallNetwork
TopsideHydraulicNetwork:topsideNetwork
DownholeHydraulicNetwork:downholeNetwork
topsideNetwork IsASubHydraulicNetwork overallNetwork
downholeNetwork IsASubHydraulicNetwork overallNetwork
```
This example defines a surface hydraulic network.
## DownholeHydraulicNetwork <!-- NOUN -->
- Display name: DownholeHydraulicNetwork
- Parent class: HydraulicNetwork
- Attributes:
- Specialization:
- Description: Hydraulic network representing downhole flow paths.
- Examples:
```dwis DownholeHydraulicNetworkExample
DownholeHydraulicNetwork:downholeNetwork
Annular:annularBranch
downholeNetwork HasBranchComponent annularBranch
```
This example identifies the downhole portion of the network.
## TopsideHydraulicNetwork <!-- NOUN -->
- Display name: TopsideHydraulicNetwork
- Parent class: HydraulicNetwork
- Attributes:
- Specialization:
- Description: Hydraulic network representing surface flow paths.
- Examples:
```dwis TopsideHydraulicNetworkExample
TopsideHydraulicNetwork:topsideNetwork
ReturnFlowLine:returnLine
topsideNetwork HasBranchComponent returnLine
```
This example identifies the topside network.
## MPDMainFlowPath <!-- NOUN -->
- Display name: MPDMainFlowPath
- Parent class: TopsideHydraulicNetwork
- Attributes:
- Specialization:
- Description: Managed pressure drilling main flow path at surface.
- Examples:
```dwis MPDMainFlowPathExample
TopsideHydraulicNetwork:surfaceNetwork
MPDMainFlowPath:mainFlowPath
mainFlowPath IsASubHydraulicNetwork surfaceNetwork
```
This example defines the MPD main flow path.
## MPDAlternateFlowPath <!-- NOUN -->
- Display name: MPDAlternateFlowPath
- Parent class: TopsideHydraulicNetwork
- Attributes:
- Specialization:
- Description: Alternate managed pressure drilling flow path (e.g., bypass or choke line).
- Examples:
```dwis MPDAlternateFlowPathExample
TopsideHydraulicNetwork:surfaceNetwork
MPDAlternateFlowPath:alternateFlowPath
alternateFlowPath IsASubHydraulicNetwork surfaceNetwork
```
This example defines that an alternate MPD flow path is a sub-hydraulic network of the surface network.
## HydraulicCondition <!-- NOUN -->
- Display name: Hydraulic Condition
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A general category to describe high-level states of the hydraulic system.
- Examples:
## HydraulicCirculationCondition <!-- NOUN -->
- Display name: Hydraulic Circulation Condition
- Parent class: HydraulicCondition
- Attributes:
- Specialization:
- Description: Represents a condition where circulation exists along the hydraulic logical element.
- Examples:
```dwis DownholeECD
DynamicDrillingSignal:downholeECD
PhysicalData:downholeECD#01
downholeECD#01 BelongsToClass ContinuousDataType
downholeECD#01 HasDynamicValue downholeECD
downholeECD#01 IsOfMeasurableQuantity MassDensityDrilling
Measurement:downholePressure#01
downholePressure#01 BelongsToClass ContinuousDataType
downholePressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageDownholePressure
downholePressure#01 IsTransformationOutput movingAverageDownholePressure
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
This example describes the downhole ECD.
## HydraulicStaticCondition <!-- NOUN -->
- Display name: Hydraulic Static Condition
- Parent class: HydraulicCondition
- Attributes:
- Specialization:
- Description: Represents a condition where the fluid in the hydraulic logical element is static (no circulation).
- Examples:
```dwis DownholeESDExample
DynamicDrillingSignal:downholeESD
PhysicalData:downholeESD#01
downholeESD#01 BelongsToClass ContinuousDataType
downholeESD#01 HasDynamicValue downholeESD
downholeESD#01 IsOfMeasurableQuantity MassDensityDrilling
Measurement:downholePressure#01
downholePressure#01 BelongsToClass ContinuousDataType
downholePressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageDownholePressure
downholePressure#01 IsTransformationOutput movingAverageDownholePressure
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
This example describes the downhole ESD.
## FluidComponent <!-- NOUN -->
- Display name: FluidComponent
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Component substance of a fluid mixture.
- Examples:
```dwis fluidComponent
FluidComponent:component
DrillingDataPoint:componentFraction
componentFraction ConcernsAFluidComponent component
```
This example links a component fraction to a fluid component.
## LiquidComponent <!-- NOUN -->
- Display name: LiquidComponent
- Parent class: FluidComponent
- Attributes:
- Specialization:
- Description: Liquid portion of a fluid mixture.
- Examples:
```dwis liquidComponent
LiquidComponent:liquidComponent
DrillingDataPoint:liquidFraction
liquidFraction ConcernsAFluidComponent liquidComponent
```
This example ties a liquid fraction to a liquid component.
## FormationLiquidComponent <!-- NOUN -->
- Display name: FormationLiquidComponent
- Parent class: LiquidComponent
- Attributes:
- Specialization:
- Description: Liquid originating from the formation.
- Examples:
```dwis formationLiquid
FormationLiquidComponent:formationLiquid
DrillingDataPoint:formationLiquidFraction
formationLiquidFraction ConcernsAFluidComponent formationLiquid
```
This example references formation liquid in the mixture.
## DrillingFluidLiquidComponent <!-- NOUN -->
- Display name: DrillingFluidLiquidComponent
- Parent class: LiquidComponent
- Attributes:
- Specialization:
- Description: Liquid portion belonging to the drilling fluid.
- Examples:
```dwis mudLiquid
DrillingFluidLiquidComponent:mudLiquid
DrillingDataPoint:mudLiquidFraction
mudLiquidFraction ConcernsAFluidComponent mudLiquid
```
This example links a mud liquid fraction.
## DrillingFluidOilComponent <!-- NOUN -->
- Display name: OilComponent
- Parent class: DrillingFluidLiquidComponent
- Attributes:
- Specialization:
- Description: Oil component of an oil- or synthetic-based mud.
- Examples:
```dwis oilComponent
DrillingFluidOilComponent:oilComponent
DrillingDataPoint:oilFraction
oilFraction ConcernsAFluidComponent oilComponent
```
This example references oil fraction in the mud.
## DrillingFluidWaterComponent <!-- NOUN -->
- Display name: WaterComponent
- Parent class: DrillingFluidLiquidComponent
- Attributes:
- Specialization:
- Description: Water component of the drilling fluid.
- Examples:
```dwis waterComponent
DrillingFluidWaterComponent:waterComponent
DrillingDataPoint:waterFraction
waterFraction ConcernsAFluidComponent waterComponent
```
This example references water fraction in the mud.
## GasComponent <!-- NOUN -->
- Display name: GasComponent
- Parent class: FluidComponent
- Attributes:
- Specialization:
- Description: Gas portion of a fluid mixture.
- Examples:
```dwis gasComponent
GasComponent:gasComponent
DrillingDataPoint:gasCut
gasCut ConcernsAFluidComponent gasComponent
```
This example links gas cut to a gas component.
```dwis gasProportionFlowOutProportionExample
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
This example describes gas proportion in the return flow line.
## FormationGasComponent <!-- NOUN -->
- Display name: FormationGasComponent
- Parent class: GasComponent
- Attributes:
- Specialization:
- Description: Gas originating from the formation.
- Examples:
```dwis formationGas
FormationGasComponent:formationGas
DrillingDataPoint:formationGasFraction
formationGasFraction ConcernsAFluidComponent formationGas
```
This example references formation gas in the mixture.
## DrillingFluidGasComponent <!-- NOUN -->
- Display name: DrillingFluidGasComponent
- Parent class: GasComponent
- Attributes:
- Specialization:
- Description: Gas intentionally present in the drilling fluid (e.g., aerated mud).
- Examples:
```dwis drillingGas
DrillingFluidGasComponent:drillingGas
DrillingDataPoint:drillingGasFraction
drillingGasFraction ConcernsAFluidComponent drillingGas
```
This example notes gas component within the mud.
## SolidComponent <!-- NOUN -->
- Display name: SolidComponent
- Parent class: FluidComponent
- Attributes:
- Specialization:
- Description: Solid portion of a fluid mixture.
- Examples:
```dwis solidComponent
SolidComponent:solidComponent
DrillingDataPoint:solidsFraction
solidsFraction ConcernsAFluidComponent solidComponent
```
This example references solids fraction.
## DrillingFluidSolidComponent <!-- NOUN -->
- Display name: DrillingFluidSolidComponent
- Parent class: SolidComponent
- Attributes:
- Specialization:
- Description: Solids intentionally present in the drilling fluid (e.g., barite, bentonite).
- Examples:
```dwis mudSolid
DrillingFluidSolidComponent:mudSolid
DrillingDataPoint:mudSolidFraction
mudSolidFraction ConcernsAFluidComponent mudSolid
```
This example notes a mud solid component.
## HighGravitySolidComponent <!-- NOUN -->
- Display name: HighGravitySolidComponent
- Parent class: DrillingFluidSolidComponent
- Attributes:
- Specialization:
- Description: High-density solids such as weighting agents.
- Examples:
```dwis hgsComponent
HighGravitySolidComponent:hgsComponent
DrillingDataPoint:bariteFraction
bariteFraction ConcernsAFluidComponent hgsComponent
```
This example references barite as a high-gravity solid.
## LowGravitySolidComponent <!-- NOUN -->
- Display name: LowGravitySolidComponent
- Parent class: DrillingFluidSolidComponent
- Attributes:
- Specialization:
- Description: Low-density solids such as drilled solids and clays.
- Examples:
```dwis lgsComponent
LowGravitySolidComponent:lgsComponent
DrillingDataPoint:lgsFraction
lgsFraction ConcernsAFluidComponent lgsComponent
```
This example notes low-gravity solids fraction.
## FormationSolidComponent <!-- NOUN -->
- Display name: FormationSolidComponent
- Parent class: SolidComponent
- Attributes:
- Specialization:
- Description: Solids originating from the formation.
- Examples:
```dwis formationSolid
FormationSolidComponent:formationSolid
DrillingDataPoint:formationSolidFraction
formationSolidFraction ConcernsAFluidComponent formationSolid
```
This example references formation solids.
## CuttingsComponent <!-- NOUN -->
- Display name: CuttingsComponent
- Parent class: FormationSolidComponent
- Attributes:
- Specialization:
- Description: Solid component representing drilled cuttings.
- Examples:
```dwis cuttingsComponent
CuttingsComponent:cuttings
DrillingDataPoint:cuttingsFraction
cuttingsFraction ConcernsAFluidComponent cuttings
```
This example references cuttings fraction.
```dwis lagTimeExample
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
This example describes lag time for cuttings to reach the return flow line.
## CavingsComponent <!-- NOUN -->
- Display name: CavingsComponent
- Parent class: FormationSolidComponent
- Attributes:
- Specialization:
- Description: Larger rock fragments (cavings) originating from unstable formations.
- Examples:
```dwis cavingsComponent
CavingsComponent:cavings
DrillingDataPoint:cavingsFraction
cavingsFraction ConcernsAFluidComponent cavings
```
This example references cavings fraction.
## FluidInterface <!-- NOUN -->
- Display name: Fluid Interface
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: The interface between two fluids in a hydraulic system.
- Examples:
```dwis fluidInterface
FluidInterface:fluidInterface
DrillingLiquidType:drillingLiquidType
FormationGas:formationGas
formationGas IsUpstreamOf fluidInterface
drillingLiquidType IsDownstreamOf fluidInterface
```
This example shows an interface between formation gas and drilling liquid.
## FluidType <!-- NOUN -->
- Display name: Fluid Type
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A symbolic representation of the type of a fluid to be found in a hydraulic system.
- Examples:
```dwis fluidTypeExample
FluidInterface:fluidInterface
DrillingLiquidType:drillingLiquidType
FormationGas:formationGas
formationGas IsUpstreamOf fluidInterface
drillingLiquidType IsDownstreamOf fluidInterface
```
This example shows that there are fluid types for which gas is upstream of the drilling fluid.
## GasType <!-- NOUN -->
- Display name: Gas Type
- Parent class: FluidType
- Attributes:
- Specialization:
- Description: A symbolic representation of gas when encountered in a hydraulic system.
- Examples:
```dwis gasTypeExample
GasType:gasType
FluidInterface:gasLiquidInterface
gasType IsUpstreamOf gasLiquidInterface
```
This example uses a gas type upstream of a gas–liquid interface.
## AirType <!-- NOUN -->
- Display name: Air Type
- Parent class: GasType
- Attributes:
- Specialization:
- Description: A symbolic representation of air when encountered in a hydraulic system.
- Examples:
```dwis airTypeExample
AirType:airType
HydraulicLogicalElement:returnLine
airType IsFluidTypeLocatedAt returnLine
```
This example places air within the return line context.
## FormationGasType <!-- NOUN -->
- Display name: Formation Gas Type
- Parent class: GasType
- Attributes:
- Specialization:
- Description: A symbolic representation of formation gas when encountered in a hydraulic system.
- Examples:
```dwis formationGasTypeExample
FormationGasType:formationGasType
FluidInterface:gasLiquidInterface
formationGasType IsUpstreamOf gasLiquidInterface
```
This example uses formation gas as the upstream fluid at an interface.
## LiquidType <!-- NOUN -->
- Display name: Liquid Type
- Parent class: FluidType
- Attributes:
- Specialization:
- Description: A symbolic representation of liquid when encountered in a hydraulic system.
- Examples:
```dwis liquidTypeExample
Liquid:liquid
HydraulicLogicalElement:standpipe
liquid IsFluidTypeLocatedAt standpipe
```
This example assigns a liquid to the standpipe.
## DrillingLiquidType <!-- NOUN -->
- Display name: Drilling Liquid Type
- Parent class: LiquidType
- Attributes:
- Specialization:
- Description: A symbolic representation of drilling liquid when encountered in a hydraulic system.
- Examples:
```dwis drillingLiquidType
DrillingLiquidType:drillingLiquidType
HydraulicLogicalElement:annulus
drillingLiquidType IsFluidTypeLocatedAt annulus
```
This example tags drilling liquid in the annulus.
## FlowCurve <!-- NOUN -->
- Display name: Flow Curve
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A flow curve defines the relationship between shear stress and shear rate for a given material.
- Examples:
```dwis flowCurveExample
DrillingLiquidType:drillingFluidType
FlowCurve:flowCurve
drillingFluidType HasFlowCurve flowCurve
```
This example states that a drilling liquid has a flow curve.
## RheologicalBehavior <!-- NOUN -->
- Display name: Rheological Behavior
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: The rheological behavior defines how materials deform and flow under applied forces, 
spanning from viscous flow to elastic deformation. The rheological behavior of a FluidType depends in 
a non-obvious way of the rheological behaviors of its components.
- Examples:
```dwis rheologicalBehaviorExample
DrillingLiquidType:drillingLiquidType
RheologicalBehavior:rheologicalBehavior
drillingLiquidType HasRheologicalBehavior rheologicalBehavior
```
This example states that a drilling liquid has a rheological behavior.
## NewtonianFluid <!-- NOUN -->
- Display name: Newtonian Fluid
- Parent class: RheologicalBehavior
- Attributes:
- Specialization:
- Description: A Newtonian rheological behavior is such that the shear stress is proportional to the shear rate at 
constant conditions of pressure and temperature, i.e., the viscosity remains constant regardless of the applied shear rate.
- Examples:
```dwis NewtonianFluidExample
DrillingLiquidType:drillingLiquidType
NewtonianFluid:newtonianFluid
drillingLiquidType HasRheologicalBehavior newtonianFluid
```
This example states that a drilling liquid has a Newtonian rheological behavior.
## NonNewtonianFluid <!-- NOUN -->
- Display name: Non Newtonian Fluid
- Parent class: RheologicalBehavior
- Attributes:
- Specialization:
- Description: A non-Newtonian rheological behavior is such that the shear stress is not directly proportional 
to the shear rate when the pressure and temperature are constant, i.e., the viscosity changes with shear rate
- Examples:
```dwis NonNewtonianFluidExample
DrillingLiquidType:drillingLiquidType
NonNewtonianFluid:nonNewtonianFluid
drillingLiquidType HasRheologicalBehavior nonNewtonianFluid
```
## BinghamPlastic <!-- NOUN -->
- Display name: Bingham Plastic
- Parent class: NonNewtonianFluid
- Attributes:
- Specialization:
- Description: A Bingham plastic rheological behavior is characterized by a yield stress that must be exceeded
before the material begins to flow,
- Examples:
```dwis BinghamPlasticFluidExample
DrillingLiquidType:drillingLiquidType
BinghamPlastic:binghamPlastic
drillingLiquidType HasRheologicalBehavior binghamPlastic
```
This example states that a drilling liquid has a Bingham plastic rheological behavior.
```dwis BinghamPlasticFluidExample2
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
This example describes the yield point of a Bingham plastic fluid at the inlet of the top of string junction.
## YieldPowerLaw <!-- NOUN -->
- Display name: Yield Power Law
- Parent class: NonNewtonianFluid
- Attributes:
- Specialization:
- Description: A Yield Power Law rheological behavior is characterized by a yield stress and a shear thinning or shear thickening properties where the viscosity changes with shear rate
before the material begins to flow,
- Examples:
```dwis YieldPowerLawFluidExample
DrillingLiquidType:drillingLiquidType
YieldPowerLaw:yieldPowerLaw
drillingLiquidType HasRheologicalBehavior yieldPowerLaw
```
This example states that a drilling liquid has a yield power law rheological behavior.
## Quemada <!-- NOUN -->
- Display name: Quemada
- Parent class: NonNewtonianFluid
- Attributes:
- Specialization:
- Description: A Quemada rheological behavior exhibits shear thinning and shear thickening properties, yet with limits
at low and high shear rates that tend to constant viscosity values.
- Examples:
```dwis QuemadaExample
DrillingLiquidType:drillingLiquidType
Quemada:quemada
drillingLiquidType HasRheologicalBehavior quemada
```
This example states that a drilling liquid has a Quemada rheological behavior.
## FlowMeasurementPrinciple <!-- NOUN -->
- Display name: Flow Measurement Principle
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Describes the underlying principle used to obtain a measurement about a flowing medium.
- Examples:
```dwis FlowMeasurementPrincipleExample
DrillingDataPoint:realtimeSignal
FlowMeasurementPrinciple:flowMeasurementPrinciple
realtimeSignal UsesFlowMeasurementPrinciple flowMeasurementPrinciple
```
This example states that a realtime signal uses a flow mearurement principle.
## ResonantMeasurementPrinciple <!-- NOUN -->
- Display name: Resonant Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a resonant measurement principle is used to perform a measurement, e.g., vibrating tube or fork or cantilever.
- Examples:
```dwis ResonantMeasurementPrincipleExample
DrillingDataPoint:densitySignal
ResonantMeasurementPrinciple:resonantMeasurementPrinciple
densitySignal UsesFlowMeasurementPrinciple resonantMeasurementPrinciple
```
This example states that a mass density signal uses a resonant tube or fork or cantilever measurement principle.
## ConcentricCylindersMeasurementPrinciple <!-- NOUN -->
- Display name: Concentric Cylinder Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a measurement principle utilizing concentric cylinders is used to perform a measurement, like typically a Couette rheometer.
- Examples:
```dwis ConcentricCylindersMeasurementPrincipleExample
DrillingDataPoint:shearStressSignal
ConcentricCylindersMeasurementPrinciple:concentricCylindersMeasurementPrinciple
shearStressSignal UsesFlowMeasurementPrinciple concentricCylindersMeasurementPrinciple
```
This example states that a shear stress signal uses a measurement principle utilizing concentric cylinders.
## DifferentialPressureMeasurementPrinciple <!-- NOUN -->
- Display name: Vibrating Tube Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a differential pressure measurement principle is used to perform a measurement.
- Examples:
```dwis DifferentialPressureMeasurementPrincipleExample
DrillingDataPoint:densitySignal
DifferentialPressureMeasurementPrinciple:differentialPressureMeasurementPrinciple
densitySignal UsesFlowMeasurementPrinciple differentialPressureMeasurementPrinciple
```
This example states that a mass density signal uses a differential pressure measurement principle.
## RotatingWheelMeasurementPrinciple <!-- NOUN -->
- Display name: Rotating Wheel Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a rotating wheel measurement principle is used to perform a measurement.
- Examples:
```dwis RotatingWheelMeasurementPrincipleExample
DrillingDataPoint:massFlowRateSignal
RotatingWheelMeasurementPrinciple:rotatingWheelMeasurementPrinciple
massFlowRateSignal UsesFlowMeasurementPrinciple rotatingWheelMeasurementPrinciple
```
This example states that a mass flowrate signal uses a rotating wheel measurement principle.
## MechanicalMomentumMeasurementPrinciple <!-- NOUN -->
- Display name: Mechanical Momentum Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a mechanical momentum measurement principle is used to perform a measurement.
- Examples:
```dwis MechanicalMomentumMeasurementPrincipleExample
DrillingDataPoint:volumetricFlowRateSignal
MechanicalMomentumMeasurementPrinciple:mechanicalMomentumMeasurementPrinciple
volumetricFlowRateSignal UsesFlowMeasurementPrinciple mechanicalMomentumMeasurementPrinciple
```
This example states that a volumetric flowrate signal uses a mechanical momentum measurement principle.
## CalorimetricMeasurementPrinciple <!-- NOUN -->
- Display name: Calorimetric Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a calorimetric measurement principle is used to perform a measurement.
- Examples:
```dwis CalorimetricMeasurementPrincipleExample
DrillingDataPoint:massFlowRateSignal
CalorimetricMeasurementPrinciple:calorimetricMeasurementPrinciple
massFlowRateSignal UsesFlowMeasurementPrinciple calorimetricMeasurementPrinciple
```
This example states that a mass flowrate signal uses a calorimetric measurement principle.
## AcousticMeasurementPrinciple <!-- NOUN -->
- Display name: Acoustic Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that an acoustic measurement principle is used to perform a measurement.
- Examples:
```dwis AcousticMeasurementPrincipleExample
DrillingDataPoint:volumetricFlowRateSignal
AcousticMeasurementPrinciple:acousticMeasurementPrinciple
volumetricFlowRateSignal UsesFlowMeasurementPrinciple acousticMeasurementPrinciple
```
This example states that a volumetric flowrate signal uses an acoustic measurement principle.
## ElectromagneticMeasurementPrinciple <!-- NOUN -->
- Display name: Electromagnetic Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that an electromagnetic measurement principle is used to perform a measurement.
- Examples:
```dwis ElectromagneticMeasurementPrincipleExample
DrillingDataPoint:volumetricFlowRateSignal
ElectromagneticMeasurementPrinciple:electromagneticMeasurementPrinciple
volumetricFlowRateSignal UsesFlowMeasurementPrinciple electromagneticMeasurementPrinciple
```
This example states that a volumetric flowrate signal uses an electromagnetic measurement principle.
## RadiometricMeasurementPrinciple <!-- NOUN -->
- Display name: Radiometric Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that an radiometric measurement principle is used to perform a measurement.
- Examples:
```dwis RadiometricMeasurementPrincipleExample
DrillingDataPoint:densitySignal
RadiometricMeasurementPrinciple:radiometricMeasurementPrinciple
densitySignal UsesFlowMeasurementPrinciple radiometricMeasurementPrinciple
```
This example states that a mass density signal uses an radiometric measurement principle.
## OpticalMeasurementPrinciple <!-- NOUN -->
- Display name: Optical Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that an optical measurement principle is used to perform a measurement.
- Examples:
```dwis OpticalMeasurementPrincipleExample
DrillingDataPoint:volumetricFlowRateSignal
OpticalMeasurementPrinciple:opticalMeasurementPrinciple
volumetricFlowRateSignal UsesFlowMeasurementPrinciple radiometricMeasurementPrinciple
```
This example states that a volumetric flowrate signal uses an optical measurement principle.
## GravimetricMeasurementPrinciple <!-- NOUN -->
- Display name: Gravimetric Measurement Principle
- Parent class: FlowMeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that a gravimetric measurement principle is used to perform a measurement.
- Examples:
```dwis GravimetricMeasurementPrincipleExample
DrillingDataPoint:densitySignal
GravimetricMeasurementPrinciple:gravimetricMeasurementPrinciple
densitySignal UsesFlowMeasurementPrinciple gravimetricMeasurementPrinciple
```
This example states that a mass density signal uses an gravimetric measurement principle.
# VERBS
## HasPressureReferenceType <!-- VERB -->
- Display name: HasPressureReferenceType
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: PressureReference
- Description: Indicates the pressure reference basis used for a pressure data point.
- Examples: 
```dwis pressureReferenceExample
DrillingDataPoint:standpipePressure
GaugePressureReference:gaugePressure
standpipePressure HasPressureReferenceType gaugePressure
```
This example sets a gauge reference for standpipe pressure.
## EndsHydraulicBranchDecomposition <!-- VERB -->
- Display name: EndsHydraulicBranchDecomposition
- Parent verb: DWISVerb
- Subject class: HydraulicBranch
- Object class: HydraulicBranch
- Description: Marks the terminating branch when decomposing a hydraulic path.
- Examples: 
```dwis endBranch
HydraulicBranch:standpipeBranch
HydraulicBranch:openHole
standpipeBranch EndsHydraulicBranchDecomposition openHole
```
This example declares that the standpipe branch ends at the open hole branch.
## IsAHydraulicRepresentationFor <!-- VERB -->
- Display name: IsAHydraulicRepresentationFor
- Parent verb: DWISVerb
- Subject class: HydraulicLogicalElement
- Object class: DrillingEquipment
- Description: Links a hydraulic element to the piece of equipment it represents.
- Examples: 
```dwis hydraulicRepresentation
HydraulicBranch:standpipeBranch
DrillingEquipment:standpipe
standpipeBranch IsAHydraulicRepresentationFor standpipe
```
This example represents a standpipe with a hydraulic branch.
## IsASubHydraulicNetwork <!-- VERB -->
- Display name: Is a sub-hydraulic network
- Parent verb: DWISVerb
- Subject class: HydraulicNetwork
- Object class: HydraulicNetwork
- Description: Declares that a hydraulic network is a sub-hydraulic network of another one.
- Examples: 
```dwis IsASubHydraulicNetworkExample
HydraulicNetwork:surfaceNetwork
MPDMainFlowPath:mainFlowPath
mainFlowPath IsASubHydraulicNetwork surfaceNetwork
```
This example indicates that the mainFlowPath is a sub-hydraulic network of the surface network.
## HasLogicalElementComponent <!-- VERB -->
- Display name: Has Logical Element Component
- Parent verb: DWISVerb
- Subject class: HydraulicNetwork
- Object class: HydraulicLogicalElement
- Description: Declares that a hydraulic network has a hydraulic logical element.
- Examples: 
```dwis HasLogicalElementComponentExample
TopsideHydraulicNetwork:topsideHydraulicNetwork
ActivePitLogical:ActivePitLogical
topsideHydraulicNetwork HasLogicalElementComponent ActivePitLogical
```
This example indicates that the top side hydraulic network has a hydraulic logical component that is an active pit.
## HasBranchComponent <!-- VERB -->
- Display name: Has Branch Component
- Parent verb: DWISVerb
- Subject class: HydraulicNetwork
- Object class: HydraulicBranch
- Description: Declares that a hydraulic network contains a branch.
- Examples: 
```dwis branchComponent
HydraulicNetwork:surfaceNetwork
HydraulicBranch:returnLine
surfaceNetwork HasBranchComponent returnLine
```
This example adds a return line branch to the surface network.
## HasBranchCoordinateSystem <!-- VERB -->
- Display name: Has Branch Coordinate System
- Parent verb: DWISVerb
- Subject class: HydraulicBranch
- Object class: ReferenceFrame
- Description: Associates a coordinate system with a hydraulic branch.
- Examples: 
```dwis branchCoordinates
HydraulicBranch:annulus
ReferenceFrame:annulusFrame
annulus HasBranchCoordinateSystem annulusFrame
```
This example assigns a reference frame to the annulus branch.
## IsAssociatedToHydraulicBranch <!-- VERB -->
- Display name: Is Associated To Hydraulic Branch
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: HydraulicBranch
- Description: Associates drilling data point to a hydraulic branch.
- Examples: 
```dwis IsAssociatedToHydraulicBranch
HydraulicBranch:inletToDrillstring
DrillingDataPoint:inletPressure
inletPressure IsAssociatedToHydraulicBranch inletToDrillstring
```
This example associates the inlet pressure data point to the inlet to drillstring branch.
```dwis ASMAnnulusPressureExample
DynamicDrillingSignal:BlackStreamMeasuredAnnulusPressure
DerivedMeasurement:BlackStreamMeasuredAnnulusPressure#01
BlackStreamMeasuredAnnulusPressure#01 BelongsToClass JSonDataType
BlackStreamMeasuredAnnulusPressure#01 HasDynamicValue BlackStreamMeasuredAnnulusPressure
BlackStreamMeasuredAnnulusPressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageBlackStreamMeasuredAnnulusPressure
BlackStreamMeasuredAnnulusPressure#01 IsTransformationOutput movingAverageBlackStreamMeasuredAnnulusPressure
WiredPipeTelemetry:wiredPipeTelemetry
BlackStreamMeasuredAnnulusPressure#01 IsTransmittedBy wiredPipeTelemetry
DynamicDrillingSignal:BlackStreamMeasuredAnnulusPressureUncertainty
DrillingDataPoint:BlackStreamMeasuredAnnulusPressureUncertainty#01
BlackStreamMeasuredAnnulusPressureUncertainty#01 BelongsToClass ContinuousDataType
BlackStreamMeasuredAnnulusPressureUncertainty#01 IsOfMeasurableQuantity PressureDrilling
BlackStreamMeasuredAnnulusPressureUncertainty#01 HasDynamicValue BlackStreamMeasuredAnnulusPressureUncertainty
GaussianUncertainty:BlackStreamMeasuredAnnulusPressureGaussianUncertainty#01
BlackStreamMeasuredAnnulusPressureGaussianUncertainty#01 HasUncertaintyStandardDeviation BlackStreamMeasuredAnnulusPressureUncertainty#01
BlackStreamMeasuredAnnulusPressure#01 HasUncertainty BlackStreamMeasuredAnnulusPressureGaussianUncertainty#01
AnnulusOutletJunction:annulusOutletJunction#01
HydraulicBranch:annulusHydraulicBranch#01
annulusOutletJunction#01 HasUpstreamBranch annulusHydraulicBranch#01
BlackStreamMeasuredAnnulusPressure#01 IsAssociatedToHydraulicBranch annulusHydraulicBranch#01
PipeSectionMechanicalLogicalElement:pipeSection#01
BlackStreamMeasuredAnnulusPressure#01 IsMechanicallyLocatedAt pipeSection#01
InstrumentationCompany:NOV#01
BlackStreamMeasuredAnnulusPressure#01 IsProvidedBy NOV#01
```
This example declares a pressure signal that is measured in the annulus along the drill string.
## HasHydraulicState <!-- VERB -->
- Display name: Has Hydraulic State
- Parent verb: DWISVerb
- Subject class: HydraulicLogicalElement
- Object class: HydraulicElementState
- Description: Indicates the current state of a hydraulic logical element.
- Examples: 
```dwis junctionState
HydraulicJunction:chokeJunction
HydraulicConnectedState:connectedState
chokeJunction HasHydraulicState connectedState
```
This example records the connection state of a junction.
## HasHydraulicStateValueFrom <!-- VERB -->
- Display name: Has Hydraulic State Value From
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Indicates that the state value is provided by another signal or computation.
- Examples: 
```dwis stateValueSource
HydraulicConnectedState:connectedState
DrillingDataPoint:valveOpenFlag
connectedState HasHydraulicStateValueFrom valveOpenFlag
```
This example sets a connection state value from a valve open flag.
## HasLeftBranchCoordinates <!-- VERB -->
- Display name: Has Left Branch Coordinates
- Parent verb: DWISVerb
- Subject class: HydraulicJunction
- Object class: DrillingDataPoint
- Description: Associates coordinate data for the left branch of a junction.
- Examples: 
```dwis leftCoords
HydraulicJunction:flowJunction
DrillingDataPoint:leftBranchMD
flowJunction HasLeftBranchCoordinates leftBranchMD
```
This example sets measured depth coordinates for the left branch.
## HasRightBranchCoordinates <!-- VERB -->
- Display name: Has Right Branch Coordinates
- Parent verb: DWISVerb
- Subject class: HydraulicJunction
- Object class: DrillingDataPoint
- Description: Associates coordinate data for the right branch of a junction.
- Examples: 
```dwis rightCoords
HydraulicJunction:flowJunction
DrillingDataPoint:rightBranchMD
flowJunction HasRightBranchCoordinates rightBranchMD
```
This example sets coordinates for the right branch.
## IsHydraulicallyLocatedAt <!-- VERB -->
- Display name: Is Hydraulically Located At
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Places a measurement or estimation at a specific hydraulic element.
- Examples: 
```dwis locatedAtBranch
DrillingDataPoint:standpipePressure
HydraulicBranch:standpipeBranch
standpipePressure IsHydraulicallyLocatedAt standpipeBranch
```
This example locates standpipe pressure at the standpipe branch.
## IsEquivalentCirculationDensityAt <!-- VERB -->
- Display name: Is Equivalent Circulation Density At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates that a data point represents ECD at a hydraulic element.
- Examples: 
```dwis ecdAt
DrillingDataPoint:ecd
HydraulicLogicalElement:annulus
ecd IsEquivalentCirculationDensityAt annulus
```
This example places ECD at the annulus.
## IsFluidDensityAt <!-- VERB -->
- Display name: Is Fluid Density At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates fluid density at a hydraulic element.
- Examples: 
```dwis densityAt
DrillingDataPoint:fluidDensity
HydraulicLogicalElement:standpipeBranch
fluidDensity IsFluidDensityAt standpipeBranch
```
This example assigns fluid density to the standpipe branch.
## IsFluidTemperatureAt <!-- VERB -->
- Display name: Is Fluid Temperature At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates fluid temperature at a hydraulic element.
- Examples: 
```dwis temperatureAt
DrillingDataPoint:fluidTemperature
HydraulicLogicalElement:annulus
fluidTemperature IsFluidTemperatureAt annulus
```
This example reports temperature in the annulus.
## IsFluidVelocityAt <!-- VERB -->
- Display name: Is Fluid Velocity At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates fluid velocity at a hydraulic element.
- Examples: 
```dwis velocityAt
DrillingDataPoint:fluidVelocity
HydraulicLogicalElement:dpInner
fluidVelocity IsFluidVelocityAt dpInner
```
This example assigns fluid velocity to the drill pipe inner.
## IsOpeningRatioAt <!-- VERB -->
- Display name: Is Opening Ratio At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates an opening ratio (e.g., choke valve) at a hydraulic element.
- Examples: 
```dwis openingRatio
DrillingDataPoint:chokeOpening
HydraulicLogicalElement:chokeJunction
chokeOpening IsOpeningRatioAt chokeJunction
```
This example sets choke opening ratio at a junction.
## IsVolumeAt <!-- VERB -->
- Display name: IsVolumeAt
- Parent verb: Is Hydraulically Located At
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates a volume measurement for a HydraulicLogicalElement.
- Examples: 
```dwis tankVolume
DrillingDataPoint:mudVolume
TankLogical:mudTank
mudVolume IsVolumeAt mudTank
```
This example records mud volume in a tank.
## IsHydraulicEstimationAt <!-- VERB -->
- Display name: Is Hydraulic Estimation At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates that a value is an estimated hydraulic parameter at an element.
- Examples: 
```dwis estimatedPressureExample
DrillingDataPoint:estimatedAnnulusPressure
HydraulicLogicalElement:annulus
estimatedAnnulusPressure IsHydraulicEstimationAt annulus
```
This example shows an estimated annulus pressure.
```dwis ShakerLoadEstimateExample
DynamicDrillingSignal:CleanSightShakerLoadEstimate
ComputedData:CleanSightShakerLoadEstimate#01
CleanSightShakerLoadEstimate#01 BelongsToClass JSonDataType
CleanSightShakerLoadEstimate#01 HasDynamicValue CleanSightShakerLoadEstimate
CleanSightShakerLoadEstimate#01 IsOfMeasurableQuantity DimensionLessStandard
TopSideTelemetry:topSideTelemetry
CleanSightShakerLoadEstimate#01 IsTransmittedBy topSideTelemetry
MovingAverage:movingAverageCleanSightShakerLoadEstimate
CleanSightShakerLoadEstimate#01 IsTransformationOutput movingAverageCleanSightShakerLoadEstimate
CuttingSeparatorLogical:ShaleShakerElement#01
CleanSightShakerLoadEstimate#01 IsHydraulicEstimationAt ShaleShakerElement#01
DrillingLiquidType:DrillingFluid#01
DrillingFluid#01 IsFluidTypeLocatedAt ShaleShakerElement#01
InstrumentationCompany:DrillDocs#01
CleanSightShakerLoadEstimate#01 IsProvidedBy DrillDocs#01
```
This example declares a shaker load estimate as a hydraulic estimation at a shale shaker element.
## IsHydraulicMaximumAllowedRateOfChangeAt <!-- VERB -->
- Display name: Is Hydraulic Maximum Allowed Rate Of Change At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Maximum allowable rate of change for a hydraulic parameter at an element.
- Examples: 
```dwis maxRateOfChange
DrillingDataPoint:maxPressureRamp
HydraulicLogicalElement:chokeJunction
maxPressureRamp IsHydraulicMaximumAllowedRateOfChangeAt chokeJunction
```
This example sets a max pressure ramp rate at the choke.
## IsHydraulicMaximumAllowedValueAt <!-- VERB -->
- Display name: Is Hydraulic Maximum Allowed Value At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Maximum allowable value of a hydraulic parameter at an element.
- Examples: 
```dwis maxAllowedPressure
DrillingDataPoint:maxAllowedPressure
HydraulicLogicalElement:annulus
maxAllowedPressure IsHydraulicMaximumAllowedValueAt annulus
```
This example provides a max allowed pressure at the annulus.
## IsHydraulicMeasurementAt <!-- VERB -->
- Display name: Is Hydraulic Measurement At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates a measurement taken at a hydraulic element.
- Examples: 
```dwis hydraulicMeasurement
DrillingDataPoint:standpipePressure
HydraulicLogicalElement:standpipeBranch
standpipePressure IsHydraulicMeasurementAt standpipeBranch
```
This example sets a pressure measurement location.
## IsMassFlowRateAt <!-- VERB -->
- Display name: Is Mass Flow Rate At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates a mass flow rate value at a hydraulic element.
- Examples: 
```dwis massFlowRate
DrillingDataPoint:massFlowRate
HydraulicLogicalElement:standpipeBranch
massFlowRate IsMassFlowRateAt standpipeBranch
```
This example places mass flow rate at the standpipe.
## IsPressureAt <!-- VERB -->
- Display name: Is Pressure At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates a pressure value at a hydraulic element.
- Examples: 
```dwis pressureAt
DrillingDataPoint:annulusPressure
HydraulicLogicalElement:annulus
annulusPressure IsPressureAt annulus
```
This example locates annulus pressure.
## IsPressureGradientAt <!-- VERB -->
- Display name: Is Pressure Gradient At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates a pressure gradient at a hydraulic element.
- Examples: 
```dwis pressureGradient
DrillingDataPoint:pressureGradient
HydraulicLogicalElement:openHole
pressureGradient IsPressureGradientAt openHole
```
This example sets a pressure gradient in the open hole.
## IsVolumetricFlowRateAt <!-- VERB -->
- Display name: Is Volumetric Flow Rate At
- Parent verb: IsHydraulicallyLocatedAt
- Subject class: DrillingDataPoint
- Object class: HydraulicLogicalElement
- Description: Indicates a volumetric flow rate at a hydraulic element.
- Examples: 
```dwis volumetricFlow
DrillingDataPoint:flowRate
HydraulicLogicalElement:returnLine
flowRate IsVolumetricFlowRateAt returnLine
```
This example places flow rate at the return line.
## IsHydraulicConnectedTo <!-- VERB -->
- Display name: Is Hydraulic Connected To
- Parent verb: DWISVerb
- Subject class: HydraulicLogicalElement
- Object class: HydraulicLogicalElement
- Description: Connects two hydraulic elements within the network.
- Examples: 
```dwis connection
HydraulicBranch:standpipeBranch
HydraulicJunction:chokeJunction
standpipeBranch IsHydraulicConnectedTo chokeJunction
```
This example connects a branch to a junction.
## HasEndJunction <!-- VERB -->
- Display name: Has End Junction
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicBranch
- Object class: HydraulicJunction
- Description: Specifies the terminal junction of a branch.
- Examples: 
```dwis endJunction
HydraulicBranch:returnLine
HydraulicJunction:mudMixingJunction
returnLine HasEndJunction mudMixingJunction
```
This example sets the end junction of the return line.
## HasLeftBranch <!-- VERB -->
- Display name: Has Left Branch
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicJunction
- Object class: HydraulicBranch
- Description: Assigns the left branch connected to a junction.
- Examples: 
```dwis leftBranch
HydraulicJunction:flowJunction
HydraulicBranch:standpipeBranch
flowJunction HasLeftBranch standpipeBranch
```
This example sets the left branch of a junction.
## HasRightBranch <!-- VERB -->
- Display name: Has Right Branch
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicJunction
- Object class: HydraulicBranch
- Description: Assigns the right branch connected to a junction.
- Examples: 
```dwis rightBranch
HydraulicJunction:flowJunction
HydraulicBranch:returnLine
flowJunction HasRightBranch returnLine
```
This example sets the right branch of a junction.
## HasUpstreamBranch <!-- VERB -->
- Display name: Has Upstream Branch
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicJunction
- Object class: HydraulicBranch
- Description: Assigns the upstream branch connected to a junction.
- Examples: 
```dwis HasUpstreamBranchExample
HydraulicJunction:topOfStringJunction
HydraulicBranch:inlineBranch
topOfStringJunction HasUpstreamBranch inlineBranch
```
This example sets the inline branch upstream of the top of string junction.
## HasDownstreamBranch <!-- VERB -->
- Display name: Has Downstream Branch
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicJunction
- Object class: HydraulicBranch
- Description: Assigns the downstream branch connected to a junction.
- Examples: 
```dwis HasDownstreamBranchExample
HydraulicJunction:annulusOutletJunction
HydraulicBranch:returnFlowBranch
annulusOutletJunction HasDownstreamBranch returnFlowBranch
```
This example sets the return flow branch as downstream of a annulus outlet junction.
## HasStartJunction <!-- VERB -->
- Display name: Has Start Junction
- Parent verb: IsHydraulicConnectedTo
- Subject class: HydraulicBranch
- Object class: HydraulicJunction
- Description: Specifies the starting junction of a branch.
- Examples: 
```dwis startJunction
HydraulicBranch:standpipeBranch
HydraulicJunction:pumpDischarge
standpipeBranch HasStartJunction pumpDischarge
```
This example defines the start junction for the standpipe.
## StartsHydraulicBranchDecomposition <!-- VERB -->
- Display name: Starts Hydraulic Branch Decomposition
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Marks the starting point when decomposing a hydraulic branch.
- Examples:
```dwis startBranchDecomp
HydraulicBranch:standpipeBranch
HydraulicBranch:dpInner
standpipeBranch StartsHydraulicBranchDecomposition dpInner
```
This example denotes the start of a branch decomposition.
## IsAComponentOf <!-- VERB -->
- Display name: Is a component of
- Parent verb: DWISVerb
- Subject class: FluidComponent
- Object class: FluidType
- Description: Associate a fluid component with a fluid type.
- Examples:
```dwis IsAComponentOfExample
DrillingLiquidType:mud
SolidComponent:cuttings
cuttings IsAComponentOf mud
```
This example ties cuttings as being a component of a drilling mud.
## ConcernsAFluidComponent <!-- VERB -->
- Display name: Concerns A Fluid Component
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: FluidComponent
- Description: Indicates that a data point relates to a specific fluid component.
- Examples:
```dwis ConcernsAFluidComponentExample
DrillingDataPoint:gasCut
FluidComponent:gasComponent
gasCut ConcernsAFluidComponent gasComponent
```
This example ties gas cut to a gas component.
```dwis CuttingRecoveryRateExample
DynamicDrillingSignal:CleanSightCuttingsRecoveryRate
ComputedData:CleanSightCuttingsRecoveryRate#01
CleanSightCuttingsRecoveryRate#01 BelongsToClass JSonDataType
CleanSightCuttingsRecoveryRate#01 HasDynamicValue CleanSightCuttingsRecoveryRate
CleanSightCuttingsRecoveryRate#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
TopSideTelemetry:topSideTelemetry
CleanSightCuttingsRecoveryRate#01 IsTransmittedBy topSideTelemetry
MovingAverage:movingAverageCleanSightCuttingsRecoveryRate
CleanSightCuttingsRecoveryRate#01 IsTransformationOutput movingAverageCleanSightCuttingsRecoveryRate
CuttingSeparatorLogical:ShaleShakerElement#01
CleanSightCuttingsRecoveryRate#01 IsHydraulicEstimationAt ShaleShakerElement#01
DrillingLiquidType:DrillingFluid#01
DrillingFluid#01 IsFluidTypeLocatedAt ShaleShakerElement#01
CuttingsComponent:Cuttings#01
Cuttings#01 IsAComponentOf DrillingFluid#01
CleanSightCuttingsRecoveryRate#01 ConcernsAFluidComponent Cuttings#01
InstrumentationCompany:DrillDocs#01
CleanSightCuttingsRecoveryRate#01 IsProvidedBy DrillDocs#01
```
This example declares a cuttings recovery rate data point that concerns a cuttings fluid component from a drilling fluid.
## IsUpstreamOf <!-- VERB -->
- Display name: Is Upstream Of
- Parent verb: DWISVerb
- Subject class: FluidType
- Object class: FluidInterface
- Description: Identifies a fluid type located upstream of an interface.
- Examples:
```dwis upstreamFluid
FormationGasType:formationGasType
FluidInterface:gasLiquidInterface
formationGasType IsUpstreamOf gasLiquidInterface
```
This example places formation gas upstream of an interface.
## IsDownstreamOf <!-- VERB -->
- Display name: Is downstream of
- Parent verb: DWISVerb
- Subject class: FluidType
- Object class: FluidInterface
- Description: Identifies a fluid type located downstream of an interface.
- Examples:
```dwis downstreamFluid
DrillingLiquidType:drillingLiquidType
FluidInterface:gasLiquidInterface
drillingLiquidType IsDownstreamOf gasLiquidInterface
```
This example places drilling liquid downstream of an interface.
## IsFluidTypeLocatedAt <!-- VERB -->
- Display name: Is Fluid Type Located At
- Parent verb: DWISVerb
- Subject class: FluidType
- Object class: HydraulicLogicalElement
- Description: Indicates that a fluid type is hydraulically located at a hydraulic logical element.
- Examples:
```dwis IsFluidTypeLocatedAtExample
DrillingLiquidType:drillingLiquidType
ActivePitLogical:ActivePitLogical
drillingLiquidType IsFluidTypeLocatedAt ActivePitLogical
```
This example places drilling liquid at the active pit.
## IsHydraulicConditionFor <!-- VERB -->
- Display name: is Hydraulic Condition For
- Parent verb: DWISVerb
- Subject class: HydraulicCondition
- Object class: HydraulicLogicalElement
- Description: define the hydraulic condition of a hydraulic logical element.
- Examples:
```dwis hydraulicConditionExample
BHAAnnular:bhaAnnulus
HydraulicStaticCondition:static
static IsHydraulicConditionFor bhaAnnulus 
```
This example indicates that the BHA annulus has a static hydraulic condition.
```dwis downholeESDExample
DynamicDrillingSignal:downholeESD
PhysicalData:downholeESD#01
downholeESD#01 BelongsToClass ContinuousDataType
downholeESD#01 HasDynamicValue downholeESD
downholeESD#01 IsOfMeasurableQuantity MassDensityDrilling
Measurement:downholePressure#01
downholePressure#01 BelongsToClass ContinuousDataType
downholePressure#01 IsOfMeasurableQuantity PressureDrilling
MovingAverage:movingAverageDownholePressure
downholePressure#01 IsTransformationOutput movingAverageDownholePressure
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
This example declares a downhole equivalent static density signal with a static hydraulic condition at the BHA annulus.
## HasFlowCurve <!-- VERB -->
- Display name: Has Flow Curve
- Parent verb: DWISVerb
- Subject class: FluidType
- Object class: FlowCurve
- Description: Relate a fluid type to its flow curve.
- Examples:
```dwis HasFlowCurveExample
DrillingLiquidType:mud
FlowCurve:flowCurve
mud HasFlowCurve flowCurve
```
This example states that a drilling liquid has a flow curve.
## IsSourceFlowCurveFor <!-- VERB -->
- Display name: Is Source Flow Curve For
- Parent verb: DWISVerb
- Subject class: FlowCurve
- Object class: RheologicalBehavior
- Description: Relate a flow curve is used to estimate a rheological behavior.
- Examples:
```dwis IsSourceFlowCurveForExample
FlowCurve:flowCurve
RheologicalBehavior:rheologicalBehavior
flowCurve IsSourceFlowCurveFor rheologicalBehavior
```
This example states that a flow curve is used to estimate a rheological behavior.
## HasRheologicalBehavior <!-- VERB -->
- Display name: Has rheological behavior
- Parent verb: DWISVerb
- Subject class: FluidType
- Object class: RheologicalBehavior
- Description: Relate a fluid type to its rheological behavior.
- Examples:
```dwis HasRheologicalBehaviorExample
DrillingLiquidType:drillingLiquidType
RheologicalBehavior:rheologicalBehavior
drillingLiquidType HasRheologicalBehavior rheologicalBehavior
```
This example states that a drilling liquid has a rheological behavior.
## HasComponentRheologicalBehavior <!-- VERB -->
- Display name: Has component rheological behavior
- Parent verb: DWISVerb
- Subject class: FluidComponent
- Object class: RheologicalBehavior
- Description: Relate a fluid component to its rheological behavior.
- Examples:
```dwis HasComponentRheologicalBehaviorExample
LiquidComponent:baseOil
NewtonianFluid:baseOilRheologicalBehavior
baseOil HasComponentRheologicalBehavior baseOilRheologicalBehavior
```
This example states that a liquid component has a rheological behavior.
## IsCalculatedUsingRheologicalHypothesis <!-- VERB -->
- Display name: Is Calculated Using Rheological Hypothesis
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: RheologicalBehavior
- Description: Define that a drilling data point is calculated using a rheological behavior hypothesis.
- Examples:
```dwis IsCalculatedUsingRheologicalHypothesis
NewtonianFluid:newtonianFluid
DrillingDataPoint:shearRateAtTheWallWithNewtonianHypothesis
shearRateAtTheWallWithNewtonianHypothesis IsCalculatedUsingRheologicalHypothesis newtonianFluid
```
This example states that the shear rate at the wall is calculated using a Newtonian rheological behavior hypothesis.
## HasPlasticViscosity <!-- VERB -->
- Display name: Has plastic viscosity
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a plastic viscosity signal with a rheological behavior.
- Examples:
```dwis plasticViscosityExample
BinghamPlastic:binghamPlastic
DrillingDataPoint:PV
binghamPlastic HasPlasticViscosity PV
```
This example states that a Bingham plastic rheological behavior as a plastic viscosity defined by a drilling data point.
```dwis PlasticViscosityInletExample
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
This example declares a plastic viscosity signal at the inlet of the top of string junction associated to a Bingham plastic rheological behavior.
## HasYieldPoint <!-- VERB -->
- Display name: Has yield point
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a yield point signal with a rheological behavior.
- Examples:
```dwis yieldPointExample
BinghamPlastic:binghamPlastic
DrillingDataPoint:YP
binghamPlastic HasYieldPoint YP
```
This example states that a Bingham plastic rheological behavior as a yield point defined by a drilling data point.
## HasPowerLawConsistencyIndex <!-- VERB -->
- Display name: Has Power Law Consistency Index
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a power law consistency index signal with a rheological behavior.
- Examples:
```dwis powerLawConsistencyIndexExample
PowerLaw:powerLaw
DrillingDataPoint:K
powerLaw HasPowerLawConsistencyIndex K
```
This example states that a power law rheological behavior as a consistency index defined by a drilling data point.
## HasYieldPowerLawConsistencyIndex <!-- VERB -->
- Display name: Has Yield Power Law Consistency Index
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a yield power law consistency index signal with a rheological behavior.
- Examples:
```dwis yieldPowerLawConsistencyIndexExample
YieldPowerLaw:yieldPowerLaw
DrillingDataPoint:K
yieldPowerLaw HasYieldPowerLawConsistencyIndex K
```
This example states that a yield power law rheological behavior as a consistency index defined by a drilling data point.
## HasPowerLawFlowBehaviorIndex <!-- VERB -->
- Display name: Has Power Law Flow Behavior Index
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a power law flow behavior index signal with a rheological behavior.
- Examples:
```dwis powerLawFlowBehaviorIndexExample
PowerLaw:powerLaw
DrillingDataPoint:n
powerLaw HasPowerLawFlowBehaviorIndex n
```
This example states that a power law rheological behavior as a flow behavior index defined by a drilling data point.
## HasYieldPowerLawFlowBehaviorIndex <!-- VERB -->
- Display name: Has Yield Power Law Flow Behavior Index
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a yield power law flow behavior index signal with a rheological behavior.
- Examples:
```dwis yieldPowerLawFlowBehaviorIndexExample
YieldPowerLaw:yieldPowerLaw
DrillingDataPoint:n
yieldPowerLaw HasYieldPowerLawFlowBehaviorIndex n
```
This example states that a yield power law rheological behavior as a flow behavior index defined by a drilling data point.
## HasYieldStress <!-- VERB -->
- Display name: Has yield stress
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a yield stress signal with a rheological behavior.
- Examples:
```dwis yieldStressExample
YieldPowerLaw:yieldPowerLaw
DrillingDataPoint:gamma_y
yieldPowerLaw HasYieldStress gamma_y
```
This example states that a yield power law rheological behavior as a yield stress defined by a drilling data point.
## HasQuemadaReferenceShearRate <!-- VERB -->
- Display name: Has Quemada Reference Shear Rate
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a reference shear rate signal with a rheological behavior.
- Examples:
```dwis QuemadaReferenceShearRateExample
Quemada:quemada
DrillingDataPoint:gamma_c
quemada HasQuemadaReferenceShearRate gamma_c
```
This example states that a Quemada rheological behavior as a reference shear rate defined by a drilling data point.
## HasQuemadaViscosityAtZeroShearRate <!-- VERB -->
- Display name: Has Quemada Viscosity at Zero Shear Rate
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a viscosity at shear rate tending to zero to a signal for a rheological behavior.
- Examples:
```dwis HasQuemadaViscosityAtZeroShearRateExample
Quemada:quemada
DrillingDataPoint:etha_0
quemada HasQuemadaViscosityAtZeroShearRate etha_0
```
This example states that a Quemada rheological behavior as a viscosity at zero shear rate defined by a drilling data point.
## HasQuemadaViscosityAtInfiniteShearRate <!-- VERB -->
- Display name: Has Quemada Viscosity at Infinite Shear Rate
- Parent verb: DWISVerb
- Subject class: RheologicalBehavior
- Object class: DrillingDataPoint
- Description: Associate a viscosity at shear rate tending to infinity to a signal for a rheological behavior.
- Examples:
```dwis HasQuemadaViscosityAtInfiniteShearRateExample
Quemada:quemada
DrillingDataPoint:etha_infinity
quemada HasQuemadaViscosityAtInfiniteShearRate etha_infinity
```
This example states that a Quemada rheological behavior as a viscosity at infinite shear rate defined by a drilling data point.
## UsesMeasurementPrinciple <!-- VERB -->
- Display name: Uses Flow Measurement Principle
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: FlowMeasurementPrinciple
- Description: Associate a realtime signal to its measurement principle.
- Examples:
```dwis UsesMeasurementPrincipleExample
DrillingDataPoint:densitySignal
ResonantMeasurementPrinciple:resonantMeasurementPrinciple
densitySignal UsesFlowMeasurementPrinciple resonantMeasurementPrinciple
```
This example states that a mass density signal uses a resonant tube or fork or cantilever measurement principle.
## ControlsMeasurementPrinciple <!-- VERB -->
- Display name: Controls Flow Measurement Principle
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: FlowMeasurementPrinciple
- Description: Associate a realtime signal to its measurement principle.
- Examples:
```dwis ControlsMeasurementPrincipleExample
DrillingDataPoint:rotationalSpeedSignal
ConcentricCylindersMeasurementPrinciple:concentricCylindersMeasurementPrinciple
rotationalSpeedSignal ControlsFlowMeasurementPrinciple concentricCylindersMeasurementPrinciple
```
This example states that a mass density signal uses a resonant tube or fork or cantilever measurement principle.
