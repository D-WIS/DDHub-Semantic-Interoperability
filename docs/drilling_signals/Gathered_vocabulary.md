
- [Data structure](#data-structure)
- [Quantities and units](#quantities-and-units)
  - [Base quantities](#base-quantities)
  - [Observable quantities](#observable-quantities)
  - [Units and unit systems](#units-and-unit-systems)
- [Uncertainties](#uncertainties)
- [Data validity](#data-validity)
- [Time management](#time-management)
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


# Data structure

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
```



# Uncertainties

# Data validity

# Time management

# Data processing

Show the different types of procesing that can be involved in classical drilling data. 
As some processing requires parametrization, it is simpler to treat each processing step as a entity in the graph. The general structure then applies

```
Signal1 IsProcessingOutputOf ProcessingUnit
ProcessingUnit HasInput Signal2
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

# Physical Position

# Logical positions