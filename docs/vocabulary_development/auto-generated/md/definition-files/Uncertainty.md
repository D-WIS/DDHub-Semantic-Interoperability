# Uncertainty<!-- DEFINITION SET HEADER -->
- Description: this category contains the nouns and verbs required to describe the various types of uncertainty attached to drilling signals. Uncertainties can be related to sensor characteristics, calculations, model calibration, data assimilation.
# Nouns
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: Represent the uncertainty associated to a `DrillingDataPoint`.
- Examples:
This noun is not intended to be used directly in describing a signal. However, it can be useful when formulating a query and then it serves as a generic way to check if there are facts related to uncertainty description for a `DrillingDataPoint`.
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[dataPoint] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[uncertainty] -->|BelongsTo| N0003[SignalUncertainty] 
	N0000[dataPoint] -->|HasUncertainty| N0002[uncertainty] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?dataPoint
WHERE {
	?dataPoint rdf:type ddhub:DrillingDataPoint .
	?uncertainty rdf:type ddhub:SignalUncertainty .
	?dataPoint ddhub:HasUncertainty ?uncertainty .
}
```
This query returns all the `DrillingDataPoint` for which an uncertainty is given.
- Definition set: Uncertainty
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: [SignalUncertainty](./Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: The uncertainty is represented by a Gaussian distribution, i.e., with a `Mean` and a `StandardDeviation`, $\mathcal{N}(\overline{x},{\sigma_{x}}^2)$ where $\overline{x}$ is the `Mean` value and $\sigma_{x}$ is the `StandardDeviation`.
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[GaussianUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Mean#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[StdDev#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMean| N0004[Mean#01] 
	N0002[GU#01] -->|HasUncertaintyStandardDeviation| N0005[StdDev#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Mean#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[StdDev#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:GaussianUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Mean#01 rdf:type ddhub:DrillingDataPoint .
	?StdDev#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMean ?Mean#01 .
	?GU#01 ddhub:HasUncertaintyStandardDeviation ?StdDev#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Mean#01 ddhub:HasDynamicValue ?Signal#01 .
	?StdDev#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a Gaussian distribution that is described by a `Mean` value called `Mean#01` and a `StandardDeviation` value called `StdDev#01`. `Mean#01` is a live signal that is attached to `Signal#01`. Similarly `StdDev#01` is a live signal attached to `Signal#02`.
