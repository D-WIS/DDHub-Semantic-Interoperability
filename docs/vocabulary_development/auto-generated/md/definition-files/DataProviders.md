# DataProviders<!-- DEFINITION SET HEADER -->
- Description: description of the different actors involved in the well construction process
# Nouns
## DataProvider <!-- NOUN -->
- Display name: DataProvider
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataProviders
# Verbs
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DataProvider](./DataProviders.md#DataProvider)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataProviders
