- Description: This category groups the nouns and verbs used to describe when a drilling signal is valid. Typical cases include signals only valid off slips or downhole telemetry signals that are valid only while circulating.

# NOUNS
## ValidityCondition <!-- NOUN -->
- Display name: ValidityCondition
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A logical condition that must hold for a signal to be considered valid.
- Examples:
```dwis circulationValidity
ValidityCondition:circulationValidity
DrillingDataPoint:circulationStatus
circulationStatus IsConditionInput circulationValidity
```
This example defines a validity condition driven by the circulation status signal.
## ConnectedCondition <!-- NOUN -->
- Display name: ConnectedCondition
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: A condition expressing that a signal is valid only when two or more pieces of equipment are connected (e.g., toolface valid only when BHA is made up).
- Examples:
```dwis bhaConnectedCondition
ConnectedCondition:bhaConnected
DrillingDataPoint:bhaConnectionStatus
bhaConnectionStatus IsConditionInput bhaConnected
```
This example states that validity depends on the BHA connection status.
## EQ <!-- NOUN -->
- Display name: EQ
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: A condition that is true when its left and right inputs are equal.
- Examples:
```dwis slipsCondition
EQ:slipsOffCondition
DrillingDataPoint:slipsStatus
DrillingDataPoint:slipsOffValue
slipsStatus IsConditionLeft slipsOffCondition
slipsOffValue IsConditionRight slipsOffCondition
```
This example models validity when the slips status equals the “off” value.
## GT <!-- NOUN -->
- Display name: GT
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: A condition that is true when the left input is greater than the right input.
- Examples:
```dwis pumpPressureCondition
GT:pumpPressureCondition
DrillingDataPoint:standpipePressure
DrillingDataPoint:pressureThreshold
standpipePressure IsConditionLeft pumpPressureCondition
pressureThreshold IsConditionRight pumpPressureCondition
```
This example makes validity depend on standpipe pressure being above a threshold.
## LT <!-- NOUN -->
- Display name: LT
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: A condition that is true when the left input is lower than the right input.
- Examples:
```dwis bitDepthCondition
LT:bitDepthCondition
DrillingDataPoint:bitDepth
DrillingDataPoint:maxDepthForSensor
bitDepth IsConditionLeft bitDepthCondition
maxDepthForSensor IsConditionRight bitDepthCondition
```
This example makes validity depend on bit depth being below a sensor limit.


# VERBS
## IsConditionedBy <!-- VERB -->
- Display name: IsConditionedBy
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: ValidityCondition
- Description: Indicates that a data point is valid only when the referenced condition is satisfied.
- Examples: 
```dwis downholePressureValidity
DrillingDataPoint:downholePressure
ValidityCondition:circulationValidity
downholePressure IsConditionedBy circulationValidity
```
This example ties downhole pressure validity to circulation being active.
## IsConditionInput <!-- VERB -->
- Display name: IsConditionInput
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: ValidityCondition
- Description: Declares that a signal feeds a validity condition evaluation.
- Examples: 
```dwis conditionInputs
DrillingDataPoint:standpipePressure
ValidityCondition:pumpPressureCondition
standpipePressure IsConditionInput pumpPressureCondition
```
This example uses standpipe pressure as an input to a validity condition.
## IsConditionLeft <!-- VERB -->
- Display name: IsConditionLeft
- Parent verb: IsConditionInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Identifies the left-hand operand of a binary validity condition.
- Examples: 
```dwis leftOperand
DrillingDataPoint:standpipePressure
GT:pumpPressureCondition
standpipePressure IsConditionLeft pumpPressureCondition
```
This example sets standpipe pressure as the left operand in a greater-than condition.
## IsConditionRight <!-- VERB -->
- Display name: IsConditionRight
- Parent verb: IsConditionInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: Identifies the right-hand operand of a binary validity condition.
- Examples: 
```dwis rightOperand
DrillingDataPoint:pressureThreshold
GT:pumpPressureCondition
pressureThreshold IsConditionRight pumpPressureCondition
```
This example sets the pressure threshold as the right operand in a greater-than condition.
## IsValidBy <!-- VERB -->
- Display name: IsValidBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: States that a validity condition applies to a data point or class of signals.
- Examples: 
```dwis validityBinding
DrillingDataPoint:downholePressure
ValidityCondition:pumpPressureCondition
downholePressure IsValidBy pumpPressureCondition
```
This example binds the pump pressure condition as the validity constraint for downhole pressure.