- Definition set: Uncertainty
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: [SignalUncertainty](./Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: The uncertainty is represented by a `Histogram`.
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[GenericUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Histo#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyHistogram| N0004[Histo#01] 
	N0005[Signal#01] -->|BelongsTo| N0006[DynamicDrillingSignal] 
	N0004[Histo#01] -->|HasDynamicValue| N0005[Signal#01] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:GenericUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Histo#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyHistogram ?Histo#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Histo#01 ddhub:HasDynamicValue ?Signal#01 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a general probability distribution that is described by a histogram called `Histo#01`. `Histo#01` is a live signal that is attached to `Signal#01`.
- Definition set: Uncertainty
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: [SignalUncertainty](./Uncertainty.md#SignalUncertainty)
- Attributes:
- Specialization:
- Description: The uncertainty is represented by a uniform probability distribution between a `Min` and a `Max` value.
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[MinMaxUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Min#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[Max#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMin| N0004[Min#01] 
	N0002[GU#01] -->|HasUncertaintyMax| N0005[Max#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Min#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[Max#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:MinMaxUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Min#01 rdf:type ddhub:DrillingDataPoint .
	?Max#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMin ?Min#01 .
	?GU#01 ddhub:HasUncertaintyMax ?Max#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Min#01 ddhub:HasDynamicValue ?Signal#01 .
	?Max#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a uniform probability distribution that is described by a `Min` value called `Min#01` and a `Max` value called `Max#01`. `Min#01` is a live signal that is attached to `Signal#01`. Similarly `Max#01` is a live signal attached to `Signal#02`.
- Definition set: Uncertainty
## FullScaleUncertainty <!-- NOUN -->
- Display name: FullScaleUncertainty
- Parent class: [GaussianUncertainty](./Uncertainty.md#GaussianUncertainty)
- Attributes:
  - FullScale
    - Type: double
    - Description: The total range of measurement of the signal, i.e., $\left| max - min \right|$. The value is expected to be in the same physical quantity as the sensor value.
  - ProportionError
    - Type: double
    - Description: The proportion error on the signal. The value is expected to be a dimensionless physical quantity between 0 and 1 in SI unit. This proportion is applied to the `Fullscale` to obtain the standard deviation of the Gaussian probability distribution that describes the uncertainty of the signal. The mean value of that Gaussian distribution is the signal value.
- Specialization:
- Description: The uncertainty on the signal is described as a Gaussian distribution with a standard deviation that is calculated using a proportion of the maximum range of the signal. The `Fullscale` or `ProportionError` can either be defined as attribute values, for example when they have fixed values, or using facts utilizing the verbs `HasFullScale` or repectively `HasProportionError` when these values may change through time.
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[FullScaleUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[FullScale#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[ErrProp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasFullScale| N0004[FullScale#01] 
	N0002[GU#01] -->|HasProportionError| N0005[ErrProp#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DrillingSignal] 
	N0004[FullScale#01] -->|HasStaticValue| N0006[Signal#01] 
	N0005[ErrProp#01] -->|HasStaticValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:FullScaleUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?FullScale#01 rdf:type ddhub:DrillingDataPoint .
	?ErrProp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasFullScale ?FullScale#01 .
	?GU#01 ddhub:HasProportionError ?ErrProp#01 .
	?Signal#01 rdf:type ddhub:DrillingSignal .
	?Signal#02 rdf:type ddhub:DrillingSignal .
	?FullScale#01 ddhub:HasStaticValue ?Signal#01 .
	?ErrProp#01 ddhub:HasStaticValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using a `ProportionError` (called `ErrProp#01`) of a `FullScale` value called `FullScale#01`. `FullScale#01` is a static signal that is attached to `Signal#01`. Similarly `ErrProp#01` is a static signal attached to `Signal#02`.
- Definition set: Uncertainty
## SensorUncertainty <!-- NOUN -->
- Display name: SensorUncertainty
- Parent class: [GaussianUncertainty](./Uncertainty.md#GaussianUncertainty)
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
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[SensorUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Acc#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[Prec#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyAccuracy| N0004[Acc#01] 
	N0002[GU#01] -->|HasUncertaintyPrecision| N0005[Prec#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DrillingSignal] 
	N0004[Acc#01] -->|HasStaticValue| N0006[Signal#01] 
	N0005[Prec#01] -->|HasStaticValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:SensorUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Acc#01 rdf:type ddhub:DrillingDataPoint .
	?Prec#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyAccuracy ?Acc#01 .
	?GU#01 ddhub:HasUncertaintyPrecision ?Prec#01 .
	?Signal#01 rdf:type ddhub:DrillingSignal .
	?Signal#02 rdf:type ddhub:DrillingSignal .
	?Acc#01 ddhub:HasStaticValue ?Signal#01 .
	?Prec#01 ddhub:HasStaticValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using an `Accuracy` (called `Acc#01`)  and a `Precision` called `Prec#01`. `Acc#01` is a static signal that is attached to `Signal#01`. Similarly `Prec#01` is a static signal attached to `Signal#02`.
- Definition set: Uncertainty
# Verbs
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Object class: [SignalUncertainty](./Uncertainty.md#SignalUncertainty)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb allows to associate a `SignalUncertainty` to a `DrillingDataPoint`.
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[GaussianUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Mean#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[StdDev#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMean| N0004[Mean#01] 
	N0002[GU#01] -->|HasUncertaintyStandardDeviation| N0005[StdDev#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Mean#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[StdDev#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:GaussianUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Mean#01 rdf:type ddhub:DrillingDataPoint .
	?StdDev#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMean ?Mean#01 .
	?GU#01 ddhub:HasUncertaintyStandardDeviation ?StdDev#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Mean#01 ddhub:HasDynamicValue ?Signal#01 .
	?StdDev#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
- Definition set: Uncertainty
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [SensorUncertainty](./Uncertainty.md#SensorUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb allows to associate a `DrillingDataPoint` as the `Accuracy` of a `SensorUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[SensorUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Acc#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[Prec#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyAccuracy| N0004[Acc#01] 
	N0002[GU#01] -->|HasUncertaintyPrecision| N0005[Prec#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DrillingSignal] 
	N0004[Acc#01] -->|HasStaticValue| N0006[Signal#01] 
	N0005[Prec#01] -->|HasStaticValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:SensorUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Acc#01 rdf:type ddhub:DrillingDataPoint .
	?Prec#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyAccuracy ?Acc#01 .
	?GU#01 ddhub:HasUncertaintyPrecision ?Prec#01 .
	?Signal#01 rdf:type ddhub:DrillingSignal .
	?Signal#02 rdf:type ddhub:DrillingSignal .
	?Acc#01 ddhub:HasStaticValue ?Signal#01 .
	?Prec#01 ddhub:HasStaticValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using an `Accuracy` (called `Acc#01`)  and a `Precision` called `Prec#01`. `Acc#01` is a static signal that is attached to `Signal#01`. Similarly `Prec#01` is a static signal attached to `Signal#02`.
- Definition set: Uncertainty
## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [SensorUncertainty](./Uncertainty.md#SensorUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `Precision` of a `SensorUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[SensorUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Acc#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[Prec#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyAccuracy| N0004[Acc#01] 
	N0002[GU#01] -->|HasUncertaintyPrecision| N0005[Prec#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DrillingSignal] 
	N0004[Acc#01] -->|HasStaticValue| N0006[Signal#01] 
	N0005[Prec#01] -->|HasStaticValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:SensorUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Acc#01 rdf:type ddhub:DrillingDataPoint .
	?Prec#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyAccuracy ?Acc#01 .
	?GU#01 ddhub:HasUncertaintyPrecision ?Prec#01 .
	?Signal#01 rdf:type ddhub:DrillingSignal .
	?Signal#02 rdf:type ddhub:DrillingSignal .
	?Acc#01 ddhub:HasStaticValue ?Signal#01 .
	?Prec#01 ddhub:HasStaticValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using an `Accuracy` (called `Acc#01`)  and a `Precision` called `Prec#01`. `Acc#01` is a static signal that is attached to `Signal#01`. Similarly `Prec#01` is a static signal attached to `Signal#02`.
- Definition set: Uncertainty
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MinMaxUncertainty](./Uncertainty.md#MinMaxUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `Min` value of `MinMaxUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[MinMaxUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Min#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[Max#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMin| N0004[Min#01] 
	N0002[GU#01] -->|HasUncertaintyMax| N0005[Max#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Min#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[Max#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:MinMaxUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Min#01 rdf:type ddhub:DrillingDataPoint .
	?Max#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMin ?Min#01 .
	?GU#01 ddhub:HasUncertaintyMax ?Max#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Min#01 ddhub:HasDynamicValue ?Signal#01 .
	?Max#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a uniform probability distribution that is described by a `Min` value called `Min#01` and a `Max` value called `Max#01`. `Min#01` is a live signal that is attached to `Signal#01`. Similarly `Max#01` is a live signal attached to `Signal#02`.
- Definition set: Uncertainty
## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [MinMaxUncertainty](./Uncertainty.md#MinMaxUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `Max` value of a `MinMaxUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[MinMaxUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Min#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[Max#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMin| N0004[Min#01] 
	N0002[GU#01] -->|HasUncertaintyMax| N0005[Max#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Min#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[Max#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:MinMaxUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Min#01 rdf:type ddhub:DrillingDataPoint .
	?Max#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMin ?Min#01 .
	?GU#01 ddhub:HasUncertaintyMax ?Max#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Min#01 ddhub:HasDynamicValue ?Signal#01 .
	?Max#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a uniform probability distribution that is described by a `Min` value called `Min#01` and a `Max` value called `Max#01`. `Min#01` is a live signal that is attached to `Signal#01`. Similarly `Max#01` is a live signal attached to `Signal#02`.
- Definition set: Uncertainty
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [GaussianUncertainty](./Uncertainty.md#GaussianUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `Mean` value of a `GaussianUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[GaussianUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Mean#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[StdDev#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMean| N0004[Mean#01] 
	N0002[GU#01] -->|HasUncertaintyStandardDeviation| N0005[StdDev#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Mean#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[StdDev#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:GaussianUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Mean#01 rdf:type ddhub:DrillingDataPoint .
	?StdDev#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMean ?Mean#01 .
	?GU#01 ddhub:HasUncertaintyStandardDeviation ?StdDev#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Mean#01 ddhub:HasDynamicValue ?Signal#01 .
	?StdDev#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
- Definition set: Uncertainty
## HasUncertaintyStandardDeviation <!-- VERB -->
- Display name: HasUncertaintyStandardDeviation
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [GaussianUncertainty](./Uncertainty.md#GaussianUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `StandardDeviation` value of a `GaussianUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[GaussianUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Mean#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[StdDev#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyMean| N0004[Mean#01] 
	N0002[GU#01] -->|HasUncertaintyStandardDeviation| N0005[StdDev#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DynamicDrillingSignal] 
	N0004[Mean#01] -->|HasDynamicValue| N0006[Signal#01] 
	N0005[StdDev#01] -->|HasDynamicValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:GaussianUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Mean#01 rdf:type ddhub:DrillingDataPoint .
	?StdDev#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyMean ?Mean#01 .
	?GU#01 ddhub:HasUncertaintyStandardDeviation ?StdDev#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Signal#02 rdf:type ddhub:DynamicDrillingSignal .
	?Mean#01 ddhub:HasDynamicValue ?Signal#01 .
	?StdDev#01 ddhub:HasDynamicValue ?Signal#02 .
}
```
- Definition set: Uncertainty
## HasProportionError <!-- VERB -->
- Display name: HasProportionError
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [FullScaleUncertainty](./Uncertainty.md#FullScaleUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `ProportionError` value of a `FullScaleUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[FullScaleUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[FullScale#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[ErrProp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasFullScale| N0004[FullScale#01] 
	N0002[GU#01] -->|HasProportionError| N0005[ErrProp#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DrillingSignal] 
	N0004[FullScale#01] -->|HasStaticValue| N0006[Signal#01] 
	N0005[ErrProp#01] -->|HasStaticValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:FullScaleUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?FullScale#01 rdf:type ddhub:DrillingDataPoint .
	?ErrProp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasFullScale ?FullScale#01 .
	?GU#01 ddhub:HasProportionError ?ErrProp#01 .
	?Signal#01 rdf:type ddhub:DrillingSignal .
	?Signal#02 rdf:type ddhub:DrillingSignal .
	?FullScale#01 ddhub:HasStaticValue ?Signal#01 .
	?ErrProp#01 ddhub:HasStaticValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using a `ProportionError` (called `ErrProp#01`) of a `FullScale` value called `FullScale#01`. `FullScale#01` is a static signal that is attached to `Signal#01`. Similarly `ErrProp#01` is a static signal attached to `Signal#02`.
- Definition set: Uncertainty
## HasFullScale <!-- VERB -->
- Display name: HasFullScale
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [FullScaleUncertainty](./Uncertainty.md#FullScaleUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associate a `DrillingDataPoint` as the `FullScale` value of a `FullScaleUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[FullScaleUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[FullScale#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0005[ErrProp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasFullScale| N0004[FullScale#01] 
	N0002[GU#01] -->|HasProportionError| N0005[ErrProp#01] 
	N0006[Signal#01] -->|BelongsTo| N0007[DrillingSignal] 
	N0008[Signal#02] -->|BelongsTo| N0007[DrillingSignal] 
	N0004[FullScale#01] -->|HasStaticValue| N0006[Signal#01] 
	N0005[ErrProp#01] -->|HasStaticValue| N0008[Signal#02] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01, ?Signal#02
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:FullScaleUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?FullScale#01 rdf:type ddhub:DrillingDataPoint .
	?ErrProp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasFullScale ?FullScale#01 .
	?GU#01 ddhub:HasProportionError ?ErrProp#01 .
	?Signal#01 rdf:type ddhub:DrillingSignal .
	?Signal#02 rdf:type ddhub:DrillingSignal .
	?FullScale#01 ddhub:HasStaticValue ?Signal#01 .
	?ErrProp#01 ddhub:HasStaticValue ?Signal#02 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is representing a sensor having a Gaussian probability distibution that is described using a `ProportionError` (called `ErrProp#01`) of a `FullScale` value called `FullScale#01`. `FullScale#01` is a static signal that is attached to `Signal#01`. Similarly `ErrProp#01` is a static signal attached to `Signal#02`.
- Definition set: Uncertainty
## HasUncertaintyHistogram <!-- VERB -->
- Display name: HasUncertaintyHistogram
- Parent verb: [DWISVerb](./DWISSemantics.md#DWISVerb)
- Subject class: [GenericUncertainty](./Uncertainty.md#GenericUncertainty)
- Object class: [DrillingDataPoint](./DrillingDataSemantics.md#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: This verb is used to associated a `DrillingDataPoint` as the `Histogram` value of a `GenericUncertainty`
- Examples:
An example semantic graph looks like as follow:
```mermaid
graph LR
	N0000[ddp#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|BelongsTo| N0003[GenericUncertainty] 
	N0000[ddp#01] -->|HasUncertainty| N0002[GU#01] 
	N0004[Histo#01] -->|BelongsTo| N0001[DrillingDataPoint] 
	N0002[GU#01] -->|HasUncertaintyHistogram| N0004[Histo#01] 
	N0005[Signal#01] -->|BelongsTo| N0006[DynamicDrillingSignal] 
	N0004[Histo#01] -->|HasDynamicValue| N0005[Signal#01] 
```
An example SparQL query looks like this:
```sparql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX ddhub: <http://ddhub.no/>
PREFIX quantity: <http://ddhub.no/UnitAndQuantity>
SELECT ?Signal#01
WHERE {
	?ddp#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 rdf:type ddhub:GenericUncertainty .
	?ddp#01 ddhub:HasUncertainty ?GU#01 .
	?Histo#01 rdf:type ddhub:DrillingDataPoint .
	?GU#01 ddhub:HasUncertaintyHistogram ?Histo#01 .
	?Signal#01 rdf:type ddhub:DynamicDrillingSignal .
	?Histo#01 ddhub:HasDynamicValue ?Signal#01 .
}
```
In this example, `ddp#01` is a `DrillingDataPoint` that has an uncertainty `GU#01`, which is a general probability distribution that is described by a histogram called `Histo#01`. `Histo#01` is a live signal that is attached to `Signal#01`.
- Definition set: Uncertainty
