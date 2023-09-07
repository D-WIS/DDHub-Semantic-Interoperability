- Description: this category refers to the various functions an ADCS implements. It is to be used for the ADCS capability description. 

# NOUNS
## ActivableFunction <!-- NOUN -->
- Display name: Activable Function
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## RunnableFunction  <!-- NOUN -->
- Display name: Runnable Function 
- Parent class: ActivableFunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## ProtectionFunction  <!-- NOUN -->
- Display name: Protection Function
- Parent class: ActivableFunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## FDIRFunction  <!-- NOUN -->
- Display name: FDIR Function
- Parent class: ProtectionFunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## SOEFunction  <!-- NOUN -->
- Display name: SOE Function
- Parent class: ProtectionFunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## ControllerFunction  <!-- NOUN -->
- Display name: Controller Function
- Parent class: RunnableFunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## ProcedureFunction  <!-- NOUN -->
- Display name: Procedure Function
- Parent class: RunnableFunction
- Attributes:
- Specialization:
- Description: 
- Examples:
## ADCSTag <!-- NOUN -->
- Display name: ADCS Tag
- Parent class: DWISNoun
- Attributes:
  - Tag
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:

# VERBS
## HasTag <!-- VERB -->
- Display name: Has Tag
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: ADCSTag
- Description: 
- Examples: 
## IsEnablingSignalFor <!-- VERB -->
- Display name: IsEnablingSignalFor
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: ActivableFunction
- Description: 
- Examples: 
## IsActivatedSignalFor <!-- VERB -->
- Display name: IsActivatedSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: ActivableFunction
- Description: 
- Examples: 
## IsAllowEnablementSignalFor <!-- VERB -->
- Display name: IsAllowEnablementSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: ActivableFunction
- Description: 
- Examples: 
## IsIdlingSignalFor <!-- VERB -->
- Display name: IsIdlingSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: RunnableFunction
- Description: 
- Examples: 
## IsUserControllableExtraMarginSignalFor <!-- VERB -->
- Display name: IsUserControllableExtraMarginSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: FDIRFunction
- Description: 
- Examples: 
## IsUsedDefinedExtraMarginSignalFor <!-- VERB -->
- Display name: IsUsedDefinedExtraMarginSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: FDIRFunction
- Description: 
- Examples: 
## IsArmedSignalFor <!-- VERB -->
- Display name: IsArmedSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: FDIRFunction
- Description: 
- Examples: 
## IsTriggeredSignalFor <!-- VERB -->
- Display name: IsTriggeredSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: FDIRFunction
- Description: 
- Examples: 
## IsIdlingAfterTriggeredSignalFor <!-- VERB -->
- Display name: IsIdlingAfterTriggeredSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: FDIRFunction
- Description: 
- Examples: 
## IsImpactDescriptionSignalFor  <!-- VERB -->
- Display name: IsImpactDescriptionSignalFor  
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: FDIRFunction
- Description: 
- Examples: 
