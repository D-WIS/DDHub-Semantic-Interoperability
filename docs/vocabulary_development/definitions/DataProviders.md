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
## DataProvider <!-- NOUN -->
- Display name: OperatingCompany
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: An operating company is an entity that holds the rights to explore, develop, and produce hydrocarbon resources from a particular oil or gas field or lease
- Examples:
## DataProvider <!-- NOUN -->
- Display name: ServiceCompany
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A service company is an entity that provides services during the well construction.
- Examples:
## DataProvider <!-- NOUN -->
- Display name: DirectionalServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A directional service company is an entity that provides services for downhole directional drilling and downhole measurements.
- Examples:
## DataProvider <!-- NOUN -->
- Display name: DrillingFluidProvider
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A drilling fluid provider is a company that provides and maintains the drilling fluids during well construction.
- Examples:
## DataProvider <!-- NOUN -->
- Display name: LoggingServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A logging service company is an entity that gathers measured information during well construction.
- Examples:
## DataProvider <!-- NOUN -->
- Display name: CementingServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization: A cementing service company is an entity that provides the cement slurry used during cementing operations.
- Description: 
- Examples:
## DataProvider <!-- NOUN -->
- Display name: DataAnalysisServiceCompany
- Parent class: ServiceCompany
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A data analysis service company is an entity that analyses measured data and provide new information from these measurements.
- Examples:
## DataProvider <!-- NOUN -->
- Display name: DrillingContractor
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization: A drilling contractor is a company that is primarily responsible for conducting drilling operations, including the construction and operation of drilling rigs.
- Description: 
- Examples:
## DataProvider <!-- NOUN -->
- Display name: DWISInternalService
- Parent class: DataProvider
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A DWIS internal service is an internal component of the DWIS infrastructure that generates information that can be used by any systems connected to the DWIS infrastructure.
- Examples:

# VERBS

## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DataProvider
- Description: 
- Examples: 
