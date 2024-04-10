# DataValidity<!-- DEFINITION SET HEADER -->
- Description: this category contains all the nouns and verbs used to described the validity of signals. Some signals are for example only valid while off-slips, downhole signals transmitted via mud-pulse telemetry require circulation.
# Nouns
## ValidityCondition <!-- NOUN -->
- Display name: ValidityCondition
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## ConnectedCondition <!-- NOUN -->
- Display name: ConnectedCondition
- Parent class: [ValidityCondition](./DataValidity.md#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## EQ <!-- NOUN -->
- Display name: EQ
- Parent class: [ValidityCondition](./DataValidity.md#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## GT <!-- NOUN -->
- Display name: GT
- Parent class: [ValidityCondition](./DataValidity.md#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## LT <!-- NOUN -->
- Display name: LT
- Parent class: [ValidityCondition](./DataValidity.md#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
# Verbs
## IsConditionedBy <!-- VERB -->
- Display name: IsConditionedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ValidityCondition](./DataValidity.md#ValidityCondition)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: DataValidity
## IsConditionInput <!-- VERB -->
- Display name: IsConditionInput
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [ValidityCondition](./DataValidity.md#ValidityCondition)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: DataValidity
## IsConditionLeft <!-- VERB -->
- Display name: IsConditionLeft
- Parent verb: [IsConditionInput](./DataValidity.md#IsConditionInput)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: DataValidity
## IsConditionRight <!-- VERB -->
- Display name: IsConditionRight
- Parent verb: [IsConditionInput](./DataValidity.md#IsConditionInput)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: DataValidity
## IsValidBy <!-- VERB -->
- Display name: IsValidBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples:
- Definition set: DataValidity
