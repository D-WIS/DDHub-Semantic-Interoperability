- Description: this category contains all the nouns and verbs used to described the validity of signals. Some signals are for example only valid while off-slips, downhole signals transmitted via mud-pulse telemetry require circulation.

# NOUNS
## ValidityCondition <!-- NOUN -->
- Display name: ValidityCondition
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## ConnectedCondition <!-- NOUN -->
- Display name: ConnectedCondition
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: 
- Examples:
## EQ <!-- NOUN -->
- Display name: EQ
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: 
- Examples:
## GT <!-- NOUN -->
- Display name: GT
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: 
- Examples:
## LT <!-- NOUN -->
- Display name: LT
- Parent class: ValidityCondition
- Attributes:
- Specialization:
- Description: 
- Examples:


# VERBS
## IsConditionedBy <!-- VERB -->
- Display name: IsConditionedBy
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: ValidityCondition
- Description: 
- Examples: 
## IsConditionInput <!-- VERB -->
- Display name: IsConditionInput
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: ValidityCondition
- Description: 
- Examples: 
## IsConditionLeft <!-- VERB -->
- Display name: IsConditionLeft
- Parent verb: IsConditionInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsConditionRight <!-- VERB -->
- Display name: IsConditionRight
- Parent verb: IsConditionInput
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsValidBy <!-- VERB -->
- Display name: IsValidBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
