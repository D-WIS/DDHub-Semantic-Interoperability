- Description: this category refers mostly to the description of drilling incidents.

# NOUNS
## DrillingIncident <!-- NOUN -->
- Display name: Drilling Incident
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: This is the parent class for drilling incidents. A drilling incident is often detectable by an abnormal value of a process variable, i.e., a variable that is influenced 
by the drilling process.
- Examples:
## AbnormalOscillation <!-- NOUN -->
- Display name: Abnormal Oscillation
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun represents abnormal oscillations along the drill-stem.
- Examples:
## AbnormalAxialOscillation <!-- NOUN -->
- Display name: Abnormal Axial Oscillation
- Parent class: AbnormalOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to abnormal axial oscillations.
- Examples:
## AbnormalTorsionalOscillation <!-- NOUN -->
- Display name: Abnormal Torsional Oscillation
- Parent class: AbnormalOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to abnormal torsional oscillations.
- Examples:
## AbnormalLateralOscillation <!-- NOUN -->
- Display name: Abnormal Lateral Oscillation
- Parent class: AbnormalOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to abnormal lateral oscillations.
- Examples:
## StickSlip <!-- NOUN -->
- Display name: Stick-slip
- Parent class: AbnormalTorsionalOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to stick-slips.
- Examples:
## HFTO <!-- NOUN -->
- Display name: High Frequency Torsional Oscillation
- Parent class: AbnormalTorsionalOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to high frequency torsional oscillations.
- Examples:
## Whirling <!-- NOUN -->
- Display name: Whirling
- Parent class: AbnormalLateralOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to abnormal lateral oscillations.
- Examples:
``` dwis whirlFDIRInfo
DynamicDrillingSignal: whirlFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: whirlFDIRInfo_1
whirlFDIRInfo_1 HasDynamicValue whirlFDIRInfo
Whirling: whirlingIncident
whirlFDIRInfo_1 IsRelatedToDrillingIncident whirlingIncident
ServiceCompany: serviceCompany
whirlFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
whirlFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident whirlingIncident
whirlFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
whirlFDIRInfo_1 IsProvidedTo adviceComposer
```
## ForwardWhirl <!-- NOUN -->
- Display name: Forward Whirl
- Parent class: Whirling
- Attributes:
- Specialization:
- Description: This Noun is used to refer to forward whirl.
- Examples:
## BackwardWhirl <!-- NOUN -->
- Display name: Backward Whirl
- Parent class: Whirling
- Attributes:
- Specialization:
- Description: This Noun is used to refer to backward whirl.
- Examples:
## ChaoticWhirl <!-- NOUN -->
- Display name: Chaotic Whirl
- Parent class: Whirling
- Attributes:
- Specialization:
- Description: This Noun is used to refer to chaotic whirl.
- Examples:
## Shock <!-- NOUN -->
- Display name: Shock
- Parent class: AbnormalLateralOscillation
- Attributes:
- Specialization:
- Description: This Noun is used to refer to lateral shocks.
- Examples:
## TwistOff <!-- NOUN -->
- Display name: Twist-off
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a twist-off situation.
- Examples:
``` dwis twistOffFDIRInfo
DynamicDrillingSignal: twistOffFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: twistOffFDIRInfo_1
twistOffFDIRInfo_1 HasDynamicValue twistOffFDIRInfo
TwistOff: twistOffIncident
twistOffFDIRInfo_1 IsRelatedToDrillingIncident twistOffIncident
ServiceCompany: serviceCompany
twistOffFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
twistOffFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident twistOffIncident
twistOffFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
twistOffFDIRInfo_1 IsProvidedTo adviceComposer
```
## Overpull <!-- NOUN -->
- Display name: Overpull
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the drill-stem hangs in something in the upward direction.
- Examples:
``` dwis overpullFDIRInfo
DynamicDrillingSignal: overpullFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: overpullFDIRInfo_1
overpullFDIRInfo_1 HasDynamicValue overpullFDIRInfo
Overpull: overpullIncident
overpullFDIRInfo_1 IsRelatedToDrillingIncident overpullIncident
ServiceCompany: serviceCompany
overpullFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
overpullFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1. ManagesIncident overpullIncident
overpullFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
overpullFDIRInfo_1 IsProvidedTo adviceComposer
```
## Underpull <!-- NOUN -->
- Display name: Underpull
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the drill-stem hangs in something in the downward direction.
- Examples:
``` dwis underpullFDIRInfo
DynamicDrillingSignal: underpullFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: underpullFDIRInfo_1
underpullFDIRInfo_1 HasDynamicValue underpullFDIRInfo
Underpull: underpullIncident
underpullFDIRInfo_1 IsRelatedToDrillingIncident underpullIncident
ServiceCompany: serviceCompany
underpullFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
underpullFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident underpullIncident
underpullFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
underpullFDIRInfo_1 IsProvidedTo adviceComposer
```
## Influx <!-- NOUN -->
- Display name: Influx
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which there is an influx of formation fluids in the borehole.
- Examples:
``` dwis kickFDIRInfo
DynamicDrillingSignal: kickFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: kickFDIRInfo_1
kickFDIRInfo_1 HasDynamicValue kickFDIRInfo
Influx: influxIncident
kickFDIRInfo_1 IsRelatedToDrillingIncident influxIncident
ServiceCompany: serviceCompany
kickFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
kickFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident influxIncident
kickFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
kickFDIRInfo_1 IsProvidedTo adviceComposer
```
## LossCirculation <!-- NOUN -->
- Display name: Loss Circulation
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which drilling fluid is lost to the formation.
- Examples:
``` dwis lossCirculationFDIRInfo
DynamicDrillingSignal: lossCirculationFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: lossCirculationFDIRInfo_1
lossCirculationFDIRInfo_1 HasDynamicValue lossCirculationFDIRInfo
LossCirculation: lossCirculationIncident
lossCirculationFDIRInfo_1 IsRelatedToDrillingIncident lossCirculationIncident
ServiceCompany: serviceCompany
lossCirculationFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
lossCirculationFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident lossCirculationIncident
lossCirculationFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
lossCirculationFDIRInfo_1 IsProvidedTo adviceComposer
```
## HoleCollapse <!-- NOUN -->
- Display name: Hole Collapse
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which there is a hole collapse.
- Examples:
``` dwis HoleCollapseFDIRInfo
DynamicDrillingSignal: HoleCollapseFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: HoleCollapseFDIRInfo_1
HoleCollapseFDIRInfo_1 HasDynamicValue HoleCollapseFDIRInfo
HoleCollapse: holeCollapseIncident
HoleCollapseFDIRInfo_1 IsRelatedToDrillingIncident holeCollapseIncident
ServiceCompany: serviceCompany
HoleCollapseFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
HoleCollapseFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident holeCollapseIncident
HoleCollapseFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
HoleCollapseFDIRInfo_1 IsProvidedTo adviceComposer
```
## StuckPipe <!-- NOUN -->
- Display name: Stuck-pipe
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the drill-stem is impeded to move either axially or rotationally or both.
- Examples:
## DifferentiallyStuck <!-- NOUN -->
- Display name: Differentially Stuck
- Parent class: StuckPipe
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the drill-stem is stuck because of differential sticking.
- Examples:
``` dwis differentialStickingFDIRInfo
DynamicDrillingSignal: differentialStickingFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: differentialStickingFDIRInfo_1
differentialStickingFDIRInfo_1 HasDynamicValue differentialStickingFDIRInfo
DifferentiallyStuck: differentiallyStuckIncident
differentialStickingFDIRInfo_1 IsRelatedToDrillingIncident differentiallyStuckIncident
ServiceCompany: serviceCompany
differentialStickingFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
differentialStickingFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident differentiallyStuckIncident
differentialStickingFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
differentialStickingFDIRInfo_1 IsProvidedTo adviceComposer
```
## PipeWashout <!-- NOUN -->
- Display name: Pipe Washout
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which there is leak between the inside of the drill-stem and the annulus.
- Examples:
``` dwis pipeWashoutFDIRInfo
DynamicDrillingSignal: pipeWashoutFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: pipeWashoutFDIRInfo_1
pipeWashoutFDIRInfo_1 HasDynamicValue pipeWashoutFDIRInfo
PipeWashout: pipeWashoutIncident
pipeWashoutFDIRInfo_1 IsRelatedToDrillingIncident pipeWashoutIncident
ServiceCompany: serviceCompany
pipeWashoutFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
pipeWashoutFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident pipeWashoutIncident
pipeWashoutFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
pipeWashoutFDIRInfo_1 IsProvidedTo adviceComposer
```
## FormationWashout <!-- NOUN -->
- Display name: Formation Washout
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the formation is being washed out.
- Examples:
## OverTorque <!-- NOUN -->
- Display name: Over-torque
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the rotation of the drill-stem is impeded.
- Examples:
``` dwis overtorqueFDIRInfo
DynamicDrillingSignal: overtorqueFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: overtorqueFDIRInfo_1
overtorqueFDIRInfo_1 HasDynamicValue overtorqueFDIRInfo
OverTorque: overTorqueIncident
overtorqueFDIRInfo_1 IsRelatedToDrillingIncident overTorqueIncident
ServiceCompany: serviceCompany
overtorqueFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
overtorqueFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident overTorqueIncident
overtorqueFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
overtorqueFDIRInfo_1 IsProvidedTo adviceComposer
```
## Plugged <!-- NOUN -->
- Display name: Plugged
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the hydraulic flow-path is partially or fully blocked.
- Examples:
## PackOff <!-- NOUN -->
- Display name: Pack-off
- Parent class: Plugged
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the annulus hydraulic flow-path is partially or fully blocked.
- Examples:
``` dwis PackOffFDIRInfo
DynamicDrillingSignal: PackOffFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: PackOffFDIRInfo_1
PackOffFDIRInfo_1 HasDynamicValue PackOffFDIRInfo
PackOff: packOffIncident
PackOffFDIRInfo_1 IsRelatedToDrillingIncident packOffIncident
ServiceCompany: serviceCompany
PackOffFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
PackOffFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident packOffIncident
PackOffFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
PackOffFDIRInfo_1 IsProvidedTo adviceComposer
```
## MotorStall <!-- NOUN -->
- Display name: Motor-stall
- Parent class: DrillingIncident
- Attributes:
- Specialization:
- Description: This Noun is used to refer to a situation during which the downhole motor is stalled.
- Examples:
``` dwis motorStallFDIRInfo
DynamicDrillingSignal: motorStallFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: motorStallFDIRInfo_1
motorStallFDIRInfo_1 HasDynamicValue motorStallFDIRInfo
MotorStall: motorStallIncident
motorStallFDIRInfo_1 IsRelatedToDrillingIncident motorStallIncident
ServiceCompany: serviceCompany
motorStallFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
motorStallFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1 ManagesIncident motorStallIncident
motorStallFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
motorStallFDIRInfo_1 IsProvidedTo adviceComposer
```

# VERBS
## IsRelatedToDrillingIncident <!-- VERB -->
- Display name: Is Related to Drilling Incident
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: DrillingIncident
- Description: This Verb is used to indicate that a drilling data point is related to a drilling incident.
- Examples: 
``` dwis motorStallFDIRInfo
DynamicDrillingSignal: motorStallFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice: motorStallFDIRInfo_1
motorStallFDIRInfo_1 HasDynamicValue motorStallFDIRInfo
MotorStall: motorStallIncident
motorStallFDIRInfo_1 IsRelatedToDrillingIncident motorStallIncident
ServiceCompany: serviceCompany
motorStallFDIRInfo_1 IsProvidedBy serviceCompany
Advisor: computationUnit
motorStallFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction: FDIRFunction_1
FDIRFunction_1.HasFunction = "MotorStallFDIR"
motorStallFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer: adviceComposer
motorStallFDIRInfo_1 IsProvidedTo adviceComposer
```
## ManagesIncident <!-- VERB -->
- Display name: Manages Incident
- Parent verb: DWISVerb
- Subject class: FDIRFunction
- Object class: DrillingIncident
- Description: This Verb is used to indicate that a fault detection isolation and recovery function manages a drilling incident.
- Examples: