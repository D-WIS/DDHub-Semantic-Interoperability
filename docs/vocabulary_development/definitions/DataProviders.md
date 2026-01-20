- Description: description of the different actors involved in the well construction process

# NOUNS

## DataProvider <!-- NOUN -->
- Display name: DataProvider
- Parent class: DWISNoun
- Attributes:
  - ProviderName
    - Type: string
    - Description: The name of the data provide.
- Specialization:
- Description: A data provider is any sources for data.
- Examples:
```dwis dataProvider
DrillingDataPoint:dataProvider
dataProvider BelongsToClass DataProvider
```
This example links a drilling data point to the DataProvider definition.
## OperatingCompany <!-- NOUN -->
- Display name: OperatingCompany
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: An operating company is an entity that holds the rights to explore, develop, and produce hydrocarbon resources from a particular oil or gas field or lease
- Examples:
``` dwis stratigraphyDescription_0
DynamicDrillingSignal:stratigraphyDescription_0
StratigraphyDescription:stratigraphyDescription_1
stratigraphyDescription_1 HasDynamicValue stratigraphyDescription_0
OperatingCompany:operatingCompany_1
stratigraphyDescription_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
stratigraphyDescription_1 IsProvidedTo contextualDataBuilder_1
Prognosed:prognosed_1
stratigraphyDescription_1 IsCharacterizedBy prognosed_1
```
## ServiceCompany <!-- NOUN -->
- Display name: ServiceCompany
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: A service company is an entity that provides services during the well construction.
- Examples:
```dwis serviceCompany
DrillingDataPoint:serviceCompany
serviceCompany BelongsToClass ServiceCompany
```
This example links a drilling data point to the ServiceCompany definition.
## DirectionalServiceCompany <!-- NOUN -->
- Display name: DirectionalServiceCompany
- Parent class: ServiceCompany
- Attributes:
- Specialization:
- Description: A directional service company is an entity that provides services for downhole directional drilling and downhole measurements.
- Examples:
``` dwis trajectoryDescription_0
DynamicDrillingSignal:trajectoryDescription_0
TrajectoryDescription:trajectoryDescription_1
trajectoryDescription_1 HasDynamicValue trajectoryDescription_0
DirectionalServiceCompany:directionalServiceCompany_1
trajectoryDescription_1 IsProvidedBy directionalServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
trajectoryDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
trajectoryDescription_1 IsCharacterizedBy current_1
Extrapolated: extrapolated_1
trajectoryDescription_1 IsCharacterizedBy extrapolated_1
Measured:measured_1
trajectoryDescription_1 IsCharacterizedBy measured_1
```
## DrillingFluidProvider <!-- NOUN -->
- Display name: DrillingFluidProvider
- Parent class: ServiceCompany
- Attributes:
- Specialization:
- Description: A drilling fluid provider is a company that provides and maintains the drilling fluids during well construction.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
DrillingFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
DrillingFluidProvider:drillingFluidProvider_1
fluidDescription_1 IsProvidedBy drillingFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
fluidDescription_1 IsCharacterizedBy current_1
Measured:measured_1
fluidDescription_1 IsCharacterizedBy measured_1
```
## LoggingServiceCompany <!-- NOUN -->
- Display name: LoggingServiceCompany
- Parent class: ServiceCompany
- Attributes:
- Specialization:
- Description: A logging service company is an entity that gathers measured information during well construction.
- Examples:
``` dwis stratigraphyDescription_0
DynamicDrillingSignal:stratigraphyDescription_0
StratigraphyDescription:stratigraphyDescription_1
stratigraphyDescription_1 HasDynamicValue stratigraphyDescription_0
LoggingServiceCompany:logginServiceCompany_1
stratigraphyDescription_1 IsProvidedBy logginServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
stratigraphyDescription_1 IsProvidedTo contextualDataBuilder_1
Measured:measured_1
stratigraphyDescription_1 IsCharacterizedBy measured_1
```
## InstrumentationCompany <!-- NOUN -->
- Display name: Instrumentation Company
- Parent class: ServiceCompany
- Attributes:
- Specialization:
- Description: A service company providing measurement instruments and associated services.
- Examples:
``` dwis stratigraphyDescription_0
DynamicDrillingSignal:stratigraphyDescription_0
StratigraphyDescription:stratigraphyDescription_1
stratigraphyDescription_1 HasDynamicValue stratigraphyDescription_0
LoggingServiceCompany:logginServiceCompany_1
stratigraphyDescription_1 IsProvidedBy logginServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
stratigraphyDescription_1 IsProvidedTo contextualDataBuilder_1
Measured:measured_1
stratigraphyDescription_1 IsCharacterizedBy measured_1
```
## CementingServiceCompany <!-- NOUN -->
- Display name: CementingServiceCompany
- Parent class: ServiceCompany
- Attributes:
- Specialization: 
- Description: A cementing service company is an entity that provides the cement slurry used during cementing operations.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
CementFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
CementingServiceCompany:cementFluidProvider_1
fluidDescription_1 IsProvidedBy cementFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Measured:measured_1
fluidDescription_1 IsCharacterizedBy measured_1
```
## CompletionServiceCompany <!-- NOUN -->
- Display name: CompletionServiceCompany
- Parent class: ServiceCompany
- Attributes:
- Specialization: 
- Description: A completion service company is an entity that provides the completion equipment and fluids used during completion operations.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
CompletionFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
CompletionServiceCompany:completionFluidProvider_1
fluidDescription_1 IsProvidedBy completionFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
fluidDescription_1 IsCharacterizedBy current_1
```
## DataAnalysisServiceCompany <!-- NOUN -->
- Display name: DataAnalysisServiceCompany
- Parent class: ServiceCompany
- Attributes:
- Specialization:
- Description: A data analysis service company is an entity that analyses measured data and provide new information from these measurements.
- Examples:
``` dwis PackOffFDIRInfo
DynamicDrillingSignal:PackOffFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice:PackOffFDIRInfo_1
PackOffFDIRInfo_1 HasDynamicValue PackOffFDIRInfo
PackOff:packOffIncident
PackOffFDIRInfo_1 IsRelatedToDrillingIncident packOffIncident
DataAnalysisServiceCompany:dataAnalysisServiceCompany_1
PackOffFDIRInfo_1 IsProvidedBy dataAnalysisServiceCompany_1
Advisor:computationUnit
PackOffFDIRInfo_1 IsRecommendedBy computationUnit
FDIRFunction:FDIRFunction_1
FDIRFunction_1 ManagesIncident packOffIncident
PackOffFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISAdviceComposer:adviceComposer
PackOffFDIRInfo_1 IsProvidedTo adviceComposer
```
## DrillingContractor <!-- NOUN -->
- Display name: DrillingContractor
- Parent class: DataProvider
- Attributes:
- Specialization: 
- Description: A drilling contractor is a company that is primarily responsible for conducting drilling operations, including the construction and operation of drilling rigs.
- Examples:
``` dwis rigDescription_0
DynamicDrillingSignal:rigDescription_0
RigDescription:rigDescription_1
rigDescription_1 HasDynamicValue rigDescription_0
DrillingContractor:drillingContractor_1
rigDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
rigDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
rigDescription_1 IsCharacterizedBy current_1
```
## DWISInternalService <!-- NOUN -->
- Display name: DWISInternalService
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: A DWIS internal service is an internal component of the DWIS infrastructure that generates information that can be used by any systems connected to the DWIS infrastructure.
- Examples:
```dwis dWISInternalService
DrillingDataPoint:dWISInternalService
dWISInternalService BelongsToClass DWISInternalService
```
This example links a drilling data point to the DWISInternalService definition.
## DWISBlackboard <!-- NOUN -->
- Display name: DWIS Blackboard
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS blackboard is a shared data structure that allows different DWIS components to share information and coordinate their activities.
- Examples:
```dwis dWISBlackboard
DrillingDataPoint:dWISBlackboard
dWISBlackboard BelongsToClass DWISBlackboard
```
This example links a drilling data point to the DWISBlackboard definition.
## DWISDrillingProcessStateInterpreter <!-- NOUN -->
- Display name: DWIS Drilling Process State Interpreter
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS Drilling Process State Interpreter is a component that analyses drilling data to determine the current state of the drilling process.
- Examples:
``` dwis configurationData_0
DynamicDrillingSignal:configurationData_0
ConfigurationData:configurationData_1
configurationData_1 HasDynamicValue configurationData_0
OperatingCompany:operatingCompany_1
configurationData_1 IsProvidedBy operatingCompany_1
DWISDrillingProcessStateInterpreter:microStateInterpreter_1
configurationData_1 IsProvidedTo microStateInterpreter_1
configurationData_1 IsLimitFor microStateInterpreter_1
```
## DWISAdviceComposer <!-- NOUN -->
- Display name: DWIS Advice Composer
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS Advice Composer is a component that composes different drilling advices based on priorities set by the DWIS Scheduler.
- Examples:
``` dwis ROPManagementControllerInfo
DynamicDrillingSignal:ROPManagementControllerInfo
DrillingControlAdvice:ROPManagementControllerInfo_1
ROPManagementControllerInfo_1 HasDynamicValue ROPManagementControllerInfo
ROPLimit:ROPLimit_1
ROPManagementControllerInfo_1 HasControlLimit ROPLimit_1
WOBLimit:WOBLimit_1
ROPManagementControllerInfo_1 HasControlLimit WOBLimit_1
DifferentialPressureLimit:differentialPressureLimit
ROPManagementControllerInfo_1 HasControlLimit differentialPressureLimit
BottomOfStringReferenceLocation:bottomOfStringLocation
StableAxialVelocityObjective:stableAxialVelocityObjective
stableAxialVelocityObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableAxialVelocityObjective
StableAxialForceObjective:stableWOBObjective
stableWOBObjective IsPhysicallyLocatedAt bottomOfStringLocation
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableWOBObjective
StablePressureObjective:stableDifferentialPressure
ROPManagementControllerInfo_1 IsRelatedToDrillingObjective stableDifferentialPressure
ServiceCompany:serviceCompany
ROPManagementControllerInfo_1 IsProvidedBy serviceCompany
Advisor:computationUnit
ROPManagementControllerInfo_1 IsRecommendedBy computationUnit
ControllerFunction:autoDriller
autoDriller ImplementsObjective stableAxialVelocityObjective
autoDriller ImplementsObjective stableWOBObjective
autoDriller ImplementsObjective stableDifferentialPressure
ROPManagementControllerInfo_1 IsRecommendedFor autoDriller
DWISAdviceComposer:adviceComposer
ROPManagementControllerInfo_1 IsProvidedTo adviceComposer
DWISScheduler:scheduler
ROPManagementControllerInfo_1 IsProvidedTo scheduler
```
## DWISScheduler <!-- NOUN -->
- Display name: DWIS Scheduler
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS Scheduler is a component that schedules drilling activities based on the rig action plan and the current context estimated by the DWIS Microstate Interpretation engine.
- Examples:
``` dwis rigActionPlan_0
DynamicDrillingSignal:rigActionPlan_0
RigActionPlan:rigActionPlan_1
rigActionPlan_1 HasDynamicValue rigActionPlan_0
OperatingCompany:operatingCompany_1
rigActionPlan_1 IsProvidedBy operatingCompany_1
DWISScheduler:scheduler_1
rigActionPlan_1 IsProvidedTo scheduler_1
```
## DWISContextualDataBuilder <!-- NOUN -->
- Display name: DWIS Contextual Data Builder
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS Contextual Data Builder is a component that consolidates contextual data arising from multiple providers.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
FluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
DrillingFluidProvider:drillingFluidProvider_1
fluidDescription_1 IsProvidedBy drillingFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
fluidDescription_1 IsCharacterizedBy current_1
```
## DWISLogger <!-- NOUN -->
- Display name: DWIS Logger
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS Logger is a component that logs all the activity on DWIS Blackboard.
- Examples:
```dwis dWISLogger
DrillingDataPoint:dWISLogger
dWISLogger BelongsToClass DWISLogger
```
This example links a drilling data point to the DWISLogger definition.
## DWISADCSInterface <!-- NOUN -->
- Display name: DWIS ADCS Interface
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS ADCS interface provides access to the actual ADCS.
- Examples:
``` dwis overpullUnderpullFDIRInfo
DynamicDrillingSignal:overpullUnderpullFDIRInfo
DrillingFaultDetectionIsolationAndRecoveryAdvice:overpullUnderpullFDIRInfo_1
overpullUnderpullFDIRInfo_1 HasDynamicValue overpullUnderpullFDIRInfo
Overpull:overpullIncident
overpullUnderpullFDIRInfo_1 IsRelatedToDrillingIncident overpullIncident
Underpull:underpullIncident
overpullUnderpullFDIRInfo_1 IsRelatedToDrillingIncident underpullIncident
ServiceCompany:serviceCompany
overpullUnderpullFDIRInfo_1 IsProvidedBy serviceCompany
DWISAdviceComposer:adviceComposer_1
overpullUnderpullFDIRInfo_1 IsRecommendedBy adviceComposer_1
FDIRFunction:FDIRFunction_1
FDIRFunction_1 ManagesIncident overpullIncident
FDIRFunction_1 ManagesIncident underpullIncident
overpullUnderpullFDIRInfo_1 IsRecommendedFor FDIRFunction_1
DWISADCSInterface:ADCSInterface_1
overpullUnderpullFDIRInfo_1 IsProvidedTo ADCSInterface_1
```
## DWISADCSCapabilityDescriptor <!-- NOUN -->
- Display name: DWIS ADCS Capability Descriptor
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: The DWIS ADCS Capability descriptor describes the actual capabilities of the true ADCS.
- Examples:
``` dwis configurationData_0
DynamicDrillingSignal:configurationData_0
ConfigurationData:configurationData_1
configurationData_1 HasDynamicValue configurationData_0
DWISADCSInterface:ADCSCapabilityDescriptor_1
configurationData_1 IsProvidedBy ADCSCapabilityDescriptor_1
```
# VERBS
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: This verb is used to stipulate that something is provided by a data provider.
- Examples:
``` dwis rigDescription_0
DynamicDrillingSignal:rigDescription_0
RigDescription:rigDescription_1
rigDescription_1 HasDynamicValue rigDescription_0
DrillingContractor:drillingContractor_1
rigDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
rigDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
rigDescription_1 IsCharacterizedBy current_1
``` 
## IsProvidedTo <!-- VERB -->
- Display name: IsProvidedTo
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: This verb is used to stipulate that something is provided to a data provider.
- Examples: 
``` dwis rigDescription_0
DynamicDrillingSignal:rigDescription_0
RigDescription:rigDescription_1
rigDescription_1 HasDynamicValue rigDescription_0
DrillingContractor:drillingContractor_1
rigDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
rigDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
rigDescription_1 IsCharacterizedBy current_1
```