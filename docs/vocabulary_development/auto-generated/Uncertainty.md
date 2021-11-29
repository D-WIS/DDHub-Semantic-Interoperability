# Uncertainty<!-- DEFINITION SET HEADER -->
- Description: 
# Nouns
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: Represent the uncertainty associated to a signal.
- Examples:
- Definition set: Uncertainty
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: [SignalUncertainty](#../Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: [SignalUncertainty](#../Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: [SignalUncertainty](#../Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## RelativeUncertainty <!-- NOUN -->
- Display name: RelativeUncertainty
- Parent class: [SignalUncertainty](#../Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## SensorUncertainty <!-- NOUN -->
- Display name: SensorUncertainty
- Parent class: [SignalUncertainty](#../Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
# Verbs
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [DrillingData](#../DrillingDataSemantics.md#DrillingData)
- Object class: [SignalUncertainty](#../Uncertainty.md#SignalUncertainty)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [SensorUncertainty](#../Uncertainty.md#SensorUncertainty)
- Object class: [DrillingData](#../DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [SensorUncertainty](#../Uncertainty.md#SensorUncertainty)
- Object class: [DrillingData](#../DrillingDataSemantics.md#DrillingData)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyRelativeValue <!-- VERB -->
- Display name: HasUncertaintyRelativeValue
- Parent verb: [DWISVerb](#../.md#DWISVerb)
- Subject class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Object class: [DWISNoun](#../DWISSemantics.md#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
