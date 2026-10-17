# Downhole instrument identity, sensing principles and telemetry

These examples separate product model, physical instrument, physical sensor,
measurement principle and delivered stream. Identifiers are illustrative catalog
entries, not manufacturer-issued identifiers or real serial numbers. Select the
actual size/revision variant in a deployment. The graph URI identifies each unit;
serial number and asset identifier are optional descriptive attributes.

The examples show identity and provenance fragments, not complete signal manifests.
Production descriptions also need quantities, units, reference frames, observation
locations, timestamp semantics and actual processing. The same physical quantity
can legitimately have the same semantics across products while instrument identity
distinguishes its sources. Never infer a sensing principle from a commercial name.

## Models, physical units and representative sensors

```dwis SixDownholeInstrumentIdentities
NOV:nov
nov BelongsToClass DrillingDataEcosystemOrganization
Halliburton:halliburton
halliburton BelongsToClass DrillingDataEcosystemOrganization
WellID:wellID
wellID BelongsToClass DrillingDataEcosystemOrganization
Nabors:nabors
nabors BelongsToClass DrillingDataEcosystemOrganization

InstrumentModel:blackStreamEMSModel
blackStreamEMSModel.ModelIdentifier = "NOV/BlackStream/EMS/5in"
blackStreamEMSModel.ModelName = "BlackStream EMS 5-inch"
blackStreamEMSModel HasManufacturer nov
InstrumentInstance:emsUnit
emsUnit IsOfInstrumentModel blackStreamEMSModel
MeasurementDevice:emsAnnularPressureSensor
emsAnnularPressureSensor IsSensorOf emsUnit

InstrumentModel:blackStreamASMModel
blackStreamASMModel.ModelIdentifier = "NOV/BlackStream/ASM/5in"
blackStreamASMModel.ModelName = "BlackStream ASM 5-inch"
blackStreamASMModel HasManufacturer nov
InstrumentInstance:asmUnit
asmUnit IsOfInstrumentModel blackStreamASMModel
MeasurementDevice:asmAnnularPressureSensor
asmAnnularPressureSensor IsSensorOf asmUnit

InstrumentModel:baseStarModel
baseStarModel.ModelIdentifier = "Halliburton/BaseStar"
baseStarModel.ModelName = "BaseStar"
baseStarModel HasManufacturer halliburton
InstrumentInstance:baseStarUnit
baseStarUnit IsOfInstrumentModel baseStarModel
MeasurementDevice:baseStarAnnularPressureSensor
baseStarAnnularPressureSensor IsSensorOf baseStarUnit

InstrumentModel:fourDCaliperModel
fourDCaliperModel.ModelIdentifier = "WellID/4DCaliper"
fourDCaliperModel.ModelName = "4D Caliper"
fourDCaliperModel HasManufacturer wellID
InstrumentInstance:fourDCaliperUnit
fourDCaliperUnit IsOfInstrumentModel fourDCaliperModel
MeasurementDevice:fourDCaliperImagingSensor
fourDCaliperImagingSensor IsSensorOf fourDCaliperUnit

InstrumentModel:drillViewModel
drillViewModel.ModelIdentifier = "Nabors/BlueForce/DrillView"
drillViewModel.ModelName = "BlueForce DrillView"
drillViewModel HasManufacturer nabors
InstrumentInstance:drillViewUnit
drillViewUnit IsOfInstrumentModel drillViewModel
MeasurementDevice:drillViewAnnularPressureSensor
drillViewAnnularPressureSensor IsSensorOf drillViewUnit

InstrumentModel:fracViewModel
fracViewModel.ModelIdentifier = "Nabors/BlueForce/FracView"
fracViewModel.ModelName = "BlueForce FracView"
fracViewModel HasManufacturer nabors
InstrumentInstance:fracViewUnit
fracViewUnit IsOfInstrumentModel fracViewModel
MeasurementDevice:fracViewImagingSensor
fracViewImagingSensor IsSensorOf fracViewUnit
```

EMS, ASM, BaseStar and DrillView pressure sensor implementations are intentionally
unspecified: their common pressure output does not establish identical sensing
technology. Each sensor can have its own mechanical location, including different
positions within one tool. Do not equate the sensor location with the location of
an inferred bit force or a remote observed borehole wall.

## Imaging principles

BaseStar's PixStar module and FracView use ultrasonic imaging. The supplied Well ID
4D Caliper sheet describes electromagnetic pulse-echo imaging. Radius/time-of-flight
and echo amplitude remain distinct measurement outputs. Dynamics sensors in those
same instruments do not automatically inherit the imaging sensor's principle.

```dwis DownholeImagingPrinciples
InstrumentInstance:baseStarUnit
InstrumentInstance:fourDCaliperUnit
InstrumentInstance:fracViewUnit
MeasurementDevice:baseStarPixStarSensor
MeasurementDevice:fourDCaliperImagingSensor
MeasurementDevice:fracViewImagingSensor
baseStarPixStarSensor IsSensorOf baseStarUnit
fourDCaliperImagingSensor IsSensorOf fourDCaliperUnit
fracViewImagingSensor IsSensorOf fracViewUnit
UltrasonicPulseEchoMeasurementPrinciple:ultrasonicPulseEcho
ElectromagneticPulseEchoMeasurementPrinciple:electromagneticPulseEcho
DerivedMeasurement:baseStarBoreholeRadius
baseStarBoreholeRadius IsMeasuredBy baseStarPixStarSensor
baseStarBoreholeRadius UsesMeasurementPrinciple ultrasonicPulseEcho
DerivedMeasurement:fourDCaliperBoreholeRadius
fourDCaliperBoreholeRadius IsMeasuredBy fourDCaliperImagingSensor
fourDCaliperBoreholeRadius UsesMeasurementPrinciple electromagneticPulseEcho
DerivedMeasurement:fracViewBoreholeRadius
fracViewBoreholeRadius IsMeasuredBy fracViewImagingSensor
fracViewBoreholeRadius UsesMeasurementPrinciple ultrasonicPulseEcho
```

