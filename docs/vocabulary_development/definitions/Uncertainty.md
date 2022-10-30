- Description: this category contains the nouns and verbs required to describe the various types of uncertainty attached to drilling signals. Uncertainties can be related to sensor characteristics, calculations, model calibration, data assimilation.

# NOUNS
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Represent the uncertainty associated to a signal. 
- Examples:
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: 
- Examples:
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: 
- Examples:
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: 
- Examples:
## RelativeUncertainty <!-- NOUN -->
- Display name: RelativeUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: 
- Examples:
## SensorUncertainty <!-- NOUN -->
- Display name: SensorUncertainty
- Parent class: SignalUncertainty
- Attributes:
  - Accuracy
    - Type: double
    - Description:
  - Precision
    - Type: double 
    - Description: 
- Specialization:
- Description: 
- Examples:


# VERBS
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SignalUncertainty
- Description: 
- Examples: 
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: DWISVerb
- Subject class: SensorUncertainty
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: DWISVerb
- Subject class: SensorUncertainty
- Object class: DrillingDataPoint
- Description: 
- Examples: 
## HasUncertaintyRelativeValue <!-- VERB -->
- Display name: HasUncertaintyRelativeValue
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## HasUncertaintyStandardDeviation <!-- VERB -->
- Display name: HasUncertaintyStandardDeviation
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
