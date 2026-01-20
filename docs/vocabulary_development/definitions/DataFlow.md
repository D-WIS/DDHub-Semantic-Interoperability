- Description: This category captures how data and commands move through the drilling system, covering computation, control, signal conditioning, and telemetry. Controllers are treated as processing units that generate commands from set-points and measurements, and telemetry is treated as a special processing unit that forwards signals with an associated delay.

# NOUNS
## DataFlowNode <!-- NOUN -->
- Display name: Data Flow Node
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A data flow node is a generic term for any node in the data flow graph.
- Examples:
```dwis dataFlowHookload
MeasurementDevice:hookloadSensor
DrillingDataPoint:hookloadSignal
hookloadSignal IsGeneratedBy hookloadSensor
```
This example shows a measurement device acting as a `DataFlowNode` that generates the `hookloadSignal`.
## ComputedState <!-- NOUN -->
- Display name: Computed State
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: A state represents the current configuation of a system.
- Examples:
```dwis holeCleaningState
Interpreter:holeCleaningInterpreter
ComputedState:holeCleaningState
DWISNoun:holeCleaningProcess
holeCleaningState IsComputedBy holeCleaningInterpreter
holeCleaningState IsCurrentStateFor holeCleaningProcess
```
This example shows an interpreter computing the current hole-cleaning state of the drilling process.
## ProceduralState <!-- NOUN -->
- Display name: Procedural State
- Parent class: ComputedState
- Attributes:
- Specialization: A procedural state describes the state of a running procedure.
- Description: Describes the active state within a finite-state procedure such as startup, shutdown, or test sequences.
- Examples:
```dwis circulationStartupState
ProcedureFunction:circulationStartup
ProceduralState:circulationStartupState
circulationStartupState IsInformationForCurrentStateOf circulationStartup
```
This example captures the current state of a circulation startup procedure.
## EnablementState <!-- NOUN -->
- Display name: Enablement State
- Parent class: ProceduralState
- Attributes:
- Specialization: This noun describes some information about the state of enablement of a procedure.
- Description: Indicates whether a procedure or function is allowed to run based on permissives or user choices.
- Examples:
```dwis autoDrillerEnablement
ControllerFunction:autoDriller
EnablementState:autoDrillerEnablement
autoDrillerEnablement IsInformationForCurrentStateOf autoDriller
```
This example states whether the `autoDriller` can be enabled.
## ActivationState <!-- NOUN -->
- Display name: Activation State
- Parent class: ProceduralState
- Attributes:
- Specialization: This noun describes some information about the state of activation of a procedure.
- Description: Indicates that a procedure or function is currently activated and executing its logic.
- Examples:
```dwis autoDrillerActivation
ControllerFunction:autoDriller
ActivationState:autoDrillerActivation
autoDrillerActivation IsInformationForCurrentStateOf autoDriller
```
This example shows the activation state of the `autoDriller`.
## IdlingState <!-- NOUN -->
- Display name: Idling State
- Parent class: ProceduralState
- Attributes:
- Specialization: This noun describes some information about the idling state of a procedure.
- Description: Indicates that a function is enabled but not acting on the process because no transition or control action is required.
- Examples:
```dwis soeIdleState
SOEFunction:swabSurgeLimits
IdlingState:soeIdleState
soeIdleState IsInformationForCurrentStateOf swabSurgeLimits
```
This example captures that the swab/surge limits function is currently idle.
## ProcessState <!-- NOUN -->
- Display name: Process State
- Parent class: ComputedState
- Attributes:
- Specialization: A process state describes the state of a process.
- Description: Describes the current operating condition of a continuous process such as circulation or drilling.
- Examples:
```dwis circulationState
DWISNoun:circulationProcess
ProcessState:stableCirculation
stableCirculation IsCurrentStateFor circulationProcess
```
This example expresses that the circulation process is currently stable.
## PhysicalState <!-- NOUN -->
- Display name: Physical State
- Parent class: ComputedState
- Attributes:
- Specialization: A physical state describes the phyiscal state of a system.
- Description: Captures a computed representation of the physical condition of equipment or the well (e.g., pressure regime, torque state).
- Examples:
```dwis annulusPressureState
Interpreter:wellIntegrityInterpreter
PhysicalState:annulusPressureState
DWISNoun:annulusSection
annulusPressureState IsComputedBy wellIntegrityInterpreter
annulusPressureState IsCurrentStateFor annulusSection
```
This example shows an interpreter estimating the pressure state of an annulus section.
## ComputationUnit <!-- NOUN -->
- Display name: Computation Unit
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
```dwis hydraulicsModel
ComputationUnit:hydraulicsModel
DrillingDataPoint:standpipePressureRaw
DrillingDataPoint:predictedStandpipePressure
standpipePressureRaw IsComputationInput hydraulicsModel
predictedStandpipePressure IsComputedBy hydraulicsModel
```
This example models a hydraulics computation unit that predicts standpipe pressure.
## Advisor <!-- NOUN -->
- Display name: Advisor
- Parent class: ComputationUnit
- Attributes:
  - AdviceType
    - Type: string
    - Description: 
