- [Gathered vocabulary](#gathered-vocabulary)
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
    - [Positions](#positions)
  - [Dependencies](#dependencies)
  - [Physical Position](#physical-position)
  - [Logical positions](#logical-positions)


# Gathered vocabulary
This document summaries the various words used during the DWIS session of the workstream 1. 

It covers the main semantical thematics.  


## Data structure

## Quantities and units

The following shows the main concepts illustrated via a pressure example.

### Base quantities

```
PressureQuantity HasMassExponent 1
PressureQuantity HasLengthExponent -1
PressureQuantity HasTimeExponent -2
```

### Observable quantities
```
PumpPressureQuantity HasBaseQuantity PressureQuantity
PumpPressureQuantity HasMeaningFulPrecision 1000

FormationStrengthQuantity HasBaseQuantity PressureQuantity
FormationStrengthQuantity HasMeaningFulPrecision 100000
```

### Units and unit systems

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



## Uncertainties

## Data validity

## Time management

## Data processing

### Downhole ECD
```
DownholeECD IsConvertedBy PressureToDensityConversion
PressureToDensityConversion HasPressureInput DownholePressure
PressureToDensityConversion HasElevationInput PWDTVD

DownholePressure IsMeasuredBy PWD
DownholePressure IsTimeAveragedBy DownholePressureAveraging
DownholePressureAveraging HasInput HighFrequencyDownholePressure
DownholePressureAveraging HasTimeWindow 30
```

### Positions

## Dependencies

## Physical Position

## Logical positions