# DWISSemantics<!-- DEFINITION SET HEADER -->
- Description: definitions of the base noun and verb. All verbs and nouns in the DWIS vocabulary are children of those.
# Nouns
## DWISNoun <!-- NOUN -->
- Display name: DWIS noun
- Parent class: [](./.md#)
- Attributes:
- Specialization:
- Description: Nouns refer to the nature of a node in the graph. Implicitely a noun refers to a "is a" relation between the instance node and the noun. This is the root class for all the nouns defined in the DWIS vocabulary.
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
- Description: This is the root class for all verbs defined in the DWIS vocabulary. It is used to define a relation between a subject, which can be of any `DWISNoun` and an object, also of any type of `DWISNoun`.
- Examples: `DWISVerb` is not really intended to be used directly neither when defining facts nor in sparql queries.
- Definition set: DWISSemantics
## BelongsToClass <!-- VERB -->
- Display name: Belongs To Class
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: The verb is used between a node and a Noun, i.e., a class. Semantically it can be considered as a synonym to `rdf:type`. It has been introduced to overcome limitations from OPC-UA that does not allow for multiple inheritance. Note that the same node can be in relation using `BelongsToClass` to several classes.
- Examples: 
- Definition set: DWISSemantics
