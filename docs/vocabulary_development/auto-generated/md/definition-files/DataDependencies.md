# DataDependencies<!-- DEFINITION SET HEADER -->
- Description: 
this definition set covers the physical dependence of a `DrillingDatPoint` on something else.

# Nouns
# Verbs
## Class Inheritance for Verbs
Here is a class inheritance diagram for the verbs contained in this definition set.
```mermaid
classDiagram
DWISVerb <|-- IsDependentOn
IsDependentOn <|-- HasPressureReference
IsDependentOn <|-- HasTemperatureReference
IsDependentOn <|-- HasElevationReference
```
## Relations
Here is a graph representing the relations that can be made with the verbs defined in this definition set.
```mermaid
erDiagram
DrillingDataPoint ||--o{ DWISNoun : IsDependentOn
DrillingDataPoint ||--o{ DrillingDataPoint : HasPressureReference
DrillingDataPoint ||--o{ DrillingDataPoint : HasTemperatureReference
DrillingDataPoint ||--o{ Location : HasElevationReference
```
## IsDependentOn <!-- VERB -->
- Display name: IsDependentOn
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Definition set: DataDependencies
- Description: 
This verb is used to describe a general dependence relationship between a `DrillingDataPoint` and something else.
- Examples:
```ddhub DerrickFloorElevation HeaveElevation TideElevation
DerickFloorVerticalLocation:DerrickFloor
DerivedMeasurement:DerrickFloorElevation
Measurement:HeaveElevation
Measurement:TideElevation
DerrickFloorElevation IsOfMeasurableQuantity AxialPosition
DerrickFloorElevation IsPhysicallyLocatedAt DerrickFloor
HeaveElevation IsOfMeasurableQuantity AxialPosition
TideElevation IsOfMeasurableQuantity AxialPosition
DerrickFloorElevation IsDependentOn HeaveElevation
DerrickFloorElevation IsDependentOn TideElevation
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[DerrickFloor] -->|BelongsTo| N0001[DerickFloorVerticalLocation] 
	N0002[DerrickFloorElevation] -->|BelongsTo| N0003[DerivedMeasurement] 
	N0004[HeaveElevation] -->|BelongsTo| N0005[Measurement] 
	N0006[TideElevation] -->|BelongsTo| N0005[Measurement] 
	N0002[DerrickFloorElevation] -->|IsOfMeasurableQuantity| N0007[AxialPosition] 
	N0002[DerrickFloorElevation] -->|IsPhysicallyLocatedAt| N0000[DerrickFloor] 
	N0004[HeaveElevation] -->|IsOfMeasurableQuantity| N0007[AxialPosition] 
	N0006[TideElevation] -->|IsOfMeasurableQuantity| N0007[AxialPosition] 
	N0002[DerrickFloorElevation] -->|IsDependentOn| N0004[HeaveElevation] 
	N0002[DerrickFloorElevation] -->|IsDependentOn| N0006[TideElevation] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?DerrickFloorElevation, ?HeaveElevation, ?TideElevation
WHERE {
	?DerrickFloor rdf:type ddhub:DerickFloorVerticalLocation .
	?DerrickFloorElevation rdf:type ddhub:DerivedMeasurement .
	?HeaveElevation rdf:type ddhub:Measurement .
	?TideElevation rdf:type ddhub:Measurement .
	?DerrickFloorElevation ddhub:IsOfMeasurableQuantity ?AxialPosition .
	?DerrickFloorElevation ddhub:IsPhysicallyLocatedAt ?DerrickFloor .
	?HeaveElevation ddhub:IsOfMeasurableQuantity ?AxialPosition .
	?TideElevation ddhub:IsOfMeasurableQuantity ?AxialPosition .
	?DerrickFloorElevation ddhub:IsDependentOn ?HeaveElevation .
	?DerrickFloorElevation ddhub:IsDependentOn ?TideElevation .
}
```
In this example, it is described that the derrick floor elevation, `DerrickFloorElevation`, 
depends on the heave measurement, `HeaveElevation`, and the tide measurement, `TideElevation`.
## HasPressureReference <!-- VERB -->
- Display name: HasPressureReference
- Parent verb: [IsDependentOn](./DataDependencies.md#IsDependentOn)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Definition set: DataDependencies
- Description: 
This verb is a specialization of `IsDependentOn` and refers to the specific dependence on a pressure reference.
- Examples:
```ddhub MeasuredDrillingFluidDensity MeasuredTemperature MeasuredPressure
Measurement:MeasuredDrillingFluidDensity
Measurement:MeasuredTemperature
Measurement:MeasuredPressure
MeasuredDrillingFluidDensity IsOfMeasurableQuantity DrillingDensity
MeasuredTemperature IsOfMeasurableQuantity DrillingTemperature
MeasuredPressure IsOfMeasurableQuantity DrillingPressure
MeasuredDrillingFluidDensity HasTemperatureReference MeasuredTemperature
MeasuredDrillingFluidDensity HasPressureReference MeasuredPressure
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[MeasuredDrillingFluidDensity] -->|BelongsTo| N0001[Measurement] 
	N0002[MeasuredTemperature] -->|BelongsTo| N0001[Measurement] 
	N0003[MeasuredPressure] -->|BelongsTo| N0001[Measurement] 
	N0000[MeasuredDrillingFluidDensity] -->|IsOfMeasurableQuantity| N0004[DrillingDensity] 
	N0002[MeasuredTemperature] -->|IsOfMeasurableQuantity| N0005[DrillingTemperature] 
	N0003[MeasuredPressure] -->|IsOfMeasurableQuantity| N0006[DrillingPressure] 
	N0000[MeasuredDrillingFluidDensity] -->|HasTemperatureReference| N0002[MeasuredTemperature] 
	N0000[MeasuredDrillingFluidDensity] -->|HasPressureReference| N0003[MeasuredPressure] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?MeasuredDrillingFluidDensity, ?MeasuredTemperature, ?MeasuredPressure
WHERE {
	?MeasuredDrillingFluidDensity rdf:type ddhub:Measurement .
	?MeasuredTemperature rdf:type ddhub:Measurement .
	?MeasuredPressure rdf:type ddhub:Measurement .
	?MeasuredDrillingFluidDensity ddhub:IsOfMeasurableQuantity ?DrillingDensity .
	?MeasuredTemperature ddhub:IsOfMeasurableQuantity ?DrillingTemperature .
	?MeasuredPressure ddhub:IsOfMeasurableQuantity ?DrillingPressure .
	?MeasuredDrillingFluidDensity ddhub:HasTemperatureReference ?MeasuredTemperature .
	?MeasuredDrillingFluidDensity ddhub:HasPressureReference ?MeasuredPressure .
}
```
In this example, it is described that `MeasuredDrillingFluidDensity`, which is a measurement of the measurable quantity
`DrillingDensity` has a dependence on pressure and temperature, and that the associated measured pressure can be found
at `MeasuredPressure`.
## HasTemperatureReference <!-- VERB -->
- Display name: HasTemperatureReference
- Parent verb: [IsDependentOn](./DataDependencies.md#IsDependentOn)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Definition set: DataDependencies
- Description: 
This verb is a specialization of `IsDependentOn` and refers to the specific dependence on a temperature reference.
- Examples:
```ddhub MeasuredDrillingFluidDensity MeasuredTemperature MeasuredPressure
Measurement:MeasuredDrillingFluidDensity
Measurement:MeasuredTemperature
Measurement:MeasuredPressure
MeasuredDrillingFluidDensity IsOfMeasurableQuantity DrillingDensity
MeasuredTemperature IsOfMeasurableQuantity DrillingTemperature
MeasuredPressure IsOfMeasurableQuantity DrillingPressure
MeasuredDrillingFluidDensity HasTemperatureReference MeasuredTemperature
MeasuredDrillingFluidDensity HasPressureReference MeasuredPressure
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[MeasuredDrillingFluidDensity] -->|BelongsTo| N0001[Measurement] 
	N0002[MeasuredTemperature] -->|BelongsTo| N0001[Measurement] 
	N0003[MeasuredPressure] -->|BelongsTo| N0001[Measurement] 
	N0000[MeasuredDrillingFluidDensity] -->|IsOfMeasurableQuantity| N0004[DrillingDensity] 
	N0002[MeasuredTemperature] -->|IsOfMeasurableQuantity| N0005[DrillingTemperature] 
	N0003[MeasuredPressure] -->|IsOfMeasurableQuantity| N0006[DrillingPressure] 
	N0000[MeasuredDrillingFluidDensity] -->|HasTemperatureReference| N0002[MeasuredTemperature] 
	N0000[MeasuredDrillingFluidDensity] -->|HasPressureReference| N0003[MeasuredPressure] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?MeasuredDrillingFluidDensity, ?MeasuredTemperature, ?MeasuredPressure
WHERE {
	?MeasuredDrillingFluidDensity rdf:type ddhub:Measurement .
	?MeasuredTemperature rdf:type ddhub:Measurement .
	?MeasuredPressure rdf:type ddhub:Measurement .
	?MeasuredDrillingFluidDensity ddhub:IsOfMeasurableQuantity ?DrillingDensity .
	?MeasuredTemperature ddhub:IsOfMeasurableQuantity ?DrillingTemperature .
	?MeasuredPressure ddhub:IsOfMeasurableQuantity ?DrillingPressure .
	?MeasuredDrillingFluidDensity ddhub:HasTemperatureReference ?MeasuredTemperature .
	?MeasuredDrillingFluidDensity ddhub:HasPressureReference ?MeasuredPressure .
}
```
In this example, it is described that `MeasuredDrillingFluidDensity`, which is a measurement of the measurable quantity
`DrillingDensity` has a dependence on pressure and temperature, and that the associated measured temperaure can be found
at `MeasuredTemperature`.
## HasElevationReference <!-- VERB -->
- Display name: HasElevationReference
- Parent verb: [IsDependentOn](./DataDependencies.md#IsDependentOn)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [Location](./PhysicalLocation.md#Location)
- Definition set: DataDependencies
- Description: 
This verb is a specialization of `IsDependentOn` and refers to the specific dependence on an elevation reference.
- Examples:
```ddhub MeasuredStandPipePressure DerrickFloorElevation HeaveElevation TideElevation
Measurement:MeasuredStandPipePressure
DerickFloorVerticalLocation:DerrickFloor
DerivedMeasurement:DerrickFloorElevation
Measurement:HeaveElevation
Measurement:TideElevation
StandPipe:StandPipeElement
MechanicalLogicalElement:LogicalRepresentationStandPipe
MeasuredStandPipePressure HasElevationReference DerrickFloor
LogicalRepresentationStandPipe IsAMechanicalRepresentationFor StandPipeElement
MeasuredStandPipePressure IsMechanicallyLocatedAt LogicalRepresentationStandPipe
MeasuredStandPipePressure IsOfMeasurableQuantity DrillingPressure
DerrickFloorElevation IsOfMeasurableQuantity AxialPosition
DerrickFloorElevation IsPhysicallyLocatedAt DerrickFloor
HeaveElevation IsOfMeasurableQuantity AxialPosition
TideElevation IsOfMeasurableQuantity AxialPosition
WGS84VerticalLocation:VerticalDatum
HeaveElevation HasElevationReference VerticalDatum
TideElevation HasElevationReference VerticalDatum
DerrickFloorElevation IsDependentOn HeaveElevation
DerrickFloorElevation IsDependentOn TideElevation
```
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[MeasuredStandPipePressure] -->|BelongsTo| N0001[Measurement] 
	N0002[DerrickFloor] -->|BelongsTo| N0003[DerickFloorVerticalLocation] 
	N0004[DerrickFloorElevation] -->|BelongsTo| N0005[DerivedMeasurement] 
	N0006[HeaveElevation] -->|BelongsTo| N0001[Measurement] 
	N0007[TideElevation] -->|BelongsTo| N0001[Measurement] 
	N0008[StandPipeElement] -->|BelongsTo| N0009[StandPipe] 
	N0010[LogicalRepresentationStandPipe] -->|BelongsTo| N0011[MechanicalLogicalElement] 
	N0000[MeasuredStandPipePressure] -->|HasElevationReference| N0002[DerrickFloor] 
	N0010[LogicalRepresentationStandPipe] -->|IsAMechanicalRepresentationFor| N0008[StandPipeElement] 
	N0000[MeasuredStandPipePressure] -->|IsMechanicallyLocatedAt| N0010[LogicalRepresentationStandPipe] 
	N0000[MeasuredStandPipePressure] -->|IsOfMeasurableQuantity| N0012[DrillingPressure] 
	N0004[DerrickFloorElevation] -->|IsOfMeasurableQuantity| N0013[AxialPosition] 
	N0004[DerrickFloorElevation] -->|IsPhysicallyLocatedAt| N0002[DerrickFloor] 
	N0006[HeaveElevation] -->|IsOfMeasurableQuantity| N0013[AxialPosition] 
	N0007[TideElevation] -->|IsOfMeasurableQuantity| N0013[AxialPosition] 
	N0014[VerticalDatum] -->|BelongsTo| N0015[WGS84VerticalLocation] 
	N0006[HeaveElevation] -->|HasElevationReference| N0014[VerticalDatum] 
	N0007[TideElevation] -->|HasElevationReference| N0014[VerticalDatum] 
	N0004[DerrickFloorElevation] -->|IsDependentOn| N0006[HeaveElevation] 
	N0004[DerrickFloorElevation] -->|IsDependentOn| N0007[TideElevation] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?MeasuredStandPipePressure, ?DerrickFloorElevation, ?HeaveElevation, ?TideElevation
WHERE {
	?MeasuredStandPipePressure rdf:type ddhub:Measurement .
	?DerrickFloor rdf:type ddhub:DerickFloorVerticalLocation .
	?DerrickFloorElevation rdf:type ddhub:DerivedMeasurement .
	?HeaveElevation rdf:type ddhub:Measurement .
	?TideElevation rdf:type ddhub:Measurement .
	?StandPipeElement rdf:type ddhub:StandPipe .
	?LogicalRepresentationStandPipe rdf:type ddhub:MechanicalLogicalElement .
	?MeasuredStandPipePressure ddhub:HasElevationReference ?DerrickFloor .
	?LogicalRepresentationStandPipe ddhub:IsAMechanicalRepresentationFor ?StandPipeElement .
	?MeasuredStandPipePressure ddhub:IsMechanicallyLocatedAt ?LogicalRepresentationStandPipe .
	?MeasuredStandPipePressure ddhub:IsOfMeasurableQuantity ?DrillingPressure .
	?DerrickFloorElevation ddhub:IsOfMeasurableQuantity ?AxialPosition .
	?DerrickFloorElevation ddhub:IsPhysicallyLocatedAt ?DerrickFloor .
	?HeaveElevation ddhub:IsOfMeasurableQuantity ?AxialPosition .
	?TideElevation ddhub:IsOfMeasurableQuantity ?AxialPosition .
	?VerticalDatum rdf:type ddhub:WGS84VerticalLocation .
	?HeaveElevation ddhub:HasElevationReference ?VerticalDatum .
	?TideElevation ddhub:HasElevationReference ?VerticalDatum .
	?DerrickFloorElevation ddhub:IsDependentOn ?HeaveElevation .
	?DerrickFloorElevation ddhub:IsDependentOn ?TideElevation .
}
```
In this example, it is described that the standpipe pressure measurement, `MeasuredStandPipePressure`, depends on
the derrick floor elevation, `DerrickFloor`, elevation and that the derrick floor elevation depends on the heave
elevation and on the tide elevation, which in turn have an elevation reference compared to the vertical datum, which
here is WGS84.
