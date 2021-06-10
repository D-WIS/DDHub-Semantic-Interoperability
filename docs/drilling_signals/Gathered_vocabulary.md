
![DDHub](../img/ddhubLogo.png)

- [Data structure](#data-structure)
  - [Generalities](#generalities)
    - [Data shape](#data-shape)
    - [Signal mapping](#signal-mapping)
    - [Combined representations](#combined-representations)
  - [Examples](#examples)
    - [Standard scalars measurements](#standard-scalars-measurements)
    - [Hookload tables](#hookload-tables)
    - [Downhole pressures](#downhole-pressures)
    - [Calculated lateral displacements](#calculated-lateral-displacements)
    - [Continuous rheology](#continuous-rheology)
- [Addressing](#addressing)
- [Quantities and units](#quantities-and-units)
  - [Base quantities](#base-quantities)
  - [Observable quantities](#observable-quantities)
  - [Units and unit systems](#units-and-unit-systems)
- [Uncertainties](#uncertainties)
- [Data validity](#data-validity)
- [Time management](#time-management)
  - [Time stamps](#time-stamps)
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

> Remark: This document contains mathematical symbols. Standard Latex syntax is used. Unfortunately, GitHub does not render such symbols, they just appear as plain text. Better results are achieved by using Visual Studio Code for editing the .md files. The preview window correctly displays mathematical symbols and equations. 


# Data structure

## Generalities

### Data shape

Real-time signals can in all generality be described by their *shape* (inspired from Python, TensorFlow...). A shape in a sequence of integers $(j_1, \dots, j_n)$, such that:
- $n$ is the number of indices necessary to specify the data. It is the dimension of the multi-index $I = [i_1, \dots, i_k]$ 
- the index $i_k$, $1\leq k \leq n$, takes value between $0$ and $j_k -1$. 

We call:
- *axis* the array $[\alpha_1, \dots , \alpha_{j_k}]$,
- *rank* the number $n$, i.e. the number of axis,
- *dimension* of the $k$-th axis the number $j_k$.

Those considerations should enable the representation of most signals, as stored in a real-time server:
- a scalar has by convention the empty shape $()$,
```
s = 2.71828
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

$$T\times D \rightarrow R$$


where $T$ denotes the time "set", $D$ and $R$ the domain and range of the signal. For example:
 - a single three-dimensional velocity vector has domain $D = \empty$ and range $R = \R^3$. 
 - alternatively, seeing the three-dimensional velocity vector as three independent velocity values, one gets $D = \R^3$ and $R = \R$. 
 - a computed profile of drill-string center displacements would have domain $D = \R$ and range $\R^3$: the domain corresponds to the linear abscissa of the considered point and the range to the coordinates of the displacement in a Serret-Frenet frame centered at that point. 
 - a table of predicted hookloads, as function of the block velocity, the flow-rate and the top-drive RPM will have domain $D = \R^3$ and range $R = \R$. 
 - a simplified table of predicted hookloads, function of the block velocity, the flow-rate and a boolean indicating whether there is rotation or not would have domain $D = \R^2 \times \{0,1\}$ and range $R = \R$. 
 - an incident status table, function of flow-rate, top-drive RPM and block velocity, containing the estimated status of the wellbore with respect to some incident (such as exceeding fracturing pressure). The domain would be $D = \R^3$ while the range would be $R = \{0,1\}$. 
 - a single pressure (SPP for example) has domain $D = \empty$ and range $R= \R$
 - a series of along-string pressure measurements has domain $D = \R$ and range  $R= \R$
 - a base-oil PVT table has domain $D= \R^2$ (pressure and temperature) and range $R = \R$ (the mass density)
 - an estimated lithology profile, associating to each depth a lithology type. The domain would be $D = \R$ and the range an enumeration of $L$ lithologies, mathematically expressed as $R = \{1, \dots, L\}$. 

### Combined representations

Both the signal mapping and data shapes approach are important. The data shape describes the structure of the signal as stored on a real-time data server. The signal mapping describes the meaning of the data itself. In the DDHub context, it is then important to associate the two views, since we want to associate meaning to copmuter stored signals. 

One may encounter (at least) two situations:
1. the signal contains the domain information. This occurs in the following cases
   - data sets: in data science context, where one manipulates "self-contained" data sets, the domain information is represented. Typically, a data sets is made of several columns where the first ones contain the domain data and the latter ones the range data. Then the objective is to perform regression or classification of the range data against the domain one. In this context, one wants to specify that the domain is described by some of the axes of the global shape.
   - burst data: high frequency downhole signals are sometimes transmitted to the surface during the operations. However, they are often transmitted in packets containing a full interval of data. In that case, the transmitted data is multidimensional, where the first axis contains the date at which the measurement has been taken. The domain is therefore contained in the data itself. The same holds for retrieved WitsML logs. 
   - computed profiles: when using numerical models to evaluate the state of the drilling process, it is common to manipulate and publish profiles, such as the pressure profile in the annular. For example, a pressure profile is nothing more than a series of points (pressures, the range data) associated to a series of measured depth (the domain). Due to the dynamic nature of the computations, the measured depths are often themselves dynamic and stored as real-time signals, and both pressures and depths are usually stored together. The following structure are commonly encountered:
```
// the signal is an array of smaller arrays containing (domain, range) data
 [[0, 101325], [30, 102325], ... , [1984, 201325]] 

// the signal is an array made of two arrays: a domain array and a range array
 [[0, 30, ... , 1984], [101325, 102325, ... , 201325]] 
```
2. the signal only contains the range data. This is the most common case. For data stored as scalar values, this goes without saying. However, one can differentiate two sub-cases
   - The domain data is static, and not stored as a real-time signal. 
     - this will be the case for a series of continuous rheology mesurement for example. The measurement is stored as an array of shear stresses. The corresponding shear rates are pre-defined and not available as real-time signals. 
   - The domain is dynamic, but represented in another signal:
     - expected hookloads as a function of block velocity, rpm and flow-rate: the stored data only contains the 3-dimensional table. The values defining the corresponding flow-rates, rpms and velocities are dynamic, stored in arrays in the real-time server. In this situation, the link between the 3-dimensional table and the three axis arrays is a link between drilling datas. 
     - continuous rheology measurement made at unusual and dynamic shear rates. Then, one can imagine that the stress and rates arrays are stored as two separate items. The rate array can be interpreted as the domain of the stress array. 

## Examples

### Standard scalars measurements
```
Hookload HasShape ()
SPP HasShape ()
```

### Hookload tables

```
Hookloadtable HasShape (10,8,5)

HookloadTable HasExternalDomainAxis BlockVelocityDomainAxis
BlockVelocityDomainAxis HasIndex 0
BlockVelocityDomainAxis HasAxisData BlockVelocities
BlockVelocities HasShape (10)

HookloadTable HasExternalDomainAxis TopDriveRPMDomainAxis
TopDriveRPMDomainAxis HasIndex 1
TopDriveRPMDomainAxis HasAxisData TopDriveRPMs
TopDriveRPMs HasShape (8)

HookloadTable HasExternalDomainAxis FlowRatesDomainAxis
FlowRatesDomainAxis HasIndex 2
FlowRatesDomainAxis HasAxisData FlowRates
FlowRates HasShape (5)
```

### Downhole pressures
```
// standard
DownholePressure1 HasShape ()

// ASM
DownholePressure2 HasShape (10)
DownholePressure2 HasExternalDomainAxis DistancesToBit
DistancesToBit HasShape (10)

// Calculated profile1  
//    [[0, 30, ... , 1984], [101325, 102325, ... , 201325]] 
//    depth[i] = p[0,i]
CalculatedPressures1 HasShape (2,100)
CalculatedPressures1 HasInternalDomainAxis DepthAxis1
DepthAxis1 HasIndexLocation 0
DepthAxis1 HasIndex 0 //write index 0 at location 0 to access the depth

//Calculated profile2
//    [[0, 101325], [30, 102325], ... , [1984, 201325]] 
//    depth[i] = p[i,0] 
CalculatedPressures2 HasShape (100, 2)
CalculatedPressures2 HasInternalDomainAxis DepthAxis2
DepthAxis2 HasIndexLocation 1
DepthAxis2 HasIndex 0 //write index 0 at index location 1 to access the depth
```

### Calculated lateral displacements
```
Displacements HasShape(1000, 3) //a row in the table is Displacements[i]  = [depth, polar angle, radial distance]
Displacements HasInternalDomainAxis DepthAxis1
DepthAxis1 HasIndexLocation 1
DepthAxis1 HasIndex 0 //Displacements[i,0] = depth[i]
```

### Continuous rheology
```
//Predefined shear rates, each reading stored in separate signal
ContinuousRheology1_3 HasShape ()
ContinuousRheology1_6 HasShape ()
...
ContinuousRheology1_600 HasShape ()

//Predefined shear rates, all reading stored in single array
ContinuousRheology2 HasShape (6)
ContinuousRheology2 HasExternalDomainAxis ShearRates
ShearRates HasShape (6) // ShearRates = [3, 6, 30, 60, 300, 600]

//rates are stored in the same signal
ContinuousRheology3 HasShape (6,2)
ContinuousRheology3 HasInternalDomainAxis ShearRateAxis
ShearRateAxis HasIndexLocation 1
ShearRateAxis HasIndex 0 
```

# Addressing

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

## Time stamps

Several time-stamps can be of importance to describe signals. Among them are:
- the **acquisition** time-stamp: when the signal was written to the real-time server
- the **generation** time-stamp: when the signal was generated by its source (in case of several sequential processing boxes, one can it theory associate such a time stamp to any box)
- the **process** time-stamp: the time corresponding to the physical meaning of the signal. This is not always properly defined: it is difficult to assign an unambiguous process time-stamp to a moving average for example. 

Of course, those three time-stamp can differ. Consider the following scenario:
1. a measure *m* is taken (*Processing time stamp =  P*) 
2. filtering and buffering entail a 10ms delay before the signal is generated by the downhole tool (*Generation time stamp = P + 10ms*) 
3. data transmission: it takes additional 2s to transmit the signal up tot he real-time server (*Acquisition time stamp = P + 2.01s*)

```
MeasuredSignal HasProcessingTimeStamp P
MeasuredSignal HasGenerationTimeStamp P' // P' = P + .01s
MeasuredSignal HasAcquisitionTimeStamp P'' // P'' = P' + 2s
```


The difference between *process* and *generation* time stamps is more explicit is the following simulation scenario:
1. a real-time simulation engine buffers incoming real-time data. At time *t0* it starts processing data with process time stamp *p*
2. It uses 1s to process the data. The output of the simulations therefore has *generation* time stamp *t0 + 1s* and *process* time stamp *p*, since it describes the state of the system at time *p*. 
3. It takes an additional .5s to transfer the simulated data to the real-time server. The *acquisition* time stamp is therefore *t0 + 1.5s*

## Refresh rates

Other useful information deals with the expectations one has regarding a specific signal. It can be of primary importance for an automation system to know

## Clocks

## Delays

## Synchronization

# Data processing

Show the different types of processing that can be involved in classical drilling data. 

**Modelling remark** We use a *data flow* approach to
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