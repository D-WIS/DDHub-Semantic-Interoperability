
- [Data structure](#data-structure)
  - [Generalities](#generalities)
    - [Data shape](#data-shape)
    - [Signal mapping](#signal-mapping)
    - [Combined representations](#combined-representations)
- [Quantities and units](#quantities-and-units)
  - [Base quantities](#base-quantities)
  - [Observable quantities](#observable-quantities)
  - [Units and unit systems](#units-and-unit-systems)
- [Uncertainties](#uncertainties)
- [Data validity](#data-validity)
- [Time management](#time-management)
  - [Refresh rates](#refresh-rates)
  - [Clocks](#clocks)
  - [Delays](#delays)
  - [Synchronization](#synchronization)
- [Data processing](#data-processing)
  - [Downhole ECD](#downhole-ecd)
  - [Positions and velocities](#positions-and-velocities)
  - [Simulations](#simulations)
  - [Control and automation](#control-and-automation)
    - [Mud pumps:](#mud-pumps)
    - [FDIR](#fdir)
- [Dependencies](#dependencies)
- [Physical Position](#physical-position)
- [Logical positions](#logical-positions)


The vocabulary will be introduced by informal examples, all of the form `Subject Verb Object`. The verbs and objects in the examples are all to be considered as **instances**, and not class definitions. In these sentences, all instances are uniquely identified by some display name. 


# Data structure

## Generalities

### Data shape

Real-time signals can in all generality be dsecribed by their *shape* (inspired from Python, TensorFlow...). A shape in a sequence of integers $(j_1, \dots, j_n)$, such that:
- $n$ is the number of indices necessary to specify the data. It is the dimension of the multi-index $I = [i_1, \dots, i_k]$ 
- the index$i_k$, $1\leq k \leq n$, takes value between $0$ and $j_k -1$. 

We call:
- *axis* the array $[\alpha_1, \dots , \alpha_{j_k}]$,
- *rank* the number $n$, i.e. the number of axis,
- *dimension* of the $k$-th axis the number $j_k$.

Those considerations should enable the representation of most signals, as stored in a real-time server:
- a scalar has by convention the empty shape $()$,
```
s = 3.1415926
shape(s) = ()
rank(s) = 0
```
- a one-dimensional vector with $k$ elements has shape $(k)$. 
```
v = [1.0, 2.0, 3.0, 4.0]
shape(v) = (4)
rank(v) = 1
v[2] = 3.0
```
- a $m\times n$ matrix has shape $(m,n)$
```
v = [[1.0, 2.0, 3.0, 4.0], [2.0, 4.0, 6.0, 8.0], [3.0, 6.0, 9.0, 12.0]]
shape(v) = (3,4)
rank(v) = 2
v[2] = [3.0, 6.0, 9.0, 12.0]
v[2,1] = 6.0
```
 Note that in the latter example, jagged arrays are used. We should also find a way to distinguish and represent jagged arrays and multi-dimensional arrays (where the difference in typically in the access `v[i,j]` vs `v[i][j]`).

### Signal mapping

 However, additional information is necessary to provide enough useful meaning to the data. Mathematically speaking, a signal can be seen as a map

$$t\times D \rightarrow R$$


where $t$ denotes the time, $D$ and $R$ the domain and range of the signal. For example:
 - a single three-dimensional velocity vector has domain $D = \empty$ and range $R = \R^3$. 
 - alternatively, seeing the three-dimensional velocity vector as three independent velocity values, one gets $D = \R^3$ and $R = \R$. 
 - a computed profile of drill-string center displacements would have domain $D = \R$ and range $\R^3$: the domain corresponds to the linear abscissa of the considered point and the range to the coordinates of the displacement in a Serret-Frenet frame centered at that point. 
 - a table of predicted hookloads, as function of the block velocity, the flow-rate and the top-drive RPM will have domain $D = \R^3$ and range $R = \R$. 
 - a simplified table of predicted hookloads, function of the block velocity, the flow-rate and a boolean indicating whether there is rotation or not would have domain $D = \R^2 \times \{0,1\}$ and range $R = \R$. 
 - a single pressure (SPP for example) has domain $D = \empty$ and range $R= \R$
 - a series of along-string pressure measurements has domain $D = \R$ and range  $R= \R$
 - a base-oil PVT table has domain $D= \R^2$ (pressure and temperature) and range $R = \R$ (the mass density)

### Combined representations

Both the signal mapping and data shapes approach are important. The data shape describes the structure of the signal as stored on a real-time data server. The signal mapping describes the meaning of the data itself. In the DDHub context, it is then important to associate the two views, since we want to associate meaning to copmuter stored signals. 

One may encounter (at least) two situations:
- the signal contains the domain information. This is the case in the following cases
  - data sets: in data science context, where one manipulates "self-contained" data sets, the domain information is represented. Typically, a data sets is made of several columns where the first ones contain the domain data and the latter ones the range data. Then the objective is to perform regression or classification of the range data against the domain one. In this context, one wants to specify that the domain is described by some of the axes of the global shape.
  - computed profiles: when using numerical models to evaluate the state of the drilling process, it is common to manipulate and publish profiles, such as the pressure profile in the annular. For example, a pressure profile is nothing more than a series of points (pressures, the range data) associated to a series of measured depth (the domain). Due to the dynamic nature of the computations, the measured depths are often themselves dynamic and stored as real-time signals, and both pressures and depths are usually stored together. The following structure are commonly encountered:
```
. [[0, 101325], [30, 102325], ... , [1984, 201325]] // the signal is an array of smaller arrays containing (domain, range) data
. [[0, 30, ... , 1984], [101325, 102325, ... , 201325]] // the signal is an array made of two arrays: a domain array and a range array
```


To treat:
- simple hookload, SPP
- hookload tables (safety triggers)
- rheology (different representations)
- 3-dimensional velocities, accelerations
- ASM 3-dimensional data
- ASM pressures
- computed profiles
- PVT tables

# Quantities and units

The following shows the main concepts illustrated via a pressure example.

## Base quantities

```
PressureQuantity HasMassExponent 1
PressureQuantity HasLengthExponent -1
PressureQuantity HasTimeExponent -2
```

## Observable quantities
```
PumpPressureQuantity HasBaseQuantity PressureQuantity
PumpPressureQuantity HasMeaningFulPrecision 1000

FormationStrengthQuantity HasBaseQuantity PressureQuantity
FormationStrengthQuantity HasMeaningFulPrecision 100000
```

## Units and unit systems

```
PressureQuantity HasSIUnit Pascal
Pascal HasLabel Pa
Pascal HasConversionFactorA 1
Pascal HasConversionFactorB 0

PressureQuantity HasUnit Bar
Bar HasLabel b
Bar HasConversionFactorA 1e-5
Bar HasConversionFactorB 0

PressureQuantity HasUnit MegaPascal
MegaPascal HasLabel MPa
MegaPascal HasConversionFactorA 1e-6
MegaPascal HasConversionFactorB 0

MetricUnitSystem HasUnitAssociation PumpPressureAssociation
PumpPressureAssociation HasObservableQuantity PumpPressureQuantity
PumpPressureAssociation HasUnit Bar

MetricUnitSystem HasUnitAssociation FormationStrengthAssociation
FormationStrengthAssociation HasObservableQuantity FormationStrengthQuantity
FormationStrengthAssociation HasUnit MegaPascal

PumpPressure HasObservableQuantity PumpPressureQuantity
EstimatedUCS HasObservableQuantity FormationStrengthQuantity
```



# Uncertainties

# Data validity

# Time management

## Refresh rates

## Clocks

## Delays

## Synchronization

# Data processing

Show the different types of procesing that can be involved in classical drilling data. 
As some processing requires parametrization, it is simpler to treat each processing step as a entity in the graph. The general structure then applies

```
Signal1 IsProcessingOutputOf ProcessingUnit
ProcessingUnit HasInput Signal2
```

When treating classical signal processing functions, this approach implies to represent signals whose values are not available on the rig: `LowFrequencySignal IsResampledBy ResamplingUnit` coupled with `ResamplingUnit HasInput HighFrequencySignal` and `HighFrequencySignal IsMeasuredBy Sensor1`. In that case, the `HighFrequencySignal` is not made available. Those three sentences can therefore be condensed into 

```
LowFrequencySignal IsResampledBy ResamplingUnit
ResamplingUnit IsMeasuredBy Sensor1
```


## Downhole ECD
```
DownholeECD IsConvertedBy PressureToDensityConversion
PressureToDensityConversion HasPressureInput DownholePressure
PressureToDensityConversion HasElevationInput PWDTVD

DownholePressure IsTimeAveragedBy DownholePressureAveraging
DownholePressureAveraging HasInput HighFrequencyDownholePressure
DownholePressureAveraging HasTimeWindow 30

HighFrequencyDownholePressure IsMeasuredBy PWD
```

## Positions and velocities

```
BlockVelocity IsDerivedBy BlockDerivation
BlockDerivation HasTimeInterval 1
BlockDerivation HasInput BlockPosition

BitDepth IsTranslatedBy BitDepthTranslation
BitDepthTranslation HasTranslationAmplitude CurrentStringLength
BitDepthTranslation HasInput TopOfStringPosition

TopOfStringPosition IsProcessingOutputOf TOSPosCalculation
TOSPosCalculation HasInput BlockPosition
TOSPosCalculation HasInput StringConnected

HoleDepth IsMaximumBy HoleDepthComputation
HoleDepthComputation HasInput InitialHoleDepth
HoleDepthComputation HasInput HoleDepth
HoleDepthComputation HasInput BitDepth

InstantaneousROP1 IsDerivedBy InstROPDerivation
InstROPDerivation HasTimeInterval .5
InstROPDerivation HasInput HoleDepth

InstantaneousROP2 IsDuplicatedFrom BlockVelocity

AverageROP IsDerivedBy AvROPDerivation
```

## Simulations

```
Hookload1 IsCalculatedBy HooklaodFDIRCalculation
```

## Control and automation

### Mud pumps:
```
MP1RateCommand IsCommandFrom MP1Controller
MP1Controller HasInput MP1SetPoint

MP2RateCommand IsCommandFrom MP2Controller
MP2Controller HasInput MP2SetPoint

MP1SetPoint IsSetPointFrom MPControlSystem
MP2SetPoint IsSetPointFrom MPControlSystem
MPControlSystem HasInput MPSetPoint

MPSetPoint IsProcessingOutputOf DSCControlPanel
```

### FDIR
```
Hookload1 IsFDIRMaxThresholdFor HookLoadFDIR
Hookload1 IsValidWhen SteadyHookloadValidityCondition
Hookload1 IsValidWhen OffBottomValidityCondition
Hookload1 IsValidWhen StringConnectedValidityCondition

HookLoadFDIR HasControlVariable Hookload
```

# Dependencies

```
ContinuousDensity HasTemperatureDependence ContinuousTemperature
ContinuousDensity HasPressureDependence AtmosphericPressure
AtmosphericPressure HasConstantValue 101325
```

# Physical Position

In the following we work with *Locations*: a combination of coordinates and reference frame. One could consider more abstract locations, where several of those combinations are possible. This would facilitate the comparisons between two locations (there is only one location for the bit, but in the 1D curvilinear frame starting from the drill-floor it has coordinates *BitDepth* while in the frame starting from the block it has coordinates *BitDepth + BlockPosition*). 

```
PWD IsPhysicallyLocatedAt PWDLocation
PWDLocation HasCoordinates PWDDistanceToBit
PWDDistanceToBit HasStaticValue 15
PWDLocation HasReferenceFrame BitCurviLinearReferenceFrame

BitCurviLinearReferenceFrame HasOrigin BitLocation

BitLocation HasCoordinates BitDepth
BitLocation HasReferenceFrame DrillFloorCurviLinearReferenceFrame
DrillFloorCurviLinearReferenceFrame HasOrigin DrillFloorLocation
```

# Logical positions