- Specialization:
- Description: An advisor is a computation unit that produces an advice on how to control a process. Its output is typically
an AdvisorySystemAdvice.
- Examples:
```dwis drillingAdvisor
Advisor:drillingAdvisor
DrillingControlAdvice:ropAdvice
ropAdvice IsRecommendedBy drillingAdvisor
```
This example shows an advisor producing a drilling control advice.
## Simulator <!-- NOUN -->
- Display name: Simulator
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: A simulator is a computation unit that tries to replicate the outputs of a process. Its output is typically 
a set of ComputedData, i.e., a specialisation of DrillingDataPoint.
- Examples:
```dwis hydraulicsSimulator
Simulator:hydraulicsSimulator
DrillingDataPoint:annulusPressureForecast
annulusPressureForecast IsComputedBy hydraulicsSimulator
```
This example shows a simulator generating a forecast of annulus pressure.
## Estimator <!-- NOUN -->
- Display name: Estimator
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: An estimator is a computation unit that estimates unmeasured variables of a process. Its output is typically a set of ComputedData, i.e., a specialisation of DrillingDataPoint.
- Examples:
```dwis EstimatorExample
Estimator:cuttingFlowrateEstimator
ComputedData:cuttingFlowrate
cuttingFlowrate IsComputedBy cuttingFlowrateEstimator
```
This example shows an estimator computing the cutting flowrate.
## ModelFitter <!-- NOUN -->
- Display name: Model Fitter
- Parent class: Estimator
- Attributes:
- Specialization:
- Description: A model fitter is a computation unit that fits a model to observed data in order to estimate unmeasured variables of a process. Its output is typically a set of ComputedData, i.e., a specialisation of DrillingDataPoint.
- Examples:
```dwis ModelFitterExample
ModelFitter:YPLModelFitter
DirectMeasurement:flowCurveData
ComputedData:YPLModelParameters
flowCurveData IsComputationInput YPLModelFitter
YPLModelParameters IsComputedBy YPLModelFitter
```
This example shows a model fitter estimating YPL model parameters from flow curve data.
## Interpreter <!-- NOUN -->
- Display name: Interpreter
- Parent class: ComputationUnit
- Attributes:
- Specialization:
- Description: An interpreter is a computation unit that interprets the state of a process. Its output is typically a 
ComputedState.
- Examples:
```dwis stateInterpreter
Interpreter:stateInterpreter
ComputedState:circulationStable
DWISNoun:circulationProcess
circulationStable IsComputedBy stateInterpreter
circulationStable IsCurrentStateFor circulationProcess
```
This example shows an interpreter computing whether circulation is stable.
## ImageInterpreter <!-- NOUN -->
- Display name: Image Interpreter
- Parent class: Interpreter
- Attributes:
- Specialization:
- Description: An image interpreter is a computation unit that interprets images to produce a computed state.
- Examples:
```dwis stateInterpreter
Interpreter:stateInterpreter
ComputedState:circulationStable
DWISNoun:circulationProcess
circulationStable IsComputedBy stateInterpreter
circulationStable IsCurrentStateFor circulationProcess
```
This example shows an interpreter computing whether circulation is stable.
## Controller <!-- NOUN -->
- Display name: Controller
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: A processing unit that generates commands to drive equipment toward desired set-points using feedback.
- Examples:
```dwis autoDrillerController
Controller:autoDrillerController
DrillingDataPoint:weightOnBitSetPoint
DrillingDataPoint:hookloadSignal
weightOnBitSetPoint IsSetPointFor autoDrillerController
hookloadSignal IsComputationInput autoDrillerController
```
This example shows an autodriller controller consuming measurements and a set-point.
## ControlSystem <!-- NOUN -->
- Display name: ControlSystem
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: A collection of controllers, logic, and I/O that supervises a portion of the drilling process.
- Examples:
```dwis drillingControlSystem
ControlSystem:dcs
Controller:autoDrillerController
DWISNoun:topDrive
autoDrillerController Controls topDrive
dcs HasFunction autoDrillerController
```
This example shows a drilling control system that hosts an autodriller controller acting on the top drive.
## HoistingControlSystem <!-- NOUN -->
- Display name: Hoisting Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: A control system focused on hoisting equipment such as the drawworks and blocks.
- Examples:
```dwis hoistingSystem
HoistingControlSystem:hoistingDCS
Controller:hoistController
DWISNoun:drawworks
DrillingDataPoint:hookloadSignal
hookloadSignal IsComputationInput hoistController
hoistController Controls drawworks
hoistingDCS HasFunction hoistController
```
This example shows a hoisting control system governing the drawworks using hookload feedback.
## CirculationControlSystem <!-- NOUN -->
- Display name: Circulation Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: A control system that manages pumps, flow rate, and downhole pressure related to circulation.
- Examples:
```dwis circulationSystem
CirculationControlSystem:circulationDCS
Controller:flowController
DWISNoun:mudPumps
DrillingDataPoint:flowSetPoint
flowSetPoint IsSetPointFor flowController
flowController Controls mudPumps
circulationDCS HasFunction flowController
```
This example shows a circulation control system driving the mud pumps.
## RotationControlSystem <!-- NOUN -->
- Display name: Rotation Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: A control system managing rotary speed and torque for the drill-stem.
- Examples:
```dwis rotationSystem
RotationControlSystem:rotationDCS
Controller:rotationController
DWISNoun:topDrive
DrillingDataPoint:rotationalSpeedSetPoint
rotationalSpeedSetPoint IsSetPointFor rotationController
rotationController Controls topDrive
rotationDCS HasFunction rotationController
```
This example shows a rotation control system adjusting the top-drive speed.
## BOPControlSystem <!-- NOUN -->
- Display name: BOP Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: A control system supervising blowout preventer functions such as rams and annulars.
- Examples:
```dwis bopSystem
BOPControlSystem:bopControl
Controller:bopRamController
DWISNoun:bopRams
DrillingDataPoint:closeCommand
closeCommand IsCommandFor bopRamController
bopRamController Controls bopRams
bopControl HasFunction bopRamController
```
This example shows a BOP control system issuing ram close commands.
## RigChokeControlSystem <!-- NOUN -->
- Display name: Rig Choke Control System
- Parent class: ControlSystem
- Attributes:
- Specialization:
- Description: A control system dedicated to surface choke management for well control operations.
- Examples:
```dwis chokeSystem
RigChokeControlSystem:chokeControl
Controller:chokeController
DWISNoun:surfaceChoke
DrillingDataPoint:standpipePressureSignal
standpipePressureSignal IsComputationInput chokeController
chokeController Controls surfaceChoke
chokeControl HasFunction chokeController
```
This example shows choke control adjusting a surface choke using standpipe pressure feedback.
## MeasurementDevice <!-- NOUN -->
- Display name: Measurement Device
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Denotes a physical sensor
- Examples:
```dwis standpipeSensor
MeasurementDevice:standpipePressureSensor
DrillingDataPoint:standpipePressureRaw
standpipePressureRaw IsMeasuredBy standpipePressureSensor
standpipePressureRaw IsGeneratedBy standpipePressureSensor
```
This example shows a standpipe pressure sensor producing a raw signal.
## Transformation <!-- NOUN -->
- Display name: Transformation
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Represents a transformation applied to some signals that produces other signals
- Examples:
```dwis depthMerge
Transformation:depthMerge
DrillingDataPoint:pipeTallyDepth
DrillingDataPoint:blockHeightDepth
DrillingDataPoint:computedDepth
pipeTallyDepth IsTransformationInput depthMerge
blockHeightDepth IsTransformationInput depthMerge
computedDepth IsTransformationOutput depthMerge
```
This example merges two depth sources into a computed depth signal.
## DirectTransformation <!-- NOUN -->
- Display name: Direct Transformation
- Parent class: Transformation
- Attributes:
- Specialization:
- Description: Direct transformations are performed using only the current value of their inputs, time is not involved
- Examples:
```dwis densityFromPressure
DirectTransformation:densityFromPressure
DrillingDataPoint:standpipePressureRaw
DrillingDataPoint:equivalentDensity
standpipePressureRaw IsTransformationInput densityFromPressure
equivalentDensity IsTransformationOutput densityFromPressure
```
This example converts a pressure measurement to an equivalent circulating density using only the latest value.
## Aggregation <!-- NOUN -->
- Display name: Aggregation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Combines several input signals into a single representative value such as an average or sum.
- Examples:
```dwis hookloadAggregation
Aggregation:hookloadAggregation
DrillingDataPoint:hookloadLeft
DrillingDataPoint:hookloadRight
DrillingDataPoint:hookloadAverage
hookloadLeft IsTransformationInput hookloadAggregation
hookloadRight IsTransformationInput hookloadAggregation
hookloadAverage IsTransformationOutput hookloadAggregation
```
This example averages two hookload measurements.
## ForceFromLoadPinsTransformation <!-- NOUN -->
- Display name: Force From Load Pins Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Converts raw load pin readings into a usable force signal.
- Examples:
```dwis loadPinForce
ForceFromLoadPinsTransformation:loadPinForce
DrillingDataPoint:loadPinReading
DrillingDataPoint:hookloadForce
loadPinReading IsTransformationInput loadPinForce
hookloadForce IsTransformationOutput loadPinForce
```
This example derives hookload force from load pin readings.
## ForceToLoadTransformation <!-- NOUN -->
- Display name: Force To Load Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Converts a force signal into a load expressed for another context (e.g., block load).
- Examples:
```dwis forceToBlockLoad
ForceToLoadTransformation:forceToBlockLoad
DrillingDataPoint:hookloadForce
DrillingDataPoint:blockLoad
hookloadForce IsTransformationInput forceToBlockLoad
blockLoad IsTransformationOutput forceToBlockLoad
```
This example converts hookload force into an equivalent block load.
## MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: Measured Depth To True Vertical Depth Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Converts measured depth to true vertical depth using well trajectory information.
- Examples:
```dwis mdtvd
MeasuredDepthToTrueVerticalDepthTransformation:mdToTvd
DrillingDataPoint:measuredDepth
DrillingDataPoint:trueVerticalDepth
measuredDepth IsTransformationInput mdToTvd
trueVerticalDepth IsTransformationOutput mdToTvd
```
This example computes true vertical depth from measured depth.
## SummationTransformation <!-- NOUN -->
- Display name: SummationTransformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Sums up all the input signals to produce the output signal.
- Examples:
```dwis DWOBTaringExample
SummationTransformation:taringTransformation
DrillingDataPoint:rawAxialLoad
DrillingDataPoint:tare
DrillingDataPoint:WOBTared
rawAxialLoad IsTransformationInput taringTransformation
tare IsTransformationInput taringTransformation
WOBTared IsTransformationOutput taringTransformation
```
This example shows how the raw axial load is transformed into a tared WOB by adding a tare value.
## MeasuredDepthTranslation <!-- NOUN -->
- Display name: Measured Depth Translation
- Parent class: SummationTransformation
- Attributes:
- Specialization:
- Description: Applies an offset or calibration factor to a measured depth signal.
- Examples:
```dwis depthTranslation
MeasuredDepthTranslation:depthTranslation
DrillingDataPoint:rawMeasuredDepth
DrillingDataPoint:correctedMeasuredDepth
rawMeasuredDepth IsTransformationInput depthTranslation
correctedMeasuredDepth IsTransformationOutput depthTranslation
```
This example corrects a measured depth value with an offset.
## PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: Pressure To Equivalent Density Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Converts a pressure measurement into an equivalent circulating density for pressure management.
- Examples:
```dwis pressureToECD
PressureToEquivalentDensityTransformation:pressureToEcd
DrillingDataPoint:annulusPressure
DrillingDataPoint:equivalentDensity
annulusPressure IsTransformationInput pressureToEcd
equivalentDensity IsTransformationOutput pressureToEcd
```
This example computes equivalent circulating density from annulus pressure.
## PressureToForceTransformation <!-- NOUN -->
- Display name: Pressure To Force Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Converts pressure over an area into a resulting force signal.
- Examples:
```dwis pressureToForce
PressureToForceTransformation:pressureToForce
DrillingDataPoint:surfacePressure
DrillingDataPoint:appliedForce
surfacePressure IsTransformationInput pressureToForce
appliedForce IsTransformationOutput pressureToForce
```
This example converts pressure at the surface into force on a piston.
## TorqueToForceTransformation <!-- NOUN -->
- Display name: Torque To Force Transformation
- Parent class: DirectTransformation
- Attributes:
- Specialization:
- Description: Converts torque measured at a radius into an equivalent tangential force.
- Examples:
```dwis torqueToForce
TorqueToForceTransformation:torqueToForce
DrillingDataPoint:surfaceTorque
DrillingDataPoint:tangentialForce
surfaceTorque IsTransformationInput torqueToForce
tangentialForce IsTransformationOutput torqueToForce
```
This example converts surface torque into tangential force at the bit radius.
## SignalProcessingUnit <!-- NOUN -->
- Display name: Signal Processing Unit
- Parent class: Transformation
- Attributes:
- Specialization:
- Description: Represent any signal processing applied prior to the distribution of the considered signal. Signal processing refers to e.g. noise removal, filtering..
- Examples:
```dwis standpipeSignalProcessing
SignalProcessingUnit:standpipeSignalProcessing
DrillingDataPoint:standpipePressureRaw
DrillingDataPoint:standpipePressureFiltered
standpipePressureRaw IsTransformationInput standpipeSignalProcessing
standpipePressureFiltered IsTransformationOutput standpipeSignalProcessing
```
This example shows generic signal processing applied to standpipe pressure.
## Filter <!-- NOUN -->
- Display name: Filter
- Parent class: SignalProcessingUnit
- Attributes:
- Specialization:
- Description: A signal processing unit that attenuates unwanted frequency components.
- Examples:
```dwis hookloadFilter
Filter:hookloadFilter
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadFiltered
hookloadRaw IsTransformationInput hookloadFilter
hookloadFiltered IsTransformationOutput hookloadFilter
```
This example filters high-frequency noise from a hookload signal.
## BandPassFilter <!-- NOUN -->
- Display name: Band Pass Filter
- Parent class: Filter
- Attributes:
  - MinFrequency
    - Type: double
    - Description: 
  - MaxFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: A filter that only keeps signal components within a defined frequency band.
- Examples:
```dwis vibrationBandPass
BandPassFilter:vibrationBandPass
vibrationBandPass.MinFrequency = "0.5"
vibrationBandPass.MaxFrequency = "10.0"
DrillingDataPoint:torsionalVibrationRaw
DrillingDataPoint:torsionalVibrationBand
torsionalVibrationRaw IsTransformationInput vibrationBandPass
torsionalVibrationBand IsTransformationOutput vibrationBandPass
```
This example extracts torsional vibration content within a target band.
## HighPassFilter <!-- NOUN -->
- Display name: High Pass Filter
- Parent class: Filter
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: A filter that removes low-frequency content below a chosen cutoff.
- Examples:
```dwis accelerationHighPass
HighPassFilter:accelerationHighPass
accelerationHighPass.CutOffFrequency = "0.2"
DrillingDataPoint:accelerometerRaw
DrillingDataPoint:accelerometerHighPassed
accelerometerRaw IsTransformationInput accelerationHighPass
accelerometerHighPassed IsTransformationOutput accelerationHighPass
```
This example high-pass filters an accelerometer signal.
## LowPassFilter <!-- NOUN -->
- Display name: Low Pass Filter
- Parent class: Filter
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: A filter that removes high-frequency content above a chosen cutoff.
- Examples:
```dwis standpipeLowPass
LowPassFilter:standpipeLowPass
standpipeLowPass.CutOffFrequency = "2.5"
DrillingDataPoint:standpipePressureRaw
DrillingDataPoint:standpipePressureLowPassed
standpipePressureRaw IsTransformationInput standpipeLowPass
standpipePressureLowPassed IsTransformationOutput standpipeLowPass
```
This example low-pass filters standpipe pressure to remove spikes.
## MovingAverage <!-- NOUN -->
- Display name: Moving Average
- Parent class: Filter
- Attributes:
- Specialization:
- Description: A filter computing a rolling mean over a fixed window.
- Examples:
```dwis hookloadMovingAverage
MovingAverage:hookloadMovingAverage
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadMean
hookloadRaw IsTransformationInput hookloadMovingAverage
hookloadMean IsTransformationOutput hookloadMovingAverage
```
This example applies a moving average to smooth hookload.
## MovingStandardDeviation <!-- NOUN -->
- Display name: Moving Standard Deviation
- Parent class: Filter
- Attributes:
- Specialization:
- Description: Computes the rolling standard deviation of an input signal.
- Examples:
```dwis vibrationStd
MovingStandardDeviation:vibrationStd
DrillingDataPoint:torsionalVibrationBand
DrillingDataPoint:torsionalVibrationStd
torsionalVibrationBand IsTransformationInput vibrationStd
torsionalVibrationStd IsTransformationOutput vibrationStd
```
This example tracks the standard deviation of a vibration signal.
## MovingMin <!-- NOUN -->
- Display name: Moving Min
- Parent class: Filter
- Attributes:
- Specialization:
- Description: Tracks the minimum value within a sliding window.
- Examples:
```dwis hookloadMovingMin
MovingMin:hookloadMovingMin
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadMin
hookloadRaw IsTransformationInput hookloadMovingMin
hookloadMin IsTransformationOutput hookloadMovingMin
```
This example tracks the minimum hookload over a recent window.
## MovingMax <!-- NOUN -->
- Display name: Moving Max
- Parent class: Filter
- Attributes:
- Specialization:
- Description: Tracks the maximum value within a sliding window.
- Examples:
```dwis hookloadMovingMax
MovingMax:hookloadMovingMax
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadMax
hookloadRaw IsTransformationInput hookloadMovingMax
hookloadMax IsTransformationOutput hookloadMovingMax
```
This example tracks the maximum hookload over a recent window.
```dwis shakerLoadMovingMaxExample
DynamicDrillingSignal:CleanSightMaxCavingSize
ComputedData:CleanSightMaxCavingSize#01
CleanSightMaxCavingSize#01 BelongsToClass JSonDataType
CleanSightMaxCavingSize#01 HasDynamicValue CleanSightMaxCavingSize
CleanSightMaxCavingSize#01 IsOfMeasurableQuantity LengthSmall
TopSideTelemetry:topSideTelemetry
CleanSightMaxCavingSize#01 IsTransmittedBy topSideTelemetry
MovingMax:movingMaxCleanSightMaxCavingSize
CleanSightMaxCavingSize#01 IsTransformationOutput movingMaxCleanSightMaxCavingSize
CuttingSeparatorLogical:ShaleShakerElement#01
CleanSightMaxCavingSize#01 IsHydraulicEstimationAt ShaleShakerElement#01
DrillingLiquidType:DrillingFluid#01
DrillingFluid#01 IsFluidTypeLocatedAt ShaleShakerElement#01
CuttingsComponent:Cuttings#01
Cuttings#01 IsAComponentOf DrillingFluid#01
CleanSightMaxCavingSize#01 ConcernsAFluidComponent Cuttings#01
Interpreter:ImageInterprer#01
CleanSightMaxCavingSize#01 IsComputedBy ImageInterprer#01
InstrumentationCompany:DrillDocs#01
CleanSightMaxCavingSize#01 IsProvidedBy DrillDocs#01
```
This example defines a moving max transformation that computes the maximum caving size from shaker load measurements.
## MovingDistribution <!-- NOUN -->
- Display name: Moving Distribution
- Parent class: Filter
- Attributes:
- Specialization:
- Description: Tracks the distribution of a value within a sliding window.
- Examples:
```dwis hookloadMovingDistribution
MovingDistribution:hookloadMovingDistribution
Measurement:hookloadRaw
JSonDataType:hookloadDistribution
hookloadRaw IsTransformationInput hookloadMovingDistribution
hookloadDistribution IsTransformationOutput hookloadMovingDistribution
```
This example indicates that the hookload distribution is calculated from raw hook load measurements over a moving window.
```dwis ShakerLoadDistributionExample
DynamicDrillingSignal:CleanSightShakerLoadDistribution
ComputedData:CleanSightShakerLoadDistribution#01
CleanSightShakerLoadDistribution#01 BelongsToClass JSonDataType
CleanSightShakerLoadDistribution#01 HasDynamicValue CleanSightShakerLoadDistribution
CleanSightShakerLoadDistribution#01 IsOfMeasurableQuantity ProportionStandard
TopSideTelemetry:topSideTelemetry
CleanSightShakerLoadDistribution#01 IsTransmittedBy topSideTelemetry
MovingDistribution:movingDistribution
CleanSightShakerLoadDistribution#01 IsTransformationOutput movingDistribution
CuttingSeparatorLogical:ShaleShakerElement#01
CleanSightShakerLoadDistribution#01 IsHydraulicEstimationAt ShaleShakerElement#01
DrillingLiquidType:DrillingFluid#01
DrillingFluid#01 IsFluidTypeLocatedAt ShaleShakerElement#01
Interpreter:ImageInterprer#01
CleanSightShakerLoadDistribution#01 IsComputedBy ImageInterprer#01
InstrumentationCompany:DrillDocs#01
CleanSightShakerLoadDistribution#01 IsProvidedBy DrillDocs#01
```
This example defines a moving distribution transformation that computes the distribution of shaker load measurements.
## NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: Number Of Sample Moving Average
- Parent class: MovingAverage
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Specialization:
- Description: Moving average defined by a fixed number of samples.
- Examples:
```dwis hookloadSampleAverage
NumberOfSampleMovingAverage:hookloadSampleAverage
hookloadSampleAverage.NumberOfSamples = "50"
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadMean50
hookloadRaw IsTransformationInput hookloadSampleAverage
hookloadMean50 IsTransformationOutput hookloadSampleAverage
```
This example averages the last 50 hookload samples.
## TimeWindowMovingAverage <!-- NOUN -->
- Display name: Time Window Moving Average
- Parent class: MovingAverage
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: Moving average defined by a time duration window.
- Examples:
```dwis hookloadTimeAverage
TimeWindowMovingAverage:hookloadTimeAverage
hookloadTimeAverage.TimeWindow = "10.0"
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadMean10s
hookloadRaw IsTransformationInput hookloadTimeAverage
hookloadMean10s IsTransformationOutput hookloadTimeAverage
```
This example averages hookload over the last ten seconds.
## TimeBasedTransformation <!-- NOUN -->
- Display name: Time Based Transformation
- Parent class: Transformation
- Attributes:
- Specialization:
- Description: Transformations that apply only to time series: time derivations, time integration, averaging...
- Examples:
```dwis timeBasedDerivative
TimeBasedTransformation:timeDerivative
DrillingDataPoint:blockHeight
DrillingDataPoint:blockVelocity
blockHeight IsTransformationInput timeDerivative
blockVelocity IsTransformationOutput timeDerivative
```
This example represents a time-based derivative computing block velocity from height.
## Buffering <!-- NOUN -->
- Display name: Buffering
- Parent class: TimeBasedTransformation
- Attributes:
  - BufferingInterval
    - Type: double
    - Description: 