## Available deployed telemetry paths

In this example deployment all six tools have access to wired-pipe telemetry.
BaseStar also has access to mud-pulse telemetry through its connected MWD.
SupportsTelemetry expresses availability, not actual transmission or an integral
transmitter. A tool's internal memory is not another downhole telemetry technology.

```dwis SixDownholeInstrumentTelemetryCapabilities
InstrumentInstance:emsUnit
InstrumentInstance:asmUnit
InstrumentInstance:baseStarUnit
InstrumentInstance:fourDCaliperUnit
InstrumentInstance:drillViewUnit
InstrumentInstance:fracViewUnit
WiredPipeTelemetry:wiredPipePath
MudPulseTelemetry:baseStarMWDMudPulsePath
emsUnit SupportsTelemetry wiredPipePath
asmUnit SupportsTelemetry wiredPipePath
baseStarUnit SupportsTelemetry wiredPipePath
baseStarUnit SupportsTelemetry baseStarMWDMudPulsePath
fourDCaliperUnit SupportsTelemetry wiredPipePath
drillViewUnit SupportsTelemetry wiredPipePath
fracViewUnit SupportsTelemetry wiredPipePath
```

The five non-BaseStar instruments are configured as wired-pipe-only here, as
specified for this deployment. Missing mud-pulse facts alone do not prove that
restriction under open-world semantics. A deployment validator must treat its
allowed-path catalog as complete and reject actual paths outside that catalog.
Do not assert product-wide telemetry restrictions from these example instances.

## BaseStar: one measurement, two delivered streams

The same underlying sensor measurement can feed two different transmission lines.
Distinct delivered data points have distinct dynamic values and transport facts.
This avoids identifying BaseStar merely by the presence of mud-pulse telemetry,
and avoids merging its wired-pipe and mud-pulse streams.

```dwis BaseStarTwoTelemetryPaths
InstrumentInstance:baseStarUnit
MeasurementDevice:baseStarAnnularPressureSensor
baseStarAnnularPressureSensor IsSensorOf baseStarUnit
DirectMeasurement:baseStarAnnularPressureAtSensor
baseStarAnnularPressureAtSensor IsMeasuredBy baseStarAnnularPressureSensor
TransmissionLine:baseStarWiredTransmission
TransmissionLine:baseStarMudPulseTransmission
baseStarAnnularPressureAtSensor IsTransmissionInput baseStarWiredTransmission
baseStarAnnularPressureAtSensor IsTransmissionInput baseStarMudPulseTransmission
WiredPipeTelemetry:wiredPipePath
MudPulseTelemetry:baseStarMWDMudPulsePath
DerivedMeasurement:baseStarAnnularPressureWired
baseStarAnnularPressureWired IsTransmissionOutput baseStarWiredTransmission
baseStarAnnularPressureWired IsLocatedAtEquipment baseStarUnit
baseStarAnnularPressureWired IsTransmittedBy wiredPipePath
DynamicDrillingSignal:baseStarAnnularPressureWiredValue
baseStarAnnularPressureWired HasDynamicValue baseStarAnnularPressureWiredValue
DerivedMeasurement:baseStarAnnularPressureMudPulse
baseStarAnnularPressureMudPulse IsTransmissionOutput baseStarMudPulseTransmission
baseStarAnnularPressureMudPulse IsLocatedAtEquipment baseStarUnit
baseStarAnnularPressureMudPulse IsTransmittedBy baseStarMWDMudPulsePath
DynamicDrillingSignal:baseStarAnnularPressureMudPulseValue
baseStarAnnularPressureMudPulse HasDynamicValue baseStarAnnularPressureMudPulseValue
```

This fragment assumes transmission without additional preprocessing. When paths
apply different averaging, quantization, resampling or buffering, insert those
transformations before the respective transmission inputs, with actual parameters.
Do not invent rates or assume identical values or observation times. Use existing
transformation input/output relationships for lineage: IsDerivedFrom specifically
means differentiation in the current vocabulary.

## Definition ownership and compatibility

- InstrumentIdentity defines InstrumentModel, InstrumentInstance, model/manufacturer
  relationships and identity attributes. DrillingEquipment remains the spreadsheet-generated
  equipment taxonomy.
- DataFlow defines IsSensorOf and the existing sensor/processing lineage concepts.
- DataTransmission defines SupportsTelemetry and actual transport relationships.
- MeasurementPrinciples defines general sensing principles and UsesMeasurementPrinciple.
- Hydraulics retains FlowMeasurementPrinciple and flow-specific specializations.

AcousticMeasurementPrinciple, ElectromagneticMeasurementPrinciple and
UsesMeasurementPrinciple retain their term names, but now have a general measurement
scope. Acoustic and electromagnetic methods are no longer necessarily flow methods.
Consumers explicitly relying on the former FlowMeasurementPrinciple ancestry must
review that assumption when regenerating/loading the vocabulary. Existing nodes and
assertions are not deleted or migrated by these Markdown changes.

The complete vocabulary and schema must be regenerated and adopted by consumers
before these terms/attributes are available to C# semantic annotations. Product names
and model identifiers stay catalog instances rather than new vocabulary enums.
