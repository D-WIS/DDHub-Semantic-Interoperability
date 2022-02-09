# DWISSemantics<!-- DEFINITION SET HEADER -->
- Description: definitions of the base noun and verb. All verbs and nouns in the DWIS vocabulary are children of those.
# Nouns
## DWISNoun <!-- NOUN -->
- Display name: DWISNoun
- Parent class: [](./.md#)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DWISSemantics
# Verbs
## DWISVerb <!-- VERB -->
- Display name: DWISVerb
- Parent verb: [](./.md#)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## HasType <!-- VERB -->
- Display name: HasType
- Parent verb: [BelongsToClass](./DWISSemantics.md#BelongsToClass)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## BelongsToClass <!-- VERB -->
- Display name: BelongsToClass
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
