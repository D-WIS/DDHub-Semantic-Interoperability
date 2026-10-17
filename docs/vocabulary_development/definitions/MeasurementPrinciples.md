- Description: Physical principles used to acquire measurements, independent of instrument identity, signal processing and data telemetry. Flow-specific principles remain in Hydraulics.

# NOUNS
## MeasurementPrinciple <!-- NOUN -->
- Display name: MeasurementPrinciple
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: The physical mechanism used to obtain a measurement. It describes sensing, not transport, aggregation or the commercial instrument model.
- Examples:
```dwis MeasurementPrincipleExample
DrillingDataPoint:boreholeRadius
MeasurementPrinciple:radiusMeasurementPrinciple
boreholeRadius UsesMeasurementPrinciple radiusMeasurementPrinciple
```

## AcousticMeasurementPrinciple <!-- NOUN -->
- Display name: Acoustic Measurement Principle
- Parent class: MeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that an acoustic measurement principle is used to perform a measurement.
- Examples:
```dwis AcousticMeasurementPrincipleExample
DrillingDataPoint:volumetricFlowRateSignal
AcousticMeasurementPrinciple:acousticMeasurementPrinciple
volumetricFlowRateSignal UsesMeasurementPrinciple acousticMeasurementPrinciple
```
This example states that a volumetric flowrate signal uses an acoustic measurement principle.

## ElectromagneticMeasurementPrinciple <!-- NOUN -->
- Display name: Electromagnetic Measurement Principle
- Parent class: MeasurementPrinciple
- Attributes:
- Specialization:
- Description: Describes that an electromagnetic measurement principle is used to perform a measurement.
- Examples:
```dwis ElectromagneticMeasurementPrincipleExample
DrillingDataPoint:volumetricFlowRateSignal
ElectromagneticMeasurementPrinciple:electromagneticMeasurementPrinciple
volumetricFlowRateSignal UsesMeasurementPrinciple electromagneticMeasurementPrinciple
```
This example states that a volumetric flowrate signal uses an electromagnetic measurement principle.

## UltrasonicPulseEchoMeasurementPrinciple <!-- NOUN -->
- Display name: UltrasonicPulseEchoMeasurementPrinciple
- Parent class: AcousticMeasurementPrinciple
- Attributes:
- Specialization:
- Description: An ultrasonic pulse is emitted and its returning echo is measured. Travel time can support distance/radius estimation, while echo amplitude provides reflection information; radius and amplitude are separate outputs. This does not describe acoustic telemetry.
- Examples:
```dwis UltrasonicPulseEchoMeasurementPrincipleExample
DerivedMeasurement:boreholeRadius
UltrasonicPulseEchoMeasurementPrinciple:ultrasonicPulseEcho
boreholeRadius UsesMeasurementPrinciple ultrasonicPulseEcho
```

## ElectromagneticPulseEchoMeasurementPrinciple <!-- NOUN -->
- Display name: ElectromagneticPulseEchoMeasurementPrinciple
- Parent class: ElectromagneticMeasurementPrinciple
- Attributes:
- Specialization:
- Description: An electromagnetic pulse is emitted and its returning response is measured. Time-of-flight and echo amplitude support distinct geometric and reflection outputs. This does not describe electromagnetic telemetry or wired-pipe coupling.
- Examples:
```dwis ElectromagneticPulseEchoMeasurementPrincipleExample
DerivedMeasurement:boreholeRadius
ElectromagneticPulseEchoMeasurementPrinciple:electromagneticPulseEcho
boreholeRadius UsesMeasurementPrinciple electromagneticPulseEcho
```

# VERBS
## UsesMeasurementPrinciple <!-- VERB -->
- Display name: UsesMeasurementPrinciple
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: MeasurementPrinciple
- Description: Associates a measurement data point with the physical principle by which it is obtained. Retain processing lineage separately and use IsTransmittedBy for transport.
- Examples:
```dwis UsesMeasurementPrincipleExample
DerivedMeasurement:boreholeRadius
UltrasonicPulseEchoMeasurementPrinciple:ultrasonicPulseEcho
boreholeRadius UsesMeasurementPrinciple ultrasonicPulseEcho
```
