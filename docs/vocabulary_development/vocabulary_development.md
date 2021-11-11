# Vocabulary development. Guidelines and definitions

The vocabulary development consists in enumerating the nouns and verbs that can be used to construct a semantic graph. The semantic graph enables detailed contextualization of the drilling real-time signals available during drilling operations. 

As seen from a graph perspective:
- Nouns refer to the nature of a node in the graph. Implicitely a noun refers to a "is a" relation between the node and the noun. 
- Verbs refer to labels placed on the edges of the graph. 

## Nouns

A noun is fully characterized by:
- a name
- a display name
- a parent noun
- an attribute list:
  - attribute name, type and description
- some specialization values:
  - attribute name and value 
- a description
- some examples

### Parent relation
There can be relations between nouns. We only consider sub-typing relations. 

### Attributes
Nouns can define a set of attributes. An attribute is characterized by:
 - a name
 - a data type. We only consider simple data types (see e.g. [the ones used in RDF](https://www.w3.org/TR/rdf11-concepts/#dfn-recognized-datatype-iris))
 - attributes are inherited from the parent type. 
 - the value of attributes can be specialized. 

### Template
Below is an empty template that can be used to define a new noun.

```
## NounName <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: [Node name](./FileName.md#Node Name-)
- Attributes:
  - AttributeName
    - Type: bool
    - Description: 
- Specialization:
  - AttributeName = default value
- Description: 
- Examples:
```

 ## Verbs
 Verbs are used to connect nodes in the graph. Verbs are identified by their name, and do not support parametrization. A verb is characterized by:
- a name
- a display name
- a subject type (domain)
- an object class (range)
- a description
- some examples. 

### Template

```
## VerbName <!-- VERB -->
- Display name: verb display name
- Subject class: [Noun name](./File name.md#noun name-)
- Object class: [Noun name](./File name.md#noun name-)
- Description: 
- Examples: 
```


## Categories

- [DataFlow](DataFlow.md)
- [DataTransmission](DataTransmission.md)
- [DataValidity](DataValidity.md)
- [DrillingDataSemantics](DrillingDataSemantics.md)
- [DrillingEquipment](DrillingEquipment.md)
- [Hydraulics](Hydraulics.md)
- [Mechanics](Mechanics.md)
- [PhysicalLocation](PhysicalLocation.md)
- [Quantities](Quantities.md)
- [TimeManagement](TimeManagement.md)
- [Uncertainty](Uncertainty.md)