# Vocabulary development. Guidelines and definitions

The vocabulary development consists in enumerating the nouns and verbs that can be used to construct a semantic graph. The semantic graph enables detailed contextualization of the drilling real-time signals available during drilling operations. 

As seen from a graph perspective:
- Nouns refer to the nature of a node in the graph. Implicitely a noun refers to a "is a" relation between the node and the noun. 
- Verbs refer to labels placed on the edges of the graph. 

We use markdown to write the documents. Information about the langage can be found [there](https://docs.github.com/en/github/writing-on-github)

## Nouns

A noun is fully characterized by:
- a *name* 
- a *display name*
- a *parent noun*
- an attribute list:
  - attribute name, type and description
- some specialization values:
  - attribute name and value 
- a description
- some examples

### Name
The identification name of the noun. It should ideally follow some notational convention.

### Display name
A variant of the name used for pretty printing of the noun. It can have a more human friendly syntax. 

### Parent relation
There can be relations between nouns. We only consider sub-typing relations. 
Each noun is associated to a (unique) parent. Circular parenting is not permitted. There is a common ancestor to all nouns: DWISNode. One can therefore derive a tree structure from the nouns. The parent relation should be consistent with the *is a* relation. For example, if the DeadlineHookload noun has parent the Hookload noun, then consistency is in place. When asserting that a signal *s* is a DeadlineHookload, one implicitely asserts that *s* is a Hookload, which is true. A contrario, stating the the noun TopDriveShaft has parent noun TopDrive is erroneous: if an element *e* is a TopDriveShaft, then one implicitely asserts that *e* is also a TopDrive, which is false. In this example, using the parent relation between TopDriveShaft and TopDrive is not correct. One should instead use a *is made of* relation, or something similar.    

### Attributes
Nouns can define a set of attributes. An attribute is characterized by:
 - a name
 - a data type. We only consider simple data types (see e.g. [the ones used in RDF](https://www.w3.org/TR/rdf11-concepts/#dfn-recognized-datatype-iris))
 - attributes are inherited from the parent type. 
 - the value of attributes can be specialized. 

### Specialization values

### Description

### Examples

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

- [DataFlow](DataFlow.md): this category refers to the data processing. It should probably be renamed accordingly. It should define and organize the different types of processing encountered during drilling operations. A Thursday session was devoted to those items. Note that in the current version, control flow is also included: a controller is seen as a special type of processing unit, that generates commands based on measurements and set-points. This can of course be modified if deemed necessary. Note also that transmission is included there as well. A telemetry system is seen as a processing unit that only duplicates a signal, and a delay is associated to the duplication process. While this is a useful way of looking at telemetry, it is probably not intuitive enough. 
- [DataTransmission](DataTransmission.md): this category contains all nouns and verbs used to describe the rig's telemetry, for each signal. Downhole telemetry has focus. 
- [DataValidity](DataValidity.md): this category contains all the nouns and verbs used to described the validity of signals. Some signals are for example only valid while off-slips, downhole signals transmitted via mud-pulse telemetry require circulation. 
- [DrillingDataSemantics](DrillingDataSemantics.md): this is the part associated to the signal's description themselves. Dimensionality, data type are the main items to be described. 
- [DrillingEquipment](DrillingEquipment.md): in this category fall all the standard equipment encountered on a drilling rig. Note that the goal of the vocabulary is not to provide a detailed description of the rig. Therefore we only consider nouns that can help providing a signal context. 
- [Hydraulics](Hydraulics.md): this part refers to the hydraulic circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs. 
- [Mechanics](Mechanics.md): this part refers to the mechanical circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs. 
- [PhysicalLocation](PhysicalLocation.md): this category contains the vocabulary necessary to specify the location of various items on a rig. Coordinate systems are the main element here.  
- [Quantities](Quantities.md): quantities and units. 
- [TimeManagement](TimeManagement.md): this category referes mostly to the description of the various clocks that can be encoutered on a rig, and their synchronization status with respect to each other. 
- [Uncertainty](Uncertainty.md): this category contains the nouns and verbs required to describe the various types of uncertainty attached to drilling signals. Uncertainties can be related to sensor characteristics, calculations, model calibration, data assimilation.


## Open Questions

Questions are discussed [here](./OpenQuestions.md)
