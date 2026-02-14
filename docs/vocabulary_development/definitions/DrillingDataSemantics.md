- Description: Describes the semantics of drilling signals: their data types, how values are carried, and how set-points, commands, recommendations, advices, limits, and measurements relate to each other.

# NOUNS
## DataType <!-- NOUN -->
- Display name: Data Type
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Characterizes the type of data that is stored in a signal.
- Examples:
```dwis wobType
DataType:dataType
DrillingDataPoint:weightOnBit
weightOnBit BelongsToClass dataType
```
This example defines that the weight-on-bit signal has a data type.
## ContinuousDataType <!-- NOUN -->
- Display name: Continuous Data Type
- Parent class: DataType
- Attributes:
- Specialization:
- Description: Specifies that the data is continuous.
- Examples:
```dwis continuousWob
ContinuousDataType:continuous
DrillingDataPoint:weightOnBit
weightOnBit BelongsToClass continuous
```
This example assigns a continuous type to weight on bit.
## DateDataType <!-- NOUN -->
- Display name: Date Data Type
- Parent class: ContinuousDataType
- Attributes:
- Specialization:
- Description: Indicates that the data is a date.
- Examples:
```dwis spudDateType
DateDataType:dateType
DrillingDataPoint:spudDate
spudDate BelongsToClass dateType
```
This example states that the spud date signal is a date.
## ElapsedTimeDataType <!-- NOUN -->
- Display name: Elapsed Time Data Type
- Parent class: ContinuousDataType
- Attributes:
- Specialization:
- Description: Indicates that the data is an elapsed time.
- Examples:
```dwis circulationElapsed
ElapsedTimeDataType:elapsedType
DrillingDataPoint:circulationDuration
circulationDuration BelongsToClass elapsedType
```
This example tags circulation duration as elapsed time.
## NormalizedDataType <!-- NOUN -->
- Display name: Normalized Data Type
- Parent class: ContinuousDataType
- Attributes:
- Specialization:
- Description: Indicates that the data has been normalized and stays between 0 and 1.
- Examples:
```dwis normalizedTorque
NormalizedDataType:normalized
DrillingDataPoint:normalizedTorqueRatio
normalizedTorqueRatio BelongsToClass normalized
```
This example marks a normalized torque ratio between 0 and 1.
## DiscreteDataType <!-- NOUN -->
- Display name: Discrete Data Type
- Parent class: DataType
- Attributes:
- Specialization:
- Description: Specifies that the data is discrete.
- Examples:
```dwis standStatusType
DiscreteDataType:discrete
DrillingDataPoint:standStatus
standStatus BelongsToClass discrete
```
This example declares a stand status as discrete.
## EnumerationDataType <!-- NOUN -->
- Display name: Enumeration Data Type
- Parent class: DiscreteDataType
- Attributes:
- Specialization:
- Description: Indicates that the data is an enumeration.
- Examples:
```dwis connectionStateType
EnumerationDataType:enumType
DrillingDataPoint:connectionState
connectionState BelongsToClass enumType
```
This example assigns an enumeration type to connection state.
## BooleanDataType <!-- NOUN -->
- Display name: Boolean Data Type
- Parent class: EnumerationDataType
- Attributes:
- Specialization:
- Description: Indicates that the data is a boolean.
- Examples:
```dwis circulationFlagType
BooleanDataType:booleanType
DrillingDataPoint:isCirculating
isCirculating BelongsToClass booleanType
```
This example sets the circulation flag as boolean.
## StringDataType <!-- NOUN -->
- Display name: String Data Type
- Parent class: DataType
- Attributes:
- Specialization:
- Description: Specifies that the data is a string.
- Examples:
```dwis jobIdType
StringDataType:stringType
DrillingDataPoint:jobIdentifier
jobIdentifier BelongsToClass stringType
```
This example marks a job identifier as string data.
## JSonDataType <!-- NOUN -->
- Display name: JSon Data Type
- Parent class: StringDataType
- Attributes:
- Specialization:
- Description: Specifies that the data is a string that contains the serialization in Json of an object.
- Examples:
```dwis bhaJson
JSonDataType:jsonType
DrillingDataPoint:bhaConfiguration
bhaConfiguration BelongsToClass jsonType
```
This example stores BHA configuration as JSON.
## DrillingDataPoint <!-- NOUN -->
- Display name: DrillingDataPoint
- Parent class: DWISNoun
- Attributes:
  - IsValid
    - Type: bool
    - Description: 
- Specialization:
- Description: Main type of DDHub data. Represents a drilling signal. Can be a dynamic signal (linked to a ValueNode) or a static parameter. 
- Examples:
```dwis wobSignal
DrillingDataPoint:weightOnBit
DynamicDrillingSignal:wobSeries
weightOnBit HasDynamicValue wobSeries
```
This example shows a drilling data point holding a dynamic time series.
## PrototypeData <!-- NOUN -->
- Display name: PrototypeData
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: Represents a prototypical or design value of a drilling signal used for templates or baselines.
- Examples:
```dwis prototypeWob
PrototypeData:prototypeWob
DrillingDataPoint:weightOnBit
weightOnBit HasStaticValue prototypeWob
```
This example stores a prototype weight-on-bit value.
## ProcessData <!-- NOUN -->
- Display name: ProcessData
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: A drilling signal directly tied to process control or monitoring.
- Examples:
```dwis flowRateSignal
ProcessData:flowRate
DynamicDrillingSignal:flowRateSeries
flowRate HasDynamicValue flowRateSeries
```
This example captures flow rate as process data.
## ProcessFeature <!-- NOUN -->
- Display name: Process feature
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: This Noun is used for signals that describe a process feature, typically assuming that this is a static signal.
- Examples:
```dwis isUsedAutoDrillerWithOnlyLimit
DrillingSignal:isUsedAutoDrillerWithOnlyLimit
ProcessFeature:isUsedAutoDrillerWithOnlyLimit#01
BooleanDataType:isUsedAutoDrillerWithOnlyLimit#01
isUsedAutoDrillerWithOnlyLimit#01 HasStaticValue isUsedAutoDrillerWithOnlyLimit
ControllerFunction:AutoDriller
StableAxialVelocityObjective:stableROP
StableAxialForceObjective:stableWOB
AutoDriller ImplementsObjective stableROP
AutoDriller ImplementsObjective stableWOB
isUsedAutoDrillerWithOnlyLimit#01 IsFeatureSignalFor AutoDriller
OnlyLimits:onlyLimits
isUsedAutoDrillerWithOnlyLimit#01 IsRelatedToDrillingLimit onlyLimits
```
## SetPoint <!-- NOUN -->
- Display name: Set-point
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: A process data point intended to serve as a target value for control.
- Examples:
```dwis flowSetPoint
SetPoint:flowSetPoint
Controller:flowController
flowSetPoint IsSetPointFor flowController
```
This example defines a flow-rate set-point for a controller.
## Command <!-- NOUN -->
- Display name: Command
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: A process data point used to instruct equipment or a controller.
- Examples:
```dwis pumpCommand
Command:pumpStartCommand
ControlSystem:circulationDCS
pumpStartCommand IsCommandFor circulationDCS
```
This example issues a start command to the circulation control system.
## Recommendation <!-- NOUN -->
- Display name: Recommendation
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: A suggested value or range for a process variable prior to operator acceptance.
- Examples:
```dwis flowRecommendation
Recommendation:flowRateRecommendation
ControlSystem:circulationDCS
flowRateRecommendation IsSetPointRecommendationFor circulationDCS
```
This example recommends a flow-rate to the circulation system.
## RecommendedTarget <!-- NOUN -->
- Display name: RecommendedTarget
- Parent class: Recommendation
- Attributes:
- Specialization:
- Description: A recommended single target value.
- Examples:
```dwis wobTarget
RecommendedTarget:wobTarget
Controller:autoDrillerController
wobTarget IsSetPointRecommendationFor autoDrillerController
```
This example recommends a weight-on-bit target to the autodriller.
## RecommendedMinimum <!-- NOUN -->
- Display name: RecommendedMinimum
- Parent class: Recommendation
- Attributes:
- Specialization:
- Description: A recommended lower bound for a process variable.
- Examples:
```dwis minRpmRec
RecommendedMinimum:minRpmRecommendation
RotationControlSystem:rotationDCS
minRpmRecommendation IsSetPointMinimumRecommendationFor rotationDCS
```
This example provides a minimum RPM recommendation.
## RecommendedMaximum <!-- NOUN -->
- Display name: RecommendedMaximum
- Parent class: Recommendation
- Attributes:
- Specialization:
- Description: A recommended upper bound for a process variable.
- Examples:
```dwis maxRpmRec
RecommendedMaximum:maxRpmRecommendation
RotationControlSystem:rotationDCS
maxRpmRecommendation IsSetPointMaximumRecommendationFor rotationDCS
```
This example provides a maximum RPM recommendation.
## Advice <!-- NOUN -->
- Display name: Advice
- Parent class: ProcessData
- Attributes: 
- Specialization:
- Description: An advisory value or range proposed by a system or expert, typically requiring confirmation.
- Examples:
```dwis flowAdvice
Advice:flowAdvice
ControlSystem:circulationDCS
flowAdvice IsSetPointAdviceFor circulationDCS
```
This example provides advisory flow guidance.
## AdvisedTarget <!-- NOUN -->
- Display name: AdvisedTarget
- Parent class: Advice
- Attributes: 
- Specialization:
- Description: An advised single target value.
- Examples:
```dwis advisedWob
AdvisedTarget:advisedWob
Controller:autoDrillerController
advisedWob IsSetPointAdviceFor autoDrillerController
```
This example advises a weight-on-bit target.
## AdvisedMinimum <!-- NOUN -->
- Display name: AdvisedMinimum
- Parent class: Advice
- Attributes: 
- Specialization:
- Description: An advised lower bound for a process variable.
- Examples:
```dwis advisedMinFlow
AdvisedMinimum:advisedMinFlow
CirculationControlSystem:circulationDCS
advisedMinFlow IsSetPointMinimumAdviceFor circulationDCS
```
This example advises a minimum flow limit.
## AdvisedMaximum <!-- NOUN -->
- Display name: AdvisedMaximum
- Parent class: Advice
- Attributes: 
- Specialization:
- Description: An advised upper bound for a process variable.
- Examples:
```dwis advisedMaxTorque
AdvisedMaximum:advisedMaxTorque
RotationControlSystem:rotationDCS
advisedMaxTorque IsSetPointMaximumAdviceFor rotationDCS
```
This example advises a maximum torque limit.
## Limit <!-- NOUN -->
- Display name: Limit
- Parent class: ProcessData
- Attributes:
- Specialization:
- Description: A boundary value that should not be exceeded by a process variable.
- Examples:
```dwis wobLimit
Limit:wobLimit
ControllerFunction:autoDriller
wobLimit IsLimitFor autoDriller
```
This example sets a WOB limit for the autodriller.
## MinimumLimit <!-- NOUN -->
- Display name: Minimum Limit
- Parent class: Limit
- Attributes:
- Specialization:
- Description: A lower boundary for a process variable.
- Examples:
```dwis minFlowLimit
MinimumLimit:minFlowLimit
CirculationControlSystem:circulationDCS
minFlowLimit IsMinimumLimitFor circulationDCS
```
This example provides a minimum flow limit.
## MaximumLimit <!-- NOUN -->
- Display name: Maximum Limit
- Parent class: Limit
- Attributes:
- Specialization:
- Description: An upper boundary for a process variable.
- Examples:
```dwis maxFlowLimit
MaximumLimit:maxFlowLimit
CirculationControlSystem:circulationDCS
maxFlowLimit IsMaximumLimitFor circulationDCS
```
This example provides a maximum flow limit.
## PhysicalData <!-- NOUN -->
- Display name: PhysicalData
- Parent class: DrillingDataPoint
- Attributes:
- Specialization:
- Description: Represents a physical quantity measured or computed from the drilling system.
- Examples:
```dwis standpipePressure
PhysicalData:standpipePressure
DynamicDrillingSignal:standpipeSeries
standpipePressure HasDynamicValue standpipeSeries
```
This example stores a physical standpipe pressure signal.
## Measurement <!-- NOUN -->
- Display name: Measurement
- Parent class: PhysicalData
- Attributes:
- Specialization:
- Description: Represents individuals that are measured by some instrument and whose value can be compared with another measurement.
- Examples:
```dwis hookloadMeasurement
Measurement:hookloadMeasurement
DynamicDrillingSignal:hookloadSeries
hookloadMeasurement HasDynamicValue hookloadSeries
```
This example captures hookload as a measurement.
## DirectMeasurement <!-- NOUN -->
- Display name: Direct Measurement
- Parent class: Measurement
- Attributes:
- Specialization:
- Description: A measurement obtained directly without corrections or signal processing.
- Examples:
```dwis MeasuredPressureExample
DirectMeasurement:OmniViewMeasuredPressure#01
OmniViewMeasuredPressure#01 BelongsToClass ContinuousDataType
OmniViewMeasuredPressure#01 HasDynamicValue OmniViewMeasuredPressure
OmniViewMeasuredPressure#01 IsOfMeasurableQuantity PressureDrilling
TopSideTelemetry:topSideTelemetry
OmniViewMeasuredPressure#01 IsTransmittedBy topSideTelemetry
DynamicDrillingSignal:Sigma_OmniViewMeasuredPressure
DrillingDataPoint:Sigma_OmniViewMeasuredPressure#01
Sigma_OmniViewMeasuredPressure#01 BelongsToClass ContinuousDataType
Sigma_OmniViewMeasuredPressure#01 IsOfMeasurableQuantity PressureDrilling
Sigma_OmniViewMeasuredPressure#01 HasDynamicValue Sigma_OmniViewMeasuredPressure
GaussianUncertainty:OmniViewMeasuredPressureGaussianUncertainty#01
OmniViewMeasuredPressure#01 HasUncertainty OmniViewMeasuredPressureGaussianUncertainty#01
OmniViewMeasuredPressureGaussianUncertainty#01 HasUncertaintyMean OmniViewMeasuredPressure#01
OmniViewMeasuredPressureGaussianUncertainty#01 HasUncertaintyStandardDeviation Sigma_OmniViewMeasuredPressure#01
MeasurementDevice:OmniViewDevice#01
OmniViewDevice#01 BelongsToClass HydraulicLogicalElement
OmniViewMeasuredPressure#01 IsMeasuredBy OmniViewDevice#01
SwivelLogical:SwivelLogical#01
OmniViewDevice#01 IsHydraulicConnectedTo SwivelLogical#01
OmniViewMeasuredPressure#01 IsHydraulicallyLocatedAt SwivelLogical#01
TopOfStringJunction:topOfStringJunction#01
HydraulicBranch:inletHydraulicBranch#01
topOfStringJunction#01 HasUpstreamBranch inletHydraulicBranch#01
OmniViewMeasuredPressure#01 IsAssociatedToHydraulicBranch inletHydraulicBranch#01
InstrumentationCompany:Petromar#01
OmniViewMeasuredPressure#01 IsProvidedBy Petromar#01
```
This example defines a direct measurement of pressure from an instrumented sub.
## DerivedMeasurement <!-- NOUN -->
- Display name: DerivedMeasurement
- Parent class: Measurement
- Attributes:
- Specialization:
- Description: A measurement obtained through transformation or computation rather than direct sensing.
- Examples:
```dwis equivalentDensity
DynamicDrillingSignal:downholeECD
DerivedMeasurement:downholeECD#01
downholeECD#01 BelongsToClass ContinuousDataType
downholeECD#01 HasDynamicValue downholeECD
downholeECD#01 IsOfMeasurableQuantity MassDensityDrilling
DirectMeasurement:downholePressure#01
downholePressure#01 BelongsToClass ContinuousDataType
downholePressure#01 IsOfMeasurableQuantity PressureDrilling
PressureToEquivalentDensityTransformation:pressureToDownholeECD
downholePressure#01 IsTransformationInput pressureToDownholeECD
downholeECD#01 IsTransformationOutput pressureToDownholeECD
```
This example computes downhole equivalent circulating density from pressure.
```dwis averageTemperatureExample
DerivedMeasurement:averageMudTemperature
MovingAverage:averageTemperatureCalculator
averageMudTemperature IsTransformationOutput averageTemperatureCalculator
```
This example computes average mud temperature using a moving average.
## CorrectedMeasurement <!-- NOUN -->
- Display name: CorrectedMeasurement
- Parent class: Measurement
- Attributes:
- Specialization:
- Description: A measurement that has been corrected for bias or known offsets.
- Examples:
```dwis correctedDepth
CorrectedMeasurement:correctedDepth
DrillingDataPoint:rawMeasuredDepth
correctedDepth IsTransformationOutput depthTranslation
```
This example records a depth after applying a correction.
## ComputedData <!-- NOUN -->
- Display name: ComputedData
- Parent class: PhysicalData
- Attributes:
- Specialization:
- Description: A physical data point generated by a computation or model rather than direct measurement.
- Examples:
```dwis predictedStandpipePressure
ComputedData:predictedStandpipePressure
Simulator:hydraulicsSimulator
predictedStandpipePressure IsComputedBy hydraulicsSimulator
```
This example shows a computed standpipe pressure from a simulator.
## EstimationParameter <!-- NOUN -->
- Display name: Estimation Parameter
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A quantity describing the configuration or internal state of a data interpretation 
or estimation model rather than the physical drilling process.
- Examples:
```dwis KalmanFilterStateConfidenceExample
DynamicDrillingSignal:KalmanFilterStateConfidence
ComputedData:KalmanFilterStateConfidence#01
KalmanFilterStateConfidence#01 BelongsToClass ContinuousDataType
KalmanFilterStateConfidence#01 BelongsToClass EstimationParameter
KalmanFilterStateConfidence#01 IsOfMeasurableQuantity DimensionLessStandard
KalmanFilterStateConfidence#01 HasDynamicValue KalmanFilterStateConfidence
DataAnalysisService:pitVolumeEstimator#01
KalmanFilterStateConfidence#01 IsProvidedBy pitVolumeEstimator#01
```
A confidence indicator describing the estimator internal state quality.
## CalibrationParameter <!-- NOUN -->
- Display name: Calibration Parameter
- Parent class: EstimationParameter
- Attributes:
- Specialization:
- Description: An estimation parameter that maps a sensor representation to a physical quantity through scaling or conversion.
- Examples:
```dwis ReturnFlowCapacityScaleExample
DynamicDrillingSignal:ReturnFlowCapacityScale
ComputedData:ReturnFlowCapacityScale#01
ReturnFlowCapacityScale#01 BelongsToClass ContinuousDataType
ReturnFlowCapacityScale#01 BelongsToClass CalibrationParameter
ReturnFlowCapacityScale#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
ReturnFlowCapacityScale#01 HasDynamicValue ReturnFlowCapacityScale
DynamicDrillingSignal:ReturnFlowProportion
ReturnFlowCapacityScale#01 Calibrates ReturnFlowProportion
DataAnalysisService:pitVolumeEstimator#01
ReturnFlowCapacityScale#01 IsProvidedBy pitVolumeEstimator#01
```
Scale factor converting return proportion -> volumetric flowrate.
## CorrectionFactor <!-- NOUN -->
- Display name: Correction Factor
- Parent class: EstimationParameter
- Attributes:
- Specialization:
- Description: An estimation parameter used to compensate systematic bias or mismatch in a computed or measured quantity.
- Examples:
```dwis ReturnFlowCapacityScaleExample
DynamicDrillingSignal:EstimatedPitVolumeFlowBias
ComputedData:EstimatedPitVolumeFlowBias#01
EstimatedPitVolumeFlowBias#01 BelongsToClass ContinuousDataType
EstimatedPitVolumeFlowBias#01 BelongsToClass CorrectionFactor
EstimatedPitVolumeFlowBias#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
EstimatedPitVolumeFlowBias#01 HasDynamicValue EstimatedPitVolumeFlowBias
DynamicDrillingSignal:CorrectedActiveVolume
EstimatedPitVolumeFlowBias#01 Corrects CorrectedActiveVolume
DataAnalysisService:pitVolumeEstimator#01
EstimatedPitVolumeFlowBias#01 IsProvidedBy pitVolumeEstimator#01
```
Estimated bias used to compensate mismatch in pit volume balance.
## DrillingSignal <!-- NOUN -->
- Display name: DrillingSignal
- Parent class: DWISNoun
- Attributes:
  - Value
    - Type: object
    - Description: 
