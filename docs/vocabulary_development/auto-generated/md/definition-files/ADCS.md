# ADCS<!-- DEFINITION SET HEADER -->
- Description: this category refers to the various functions an ADCS implements. It is to be used for the ADCS capability description.
# Nouns
## ActivableFunction <!-- NOUN -->
- Display name: Activable Function
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## RunnableFunction <!-- NOUN -->
- Display name: Runnable Function
- Parent class: [ActivableFunction](./ADCS.md#ActivableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ProtectionFunction <!-- NOUN -->
- Display name: Protection Function
- Parent class: [ActivableFunction](./ADCS.md#ActivableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## FDIRFunction <!-- NOUN -->
- Display name: FDIR Function
- Parent class: [ProtectionFunction](./ADCS.md#ProtectionFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## SOEFunction <!-- NOUN -->
- Display name: SOE Function
- Parent class: [ProtectionFunction](./ADCS.md#ProtectionFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ControllerFunction <!-- NOUN -->
- Display name: Controller Function
- Parent class: [RunnableFunction](./ADCS.md#RunnableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ProcedureFunction <!-- NOUN -->
- Display name: Procedure Function
- Parent class: [RunnableFunction](./ADCS.md#RunnableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ADCSTag <!-- NOUN -->
- Display name: ADCS Tag
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - Tag
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
# Verbs
## HasTag <!-- VERB -->
- Display name: Has Tag
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [ADCSTag](./ADCS.md#ADCSTag)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsEnablingSignalFor <!-- VERB -->
- Display name: IsEnablingSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [ActivableFunction](./ADCS.md#ActivableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsActivatedSignalFor <!-- VERB -->
- Display name: IsActivatedSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [ActivableFunction](./ADCS.md#ActivableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsAllowEnablementSignalFor <!-- VERB -->
- Display name: IsAllowEnablementSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [ActivableFunction](./ADCS.md#ActivableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsIdlingSignalFor <!-- VERB -->
- Display name: IsIdlingSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [RunnableFunction](./ADCS.md#RunnableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsUserControllableExtraMarginSignalFor <!-- VERB -->
- Display name: IsUserControllableExtraMarginSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [FDIRFunction](./ADCS.md#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsUsedDefinedExtraMarginSignalFor <!-- VERB -->
- Display name: IsUsedDefinedExtraMarginSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [FDIRFunction](./ADCS.md#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsArmedSignalFor <!-- VERB -->
- Display name: IsArmedSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [FDIRFunction](./ADCS.md#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsTriggeredSignalFor <!-- VERB -->
- Display name: IsTriggeredSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [FDIRFunction](./ADCS.md#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsIdlingAfterTriggeredSignalFor <!-- VERB -->
- Display name: IsIdlingAfterTriggeredSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [FDIRFunction](./ADCS.md#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsImpactDescriptionSignalFor <!-- VERB -->
- Display name: IsImpactDescriptionSignalFor
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [FDIRFunction](./ADCS.md#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
