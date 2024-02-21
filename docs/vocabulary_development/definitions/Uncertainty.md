- Description: this category contains the nouns and verbs required to describe the various types of uncertainty attached to drilling signals. Uncertainties can be related to sensor characteristics, calculations, model calibration, data assimilation.

# NOUNS
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: Represent the uncertainty associated to a `DrillingDataPoint`. 
- Examples:
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: The uncertainty is represented by a Gaussian distribution, i.e., with a `Mean` and a `StandardDeviation`, $\mathcal{N}(\overline{x},{\sigma_{x}}^2)$ where $\overline{x}$ is the `Mean` value and $\sigma_{x}$ is the `StandardDeviation`.
- Examples:
```dot
"ddp#01" -> "DrillingDataPoint" [label="BelongsToClass"]
```
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: The uncertainty is represented by a `Histogram`.
- Examples:
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: SignalUncertainty
- Attributes:
- Specialization:
- Description: The uncertainty is represented by a uniform probability distribution between a `Min` and a `Max` value.
- Examples:
## FullScaleUncertainty <!-- NOUN -->
- Display name: RelativeUncertainty
- Parent class: GaussianUncertainty
- Attributes:
  - Fullscale
    - Type: double
    - Description: The total range of measurement of the signal, i.e., $\left| max - min \right|}$. The value is expected to be in the same physical quantity as the sensor value.
  - ProportionError
    - Type: double
    - Description: The proportion error on the signal. The value is expected to be a dimensionless physical quantity between 0 and 1 in SI unit. This proportion is applied to the `Fullscale` to obtain the standard deviation of the Gaussian probability distribution that describes the uncertainty of the signal. The mean value of that Gaussian distribution is the signal value.
- Specialization:
- Description: The uncertainty on the signal is described as a Gaussian distribution with a standard deviation that is calculated using a proportion of the maximum range of the signal. The `Fullscale` or `ProportionError` can either be defined as attribute values, for example when they have fixed values, or using facts utilizing the verbs `HasFullScale` or repectively `HasProportionError` when these values may change through time.
- Examples:
## SensorUncertainty <!-- NOUN -->
- Display name: SensorUncertainty
- Parent class: GaussianUncertainty
- Attributes:
  - Accuracy
    - Type: double
    - Description: The standard deviation of the systematic bias component of the uncertainty of the sensor. The assumed mean value of the attached Gaussian distribution is the measured value. The value is expected to be in the same physical quantity as the sensor value.
  - Precision
    - Type: double 
    - Description: The standard deviation of the repetitive error component of the uncertainty of the sensor. The assumed mean value of the attached Gaussian distribution is the measured value. The value is expected to be in the same physical quantity as the sensor value.
- Specialization:
- Description: The uncertainty of the sensor is described by a systematic bias and repetitive error. The systematic bias is referred to as the `Accuracy` while the repetitive error is referred to as the `Precision`. The standard deviation of the overall Gaussian distribution is $\sqrt{\sigma^2{_a}+\sigma^2{_p}}$ where $\sigma_a$ is the accuracy and $\sigma_p$ is the precision. The `Accuracy` or the `Precision` can either be defined as attribute values, for example when they have fixed values, or using another facts utilizing the verbs `HasAccuracy` or respectively `HasPrecision` when these values may change through time.
- Examples:


# VERBS
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SignalUncertainty
- Description: This verb allows to associate a `SignalUncertainty` to a `DrillingDataPoint`.
- Examples: 
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: DWISVerb
- Subject class: SensorUncertainty
- Object class: DrillingDataPoint
- Description: This verb allows to associate a `DrillingDataPoint` as the `Accuracy` of a `SensorUncertainty`
- Examples:
- ## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: DWISVerb
- Subject class: SensorUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Precision` of a `SensorUncertainty`
- Examples: 
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: DWISVerb
- Subject class: MinMaxUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Min` value of `MinMaxUncertainty`
- Examples:
- ## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: DWISVerb
- Subject class: MinMaxUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Max` value of a `MinMaxUncertainty`
- Examples: 
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: DWISVerb
- Subject class: GaussianUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Mean` value of a `GaussianUncertainty`
- Examples:
## HasUncertaintyStandardDeviation <!-- VERB -->
- Display name: HasUncertaintyStandardDeviation
- Parent verb: DWISVerb
- Subject class: GaussianUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `StandardDeviation` value of a `GaussianUncertainty`
- Examples: 
## HasProportionError <!-- VERB -->
- Display name: HasProportionError
- Parent verb: DWISVerb
- Subject class: FullScaleUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `ProportionError` value of a `FullScaleUncertainty`
- Examples:
- ## HasFullScale <!-- VERB -->
- Display name: HasFullScale
- Parent verb: DWISVerb
- Subject class: FullScaleUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `FullScale` value of a `FullScaleUncertainty`
- Examples: 
## HasUncertaintyHistogram <!-- VERB -->
- Display name: HasUncertaintyHistogram
- Parent verb: DWISVerb
- Subject class: GenericUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associated a `DrillingDataPoint` as the `Histogram` value of a `GenericUncertainty`
- Examples: 
