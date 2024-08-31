-Description: standard quantity types. These are sub-classes of `Quantity`, for which their physical dimension is defined.

# NOUNS
## AccelerationQuantity <!-- NOUN -->
- Display name: Acceleration
- Parent class: Quantity
- Specialization: 
  - L = 1
  - T = -2
- Description: 
**Acceleration** is defined as the rate of change of velocity with respect to time. Velocity itself is the rate of change of displacement (or position) with respect to time. Therefore, acceleration is the rate of change of displacement twice with respect to time.

Let's break this down:

1. **Displacement** (or position) has the dimension of **Length(L)**.

2. **Velocity** is displacement per unit time:
$$\text{Velocity} = \frac{\text{Length}}{\text{Time}} = \frac{L}{T}$$
So, the dimension of velocity is **$[L T^{ -1}]$**.

3. **Acceleration** is the rate of change of velocity with respect to time:
$$\text{Acceleration} = \frac{\text{Velocity}}{\text{Time}} = \frac{L T^{ -1}}{T} = L T ^{-2}$$
Therefore, the dimension of acceleration is $[LT^{-2}]$.

The SI unit for **acceleration** is: metre per second squared with the associated unit label $\frac{m}{s^{2}}$

- Examples: 
``` dwis
Quantity:AccelerationQuantity
AccelerationQuantity.L = 1
AccelerationQuantity.T = -2
Unit:MetrePerSecondSquared
MetrePerSecondSquared.ConversionFactorA = 0
MetrePerSecondSquared.ConversionFactorB = 1
MetrePerSecondSquared.Symbol = "m/s²"
MetrePerSecondSquared IsUnitForQuantity AccelerationQuantity
AccelerationQuantity HasSIUnit MetrePerSecondSquared
Unit:FootPerSecondSquared
FootPerSecondSquared.ConversionFactorA = 0
FootPerSecondSquared.ConversionFactorB = 3.280839895013124
FootPerSecondSquared.Symbol = "ft/s²"
FootPerSecondSquared IsUnitForQuantity AccelerationQuantity
Unit:CentimetrePerSecondSquared
CentimetrePerSecondSquared.ConversionFactorA = 0
CentimetrePerSecondSquared.ConversionFactorB = 100
CentimetrePerSecondSquared.Symbol = "cm/s²"
CentimetrePerSecondSquared IsUnitForQuantity AccelerationQuantity
Unit:CentimetrePerHourPerSecond
CentimetrePerHourPerSecond.ConversionFactorA = 0
CentimetrePerHourPerSecond.ConversionFactorB = 360000
CentimetrePerHourPerSecond.Symbol = "cm/(h•s)"
CentimetrePerHourPerSecond IsUnitForQuantity AccelerationQuantity
Unit:CentimetrePerMinutePerSecond
CentimetrePerMinutePerSecond.ConversionFactorA = 0
CentimetrePerMinutePerSecond.ConversionFactorB = 6000
CentimetrePerMinutePerSecond.Symbol = "cm/(min•s)"
CentimetrePerMinutePerSecond IsUnitForQuantity AccelerationQuantity
Unit:FootPerHourPerSecond
FootPerHourPerSecond.ConversionFactorA = 0
FootPerHourPerSecond.ConversionFactorB = 11811.023622047245
FootPerHourPerSecond.Symbol = "ft/(h•s)"
FootPerHourPerSecond IsUnitForQuantity AccelerationQuantity
Unit:FootPerMinutePerSecond
FootPerMinutePerSecond.ConversionFactorA = 0
FootPerMinutePerSecond.ConversionFactorB = 196.85039370078744
FootPerMinutePerSecond.Symbol = "ft/(min•s)"
FootPerMinutePerSecond IsUnitForQuantity AccelerationQuantity
Unit:Galileo
Galileo.ConversionFactorA = 0
Galileo.ConversionFactorB = 100
Galileo.Symbol = "Gal"
Galileo IsUnitForQuantity AccelerationQuantity
Unit:GravityStandard
GravityStandard.ConversionFactorA = 0
GravityStandard.ConversionFactorB = 0.10197162129779283
GravityStandard.Symbol = "gn"
GravityStandard IsUnitForQuantity AccelerationQuantity
Unit:InchPerHourPerSecond
InchPerHourPerSecond.ConversionFactorA = 0
InchPerHourPerSecond.ConversionFactorB = 141732.28346456692
InchPerHourPerSecond.Symbol = "in/(h•s)"
InchPerHourPerSecond IsUnitForQuantity AccelerationQuantity
Unit:InchPerMinutePerSecond
InchPerMinutePerSecond.ConversionFactorA = 0
InchPerMinutePerSecond.ConversionFactorB = 2362.2047244094488
InchPerMinutePerSecond.Symbol = "in/(min•s)"
InchPerMinutePerSecond IsUnitForQuantity AccelerationQuantity
Unit:InchPerSecondSquared
InchPerSecondSquared.ConversionFactorA = 0
InchPerSecondSquared.ConversionFactorB = 39.37007874015748
InchPerSecondSquared.Symbol = "in/s²"
InchPerSecondSquared IsUnitForQuantity AccelerationQuantity
Unit:KnotPerSecond
KnotPerSecond.ConversionFactorA = 0
KnotPerSecond.ConversionFactorB = 1.9438444924406046
KnotPerSecond.Symbol = "kn/s"
KnotPerSecond IsUnitForQuantity AccelerationQuantity
Unit:MetrePerSecondPerMillisecond
MetrePerSecondPerMillisecond.ConversionFactorA = 0
MetrePerSecondPerMillisecond.ConversionFactorB = 0.001
MetrePerSecondPerMillisecond.Symbol = "m/(s•ms)"
MetrePerSecondPerMillisecond IsUnitForQuantity AccelerationQuantity
Unit:MilePerHourPerSecond
MilePerHourPerSecond.ConversionFactorA = 0
MilePerHourPerSecond.ConversionFactorB = 2.2369362920544025
MilePerHourPerSecond.Symbol = "mi/(h•s)"
MilePerHourPerSecond IsUnitForQuantity AccelerationQuantity
Unit:MilePerMinutePerSecond
MilePerMinutePerSecond.ConversionFactorA = 0
MilePerMinutePerSecond.ConversionFactorB = 0.03728227153424004
MilePerMinutePerSecond.Symbol = "mi/(min•s)"
MilePerMinutePerSecond IsUnitForQuantity AccelerationQuantity
Unit:MilePerSecondSquared
MilePerSecondSquared.ConversionFactorA = 0
MilePerSecondSquared.ConversionFactorB = 0.000621371192237334
MilePerSecondSquared.Symbol = "mi/s²"
MilePerSecondSquared IsUnitForQuantity AccelerationQuantity
Unit:KilometrePerSecondSquared
KilometrePerSecondSquared.ConversionFactorA = 0
KilometrePerSecondSquared.ConversionFactorB = 0.001
KilometrePerSecondSquared.Symbol = "km/s²"
KilometrePerSecondSquared IsUnitForQuantity AccelerationQuantity
Unit:KilometrePerHourPerSecond
KilometrePerHourPerSecond.ConversionFactorA = 0
KilometrePerHourPerSecond.ConversionFactorB = 3.6
KilometrePerHourPerSecond.Symbol = "km/(h•s)"
KilometrePerHourPerSecond IsUnitForQuantity AccelerationQuantity
Unit:KilometrePerMinutePerSecond
KilometrePerMinutePerSecond.ConversionFactorA = 0
KilometrePerMinutePerSecond.ConversionFactorB = 0.06
KilometrePerMinutePerSecond.Symbol = "km/(min•s)"
KilometrePerMinutePerSecond IsUnitForQuantity AccelerationQuantity
```
## AmountSubstanceQuantity <!-- NOUN -->
- Display name: AmountSubstance
- Parent class: Quantity
- Specialization: 
  - N = 1