- Specialization:
- Description: Stores a time slice of data before forwarding it, often to align or batch records.
- Examples:
```dwis blockHeightBuffer
Buffering:blockHeightBuffer
blockHeightBuffer.BufferingInterval = "5.0"
DrillingDataPoint:blockHeight
DrillingDataPoint:blockHeightBuffered
blockHeight IsBufferingInput blockHeightBuffer
blockHeightBuffered IsBufferingOutput blockHeightBuffer
```
This example buffers block height values over a five-second interval.
## Derivation <!-- NOUN -->
- Display name: Derivation
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: Computes the derivative of a time series.
- Examples:
```dwis weightOnBitDerivative
Derivation:weightOnBitDerivative
DrillingDataPoint:weightOnBit
DrillingDataPoint:weightOnBitRate
weightOnBit IsDerivationInput weightOnBitDerivative
weightOnBitRate IsDerivedFrom weightOnBit
```
This example derives the rate of change of weight on bit.
## Integration <!-- NOUN -->
- Display name: Integration
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: Integrates a time series over time.
- Examples:
```dwis flowIntegration
Integration:flowIntegration
DrillingDataPoint:flowRate
DrillingDataPoint:pumpedVolume
flowRate IsTransformationInput flowIntegration
pumpedVolume IsIntegratedFrom flowRate
```
This example integrates flow rate to compute pumped volume.
## RangeExtraction <!-- NOUN -->
- Display name: Range Extraction
- Parent class: TimeBasedTransformation
- Attributes:
- Specialization:
- Description: Extracts a subset of data either by count or time span.
- Examples:
```dwis windowSelection
RangeExtraction:windowSelection
DrillingDataPoint:standpipePressureRaw
DrillingDataPoint:standpipePressureWindow
standpipePressureRaw IsTransformationInput windowSelection
standpipePressureWindow IsTransformationOutput windowSelection
```
This example extracts a recent window of standpipe pressure values.
## NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: Number Of Items Range Extraction
- Parent class: RangeExtraction
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Specialization:
- Description: Extracts the latest N samples from a signal.
- Examples:
```dwis lastSamplesSelection
NumberOfItemsRangeExtraction:lastSamplesSelection
lastSamplesSelection.NumberOfItems = "200"
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadLast200
hookloadRaw IsTransformationInput lastSamplesSelection
hookloadLast200 IsTransformationOutput lastSamplesSelection
```
This example selects the last 200 hookload samples.
## TimeWindowRangeExtraction <!-- NOUN -->
- Display name: Time Window Range Extraction
- Parent class: RangeExtraction
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: Extracts samples from a signal over a defined time window.
- Examples:
```dwis lastTenSeconds
TimeWindowRangeExtraction:lastTenSeconds
lastTenSeconds.TimeWindow = "10.0"
DrillingDataPoint:standpipePressureRaw
DrillingDataPoint:standpipePressure10s
standpipePressureRaw IsTransformationInput lastTenSeconds
standpipePressure10s IsTransformationOutput lastTenSeconds
```
This example captures standpipe pressure values from the last ten seconds.
## Resampling <!-- NOUN -->
- Display name: Resampling
- Parent class: TimeBasedTransformation
- Attributes:
  - ResamplingRate
    - Type: double
    - Description: 
  - ResamplingDelay
    - Type: double
    - Description: 
  - Validity
    - Type: double
    - Description: 
