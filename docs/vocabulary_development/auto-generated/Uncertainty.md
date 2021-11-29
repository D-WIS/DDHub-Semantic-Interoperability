# Uncertainty<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: [DWISNoun](#./DWISSemantics.md)
- Attributes:
- Specialization:
- Description: Represent the uncertainty associated to a signal.
- Examples:
- Definition set: Uncertainty
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: [SignalUncertainty](#./Uncertainty.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: [SignalUncertainty](#./Uncertainty.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: [SignalUncertainty](#./Uncertainty.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## RelativeUncertainty <!-- NOUN -->
- Display name: RelativeUncertainty
- Parent class: [SignalUncertainty](#./Uncertainty.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## SensorUncertainty <!-- NOUN -->
- Display name: SensorUncertainty
- Parent class: [SignalUncertainty](#./Uncertainty.md)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
# Verbs
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DrillingData](#./DrillingDataSemantics.md)
- Object class: [SignalUncertainty](#./Uncertainty.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: [DWISVerb](#./.md)
- Subject class: [SensorUncertainty](#./Uncertainty.md)
- Object class: [DrillingData](#./DrillingDataSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DWISNoun](#./DWISSemantics.md)
- Object class: [DWISNoun](#./DWISSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DWISNoun](#./DWISSemantics.md)
- Object class: [DWISNoun](#./DWISSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DWISNoun](#./DWISSemantics.md)
- Object class: [DWISNoun](#./DWISSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: [DWISVerb](#./.md)
- Subject class: [SensorUncertainty](#./Uncertainty.md)
- Object class: [DrillingData](#./DrillingDataSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyRelativeValue <!-- VERB -->
- Display name: HasUncertaintyRelativeValue
- Parent verb: [DWISVerb](#./.md)
- Subject class: [DWISNoun](#./DWISSemantics.md)
- Object class: [DWISNoun](#./DWISSemantics.md)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
