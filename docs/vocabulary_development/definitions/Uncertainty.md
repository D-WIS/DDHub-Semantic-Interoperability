- Description: this category contains the nouns and verbs required to describe the various types of uncertainty attached to drilling signals. Uncertainties can be related to sensor characteristics, calculations, model calibration, data assimilation.

# NOUNS
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: DWISNoun
- Description: Represent the uncertainty associated to a `DrillingDataPoint`. 
- Examples:
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: SignalUncertainty
- Description: The uncertainty is represented by a Gaussian distribution, i.e., with a `Mean` and a `StandardDeviation`, $\mathcal{N}(\overline{x},{\sigma_{x}}^2)$ where $\overline{x}$ is the `Mean` value and $\sigma_{x}$ is the `StandardDeviation`.
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[GaussianUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Mean#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[StdDev#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMean| E[Mean#01] ;
  D[GU#01] -->|HasUncertaintyStandardDeviation| F[StdDev#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Mean#01] -->|HasDynamicValue| G[Signal#01] ;
  F[StdDev#01] -->|HasDynamicValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a Gaussian distribution that is described by a `Mean` value called `Mean#01` and a `StandardDeviation` value called `StdDev#01`. `Mean#01` is a live signal that is attached to `Signal#01`. Similarly `StdDev#01` is a live signal attached to `Signal#02`.
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: SignalUncertainty
- Description: The uncertainty is represented by a `Histogram`.
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[GenericUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Histo#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyHistogram| E[Histo#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Histo#01] -->|HasDynamicValue| G[Signal#01] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a general probability distribution that is described by a histogram called `Histo#01`. `Histo#01` is a live signal that is attached to `Signal#01`.
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: SignalUncertainty
- Description: The uncertainty is represented by a uniform probability distribution between a `Min` and a `Max` value.
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[MinMaxUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Min#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[Max#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMin| E[Min#01] ;
  D[GU#01] -->|HasUncertaintyMax| F[Max#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Min#01] -->|HasDynamicValue| G[Signal#01] ;
  F[Max#01] -->|HasDynamicValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a uniform probability distribution that is described by a `Min` value called `Min#01` and a `Max` value called `Max#01`. `Min#01` is a live signal that is attached to `Signal#01`. Similarly `Max#01` is a live signal attached to `Signal#02`.
## FullScaleUncertainty <!-- NOUN -->
- Display name: FullScaleUncertainty
- Parent class: GaussianUncertainty
- Attributes:
  - FullScale
    - Type: double
    - Description: The total range of measurement of the signal, i.e., $\left| max - min \right|$. The value is expected to be in the same physical quantity as the sensor value.
  - ProportionError
    - Type: double
    - Description: The proportion error on the signal. The value is expected to be a dimensionless physical quantity between 0 and 1 in SI unit. This proportion is applied to the `Fullscale` to obtain the standard deviation of the Gaussian probability distribution that describes the uncertainty of the signal. The mean value of that Gaussian distribution is the signal value.
- Description: The uncertainty on the signal is described as a Gaussian distribution with a standard deviation that is calculated using a proportion of the maximum range of the signal. The `Fullscale` or `ProportionError` can either be defined as attribute values, for example when they have fixed values, or using facts utilizing the verbs `HasFullScale` or repectively `HasProportionError` when these values may change through time.
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[FullScaleUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[FullScale#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[ErrProp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasFullScale| E[FullScale#01] ;
  D[GU#01] -->|HasProportionError| F[ErrProp#01] ;
  G[Signal#01] -->|BelongsToClass| C[DrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DrillingSignal];
  E[FullScale#01] -->|HasStaticValue| G[Signal#01] ;
  F[ErrProp#01] -->|HasStaticValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using a `ProportionError` (called `ErrProp#01`) of a `FullScale` value called `FullScale#01`. `FullScale#01` is a static signal that is attached to `Signal#01`. Similarly `ErrProp#01` is a static signal attached to `Signal#02`.
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
- Description: The uncertainty of the sensor is described by a systematic bias and repetitive error. The systematic bias is referred to as the `Accuracy` while the repetitive error is referred to as the `Precision`. The standard deviation of the overall Gaussian distribution is $\sqrt{\sigma^2{_a}+\sigma^2{_p}}$ where $\sigma_a$ is the accuracy and $\sigma_p$ is the precision. The `Accuracy` or the `Precision` can either be defined as attribute values, for example when they have fixed values, or using another facts utilizing the verbs `HasAccuracy` or respectively `HasPrecision` when these values may change through time.
- Examples: 
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[SensorUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Acc#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[Prec#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyAccuracy| E[Acc#01] ;
  D[GU#01] -->|HasUncertaintyPrecision| F[Prec#01] ;
  G[Signal#01] -->|BelongsToClass| C[DrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DrillingSignal];
  E[Acc#01] -->|HasStaticValue| G[Signal#01] ;
  F[Prec#01] -->|HasStaticValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using an `Accuracy` (called `Acc#01`)  and a `Precision` called `Prec#01`. `Acc#01` is a static signal that is attached to `Signal#01`. Similarly `Prec#01` is a static signal attached to `Signal#02`.
# VERBS
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: DWISVerb
- Subject class: DrillingDataPoint
- Object class: SignalUncertainty
- Description: This verb allows to associate a `SignalUncertainty` to a `DrillingDataPoint`.
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[GaussianUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Mean#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[StdDev#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMean| E[Mean#01] ;
  D[GU#01] -->|HasUncertaintyStandardDeviation| F[StdDev#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Mean#01] -->|HasDynamicValue| G[Signal#01] ;
  F[StdDev#01] -->|HasDynamicValue| H[Signal#02] ;
```
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: DWISVerb
- Subject class: SensorUncertainty
- Object class: DrillingDataPoint
- Description: This verb allows to associate a `DrillingDataPoint` as the `Accuracy` of a `SensorUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[SensorUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Acc#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[Prec#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyAccuracy| E[Acc#01] ;
  D[GU#01] -->|HasUncertaintyPrecision| F[Prec#01] ;
  G[Signal#01] -->|BelongsToClass| C[DrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DrillingSignal];
  E[Acc#01] -->|HasStaticValue| G[Signal#01] ;
  F[Prec#01] -->|HasStaticValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using an `Accuracy` (called `Acc#01`)  and a `Precision` called `Prec#01`. `Acc#01` is a static signal that is attached to `Signal#01`. Similarly `Prec#01` is a static signal attached to `Signal#02`.
- ## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: DWISVerb
- Subject class: SensorUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Precision` of a `SensorUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[SensorUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Acc#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[Prec#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyAccuracy| E[Acc#01] ;
  D[GU#01] -->|HasUncertaintyPrecision| F[Prec#01] ;
  G[Signal#01] -->|BelongsToClass| C[DrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DrillingSignal];
  E[Acc#01] -->|HasStaticValue| G[Signal#01] ;
  F[Prec#01] -->|HasStaticValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using an `Accuracy` (called `Acc#01`)  and a `Precision` called `Prec#01`. `Acc#01` is a static signal that is attached to `Signal#01`. Similarly `Prec#01` is a static signal attached to `Signal#02`.
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: DWISVerb
- Subject class: MinMaxUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Min` value of `MinMaxUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[MinMaxUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Min#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[Max#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMin| E[Min#01] ;
  D[GU#01] -->|HasUncertaintyMax| F[Max#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Min#01] -->|HasDynamicValue| G[Signal#01] ;
  F[Max#01] -->|HasDynamicValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a uniform probability distribution that is described by a `Min` value called `Min#01` and a `Max` value called `Max#01`. `Min#01` is a live signal that is attached to `Signal#01`. Similarly `Max#01` is a live signal attached to `Signal#02`.
- ## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: DWISVerb
- Subject class: MinMaxUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Max` value of a `MinMaxUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[MinMaxUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Min#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[Max#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMin| E[Min#01] ;
  D[GU#01] -->|HasUncertaintyMax| F[Max#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Min#01] -->|HasDynamicValue| G[Signal#01] ;
  F[Max#01] -->|HasDynamicValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a uniform probability distribution that is described by a `Min` value called `Min#01` and a `Max` value called `Max#01`. `Min#01` is a live signal that is attached to `Signal#01`. Similarly `Max#01` is a live signal attached to `Signal#02`.
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: DWISVerb
- Subject class: GaussianUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `Mean` value of a `GaussianUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[GaussianUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Mean#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[StdDev#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMean| E[Mean#01] ;
  D[GU#01] -->|HasUncertaintyStandardDeviation| F[StdDev#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Mean#01] -->|HasDynamicValue| G[Signal#01] ;
  F[StdDev#01] -->|HasDynamicValue| H[Signal#02] ;
```
## HasUncertaintyStandardDeviation <!-- VERB -->
- Display name: HasUncertaintyStandardDeviation
- Parent verb: DWISVerb
- Subject class: GaussianUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `StandardDeviation` value of a `GaussianUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[GaussianUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Mean#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[StdDev#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyMean| E[Mean#01] ;
  D[GU#01] -->|HasUncertaintyStandardDeviation| F[StdDev#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Mean#01] -->|HasDynamicValue| G[Signal#01] ;
  F[StdDev#01] -->|HasDynamicValue| H[Signal#02] ;
```
## HasProportionError <!-- VERB -->
- Display name: HasProportionError
- Parent verb: DWISVerb
- Subject class: FullScaleUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `ProportionError` value of a `FullScaleUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[FullScaleUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[FullScale#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[ErrProp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasFullScale| E[FullScale#01] ;
  D[GU#01] -->|HasProportionError| F[ErrProp#01] ;
  G[Signal#01] -->|BelongsToClass| C[DrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DrillingSignal];
  E[FullScale#01] -->|HasStaticValue| G[Signal#01] ;
  F[ErrProp#01] -->|HasStaticValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using a `ProportionError` (called `ErrProp#01`) of a `FullScale` value called `FullScale#01`. `FullScale#01` is a static signal that is attached to `Signal#01`. Similarly `ErrProp#01` is a static signal attached to `Signal#02`.
- ## HasFullScale <!-- VERB -->
- Display name: HasFullScale
- Parent verb: DWISVerb
- Subject class: FullScaleUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associate a `DrillingDataPoint` as the `FullScale` value of a `FullScaleUncertainty`
- Examples:
```mermaid
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[FullScaleUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[FullScale#01] -->|BelongsToClass| B[DrillingDataPoint];
  F[ErrProp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasFullScale| E[FullScale#01] ;
  D[GU#01] -->|HasProportionError| F[ErrProp#01] ;
  G[Signal#01] -->|BelongsToClass| C[DrillingSignal];
  H[Signal#02] -->|BelongsToClass| C[DrillingSignal];
  E[FullScale#01] -->|HasStaticValue| G[Signal#01] ;
  F[ErrProp#01] -->|HasStaticValue| H[Signal#02] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using a `ProportionError` (called `ErrProp#01`) of a `FullScale` value called `FullScale#01`. `FullScale#01` is a static signal that is attached to `Signal#01`. Similarly `ErrProp#01` is a static signal attached to `Signal#02`.
## HasUncertaintyHistogram <!-- VERB -->
- Display name: HasUncertaintyHistogram
- Parent verb: DWISVerb
- Subject class: GenericUncertainty
- Object class: DrillingDataPoint
- Description: This verb is used to associated a `DrillingDataPoint` as the `Histogram` value of a `GenericUncertainty`
- Examples: 
graph LR;
  A[ddp#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|BelongsToClass| I[GenericUncertainty];
  A[ddp#01] -->|HasUncertainty| D[GU#01] ;
  E[Histo#01] -->|BelongsToClass| B[DrillingDataPoint];
  D[GU#01] -->|HasUncertaintyHistogram| E[Histo#01] ;
  G[Signal#01] -->|BelongsToClass| C[DynamicDrillingSignal];
  E[Histo#01] -->|HasDynamicValue| G[Signal#01] ;
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a general probability distribution that is described by a histogram called `Histo#01`. `Histo#01` is a live signal that is attached to `Signal#01`.
