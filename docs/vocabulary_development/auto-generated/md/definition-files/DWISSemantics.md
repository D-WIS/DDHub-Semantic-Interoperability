# DWISSemantics<!-- DEFINITION SET HEADER -->
- Description: definitions of the base noun and verb. All verbs and nouns in the DWIS vocabulary are children of those.
# Nouns
## DWISNoun <!-- NOUN -->
- Display name: DWIS noun
- Parent class: [](./.md#)
- Attributes:
- Specialization:
- Description: Nouns refer to the nature of a node in the graph. Implicitely a noun refers to a "is a" relation between the instance node and the noun.
- Examples:
- Definition set: DWISSemantics
# Verbs
## DWISVerb <!-- VERB -->
- Display name: DWIS verb
- Parent verb: [](./.md#)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## HasType <!-- VERB -->
- Display name: Has Type
- Parent verb: [BelongsToClass](./DWISSemantics.md#BelongsToClass)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## BelongsToClass <!-- VERB -->
- Display name: Belongs To Class
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