- Specialization:
- Description: Adjusts the sampling rate of a signal and can annotate the validity of the resampled points.
- Examples:
```dwis resampleHookload
Resampling:resampleHookload
resampleHookload.ResamplingRate = "1.0"
resampleHookload.ResamplingDelay = "0.1"
DrillingDataPoint:hookloadRaw
DrillingDataPoint:hookloadResampled
hookloadRaw IsResamplingInput resampleHookload
hookloadResampled IsResampledBy resampleHookload
```
This example resamples hookload to 1 Hz with a small delay.
## TransmissionLine <!-- NOUN -->
- Display name: Transmission Line
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: Represents telemetry or wiring that forwards a signal, potentially with delay or duplication.
- Examples:
```dwis surfaceToDownholeTelemetry
TransmissionLine:surfaceToDownholeTelemetry
DrillingDataPoint:surfaceCommand
DrillingDataPoint:downholeCommand
surfaceCommand IsTransmissionInput surfaceToDownholeTelemetry
downholeCommand IsTransmissionOutput surfaceToDownholeTelemetry
```
This example models a telemetry link forwarding a surface command to a downhole tool.
## UserInterface <!-- NOUN -->
- Display name: User Interface
- Parent class: DataFlowNode
- Attributes:
- Specialization:
- Description: The human-machine interface through which operators view data and enter commands.
- Examples:
```dwis drillerHMI
UserInterface:drillerHMI
DrillingDataPoint:standpipePressureDisplay
DrillingDataPoint:flowRateCommand
standpipePressureDisplay IsTransmissionOutput drillerHMI
flowRateCommand IsCommandFor drillerHMI
```
This example shows an HMI displaying pressure and accepting a flow-rate command.


# VERBS
## IsSubSystemOf <!-- VERB -->
- Display name: IsSubSystemOf
- Parent verb: DWISVerb
- Subject class: DataFlowNode
- Object class: DataFlowNode
- Description: Indicates that a data flow node is part of a larger system or control structure.
- Examples: 
```dwis IsSubSystemOfExample
MeasurementDevice:inlineRheometer
ModelFitter:YPLModelFitter
YPLModelFitter IsSubSystemOf inlineRheometer
```
This example shows that the YPL model fitter is part of an inline rheometer.
## Controls <!-- VERB -->
- Display name: Controls
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Indicates that a data flow node drives or regulates another equipment or function.
- Examples: 
```dwis hoistingControl
Controller:hoistController
DWISNoun:drawworks
hoistController Controls drawworks
```
This example shows a hoist controller acting on the drawworks.
## HasFunction <!-- VERB -->
- Display name: Has Function
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: Connects a signal to the data flow node that produced it or to the function it relates to.
- Examples: 
```dwis autodrillerFunctionSignal
ControlSystem:dcs
DrillingDataPoint:autodrillerStatus
autodrillerStatus HasFunction dcs
```
This example links an autodriller status signal to the drilling control system providing it.
## IsCommandFor <!-- VERB -->
- Display name: Is Command For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: Marks a signal as a command sent to a specific node or equipment.
- Examples: 
```dwis pumpCommand
DrillingDataPoint:flowRateCommand
Controller:flowController
flowRateCommand IsCommandFor flowController
```
This example designates a flow-rate command for the flow controller.
## IsComputationInput <!-- VERB -->
- Display name: Is Computation Input
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ComputationUnit
- Description: Indicates that a signal is used as an input by a computation unit.
- Examples: 
```dwis computationInput
DrillingDataPoint:standpipePressureRaw
ComputationUnit:hydraulicsModel
standpipePressureRaw IsComputationInput hydraulicsModel
```
This example shows raw standpipe pressure used by a hydraulics model.
## IsLimitFor <!-- VERB -->
- Display name: Is Limit For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: Declares that a signal expresses a limit relevant to a node or function.
- Examples: 
```dwis wobLimit
DrillingDataPoint:wobLimit
ControllerFunction:autoDriller
wobLimit IsLimitFor autoDriller
```
This example ties a WOB limit to the autodriller.
## IsMinimumLimitFor <!-- VERB -->
- Display name: Is Minimum Limit For
- Parent verb: IsLimitFor
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: Indicates that the signal represents the minimum acceptable bound for a function or equipment.
- Examples: 
```dwis minFlowLimit
DrillingDataPoint:minFlowRateLimit
CirculationControlSystem:circulationDCS
minFlowRateLimit IsMinimumLimitFor circulationDCS
```
This example sets a minimum flow-rate limit for the circulation control system.
## IsMaximumLimitFor <!-- VERB -->
- Display name: Is Maximum Limit For
- Parent verb: IsLimitFor
- Subject class: DrillingDataPoint
- Object class: DWISNoun
- Description: Indicates that the signal represents the maximum acceptable bound for a function or equipment.
- Examples: 
```dwis maxTorqueLimit
DrillingDataPoint:maxTorqueLimit
RotationControlSystem:rotationDCS
maxTorqueLimit IsMaximumLimitFor rotationDCS
```
This example sets a maximum torque limit for the rotation control system.
## IsCurrentStateFor <!-- VERB -->
- Display name: Is Current State For
- Parent verb: HasFunction
- Subject class: ComputedState
- Object class: DWISNoun
- Description: Indicates that a computed state represents the present state of a target object or process.
- Examples: 
```dwis circulationStateInfo
ComputedState:circulationStable
DWISNoun:circulationProcess
circulationStable IsCurrentStateFor circulationProcess
```
This example declares that `circulationStable` is the current state of the circulation process.
## IsInformationForCurrentStateOf <!-- VERB -->
- Display name: Is Information For Current State Of
- Parent verb: HasFunction
- Subject class: ComputedState
- Object class: DWISNoun
- Description: Provides supporting information about the current state of an object or process.
- Examples: 
```dwis autodrillerStatusInfo
ComputedState:autoDrillerActivation
ControllerFunction:autoDriller
autoDrillerActivation IsInformationForCurrentStateOf autoDriller
```
This example supplies activation status for the autodriller.
## IsInSafeModeStateFor <!-- VERB -->
- Display name: Is In Safe Mode State For
- Parent verb: IsInformationForCurrentStateOf
- Subject class: ComputedState
- Object class: DWISNoun
- Description: Indicates that the target object or process is currently in a safe or fallback mode.
- Examples:
```dwis safeModeState
ComputedState:safeModeActive
ControlSystem:dcs
safeModeActive IsInSafeModeStateFor dcs
```
This example records that the control system is in safe mode.
## IsSetPointFor <!-- VERB -->
- Display name: Is Set-Point For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: Controller
- Description: Identifies a signal that provides a target value to a controller.
- Examples: 
```dwis weightOnBitSetPoint
DrillingDataPoint:wobSetPoint
Controller:autoDrillerController
wobSetPoint IsSetPointFor autoDrillerController
```
This example assigns a weight-on-bit set-point to the autodriller controller.
## IsSetPointRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Recommendation For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: Marks a signal as a recommended set-point produced for a control system.
- Examples: 
```dwis recommendedFlowRate
DrillingDataPoint:flowRateRecommendation
CirculationControlSystem:circulationDCS
flowRateRecommendation IsSetPointRecommendationFor circulationDCS
```
This example recommends a flow-rate set-point for the circulation control system.
## IsSetPointAdviceFor <!-- VERB -->
- Display name: Is Set-Point Advice For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: Indicates an advisory set-point that may be reviewed before being applied to a control system.
- Examples: 
```dwis advisedRotarySpeed
DrillingDataPoint:rotarySpeedAdvice
RotationControlSystem:rotationDCS
rotarySpeedAdvice IsSetPointAdviceFor rotationDCS
```
This example provides an advisory rotational speed for the rotation control system.
## IsSetPointMinimumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Minimum Recommendation For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: Indicates a recommended minimum bound for a control system set-point.
- Examples: 
```dwis minFlowRecommendation
DrillingDataPoint:minFlowRecommendation
CirculationControlSystem:circulationDCS
minFlowRecommendation IsSetPointMinimumRecommendationFor circulationDCS
```
This example sets a recommended minimum flow for the circulation control system.
## IsSetPointMinimumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Minimum Advice For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: Provides an advisory minimum bound for a control system set-point.
- Examples: 
```dwis minTorqueAdvice
DrillingDataPoint:minTorqueAdvice
RotationControlSystem:rotationDCS
minTorqueAdvice IsSetPointMinimumAdviceFor rotationDCS
```
This example advises a minimum torque limit for the rotation control system.
## IsSetPointMaximumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Maximum Recommendation For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: Indicates a recommended maximum bound for a control system set-point.
- Examples: 
```dwis maxFlowRecommendation
DrillingDataPoint:maxFlowRecommendation
CirculationControlSystem:circulationDCS
maxFlowRecommendation IsSetPointMaximumRecommendationFor circulationDCS
```
This example sets a recommended maximum flow rate for the circulation control system.
## IsSetPointMaximumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Maximum Advice For
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: ControlSystem
- Description: Provides an advisory maximum bound for a control system set-point.
- Examples: 
```dwis maxRotarySpeedAdvice
DrillingDataPoint:maxRotarySpeedAdvice
RotationControlSystem:rotationDCS
maxRotarySpeedAdvice IsSetPointMaximumAdviceFor rotationDCS
```
This example advises a maximum rotational speed for the rotation control system.
## IsTransformationInput <!-- VERB -->
- Display name: Is Transformation Input
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: Transformation
- Description: Declares that a signal is used as an input to a transformation node.
- Examples: 
```dwis hookloadToForceInput
DrillingDataPoint:hookloadRaw
ForceToLoadTransformation:forceToBlockLoad
hookloadRaw IsTransformationInput forceToBlockLoad
```
This example shows hookload used as input to a conversion transformation.
## IsBufferingInput <!-- VERB -->
- Display name: Is Buffering Input
- Parent verb: IsTransformationInput
- Subject class: DrillingDataPoint
- Object class: Buffering
- Description: Identifies a signal that enters a buffering stage.
- Examples: 
```dwis bufferingInput
DrillingDataPoint:blockHeight
Buffering:blockHeightBuffer
blockHeight IsBufferingInput blockHeightBuffer
```
This example shows block height entering a buffer.
## IsDerivationInput <!-- VERB -->
- Display name: Is Derivation Input
- Parent verb: IsTransformationInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Identifies a signal used as the basis for a derivative calculation.
- Examples: 
```dwis derivativeInput
DrillingDataPoint:hookloadRaw
Derivation:hookloadDerivative
hookloadRaw IsDerivationInput hookloadDerivative
```
This example feeds hookload into a derivative computation.
## IsResamplingInput <!-- VERB -->
- Display name: Is Resampling Input
- Parent verb: IsTransformationInput
- Subject class: DrillingDataPoint
- Object class: Resampling
- Description: Marks a signal that will be resampled to a new rate.
- Examples: 
```dwis resamplingInput
DrillingDataPoint:hookloadRaw
Resampling:resampleHookload
hookloadRaw IsResamplingInput resampleHookload
```
This example shows hookload as input to a resampling transformation.
## IsTransmissionInput <!-- VERB -->
- Display name: Is Transmission Input
- Parent verb: HasFunction
- Subject class: DrillingDataPoint
- Object class: TransmissionLine
- Description: Declares that a signal enters a transmission line for forwarding.
- Examples: 
```dwis telemetryInput
DrillingDataPoint:surfaceCommand
TransmissionLine:surfaceToDownholeTelemetry
surfaceCommand IsTransmissionInput surfaceToDownholeTelemetry
```
This example shows a surface command entering a telemetry link.
## IsGeneratedBy <!-- VERB -->
- Display name: Is Generated By
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: Indicates which data flow node produced a given signal.
- Examples: 
```dwis generatedBySensor
DrillingDataPoint:standpipePressureRaw
MeasurementDevice:standpipePressureSensor
standpipePressureRaw IsGeneratedBy standpipePressureSensor
```
This example states that a standpipe pressure signal is generated by its sensor.
## IsComputedBy <!-- VERB -->
- Display name: Is Computed By
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Links a computed value or state to the computation unit that produced it.
- Examples: 
```dwis computedByModel
DrillingDataPoint:predictedStandpipePressure
Simulator:hydraulicsSimulator
predictedStandpipePressure IsComputedBy hydraulicsSimulator
```
This example attributes a predicted pressure signal to a simulator.
## IsMeasuredBy <!-- VERB -->
- Display name: Is Measured By
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Associates a measured signal with the physical measurement device that collected it.
- Examples: 
```dwis measuredBySensor
DrillingDataPoint:hookloadRaw
MeasurementDevice:hookloadSensor
hookloadRaw IsMeasuredBy hookloadSensor
```
This example shows hookload measured by a load-pin sensor.
## IsRecordedFrom <!-- VERB -->
- Display name: Is Recorded From
- Parent verb: IsGeneratedBy
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Indicates that a signal was recorded from another data source or channel.
- Examples: 
```dwis recordedFromTelemetry
DrillingDataPoint:downholeAnnulusPressure
TransmissionLine:surfaceToDownholeTelemetry
downholeAnnulusPressure IsRecordedFrom surfaceToDownholeTelemetry
```
This example records a downhole pressure signal received over telemetry.
## IsTransformationOutput <!-- VERB -->
- Display name: Is Transformation Output
- Parent verb: IsGeneratedBy
- Subject class: DrillingDataPoint
- Object class: DataFlowNode
- Description: Identifies a signal as the result of a transformation node.
- Examples: 
```dwis transformedOutput
DrillingDataPoint:hookloadFiltered
Filter:hookloadFilter
hookloadFiltered IsTransformationOutput hookloadFilter
```
This example marks the filtered hookload as the output of a filter.
```dwis AverageShakerLoadEstimateExample
DynamicDrillingSignal:CleanSightAverageShakerLoadEstimate
ComputedData:CleanSightAverageShakerLoadEstimate#01
CleanSightAverageShakerLoadEstimate#01 BelongsToClass ContinuousDataType
CleanSightAverageShakerLoadEstimate#01 HasDynamicValue CleanSightAverageShakerLoadEstimate
CleanSightAverageShakerLoadEstimate#01 IsOfMeasurableQuantity DimensionLessStandard
TopSideTelemetry:topSideTelemetry
CleanSightAverageShakerLoadEstimate#01 IsTransmittedBy topSideTelemetry
MovingAverage:movingAverageCleanSightAverageShakerLoadEstimate
CleanSightAverageShakerLoadEstimate#01 IsTransformationOutput movingAverageCleanSightAverageShakerLoadEstimate
DynamicDrillingSignal:Sigma_AverageShakerLoadEstimate
DrillingDataPoint:Sigma_AverageShakerLoadEstimate#01
Sigma_AverageShakerLoadEstimate#01 BelongsToClass ContinuousDataType
Sigma_AverageShakerLoadEstimate#01 IsOfMeasurableQuantity DimensionLessStandard
Sigma_AverageShakerLoadEstimate#01 HasDynamicValue Sigma_AverageShakerLoadEstimate
GaussianUncertainty:GaussianUncertaintyCleanSightAverageShakerLoadEstimate#01
CleanSightAverageShakerLoadEstimate#01 HasUncertainty GaussianUncertaintyCleanSightAverageShakerLoadEstimate#01
GaussianUncertaintyCleanSightAverageShakerLoadEstimate#01 HasUncertaintyMean CleanSightAverageShakerLoadEstimate#01
GaussianUncertaintyCleanSightAverageShakerLoadEstimate#01 HasUncertaintyStandardDeviation Sigma_AverageShakerLoadEstimate#01
CuttingSeparatorLogical:ShaleShakerElement#01
DrillingLiquidType:DrillingFluid#01
DrillingFluid#01 IsFluidTypeLocatedAt ShaleShakerElement#01
CleanSightAverageShakerLoadEstimate#01 IsHydraulicEstimationAt ShaleShakerElement#01
Interpreter:ImageInterpreter#01
CleanSightAverageShakerLoadEstimate#01 IsComputedBy ImageInterpreter#01
InstrumentationCompany:DrillDocs#01
CleanSightAverageShakerLoadEstimate#01 IsProvidedBy DrillDocs#01
```
This example defines a moving average transformation that computes the average shaker load estimate.
## IsBufferingOutput <!-- VERB -->
- Display name: Is Buffering Output
- Parent verb: IsTransformationOutput
- Subject class: DrillingDataPoint
- Object class: Buffering
- Description: Indicates a signal emitted after buffering.
- Examples: 
```dwis bufferingOutput
DrillingDataPoint:blockHeightBuffered
Buffering:blockHeightBuffer
blockHeightBuffered IsBufferingOutput blockHeightBuffer
```
This example identifies the buffered block height signal.
## IsDerivedFrom <!-- VERB -->
- Display name: Is Derived From
- Parent verb: IsTransformationOutput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: States that a signal is obtained by differentiating another signal.
- Examples: 
```dwis derivedFromHookload
DrillingDataPoint:hookloadRate
DrillingDataPoint:hookloadRaw
hookloadRate IsDerivedFrom hookloadRaw
```
This example notes that hookload rate is derived from the raw hookload.
## IsIntegratedFrom <!-- VERB -->
- Display name: Is Integrated From
- Parent verb: IsTransformationOutput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Indicates that a signal is obtained by integrating another signal.
- Examples: 
```dwis integratedFromFlow
DrillingDataPoint:pumpedVolume
DrillingDataPoint:flowRate
pumpedVolume IsIntegratedFrom flowRate
```
This example shows pumped volume integrated from flow rate.
## IsResampledBy <!-- VERB -->
- Display name: Is Resampled By
- Parent verb: IsTransformationOutput
- Subject class: DrillingDataPoint
- Object class: Resampling
- Description: Links a resampled signal to the resampling node that produced it.
- Examples: 
```dwis resampledHookload
DrillingDataPoint:hookloadResampled
Resampling:resampleHookload
hookloadResampled IsResampledBy resampleHookload
```
This example ties the resampled hookload to its resampling process.
## IsTransmissionOutput <!-- VERB -->
- Display name: Is Transmission Output
- Parent verb: IsGeneratedBy
- Subject class: DrillingDataPoint
- Object class: TransmissionLine
- Description: Declares a signal as the output of a transmission line.
- Examples: 
```dwis telemetryOutput
DrillingDataPoint:downholeCommand
TransmissionLine:surfaceToDownholeTelemetry
downholeCommand IsTransmissionOutput surfaceToDownholeTelemetry
```
This example shows the downhole command as telemetry output.
## IsProcessedBy <!-- VERB -->
- Display name: Is Processed By
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Indicates that a signal or state is processed by a given data flow node.
- Examples: 
```dwis processedByFilter
DrillingDataPoint:standpipePressureRaw
Filter:standpipeLowPass
standpipePressureRaw IsProcessedBy standpipeLowPass
```
This example shows standpipe pressure processed by a low-pass filter.