- Description: 
The **amount of substance** refers to the quantity of entities (such as atoms, molecules, ions, or other particles) in a system.The standard unit used to measure the amount of substance is the **mole** (mol). One mole corresponds to $6.022×10^{23}$ entities (Avogadro's number) of the given substance.

This is one of the nine fundamental dimensions in the International System of Units (SI).A fundamental quantity does not depend on any combinations of other fundamental dimensions.It is denoted $[N]$.
The SI unit for **amount substance** is: mole with the associated unit label $mol$

- Examples: 
``` dwis
Quantity:AmountSubstanceQuantity
AmountSubstanceQuantity.N = 1
Unit:Mole
Mole.ConversionFactorA = 0
Mole.ConversionFactorB = 1
Mole.Symbol = "mol"
Mole IsUnitForQuantity AmountSubstanceQuantity
AmountSubstanceQuantity HasSIUnit Mole
Unit:Decimole
Decimole.ConversionFactorA = 0
Decimole.ConversionFactorB = 10
Decimole.Symbol = "dmol"
Decimole IsUnitForQuantity AmountSubstanceQuantity
Unit:Centimole
Centimole.ConversionFactorA = 0
Centimole.ConversionFactorB = 100
Centimole.Symbol = "cmol"
Centimole IsUnitForQuantity AmountSubstanceQuantity
Unit:Millimole
Millimole.ConversionFactorA = 0
Millimole.ConversionFactorB = 1000
Millimole.Symbol = "mmol"
Millimole IsUnitForQuantity AmountSubstanceQuantity
Unit:Micromole
Micromole.ConversionFactorA = 0
Micromole.ConversionFactorB = 1000000
Micromole.Symbol = "µmol"
Micromole IsUnitForQuantity AmountSubstanceQuantity
Unit:Nanomole
Nanomole.ConversionFactorA = 0
Nanomole.ConversionFactorB = 999999999.9999999
Nanomole.Symbol = "nmol"
Nanomole IsUnitForQuantity AmountSubstanceQuantity
Unit:Picomole
Picomole.ConversionFactorA = 0
Picomole.ConversionFactorB = 1000000000000
Picomole.Symbol = "pmol"
Picomole IsUnitForQuantity AmountSubstanceQuantity
Unit:Kilomole
Kilomole.ConversionFactorA = 0
Kilomole.ConversionFactorB = 0.001
Kilomole.Symbol = "kmol"
Kilomole IsUnitForQuantity AmountSubstanceQuantity
```
## AngleGradientPerLengthQuantity <!-- NOUN -->
- Display name: AngleGradientPerLength
- Parent class: Quantity
- Specialization: 
  - L = -1
  - Theta = 1
- Description: 
Consider a situation where you have a length $L$ along which an angle $\theta$ changes. The angle variation gradient is defined as the **rate of change of the angle** per unit change in length. Mathematically, it can be expressed as: 
$$\text{ Angle Variation Gradient} = \frac{ d\theta}{ dL}$$
where: 
- **$d\theta$** is the infinitesimal change in the angle. 
- **$dL$** is the infinitesimal change in the length along the direction of interest. 
1. **Dimension**: The angle $\theta$ has the dimension of **plane angle**, and the length $L$ is one of the fundamental dimensions. Therefore, the dimension of **angle variation gradient** is: 
$$[{\theta}L^{-1}]$$ 
2. **Interpretation**: This gradient describes how quickly the angle changes as you move along the length. For example, in fields like physics or engineering, this could describe the bending of a beam(where the angle describes the deflection) or the rate of turning along a curved path. 
3. **Applications**: This concept is common in areas like differential geometry, mechanics (bending beams or wires), and in the analysis of curvature in space (where curvature can be described as the rate of change of the angle with respect to the arc length). 

The SI unit for **angle gradient per length** is: radian per metre with the associated unit label $\frac{rad}{m}$

- Examples: 
``` dwis
Quantity:AngleGradientPerLengthQuantity
AngleGradientPerLengthQuantity.L = -1
AngleGradientPerLengthQuantity.Theta = 1
Unit:RadianPerMetre
RadianPerMetre.ConversionFactorA = 0
RadianPerMetre.ConversionFactorB = 1
RadianPerMetre.Symbol = "rad/m"
RadianPerMetre IsUnitForQuantity AngleGradientPerLengthQuantity
AngleGradientPerLengthQuantity HasSIUnit RadianPerMetre
Unit:DegreePerMetre
DegreePerMetre.ConversionFactorA = 0
DegreePerMetre.ConversionFactorB = 57.29577951308232
DegreePerMetre.Symbol = "°/m"
DegreePerMetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:DegreePerCentimetre
DegreePerCentimetre.ConversionFactorA = 0
DegreePerCentimetre.ConversionFactorB = 0.5729577951308232
DegreePerCentimetre.Symbol = "°/cm"
DegreePerCentimetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:DegreePerFoot
DegreePerFoot.ConversionFactorA = 0
DegreePerFoot.ConversionFactorB = 17.46375359558749
DegreePerFoot.Symbol = "°/ft"
DegreePerFoot IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:DegreePerInch
DegreePerInch.ConversionFactorA = 0
DegreePerInch.ConversionFactorB = 1.455312799632291
DegreePerInch.Symbol = "°/in"
DegreePerInch IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:DegreePerDecimetre
DegreePerDecimetre.ConversionFactorA = 0
DegreePerDecimetre.ConversionFactorB = 5.729577951308233
DegreePerDecimetre.Symbol = "°/dm"
DegreePerDecimetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:DegreePerMillimetre
DegreePerMillimetre.ConversionFactorA = 0
DegreePerMillimetre.ConversionFactorB = 0.057295779513082325
DegreePerMillimetre.Symbol = "°/mm"
DegreePerMillimetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:RadianPerMillimetre
RadianPerMillimetre.ConversionFactorA = 0
RadianPerMillimetre.ConversionFactorB = 0.001
RadianPerMillimetre.Symbol = "rad/mm"
RadianPerMillimetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:RadianPerCentimetre
RadianPerCentimetre.ConversionFactorA = 0
RadianPerCentimetre.ConversionFactorB = 0.01
RadianPerCentimetre.Symbol = "rad/cm"
RadianPerCentimetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:RadianPerDecimetre
RadianPerDecimetre.ConversionFactorA = 0
RadianPerDecimetre.ConversionFactorB = 0.1
RadianPerDecimetre.Symbol = "rad/dm"
RadianPerDecimetre IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:RadianPerFoot
RadianPerFoot.ConversionFactorA = 0
RadianPerFoot.ConversionFactorB = 0.30479999999999996
RadianPerFoot.Symbol = "rad/ft"
RadianPerFoot IsUnitForQuantity AngleGradientPerLengthQuantity
Unit:RadianPerInch
RadianPerInch.ConversionFactorA = 0
RadianPerInch.ConversionFactorB = 0.0254
RadianPerInch.Symbol = "rad/in"
RadianPerInch IsUnitForQuantity AngleGradientPerLengthQuantity
```
## AngleMagneticFluxDensityQuantity <!-- NOUN -->
- Display name: AngleMagneticFluxDensity
- Parent class: Quantity
- Specialization: 
  - M = 1
  - T = -2
  - I = -1
  - Theta = 1
- Description: 
The **angle magnetic flux density** is the product of an angle by a magnetic flux density. Let's break it down step by step:
1. Magnetic Flux Density
The **magnetic flux density** $\mathbf{B}$ is a measure of the strength and direction of the magnetic field at a particular point in space. It represents the amount of magnetic flux passing through a unit area perpendicular to the direction of the magnetic field. In simpler terms, it describes how dense or concentrated the magnetic field lines are in a given region.It can be expressed in terms of the fundamental dimensions as:
$$[M][T]^{-2}[I]^{-1}$$
Where:
- $[M]$ represents mass
- $[I]$ represents electric current
- $[T]$ represents time
2. Plane Angle
A **plane angle** is one of the nine fundamental dimensions in the International Unit System (SI). It is denoted: $$[\theta]$$
3. Angle Magnetic Flux Density
So the dimension of **angle magnetic flux density** is:
$$[M{\theta}I^{-1}T^{-2}]$$

The SI unit for **angle magnetic flux density** is: radian tesla with the associated unit label $rad \cdot T$

- Examples: 
``` dwis
Quantity:AngleMagneticFluxDensityQuantity
AngleMagneticFluxDensityQuantity.M = 1
AngleMagneticFluxDensityQuantity.T = -2
AngleMagneticFluxDensityQuantity.I = -1
AngleMagneticFluxDensityQuantity.Theta = 1
Unit:RadianTesla
RadianTesla.ConversionFactorA = 0
RadianTesla.ConversionFactorB = 1
RadianTesla.Symbol = "rad•T"
RadianTesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
AngleMagneticFluxDensityQuantity HasSIUnit RadianTesla
Unit:RadianGauss
RadianGauss.ConversionFactorA = 0
RadianGauss.ConversionFactorB = 10000
RadianGauss.Symbol = "rad•G"
RadianGauss IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:RadianMilligauss
RadianMilligauss.ConversionFactorA = 0
RadianMilligauss.ConversionFactorB = 10000000
RadianMilligauss.Symbol = "rad•mG"
RadianMilligauss IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:RadianMillitesla
RadianMillitesla.ConversionFactorA = 0
RadianMillitesla.ConversionFactorB = 1000
RadianMillitesla.Symbol = "rad•mT"
RadianMillitesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:RadianMicrotesla
RadianMicrotesla.ConversionFactorA = 0
RadianMicrotesla.ConversionFactorB = 1000000
RadianMicrotesla.Symbol = "rad•µT"
RadianMicrotesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:RadianNanotesla
RadianNanotesla.ConversionFactorA = 0
RadianNanotesla.ConversionFactorB = 999999999.9999999
RadianNanotesla.Symbol = "rad•nT"
RadianNanotesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:RadianMaxwellPerSquareCentimetre
RadianMaxwellPerSquareCentimetre.ConversionFactorA = 0
RadianMaxwellPerSquareCentimetre.ConversionFactorB = 10000
RadianMaxwellPerSquareCentimetre.Symbol = "rad•Mx/cm²"
RadianMaxwellPerSquareCentimetre IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:RadianWeberPerSquareMetre
RadianWeberPerSquareMetre.ConversionFactorA = 0
RadianWeberPerSquareMetre.ConversionFactorB = 1
RadianWeberPerSquareMetre.Symbol = "rad•Wb/m²"
RadianWeberPerSquareMetre IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeTesla
DegreeTesla.ConversionFactorA = 0
DegreeTesla.ConversionFactorB = 57.29577951308232
DegreeTesla.Symbol = "°•T"
DegreeTesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeGauss
DegreeGauss.ConversionFactorA = 0
DegreeGauss.ConversionFactorB = 572957.7951308232
DegreeGauss.Symbol = "°•G"
DegreeGauss IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeMilligauss
DegreeMilligauss.ConversionFactorA = 0
DegreeMilligauss.ConversionFactorB = 572957795.1308231
DegreeMilligauss.Symbol = "°•mG"
DegreeMilligauss IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeMillitesla
DegreeMillitesla.ConversionFactorA = 0
DegreeMillitesla.ConversionFactorB = 57295.77951308232
DegreeMillitesla.Symbol = "°•mT"
DegreeMillitesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeMicrotesla
DegreeMicrotesla.ConversionFactorA = 0
DegreeMicrotesla.ConversionFactorB = 57295779.513082325
DegreeMicrotesla.Symbol = "°•µT"
DegreeMicrotesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeNanotesla
DegreeNanotesla.ConversionFactorA = 0
DegreeNanotesla.ConversionFactorB = 57295779513.08232
DegreeNanotesla.Symbol = "°•nT"
DegreeNanotesla IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeMaxwellPerSquareCentimetre
DegreeMaxwellPerSquareCentimetre.ConversionFactorA = 0
DegreeMaxwellPerSquareCentimetre.ConversionFactorB = 572957.7951308232
DegreeMaxwellPerSquareCentimetre.Symbol = "°•Mx/cm²"
DegreeMaxwellPerSquareCentimetre IsUnitForQuantity AngleMagneticFluxDensityQuantity
Unit:DegreeWeberPerSquareMetre
DegreeWeberPerSquareMetre.ConversionFactorA = 0
DegreeWeberPerSquareMetre.ConversionFactorB = 57.29577951308232
DegreeWeberPerSquareMetre.Symbol = "°•Wb/m²"
DegreeWeberPerSquareMetre IsUnitForQuantity AngleMagneticFluxDensityQuantity
```
## AngularAccelerationQuantity <!-- NOUN -->
- Display name: AngularAcceleration
- Parent class: Quantity
- Specialization: 
  - T = -2
  - Theta = 1
- Description: 
An angular acceleration is the second derivative compared to time of a plan angle: $\frac{d^2\theta}{dt^2}$.
The dimension of angular acceleration is:
$$[{\theta}T^{-2}]$$.

The SI unit for **angular acceleration** is: radian per second squared with the associated unit label $\frac{rad}{s^{2}}$

- Examples: 
``` dwis
Quantity:AngularAccelerationQuantity
AngularAccelerationQuantity.T = -2
AngularAccelerationQuantity.Theta = 1
Unit:RadianPerSecondSquared
RadianPerSecondSquared.ConversionFactorA = 0
RadianPerSecondSquared.ConversionFactorB = 1
RadianPerSecondSquared.Symbol = "rad/s²"
RadianPerSecondSquared IsUnitForQuantity AngularAccelerationQuantity
AngularAccelerationQuantity HasSIUnit RadianPerSecondSquared
Unit:DegreePerSecondSquared
DegreePerSecondSquared.ConversionFactorA = 0
DegreePerSecondSquared.ConversionFactorB = 57.29577951308232
DegreePerSecondSquared.Symbol = "°/s²"
DegreePerSecondSquared IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerDayPerSecond
RadianPerDayPerSecond.ConversionFactorA = 0
RadianPerDayPerSecond.ConversionFactorB = 86400
RadianPerDayPerSecond.Symbol = "rad/d/s"
RadianPerDayPerSecond IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerHourPerSecond
RadianPerHourPerSecond.ConversionFactorA = 0
RadianPerHourPerSecond.ConversionFactorB = 3600
RadianPerHourPerSecond.Symbol = "rad/h/s"
RadianPerHourPerSecond IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerMinutePerSecond
RadianPerMinutePerSecond.ConversionFactorA = 0
RadianPerMinutePerSecond.ConversionFactorB = 60
RadianPerMinutePerSecond.Symbol = "rad/min/s"
RadianPerMinutePerSecond IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerDayPerSecond
DegreePerDayPerSecond.ConversionFactorA = 0
DegreePerDayPerSecond.ConversionFactorB = 4950355.3499303125
DegreePerDayPerSecond.Symbol = "°/d/s"
DegreePerDayPerSecond IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerHourPerSecond
DegreePerHourPerSecond.ConversionFactorA = 0
DegreePerHourPerSecond.ConversionFactorB = 206264.80624709636
DegreePerHourPerSecond.Symbol = "°/h/s"
DegreePerHourPerSecond IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerMinutePerSecond
DegreePerMinutePerSecond.ConversionFactorA = 0
DegreePerMinutePerSecond.ConversionFactorB = 3437.746770784939
DegreePerMinutePerSecond.Symbol = "°/min/s"
DegreePerMinutePerSecond IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerSecondPerMinute
RadianPerSecondPerMinute.ConversionFactorA = 0
RadianPerSecondPerMinute.ConversionFactorB = 60
RadianPerSecondPerMinute.Symbol = "rad/s/min"
RadianPerSecondPerMinute IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerSecondPerMinute
DegreePerSecondPerMinute.ConversionFactorA = 0
DegreePerSecondPerMinute.ConversionFactorB = 3437.746770784939
DegreePerSecondPerMinute.Symbol = "°/s/min"
DegreePerSecondPerMinute IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerDayPerMinute
RadianPerDayPerMinute.ConversionFactorA = 0
RadianPerDayPerMinute.ConversionFactorB = 5184000
RadianPerDayPerMinute.Symbol = "rad/d/min"
RadianPerDayPerMinute IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerHourPerMinute
RadianPerHourPerMinute.ConversionFactorA = 0
RadianPerHourPerMinute.ConversionFactorB = 216000
RadianPerHourPerMinute.Symbol = "rad/h/min"
RadianPerHourPerMinute IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerMinuteSquared
RadianPerMinuteSquared.ConversionFactorA = 0
RadianPerMinuteSquared.ConversionFactorB = 3600
RadianPerMinuteSquared.Symbol = "rad/min²"
RadianPerMinuteSquared IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerDayPerMinute
DegreePerDayPerMinute.ConversionFactorA = 0
DegreePerDayPerMinute.ConversionFactorB = 297021320.99581873
DegreePerDayPerMinute.Symbol = "°/d/min"
DegreePerDayPerMinute IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerHourPerMinute
DegreePerHourPerMinute.ConversionFactorA = 0
DegreePerHourPerMinute.ConversionFactorB = 12375888.374825781
DegreePerHourPerMinute.Symbol = "°/h/min"
DegreePerHourPerMinute IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerMinuteSquared
DegreePerMinuteSquared.ConversionFactorA = 0
DegreePerMinuteSquared.ConversionFactorB = 206264.80624709636
DegreePerMinuteSquared.Symbol = "°/min²"
DegreePerMinuteSquared IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerSecondPerHour
RadianPerSecondPerHour.ConversionFactorA = 0
RadianPerSecondPerHour.ConversionFactorB = 3600
RadianPerSecondPerHour.Symbol = "rad/s/h"
RadianPerSecondPerHour IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerSecondPerHour
DegreePerSecondPerHour.ConversionFactorA = 0
DegreePerSecondPerHour.ConversionFactorB = 206264.80624709636
DegreePerSecondPerHour.Symbol = "°/s/h"
DegreePerSecondPerHour IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerDayPerHour
RadianPerDayPerHour.ConversionFactorA = 0
RadianPerDayPerHour.ConversionFactorB = 311040000
RadianPerDayPerHour.Symbol = "rad/d/h"
RadianPerDayPerHour IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerHourSquared
RadianPerHourSquared.ConversionFactorA = 0
RadianPerHourSquared.ConversionFactorB = 12960000
RadianPerHourSquared.Symbol = "rad/h²"
RadianPerHourSquared IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerMinutePerHour
RadianPerMinutePerHour.ConversionFactorA = 0
RadianPerMinutePerHour.ConversionFactorB = 216000
RadianPerMinutePerHour.Symbol = "rad/min/h"
RadianPerMinutePerHour IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerDayPerHour
DegreePerDayPerHour.ConversionFactorA = 0
DegreePerDayPerHour.ConversionFactorB = 17821279259.749126
DegreePerDayPerHour.Symbol = "°/d/h"
DegreePerDayPerHour IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerHourSquared
DegreePerHourSquared.ConversionFactorA = 0
DegreePerHourSquared.ConversionFactorB = 742553302.4895469
DegreePerHourSquared.Symbol = "°/h²"
DegreePerHourSquared IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerMinutePerHour
DegreePerMinutePerHour.ConversionFactorA = 0
DegreePerMinutePerHour.ConversionFactorB = 12375888.374825781
DegreePerMinutePerHour.Symbol = "°/min/h"
DegreePerMinutePerHour IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerSecondPerDay
RadianPerSecondPerDay.ConversionFactorA = 0
RadianPerSecondPerDay.ConversionFactorB = 86400
RadianPerSecondPerDay.Symbol = "rad/s/d"
RadianPerSecondPerDay IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerSecondPerDay
DegreePerSecondPerDay.ConversionFactorA = 0
DegreePerSecondPerDay.ConversionFactorB = 4950355.3499303125
DegreePerSecondPerDay.Symbol = "°/s/d"
DegreePerSecondPerDay IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerDaySquared
RadianPerDaySquared.ConversionFactorA = 0
RadianPerDaySquared.ConversionFactorB = 7464960000
RadianPerDaySquared.Symbol = "rad/d²"
RadianPerDaySquared IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerHourPerDay
RadianPerHourPerDay.ConversionFactorA = 0
RadianPerHourPerDay.ConversionFactorB = 311040000
RadianPerHourPerDay.Symbol = "rad/h/d"
RadianPerHourPerDay IsUnitForQuantity AngularAccelerationQuantity
Unit:RadianPerMinutePerDay
RadianPerMinutePerDay.ConversionFactorA = 0
RadianPerMinutePerDay.ConversionFactorB = 5184000
RadianPerMinutePerDay.Symbol = "rad/min/d"
RadianPerMinutePerDay IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerDaySquared
DegreePerDaySquared.ConversionFactorA = 0
DegreePerDaySquared.ConversionFactorB = 427710702233.979
DegreePerDaySquared.Symbol = "°/d²"
DegreePerDaySquared IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerHourPerDay
DegreePerHourPerDay.ConversionFactorA = 0
DegreePerHourPerDay.ConversionFactorB = 17821279259.749126
DegreePerHourPerDay.Symbol = "°/h/d"
DegreePerHourPerDay IsUnitForQuantity AngularAccelerationQuantity
Unit:DegreePerMinutePerDay
DegreePerMinutePerDay.ConversionFactorA = 0
DegreePerMinutePerDay.ConversionFactorB = 297021320.99581873
DegreePerMinutePerDay.Symbol = "°/min/d"
DegreePerMinutePerDay IsUnitForQuantity AngularAccelerationQuantity
```
## AngularVelocityQuantity <!-- NOUN -->
- Display name: AngularVelocity
- Parent class: Quantity
- Specialization: 
  - T = -1
  - Theta = 1
- Description: 
An angular velocity is the first derivative compared to time of a plan angle: $\frac{d\theta}{dt}$.
The dimension of angular velocity is:
$$[{\theta}T^{-1}]$$.

The SI unit for **angular velocity** is: radian per second with the associated unit label $\frac{rad}{s}$

- Examples: 
``` dwis
Quantity:AngularVelocityQuantity
AngularVelocityQuantity.T = -1
AngularVelocityQuantity.Theta = 1
Unit:RadianPerSecond
RadianPerSecond.ConversionFactorA = 0
RadianPerSecond.ConversionFactorB = 1
RadianPerSecond.Symbol = "rad/s"
RadianPerSecond IsUnitForQuantity AngularVelocityQuantity
AngularVelocityQuantity HasSIUnit RadianPerSecond
Unit:DegreePerSecond
DegreePerSecond.ConversionFactorA = 0
DegreePerSecond.ConversionFactorB = 57.29577951308232
DegreePerSecond.Symbol = "°/s"
DegreePerSecond IsUnitForQuantity AngularVelocityQuantity
Unit:RadianPerDay
RadianPerDay.ConversionFactorA = 0
RadianPerDay.ConversionFactorB = 86400
RadianPerDay.Symbol = "rad/d"
RadianPerDay IsUnitForQuantity AngularVelocityQuantity
Unit:RadianPerHour
RadianPerHour.ConversionFactorA = 0
RadianPerHour.ConversionFactorB = 3600
RadianPerHour.Symbol = "rad/h"
RadianPerHour IsUnitForQuantity AngularVelocityQuantity
Unit:RadianPerMinute
RadianPerMinute.ConversionFactorA = 0
RadianPerMinute.ConversionFactorB = 60
RadianPerMinute.Symbol = "rad/min"
RadianPerMinute IsUnitForQuantity AngularVelocityQuantity
Unit:DegreePerDay
DegreePerDay.ConversionFactorA = 0
DegreePerDay.ConversionFactorB = 4950355.3499303125
DegreePerDay.Symbol = "°/d"
DegreePerDay IsUnitForQuantity AngularVelocityQuantity
Unit:DegreePerHour
DegreePerHour.ConversionFactorA = 0
DegreePerHour.ConversionFactorB = 206264.80624709636
DegreePerHour.Symbol = "°/h"
DegreePerHour IsUnitForQuantity AngularVelocityQuantity
Unit:DegreePerMinute
DegreePerMinute.ConversionFactorA = 0
DegreePerMinute.ConversionFactorB = 3437.746770784939
DegreePerMinute.Symbol = "°/min"
DegreePerMinute IsUnitForQuantity AngularVelocityQuantity
```
## AreaQuantity <!-- NOUN -->
- Display name: Area
- Parent class: Quantity
- Specialization: 
  - L = 2
- Description: 
Area is the measure of the extent of a surface or the size of a two-dimensional shape.
The dimension of area is:
$$[L^{2}]$$.

The SI unit for **area** is: square metre with the associated unit label $m^{2}$

- Examples: 
``` dwis
Quantity:AreaQuantity
AreaQuantity.L = 2
Unit:SquareMetre
SquareMetre.ConversionFactorA = 0
SquareMetre.ConversionFactorB = 1
SquareMetre.Symbol = "m²"
SquareMetre IsUnitForQuantity AreaQuantity
AreaQuantity HasSIUnit SquareMetre
Unit:SquareKilometre
SquareKilometre.ConversionFactorA = 0
SquareKilometre.ConversionFactorB = 1E-06
SquareKilometre.Symbol = "km²"
SquareKilometre IsUnitForQuantity AreaQuantity
Unit:Hectare
Hectare.ConversionFactorA = 0
Hectare.ConversionFactorB = 0.0001
Hectare.Symbol = "ha"
Hectare IsUnitForQuantity AreaQuantity
Unit:SquareDecametre
SquareDecametre.ConversionFactorA = 0
SquareDecametre.ConversionFactorB = 0.01
SquareDecametre.Symbol = "dam²"
SquareDecametre IsUnitForQuantity AreaQuantity
Unit:SquareDecimetre
SquareDecimetre.ConversionFactorA = 0
SquareDecimetre.ConversionFactorB = 99.99999999999999
SquareDecimetre.Symbol = "dm²"
SquareDecimetre IsUnitForQuantity AreaQuantity
Unit:SquareCentimetre
SquareCentimetre.ConversionFactorA = 0
SquareCentimetre.ConversionFactorB = 10000
SquareCentimetre.Symbol = "cm²"
SquareCentimetre IsUnitForQuantity AreaQuantity
Unit:SquareMillimetre
SquareMillimetre.ConversionFactorA = 0
SquareMillimetre.ConversionFactorB = 1000000
SquareMillimetre.Symbol = "mm²"
SquareMillimetre IsUnitForQuantity AreaQuantity
Unit:SquareMicrometre
SquareMicrometre.ConversionFactorA = 0
SquareMicrometre.ConversionFactorB = 1000000000000
SquareMicrometre.Symbol = "µm²"
SquareMicrometre IsUnitForQuantity AreaQuantity
Unit:SquareFoot
SquareFoot.ConversionFactorA = 0
SquareFoot.ConversionFactorB = 10.763910416709725
SquareFoot.Symbol = "ft²"
SquareFoot IsUnitForQuantity AreaQuantity
Unit:SquareInch
SquareInch.ConversionFactorA = 0
SquareInch.ConversionFactorB = 1550.0031000062002
SquareInch.Symbol = "in²"
SquareInch IsUnitForQuantity AreaQuantity
Unit:SquareYard
SquareYard.ConversionFactorA = 0
SquareYard.ConversionFactorB = 1.1959900463010806
SquareYard.Symbol = "yd²"
SquareYard IsUnitForQuantity AreaQuantity
Unit:Acre
Acre.ConversionFactorA = 0
Acre.ConversionFactorB = 0.0002471053814671654
Acre.Symbol = "ac"
Acre IsUnitForQuantity AreaQuantity
Unit:SquareMile
SquareMile.ConversionFactorA = 0
SquareMile.ConversionFactorB = 3.861021585424459E-07
SquareMile.Symbol = "mi²"
SquareMile IsUnitForQuantity AreaQuantity
```
## CompressibilityQuantity <!-- NOUN -->
- Display name: Compressibility
- Parent class: Quantity
- Specialization: 
  - L = 1
  - M = -1
  - T = 2
- Description: 
Compressibility is the measure of how much a substance's volume decreases under pressure. It indicates how easily a material or fluid can be compressed and is typically expressed as a change in volume per unit change in pressure.
The dimension of compressibility is:
$$[T^{2}LM^{-1}]$$.

The SI unit for **compressibility** is: inverse pascal with the associated unit label $\frac{1}{Pa}$

- Examples: 
``` dwis
Quantity:CompressibilityQuantity
CompressibilityQuantity.L = 1
CompressibilityQuantity.M = -1
CompressibilityQuantity.T = 2
Unit:InversePascal
InversePascal.ConversionFactorA = 0
InversePascal.ConversionFactorB = 1
InversePascal.Symbol = "1/Pa"
InversePascal IsUnitForQuantity CompressibilityQuantity
CompressibilityQuantity HasSIUnit InversePascal
Unit:InverseBar
InverseBar.ConversionFactorA = 0
InverseBar.ConversionFactorB = 100000
InverseBar.Symbol = "1/bar"
InverseBar IsUnitForQuantity CompressibilityQuantity
Unit:InversePoundPerSquareInch
InversePoundPerSquareInch.ConversionFactorA = 0
InversePoundPerSquareInch.ConversionFactorB = 6894.757293168361
InversePoundPerSquareInch.Symbol = "1/psi"
InversePoundPerSquareInch IsUnitForQuantity CompressibilityQuantity
Unit:InverseAtmosphere
InverseAtmosphere.ConversionFactorA = 0
InverseAtmosphere.ConversionFactorB = 101325
InverseAtmosphere.Symbol = "1/atm"
InverseAtmosphere IsUnitForQuantity CompressibilityQuantity
```
## CurvatureQuantity <!-- NOUN -->
- Display name: Curvature
- Parent class: Quantity
- Specialization: 
  - L = -1
  - Theta = 1
- Description: 
A curvature is the second derivative of a position compared to the curvilinear abscissa: $\frac{d^2x}{ds^2}$, where $x$ is the position and $s$ is the curvilinear abscissa.
The dimension of curvature is:
$$[{\theta}L^{-1}]$$.

The SI unit for **curvature** is: radian per metre with the associated unit label $\frac{rad}{m}$

- Examples: 
``` dwis
Quantity:CurvatureQuantity
CurvatureQuantity.L = -1
CurvatureQuantity.Theta = 1
Unit:RadianPerMetre
RadianPerMetre.ConversionFactorA = 0
RadianPerMetre.ConversionFactorB = 1
RadianPerMetre.Symbol = "rad/m"
RadianPerMetre IsUnitForQuantity CurvatureQuantity
CurvatureQuantity HasSIUnit RadianPerMetre
Unit:DegreePer10m
DegreePer10m.ConversionFactorA = 0
DegreePer10m.ConversionFactorB = 572.9577951308232
DegreePer10m.Symbol = "°/10m"
DegreePer10m IsUnitForQuantity CurvatureQuantity
Unit:DegreePer30m
DegreePer30m.ConversionFactorA = 0
DegreePer30m.ConversionFactorB = 1718.8733853924696
DegreePer30m.Symbol = "°/30m"
DegreePer30m IsUnitForQuantity CurvatureQuantity
Unit:DegreePer30ft
DegreePer30ft.ConversionFactorA = 0
DegreePer30ft.ConversionFactorB = 523.9126078676246
DegreePer30ft.Symbol = "°/30ft"
DegreePer30ft IsUnitForQuantity CurvatureQuantity
Unit:DegreePer100ft
DegreePer100ft.ConversionFactorA = 0
DegreePer100ft.ConversionFactorB = 1746.375359558749
DegreePer100ft.Symbol = "°/100ft"
DegreePer100ft IsUnitForQuantity CurvatureQuantity
Unit:DegreePerFoot
DegreePerFoot.ConversionFactorA = 0
DegreePerFoot.ConversionFactorB = 17.46375359558749
DegreePerFoot.Symbol = "°/ft"
DegreePerFoot IsUnitForQuantity CurvatureQuantity
Unit:RadianPerFoot
RadianPerFoot.ConversionFactorA = 0
RadianPerFoot.ConversionFactorB = 0.30479999999999996
RadianPerFoot.Symbol = "rad/ft"
RadianPerFoot IsUnitForQuantity CurvatureQuantity
Unit:DegreePerMetre
DegreePerMetre.ConversionFactorA = 0
DegreePerMetre.ConversionFactorB = 57.29577951308232
DegreePerMetre.Symbol = "°/m"
DegreePerMetre IsUnitForQuantity CurvatureQuantity
Unit:DegreePerDecimeter
DegreePerDecimeter.ConversionFactorA = 0
DegreePerDecimeter.ConversionFactorB = 5.729577951308233
DegreePerDecimeter.Symbol = "°/dm"
DegreePerDecimeter IsUnitForQuantity CurvatureQuantity
Unit:DegreePerCentimeter
DegreePerCentimeter.ConversionFactorA = 0
DegreePerCentimeter.ConversionFactorB = 0.5729577951308232
DegreePerCentimeter.Symbol = "°/cm"
DegreePerCentimeter IsUnitForQuantity CurvatureQuantity
Unit:DegreePerMillimeter
DegreePerMillimeter.ConversionFactorA = 0
DegreePerMillimeter.ConversionFactorB = 0.057295779513082325
DegreePerMillimeter.Symbol = "°/mm"
DegreePerMillimeter IsUnitForQuantity CurvatureQuantity
Unit:DegreePerMicrometer
DegreePerMicrometer.ConversionFactorA = 0
DegreePerMicrometer.ConversionFactorB = 5.729577951308232E-05
DegreePerMicrometer.Symbol = "°/mm"
DegreePerMicrometer IsUnitForQuantity CurvatureQuantity
Unit:DegreePerNanometer
DegreePerNanometer.ConversionFactorA = 0
DegreePerNanometer.ConversionFactorB = 5.7295779513082324E-08
DegreePerNanometer.Symbol = "°/mm"
DegreePerNanometer IsUnitForQuantity CurvatureQuantity
Unit:DegreePerDecameter
DegreePerDecameter.ConversionFactorA = 0
DegreePerDecameter.ConversionFactorB = 572.9577951308232
DegreePerDecameter.Symbol = "°/dam"
DegreePerDecameter IsUnitForQuantity CurvatureQuantity
Unit:DegreePerHectometer
DegreePerHectometer.ConversionFactorA = 0
DegreePerHectometer.ConversionFactorB = 5729.5779513082325
DegreePerHectometer.Symbol = "°/hm"
DegreePerHectometer IsUnitForQuantity CurvatureQuantity
Unit:DegreePerKilometer
DegreePerKilometer.ConversionFactorA = 0
DegreePerKilometer.ConversionFactorB = 57295.77951308232
DegreePerKilometer.Symbol = "°/km"
DegreePerKilometer IsUnitForQuantity CurvatureQuantity
Unit:RadianPerDecimeter
RadianPerDecimeter.ConversionFactorA = 0
RadianPerDecimeter.ConversionFactorB = 0.1
RadianPerDecimeter.Symbol = "rad/dm"
RadianPerDecimeter IsUnitForQuantity CurvatureQuantity
Unit:RadianPerCentimeter
RadianPerCentimeter.ConversionFactorA = 0
RadianPerCentimeter.ConversionFactorB = 0.01
RadianPerCentimeter.Symbol = "rad/cm"
RadianPerCentimeter IsUnitForQuantity CurvatureQuantity
Unit:RadianPerMillimeter
RadianPerMillimeter.ConversionFactorA = 0
RadianPerMillimeter.ConversionFactorB = 0.001
RadianPerMillimeter.Symbol = "rad/mm"
RadianPerMillimeter IsUnitForQuantity CurvatureQuantity
Unit:RadianPerMicrometer
RadianPerMicrometer.ConversionFactorA = 0
RadianPerMicrometer.ConversionFactorB = 1E-06
RadianPerMicrometer.Symbol = "rad/mm"
RadianPerMicrometer IsUnitForQuantity CurvatureQuantity
Unit:RadianPerNanometer
RadianPerNanometer.ConversionFactorA = 0
RadianPerNanometer.ConversionFactorB = 1E-09
RadianPerNanometer.Symbol = "rad/mm"
RadianPerNanometer IsUnitForQuantity CurvatureQuantity
Unit:RadianPerDecameter
RadianPerDecameter.ConversionFactorA = 0
RadianPerDecameter.ConversionFactorB = 10
RadianPerDecameter.Symbol = "rad/dam"
RadianPerDecameter IsUnitForQuantity CurvatureQuantity
Unit:RadianPerHectometer
RadianPerHectometer.ConversionFactorA = 0
RadianPerHectometer.ConversionFactorB = 100
RadianPerHectometer.Symbol = "rad/hm"
RadianPerHectometer IsUnitForQuantity CurvatureQuantity
Unit:RadianPerKilometer
RadianPerKilometer.ConversionFactorA = 0
RadianPerKilometer.ConversionFactorB = 1000
RadianPerKilometer.Symbol = "rad/km"
RadianPerKilometer IsUnitForQuantity CurvatureQuantity
Unit:DegreePerYard
DegreePerYard.ConversionFactorA = 0
DegreePerYard.ConversionFactorB = 52.391260786762466
DegreePerYard.Symbol = "°/yd"
DegreePerYard IsUnitForQuantity CurvatureQuantity
Unit:DegreePerMile
DegreePerMile.ConversionFactorA = 0
DegreePerMile.ConversionFactorB = 92208.61898470194
DegreePerMile.Symbol = "°/mi"
DegreePerMile IsUnitForQuantity CurvatureQuantity
Unit:RadianPerYard
RadianPerYard.ConversionFactorA = 0
RadianPerYard.ConversionFactorB = 0.9143999999999999
RadianPerYard.Symbol = "rad/yd"
RadianPerYard IsUnitForQuantity CurvatureQuantity
Unit:RadianPerMile
RadianPerMile.ConversionFactorA = 0
RadianPerMile.ConversionFactorB = 1609.3439999999998
RadianPerMile.Symbol = "rad/mi"
RadianPerMile IsUnitForQuantity CurvatureQuantity
```
## MassDensityGradientPerLengthQuantity <!-- NOUN -->
- Display name: MassDensityGradientPerLength
- Parent class: Quantity
- Specialization: 
  - L = -4
  - M = 1
- Description: 
A mass density gradient per length is the first derivative of a mass density compared to a distance: $\frac{d\rho}{ds}$, where $\rho$ is the mass density and $s$ is a distance.
The dimension of mass density gradient per length is:
$$[ML^{-4}]$$.

The SI unit for **mass density gradient per length** is: kilogram per cubic metre per metre with the associated unit label $\frac{\frac{kg}{m^{3}}}{m}$

- Examples: 
``` dwis
Quantity:MassDensityGradientPerLengthQuantity
MassDensityGradientPerLengthQuantity.L = -4
MassDensityGradientPerLengthQuantity.M = 1
Unit:KilogramPerCubicMetrePerMetre
KilogramPerCubicMetrePerMetre.ConversionFactorA = 0
KilogramPerCubicMetrePerMetre.ConversionFactorB = 1
KilogramPerCubicMetrePerMetre.Symbol = "kg/m³/m"
KilogramPerCubicMetrePerMetre IsUnitForQuantity MassDensityGradientPerLengthQuantity
MassDensityGradientPerLengthQuantity HasSIUnit KilogramPerCubicMetrePerMetre
Unit:SpecificGravityPerMetre
SpecificGravityPerMetre.ConversionFactorA = 0
SpecificGravityPerMetre.ConversionFactorB = 0.001000028000784022
SpecificGravityPerMetre.Symbol = "sg/m"
SpecificGravityPerMetre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:SpecificGravityPer10Metre
SpecificGravityPer10Metre.ConversionFactorA = 0
SpecificGravityPer10Metre.ConversionFactorB = 0.01000028000784022
SpecificGravityPer10Metre.Symbol = "sg/10m"
SpecificGravityPer10Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:SpecificGravityPer30Metre
SpecificGravityPer30Metre.ConversionFactorA = 0
SpecificGravityPer30Metre.ConversionFactorB = 0.03000084002352066
SpecificGravityPer30Metre.Symbol = "sg/30m"
SpecificGravityPer30Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:SpecificGravityPer100Metre
SpecificGravityPer100Metre.ConversionFactorA = 0
SpecificGravityPer100Metre.ConversionFactorB = 0.10000280007840219
SpecificGravityPer100Metre.Symbol = "sg/100m"
SpecificGravityPer100Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:GramPerCubicCentimetrePer100Metre
GramPerCubicCentimetrePer100Metre.ConversionFactorA = 0
GramPerCubicCentimetrePer100Metre.ConversionFactorB = 0.10000000000000002
GramPerCubicCentimetrePer100Metre.Symbol = "g/cm³/100m"
GramPerCubicCentimetrePer100Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerGallonUkPerFoot
PoundPerGallonUkPerFoot.ConversionFactorA = 0
PoundPerGallonUkPerFoot.ConversionFactorB = 0.00305483143819196
PoundPerGallonUkPerFoot.Symbol = "ppgUK/ft"
PoundPerGallonUkPerFoot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerGallonUkPer30Foot
PoundPerGallonUkPer30Foot.ConversionFactorA = 0
PoundPerGallonUkPer30Foot.ConversionFactorB = 0.0916449431457588
PoundPerGallonUkPer30Foot.Symbol = "ppgUK/30ft"
PoundPerGallonUkPer30Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerGallonUkPer100Foot
PoundPerGallonUkPer100Foot.ConversionFactorA = 0
PoundPerGallonUkPer100Foot.ConversionFactorB = 0.305483143819196
PoundPerGallonUkPer100Foot.Symbol = "ppgUK/100ft"
PoundPerGallonUkPer100Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerGallonUsPerFoot
PoundPerGallonUsPerFoot.ConversionFactorA = 0
PoundPerGallonUsPerFoot.ConversionFactorB = 0.0025436792769754917
PoundPerGallonUsPerFoot.Symbol = "ppgUS/ft"
PoundPerGallonUsPerFoot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerGallonUsPer30Foot
PoundPerGallonUsPer30Foot.ConversionFactorA = 0
PoundPerGallonUsPer30Foot.ConversionFactorB = 0.07631037830926475
PoundPerGallonUsPer30Foot.Symbol = "ppgUS/30ft"
PoundPerGallonUsPer30Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerGallonUsPer100Foot
PoundPerGallonUsPer100Foot.ConversionFactorA = 0
PoundPerGallonUsPer100Foot.ConversionFactorB = 0.2543679276975492
PoundPerGallonUsPer100Foot.Symbol = "ppgUS/100ft"
PoundPerGallonUsPer100Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:KilogramPerCubicMetrePer10Metre
KilogramPerCubicMetrePer10Metre.ConversionFactorA = 0
KilogramPerCubicMetrePer10Metre.ConversionFactorB = 10
KilogramPerCubicMetrePer10Metre.Symbol = "kg/m³/10m"
KilogramPerCubicMetrePer10Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:KilogramPerCubicMetrePer30Metre
KilogramPerCubicMetrePer30Metre.ConversionFactorA = 0
KilogramPerCubicMetrePer30Metre.ConversionFactorB = 30
KilogramPerCubicMetrePer30Metre.Symbol = "kg/m³/30m"
KilogramPerCubicMetrePer30Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:KilogramPerCubicMetrePer100Metre
KilogramPerCubicMetrePer100Metre.ConversionFactorA = 0
KilogramPerCubicMetrePer100Metre.ConversionFactorB = 100
KilogramPerCubicMetrePer100Metre.Symbol = "kg/m³/30m"
KilogramPerCubicMetrePer100Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:GramPerCubicCentimetrePerMetre
GramPerCubicCentimetrePerMetre.ConversionFactorA = 0
GramPerCubicCentimetrePerMetre.ConversionFactorB = 0.0010000000000000002
GramPerCubicCentimetrePerMetre.Symbol = "g/cm³/m"
GramPerCubicCentimetrePerMetre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:GramPerCubicCentimetrePer10Metre
GramPerCubicCentimetrePer10Metre.ConversionFactorA = 0
GramPerCubicCentimetrePer10Metre.ConversionFactorB = 0.010000000000000002
GramPerCubicCentimetrePer10Metre.Symbol = "g/cm³/10m"
GramPerCubicCentimetrePer10Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:GramPerCubicCentimetrePer30Metre
GramPerCubicCentimetrePer30Metre.ConversionFactorA = 0
GramPerCubicCentimetrePer30Metre.ConversionFactorB = 0.030000000000000002
GramPerCubicCentimetrePer30Metre.Symbol = "g/cm³/30m"
GramPerCubicCentimetrePer30Metre IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicFootPerFoot
PoundPerCubicFootPerFoot.ConversionFactorA = 0
PoundPerCubicFootPerFoot.ConversionFactorB = 0.019028042383608865
PoundPerCubicFootPerFoot.Symbol = "lb/ft³/ft"
PoundPerCubicFootPerFoot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicFootPer30Foot
PoundPerCubicFootPer30Foot.ConversionFactorA = 0
PoundPerCubicFootPer30Foot.ConversionFactorB = 0.570841271508266
PoundPerCubicFootPer30Foot.Symbol = "lb/ft³/30ft"
PoundPerCubicFootPer30Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicFootPer100Foot
PoundPerCubicFootPer100Foot.ConversionFactorA = 0
PoundPerCubicFootPer100Foot.ConversionFactorB = 1.902804238360887
PoundPerCubicFootPer100Foot.Symbol = "lb/ft³/100ft"
PoundPerCubicFootPer100Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicInchPerFoot
PoundPerCubicInchPerFoot.ConversionFactorA = 0
PoundPerCubicInchPerFoot.ConversionFactorB = 1.1011598601625506E-05
PoundPerCubicInchPerFoot.Symbol = "lb/in³/ft"
PoundPerCubicInchPerFoot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicInchPer30Foot
PoundPerCubicInchPer30Foot.ConversionFactorA = 0
PoundPerCubicInchPer30Foot.ConversionFactorB = 0.00033034795804876514
PoundPerCubicInchPer30Foot.Symbol = "lb/in³/30ft"
PoundPerCubicInchPer30Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicInchPer100Foot
PoundPerCubicInchPer100Foot.ConversionFactorA = 0
PoundPerCubicInchPer100Foot.ConversionFactorB = 0.0011011598601625506
PoundPerCubicInchPer100Foot.Symbol = "lb/in³/100ft"
PoundPerCubicInchPer100Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicYardPerFoot
PoundPerCubicYardPerFoot.ConversionFactorA = 0
PoundPerCubicYardPerFoot.ConversionFactorB = 0.5137571443574394
PoundPerCubicYardPerFoot.Symbol = "lb/yd³/ft"
PoundPerCubicYardPerFoot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicYardPer30Foot
PoundPerCubicYardPer30Foot.ConversionFactorA = 0
PoundPerCubicYardPer30Foot.ConversionFactorB = 15.412714330723183
PoundPerCubicYardPer30Foot.Symbol = "lb/yd³/30ft"
PoundPerCubicYardPer30Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
Unit:PoundPerCubicYardPer100Foot
PoundPerCubicYardPer100Foot.ConversionFactorA = 0
PoundPerCubicYardPer100Foot.ConversionFactorB = 51.37571443574393
PoundPerCubicYardPer100Foot.Symbol = "lb/yd³/100ft"
PoundPerCubicYardPer100Foot IsUnitForQuantity MassDensityGradientPerLengthQuantity
```
## MassDensityGradientPerTemperatureQuantity <!-- NOUN -->
- Display name: MassDensityGradientPerTemperature
- Parent class: Quantity
- Specialization: 
  - L = -3
  - M = 1
  - ThT = -1
- Description: 
A mass density gradient per temperature is the first derivative of a mass density compared to temperature: $\frac{d\rho}{dT}$, where $\rho$ is a mass density and $T$ is temperature.
The dimension of mass density gradient per temperature is:
$$[MK^{-1}L^{-3}]$$.

The SI unit for **mass density gradient per temperature** is: kilogram per cubic metre per kelvin with the associated unit label $\frac{\frac{kg}{m^{3}}}{K}$

- Examples: 
``` dwis
Quantity:MassDensityGradientPerTemperatureQuantity
MassDensityGradientPerTemperatureQuantity.L = -3
MassDensityGradientPerTemperatureQuantity.M = 1
MassDensityGradientPerTemperatureQuantity.ThT = -1
Unit:KilogramPerCubicMetrePerKelvin
KilogramPerCubicMetrePerKelvin.ConversionFactorA = 0
KilogramPerCubicMetrePerKelvin.ConversionFactorB = 1
KilogramPerCubicMetrePerKelvin.Symbol = "kg/m³/K"
KilogramPerCubicMetrePerKelvin IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
MassDensityGradientPerTemperatureQuantity HasSIUnit KilogramPerCubicMetrePerKelvin
Unit:SpecificGravityPerCelsius
SpecificGravityPerCelsius.ConversionFactorA = 0
SpecificGravityPerCelsius.ConversionFactorB = 0.001000028000784022
SpecificGravityPerCelsius.Symbol = "sg/°C"
SpecificGravityPerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:GramPerCubicCentimetrePerCelsius
GramPerCubicCentimetrePerCelsius.ConversionFactorA = 0
GramPerCubicCentimetrePerCelsius.ConversionFactorB = 0.0010000000000000002
GramPerCubicCentimetrePerCelsius.Symbol = "g/cm³/°C"
GramPerCubicCentimetrePerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerGallonUkPerCelsius
PoundPerGallonUkPerCelsius.ConversionFactorA = 0
PoundPerGallonUkPerCelsius.ConversionFactorB = 0.010022412854960501
PoundPerGallonUkPerCelsius.Symbol = "ppgUK/°C"
PoundPerGallonUkPerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerGallonUsPerFahrenheit
PoundPerGallonUsPerFahrenheit.ConversionFactorA = 0
PoundPerGallonUsPerFahrenheit.ConversionFactorB = 0.004636335806677406
PoundPerGallonUsPerFahrenheit.Symbol = "ppgUS/°F"
PoundPerGallonUsPerFahrenheit IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerGallonUkPerFahrenheit
PoundPerGallonUkPerFahrenheit.ConversionFactorA = 0
PoundPerGallonUkPerFahrenheit.ConversionFactorB = 0.005568007141644723
PoundPerGallonUkPerFahrenheit.Symbol = "ppgUK/°F"
PoundPerGallonUkPerFahrenheit IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerGallonUsPerCelsius
PoundPerGallonUsPerCelsius.ConversionFactorA = 0
PoundPerGallonUsPerCelsius.ConversionFactorB = 0.00834540445201933
PoundPerGallonUsPerCelsius.Symbol = "ppgUS/°C"
PoundPerGallonUsPerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerCubicFootPerCelsius
PoundPerCubicFootPerCelsius.ConversionFactorA = 0
PoundPerCubicFootPerCelsius.ConversionFactorB = 0.06242796057614459
PoundPerCubicFootPerCelsius.Symbol = "lb/ft³/°C"
PoundPerCubicFootPerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerCubicFootPerFahrenheit
PoundPerCubicFootPerFahrenheit.ConversionFactorA = 0
PoundPerCubicFootPerFahrenheit.ConversionFactorB = 0.03468220032008033
PoundPerCubicFootPerFahrenheit.Symbol = "lb/ft³/°F"
PoundPerCubicFootPerFahrenheit IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerCubicInchPerCelsius
PoundPerCubicInchPerCelsius.ConversionFactorA = 0
PoundPerCubicInchPerCelsius.ConversionFactorB = 3.612729200008369E-05
PoundPerCubicInchPerCelsius.Symbol = "lb/in³/°C"
PoundPerCubicInchPerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerCubicInchPerFahrenheit
PoundPerCubicInchPerFahrenheit.ConversionFactorA = 0
PoundPerCubicInchPerFahrenheit.ConversionFactorB = 2.0070717777824268E-05
PoundPerCubicInchPerFahrenheit.Symbol = "lb/in³/°F"
PoundPerCubicInchPerFahrenheit IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerCubicYardPerCelsius
PoundPerCubicYardPerCelsius.ConversionFactorA = 0
PoundPerCubicYardPerCelsius.ConversionFactorB = 1.6855549355559039
PoundPerCubicYardPerCelsius.Symbol = "lb/yd³/°C"
PoundPerCubicYardPerCelsius IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
Unit:PoundPerCubicYeardPerFahrenheit
PoundPerCubicYeardPerFahrenheit.ConversionFactorA = 0
PoundPerCubicYeardPerFahrenheit.ConversionFactorB = 0.9364194086421688
PoundPerCubicYeardPerFahrenheit.Symbol = "lb/yd³/°F"
PoundPerCubicYeardPerFahrenheit IsUnitForQuantity MassDensityGradientPerTemperatureQuantity
```
## MassDensityQuantity <!-- NOUN -->
- Display name: MassDensity
- Parent class: Quantity
- Specialization: 
  - L = -3
  - M = 1
- Description: 
Mass density is the amount of mass per unit volume of a substance.
The dimension of mass density is:
$$[ML^{-3}]$$.

The SI unit for **mass density** is: kilogram per cubic metre with the associated unit label $\frac{kg}{m^{3}}$

- Examples: 
``` dwis
Quantity:MassDensityQuantity
MassDensityQuantity.L = -3
MassDensityQuantity.M = 1
Unit:KilogramPerCubicMetre
KilogramPerCubicMetre.ConversionFactorA = 0
KilogramPerCubicMetre.ConversionFactorB = 1
KilogramPerCubicMetre.Symbol = "kg/m³"
KilogramPerCubicMetre IsUnitForQuantity MassDensityQuantity
MassDensityQuantity HasSIUnit KilogramPerCubicMetre
Unit:GramPerCubicMetre
GramPerCubicMetre.ConversionFactorA = 0
GramPerCubicMetre.ConversionFactorB = 1000
GramPerCubicMetre.Symbol = "g/m³"
GramPerCubicMetre IsUnitForQuantity MassDensityQuantity
Unit:SpecificGravity
SpecificGravity.ConversionFactorA = 0
SpecificGravity.ConversionFactorB = 999.972
SpecificGravity.Symbol = "s.g."
SpecificGravity IsUnitForQuantity MassDensityQuantity
Unit:GramPerCubicCentimetre
GramPerCubicCentimetre.ConversionFactorA = 0
GramPerCubicCentimetre.ConversionFactorB = 0.0010000000000000002
GramPerCubicCentimetre.Symbol = "g/cm³"
GramPerCubicCentimetre IsUnitForQuantity MassDensityQuantity
Unit:PoundPerGallonUk
PoundPerGallonUk.ConversionFactorA = 0
PoundPerGallonUk.ConversionFactorB = 0.010022412854960501
PoundPerGallonUk.Symbol = "ppgUK"
PoundPerGallonUk IsUnitForQuantity MassDensityQuantity
Unit:PoundPerGallonUs
PoundPerGallonUs.ConversionFactorA = 0
PoundPerGallonUs.ConversionFactorB = 0.00834540445201933
PoundPerGallonUs.Symbol = "ppgUS"
PoundPerGallonUs IsUnitForQuantity MassDensityQuantity
Unit:PoundPerCubicFoot
PoundPerCubicFoot.ConversionFactorA = 0
PoundPerCubicFoot.ConversionFactorB = 0.06242796057614459
PoundPerCubicFoot.Symbol = "lb/ft³"
PoundPerCubicFoot IsUnitForQuantity MassDensityQuantity
Unit:PoundPerCubicInch
PoundPerCubicInch.ConversionFactorA = 0
PoundPerCubicInch.ConversionFactorB = 3.612729200008369E-05
PoundPerCubicInch.Symbol = "lb/in³"
PoundPerCubicInch IsUnitForQuantity MassDensityQuantity
Unit:PoundPerCubicYard
PoundPerCubicYard.ConversionFactorA = 0
PoundPerCubicYard.ConversionFactorB = 1.6855549355559039
PoundPerCubicYard.Symbol = "lb/yd³"
PoundPerCubicYard IsUnitForQuantity MassDensityQuantity
```
## MassDensityRateOfChangeQuantity <!-- NOUN -->
- Display name: MassDensityRateOfChange
- Parent class: Quantity
- Specialization: 
  - L = -3
  - M = 1
  - T = -1
- Description: 
A mass density rate of change is the time derivative of a mass density: $\frac{d\rho}{dt}$, where $\rho$ is the mass density and $t$ is time.
The dimension of mass density rate of change is:
$$[MT^{-1}L^{-3}]$$.

The SI unit for **mass density rate of change** is: kilogram per cubic metre per second with the associated unit label $\frac{\frac{kg}{m^{3}}}{s}$

- Examples: 
``` dwis
Quantity:MassDensityRateOfChangeQuantity
MassDensityRateOfChangeQuantity.L = -3
MassDensityRateOfChangeQuantity.M = 1
MassDensityRateOfChangeQuantity.T = -1
Unit:KilogramPerCubicMetrePerSecond
KilogramPerCubicMetrePerSecond.ConversionFactorA = 0
KilogramPerCubicMetrePerSecond.ConversionFactorB = 1
KilogramPerCubicMetrePerSecond.Symbol = "kg/m³/s"
KilogramPerCubicMetrePerSecond IsUnitForQuantity MassDensityRateOfChangeQuantity
MassDensityRateOfChangeQuantity HasSIUnit KilogramPerCubicMetrePerSecond
Unit:SpecificGravityPerSecond
SpecificGravityPerSecond.ConversionFactorA = 0
SpecificGravityPerSecond.ConversionFactorB = 0.001000028000784022
SpecificGravityPerSecond.Symbol = "sg/s"
SpecificGravityPerSecond IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:SpecificGravityPerMinute
SpecificGravityPerMinute.ConversionFactorA = 0
SpecificGravityPerMinute.ConversionFactorB = 0.06000168004704132
SpecificGravityPerMinute.Symbol = "sg/min"
SpecificGravityPerMinute IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:SpecificGravityPerHour
SpecificGravityPerHour.ConversionFactorA = 0
SpecificGravityPerHour.ConversionFactorB = 3.600100802822479
SpecificGravityPerHour.Symbol = "sg/h"
SpecificGravityPerHour IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:GramPerCubicCentimetrePerSecond
GramPerCubicCentimetrePerSecond.ConversionFactorA = 0
GramPerCubicCentimetrePerSecond.ConversionFactorB = 0.001
GramPerCubicCentimetrePerSecond.Symbol = "g/cm³/s"
GramPerCubicCentimetrePerSecond IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:GramPerCubicCentimetrePerMinute
GramPerCubicCentimetrePerMinute.ConversionFactorA = 0
GramPerCubicCentimetrePerMinute.ConversionFactorB = 0.06
GramPerCubicCentimetrePerMinute.Symbol = "g/cm³/min"
GramPerCubicCentimetrePerMinute IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:GramPerCubicCentimetrePerHour
GramPerCubicCentimetrePerHour.ConversionFactorA = 0
GramPerCubicCentimetrePerHour.ConversionFactorB = 3.6
GramPerCubicCentimetrePerHour.Symbol = "g/cm³/h"
GramPerCubicCentimetrePerHour IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:PoundPerGallonUkPerSecond
PoundPerGallonUkPerSecond.ConversionFactorA = 0
PoundPerGallonUkPerSecond.ConversionFactorB = 0.010022412854960501
PoundPerGallonUkPerSecond.Symbol = "ppgUK/s"
PoundPerGallonUkPerSecond IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:PoundPerGallonUkPerMinute
PoundPerGallonUkPerMinute.ConversionFactorA = 0
PoundPerGallonUkPerMinute.ConversionFactorB = 0.6013447712976301
PoundPerGallonUkPerMinute.Symbol = "ppgUK/min"
PoundPerGallonUkPerMinute IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:PoundPerGallonUkPerHour
PoundPerGallonUkPerHour.ConversionFactorA = 0
PoundPerGallonUkPerHour.ConversionFactorB = 36.08068627785781
PoundPerGallonUkPerHour.Symbol = "ppgUK/h"
PoundPerGallonUkPerHour IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:PoundPerGallonUsPerSecond
PoundPerGallonUsPerSecond.ConversionFactorA = 0
PoundPerGallonUsPerSecond.ConversionFactorB = 0.00834540445201933
PoundPerGallonUsPerSecond.Symbol = "ppgUS/s"
PoundPerGallonUsPerSecond IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:PoundPerGallonUsPerMinute
PoundPerGallonUsPerMinute.ConversionFactorA = 0
PoundPerGallonUsPerMinute.ConversionFactorB = 0.5007242671211598
PoundPerGallonUsPerMinute.Symbol = "ppgUS/min"
PoundPerGallonUsPerMinute IsUnitForQuantity MassDensityRateOfChangeQuantity
Unit:PoundPerGallonUsPerHour
PoundPerGallonUsPerHour.ConversionFactorA = 0
PoundPerGallonUsPerHour.ConversionFactorB = 30.043456027269592
PoundPerGallonUsPerHour.Symbol = "ppgUS/h"
PoundPerGallonUsPerHour IsUnitForQuantity MassDensityRateOfChangeQuantity
```
## DimensionlessQuantity <!-- NOUN -->
- Display name: Dimensionless
- Parent class: Quantity
- Specialization: 
- Description: 
As its name indicates, a dimensionless quantity has no dimension:

- Examples: 
``` dwis
Quantity:DimensionlessQuantity
Unit:Dimensionless
Dimensionless.ConversionFactorA = 0
Dimensionless.ConversionFactorB = 1
Dimensionless IsUnitForQuantity DimensionlessQuantity
DimensionlessQuantity HasSIUnit Dimensionless
```
## DynamicViscosityQuantity <!-- NOUN -->
- Display name: DynamicViscosity
- Parent class: Quantity
- Specialization: 
  - L = -1
  - M = 1
  - T = -1
- Description: 
Dynamic viscosity is a measure of a fluid's resistance to shear or flow when a force is applied. It quantifies how thick or thin the fluid is.
The dimension of dynamic viscosity is:
$$[ML^{-1}T^{-1}]$$.

The SI unit for **dynamic viscosity** is: pascal second with the associated unit label $Pa \cdot s$

- Examples: 
``` dwis
Quantity:DynamicViscosityQuantity
DynamicViscosityQuantity.L = -1
DynamicViscosityQuantity.M = 1
DynamicViscosityQuantity.T = -1
Unit:PascalSecond
PascalSecond.ConversionFactorA = 0
PascalSecond.ConversionFactorB = 1
PascalSecond.Symbol = "Pa•s"
PascalSecond IsUnitForQuantity DynamicViscosityQuantity
DynamicViscosityQuantity HasSIUnit PascalSecond
Unit:MillipascalSecond
MillipascalSecond.ConversionFactorA = 0
MillipascalSecond.ConversionFactorB = 1000
MillipascalSecond.Symbol = "mPa•s"
MillipascalSecond IsUnitForQuantity DynamicViscosityQuantity
Unit:MicropascalSecond
MicropascalSecond.ConversionFactorA = 0
MicropascalSecond.ConversionFactorB = 1000000
MicropascalSecond.Symbol = "µPa•s"
MicropascalSecond IsUnitForQuantity DynamicViscosityQuantity
Unit:Poise
Poise.ConversionFactorA = 0
Poise.ConversionFactorB = 10
Poise.Symbol = "P"
Poise IsUnitForQuantity DynamicViscosityQuantity
Unit:Centipoise
Centipoise.ConversionFactorA = 0
Centipoise.ConversionFactorB = 1000
Centipoise.Symbol = "cP"
Centipoise IsUnitForQuantity DynamicViscosityQuantity
Unit:Millipoise
Millipoise.ConversionFactorA = 0
Millipoise.ConversionFactorB = 10000
Millipoise.Symbol = "mP"
Millipoise IsUnitForQuantity DynamicViscosityQuantity
Unit:Micropoise
Micropoise.ConversionFactorA = 0
Micropoise.ConversionFactorB = 10000000
Micropoise.Symbol = "µP"
Micropoise IsUnitForQuantity DynamicViscosityQuantity
Unit:PoundSecondPerSquareFoot
PoundSecondPerSquareFoot.ConversionFactorA = 0
PoundSecondPerSquareFoot.ConversionFactorB = 0.020885434233150126
PoundSecondPerSquareFoot.Symbol = "lb•s/ft²"
PoundSecondPerSquareFoot IsUnitForQuantity DynamicViscosityQuantity
Unit:PoundSecondPer100SquareFoot
PoundSecondPer100SquareFoot.ConversionFactorA = 0
PoundSecondPer100SquareFoot.ConversionFactorB = 2.0885434233150124
PoundSecondPer100SquareFoot.Symbol = "lb•s/100ft²"
PoundSecondPer100SquareFoot IsUnitForQuantity DynamicViscosityQuantity
Unit:PoundSecondPerSquareInch
PoundSecondPerSquareInch.ConversionFactorA = 0
PoundSecondPerSquareInch.ConversionFactorB = 0.0001450377377302092
PoundSecondPerSquareInch.Symbol = "lb•s/in²"
PoundSecondPerSquareInch IsUnitForQuantity DynamicViscosityQuantity
Unit:DyneSecondPerSquareCentimetre
DyneSecondPerSquareCentimetre.ConversionFactorA = 0
DyneSecondPerSquareCentimetre.ConversionFactorB = 10
DyneSecondPerSquareCentimetre.Symbol = "dyne•s/cm²"
DyneSecondPerSquareCentimetre IsUnitForQuantity DynamicViscosityQuantity
```
## ElectricCapacitanceQuantity <!-- NOUN -->
- Display name: ElectricCapacitance
- Parent class: Quantity
- Specialization: 
  - L = -2
  - M = -1
  - T = 4
  - I = 2
- Description: 
lectric capacitance is the ability of a capacitor or a component to store electrical charge per unit voltage applied across it.
The dimension of electric capacitance is:
$$[T^{4}I^{2}M^{-1}L^{-2}]$$.

The SI unit for **electric capacitance** is: farad with the associated unit label $F$

- Examples: 
``` dwis
Quantity:ElectricCapacitanceQuantity
ElectricCapacitanceQuantity.L = -2
ElectricCapacitanceQuantity.M = -1
ElectricCapacitanceQuantity.T = 4
ElectricCapacitanceQuantity.I = 2
Unit:Farad
Farad.ConversionFactorA = 0
Farad.ConversionFactorB = 1
Farad.Symbol = "F"
Farad IsUnitForQuantity ElectricCapacitanceQuantity
ElectricCapacitanceQuantity HasSIUnit Farad
Unit:CoulombPerVolt
CoulombPerVolt.ConversionFactorA = 0
CoulombPerVolt.ConversionFactorB = 1
CoulombPerVolt.Symbol = "C/V"
CoulombPerVolt IsUnitForQuantity ElectricCapacitanceQuantity
Unit:Millifarad
Millifarad.ConversionFactorA = 0
Millifarad.ConversionFactorB = 1000
Millifarad.Symbol = "mF"
Millifarad IsUnitForQuantity ElectricCapacitanceQuantity
Unit:Microfarad
Microfarad.ConversionFactorA = 0
Microfarad.ConversionFactorB = 1000000
Microfarad.Symbol = "μF"
Microfarad IsUnitForQuantity ElectricCapacitanceQuantity
Unit:Nanofarad
Nanofarad.ConversionFactorA = 0
Nanofarad.ConversionFactorB = 999999999.9999999
Nanofarad.Symbol = "nF"
Nanofarad IsUnitForQuantity ElectricCapacitanceQuantity
Unit:Picofarad
Picofarad.ConversionFactorA = 0
Picofarad.ConversionFactorB = 1000000000000
Picofarad.Symbol = "pF"
Picofarad IsUnitForQuantity ElectricCapacitanceQuantity
```
## ElectricCurrentQuantity <!-- NOUN -->
- Display name: ElectricCurrent
- Parent class: Quantity
- Specialization: 
  - I = 1
- Description: 
Electric current is the flow of electric charge through a conductor or circuit.
The dimension of electric current is:
$$[I]$$.

The SI unit for **electric current** is: ampere with the associated unit label $A$

- Examples: 
``` dwis
Quantity:ElectricCurrentQuantity
ElectricCurrentQuantity.I = 1
Unit:Ampere
Ampere.ConversionFactorA = 0
Ampere.ConversionFactorB = 1
Ampere.Symbol = "A"
Ampere IsUnitForQuantity ElectricCurrentQuantity
ElectricCurrentQuantity HasSIUnit Ampere
Unit:CoulombPerSecond
CoulombPerSecond.ConversionFactorA = 0
CoulombPerSecond.ConversionFactorB = 1
CoulombPerSecond.Symbol = "C/s"
CoulombPerSecond IsUnitForQuantity ElectricCurrentQuantity
Unit:SiemensVolt
SiemensVolt.ConversionFactorA = 0
SiemensVolt.ConversionFactorB = 1
SiemensVolt.Symbol = "S•V"
SiemensVolt IsUnitForQuantity ElectricCurrentQuantity
Unit:VoltPerOhm
VoltPerOhm.ConversionFactorA = 0
VoltPerOhm.ConversionFactorB = 1
VoltPerOhm.Symbol = "V/Ω"
VoltPerOhm IsUnitForQuantity ElectricCurrentQuantity
Unit:WattPerVolt
WattPerVolt.ConversionFactorA = 0
WattPerVolt.ConversionFactorB = 1
WattPerVolt.Symbol = "W/V"
WattPerVolt IsUnitForQuantity ElectricCurrentQuantity
Unit:WeberPerHenry
WeberPerHenry.ConversionFactorA = 0
WeberPerHenry.ConversionFactorB = 1
WeberPerHenry.Symbol = "Wb/H"
WeberPerHenry IsUnitForQuantity ElectricCurrentQuantity
Unit:Deciampere
Deciampere.ConversionFactorA = 0
Deciampere.ConversionFactorB = 10
Deciampere.Symbol = "dA"
Deciampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Centiampere
Centiampere.ConversionFactorA = 0
Centiampere.ConversionFactorB = 100
Centiampere.Symbol = "cA"
Centiampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Milliampere
Milliampere.ConversionFactorA = 0
Milliampere.ConversionFactorB = 1000
Milliampere.Symbol = "mA"
Milliampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Microampere
Microampere.ConversionFactorA = 0
Microampere.ConversionFactorB = 1000000
Microampere.Symbol = "µA"
Microampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Nanoampere
Nanoampere.ConversionFactorA = 0
Nanoampere.ConversionFactorB = 999999999.9999999
Nanoampere.Symbol = "nA"
Nanoampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Picoampere
Picoampere.ConversionFactorA = 0
Picoampere.ConversionFactorB = 1000000000000
Picoampere.Symbol = "pA"
Picoampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Biot
Biot.ConversionFactorA = 0
Biot.ConversionFactorB = 0.1
Biot.Symbol = "Bi"
Biot IsUnitForQuantity ElectricCurrentQuantity
Unit:Abampere
Abampere.ConversionFactorA = 0
Abampere.ConversionFactorB = 0.1
Abampere.Symbol = "abA"
Abampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Kiloampere
Kiloampere.ConversionFactorA = 0
Kiloampere.ConversionFactorB = 0.001
Kiloampere.Symbol = "kA"
Kiloampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Megaampere
Megaampere.ConversionFactorA = 0
Megaampere.ConversionFactorB = 1E-06
Megaampere.Symbol = "MA"
Megaampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Gigaampere
Gigaampere.ConversionFactorA = 0
Gigaampere.ConversionFactorB = 1E-09
Gigaampere.Symbol = "GA"
Gigaampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Teraampere
Teraampere.ConversionFactorA = 0
Teraampere.ConversionFactorB = 1E-12
Teraampere.Symbol = "TA"
Teraampere IsUnitForQuantity ElectricCurrentQuantity
Unit:Statampere
Statampere.ConversionFactorA = 0
Statampere.ConversionFactorB = 2997924580
Statampere.Symbol = "stA"
Statampere IsUnitForQuantity ElectricCurrentQuantity
```
## ElongationGradientPerLengthQuantity <!-- NOUN -->
- Display name: ElongationGradientPerLength
- Parent class: Quantity
- Specialization: 
- Description: 
An elongation gradient per length is the first derivative of an elongation compared to a distance: $\frac{d\epsilon}{ds}$, where $\epsilon$ is an elongation and $s$ is a distance.
It is dimensionless.

The SI unit for **elongation gradient per length** is: metre per metre with the associated unit label $\frac{m}{m}$

- Examples: 
``` dwis
Quantity:ElongationGradientPerLengthQuantity
Unit:MetrePerMetre
MetrePerMetre.ConversionFactorA = 0
MetrePerMetre.ConversionFactorB = 1
MetrePerMetre.Symbol = "m/m"
MetrePerMetre IsUnitForQuantity ElongationGradientPerLengthQuantity
ElongationGradientPerLengthQuantity HasSIUnit MetrePerMetre
Unit:DecimetrePerMetre
DecimetrePerMetre.ConversionFactorA = 0
DecimetrePerMetre.ConversionFactorB = 10
DecimetrePerMetre.Symbol = "dm/m"
DecimetrePerMetre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:CentimetrePerMetre
CentimetrePerMetre.ConversionFactorA = 0
CentimetrePerMetre.ConversionFactorB = 100
CentimetrePerMetre.Symbol = "cm/m"
CentimetrePerMetre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:MillimetrePerMetre
MillimetrePerMetre.ConversionFactorA = 0
MillimetrePerMetre.ConversionFactorB = 1000
MillimetrePerMetre.Symbol = "mm/m"
MillimetrePerMetre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:MicrometrePerMetre
MicrometrePerMetre.ConversionFactorA = 0
MicrometrePerMetre.ConversionFactorB = 1000000
MicrometrePerMetre.Symbol = "µm/m"
MicrometrePerMetre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:MetrePerKilometre
MetrePerKilometre.ConversionFactorA = 0
MetrePerKilometre.ConversionFactorB = 1000
MetrePerKilometre.Symbol = "m/km"
MetrePerKilometre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:DecimetrePerKilometre
DecimetrePerKilometre.ConversionFactorA = 0
DecimetrePerKilometre.ConversionFactorB = 10000
DecimetrePerKilometre.Symbol = "dm/km"
DecimetrePerKilometre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:CentimetrePerKilometre
CentimetrePerKilometre.ConversionFactorA = 0
CentimetrePerKilometre.ConversionFactorB = 100000
CentimetrePerKilometre.Symbol = "cm/km"
CentimetrePerKilometre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:MillimetrePerKilometre
MillimetrePerKilometre.ConversionFactorA = 0
MillimetrePerKilometre.ConversionFactorB = 1000000
MillimetrePerKilometre.Symbol = "mm/km"
MillimetrePerKilometre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:MicrometrePerKilometre
MicrometrePerKilometre.ConversionFactorA = 0
MicrometrePerKilometre.ConversionFactorB = 1000000000
MicrometrePerKilometre.Symbol = "µm/km"
MicrometrePerKilometre IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:InchPerFoot
InchPerFoot.ConversionFactorA = 0
InchPerFoot.ConversionFactorB = 11.999999999999998
InchPerFoot.Symbol = "in/ft"
InchPerFoot IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:InchPerYard
InchPerYard.ConversionFactorA = 0
InchPerYard.ConversionFactorB = 36
InchPerYard.Symbol = "in/yd"
InchPerYard IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:InchPerMile
InchPerMile.ConversionFactorA = 0
InchPerMile.ConversionFactorB = 63359.99999999999
InchPerMile.Symbol = "in/mi"
InchPerMile IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:FootPerFoot
FootPerFoot.ConversionFactorA = 0
FootPerFoot.ConversionFactorB = 1
FootPerFoot.Symbol = "ft/ft"
FootPerFoot IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:FootPerYard
FootPerYard.ConversionFactorA = 0
FootPerYard.ConversionFactorB = 3
FootPerYard.Symbol = "ft/yd"
FootPerYard IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:FootPerMile
FootPerMile.ConversionFactorA = 0
FootPerMile.ConversionFactorB = 5280
FootPerMile.Symbol = "ft/mi"
FootPerMile IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:YardPerFoot
YardPerFoot.ConversionFactorA = 0
YardPerFoot.ConversionFactorB = 0.3333333333333333
YardPerFoot.Symbol = "yd/ft"
YardPerFoot IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:YardPerYard
YardPerYard.ConversionFactorA = 0
YardPerYard.ConversionFactorB = 1
YardPerYard.Symbol = "yd/yd"
YardPerYard IsUnitForQuantity ElongationGradientPerLengthQuantity
Unit:YardPerMile
YardPerMile.ConversionFactorA = 0
YardPerMile.ConversionFactorB = 1760
YardPerMile.Symbol = "yd/mi"
YardPerMile IsUnitForQuantity ElongationGradientPerLengthQuantity
```
## EnergyDensityQuantity <!-- NOUN -->
- Display name: EnergyDensity
- Parent class: Quantity
- Specialization: 
  - L = -1
  - M = 1
  - T = -2
- Description: 
Energy density is the amount of energy stored per unit volume or mass of a substance or system.
The dimension of energy density is:
$$[ML^{-1}T^{-2}]$$.

The SI unit for **energy density** is: joule per cubic metre with the associated unit label $\frac{J}{m^{3}}$

- Examples: 
``` dwis
Quantity:EnergyDensityQuantity
EnergyDensityQuantity.L = -1
EnergyDensityQuantity.M = 1
EnergyDensityQuantity.T = -2
Unit:JoulePerCubicMetre
JoulePerCubicMetre.ConversionFactorA = 0
JoulePerCubicMetre.ConversionFactorB = 1
JoulePerCubicMetre.Symbol = "J/m³"
JoulePerCubicMetre IsUnitForQuantity EnergyDensityQuantity
EnergyDensityQuantity HasSIUnit JoulePerCubicMetre
Unit:JoulePerLitre
JoulePerLitre.ConversionFactorA = 0
JoulePerLitre.ConversionFactorB = 0.001
JoulePerLitre.Symbol = "J/L"
JoulePerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:KilojoulePerCubicMetre
KilojoulePerCubicMetre.ConversionFactorA = 0
KilojoulePerCubicMetre.ConversionFactorB = 0.001
KilojoulePerCubicMetre.Symbol = "kJ/m³"
KilojoulePerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:KilojoulePerLitre
KilojoulePerLitre.ConversionFactorA = 0
KilojoulePerLitre.ConversionFactorB = 1E-06
KilojoulePerLitre.Symbol = "kJ/L"
KilojoulePerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:MegajoulePerCubicMetre
MegajoulePerCubicMetre.ConversionFactorA = 0
MegajoulePerCubicMetre.ConversionFactorB = 1E-06
MegajoulePerCubicMetre.Symbol = "MJ/m³"
MegajoulePerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:MegajoulePerLitre
MegajoulePerLitre.ConversionFactorA = 0
MegajoulePerLitre.ConversionFactorB = 1E-09
MegajoulePerLitre.Symbol = "MJ/L"
MegajoulePerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:GigajoulePerCubicMetre
GigajoulePerCubicMetre.ConversionFactorA = 0
GigajoulePerCubicMetre.ConversionFactorB = 1E-09
GigajoulePerCubicMetre.Symbol = "GJ/m³"
GigajoulePerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:GigajoulePerLitre
GigajoulePerLitre.ConversionFactorA = 0
GigajoulePerLitre.ConversionFactorB = 1E-12
GigajoulePerLitre.Symbol = "GJ/L"
GigajoulePerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:CaloriePerCubicMetre
CaloriePerCubicMetre.ConversionFactorA = 0
CaloriePerCubicMetre.ConversionFactorB = 0.2390057361376673
CaloriePerCubicMetre.Symbol = "cal/m³"
CaloriePerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:CaloriePerLitre
CaloriePerLitre.ConversionFactorA = 0
CaloriePerLitre.ConversionFactorB = 0.0002390057361376673
CaloriePerLitre.Symbol = "cal/L"
CaloriePerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:KilocaloriePerCubicMetre
KilocaloriePerCubicMetre.ConversionFactorA = 0
KilocaloriePerCubicMetre.ConversionFactorB = 0.0002390057361376673
KilocaloriePerCubicMetre.Symbol = "Cal/m³"
KilocaloriePerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:KilocaloriePerLitre
KilocaloriePerLitre.ConversionFactorA = 0
KilocaloriePerLitre.ConversionFactorB = 2.390057361376673E-07
KilocaloriePerLitre.Symbol = "Cal/L"
KilocaloriePerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:JoulePerCubicFoot
JoulePerCubicFoot.ConversionFactorA = 0
JoulePerCubicFoot.ConversionFactorB = 0.02831684659199999
JoulePerCubicFoot.Symbol = "J/ft³"
JoulePerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:KilojoulePerCubicFoot
KilojoulePerCubicFoot.ConversionFactorA = 0
KilojoulePerCubicFoot.ConversionFactorB = 2.831684659199999E-05
KilojoulePerCubicFoot.Symbol = "kJ/ft³"
KilojoulePerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:MegajoulePerCubicFoot
MegajoulePerCubicFoot.ConversionFactorA = 0
MegajoulePerCubicFoot.ConversionFactorB = 2.831684659199999E-08
MegajoulePerCubicFoot.Symbol = "MJ/ft³"
MegajoulePerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:GigajoulePerCubicFoot
GigajoulePerCubicFoot.ConversionFactorA = 0
GigajoulePerCubicFoot.ConversionFactorB = 2.831684659199999E-11
GigajoulePerCubicFoot.Symbol = "GJ/ft³"
GigajoulePerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:CaloriePerCubicFoot
CaloriePerCubicFoot.ConversionFactorA = 0
CaloriePerCubicFoot.ConversionFactorB = 0.006767888764818353
CaloriePerCubicFoot.Symbol = "cal/ft³"
CaloriePerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:KilocaloriePerCubicFoot
KilocaloriePerCubicFoot.ConversionFactorA = 0
KilocaloriePerCubicFoot.ConversionFactorB = 6.767888764818354E-06
KilocaloriePerCubicFoot.Symbol = "Cal/ft³"
KilocaloriePerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:JoulePerCubicInch
JoulePerCubicInch.ConversionFactorA = 0
JoulePerCubicInch.ConversionFactorB = 1.6387064E-05
JoulePerCubicInch.Symbol = "J/in³"
JoulePerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:KilojoulePerCubicInch
KilojoulePerCubicInch.ConversionFactorA = 0
KilojoulePerCubicInch.ConversionFactorB = 1.6387064E-08
KilojoulePerCubicInch.Symbol = "kJ/in³"
KilojoulePerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:MegajoulePerCubicInch
MegajoulePerCubicInch.ConversionFactorA = 0
MegajoulePerCubicInch.ConversionFactorB = 1.6387064E-11
MegajoulePerCubicInch.Symbol = "MJ/in³"
MegajoulePerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:GigajoulePerCubicInch
GigajoulePerCubicInch.ConversionFactorA = 0
GigajoulePerCubicInch.ConversionFactorB = 1.6387064E-14
GigajoulePerCubicInch.Symbol = "GJ/in³"
GigajoulePerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:CaloriePerCubicInch
CaloriePerCubicInch.ConversionFactorA = 0
CaloriePerCubicInch.ConversionFactorB = 3.916602294455067E-06
CaloriePerCubicInch.Symbol = "cal/in³"
CaloriePerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:KilocaloriePerCubicInch
KilocaloriePerCubicInch.ConversionFactorA = 0
KilocaloriePerCubicInch.ConversionFactorB = 3.916602294455067E-09
KilocaloriePerCubicInch.Symbol = "Cal/in³"
KilocaloriePerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:JoulePerGallonUk
JoulePerGallonUk.ConversionFactorA = 0
JoulePerGallonUk.ConversionFactorB = 0.00454609
JoulePerGallonUk.Symbol = "J/gal(UK)"
JoulePerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:KilojoulePerGallonUk
KilojoulePerGallonUk.ConversionFactorA = 0
KilojoulePerGallonUk.ConversionFactorB = 4.54609E-06
KilojoulePerGallonUk.Symbol = "kJ/gal(UK)"
KilojoulePerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:MegajoulePerGallonUk
MegajoulePerGallonUk.ConversionFactorA = 0
MegajoulePerGallonUk.ConversionFactorB = 4.54609E-09
MegajoulePerGallonUk.Symbol = "MJ/gal(UK)"
MegajoulePerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:GigajoulePerGallonUk
GigajoulePerGallonUk.ConversionFactorA = 0
GigajoulePerGallonUk.ConversionFactorB = 4.54609E-12
GigajoulePerGallonUk.Symbol = "GJ/gal(UK)"
GigajoulePerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:CaloriePerGallonUk
CaloriePerGallonUk.ConversionFactorA = 0
CaloriePerGallonUk.ConversionFactorB = 0.0010865415869980878
CaloriePerGallonUk.Symbol = "cal/gal(UK)"
CaloriePerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:KilocaloriePerGallonUk
KilocaloriePerGallonUk.ConversionFactorA = 0
KilocaloriePerGallonUk.ConversionFactorB = 1.086541586998088E-06
KilocaloriePerGallonUk.Symbol = "Cal/gal(UK)"
KilocaloriePerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:JoulePerGallonUs
JoulePerGallonUs.ConversionFactorA = 0
JoulePerGallonUs.ConversionFactorB = 0.0037854117839999997
JoulePerGallonUs.Symbol = "J/gal(US)"
JoulePerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:KilojoulePerGallonUs
KilojoulePerGallonUs.ConversionFactorA = 0
KilojoulePerGallonUs.ConversionFactorB = 3.7854117839999998E-06
KilojoulePerGallonUs.Symbol = "kJ/gal(US)"
KilojoulePerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:MegajoulePerGallonUs
MegajoulePerGallonUs.ConversionFactorA = 0
MegajoulePerGallonUs.ConversionFactorB = 3.7854117839999995E-09
MegajoulePerGallonUs.Symbol = "MJ/gal(US)"
MegajoulePerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:GigajoulePerGallonUs
GigajoulePerGallonUs.ConversionFactorA = 0
GigajoulePerGallonUs.ConversionFactorB = 3.785411784E-12
GigajoulePerGallonUs.Symbol = "GJ/gal(US)"
GigajoulePerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:CaloriePerGallonUs
CaloriePerGallonUs.ConversionFactorA = 0
CaloriePerGallonUs.ConversionFactorB = 0.0009047351300191204
CaloriePerGallonUs.Symbol = "cal/gal(US)"
CaloriePerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:KilocaloriePerGallonUs
KilocaloriePerGallonUs.ConversionFactorA = 0
KilocaloriePerGallonUs.ConversionFactorB = 9.047351300191203E-07
KilocaloriePerGallonUs.Symbol = "Cal/gal(US)"
KilocaloriePerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:BritishThermalUnitPerCubicMetre
BritishThermalUnitPerCubicMetre.ConversionFactorA = 0
BritishThermalUnitPerCubicMetre.ConversionFactorB = 0.0009484516526770049
BritishThermalUnitPerCubicMetre.Symbol = "BTU/m³"
BritishThermalUnitPerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:BritishThermalUnitPerLitre
BritishThermalUnitPerLitre.ConversionFactorA = 0
BritishThermalUnitPerLitre.ConversionFactorB = 9.484516526770049E-07
BritishThermalUnitPerLitre.Symbol = "BTU/L"
BritishThermalUnitPerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:BritishThermalUnitPerCubicFoot
BritishThermalUnitPerCubicFoot.ConversionFactorA = 0
BritishThermalUnitPerCubicFoot.ConversionFactorB = 2.6857159948783606E-05
BritishThermalUnitPerCubicFoot.Symbol = "BTU/ft³"
BritishThermalUnitPerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:BritishThermalUnitPerCubicInch
BritishThermalUnitPerCubicInch.ConversionFactorA = 0
BritishThermalUnitPerCubicInch.ConversionFactorB = 1.554233793332385E-08
BritishThermalUnitPerCubicInch.Symbol = "BTU/in³"
BritishThermalUnitPerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:BritishThermalUnitPerGallonUk
BritishThermalUnitPerGallonUk.ConversionFactorA = 0
BritishThermalUnitPerGallonUk.ConversionFactorB = 4.311746573718405E-06
BritishThermalUnitPerGallonUk.Symbol = "BTU/gal(UK)"
BritishThermalUnitPerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:BritishThermalUnitPerGallonUs
BritishThermalUnitPerGallonUs.ConversionFactorA = 0
BritishThermalUnitPerGallonUs.ConversionFactorB = 3.5902800625978092E-06
BritishThermalUnitPerGallonUs.Symbol = "BTU/gal(US)"
BritishThermalUnitPerGallonUs IsUnitForQuantity EnergyDensityQuantity
Unit:KiloBritishThermalUnitPerCubicMetre
KiloBritishThermalUnitPerCubicMetre.ConversionFactorA = 0
KiloBritishThermalUnitPerCubicMetre.ConversionFactorB = 9.484516526770048E-07
KiloBritishThermalUnitPerCubicMetre.Symbol = "kBTU/m³"
KiloBritishThermalUnitPerCubicMetre IsUnitForQuantity EnergyDensityQuantity
Unit:KiloBritishThermalUnitPerLitre
KiloBritishThermalUnitPerLitre.ConversionFactorA = 0
KiloBritishThermalUnitPerLitre.ConversionFactorB = 9.48451652677005E-10
KiloBritishThermalUnitPerLitre.Symbol = "kBTU/L"
KiloBritishThermalUnitPerLitre IsUnitForQuantity EnergyDensityQuantity
Unit:KiloBritishThermalUnitPerCubicFoot
KiloBritishThermalUnitPerCubicFoot.ConversionFactorA = 0
KiloBritishThermalUnitPerCubicFoot.ConversionFactorB = 2.6857159948783602E-08
KiloBritishThermalUnitPerCubicFoot.Symbol = "kBTU/ft³"
KiloBritishThermalUnitPerCubicFoot IsUnitForQuantity EnergyDensityQuantity
Unit:KiloBritishThermalUnitPerCubicInch
KiloBritishThermalUnitPerCubicInch.ConversionFactorA = 0
KiloBritishThermalUnitPerCubicInch.ConversionFactorB = 1.5542337933323848E-11
KiloBritishThermalUnitPerCubicInch.Symbol = "kBTU/in³"
KiloBritishThermalUnitPerCubicInch IsUnitForQuantity EnergyDensityQuantity
Unit:KiloBritishThermalUnitPerGallonUk
KiloBritishThermalUnitPerGallonUk.ConversionFactorA = 0
KiloBritishThermalUnitPerGallonUk.ConversionFactorB = 4.311746573718405E-09
KiloBritishThermalUnitPerGallonUk.Symbol = "kBTU/gal(UK)"
KiloBritishThermalUnitPerGallonUk IsUnitForQuantity EnergyDensityQuantity
Unit:KiloBritishThermalUnitPerGallonUs
KiloBritishThermalUnitPerGallonUs.ConversionFactorA = 0
KiloBritishThermalUnitPerGallonUs.ConversionFactorB = 3.5902800625978087E-09
KiloBritishThermalUnitPerGallonUs.Symbol = "kBTU/gal(US)"
KiloBritishThermalUnitPerGallonUs IsUnitForQuantity EnergyDensityQuantity
```
## ForceGradientPerLengthQuantity <!-- NOUN -->
- Display name: ForceGradientPerLength
- Parent class: Quantity
- Specialization: 
  - M = 1
  - T = -2
- Description: 
A force gradient per length is the first derivative compared to a distance of a force: $\frac{dF}{ds}$ where $F$ is a force and $s$ is a distance.
The dimension of force gradient per length is:
$$[MT^{-2}]$$.

The SI unit for **force gradient per length** is: newton per metre with the associated unit label $\frac{N}{m}$

- Examples: 
``` dwis
Quantity:ForceGradientPerLengthQuantity
ForceGradientPerLengthQuantity.M = 1
ForceGradientPerLengthQuantity.T = -2
Unit:NewtonPerMetre
NewtonPerMetre.ConversionFactorA = 0
NewtonPerMetre.ConversionFactorB = 1
NewtonPerMetre.Symbol = "N/m"
NewtonPerMetre IsUnitForQuantity ForceGradientPerLengthQuantity
ForceGradientPerLengthQuantity HasSIUnit NewtonPerMetre
Unit:NewtonPer30Metre
NewtonPer30Metre.ConversionFactorA = 0
NewtonPer30Metre.ConversionFactorB = 30
NewtonPer30Metre.Symbol = "N/30m"
NewtonPer30Metre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:NewtonPer10Metre
NewtonPer10Metre.ConversionFactorA = 0
NewtonPer10Metre.ConversionFactorB = 10
NewtonPer10Metre.Symbol = "N/10m"
NewtonPer10Metre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:NewtonPerDecimetre
NewtonPerDecimetre.ConversionFactorA = 0
NewtonPerDecimetre.ConversionFactorB = 0.1
NewtonPerDecimetre.Symbol = "N/dm"
NewtonPerDecimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:NewtonPerCentimetre
NewtonPerCentimetre.ConversionFactorA = 0
NewtonPerCentimetre.ConversionFactorB = 0.01
NewtonPerCentimetre.Symbol = "N/cm"
NewtonPerCentimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:NewtonPerMillimetre
NewtonPerMillimetre.ConversionFactorA = 0
NewtonPerMillimetre.ConversionFactorB = 0.001
NewtonPerMillimetre.Symbol = "N/mm"
NewtonPerMillimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:DecanewtonPerMetre
DecanewtonPerMetre.ConversionFactorA = 0
DecanewtonPerMetre.ConversionFactorB = 0.1
DecanewtonPerMetre.Symbol = "daN/m"
DecanewtonPerMetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:DecanewtonPer30Metre
DecanewtonPer30Metre.ConversionFactorA = 0
DecanewtonPer30Metre.ConversionFactorB = 3
DecanewtonPer30Metre.Symbol = "daN/30m"
DecanewtonPer30Metre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:DecanewtonPer10Metre
DecanewtonPer10Metre.ConversionFactorA = 0
DecanewtonPer10Metre.ConversionFactorB = 1
DecanewtonPer10Metre.Symbol = "daN/10m"
DecanewtonPer10Metre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:DecanewtonPerDecimetre
DecanewtonPerDecimetre.ConversionFactorA = 0
DecanewtonPerDecimetre.ConversionFactorB = 0.01
DecanewtonPerDecimetre.Symbol = "daN/dm"
DecanewtonPerDecimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:DecanewtonPerCentimetre
DecanewtonPerCentimetre.ConversionFactorA = 0
DecanewtonPerCentimetre.ConversionFactorB = 0.001
DecanewtonPerCentimetre.Symbol = "daN/cm"
DecanewtonPerCentimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:DecanewtonPerMillimetre
DecanewtonPerMillimetre.ConversionFactorA = 0
DecanewtonPerMillimetre.ConversionFactorB = 0.0001
DecanewtonPerMillimetre.Symbol = "daN/mm"
DecanewtonPerMillimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilonewtonPerMetre
KilonewtonPerMetre.ConversionFactorA = 0
KilonewtonPerMetre.ConversionFactorB = 0.001
KilonewtonPerMetre.Symbol = "kN/m"
KilonewtonPerMetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilonewtonPer30Metre
KilonewtonPer30Metre.ConversionFactorA = 0
KilonewtonPer30Metre.ConversionFactorB = 0.03
KilonewtonPer30Metre.Symbol = "kN/30m"
KilonewtonPer30Metre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilonewtonPer10Metre
KilonewtonPer10Metre.ConversionFactorA = 0
KilonewtonPer10Metre.ConversionFactorB = 0.01
KilonewtonPer10Metre.Symbol = "kN/10m"
KilonewtonPer10Metre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilonewtonPerDecimetre
KilonewtonPerDecimetre.ConversionFactorA = 0
KilonewtonPerDecimetre.ConversionFactorB = 0.0001
KilonewtonPerDecimetre.Symbol = "kN/dm"
KilonewtonPerDecimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilonewtonPerCentimetre
KilonewtonPerCentimetre.ConversionFactorA = 0
KilonewtonPerCentimetre.ConversionFactorB = 1E-05
KilonewtonPerCentimetre.Symbol = "kN/cm"
KilonewtonPerCentimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilonewtonPerMillimetre
KilonewtonPerMillimetre.ConversionFactorA = 0
KilonewtonPerMillimetre.ConversionFactorB = 1E-06
KilonewtonPerMillimetre.Symbol = "kN/mm"
KilonewtonPerMillimetre IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:PoundPerFoot
PoundPerFoot.ConversionFactorA = 0
PoundPerFoot.ConversionFactorB = 0.06852176585679175
PoundPerFoot.Symbol = "lbf/ft"
PoundPerFoot IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:PoundPerInch
PoundPerInch.ConversionFactorA = 0
PoundPerInch.ConversionFactorB = 0.0057101471547326465
PoundPerInch.Symbol = "lbf/in"
PoundPerInch IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilopoundPerFoot
KilopoundPerFoot.ConversionFactorA = 0
KilopoundPerFoot.ConversionFactorB = 6.852176585679175E-05
KilopoundPerFoot.Symbol = "klbf/ft"
KilopoundPerFoot IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilopoundPerInch
KilopoundPerInch.ConversionFactorA = 0
KilopoundPerInch.ConversionFactorB = 5.7101471547326466E-06
KilopoundPerInch.Symbol = "klbf/in"
KilopoundPerInch IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:PoundPer30Foot
PoundPer30Foot.ConversionFactorA = 0
PoundPer30Foot.ConversionFactorB = 2.0556529757037523
PoundPer30Foot.Symbol = "lbf/30ft"
PoundPer30Foot IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:PoundPer100Foot
PoundPer100Foot.ConversionFactorA = 0
PoundPer100Foot.ConversionFactorB = 6.852176585679175
PoundPer100Foot.Symbol = "lbf/100ft"
PoundPer100Foot IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilopoundPer30Foot
KilopoundPer30Foot.ConversionFactorA = 0
KilopoundPer30Foot.ConversionFactorB = 0.0020556529757037524
KilopoundPer30Foot.Symbol = "klbf/30ft"
KilopoundPer30Foot IsUnitForQuantity ForceGradientPerLengthQuantity
Unit:KilopoundPer100Foot
KilopoundPer100Foot.ConversionFactorA = 0
KilopoundPer100Foot.ConversionFactorB = 0.006852176585679175
KilopoundPer100Foot.Symbol = "klbf/100ft"
KilopoundPer100Foot IsUnitForQuantity ForceGradientPerLengthQuantity
```
## ForceQuantity <!-- NOUN -->
- Display name: Force
- Parent class: Quantity
- Specialization: 
  - L = 1
  - M = 1
  - T = -2
- Description: 
A force is an influence that can cause an object to change its velocity unless counterbalanced by other forces.
The dimension of force is:
$$[LMT^{-2}]$$.

The SI unit for **force** is: newton with the associated unit label $N$

- Examples: 
``` dwis
Quantity:ForceQuantity
ForceQuantity.L = 1
ForceQuantity.M = 1
ForceQuantity.T = -2
Unit:Newton
Newton.ConversionFactorA = 0
Newton.ConversionFactorB = 1
Newton.Symbol = "N"
Newton IsUnitForQuantity ForceQuantity
ForceQuantity HasSIUnit Newton
Unit:Decanewton
Decanewton.ConversionFactorA = 0
Decanewton.ConversionFactorB = 0.1
Decanewton.Symbol = "daN"
Decanewton IsUnitForQuantity ForceQuantity
Unit:Kilonewton
Kilonewton.ConversionFactorA = 0
Kilonewton.ConversionFactorB = 0.001
Kilonewton.Symbol = "kN"
Kilonewton IsUnitForQuantity ForceQuantity
Unit:Kilodecanewton
Kilodecanewton.ConversionFactorA = 0
Kilodecanewton.ConversionFactorB = 0.0001
Kilodecanewton.Symbol = "kdaN"
Kilodecanewton IsUnitForQuantity ForceQuantity
Unit:KilogramForce
KilogramForce.ConversionFactorA = 0
KilogramForce.ConversionFactorB = 0.10197162129779283
KilogramForce.Symbol = "kgf"
KilogramForce IsUnitForQuantity ForceQuantity
Unit:PoundForce
PoundForce.ConversionFactorA = 0
PoundForce.ConversionFactorB = 0.2248089430997105
PoundForce.Symbol = "lbf"
PoundForce IsUnitForQuantity ForceQuantity
Unit:KilopoundForce
KilopoundForce.ConversionFactorA = 0
KilopoundForce.ConversionFactorB = 0.0002248089430997105
KilopoundForce.Symbol = "klbf"
KilopoundForce IsUnitForQuantity ForceQuantity
```
## FrequencyQuantity <!-- NOUN -->
- Display name: Frequency
- Parent class: Quantity
- Specialization: 
  - T = -1
- Description: 
Frequency is the number of occurrences of a repeating event per unit of time.
The dimension of frequency is:
$$[T^{-1}]$$.

The SI unit for **frequency** is: hertz with the associated unit label $Hz$

- Examples: 
``` dwis
Quantity:FrequencyQuantity
FrequencyQuantity.T = -1
Unit:Hertz
Hertz.ConversionFactorA = 0
Hertz.ConversionFactorB = 1
Hertz.Symbol = "Hz"
Hertz IsUnitForQuantity FrequencyQuantity
FrequencyQuantity HasSIUnit Hertz
Unit:ReciprocalSecond
ReciprocalSecond.ConversionFactorA = 0
ReciprocalSecond.ConversionFactorB = 1
ReciprocalSecond.Symbol = "1/s"
ReciprocalSecond IsUnitForQuantity FrequencyQuantity
Unit:Kilohertz
Kilohertz.ConversionFactorA = 0
Kilohertz.ConversionFactorB = 0.001
Kilohertz.Symbol = "kHz"
Kilohertz IsUnitForQuantity FrequencyQuantity
Unit:Megahertz
Megahertz.ConversionFactorA = 0
Megahertz.ConversionFactorB = 1E-06
Megahertz.Symbol = "MHz"
Megahertz IsUnitForQuantity FrequencyQuantity
Unit:Gigahertz
Gigahertz.ConversionFactorA = 0
Gigahertz.ConversionFactorB = 1E-09
Gigahertz.Symbol = "GHz"
Gigahertz IsUnitForQuantity FrequencyQuantity
Unit:Terahertz
Terahertz.ConversionFactorA = 0
Terahertz.ConversionFactorB = 1E-12
Terahertz.Symbol = "THz"
Terahertz IsUnitForQuantity FrequencyQuantity
Unit:Rpm
Rpm.ConversionFactorA = 0
Rpm.ConversionFactorB = 60
Rpm.Symbol = "rpm"
Rpm IsUnitForQuantity FrequencyQuantity
Unit:Spm
Spm.ConversionFactorA = 0
Spm.ConversionFactorB = 60
Spm.Symbol = "spm"
Spm IsUnitForQuantity FrequencyQuantity
Unit:RotationPerSecond
RotationPerSecond.ConversionFactorA = 0
RotationPerSecond.ConversionFactorB = 1
RotationPerSecond.Symbol = "rps"
RotationPerSecond IsUnitForQuantity FrequencyQuantity
Unit:StrokePerSecond
StrokePerSecond.ConversionFactorA = 0
StrokePerSecond.ConversionFactorB = 1
StrokePerSecond.Symbol = "sps"
StrokePerSecond IsUnitForQuantity FrequencyQuantity
Unit:StrokePerHour
StrokePerHour.ConversionFactorA = 0
StrokePerHour.ConversionFactorB = 3600
StrokePerHour.Symbol = "sph"
StrokePerHour IsUnitForQuantity FrequencyQuantity
Unit:RotationPerHour
RotationPerHour.ConversionFactorA = 0
RotationPerHour.ConversionFactorB = 3600
RotationPerHour.Symbol = "rph"
RotationPerHour IsUnitForQuantity FrequencyQuantity
Unit:ShockPerSecond
ShockPerSecond.ConversionFactorA = 0
ShockPerSecond.ConversionFactorB = 1
ShockPerSecond.Symbol = "sps"
ShockPerSecond IsUnitForQuantity FrequencyQuantity
Unit:ShockPerMinute
ShockPerMinute.ConversionFactorA = 0
ShockPerMinute.ConversionFactorB = 60
ShockPerMinute.Symbol = "spm"
ShockPerMinute IsUnitForQuantity FrequencyQuantity
Unit:ShockPerHour
ShockPerHour.ConversionFactorA = 0
ShockPerHour.ConversionFactorB = 3600
ShockPerHour.Symbol = "spm"
ShockPerHour IsUnitForQuantity FrequencyQuantity
```
## FrequencyRateOfChangeQuantity <!-- NOUN -->
- Display name: FrequencyRateOfChange
- Parent class: Quantity
- Specialization: 
  - T = -2
- Description: 
A frequency rate of change is the time derivative of a frequency: $\frac{df}{dt}$, where $f$ is a frequency and $t$ is time.
The dimension of frequency rate of change is:
$$[T^{-2}]$$.

The SI unit for **frequency rate of change** is: hertz per second with the associated unit label $\frac{Hz}{s}$

- Examples: 
``` dwis
Quantity:FrequencyRateOfChangeQuantity
FrequencyRateOfChangeQuantity.T = -2
Unit:HertzPerSecond
HertzPerSecond.ConversionFactorA = 0
HertzPerSecond.ConversionFactorB = 1
HertzPerSecond.Symbol = "Hz/s"
HertzPerSecond IsUnitForQuantity FrequencyRateOfChangeQuantity
FrequencyRateOfChangeQuantity HasSIUnit HertzPerSecond
Unit:KiloHertzPerSecond
KiloHertzPerSecond.ConversionFactorA = 0
KiloHertzPerSecond.ConversionFactorB = 0.001
KiloHertzPerSecond.Symbol = "kHz/s"
KiloHertzPerSecond IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:MegaHertzPerSecond
MegaHertzPerSecond.ConversionFactorA = 0
MegaHertzPerSecond.ConversionFactorB = 1E-06
MegaHertzPerSecond.Symbol = "MHz/s"
MegaHertzPerSecond IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:GigaHertzPerSecond
GigaHertzPerSecond.ConversionFactorA = 0
GigaHertzPerSecond.ConversionFactorB = 1E-09
GigaHertzPerSecond.Symbol = "GHz/s"
GigaHertzPerSecond IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:HertzPerMinute
HertzPerMinute.ConversionFactorA = 0
HertzPerMinute.ConversionFactorB = 60
HertzPerMinute.Symbol = "Hz/min"
HertzPerMinute IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:KiloHertzPerMinute
KiloHertzPerMinute.ConversionFactorA = 0
KiloHertzPerMinute.ConversionFactorB = 0.06
KiloHertzPerMinute.Symbol = "kHz/min"
KiloHertzPerMinute IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:MegaHertzPerMinute
MegaHertzPerMinute.ConversionFactorA = 0
MegaHertzPerMinute.ConversionFactorB = 6E-05
MegaHertzPerMinute.Symbol = "MHz/min"
MegaHertzPerMinute IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:GigaHertzPerMinute
GigaHertzPerMinute.ConversionFactorA = 0
GigaHertzPerMinute.ConversionFactorB = 6E-08
GigaHertzPerMinute.Symbol = "GHz/min"
GigaHertzPerMinute IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:HertzPerHour
HertzPerHour.ConversionFactorA = 0
HertzPerHour.ConversionFactorB = 3600
HertzPerHour.Symbol = "Hz/h"
HertzPerHour IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:KiloHertzPerHour
KiloHertzPerHour.ConversionFactorA = 0
KiloHertzPerHour.ConversionFactorB = 3.6
KiloHertzPerHour.Symbol = "kHz/h"
KiloHertzPerHour IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:MegaHertzPerHour
MegaHertzPerHour.ConversionFactorA = 0
MegaHertzPerHour.ConversionFactorB = 0.0036
MegaHertzPerHour.Symbol = "MHz/h"
MegaHertzPerHour IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:GigaHertzPerHour
GigaHertzPerHour.ConversionFactorA = 0
GigaHertzPerHour.ConversionFactorB = 3.6E-06
GigaHertzPerHour.Symbol = "GHz/h"
GigaHertzPerHour IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:HertzPerDay
HertzPerDay.ConversionFactorA = 0
HertzPerDay.ConversionFactorB = 86400
HertzPerDay.Symbol = "Hz/d"
HertzPerDay IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:KiloHertzPerDay
KiloHertzPerDay.ConversionFactorA = 0
KiloHertzPerDay.ConversionFactorB = 86.4
KiloHertzPerDay.Symbol = "kHz/d"
KiloHertzPerDay IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:MegaHertzPerDay
MegaHertzPerDay.ConversionFactorA = 0
MegaHertzPerDay.ConversionFactorB = 0.0864
MegaHertzPerDay.Symbol = "MHz/d"
MegaHertzPerDay IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:GigaHertzPerDay
GigaHertzPerDay.ConversionFactorA = 0
GigaHertzPerDay.ConversionFactorB = 8.64E-05
GigaHertzPerDay.Symbol = "GHz/d"
GigaHertzPerDay IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:HertzPerYear
HertzPerYear.ConversionFactorA = 0
HertzPerYear.ConversionFactorB = 31557600
HertzPerYear.Symbol = "Hz/y"
HertzPerYear IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:KiloHertzPerYear
KiloHertzPerYear.ConversionFactorA = 0
KiloHertzPerYear.ConversionFactorB = 31557.6
KiloHertzPerYear.Symbol = "kHz/y"
KiloHertzPerYear IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:MegaHertzPerYear
MegaHertzPerYear.ConversionFactorA = 0
MegaHertzPerYear.ConversionFactorB = 31.5576
MegaHertzPerYear.Symbol = "MHz/y"
MegaHertzPerYear IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:GigaHertzPerYear
GigaHertzPerYear.ConversionFactorA = 0
GigaHertzPerYear.ConversionFactorB = 0.0315576
GigaHertzPerYear.Symbol = "GHz/y"
GigaHertzPerYear IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:RpmPerSecond
RpmPerSecond.ConversionFactorA = 0
RpmPerSecond.ConversionFactorB = 1
RpmPerSecond.Symbol = "rpm/s"
RpmPerSecond IsUnitForQuantity FrequencyRateOfChangeQuantity
Unit:SpmPerSecond
SpmPerSecond.ConversionFactorA = 0
SpmPerSecond.ConversionFactorB = 1
SpmPerSecond.Symbol = "spm/s"
SpmPerSecond IsUnitForQuantity FrequencyRateOfChangeQuantity
```
## HeatTransferCoefficientQuantity <!-- NOUN -->
- Display name: HeatTransferCoefficient
- Parent class: Quantity
- Specialization: 
  - M = 1
  - T = -3
  - ThT = -1
- Description: 
Heat transfer coefficient is a measure of the efficiency with which heat is transferred between a solid surface and a fluid (or between two fluids) per unit area and temperature difference.
The dimension of heat transfer coefficient is:
$$[MK^{-1}T^{-3}]$$.

The SI unit for **heat transfer coefficient** is: watt per square metre per kelvin with the associated unit label $\frac{W}{m^{2} \cdot K}$

- Examples: 
``` dwis
Quantity:HeatTransferCoefficientQuantity
HeatTransferCoefficientQuantity.M = 1
HeatTransferCoefficientQuantity.T = -3
HeatTransferCoefficientQuantity.ThT = -1
Unit:WattPerSquareMetrePerKelvin
WattPerSquareMetrePerKelvin.ConversionFactorA = 0
WattPerSquareMetrePerKelvin.ConversionFactorB = 1
WattPerSquareMetrePerKelvin.Symbol = "W/m²/K"
WattPerSquareMetrePerKelvin IsUnitForQuantity HeatTransferCoefficientQuantity
HeatTransferCoefficientQuantity HasSIUnit WattPerSquareMetrePerKelvin
Unit:BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit.ConversionFactorA = 0
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit.ConversionFactorB = 0.17622808365343573
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit.Symbol = "BTU/h/ft²/°F"
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit IsUnitForQuantity HeatTransferCoefficientQuantity
```
## InterfacialTensionQuantity <!-- NOUN -->
- Display name: InterfacialTension
- Parent class: Quantity
- Specialization: 
  - M = 1
  - T = -2
- Description: 
Interfacial tension is the force per unit length acting along the boundary between two immiscible liquids, resisting their mixing.
The dimension of interfacial tension is:
$$[MT^{-2}]$$.

The SI unit for **interfacial tension** is: newton per metre with the associated unit label $\frac{N}{m}$

- Examples: 
``` dwis
Quantity:InterfacialTensionQuantity
InterfacialTensionQuantity.M = 1
InterfacialTensionQuantity.T = -2
Unit:NewtonPerMetre
NewtonPerMetre.ConversionFactorA = 0
NewtonPerMetre.ConversionFactorB = 1
NewtonPerMetre.Symbol = "N/m"
NewtonPerMetre IsUnitForQuantity InterfacialTensionQuantity
InterfacialTensionQuantity HasSIUnit NewtonPerMetre
Unit:MillinewtonPerMetre
MillinewtonPerMetre.ConversionFactorA = 0
MillinewtonPerMetre.ConversionFactorB = 1000
MillinewtonPerMetre.Symbol = "mN/m"
MillinewtonPerMetre IsUnitForQuantity InterfacialTensionQuantity
Unit:DynePerCentimetre
DynePerCentimetre.ConversionFactorA = 0
DynePerCentimetre.ConversionFactorB = 999.9999999999999
DynePerCentimetre.Symbol = "dyne/cm"
DynePerCentimetre IsUnitForQuantity InterfacialTensionQuantity
Unit:PoundPerSecondSquared
PoundPerSecondSquared.ConversionFactorA = 0
PoundPerSecondSquared.ConversionFactorB = 2.2046226218487757
PoundPerSecondSquared.Symbol = "lb/s²"
PoundPerSecondSquared IsUnitForQuantity InterfacialTensionQuantity
```
## LengthQuantity <!-- NOUN -->
- Display name: Length
- Parent class: Quantity
- Specialization: 
  - L = 1
- Description: 
Length is a measure of distance.
The dimension of length is:
$$[L]$$.

The SI unit for **length** is: metre with the associated unit label $m$

- Examples: 
``` dwis
Quantity:LengthQuantity
LengthQuantity.L = 1
Unit:Metre
Metre.ConversionFactorA = 0
Metre.ConversionFactorB = 1
Metre.Symbol = "m"
Metre IsUnitForQuantity LengthQuantity
LengthQuantity HasSIUnit Metre
Unit:Decimetre
Decimetre.ConversionFactorA = 0
Decimetre.ConversionFactorB = 10
Decimetre.Symbol = "dm"
Decimetre IsUnitForQuantity LengthQuantity
Unit:Centimetre
Centimetre.ConversionFactorA = 0
Centimetre.ConversionFactorB = 100
Centimetre.Symbol = "cm"
Centimetre IsUnitForQuantity LengthQuantity
Unit:Millimetre
Millimetre.ConversionFactorA = 0
Millimetre.ConversionFactorB = 1000
Millimetre.Symbol = "mm"
Millimetre IsUnitForQuantity LengthQuantity
Unit:Micrometre
Micrometre.ConversionFactorA = 0
Micrometre.ConversionFactorB = 1000000
Micrometre.Symbol = "µm"
Micrometre IsUnitForQuantity LengthQuantity
Unit:Nanometre
Nanometre.ConversionFactorA = 0
Nanometre.ConversionFactorB = 999999999.9999999
Nanometre.Symbol = "nm"
Nanometre IsUnitForQuantity LengthQuantity
Unit:Aangstroem
Aangstroem.ConversionFactorA = 0
Aangstroem.ConversionFactorB = 10000000000
Aangstroem.Symbol = "Å"
Aangstroem IsUnitForQuantity LengthQuantity
Unit:Picometre
Picometre.ConversionFactorA = 0
Picometre.ConversionFactorB = 1000000000000
Picometre.Symbol = "pm"
Picometre IsUnitForQuantity LengthQuantity
Unit:Decametre
Decametre.ConversionFactorA = 0
Decametre.ConversionFactorB = 0.1
Decametre.Symbol = "dam"
Decametre IsUnitForQuantity LengthQuantity
Unit:Hectometre
Hectometre.ConversionFactorA = 0
Hectometre.ConversionFactorB = 0.01
Hectometre.Symbol = "hm"
Hectometre IsUnitForQuantity LengthQuantity
Unit:Kilometre
Kilometre.ConversionFactorA = 0
Kilometre.ConversionFactorB = 0.001
Kilometre.Symbol = "km"
Kilometre IsUnitForQuantity LengthQuantity
Unit:AstronomicalUnit
AstronomicalUnit.ConversionFactorA = 0
AstronomicalUnit.ConversionFactorB = 6.684587122268445E-12
AstronomicalUnit.Symbol = "au"
AstronomicalUnit IsUnitForQuantity LengthQuantity
Unit:LightYear
LightYear.ConversionFactorA = 0
LightYear.ConversionFactorB = 1.0570008340246154E-16
LightYear.Symbol = "ly"
LightYear IsUnitForQuantity LengthQuantity
Unit:Parsec
Parsec.ConversionFactorA = 0
Parsec.ConversionFactorB = 3.240779289444365E-17
Parsec.Symbol = "pc"
Parsec IsUnitForQuantity LengthQuantity
Unit:Foot
Foot.ConversionFactorA = 0
Foot.ConversionFactorB = 3.280839895013124
Foot.Symbol = "ft"
Foot IsUnitForQuantity LengthQuantity
Unit:UsSurveyFoot
UsSurveyFoot.ConversionFactorA = 0
UsSurveyFoot.ConversionFactorB = 3.2808333333333337
UsSurveyFoot.Symbol = "ft"
UsSurveyFoot IsUnitForQuantity LengthQuantity
Unit:Inch
Inch.ConversionFactorA = 0
Inch.ConversionFactorB = 39.37007874015748
Inch.Symbol = "in"
Inch IsUnitForQuantity LengthQuantity
Unit:Yard
Yard.ConversionFactorA = 0
Yard.ConversionFactorB = 1.093613298337708
Yard.Symbol = "yd"
Yard IsUnitForQuantity LengthQuantity
Unit:Fathom
Fathom.ConversionFactorA = 0
Fathom.ConversionFactorB = 0.546806649168854
Fathom.Symbol = "fathom"
Fathom IsUnitForQuantity LengthQuantity
Unit:SurveyorSChain
SurveyorSChain.ConversionFactorA = 0
SurveyorSChain.ConversionFactorB = 0.04970969537898672
SurveyorSChain.Symbol = "chain"
SurveyorSChain IsUnitForQuantity LengthQuantity
Unit:Mile
Mile.ConversionFactorA = 0
Mile.ConversionFactorB = 0.000621371192237334
Mile.Symbol = "mi"
Mile IsUnitForQuantity LengthQuantity
Unit:InternationalNauticalMile
InternationalNauticalMile.ConversionFactorA = 0
InternationalNauticalMile.ConversionFactorB = 0.0005399568034557236
InternationalNauticalMile.Symbol = "nmi"
InternationalNauticalMile IsUnitForQuantity LengthQuantity
Unit:UkNauticalMile
UkNauticalMile.ConversionFactorA = 0
UkNauticalMile.ConversionFactorB = 0.0005396118248376849
UkNauticalMile.Symbol = "UK nmi"
UkNauticalMile IsUnitForQuantity LengthQuantity
Unit:ScandinavianMile
ScandinavianMile.ConversionFactorA = 0
ScandinavianMile.ConversionFactorB = 0.0001
ScandinavianMile.Symbol = "mil"
ScandinavianMile IsUnitForQuantity LengthQuantity
Unit:InchPer32
InchPer32.ConversionFactorA = 0
InchPer32.ConversionFactorB = 1259.8425196850394
InchPer32.Symbol = "in/32"
InchPer32 IsUnitForQuantity LengthQuantity
Unit:Mil
Mil.ConversionFactorA = 0
Mil.ConversionFactorB = 39370.07874015748
Mil.Symbol = "mil"
Mil IsUnitForQuantity LengthQuantity
Unit:Thou
Thou.ConversionFactorA = 0
Thou.ConversionFactorB = 39370.07874015748
Thou.Symbol = "thou"
Thou IsUnitForQuantity LengthQuantity
Unit:Hand
Hand.ConversionFactorA = 0
Hand.ConversionFactorB = 9.84251968503937
Hand.Symbol = "hand"
Hand IsUnitForQuantity LengthQuantity
Unit:Furlong
Furlong.ConversionFactorA = 0
Furlong.ConversionFactorB = 0.004970969537898672
Furlong.Symbol = "furlong"
Furlong IsUnitForQuantity LengthQuantity
```
## LuminousIntensityQuantity <!-- NOUN -->
- Display name: LuminousIntensity
- Parent class: Quantity
- Specialization: 
  - J = 1
- Description: 
Luminous intensity is the measure of the amount of visible light emitted by a source in a particular direction.
The dimension of luminous intensity is:
$$[J]$$.

The SI unit for **luminous intensity** is: candela with the associated unit label $cd$

- Examples: 
``` dwis
Quantity:LuminousIntensityQuantity
LuminousIntensityQuantity.J = 1
Unit:Candela
Candela.ConversionFactorA = 0
Candela.ConversionFactorB = 1
Candela.Symbol = "cd"
Candela IsUnitForQuantity LuminousIntensityQuantity
LuminousIntensityQuantity HasSIUnit Candela
Unit:LumenPerSteradian
LumenPerSteradian.ConversionFactorA = 0
LumenPerSteradian.ConversionFactorB = 1
LumenPerSteradian.Symbol = "lm/st"
LumenPerSteradian IsUnitForQuantity LuminousIntensityQuantity
Unit:Millicandela
Millicandela.ConversionFactorA = 0
Millicandela.ConversionFactorB = 1000
Millicandela.Symbol = "mcd"
Millicandela IsUnitForQuantity LuminousIntensityQuantity
Unit:Kilocandela
Kilocandela.ConversionFactorA = 0
Kilocandela.ConversionFactorB = 0.001
Kilocandela.Symbol = "kcd"
Kilocandela IsUnitForQuantity LuminousIntensityQuantity
Unit:Hefnerkerze
Hefnerkerze.ConversionFactorA = 0
Hefnerkerze.ConversionFactorB = 1.0869565217391304
Hefnerkerze.Symbol = "hefnerkerze"
Hefnerkerze IsUnitForQuantity LuminousIntensityQuantity
Unit:InternationalCandle
InternationalCandle.ConversionFactorA = 0
InternationalCandle.ConversionFactorB = 0.9803921568627451
InternationalCandle.Symbol = "int. candle"
InternationalCandle IsUnitForQuantity LuminousIntensityQuantity
Unit:DecimalCandle
DecimalCandle.ConversionFactorA = 0
DecimalCandle.ConversionFactorB = 1
DecimalCandle.Symbol = "dec. candle"
DecimalCandle IsUnitForQuantity LuminousIntensityQuantity
Unit:BerlinerLichteinheit
BerlinerLichteinheit.ConversionFactorA = 0
BerlinerLichteinheit.ConversionFactorB = 1.0869565217391304
BerlinerLichteinheit.Symbol = "berliner lichteinheit"
BerlinerLichteinheit IsUnitForQuantity LuminousIntensityQuantity
Unit:DvwgCandle
DvwgCandle.ConversionFactorA = 0
DvwgCandle.ConversionFactorB = 0.9354186934071691
DvwgCandle.Symbol = "DVWG candle"
DvwgCandle IsUnitForQuantity LuminousIntensityQuantity
Unit:Violle
Violle.ConversionFactorA = 0
Violle.ConversionFactorB = 0.016666666666666666
Violle.Symbol = "violle"
Violle IsUnitForQuantity LuminousIntensityQuantity
Unit:Carcel
Carcel.ConversionFactorA = 0
Carcel.ConversionFactorB = 0.1026694045174538
Carcel.Symbol = "carcel"
Carcel IsUnitForQuantity LuminousIntensityQuantity
```
## MagneticFluxDensityQuantity <!-- NOUN -->
- Display name: MagneticFluxDensity
- Parent class: Quantity
- Specialization: 
  - M = 1
  - T = -2
  - I = -1
- Description: 
Magnetic flux density is the measure of the strength of a magnetic field per unit area through which the magnetic flux passes. It indicates how concentrated the magnetic field is.
The dimension of magnetic flux density is:
$$[MI^{-1}T^{-2}]$$.

The SI unit for **magnetic flux density** is: tesla with the associated unit label $T$

- Examples: 
``` dwis
Quantity:MagneticFluxDensityQuantity
MagneticFluxDensityQuantity.M = 1
MagneticFluxDensityQuantity.T = -2
MagneticFluxDensityQuantity.I = -1
Unit:Tesla
Tesla.ConversionFactorA = 0
Tesla.ConversionFactorB = 1
Tesla.Symbol = "T"
Tesla IsUnitForQuantity MagneticFluxDensityQuantity
MagneticFluxDensityQuantity HasSIUnit Tesla
Unit:Gauss
Gauss.ConversionFactorA = 0
Gauss.ConversionFactorB = 10000
Gauss.Symbol = "G"
Gauss IsUnitForQuantity MagneticFluxDensityQuantity
Unit:Milligauss
Milligauss.ConversionFactorA = 0
Milligauss.ConversionFactorB = 10000000
Milligauss.Symbol = "mG"
Milligauss IsUnitForQuantity MagneticFluxDensityQuantity
Unit:Millitesla
Millitesla.ConversionFactorA = 0
Millitesla.ConversionFactorB = 1000
Millitesla.Symbol = "mT"
Millitesla IsUnitForQuantity MagneticFluxDensityQuantity
Unit:Microtesla
Microtesla.ConversionFactorA = 0
Microtesla.ConversionFactorB = 1000000
Microtesla.Symbol = "µT"
Microtesla IsUnitForQuantity MagneticFluxDensityQuantity
Unit:Nanotesla
Nanotesla.ConversionFactorA = 0
Nanotesla.ConversionFactorB = 999999999.9999999
Nanotesla.Symbol = "nT"
Nanotesla IsUnitForQuantity MagneticFluxDensityQuantity
Unit:MaxwellPerSquareCentimetre
MaxwellPerSquareCentimetre.ConversionFactorA = 0
MaxwellPerSquareCentimetre.ConversionFactorB = 0.0001
MaxwellPerSquareCentimetre.Symbol = "Mx/cm²"
MaxwellPerSquareCentimetre IsUnitForQuantity MagneticFluxDensityQuantity
Unit:WeberPerSquareMetre
WeberPerSquareMetre.ConversionFactorA = 0
WeberPerSquareMetre.ConversionFactorB = 1
WeberPerSquareMetre.Symbol = "Wb/m²"
WeberPerSquareMetre IsUnitForQuantity MagneticFluxDensityQuantity
```
## MagneticFluxQuantity <!-- NOUN -->
- Display name: MagneticFlux
- Parent class: Quantity
- Specialization: 
  - L = 2
  - M = 1
  - T = -2
  - I = -1
- Description: 
Magnetic flux is the measure of the total magnetic field passing through a given area. It quantifies the strength and distribution of a magnetic field over a surface.
The dimension of magnetic flux is:
$$[L^{2}MI^{-1}T^{-2}]$$.

The SI unit for **magnetic flux** is: weber with the associated unit label $Wb$

- Examples: 
``` dwis
Quantity:MagneticFluxQuantity
MagneticFluxQuantity.L = 2
MagneticFluxQuantity.M = 1
MagneticFluxQuantity.T = -2
MagneticFluxQuantity.I = -1
Unit:Weber
Weber.ConversionFactorA = 0
Weber.ConversionFactorB = 1
Weber.Symbol = "Wb"
Weber IsUnitForQuantity MagneticFluxQuantity
MagneticFluxQuantity HasSIUnit Weber
Unit:Milliweber
Milliweber.ConversionFactorA = 0
Milliweber.ConversionFactorB = 1000
Milliweber.Symbol = "mWb"
Milliweber IsUnitForQuantity MagneticFluxQuantity
Unit:Microweber
Microweber.ConversionFactorA = 0
Microweber.ConversionFactorB = 1000000
Microweber.Symbol = "µWb"
Microweber IsUnitForQuantity MagneticFluxQuantity
Unit:VoltSecond
VoltSecond.ConversionFactorA = 0
VoltSecond.ConversionFactorB = 1
VoltSecond.Symbol = "V•s"
VoltSecond IsUnitForQuantity MagneticFluxQuantity
Unit:UnitPole
UnitPole.ConversionFactorA = 0
UnitPole.ConversionFactorB = 795774715459476.8
UnitPole.Symbol = "unit pole"
UnitPole IsUnitForQuantity MagneticFluxQuantity
Unit:Megaline
Megaline.ConversionFactorA = 0
Megaline.ConversionFactorB = 100
Megaline.Symbol = "megaline"
Megaline IsUnitForQuantity MagneticFluxQuantity
Unit:Kiloline
Kiloline.ConversionFactorA = 0
Kiloline.ConversionFactorB = 99999.99999999999
Kiloline.Symbol = "kiloline"
Kiloline IsUnitForQuantity MagneticFluxQuantity
Unit:Line
Line.ConversionFactorA = 0
Line.ConversionFactorB = 100000000
Line.Symbol = "line"
Line IsUnitForQuantity MagneticFluxQuantity
Unit:Maxwell
Maxwell.ConversionFactorA = 0
Maxwell.ConversionFactorB = 100000000
Maxwell.Symbol = "Mx"
Maxwell IsUnitForQuantity MagneticFluxQuantity
Unit:TeslaSquareMetre
TeslaSquareMetre.ConversionFactorA = 0
TeslaSquareMetre.ConversionFactorB = 1
TeslaSquareMetre.Symbol = "T•m²"
TeslaSquareMetre IsUnitForQuantity MagneticFluxQuantity
Unit:TeslaSquareCentimetre
TeslaSquareCentimetre.ConversionFactorA = 0
TeslaSquareCentimetre.ConversionFactorB = 10000
TeslaSquareCentimetre.Symbol = "T•cm²"
TeslaSquareCentimetre IsUnitForQuantity MagneticFluxQuantity
Unit:GaussSquareCentimetre
GaussSquareCentimetre.ConversionFactorA = 0
GaussSquareCentimetre.ConversionFactorB = 99999999.99999999
GaussSquareCentimetre.Symbol = "G•cm²"
GaussSquareCentimetre IsUnitForQuantity MagneticFluxQuantity
Unit:MagneticFluxQuantum
MagneticFluxQuantum.ConversionFactorA = 0
MagneticFluxQuantum.ConversionFactorB = 483597848416983.56
MagneticFluxQuantum.Symbol = "mag flux quant"
MagneticFluxQuantum IsUnitForQuantity MagneticFluxQuantity
```
## MassGradientPerLengthQuantity <!-- NOUN -->
- Display name: MassGradientPerLength
- Parent class: Quantity
- Specialization: 
  - L = -1
  - M = 1
- Description: 
A mass gradient per length is the first derivative of a mass compared to a distance: $\frac{dm}{ds}$, where $m$ is a mass and $s$ is a distance.
The dimension of mass gradient per length is:
$$[ML^{-1}]$$.

The SI unit for **mass gradient per length** is: kilogram per metre with the associated unit label $\frac{kg}{m}$

- Examples: 
``` dwis
Quantity:MassGradientPerLengthQuantity
MassGradientPerLengthQuantity.L = -1
MassGradientPerLengthQuantity.M = 1
Unit:KilogramPerMetre
KilogramPerMetre.ConversionFactorA = 0
KilogramPerMetre.ConversionFactorB = 1
KilogramPerMetre.Symbol = "kg/m"
KilogramPerMetre IsUnitForQuantity MassGradientPerLengthQuantity
MassGradientPerLengthQuantity HasSIUnit KilogramPerMetre
Unit:PoundPerFoot
PoundPerFoot.ConversionFactorA = 0
PoundPerFoot.ConversionFactorB = 0.6719689751395067
PoundPerFoot.Symbol = "lb/ft"
PoundPerFoot IsUnitForQuantity MassGradientPerLengthQuantity
Unit:GramPerMetre
GramPerMetre.ConversionFactorA = 0
GramPerMetre.ConversionFactorB = 1000
GramPerMetre.Symbol = "g/m"
GramPerMetre IsUnitForQuantity MassGradientPerLengthQuantity
```
## MassRateQuantity <!-- NOUN -->
- Display name: MassRate
- Parent class: Quantity
- Specialization: 
  - M = 1
  - T = -1
- Description: 
A mass rate is the time derivative of a mass: $\frac{dm}{dt}$, where $m$ is a mass and $t$ is time.
The dimension of mass rate is:
$$[MT^{-1}]$$.

The SI unit for **mass rate** is: kilogram per second with the associated unit label $\frac{kg}{s}$

- Examples: 
``` dwis
Quantity:MassRateQuantity
MassRateQuantity.M = 1
MassRateQuantity.T = -1
Unit:KilogramPerSecond
KilogramPerSecond.ConversionFactorA = 0
KilogramPerSecond.ConversionFactorB = 1
KilogramPerSecond.Symbol = "kg/s"
KilogramPerSecond IsUnitForQuantity MassRateQuantity
MassRateQuantity HasSIUnit KilogramPerSecond
Unit:KilogramPerMinute
KilogramPerMinute.ConversionFactorA = 0
KilogramPerMinute.ConversionFactorB = 60
KilogramPerMinute.Symbol = "kg/min"
KilogramPerMinute IsUnitForQuantity MassRateQuantity
Unit:KilogramPerHour
KilogramPerHour.ConversionFactorA = 0
KilogramPerHour.ConversionFactorB = 3600
KilogramPerHour.Symbol = "kg/h"
KilogramPerHour IsUnitForQuantity MassRateQuantity
Unit:KilogramPerYear
KilogramPerYear.ConversionFactorA = 0
KilogramPerYear.ConversionFactorB = 31557600
KilogramPerYear.Symbol = "kg/y"
KilogramPerYear IsUnitForQuantity MassRateQuantity
Unit:PoundPerSecond
PoundPerSecond.ConversionFactorA = 0
PoundPerSecond.ConversionFactorB = 2.2046226218487757
PoundPerSecond.Symbol = "lb/s"
PoundPerSecond IsUnitForQuantity MassRateQuantity
Unit:PoundPerMinute
PoundPerMinute.ConversionFactorA = 0
PoundPerMinute.ConversionFactorB = 132.27735731092653
PoundPerMinute.Symbol = "lb/min"
PoundPerMinute IsUnitForQuantity MassRateQuantity
Unit:PoundPerHour
PoundPerHour.ConversionFactorA = 0
PoundPerHour.ConversionFactorB = 7936.6414386555925
PoundPerHour.Symbol = "lb/h"
PoundPerHour IsUnitForQuantity MassRateQuantity
Unit:PoundPerYear
PoundPerYear.ConversionFactorA = 0
PoundPerYear.ConversionFactorB = 69572598.85125493
PoundPerYear.Symbol = "lb/y"
PoundPerYear IsUnitForQuantity MassRateQuantity
```
## MaterialStrengthQuantity <!-- NOUN -->
- Display name: MaterialStrength
- Parent class: Quantity
- Specialization: 
  - L = -1
  - M = 1
  - T = -2
- Description: 
Material strength refers to the ability of a material to withstand an applied force or load without failing or deforming. It measures how much stress a material can endure before it breaks, bends, or permanently deforms, often categorized into types like tensile, compressive, and shear strength.
The dimension of material strength is:
$$[ML^{-1}T^{-2}]$$.

The SI unit for **material strength** is: pascal with the associated unit label $Pa$

- Examples: 
``` dwis
Quantity:MaterialStrengthQuantity
MaterialStrengthQuantity.L = -1
MaterialStrengthQuantity.M = 1
MaterialStrengthQuantity.T = -2
Unit:Pascal
Pascal.ConversionFactorA = 0
Pascal.ConversionFactorB = 1
Pascal.Symbol = "Pa"
Pascal IsUnitForQuantity MaterialStrengthQuantity
MaterialStrengthQuantity HasSIUnit Pascal
Unit:Megapascal
Megapascal.ConversionFactorA = 0
Megapascal.ConversionFactorB = 1E-06
Megapascal.Symbol = "MPa"
Megapascal IsUnitForQuantity MaterialStrengthQuantity
Unit:Gigapascal
Gigapascal.ConversionFactorA = 0
Gigapascal.ConversionFactorB = 1E-09
Gigapascal.Symbol = "GPa"
Gigapascal IsUnitForQuantity MaterialStrengthQuantity
Unit:Psi
Psi.ConversionFactorA = 0
Psi.ConversionFactorB = 0.00014503773773020924
Psi.Symbol = "psi"
Psi IsUnitForQuantity MaterialStrengthQuantity
Unit:PoundPer100SquareFoot
PoundPer100SquareFoot.ConversionFactorA = 0
PoundPer100SquareFoot.ConversionFactorB = 2.0885434233150124
PoundPer100SquareFoot.Symbol = "lbf/100ft²"
PoundPer100SquareFoot IsUnitForQuantity MaterialStrengthQuantity
Unit:MegapoundPerSquareInch
MegapoundPerSquareInch.ConversionFactorA = 0
MegapoundPerSquareInch.ConversionFactorB = 1.4503773773020922E-10
MegapoundPerSquareInch.Symbol = "Mpsi"
MegapoundPerSquareInch IsUnitForQuantity MaterialStrengthQuantity
```
## PorousMediumPermeabilityQuantity <!-- NOUN -->
- Display name: PorousMediumPermeability
- Parent class: Quantity
- Specialization: 
  - L = 2
- Description: 
The permeability is a property of porous medium that quantifies its ability to allow fluids to pass through it.
The dimension of porous medium permeability is:
$$[L^{2}]$$.

The SI unit for **porous medium permeability** is: square metre with the associated unit label $m^{2}$

- Examples: 
``` dwis
Quantity:PorousMediumPermeabilityQuantity
PorousMediumPermeabilityQuantity.L = 2
Unit:SquareMetre
SquareMetre.ConversionFactorA = 0
SquareMetre.ConversionFactorB = 1
SquareMetre.Symbol = "m²"
SquareMetre IsUnitForQuantity PorousMediumPermeabilityQuantity
PorousMediumPermeabilityQuantity HasSIUnit SquareMetre
Unit:Darcy
Darcy.ConversionFactorA = 0
Darcy.ConversionFactorB = 1013250000000
Darcy.Symbol = "D"
Darcy IsUnitForQuantity PorousMediumPermeabilityQuantity
Unit:Millidarcy
Millidarcy.ConversionFactorA = 0
Millidarcy.ConversionFactorB = 1013250000000000.1
Millidarcy.Symbol = "mD"
Millidarcy IsUnitForQuantity PorousMediumPermeabilityQuantity
Unit:Microdarcy
Microdarcy.ConversionFactorA = 0
Microdarcy.ConversionFactorB = 1.01325E+18
Microdarcy.Symbol = "µD"
Microdarcy IsUnitForQuantity PorousMediumPermeabilityQuantity
Unit:Nanodarcy
Nanodarcy.ConversionFactorA = 0
Nanodarcy.ConversionFactorB = 1.01325E+21
Nanodarcy.Symbol = "nD"
Nanodarcy IsUnitForQuantity PorousMediumPermeabilityQuantity
```
## PlaneAngleQuantity <!-- NOUN -->
- Display name: PlaneAngle
- Parent class: Quantity
- Specialization: 
  - Theta = 1
- Description: 
A plane angle is the angle formed between two intersecting lines or planes in a two-dimensional or three-dimensional space.
The dimension of plane angle is:
$$[{\theta}]$$.

The SI unit for **plane angle** is: radian with the associated unit label $rad$

- Examples: 
``` dwis
Quantity:PlaneAngleQuantity
PlaneAngleQuantity.Theta = 1
Unit:Radian
Radian.ConversionFactorA = 0
Radian.ConversionFactorB = 1
Radian.Symbol = "rad"
Radian IsUnitForQuantity PlaneAngleQuantity
PlaneAngleQuantity HasSIUnit Radian
Unit:Milliradian
Milliradian.ConversionFactorA = 0
Milliradian.ConversionFactorB = 1000
Milliradian.Symbol = "mrad"
Milliradian IsUnitForQuantity PlaneAngleQuantity
Unit:Degree
Degree.ConversionFactorA = 0
Degree.ConversionFactorB = 57.29577951308232
Degree.Symbol = "°"
Degree IsUnitForQuantity PlaneAngleQuantity
Unit:Grad
Grad.ConversionFactorA = 0
Grad.ConversionFactorB = 63.66197723675813
Grad.Symbol = "grad"
Grad IsUnitForQuantity PlaneAngleQuantity
Unit:Gon
Gon.ConversionFactorA = 0
Gon.ConversionFactorB = 63.66197723675813
Gon.Symbol = "gon"
Gon IsUnitForQuantity PlaneAngleQuantity
Unit:Circle
Circle.ConversionFactorA = 0
Circle.ConversionFactorB = 0.15915494309189535
Circle.Symbol = "circle"
Circle IsUnitForQuantity PlaneAngleQuantity
Unit:Revolution
Revolution.ConversionFactorA = 0
Revolution.ConversionFactorB = 0.15915494309189535
Revolution.Symbol = "revolution"
Revolution IsUnitForQuantity PlaneAngleQuantity
Unit:Quadrant
Quadrant.ConversionFactorA = 0
Quadrant.ConversionFactorB = 0.6366197723675814
Quadrant.Symbol = "quadrant"
Quadrant IsUnitForQuantity PlaneAngleQuantity
Unit:Sextant
Sextant.ConversionFactorA = 0
Sextant.ConversionFactorB = 0.954929658551372
Sextant.Symbol = "sextant"
Sextant IsUnitForQuantity PlaneAngleQuantity
Unit:Octant
Octant.ConversionFactorA = 0
Octant.ConversionFactorB = 1.2732395447351628
Octant.Symbol = "octant"
Octant IsUnitForQuantity PlaneAngleQuantity
Unit:ArcMinute
ArcMinute.ConversionFactorA = 0
ArcMinute.ConversionFactorB = 3437.746770784939
ArcMinute.Symbol = "'"
ArcMinute IsUnitForQuantity PlaneAngleQuantity
Unit:ArcSecond
ArcSecond.ConversionFactorA = 0
ArcSecond.ConversionFactorB = 206264.80624709636
ArcSecond.Symbol = """
ArcSecond IsUnitForQuantity PlaneAngleQuantity
```
## PowerQuantity <!-- NOUN -->
- Display name: Power
- Parent class: Quantity
- Specialization: 
  - L = 2
  - M = 1
  - T = -3
- Description: 
Power is the rate at which work is done or energy is transferred over time.
The dimension of power is:
$$[L^{2}MT^{-3}]$$.

The SI unit for **power** is: watt with the associated unit label $W$

- Examples: 
``` dwis
Quantity:PowerQuantity
PowerQuantity.L = 2
PowerQuantity.M = 1
PowerQuantity.T = -3
Unit:Watt
Watt.ConversionFactorA = 0
Watt.ConversionFactorB = 1
Watt.Symbol = "W"
Watt IsUnitForQuantity PowerQuantity
PowerQuantity HasSIUnit Watt
Unit:Decawatt
Decawatt.ConversionFactorA = 0
Decawatt.ConversionFactorB = 0.1
Decawatt.Symbol = "daW"
Decawatt IsUnitForQuantity PowerQuantity
Unit:Hectowatt
Hectowatt.ConversionFactorA = 0
Hectowatt.ConversionFactorB = 0.01
Hectowatt.Symbol = "hW"
Hectowatt IsUnitForQuantity PowerQuantity
Unit:Kilowatt
Kilowatt.ConversionFactorA = 0
Kilowatt.ConversionFactorB = 0.001
Kilowatt.Symbol = "kW"
Kilowatt IsUnitForQuantity PowerQuantity
Unit:Megawatt
Megawatt.ConversionFactorA = 0
Megawatt.ConversionFactorB = 1E-06
Megawatt.Symbol = "MW"
Megawatt IsUnitForQuantity PowerQuantity
Unit:Gigawatt
Gigawatt.ConversionFactorA = 0
Gigawatt.ConversionFactorB = 1E-09
Gigawatt.Symbol = "GW"
Gigawatt IsUnitForQuantity PowerQuantity
Unit:Terawatt
Terawatt.ConversionFactorA = 0
Terawatt.ConversionFactorB = 1E-12
Terawatt.Symbol = "TW"
Terawatt IsUnitForQuantity PowerQuantity
Unit:Petawatt
Petawatt.ConversionFactorA = 0
Petawatt.ConversionFactorB = 1E-15
Petawatt.Symbol = "PW"
Petawatt IsUnitForQuantity PowerQuantity
Unit:Exawatt
Exawatt.ConversionFactorA = 0
Exawatt.ConversionFactorB = 1E-18
Exawatt.Symbol = "EW"
Exawatt IsUnitForQuantity PowerQuantity
Unit:Deciwatt
Deciwatt.ConversionFactorA = 0
Deciwatt.ConversionFactorB = 10
Deciwatt.Symbol = "dW"
Deciwatt IsUnitForQuantity PowerQuantity
Unit:Centiwatt
Centiwatt.ConversionFactorA = 0
Centiwatt.ConversionFactorB = 100
Centiwatt.Symbol = "cW"
Centiwatt IsUnitForQuantity PowerQuantity
Unit:Milliwatt
Milliwatt.ConversionFactorA = 0
Milliwatt.ConversionFactorB = 1000
Milliwatt.Symbol = "mW"
Milliwatt IsUnitForQuantity PowerQuantity
Unit:Microwatt
Microwatt.ConversionFactorA = 0
Microwatt.ConversionFactorB = 1000000
Microwatt.Symbol = "µW"
Microwatt IsUnitForQuantity PowerQuantity
Unit:Nanowatt
Nanowatt.ConversionFactorA = 0
Nanowatt.ConversionFactorB = 999999999.9999999
Nanowatt.Symbol = "nW"
Nanowatt IsUnitForQuantity PowerQuantity
Unit:Picowatt
Picowatt.ConversionFactorA = 0
Picowatt.ConversionFactorB = 1000000000000
Picowatt.Symbol = "pW"
Picowatt IsUnitForQuantity PowerQuantity
Unit:Femtowatt
Femtowatt.ConversionFactorA = 0
Femtowatt.ConversionFactorB = 999999999999999.9
Femtowatt.Symbol = "fW"
Femtowatt IsUnitForQuantity PowerQuantity
Unit:Attowatt
Attowatt.ConversionFactorA = 0
Attowatt.ConversionFactorB = 9.999999999999999E+17
Attowatt.Symbol = "aW"
Attowatt IsUnitForQuantity PowerQuantity
```
## PressureGradientPerLengthQuantity <!-- NOUN -->
- Display name: PressureGradientPerLength
- Parent class: Quantity
- Specialization: 
  - L = -2
  - M = 1
  - T = -2
- Description: 
A pressure gradient per length is the first derivative of a pressure compared to a distance: $\frac{dp}{ds}$, where $p$ is a pressure and $s$ is a distance.
The dimension of pressure gradient per length is:
$$[ML^{-2}T^{-2}]$$.

The SI unit for **pressure gradient per length** is: pascal per metre with the associated unit label $\frac{Pa}{m}$

- Examples: 
``` dwis
Quantity:PressureGradientPerLengthQuantity
PressureGradientPerLengthQuantity.L = -2
PressureGradientPerLengthQuantity.M = 1
PressureGradientPerLengthQuantity.T = -2
Unit:PascalPerMetre
PascalPerMetre.ConversionFactorA = 0
PascalPerMetre.ConversionFactorB = 1
PascalPerMetre.Symbol = "Pa/m"
PascalPerMetre IsUnitForQuantity PressureGradientPerLengthQuantity
PressureGradientPerLengthQuantity HasSIUnit PascalPerMetre
Unit:BarPerMetre
BarPerMetre.ConversionFactorA = 0
BarPerMetre.ConversionFactorB = 1E-05
BarPerMetre.Symbol = "bar/m"
BarPerMetre IsUnitForQuantity PressureGradientPerLengthQuantity
Unit:PsiPerMetre
PsiPerMetre.ConversionFactorA = 0
PsiPerMetre.ConversionFactorB = 0.00014503773773020924
PsiPerMetre.Symbol = "psi/m"
PsiPerMetre IsUnitForQuantity PressureGradientPerLengthQuantity
Unit:PsiPerFoot
PsiPerFoot.ConversionFactorA = 0
PsiPerFoot.ConversionFactorB = 4.4207502460167764E-05
PsiPerFoot.Symbol = "psi/ft"
PsiPerFoot IsUnitForQuantity PressureGradientPerLengthQuantity
```
## PressureLossConstantQuantity <!-- NOUN -->
- Display name: PressureLossConstant
- Parent class: Quantity
- Specialization: 
  - L = 4
- Description: 
The pressure loss constant is a parameter used to quantify the resistance to flow in a system, such as a pipe or more complex tubulars, which leads to a reduction in pressure. It helps in calculating the pressure drop due to friction or other factors in fluid dynamics.
The dimension of pressure loss constant is:
$$[L^{4}]$$.

The SI unit for **pressure loss constant** is: pressure loss constant SI with the associated unit label $(\frac{m^{3}}{s})^{2} \cdot \frac{(\frac{kg}{m^{3}})}{Pa}$

- Examples: 
``` dwis
Quantity:PressureLossConstantQuantity
PressureLossConstantQuantity.L = 4
Unit:PressureLossConstantSi
PressureLossConstantSi.ConversionFactorA = 0
PressureLossConstantSi.ConversionFactorB = 1
PressureLossConstantSi.Symbol = "(m³/s)²•(kg/m³)/Pa"
PressureLossConstantSi IsUnitForQuantity PressureLossConstantQuantity
PressureLossConstantQuantity HasSIUnit PressureLossConstantSi
Unit:PressureLossConstantMetric
PressureLossConstantMetric.ConversionFactorA = 0
PressureLossConstantMetric.ConversionFactorB = 360010080282.2479
PressureLossConstantMetric.Symbol = "(l/min)²•sg/bar"
PressureLossConstantMetric IsUnitForQuantity PressureLossConstantQuantity
Unit:PressureLossConstantUk
PressureLossConstantUk.ConversionFactorA = 0
PressureLossConstantUk.ConversionFactorB = 12036984846.853645
PressureLossConstantUk.Symbol = "gpmuk²•ppguk/psi"
PressureLossConstantUk IsUnitForQuantity PressureLossConstantQuantity
Unit:PressureLossConstantUs
PressureLossConstantUs.ConversionFactorA = 0
PressureLossConstantUs.ConversionFactorB = 14455816055.131952
PressureLossConstantUs.Symbol = "gpmus²•ppgus/psi"
PressureLossConstantUs IsUnitForQuantity PressureLossConstantQuantity
```
## PressureQuantity <!-- NOUN -->
- Display name: Pressure
- Parent class: Quantity
- Specialization: 
  - L = -1
  - M = 1
  - T = -2
- Description: 
Pressure is the force applied per unit area on a surface.
The dimension of pressure is:
$$[ML^{-1}T^{-2}]$$.

The SI unit for **pressure** is: pascal with the associated unit label $Pa$

- Examples: 
``` dwis
Quantity:PressureQuantity
PressureQuantity.L = -1
PressureQuantity.M = 1
PressureQuantity.T = -2
Unit:Pascal
Pascal.ConversionFactorA = 0
Pascal.ConversionFactorB = 1
Pascal.Symbol = "Pa"
Pascal IsUnitForQuantity PressureQuantity
PressureQuantity HasSIUnit Pascal
Unit:Kilopascal
Kilopascal.ConversionFactorA = 0
Kilopascal.ConversionFactorB = 0.001
Kilopascal.Symbol = "KPa"
Kilopascal IsUnitForQuantity PressureQuantity
Unit:Bar
Bar.ConversionFactorA = 0
Bar.ConversionFactorB = 1E-05
Bar.Symbol = "bar"
Bar IsUnitForQuantity PressureQuantity
Unit:Millibar
Millibar.ConversionFactorA = 0
Millibar.ConversionFactorB = 0.01
Millibar.Symbol = "mbar"
Millibar IsUnitForQuantity PressureQuantity
Unit:Microbar
Microbar.ConversionFactorA = 0
Microbar.ConversionFactorB = 10
Microbar.Symbol = "µbar"
Microbar IsUnitForQuantity PressureQuantity
Unit:PoundPerSquareInch
PoundPerSquareInch.ConversionFactorA = 0
PoundPerSquareInch.ConversionFactorB = 0.00014503773773020924
PoundPerSquareInch.Symbol = "psi"
PoundPerSquareInch IsUnitForQuantity PressureQuantity
Unit:PoundPer100SquareFoot
PoundPer100SquareFoot.ConversionFactorA = 0
PoundPer100SquareFoot.ConversionFactorB = 2.0885434233150124
PoundPer100SquareFoot.Symbol = "lbf/100ft²"
PoundPer100SquareFoot IsUnitForQuantity PressureQuantity
Unit:KilopoundPerSquareInch
KilopoundPerSquareInch.ConversionFactorA = 0
KilopoundPerSquareInch.ConversionFactorB = 1.4503773773020924E-07
KilopoundPerSquareInch.Symbol = "ksi"
KilopoundPerSquareInch IsUnitForQuantity PressureQuantity
Unit:StandardAtmosphere
StandardAtmosphere.ConversionFactorA = 0
StandardAtmosphere.ConversionFactorB = 9.869232667160129E-06
StandardAtmosphere.Symbol = "atm"
StandardAtmosphere IsUnitForQuantity PressureQuantity
Unit:PoundPerSquareFoot
PoundPerSquareFoot.ConversionFactorA = 0
PoundPerSquareFoot.ConversionFactorB = 0.020885434233150126
PoundPerSquareFoot.Symbol = "lb/ft²"
PoundPerSquareFoot IsUnitForQuantity PressureQuantity
Unit:Megapascal
Megapascal.ConversionFactorA = 0
Megapascal.ConversionFactorB = 1E-06
Megapascal.Symbol = "MPa"
Megapascal IsUnitForQuantity PressureQuantity
Unit:Gigapascal
Gigapascal.ConversionFactorA = 0
Gigapascal.ConversionFactorB = 1E-09
Gigapascal.Symbol = "GPa"
Gigapascal IsUnitForQuantity PressureQuantity
Unit:NewtonPerSquareMetre
NewtonPerSquareMetre.ConversionFactorA = 0
NewtonPerSquareMetre.ConversionFactorB = 1
NewtonPerSquareMetre.Symbol = "N/m²"
NewtonPerSquareMetre IsUnitForQuantity PressureQuantity
Unit:NewtonPerSquareCentimetre
NewtonPerSquareCentimetre.ConversionFactorA = 0
NewtonPerSquareCentimetre.ConversionFactorB = 0.0001
NewtonPerSquareCentimetre.Symbol = "N/cm²"
NewtonPerSquareCentimetre IsUnitForQuantity PressureQuantity
Unit:NewtonPerSquareMillimetre
NewtonPerSquareMillimetre.ConversionFactorA = 0
NewtonPerSquareMillimetre.ConversionFactorB = 1E-06
NewtonPerSquareMillimetre.Symbol = "N/mm²"
NewtonPerSquareMillimetre IsUnitForQuantity PressureQuantity
Unit:KilonewtonPerSquareMetre
KilonewtonPerSquareMetre.ConversionFactorA = 0
KilonewtonPerSquareMetre.ConversionFactorB = 0.001
KilonewtonPerSquareMetre.Symbol = "kN/m²"
KilonewtonPerSquareMetre IsUnitForQuantity PressureQuantity
Unit:MegapoundPerSquareInch
MegapoundPerSquareInch.ConversionFactorA = 0
MegapoundPerSquareInch.ConversionFactorB = 1.4503773773020922E-10
MegapoundPerSquareInch.Symbol = "Mpsi"
MegapoundPerSquareInch IsUnitForQuantity PressureQuantity
Unit:Torr
Torr.ConversionFactorA = 0
Torr.ConversionFactorB = 0.007500616827041697
Torr.Symbol = "Torr"
Torr IsUnitForQuantity PressureQuantity
Unit:CentimetreMercuryAtZeroDegreeCelsius
CentimetreMercuryAtZeroDegreeCelsius.ConversionFactorA = 0
CentimetreMercuryAtZeroDegreeCelsius.ConversionFactorB = 0.0007500615758456563
CentimetreMercuryAtZeroDegreeCelsius.Symbol = "cm Hg 0°C"
CentimetreMercuryAtZeroDegreeCelsius IsUnitForQuantity PressureQuantity
Unit:MillimetreMercuryAtZeroDegreeCelsius
MillimetreMercuryAtZeroDegreeCelsius.ConversionFactorA = 0
MillimetreMercuryAtZeroDegreeCelsius.ConversionFactorB = 0.007500615758456563
MillimetreMercuryAtZeroDegreeCelsius.Symbol = "mm Hg 0°C"
MillimetreMercuryAtZeroDegreeCelsius IsUnitForQuantity PressureQuantity
Unit:InchMercuryAt32DegreeFahrenheit
InchMercuryAt32DegreeFahrenheit.ConversionFactorA = 0
InchMercuryAt32DegreeFahrenheit.ConversionFactorB = 3386.3890000000006
InchMercuryAt32DegreeFahrenheit.Symbol = "in Hg 32°F"
InchMercuryAt32DegreeFahrenheit IsUnitForQuantity PressureQuantity
Unit:InchMercuryAt60DegreeFahrenheit
InchMercuryAt60DegreeFahrenheit.ConversionFactorA = 0
InchMercuryAt60DegreeFahrenheit.ConversionFactorB = 3376.85
InchMercuryAt60DegreeFahrenheit.Symbol = "in Hg 60°F"
InchMercuryAt60DegreeFahrenheit IsUnitForQuantity PressureQuantity
Unit:CentimetreWaterAt4DegreeCelsius
CentimetreWaterAt4DegreeCelsius.ConversionFactorA = 0
CentimetreWaterAt4DegreeCelsius.ConversionFactorB = 0.010104429276573386
CentimetreWaterAt4DegreeCelsius.Symbol = "cm Aq 4°C"
CentimetreWaterAt4DegreeCelsius IsUnitForQuantity PressureQuantity
Unit:MillimetreWaterAt4DegreeCelsius
MillimetreWaterAt4DegreeCelsius.ConversionFactorA = 0
MillimetreWaterAt4DegreeCelsius.ConversionFactorB = 0.10104429276573387
MillimetreWaterAt4DegreeCelsius.Symbol = "mm Aq 4°C"
MillimetreWaterAt4DegreeCelsius IsUnitForQuantity PressureQuantity
Unit:InchWaterAt4DegreeCelsius
InchWaterAt4DegreeCelsius.ConversionFactorA = 0
InchWaterAt4DegreeCelsius.ConversionFactorB = 0.00401474213311279
InchWaterAt4DegreeCelsius.Symbol = "in Aq 4°C"
InchWaterAt4DegreeCelsius IsUnitForQuantity PressureQuantity
Unit:FootWaterAt4DegreeCelsius
FootWaterAt4DegreeCelsius.ConversionFactorA = 0
FootWaterAt4DegreeCelsius.ConversionFactorB = 0.0003345525543589354
FootWaterAt4DegreeCelsius.Symbol = "ft Aq 4°C"
FootWaterAt4DegreeCelsius IsUnitForQuantity PressureQuantity
Unit:DynePerSquareCentimetre
DynePerSquareCentimetre.ConversionFactorA = 0
DynePerSquareCentimetre.ConversionFactorB = 10
DynePerSquareCentimetre.Symbol = "dyne/cm²"
DynePerSquareCentimetre IsUnitForQuantity PressureQuantity
```
## ProportionQuantity <!-- NOUN -->
- Display name: Proportion
- Parent class: Quantity
- Specialization: 
- Description: 
A proportion is the ratio of two quantities with the same dimension. It represents how one quantity compares to another in relative terms.
A proportion is dimensionless:

- Examples: 
``` dwis
Quantity:ProportionQuantity
Unit:Proportion
Proportion.ConversionFactorA = 0
Proportion.ConversionFactorB = 1
Proportion IsUnitForQuantity ProportionQuantity
ProportionQuantity HasSIUnit Proportion
Unit:Percent
Percent.ConversionFactorA = 0
Percent.ConversionFactorB = 100
Percent.Symbol = "%"
Percent IsUnitForQuantity ProportionQuantity
Unit:PerThousand
PerThousand.ConversionFactorA = 0
PerThousand.ConversionFactorB = 1000
PerThousand.Symbol = "‰"
PerThousand IsUnitForQuantity ProportionQuantity
Unit:PartPerMillion
PartPerMillion.ConversionFactorA = 0
PartPerMillion.ConversionFactorB = 1000000
PartPerMillion.Symbol = "ppm"
PartPerMillion IsUnitForQuantity ProportionQuantity
```
## RandomWalkQuantity <!-- NOUN -->
- Display name: RandomWalk
- Parent class: Quantity
- Specialization: 
  - T = -0,5
  - Theta = 1
- Description: 
A random walk is a mathematical concept describing a path consisting of a series of random steps or movements, where each step's direction or magnitude is determined probabilistically. It is used to model various phenomena in fields like physics, finance, and computer science.
The dimension of random walk is:
$$[{\theta}T^{-0,5}]$$.

The SI unit for **random walk** is: radian per square root second with the associated unit label $\frac{rad}{\sqrt{s}}$

- Examples: 
``` dwis
Quantity:RandomWalkQuantity
RandomWalkQuantity.T = -0.5
RandomWalkQuantity.Theta = 1
Unit:RadianPerSquareRootSecond
RadianPerSquareRootSecond.ConversionFactorA = 0
RadianPerSquareRootSecond.ConversionFactorB = 1
RadianPerSquareRootSecond.Symbol = "rad/√s"
RadianPerSquareRootSecond IsUnitForQuantity RandomWalkQuantity
RandomWalkQuantity HasSIUnit RadianPerSquareRootSecond
Unit:RadianPerSquareRootMinute
RadianPerSquareRootMinute.ConversionFactorA = 0
RadianPerSquareRootMinute.ConversionFactorB = 7.745966692414834
RadianPerSquareRootMinute.Symbol = "rad/√min"
RadianPerSquareRootMinute IsUnitForQuantity RandomWalkQuantity
Unit:RadianPerSquareRootHour
RadianPerSquareRootHour.ConversionFactorA = 0
RadianPerSquareRootHour.ConversionFactorB = 60
RadianPerSquareRootHour.Symbol = "rad/√h"
RadianPerSquareRootHour IsUnitForQuantity RandomWalkQuantity
Unit:RadianPerSquareRootDay
RadianPerSquareRootDay.ConversionFactorA = 0
RadianPerSquareRootDay.ConversionFactorB = 293.9387691339814
RadianPerSquareRootDay.Symbol = "rad/√d"
RadianPerSquareRootDay IsUnitForQuantity RandomWalkQuantity
Unit:DegreePerSquareRootSecond
DegreePerSquareRootSecond.ConversionFactorA = 0
DegreePerSquareRootSecond.ConversionFactorB = 57.29577951308232
DegreePerSquareRootSecond.Symbol = "°/√s"
DegreePerSquareRootSecond IsUnitForQuantity RandomWalkQuantity
Unit:DegreePerSquareRootMinute
DegreePerSquareRootMinute.ConversionFactorA = 0
DegreePerSquareRootMinute.ConversionFactorB = 443.8111997242799
DegreePerSquareRootMinute.Symbol = "°/√min"
DegreePerSquareRootMinute IsUnitForQuantity RandomWalkQuantity
Unit:DegreePerSquareRootHour
DegreePerSquareRootHour.ConversionFactorA = 0
DegreePerSquareRootHour.ConversionFactorB = 3437.746770784939
DegreePerSquareRootHour.Symbol = "°/√h"
DegreePerSquareRootHour IsUnitForQuantity RandomWalkQuantity
Unit:DegreePerSquareRootDay
DegreePerSquareRootDay.ConversionFactorA = 0
DegreePerSquareRootDay.ConversionFactorB = 16841.450906647406
DegreePerSquareRootDay.Symbol = "°/√d"
DegreePerSquareRootDay IsUnitForQuantity RandomWalkQuantity
```
## RelativeTemperatureQuantity <!-- NOUN -->
- Display name: RelativeTemperature
- Parent class: Quantity
- Specialization: 
  - ThT = 1
- Description: 
Relative temperature is a measure of temperature expressed in relation to a reference point or baseline, often used to compare temperature differences rather than absolute values.
The dimension of relative temperature is:
$$[K]$$.

The SI unit for **relative temperature** is: kelvin with the associated unit label $K$

- Examples: 
``` dwis
Quantity:RelativeTemperatureQuantity
RelativeTemperatureQuantity.ThT = 1
Unit:Kelvin
Kelvin.ConversionFactorA = 0
Kelvin.ConversionFactorB = 1
Kelvin.Symbol = "K"
Kelvin IsUnitForQuantity RelativeTemperatureQuantity
RelativeTemperatureQuantity HasSIUnit Kelvin
Unit:RelativeCelsius
RelativeCelsius.ConversionFactorA = 0
RelativeCelsius.ConversionFactorB = 1
RelativeCelsius.Symbol = "°C"
RelativeCelsius IsUnitForQuantity RelativeTemperatureQuantity
Unit:Rankine
Rankine.ConversionFactorA = 0
Rankine.ConversionFactorB = 1.7999999999999998
Rankine.Symbol = "°R"
Rankine IsUnitForQuantity RelativeTemperatureQuantity
```
## ElectricResistivityQuantity <!-- NOUN -->
- Display name: ElectricResistivity
- Parent class: Quantity
- Specialization: 
  - L = 3
  - M = 1
  - T = -3
  - I = -2
- Description: 
Electric resistivity is a material's inherent property that measures how strongly it resists the flow of electric current.
The dimension of resistivity is:
$$[L^{3}MI^{-2}T^{-3}]$$.

The SI unit for **electric resistivity** is: ohm metre with the associated unit label $\Omega \cdot m$

- Examples: 
``` dwis
Quantity:ElectricResistivityQuantity
ElectricResistivityQuantity.L = 3
ElectricResistivityQuantity.M = 1
ElectricResistivityQuantity.T = -3
ElectricResistivityQuantity.I = -2
Unit:OhmMetre
OhmMetre.ConversionFactorA = 0
OhmMetre.ConversionFactorB = 1
OhmMetre.Symbol = "Ω•m"
OhmMetre IsUnitForQuantity ElectricResistivityQuantity
ElectricResistivityQuantity HasSIUnit OhmMetre
Unit:KiloOhmMetre
KiloOhmMetre.ConversionFactorA = 0
KiloOhmMetre.ConversionFactorB = 0.001
KiloOhmMetre.Symbol = "kΩ•m"
KiloOhmMetre IsUnitForQuantity ElectricResistivityQuantity
Unit:MegaOhmMetre
MegaOhmMetre.ConversionFactorA = 0
MegaOhmMetre.ConversionFactorB = 1E-06
MegaOhmMetre.Symbol = "MΩ•m"
MegaOhmMetre IsUnitForQuantity ElectricResistivityQuantity
Unit:GigaOhmMetre
GigaOhmMetre.ConversionFactorA = 0
GigaOhmMetre.ConversionFactorB = 1E-09
GigaOhmMetre.Symbol = "GΩ•m"
GigaOhmMetre IsUnitForQuantity ElectricResistivityQuantity
```
## SolidAngleQuantity <!-- NOUN -->
- Display name: SolidAngle
- Parent class: Quantity
- Specialization: 
  - Omega = 1
- Description: 
A solid angle is a three-dimensional angle that measures the portion of a sphere's surface subtended by an object. It is the 3D equivalent of a planar angle in two dimensions.
The dimension of solid angle is:
$$[{\Omega}]$$.

The SI unit for **solid angle** is: steradian with the associated unit label $sr$

- Examples: 
``` dwis
Quantity:SolidAngleQuantity
SolidAngleQuantity.Omega = 1
Unit:Steradian
Steradian.ConversionFactorA = 0
Steradian.ConversionFactorB = 1
Steradian.Symbol = "sr"
Steradian IsUnitForQuantity SolidAngleQuantity
SolidAngleQuantity HasSIUnit Steradian
Unit:Spat
Spat.ConversionFactorA = 0
Spat.ConversionFactorB = 0.07957747154594767
Spat.Symbol = "spat"
Spat IsUnitForQuantity SolidAngleQuantity
Unit:DegreeSquared
DegreeSquared.ConversionFactorA = 0
DegreeSquared.ConversionFactorB = 3282.806350011744
DegreeSquared.Symbol = "(°)²"
DegreeSquared IsUnitForQuantity SolidAngleQuantity
```
## IsobaricSpecificHeatCapacityQuantity <!-- NOUN -->
- Display name: IsobaricSpecificHeatCapacity
- Parent class: Quantity
- Specialization: 
  - L = 2
  - T = -2
  - ThT = -1
- Description: 
Isobaric specific heat capacity is the amount of heat required to raise the temperature of one unit mass of a substance by one unit of temperature at constant pressure. It indicates how much heat energy a material can store.
The dimension of specific heat capacity is:
$$[L^{2}K^{-1}T^{-2}]$$.

The SI unit for **isobaric specific heat capacity** is: joule per kilogram kelvin with the associated unit label $\frac{J}{kg \cdot K}$

- Examples: 
``` dwis
Quantity:IsobaricSpecificHeatCapacityQuantity
IsobaricSpecificHeatCapacityQuantity.L = 2
IsobaricSpecificHeatCapacityQuantity.T = -2
IsobaricSpecificHeatCapacityQuantity.ThT = -1
Unit:JoulePerKilogramKelvin
JoulePerKilogramKelvin.ConversionFactorA = 0
JoulePerKilogramKelvin.ConversionFactorB = 1
JoulePerKilogramKelvin.Symbol = "J/kg•K"
JoulePerKilogramKelvin IsUnitForQuantity IsobaricSpecificHeatCapacityQuantity
IsobaricSpecificHeatCapacityQuantity HasSIUnit JoulePerKilogramKelvin
Unit:JoulePerGramKelvin
JoulePerGramKelvin.ConversionFactorA = 0
JoulePerGramKelvin.ConversionFactorB = 0.001
JoulePerGramKelvin.Symbol = "J/g•K"
JoulePerGramKelvin IsUnitForQuantity IsobaricSpecificHeatCapacityQuantity
Unit:JoulePerGramDegreeCelsius
JoulePerGramDegreeCelsius.ConversionFactorA = 0
JoulePerGramDegreeCelsius.ConversionFactorB = 0.001
JoulePerGramDegreeCelsius.Symbol = "J/g•°C"
JoulePerGramDegreeCelsius IsUnitForQuantity IsobaricSpecificHeatCapacityQuantity
Unit:CaloriePerGramDegreeCelsius
CaloriePerGramDegreeCelsius.ConversionFactorA = 0
CaloriePerGramDegreeCelsius.ConversionFactorB = 0.0002390057361376673
CaloriePerGramDegreeCelsius.Symbol = "cal/g•°C"
CaloriePerGramDegreeCelsius IsUnitForQuantity IsobaricSpecificHeatCapacityQuantity
Unit:BritishThermalUnitPerPoundDegreeFahrenheit
BritishThermalUnitPerPoundDegreeFahrenheit.ConversionFactorA = 0
BritishThermalUnitPerPoundDegreeFahrenheit.ConversionFactorB = 0.0002390057960934331
BritishThermalUnitPerPoundDegreeFahrenheit.Symbol = "BTU/lb•°F"
BritishThermalUnitPerPoundDegreeFahrenheit IsUnitForQuantity IsobaricSpecificHeatCapacityQuantity
Unit:KilocaloriePerGramDegreeCelsius
KilocaloriePerGramDegreeCelsius.ConversionFactorA = 0
KilocaloriePerGramDegreeCelsius.ConversionFactorB = 2.390057361376673E-07
KilocaloriePerGramDegreeCelsius.Symbol = "Cal/g•°C"
KilocaloriePerGramDegreeCelsius IsUnitForQuantity IsobaricSpecificHeatCapacityQuantity
```
## IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity <!-- NOUN -->
- Display name: IsobaricSpecificHeatCapacityGradientPerTemperature
- Parent class: Quantity
- Specialization: 
  - L = 2
  - T = -2
  - ThT = -2
- Description: 
An isobaric specific heat capacity gradient per temperature is the first derivative of an isobaric specific heat capacity compared to temperature: $\frac{dC_p}{dT}$, where $C_p$ is a isobaric specific heat capacity and $T$ is a temperature.
The dimension of specific heat capacity gradient per temperature is:
$$[L^{2}T^{-2}K^{-2}]$$.

The SI unit for **isobaric specific heat capacity gradient per temperature** is: joule per kilogram squared kelvin with the associated unit label $\frac{J}{kg \cdot K^{2}}$

- Examples: 
``` dwis
Quantity:IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity.L = 2
IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity.T = -2
IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity.ThT = -2
Unit:JoulePerKilogramSquaredKelvin
JoulePerKilogramSquaredKelvin.ConversionFactorA = 0
JoulePerKilogramSquaredKelvin.ConversionFactorB = 1
JoulePerKilogramSquaredKelvin.Symbol = "J/kg•K²"
JoulePerKilogramSquaredKelvin IsUnitForQuantity IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity HasSIUnit JoulePerKilogramSquaredKelvin
Unit:JoulePerGramSquaredKelvin
JoulePerGramSquaredKelvin.ConversionFactorA = 0
JoulePerGramSquaredKelvin.ConversionFactorB = 0.001
JoulePerGramSquaredKelvin.Symbol = "J/g•K²"
JoulePerGramSquaredKelvin IsUnitForQuantity IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
Unit:JoulePerGramDegreeSquaredCelsius
JoulePerGramDegreeSquaredCelsius.ConversionFactorA = 0
JoulePerGramDegreeSquaredCelsius.ConversionFactorB = 0.001
JoulePerGramDegreeSquaredCelsius.Symbol = "J/g•°C²"
JoulePerGramDegreeSquaredCelsius IsUnitForQuantity IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
Unit:CaloriePerGramDegreeSquaredCelsius
CaloriePerGramDegreeSquaredCelsius.ConversionFactorA = 0
CaloriePerGramDegreeSquaredCelsius.ConversionFactorB = 0.0002390057361376673
CaloriePerGramDegreeSquaredCelsius.Symbol = "cal/g•°C²"
CaloriePerGramDegreeSquaredCelsius IsUnitForQuantity IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
Unit:BritishThermalUnitPerPoundSquaredDegreeFahrenheit
BritishThermalUnitPerPoundSquaredDegreeFahrenheit.ConversionFactorA = 0
BritishThermalUnitPerPoundSquaredDegreeFahrenheit.ConversionFactorB = 0.00013278099782968505
BritishThermalUnitPerPoundSquaredDegreeFahrenheit.Symbol = "BTU/lb•°F²"
BritishThermalUnitPerPoundSquaredDegreeFahrenheit IsUnitForQuantity IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity
```
## StressQuantity <!-- NOUN -->
- Display name: Stress
- Parent class: Quantity
- Specialization: 
  - L = -1
  - M = 1
  - T = -2
- Description: 
Stress in a material is the internal force per unit area that arises when the material is subjected to external forces or loads. It reflects how much the material is being compressed, stretched, or sheared.
The dimension of stress is:
$$[ML^{-1}T^{-2}]$$.

The SI unit for **stress** is: pascal with the associated unit label $Pa$

- Examples: 
``` dwis
Quantity:StressQuantity
StressQuantity.L = -1
StressQuantity.M = 1
StressQuantity.T = -2
Unit:Pascal
Pascal.ConversionFactorA = 0
Pascal.ConversionFactorB = 1
Pascal.Symbol = "Pa"
Pascal IsUnitForQuantity StressQuantity
StressQuantity HasSIUnit Pascal
Unit:Kilopascal
Kilopascal.ConversionFactorA = 0
Kilopascal.ConversionFactorB = 0.001
Kilopascal.Symbol = "KPa"
Kilopascal IsUnitForQuantity StressQuantity
Unit:Bar
Bar.ConversionFactorA = 0
Bar.ConversionFactorB = 1E-05
Bar.Symbol = "bar"
Bar IsUnitForQuantity StressQuantity
Unit:Millibar
Millibar.ConversionFactorA = 0
Millibar.ConversionFactorB = 0.01
Millibar.Symbol = "mbar"
Millibar IsUnitForQuantity StressQuantity
Unit:Microbar
Microbar.ConversionFactorA = 0
Microbar.ConversionFactorB = 10
Microbar.Symbol = "µbar"
Microbar IsUnitForQuantity StressQuantity
Unit:PoundPerSquareInch
PoundPerSquareInch.ConversionFactorA = 0
PoundPerSquareInch.ConversionFactorB = 0.00014503773773020924
PoundPerSquareInch.Symbol = "psi"
PoundPerSquareInch IsUnitForQuantity StressQuantity
Unit:PoundPer100SquareFoot
PoundPer100SquareFoot.ConversionFactorA = 0
PoundPer100SquareFoot.ConversionFactorB = 2.0885434233150124
PoundPer100SquareFoot.Symbol = "lbf/100ft²"
PoundPer100SquareFoot IsUnitForQuantity StressQuantity
Unit:KilopoundPerSquareInch
KilopoundPerSquareInch.ConversionFactorA = 0
KilopoundPerSquareInch.ConversionFactorB = 1.4503773773020924E-07
KilopoundPerSquareInch.Symbol = "ksi"
KilopoundPerSquareInch IsUnitForQuantity StressQuantity
Unit:PoundPerSquareFoot
PoundPerSquareFoot.ConversionFactorA = 0
PoundPerSquareFoot.ConversionFactorB = 0.020885434233150126
PoundPerSquareFoot.Symbol = "lb/ft²"
PoundPerSquareFoot IsUnitForQuantity StressQuantity
Unit:Megapascal
Megapascal.ConversionFactorA = 0
Megapascal.ConversionFactorB = 1E-06
Megapascal.Symbol = "MPa"
Megapascal IsUnitForQuantity StressQuantity
Unit:Gigapascal
Gigapascal.ConversionFactorA = 0
Gigapascal.ConversionFactorB = 1E-09
Gigapascal.Symbol = "GPa"
Gigapascal IsUnitForQuantity StressQuantity
Unit:NewtonPerSquareMetre
NewtonPerSquareMetre.ConversionFactorA = 0
NewtonPerSquareMetre.ConversionFactorB = 1
NewtonPerSquareMetre.Symbol = "N/m²"
NewtonPerSquareMetre IsUnitForQuantity StressQuantity
Unit:NewtonPerSquareCentimetre
NewtonPerSquareCentimetre.ConversionFactorA = 0
NewtonPerSquareCentimetre.ConversionFactorB = 0.0001
NewtonPerSquareCentimetre.Symbol = "N/cm²"
NewtonPerSquareCentimetre IsUnitForQuantity StressQuantity
Unit:NewtonPerSquareMillimetre
NewtonPerSquareMillimetre.ConversionFactorA = 0
NewtonPerSquareMillimetre.ConversionFactorB = 1E-06
NewtonPerSquareMillimetre.Symbol = "N/mm²"
NewtonPerSquareMillimetre IsUnitForQuantity StressQuantity
Unit:KilonewtonPerSquareMetre
KilonewtonPerSquareMetre.ConversionFactorA = 0
KilonewtonPerSquareMetre.ConversionFactorB = 0.001
KilonewtonPerSquareMetre.Symbol = "kN/m²"
KilonewtonPerSquareMetre IsUnitForQuantity StressQuantity
Unit:MegapoundPerSquareInch
MegapoundPerSquareInch.ConversionFactorA = 0
MegapoundPerSquareInch.ConversionFactorB = 1.4503773773020922E-10
MegapoundPerSquareInch.Symbol = "Mpsi"
MegapoundPerSquareInch IsUnitForQuantity StressQuantity
Unit:DynePerSquareCentimetre
DynePerSquareCentimetre.ConversionFactorA = 0
DynePerSquareCentimetre.ConversionFactorB = 10
DynePerSquareCentimetre.Symbol = "dyne/cm²"
DynePerSquareCentimetre IsUnitForQuantity StressQuantity
```
## TemperatureGradientPerLengthQuantity <!-- NOUN -->
- Display name: TemperatureGradientPerLength
- Parent class: Quantity
- Specialization: 
  - L = -1
  - ThT = 1
- Description: 
A temperature gradient per lenth is the first derivative of a temperature compared to a distance: $\frac{dT}{ds}$, where $T$ is a temperature and $s$ is a distance.
The dimension of temperature gradient per length is:
$$[KL^{-1}]$$.

The SI unit for **temperature gradient per length** is: kelvin per metre with the associated unit label $\frac{K}{m}$

- Examples: 
``` dwis
Quantity:TemperatureGradientPerLengthQuantity
TemperatureGradientPerLengthQuantity.L = -1
TemperatureGradientPerLengthQuantity.ThT = 1
Unit:KelvinPerMetre
KelvinPerMetre.ConversionFactorA = 0
KelvinPerMetre.ConversionFactorB = 1
KelvinPerMetre.Symbol = "K/m"
KelvinPerMetre IsUnitForQuantity TemperatureGradientPerLengthQuantity
TemperatureGradientPerLengthQuantity HasSIUnit KelvinPerMetre
Unit:CelsiusPerMetre
CelsiusPerMetre.ConversionFactorA = 0
CelsiusPerMetre.ConversionFactorB = 1
CelsiusPerMetre.Symbol = "°C/m"
CelsiusPerMetre IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:CelsiusPer10Metre
CelsiusPer10Metre.ConversionFactorA = 0
CelsiusPer10Metre.ConversionFactorB = 10
CelsiusPer10Metre.Symbol = "°C/10m"
CelsiusPer10Metre IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:CelsiusPer30Metre
CelsiusPer30Metre.ConversionFactorA = 0
CelsiusPer30Metre.ConversionFactorB = 30
CelsiusPer30Metre.Symbol = "°C/30m"
CelsiusPer30Metre IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:CelsiusPer100Metre
CelsiusPer100Metre.ConversionFactorA = 0
CelsiusPer100Metre.ConversionFactorB = 100
CelsiusPer100Metre.Symbol = "°C/100m"
CelsiusPer100Metre IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:CelsiusPerFoot
CelsiusPerFoot.ConversionFactorA = 0
CelsiusPerFoot.ConversionFactorB = 0.30479999999999996
CelsiusPerFoot.Symbol = "°C/ft"
CelsiusPerFoot IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:CelsiusPer30Foot
CelsiusPer30Foot.ConversionFactorA = 0
CelsiusPer30Foot.ConversionFactorB = 9.143999999999998
CelsiusPer30Foot.Symbol = "°C/30ft"
CelsiusPer30Foot IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:CelsiusPer100Foot
CelsiusPer100Foot.ConversionFactorA = 0
CelsiusPer100Foot.ConversionFactorB = 30.479999999999997
CelsiusPer100Foot.Symbol = "°C/100ft"
CelsiusPer100Foot IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:FahrenheitPerFoot
FahrenheitPerFoot.ConversionFactorA = 0
FahrenheitPerFoot.ConversionFactorB = 0.5486399999999999
FahrenheitPerFoot.Symbol = "°F/ft"
FahrenheitPerFoot IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:FahrenheitPer30Foot
FahrenheitPer30Foot.ConversionFactorA = 0
FahrenheitPer30Foot.ConversionFactorB = 16.459199999999996
FahrenheitPer30Foot.Symbol = "°F/30ft"
FahrenheitPer30Foot IsUnitForQuantity TemperatureGradientPerLengthQuantity
Unit:FahrenheitPer100Foot
FahrenheitPer100Foot.ConversionFactorA = 0
FahrenheitPer100Foot.ConversionFactorB = 54.86399999999999
FahrenheitPer100Foot.Symbol = "°F/100ft"
FahrenheitPer100Foot IsUnitForQuantity TemperatureGradientPerLengthQuantity
```
## TemperatureQuantity <!-- NOUN -->
- Display name: Temperature
- Parent class: Quantity
- Specialization: 
  - ThT = 1
- Description: 
Temperature is a measure of the average kinetic energy of particles in a substance, indicating how hot or cold the substance is.
The dimension of temperature is:
$$[K]$$.

The SI unit for **temperature** is: kelvin with the associated unit label $K$

- Examples: 
``` dwis
Quantity:TemperatureQuantity
TemperatureQuantity.ThT = 1
Unit:Kelvin
Kelvin.ConversionFactorA = 0
Kelvin.ConversionFactorB = 1
Kelvin.Symbol = "K"
Kelvin IsUnitForQuantity TemperatureQuantity
TemperatureQuantity HasSIUnit Kelvin
Unit:Celsius
Celsius.ConversionFactorA = -273.15
Celsius.ConversionFactorB = 1
Celsius.Symbol = "°C"
Celsius IsUnitForQuantity TemperatureQuantity
Unit:Fahrenheit
Fahrenheit.ConversionFactorA = -459.67
Fahrenheit.ConversionFactorB = 1.7999999999999998
Fahrenheit.Symbol = "°F"
Fahrenheit IsUnitForQuantity TemperatureQuantity
Unit:Rankine
Rankine.ConversionFactorA = 0
Rankine.ConversionFactorB = 1.7999999999999998
Rankine.Symbol = "°R"
Rankine IsUnitForQuantity TemperatureQuantity
Unit:Réaumur
Réaumur.ConversionFactorA = -218.51999999999998
Réaumur.ConversionFactorB = 0.8
Réaumur.Symbol = "°Ré"
Réaumur IsUnitForQuantity TemperatureQuantity
```
## ThermalConductivityQuantity <!-- NOUN -->
- Display name: ThermalConductivity
- Parent class: Quantity
- Specialization: 
  - L = 1
  - M = 1
  - T = -3
  - ThT = -1
- Description: 
Thermal conductivity is a material's ability to conduct heat. It measures how efficiently heat is transferred through a material when there is a temperature difference.
The dimension of thermal conductivity is:
$$[LMK^{-1}T^{-3}]$$.

The SI unit for **thermal conductivity** is: watt per metre kelvin with the associated unit label $\frac{W}{m \cdot K}$

- Examples: 
``` dwis
Quantity:ThermalConductivityQuantity
ThermalConductivityQuantity.L = 1
ThermalConductivityQuantity.M = 1
ThermalConductivityQuantity.T = -3
ThermalConductivityQuantity.ThT = -1
Unit:WattPerMetreKelvin
WattPerMetreKelvin.ConversionFactorA = 0
WattPerMetreKelvin.ConversionFactorB = 1
WattPerMetreKelvin.Symbol = "W/m•K"
WattPerMetreKelvin IsUnitForQuantity ThermalConductivityQuantity
ThermalConductivityQuantity HasSIUnit WattPerMetreKelvin
Unit:CaloriePerMetreSecondDegreeCelsius
CaloriePerMetreSecondDegreeCelsius.ConversionFactorA = 0
CaloriePerMetreSecondDegreeCelsius.ConversionFactorB = 0.2390057361376673
CaloriePerMetreSecondDegreeCelsius.Symbol = "cal/m•s•°C"
CaloriePerMetreSecondDegreeCelsius IsUnitForQuantity ThermalConductivityQuantity
Unit:CaloriePerCentimetreSecondDegreeCelsius
CaloriePerCentimetreSecondDegreeCelsius.ConversionFactorA = 0
CaloriePerCentimetreSecondDegreeCelsius.ConversionFactorB = 0.002390057361376673
CaloriePerCentimetreSecondDegreeCelsius.Symbol = "cal/cm•s•°C"
CaloriePerCentimetreSecondDegreeCelsius IsUnitForQuantity ThermalConductivityQuantity
Unit:BritishThermalUnitPerHourFootDegreeFahrenheit
BritishThermalUnitPerHourFootDegreeFahrenheit.ConversionFactorA = 0
BritishThermalUnitPerHourFootDegreeFahrenheit.ConversionFactorB = 0.5781761274719021
BritishThermalUnitPerHourFootDegreeFahrenheit.Symbol = "BTU/h•ft•°F"
BritishThermalUnitPerHourFootDegreeFahrenheit IsUnitForQuantity ThermalConductivityQuantity
Unit:BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit.ConversionFactorA = 0
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit.ConversionFactorB = 6.938113529662824
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit.Symbol = "BTU•in/h•ft²•°F"
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit IsUnitForQuantity ThermalConductivityQuantity
```
## ThermalConductivityGradientPerTemperatureQuantity <!-- NOUN -->
- Display name: ThermalConductivityGradientPerTemperature
- Parent class: Quantity
- Specialization: 
  - L = 1
  - M = 1
  - T = -3
  - ThT = -2
- Description: 
A thermal conductivity gradient per temperature is the first derivative of a thermal conductivity compared to temperature: $\frac{dk}{dT}$, where $k$ is a thermal conductivity and $T$ is temperature. 
The dimension of thermal conductivity gradient per temperature is:
$$[LMK^{-2}T^{-3}]$$.

The SI unit for **thermal conductivity gradient per temperature** is: watt per metre kelvin per kelvin with the associated unit label $\frac{(\frac{W}{(m \cdot K)}}{K}$

- Examples: 
``` dwis
Quantity:ThermalConductivityGradientPerTemperatureQuantity
ThermalConductivityGradientPerTemperatureQuantity.L = 1
ThermalConductivityGradientPerTemperatureQuantity.M = 1
ThermalConductivityGradientPerTemperatureQuantity.T = -3
ThermalConductivityGradientPerTemperatureQuantity.ThT = -2
Unit:WattPerMetreKelvinPerKelvin
WattPerMetreKelvinPerKelvin.ConversionFactorA = 0
WattPerMetreKelvinPerKelvin.ConversionFactorB = 1
WattPerMetreKelvinPerKelvin.Symbol = "(W/(m•K))/K"
WattPerMetreKelvinPerKelvin IsUnitForQuantity ThermalConductivityGradientPerTemperatureQuantity
ThermalConductivityGradientPerTemperatureQuantity HasSIUnit WattPerMetreKelvinPerKelvin
Unit:CaloriePerMetreSecondDegreeCelsiusSquared
CaloriePerMetreSecondDegreeCelsiusSquared.ConversionFactorA = 0
CaloriePerMetreSecondDegreeCelsiusSquared.ConversionFactorB = 0.2390057361376673
CaloriePerMetreSecondDegreeCelsiusSquared.Symbol = "Cal/m•s•°C²"
CaloriePerMetreSecondDegreeCelsiusSquared IsUnitForQuantity ThermalConductivityGradientPerTemperatureQuantity
Unit:CaloriePerCentimetreSecondDegreeCelsiusSquared
CaloriePerCentimetreSecondDegreeCelsiusSquared.ConversionFactorA = 0
CaloriePerCentimetreSecondDegreeCelsiusSquared.ConversionFactorB = 0.002390057361376673
CaloriePerCentimetreSecondDegreeCelsiusSquared.Symbol = "Cal/cm•s•°C²"
CaloriePerCentimetreSecondDegreeCelsiusSquared IsUnitForQuantity ThermalConductivityGradientPerTemperatureQuantity
Unit:BritishThermalUnitPerHourFootDegreeFahrenheitSquared
BritishThermalUnitPerHourFootDegreeFahrenheitSquared.ConversionFactorA = 0
BritishThermalUnitPerHourFootDegreeFahrenheitSquared.ConversionFactorB = 0.3212089597066123
BritishThermalUnitPerHourFootDegreeFahrenheitSquared.Symbol = "BTU/h•ft•°F²"
BritishThermalUnitPerHourFootDegreeFahrenheitSquared IsUnitForQuantity ThermalConductivityGradientPerTemperatureQuantity
Unit:BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared.ConversionFactorA = 0
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared.ConversionFactorB = 3.8545075164793468
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared.Symbol = "BTU•in/h•ft²•°F²"
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared IsUnitForQuantity ThermalConductivityGradientPerTemperatureQuantity
```
## TimeQuantity <!-- NOUN -->
- Display name: Time
- Parent class: Quantity
- Specialization: 
  - T = 1
- Description: 
Time is a continuous, measurable progression in which events occur, from the past through the present to the future.
The dimension of time is:
$$[T]$$.

The SI unit for **time** is: second with the associated unit label $s$

- Examples: 
``` dwis
Quantity:TimeQuantity
TimeQuantity.T = 1
Unit:Second
Second.ConversionFactorA = 0
Second.ConversionFactorB = 1
Second.Symbol = "s"
Second IsUnitForQuantity TimeQuantity
TimeQuantity HasSIUnit Second
Unit:Millisecond
Millisecond.ConversionFactorA = 0
Millisecond.ConversionFactorB = 1000
Millisecond.Symbol = "ms"
Millisecond IsUnitForQuantity TimeQuantity
Unit:Microsecond
Microsecond.ConversionFactorA = 0
Microsecond.ConversionFactorB = 1000000
Microsecond.Symbol = "µs"
Microsecond IsUnitForQuantity TimeQuantity
Unit:Shake
Shake.ConversionFactorA = 0
Shake.ConversionFactorB = 100000000
Shake.Symbol = "shake"
Shake IsUnitForQuantity TimeQuantity
Unit:Nanosecond
Nanosecond.ConversionFactorA = 0
Nanosecond.ConversionFactorB = 999999999.9999999
Nanosecond.Symbol = "ns"
Nanosecond IsUnitForQuantity TimeQuantity
Unit:Picosecond
Picosecond.ConversionFactorA = 0
Picosecond.ConversionFactorB = 1000000000000
Picosecond.Symbol = "ps"
Picosecond IsUnitForQuantity TimeQuantity
Unit:Minute
Minute.ConversionFactorA = 0
Minute.ConversionFactorB = 0.016666666666666666
Minute.Symbol = "min"
Minute IsUnitForQuantity TimeQuantity
Unit:Hour
Hour.ConversionFactorA = 0
Hour.ConversionFactorB = 0.0002777777777777778
Hour.Symbol = "h"
Hour IsUnitForQuantity TimeQuantity
Unit:Day
Day.ConversionFactorA = 0
Day.ConversionFactorB = 1.1574074074074073E-05
Day.Symbol = "d"
Day IsUnitForQuantity TimeQuantity
Unit:Week
Week.ConversionFactorA = 0
Week.ConversionFactorB = 1.6534391534391535E-06
Week.Symbol = "week"
Week IsUnitForQuantity TimeQuantity
Unit:Fortnight
Fortnight.ConversionFactorA = 0
Fortnight.ConversionFactorB = 8.267195767195768E-07
Fortnight.Symbol = "14d"
Fortnight IsUnitForQuantity TimeQuantity
Unit:MonthCommon
MonthCommon.ConversionFactorA = 0
MonthCommon.ConversionFactorB = 3.802570537683474E-07
MonthCommon.Symbol = "month common"
MonthCommon IsUnitForQuantity TimeQuantity
Unit:MonthSideral
MonthSideral.ConversionFactorA = 0
MonthSideral.ConversionFactorB = 4.2362265228665E-07
MonthSideral.Symbol = "month sideral"
MonthSideral IsUnitForQuantity TimeQuantity
Unit:MonthSynodic
MonthSynodic.ConversionFactorA = 0
MonthSynodic.ConversionFactorB = 3.9193507729016165E-07
MonthSynodic.Symbol = "month synodic"
MonthSynodic IsUnitForQuantity TimeQuantity
Unit:QuarterCommon
QuarterCommon.ConversionFactorA = 0
QuarterCommon.ConversionFactorB = 1.267523512561158E-07
QuarterCommon.Symbol = "quarter common"
QuarterCommon IsUnitForQuantity TimeQuantity
Unit:YearCommon
YearCommon.ConversionFactorA = 0
YearCommon.ConversionFactorB = 3.1709791983764586E-08
YearCommon.Symbol = "y"
YearCommon IsUnitForQuantity TimeQuantity
Unit:YearAverageGregorian
YearAverageGregorian.ConversionFactorA = 0
YearAverageGregorian.ConversionFactorB = 3.1709791983764586E-08
YearAverageGregorian.Symbol = "year average gregorian"
YearAverageGregorian IsUnitForQuantity TimeQuantity
Unit:YearJulian
YearJulian.ConversionFactorA = 0
YearJulian.ConversionFactorB = 3.168808781402895E-08
YearJulian.Symbol = "year julian"
YearJulian IsUnitForQuantity TimeQuantity
Unit:YearLeap
YearLeap.ConversionFactorA = 0
YearLeap.ConversionFactorB = 3.1623153207852664E-08
YearLeap.Symbol = "year leap"
YearLeap IsUnitForQuantity TimeQuantity
Unit:YearTropical
YearTropical.ConversionFactorA = 0
YearTropical.ConversionFactorB = 3.1688764535078565E-08
YearTropical.Symbol = "year tropical"
YearTropical IsUnitForQuantity TimeQuantity
Unit:Decade
Decade.ConversionFactorA = 0
Decade.ConversionFactorB = 3.168808781402895E-09
Decade.Symbol = "decade"
Decade IsUnitForQuantity TimeQuantity
Unit:Century
Century.ConversionFactorA = 0
Century.ConversionFactorB = 3.168808781402895E-10
Century.Symbol = "century"
Century IsUnitForQuantity TimeQuantity
Unit:Millenia
Millenia.ConversionFactorA = 0
Millenia.ConversionFactorB = 3.168808781402895E-11
Millenia.Symbol = "millenia"
Millenia IsUnitForQuantity TimeQuantity
Unit:MillionYear
MillionYear.ConversionFactorA = 0
MillionYear.ConversionFactorB = 3.168808781402895E-14
MillionYear.Symbol = "My"
MillionYear IsUnitForQuantity TimeQuantity
```
## TorqueGradientPerLengthQuantity <!-- NOUN -->
- Display name: TorqueGradientPerLength
- Parent class: Quantity
- Specialization: 
  - L = 1
  - M = 1
  - T = -2
- Description: 
A torque gradient per length is the first derivative of torque compared to a distance: $\frac{d\tau}{ds}$, where $\tau$ is a torque and $s$ is a distance.
The dimension of torque gradient per length is:
$$[LMT^{-2}]$$.

The SI unit for **torque gradient per length** is: newton metre per metre with the associated unit label $\frac{N \cdot m}{m}$

- Examples: 
``` dwis
Quantity:TorqueGradientPerLengthQuantity
TorqueGradientPerLengthQuantity.L = 1
TorqueGradientPerLengthQuantity.M = 1
TorqueGradientPerLengthQuantity.T = -2
Unit:NewtonMetrePerMetre
NewtonMetrePerMetre.ConversionFactorA = 0
NewtonMetrePerMetre.ConversionFactorB = 1
NewtonMetrePerMetre.Symbol = "N•m/m"
NewtonMetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
TorqueGradientPerLengthQuantity HasSIUnit NewtonMetrePerMetre
Unit:DecanewtonMetrePerMetre
DecanewtonMetrePerMetre.ConversionFactorA = 0
DecanewtonMetrePerMetre.ConversionFactorB = 0.1
DecanewtonMetrePerMetre.Symbol = "daN•m/m"
DecanewtonMetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilogramForceMetrePerMetre
KilogramForceMetrePerMetre.ConversionFactorA = 0
KilogramForceMetrePerMetre.ConversionFactorB = 0.10197162129779283
KilogramForceMetrePerMetre.Symbol = "kgf•m/m"
KilogramForceMetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilonewtonMetrePerMetre
KilonewtonMetrePerMetre.ConversionFactorA = 0
KilonewtonMetrePerMetre.ConversionFactorB = 0.001
KilonewtonMetrePerMetre.Symbol = "kN•m/m"
KilonewtonMetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:FootPoundPerMetre
FootPoundPerMetre.ConversionFactorA = 0
FootPoundPerMetre.ConversionFactorB = 0.7375621492772655
FootPoundPerMetre.Symbol = "ft•lbf/m"
FootPoundPerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilofootPoundPerMetre
KilofootPoundPerMetre.ConversionFactorA = 0
KilofootPoundPerMetre.ConversionFactorB = 0.0007375621492772654
KilofootPoundPerMetre.Symbol = "kft•lbf/m"
KilofootPoundPerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonDecimetrePerMetre
NewtonDecimetrePerMetre.ConversionFactorA = 0
NewtonDecimetrePerMetre.ConversionFactorB = 10
NewtonDecimetrePerMetre.Symbol = "N•dm/m"
NewtonDecimetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonCentimetrePerMetre
NewtonCentimetrePerMetre.ConversionFactorA = 0
NewtonCentimetrePerMetre.ConversionFactorB = 100
NewtonCentimetrePerMetre.Symbol = "N•cm/m"
NewtonCentimetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMillimetrePerMetre
NewtonMillimetrePerMetre.ConversionFactorA = 0
NewtonMillimetrePerMetre.ConversionFactorB = 1000
NewtonMillimetrePerMetre.Symbol = "N•mm/m"
NewtonMillimetrePerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:InchPoundPerMetre
InchPoundPerMetre.ConversionFactorA = 0
InchPoundPerMetre.ConversionFactorB = 8.850745791327185
InchPoundPerMetre.Symbol = "in•lbf/m"
InchPoundPerMetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMetrePerDecimetre
NewtonMetrePerDecimetre.ConversionFactorA = 0
NewtonMetrePerDecimetre.ConversionFactorB = 0.1
NewtonMetrePerDecimetre.Symbol = "N•m/dm"
NewtonMetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:DecanewtonMetrePerDecimetre
DecanewtonMetrePerDecimetre.ConversionFactorA = 0
DecanewtonMetrePerDecimetre.ConversionFactorB = 0.01
DecanewtonMetrePerDecimetre.Symbol = "daN•m/dm"
DecanewtonMetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilogramForceMetrePerDecimetre
KilogramForceMetrePerDecimetre.ConversionFactorA = 0
KilogramForceMetrePerDecimetre.ConversionFactorB = 0.010197162129779284
KilogramForceMetrePerDecimetre.Symbol = "kgf•m/dm"
KilogramForceMetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilonewtonMetrePerDecimetre
KilonewtonMetrePerDecimetre.ConversionFactorA = 0
KilonewtonMetrePerDecimetre.ConversionFactorB = 0.0001
KilonewtonMetrePerDecimetre.Symbol = "kN•m/dm"
KilonewtonMetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:FootPoundPerDecimetre
FootPoundPerDecimetre.ConversionFactorA = 0
FootPoundPerDecimetre.ConversionFactorB = 0.07375621492772655
FootPoundPerDecimetre.Symbol = "ft•lbf/dm"
FootPoundPerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilofootPoundPerDecimetre
KilofootPoundPerDecimetre.ConversionFactorA = 0
KilofootPoundPerDecimetre.ConversionFactorB = 7.375621492772657E-05
KilofootPoundPerDecimetre.Symbol = "kft•lbf/dm"
KilofootPoundPerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonDecimetrePerDecimetre
NewtonDecimetrePerDecimetre.ConversionFactorA = 0
NewtonDecimetrePerDecimetre.ConversionFactorB = 1
NewtonDecimetrePerDecimetre.Symbol = "N•dm/dm"
NewtonDecimetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonCentimetrePerDecimetre
NewtonCentimetrePerDecimetre.ConversionFactorA = 0
NewtonCentimetrePerDecimetre.ConversionFactorB = 10
NewtonCentimetrePerDecimetre.Symbol = "N•cm/dm"
NewtonCentimetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMillimetrePerDecimetre
NewtonMillimetrePerDecimetre.ConversionFactorA = 0
NewtonMillimetrePerDecimetre.ConversionFactorB = 100
NewtonMillimetrePerDecimetre.Symbol = "N•mm/dm"
NewtonMillimetrePerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:InchPoundPerDecimetre
InchPoundPerDecimetre.ConversionFactorA = 0
InchPoundPerDecimetre.ConversionFactorB = 0.8850745791327186
InchPoundPerDecimetre.Symbol = "in•lbf/dm"
InchPoundPerDecimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMetrePerCentimetre
NewtonMetrePerCentimetre.ConversionFactorA = 0
NewtonMetrePerCentimetre.ConversionFactorB = 0.01
NewtonMetrePerCentimetre.Symbol = "N•m/cm"
NewtonMetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:DecanewtonMetrePerCentimetre
DecanewtonMetrePerCentimetre.ConversionFactorA = 0
DecanewtonMetrePerCentimetre.ConversionFactorB = 0.001
DecanewtonMetrePerCentimetre.Symbol = "daN•m/cm"
DecanewtonMetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilogramForceMetrePerCentimetre
KilogramForceMetrePerCentimetre.ConversionFactorA = 0
KilogramForceMetrePerCentimetre.ConversionFactorB = 0.0010197162129779284
KilogramForceMetrePerCentimetre.Symbol = "kgf•m/cm"
KilogramForceMetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilonewtonMetrePerCentimetre
KilonewtonMetrePerCentimetre.ConversionFactorA = 0
KilonewtonMetrePerCentimetre.ConversionFactorB = 1E-05
KilonewtonMetrePerCentimetre.Symbol = "kN•m/cm"
KilonewtonMetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:FootPoundPerCentimetre
FootPoundPerCentimetre.ConversionFactorA = 0
FootPoundPerCentimetre.ConversionFactorB = 0.007375621492772655
FootPoundPerCentimetre.Symbol = "ft•lbf/cm"
FootPoundPerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilofootPoundPerCentimetre
KilofootPoundPerCentimetre.ConversionFactorA = 0
KilofootPoundPerCentimetre.ConversionFactorB = 7.3756214927726565E-06
KilofootPoundPerCentimetre.Symbol = "kft•lbf/cm"
KilofootPoundPerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonDecimetrePerCentimetre
NewtonDecimetrePerCentimetre.ConversionFactorA = 0
NewtonDecimetrePerCentimetre.ConversionFactorB = 0.09999999999999999
NewtonDecimetrePerCentimetre.Symbol = "N•dm/cm"
NewtonDecimetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonCentimetrePerCentimetre
NewtonCentimetrePerCentimetre.ConversionFactorA = 0
NewtonCentimetrePerCentimetre.ConversionFactorB = 1
NewtonCentimetrePerCentimetre.Symbol = "N•cm/cm"
NewtonCentimetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMillimetrePerCentimetre
NewtonMillimetrePerCentimetre.ConversionFactorA = 0
NewtonMillimetrePerCentimetre.ConversionFactorB = 10
NewtonMillimetrePerCentimetre.Symbol = "N•mm/cm"
NewtonMillimetrePerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:InchPoundPerCentimetre
InchPoundPerCentimetre.ConversionFactorA = 0
InchPoundPerCentimetre.ConversionFactorB = 0.08850745791327186
InchPoundPerCentimetre.Symbol = "in•lbf/cm"
InchPoundPerCentimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMetrePerMillimetre
NewtonMetrePerMillimetre.ConversionFactorA = 0
NewtonMetrePerMillimetre.ConversionFactorB = 0.001
NewtonMetrePerMillimetre.Symbol = "N•m/mm"
NewtonMetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:DecanewtonMetrePerMillimetre
DecanewtonMetrePerMillimetre.ConversionFactorA = 0
DecanewtonMetrePerMillimetre.ConversionFactorB = 0.0001
DecanewtonMetrePerMillimetre.Symbol = "daN•m/mm"
DecanewtonMetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilogramForceMetrePerMillimetre
KilogramForceMetrePerMillimetre.ConversionFactorA = 0
KilogramForceMetrePerMillimetre.ConversionFactorB = 0.00010197162129779284
KilogramForceMetrePerMillimetre.Symbol = "kgf•m/mm"
KilogramForceMetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilonewtonMetrePerMillimetre
KilonewtonMetrePerMillimetre.ConversionFactorA = 0
KilonewtonMetrePerMillimetre.ConversionFactorB = 1E-06
KilonewtonMetrePerMillimetre.Symbol = "kN•m/mm"
KilonewtonMetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:FootPoundPerMillimetre
FootPoundPerMillimetre.ConversionFactorA = 0
FootPoundPerMillimetre.ConversionFactorB = 0.0007375621492772656
FootPoundPerMillimetre.Symbol = "ft•lbf/mm"
FootPoundPerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilofootPoundPerMillimetre
KilofootPoundPerMillimetre.ConversionFactorA = 0
KilofootPoundPerMillimetre.ConversionFactorB = 7.375621492772656E-07
KilofootPoundPerMillimetre.Symbol = "kft•lbf/mm"
KilofootPoundPerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonDecimetrePerMillimetre
NewtonDecimetrePerMillimetre.ConversionFactorA = 0
NewtonDecimetrePerMillimetre.ConversionFactorB = 0.01
NewtonDecimetrePerMillimetre.Symbol = "N•dm/mm"
NewtonDecimetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonCentimetrePerMillimetre
NewtonCentimetrePerMillimetre.ConversionFactorA = 0
NewtonCentimetrePerMillimetre.ConversionFactorB = 0.1
NewtonCentimetrePerMillimetre.Symbol = "N•cm/mm"
NewtonCentimetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMillimetrePerMillimetre
NewtonMillimetrePerMillimetre.ConversionFactorA = 0
NewtonMillimetrePerMillimetre.ConversionFactorB = 1
NewtonMillimetrePerMillimetre.Symbol = "N•mm/mm"
NewtonMillimetrePerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:InchPoundPerMillimetre
InchPoundPerMillimetre.ConversionFactorA = 0
InchPoundPerMillimetre.ConversionFactorB = 0.008850745791327186
InchPoundPerMillimetre.Symbol = "in•lbf/mm"
InchPoundPerMillimetre IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMetrePerFoot
NewtonMetrePerFoot.ConversionFactorA = 0
NewtonMetrePerFoot.ConversionFactorB = 0.30479999999999996
NewtonMetrePerFoot.Symbol = "N•m/ft"
NewtonMetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:DecanewtonMetrePerFoot
DecanewtonMetrePerFoot.ConversionFactorA = 0
DecanewtonMetrePerFoot.ConversionFactorB = 0.030479999999999997
DecanewtonMetrePerFoot.Symbol = "daN•m/ft"
DecanewtonMetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilogramForceMetrePerFoot
KilogramForceMetrePerFoot.ConversionFactorA = 0
KilogramForceMetrePerFoot.ConversionFactorB = 0.03108095017156725
KilogramForceMetrePerFoot.Symbol = "kgf•m/ft"
KilogramForceMetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilonewtonMetrePerFoot
KilonewtonMetrePerFoot.ConversionFactorA = 0
KilonewtonMetrePerFoot.ConversionFactorB = 0.0003048
KilonewtonMetrePerFoot.Symbol = "kN•m/ft"
KilonewtonMetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:FootPoundPerFoot
FootPoundPerFoot.ConversionFactorA = 0
FootPoundPerFoot.ConversionFactorB = 0.2248089430997105
FootPoundPerFoot.Symbol = "ft•lbf/ft"
FootPoundPerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilofootPoundPerFoot
KilofootPoundPerFoot.ConversionFactorA = 0
KilofootPoundPerFoot.ConversionFactorB = 0.00022480894309971053
KilofootPoundPerFoot.Symbol = "kft•lbf/ft"
KilofootPoundPerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonDecimetrePerFoot
NewtonDecimetrePerFoot.ConversionFactorA = 0
NewtonDecimetrePerFoot.ConversionFactorB = 3.0479999999999996
NewtonDecimetrePerFoot.Symbol = "N•dm/ft"
NewtonDecimetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonCentimetrePerFoot
NewtonCentimetrePerFoot.ConversionFactorA = 0
NewtonCentimetrePerFoot.ConversionFactorB = 30.479999999999997
NewtonCentimetrePerFoot.Symbol = "N•cm/ft"
NewtonCentimetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMillimetrePerFoot
NewtonMillimetrePerFoot.ConversionFactorA = 0
NewtonMillimetrePerFoot.ConversionFactorB = 304.79999999999995
NewtonMillimetrePerFoot.Symbol = "N•mm/ft"
NewtonMillimetrePerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:InchPoundPerFoot
InchPoundPerFoot.ConversionFactorA = 0
InchPoundPerFoot.ConversionFactorB = 2.697707317196526
InchPoundPerFoot.Symbol = "in•lbf/ft"
InchPoundPerFoot IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMetrePerInch
NewtonMetrePerInch.ConversionFactorA = 0
NewtonMetrePerInch.ConversionFactorB = 0.0254
NewtonMetrePerInch.Symbol = "N•m/in"
NewtonMetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:DecanewtonMetrePerInch
DecanewtonMetrePerInch.ConversionFactorA = 0
DecanewtonMetrePerInch.ConversionFactorB = 0.0025399999999999997
DecanewtonMetrePerInch.Symbol = "daN•m/in"
DecanewtonMetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilogramForceMetrePerInch
KilogramForceMetrePerInch.ConversionFactorA = 0
KilogramForceMetrePerInch.ConversionFactorB = 0.0025900791809639378
KilogramForceMetrePerInch.Symbol = "kgf•m/in"
KilogramForceMetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilonewtonMetrePerInch
KilonewtonMetrePerInch.ConversionFactorA = 0
KilonewtonMetrePerInch.ConversionFactorB = 2.5399999999999997E-05
KilonewtonMetrePerInch.Symbol = "kN•m/in"
KilonewtonMetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:FootPoundPerInch
FootPoundPerInch.ConversionFactorA = 0
FootPoundPerInch.ConversionFactorB = 0.018734078591642542
FootPoundPerInch.Symbol = "ft•lbf/in"
FootPoundPerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:KilofootPoundPerInch
KilofootPoundPerInch.ConversionFactorA = 0
KilofootPoundPerInch.ConversionFactorB = 1.8734078591642546E-05
KilofootPoundPerInch.Symbol = "kft•lbf/in"
KilofootPoundPerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonDecimetrePerInch
NewtonDecimetrePerInch.ConversionFactorA = 0
NewtonDecimetrePerInch.ConversionFactorB = 0.25399999999999995
NewtonDecimetrePerInch.Symbol = "N•dm/in"
NewtonDecimetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonCentimetrePerInch
NewtonCentimetrePerInch.ConversionFactorA = 0
NewtonCentimetrePerInch.ConversionFactorB = 2.54
NewtonCentimetrePerInch.Symbol = "N•cm/in"
NewtonCentimetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:NewtonMillimetrePerInch
NewtonMillimetrePerInch.ConversionFactorA = 0
NewtonMillimetrePerInch.ConversionFactorB = 25.4
NewtonMillimetrePerInch.Symbol = "N•mm/in"
NewtonMillimetrePerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
Unit:InchPoundPerInch
InchPoundPerInch.ConversionFactorA = 0
InchPoundPerInch.ConversionFactorB = 0.2248089430997105
InchPoundPerInch.Symbol = "in•lbf/in"
InchPoundPerInch IsUnitForQuantity TorqueGradientPerLengthQuantity
```
## TorqueQuantity <!-- NOUN -->
- Display name: Torque
- Parent class: Quantity
- Specialization: 
  - L = 2
  - M = 1
  - T = -2
- Description: 
A torque is a measure of the rotational force applied to a body around an axis.
The dimension of torque is:
$$[L^{2}MT^{-2}]$$.

The SI unit for **torque** is: newton metre with the associated unit label $N \cdot m$

- Examples: 
``` dwis
Quantity:TorqueQuantity
TorqueQuantity.L = 2
TorqueQuantity.M = 1
TorqueQuantity.T = -2
Unit:NewtonMetre
NewtonMetre.ConversionFactorA = 0
NewtonMetre.ConversionFactorB = 1
NewtonMetre.Symbol = "N•m"
NewtonMetre IsUnitForQuantity TorqueQuantity
TorqueQuantity HasSIUnit NewtonMetre
Unit:DecanewtonMetre
DecanewtonMetre.ConversionFactorA = 0
DecanewtonMetre.ConversionFactorB = 0.1
DecanewtonMetre.Symbol = "daN•m"
DecanewtonMetre IsUnitForQuantity TorqueQuantity
Unit:KilogramForceMetre
KilogramForceMetre.ConversionFactorA = 0
KilogramForceMetre.ConversionFactorB = 0.10197162129779283
KilogramForceMetre.Symbol = "kgf•m"
KilogramForceMetre IsUnitForQuantity TorqueQuantity
Unit:KilonewtonMetre
KilonewtonMetre.ConversionFactorA = 0
KilonewtonMetre.ConversionFactorB = 0.001
KilonewtonMetre.Symbol = "kN•m"
KilonewtonMetre IsUnitForQuantity TorqueQuantity
Unit:FootPound
FootPound.ConversionFactorA = 0
FootPound.ConversionFactorB = 0.7375621492772655
FootPound.Symbol = "ft•lbf"
FootPound IsUnitForQuantity TorqueQuantity
Unit:KilofootPound
KilofootPound.ConversionFactorA = 0
KilofootPound.ConversionFactorB = 0.0007375621492772656
KilofootPound.Symbol = "kft•lbf"
KilofootPound IsUnitForQuantity TorqueQuantity
Unit:NewtonDecimetre
NewtonDecimetre.ConversionFactorA = 0
NewtonDecimetre.ConversionFactorB = 10
NewtonDecimetre.Symbol = "N•dm"
NewtonDecimetre IsUnitForQuantity TorqueQuantity
Unit:NewtonCentimetre
NewtonCentimetre.ConversionFactorA = 0
NewtonCentimetre.ConversionFactorB = 100
NewtonCentimetre.Symbol = "N•cm"
NewtonCentimetre IsUnitForQuantity TorqueQuantity
Unit:NewtonMillimetre
NewtonMillimetre.ConversionFactorA = 0
NewtonMillimetre.ConversionFactorB = 1000
NewtonMillimetre.Symbol = "N•mm"
NewtonMillimetre IsUnitForQuantity TorqueQuantity
Unit:InchPound
InchPound.ConversionFactorA = 0
InchPound.ConversionFactorB = 8.850745791327185
InchPound.Symbol = "in•lbf"
InchPound IsUnitForQuantity TorqueQuantity
```
## VelocityQuantity <!-- NOUN -->
- Display name: Velocity
- Parent class: Quantity
- Specialization: 
  - L = 1
  - T = -1
- Description: 
A velocity is the time derivative of a position or a displacement: $\frac{dx}{dt}$, where $x$ is a position and $t$ is time.
The dimension of velocity is:
$$[LT^{-1}]$$.

The SI unit for **velocity** is: metre per second with the associated unit label $\frac{m}{s}$

- Examples: 
``` dwis
Quantity:VelocityQuantity
VelocityQuantity.L = 1
VelocityQuantity.T = -1
Unit:MetrePerSecond
MetrePerSecond.ConversionFactorA = 0
MetrePerSecond.ConversionFactorB = 1
MetrePerSecond.Symbol = "m/s"
MetrePerSecond IsUnitForQuantity VelocityQuantity
VelocityQuantity HasSIUnit MetrePerSecond
Unit:MetrePerMinute
MetrePerMinute.ConversionFactorA = 0
MetrePerMinute.ConversionFactorB = 60
MetrePerMinute.Symbol = "m/min"
MetrePerMinute IsUnitForQuantity VelocityQuantity
Unit:CentimetrePerSecond
CentimetrePerSecond.ConversionFactorA = 0
CentimetrePerSecond.ConversionFactorB = 100
CentimetrePerSecond.Symbol = "cm/s"
CentimetrePerSecond IsUnitForQuantity VelocityQuantity
Unit:MetrePerHour
MetrePerHour.ConversionFactorA = 0
MetrePerHour.ConversionFactorB = 3600
MetrePerHour.Symbol = "m/h"
MetrePerHour IsUnitForQuantity VelocityQuantity
Unit:MetrePerDay
MetrePerDay.ConversionFactorA = 0
MetrePerDay.ConversionFactorB = 86400
MetrePerDay.Symbol = "m/d"
MetrePerDay IsUnitForQuantity VelocityQuantity
Unit:FootPerHour
FootPerHour.ConversionFactorA = 0
FootPerHour.ConversionFactorB = 11811.023622047245
FootPerHour.Symbol = "ft/h"
FootPerHour IsUnitForQuantity VelocityQuantity
Unit:FootPerDay
FootPerDay.ConversionFactorA = 0
FootPerDay.ConversionFactorB = 283464.5669291339
FootPerDay.Symbol = "ft/d"
FootPerDay IsUnitForQuantity VelocityQuantity
Unit:FootPerMinute
FootPerMinute.ConversionFactorA = 0
FootPerMinute.ConversionFactorB = 196.85039370078744
FootPerMinute.Symbol = "ft/m"
FootPerMinute IsUnitForQuantity VelocityQuantity
Unit:FootPerSecond
FootPerSecond.ConversionFactorA = 0
FootPerSecond.ConversionFactorB = 3.280839895013124
FootPerSecond.Symbol = "ft/s"
FootPerSecond IsUnitForQuantity VelocityQuantity
Unit:InchPerSecond
InchPerSecond.ConversionFactorA = 0
InchPerSecond.ConversionFactorB = 39.37007874015748
InchPerSecond.Symbol = "in/s"
InchPerSecond IsUnitForQuantity VelocityQuantity
Unit:MilePerHour
MilePerHour.ConversionFactorA = 0
MilePerHour.ConversionFactorB = 2.2369362920544025
MilePerHour.Symbol = "mph"
MilePerHour IsUnitForQuantity VelocityQuantity
Unit:KilometrePerHour
KilometrePerHour.ConversionFactorA = 0
KilometrePerHour.ConversionFactorB = 3.6
KilometrePerHour.Symbol = "km/h"
KilometrePerHour IsUnitForQuantity VelocityQuantity
Unit:KilometrePerMinute
KilometrePerMinute.ConversionFactorA = 0
KilometrePerMinute.ConversionFactorB = 0.06
KilometrePerMinute.Symbol = "km/min"
KilometrePerMinute IsUnitForQuantity VelocityQuantity
Unit:KilometrePerSecond
KilometrePerSecond.ConversionFactorA = 0
KilometrePerSecond.ConversionFactorB = 0.001
KilometrePerSecond.Symbol = "km/s"
KilometrePerSecond IsUnitForQuantity VelocityQuantity
Unit:KilometrePerDay
KilometrePerDay.ConversionFactorA = 0
KilometrePerDay.ConversionFactorB = 86.4
KilometrePerDay.Symbol = "km/d"
KilometrePerDay IsUnitForQuantity VelocityQuantity
Unit:MilePerMinute
MilePerMinute.ConversionFactorA = 0
MilePerMinute.ConversionFactorB = 0.03728227153424004
MilePerMinute.Symbol = "mi/min"
MilePerMinute IsUnitForQuantity VelocityQuantity
Unit:MilePerSecond
MilePerSecond.ConversionFactorA = 0
MilePerSecond.ConversionFactorB = 0.000621371192237334
MilePerSecond.Symbol = "mi/s"
MilePerSecond IsUnitForQuantity VelocityQuantity
Unit:MilePerDay
MilePerDay.ConversionFactorA = 0
MilePerDay.ConversionFactorB = 53.68647100930566
MilePerDay.Symbol = "mi/d"
MilePerDay IsUnitForQuantity VelocityQuantity
Unit:InchPerMinute
InchPerMinute.ConversionFactorA = 0
InchPerMinute.ConversionFactorB = 2362.2047244094488
InchPerMinute.Symbol = "in/min"
InchPerMinute IsUnitForQuantity VelocityQuantity
Unit:InchPerHour
InchPerHour.ConversionFactorA = 0
InchPerHour.ConversionFactorB = 141732.28346456692
InchPerHour.Symbol = "in/h"
InchPerHour IsUnitForQuantity VelocityQuantity
Unit:InchPerDay
InchPerDay.ConversionFactorA = 0
InchPerDay.ConversionFactorB = 3401574.8031496066
InchPerDay.Symbol = "in/d"
InchPerDay IsUnitForQuantity VelocityQuantity
Unit:CentimetrePerMinute
CentimetrePerMinute.ConversionFactorA = 0
CentimetrePerMinute.ConversionFactorB = 6000
CentimetrePerMinute.Symbol = "cm/min"
CentimetrePerMinute IsUnitForQuantity VelocityQuantity
Unit:CentimetrePerHour
CentimetrePerHour.ConversionFactorA = 0
CentimetrePerHour.ConversionFactorB = 360000
CentimetrePerHour.Symbol = "cm/h"
CentimetrePerHour IsUnitForQuantity VelocityQuantity
Unit:CentimetrePerDay
CentimetrePerDay.ConversionFactorA = 0
CentimetrePerDay.ConversionFactorB = 8640000
CentimetrePerDay.Symbol = "cm/d"
CentimetrePerDay IsUnitForQuantity VelocityQuantity
Unit:MillimetrePerSecond
MillimetrePerSecond.ConversionFactorA = 0
MillimetrePerSecond.ConversionFactorB = 1000
MillimetrePerSecond.Symbol = "mm/s"
MillimetrePerSecond IsUnitForQuantity VelocityQuantity
Unit:MillimetrePerMinute
MillimetrePerMinute.ConversionFactorA = 0
MillimetrePerMinute.ConversionFactorB = 60000
MillimetrePerMinute.Symbol = "mm/min"
MillimetrePerMinute IsUnitForQuantity VelocityQuantity
Unit:MillimetrePerHour
MillimetrePerHour.ConversionFactorA = 0
MillimetrePerHour.ConversionFactorB = 3600000
MillimetrePerHour.Symbol = "mm/h"
MillimetrePerHour IsUnitForQuantity VelocityQuantity
Unit:MillimetrePerDay
MillimetrePerDay.ConversionFactorA = 0
MillimetrePerDay.ConversionFactorB = 86400000
MillimetrePerDay.Symbol = "mm/d"
MillimetrePerDay IsUnitForQuantity VelocityQuantity
Unit:DecimetrePerSecond
DecimetrePerSecond.ConversionFactorA = 0
DecimetrePerSecond.ConversionFactorB = 10
DecimetrePerSecond.Symbol = "dm/s"
DecimetrePerSecond IsUnitForQuantity VelocityQuantity
Unit:DecimetrePerMinute
DecimetrePerMinute.ConversionFactorA = 0
DecimetrePerMinute.ConversionFactorB = 600
DecimetrePerMinute.Symbol = "dm/min"
DecimetrePerMinute IsUnitForQuantity VelocityQuantity
Unit:DecimetrePerHour
DecimetrePerHour.ConversionFactorA = 0
DecimetrePerHour.ConversionFactorB = 36000
DecimetrePerHour.Symbol = "dm/h"
DecimetrePerHour IsUnitForQuantity VelocityQuantity
Unit:DecimetrePerDay
DecimetrePerDay.ConversionFactorA = 0
DecimetrePerDay.ConversionFactorB = 864000
DecimetrePerDay.Symbol = "dm/d"
DecimetrePerDay IsUnitForQuantity VelocityQuantity
Unit:FurlongPerFortnight
FurlongPerFortnight.ConversionFactorA = 0
FurlongPerFortnight.ConversionFactorB = 6012.884753042234
FurlongPerFortnight.Symbol = "furlong/14d"
FurlongPerFortnight IsUnitForQuantity VelocityQuantity
```
## VolumeQuantity <!-- NOUN -->
- Display name: Volume
- Parent class: Quantity
- Specialization: 
  - L = 3
- Description: 
A volume is the amount of three-dimensional space occupied by a body.
The dimension of volume is:
$$[L^{3}]$$.

The SI unit for **volume** is: cubic metre with the associated unit label $m^{3}$

- Examples: 
``` dwis
Quantity:VolumeQuantity
VolumeQuantity.L = 3
Unit:CubicMetre
CubicMetre.ConversionFactorA = 0
CubicMetre.ConversionFactorB = 1
CubicMetre.Symbol = "m³"
CubicMetre IsUnitForQuantity VolumeQuantity
VolumeQuantity HasSIUnit CubicMetre
Unit:Litre
Litre.ConversionFactorA = 0
Litre.ConversionFactorB = 1000
Litre.Symbol = "l"
Litre IsUnitForQuantity VolumeQuantity
Unit:Decilitre
Decilitre.ConversionFactorA = 0
Decilitre.ConversionFactorB = 10000
Decilitre.Symbol = "dl"
Decilitre IsUnitForQuantity VolumeQuantity
Unit:Centilitre
Centilitre.ConversionFactorA = 0
Centilitre.ConversionFactorB = 99999.99999999999
Centilitre.Symbol = "cl"
Centilitre IsUnitForQuantity VolumeQuantity
Unit:Millilitre
Millilitre.ConversionFactorA = 0
Millilitre.ConversionFactorB = 1000000
Millilitre.Symbol = "ml"
Millilitre IsUnitForQuantity VolumeQuantity
Unit:UsGallon
UsGallon.ConversionFactorA = 0
UsGallon.ConversionFactorB = 264.17205235814845
UsGallon.Symbol = "US Gal."
UsGallon IsUnitForQuantity VolumeQuantity
Unit:UkGallon
UkGallon.ConversionFactorA = 0
UkGallon.ConversionFactorB = 219.96924829908778
UkGallon.Symbol = "UK Gal."
UkGallon IsUnitForQuantity VolumeQuantity
Unit:Barrel
Barrel.ConversionFactorA = 0
Barrel.ConversionFactorB = 6.289810770432106
Barrel.Symbol = "bbl"
Barrel IsUnitForQuantity VolumeQuantity
Unit:MillionCubicMetre
MillionCubicMetre.ConversionFactorA = 0
MillionCubicMetre.ConversionFactorB = 1E-06
MillionCubicMetre.Symbol = "Mm³"
MillionCubicMetre IsUnitForQuantity VolumeQuantity
Unit:MillionLitre
MillionLitre.ConversionFactorA = 0
MillionLitre.ConversionFactorB = 0.001
MillionLitre.Symbol = "Ml"
MillionLitre IsUnitForQuantity VolumeQuantity
Unit:MillionUkGallon
MillionUkGallon.ConversionFactorA = 0
MillionUkGallon.ConversionFactorB = 0.0002199692482990878
MillionUkGallon.Symbol = "M UK Gal."
MillionUkGallon IsUnitForQuantity VolumeQuantity
Unit:MillionBarrel
MillionBarrel.ConversionFactorA = 0
MillionBarrel.ConversionFactorB = 6.289810770432106E-06
MillionBarrel.Symbol = "Mbbl"
MillionBarrel IsUnitForQuantity VolumeQuantity
Unit:ThousandStandardCubicFoot
ThousandStandardCubicFoot.ConversionFactorA = 0
ThousandStandardCubicFoot.ConversionFactorB = 0.0353146667214886
ThousandStandardCubicFoot.Symbol = "Mscf"
ThousandStandardCubicFoot IsUnitForQuantity VolumeQuantity
Unit:MillionStandardCubicFoot
MillionStandardCubicFoot.ConversionFactorA = 0
MillionStandardCubicFoot.ConversionFactorB = 3.531466672148861E-05
MillionStandardCubicFoot.Symbol = "MMscf"
MillionStandardCubicFoot IsUnitForQuantity VolumeQuantity
Unit:CubicFoot
CubicFoot.ConversionFactorA = 0
CubicFoot.ConversionFactorB = 35.3146667214886
CubicFoot.Symbol = "ft³"
CubicFoot IsUnitForQuantity VolumeQuantity
Unit:CubicInch
CubicInch.ConversionFactorA = 0
CubicInch.ConversionFactorB = 61023.74409473229
CubicInch.Symbol = "in³"
CubicInch IsUnitForQuantity VolumeQuantity
Unit:MillionUsGallon
MillionUsGallon.ConversionFactorA = 0
MillionUsGallon.ConversionFactorB = 0.00026417205235814843
MillionUsGallon.Symbol = "M US Gal."
MillionUsGallon IsUnitForQuantity VolumeQuantity
```
## VolumetricFlowRateOfChangeQuantity <!-- NOUN -->
- Display name: VolumetricFlowRateOfChange
- Parent class: Quantity
- Specialization: 
  - L = 3
  - T = -2
- Description: 
A volumetric flow rate of change is the time derivative of a volumetric flowrate: $\frac{dQ}{dt}$, where $Q$ is a volumetric flowrate and $t$ is time.
The dimension of volumetric flow rate of change is:
$$[L^{3}T^{-2}]$$.

The SI unit for **volumetric flow Rate rate of change** is: cubic metre per second squared with the associated unit label $\frac{m^{3}}{s^{2}}$

- Examples: 
``` dwis
Quantity:VolumetricFlowRateOfChangeQuantity
VolumetricFlowRateOfChangeQuantity.L = 3
VolumetricFlowRateOfChangeQuantity.T = -2
Unit:CubicMetrePerSecondSquared
CubicMetrePerSecondSquared.ConversionFactorA = 0
CubicMetrePerSecondSquared.ConversionFactorB = 1
CubicMetrePerSecondSquared.Symbol = "m³/s²"
CubicMetrePerSecondSquared IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
VolumetricFlowRateOfChangeQuantity HasSIUnit CubicMetrePerSecondSquared
Unit:LitrePerMinuteSquared
LitrePerMinuteSquared.ConversionFactorA = 0
LitrePerMinuteSquared.ConversionFactorB = 3600000
LitrePerMinuteSquared.Symbol = "L/min²"
LitrePerMinuteSquared IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
Unit:LitrePerMinutePerSecond
LitrePerMinutePerSecond.ConversionFactorA = 0
LitrePerMinutePerSecond.ConversionFactorB = 60000
LitrePerMinutePerSecond.Symbol = "L/min/s"
LitrePerMinutePerSecond IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
Unit:LitrePerSecondSquared
LitrePerSecondSquared.ConversionFactorA = 0
LitrePerSecondSquared.ConversionFactorB = 1000
LitrePerSecondSquared.Symbol = "L/s²"
LitrePerSecondSquared IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
Unit:UkGallonPerMinuteSquared
UkGallonPerMinuteSquared.ConversionFactorA = 0
UkGallonPerMinuteSquared.ConversionFactorB = 791889.293876716
UkGallonPerMinuteSquared.Symbol = "UKGal/min²"
UkGallonPerMinuteSquared IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
Unit:UkGallonPerMinutePerSecond
UkGallonPerMinutePerSecond.ConversionFactorA = 0
UkGallonPerMinutePerSecond.ConversionFactorB = 13198.154897945267
UkGallonPerMinutePerSecond.Symbol = "UKGal/min/s"
UkGallonPerMinutePerSecond IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
Unit:UsGallonPerMinuteSquared
UsGallonPerMinuteSquared.ConversionFactorA = 0
UsGallonPerMinuteSquared.ConversionFactorB = 951019.3884893344
UsGallonPerMinuteSquared.Symbol = "USGal/min²"
UsGallonPerMinuteSquared IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
Unit:UsGallonPerMinutePerSecond
UsGallonPerMinutePerSecond.ConversionFactorA = 0
UsGallonPerMinutePerSecond.ConversionFactorB = 15850.323141488907
UsGallonPerMinutePerSecond.Symbol = "USGal/min/s"
UsGallonPerMinutePerSecond IsUnitForQuantity VolumetricFlowRateOfChangeQuantity
```
## VolumetricFlowRateQuantity <!-- NOUN -->
- Display name: VolumetricFlowRate
- Parent class: Quantity
- Specialization: 
  - L = 3
  - T = -1
- Description: 
A volumetric flowrate is the volume of fluid that passes per unit time: $\frac{dV}{dt}$, where $V$ is a volume and $t$ is time.
The dimension of volumetric flowrate is:
$$[L^{3}T^{-1}]$$.

The SI unit for **volumetric flow rate** is: cubic metre per second with the associated unit label $\frac{m^{3}}{s}$

- Examples: 
``` dwis
Quantity:VolumetricFlowRateQuantity
VolumetricFlowRateQuantity.L = 3
VolumetricFlowRateQuantity.T = -1
Unit:CubicMetrePerSecond
CubicMetrePerSecond.ConversionFactorA = 0
CubicMetrePerSecond.ConversionFactorB = 1
CubicMetrePerSecond.Symbol = "m³/s"
CubicMetrePerSecond IsUnitForQuantity VolumetricFlowRateQuantity
VolumetricFlowRateQuantity HasSIUnit CubicMetrePerSecond
Unit:LitrePerSecond
LitrePerSecond.ConversionFactorA = 0
LitrePerSecond.ConversionFactorB = 1000
LitrePerSecond.Symbol = "L/s"
LitrePerSecond IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicFootPerSecond
CubicFootPerSecond.ConversionFactorA = 0
CubicFootPerSecond.ConversionFactorB = 35.3146667214886
CubicFootPerSecond.Symbol = "ft³/s"
CubicFootPerSecond IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UkGallonPerSecond
UkGallonPerSecond.ConversionFactorA = 0
UkGallonPerSecond.ConversionFactorB = 219.96924829908778
UkGallonPerSecond.Symbol = "gpsUK"
UkGallonPerSecond IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UsGallonPerSecond
UsGallonPerSecond.ConversionFactorA = 0
UsGallonPerSecond.ConversionFactorB = 264.17205235814845
UsGallonPerSecond.Symbol = "gpsUS"
UsGallonPerSecond IsUnitForQuantity VolumetricFlowRateQuantity
Unit:BarrelPerSecond
BarrelPerSecond.ConversionFactorA = 0
BarrelPerSecond.ConversionFactorB = 6.289810770432106
BarrelPerSecond.Symbol = "bbl/s"
BarrelPerSecond IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicMetrePerMinute
CubicMetrePerMinute.ConversionFactorA = 0
CubicMetrePerMinute.ConversionFactorB = 60
CubicMetrePerMinute.Symbol = "m³/min"
CubicMetrePerMinute IsUnitForQuantity VolumetricFlowRateQuantity
Unit:LitrePerMinute
LitrePerMinute.ConversionFactorA = 0
LitrePerMinute.ConversionFactorB = 60000
LitrePerMinute.Symbol = "L/min"
LitrePerMinute IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicFootPerMinute
CubicFootPerMinute.ConversionFactorA = 0
CubicFootPerMinute.ConversionFactorB = 2118.880003289316
CubicFootPerMinute.Symbol = "ft³/min"
CubicFootPerMinute IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UkGallonPerMinute
UkGallonPerMinute.ConversionFactorA = 0
UkGallonPerMinute.ConversionFactorB = 13198.154897945267
UkGallonPerMinute.Symbol = "gpmUK"
UkGallonPerMinute IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UsGallonPerMinute
UsGallonPerMinute.ConversionFactorA = 0
UsGallonPerMinute.ConversionFactorB = 15850.323141488907
UsGallonPerMinute.Symbol = "gpmUS"
UsGallonPerMinute IsUnitForQuantity VolumetricFlowRateQuantity
Unit:BarrelPerMinute
BarrelPerMinute.ConversionFactorA = 0
BarrelPerMinute.ConversionFactorB = 377.3886462259263
BarrelPerMinute.Symbol = "bbl/m"
BarrelPerMinute IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicMetrePerHour
CubicMetrePerHour.ConversionFactorA = 0
CubicMetrePerHour.ConversionFactorB = 3600
CubicMetrePerHour.Symbol = "m³/h"
CubicMetrePerHour IsUnitForQuantity VolumetricFlowRateQuantity
Unit:LitrePerHour
LitrePerHour.ConversionFactorA = 0
LitrePerHour.ConversionFactorB = 3600000
LitrePerHour.Symbol = "L/h"
LitrePerHour IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicFootPerHour
CubicFootPerHour.ConversionFactorA = 0
CubicFootPerHour.ConversionFactorB = 127132.80019735897
CubicFootPerHour.Symbol = "ft³/h"
CubicFootPerHour IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UkGallonPerHour
UkGallonPerHour.ConversionFactorA = 0
UkGallonPerHour.ConversionFactorB = 791889.293876716
UkGallonPerHour.Symbol = "gphUK"
UkGallonPerHour IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UsGallonPerHour
UsGallonPerHour.ConversionFactorA = 0
UsGallonPerHour.ConversionFactorB = 951019.3884893344
UsGallonPerHour.Symbol = "gphUS"
UsGallonPerHour IsUnitForQuantity VolumetricFlowRateQuantity
Unit:BarrelPerHour
BarrelPerHour.ConversionFactorA = 0
BarrelPerHour.ConversionFactorB = 22643.31877355558
BarrelPerHour.Symbol = "bbl/h"
BarrelPerHour IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicMetrePerDay
CubicMetrePerDay.ConversionFactorA = 0
CubicMetrePerDay.ConversionFactorB = 86400
CubicMetrePerDay.Symbol = "m³/d"
CubicMetrePerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:MillionCubicMetrePerDay
MillionCubicMetrePerDay.ConversionFactorA = 0
MillionCubicMetrePerDay.ConversionFactorB = 0.0864
MillionCubicMetrePerDay.Symbol = "Mm³/d"
MillionCubicMetrePerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UkGallonPerDay
UkGallonPerDay.ConversionFactorA = 0
UkGallonPerDay.ConversionFactorB = 19005343.053041186
UkGallonPerDay.Symbol = "gpdUK"
UkGallonPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UsGallonPerDay
UsGallonPerDay.ConversionFactorA = 0
UsGallonPerDay.ConversionFactorB = 22824465.323744025
UsGallonPerDay.Symbol = "gpdUS"
UsGallonPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:MillionUkGallonPerDay
MillionUkGallonPerDay.ConversionFactorA = 0
MillionUkGallonPerDay.ConversionFactorB = 19.005343053041184
MillionUkGallonPerDay.Symbol = "MillionUKGallonPerDay"
MillionUkGallonPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:MillionUsGallonPerDay
MillionUsGallonPerDay.ConversionFactorA = 0
MillionUsGallonPerDay.ConversionFactorB = 22.824465323744025
MillionUsGallonPerDay.Symbol = "MillionUSGallonPerDay"
MillionUsGallonPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:LitrePerDay
LitrePerDay.ConversionFactorA = 0
LitrePerDay.ConversionFactorB = 86400000
LitrePerDay.Symbol = "L/d"
LitrePerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:MillionLiterPerDay
MillionLiterPerDay.ConversionFactorA = 0
MillionLiterPerDay.ConversionFactorB = 86.4
MillionLiterPerDay.Symbol = "MillionLiterPerDay"
MillionLiterPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicFootPerDay
CubicFootPerDay.ConversionFactorA = 0
CubicFootPerDay.ConversionFactorB = 3051187.204736615
CubicFootPerDay.Symbol = "ft³/d"
CubicFootPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:ThousandStandardCubicFootPerDay
ThousandStandardCubicFootPerDay.ConversionFactorA = 0
ThousandStandardCubicFootPerDay.ConversionFactorB = 3051.187204736615
ThousandStandardCubicFootPerDay.Symbol = "Mscf/d"
ThousandStandardCubicFootPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:MillionStandardCubicFootPerDay
MillionStandardCubicFootPerDay.ConversionFactorA = 0
MillionStandardCubicFootPerDay.ConversionFactorB = 3.0511872047366158
MillionStandardCubicFootPerDay.Symbol = "MMscf/d"
MillionStandardCubicFootPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:BarrelPerDay
BarrelPerDay.ConversionFactorA = 0
BarrelPerDay.ConversionFactorB = 543439.6505653339
BarrelPerDay.Symbol = "bbl/d"
BarrelPerDay IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicMetrePerYear
CubicMetrePerYear.ConversionFactorA = 0
CubicMetrePerYear.ConversionFactorB = 31557600
CubicMetrePerYear.Symbol = "m³/year"
CubicMetrePerYear IsUnitForQuantity VolumetricFlowRateQuantity
Unit:LitrePerYear
LitrePerYear.ConversionFactorA = 0
LitrePerYear.ConversionFactorB = 31557600000
LitrePerYear.Symbol = "L/year"
LitrePerYear IsUnitForQuantity VolumetricFlowRateQuantity
Unit:CubicFootPerYear
CubicFootPerYear.ConversionFactorA = 0
CubicFootPerYear.ConversionFactorB = 1114446126.5300486
CubicFootPerYear.Symbol = "ft³/year"
CubicFootPerYear IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UkGallonPerYear
UkGallonPerYear.ConversionFactorA = 0
UkGallonPerYear.ConversionFactorB = 6941701550.123293
UkGallonPerYear.Symbol = "gpyUK"
UkGallonPerYear IsUnitForQuantity VolumetricFlowRateQuantity
Unit:UsGallonPerYear
UsGallonPerYear.ConversionFactorA = 0
UsGallonPerYear.ConversionFactorB = 8336635959.497505
UsGallonPerYear.Symbol = "gpyUS"
UsGallonPerYear IsUnitForQuantity VolumetricFlowRateQuantity
Unit:BarrelPerYear
BarrelPerYear.ConversionFactorA = 0
BarrelPerYear.ConversionFactorB = 198491332.36898822
BarrelPerYear.Symbol = "bbl/year"
BarrelPerYear IsUnitForQuantity VolumetricFlowRateQuantity
```
## WaveNumberQuantity <!-- NOUN -->
- Display name: WaveNumber
- Parent class: Quantity
- Specialization: 
  - L = -1
- Description: 
A wave number is the number of wave lengths per unit distance.
The dimension of wave number is:
$$[L^{-1}]$$.

The SI unit for **wave number** is: reciprocal metre with the associated unit label $\frac{1}{m}$

- Examples: 
``` dwis
Quantity:WaveNumberQuantity
WaveNumberQuantity.L = -1
Unit:ReciprocalMetre
ReciprocalMetre.ConversionFactorA = 0
ReciprocalMetre.ConversionFactorB = 1
ReciprocalMetre.Symbol = "1/m"
ReciprocalMetre IsUnitForQuantity WaveNumberQuantity
WaveNumberQuantity HasSIUnit ReciprocalMetre
Unit:ReciprocalDecimetre
ReciprocalDecimetre.ConversionFactorA = 0
ReciprocalDecimetre.ConversionFactorB = 0.1
ReciprocalDecimetre.Symbol = "1/dm"
ReciprocalDecimetre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalCentimetre
ReciprocalCentimetre.ConversionFactorA = 0
ReciprocalCentimetre.ConversionFactorB = 0.01
ReciprocalCentimetre.Symbol = "1/cm"
ReciprocalCentimetre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalMillimetre
ReciprocalMillimetre.ConversionFactorA = 0
ReciprocalMillimetre.ConversionFactorB = 0.001
ReciprocalMillimetre.Symbol = "1/mm"
ReciprocalMillimetre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalMicrometre
ReciprocalMicrometre.ConversionFactorA = 0
ReciprocalMicrometre.ConversionFactorB = 1E-06
ReciprocalMicrometre.Symbol = "1/µm"
ReciprocalMicrometre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalNanometre
ReciprocalNanometre.ConversionFactorA = 0
ReciprocalNanometre.ConversionFactorB = 1E-09
ReciprocalNanometre.Symbol = "1/nm"
ReciprocalNanometre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalAangstroem
ReciprocalAangstroem.ConversionFactorA = 0
ReciprocalAangstroem.ConversionFactorB = 1E-10
ReciprocalAangstroem.Symbol = "1/Å"
ReciprocalAangstroem IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalPicometre
ReciprocalPicometre.ConversionFactorA = 0
ReciprocalPicometre.ConversionFactorB = 1E-12
ReciprocalPicometre.Symbol = "1/pm"
ReciprocalPicometre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalDecametre
ReciprocalDecametre.ConversionFactorA = 0
ReciprocalDecametre.ConversionFactorB = 10
ReciprocalDecametre.Symbol = "1/dam"
ReciprocalDecametre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalHectometre
ReciprocalHectometre.ConversionFactorA = 0
ReciprocalHectometre.ConversionFactorB = 100
ReciprocalHectometre.Symbol = "1/hm"
ReciprocalHectometre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalKilometre
ReciprocalKilometre.ConversionFactorA = 0
ReciprocalKilometre.ConversionFactorB = 1000
ReciprocalKilometre.Symbol = "1/km"
ReciprocalKilometre IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalAstronomicalUnit
ReciprocalAstronomicalUnit.ConversionFactorA = 0
ReciprocalAstronomicalUnit.ConversionFactorB = 149597870700
ReciprocalAstronomicalUnit.Symbol = "1/au"
ReciprocalAstronomicalUnit IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalLightYear
ReciprocalLightYear.ConversionFactorA = 0
ReciprocalLightYear.ConversionFactorB = 9460730472580800
ReciprocalLightYear.Symbol = "1/ly"
ReciprocalLightYear IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalParsec
ReciprocalParsec.ConversionFactorA = 0
ReciprocalParsec.ConversionFactorB = 30856775814913670
ReciprocalParsec.Symbol = "1/pc"
ReciprocalParsec IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalFoot
ReciprocalFoot.ConversionFactorA = 0
ReciprocalFoot.ConversionFactorB = 0.30479999999999996
ReciprocalFoot.Symbol = "1/ft"
ReciprocalFoot IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalUsSurveyFoot
ReciprocalUsSurveyFoot.ConversionFactorA = 0
ReciprocalUsSurveyFoot.ConversionFactorB = 0.3048006096012192
ReciprocalUsSurveyFoot.Symbol = "1/ft"
ReciprocalUsSurveyFoot IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalInch
ReciprocalInch.ConversionFactorA = 0
ReciprocalInch.ConversionFactorB = 0.0254
ReciprocalInch.Symbol = "1/in"
ReciprocalInch IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalYard
ReciprocalYard.ConversionFactorA = 0
ReciprocalYard.ConversionFactorB = 0.9143999999999999
ReciprocalYard.Symbol = "1/yd"
ReciprocalYard IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalFathom
ReciprocalFathom.ConversionFactorA = 0
ReciprocalFathom.ConversionFactorB = 1.8287999999999998
ReciprocalFathom.Symbol = "1/fathom"
ReciprocalFathom IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalSurveyorsChain
ReciprocalSurveyorsChain.ConversionFactorA = 0
ReciprocalSurveyorsChain.ConversionFactorB = 20.116799999999998
ReciprocalSurveyorsChain.Symbol = "1/chain"
ReciprocalSurveyorsChain IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalMile
ReciprocalMile.ConversionFactorA = 0
ReciprocalMile.ConversionFactorB = 1609.3439999999998
ReciprocalMile.Symbol = "1/mi"
ReciprocalMile IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalInternationalNauticalMile
ReciprocalInternationalNauticalMile.ConversionFactorA = 0
ReciprocalInternationalNauticalMile.ConversionFactorB = 1852
ReciprocalInternationalNauticalMile.Symbol = "1/nmi"
ReciprocalInternationalNauticalMile IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalUkNauticalMile
ReciprocalUkNauticalMile.ConversionFactorA = 0
ReciprocalUkNauticalMile.ConversionFactorB = 1853.1839999999997
ReciprocalUkNauticalMile.Symbol = "1/(UK nmi)"
ReciprocalUkNauticalMile IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalScandinavianMile
ReciprocalScandinavianMile.ConversionFactorA = 0
ReciprocalScandinavianMile.ConversionFactorB = 10000
ReciprocalScandinavianMile.Symbol = "1/mil"
ReciprocalScandinavianMile IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalInchPer32
ReciprocalInchPer32.ConversionFactorA = 0
ReciprocalInchPer32.ConversionFactorB = 0.00079375
ReciprocalInchPer32.Symbol = "1/in/32"
ReciprocalInchPer32 IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalMil
ReciprocalMil.ConversionFactorA = 0
ReciprocalMil.ConversionFactorB = 2.54E-05
ReciprocalMil.Symbol = "1/mil"
ReciprocalMil IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalThou
ReciprocalThou.ConversionFactorA = 0
ReciprocalThou.ConversionFactorB = 2.54E-05
ReciprocalThou.Symbol = "1/thou"
ReciprocalThou IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalHand
ReciprocalHand.ConversionFactorA = 0
ReciprocalHand.ConversionFactorB = 0.1016
ReciprocalHand.Symbol = "1/hand"
ReciprocalHand IsUnitForQuantity WaveNumberQuantity
Unit:ReciprocalFurlong
ReciprocalFurlong.ConversionFactorA = 0
ReciprocalFurlong.ConversionFactorB = 201.16799999999998
ReciprocalFurlong.Symbol = "1/furlong"
ReciprocalFurlong IsUnitForQuantity WaveNumberQuantity
```
## MassQuantity <!-- NOUN -->
- Display name: Mass
- Parent class: Quantity
- Specialization: 
  - M = 1
- Description: 
Mass can be experimentally defined as a measure of the body's inertia, meaning the resistance to acceleration (change of velocity) when a net force is applied. The object's mass also determines the strength of its gravitational attraction to other bodies.
The dimension of mass is:
$$[M]$$.

The SI unit for **mass** is: kilogram with the associated unit label $kg$

- Examples: 
``` dwis
Quantity:MassQuantity
MassQuantity.M = 1
Unit:Kilogram
Kilogram.ConversionFactorA = 0
Kilogram.ConversionFactorB = 1
Kilogram.Symbol = "kg"
Kilogram IsUnitForQuantity MassQuantity
MassQuantity HasSIUnit Kilogram
Unit:Hectogram
Hectogram.ConversionFactorA = 0
Hectogram.ConversionFactorB = 10
Hectogram.Symbol = "hg"
Hectogram IsUnitForQuantity MassQuantity
Unit:Decagram
Decagram.ConversionFactorA = 0
Decagram.ConversionFactorB = 100
Decagram.Symbol = "dag"
Decagram IsUnitForQuantity MassQuantity
Unit:Gram
Gram.ConversionFactorA = 0
Gram.ConversionFactorB = 1000
Gram.Symbol = "g"
Gram IsUnitForQuantity MassQuantity
Unit:Centigram
Centigram.ConversionFactorA = 0
Centigram.ConversionFactorB = 10000
Centigram.Symbol = "cg"
Centigram IsUnitForQuantity MassQuantity
Unit:Milligram
Milligram.ConversionFactorA = 0
Milligram.ConversionFactorB = 1000000
Milligram.Symbol = "mg"
Milligram IsUnitForQuantity MassQuantity
Unit:Microgram
Microgram.ConversionFactorA = 0
Microgram.ConversionFactorB = 999999999.9999999
Microgram.Symbol = "µg"
Microgram IsUnitForQuantity MassQuantity
Unit:Nanogram
Nanogram.ConversionFactorA = 0
Nanogram.ConversionFactorB = 1000000000000
Nanogram.Symbol = "ng"
Nanogram IsUnitForQuantity MassQuantity
Unit:AtomMassUnit
AtomMassUnit.ConversionFactorA = 0
AtomMassUnit.ConversionFactorB = 6.022140762081123E+26
AtomMassUnit.Symbol = "u"
AtomMassUnit IsUnitForQuantity MassQuantity
Unit:TonneMetric
TonneMetric.ConversionFactorA = 0
TonneMetric.ConversionFactorB = 0.001
TonneMetric.Symbol = "t"
TonneMetric IsUnitForQuantity MassQuantity
Unit:Kilotonne
Kilotonne.ConversionFactorA = 0
Kilotonne.ConversionFactorB = 1E-06
Kilotonne.Symbol = "kt"
Kilotonne IsUnitForQuantity MassQuantity
Unit:Megatonne
Megatonne.ConversionFactorA = 0
Megatonne.ConversionFactorB = 1E-09
Megatonne.Symbol = "Mt"
Megatonne IsUnitForQuantity MassQuantity
Unit:Gigatonne
Gigatonne.ConversionFactorA = 0
Gigatonne.ConversionFactorB = 1E-12
Gigatonne.Symbol = "Gt"
Gigatonne IsUnitForQuantity MassQuantity
Unit:Pound
Pound.ConversionFactorA = 0
Pound.ConversionFactorB = 2.2046226218487757
Pound.Symbol = "lb"
Pound IsUnitForQuantity MassQuantity
Unit:Kilopound
Kilopound.ConversionFactorA = 0
Kilopound.ConversionFactorB = 0.002204622621848776
Kilopound.Symbol = "klb"
Kilopound IsUnitForQuantity MassQuantity
Unit:Ounce
Ounce.ConversionFactorA = 0
Ounce.ConversionFactorB = 35.27396194958041
Ounce.Symbol = "oz"
Ounce IsUnitForQuantity MassQuantity
Unit:Stone
Stone.ConversionFactorA = 0
Stone.ConversionFactorB = 0.1574730444177697
Stone.Symbol = "st"
Stone IsUnitForQuantity MassQuantity
Unit:TonUk
TonUk.ConversionFactorA = 0
TonUk.ConversionFactorB = 0.0009842065276110606
TonUk.Symbol = "LT"
TonUk IsUnitForQuantity MassQuantity
Unit:TonUs
TonUs.ConversionFactorA = 0
TonUs.ConversionFactorB = 0.001102311310924388
TonUs.Symbol = "ST"
TonUs IsUnitForQuantity MassQuantity
Unit:SolarMass
SolarMass.ConversionFactorA = 0
SolarMass.ConversionFactorB = 5.0291176051105175E-31
SolarMass.Symbol = "M☉"
SolarMass IsUnitForQuantity MassQuantity
Unit:EarthMass
EarthMass.ConversionFactorA = 0
EarthMass.ConversionFactorB = 1.6744248350691536E-25
EarthMass.Symbol = "M🜨"
EarthMass IsUnitForQuantity MassQuantity
Unit:Grain
Grain.ConversionFactorA = 0
Grain.ConversionFactorB = 15432.358352941428
Grain.Symbol = "gr"
Grain IsUnitForQuantity MassQuantity
Unit:HundredWeights
HundredWeights.ConversionFactorA = 0
HundredWeights.ConversionFactorB = 0.022046226218487758
HundredWeights.Symbol = "cwt"
HundredWeights IsUnitForQuantity MassQuantity
```
## EnergyQuantity <!-- NOUN -->
- Display name: Energy
- Parent class: Quantity
- Specialization: 
  - L = 2
  - M = 1
  - T = -2
- Description: 
Energy is the quantitative property that is transferred to a body or to a physical system, recognizable in the performance of work and in the form of heat and light. Energy is a conserved quantity—the law of conservation of energy states that energy can be converted in form, but not created or destroyed; matter and energy may also be converted to one another.
The dimension of energy is:
$$[L^{2}MT^{-2}]$$.

The SI unit for **energy** is: joule with the associated unit label $J$

- Examples: 
``` dwis
Quantity:EnergyQuantity
EnergyQuantity.L = 2
EnergyQuantity.M = 1
EnergyQuantity.T = -2
Unit:Joule
Joule.ConversionFactorA = 0
Joule.ConversionFactorB = 1
Joule.Symbol = "J"
Joule IsUnitForQuantity EnergyQuantity
EnergyQuantity HasSIUnit Joule
Unit:Kilojoule
Kilojoule.ConversionFactorA = 0
Kilojoule.ConversionFactorB = 0.001
Kilojoule.Symbol = "kJ"
Kilojoule IsUnitForQuantity EnergyQuantity
Unit:Megajoule
Megajoule.ConversionFactorA = 0
Megajoule.ConversionFactorB = 1E-06
Megajoule.Symbol = "MJ"
Megajoule IsUnitForQuantity EnergyQuantity
Unit:Gigajoule
Gigajoule.ConversionFactorA = 0
Gigajoule.ConversionFactorB = 1E-09
Gigajoule.Symbol = "GJ"
Gigajoule IsUnitForQuantity EnergyQuantity
Unit:Calorie
Calorie.ConversionFactorA = 0
Calorie.ConversionFactorB = 0.2390057361376673
Calorie.Symbol = "cal"
Calorie IsUnitForQuantity EnergyQuantity
Unit:Kilocalorie
Kilocalorie.ConversionFactorA = 0
Kilocalorie.ConversionFactorB = 0.0002390057361376673
Kilocalorie.Symbol = "Cal"
Kilocalorie IsUnitForQuantity EnergyQuantity
Unit:BritishThermalUnit
BritishThermalUnit.ConversionFactorA = 0
BritishThermalUnit.ConversionFactorB = 0.0009484516526770049
BritishThermalUnit.Symbol = "BTU"
BritishThermalUnit IsUnitForQuantity EnergyQuantity
Unit:KiloBritishThermalUnit
KiloBritishThermalUnit.ConversionFactorA = 0
KiloBritishThermalUnit.ConversionFactorB = 9.484516526770048E-07
KiloBritishThermalUnit.Symbol = "kBTU"
KiloBritishThermalUnit IsUnitForQuantity EnergyQuantity
Unit:MegaBritishThermalUnit
MegaBritishThermalUnit.ConversionFactorA = 0
MegaBritishThermalUnit.ConversionFactorB = 9.48451652677005E-10
MegaBritishThermalUnit.Symbol = "MMBTU"
MegaBritishThermalUnit IsUnitForQuantity EnergyQuantity
```
## GravitationalLoadQuantity <!-- NOUN -->
- Display name: GravitationalLoad
- Parent class: Quantity
- Specialization: 
  - M = 1
- Description: 
Mass can be experimentally defined as a measure of the body's inertia, meaning the resistance to acceleration (change of velocity) when a net force is applied. The object's mass also determines the strength of its gravitational attraction to other bodies.
The dimension of mass is:
$$[M]$$.

The SI unit for **mass** is: kilogram with the associated unit label $kg$

- Examples: 
``` dwis
Quantity:GravitationalLoadQuantity
GravitationalLoadQuantity.M = 1
Unit:Kilogram
Kilogram.ConversionFactorA = 0
Kilogram.ConversionFactorB = 1
Kilogram.Symbol = "kg"
Kilogram IsUnitForQuantity GravitationalLoadQuantity
GravitationalLoadQuantity HasSIUnit Kilogram
Unit:TonneMetric
TonneMetric.ConversionFactorA = 0
TonneMetric.ConversionFactorB = 0.001
TonneMetric.Symbol = "t"
TonneMetric IsUnitForQuantity GravitationalLoadQuantity
Unit:Pound
Pound.ConversionFactorA = 0
Pound.ConversionFactorB = 2.2046226218487757
Pound.Symbol = "lb"
Pound IsUnitForQuantity GravitationalLoadQuantity
Unit:Kilopound
Kilopound.ConversionFactorA = 0
Kilopound.ConversionFactorB = 0.002204622621848776
Kilopound.Symbol = "klb"
Kilopound IsUnitForQuantity GravitationalLoadQuantity
Unit:TonUk
TonUk.ConversionFactorA = 0
TonUk.ConversionFactorB = 0.0009842065276110606
TonUk.Symbol = "LT"
TonUk IsUnitForQuantity GravitationalLoadQuantity
```
## HydraulicConductivityQuantity <!-- NOUN -->
- Display name: HydraulicConductivity
- Parent class: Quantity
- Specialization: 
  - L = 1
  - T = -1
- Description: 
A velocity is the time derivative of a position or a displacement: $\frac{dx}{dt}$, where $x$ is a position and $t$ is time.
The dimension of velocity is:
$$[LT^{-1}]$$.

The SI unit for **velocity** is: metre per second with the associated unit label $\frac{m}{s}$

- Examples: 
``` dwis
Quantity:HydraulicConductivityQuantity
HydraulicConductivityQuantity.L = 1
HydraulicConductivityQuantity.T = -1
Unit:MetrePerSecond
MetrePerSecond.ConversionFactorA = 0
MetrePerSecond.ConversionFactorB = 1
MetrePerSecond.Symbol = "m/s"
MetrePerSecond IsUnitForQuantity HydraulicConductivityQuantity
HydraulicConductivityQuantity HasSIUnit MetrePerSecond
Unit:MetrePerMinute
MetrePerMinute.ConversionFactorA = 0
MetrePerMinute.ConversionFactorB = 60
MetrePerMinute.Symbol = "m/min"
MetrePerMinute IsUnitForQuantity HydraulicConductivityQuantity
Unit:MetrePerHour
MetrePerHour.ConversionFactorA = 0
MetrePerHour.ConversionFactorB = 3600
MetrePerHour.Symbol = "m/h"
MetrePerHour IsUnitForQuantity HydraulicConductivityQuantity
Unit:MetrePerDay
MetrePerDay.ConversionFactorA = 0
MetrePerDay.ConversionFactorB = 86400
MetrePerDay.Symbol = "m/d"
MetrePerDay IsUnitForQuantity HydraulicConductivityQuantity
Unit:FootPerSecond
FootPerSecond.ConversionFactorA = 0
FootPerSecond.ConversionFactorB = 3.280839895013124
FootPerSecond.Symbol = "ft/s"
FootPerSecond IsUnitForQuantity HydraulicConductivityQuantity
Unit:FootPerMinute
FootPerMinute.ConversionFactorA = 0
FootPerMinute.ConversionFactorB = 196.85039370078744
FootPerMinute.Symbol = "ft/m"
FootPerMinute IsUnitForQuantity HydraulicConductivityQuantity
Unit:FootPerHour
FootPerHour.ConversionFactorA = 0
FootPerHour.ConversionFactorB = 11811.023622047245
FootPerHour.Symbol = "ft/h"
FootPerHour IsUnitForQuantity HydraulicConductivityQuantity
Unit:FootPerDay
FootPerDay.ConversionFactorA = 0
FootPerDay.ConversionFactorB = 283464.5669291339
FootPerDay.Symbol = "ft/d"
FootPerDay IsUnitForQuantity HydraulicConductivityQuantity
Unit:CentimetrePerSecond
CentimetrePerSecond.ConversionFactorA = 0
CentimetrePerSecond.ConversionFactorB = 100
CentimetrePerSecond.Symbol = "cm/s"
CentimetrePerSecond IsUnitForQuantity HydraulicConductivityQuantity
Unit:InchPerSecond
InchPerSecond.ConversionFactorA = 0
InchPerSecond.ConversionFactorB = 39.37007874015748
InchPerSecond.Symbol = "in/s"
InchPerSecond IsUnitForQuantity HydraulicConductivityQuantity
```
## RotationalFrequencyRateOfChangeQuantity <!-- NOUN -->
- Display name: RotationalFrequencyRateOfChange
- Parent class: Quantity
- Specialization: 
  - T = -2
- Description: 
A frequency rate of change is the time derivative of a frequency: $\frac{df}{dt}$, where $f$ is a frequency and $t$ is time.
The dimension of frequency rate of change is:
$$[T^{-2}]$$.

The SI unit for **frequency rate of change** is: hertz per second with the associated unit label $\frac{Hz}{s}$
A rotation frequency rate of change is the time derivative of a rotation frequency.
The meaningful precision of rotational frequency is typically:  Hz/s

- Examples: 
``` dwis
Quantity:RotationalFrequencyRateOfChangeQuantity
RotationalFrequencyRateOfChangeQuantity.T = -2
Unit:HertzPerSecond
HertzPerSecond.ConversionFactorA = 0
HertzPerSecond.ConversionFactorB = 1
HertzPerSecond.Symbol = "Hz/s"
HertzPerSecond IsUnitForQuantity RotationalFrequencyRateOfChangeQuantity
RotationalFrequencyRateOfChangeQuantity HasSIUnit HertzPerSecond
Unit:RpmPerSecond
RpmPerSecond.ConversionFactorA = 0
RpmPerSecond.ConversionFactorB = 1
RpmPerSecond.Symbol = "rpm/s"
RpmPerSecond IsUnitForQuantity RotationalFrequencyRateOfChangeQuantity
```
## TensionQuantity <!-- NOUN -->
- Display name: Tension
- Parent class: Quantity
- Specialization: 
  - L = 1
  - M = 1
  - T = -2
- Description: 
Tension is the pulling or stretching force transmitted axially along an object such as a string, rope, chain, rod, truss member, or other object, so as to stretch or pull apart the object. In terms of force, it is the opposite of compression. Tension might also be described as the action-reaction pair of forces acting at each end of an object.
The dimension of tension is:
$$[LMT^{-2}]$$.

- Examples: 
``` dwis
Quantity:TensionQuantity
TensionQuantity.L = 1
TensionQuantity.M = 1
TensionQuantity.T = -2
Unit:Newton
Newton.ConversionFactorA = 0
Newton.ConversionFactorB = 1
Newton.Symbol = "N"
Newton IsUnitForQuantity TensionQuantity
TensionQuantity HasSIUnit Newton
Unit:Decanewton
Decanewton.ConversionFactorA = 0
Decanewton.ConversionFactorB = 0.1
Decanewton.Symbol = "daN"
Decanewton IsUnitForQuantity TensionQuantity
Unit:Kilonewton
Kilonewton.ConversionFactorA = 0
Kilonewton.ConversionFactorB = 0.001
Kilonewton.Symbol = "kN"
Kilonewton IsUnitForQuantity TensionQuantity
Unit:Kilodecanewton
Kilodecanewton.ConversionFactorA = 0
Kilodecanewton.ConversionFactorB = 0.0001
Kilodecanewton.Symbol = "kdaN"
Kilodecanewton IsUnitForQuantity TensionQuantity
Unit:KilogramForce
KilogramForce.ConversionFactorA = 0
KilogramForce.ConversionFactorB = 0.10197162129779283
KilogramForce.Symbol = "kgf"
KilogramForce IsUnitForQuantity TensionQuantity
Unit:PoundForce
PoundForce.ConversionFactorA = 0
PoundForce.ConversionFactorB = 0.2248089430997105
PoundForce.Symbol = "lbf"
PoundForce IsUnitForQuantity TensionQuantity
Unit:KilopoundForce
KilopoundForce.ConversionFactorA = 0
KilopoundForce.ConversionFactorB = 0.0002248089430997105
KilopoundForce.Symbol = "klbf"
KilopoundForce IsUnitForQuantity TensionQuantity
```