- Specialization:
- Description: Data structure used to store the streaming drilling data. 
- Examples:
```dwis wobSignalValue
DrillingSignal:wobSignal
DrillingDataPoint:weightOnBit
weightOnBit HasValue wobSignal
```
This example links a drilling data point to its signal value container.
## DynamicDrillingSignal <!-- NOUN -->
- Display name: DynamicDrillingSignal
- Parent class: DrillingSignal
- Attributes:
  - TimeStampAtSource
    - Type: DateTime
    - Description: this is a UTC date-time value corresponding to the time at which the value has been taken.
  - TimeStampAcquisition
    - Type: DateTime
    - Description: this is a UTC date-time value at which the value has been acquired by the data acquisition system.
- Specialization:
- Description: Represents a time-stamped drilling signal acquired or recorded over time.
- Examples:
```dwis timeStampedWob
DynamicDrillingSignal:wobSeries
DrillingDataPoint:weightOnBit
weightOnBit HasDynamicValue wobSeries
wobSeries.TimeStampAtSource = "2024-06-01T12:00:00Z"
wobSeries.TimeStampAcquisition = "2024-06-01T12:00:00Z"
```
This example stores time-stamped weight-on-bit samples.


# VERBS
## HasDomain <!-- VERB -->
- Display name: HasDomain
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Declares the domain (e.g., depth or time interval) over which a data point is valid.
- Examples: 
```dwis domainExample
DrillingDataPoint:standpipePressure
DrillingDataPoint:measuredDepth
standpipePressure HasDomain measuredDepth
```
This example sets measured depth as the domain for standpipe pressure values.
## HasTimeIntervalDomain <!-- VERB -->
- Display name: HasTimeIntervalDomain
- Parent verb: HasDomain
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the domain of a data point is defined over a time interval.
- Examples: 
```dwis timeDomainExample
DrillingDataPoint:circulationPressure
DrillingDataPoint:circulationTimeWindow
circulationPressure HasTimeIntervalDomain circulationTimeWindow
```
This example associates circulation pressure with a time-window domain.
## HasValue <!-- VERB -->
- Display name: HasValue
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingSignal
- Description: Associates a data point with its stored value.
- Examples: 
```dwis valueExample
DrillingDataPoint:flowRate
DrillingSignal:flowSignal
flowRate HasValue flowSignal
```
This example links flow rate to its signal payload.
## HasDynamicValue <!-- VERB -->
- Display name: HasDynamicValue
- Parent verb: HasValue
- Subject class: DrillingDataPoint
- Object class: DynamicDrillingSignal
- Description: Indicates that the value is a time-varying drilling signal.
- Examples: 
```dwis dynamicValueExample
DrillingDataPoint:hookload
DynamicDrillingSignal:hookloadSeries
hookload HasDynamicValue hookloadSeries
```
This example shows a hookload data point with dynamic samples.
## HasStaticValue <!-- VERB -->
- Display name: HasStaticValue
- Parent verb: HasValue
- Subject class: DrillingDataPoint
- Object class: DrillingSignal
- Description: Indicates that the value is static (non time-varying).
- Examples:
```dwis staticValueExample
DrillingDataPoint:pipeInnerDiameter
DrillingSignal:pipeInnerDiameterValue
pipeInnerDiameter HasStaticValue pipeInnerDiameterValue
```
This example stores a static inner diameter value.
## IsToBeComparedWith <!-- VERB -->
- Display name: IsToBeComparedWith
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: States that two data points should be compared for validation or control.
- Examples:
```dwis comparisonExample
DrillingDataPoint:standpipePressure
DrillingDataPoint:pressureLimit
standpipePressure IsToBeComparedWith pressureLimit
```
This example indicates the pressure should be checked against a limit.
## IsToBeGreaterThan <!-- VERB -->
- Display name: IsToBeGreaterThan
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should stay greater than the object.
- Examples:
```dwis greaterThanExample
DrillingDataPoint:annularVelocity
DrillingDataPoint:minAnnularVelocity
annularVelocity IsToBeGreaterThan minAnnularVelocity
```
This example requires annular velocity to exceed a minimum.
## IsToBeGreaterOrEqualThan <!-- VERB -->
- Display name: IsToBeGreaterOrEqualThan
- Parent verb: IsToBeGreaterThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should stay greater than or equal to the object.
- Examples:
```dwis greaterOrEqualExample
DrillingDataPoint:flowRate
DrillingDataPoint:targetFlowRate
flowRate IsToBeGreaterOrEqualThan targetFlowRate
```
This example requires flow rate to meet or exceed a target.
## IsToBeStrictlyGreaterThan <!-- VERB -->
- Display name: IsToBeStrictlyGreaterThan
- Parent verb: IsToBeGreaterThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should stay strictly greater than the object.
- Examples:
```dwis strictlyGreaterExample
DrillingDataPoint:standpipePressure
DrillingDataPoint:circulationThreshold
standpipePressure IsToBeStrictlyGreaterThan circulationThreshold
```
This example enforces pressure above a circulation threshold.
## IsToBeSmallerThan <!-- VERB -->
- Display name: IsToBeSmallerThan
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should stay below the object.
- Examples:
```dwis smallerThanExample
DrillingDataPoint:torque
DrillingDataPoint:torqueLimit
torque IsToBeSmallerThan torqueLimit
```
This example requires torque to remain under a limit.
## IsToBeSmallerOrEqualThan <!-- VERB -->
- Display name: IsToBeSmallerOrEqualThan
- Parent verb: IsToBeSmallerThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should stay below or equal to the object.
- Examples:
```dwis smallerOrEqualExample
DrillingDataPoint:mudWeight
DrillingDataPoint:maxMudWeight
mudWeight IsToBeSmallerOrEqualThan maxMudWeight
```
This example keeps mud weight at or below a maximum.
## IsToBeStrictlySmallerThan <!-- VERB -->
- Display name: IsToBeStrictlySmallerThan
- Parent verb: IsToBeSmallerThan
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should stay strictly below the object.
- Examples:
```dwis strictlySmallerExample
DrillingDataPoint:wellheadPressure
DrillingDataPoint:fracPressureLimit
wellheadPressure IsToBeStrictlySmallerThan fracPressureLimit
```
This example requires wellhead pressure to be strictly below the fracturing limit.
## IsToBeEqualTo <!-- VERB -->
- Display name: IsToBeEqualTo
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should match the object.
- Examples:
```dwis equalExample
DrillingDataPoint:rotarySpeed
DrillingDataPoint:rotarySetPoint
rotarySpeed IsToBeEqualTo rotarySetPoint
```
This example requires rotary speed to equal its set-point.
## IsToBeDifferentFrom <!-- VERB -->
- Display name: IsToBeDifferentFrom
- Parent verb: IsToBeComparedWith
- Subject class: DrillingDataPoint
- Object class: DrillingDataPoint
- Description: Indicates that the subject should differ from the object.
- Examples:
```dwis differentFromExample
DrillingDataPoint:selectedBitType
DrillingDataPoint:previousBitType
selectedBitType IsToBeDifferentFrom previousBitType
```
This example states that the selected bit type must differ from the previous one.
## IsLocatedAtEquipment <!-- VERB -->
- Display name: Is Located At Equipment
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: Equipment
- Description: Indicates that the drilling data point is associated with a specific piece of equipment.
- Examples:
```dwis IsLocatedAtEquipmentExample
DrillingDataPoint:measurement
Equipment:equiment
measurement IsLocatedAtEquipment equiment
```
This example states that a measurement is located at specific piece of equipment.
## Adjusts <!-- VERB -->
- Display name: Adjusts
- Parent verb: DWISVerb
- Subject class: EstimationParameter
- Object class: DrillingDataPoint
- Description: Indicates that an EstimationParameter is applied to modify the interpretation of a DrillingDataPoint.
- Examples:
```dwis CorrectsExample
DynamicDrillingSignal:ActivePitVolumeAdjustmentParameter
ComputedData:ActivePitVolumeAdjustmentParameter#01
ActivePitVolumeAdjustmentParameter#01 BelongsToClass ContinuousDataType
ActivePitVolumeAdjustmentParameter#01 BelongsToClass EstimationParameter
ActivePitVolumeAdjustmentParameter#01 IsOfMeasurableQuantity VolumeDrilling
ActivePitVolumeAdjustmentParameter#01 HasDynamicValue ActivePitVolumeAdjustmentParameter
DynamicDrillingSignal:ActivePitVolume
DerivedMeasurement:ActivePitVolume#01
ActivePitVolume#01 BelongsToClass ContinuousDataType
ActivePitVolume#01 IsOfMeasurableQuantity VolumeDrilling
ActivePitVolume#01 HasDynamicValue ActivePitVolume
ActivePitVolumeAdjustmentParameter#01 Adjusts ActivePitVolume#01
```
An estimator-produced parameter modifies how the active pit volume measurement must be interpreted, 
without specifying whether the adjustment is additive (bias) or multiplicative (scale).
## Corrects <!-- VERB -->
- Display name: Corrects
- Parent verb: Adjusts
- Subject class: CorrectionFactor
- Object class: DrillingDataPoint
- Description: Indicates that a CorrectionFactor is applied to compensate systematic bias 
in a DrillingDataPoint during interpretation or computation.
- Examples:
```dwis CorrectsExample
DynamicDrillingSignal:EstimatedPitVolumeFlowBias
ComputedData:EstimatedPitVolumeFlowBias#01
EstimatedPitVolumeFlowBias#01 BelongsToClass ContinuousDataType
EstimatedPitVolumeFlowBias#01 BelongsToClass CorrectionFactor
EstimatedPitVolumeFlowBias#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
EstimatedPitVolumeFlowBias#01 HasDynamicValue EstimatedPitVolumeFlowBias
DynamicDrillingSignal:CorrectedActiveVolume
DerivedMeasurement:CorrectedActiveVolume#01
CorrectedActiveVolume#01 BelongsToClass ContinuousDataType
CorrectedActiveVolume#01 HasDynamicValue CorrectedActiveVolume
CorrectedActiveVolume#01 IsOfMeasurableQuantity VolumeDrilling
EstimatedPitVolumeFlowBias#01 Corrects CorrectedActiveVolume#01
```
Estimated bias used to compensate mismatch in pit volume balance.
## Scales <!-- VERB -->
- Display name: Scales
- Parent verb: Adjusts
- Subject class: CalibrationParameter
- Object class: DrillingDataPoint
- Description: Indicates that a CalibrationParameter is applied as a multiplicative factor 
when converting or correcting a DrillingDataPoint.
- Examples:
```dwis ScalesExample
DynamicDrillingSignal:ReturnFlowCapacityScale
ComputedData:ReturnFlowCapacityScale#01
ReturnFlowCapacityScale#01 BelongsToClass ContinuousDataType
ReturnFlowCapacityScale#01 BelongsToClass CalibrationParameter
ReturnFlowCapacityScale#01 IsOfMeasurableQuantity VolumetricFlowrateDrilling
ReturnFlowCapacityScale#01 HasDynamicValue ReturnFlowCapacityScale
DynamicDrillingSignal:ReturnFlowProportion
DerivedMeasurement:ReturnFlowProportion#01
ReturnFlowProportion#01 BelongsToClass ContinuousDataType
ReturnFlowProportion#01 IsOfMeasurableQuantity DimensionLessStandard
ReturnFlowProportion#01 HasDynamicValue ReturnFlowProportion
ReturnFlowCapacityScale#01 Scales ReturnFlowProportion#01
```
A computed calibration parameter representing a volumetric flowrate scale factor is used to 
convert a dimensionless return-flow proportion measurement into a physically interpretable flow quantity.
## IsGainOf <!-- VERB -->
- Display name: Is Gain Of
- Parent verb: Adjusts
- Subject class: CalibrationParameter
- Object class: Transformation
- Description: Indicates that a CalibrationParameter defines the multiplicative gain used by a 
Transformation when producing its output.
- Examples:
```dwis IsGainOfExample
CalibrationParameter:ReturnFlowCapacityScale
ReturnFlowCapacityScale#01 BelongsToClass ContinuousDataType
ReturnFlowCapacityScale#01 HasDynamicValue ReturnFlowCapacityScale
Transformation:ReturnFlowConversion
ReturnFlowCapacityScale#01 IsGainOf ReturnFlowConversion
```
A calibration parameter defines the multiplicative gain used by the return-flow conversion 
transformation when computing its output.