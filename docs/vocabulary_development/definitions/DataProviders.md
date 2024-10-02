- Description: description of the different actors involved in the well construction process

# NOUNS

## DataProvider <!-- NOUN -->
- Display name: DataProvider
- Parent class: DWISNoun
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A data provider is any sources for data
- Examples:
## OperatingCompany <!-- NOUN -->
- Display name: OperatingCompany
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: An operating company is an entity that holds the rights to explore, develop, and produce hydrocarbon resources from a particular oil or gas field or lease
- Examples:
## ServiceCompany <!-- NOUN -->
- Display name: ServiceCompany
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A service company is an entity that provides services during the well construction.
- Examples:
## DirectionalServiceCompany <!-- NOUN -->
- Display name: DirectionalServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A directional service company is an entity that provides services for downhole directional drilling and downhole measurements.
- Examples:
## DrillingFluidProvider <!-- NOUN -->
- Display name: DrillingFluidProvider
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A drilling fluid provider is a company that provides and maintains the drilling fluids during well construction.
- Examples:
## LoggingServiceCompany <!-- NOUN -->
- Display name: LoggingServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A logging service company is an entity that gathers measured information during well construction.
- Examples:
## CementingServiceCompany <!-- NOUN -->
- Display name: CementingServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization: A cementing service company is an entity that provides the cement slurry used during cementing operations.
- Description: 
- Examples:
## DataAnalysisServiceCompany <!-- NOUN -->
- Display name: DataAnalysisServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A data analysis service company is an entity that analyses measured data and provide new information from these measurements.
- Examples:
## DrillingContractor <!-- NOUN -->
- Display name: DrillingContractor
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization: A drilling contractor is a company that is primarily responsible for conducting drilling operations, including the construction and operation of drilling rigs.
- Description: 
- Examples:
## DWISInternalService <!-- NOUN -->
- Display name: DWISInternalService
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A DWIS internal service is an internal component of the DWIS infrastructure that generates information that can be used by any systems connected to the DWIS infrastructure.
- Examples:
## DWISBlackboard <!-- NOUN -->
- Display name: DWIS Blackboard
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISDrillingProcessStateInterpreter <!-- NOUN -->
- Display name: DWIS Drilling Process State Interpreter
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISAdviceComposer <!-- NOUN -->
- Display name: DWIS Advice Composer
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISScheduler <!-- NOUN -->
- Display name: DWIS Scheduler
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISContextualDataBuilder <!-- NOUN -->
- Display name: DWIS Contextual Data Builder
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISLogger <!-- NOUN -->
- Display name: DWIS Logger
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISADCSInterface <!-- NOUN -->
- Display name: DWIS ADCS Interface
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
## DWISADCSCapabilityDescriptor <!-- NOUN -->
- Display name: DWIS ADCS Capability Descriptor
- Parent class: DWISInternalService
- Attributes:
- Specialization:
- Description: 
- Examples:
# VERBS
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: 
- Examples: 
## IsProvidedTo <!-- VERB -->
- Display name: IsProvidedTo
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: 
- Examples: 
