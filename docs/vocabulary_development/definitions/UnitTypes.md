-Description: standard measurable quantity types. A measurable quantity type is a sub-class of `MeasurableQuantity` for which a `MeaningfulPrecision` is defined.

# NOUNS
## MetrePerSecondSquared <!-- NOUN -->
- Display name: metre per second squared
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
MetrePerSecondSquared:MetrePerSecondSquared_1
MetrePerSecondSquared_1.Symbol = "m/s²"
```
## FootPerSecondSquared <!-- NOUN -->
- Display name: foot per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.280839895013124
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per second squared
[SI] is the value in SI
a = 1.0/Foot, i.e., 3.280839895013124
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerSecondSquared:FootPerSecondSquared_1
FootPerSecondSquared_1.ConversionFactorB = "3.280839895013124"
FootPerSecondSquared_1.Symbol = "ft/s²"
```
## CentimetrePerSecondSquared <!-- NOUN -->
- Display name: centimetre per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per second squared
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
CentimetrePerSecondSquared:CentimetrePerSecondSquared_1
CentimetrePerSecondSquared_1.ConversionFactorB = "100"
CentimetrePerSecondSquared_1.Symbol = "cm/s²"
```
## CentimetrePerHourPerSecond <!-- NOUN -->
- Display name: centimetre per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 360000
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per hour per second
[SI] is the value in SI
a = Hour/Centi, i.e., 360000
and
Hour = 60.0 * Minute
Centi = 0.01
Minute = 60.0

- Examples: 
``` dwis
CentimetrePerHourPerSecond:CentimetrePerHourPerSecond_1
CentimetrePerHourPerSecond_1.ConversionFactorB = "360000"
CentimetrePerHourPerSecond_1.Symbol = "cm/(h•s)"
```
## CentimetrePerMinutePerSecond <!-- NOUN -->
- Display name: centimetre per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6000
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per minute per second
[SI] is the value in SI
a = Minute/Centi, i.e., 6000
and
Minute = 60.0
Centi = 0.01

- Examples: 
``` dwis
CentimetrePerMinutePerSecond:CentimetrePerMinutePerSecond_1
CentimetrePerMinutePerSecond_1.ConversionFactorB = "6000"
CentimetrePerMinutePerSecond_1.Symbol = "cm/(min•s)"
```
## FootPerHourPerSecond <!-- NOUN -->
- Display name: foot per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 11811.023622047245
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per hour per second
[SI] is the value in SI
a = Hour/Foot, i.e., 11811.023622047245
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerHourPerSecond:FootPerHourPerSecond_1
FootPerHourPerSecond_1.ConversionFactorB = "11811.023622047245"
FootPerHourPerSecond_1.Symbol = "ft/(h•s)"
```
## FootPerMinutePerSecond <!-- NOUN -->
- Display name: foot per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 196.85039370078744
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per minute per second
[SI] is the value in SI
a = Minute/Foot, i.e., 196.85039370078744
and
Minute = 60.0
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerMinutePerSecond:FootPerMinutePerSecond_1
FootPerMinutePerSecond_1.ConversionFactorB = "196.85039370078744"
FootPerMinutePerSecond_1.Symbol = "ft/(min•s)"
```
## Galileo <!-- NOUN -->
- Display name: galileo
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in galileo
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Galileo:Galileo_1
Galileo_1.ConversionFactorB = "100"
Galileo_1.Symbol = "Gal"
```
## GravityStandard <!-- NOUN -->
- Display name: gravity standard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10197162129779283
- Description: 
[v] = a * [SI]
where
[v] is the value in gravity standard
[SI] is the value in SI
a = 1.0/G, i.e., 0.10197162129779283
and
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
GravityStandard:GravityStandard_1
GravityStandard_1.ConversionFactorB = "0.10197162129779283"
GravityStandard_1.Symbol = "gn"
```
## InchPerHourPerSecond <!-- NOUN -->
- Display name: inch per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 141732.28346456692
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per hour per second
[SI] is the value in SI
a = Hour/Inch, i.e., 141732.28346456692
and
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
InchPerHourPerSecond:InchPerHourPerSecond_1
InchPerHourPerSecond_1.ConversionFactorB = "141732.28346456692"
InchPerHourPerSecond_1.Symbol = "in/(h•s)"
```
## InchPerMinutePerSecond <!-- NOUN -->
- Display name: inch per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2362.2047244094488
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per minute per second
[SI] is the value in SI
a = Minute/Inch, i.e., 2362.2047244094488
and
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
InchPerMinutePerSecond:InchPerMinutePerSecond_1
InchPerMinutePerSecond_1.ConversionFactorB = "2362.2047244094488"
InchPerMinutePerSecond_1.Symbol = "in/(min•s)"
```
## InchPerSecondSquared <!-- NOUN -->
- Display name: inch per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 39.37007874015748
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per second squared
[SI] is the value in SI
a = 1.0/Inch, i.e., 39.37007874015748
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
InchPerSecondSquared:InchPerSecondSquared_1
InchPerSecondSquared_1.ConversionFactorB = "39.37007874015748"
InchPerSecondSquared_1.Symbol = "in/s²"
```
## KnotPerSecond <!-- NOUN -->
- Display name: knot per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.9438444924406046
- Description: 
[v] = a * [SI]
where
[v] is the value in knot per second
[SI] is the value in SI
a = 1.0/Knot, i.e., 1.9438444924406046
and
Knot = 1.852 * Kilo / Hour reference: https://en.wikipedia.org/wiki/Knot_(unit)
Kilo = 1000.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
KnotPerSecond:KnotPerSecond_1
KnotPerSecond_1.ConversionFactorB = "1.9438444924406046"
KnotPerSecond_1.Symbol = "kn/s"
```
## MetrePerSecondPerMillisecond <!-- NOUN -->
- Display name: metre per second per millisecond
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in metre per second per millisecond
[SI] is the value in SI
a = Milli /Unit, i.e., 0.001
and
Milli = 0.001
Unit = 1.0

- Examples: 
``` dwis
MetrePerSecondPerMillisecond:MetrePerSecondPerMillisecond_1
MetrePerSecondPerMillisecond_1.ConversionFactorB = "0.001"
MetrePerSecondPerMillisecond_1.Symbol = "m/(s•ms)"
```
## MilePerHourPerSecond <!-- NOUN -->
- Display name: mile per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.2369362920544025
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per hour per second
[SI] is the value in SI
a = Hour / Mile, i.e., 2.2369362920544025
and
Hour = 60.0 * Minute
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Minute = 60.0
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerHourPerSecond:MilePerHourPerSecond_1
MilePerHourPerSecond_1.ConversionFactorB = "2.2369362920544025"
MilePerHourPerSecond_1.Symbol = "mi/(h•s)"
```
## MilePerMinutePerSecond <!-- NOUN -->
- Display name: mile per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.03728227153424004
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per minute per second
[SI] is the value in SI
a = Minute /Mile, i.e., 0.03728227153424004
and
Minute = 60.0
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerMinutePerSecond:MilePerMinutePerSecond_1
MilePerMinutePerSecond_1.ConversionFactorB = "0.03728227153424004"
MilePerMinutePerSecond_1.Symbol = "mi/(min•s)"
```
## MilePerSecondSquared <!-- NOUN -->
- Display name: mile per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.000621371192237334
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per second squared
[SI] is the value in SI
a = 1.0/Mile, i.e., 0.000621371192237334
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerSecondSquared:MilePerSecondSquared_1
MilePerSecondSquared_1.ConversionFactorB = "0.000621371192237334"
MilePerSecondSquared_1.Symbol = "mi/s²"
```
## KilometrePerSecondSquared <!-- NOUN -->
- Display name: kilometre per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per second squared
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KilometrePerSecondSquared:KilometrePerSecondSquared_1
KilometrePerSecondSquared_1.ConversionFactorB = "0.001"
KilometrePerSecondSquared_1.Symbol = "km/s²"
```
## KilometrePerHourPerSecond <!-- NOUN -->
- Display name: kilometre per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.6
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per hour per second
[SI] is the value in SI
a = Hour/Kilo, i.e., 3.6
and
Hour = 60.0 * Minute
Kilo = 1000.0
Minute = 60.0

- Examples: 
``` dwis
KilometrePerHourPerSecond:KilometrePerHourPerSecond_1
KilometrePerHourPerSecond_1.ConversionFactorB = "3.6"
KilometrePerHourPerSecond_1.Symbol = "km/(h•s)"
```
## KilometrePerMinutePerSecond <!-- NOUN -->
- Display name: kilometre per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per minute per second
[SI] is the value in SI
a = Minute/Kilo, i.e., 0.06
and
Minute = 60.0
Kilo = 1000.0

- Examples: 
``` dwis
KilometrePerMinutePerSecond:KilometrePerMinutePerSecond_1
KilometrePerMinutePerSecond_1.ConversionFactorB = "0.06"
KilometrePerMinutePerSecond_1.Symbol = "km/(min•s)"
```
## Mole <!-- NOUN -->
- Display name: mole
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Mole:Mole_1
Mole_1.Symbol = "mol"
```
## Decimole <!-- NOUN -->
- Display name: decimole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in decimole
[SI] is the value in SI
a = 1.0/Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
Decimole:Decimole_1
Decimole_1.ConversionFactorB = "10"
Decimole_1.Symbol = "dmol"
```
## Centimole <!-- NOUN -->
- Display name: centimole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centimole
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Centimole:Centimole_1
Centimole_1.ConversionFactorB = "100"
Centimole_1.Symbol = "cmol"
```
## Millimole <!-- NOUN -->
- Display name: millimole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimole
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millimole:Millimole_1
Millimole_1.ConversionFactorB = "1000"
Millimole_1.Symbol = "mmol"
```
## Micromole <!-- NOUN -->
- Display name: micromole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in micromole
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Micromole:Micromole_1
Micromole_1.ConversionFactorB = "1000000"
Micromole_1.Symbol = "µmol"
```
## Nanomole <!-- NOUN -->
- Display name: nanomole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanomole
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanomole:Nanomole_1
Nanomole_1.ConversionFactorB = "999999999.9999999"
Nanomole_1.Symbol = "nmol"
```
## Picomole <!-- NOUN -->
- Display name: picomole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picomole
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picomole:Picomole_1
Picomole_1.ConversionFactorB = "1000000000000"
Picomole_1.Symbol = "pmol"
```
## Kilomole <!-- NOUN -->
- Display name: kilomole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilomole
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilomole:Kilomole_1
Kilomole_1.ConversionFactorB = "0.001"
Kilomole_1.Symbol = "kmol"
```
## RadianPerMetre <!-- NOUN -->
- Display name: radian per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
RadianPerMetre:RadianPerMetre_1
RadianPerMetre_1.Symbol = "rad/m"
```
## DegreePerMetre <!-- NOUN -->
- Display name: degree per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per metre
[SI] is the value in SI
a = Degree, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerMetre:DegreePerMetre_1
DegreePerMetre_1.ConversionFactorB = "57.29577951308232"
DegreePerMetre_1.Symbol = "°/m"
```
## DegreePerCentimetre <!-- NOUN -->
- Display name: degree per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.5729577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per centimetre
[SI] is the value in SI
a = Degree*Centi, i.e., 0.5729577951308232
and
Degree = 180.0 / System.Math.PI
Centi = 0.01

- Examples: 
``` dwis
DegreePerCentimetre:DegreePerCentimetre_1
DegreePerCentimetre_1.ConversionFactorB = "0.5729577951308232"
DegreePerCentimetre_1.Symbol = "°/cm"
```
## DegreePerFoot <!-- NOUN -->
- Display name: degree per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 17.46375359558749
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per foot
[SI] is the value in SI
a = Degree*Foot, i.e., 17.46375359558749
and
Degree = 180.0 / System.Math.PI
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DegreePerFoot:DegreePerFoot_1
DegreePerFoot_1.ConversionFactorB = "17.46375359558749"
DegreePerFoot_1.Symbol = "°/ft"
```
## DegreePerInch <!-- NOUN -->
- Display name: degree per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.455312799632291
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per inch
[SI] is the value in SI
a = Degree*Inch, i.e., 1.455312799632291
and
Degree = 180.0 / System.Math.PI
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DegreePerInch:DegreePerInch_1
DegreePerInch_1.ConversionFactorB = "1.455312799632291"
DegreePerInch_1.Symbol = "°/in"
```
## DegreePerDecimetre <!-- NOUN -->
- Display name: degree per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5.729577951308233
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per decimetre
[SI] is the value in SI
a = Degree*Deci, i.e., 5.729577951308233
and
Degree = 180.0 / System.Math.PI
Deci = 0.1

- Examples: 
``` dwis
DegreePerDecimetre:DegreePerDecimetre_1
DegreePerDecimetre_1.ConversionFactorB = "5.729577951308233"
DegreePerDecimetre_1.Symbol = "°/dm"
```
## DegreePerMillimetre <!-- NOUN -->
- Display name: degree per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.057295779513082325
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per millimetre
[SI] is the value in SI
a = Degree*Milli, i.e., 0.057295779513082325
and
Degree = 180.0 / System.Math.PI
Milli = 0.001

- Examples: 
``` dwis
DegreePerMillimetre:DegreePerMillimetre_1
DegreePerMillimetre_1.ConversionFactorB = "0.057295779513082325"
DegreePerMillimetre_1.Symbol = "°/mm"
```
## RadianPerMillimetre <!-- NOUN -->
- Display name: radian per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per millimetre
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
RadianPerMillimetre:RadianPerMillimetre_1
RadianPerMillimetre_1.ConversionFactorB = "0.001"
RadianPerMillimetre_1.Symbol = "rad/mm"
```
## RadianPerCentimetre <!-- NOUN -->
- Display name: radian per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per centimetre
[SI] is the value in SI
a = Centi, i.e., 0.01
and
Centi = 0.01

- Examples: 
``` dwis
RadianPerCentimetre:RadianPerCentimetre_1
RadianPerCentimetre_1.ConversionFactorB = "0.01"
RadianPerCentimetre_1.Symbol = "rad/cm"
```
## RadianPerDecimetre <!-- NOUN -->
- Display name: radian per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per decimetre
[SI] is the value in SI
a = Deci, i.e., 0.1
and
Deci = 0.1

- Examples: 
``` dwis
RadianPerDecimetre:RadianPerDecimetre_1
RadianPerDecimetre_1.ConversionFactorB = "0.1"
RadianPerDecimetre_1.Symbol = "rad/dm"
```
## RadianPerFoot <!-- NOUN -->
- Display name: radian per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.30479999999999996
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per foot
[SI] is the value in SI
a = Foot, i.e., 0.30479999999999996
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
RadianPerFoot:RadianPerFoot_1
RadianPerFoot_1.ConversionFactorB = "0.30479999999999996"
RadianPerFoot_1.Symbol = "rad/ft"
```
## RadianPerInch <!-- NOUN -->
- Display name: radian per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0254
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per inch
[SI] is the value in SI
a = Inch, i.e., 0.0254
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
RadianPerInch:RadianPerInch_1
RadianPerInch_1.ConversionFactorB = "0.0254"
RadianPerInch_1.Symbol = "rad/in"
```
## RadianTesla <!-- NOUN -->
- Display name: radian tesla
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
RadianTesla:RadianTesla_1
RadianTesla_1.Symbol = "rad•T"
```
## RadianGauss <!-- NOUN -->
- Display name: radian gauss
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian gauss
[SI] is the value in SI
a = 1.0/Gauss, i.e., 10000
and
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)

- Examples: 
``` dwis
RadianGauss:RadianGauss_1
RadianGauss_1.ConversionFactorB = "10000"
RadianGauss_1.Symbol = "rad•G"
```
## RadianMilligauss <!-- NOUN -->
- Display name: radian milligauss
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian milligauss
[SI] is the value in SI
a = 1.0/(Milli*Gauss), i.e., 10000000
and
Milli = 0.001
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)

- Examples: 
``` dwis
RadianMilligauss:RadianMilligauss_1
RadianMilligauss_1.ConversionFactorB = "10000000"
RadianMilligauss_1.Symbol = "rad•mG"
```
## RadianMillitesla <!-- NOUN -->
- Display name: radian millitesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian millitesla
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
RadianMillitesla:RadianMillitesla_1
RadianMillitesla_1.ConversionFactorB = "1000"
RadianMillitesla_1.Symbol = "rad•mT"
```
## RadianMicrotesla <!-- NOUN -->
- Display name: radian microtesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian microtesla
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
RadianMicrotesla:RadianMicrotesla_1
RadianMicrotesla_1.ConversionFactorB = "1000000"
RadianMicrotesla_1.Symbol = "rad•µT"
```
## RadianNanotesla <!-- NOUN -->
- Display name: radian nanotesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in radian nanotesla
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
RadianNanotesla:RadianNanotesla_1
RadianNanotesla_1.ConversionFactorB = "999999999.9999999"
RadianNanotesla_1.Symbol = "rad•nT"
```
## RadianMaxwellPerSquareCentimetre <!-- NOUN -->
- Display name: radian maxwell per square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian maxwell per square centimetre
[SI] is the value in SI
a = 1.0/(Centi*Centi), i.e., 10000
and
Centi = 0.01

- Examples: 
``` dwis
RadianMaxwellPerSquareCentimetre:RadianMaxwellPerSquareCentimetre_1
RadianMaxwellPerSquareCentimetre_1.ConversionFactorB = "10000"
RadianMaxwellPerSquareCentimetre_1.Symbol = "rad•Mx/cm²"
```
## RadianWeberPerSquareMetre <!-- NOUN -->
- Display name: radian weber per square metre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in radian weber per square metre
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
RadianWeberPerSquareMetre:RadianWeberPerSquareMetre_1
RadianWeberPerSquareMetre_1.Symbol = "rad•Wb/m²"
```
## DegreeTesla <!-- NOUN -->
- Display name: degree tesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree tesla
[SI] is the value in SI
a = Degree/Unit, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI
Unit = 1.0

- Examples: 
``` dwis
DegreeTesla:DegreeTesla_1
DegreeTesla_1.ConversionFactorB = "57.29577951308232"
DegreeTesla_1.Symbol = "°•T"
```
## DegreeGauss <!-- NOUN -->
- Display name: degree gauss
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 572957.7951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree gauss
[SI] is the value in SI
a = Degree/Gauss, i.e., 572957.7951308232
and
Degree = 180.0 / System.Math.PI
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)

- Examples: 
``` dwis
DegreeGauss:DegreeGauss_1
DegreeGauss_1.ConversionFactorB = "572957.7951308232"
DegreeGauss_1.Symbol = "°•G"
```
## DegreeMilligauss <!-- NOUN -->
- Display name: degree milligauss
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 572957795.1308231
- Description: 
[v] = a * [SI]
where
[v] is the value in degree milligauss
[SI] is the value in SI
a = Degree/(Milli*Gauss), i.e., 572957795.1308231
and
Degree = 180.0 / System.Math.PI
Milli = 0.001
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)

- Examples: 
``` dwis
DegreeMilligauss:DegreeMilligauss_1
DegreeMilligauss_1.ConversionFactorB = "572957795.1308231"
DegreeMilligauss_1.Symbol = "°•mG"
```
## DegreeMillitesla <!-- NOUN -->
- Display name: degree millitesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57295.77951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree millitesla
[SI] is the value in SI
a = Degree/Milli, i.e., 57295.77951308232
and
Degree = 180.0 / System.Math.PI
Milli = 0.001

- Examples: 
``` dwis
DegreeMillitesla:DegreeMillitesla_1
DegreeMillitesla_1.ConversionFactorB = "57295.77951308232"
DegreeMillitesla_1.Symbol = "°•mT"
```
## DegreeMicrotesla <!-- NOUN -->
- Display name: degree microtesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57295779.513082325
- Description: 
[v] = a * [SI]
where
[v] is the value in degree microtesla
[SI] is the value in SI
a = Degree/Micro, i.e., 57295779.513082325
and
Degree = 180.0 / System.Math.PI
Micro = 1e-6

- Examples: 
``` dwis
DegreeMicrotesla:DegreeMicrotesla_1
DegreeMicrotesla_1.ConversionFactorB = "57295779.513082325"
DegreeMicrotesla_1.Symbol = "°•µT"
```
## DegreeNanotesla <!-- NOUN -->
- Display name: degree nanotesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57295779513.08232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree nanotesla
[SI] is the value in SI
a = Degree/Nano, i.e., 57295779513.08232
and
Degree = 180.0 / System.Math.PI
Nano = 1e-9

- Examples: 
``` dwis
DegreeNanotesla:DegreeNanotesla_1
DegreeNanotesla_1.ConversionFactorB = "57295779513.08232"
DegreeNanotesla_1.Symbol = "°•nT"
```
## DegreeMaxwellPerSquareCentimetre <!-- NOUN -->
- Display name: degree maxwell per square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 572957.7951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree maxwell per square centimetre
[SI] is the value in SI
a = Degree/(Centi*Centi), i.e., 572957.7951308232
and
Degree = 180.0 / System.Math.PI
Centi = 0.01

- Examples: 
``` dwis
DegreeMaxwellPerSquareCentimetre:DegreeMaxwellPerSquareCentimetre_1
DegreeMaxwellPerSquareCentimetre_1.ConversionFactorB = "572957.7951308232"
DegreeMaxwellPerSquareCentimetre_1.Symbol = "°•Mx/cm²"
```
## DegreeWeberPerSquareMetre <!-- NOUN -->
- Display name: degree weber per square metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree weber per square metre
[SI] is the value in SI
a = Degree/Unit, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI
Unit = 1.0

- Examples: 
``` dwis
DegreeWeberPerSquareMetre:DegreeWeberPerSquareMetre_1
DegreeWeberPerSquareMetre_1.ConversionFactorB = "57.29577951308232"
DegreeWeberPerSquareMetre_1.Symbol = "°•Wb/m²"
```
## RadianPerSecondSquared <!-- NOUN -->
- Display name: radian per second squared
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
RadianPerSecondSquared:RadianPerSecondSquared_1
RadianPerSecondSquared_1.Symbol = "rad/s²"
```
## DegreePerSecondSquared <!-- NOUN -->
- Display name: degree per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per second squared
[SI] is the value in SI
a = Degree, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerSecondSquared:DegreePerSecondSquared_1
DegreePerSecondSquared_1.ConversionFactorB = "57.29577951308232"
DegreePerSecondSquared_1.Symbol = "°/s²"
```
## RadianPerDayPerSecond <!-- NOUN -->
- Display name: radian per day per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per day per second
[SI] is the value in SI
a = Day, i.e., 86400
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerDayPerSecond:RadianPerDayPerSecond_1
RadianPerDayPerSecond_1.ConversionFactorB = "86400"
RadianPerDayPerSecond_1.Symbol = "rad/d/s"
```
## RadianPerHourPerSecond <!-- NOUN -->
- Display name: radian per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per hour per second
[SI] is the value in SI
a = Hour, i.e., 3600
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerHourPerSecond:RadianPerHourPerSecond_1
RadianPerHourPerSecond_1.ConversionFactorB = "3600"
RadianPerHourPerSecond_1.Symbol = "rad/h/s"
```
## RadianPerMinutePerSecond <!-- NOUN -->
- Display name: radian per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per minute per second
[SI] is the value in SI
a = Minute, i.e., 60
and
Minute = 60.0

- Examples: 
``` dwis
RadianPerMinutePerSecond:RadianPerMinutePerSecond_1
RadianPerMinutePerSecond_1.ConversionFactorB = "60"
RadianPerMinutePerSecond_1.Symbol = "rad/min/s"
```
## DegreePerDayPerSecond <!-- NOUN -->
- Display name: degree per day per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4950355.3499303125
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per day per second
[SI] is the value in SI
a = Day*Degree, i.e., 4950355.3499303125
and
Day = 24.0 * Hour
Degree = 180.0 / System.Math.PI
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DegreePerDayPerSecond:DegreePerDayPerSecond_1
DegreePerDayPerSecond_1.ConversionFactorB = "4950355.3499303125"
DegreePerDayPerSecond_1.Symbol = "°/d/s"
```
## DegreePerHourPerSecond <!-- NOUN -->
- Display name: degree per hour per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 206264.80624709636
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per hour per second
[SI] is the value in SI
a = Hour*Degree, i.e., 206264.80624709636
and
Hour = 60.0 * Minute
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerHourPerSecond:DegreePerHourPerSecond_1
DegreePerHourPerSecond_1.ConversionFactorB = "206264.80624709636"
DegreePerHourPerSecond_1.Symbol = "°/h/s"
```
## DegreePerMinutePerSecond <!-- NOUN -->
- Display name: degree per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3437.746770784939
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per minute per second
[SI] is the value in SI
a = Minute*Degree, i.e., 3437.746770784939
and
Minute = 60.0
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerMinutePerSecond:DegreePerMinutePerSecond_1
DegreePerMinutePerSecond_1.ConversionFactorB = "3437.746770784939"
DegreePerMinutePerSecond_1.Symbol = "°/min/s"
```
## RadianPerSecondPerMinute <!-- NOUN -->
- Display name: radian per second per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per second per minute
[SI] is the value in SI
a = Unit * Minute, i.e., 60
and
Unit = 1.0
Minute = 60.0

- Examples: 
``` dwis
RadianPerSecondPerMinute:RadianPerSecondPerMinute_1
RadianPerSecondPerMinute_1.ConversionFactorB = "60"
RadianPerSecondPerMinute_1.Symbol = "rad/s/min"
```
## DegreePerSecondPerMinute <!-- NOUN -->
- Display name: degree per second per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3437.746770784939
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per second per minute
[SI] is the value in SI
a = Unit * Minute * Degree, i.e., 3437.746770784939
and
Unit = 1.0
Minute = 60.0
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerSecondPerMinute:DegreePerSecondPerMinute_1
DegreePerSecondPerMinute_1.ConversionFactorB = "3437.746770784939"
DegreePerSecondPerMinute_1.Symbol = "°/s/min"
```
## RadianPerDayPerMinute <!-- NOUN -->
- Display name: radian per day per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5184000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per day per minute
[SI] is the value in SI
a = Day*Minute, i.e., 5184000
and
Day = 24.0 * Hour
Minute = 60.0
Hour = 60.0 * Minute

- Examples: 
``` dwis
RadianPerDayPerMinute:RadianPerDayPerMinute_1
RadianPerDayPerMinute_1.ConversionFactorB = "5184000"
RadianPerDayPerMinute_1.Symbol = "rad/d/min"
```
## RadianPerHourPerMinute <!-- NOUN -->
- Display name: radian per hour per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 216000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per hour per minute
[SI] is the value in SI
a = Hour*Minute, i.e., 216000
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerHourPerMinute:RadianPerHourPerMinute_1
RadianPerHourPerMinute_1.ConversionFactorB = "216000"
RadianPerHourPerMinute_1.Symbol = "rad/h/min"
```
## RadianPerMinuteSquared <!-- NOUN -->
- Display name: radian per minute squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per minute squared
[SI] is the value in SI
a = Minute*Minute, i.e., 3600
and
Minute = 60.0

- Examples: 
``` dwis
RadianPerMinuteSquared:RadianPerMinuteSquared_1
RadianPerMinuteSquared_1.ConversionFactorB = "3600"
RadianPerMinuteSquared_1.Symbol = "rad/min²"
```
## DegreePerDayPerMinute <!-- NOUN -->
- Display name: degree per day per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 297021320.99581873
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per day per minute
[SI] is the value in SI
a = Day*Minute*Degree, i.e., 297021320.99581873
and
Day = 24.0 * Hour
Minute = 60.0
Degree = 180.0 / System.Math.PI
Hour = 60.0 * Minute

- Examples: 
``` dwis
DegreePerDayPerMinute:DegreePerDayPerMinute_1
DegreePerDayPerMinute_1.ConversionFactorB = "297021320.99581873"
DegreePerDayPerMinute_1.Symbol = "°/d/min"
```
## DegreePerHourPerMinute <!-- NOUN -->
- Display name: degree per hour per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 12375888.374825781
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per hour per minute
[SI] is the value in SI
a = Hour*Minute*Degree, i.e., 12375888.374825781
and
Hour = 60.0 * Minute
Minute = 60.0
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerHourPerMinute:DegreePerHourPerMinute_1
DegreePerHourPerMinute_1.ConversionFactorB = "12375888.374825781"
DegreePerHourPerMinute_1.Symbol = "°/h/min"
```
## DegreePerMinuteSquared <!-- NOUN -->
- Display name: degree per minute squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 206264.80624709636
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per minute squared
[SI] is the value in SI
a = Minute*Minute*Degree, i.e., 206264.80624709636
and
Minute = 60.0
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerMinuteSquared:DegreePerMinuteSquared_1
DegreePerMinuteSquared_1.ConversionFactorB = "206264.80624709636"
DegreePerMinuteSquared_1.Symbol = "°/min²"
```
## RadianPerSecondPerHour <!-- NOUN -->
- Display name: radian per second per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per second per hour
[SI] is the value in SI
a = Unit*Hour, i.e., 3600
and
Unit = 1.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerSecondPerHour:RadianPerSecondPerHour_1
RadianPerSecondPerHour_1.ConversionFactorB = "3600"
RadianPerSecondPerHour_1.Symbol = "rad/s/h"
```
## DegreePerSecondPerHour <!-- NOUN -->
- Display name: degree per second per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 206264.80624709636
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per second per hour
[SI] is the value in SI
a = Unit*Hour*Degree, i.e., 206264.80624709636
and
Unit = 1.0
Hour = 60.0 * Minute
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerSecondPerHour:DegreePerSecondPerHour_1
DegreePerSecondPerHour_1.ConversionFactorB = "206264.80624709636"
DegreePerSecondPerHour_1.Symbol = "°/s/h"
```
## RadianPerDayPerHour <!-- NOUN -->
- Display name: radian per day per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 311040000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per day per hour
[SI] is the value in SI
a = Day*Hour, i.e., 311040000
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerDayPerHour:RadianPerDayPerHour_1
RadianPerDayPerHour_1.ConversionFactorB = "311040000"
RadianPerDayPerHour_1.Symbol = "rad/d/h"
```
## RadianPerHourSquared <!-- NOUN -->
- Display name: radian per hour squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 12960000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per hour squared
[SI] is the value in SI
a = Hour*Hour, i.e., 12960000
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerHourSquared:RadianPerHourSquared_1
RadianPerHourSquared_1.ConversionFactorB = "12960000"
RadianPerHourSquared_1.Symbol = "rad/h²"
```
## RadianPerMinutePerHour <!-- NOUN -->
- Display name: radian per minute per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 216000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per minute per hour
[SI] is the value in SI
a = Minute*Hour, i.e., 216000
and
Minute = 60.0
Hour = 60.0 * Minute

- Examples: 
``` dwis
RadianPerMinutePerHour:RadianPerMinutePerHour_1
RadianPerMinutePerHour_1.ConversionFactorB = "216000"
RadianPerMinutePerHour_1.Symbol = "rad/min/h"
```
## DegreePerDayPerHour <!-- NOUN -->
- Display name: degree per day per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 17821279259.749126
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per day per hour
[SI] is the value in SI
a = Day*Hour*Degree, i.e., 17821279259.749126
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerDayPerHour:DegreePerDayPerHour_1
DegreePerDayPerHour_1.ConversionFactorB = "17821279259.749126"
DegreePerDayPerHour_1.Symbol = "°/d/h"
```
## DegreePerHourSquared <!-- NOUN -->
- Display name: degree per hour squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 742553302.4895469
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per hour squared
[SI] is the value in SI
a = Hour*Hour*Degree, i.e., 742553302.4895469
and
Hour = 60.0 * Minute
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerHourSquared:DegreePerHourSquared_1
DegreePerHourSquared_1.ConversionFactorB = "742553302.4895469"
DegreePerHourSquared_1.Symbol = "°/h²"
```
## DegreePerMinutePerHour <!-- NOUN -->
- Display name: degree per minute per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 12375888.374825781
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per minute per hour
[SI] is the value in SI
a = Minute*Hour*Degree, i.e., 12375888.374825781
and
Minute = 60.0
Hour = 60.0 * Minute
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerMinutePerHour:DegreePerMinutePerHour_1
DegreePerMinutePerHour_1.ConversionFactorB = "12375888.374825781"
DegreePerMinutePerHour_1.Symbol = "°/min/h"
```
## RadianPerSecondPerDay <!-- NOUN -->
- Display name: radian per second per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per second per day
[SI] is the value in SI
a = Unit*Day, i.e., 86400
and
Unit = 1.0
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerSecondPerDay:RadianPerSecondPerDay_1
RadianPerSecondPerDay_1.ConversionFactorB = "86400"
RadianPerSecondPerDay_1.Symbol = "rad/s/d"
```
## DegreePerSecondPerDay <!-- NOUN -->
- Display name: degree per second per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4950355.3499303125
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per second per day
[SI] is the value in SI
a = Degree*Unit*Day, i.e., 4950355.3499303125
and
Degree = 180.0 / System.Math.PI
Unit = 1.0
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DegreePerSecondPerDay:DegreePerSecondPerDay_1
DegreePerSecondPerDay_1.ConversionFactorB = "4950355.3499303125"
DegreePerSecondPerDay_1.Symbol = "°/s/d"
```
## RadianPerDaySquared <!-- NOUN -->
- Display name: radian per day squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 7464960000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per day squared
[SI] is the value in SI
a = Day*Day, i.e., 7464960000
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerDaySquared:RadianPerDaySquared_1
RadianPerDaySquared_1.ConversionFactorB = "7464960000"
RadianPerDaySquared_1.Symbol = "rad/d²"
```
## RadianPerHourPerDay <!-- NOUN -->
- Display name: radian per hour per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 311040000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per hour per day
[SI] is the value in SI
a = Hour*Day, i.e., 311040000
and
Hour = 60.0 * Minute
Day = 24.0 * Hour
Minute = 60.0

- Examples: 
``` dwis
RadianPerHourPerDay:RadianPerHourPerDay_1
RadianPerHourPerDay_1.ConversionFactorB = "311040000"
RadianPerHourPerDay_1.Symbol = "rad/h/d"
```
## RadianPerMinutePerDay <!-- NOUN -->
- Display name: radian per minute per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5184000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per minute per day
[SI] is the value in SI
a = Minute*Day, i.e., 5184000
and
Minute = 60.0
Day = 24.0 * Hour
Hour = 60.0 * Minute

- Examples: 
``` dwis
RadianPerMinutePerDay:RadianPerMinutePerDay_1
RadianPerMinutePerDay_1.ConversionFactorB = "5184000"
RadianPerMinutePerDay_1.Symbol = "rad/min/d"
```
## DegreePerDaySquared <!-- NOUN -->
- Display name: degree per day squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 427710702233.979
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per day squared
[SI] is the value in SI
a = Day*Day*Degree, i.e., 427710702233.979
and
Day = 24.0 * Hour
Degree = 180.0 / System.Math.PI
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DegreePerDaySquared:DegreePerDaySquared_1
DegreePerDaySquared_1.ConversionFactorB = "427710702233.979"
DegreePerDaySquared_1.Symbol = "°/d²"
```
## DegreePerHourPerDay <!-- NOUN -->
- Display name: degree per hour per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 17821279259.749126
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per hour per day
[SI] is the value in SI
a = Hour*Day*Degree, i.e., 17821279259.749126
and
Hour = 60.0 * Minute
Day = 24.0 * Hour
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerHourPerDay:DegreePerHourPerDay_1
DegreePerHourPerDay_1.ConversionFactorB = "17821279259.749126"
DegreePerHourPerDay_1.Symbol = "°/h/d"
```
## DegreePerMinutePerDay <!-- NOUN -->
- Display name: degree per minute per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 297021320.99581873
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per minute per day
[SI] is the value in SI
a = Minute*Day*Degree, i.e., 297021320.99581873
and
Minute = 60.0
Day = 24.0 * Hour
Degree = 180.0 / System.Math.PI
Hour = 60.0 * Minute

- Examples: 
``` dwis
DegreePerMinutePerDay:DegreePerMinutePerDay_1
DegreePerMinutePerDay_1.ConversionFactorB = "297021320.99581873"
DegreePerMinutePerDay_1.Symbol = "°/min/d"
```
## RadianPerSecond <!-- NOUN -->
- Display name: radian per second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
RadianPerSecond:RadianPerSecond_1
RadianPerSecond_1.Symbol = "rad/s"
```
## DegreePerSecond <!-- NOUN -->
- Display name: degree per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per second
[SI] is the value in SI
a = Degree, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerSecond:DegreePerSecond_1
DegreePerSecond_1.ConversionFactorB = "57.29577951308232"
DegreePerSecond_1.Symbol = "°/s"
```
## RadianPerDay <!-- NOUN -->
- Display name: radian per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per day
[SI] is the value in SI
a = Day, i.e., 86400
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerDay:RadianPerDay_1
RadianPerDay_1.ConversionFactorB = "86400"
RadianPerDay_1.Symbol = "rad/d"
```
## RadianPerHour <!-- NOUN -->
- Display name: radian per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per hour
[SI] is the value in SI
a = Hour, i.e., 3600
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerHour:RadianPerHour_1
RadianPerHour_1.ConversionFactorB = "3600"
RadianPerHour_1.Symbol = "rad/h"
```
## RadianPerMinute <!-- NOUN -->
- Display name: radian per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per minute
[SI] is the value in SI
a = Minute, i.e., 60
and
Minute = 60.0

- Examples: 
``` dwis
RadianPerMinute:RadianPerMinute_1
RadianPerMinute_1.ConversionFactorB = "60"
RadianPerMinute_1.Symbol = "rad/min"
```
## DegreePerDay <!-- NOUN -->
- Display name: degree per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4950355.3499303125
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per day
[SI] is the value in SI
a = Degree*Day, i.e., 4950355.3499303125
and
Degree = 180.0 / System.Math.PI
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DegreePerDay:DegreePerDay_1
DegreePerDay_1.ConversionFactorB = "4950355.3499303125"
DegreePerDay_1.Symbol = "°/d"
```
## DegreePerHour <!-- NOUN -->
- Display name: degree per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 206264.80624709636
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per hour
[SI] is the value in SI
a = Degree*Hour, i.e., 206264.80624709636
and
Degree = 180.0 / System.Math.PI
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DegreePerHour:DegreePerHour_1
DegreePerHour_1.ConversionFactorB = "206264.80624709636"
DegreePerHour_1.Symbol = "°/h"
```
## DegreePerMinute <!-- NOUN -->
- Display name: degree per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3437.746770784939
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per minute
[SI] is the value in SI
a = Degree*Minute, i.e., 3437.746770784939
and
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerMinute:DegreePerMinute_1
DegreePerMinute_1.ConversionFactorB = "3437.746770784939"
DegreePerMinute_1.Symbol = "°/min"
```
## SquareMetre <!-- NOUN -->
- Display name: square metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
SquareMetre:SquareMetre_1
SquareMetre_1.Symbol = "m²"
```
## SquareKilometre <!-- NOUN -->
- Display name: square kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in square kilometre
[SI] is the value in SI
a = 1.0/(Kilo*Kilo), i.e., 1E-06
and
Kilo = 1000.0

- Examples: 
``` dwis
SquareKilometre:SquareKilometre_1
SquareKilometre_1.ConversionFactorB = "1E-06"
SquareKilometre_1.Symbol = "km²"
```
## Hectare <!-- NOUN -->
- Display name: hectare
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in hectare
[SI] is the value in SI
a = 1.0/(Hecto*Hecto), i.e., 0.0001
and
Hecto = 100.0

- Examples: 
``` dwis
Hectare:Hectare_1
Hectare_1.ConversionFactorB = "0.0001"
Hectare_1.Symbol = "ha"
```
## SquareDecametre <!-- NOUN -->
- Display name: square decametre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in square decametre
[SI] is the value in SI
a = 1.0/(Deca*Deca), i.e., 0.01
and
Deca = 10.0

- Examples: 
``` dwis
SquareDecametre:SquareDecametre_1
SquareDecametre_1.ConversionFactorB = "0.01"
SquareDecametre_1.Symbol = "dam²"
```
## SquareDecimetre <!-- NOUN -->
- Display name: square decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 99.99999999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in square decimetre
[SI] is the value in SI
a = 1.0/(Deci*Deci), i.e., 99.99999999999999
and
Deci = 0.1

- Examples: 
``` dwis
SquareDecimetre:SquareDecimetre_1
SquareDecimetre_1.ConversionFactorB = "99.99999999999999"
SquareDecimetre_1.Symbol = "dm²"
```
## SquareCentimetre <!-- NOUN -->
- Display name: square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in square centimetre
[SI] is the value in SI
a = 1.0/(Centi*Centi), i.e., 10000
and
Centi = 0.01

- Examples: 
``` dwis
SquareCentimetre:SquareCentimetre_1
SquareCentimetre_1.ConversionFactorB = "10000"
SquareCentimetre_1.Symbol = "cm²"
```
## SquareMillimetre <!-- NOUN -->
- Display name: square millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in square millimetre
[SI] is the value in SI
a = 1.0/(Milli*Milli), i.e., 1000000
and
Milli = 0.001

- Examples: 
``` dwis
SquareMillimetre:SquareMillimetre_1
SquareMillimetre_1.ConversionFactorB = "1000000"
SquareMillimetre_1.Symbol = "mm²"
```
## SquareMicrometre <!-- NOUN -->
- Display name: square micrometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in square micrometre
[SI] is the value in SI
a = 1.0/(Micro*Micro), i.e., 1000000000000
and
Micro = 1e-6

- Examples: 
``` dwis
SquareMicrometre:SquareMicrometre_1
SquareMicrometre_1.ConversionFactorB = "1000000000000"
SquareMicrometre_1.Symbol = "µm²"
```
## SquareFoot <!-- NOUN -->
- Display name: square foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10.763910416709725
- Description: 
[v] = a * [SI]
where
[v] is the value in square foot
[SI] is the value in SI
a = 1.0/(Foot*Foot), i.e., 10.763910416709725
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
SquareFoot:SquareFoot_1
SquareFoot_1.ConversionFactorB = "10.763910416709725"
SquareFoot_1.Symbol = "ft²"
```
## SquareInch <!-- NOUN -->
- Display name: square inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1550.0031000062002
- Description: 
[v] = a * [SI]
where
[v] is the value in square inch
[SI] is the value in SI
a = 1.0/(Inch*Inch), i.e., 1550.0031000062002
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
SquareInch:SquareInch_1
SquareInch_1.ConversionFactorB = "1550.0031000062002"
SquareInch_1.Symbol = "in²"
```
## SquareYard <!-- NOUN -->
- Display name: square yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.1959900463010806
- Description: 
[v] = a * [SI]
where
[v] is the value in square yard
[SI] is the value in SI
a = 1.0/(Yard*Yard), i.e., 1.1959900463010806
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
SquareYard:SquareYard_1
SquareYard_1.ConversionFactorB = "1.1959900463010806"
SquareYard_1.Symbol = "yd²"
```
## Acre <!-- NOUN -->
- Display name: acre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002471053814671654
- Description: 
[v] = a * [SI]
where
[v] is the value in acre
[SI] is the value in SI
a = 1.0/Acre, i.e., 0.0002471053814671654
and
Acre = SurveyorChain * Furlong reference: https://en.wikipedia.org/wiki/Acre
SurveyorChain = 22.0 * Yard reference: https://www.britannica.com/technology/surveyors-chain
Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Acre:Acre_1
Acre_1.ConversionFactorB = "0.0002471053814671654"
Acre_1.Symbol = "ac"
```
## SquareMile <!-- NOUN -->
- Display name: square mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.861021585424459E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in square mile
[SI] is the value in SI
a = 1.0/(Mile*Mile), i.e., 3.861021585424459E-07
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
SquareMile:SquareMile_1
SquareMile_1.ConversionFactorB = "3.861021585424459E-07"
SquareMile_1.Symbol = "mi²"
```
## InversePascal <!-- NOUN -->
- Display name: inverse pascal
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
InversePascal:InversePascal_1
InversePascal_1.Symbol = "1/Pa"
```
## InverseBar <!-- NOUN -->
- Display name: inverse bar
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100000
- Description: 
[v] = a * [SI]
where
[v] is the value in inverse bar
[SI] is the value in SI
a = Bar, i.e., 100000
and
Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)

- Examples: 
``` dwis
InverseBar:InverseBar_1
InverseBar_1.ConversionFactorB = "100000"
InverseBar_1.Symbol = "1/bar"
```
## InversePoundPerSquareInch <!-- NOUN -->
- Display name: inverse pound per square inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6894.757293168361
- Description: 
[v] = a * [SI]
where
[v] is the value in inverse pound per square inch
[SI] is the value in SI
a = PSI, i.e., 6894.757293168361
and
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InversePoundPerSquareInch:InversePoundPerSquareInch_1
InversePoundPerSquareInch_1.ConversionFactorB = "6894.757293168361"
InversePoundPerSquareInch_1.Symbol = "1/psi"
```
## InverseAtmosphere <!-- NOUN -->
- Display name: inverse atmosphere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 101325
- Description: 
[v] = a * [SI]
where
[v] is the value in inverse atmosphere
[SI] is the value in SI
a = Atmosphere, i.e., 101325
and
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
InverseAtmosphere:InverseAtmosphere_1
InverseAtmosphere_1.ConversionFactorB = "101325"
InverseAtmosphere_1.Symbol = "1/atm"
```
## PascalSecond <!-- NOUN -->
- Display name: pascal second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
PascalSecond:PascalSecond_1
PascalSecond_1.Symbol = "Pa•s"
```
## MicropascalSecond <!-- NOUN -->
- Display name: micropascal second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in micropascal second
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
MicropascalSecond:MicropascalSecond_1
MicropascalSecond_1.ConversionFactorB = "1000000"
MicropascalSecond_1.Symbol = "µPa•s"
```
## Centipoise <!-- NOUN -->
- Display name: centipoise
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in centipoise
[SI] is the value in SI
a = 1.0/(Centi * Poise), i.e., 1000
and
Centi = 0.01
Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)

- Examples: 
``` dwis
Centipoise:Centipoise_1
Centipoise_1.ConversionFactorB = "1000"
Centipoise_1.Symbol = "cP"
```
## Micropoise <!-- NOUN -->
- Display name: micropoise
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000000
- Description: 
[v] = a * [SI]
where
[v] is the value in micropoise
[SI] is the value in SI
a = 1.0/(Micro* Poise), i.e., 10000000
and
Micro = 1e-6
Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)

- Examples: 
``` dwis
Micropoise:Micropoise_1
Micropoise_1.ConversionFactorB = "10000000"
Micropoise_1.Symbol = "µP"
```
## PoundSecondPer100SquareFoot <!-- NOUN -->
- Display name: pound second per 100 square foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.0885434233150124
- Description: 
[v] = a * [SI]
where
[v] is the value in pound second per 100 square foot
[SI] is the value in SI
a = (100.0*Foot*Foot)/(Pound * G), i.e., 2.0885434233150124
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundSecondPer100SquareFoot:PoundSecondPer100SquareFoot_1
PoundSecondPer100SquareFoot_1.ConversionFactorB = "2.0885434233150124"
PoundSecondPer100SquareFoot_1.Symbol = "lb•s/100ft²"
```
## DyneSecondPerSquareCentimetre <!-- NOUN -->
- Display name: dyne second per square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in dyne second per square centimetre
[SI] is the value in SI
a = 1.0/Poise, i.e., 10
and
Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)

- Examples: 
``` dwis
DyneSecondPerSquareCentimetre:DyneSecondPerSquareCentimetre_1
DyneSecondPerSquareCentimetre_1.ConversionFactorB = "10"
DyneSecondPerSquareCentimetre_1.Symbol = "dyne•s/cm²"
```
## DegreePer10m <!-- NOUN -->
- Display name: degree per 10m
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 572.9577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per 10m
[SI] is the value in SI
a = Degree*10.0, i.e., 572.9577951308232
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePer10m:DegreePer10m_1
DegreePer10m_1.ConversionFactorB = "572.9577951308232"
DegreePer10m_1.Symbol = "°/10m"
```
## DegreePer30m <!-- NOUN -->
- Display name: degree per 30m
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1718.8733853924696
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per 30m
[SI] is the value in SI
a = Degree*30.0, i.e., 1718.8733853924696
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePer30m:DegreePer30m_1
DegreePer30m_1.ConversionFactorB = "1718.8733853924696"
DegreePer30m_1.Symbol = "°/30m"
```
## DegreePer30ft <!-- NOUN -->
- Display name: degree per 30ft
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 523.9126078676246
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per 30ft
[SI] is the value in SI
a = Degree*30.0*Foot, i.e., 523.9126078676246
and
Degree = 180.0 / System.Math.PI
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DegreePer30ft:DegreePer30ft_1
DegreePer30ft_1.ConversionFactorB = "523.9126078676246"
DegreePer30ft_1.Symbol = "°/30ft"
```
## DegreePer100ft <!-- NOUN -->
- Display name: degree per 100ft
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1746.375359558749
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per 100ft
[SI] is the value in SI
a = Degree*100.0*Foot, i.e., 1746.375359558749
and
Degree = 180.0 / System.Math.PI
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DegreePer100ft:DegreePer100ft_1
DegreePer100ft_1.ConversionFactorB = "1746.375359558749"
DegreePer100ft_1.Symbol = "°/100ft"
```
## DegreePerDecimeter <!-- NOUN -->
- Display name: degree per decimeter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5.729577951308233
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per decimeter
[SI] is the value in SI
a = Degree*Deci, i.e., 5.729577951308233
and
Degree = 180.0 / System.Math.PI
Deci = 0.1

- Examples: 
``` dwis
DegreePerDecimeter:DegreePerDecimeter_1
DegreePerDecimeter_1.ConversionFactorB = "5.729577951308233"
DegreePerDecimeter_1.Symbol = "°/dm"
```
## DegreePerCentimeter <!-- NOUN -->
- Display name: degree per centimeter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.5729577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per centimeter
[SI] is the value in SI
a = Degree*Centi, i.e., 0.5729577951308232
and
Degree = 180.0 / System.Math.PI
Centi = 0.01

- Examples: 
``` dwis
DegreePerCentimeter:DegreePerCentimeter_1
DegreePerCentimeter_1.ConversionFactorB = "0.5729577951308232"
DegreePerCentimeter_1.Symbol = "°/cm"
```
## DegreePerMillimeter <!-- NOUN -->
- Display name: degree per millimeter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.057295779513082325
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per millimeter
[SI] is the value in SI
a = Degree*Milli, i.e., 0.057295779513082325
and
Degree = 180.0 / System.Math.PI
Milli = 0.001

- Examples: 
``` dwis
DegreePerMillimeter:DegreePerMillimeter_1
DegreePerMillimeter_1.ConversionFactorB = "0.057295779513082325"
DegreePerMillimeter_1.Symbol = "°/mm"
```
## DegreePerMicrometer <!-- NOUN -->
- Display name: degree per micrometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5.729577951308232E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per micrometer
[SI] is the value in SI
a = Degree*Micro, i.e., 5.729577951308232E-05
and
Degree = 180.0 / System.Math.PI
Micro = 1e-6

- Examples: 
``` dwis
DegreePerMicrometer:DegreePerMicrometer_1
DegreePerMicrometer_1.ConversionFactorB = "5.729577951308232E-05"
DegreePerMicrometer_1.Symbol = "°/mm"
```
## DegreePerNanometer <!-- NOUN -->
- Display name: degree per nanometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5.7295779513082324E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per nanometer
[SI] is the value in SI
a = Degree*Nano, i.e., 5.7295779513082324E-08
and
Degree = 180.0 / System.Math.PI
Nano = 1e-9

- Examples: 
``` dwis
DegreePerNanometer:DegreePerNanometer_1
DegreePerNanometer_1.ConversionFactorB = "5.7295779513082324E-08"
DegreePerNanometer_1.Symbol = "°/mm"
```
## DegreePerDecameter <!-- NOUN -->
- Display name: degree per decameter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 572.9577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per decameter
[SI] is the value in SI
a = Degree*Deca, i.e., 572.9577951308232
and
Degree = 180.0 / System.Math.PI
Deca = 10.0

- Examples: 
``` dwis
DegreePerDecameter:DegreePerDecameter_1
DegreePerDecameter_1.ConversionFactorB = "572.9577951308232"
DegreePerDecameter_1.Symbol = "°/dam"
```
## DegreePerHectometer <!-- NOUN -->
- Display name: degree per hectometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5729.5779513082325
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per hectometer
[SI] is the value in SI
a = Degree*Hecto, i.e., 5729.5779513082325
and
Degree = 180.0 / System.Math.PI
Hecto = 100.0

- Examples: 
``` dwis
DegreePerHectometer:DegreePerHectometer_1
DegreePerHectometer_1.ConversionFactorB = "5729.5779513082325"
DegreePerHectometer_1.Symbol = "°/hm"
```
## DegreePerKilometer <!-- NOUN -->
- Display name: degree per kilometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57295.77951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per kilometer
[SI] is the value in SI
a = Degree*Kilo, i.e., 57295.77951308232
and
Degree = 180.0 / System.Math.PI
Kilo = 1000.0

- Examples: 
``` dwis
DegreePerKilometer:DegreePerKilometer_1
DegreePerKilometer_1.ConversionFactorB = "57295.77951308232"
DegreePerKilometer_1.Symbol = "°/km"
```
## RadianPerDecimeter <!-- NOUN -->
- Display name: radian per decimeter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per decimeter
[SI] is the value in SI
a = Deci, i.e., 0.1
and
Deci = 0.1

- Examples: 
``` dwis
RadianPerDecimeter:RadianPerDecimeter_1
RadianPerDecimeter_1.ConversionFactorB = "0.1"
RadianPerDecimeter_1.Symbol = "rad/dm"
```
## RadianPerCentimeter <!-- NOUN -->
- Display name: radian per centimeter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per centimeter
[SI] is the value in SI
a = Centi, i.e., 0.01
and
Centi = 0.01

- Examples: 
``` dwis
RadianPerCentimeter:RadianPerCentimeter_1
RadianPerCentimeter_1.ConversionFactorB = "0.01"
RadianPerCentimeter_1.Symbol = "rad/cm"
```
## RadianPerMillimeter <!-- NOUN -->
- Display name: radian per millimeter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per millimeter
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
RadianPerMillimeter:RadianPerMillimeter_1
RadianPerMillimeter_1.ConversionFactorB = "0.001"
RadianPerMillimeter_1.Symbol = "rad/mm"
```
## RadianPerMicrometer <!-- NOUN -->
- Display name: radian per micrometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per micrometer
[SI] is the value in SI
a = Micro, i.e., 1E-06
and
Micro = 1e-6

- Examples: 
``` dwis
RadianPerMicrometer:RadianPerMicrometer_1
RadianPerMicrometer_1.ConversionFactorB = "1E-06"
RadianPerMicrometer_1.Symbol = "rad/mm"
```
## RadianPerNanometer <!-- NOUN -->
- Display name: radian per nanometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per nanometer
[SI] is the value in SI
a = Nano, i.e., 1E-09
and
Nano = 1e-9

- Examples: 
``` dwis
RadianPerNanometer:RadianPerNanometer_1
RadianPerNanometer_1.ConversionFactorB = "1E-09"
RadianPerNanometer_1.Symbol = "rad/mm"
```
## RadianPerDecameter <!-- NOUN -->
- Display name: radian per decameter
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per decameter
[SI] is the value in SI
a = Deca, i.e., 10
and
Deca = 10.0

- Examples: 
``` dwis
RadianPerDecameter:RadianPerDecameter_1
RadianPerDecameter_1.ConversionFactorB = "10"
RadianPerDecameter_1.Symbol = "rad/dam"
```
## RadianPerHectometer <!-- NOUN -->
- Display name: radian per hectometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per hectometer
[SI] is the value in SI
a = Hecto, i.e., 100
and
Hecto = 100.0

- Examples: 
``` dwis
RadianPerHectometer:RadianPerHectometer_1
RadianPerHectometer_1.ConversionFactorB = "100"
RadianPerHectometer_1.Symbol = "rad/hm"
```
## RadianPerKilometer <!-- NOUN -->
- Display name: radian per kilometer
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per kilometer
[SI] is the value in SI
a = Kilo, i.e., 1000
and
Kilo = 1000.0

- Examples: 
``` dwis
RadianPerKilometer:RadianPerKilometer_1
RadianPerKilometer_1.ConversionFactorB = "1000"
RadianPerKilometer_1.Symbol = "rad/km"
```
## DegreePerYard <!-- NOUN -->
- Display name: degree per yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 52.391260786762466
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per yard
[SI] is the value in SI
a = Degree*Yard, i.e., 52.391260786762466
and
Degree = 180.0 / System.Math.PI
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DegreePerYard:DegreePerYard_1
DegreePerYard_1.ConversionFactorB = "52.391260786762466"
DegreePerYard_1.Symbol = "°/yd"
```
## DegreePerMile <!-- NOUN -->
- Display name: degree per mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 92208.61898470194
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per mile
[SI] is the value in SI
a = Degree*Mile, i.e., 92208.61898470194
and
Degree = 180.0 / System.Math.PI
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DegreePerMile:DegreePerMile_1
DegreePerMile_1.ConversionFactorB = "92208.61898470194"
DegreePerMile_1.Symbol = "°/mi"
```
## RadianPerYard <!-- NOUN -->
- Display name: radian per yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.9143999999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per yard
[SI] is the value in SI
a = Yard, i.e., 0.9143999999999999
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
RadianPerYard:RadianPerYard_1
RadianPerYard_1.ConversionFactorB = "0.9143999999999999"
RadianPerYard_1.Symbol = "rad/yd"
```
## RadianPerMile <!-- NOUN -->
- Display name: radian per mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1609.3439999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per mile
[SI] is the value in SI
a = Mile, i.e., 1609.3439999999998
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
RadianPerMile:RadianPerMile_1
RadianPerMile_1.ConversionFactorB = "1609.3439999999998"
RadianPerMile_1.Symbol = "rad/mi"
```
## KilogramPerCubicMetrePerMetre <!-- NOUN -->
- Display name: kilogram per cubic metre per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KilogramPerCubicMetrePerMetre:KilogramPerCubicMetrePerMetre_1
KilogramPerCubicMetrePerMetre_1.Symbol = "kg/m³/m"
```
## SpecificGravityPerMetre <!-- NOUN -->
- Display name: specific gravity per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001000028000784022
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per metre
[SI] is the value in SI
a = SpecificGavity4degC, i.e., 0.001000028000784022
and
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPerMetre:SpecificGravityPerMetre_1
SpecificGravityPerMetre_1.ConversionFactorB = "0.001000028000784022"
SpecificGravityPerMetre_1.Symbol = "sg/m"
```
## SpecificGravityPer10Metre <!-- NOUN -->
- Display name: specific gravity per 10 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01000028000784022
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per 10 metre
[SI] is the value in SI
a = Deca*SpecificGavity4degC, i.e., 0.01000028000784022
and
Deca = 10.0
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPer10Metre:SpecificGravityPer10Metre_1
SpecificGravityPer10Metre_1.ConversionFactorB = "0.01000028000784022"
SpecificGravityPer10Metre_1.Symbol = "sg/10m"
```
## SpecificGravityPer30Metre <!-- NOUN -->
- Display name: specific gravity per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.03000084002352066
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per 30 metre
[SI] is the value in SI
a = 3.0*Deca*SpecificGavity4degC, i.e., 0.03000084002352066
and
Deca = 10.0
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPer30Metre:SpecificGravityPer30Metre_1
SpecificGravityPer30Metre_1.ConversionFactorB = "0.03000084002352066"
SpecificGravityPer30Metre_1.Symbol = "sg/30m"
```
## SpecificGravityPer100Metre <!-- NOUN -->
- Display name: specific gravity per 100 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10000280007840219
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per 100 metre
[SI] is the value in SI
a = Hecto*SpecificGavity4degC, i.e., 0.10000280007840219
and
Hecto = 100.0
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPer100Metre:SpecificGravityPer100Metre_1
SpecificGravityPer100Metre_1.ConversionFactorB = "0.10000280007840219"
SpecificGravityPer100Metre_1.Symbol = "sg/100m"
```
## GramPerCubicCentimetrePer100Metre <!-- NOUN -->
- Display name: gram per cubic centimetre per 100 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10000000000000002
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per 100 metre
[SI] is the value in SI
a = Centi*Centi*Centi*Hecto/Milli, i.e., 0.10000000000000002
and
Centi = 0.01
Hecto = 100.0
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePer100Metre:GramPerCubicCentimetrePer100Metre_1
GramPerCubicCentimetrePer100Metre_1.ConversionFactorB = "0.10000000000000002"
GramPerCubicCentimetrePer100Metre_1.Symbol = "g/cm³/100m"
```
## PoundPerGallonUkPerFoot <!-- NOUN -->
- Display name: pound per gallon (UK) per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00305483143819196
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per foot
[SI] is the value in SI
a = GallonUK*Foot/Pound, i.e., 0.00305483143819196
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUkPerFoot:PoundPerGallonUkPerFoot_1
PoundPerGallonUkPerFoot_1.ConversionFactorB = "0.00305483143819196"
PoundPerGallonUkPerFoot_1.Symbol = "ppgUK/ft"
```
## PoundPerGallonUkPer30Foot <!-- NOUN -->
- Display name: pound per gallon (UK) per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0916449431457588
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per 30 foot
[SI] is the value in SI
a = GallonUK*30.0*Foot/Pound, i.e., 0.0916449431457588
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUkPer30Foot:PoundPerGallonUkPer30Foot_1
PoundPerGallonUkPer30Foot_1.ConversionFactorB = "0.0916449431457588"
PoundPerGallonUkPer30Foot_1.Symbol = "ppgUK/30ft"
```
## PoundPerGallonUkPer100Foot <!-- NOUN -->
- Display name: pound per gallon (UK) per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.305483143819196
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per 100 foot
[SI] is the value in SI
a = GallonUK*100.0*Foot/Pound, i.e., 0.305483143819196
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUkPer100Foot:PoundPerGallonUkPer100Foot_1
PoundPerGallonUkPer100Foot_1.ConversionFactorB = "0.305483143819196"
PoundPerGallonUkPer100Foot_1.Symbol = "ppgUK/100ft"
```
## PoundPerGallonUsPerFoot <!-- NOUN -->
- Display name: pound per gallon (US) per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0025436792769754917
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per foot
[SI] is the value in SI
a = GallonUS*Foot/Pound, i.e., 0.0025436792769754917
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPerFoot:PoundPerGallonUsPerFoot_1
PoundPerGallonUsPerFoot_1.ConversionFactorB = "0.0025436792769754917"
PoundPerGallonUsPerFoot_1.Symbol = "ppgUS/ft"
```
## PoundPerGallonUsPer30Foot <!-- NOUN -->
- Display name: pound per gallon (US) per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.07631037830926475
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per 30 foot
[SI] is the value in SI
a = GallonUS*30.0*Foot/Pound, i.e., 0.07631037830926475
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPer30Foot:PoundPerGallonUsPer30Foot_1
PoundPerGallonUsPer30Foot_1.ConversionFactorB = "0.07631037830926475"
PoundPerGallonUsPer30Foot_1.Symbol = "ppgUS/30ft"
```
## PoundPerGallonUsPer100Foot <!-- NOUN -->
- Display name: pound per gallon (US) per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2543679276975492
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per 100 foot
[SI] is the value in SI
a = GallonUS*100.0*Foot/Pound, i.e., 0.2543679276975492
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPer100Foot:PoundPerGallonUsPer100Foot_1
PoundPerGallonUsPer100Foot_1.ConversionFactorB = "0.2543679276975492"
PoundPerGallonUsPer100Foot_1.Symbol = "ppgUS/100ft"
```
## KilogramPerCubicMetrePer10Metre <!-- NOUN -->
- Display name: kilogram per cubic metre per 10 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram per cubic metre per 10 metre
[SI] is the value in SI
a = Deca/Unit, i.e., 10
and
Deca = 10.0
Unit = 1.0

- Examples: 
``` dwis
KilogramPerCubicMetrePer10Metre:KilogramPerCubicMetrePer10Metre_1
KilogramPerCubicMetrePer10Metre_1.ConversionFactorB = "10"
KilogramPerCubicMetrePer10Metre_1.Symbol = "kg/m³/10m"
```
## KilogramPerCubicMetrePer30Metre <!-- NOUN -->
- Display name: kilogram per cubic metre per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram per cubic metre per 30 metre
[SI] is the value in SI
a = 3.0 *Deca/Unit, i.e., 30
and
Deca = 10.0
Unit = 1.0

- Examples: 
``` dwis
KilogramPerCubicMetrePer30Metre:KilogramPerCubicMetrePer30Metre_1
KilogramPerCubicMetrePer30Metre_1.ConversionFactorB = "30"
KilogramPerCubicMetrePer30Metre_1.Symbol = "kg/m³/30m"
```
## KilogramPerCubicMetrePer100Metre <!-- NOUN -->
- Display name: kilogram per cubic metre per 100 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram per cubic metre per 100 metre
[SI] is the value in SI
a = Hecto/Unit, i.e., 100
and
Hecto = 100.0
Unit = 1.0

- Examples: 
``` dwis
KilogramPerCubicMetrePer100Metre:KilogramPerCubicMetrePer100Metre_1
KilogramPerCubicMetrePer100Metre_1.ConversionFactorB = "100"
KilogramPerCubicMetrePer100Metre_1.Symbol = "kg/m³/30m"
```
## GramPerCubicCentimetrePerMetre <!-- NOUN -->
- Display name: gram per cubic centimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0010000000000000002
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per metre
[SI] is the value in SI
a = Centi*Centi*Centi/Milli, i.e., 0.0010000000000000002
and
Centi = 0.01
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePerMetre:GramPerCubicCentimetrePerMetre_1
GramPerCubicCentimetrePerMetre_1.ConversionFactorB = "0.0010000000000000002"
GramPerCubicCentimetrePerMetre_1.Symbol = "g/cm³/m"
```
## GramPerCubicCentimetrePer10Metre <!-- NOUN -->
- Display name: gram per cubic centimetre per 10 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.010000000000000002
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per 10 metre
[SI] is the value in SI
a = Centi*Centi*Centi*Deca/Milli, i.e., 0.010000000000000002
and
Centi = 0.01
Deca = 10.0
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePer10Metre:GramPerCubicCentimetrePer10Metre_1
GramPerCubicCentimetrePer10Metre_1.ConversionFactorB = "0.010000000000000002"
GramPerCubicCentimetrePer10Metre_1.Symbol = "g/cm³/10m"
```
## GramPerCubicCentimetrePer30Metre <!-- NOUN -->
- Display name: gram per cubic centimetre per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.030000000000000002
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per 30 metre
[SI] is the value in SI
a = Centi*Centi*Centi*3.0*Deca/Milli, i.e., 0.030000000000000002
and
Centi = 0.01
Deca = 10.0
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePer30Metre:GramPerCubicCentimetrePer30Metre_1
GramPerCubicCentimetrePer30Metre_1.ConversionFactorB = "0.030000000000000002"
GramPerCubicCentimetrePer30Metre_1.Symbol = "g/cm³/30m"
```
## PoundPerCubicFootPerFoot <!-- NOUN -->
- Display name: pound per cubic foot per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.019028042383608865
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic foot per foot
[SI] is the value in SI
a = Foot*Foot*Foot*Foot/Pound, i.e., 0.019028042383608865
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicFootPerFoot:PoundPerCubicFootPerFoot_1
PoundPerCubicFootPerFoot_1.ConversionFactorB = "0.019028042383608865"
PoundPerCubicFootPerFoot_1.Symbol = "lb/ft³/ft"
```
## PoundPerCubicFootPer30Foot <!-- NOUN -->
- Display name: pound per cubic foot per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.570841271508266
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic foot per 30 foot
[SI] is the value in SI
a = Foot*Foot*Foot*30.0*Foot/Pound, i.e., 0.570841271508266
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicFootPer30Foot:PoundPerCubicFootPer30Foot_1
PoundPerCubicFootPer30Foot_1.ConversionFactorB = "0.570841271508266"
PoundPerCubicFootPer30Foot_1.Symbol = "lb/ft³/30ft"
```
## PoundPerCubicFootPer100Foot <!-- NOUN -->
- Display name: pound per cubic foot per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.902804238360887
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic foot per 100 foot
[SI] is the value in SI
a = Foot*Foot*Foot*100.0*Foot/Pound, i.e., 1.902804238360887
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicFootPer100Foot:PoundPerCubicFootPer100Foot_1
PoundPerCubicFootPer100Foot_1.ConversionFactorB = "1.902804238360887"
PoundPerCubicFootPer100Foot_1.Symbol = "lb/ft³/100ft"
```
## PoundPerCubicInchPerFoot <!-- NOUN -->
- Display name: pound per cubic inch per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.1011598601625506E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic inch per foot
[SI] is the value in SI
a = Inch*Inch*Inch*Foot/Pound, i.e., 1.1011598601625506E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerCubicInchPerFoot:PoundPerCubicInchPerFoot_1
PoundPerCubicInchPerFoot_1.ConversionFactorB = "1.1011598601625506E-05"
PoundPerCubicInchPerFoot_1.Symbol = "lb/in³/ft"
```
## PoundPerCubicInchPer30Foot <!-- NOUN -->
- Display name: pound per cubic inch per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00033034795804876514
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic inch per 30 foot
[SI] is the value in SI
a = Inch*Inch*Inch*30.0*Foot/Pound, i.e., 0.00033034795804876514
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerCubicInchPer30Foot:PoundPerCubicInchPer30Foot_1
PoundPerCubicInchPer30Foot_1.ConversionFactorB = "0.00033034795804876514"
PoundPerCubicInchPer30Foot_1.Symbol = "lb/in³/30ft"
```
## PoundPerCubicInchPer100Foot <!-- NOUN -->
- Display name: pound per cubic inch per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0011011598601625506
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic inch per 100 foot
[SI] is the value in SI
a = Inch*Inch*Inch*100.0*Foot/Pound, i.e., 0.0011011598601625506
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerCubicInchPer100Foot:PoundPerCubicInchPer100Foot_1
PoundPerCubicInchPer100Foot_1.ConversionFactorB = "0.0011011598601625506"
PoundPerCubicInchPer100Foot_1.Symbol = "lb/in³/100ft"
```
## PoundPerCubicYardPerFoot <!-- NOUN -->
- Display name: pound per cubic yard per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.5137571443574394
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic yard per foot
[SI] is the value in SI
a = Yard*Yard*Yard*Foot/Pound, i.e., 0.5137571443574394
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicYardPerFoot:PoundPerCubicYardPerFoot_1
PoundPerCubicYardPerFoot_1.ConversionFactorB = "0.5137571443574394"
PoundPerCubicYardPerFoot_1.Symbol = "lb/yd³/ft"
```
## PoundPerCubicYardPer30Foot <!-- NOUN -->
- Display name: pound per cubic yard per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 15.412714330723183
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic yard per 30 foot
[SI] is the value in SI
a = Yard*Yard*Yard*30.0*Foot/Pound, i.e., 15.412714330723183
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicYardPer30Foot:PoundPerCubicYardPer30Foot_1
PoundPerCubicYardPer30Foot_1.ConversionFactorB = "15.412714330723183"
PoundPerCubicYardPer30Foot_1.Symbol = "lb/yd³/30ft"
```
## PoundPerCubicYardPer100Foot <!-- NOUN -->
- Display name: pound per cubic yard per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 51.37571443574393
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic yard per 100 foot
[SI] is the value in SI
a = Yard*Yard*Yard*100.0*Foot/Pound, i.e., 51.37571443574393
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicYardPer100Foot:PoundPerCubicYardPer100Foot_1
PoundPerCubicYardPer100Foot_1.ConversionFactorB = "51.37571443574393"
PoundPerCubicYardPer100Foot_1.Symbol = "lb/yd³/100ft"
```
## KilogramPerCubicMetrePerKelvin <!-- NOUN -->
- Display name: kilogram per cubic metre per kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KilogramPerCubicMetrePerKelvin:KilogramPerCubicMetrePerKelvin_1
KilogramPerCubicMetrePerKelvin_1.Symbol = "kg/m³/K"
```
## SpecificGravityPerCelsius <!-- NOUN -->
- Display name: specific gravity per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001000028000784022
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per celsius
[SI] is the value in SI
a = SpecificGavity4degC, i.e., 0.001000028000784022
and
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPerCelsius:SpecificGravityPerCelsius_1
SpecificGravityPerCelsius_1.ConversionFactorB = "0.001000028000784022"
SpecificGravityPerCelsius_1.Symbol = "sg/°C"
```
## GramPerCubicCentimetrePerCelsius <!-- NOUN -->
- Display name: gram per cubic centimetre per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0010000000000000002
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per celsius
[SI] is the value in SI
a = Centi*Centi*Centi/Milli, i.e., 0.0010000000000000002
and
Centi = 0.01
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePerCelsius:GramPerCubicCentimetrePerCelsius_1
GramPerCubicCentimetrePerCelsius_1.ConversionFactorB = "0.0010000000000000002"
GramPerCubicCentimetrePerCelsius_1.Symbol = "g/cm³/°C"
```
## PoundPerGallonUkPerCelsius <!-- NOUN -->
- Display name: pound per gallon (UK) per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.010022412854960501
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per celsius
[SI] is the value in SI
a = GallonUK/Pound, i.e., 0.010022412854960501
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerGallonUkPerCelsius:PoundPerGallonUkPerCelsius_1
PoundPerGallonUkPerCelsius_1.ConversionFactorB = "0.010022412854960501"
PoundPerGallonUkPerCelsius_1.Symbol = "ppgUK/°C"
```
## PoundPerGallonUsPerFahrenheit <!-- NOUN -->
- Display name: pound per gallon (US) per fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.004636335806677406
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per fahrenheit
[SI] is the value in SI
a = GallonUS*FahrenheitSlope/Pound, i.e., 0.004636335806677406
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPerFahrenheit:PoundPerGallonUsPerFahrenheit_1
PoundPerGallonUsPerFahrenheit_1.ConversionFactorB = "0.004636335806677406"
PoundPerGallonUsPerFahrenheit_1.Symbol = "ppgUS/°F"
```
## PoundPerGallonUkPerFahrenheit <!-- NOUN -->
- Display name: pound per gallon (UK) per fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.005568007141644723
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per fahrenheit
[SI] is the value in SI
a = GallonUK*FahrenheitSlope/Pound, i.e., 0.005568007141644723
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerGallonUkPerFahrenheit:PoundPerGallonUkPerFahrenheit_1
PoundPerGallonUkPerFahrenheit_1.ConversionFactorB = "0.005568007141644723"
PoundPerGallonUkPerFahrenheit_1.Symbol = "ppgUK/°F"
```
## PoundPerGallonUsPerCelsius <!-- NOUN -->
- Display name: pound per gallon (US) per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00834540445201933
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per celsius
[SI] is the value in SI
a = GallonUS/Pound, i.e., 0.00834540445201933
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPerCelsius:PoundPerGallonUsPerCelsius_1
PoundPerGallonUsPerCelsius_1.ConversionFactorB = "0.00834540445201933"
PoundPerGallonUsPerCelsius_1.Symbol = "ppgUS/°C"
```
## PoundPerCubicFootPerCelsius <!-- NOUN -->
- Display name: pound per cubic foot per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06242796057614459
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic foot per celsius
[SI] is the value in SI
a = Foot*Foot*Foot/Pound, i.e., 0.06242796057614459
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicFootPerCelsius:PoundPerCubicFootPerCelsius_1
PoundPerCubicFootPerCelsius_1.ConversionFactorB = "0.06242796057614459"
PoundPerCubicFootPerCelsius_1.Symbol = "lb/ft³/°C"
```
## PoundPerCubicFootPerFahrenheit <!-- NOUN -->
- Display name: pound per cubic foot per fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.03468220032008033
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic foot per fahrenheit
[SI] is the value in SI
a = Foot*Foot*Foot*FahrenheitSlope/Pound, i.e., 0.03468220032008033
and
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicFootPerFahrenheit:PoundPerCubicFootPerFahrenheit_1
PoundPerCubicFootPerFahrenheit_1.ConversionFactorB = "0.03468220032008033"
PoundPerCubicFootPerFahrenheit_1.Symbol = "lb/ft³/°F"
```
## PoundPerCubicInchPerCelsius <!-- NOUN -->
- Display name: pound per cubic inch per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.612729200008369E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic inch per celsius
[SI] is the value in SI
a = Inch*Inch*Inch/Pound, i.e., 3.612729200008369E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerCubicInchPerCelsius:PoundPerCubicInchPerCelsius_1
PoundPerCubicInchPerCelsius_1.ConversionFactorB = "3.612729200008369E-05"
PoundPerCubicInchPerCelsius_1.Symbol = "lb/in³/°C"
```
## PoundPerCubicInchPerFahrenheit <!-- NOUN -->
- Display name: pound per cubic inch per fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.0070717777824268E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic inch per fahrenheit
[SI] is the value in SI
a = Inch*Inch*Inch*FahrenheitSlope/Pound, i.e., 2.0070717777824268E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerCubicInchPerFahrenheit:PoundPerCubicInchPerFahrenheit_1
PoundPerCubicInchPerFahrenheit_1.ConversionFactorB = "2.0070717777824268E-05"
PoundPerCubicInchPerFahrenheit_1.Symbol = "lb/in³/°F"
```
## PoundPerCubicYardPerCelsius <!-- NOUN -->
- Display name: pound per cubic yard per celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6855549355559039
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic yard per celsius
[SI] is the value in SI
a = Yard*Yard*Yard/Pound, i.e., 1.6855549355559039
and
Yard = 3.0 * Foot
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicYardPerCelsius:PoundPerCubicYardPerCelsius_1
PoundPerCubicYardPerCelsius_1.ConversionFactorB = "1.6855549355559039"
PoundPerCubicYardPerCelsius_1.Symbol = "lb/yd³/°C"
```
## PoundPerCubicYeardPerFahrenheit <!-- NOUN -->
- Display name: pound per cubic yeard per fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.9364194086421688
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic yeard per fahrenheit
[SI] is the value in SI
a = Yard*Yard*Yard*FahrenheitSlope/Pound, i.e., 0.9364194086421688
and
Yard = 3.0 * Foot
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicYeardPerFahrenheit:PoundPerCubicYeardPerFahrenheit_1
PoundPerCubicYeardPerFahrenheit_1.ConversionFactorB = "0.9364194086421688"
PoundPerCubicYeardPerFahrenheit_1.Symbol = "lb/yd³/°F"
```
## KilogramPerCubicMetre <!-- NOUN -->
- Display name: kilogram per cubic metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KilogramPerCubicMetre:KilogramPerCubicMetre_1
KilogramPerCubicMetre_1.Symbol = "kg/m³"
```
## GramPerCubicMetre <!-- NOUN -->
- Display name: gram per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic metre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicMetre:GramPerCubicMetre_1
GramPerCubicMetre_1.ConversionFactorB = "1000"
GramPerCubicMetre_1.Symbol = "g/m³"
```
## SpecificGravity <!-- NOUN -->
- Display name: specific gravity
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999.972
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity
[SI] is the value in SI
a = 1.0/SpecificGavity4degC, i.e., 999.972
and
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravity:SpecificGravity_1
SpecificGravity_1.ConversionFactorB = "999.972"
SpecificGravity_1.Symbol = "s.g."
```
## GramPerCubicCentimetre <!-- NOUN -->
- Display name: gram per cubic centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0010000000000000002
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre
[SI] is the value in SI
a = Centi*Centi*Centi / Milli, i.e., 0.0010000000000000002
and
Centi = 0.01
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetre:GramPerCubicCentimetre_1
GramPerCubicCentimetre_1.ConversionFactorB = "0.0010000000000000002"
GramPerCubicCentimetre_1.Symbol = "g/cm³"
```
## PoundPerGallonUk <!-- NOUN -->
- Display name: pound per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.010022412854960501
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK)
[SI] is the value in SI
a = 1.0/PPGUK, i.e., 0.010022412854960501
and
PPGUK = Pound / GallonUK
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
PoundPerGallonUk:PoundPerGallonUk_1
PoundPerGallonUk_1.ConversionFactorB = "0.010022412854960501"
PoundPerGallonUk_1.Symbol = "ppgUK"
```
## PoundPerGallonUs <!-- NOUN -->
- Display name: pound per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00834540445201933
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US)
[SI] is the value in SI
a = 1.0/PPGUS, i.e., 0.00834540445201933
and
PPGUS = Pound / GallonUS
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUs:PoundPerGallonUs_1
PoundPerGallonUs_1.ConversionFactorB = "0.00834540445201933"
PoundPerGallonUs_1.Symbol = "ppgUS"
```
## PoundPerCubicFoot <!-- NOUN -->
- Display name: pound per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06242796057614459
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic foot
[SI] is the value in SI
a = Foot*Foot*Foot/Pound, i.e., 0.06242796057614459
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicFoot:PoundPerCubicFoot_1
PoundPerCubicFoot_1.ConversionFactorB = "0.06242796057614459"
PoundPerCubicFoot_1.Symbol = "lb/ft³"
```
## PoundPerCubicInch <!-- NOUN -->
- Display name: pound per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.612729200008369E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/Pound, i.e., 3.612729200008369E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerCubicInch:PoundPerCubicInch_1
PoundPerCubicInch_1.ConversionFactorB = "3.612729200008369E-05"
PoundPerCubicInch_1.Symbol = "lb/in³"
```
## PoundPerCubicYard <!-- NOUN -->
- Display name: pound per cubic yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6855549355559039
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per cubic yard
[SI] is the value in SI
a = Yard*Yard*Yard/Pound, i.e., 1.6855549355559039
and
Yard = 3.0 * Foot
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerCubicYard:PoundPerCubicYard_1
PoundPerCubicYard_1.ConversionFactorB = "1.6855549355559039"
PoundPerCubicYard_1.Symbol = "lb/yd³"
```
## KilogramPerCubicMetrePerSecond <!-- NOUN -->
- Display name: kilogram per cubic metre per second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KilogramPerCubicMetrePerSecond:KilogramPerCubicMetrePerSecond_1
KilogramPerCubicMetrePerSecond_1.Symbol = "kg/m³/s"
```
## SpecificGravityPerSecond <!-- NOUN -->
- Display name: specific gravity per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001000028000784022
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per second
[SI] is the value in SI
a = 1.0/WaterDensity4degC1Atm, i.e., 0.001000028000784022
and
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPerSecond:SpecificGravityPerSecond_1
SpecificGravityPerSecond_1.ConversionFactorB = "0.001000028000784022"
SpecificGravityPerSecond_1.Symbol = "sg/s"
```
## SpecificGravityPerMinute <!-- NOUN -->
- Display name: specific gravity per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06000168004704132
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per minute
[SI] is the value in SI
a = Minute / WaterDensity4degC1Atm, i.e., 0.06000168004704132
and
Minute = 60.0
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
SpecificGravityPerMinute:SpecificGravityPerMinute_1
SpecificGravityPerMinute_1.ConversionFactorB = "0.06000168004704132"
SpecificGravityPerMinute_1.Symbol = "sg/min"
```
## SpecificGravityPerHour <!-- NOUN -->
- Display name: specific gravity per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.600100802822479
- Description: 
[v] = a * [SI]
where
[v] is the value in specific gravity per hour
[SI] is the value in SI
a = Hour / WaterDensity4degC1Atm, i.e., 3.600100802822479
and
Hour = 60.0 * Minute
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density
Minute = 60.0

- Examples: 
``` dwis
SpecificGravityPerHour:SpecificGravityPerHour_1
SpecificGravityPerHour_1.ConversionFactorB = "3.600100802822479"
SpecificGravityPerHour_1.Symbol = "sg/h"
```
## GramPerCubicCentimetrePerSecond <!-- NOUN -->
- Display name: gram per cubic centimetre per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per second
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePerSecond:GramPerCubicCentimetrePerSecond_1
GramPerCubicCentimetrePerSecond_1.ConversionFactorB = "0.001"
GramPerCubicCentimetrePerSecond_1.Symbol = "g/cm³/s"
```
## GramPerCubicCentimetrePerMinute <!-- NOUN -->
- Display name: gram per cubic centimetre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per minute
[SI] is the value in SI
a = Minute * Milli, i.e., 0.06
and
Minute = 60.0
Milli = 0.001

- Examples: 
``` dwis
GramPerCubicCentimetrePerMinute:GramPerCubicCentimetrePerMinute_1
GramPerCubicCentimetrePerMinute_1.ConversionFactorB = "0.06"
GramPerCubicCentimetrePerMinute_1.Symbol = "g/cm³/min"
```
## GramPerCubicCentimetrePerHour <!-- NOUN -->
- Display name: gram per cubic centimetre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.6
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per cubic centimetre per hour
[SI] is the value in SI
a = Hour *Milli, i.e., 3.6
and
Hour = 60.0 * Minute
Milli = 0.001
Minute = 60.0

- Examples: 
``` dwis
GramPerCubicCentimetrePerHour:GramPerCubicCentimetrePerHour_1
GramPerCubicCentimetrePerHour_1.ConversionFactorB = "3.6"
GramPerCubicCentimetrePerHour_1.Symbol = "g/cm³/h"
```
## PoundPerGallonUkPerSecond <!-- NOUN -->
- Display name: pound per gallon (UK) per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.010022412854960501
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per second
[SI] is the value in SI
a = 1.0 / PPGUK, i.e., 0.010022412854960501
and
PPGUK = Pound / GallonUK
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
PoundPerGallonUkPerSecond:PoundPerGallonUkPerSecond_1
PoundPerGallonUkPerSecond_1.ConversionFactorB = "0.010022412854960501"
PoundPerGallonUkPerSecond_1.Symbol = "ppgUK/s"
```
## PoundPerGallonUkPerMinute <!-- NOUN -->
- Display name: pound per gallon (UK) per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.6013447712976301
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per minute
[SI] is the value in SI
a = Minute / PPGUK, i.e., 0.6013447712976301
and
Minute = 60.0
PPGUK = Pound / GallonUK
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
PoundPerGallonUkPerMinute:PoundPerGallonUkPerMinute_1
PoundPerGallonUkPerMinute_1.ConversionFactorB = "0.6013447712976301"
PoundPerGallonUkPerMinute_1.Symbol = "ppgUK/min"
```
## PoundPerGallonUkPerHour <!-- NOUN -->
- Display name: pound per gallon (UK) per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 36.08068627785781
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (UK) per hour
[SI] is the value in SI
a = Hour / PPGUK, i.e., 36.08068627785781
and
Hour = 60.0 * Minute
PPGUK = Pound / GallonUK
Minute = 60.0
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
PoundPerGallonUkPerHour:PoundPerGallonUkPerHour_1
PoundPerGallonUkPerHour_1.ConversionFactorB = "36.08068627785781"
PoundPerGallonUkPerHour_1.Symbol = "ppgUK/h"
```
## PoundPerGallonUsPerSecond <!-- NOUN -->
- Display name: pound per gallon (US) per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00834540445201933
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per second
[SI] is the value in SI
a = 1.0 /PPGUS, i.e., 0.00834540445201933
and
PPGUS = Pound / GallonUS
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPerSecond:PoundPerGallonUsPerSecond_1
PoundPerGallonUsPerSecond_1.ConversionFactorB = "0.00834540445201933"
PoundPerGallonUsPerSecond_1.Symbol = "ppgUS/s"
```
## PoundPerGallonUsPerMinute <!-- NOUN -->
- Display name: pound per gallon (US) per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.5007242671211598
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per minute
[SI] is the value in SI
a = Minute / PPGUS, i.e., 0.5007242671211598
and
Minute = 60.0
PPGUS = Pound / GallonUS
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPerMinute:PoundPerGallonUsPerMinute_1
PoundPerGallonUsPerMinute_1.ConversionFactorB = "0.5007242671211598"
PoundPerGallonUsPerMinute_1.Symbol = "ppgUS/min"
```
## PoundPerGallonUsPerHour <!-- NOUN -->
- Display name: pound per gallon (US) per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30.043456027269592
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per gallon (US) per hour
[SI] is the value in SI
a = Hour / PPGUS, i.e., 30.043456027269592
and
Hour = 60.0 * Minute
PPGUS = Pound / GallonUS
Minute = 60.0
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundPerGallonUsPerHour:PoundPerGallonUsPerHour_1
PoundPerGallonUsPerHour_1.ConversionFactorB = "30.043456027269592"
PoundPerGallonUsPerHour_1.Symbol = "ppgUS/h"
```
## Dimensionless <!-- NOUN -->
- Display name: dimensionless
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Dimensionless:Dimensionless_1
```
## MillipascalSecond <!-- NOUN -->
- Display name: millipascal second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millipascal second
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
MillipascalSecond:MillipascalSecond_1
MillipascalSecond_1.ConversionFactorB = "1000"
MillipascalSecond_1.Symbol = "mPa•s"
```
## Poise <!-- NOUN -->
- Display name: poise
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in poise
[SI] is the value in SI
a = 1.0/Poise, i.e., 10
and
Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)

- Examples: 
``` dwis
Poise:Poise_1
Poise_1.ConversionFactorB = "10"
Poise_1.Symbol = "P"
```
## Millipoise <!-- NOUN -->
- Display name: millipoise
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in millipoise
[SI] is the value in SI
a = 1.0/(Milli* Poise), i.e., 10000
and
Milli = 0.001
Poise = 0.1 reference: https://en.wikipedia.org/wiki/Poise_(unit)

- Examples: 
``` dwis
Millipoise:Millipoise_1
Millipoise_1.ConversionFactorB = "10000"
Millipoise_1.Symbol = "mP"
```
## PoundSecondPerSquareFoot <!-- NOUN -->
- Display name: pound second per square foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.020885434233150126
- Description: 
[v] = a * [SI]
where
[v] is the value in pound second per square foot
[SI] is the value in SI
a = (Foot*Foot)/(Pound * G), i.e., 0.020885434233150126
and
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
PoundSecondPerSquareFoot:PoundSecondPerSquareFoot_1
PoundSecondPerSquareFoot_1.ConversionFactorB = "0.020885434233150126"
PoundSecondPerSquareFoot_1.Symbol = "lb•s/ft²"
```
## PoundSecondPerSquareInch <!-- NOUN -->
- Display name: pound second per square inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001450377377302092
- Description: 
[v] = a * [SI]
where
[v] is the value in pound second per square inch
[SI] is the value in SI
a = (Inch*Inch)/(Pound * G), i.e., 0.0001450377377302092
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundSecondPerSquareInch:PoundSecondPerSquareInch_1
PoundSecondPerSquareInch_1.ConversionFactorB = "0.0001450377377302092"
PoundSecondPerSquareInch_1.Symbol = "lb•s/in²"
```
## Farad <!-- NOUN -->
- Display name: farad
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Farad:Farad_1
Farad_1.Symbol = "F"
```
## CoulombPerVolt <!-- NOUN -->
- Display name: coulomb per volt
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in coulomb per volt
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
CoulombPerVolt:CoulombPerVolt_1
CoulombPerVolt_1.Symbol = "C/V"
```
## Millifarad <!-- NOUN -->
- Display name: millifarad
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millifarad
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millifarad:Millifarad_1
Millifarad_1.ConversionFactorB = "1000"
Millifarad_1.Symbol = "mF"
```
## Microfarad <!-- NOUN -->
- Display name: microfarad
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microfarad
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microfarad:Microfarad_1
Microfarad_1.ConversionFactorB = "1000000"
Microfarad_1.Symbol = "μF"
```
## Nanofarad <!-- NOUN -->
- Display name: nanofarad
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanofarad
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanofarad:Nanofarad_1
Nanofarad_1.ConversionFactorB = "999999999.9999999"
Nanofarad_1.Symbol = "nF"
```
## Picofarad <!-- NOUN -->
- Display name: picofarad
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picofarad
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picofarad:Picofarad_1
Picofarad_1.ConversionFactorB = "1000000000000"
Picofarad_1.Symbol = "pF"
```
## Ampere <!-- NOUN -->
- Display name: ampere
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Ampere:Ampere_1
Ampere_1.Symbol = "A"
```
## CoulombPerSecond <!-- NOUN -->
- Display name: coulomb per second
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in coulomb per second
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
CoulombPerSecond:CoulombPerSecond_1
CoulombPerSecond_1.Symbol = "C/s"
```
## SiemensVolt <!-- NOUN -->
- Display name: siemens volt
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in siemens volt
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
SiemensVolt:SiemensVolt_1
SiemensVolt_1.Symbol = "S•V"
```
## VoltPerOhm <!-- NOUN -->
- Display name: volt per ohm
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in volt per ohm
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
VoltPerOhm:VoltPerOhm_1
VoltPerOhm_1.Symbol = "V/Ω"
```
## WattPerVolt <!-- NOUN -->
- Display name: watt per volt
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in watt per volt
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
WattPerVolt:WattPerVolt_1
WattPerVolt_1.Symbol = "W/V"
```
## WeberPerHenry <!-- NOUN -->
- Display name: weber per henry
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in weber per henry
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
WeberPerHenry:WeberPerHenry_1
WeberPerHenry_1.Symbol = "Wb/H"
```
## Deciampere <!-- NOUN -->
- Display name: deciampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in deciampere
[SI] is the value in SI
a = 1.0/Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
Deciampere:Deciampere_1
Deciampere_1.ConversionFactorB = "10"
Deciampere_1.Symbol = "dA"
```
## Centiampere <!-- NOUN -->
- Display name: centiampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centiampere
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Centiampere:Centiampere_1
Centiampere_1.ConversionFactorB = "100"
Centiampere_1.Symbol = "cA"
```
## Milliampere <!-- NOUN -->
- Display name: milliampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in milliampere
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Milliampere:Milliampere_1
Milliampere_1.ConversionFactorB = "1000"
Milliampere_1.Symbol = "mA"
```
## Microampere <!-- NOUN -->
- Display name: microampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microampere
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microampere:Microampere_1
Microampere_1.ConversionFactorB = "1000000"
Microampere_1.Symbol = "µA"
```
## Nanoampere <!-- NOUN -->
- Display name: nanoampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanoampere
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanoampere:Nanoampere_1
Nanoampere_1.ConversionFactorB = "999999999.9999999"
Nanoampere_1.Symbol = "nA"
```
## Picoampere <!-- NOUN -->
- Display name: picoampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picoampere
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picoampere:Picoampere_1
Picoampere_1.ConversionFactorB = "1000000000000"
Picoampere_1.Symbol = "pA"
```
## Biot <!-- NOUN -->
- Display name: biot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in biot
[SI] is the value in SI
a = 1.0/Deca, i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
Biot:Biot_1
Biot_1.ConversionFactorB = "0.1"
Biot_1.Symbol = "Bi"
```
## Abampere <!-- NOUN -->
- Display name: abampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in abampere
[SI] is the value in SI
a = 1.0/Deca, i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
Abampere:Abampere_1
Abampere_1.ConversionFactorB = "0.1"
Abampere_1.Symbol = "abA"
```
## Kiloampere <!-- NOUN -->
- Display name: kiloampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kiloampere
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kiloampere:Kiloampere_1
Kiloampere_1.ConversionFactorB = "0.001"
Kiloampere_1.Symbol = "kA"
```
## Megaampere <!-- NOUN -->
- Display name: megaampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megaampere
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Megaampere:Megaampere_1
Megaampere_1.ConversionFactorB = "1E-06"
Megaampere_1.Symbol = "MA"
```
## Gigaampere <!-- NOUN -->
- Display name: gigaampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigaampere
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Gigaampere:Gigaampere_1
Gigaampere_1.ConversionFactorB = "1E-09"
Gigaampere_1.Symbol = "GA"
```
## Teraampere <!-- NOUN -->
- Display name: teraampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in teraampere
[SI] is the value in SI
a = 1.0/Tera, i.e., 1E-12
and
Tera = 1e12

- Examples: 
``` dwis
Teraampere:Teraampere_1
Teraampere_1.ConversionFactorB = "1E-12"
Teraampere_1.Symbol = "TA"
```
## Statampere <!-- NOUN -->
- Display name: statampere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2997924580
- Description: 
[v] = a * [SI]
where
[v] is the value in statampere
[SI] is the value in SI
a = C_cgs/10.0, i.e., 2997924580
and
C_cgs = 2.99792458e10 reference: https://en.wikipedia.org/wiki/Statampere

- Examples: 
``` dwis
Statampere:Statampere_1
Statampere_1.ConversionFactorB = "2997924580"
Statampere_1.Symbol = "stA"
```
## Volt <!-- NOUN -->
- Display name: volt
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Volt:Volt_1
Volt_1.Symbol = "V"
```
## Millivolt <!-- NOUN -->
- Display name: millivolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millivolt
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millivolt:Millivolt_1
Millivolt_1.ConversionFactorB = "1000"
Millivolt_1.Symbol = "mV"
```
## Centivolt <!-- NOUN -->
- Display name: centivolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centivolt
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Centivolt:Centivolt_1
Centivolt_1.ConversionFactorB = "100"
Centivolt_1.Symbol = "cV"
```
## Microvolt <!-- NOUN -->
- Display name: microvolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microvolt
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microvolt:Microvolt_1
Microvolt_1.ConversionFactorB = "1000000"
Microvolt_1.Symbol = "µV"
```
## Nanovolt <!-- NOUN -->
- Display name: nanovolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanovolt
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanovolt:Nanovolt_1
Nanovolt_1.ConversionFactorB = "999999999.9999999"
Nanovolt_1.Symbol = "nV"
```
## Picovolt <!-- NOUN -->
- Display name: picovolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picovolt
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picovolt:Picovolt_1
Picovolt_1.ConversionFactorB = "1000000000000"
Picovolt_1.Symbol = "pV"
```
## Kilovolt <!-- NOUN -->
- Display name: kilovolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilovolt
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilovolt:Kilovolt_1
Kilovolt_1.ConversionFactorB = "0.001"
Kilovolt_1.Symbol = "kV"
```
## Megavolt <!-- NOUN -->
- Display name: megavolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megavolt
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Megavolt:Megavolt_1
Megavolt_1.ConversionFactorB = "1E-06"
Megavolt_1.Symbol = "MV"
```
## Gigavolt <!-- NOUN -->
- Display name: gigavolt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigavolt
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Gigavolt:Gigavolt_1
Gigavolt_1.ConversionFactorB = "1E-09"
Gigavolt_1.Symbol = "GV"
```
## MetrePerMetre <!-- NOUN -->
- Display name: metre per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
MetrePerMetre:MetrePerMetre_1
MetrePerMetre_1.Symbol = "m/m"
```
## DecimetrePerMetre <!-- NOUN -->
- Display name: decimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre per metre
[SI] is the value in SI
a = 1.0 / Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
DecimetrePerMetre:DecimetrePerMetre_1
DecimetrePerMetre_1.ConversionFactorB = "10"
DecimetrePerMetre_1.Symbol = "dm/m"
```
## CentimetrePerMetre <!-- NOUN -->
- Display name: centimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per metre
[SI] is the value in SI
a = 1.0 / Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
CentimetrePerMetre:CentimetrePerMetre_1
CentimetrePerMetre_1.ConversionFactorB = "100"
CentimetrePerMetre_1.Symbol = "cm/m"
```
## MillimetrePerMetre <!-- NOUN -->
- Display name: millimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre per metre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
MillimetrePerMetre:MillimetrePerMetre_1
MillimetrePerMetre_1.ConversionFactorB = "1000"
MillimetrePerMetre_1.Symbol = "mm/m"
```
## MicrometrePerMetre <!-- NOUN -->
- Display name: micrometre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in micrometre per metre
[SI] is the value in SI
a = 1.0 / Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
MicrometrePerMetre:MicrometrePerMetre_1
MicrometrePerMetre_1.ConversionFactorB = "1000000"
MicrometrePerMetre_1.Symbol = "µm/m"
```
## MetrePerKilometre <!-- NOUN -->
- Display name: metre per kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in metre per kilometre
[SI] is the value in SI
a = Kilo/Unit, i.e., 1000
and
Kilo = 1000.0
Unit = 1.0

- Examples: 
``` dwis
MetrePerKilometre:MetrePerKilometre_1
MetrePerKilometre_1.ConversionFactorB = "1000"
MetrePerKilometre_1.Symbol = "m/km"
```
## DecimetrePerKilometre <!-- NOUN -->
- Display name: decimetre per kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre per kilometre
[SI] is the value in SI
a = Kilo / Deci, i.e., 10000
and
Kilo = 1000.0
Deci = 0.1

- Examples: 
``` dwis
DecimetrePerKilometre:DecimetrePerKilometre_1
DecimetrePerKilometre_1.ConversionFactorB = "10000"
DecimetrePerKilometre_1.Symbol = "dm/km"
```
## CentimetrePerKilometre <!-- NOUN -->
- Display name: centimetre per kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100000
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per kilometre
[SI] is the value in SI
a = Kilo / Centi, i.e., 100000
and
Kilo = 1000.0
Centi = 0.01

- Examples: 
``` dwis
CentimetrePerKilometre:CentimetrePerKilometre_1
CentimetrePerKilometre_1.ConversionFactorB = "100000"
CentimetrePerKilometre_1.Symbol = "cm/km"
```
## MillimetrePerKilometre <!-- NOUN -->
- Display name: millimetre per kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre per kilometre
[SI] is the value in SI
a = Kilo / Milli, i.e., 1000000
and
Kilo = 1000.0
Milli = 0.001

- Examples: 
``` dwis
MillimetrePerKilometre:MillimetrePerKilometre_1
MillimetrePerKilometre_1.ConversionFactorB = "1000000"
MillimetrePerKilometre_1.Symbol = "mm/km"
```
## MicrometrePerKilometre <!-- NOUN -->
- Display name: micrometre per kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in micrometre per kilometre
[SI] is the value in SI
a = Kilo / Micro, i.e., 1000000000
and
Kilo = 1000.0
Micro = 1e-6

- Examples: 
``` dwis
MicrometrePerKilometre:MicrometrePerKilometre_1
MicrometrePerKilometre_1.ConversionFactorB = "1000000000"
MicrometrePerKilometre_1.Symbol = "µm/km"
```
## InchPerFoot <!-- NOUN -->
- Display name: inch per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 11.999999999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per foot
[SI] is the value in SI
a = Foot / Inch, i.e., 11.999999999999998
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
InchPerFoot:InchPerFoot_1
InchPerFoot_1.ConversionFactorB = "11.999999999999998"
InchPerFoot_1.Symbol = "in/ft"
```
## InchPerYard <!-- NOUN -->
- Display name: inch per yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 36
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per yard
[SI] is the value in SI
a = Yard / Inch, i.e., 36
and
Yard = 3.0 * Foot
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Foot = 12.0 * Inch

- Examples: 
``` dwis
InchPerYard:InchPerYard_1
InchPerYard_1.ConversionFactorB = "36"
InchPerYard_1.Symbol = "in/yd"
```
## InchPerMile <!-- NOUN -->
- Display name: inch per mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 63359.99999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per mile
[SI] is the value in SI
a = Mile / Inch, i.e., 63359.99999999999
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Yard = 3.0 * Foot
Foot = 12.0 * Inch

- Examples: 
``` dwis
InchPerMile:InchPerMile_1
InchPerMile_1.ConversionFactorB = "63359.99999999999"
InchPerMile_1.Symbol = "in/mi"
```
## FootPerFoot <!-- NOUN -->
- Display name: foot per foot
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per foot
[SI] is the value in SI
a = Foot / Foot, i.e., 1
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerFoot:FootPerFoot_1
FootPerFoot_1.Symbol = "ft/ft"
```
## FootPerYard <!-- NOUN -->
- Display name: foot per yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per yard
[SI] is the value in SI
a = Yard / Foot, i.e., 3
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerYard:FootPerYard_1
FootPerYard_1.ConversionFactorB = "3"
FootPerYard_1.Symbol = "ft/yd"
```
## FootPerMile <!-- NOUN -->
- Display name: foot per mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5280
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per mile
[SI] is the value in SI
a = Mile / Foot, i.e., 5280
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Foot = 12.0 * Inch
Yard = 3.0 * Foot
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerMile:FootPerMile_1
FootPerMile_1.ConversionFactorB = "5280"
FootPerMile_1.Symbol = "ft/mi"
```
## YardPerFoot <!-- NOUN -->
- Display name: yard per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.3333333333333333
- Description: 
[v] = a * [SI]
where
[v] is the value in yard per foot
[SI] is the value in SI
a = Foot / Yard, i.e., 0.3333333333333333
and
Foot = 12.0 * Inch
Yard = 3.0 * Foot
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
YardPerFoot:YardPerFoot_1
YardPerFoot_1.ConversionFactorB = "0.3333333333333333"
YardPerFoot_1.Symbol = "yd/ft"
```
## YardPerYard <!-- NOUN -->
- Display name: yard per yard
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in yard per yard
[SI] is the value in SI
a = Yard / Yard, i.e., 1
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
YardPerYard:YardPerYard_1
YardPerYard_1.Symbol = "yd/yd"
```
## YardPerMile <!-- NOUN -->
- Display name: yard per mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1760
- Description: 
[v] = a * [SI]
where
[v] is the value in yard per mile
[SI] is the value in SI
a = Mile / Yard, i.e., 1760
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
YardPerMile:YardPerMile_1
YardPerMile_1.ConversionFactorB = "1760"
YardPerMile_1.Symbol = "yd/mi"
```
## JoulePerCubicMetre <!-- NOUN -->
- Display name: joule per cubic metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
JoulePerCubicMetre:JoulePerCubicMetre_1
JoulePerCubicMetre_1.Symbol = "J/m³"
```
## JoulePerLitre <!-- NOUN -->
- Display name: joule per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per litre
[SI] is the value in SI
a = Litre/Unit, i.e., 0.001
and
Litre = 0.001
Unit = 1.0

- Examples: 
``` dwis
JoulePerLitre:JoulePerLitre_1
JoulePerLitre_1.ConversionFactorB = "0.001"
JoulePerLitre_1.Symbol = "J/L"
```
## KilojoulePerCubicMetre <!-- NOUN -->
- Display name: kilojoule per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule per cubic metre
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KilojoulePerCubicMetre:KilojoulePerCubicMetre_1
KilojoulePerCubicMetre_1.ConversionFactorB = "0.001"
KilojoulePerCubicMetre_1.Symbol = "kJ/m³"
```
## KilojoulePerLitre <!-- NOUN -->
- Display name: kilojoule per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule per litre
[SI] is the value in SI
a = Litre/Kilo, i.e., 1E-06
and
Litre = 0.001
Kilo = 1000.0

- Examples: 
``` dwis
KilojoulePerLitre:KilojoulePerLitre_1
KilojoulePerLitre_1.ConversionFactorB = "1E-06"
KilojoulePerLitre_1.Symbol = "kJ/L"
```
## MegajoulePerCubicMetre <!-- NOUN -->
- Display name: megajoule per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule per cubic metre
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
MegajoulePerCubicMetre:MegajoulePerCubicMetre_1
MegajoulePerCubicMetre_1.ConversionFactorB = "1E-06"
MegajoulePerCubicMetre_1.Symbol = "MJ/m³"
```
## MegajoulePerLitre <!-- NOUN -->
- Display name: megajoule per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule per litre
[SI] is the value in SI
a = Litre/Mega, i.e., 1E-09
and
Litre = 0.001
Mega = 1e6

- Examples: 
``` dwis
MegajoulePerLitre:MegajoulePerLitre_1
MegajoulePerLitre_1.ConversionFactorB = "1E-09"
MegajoulePerLitre_1.Symbol = "MJ/L"
```
## GigajoulePerCubicMetre <!-- NOUN -->
- Display name: gigajoule per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule per cubic metre
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
GigajoulePerCubicMetre:GigajoulePerCubicMetre_1
GigajoulePerCubicMetre_1.ConversionFactorB = "1E-09"
GigajoulePerCubicMetre_1.Symbol = "GJ/m³"
```
## GigajoulePerLitre <!-- NOUN -->
- Display name: gigajoule per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule per litre
[SI] is the value in SI
a = Litre/Giga, i.e., 1E-12
and
Litre = 0.001
Giga = 1e9

- Examples: 
``` dwis
GigajoulePerLitre:GigajoulePerLitre_1
GigajoulePerLitre_1.ConversionFactorB = "1E-12"
GigajoulePerLitre_1.Symbol = "GJ/L"
```
## CaloriePerCubicMetre <!-- NOUN -->
- Display name: calorie per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per cubic metre
[SI] is the value in SI
a = 1.0/Calorie, i.e., 0.2390057361376673
and
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerCubicMetre:CaloriePerCubicMetre_1
CaloriePerCubicMetre_1.ConversionFactorB = "0.2390057361376673"
CaloriePerCubicMetre_1.Symbol = "cal/m³"
```
## CaloriePerLitre <!-- NOUN -->
- Display name: calorie per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per litre
[SI] is the value in SI
a = Litre/Calorie, i.e., 0.0002390057361376673
and
Litre = 0.001
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerLitre:CaloriePerLitre_1
CaloriePerLitre_1.ConversionFactorB = "0.0002390057361376673"
CaloriePerLitre_1.Symbol = "cal/L"
```
## KilocaloriePerCubicMetre <!-- NOUN -->
- Display name: kilocalorie per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per cubic metre
[SI] is the value in SI
a = 1.0 / (Kilo * Calorie), i.e., 0.0002390057361376673
and
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
KilocaloriePerCubicMetre:KilocaloriePerCubicMetre_1
KilocaloriePerCubicMetre_1.ConversionFactorB = "0.0002390057361376673"
KilocaloriePerCubicMetre_1.Symbol = "Cal/m³"
```
## KilocaloriePerLitre <!-- NOUN -->
- Display name: kilocalorie per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.390057361376673E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per litre
[SI] is the value in SI
a = Litre/(Kilo * Calorie), i.e., 2.390057361376673E-07
and
Litre = 0.001
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
KilocaloriePerLitre:KilocaloriePerLitre_1
KilocaloriePerLitre_1.ConversionFactorB = "2.390057361376673E-07"
KilocaloriePerLitre_1.Symbol = "Cal/L"
```
## JoulePerCubicFoot <!-- NOUN -->
- Display name: joule per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.02831684659199999
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / Unit, i.e., 0.02831684659199999
and
Foot = 12.0 * Inch
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
JoulePerCubicFoot:JoulePerCubicFoot_1
JoulePerCubicFoot_1.ConversionFactorB = "0.02831684659199999"
JoulePerCubicFoot_1.Symbol = "J/ft³"
```
## KilojoulePerCubicFoot <!-- NOUN -->
- Display name: kilojoule per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.831684659199999E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / Kilo, i.e., 2.831684659199999E-05
and
Foot = 12.0 * Inch
Kilo = 1000.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KilojoulePerCubicFoot:KilojoulePerCubicFoot_1
KilojoulePerCubicFoot_1.ConversionFactorB = "2.831684659199999E-05"
KilojoulePerCubicFoot_1.Symbol = "kJ/ft³"
```
## MegajoulePerCubicFoot <!-- NOUN -->
- Display name: megajoule per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.831684659199999E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / Mega, i.e., 2.831684659199999E-08
and
Foot = 12.0 * Inch
Mega = 1e6
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MegajoulePerCubicFoot:MegajoulePerCubicFoot_1
MegajoulePerCubicFoot_1.ConversionFactorB = "2.831684659199999E-08"
MegajoulePerCubicFoot_1.Symbol = "MJ/ft³"
```
## GigajoulePerCubicFoot <!-- NOUN -->
- Display name: gigajoule per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.831684659199999E-11
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / Giga, i.e., 2.831684659199999E-11
and
Foot = 12.0 * Inch
Giga = 1e9
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
GigajoulePerCubicFoot:GigajoulePerCubicFoot_1
GigajoulePerCubicFoot_1.ConversionFactorB = "2.831684659199999E-11"
GigajoulePerCubicFoot_1.Symbol = "GJ/ft³"
```
## CaloriePerCubicFoot <!-- NOUN -->
- Display name: calorie per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.006767888764818353
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / Calorie, i.e., 0.006767888764818353
and
Foot = 12.0 * Inch
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CaloriePerCubicFoot:CaloriePerCubicFoot_1
CaloriePerCubicFoot_1.ConversionFactorB = "0.006767888764818353"
CaloriePerCubicFoot_1.Symbol = "cal/ft³"
```
## KilocaloriePerCubicFoot <!-- NOUN -->
- Display name: kilocalorie per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.767888764818354E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / (Kilo * Calorie), i.e., 6.767888764818354E-06
and
Foot = 12.0 * Inch
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KilocaloriePerCubicFoot:KilocaloriePerCubicFoot_1
KilocaloriePerCubicFoot_1.ConversionFactorB = "6.767888764818354E-06"
KilocaloriePerCubicFoot_1.Symbol = "Cal/ft³"
```
## JoulePerCubicInch <!-- NOUN -->
- Display name: joule per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6387064E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/Unit, i.e., 1.6387064E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Unit = 1.0

- Examples: 
``` dwis
JoulePerCubicInch:JoulePerCubicInch_1
JoulePerCubicInch_1.ConversionFactorB = "1.6387064E-05"
JoulePerCubicInch_1.Symbol = "J/in³"
```
## KilojoulePerCubicInch <!-- NOUN -->
- Display name: kilojoule per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6387064E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/Kilo, i.e., 1.6387064E-08
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Kilo = 1000.0

- Examples: 
``` dwis
KilojoulePerCubicInch:KilojoulePerCubicInch_1
KilojoulePerCubicInch_1.ConversionFactorB = "1.6387064E-08"
KilojoulePerCubicInch_1.Symbol = "kJ/in³"
```
## MegajoulePerCubicInch <!-- NOUN -->
- Display name: megajoule per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6387064E-11
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/Mega, i.e., 1.6387064E-11
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Mega = 1e6

- Examples: 
``` dwis
MegajoulePerCubicInch:MegajoulePerCubicInch_1
MegajoulePerCubicInch_1.ConversionFactorB = "1.6387064E-11"
MegajoulePerCubicInch_1.Symbol = "MJ/in³"
```
## GigajoulePerCubicInch <!-- NOUN -->
- Display name: gigajoule per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6387064E-14
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/Giga, i.e., 1.6387064E-14
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Giga = 1e9

- Examples: 
``` dwis
GigajoulePerCubicInch:GigajoulePerCubicInch_1
GigajoulePerCubicInch_1.ConversionFactorB = "1.6387064E-14"
GigajoulePerCubicInch_1.Symbol = "GJ/in³"
```
## CaloriePerCubicInch <!-- NOUN -->
- Display name: calorie per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.916602294455067E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/Calorie, i.e., 3.916602294455067E-06
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerCubicInch:CaloriePerCubicInch_1
CaloriePerCubicInch_1.ConversionFactorB = "3.916602294455067E-06"
CaloriePerCubicInch_1.Symbol = "cal/in³"
```
## KilocaloriePerCubicInch <!-- NOUN -->
- Display name: kilocalorie per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.916602294455067E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/(Kilo * Calorie), i.e., 3.916602294455067E-09
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
KilocaloriePerCubicInch:KilocaloriePerCubicInch_1
KilocaloriePerCubicInch_1.ConversionFactorB = "3.916602294455067E-09"
KilocaloriePerCubicInch_1.Symbol = "Cal/in³"
```
## JoulePerGallonUk <!-- NOUN -->
- Display name: joule per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00454609
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per gallon (UK)
[SI] is the value in SI
a = GallonUK / Unit, i.e., 0.00454609
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Unit = 1.0

- Examples: 
``` dwis
JoulePerGallonUk:JoulePerGallonUk_1
JoulePerGallonUk_1.ConversionFactorB = "0.00454609"
JoulePerGallonUk_1.Symbol = "J/gal(UK)"
```
## KilojoulePerGallonUk <!-- NOUN -->
- Display name: kilojoule per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.54609E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule per gallon (UK)
[SI] is the value in SI
a = GallonUK / Kilo, i.e., 4.54609E-06
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Kilo = 1000.0

- Examples: 
``` dwis
KilojoulePerGallonUk:KilojoulePerGallonUk_1
KilojoulePerGallonUk_1.ConversionFactorB = "4.54609E-06"
KilojoulePerGallonUk_1.Symbol = "kJ/gal(UK)"
```
## MegajoulePerGallonUk <!-- NOUN -->
- Display name: megajoule per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.54609E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule per gallon (UK)
[SI] is the value in SI
a = GallonUK / Mega, i.e., 4.54609E-09
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Mega = 1e6

- Examples: 
``` dwis
MegajoulePerGallonUk:MegajoulePerGallonUk_1
MegajoulePerGallonUk_1.ConversionFactorB = "4.54609E-09"
MegajoulePerGallonUk_1.Symbol = "MJ/gal(UK)"
```
## GigajoulePerGallonUk <!-- NOUN -->
- Display name: gigajoule per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.54609E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule per gallon (UK)
[SI] is the value in SI
a = GallonUK / Giga, i.e., 4.54609E-12
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Giga = 1e9

- Examples: 
``` dwis
GigajoulePerGallonUk:GigajoulePerGallonUk_1
GigajoulePerGallonUk_1.ConversionFactorB = "4.54609E-12"
GigajoulePerGallonUk_1.Symbol = "GJ/gal(UK)"
```
## CaloriePerGallonUk <!-- NOUN -->
- Display name: calorie per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0010865415869980878
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per gallon (UK)
[SI] is the value in SI
a = GallonUK / Calorie, i.e., 0.0010865415869980878
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerGallonUk:CaloriePerGallonUk_1
CaloriePerGallonUk_1.ConversionFactorB = "0.0010865415869980878"
CaloriePerGallonUk_1.Symbol = "cal/gal(UK)"
```
## KilocaloriePerGallonUk <!-- NOUN -->
- Display name: kilocalorie per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.086541586998088E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per gallon (UK)
[SI] is the value in SI
a = GallonUK / (Kilo * Calorie), i.e., 1.086541586998088E-06
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
KilocaloriePerGallonUk:KilocaloriePerGallonUk_1
KilocaloriePerGallonUk_1.ConversionFactorB = "1.086541586998088E-06"
KilocaloriePerGallonUk_1.Symbol = "Cal/gal(UK)"
```
## JoulePerGallonUs <!-- NOUN -->
- Display name: joule per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0037854117839999997
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per gallon (US)
[SI] is the value in SI
a = GallonUS / Unit, i.e., 0.0037854117839999997
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
JoulePerGallonUs:JoulePerGallonUs_1
JoulePerGallonUs_1.ConversionFactorB = "0.0037854117839999997"
JoulePerGallonUs_1.Symbol = "J/gal(US)"
```
## KilojoulePerGallonUs <!-- NOUN -->
- Display name: kilojoule per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.7854117839999998E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule per gallon (US)
[SI] is the value in SI
a = GallonUS / Kilo, i.e., 3.7854117839999998E-06
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Kilo = 1000.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KilojoulePerGallonUs:KilojoulePerGallonUs_1
KilojoulePerGallonUs_1.ConversionFactorB = "3.7854117839999998E-06"
KilojoulePerGallonUs_1.Symbol = "kJ/gal(US)"
```
## MegajoulePerGallonUs <!-- NOUN -->
- Display name: megajoule per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.7854117839999995E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule per gallon (US)
[SI] is the value in SI
a = GallonUS / Mega, i.e., 3.7854117839999995E-09
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Mega = 1e6
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MegajoulePerGallonUs:MegajoulePerGallonUs_1
MegajoulePerGallonUs_1.ConversionFactorB = "3.7854117839999995E-09"
MegajoulePerGallonUs_1.Symbol = "MJ/gal(US)"
```
## GigajoulePerGallonUs <!-- NOUN -->
- Display name: gigajoule per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.785411784E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule per gallon (US)
[SI] is the value in SI
a = GallonUS / Giga, i.e., 3.785411784E-12
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Giga = 1e9
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
GigajoulePerGallonUs:GigajoulePerGallonUs_1
GigajoulePerGallonUs_1.ConversionFactorB = "3.785411784E-12"
GigajoulePerGallonUs_1.Symbol = "GJ/gal(US)"
```
## CaloriePerGallonUs <!-- NOUN -->
- Display name: calorie per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0009047351300191204
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per gallon (US)
[SI] is the value in SI
a = GallonUS / Calorie, i.e., 0.0009047351300191204
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CaloriePerGallonUs:CaloriePerGallonUs_1
CaloriePerGallonUs_1.ConversionFactorB = "0.0009047351300191204"
CaloriePerGallonUs_1.Symbol = "cal/gal(US)"
```
## KilocaloriePerGallonUs <!-- NOUN -->
- Display name: kilocalorie per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.047351300191203E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per gallon (US)
[SI] is the value in SI
a = GallonUS / (Kilo * Calorie), i.e., 9.047351300191203E-07
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KilocaloriePerGallonUs:KilocaloriePerGallonUs_1
KilocaloriePerGallonUs_1.ConversionFactorB = "9.047351300191203E-07"
KilocaloriePerGallonUs_1.Symbol = "Cal/gal(US)"
```
## BritishThermalUnitPerCubicMetre <!-- NOUN -->
- Display name: british thermal unit per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0009484516526770049
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per cubic metre
[SI] is the value in SI
a = 1.0/BTU, i.e., 0.0009484516526770049
and
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnitPerCubicMetre:BritishThermalUnitPerCubicMetre_1
BritishThermalUnitPerCubicMetre_1.ConversionFactorB = "0.0009484516526770049"
BritishThermalUnitPerCubicMetre_1.Symbol = "BTU/m³"
```
## BritishThermalUnitPerLitre <!-- NOUN -->
- Display name: british thermal unit per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.484516526770049E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per litre
[SI] is the value in SI
a = Litre/BTU, i.e., 9.484516526770049E-07
and
Litre = 0.001
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnitPerLitre:BritishThermalUnitPerLitre_1
BritishThermalUnitPerLitre_1.ConversionFactorB = "9.484516526770049E-07"
BritishThermalUnitPerLitre_1.Symbol = "BTU/L"
```
## BritishThermalUnitPerCubicFoot <!-- NOUN -->
- Display name: british thermal unit per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.6857159948783606E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / BTU, i.e., 2.6857159948783606E-05
and
Foot = 12.0 * Inch
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BritishThermalUnitPerCubicFoot:BritishThermalUnitPerCubicFoot_1
BritishThermalUnitPerCubicFoot_1.ConversionFactorB = "2.6857159948783606E-05"
BritishThermalUnitPerCubicFoot_1.Symbol = "BTU/ft³"
```
## BritishThermalUnitPerCubicInch <!-- NOUN -->
- Display name: british thermal unit per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.554233793332385E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/BTU, i.e., 1.554233793332385E-08
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnitPerCubicInch:BritishThermalUnitPerCubicInch_1
BritishThermalUnitPerCubicInch_1.ConversionFactorB = "1.554233793332385E-08"
BritishThermalUnitPerCubicInch_1.Symbol = "BTU/in³"
```
## BritishThermalUnitPerGallonUk <!-- NOUN -->
- Display name: british thermal unit per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.311746573718405E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per gallon (UK)
[SI] is the value in SI
a = GallonUK / BTU, i.e., 4.311746573718405E-06
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnitPerGallonUk:BritishThermalUnitPerGallonUk_1
BritishThermalUnitPerGallonUk_1.ConversionFactorB = "4.311746573718405E-06"
BritishThermalUnitPerGallonUk_1.Symbol = "BTU/gal(UK)"
```
## BritishThermalUnitPerGallonUs <!-- NOUN -->
- Display name: british thermal unit per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.5902800625978092E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per gallon (US)
[SI] is the value in SI
a = GallonUS / BTU, i.e., 3.5902800625978092E-06
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BritishThermalUnitPerGallonUs:BritishThermalUnitPerGallonUs_1
BritishThermalUnitPerGallonUs_1.ConversionFactorB = "3.5902800625978092E-06"
BritishThermalUnitPerGallonUs_1.Symbol = "BTU/gal(US)"
```
## KiloBritishThermalUnitPerCubicMetre <!-- NOUN -->
- Display name: kilo british thermal unit per cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.484516526770048E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit per cubic metre
[SI] is the value in SI
a = 1.0/(Kilo * BTU), i.e., 9.484516526770048E-07
and
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
KiloBritishThermalUnitPerCubicMetre:KiloBritishThermalUnitPerCubicMetre_1
KiloBritishThermalUnitPerCubicMetre_1.ConversionFactorB = "9.484516526770048E-07"
KiloBritishThermalUnitPerCubicMetre_1.Symbol = "kBTU/m³"
```
## KiloBritishThermalUnitPerLitre <!-- NOUN -->
- Display name: kilo british thermal unit per litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.48451652677005E-10
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit per litre
[SI] is the value in SI
a = Litre/(Kilo * BTU), i.e., 9.48451652677005E-10
and
Litre = 0.001
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
KiloBritishThermalUnitPerLitre:KiloBritishThermalUnitPerLitre_1
KiloBritishThermalUnitPerLitre_1.ConversionFactorB = "9.48451652677005E-10"
KiloBritishThermalUnitPerLitre_1.Symbol = "kBTU/L"
```
## KiloBritishThermalUnitPerCubicFoot <!-- NOUN -->
- Display name: kilo british thermal unit per cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.6857159948783602E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit per cubic foot
[SI] is the value in SI
a = Foot * Foot * Foot / (Kilo * BTU), i.e., 2.6857159948783602E-08
and
Foot = 12.0 * Inch
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KiloBritishThermalUnitPerCubicFoot:KiloBritishThermalUnitPerCubicFoot_1
KiloBritishThermalUnitPerCubicFoot_1.ConversionFactorB = "2.6857159948783602E-08"
KiloBritishThermalUnitPerCubicFoot_1.Symbol = "kBTU/ft³"
```
## KiloBritishThermalUnitPerCubicInch <!-- NOUN -->
- Display name: kilo british thermal unit per cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.5542337933323848E-11
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit per cubic inch
[SI] is the value in SI
a = Inch*Inch*Inch/(Kilo * BTU), i.e., 1.5542337933323848E-11
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
KiloBritishThermalUnitPerCubicInch:KiloBritishThermalUnitPerCubicInch_1
KiloBritishThermalUnitPerCubicInch_1.ConversionFactorB = "1.5542337933323848E-11"
KiloBritishThermalUnitPerCubicInch_1.Symbol = "kBTU/in³"
```
## KiloBritishThermalUnitPerGallonUk <!-- NOUN -->
- Display name: kilo british thermal unit per gallon (UK)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.311746573718405E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit per gallon (UK)
[SI] is the value in SI
a = GallonUK / (Kilo * BTU), i.e., 4.311746573718405E-09
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
KiloBritishThermalUnitPerGallonUk:KiloBritishThermalUnitPerGallonUk_1
KiloBritishThermalUnitPerGallonUk_1.ConversionFactorB = "4.311746573718405E-09"
KiloBritishThermalUnitPerGallonUk_1.Symbol = "kBTU/gal(UK)"
```
## KiloBritishThermalUnitPerGallonUs <!-- NOUN -->
- Display name: kilo british thermal unit per gallon (US)
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.5902800625978087E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit per gallon (US)
[SI] is the value in SI
a = GallonUS / (Kilo * BTU), i.e., 3.5902800625978087E-09
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KiloBritishThermalUnitPerGallonUs:KiloBritishThermalUnitPerGallonUs_1
KiloBritishThermalUnitPerGallonUs_1.ConversionFactorB = "3.5902800625978087E-09"
KiloBritishThermalUnitPerGallonUs_1.Symbol = "kBTU/gal(US)"
```
## NewtonPerMetre <!-- NOUN -->
- Display name: newton per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
NewtonPerMetre:NewtonPerMetre_1
NewtonPerMetre_1.Symbol = "N/m"
```
## NewtonPer30Metre <!-- NOUN -->
- Display name: newton per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per 30 metre
[SI] is the value in SI
a = 3*Deca/Unit, i.e., 30
and
Deca = 10.0
Unit = 1.0

- Examples: 
``` dwis
NewtonPer30Metre:NewtonPer30Metre_1
NewtonPer30Metre_1.ConversionFactorB = "30"
NewtonPer30Metre_1.Symbol = "N/30m"
```
## NewtonPer10Metre <!-- NOUN -->
- Display name: newton per 10 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per 10 metre
[SI] is the value in SI
a = Deca/Unit, i.e., 10
and
Deca = 10.0
Unit = 1.0

- Examples: 
``` dwis
NewtonPer10Metre:NewtonPer10Metre_1
NewtonPer10Metre_1.ConversionFactorB = "10"
NewtonPer10Metre_1.Symbol = "N/10m"
```
## NewtonPerDecimetre <!-- NOUN -->
- Display name: newton per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per decimetre
[SI] is the value in SI
a = Deci/Unit, i.e., 0.1
and
Deci = 0.1
Unit = 1.0

- Examples: 
``` dwis
NewtonPerDecimetre:NewtonPerDecimetre_1
NewtonPerDecimetre_1.ConversionFactorB = "0.1"
NewtonPerDecimetre_1.Symbol = "N/dm"
```
## NewtonPerCentimetre <!-- NOUN -->
- Display name: newton per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per centimetre
[SI] is the value in SI
a = Centi/Unit, i.e., 0.01
and
Centi = 0.01
Unit = 1.0

- Examples: 
``` dwis
NewtonPerCentimetre:NewtonPerCentimetre_1
NewtonPerCentimetre_1.ConversionFactorB = "0.01"
NewtonPerCentimetre_1.Symbol = "N/cm"
```
## NewtonPerMillimetre <!-- NOUN -->
- Display name: newton per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per millimetre
[SI] is the value in SI
a = Milli/Unit, i.e., 0.001
and
Milli = 0.001
Unit = 1.0

- Examples: 
``` dwis
NewtonPerMillimetre:NewtonPerMillimetre_1
NewtonPerMillimetre_1.ConversionFactorB = "0.001"
NewtonPerMillimetre_1.Symbol = "N/mm"
```
## DecanewtonPerMetre <!-- NOUN -->
- Display name: decanewton per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton per metre
[SI] is the value in SI
a = 1.0/Deca, i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
DecanewtonPerMetre:DecanewtonPerMetre_1
DecanewtonPerMetre_1.ConversionFactorB = "0.1"
DecanewtonPerMetre_1.Symbol = "daN/m"
```
## DecanewtonPer30Metre <!-- NOUN -->
- Display name: decanewton per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton per 30 metre
[SI] is the value in SI
a = 3*Deca/Deca, i.e., 3
and
Deca = 10.0

- Examples: 
``` dwis
DecanewtonPer30Metre:DecanewtonPer30Metre_1
DecanewtonPer30Metre_1.ConversionFactorB = "3"
DecanewtonPer30Metre_1.Symbol = "daN/30m"
```
## DecanewtonPer10Metre <!-- NOUN -->
- Display name: decanewton per 10 metre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton per 10 metre
[SI] is the value in SI
a = Deca/Deca, i.e., 1
and
Deca = 10.0

- Examples: 
``` dwis
DecanewtonPer10Metre:DecanewtonPer10Metre_1
DecanewtonPer10Metre_1.Symbol = "daN/10m"
```
## DecanewtonPerDecimetre <!-- NOUN -->
- Display name: decanewton per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton per decimetre
[SI] is the value in SI
a = Deci/Deca, i.e., 0.01
and
Deci = 0.1
Deca = 10.0

- Examples: 
``` dwis
DecanewtonPerDecimetre:DecanewtonPerDecimetre_1
DecanewtonPerDecimetre_1.ConversionFactorB = "0.01"
DecanewtonPerDecimetre_1.Symbol = "daN/dm"
```
## DecanewtonPerCentimetre <!-- NOUN -->
- Display name: decanewton per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton per centimetre
[SI] is the value in SI
a = Centi/Deca, i.e., 0.001
and
Centi = 0.01
Deca = 10.0

- Examples: 
``` dwis
DecanewtonPerCentimetre:DecanewtonPerCentimetre_1
DecanewtonPerCentimetre_1.ConversionFactorB = "0.001"
DecanewtonPerCentimetre_1.Symbol = "daN/cm"
```
## DecanewtonPerMillimetre <!-- NOUN -->
- Display name: decanewton per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton per millimetre
[SI] is the value in SI
a = Milli/Deca, i.e., 0.0001
and
Milli = 0.001
Deca = 10.0

- Examples: 
``` dwis
DecanewtonPerMillimetre:DecanewtonPerMillimetre_1
DecanewtonPerMillimetre_1.ConversionFactorB = "0.0001"
DecanewtonPerMillimetre_1.Symbol = "daN/mm"
```
## KilonewtonPerMetre <!-- NOUN -->
- Display name: kilonewton per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per metre
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPerMetre:KilonewtonPerMetre_1
KilonewtonPerMetre_1.ConversionFactorB = "0.001"
KilonewtonPerMetre_1.Symbol = "kN/m"
```
## KilonewtonPer30Metre <!-- NOUN -->
- Display name: kilonewton per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.03
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per 30 metre
[SI] is the value in SI
a = 3*Deca/Kilo, i.e., 0.03
and
Deca = 10.0
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPer30Metre:KilonewtonPer30Metre_1
KilonewtonPer30Metre_1.ConversionFactorB = "0.03"
KilonewtonPer30Metre_1.Symbol = "kN/30m"
```
## KilonewtonPer10Metre <!-- NOUN -->
- Display name: kilonewton per 10 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per 10 metre
[SI] is the value in SI
a = Deca/Kilo, i.e., 0.01
and
Deca = 10.0
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPer10Metre:KilonewtonPer10Metre_1
KilonewtonPer10Metre_1.ConversionFactorB = "0.01"
KilonewtonPer10Metre_1.Symbol = "kN/10m"
```
## KilonewtonPerDecimetre <!-- NOUN -->
- Display name: kilonewton per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per decimetre
[SI] is the value in SI
a = Deci/Kilo, i.e., 0.0001
and
Deci = 0.1
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPerDecimetre:KilonewtonPerDecimetre_1
KilonewtonPerDecimetre_1.ConversionFactorB = "0.0001"
KilonewtonPerDecimetre_1.Symbol = "kN/dm"
```
## KilonewtonPerCentimetre <!-- NOUN -->
- Display name: kilonewton per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per centimetre
[SI] is the value in SI
a = Centi/Kilo, i.e., 1E-05
and
Centi = 0.01
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPerCentimetre:KilonewtonPerCentimetre_1
KilonewtonPerCentimetre_1.ConversionFactorB = "1E-05"
KilonewtonPerCentimetre_1.Symbol = "kN/cm"
```
## KilonewtonPerMillimetre <!-- NOUN -->
- Display name: kilonewton per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per millimetre
[SI] is the value in SI
a = Milli/Kilo, i.e., 1E-06
and
Milli = 0.001
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPerMillimetre:KilonewtonPerMillimetre_1
KilonewtonPerMillimetre_1.ConversionFactorB = "1E-06"
KilonewtonPerMillimetre_1.Symbol = "kN/mm"
```
## PoundPerFoot <!-- NOUN -->
- Display name: pound per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06852176585679175
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per foot
[SI] is the value in SI
a = Foot/PoundForce, i.e., 0.06852176585679175
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPerFoot:PoundPerFoot_1
PoundPerFoot_1.ConversionFactorB = "0.06852176585679175"
PoundPerFoot_1.Symbol = "lbf/ft"
```
## PoundPerInch <!-- NOUN -->
- Display name: pound per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0057101471547326465
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per inch
[SI] is the value in SI
a = Inch/PoundForce, i.e., 0.0057101471547326465
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPerInch:PoundPerInch_1
PoundPerInch_1.ConversionFactorB = "0.0057101471547326465"
PoundPerInch_1.Symbol = "lbf/in"
```
## KilopoundPerFoot <!-- NOUN -->
- Display name: kilopound per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.852176585679175E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound per foot
[SI] is the value in SI
a = Foot/(Kilo*PoundForce), i.e., 6.852176585679175E-05
and
Foot = 12.0 * Inch
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilopoundPerFoot:KilopoundPerFoot_1
KilopoundPerFoot_1.ConversionFactorB = "6.852176585679175E-05"
KilopoundPerFoot_1.Symbol = "klbf/ft"
```
## KilopoundPerInch <!-- NOUN -->
- Display name: kilopound per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5.7101471547326466E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound per inch
[SI] is the value in SI
a = Inch/(Kilo*PoundForce), i.e., 5.7101471547326466E-06
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilopoundPerInch:KilopoundPerInch_1
KilopoundPerInch_1.ConversionFactorB = "5.7101471547326466E-06"
KilopoundPerInch_1.Symbol = "klbf/in"
```
## PoundPer30Foot <!-- NOUN -->
- Display name: pound per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.0556529757037523
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per 30 foot
[SI] is the value in SI
a = 30.0*Foot/PoundForce, i.e., 2.0556529757037523
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPer30Foot:PoundPer30Foot_1
PoundPer30Foot_1.ConversionFactorB = "2.0556529757037523"
PoundPer30Foot_1.Symbol = "lbf/30ft"
```
## PoundPer100Foot <!-- NOUN -->
- Display name: pound per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.852176585679175
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per 100 foot
[SI] is the value in SI
a = 100.0*Foot/PoundForce, i.e., 6.852176585679175
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPer100Foot:PoundPer100Foot_1
PoundPer100Foot_1.ConversionFactorB = "6.852176585679175"
PoundPer100Foot_1.Symbol = "lbf/100ft"
```
## KilopoundPer30Foot <!-- NOUN -->
- Display name: kilopound per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0020556529757037524
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound per 30 foot
[SI] is the value in SI
a = 30.0*Foot/(Kilo*PoundForce), i.e., 0.0020556529757037524
and
Foot = 12.0 * Inch
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilopoundPer30Foot:KilopoundPer30Foot_1
KilopoundPer30Foot_1.ConversionFactorB = "0.0020556529757037524"
KilopoundPer30Foot_1.Symbol = "klbf/30ft"
```
## KilopoundPer100Foot <!-- NOUN -->
- Display name: kilopound per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.006852176585679175
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound per 100 foot
[SI] is the value in SI
a = 100.0*Foot/(Kilo*PoundForce), i.e., 0.006852176585679175
and
Foot = 12.0 * Inch
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilopoundPer100Foot:KilopoundPer100Foot_1
KilopoundPer100Foot_1.ConversionFactorB = "0.006852176585679175"
KilopoundPer100Foot_1.Symbol = "klbf/100ft"
```
## Newton <!-- NOUN -->
- Display name: newton
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Newton:Newton_1
Newton_1.Symbol = "N"
```
## Decanewton <!-- NOUN -->
- Display name: decanewton
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton
[SI] is the value in SI
a = 1.0/(Deca), i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
Decanewton:Decanewton_1
Decanewton_1.ConversionFactorB = "0.1"
Decanewton_1.Symbol = "daN"
```
## Kilonewton <!-- NOUN -->
- Display name: kilonewton
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilonewton:Kilonewton_1
Kilonewton_1.ConversionFactorB = "0.001"
Kilonewton_1.Symbol = "kN"
```
## Kilodecanewton <!-- NOUN -->
- Display name: kilodecanewton
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilodecanewton
[SI] is the value in SI
a = 1.0/(Kilo*Deca), i.e., 0.0001
and
Kilo = 1000.0
Deca = 10.0

- Examples: 
``` dwis
Kilodecanewton:Kilodecanewton_1
Kilodecanewton_1.ConversionFactorB = "0.0001"
Kilodecanewton_1.Symbol = "kdaN"
```
## KilogramForce <!-- NOUN -->
- Display name: kilogram force
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10197162129779283
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force
[SI] is the value in SI
a = 1.0/KilogramForce, i.e., 0.10197162129779283
and
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForce:KilogramForce_1
KilogramForce_1.ConversionFactorB = "0.10197162129779283"
KilogramForce_1.Symbol = "kgf"
```
## PoundForce <!-- NOUN -->
- Display name: pound force
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2248089430997105
- Description: 
[v] = a * [SI]
where
[v] is the value in pound force
[SI] is the value in SI
a = 1.0/PoundForce, i.e., 0.2248089430997105
and
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundForce:PoundForce_1
PoundForce_1.ConversionFactorB = "0.2248089430997105"
PoundForce_1.Symbol = "lbf"
```
## KilopoundForce <!-- NOUN -->
- Display name: kilopound force
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002248089430997105
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound force
[SI] is the value in SI
a = 1.0/(Kilo*PoundForce), i.e., 0.0002248089430997105
and
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilopoundForce:KilopoundForce_1
KilopoundForce_1.ConversionFactorB = "0.0002248089430997105"
KilopoundForce_1.Symbol = "klbf"
```
## Hertz <!-- NOUN -->
- Display name: hertz
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Hertz:Hertz_1
Hertz_1.Symbol = "Hz"
```
## ReciprocalSecond <!-- NOUN -->
- Display name: reciprocal second
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal second
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
ReciprocalSecond:ReciprocalSecond_1
ReciprocalSecond_1.Symbol = "1/s"
```
## Kilohertz <!-- NOUN -->
- Display name: kilohertz
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilohertz
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilohertz:Kilohertz_1
Kilohertz_1.ConversionFactorB = "0.001"
Kilohertz_1.Symbol = "kHz"
```
## Megahertz <!-- NOUN -->
- Display name: megahertz
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megahertz
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Megahertz:Megahertz_1
Megahertz_1.ConversionFactorB = "1E-06"
Megahertz_1.Symbol = "MHz"
```
## Gigahertz <!-- NOUN -->
- Display name: gigahertz
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigahertz
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Gigahertz:Gigahertz_1
Gigahertz_1.ConversionFactorB = "1E-09"
Gigahertz_1.Symbol = "GHz"
```
## Terahertz <!-- NOUN -->
- Display name: terahertz
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in terahertz
[SI] is the value in SI
a = 1.0/Tera, i.e., 1E-12
and
Tera = 1e12

- Examples: 
``` dwis
Terahertz:Terahertz_1
Terahertz_1.ConversionFactorB = "1E-12"
Terahertz_1.Symbol = "THz"
```
## Rpm <!-- NOUN -->
- Display name: rpm
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in rpm
[SI] is the value in SI
a = Minute, i.e., 60
and
Minute = 60.0

- Examples: 
``` dwis
Rpm:Rpm_1
Rpm_1.ConversionFactorB = "60"
Rpm_1.Symbol = "rpm"
```
## Spm <!-- NOUN -->
- Display name: spm
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in spm
[SI] is the value in SI
a = Minute, i.e., 60
and
Minute = 60.0

- Examples: 
``` dwis
Spm:Spm_1
Spm_1.ConversionFactorB = "60"
Spm_1.Symbol = "spm"
```
## RotationPerSecond <!-- NOUN -->
- Display name: rotation per second
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in rotation per second
[SI] is the value in SI
a = Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
RotationPerSecond:RotationPerSecond_1
RotationPerSecond_1.Symbol = "rps"
```
## StrokePerSecond <!-- NOUN -->
- Display name: stroke per second
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in stroke per second
[SI] is the value in SI
a = Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
StrokePerSecond:StrokePerSecond_1
StrokePerSecond_1.Symbol = "sps"
```
## StrokePerHour <!-- NOUN -->
- Display name: stroke per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in stroke per hour
[SI] is the value in SI
a = Hour, i.e., 3600
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
StrokePerHour:StrokePerHour_1
StrokePerHour_1.ConversionFactorB = "3600"
StrokePerHour_1.Symbol = "sph"
```
## RotationPerHour <!-- NOUN -->
- Display name: rotation per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in rotation per hour
[SI] is the value in SI
a = Hour, i.e., 3600
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RotationPerHour:RotationPerHour_1
RotationPerHour_1.ConversionFactorB = "3600"
RotationPerHour_1.Symbol = "rph"
```
## ShockPerSecond <!-- NOUN -->
- Display name: shock per second
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in shock per second
[SI] is the value in SI
a = Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
ShockPerSecond:ShockPerSecond_1
ShockPerSecond_1.Symbol = "sps"
```
## ShockPerMinute <!-- NOUN -->
- Display name: shock per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in shock per minute
[SI] is the value in SI
a = Minute, i.e., 60
and
Minute = 60.0

- Examples: 
``` dwis
ShockPerMinute:ShockPerMinute_1
ShockPerMinute_1.ConversionFactorB = "60"
ShockPerMinute_1.Symbol = "spm"
```
## ShockPerHour <!-- NOUN -->
- Display name: shock per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in shock per hour
[SI] is the value in SI
a = Hour, i.e., 3600
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
ShockPerHour:ShockPerHour_1
ShockPerHour_1.ConversionFactorB = "3600"
ShockPerHour_1.Symbol = "spm"
```
## HertzPerSecond <!-- NOUN -->
- Display name: hertz per second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
HertzPerSecond:HertzPerSecond_1
HertzPerSecond_1.Symbol = "Hz/s"
```
## KiloHertzPerSecond <!-- NOUN -->
- Display name: kilo hertz per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo hertz per second
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KiloHertzPerSecond:KiloHertzPerSecond_1
KiloHertzPerSecond_1.ConversionFactorB = "0.001"
KiloHertzPerSecond_1.Symbol = "kHz/s"
```
## MegaHertzPerSecond <!-- NOUN -->
- Display name: mega hertz per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in mega hertz per second
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
MegaHertzPerSecond:MegaHertzPerSecond_1
MegaHertzPerSecond_1.ConversionFactorB = "1E-06"
MegaHertzPerSecond_1.Symbol = "MHz/s"
```
## GigaHertzPerSecond <!-- NOUN -->
- Display name: giga hertz per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in giga hertz per second
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
GigaHertzPerSecond:GigaHertzPerSecond_1
GigaHertzPerSecond_1.ConversionFactorB = "1E-09"
GigaHertzPerSecond_1.Symbol = "GHz/s"
```
## HertzPerMinute <!-- NOUN -->
- Display name: hertz per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in hertz per minute
[SI] is the value in SI
a = Minute/Unit, i.e., 60
and
Minute = 60.0
Unit = 1.0

- Examples: 
``` dwis
HertzPerMinute:HertzPerMinute_1
HertzPerMinute_1.ConversionFactorB = "60"
HertzPerMinute_1.Symbol = "Hz/min"
```
## KiloHertzPerMinute <!-- NOUN -->
- Display name: kilo hertz per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo hertz per minute
[SI] is the value in SI
a = Minute/Kilo, i.e., 0.06
and
Minute = 60.0
Kilo = 1000.0

- Examples: 
``` dwis
KiloHertzPerMinute:KiloHertzPerMinute_1
KiloHertzPerMinute_1.ConversionFactorB = "0.06"
KiloHertzPerMinute_1.Symbol = "kHz/min"
```
## MegaHertzPerMinute <!-- NOUN -->
- Display name: mega hertz per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in mega hertz per minute
[SI] is the value in SI
a = Minute/Mega, i.e., 6E-05
and
Minute = 60.0
Mega = 1e6

- Examples: 
``` dwis
MegaHertzPerMinute:MegaHertzPerMinute_1
MegaHertzPerMinute_1.ConversionFactorB = "6E-05"
MegaHertzPerMinute_1.Symbol = "MHz/min"
```
## GigaHertzPerMinute <!-- NOUN -->
- Display name: giga hertz per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in giga hertz per minute
[SI] is the value in SI
a = Minute/Giga, i.e., 6E-08
and
Minute = 60.0
Giga = 1e9

- Examples: 
``` dwis
GigaHertzPerMinute:GigaHertzPerMinute_1
GigaHertzPerMinute_1.ConversionFactorB = "6E-08"
GigaHertzPerMinute_1.Symbol = "GHz/min"
```
## HertzPerHour <!-- NOUN -->
- Display name: hertz per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in hertz per hour
[SI] is the value in SI
a = Hour/Unit, i.e., 3600
and
Hour = 60.0 * Minute
Unit = 1.0
Minute = 60.0

- Examples: 
``` dwis
HertzPerHour:HertzPerHour_1
HertzPerHour_1.ConversionFactorB = "3600"
HertzPerHour_1.Symbol = "Hz/h"
```
## KiloHertzPerHour <!-- NOUN -->
- Display name: kilo hertz per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.6
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo hertz per hour
[SI] is the value in SI
a = Hour/Kilo, i.e., 3.6
and
Hour = 60.0 * Minute
Kilo = 1000.0
Minute = 60.0

- Examples: 
``` dwis
KiloHertzPerHour:KiloHertzPerHour_1
KiloHertzPerHour_1.ConversionFactorB = "3.6"
KiloHertzPerHour_1.Symbol = "kHz/h"
```
## MegaHertzPerHour <!-- NOUN -->
- Display name: mega hertz per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0036
- Description: 
[v] = a * [SI]
where
[v] is the value in mega hertz per hour
[SI] is the value in SI
a = Hour/Mega, i.e., 0.0036
and
Hour = 60.0 * Minute
Mega = 1e6
Minute = 60.0

- Examples: 
``` dwis
MegaHertzPerHour:MegaHertzPerHour_1
MegaHertzPerHour_1.ConversionFactorB = "0.0036"
MegaHertzPerHour_1.Symbol = "MHz/h"
```
## GigaHertzPerHour <!-- NOUN -->
- Display name: giga hertz per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.6E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in giga hertz per hour
[SI] is the value in SI
a = Hour/Giga, i.e., 3.6E-06
and
Hour = 60.0 * Minute
Giga = 1e9
Minute = 60.0

- Examples: 
``` dwis
GigaHertzPerHour:GigaHertzPerHour_1
GigaHertzPerHour_1.ConversionFactorB = "3.6E-06"
GigaHertzPerHour_1.Symbol = "GHz/h"
```
## HertzPerDay <!-- NOUN -->
- Display name: hertz per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400
- Description: 
[v] = a * [SI]
where
[v] is the value in hertz per day
[SI] is the value in SI
a = Day/Unit, i.e., 86400
and
Day = 24.0 * Hour
Unit = 1.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
HertzPerDay:HertzPerDay_1
HertzPerDay_1.ConversionFactorB = "86400"
HertzPerDay_1.Symbol = "Hz/d"
```
## KiloHertzPerDay <!-- NOUN -->
- Display name: kilo hertz per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86.4
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo hertz per day
[SI] is the value in SI
a = Day/Kilo, i.e., 86.4
and
Day = 24.0 * Hour
Kilo = 1000.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
KiloHertzPerDay:KiloHertzPerDay_1
KiloHertzPerDay_1.ConversionFactorB = "86.4"
KiloHertzPerDay_1.Symbol = "kHz/d"
```
## MegaHertzPerDay <!-- NOUN -->
- Display name: mega hertz per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0864
- Description: 
[v] = a * [SI]
where
[v] is the value in mega hertz per day
[SI] is the value in SI
a = Day/Mega, i.e., 0.0864
and
Day = 24.0 * Hour
Mega = 1e6
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MegaHertzPerDay:MegaHertzPerDay_1
MegaHertzPerDay_1.ConversionFactorB = "0.0864"
MegaHertzPerDay_1.Symbol = "MHz/d"
```
## GigaHertzPerDay <!-- NOUN -->
- Display name: giga hertz per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 8.64E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in giga hertz per day
[SI] is the value in SI
a = Day/Giga, i.e., 8.64E-05
and
Day = 24.0 * Hour
Giga = 1e9
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
GigaHertzPerDay:GigaHertzPerDay_1
GigaHertzPerDay_1.ConversionFactorB = "8.64E-05"
GigaHertzPerDay_1.Symbol = "GHz/d"
```
## HertzPerYear <!-- NOUN -->
- Display name: hertz per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 31557600
- Description: 
[v] = a * [SI]
where
[v] is the value in hertz per year
[SI] is the value in SI
a = YearJulian/Unit, i.e., 31557600
and
YearJulian = 365.25 * Day
Unit = 1.0
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
HertzPerYear:HertzPerYear_1
HertzPerYear_1.ConversionFactorB = "31557600"
HertzPerYear_1.Symbol = "Hz/y"
```
## KiloHertzPerYear <!-- NOUN -->
- Display name: kilo hertz per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 31557.6
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo hertz per year
[SI] is the value in SI
a = YearJulian/Kilo, i.e., 31557.6
and
YearJulian = 365.25 * Day
Kilo = 1000.0
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
KiloHertzPerYear:KiloHertzPerYear_1
KiloHertzPerYear_1.ConversionFactorB = "31557.6"
KiloHertzPerYear_1.Symbol = "kHz/y"
```
## MegaHertzPerYear <!-- NOUN -->
- Display name: mega hertz per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 31.5576
- Description: 
[v] = a * [SI]
where
[v] is the value in mega hertz per year
[SI] is the value in SI
a = YearJulian/Mega, i.e., 31.5576
and
YearJulian = 365.25 * Day
Mega = 1e6
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MegaHertzPerYear:MegaHertzPerYear_1
MegaHertzPerYear_1.ConversionFactorB = "31.5576"
MegaHertzPerYear_1.Symbol = "MHz/y"
```
## GigaHertzPerYear <!-- NOUN -->
- Display name: giga hertz per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0315576
- Description: 
[v] = a * [SI]
where
[v] is the value in giga hertz per year
[SI] is the value in SI
a = YearJulian/Giga, i.e., 0.0315576
and
YearJulian = 365.25 * Day
Giga = 1e9
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
GigaHertzPerYear:GigaHertzPerYear_1
GigaHertzPerYear_1.ConversionFactorB = "0.0315576"
GigaHertzPerYear_1.Symbol = "GHz/y"
```
## RpmPerSecond <!-- NOUN -->
- Display name: rpm per second
- Parent class: Unit
- Specialization: 
- Description: 
- Examples: 
``` dwis
RpmPerSecond:RpmPerSecond_1
RpmPerSecond_1.Symbol = "rpm/s"
```
## SpmPerSecond <!-- NOUN -->
- Display name: spm per second
- Parent class: Unit
- Specialization: 
- Description: 
- Examples: 
``` dwis
SpmPerSecond:SpmPerSecond_1
SpmPerSecond_1.Symbol = "spm/s"
```
## WattPerSquareMetrePerKelvin <!-- NOUN -->
- Display name: watt per square metre per kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
WattPerSquareMetrePerKelvin:WattPerSquareMetrePerKelvin_1
WattPerSquareMetrePerKelvin_1.Symbol = "W/m²/K"
```
## BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit <!-- NOUN -->
- Display name: british thermal unit per hour per square foot per degree fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.17622808365343573
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per hour per square foot per degree fahrenheit
[SI] is the value in SI
a = Hour * Foot*Foot * FahrenheitSlope / BTU, i.e., 0.17622808365343573
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit:BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit_1
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit_1.ConversionFactorB = "0.17622808365343573"
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit_1.Symbol = "BTU/h/ft²/°F"
```
## DotPerMetre <!-- NOUN -->
- Display name: dot per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
DotPerMetre:DotPerMetre_1
DotPerMetre_1.Symbol = "dpm"
```
## DotPerInch <!-- NOUN -->
- Display name: dot per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0254
- Description: 
[v] = a * [SI]
where
[v] is the value in dot per inch
[SI] is the value in SI
a = Inch, i.e., 0.0254
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DotPerInch:DotPerInch_1
DotPerInch_1.ConversionFactorB = "0.0254"
DotPerInch_1.Symbol = "dpi"
```
## DotPerMillimetre <!-- NOUN -->
- Display name: dot per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in dot per millimetre
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
DotPerMillimetre:DotPerMillimetre_1
DotPerMillimetre_1.ConversionFactorB = "0.001"
DotPerMillimetre_1.Symbol = "dpmm"
```
## DotPerMicrometre <!-- NOUN -->
- Display name: dot per micrometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in dot per micrometre
[SI] is the value in SI
a = Micro, i.e., 1E-06
and
Micro = 1e-6

- Examples: 
``` dwis
DotPerMicrometre:DotPerMicrometre_1
DotPerMicrometre_1.ConversionFactorB = "1E-06"
DotPerMicrometre_1.Symbol = "dpµm"
```
## MillinewtonPerMetre <!-- NOUN -->
- Display name: millinewton per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millinewton per metre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
MillinewtonPerMetre:MillinewtonPerMetre_1
MillinewtonPerMetre_1.ConversionFactorB = "1000"
MillinewtonPerMetre_1.Symbol = "mN/m"
```
## DynePerCentimetre <!-- NOUN -->
- Display name: dyne per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999.9999999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in dyne per centimetre
[SI] is the value in SI
a = Centi/Dyne, i.e., 999.9999999999999
and
Centi = 0.01
Dyne = 1e-5 reference: https://en.wikipedia.org/wiki/Dyne

- Examples: 
``` dwis
DynePerCentimetre:DynePerCentimetre_1
DynePerCentimetre_1.ConversionFactorB = "999.9999999999999"
DynePerCentimetre_1.Symbol = "dyne/cm"
```
## PoundPerSecondSquared <!-- NOUN -->
- Display name: pound per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.2046226218487757
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per second squared
[SI] is the value in SI
a = 1.0/Pound, i.e., 2.2046226218487757
and
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerSecondSquared:PoundPerSecondSquared_1
PoundPerSecondSquared_1.ConversionFactorB = "2.2046226218487757"
PoundPerSecondSquared_1.Symbol = "lb/s²"
```
## Metre <!-- NOUN -->
- Display name: metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Metre:Metre_1
Metre_1.Symbol = "m"
```
## Decimetre <!-- NOUN -->
- Display name: decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre
[SI] is the value in SI
a = 1.0/Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
Decimetre:Decimetre_1
Decimetre_1.ConversionFactorB = "10"
Decimetre_1.Symbol = "dm"
```
## Centimetre <!-- NOUN -->
- Display name: centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Centimetre:Centimetre_1
Centimetre_1.ConversionFactorB = "100"
Centimetre_1.Symbol = "cm"
```
## Millimetre <!-- NOUN -->
- Display name: millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millimetre:Millimetre_1
Millimetre_1.ConversionFactorB = "1000"
Millimetre_1.Symbol = "mm"
```
## Micrometre <!-- NOUN -->
- Display name: micrometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in micrometre
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Micrometre:Micrometre_1
Micrometre_1.ConversionFactorB = "1000000"
Micrometre_1.Symbol = "µm"
```
## Nanometre <!-- NOUN -->
- Display name: nanometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanometre
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanometre:Nanometre_1
Nanometre_1.ConversionFactorB = "999999999.9999999"
Nanometre_1.Symbol = "nm"
```
## Aangstroem <!-- NOUN -->
- Display name: ångstrøm
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in ångstrøm
[SI] is the value in SI
a = 1.0/Angstrom, i.e., 10000000000
and
Angstrom = 1e-10

- Examples: 
``` dwis
Aangstroem:Aangstroem_1
Aangstroem_1.ConversionFactorB = "10000000000"
Aangstroem_1.Symbol = "Å"
```
## Picometre <!-- NOUN -->
- Display name: picometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picometre
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picometre:Picometre_1
Picometre_1.ConversionFactorB = "1000000000000"
Picometre_1.Symbol = "pm"
```
## Decametre <!-- NOUN -->
- Display name: decametre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in decametre
[SI] is the value in SI
a = 1.0/Deca, i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
Decametre:Decametre_1
Decametre_1.ConversionFactorB = "0.1"
Decametre_1.Symbol = "dam"
```
## Hectometre <!-- NOUN -->
- Display name: hectometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in hectometre
[SI] is the value in SI
a = 1.0/Hecto, i.e., 0.01
and
Hecto = 100.0

- Examples: 
``` dwis
Hectometre:Hectometre_1
Hectometre_1.ConversionFactorB = "0.01"
Hectometre_1.Symbol = "hm"
```
## Kilometre <!-- NOUN -->
- Display name: kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilometre:Kilometre_1
Kilometre_1.ConversionFactorB = "0.001"
Kilometre_1.Symbol = "km"
```
## AstronomicalUnit <!-- NOUN -->
- Display name: astronomical unit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.684587122268445E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in astronomical unit
[SI] is the value in SI
a = 1.0/AstronomicalUnit, i.e., 6.684587122268445E-12
and
AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf

- Examples: 
``` dwis
AstronomicalUnit:AstronomicalUnit_1
AstronomicalUnit_1.ConversionFactorB = "6.684587122268445E-12"
AstronomicalUnit_1.Symbol = "au"
```
## LightYear <!-- NOUN -->
- Display name: light year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.0570008340246154E-16
- Description: 
[v] = a * [SI]
where
[v] is the value in light year
[SI] is the value in SI
a = 1.0/LightYear, i.e., 1.0570008340246154E-16
and
LightYear = 9460730472580800.0 reference: https://www.iau.org/public/themes/measuring/

- Examples: 
``` dwis
LightYear:LightYear_1
LightYear_1.ConversionFactorB = "1.0570008340246154E-16"
LightYear_1.Symbol = "ly"
```
## Parsec <!-- NOUN -->
- Display name: parsec
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.240779289444365E-17
- Description: 
[v] = a * [SI]
where
[v] is the value in parsec
[SI] is the value in SI
a = 1.0/Parsec, i.e., 3.240779289444365E-17
and
Parsec = (60.0*60.0*180.0 / System.Math.PI) * AstronomicalUnit reference: https://imagine.gsfc.nasa.gov/features/cosmic/milkyway_info.html
AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf

- Examples: 
``` dwis
Parsec:Parsec_1
Parsec_1.ConversionFactorB = "3.240779289444365E-17"
Parsec_1.Symbol = "pc"
```
## Foot <!-- NOUN -->
- Display name: foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.280839895013124
- Description: 
[v] = a * [SI]
where
[v] is the value in foot
[SI] is the value in SI
a = 1.0/Foot, i.e., 3.280839895013124
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Foot:Foot_1
Foot_1.ConversionFactorB = "3.280839895013124"
Foot_1.Symbol = "ft"
```
## UsSurveyFoot <!-- NOUN -->
- Display name: US survey foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.2808333333333337
- Description: 
[v] = a * [SI]
where
[v] is the value in US survey foot
[SI] is the value in SI
a = 1.0/USSurveyFoot, i.e., 3.2808333333333337
and
USSurveyFoot = 1200.0 / 3937.0 reference: https://www.nist.gov/pml/us-surveyfoot

- Examples: 
``` dwis
UsSurveyFoot:UsSurveyFoot_1
UsSurveyFoot_1.ConversionFactorB = "3.2808333333333337"
UsSurveyFoot_1.Symbol = "ft"
```
## Inch <!-- NOUN -->
- Display name: inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 39.37007874015748
- Description: 
[v] = a * [SI]
where
[v] is the value in inch
[SI] is the value in SI
a = 1.0/Inch, i.e., 39.37007874015748
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Inch:Inch_1
Inch_1.ConversionFactorB = "39.37007874015748"
Inch_1.Symbol = "in"
```
## Yard <!-- NOUN -->
- Display name: yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.093613298337708
- Description: 
[v] = a * [SI]
where
[v] is the value in yard
[SI] is the value in SI
a = 1.0/Yard, i.e., 1.093613298337708
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Yard:Yard_1
Yard_1.ConversionFactorB = "1.093613298337708"
Yard_1.Symbol = "yd"
```
## Fathom <!-- NOUN -->
- Display name: fathom
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.546806649168854
- Description: 
[v] = a * [SI]
where
[v] is the value in fathom
[SI] is the value in SI
a = 1.0/Fathom, i.e., 0.546806649168854
and
Fathom = 6.0 * Foot reference: https://www.britannica.com/science/fathom
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Fathom:Fathom_1
Fathom_1.ConversionFactorB = "0.546806649168854"
Fathom_1.Symbol = "fathom"
```
## SurveyorSChain <!-- NOUN -->
- Display name: surveyor's chain
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.04970969537898672
- Description: 
[v] = a * [SI]
where
[v] is the value in surveyor's chain
[SI] is the value in SI
a = 1.0/SurveyorChain, i.e., 0.04970969537898672
and
SurveyorChain = 22.0 * Yard reference: https://www.britannica.com/technology/surveyors-chain
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
SurveyorSChain:SurveyorSChain_1
SurveyorSChain_1.ConversionFactorB = "0.04970969537898672"
SurveyorSChain_1.Symbol = "chain"
```
## Mile <!-- NOUN -->
- Display name: mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.000621371192237334
- Description: 
[v] = a * [SI]
where
[v] is the value in mile
[SI] is the value in SI
a = 1.0/Mile, i.e., 0.000621371192237334
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Mile:Mile_1
Mile_1.ConversionFactorB = "0.000621371192237334"
Mile_1.Symbol = "mi"
```
## InternationalNauticalMile <!-- NOUN -->
- Display name: international nautical mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0005399568034557236
- Description: 
[v] = a * [SI]
where
[v] is the value in international nautical mile
[SI] is the value in SI
a = 1.0/InternationalNauticalMile, i.e., 0.0005399568034557236
and
InternationalNauticalMile = 1852.0 reference: https://www.merriam-webster.com/dictionary/nautical%20mile

- Examples: 
``` dwis
InternationalNauticalMile:InternationalNauticalMile_1
InternationalNauticalMile_1.ConversionFactorB = "0.0005399568034557236"
InternationalNauticalMile_1.Symbol = "nmi"
```
## UkNauticalMile <!-- NOUN -->
- Display name: UK nautical mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0005396118248376849
- Description: 
[v] = a * [SI]
where
[v] is the value in UK nautical mile
[SI] is the value in SI
a = 1.0/UKNauticalMile, i.e., 0.0005396118248376849
and
UKNauticalMile = 6080 * Foot reference: https://www.rmg.co.uk/stories/topics/nautical-mile
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UkNauticalMile:UkNauticalMile_1
UkNauticalMile_1.ConversionFactorB = "0.0005396118248376849"
UkNauticalMile_1.Symbol = "UK nmi"
```
## ScandinavianMile <!-- NOUN -->
- Display name: scandinavian mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in scandinavian mile
[SI] is the value in SI
a = 1.0/ScandinavianMile, i.e., 0.0001
and
ScandinavianMile = 10000.0

- Examples: 
``` dwis
ScandinavianMile:ScandinavianMile_1
ScandinavianMile_1.ConversionFactorB = "0.0001"
ScandinavianMile_1.Symbol = "mil"
```
## InchPer32 <!-- NOUN -->
- Display name: inch per 32
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1259.8425196850394
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per 32
[SI] is the value in SI
a = 1.0/InchPer32, i.e., 1259.8425196850394
and
InchPer32 = Inch / 32.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
InchPer32:InchPer32_1
InchPer32_1.ConversionFactorB = "1259.8425196850394"
InchPer32_1.Symbol = "in/32"
```
## Mil <!-- NOUN -->
- Display name: mil
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 39370.07874015748
- Description: 
[v] = a * [SI]
where
[v] is the value in mil
[SI] is the value in SI
a = 1.0/Mil, i.e., 39370.07874015748
and
Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Mil:Mil_1
Mil_1.ConversionFactorB = "39370.07874015748"
Mil_1.Symbol = "mil"
```
## Thou <!-- NOUN -->
- Display name: thou
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 39370.07874015748
- Description: 
[v] = a * [SI]
where
[v] is the value in thou
[SI] is the value in SI
a = 1.0/Thou, i.e., 39370.07874015748
and
Thou = Mil
Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Thou:Thou_1
Thou_1.ConversionFactorB = "39370.07874015748"
Thou_1.Symbol = "thou"
```
## Hand <!-- NOUN -->
- Display name: hand
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.84251968503937
- Description: 
[v] = a * [SI]
where
[v] is the value in hand
[SI] is the value in SI
a = 1.0/Hand, i.e., 9.84251968503937
and
Hand = 4.0 * Inch reference: https://en.wikipedia.org/wiki/Hand_(unit)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Hand:Hand_1
Hand_1.ConversionFactorB = "9.84251968503937"
Hand_1.Symbol = "hand"
```
## Furlong <!-- NOUN -->
- Display name: furlong
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.004970969537898672
- Description: 
[v] = a * [SI]
where
[v] is the value in furlong
[SI] is the value in SI
a = 1.0/Furlong, i.e., 0.004970969537898672
and
Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Furlong:Furlong_1
Furlong_1.ConversionFactorB = "0.004970969537898672"
Furlong_1.Symbol = "furlong"
```
## Candela <!-- NOUN -->
- Display name: candela
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Candela:Candela_1
Candela_1.Symbol = "cd"
```
## LumenPerSteradian <!-- NOUN -->
- Display name: lumen per steradian
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in lumen per steradian
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
LumenPerSteradian:LumenPerSteradian_1
LumenPerSteradian_1.Symbol = "lm/st"
```
## Millicandela <!-- NOUN -->
- Display name: millicandela
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millicandela
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millicandela:Millicandela_1
Millicandela_1.ConversionFactorB = "1000"
Millicandela_1.Symbol = "mcd"
```
## Kilocandela <!-- NOUN -->
- Display name: kilocandela
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocandela
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilocandela:Kilocandela_1
Kilocandela_1.ConversionFactorB = "0.001"
Kilocandela_1.Symbol = "kcd"
```
## Hefnerkerze <!-- NOUN -->
- Display name: hefnerkerze
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.0869565217391304
- Description: 
[v] = a * [SI]
where
[v] is the value in hefnerkerze
[SI] is the value in SI
a = 1.0/Hefnerkerze, i.e., 1.0869565217391304
and
Hefnerkerze = 0.92 reference: https://en.wikipedia.org/wiki/Hefner_lamp

- Examples: 
``` dwis
Hefnerkerze:Hefnerkerze_1
Hefnerkerze_1.ConversionFactorB = "1.0869565217391304"
Hefnerkerze_1.Symbol = "hefnerkerze"
```
## InternationalCandle <!-- NOUN -->
- Display name: international candle
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.9803921568627451
- Description: 
[v] = a * [SI]
where
[v] is the value in international candle
[SI] is the value in SI
a = 1.0/InternationalCandle, i.e., 0.9803921568627451
and
InternationalCandle = 1.02

- Examples: 
``` dwis
InternationalCandle:InternationalCandle_1
InternationalCandle_1.ConversionFactorB = "0.9803921568627451"
InternationalCandle_1.Symbol = "int. candle"
```
## DecimalCandle <!-- NOUN -->
- Display name: decimal candle
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in decimal candle
[SI] is the value in SI
a = 1.0 / Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
DecimalCandle:DecimalCandle_1
DecimalCandle_1.Symbol = "dec. candle"
```
## BerlinerLichteinheit <!-- NOUN -->
- Display name: berliner lichteinheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.0869565217391304
- Description: 
[v] = a * [SI]
where
[v] is the value in berliner lichteinheit
[SI] is the value in SI
a = 1.0/ Hefnerkerze, i.e., 1.0869565217391304
and
Hefnerkerze = 0.92 reference: https://en.wikipedia.org/wiki/Hefner_lamp

- Examples: 
``` dwis
BerlinerLichteinheit:BerlinerLichteinheit_1
BerlinerLichteinheit_1.ConversionFactorB = "1.0869565217391304"
BerlinerLichteinheit_1.Symbol = "berliner lichteinheit"
```
## DvwgCandle <!-- NOUN -->
- Display name: DVWG candle
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.9354186934071691
- Description: 
[v] = a * [SI]
where
[v] is the value in DVWG candle
[SI] is the value in SI
a = 1.0/DVGWCandle, i.e., 0.9354186934071691
and
DVGWCandle = 1.162 * Hefnerkerze reference: https://fr.wikipedia.org/wiki/Bougie_(unit%C3%A9)
Hefnerkerze = 0.92 reference: https://en.wikipedia.org/wiki/Hefner_lamp

- Examples: 
``` dwis
DvwgCandle:DvwgCandle_1
DvwgCandle_1.ConversionFactorB = "0.9354186934071691"
DvwgCandle_1.Symbol = "DVWG candle"
```
## Violle <!-- NOUN -->
- Display name: violle
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.016666666666666666
- Description: 
[v] = a * [SI]
where
[v] is the value in violle
[SI] is the value in SI
a = 1.0/Violle, i.e., 0.016666666666666666
and
Violle = 60.0 reference: https://en.wikipedia.org/wiki/Jules_Violle

- Examples: 
``` dwis
Violle:Violle_1
Violle_1.ConversionFactorB = "0.016666666666666666"
Violle_1.Symbol = "violle"
```
## Carcel <!-- NOUN -->
- Display name: carcel
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1026694045174538
- Description: 
[v] = a * [SI]
where
[v] is the value in carcel
[SI] is the value in SI
a = 1.0/Carcel, i.e., 0.1026694045174538
and
Carcel = 9.74 reference: https://en.wikipedia.org/wiki/Carcel

- Examples: 
``` dwis
Carcel:Carcel_1
Carcel_1.ConversionFactorB = "0.1026694045174538"
Carcel_1.Symbol = "carcel"
```
## Tesla <!-- NOUN -->
- Display name: tesla
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Tesla:Tesla_1
Tesla_1.Symbol = "T"
```
## Gauss <!-- NOUN -->
- Display name: gauss
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in gauss
[SI] is the value in SI
a = 1.0/Gauss, i.e., 10000
and
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)

- Examples: 
``` dwis
Gauss:Gauss_1
Gauss_1.ConversionFactorB = "10000"
Gauss_1.Symbol = "G"
```
## Milligauss <!-- NOUN -->
- Display name: milligauss
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000000
- Description: 
[v] = a * [SI]
where
[v] is the value in milligauss
[SI] is the value in SI
a = 1.0/(Milli*Gauss), i.e., 10000000
and
Milli = 0.001
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)

- Examples: 
``` dwis
Milligauss:Milligauss_1
Milligauss_1.ConversionFactorB = "10000000"
Milligauss_1.Symbol = "mG"
```
## Millitesla <!-- NOUN -->
- Display name: millitesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millitesla
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millitesla:Millitesla_1
Millitesla_1.ConversionFactorB = "1000"
Millitesla_1.Symbol = "mT"
```
## Microtesla <!-- NOUN -->
- Display name: microtesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microtesla
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microtesla:Microtesla_1
Microtesla_1.ConversionFactorB = "1000000"
Microtesla_1.Symbol = "µT"
```
## Nanotesla <!-- NOUN -->
- Display name: nanotesla
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanotesla
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanotesla:Nanotesla_1
Nanotesla_1.ConversionFactorB = "999999999.9999999"
Nanotesla_1.Symbol = "nT"
```
## MaxwellPerSquareCentimetre <!-- NOUN -->
- Display name: maxwell per square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in maxwell per square centimetre
[SI] is the value in SI
a = Centi*Centi/Unit, i.e., 0.0001
and
Centi = 0.01
Unit = 1.0

- Examples: 
``` dwis
MaxwellPerSquareCentimetre:MaxwellPerSquareCentimetre_1
MaxwellPerSquareCentimetre_1.ConversionFactorB = "0.0001"
MaxwellPerSquareCentimetre_1.Symbol = "Mx/cm²"
```
## WeberPerSquareMetre <!-- NOUN -->
- Display name: weber per square metre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in weber per square metre
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
WeberPerSquareMetre:WeberPerSquareMetre_1
WeberPerSquareMetre_1.Symbol = "Wb/m²"
```
## Weber <!-- NOUN -->
- Display name: weber
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Weber:Weber_1
Weber_1.Symbol = "Wb"
```
## Milliweber <!-- NOUN -->
- Display name: milliweber
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in milliweber
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Milliweber:Milliweber_1
Milliweber_1.ConversionFactorB = "1000"
Milliweber_1.Symbol = "mWb"
```
## Microweber <!-- NOUN -->
- Display name: microweber
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microweber
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microweber:Microweber_1
Microweber_1.ConversionFactorB = "1000000"
Microweber_1.Symbol = "µWb"
```
## VoltSecond <!-- NOUN -->
- Display name: volt second
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in volt second
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
VoltSecond:VoltSecond_1
VoltSecond_1.Symbol = "V•s"
```
## UnitPole <!-- NOUN -->
- Display name: unit pole
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 795774715459476.8
- Description: 
[v] = a * [SI]
where
[v] is the value in unit pole
[SI] is the value in SI
a = 1e16/(4.0*PI), i.e., 795774715459476.8

- Examples: 
``` dwis
UnitPole:UnitPole_1
UnitPole_1.ConversionFactorB = "795774715459476.8"
UnitPole_1.Symbol = "unit pole"
```
## Megaline <!-- NOUN -->
- Display name: megaline
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in megaline
[SI] is the value in SI
a = 1.0/(Mega*Line), i.e., 100
and
Mega = 1e6
Line = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)

- Examples: 
``` dwis
Megaline:Megaline_1
Megaline_1.ConversionFactorB = "100"
Megaline_1.Symbol = "megaline"
```
## Kiloline <!-- NOUN -->
- Display name: kiloline
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 99999.99999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in kiloline
[SI] is the value in SI
a = 1.0/(Kilo*Line), i.e., 99999.99999999999
and
Kilo = 1000.0
Line = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)

- Examples: 
``` dwis
Kiloline:Kiloline_1
Kiloline_1.ConversionFactorB = "99999.99999999999"
Kiloline_1.Symbol = "kiloline"
```
## Line <!-- NOUN -->
- Display name: line
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100000000
- Description: 
[v] = a * [SI]
where
[v] is the value in line
[SI] is the value in SI
a = 1.0/Line, i.e., 100000000
and
Line = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)

- Examples: 
``` dwis
Line:Line_1
Line_1.ConversionFactorB = "100000000"
Line_1.Symbol = "line"
```
## Maxwell <!-- NOUN -->
- Display name: maxwell
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100000000
- Description: 
[v] = a * [SI]
where
[v] is the value in maxwell
[SI] is the value in SI
a = 1.0/Maxwell, i.e., 100000000
and
Maxwell = 1e-8 reference: https://en.wikipedia.org/wiki/Maxwell_(unit)

- Examples: 
``` dwis
Maxwell:Maxwell_1
Maxwell_1.ConversionFactorB = "100000000"
Maxwell_1.Symbol = "Mx"
```
## TeslaSquareMetre <!-- NOUN -->
- Display name: tesla square metre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in tesla square metre
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
TeslaSquareMetre:TeslaSquareMetre_1
TeslaSquareMetre_1.Symbol = "T•m²"
```
## TeslaSquareCentimetre <!-- NOUN -->
- Display name: tesla square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in tesla square centimetre
[SI] is the value in SI
a = 1.0/(Unit *Centi*Centi), i.e., 10000
and
Unit = 1.0
Centi = 0.01

- Examples: 
``` dwis
TeslaSquareCentimetre:TeslaSquareCentimetre_1
TeslaSquareCentimetre_1.ConversionFactorB = "10000"
TeslaSquareCentimetre_1.Symbol = "T•cm²"
```
## GaussSquareCentimetre <!-- NOUN -->
- Display name: gauss square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 99999999.99999999
- Description: 
[v] = a * [SI]
where
[v] is the value in gauss square centimetre
[SI] is the value in SI
a = 1.0/(Gauss *Centi*Centi), i.e., 99999999.99999999
and
Gauss = 1e-4 reference: https://en.wikipedia.org/wiki/Gauss_(unit)
Centi = 0.01

- Examples: 
``` dwis
GaussSquareCentimetre:GaussSquareCentimetre_1
GaussSquareCentimetre_1.ConversionFactorB = "99999999.99999999"
GaussSquareCentimetre_1.Symbol = "G•cm²"
```
## MagneticFluxQuantum <!-- NOUN -->
- Display name: magnetic flux quantum
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 483597848416983.56
- Description: 
[v] = a * [SI]
where
[v] is the value in magnetic flux quantum
[SI] is the value in SI
a = 1.0/MagneticFluxQuantum, i.e., 483597848416983.56
and
MagneticFluxQuantum = PlanckConstant / (2.0*ElectronCharge) reference: https://en.wikipedia.org/wiki/Magnetic_flux_quantum
PlanckConstant = 6.62607015e-34 reference: https://en.wikipedia.org/wiki/Planck_constant
ElectronCharge = 1.602176634e-19 reference: https://en.wikipedia.org/wiki/Elementary_charge

- Examples: 
``` dwis
MagneticFluxQuantum:MagneticFluxQuantum_1
MagneticFluxQuantum_1.ConversionFactorB = "483597848416983.56"
MagneticFluxQuantum_1.Symbol = "mag flux quant"
```
## KilogramPerMetre <!-- NOUN -->
- Display name: kilogram per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KilogramPerMetre:KilogramPerMetre_1
KilogramPerMetre_1.Symbol = "kg/m"
```
## GramPerMetre <!-- NOUN -->
- Display name: gram per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in gram per metre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
GramPerMetre:GramPerMetre_1
GramPerMetre_1.ConversionFactorB = "1000"
GramPerMetre_1.Symbol = "g/m"
```
## KilogramPerSecond <!-- NOUN -->
- Display name: kilogram per second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KilogramPerSecond:KilogramPerSecond_1
KilogramPerSecond_1.Symbol = "kg/s"
```
## KilogramPerMinute <!-- NOUN -->
- Display name: kilogram per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram per minute
[SI] is the value in SI
a = Minute/Unit, i.e., 60
and
Minute = 60.0
Unit = 1.0

- Examples: 
``` dwis
KilogramPerMinute:KilogramPerMinute_1
KilogramPerMinute_1.ConversionFactorB = "60"
KilogramPerMinute_1.Symbol = "kg/min"
```
## KilogramPerHour <!-- NOUN -->
- Display name: kilogram per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram per hour
[SI] is the value in SI
a = Hour/Unit, i.e., 3600
and
Hour = 60.0 * Minute
Unit = 1.0
Minute = 60.0

- Examples: 
``` dwis
KilogramPerHour:KilogramPerHour_1
KilogramPerHour_1.ConversionFactorB = "3600"
KilogramPerHour_1.Symbol = "kg/h"
```
## KilogramPerYear <!-- NOUN -->
- Display name: kilogram per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 31557600
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram per year
[SI] is the value in SI
a = YearJulian/Unit, i.e., 31557600
and
YearJulian = 365.25 * Day
Unit = 1.0
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
KilogramPerYear:KilogramPerYear_1
KilogramPerYear_1.ConversionFactorB = "31557600"
KilogramPerYear_1.Symbol = "kg/y"
```
## PoundPerSecond <!-- NOUN -->
- Display name: pound per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.2046226218487757
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per second
[SI] is the value in SI
a = Unit/Pound, i.e., 2.2046226218487757
and
Unit = 1.0
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerSecond:PoundPerSecond_1
PoundPerSecond_1.ConversionFactorB = "2.2046226218487757"
PoundPerSecond_1.Symbol = "lb/s"
```
## PoundPerMinute <!-- NOUN -->
- Display name: pound per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 132.27735731092653
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per minute
[SI] is the value in SI
a = Minute/Pound, i.e., 132.27735731092653
and
Minute = 60.0
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
PoundPerMinute:PoundPerMinute_1
PoundPerMinute_1.ConversionFactorB = "132.27735731092653"
PoundPerMinute_1.Symbol = "lb/min"
```
## PoundPerHour <!-- NOUN -->
- Display name: pound per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 7936.6414386555925
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per hour
[SI] is the value in SI
a = Hour/Pound, i.e., 7936.6414386555925
and
Hour = 60.0 * Minute
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Minute = 60.0

- Examples: 
``` dwis
PoundPerHour:PoundPerHour_1
PoundPerHour_1.ConversionFactorB = "7936.6414386555925"
PoundPerHour_1.Symbol = "lb/h"
```
## PoundPerYear <!-- NOUN -->
- Display name: pound per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 69572598.85125493
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per year
[SI] is the value in SI
a = YearJulian/Pound, i.e., 69572598.85125493
and
YearJulian = 365.25 * Day
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
PoundPerYear:PoundPerYear_1
PoundPerYear_1.ConversionFactorB = "69572598.85125493"
PoundPerYear_1.Symbol = "lb/y"
```
## Pascal <!-- NOUN -->
- Display name: pascal
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Pascal:Pascal_1
Pascal_1.Symbol = "Pa"
```
## Megapascal <!-- NOUN -->
- Display name: megapascal
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megapascal
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Megapascal:Megapascal_1
Megapascal_1.ConversionFactorB = "1E-06"
Megapascal_1.Symbol = "MPa"
```
## Gigapascal <!-- NOUN -->
- Display name: gigapascal
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigapascal
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Gigapascal:Gigapascal_1
Gigapascal_1.ConversionFactorB = "1E-09"
Gigapascal_1.Symbol = "GPa"
```
## Psi <!-- NOUN -->
- Display name: psi
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00014503773773020924
- Description: 
[v] = a * [SI]
where
[v] is the value in psi
[SI] is the value in SI
a = 1.0/PSI, i.e., 0.00014503773773020924
and
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
Psi:Psi_1
Psi_1.ConversionFactorB = "0.00014503773773020924"
Psi_1.Symbol = "psi"
```
## PoundPer100SquareFoot <!-- NOUN -->
- Display name: pound per 100 square foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.0885434233150124
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per 100 square foot
[SI] is the value in SI
a = 100.0*Foot*Foot/(PoundForce), i.e., 2.0885434233150124
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPer100SquareFoot:PoundPer100SquareFoot_1
PoundPer100SquareFoot_1.ConversionFactorB = "2.0885434233150124"
PoundPer100SquareFoot_1.Symbol = "lbf/100ft²"
```
## MegapoundPerSquareInch <!-- NOUN -->
- Display name: megapound per square inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.4503773773020922E-10
- Description: 
[v] = a * [SI]
where
[v] is the value in megapound per square inch
[SI] is the value in SI
a = 1.0/(Mega*PSI), i.e., 1.4503773773020922E-10
and
Mega = 1e6
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
MegapoundPerSquareInch:MegapoundPerSquareInch_1
MegapoundPerSquareInch_1.ConversionFactorB = "1.4503773773020922E-10"
MegapoundPerSquareInch_1.Symbol = "Mpsi"
```
## Darcy <!-- NOUN -->
- Display name: darcy
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1013250000000
- Description: 
[v] = a * [SI]
where
[v] is the value in darcy
[SI] is the value in SI
a = 1.0/Darcy, i.e., 1013250000000
and
Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
Darcy:Darcy_1
Darcy_1.ConversionFactorB = "1013250000000"
Darcy_1.Symbol = "D"
```
## Millidarcy <!-- NOUN -->
- Display name: millidarcy
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1013250000000000.1
- Description: 
[v] = a * [SI]
where
[v] is the value in millidarcy
[SI] is the value in SI
a = 1.0/(Milli*Darcy), i.e., 1013250000000000.1
and
Milli = 0.001
Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
Millidarcy:Millidarcy_1
Millidarcy_1.ConversionFactorB = "1013250000000000.1"
Millidarcy_1.Symbol = "mD"
```
## Microdarcy <!-- NOUN -->
- Display name: microdarcy
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.01325E+18
- Description: 
[v] = a * [SI]
where
[v] is the value in microdarcy
[SI] is the value in SI
a = 1.0/(Micro*Darcy), i.e., 1.01325E+18
and
Micro = 1e-6
Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
Microdarcy:Microdarcy_1
Microdarcy_1.ConversionFactorB = "1.01325E+18"
Microdarcy_1.Symbol = "µD"
```
## Nanodarcy <!-- NOUN -->
- Display name: nanodarcy
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.01325E+21
- Description: 
[v] = a * [SI]
where
[v] is the value in nanodarcy
[SI] is the value in SI
a = 1.0/(Nano*Darcy), i.e., 1.01325E+21
and
Nano = 1e-9
Darcy = 0.0000001 / Atmosphere reference: https://en.wikipedia.org/wiki/Darcy_(unit)
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
Nanodarcy:Nanodarcy_1
Nanodarcy_1.ConversionFactorB = "1.01325E+21"
Nanodarcy_1.Symbol = "nD"
```
## Radian <!-- NOUN -->
- Display name: radian
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Radian:Radian_1
Radian_1.Symbol = "rad"
```
## Milliradian <!-- NOUN -->
- Display name: milliradian
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in milliradian
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Milliradian:Milliradian_1
Milliradian_1.ConversionFactorB = "1000"
Milliradian_1.Symbol = "mrad"
```
## Degree <!-- NOUN -->
- Display name: degree
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree
[SI] is the value in SI
a = Degree, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
Degree:Degree_1
Degree_1.ConversionFactorB = "57.29577951308232"
Degree_1.Symbol = "°"
```
## Grad <!-- NOUN -->
- Display name: grad
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 63.66197723675813
- Description: 
[v] = a * [SI]
where
[v] is the value in grad
[SI] is the value in SI
a = Grad, i.e., 63.66197723675813
and
Grad = 200.0 / System.Math.PI

- Examples: 
``` dwis
Grad:Grad_1
Grad_1.ConversionFactorB = "63.66197723675813"
Grad_1.Symbol = "grad"
```
## Gon <!-- NOUN -->
- Display name: gon
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 63.66197723675813
- Description: 
[v] = a * [SI]
where
[v] is the value in gon
[SI] is the value in SI
a = Grad, i.e., 63.66197723675813
and
Grad = 200.0 / System.Math.PI

- Examples: 
``` dwis
Gon:Gon_1
Gon_1.ConversionFactorB = "63.66197723675813"
Gon_1.Symbol = "gon"
```
## Circle <!-- NOUN -->
- Display name: circle
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.15915494309189535
- Description: 
[v] = a * [SI]
where
[v] is the value in circle
[SI] is the value in SI
a = 1.0/(2.0*PI), i.e., 0.15915494309189535

- Examples: 
``` dwis
Circle:Circle_1
Circle_1.ConversionFactorB = "0.15915494309189535"
Circle_1.Symbol = "circle"
```
## Revolution <!-- NOUN -->
- Display name: revolution
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.15915494309189535
- Description: 
[v] = a * [SI]
where
[v] is the value in revolution
[SI] is the value in SI
a = 1.0/(2.0*PI), i.e., 0.15915494309189535

- Examples: 
``` dwis
Revolution:Revolution_1
Revolution_1.ConversionFactorB = "0.15915494309189535"
Revolution_1.Symbol = "revolution"
```
## Quadrant <!-- NOUN -->
- Display name: quadrant
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.6366197723675814
- Description: 
[v] = a * [SI]
where
[v] is the value in quadrant
[SI] is the value in SI
a = 2.0/PI, i.e., 0.6366197723675814

- Examples: 
``` dwis
Quadrant:Quadrant_1
Quadrant_1.ConversionFactorB = "0.6366197723675814"
Quadrant_1.Symbol = "quadrant"
```
## Sextant <!-- NOUN -->
- Display name: sextant
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.954929658551372
- Description: 
[v] = a * [SI]
where
[v] is the value in sextant
[SI] is the value in SI
a = 3.0/PI, i.e., 0.954929658551372

- Examples: 
``` dwis
Sextant:Sextant_1
Sextant_1.ConversionFactorB = "0.954929658551372"
Sextant_1.Symbol = "sextant"
```
## Octant <!-- NOUN -->
- Display name: octant
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.2732395447351628
- Description: 
[v] = a * [SI]
where
[v] is the value in octant
[SI] is the value in SI
a = 4.0/PI, i.e., 1.2732395447351628

- Examples: 
``` dwis
Octant:Octant_1
Octant_1.ConversionFactorB = "1.2732395447351628"
Octant_1.Symbol = "octant"
```
## ArcMinute <!-- NOUN -->
- Display name: arc minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3437.746770784939
- Description: 
[v] = a * [SI]
where
[v] is the value in arc minute
[SI] is the value in SI
a = 60.0*Degree, i.e., 3437.746770784939
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
ArcMinute:ArcMinute_1
ArcMinute_1.ConversionFactorB = "3437.746770784939"
ArcMinute_1.Symbol = "'"
```
## ArcSecond <!-- NOUN -->
- Display name: arc second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 206264.80624709636
- Description: 
[v] = a * [SI]
where
[v] is the value in arc second
[SI] is the value in SI
a = 60.0*60.0*Degree, i.e., 206264.80624709636
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
ArcSecond:ArcSecond_1
ArcSecond_1.ConversionFactorB = "206264.80624709636"
ArcSecond_1.Symbol = """
```
## Watt <!-- NOUN -->
- Display name: watt
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Watt:Watt_1
Watt_1.Symbol = "W"
```
## Decawatt <!-- NOUN -->
- Display name: decawatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in decawatt
[SI] is the value in SI
a = 1.0/Deca, i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
Decawatt:Decawatt_1
Decawatt_1.ConversionFactorB = "0.1"
Decawatt_1.Symbol = "daW"
```
## Hectowatt <!-- NOUN -->
- Display name: hectowatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in hectowatt
[SI] is the value in SI
a = 1.0/Hecto, i.e., 0.01
and
Hecto = 100.0

- Examples: 
``` dwis
Hectowatt:Hectowatt_1
Hectowatt_1.ConversionFactorB = "0.01"
Hectowatt_1.Symbol = "hW"
```
## Kilowatt <!-- NOUN -->
- Display name: kilowatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilowatt
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilowatt:Kilowatt_1
Kilowatt_1.ConversionFactorB = "0.001"
Kilowatt_1.Symbol = "kW"
```
## Megawatt <!-- NOUN -->
- Display name: megawatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megawatt
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Megawatt:Megawatt_1
Megawatt_1.ConversionFactorB = "1E-06"
Megawatt_1.Symbol = "MW"
```
## Gigawatt <!-- NOUN -->
- Display name: gigawatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigawatt
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Gigawatt:Gigawatt_1
Gigawatt_1.ConversionFactorB = "1E-09"
Gigawatt_1.Symbol = "GW"
```
## Terawatt <!-- NOUN -->
- Display name: terawatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in terawatt
[SI] is the value in SI
a = 1.0/Tera, i.e., 1E-12
and
Tera = 1e12

- Examples: 
``` dwis
Terawatt:Terawatt_1
Terawatt_1.ConversionFactorB = "1E-12"
Terawatt_1.Symbol = "TW"
```
## Petawatt <!-- NOUN -->
- Display name: petawatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-15
- Description: 
[v] = a * [SI]
where
[v] is the value in petawatt
[SI] is the value in SI
a = 1.0/Peta, i.e., 1E-15
and
Peta = 1e15

- Examples: 
``` dwis
Petawatt:Petawatt_1
Petawatt_1.ConversionFactorB = "1E-15"
Petawatt_1.Symbol = "PW"
```
## Exawatt <!-- NOUN -->
- Display name: exawatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-18
- Description: 
[v] = a * [SI]
where
[v] is the value in exawatt
[SI] is the value in SI
a = 1.0/Exa, i.e., 1E-18
and
Exa = 1e18

- Examples: 
``` dwis
Exawatt:Exawatt_1
Exawatt_1.ConversionFactorB = "1E-18"
Exawatt_1.Symbol = "EW"
```
## Deciwatt <!-- NOUN -->
- Display name: deciwatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in deciwatt
[SI] is the value in SI
a = 1.0/Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
Deciwatt:Deciwatt_1
Deciwatt_1.ConversionFactorB = "10"
Deciwatt_1.Symbol = "dW"
```
## Centiwatt <!-- NOUN -->
- Display name: centiwatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centiwatt
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Centiwatt:Centiwatt_1
Centiwatt_1.ConversionFactorB = "100"
Centiwatt_1.Symbol = "cW"
```
## Milliwatt <!-- NOUN -->
- Display name: milliwatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in milliwatt
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Milliwatt:Milliwatt_1
Milliwatt_1.ConversionFactorB = "1000"
Milliwatt_1.Symbol = "mW"
```
## Microwatt <!-- NOUN -->
- Display name: microwatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microwatt
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microwatt:Microwatt_1
Microwatt_1.ConversionFactorB = "1000000"
Microwatt_1.Symbol = "µW"
```
## Nanowatt <!-- NOUN -->
- Display name: nanowatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanowatt
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanowatt:Nanowatt_1
Nanowatt_1.ConversionFactorB = "999999999.9999999"
Nanowatt_1.Symbol = "nW"
```
## Picowatt <!-- NOUN -->
- Display name: picowatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picowatt
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picowatt:Picowatt_1
Picowatt_1.ConversionFactorB = "1000000000000"
Picowatt_1.Symbol = "pW"
```
## Femtowatt <!-- NOUN -->
- Display name: femtowatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999999999.9
- Description: 
[v] = a * [SI]
where
[v] is the value in femtowatt
[SI] is the value in SI
a = 1.0/Femto, i.e., 999999999999999.9
and
Femto = 1e-15

- Examples: 
``` dwis
Femtowatt:Femtowatt_1
Femtowatt_1.ConversionFactorB = "999999999999999.9"
Femtowatt_1.Symbol = "fW"
```
## Attowatt <!-- NOUN -->
- Display name: attowatt
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.999999999999999E+17
- Description: 
[v] = a * [SI]
where
[v] is the value in attowatt
[SI] is the value in SI
a = 1.0/Atto, i.e., 9.999999999999999E+17
and
Atto = 1e-18

- Examples: 
``` dwis
Attowatt:Attowatt_1
Attowatt_1.ConversionFactorB = "9.999999999999999E+17"
Attowatt_1.Symbol = "aW"
```
## PascalPerMetre <!-- NOUN -->
- Display name: pascal per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
PascalPerMetre:PascalPerMetre_1
PascalPerMetre_1.Symbol = "Pa/m"
```
## BarPerMetre <!-- NOUN -->
- Display name: bar per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in bar per metre
[SI] is the value in SI
a = 1.0/Bar, i.e., 1E-05
and
Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)

- Examples: 
``` dwis
BarPerMetre:BarPerMetre_1
BarPerMetre_1.ConversionFactorB = "1E-05"
BarPerMetre_1.Symbol = "bar/m"
```
## PsiPerMetre <!-- NOUN -->
- Display name: psi per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00014503773773020924
- Description: 
[v] = a * [SI]
where
[v] is the value in psi per metre
[SI] is the value in SI
a = 1.0/PSI, i.e., 0.00014503773773020924
and
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PsiPerMetre:PsiPerMetre_1
PsiPerMetre_1.ConversionFactorB = "0.00014503773773020924"
PsiPerMetre_1.Symbol = "psi/m"
```
## PsiPerFoot <!-- NOUN -->
- Display name: psi per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.4207502460167764E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in psi per foot
[SI] is the value in SI
a = Foot/PSI, i.e., 4.4207502460167764E-05
and
Foot = 12.0 * Inch
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PsiPerFoot:PsiPerFoot_1
PsiPerFoot_1.ConversionFactorB = "4.4207502460167764E-05"
PsiPerFoot_1.Symbol = "psi/ft"
```
## PressureLossConstantSi <!-- NOUN -->
- Display name: pressure loss constant SI
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
PressureLossConstantSi:PressureLossConstantSi_1
PressureLossConstantSi_1.Symbol = "(m³/s)²•(kg/m³)/Pa"
```
## PressureLossConstantMetric <!-- NOUN -->
- Display name: pressure loss constant metric
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 360010080282.2479
- Description: 
[v] = a * [SI]
where
[v] is the value in pressure loss constant metric
[SI] is the value in SI
a = Minute*Minute*Bar*SpecificGavity4degC/(Milli*Milli), i.e., 360010080282.2479
and
Minute = 60.0
Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)
SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm
Milli = 0.001
WaterDensity4degC1Atm = 999.9720 reference: https://en.wikipedia.org/wiki/Relative_density

- Examples: 
``` dwis
PressureLossConstantMetric:PressureLossConstantMetric_1
PressureLossConstantMetric_1.ConversionFactorB = "360010080282.2479"
PressureLossConstantMetric_1.Symbol = "(l/min)²•sg/bar"
```
## PressureLossConstantUk <!-- NOUN -->
- Display name: pressure loss constant UK
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 12036984846.853645
- Description: 
[v] = a * [SI]
where
[v] is the value in pressure loss constant UK
[SI] is the value in SI
a = Minute*Minute*PSI/(PPGUK*GallonUK*GallonUK), i.e., 12036984846.853645
and
Minute = 60.0
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PPGUK = Pound / GallonUK
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PressureLossConstantUk:PressureLossConstantUk_1
PressureLossConstantUk_1.ConversionFactorB = "12036984846.853645"
PressureLossConstantUk_1.Symbol = "gpmuk²•ppguk/psi"
```
## PressureLossConstantUs <!-- NOUN -->
- Display name: pressure loss constant US
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 14455816055.131952
- Description: 
[v] = a * [SI]
where
[v] is the value in pressure loss constant US
[SI] is the value in SI
a = Minute*Minute*PSI/(PPGUS*GallonUS*GallonUS), i.e., 14455816055.131952
and
Minute = 60.0
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PPGUS = Pound / GallonUS
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PressureLossConstantUs:PressureLossConstantUs_1
PressureLossConstantUs_1.ConversionFactorB = "14455816055.131952"
PressureLossConstantUs_1.Symbol = "gpmus²•ppgus/psi"
```
## Kilopascal <!-- NOUN -->
- Display name: kilopascal
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopascal
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilopascal:Kilopascal_1
Kilopascal_1.ConversionFactorB = "0.001"
Kilopascal_1.Symbol = "KPa"
```
## Bar <!-- NOUN -->
- Display name: bar
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in bar
[SI] is the value in SI
a = 1.0/Bar, i.e., 1E-05
and
Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)

- Examples: 
``` dwis
Bar:Bar_1
Bar_1.ConversionFactorB = "1E-05"
Bar_1.Symbol = "bar"
```
## Millibar <!-- NOUN -->
- Display name: millibar
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in millibar
[SI] is the value in SI
a = 1.0/(Milli*Bar), i.e., 0.01
and
Milli = 0.001
Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)

- Examples: 
``` dwis
Millibar:Millibar_1
Millibar_1.ConversionFactorB = "0.01"
Millibar_1.Symbol = "mbar"
```
## Microbar <!-- NOUN -->
- Display name: microbar
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in microbar
[SI] is the value in SI
a = 1.0/(Micro*Bar), i.e., 10
and
Micro = 1e-6
Bar = 1e5 reference: https://en.wikipedia.org/wiki/Bar_(unit)

- Examples: 
``` dwis
Microbar:Microbar_1
Microbar_1.ConversionFactorB = "10"
Microbar_1.Symbol = "µbar"
```
## PoundPerSquareInch <!-- NOUN -->
- Display name: pound per square inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00014503773773020924
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per square inch
[SI] is the value in SI
a = 1.0/PSI, i.e., 0.00014503773773020924
and
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPerSquareInch:PoundPerSquareInch_1
PoundPerSquareInch_1.ConversionFactorB = "0.00014503773773020924"
PoundPerSquareInch_1.Symbol = "psi"
```
## KilopoundPerSquareInch <!-- NOUN -->
- Display name: kilopound per square inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.4503773773020924E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound per square inch
[SI] is the value in SI
a = 1.0/(Kilo*PSI), i.e., 1.4503773773020924E-07
and
Kilo = 1000.0
PSI = PoundForce / (Inch * Inch) reference: https://en.wikipedia.org/wiki/Pound_per_square_inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilopoundPerSquareInch:KilopoundPerSquareInch_1
KilopoundPerSquareInch_1.ConversionFactorB = "1.4503773773020924E-07"
KilopoundPerSquareInch_1.Symbol = "ksi"
```
## StandardAtmosphere <!-- NOUN -->
- Display name: standard atmosphere
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.869232667160129E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in standard atmosphere
[SI] is the value in SI
a = 1.0/Atmosphere, i.e., 9.869232667160129E-06
and
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
StandardAtmosphere:StandardAtmosphere_1
StandardAtmosphere_1.ConversionFactorB = "9.869232667160129E-06"
StandardAtmosphere_1.Symbol = "atm"
```
## PoundPerSquareFoot <!-- NOUN -->
- Display name: pound per square foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.020885434233150126
- Description: 
[v] = a * [SI]
where
[v] is the value in pound per square foot
[SI] is the value in SI
a = Foot*Foot/PoundForce, i.e., 0.020885434233150126
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
PoundPerSquareFoot:PoundPerSquareFoot_1
PoundPerSquareFoot_1.ConversionFactorB = "0.020885434233150126"
PoundPerSquareFoot_1.Symbol = "lb/ft²"
```
## NewtonPerSquareMetre <!-- NOUN -->
- Display name: newton per square metre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per square metre
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
NewtonPerSquareMetre:NewtonPerSquareMetre_1
NewtonPerSquareMetre_1.Symbol = "N/m²"
```
## NewtonPerSquareCentimetre <!-- NOUN -->
- Display name: newton per square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per square centimetre
[SI] is the value in SI
a = Centi*Centi, i.e., 0.0001
and
Centi = 0.01

- Examples: 
``` dwis
NewtonPerSquareCentimetre:NewtonPerSquareCentimetre_1
NewtonPerSquareCentimetre_1.ConversionFactorB = "0.0001"
NewtonPerSquareCentimetre_1.Symbol = "N/cm²"
```
## NewtonPerSquareMillimetre <!-- NOUN -->
- Display name: newton per square millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in newton per square millimetre
[SI] is the value in SI
a = Milli*Milli, i.e., 1E-06
and
Milli = 0.001

- Examples: 
``` dwis
NewtonPerSquareMillimetre:NewtonPerSquareMillimetre_1
NewtonPerSquareMillimetre_1.ConversionFactorB = "1E-06"
NewtonPerSquareMillimetre_1.Symbol = "N/mm²"
```
## KilonewtonPerSquareMetre <!-- NOUN -->
- Display name: kilonewton per square metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton per square metre
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonPerSquareMetre:KilonewtonPerSquareMetre_1
KilonewtonPerSquareMetre_1.ConversionFactorB = "0.001"
KilonewtonPerSquareMetre_1.Symbol = "kN/m²"
```
## Torr <!-- NOUN -->
- Display name: torr
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.007500616827041697
- Description: 
[v] = a * [SI]
where
[v] is the value in torr
[SI] is the value in SI
a = 1.0/Torr, i.e., 0.007500616827041697
and
Torr = (1.0 / 760.0) * Atmosphere reference: https://en.wikipedia.org/wiki/Torr
Atmosphere = 101325.0 reference: https://en.wikipedia.org/wiki/Atmospheric_pressure

- Examples: 
``` dwis
Torr:Torr_1
Torr_1.ConversionFactorB = "0.007500616827041697"
Torr_1.Symbol = "Torr"
```
## CentimetreMercuryAtZeroDegreeCelsius <!-- NOUN -->
- Display name: centimetre mercury at zero degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0007500615758456563
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre mercury at zero degree celsius
[SI] is the value in SI
a = 1.0/(Deca*MillimetreMercury), i.e., 0.0007500615758456563
and
Deca = 10.0
MillimetreMercury = 133.322387415 reference: https://en.wikipedia.org/wiki/Millimetre_of_mercury

- Examples: 
``` dwis
CentimetreMercuryAtZeroDegreeCelsius:CentimetreMercuryAtZeroDegreeCelsius_1
CentimetreMercuryAtZeroDegreeCelsius_1.ConversionFactorB = "0.0007500615758456563"
CentimetreMercuryAtZeroDegreeCelsius_1.Symbol = "cm Hg 0°C"
```
## MillimetreMercuryAtZeroDegreeCelsius <!-- NOUN -->
- Display name: millimetre mercury at zero degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.007500615758456563
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre mercury at zero degree celsius
[SI] is the value in SI
a = 1.0/MillimetreMercury, i.e., 0.007500615758456563
and
MillimetreMercury = 133.322387415 reference: https://en.wikipedia.org/wiki/Millimetre_of_mercury

- Examples: 
``` dwis
MillimetreMercuryAtZeroDegreeCelsius:MillimetreMercuryAtZeroDegreeCelsius_1
MillimetreMercuryAtZeroDegreeCelsius_1.ConversionFactorB = "0.007500615758456563"
MillimetreMercuryAtZeroDegreeCelsius_1.Symbol = "mm Hg 0°C"
```
## InchMercuryAt32DegreeFahrenheit <!-- NOUN -->
- Display name: inch mercury at 32 degree fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3386.3890000000006
- Description: 
[v] = a * [SI]
where
[v] is the value in inch mercury at 32 degree fahrenheit
[SI] is the value in SI
a = 1.0/InchMercury32degF, i.e., 3386.3890000000006
and
InchMercury32degF = 1.0/3386.389 reference: https://en.wikipedia.org/wiki/Inch_of_mercury

- Examples: 
``` dwis
InchMercuryAt32DegreeFahrenheit:InchMercuryAt32DegreeFahrenheit_1
InchMercuryAt32DegreeFahrenheit_1.ConversionFactorB = "3386.3890000000006"
InchMercuryAt32DegreeFahrenheit_1.Symbol = "in Hg 32°F"
```
## InchMercuryAt60DegreeFahrenheit <!-- NOUN -->
- Display name: inch mercury at 60 degree fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3376.85
- Description: 
[v] = a * [SI]
where
[v] is the value in inch mercury at 60 degree fahrenheit
[SI] is the value in SI
a = 1.0/InchMercury60degF, i.e., 3376.85
and
InchMercury60degF = 1.0 / 3376.85 reference: https://en.wikipedia.org/wiki/Inch_of_mercury

- Examples: 
``` dwis
InchMercuryAt60DegreeFahrenheit:InchMercuryAt60DegreeFahrenheit_1
InchMercuryAt60DegreeFahrenheit_1.ConversionFactorB = "3376.85"
InchMercuryAt60DegreeFahrenheit_1.Symbol = "in Hg 60°F"
```
## CentimetreWaterAt4DegreeCelsius <!-- NOUN -->
- Display name: centimetre water at 4 degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.010104429276573386
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre water at 4 degree celsius
[SI] is the value in SI
a = 1.0/(Deca*MillimetreWater4degC), i.e., 0.010104429276573386
and
Deca = 10.0
MillimetreWater4degC = 9.89665 reference: https://en.wikipedia.org/wiki/Centimetre_or_millimetre_of_water

- Examples: 
``` dwis
CentimetreWaterAt4DegreeCelsius:CentimetreWaterAt4DegreeCelsius_1
CentimetreWaterAt4DegreeCelsius_1.ConversionFactorB = "0.010104429276573386"
CentimetreWaterAt4DegreeCelsius_1.Symbol = "cm Aq 4°C"
```
## MillimetreWaterAt4DegreeCelsius <!-- NOUN -->
- Display name: millimetre water at 4 degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10104429276573387
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre water at 4 degree celsius
[SI] is the value in SI
a = 1.0/MillimetreWater4degC, i.e., 0.10104429276573387
and
MillimetreWater4degC = 9.89665 reference: https://en.wikipedia.org/wiki/Centimetre_or_millimetre_of_water

- Examples: 
``` dwis
MillimetreWaterAt4DegreeCelsius:MillimetreWaterAt4DegreeCelsius_1
MillimetreWaterAt4DegreeCelsius_1.ConversionFactorB = "0.10104429276573387"
MillimetreWaterAt4DegreeCelsius_1.Symbol = "mm Aq 4°C"
```
## InchWaterAt4DegreeCelsius <!-- NOUN -->
- Display name: inch water at 4 degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00401474213311279
- Description: 
[v] = a * [SI]
where
[v] is the value in inch water at 4 degree celsius
[SI] is the value in SI
a = 1.0/InchWater4degC, i.e., 0.00401474213311279
and
InchWater4degC = 249.082 reference: https://en.wikipedia.org/wiki/Inch_of_water

- Examples: 
``` dwis
InchWaterAt4DegreeCelsius:InchWaterAt4DegreeCelsius_1
InchWaterAt4DegreeCelsius_1.ConversionFactorB = "0.00401474213311279"
InchWaterAt4DegreeCelsius_1.Symbol = "in Aq 4°C"
```
## FootWaterAt4DegreeCelsius <!-- NOUN -->
- Display name: foot water at 4 degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0003345525543589354
- Description: 
[v] = a * [SI]
where
[v] is the value in foot water at 4 degree celsius
[SI] is the value in SI
a = 1.0/FootWater4degC, i.e., 0.0003345525543589354
and
FootWater4degC = 2989.067 reference: https://en.wikipedia.org/wiki/Inch_of_water

- Examples: 
``` dwis
FootWaterAt4DegreeCelsius:FootWaterAt4DegreeCelsius_1
FootWaterAt4DegreeCelsius_1.ConversionFactorB = "0.0003345525543589354"
FootWaterAt4DegreeCelsius_1.Symbol = "ft Aq 4°C"
```
## DynePerSquareCentimetre <!-- NOUN -->
- Display name: dyne per square centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in dyne per square centimetre
[SI] is the value in SI
a = Centi*Centi/Dyne, i.e., 10
and
Centi = 0.01
Dyne = 1e-5 reference: https://en.wikipedia.org/wiki/Dyne

- Examples: 
``` dwis
DynePerSquareCentimetre:DynePerSquareCentimetre_1
DynePerSquareCentimetre_1.ConversionFactorB = "10"
DynePerSquareCentimetre_1.Symbol = "dyne/cm²"
```
## Proportion <!-- NOUN -->
- Display name: proportion
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Proportion:Proportion_1
```
## Percent <!-- NOUN -->
- Display name: percent
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in percent
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Percent:Percent_1
Percent_1.ConversionFactorB = "100"
Percent_1.Symbol = "%"
```
## PerThousand <!-- NOUN -->
- Display name: per thousand
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in per thousand
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
PerThousand:PerThousand_1
PerThousand_1.ConversionFactorB = "1000"
PerThousand_1.Symbol = "‰"
```
## PartPerMillion <!-- NOUN -->
- Display name: part per million
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in part per million
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
PartPerMillion:PartPerMillion_1
PartPerMillion_1.ConversionFactorB = "1000000"
PartPerMillion_1.Symbol = "ppm"
```
## RadianPerSquareRootSecond <!-- NOUN -->
- Display name: radian per square root second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
RadianPerSquareRootSecond:RadianPerSquareRootSecond_1
RadianPerSquareRootSecond_1.Symbol = "rad/√s"
```
## RadianPerSquareRootMinute <!-- NOUN -->
- Display name: radian per square root minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 7.745966692414834
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per square root minute
[SI] is the value in SI
a = Sqrt(Minute), i.e., 7.745966692414834
and
Minute = 60.0

- Examples: 
``` dwis
RadianPerSquareRootMinute:RadianPerSquareRootMinute_1
RadianPerSquareRootMinute_1.ConversionFactorB = "7.745966692414834"
RadianPerSquareRootMinute_1.Symbol = "rad/√min"
```
## RadianPerSquareRootHour <!-- NOUN -->
- Display name: radian per square root hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per square root hour
[SI] is the value in SI
a = Sqrt(Hour), i.e., 60
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerSquareRootHour:RadianPerSquareRootHour_1
RadianPerSquareRootHour_1.ConversionFactorB = "60"
RadianPerSquareRootHour_1.Symbol = "rad/√h"
```
## RadianPerSquareRootDay <!-- NOUN -->
- Display name: radian per square root day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 293.9387691339814
- Description: 
[v] = a * [SI]
where
[v] is the value in radian per square root day
[SI] is the value in SI
a = Sqrt(Day), i.e., 293.9387691339814
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
RadianPerSquareRootDay:RadianPerSquareRootDay_1
RadianPerSquareRootDay_1.ConversionFactorB = "293.9387691339814"
RadianPerSquareRootDay_1.Symbol = "rad/√d"
```
## DegreePerSquareRootSecond <!-- NOUN -->
- Display name: degree per square root second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 57.29577951308232
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per square root second
[SI] is the value in SI
a = Degree, i.e., 57.29577951308232
and
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerSquareRootSecond:DegreePerSquareRootSecond_1
DegreePerSquareRootSecond_1.ConversionFactorB = "57.29577951308232"
DegreePerSquareRootSecond_1.Symbol = "°/√s"
```
## DegreePerSquareRootMinute <!-- NOUN -->
- Display name: degree per square root minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 443.8111997242799
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per square root minute
[SI] is the value in SI
a = Sqrt(Minute)*Degree, i.e., 443.8111997242799
and
Minute = 60.0
Degree = 180.0 / System.Math.PI

- Examples: 
``` dwis
DegreePerSquareRootMinute:DegreePerSquareRootMinute_1
DegreePerSquareRootMinute_1.ConversionFactorB = "443.8111997242799"
DegreePerSquareRootMinute_1.Symbol = "°/√min"
```
## DegreePerSquareRootHour <!-- NOUN -->
- Display name: degree per square root hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3437.746770784939
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per square root hour
[SI] is the value in SI
a = Sqrt(Hour)*Degree, i.e., 3437.746770784939
and
Hour = 60.0 * Minute
Degree = 180.0 / System.Math.PI
Minute = 60.0

- Examples: 
``` dwis
DegreePerSquareRootHour:DegreePerSquareRootHour_1
DegreePerSquareRootHour_1.ConversionFactorB = "3437.746770784939"
DegreePerSquareRootHour_1.Symbol = "°/√h"
```
## DegreePerSquareRootDay <!-- NOUN -->
- Display name: degree per square root day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 16841.450906647406
- Description: 
[v] = a * [SI]
where
[v] is the value in degree per square root day
[SI] is the value in SI
a = Sqrt(Day)*Degree, i.e., 16841.450906647406
and
Day = 24.0 * Hour
Degree = 180.0 / System.Math.PI
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DegreePerSquareRootDay:DegreePerSquareRootDay_1
DegreePerSquareRootDay_1.ConversionFactorB = "16841.450906647406"
DegreePerSquareRootDay_1.Symbol = "°/√d"
```
## Kelvin <!-- NOUN -->
- Display name: kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Kelvin:Kelvin_1
Kelvin_1.Symbol = "K"
```
## RelativeCelsius <!-- NOUN -->
- Display name: relative celsius
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in relative celsius
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
RelativeCelsius:RelativeCelsius_1
RelativeCelsius_1.Symbol = "°C"
```
## Rankine <!-- NOUN -->
- Display name: rankine
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.7999999999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in rankine
[SI] is the value in SI
a = 1.0/FahrenheitSlope, i.e., 1.7999999999999998
and
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit

- Examples: 
``` dwis
Rankine:Rankine_1
Rankine_1.ConversionFactorB = "1.7999999999999998"
Rankine_1.Symbol = "°R"
```
## OhmMetre <!-- NOUN -->
- Display name: ohm metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
OhmMetre:OhmMetre_1
OhmMetre_1.Symbol = "Ω•m"
```
## KiloOhmMetre <!-- NOUN -->
- Display name: kilo ohm metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo ohm metre
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KiloOhmMetre:KiloOhmMetre_1
KiloOhmMetre_1.ConversionFactorB = "0.001"
KiloOhmMetre_1.Symbol = "kΩ•m"
```
## MegaOhmMetre <!-- NOUN -->
- Display name: mega ohm metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in mega ohm metre
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
MegaOhmMetre:MegaOhmMetre_1
MegaOhmMetre_1.ConversionFactorB = "1E-06"
MegaOhmMetre_1.Symbol = "MΩ•m"
```
## GigaOhmMetre <!-- NOUN -->
- Display name: giga ohm metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in giga ohm metre
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
GigaOhmMetre:GigaOhmMetre_1
GigaOhmMetre_1.ConversionFactorB = "1E-09"
GigaOhmMetre_1.Symbol = "GΩ•m"
```
## Steradian <!-- NOUN -->
- Display name: steradian
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Steradian:Steradian_1
Steradian_1.Symbol = "sr"
```
## Spat <!-- NOUN -->
- Display name: spat
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.07957747154594767
- Description: 
[v] = a * [SI]
where
[v] is the value in spat
[SI] is the value in SI
a = 1/(4.0*PI), i.e., 0.07957747154594767

- Examples: 
``` dwis
Spat:Spat_1
Spat_1.ConversionFactorB = "0.07957747154594767"
Spat_1.Symbol = "spat"
```
## DegreeSquared <!-- NOUN -->
- Display name: degree squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3282.806350011744
- Description: 
[v] = a * [SI]
where
[v] is the value in degree squared
[SI] is the value in SI
a = (180.0*180.0)/(PI*PI), i.e., 3282.806350011744

- Examples: 
``` dwis
DegreeSquared:DegreeSquared_1
DegreeSquared_1.ConversionFactorB = "3282.806350011744"
DegreeSquared_1.Symbol = "(°)²"
```
## JoulePerKilogramKelvin <!-- NOUN -->
- Display name: joule per kilogram kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
JoulePerKilogramKelvin:JoulePerKilogramKelvin_1
JoulePerKilogramKelvin_1.Symbol = "J/kg•K"
```
## JoulePerGramKelvin <!-- NOUN -->
- Display name: joule per gram kelvin
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per gram kelvin
[SI] is the value in SI
a = Milli/Unit, i.e., 0.001
and
Milli = 0.001
Unit = 1.0

- Examples: 
``` dwis
JoulePerGramKelvin:JoulePerGramKelvin_1
JoulePerGramKelvin_1.ConversionFactorB = "0.001"
JoulePerGramKelvin_1.Symbol = "J/g•K"
```
## JoulePerGramDegreeCelsius <!-- NOUN -->
- Display name: joule per gram degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per gram degree celsius
[SI] is the value in SI
a = Milli/Unit, i.e., 0.001
and
Milli = 0.001
Unit = 1.0

- Examples: 
``` dwis
JoulePerGramDegreeCelsius:JoulePerGramDegreeCelsius_1
JoulePerGramDegreeCelsius_1.ConversionFactorB = "0.001"
JoulePerGramDegreeCelsius_1.Symbol = "J/g•°C"
```
## CaloriePerGramDegreeCelsius <!-- NOUN -->
- Display name: calorie per gram degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per gram degree celsius
[SI] is the value in SI
a = Milli/Calorie, i.e., 0.0002390057361376673
and
Milli = 0.001
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerGramDegreeCelsius:CaloriePerGramDegreeCelsius_1
CaloriePerGramDegreeCelsius_1.ConversionFactorB = "0.0002390057361376673"
CaloriePerGramDegreeCelsius_1.Symbol = "cal/g•°C"
```
## BritishThermalUnitPerPoundDegreeFahrenheit <!-- NOUN -->
- Display name: british thermal unit per pound degree fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002390057960934331
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per pound degree fahrenheit
[SI] is the value in SI
a = Pound*FahrenheitSlope/BTU, i.e., 0.0002390057960934331
and
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnitPerPoundDegreeFahrenheit:BritishThermalUnitPerPoundDegreeFahrenheit_1
BritishThermalUnitPerPoundDegreeFahrenheit_1.ConversionFactorB = "0.0002390057960934331"
BritishThermalUnitPerPoundDegreeFahrenheit_1.Symbol = "BTU/lb•°F"
```
## KilocaloriePerGramDegreeCelsius <!-- NOUN -->
- Display name: kilocalorie per gram degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.390057361376673E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie per gram degree celsius
[SI] is the value in SI
a = Milli/(Kilo*Calorie), i.e., 2.390057361376673E-07
and
Milli = 0.001
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
KilocaloriePerGramDegreeCelsius:KilocaloriePerGramDegreeCelsius_1
KilocaloriePerGramDegreeCelsius_1.ConversionFactorB = "2.390057361376673E-07"
KilocaloriePerGramDegreeCelsius_1.Symbol = "Cal/g•°C"
```
## JoulePerKilogramSquaredKelvin <!-- NOUN -->
- Display name: joule per kilogram squared kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
JoulePerKilogramSquaredKelvin:JoulePerKilogramSquaredKelvin_1
JoulePerKilogramSquaredKelvin_1.Symbol = "J/kg•K²"
```
## JoulePerGramSquaredKelvin <!-- NOUN -->
- Display name: joule per gram squared kelvin
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per gram squared kelvin
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
JoulePerGramSquaredKelvin:JoulePerGramSquaredKelvin_1
JoulePerGramSquaredKelvin_1.ConversionFactorB = "0.001"
JoulePerGramSquaredKelvin_1.Symbol = "J/g•K²"
```
## JoulePerGramDegreeSquaredCelsius <!-- NOUN -->
- Display name: joule per gram degree squared celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in joule per gram degree squared celsius
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
JoulePerGramDegreeSquaredCelsius:JoulePerGramDegreeSquaredCelsius_1
JoulePerGramDegreeSquaredCelsius_1.ConversionFactorB = "0.001"
JoulePerGramDegreeSquaredCelsius_1.Symbol = "J/g•°C²"
```
## CaloriePerGramDegreeSquaredCelsius <!-- NOUN -->
- Display name: calorie per gram degree squared celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per gram degree squared celsius
[SI] is the value in SI
a = Milli/Calorie, i.e., 0.0002390057361376673
and
Milli = 0.001
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerGramDegreeSquaredCelsius:CaloriePerGramDegreeSquaredCelsius_1
CaloriePerGramDegreeSquaredCelsius_1.ConversionFactorB = "0.0002390057361376673"
CaloriePerGramDegreeSquaredCelsius_1.Symbol = "cal/g•°C²"
```
## BritishThermalUnitPerPoundSquaredDegreeFahrenheit <!-- NOUN -->
- Display name: british thermal unit per pound squared degree fahrenheit 
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00013278099782968505
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per pound squared degree fahrenheit 
[SI] is the value in SI
a = Pound*FahrenheitSlope*FahrenheitSlope/BTU, i.e., 0.00013278099782968505
and
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnitPerPoundSquaredDegreeFahrenheit:BritishThermalUnitPerPoundSquaredDegreeFahrenheit_1
BritishThermalUnitPerPoundSquaredDegreeFahrenheit_1.ConversionFactorB = "0.00013278099782968505"
BritishThermalUnitPerPoundSquaredDegreeFahrenheit_1.Symbol = "BTU/lb•°F²"
```
## KelvinPerMetre <!-- NOUN -->
- Display name: kelvin per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
KelvinPerMetre:KelvinPerMetre_1
KelvinPerMetre_1.Symbol = "K/m"
```
## CelsiusPerMetre <!-- NOUN -->
- Display name: celsius per metre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per metre
[SI] is the value in SI
a = 1.0/Unit, i.e., 1
and
Unit = 1.0

- Examples: 
``` dwis
CelsiusPerMetre:CelsiusPerMetre_1
CelsiusPerMetre_1.Symbol = "°C/m"
```
## CelsiusPer10Metre <!-- NOUN -->
- Display name: celsius per 10 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per 10 metre
[SI] is the value in SI
a = Deca/Unit, i.e., 10
and
Deca = 10.0
Unit = 1.0

- Examples: 
``` dwis
CelsiusPer10Metre:CelsiusPer10Metre_1
CelsiusPer10Metre_1.ConversionFactorB = "10"
CelsiusPer10Metre_1.Symbol = "°C/10m"
```
## CelsiusPer30Metre <!-- NOUN -->
- Display name: celsius per 30 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per 30 metre
[SI] is the value in SI
a = 3.0*Deca/Unit, i.e., 30
and
Deca = 10.0
Unit = 1.0

- Examples: 
``` dwis
CelsiusPer30Metre:CelsiusPer30Metre_1
CelsiusPer30Metre_1.ConversionFactorB = "30"
CelsiusPer30Metre_1.Symbol = "°C/30m"
```
## CelsiusPer100Metre <!-- NOUN -->
- Display name: celsius per 100 metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per 100 metre
[SI] is the value in SI
a = Hecto/Unit, i.e., 100
and
Hecto = 100.0
Unit = 1.0

- Examples: 
``` dwis
CelsiusPer100Metre:CelsiusPer100Metre_1
CelsiusPer100Metre_1.ConversionFactorB = "100"
CelsiusPer100Metre_1.Symbol = "°C/100m"
```
## CelsiusPerFoot <!-- NOUN -->
- Display name: celsius per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.30479999999999996
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per foot
[SI] is the value in SI
a = Foot/Unit, i.e., 0.30479999999999996
and
Foot = 12.0 * Inch
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CelsiusPerFoot:CelsiusPerFoot_1
CelsiusPerFoot_1.ConversionFactorB = "0.30479999999999996"
CelsiusPerFoot_1.Symbol = "°C/ft"
```
## CelsiusPer30Foot <!-- NOUN -->
- Display name: celsius per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.143999999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per 30 foot
[SI] is the value in SI
a = 30.0*Foot/Unit, i.e., 9.143999999999998
and
Foot = 12.0 * Inch
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CelsiusPer30Foot:CelsiusPer30Foot_1
CelsiusPer30Foot_1.ConversionFactorB = "9.143999999999998"
CelsiusPer30Foot_1.Symbol = "°C/30ft"
```
## CelsiusPer100Foot <!-- NOUN -->
- Display name: celsius per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30.479999999999997
- Description: 
[v] = a * [SI]
where
[v] is the value in celsius per 100 foot
[SI] is the value in SI
a = 100.0*Foot/Unit, i.e., 30.479999999999997
and
Foot = 12.0 * Inch
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CelsiusPer100Foot:CelsiusPer100Foot_1
CelsiusPer100Foot_1.ConversionFactorB = "30.479999999999997"
CelsiusPer100Foot_1.Symbol = "°C/100ft"
```
## FahrenheitPerFoot <!-- NOUN -->
- Display name: fahrenheit per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.5486399999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in fahrenheit per foot
[SI] is the value in SI
a = Foot/FahrenheitSlope, i.e., 0.5486399999999999
and
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FahrenheitPerFoot:FahrenheitPerFoot_1
FahrenheitPerFoot_1.ConversionFactorB = "0.5486399999999999"
FahrenheitPerFoot_1.Symbol = "°F/ft"
```
## FahrenheitPer30Foot <!-- NOUN -->
- Display name: fahrenheit per 30 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 16.459199999999996
- Description: 
[v] = a * [SI]
where
[v] is the value in fahrenheit per 30 foot
[SI] is the value in SI
a = 30.0*Foot/FahrenheitSlope, i.e., 16.459199999999996
and
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FahrenheitPer30Foot:FahrenheitPer30Foot_1
FahrenheitPer30Foot_1.ConversionFactorB = "16.459199999999996"
FahrenheitPer30Foot_1.Symbol = "°F/30ft"
```
## FahrenheitPer100Foot <!-- NOUN -->
- Display name: fahrenheit per 100 foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 54.86399999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in fahrenheit per 100 foot
[SI] is the value in SI
a = 100.0*Foot/FahrenheitSlope, i.e., 54.86399999999999
and
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FahrenheitPer100Foot:FahrenheitPer100Foot_1
FahrenheitPer100Foot_1.ConversionFactorB = "54.86399999999999"
FahrenheitPer100Foot_1.Symbol = "°F/100ft"
```
## Celsius <!-- NOUN -->
- Display name: celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorA = -273.15
- Description: 
[v] = a * [SI] + b
where
[v] is the value in celsius
[SI] is the value in SI
a = Unit, i.e., 1
b = -ZeroCelsius, i.e., -273.15
and
Unit = 1.0
ZeroCelsius = 273.15 reference: https://www.nist.gov/pml/owm/si-units-temperature

- Examples: 
``` dwis
Celsius:Celsius_1
Celsius_1.ConversionFactorA = "-273.15"
Celsius_1.Symbol = "°C"
```
## Fahrenheit <!-- NOUN -->
- Display name: fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorA = -459.67
  - ConversionFactorB = 1.7999999999999998
- Description: 
[v] = a * [SI] + b
where
[v] is the value in fahrenheit
[SI] is the value in SI
a = 1.0/FahrenheitSlope, i.e., 1.7999999999999998
b = -FahrenheitBias, i.e., -459.67
and
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
FahrenheitBias = 459.67 reference: https://nn.wikipedia.org/wiki/Fahrenheit

- Examples: 
``` dwis
Fahrenheit:Fahrenheit_1
Fahrenheit_1.ConversionFactorA = "-459.67"
Fahrenheit_1.ConversionFactorB = "1.7999999999999998"
Fahrenheit_1.Symbol = "°F"
```
## Réaumur <!-- NOUN -->
- Display name: réaumur
- Parent class: Unit
- Specialization: 
  - ConversionFactorA = -218.51999999999998
  - ConversionFactorB = 0.8
- Description: 
[v] = a * [SI] + b
where
[v] is the value in réaumur
[SI] is the value in SI
a = 1.0/ReaumurSlope, i.e., 0.8
b = -ReaumurBias, i.e., -218.51999999999998
and
ReaumurSlope = 5.0 / 4.0 reference: https://en.wikipedia.org/wiki/R%C3%A9aumur_scale
ReaumurBias = ZeroCelsius / ReaumurSlope
ZeroCelsius = 273.15 reference: https://www.nist.gov/pml/owm/si-units-temperature

- Examples: 
``` dwis
Réaumur:Réaumur_1
Réaumur_1.ConversionFactorA = "-218.51999999999998"
Réaumur_1.ConversionFactorB = "0.8"
Réaumur_1.Symbol = "°Ré"
```
## WattPerMetreKelvin <!-- NOUN -->
- Display name: watt per metre kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
WattPerMetreKelvin:WattPerMetreKelvin_1
WattPerMetreKelvin_1.Symbol = "W/m•K"
```
## CaloriePerMetreSecondDegreeCelsius <!-- NOUN -->
- Display name: calorie per metre second degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per metre second degree celsius
[SI] is the value in SI
a = 1.0/Calorie, i.e., 0.2390057361376673
and
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerMetreSecondDegreeCelsius:CaloriePerMetreSecondDegreeCelsius_1
CaloriePerMetreSecondDegreeCelsius_1.ConversionFactorB = "0.2390057361376673"
CaloriePerMetreSecondDegreeCelsius_1.Symbol = "cal/m•s•°C"
```
## CaloriePerCentimetreSecondDegreeCelsius <!-- NOUN -->
- Display name: calorie per centimetre second degree celsius
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per centimetre second degree celsius
[SI] is the value in SI
a = Centi/Calorie, i.e., 0.002390057361376673
and
Centi = 0.01
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerCentimetreSecondDegreeCelsius:CaloriePerCentimetreSecondDegreeCelsius_1
CaloriePerCentimetreSecondDegreeCelsius_1.ConversionFactorB = "0.002390057361376673"
CaloriePerCentimetreSecondDegreeCelsius_1.Symbol = "cal/cm•s•°C"
```
## BritishThermalUnitPerHourFootDegreeFahrenheit <!-- NOUN -->
- Display name: british thermal unit per hour foot degree fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.5781761274719021
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per hour foot degree fahrenheit
[SI] is the value in SI
a = Hour*Foot*FahrenheitSlope/BTU, i.e., 0.5781761274719021
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BritishThermalUnitPerHourFootDegreeFahrenheit:BritishThermalUnitPerHourFootDegreeFahrenheit_1
BritishThermalUnitPerHourFootDegreeFahrenheit_1.ConversionFactorB = "0.5781761274719021"
BritishThermalUnitPerHourFootDegreeFahrenheit_1.Symbol = "BTU/h•ft•°F"
```
## BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit <!-- NOUN -->
- Display name: british thermal unit inch per hour square foot degree fahrenheit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.938113529662824
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit inch per hour square foot degree fahrenheit
[SI] is the value in SI
a = Hour*Foot*Foot*FahrenheitSlope/(BTU*Inch), i.e., 6.938113529662824
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit:BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit_1
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit_1.ConversionFactorB = "6.938113529662824"
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit_1.Symbol = "BTU•in/h•ft²•°F"
```
## WattPerMetreKelvinPerKelvin <!-- NOUN -->
- Display name: watt per metre kelvin per kelvin
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
WattPerMetreKelvinPerKelvin:WattPerMetreKelvinPerKelvin_1
WattPerMetreKelvinPerKelvin_1.Symbol = "(W/(m•K))/K"
```
## CaloriePerMetreSecondDegreeCelsiusSquared <!-- NOUN -->
- Display name: calorie per metre second degree celsius squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per metre second degree celsius squared
[SI] is the value in SI
a = 1.0/Calorie, i.e., 0.2390057361376673
and
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerMetreSecondDegreeCelsiusSquared:CaloriePerMetreSecondDegreeCelsiusSquared_1
CaloriePerMetreSecondDegreeCelsiusSquared_1.ConversionFactorB = "0.2390057361376673"
CaloriePerMetreSecondDegreeCelsiusSquared_1.Symbol = "Cal/m•s•°C²"
```
## CaloriePerCentimetreSecondDegreeCelsiusSquared <!-- NOUN -->
- Display name: calorie per centimetre second degree celsius squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie per centimetre second degree celsius squared
[SI] is the value in SI
a = Centi/Calorie, i.e., 0.002390057361376673
and
Centi = 0.01
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
CaloriePerCentimetreSecondDegreeCelsiusSquared:CaloriePerCentimetreSecondDegreeCelsiusSquared_1
CaloriePerCentimetreSecondDegreeCelsiusSquared_1.ConversionFactorB = "0.002390057361376673"
CaloriePerCentimetreSecondDegreeCelsiusSquared_1.Symbol = "Cal/cm•s•°C²"
```
## BritishThermalUnitPerHourFootDegreeFahrenheitSquared <!-- NOUN -->
- Display name: british thermal unit per hour foot degree fahrenheit squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.3212089597066123
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit per hour foot degree fahrenheit squared
[SI] is the value in SI
a = Hour*Foot*FahrenheitSlope*FahrenheitSlope/BTU, i.e., 0.3212089597066123
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BritishThermalUnitPerHourFootDegreeFahrenheitSquared:BritishThermalUnitPerHourFootDegreeFahrenheitSquared_1
BritishThermalUnitPerHourFootDegreeFahrenheitSquared_1.ConversionFactorB = "0.3212089597066123"
BritishThermalUnitPerHourFootDegreeFahrenheitSquared_1.Symbol = "BTU/h•ft•°F²"
```
## BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared <!-- NOUN -->
- Display name: british thermal unit inch per hour square foot degree fahrenheit squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.8545075164793468
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit inch per hour square foot degree fahrenheit squared
[SI] is the value in SI
a = Hour*Foot*Foot*FahrenheitSlope*FahrenheitSlope/(BTU*Inch), i.e., 3.8545075164793468
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared:BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared_1
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared_1.ConversionFactorB = "3.8545075164793468"
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared_1.Symbol = "BTU•in/h•ft²•°F²"
```
## Second <!-- NOUN -->
- Display name: second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Second:Second_1
Second_1.Symbol = "s"
```
## Millisecond <!-- NOUN -->
- Display name: millisecond
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millisecond
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Millisecond:Millisecond_1
Millisecond_1.ConversionFactorB = "1000"
Millisecond_1.Symbol = "ms"
```
## Microsecond <!-- NOUN -->
- Display name: microsecond
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in microsecond
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Microsecond:Microsecond_1
Microsecond_1.ConversionFactorB = "1000000"
Microsecond_1.Symbol = "µs"
```
## Shake <!-- NOUN -->
- Display name: shake
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100000000
- Description: 
[v] = a * [SI]
where
[v] is the value in shake
[SI] is the value in SI
a = 1.0/(10.0*Nano), i.e., 100000000
and
Nano = 1e-9

- Examples: 
``` dwis
Shake:Shake_1
Shake_1.ConversionFactorB = "100000000"
Shake_1.Symbol = "shake"
```
## Nanosecond <!-- NOUN -->
- Display name: nanosecond
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in nanosecond
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Nanosecond:Nanosecond_1
Nanosecond_1.ConversionFactorB = "999999999.9999999"
Nanosecond_1.Symbol = "ns"
```
## Picosecond <!-- NOUN -->
- Display name: picosecond
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in picosecond
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Picosecond:Picosecond_1
Picosecond_1.ConversionFactorB = "1000000000000"
Picosecond_1.Symbol = "ps"
```
## Minute <!-- NOUN -->
- Display name: minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.016666666666666666
- Description: 
[v] = a * [SI]
where
[v] is the value in minute
[SI] is the value in SI
a = 1.0/Minute, i.e., 0.016666666666666666
and
Minute = 60.0

- Examples: 
``` dwis
Minute:Minute_1
Minute_1.ConversionFactorB = "0.016666666666666666"
Minute_1.Symbol = "min"
```
## Hour <!-- NOUN -->
- Display name: hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002777777777777778
- Description: 
[v] = a * [SI]
where
[v] is the value in hour
[SI] is the value in SI
a = 1.0/Hour, i.e., 0.0002777777777777778
and
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Hour:Hour_1
Hour_1.ConversionFactorB = "0.0002777777777777778"
Hour_1.Symbol = "h"
```
## Day <!-- NOUN -->
- Display name: day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.1574074074074073E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in day
[SI] is the value in SI
a = 1.0/Day, i.e., 1.1574074074074073E-05
and
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Day:Day_1
Day_1.ConversionFactorB = "1.1574074074074073E-05"
Day_1.Symbol = "d"
```
## Week <!-- NOUN -->
- Display name: week
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6534391534391535E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in week
[SI] is the value in SI
a = 1.0/Week, i.e., 1.6534391534391535E-06
and
Week = 7.0 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Week:Week_1
Week_1.ConversionFactorB = "1.6534391534391535E-06"
Week_1.Symbol = "week"
```
## Fortnight <!-- NOUN -->
- Display name: fortnight
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 8.267195767195768E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in fortnight
[SI] is the value in SI
a = 1.0/Fortnight, i.e., 8.267195767195768E-07
and
Fortnight = 14.0 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Fortnight:Fortnight_1
Fortnight_1.ConversionFactorB = "8.267195767195768E-07"
Fortnight_1.Symbol = "14d"
```
## MonthCommon <!-- NOUN -->
- Display name: month common
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.802570537683474E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in month common
[SI] is the value in SI
a = 1.0/MonthCommon, i.e., 3.802570537683474E-07
and
MonthCommon = YearJulian / 12.0
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MonthCommon:MonthCommon_1
MonthCommon_1.ConversionFactorB = "3.802570537683474E-07"
MonthCommon_1.Symbol = "month common"
```
## MonthSideral <!-- NOUN -->
- Display name: month sideral
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 4.2362265228665E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in month sideral
[SI] is the value in SI
a = 1.0/MonthSideral, i.e., 4.2362265228665E-07
and
MonthSideral = 27.32166 * Day reference: https://en.wikipedia.org/wiki/Month
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MonthSideral:MonthSideral_1
MonthSideral_1.ConversionFactorB = "4.2362265228665E-07"
MonthSideral_1.Symbol = "month sideral"
```
## MonthSynodic <!-- NOUN -->
- Display name: month synodic
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.9193507729016165E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in month synodic
[SI] is the value in SI
a = 1.0/MonthSynodic, i.e., 3.9193507729016165E-07
and
MonthSynodic = 29.53059 * Day reference: https://en.wikipedia.org/wiki/Month
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MonthSynodic:MonthSynodic_1
MonthSynodic_1.ConversionFactorB = "3.9193507729016165E-07"
MonthSynodic_1.Symbol = "month synodic"
```
## QuarterCommon <!-- NOUN -->
- Display name: quarter common
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.267523512561158E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in quarter common
[SI] is the value in SI
a = 1.0/QuarterCommon, i.e., 1.267523512561158E-07
and
QuarterCommon = YearJulian / 4.0
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
QuarterCommon:QuarterCommon_1
QuarterCommon_1.ConversionFactorB = "1.267523512561158E-07"
QuarterCommon_1.Symbol = "quarter common"
```
## YearCommon <!-- NOUN -->
- Display name: year common
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.1709791983764586E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in year common
[SI] is the value in SI
a = 1.0/YearCommon, i.e., 3.1709791983764586E-08
and
YearCommon = 365 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
YearCommon:YearCommon_1
YearCommon_1.ConversionFactorB = "3.1709791983764586E-08"
YearCommon_1.Symbol = "y"
```
## YearAverageGregorian <!-- NOUN -->
- Display name: year average gregorian
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.1709791983764586E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in year average gregorian
[SI] is the value in SI
a = 1.0/YearAverageGregorian, i.e., 3.1709791983764586E-08
and
YearAverageGregorian = (365.0 + 97 / 400) * Day reference: https://en.wikipedia.org/wiki/Gregorian_calendar
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
YearAverageGregorian:YearAverageGregorian_1
YearAverageGregorian_1.ConversionFactorB = "3.1709791983764586E-08"
YearAverageGregorian_1.Symbol = "year average gregorian"
```
## YearJulian <!-- NOUN -->
- Display name: year julian
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.168808781402895E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in year julian
[SI] is the value in SI
a = 1.0/YearJulian, i.e., 3.168808781402895E-08
and
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
YearJulian:YearJulian_1
YearJulian_1.ConversionFactorB = "3.168808781402895E-08"
YearJulian_1.Symbol = "year julian"
```
## YearLeap <!-- NOUN -->
- Display name: year leap
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.1623153207852664E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in year leap
[SI] is the value in SI
a = 1.0/YearLeap, i.e., 3.1623153207852664E-08
and
YearLeap = 366 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
YearLeap:YearLeap_1
YearLeap_1.ConversionFactorB = "3.1623153207852664E-08"
YearLeap_1.Symbol = "year leap"
```
## YearTropical <!-- NOUN -->
- Display name: year tropical
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.1688764535078565E-08
- Description: 
[v] = a * [SI]
where
[v] is the value in year tropical
[SI] is the value in SI
a = 1.0/YearTropical, i.e., 3.1688764535078565E-08
and
YearTropical = 365.2422 * Day reference: https://www.grc.nasa.gov/www/k-12/Numbers/Math/Mathematical_Thinking/calendar_calculations.htm
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
YearTropical:YearTropical_1
YearTropical_1.ConversionFactorB = "3.1688764535078565E-08"
YearTropical_1.Symbol = "year tropical"
```
## Decade <!-- NOUN -->
- Display name: decade
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.168808781402895E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in decade
[SI] is the value in SI
a = 1.0/Decade, i.e., 3.168808781402895E-09
and
Decade = 10.0 * YearJulian
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Decade:Decade_1
Decade_1.ConversionFactorB = "3.168808781402895E-09"
Decade_1.Symbol = "decade"
```
## Century <!-- NOUN -->
- Display name: century
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.168808781402895E-10
- Description: 
[v] = a * [SI]
where
[v] is the value in century
[SI] is the value in SI
a = 1.0/Century, i.e., 3.168808781402895E-10
and
Century = 10.0 * Decade
Decade = 10.0 * YearJulian
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Century:Century_1
Century_1.ConversionFactorB = "3.168808781402895E-10"
Century_1.Symbol = "century"
```
## Millenia <!-- NOUN -->
- Display name: millenia
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.168808781402895E-11
- Description: 
[v] = a * [SI]
where
[v] is the value in millenia
[SI] is the value in SI
a = 1.0/Millenia, i.e., 3.168808781402895E-11
and
Millenia = 10.0 * Century
Century = 10.0 * Decade
Decade = 10.0 * YearJulian
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
Millenia:Millenia_1
Millenia_1.ConversionFactorB = "3.168808781402895E-11"
Millenia_1.Symbol = "millenia"
```
## MillionYear <!-- NOUN -->
- Display name: million year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.168808781402895E-14
- Description: 
[v] = a * [SI]
where
[v] is the value in million year
[SI] is the value in SI
a = 1.0/MillionYear, i.e., 3.168808781402895E-14
and
MillionYear = 1000.0 * Millenia
Millenia = 10.0 * Century
Century = 10.0 * Decade
Decade = 10.0 * YearJulian
YearJulian = 365.25 * Day
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MillionYear:MillionYear_1
MillionYear_1.ConversionFactorB = "3.168808781402895E-14"
MillionYear_1.Symbol = "My"
```
## NewtonMetrePerMetre <!-- NOUN -->
- Display name: newton metre per metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
NewtonMetrePerMetre:NewtonMetrePerMetre_1
NewtonMetrePerMetre_1.Symbol = "N•m/m"
```
## DecanewtonMetrePerMetre <!-- NOUN -->
- Display name: decanewton metre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre per metre
[SI] is the value in SI
a = Unit/Deca, i.e., 0.1
and
Unit = 1.0
Deca = 10.0

- Examples: 
``` dwis
DecanewtonMetrePerMetre:DecanewtonMetrePerMetre_1
DecanewtonMetrePerMetre_1.ConversionFactorB = "0.1"
DecanewtonMetrePerMetre_1.Symbol = "daN•m/m"
```
## KilogramForceMetrePerMetre <!-- NOUN -->
- Display name: kilogram force metre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10197162129779283
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre per metre
[SI] is the value in SI
a = Unit/(KilogramForce), i.e., 0.10197162129779283
and
Unit = 1.0
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetrePerMetre:KilogramForceMetrePerMetre_1
KilogramForceMetrePerMetre_1.ConversionFactorB = "0.10197162129779283"
KilogramForceMetrePerMetre_1.Symbol = "kgf•m/m"
```
## KilonewtonMetrePerMetre <!-- NOUN -->
- Display name: kilonewton metre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre per metre
[SI] is the value in SI
a = Unit/Kilo, i.e., 0.001
and
Unit = 1.0
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonMetrePerMetre:KilonewtonMetrePerMetre_1
KilonewtonMetrePerMetre_1.ConversionFactorB = "0.001"
KilonewtonMetrePerMetre_1.Symbol = "kN•m/m"
```
## FootPoundPerMetre <!-- NOUN -->
- Display name: foot pound per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.7375621492772655
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound per metre
[SI] is the value in SI
a = Unit/(PoundForce*Foot), i.e., 0.7375621492772655
and
Unit = 1.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPoundPerMetre:FootPoundPerMetre_1
FootPoundPerMetre_1.ConversionFactorB = "0.7375621492772655"
FootPoundPerMetre_1.Symbol = "ft•lbf/m"
```
## KilofootPoundPerMetre <!-- NOUN -->
- Display name: kilofoot pound per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0007375621492772654
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound per metre
[SI] is the value in SI
a = Unit/(Kilo*PoundForce*Foot), i.e., 0.0007375621492772654
and
Unit = 1.0
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Foot = 12.0 * Inch
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KilofootPoundPerMetre:KilofootPoundPerMetre_1
KilofootPoundPerMetre_1.ConversionFactorB = "0.0007375621492772654"
KilofootPoundPerMetre_1.Symbol = "kft•lbf/m"
```
## NewtonDecimetrePerMetre <!-- NOUN -->
- Display name: newton decimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre per metre
[SI] is the value in SI
a = Unit/Deci, i.e., 10
and
Unit = 1.0
Deci = 0.1

- Examples: 
``` dwis
NewtonDecimetrePerMetre:NewtonDecimetrePerMetre_1
NewtonDecimetrePerMetre_1.ConversionFactorB = "10"
NewtonDecimetrePerMetre_1.Symbol = "N•dm/m"
```
## NewtonCentimetrePerMetre <!-- NOUN -->
- Display name: newton centimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre per metre
[SI] is the value in SI
a = Unit/Centi, i.e., 100
and
Unit = 1.0
Centi = 0.01

- Examples: 
``` dwis
NewtonCentimetrePerMetre:NewtonCentimetrePerMetre_1
NewtonCentimetrePerMetre_1.ConversionFactorB = "100"
NewtonCentimetrePerMetre_1.Symbol = "N•cm/m"
```
## NewtonMillimetrePerMetre <!-- NOUN -->
- Display name: newton millimetre per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre per metre
[SI] is the value in SI
a = Unit/Milli, i.e., 1000
and
Unit = 1.0
Milli = 0.001

- Examples: 
``` dwis
NewtonMillimetrePerMetre:NewtonMillimetrePerMetre_1
NewtonMillimetrePerMetre_1.ConversionFactorB = "1000"
NewtonMillimetrePerMetre_1.Symbol = "N•mm/m"
```
## InchPoundPerMetre <!-- NOUN -->
- Display name: inch pound per metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 8.850745791327185
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound per metre
[SI] is the value in SI
a = Unit/(Inch*PoundForce), i.e., 8.850745791327185
and
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPoundPerMetre:InchPoundPerMetre_1
InchPoundPerMetre_1.ConversionFactorB = "8.850745791327185"
InchPoundPerMetre_1.Symbol = "in•lbf/m"
```
## NewtonMetrePerDecimetre <!-- NOUN -->
- Display name: Newton metre per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in Newton metre per decimetre
[SI] is the value in SI
a = Deci/Unit, i.e., 0.1
and
Deci = 0.1
Unit = 1.0

- Examples: 
``` dwis
NewtonMetrePerDecimetre:NewtonMetrePerDecimetre_1
NewtonMetrePerDecimetre_1.ConversionFactorB = "0.1"
NewtonMetrePerDecimetre_1.Symbol = "N•m/dm"
```
## DecanewtonMetrePerDecimetre <!-- NOUN -->
- Display name: decanewton metre per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre per decimetre
[SI] is the value in SI
a = Deci/Deca, i.e., 0.01
and
Deci = 0.1
Deca = 10.0

- Examples: 
``` dwis
DecanewtonMetrePerDecimetre:DecanewtonMetrePerDecimetre_1
DecanewtonMetrePerDecimetre_1.ConversionFactorB = "0.01"
DecanewtonMetrePerDecimetre_1.Symbol = "daN•m/dm"
```
## KilogramForceMetrePerDecimetre <!-- NOUN -->
- Display name: kilogram force metre per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.010197162129779284
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre per decimetre
[SI] is the value in SI
a = Deci/(KilogramForce), i.e., 0.010197162129779284
and
Deci = 0.1
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetrePerDecimetre:KilogramForceMetrePerDecimetre_1
KilogramForceMetrePerDecimetre_1.ConversionFactorB = "0.010197162129779284"
KilogramForceMetrePerDecimetre_1.Symbol = "kgf•m/dm"
```
## KilonewtonMetrePerDecimetre <!-- NOUN -->
- Display name: kilonewton metre per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre per decimetre
[SI] is the value in SI
a = Deci/(Kilo*Unit), i.e., 0.0001
and
Deci = 0.1
Kilo = 1000.0
Unit = 1.0

- Examples: 
``` dwis
KilonewtonMetrePerDecimetre:KilonewtonMetrePerDecimetre_1
KilonewtonMetrePerDecimetre_1.ConversionFactorB = "0.0001"
KilonewtonMetrePerDecimetre_1.Symbol = "kN•m/dm"
```
## FootPoundPerDecimetre <!-- NOUN -->
- Display name: foot pound per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.07375621492772655
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound per decimetre
[SI] is the value in SI
a = Deci/(Foot*PoundForce), i.e., 0.07375621492772655
and
Deci = 0.1
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
FootPoundPerDecimetre:FootPoundPerDecimetre_1
FootPoundPerDecimetre_1.ConversionFactorB = "0.07375621492772655"
FootPoundPerDecimetre_1.Symbol = "ft•lbf/dm"
```
## KilofootPoundPerDecimetre <!-- NOUN -->
- Display name: kilofoot pound per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 7.375621492772657E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound per decimetre
[SI] is the value in SI
a = Deci/(Kilo*Foot*PoundForce), i.e., 7.375621492772657E-05
and
Deci = 0.1
Kilo = 1000.0
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilofootPoundPerDecimetre:KilofootPoundPerDecimetre_1
KilofootPoundPerDecimetre_1.ConversionFactorB = "7.375621492772657E-05"
KilofootPoundPerDecimetre_1.Symbol = "kft•lbf/dm"
```
## NewtonDecimetrePerDecimetre <!-- NOUN -->
- Display name: newton decimetre per decimetre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre per decimetre
[SI] is the value in SI
a = Deci/(Deci*Unit), i.e., 1
and
Deci = 0.1
Unit = 1.0

- Examples: 
``` dwis
NewtonDecimetrePerDecimetre:NewtonDecimetrePerDecimetre_1
NewtonDecimetrePerDecimetre_1.Symbol = "N•dm/dm"
```
## NewtonCentimetrePerDecimetre <!-- NOUN -->
- Display name: newton centimetre per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre per decimetre
[SI] is the value in SI
a = Deci/(Centi*Unit), i.e., 10
and
Deci = 0.1
Centi = 0.01
Unit = 1.0

- Examples: 
``` dwis
NewtonCentimetrePerDecimetre:NewtonCentimetrePerDecimetre_1
NewtonCentimetrePerDecimetre_1.ConversionFactorB = "10"
NewtonCentimetrePerDecimetre_1.Symbol = "N•cm/dm"
```
## NewtonMillimetrePerDecimetre <!-- NOUN -->
- Display name: newton millimetre per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre per decimetre
[SI] is the value in SI
a = Deci/(Milli*Unit), i.e., 100
and
Deci = 0.1
Milli = 0.001
Unit = 1.0

- Examples: 
``` dwis
NewtonMillimetrePerDecimetre:NewtonMillimetrePerDecimetre_1
NewtonMillimetrePerDecimetre_1.ConversionFactorB = "100"
NewtonMillimetrePerDecimetre_1.Symbol = "N•mm/dm"
```
## InchPoundPerDecimetre <!-- NOUN -->
- Display name: inch pound per decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.8850745791327186
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound per decimetre
[SI] is the value in SI
a = Deci/(Inch*PoundForce), i.e., 0.8850745791327186
and
Deci = 0.1
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPoundPerDecimetre:InchPoundPerDecimetre_1
InchPoundPerDecimetre_1.ConversionFactorB = "0.8850745791327186"
InchPoundPerDecimetre_1.Symbol = "in•lbf/dm"
```
## NewtonMetrePerCentimetre <!-- NOUN -->
- Display name: Newton metre per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in Newton metre per centimetre
[SI] is the value in SI
a = Centi/(Unit*Unit), i.e., 0.01
and
Centi = 0.01
Unit = 1.0

- Examples: 
``` dwis
NewtonMetrePerCentimetre:NewtonMetrePerCentimetre_1
NewtonMetrePerCentimetre_1.ConversionFactorB = "0.01"
NewtonMetrePerCentimetre_1.Symbol = "N•m/cm"
```
## DecanewtonMetrePerCentimetre <!-- NOUN -->
- Display name: decanewton metre per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre per centimetre
[SI] is the value in SI
a = Centi/(Deca), i.e., 0.001
and
Centi = 0.01
Deca = 10.0

- Examples: 
``` dwis
DecanewtonMetrePerCentimetre:DecanewtonMetrePerCentimetre_1
DecanewtonMetrePerCentimetre_1.ConversionFactorB = "0.001"
DecanewtonMetrePerCentimetre_1.Symbol = "daN•m/cm"
```
## KilogramForceMetrePerCentimetre <!-- NOUN -->
- Display name: kilogram force metre per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0010197162129779284
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre per centimetre
[SI] is the value in SI
a = Centi/(KilogramForce), i.e., 0.0010197162129779284
and
Centi = 0.01
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetrePerCentimetre:KilogramForceMetrePerCentimetre_1
KilogramForceMetrePerCentimetre_1.ConversionFactorB = "0.0010197162129779284"
KilogramForceMetrePerCentimetre_1.Symbol = "kgf•m/cm"
```
## KilonewtonMetrePerCentimetre <!-- NOUN -->
- Display name: kilonewton metre per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre per centimetre
[SI] is the value in SI
a = Centi/(Kilo), i.e., 1E-05
and
Centi = 0.01
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonMetrePerCentimetre:KilonewtonMetrePerCentimetre_1
KilonewtonMetrePerCentimetre_1.ConversionFactorB = "1E-05"
KilonewtonMetrePerCentimetre_1.Symbol = "kN•m/cm"
```
## FootPoundPerCentimetre <!-- NOUN -->
- Display name: foot pound per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.007375621492772655
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound per centimetre
[SI] is the value in SI
a = Centi/(Foot*PoundForce), i.e., 0.007375621492772655
and
Centi = 0.01
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
FootPoundPerCentimetre:FootPoundPerCentimetre_1
FootPoundPerCentimetre_1.ConversionFactorB = "0.007375621492772655"
FootPoundPerCentimetre_1.Symbol = "ft•lbf/cm"
```
## KilofootPoundPerCentimetre <!-- NOUN -->
- Display name: kilofoot pound per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 7.3756214927726565E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound per centimetre
[SI] is the value in SI
a = Centi/(Kilo*Foot*PoundForce), i.e., 7.3756214927726565E-06
and
Centi = 0.01
Kilo = 1000.0
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilofootPoundPerCentimetre:KilofootPoundPerCentimetre_1
KilofootPoundPerCentimetre_1.ConversionFactorB = "7.3756214927726565E-06"
KilofootPoundPerCentimetre_1.Symbol = "kft•lbf/cm"
```
## NewtonDecimetrePerCentimetre <!-- NOUN -->
- Display name: newton decimetre per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.09999999999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre per centimetre
[SI] is the value in SI
a = Centi/(Deci), i.e., 0.09999999999999999
and
Centi = 0.01
Deci = 0.1

- Examples: 
``` dwis
NewtonDecimetrePerCentimetre:NewtonDecimetrePerCentimetre_1
NewtonDecimetrePerCentimetre_1.ConversionFactorB = "0.09999999999999999"
NewtonDecimetrePerCentimetre_1.Symbol = "N•dm/cm"
```
## NewtonCentimetrePerCentimetre <!-- NOUN -->
- Display name: newton centimetre per centimetre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre per centimetre
[SI] is the value in SI
a = Centi/Centi, i.e., 1
and
Centi = 0.01

- Examples: 
``` dwis
NewtonCentimetrePerCentimetre:NewtonCentimetrePerCentimetre_1
NewtonCentimetrePerCentimetre_1.Symbol = "N•cm/cm"
```
## NewtonMillimetrePerCentimetre <!-- NOUN -->
- Display name: newton millimetre per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre per centimetre
[SI] is the value in SI
a = Centi/Milli, i.e., 10
and
Centi = 0.01
Milli = 0.001

- Examples: 
``` dwis
NewtonMillimetrePerCentimetre:NewtonMillimetrePerCentimetre_1
NewtonMillimetrePerCentimetre_1.ConversionFactorB = "10"
NewtonMillimetrePerCentimetre_1.Symbol = "N•mm/cm"
```
## InchPoundPerCentimetre <!-- NOUN -->
- Display name: inch pound per centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.08850745791327186
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound per centimetre
[SI] is the value in SI
a = Centi/(Inch*PoundForce), i.e., 0.08850745791327186
and
Centi = 0.01
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPoundPerCentimetre:InchPoundPerCentimetre_1
InchPoundPerCentimetre_1.ConversionFactorB = "0.08850745791327186"
InchPoundPerCentimetre_1.Symbol = "in•lbf/cm"
```
## NewtonMetrePerMillimetre <!-- NOUN -->
- Display name: Newton metre per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in Newton metre per millimetre
[SI] is the value in SI
a = Milli/(Unit*Unit), i.e., 0.001
and
Milli = 0.001
Unit = 1.0

- Examples: 
``` dwis
NewtonMetrePerMillimetre:NewtonMetrePerMillimetre_1
NewtonMetrePerMillimetre_1.ConversionFactorB = "0.001"
NewtonMetrePerMillimetre_1.Symbol = "N•m/mm"
```
## DecanewtonMetrePerMillimetre <!-- NOUN -->
- Display name: decanewton metre per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0001
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre per millimetre
[SI] is the value in SI
a = Milli/(Deca), i.e., 0.0001
and
Milli = 0.001
Deca = 10.0

- Examples: 
``` dwis
DecanewtonMetrePerMillimetre:DecanewtonMetrePerMillimetre_1
DecanewtonMetrePerMillimetre_1.ConversionFactorB = "0.0001"
DecanewtonMetrePerMillimetre_1.Symbol = "daN•m/mm"
```
## KilogramForceMetrePerMillimetre <!-- NOUN -->
- Display name: kilogram force metre per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00010197162129779284
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre per millimetre
[SI] is the value in SI
a = Milli/(KilogramForce), i.e., 0.00010197162129779284
and
Milli = 0.001
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetrePerMillimetre:KilogramForceMetrePerMillimetre_1
KilogramForceMetrePerMillimetre_1.ConversionFactorB = "0.00010197162129779284"
KilogramForceMetrePerMillimetre_1.Symbol = "kgf•m/mm"
```
## KilonewtonMetrePerMillimetre <!-- NOUN -->
- Display name: kilonewton metre per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre per millimetre
[SI] is the value in SI
a = Milli/(Kilo), i.e., 1E-06
and
Milli = 0.001
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonMetrePerMillimetre:KilonewtonMetrePerMillimetre_1
KilonewtonMetrePerMillimetre_1.ConversionFactorB = "1E-06"
KilonewtonMetrePerMillimetre_1.Symbol = "kN•m/mm"
```
## FootPoundPerMillimetre <!-- NOUN -->
- Display name: foot pound per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0007375621492772656
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound per millimetre
[SI] is the value in SI
a = Milli/(Foot*PoundForce), i.e., 0.0007375621492772656
and
Milli = 0.001
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
FootPoundPerMillimetre:FootPoundPerMillimetre_1
FootPoundPerMillimetre_1.ConversionFactorB = "0.0007375621492772656"
FootPoundPerMillimetre_1.Symbol = "ft•lbf/mm"
```
## KilofootPoundPerMillimetre <!-- NOUN -->
- Display name: kilofoot pound per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 7.375621492772656E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound per millimetre
[SI] is the value in SI
a = Milli/(Kilo*Foot*PoundForce), i.e., 7.375621492772656E-07
and
Milli = 0.001
Kilo = 1000.0
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilofootPoundPerMillimetre:KilofootPoundPerMillimetre_1
KilofootPoundPerMillimetre_1.ConversionFactorB = "7.375621492772656E-07"
KilofootPoundPerMillimetre_1.Symbol = "kft•lbf/mm"
```
## NewtonDecimetrePerMillimetre <!-- NOUN -->
- Display name: newton decimetre per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre per millimetre
[SI] is the value in SI
a = Milli/(Deci), i.e., 0.01
and
Milli = 0.001
Deci = 0.1

- Examples: 
``` dwis
NewtonDecimetrePerMillimetre:NewtonDecimetrePerMillimetre_1
NewtonDecimetrePerMillimetre_1.ConversionFactorB = "0.01"
NewtonDecimetrePerMillimetre_1.Symbol = "N•dm/mm"
```
## NewtonCentimetrePerMillimetre <!-- NOUN -->
- Display name: newton centimetre per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre per millimetre
[SI] is the value in SI
a = Milli/Centi, i.e., 0.1
and
Milli = 0.001
Centi = 0.01

- Examples: 
``` dwis
NewtonCentimetrePerMillimetre:NewtonCentimetrePerMillimetre_1
NewtonCentimetrePerMillimetre_1.ConversionFactorB = "0.1"
NewtonCentimetrePerMillimetre_1.Symbol = "N•cm/mm"
```
## NewtonMillimetrePerMillimetre <!-- NOUN -->
- Display name: newton millimetre per millimetre
- Parent class: Unit
- Specialization: 
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre per millimetre
[SI] is the value in SI
a = Milli/Milli, i.e., 1
and
Milli = 0.001

- Examples: 
``` dwis
NewtonMillimetrePerMillimetre:NewtonMillimetrePerMillimetre_1
NewtonMillimetrePerMillimetre_1.Symbol = "N•mm/mm"
```
## InchPoundPerMillimetre <!-- NOUN -->
- Display name: inch pound per millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.008850745791327186
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound per millimetre
[SI] is the value in SI
a = Milli/(Inch*PoundForce), i.e., 0.008850745791327186
and
Milli = 0.001
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPoundPerMillimetre:InchPoundPerMillimetre_1
InchPoundPerMillimetre_1.ConversionFactorB = "0.008850745791327186"
InchPoundPerMillimetre_1.Symbol = "in•lbf/mm"
```
## NewtonMetrePerFoot <!-- NOUN -->
- Display name: Newton metre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.30479999999999996
- Description: 
[v] = a * [SI]
where
[v] is the value in Newton metre per foot
[SI] is the value in SI
a = Foot/Unit, i.e., 0.30479999999999996
and
Foot = 12.0 * Inch
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
NewtonMetrePerFoot:NewtonMetrePerFoot_1
NewtonMetrePerFoot_1.ConversionFactorB = "0.30479999999999996"
NewtonMetrePerFoot_1.Symbol = "N•m/ft"
```
## DecanewtonMetrePerFoot <!-- NOUN -->
- Display name: decanewton metre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.030479999999999997
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre per foot
[SI] is the value in SI
a = Foot/(Deca), i.e., 0.030479999999999997
and
Foot = 12.0 * Inch
Deca = 10.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
DecanewtonMetrePerFoot:DecanewtonMetrePerFoot_1
DecanewtonMetrePerFoot_1.ConversionFactorB = "0.030479999999999997"
DecanewtonMetrePerFoot_1.Symbol = "daN•m/ft"
```
## KilogramForceMetrePerFoot <!-- NOUN -->
- Display name: kilogram force metre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.03108095017156725
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre per foot
[SI] is the value in SI
a = Foot/KilogramForce, i.e., 0.03108095017156725
and
Foot = 12.0 * Inch
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetrePerFoot:KilogramForceMetrePerFoot_1
KilogramForceMetrePerFoot_1.ConversionFactorB = "0.03108095017156725"
KilogramForceMetrePerFoot_1.Symbol = "kgf•m/ft"
```
## KilonewtonMetrePerFoot <!-- NOUN -->
- Display name: kilonewton metre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0003048
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre per foot
[SI] is the value in SI
a = Foot/Kilo, i.e., 0.0003048
and
Foot = 12.0 * Inch
Kilo = 1000.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
KilonewtonMetrePerFoot:KilonewtonMetrePerFoot_1
KilonewtonMetrePerFoot_1.ConversionFactorB = "0.0003048"
KilonewtonMetrePerFoot_1.Symbol = "kN•m/ft"
```
## FootPoundPerFoot <!-- NOUN -->
- Display name: foot pound per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2248089430997105
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound per foot
[SI] is the value in SI
a = Foot/(Foot*PoundForce), i.e., 0.2248089430997105
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
FootPoundPerFoot:FootPoundPerFoot_1
FootPoundPerFoot_1.ConversionFactorB = "0.2248089430997105"
FootPoundPerFoot_1.Symbol = "ft•lbf/ft"
```
## KilofootPoundPerFoot <!-- NOUN -->
- Display name: kilofoot pound per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00022480894309971053
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound per foot
[SI] is the value in SI
a = Foot/(Kilo*Foot*PoundForce), i.e., 0.00022480894309971053
and
Foot = 12.0 * Inch
Kilo = 1000.0
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilofootPoundPerFoot:KilofootPoundPerFoot_1
KilofootPoundPerFoot_1.ConversionFactorB = "0.00022480894309971053"
KilofootPoundPerFoot_1.Symbol = "kft•lbf/ft"
```
## NewtonDecimetrePerFoot <!-- NOUN -->
- Display name: newton decimetre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.0479999999999996
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre per foot
[SI] is the value in SI
a = Foot/(Deci), i.e., 3.0479999999999996
and
Foot = 12.0 * Inch
Deci = 0.1
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
NewtonDecimetrePerFoot:NewtonDecimetrePerFoot_1
NewtonDecimetrePerFoot_1.ConversionFactorB = "3.0479999999999996"
NewtonDecimetrePerFoot_1.Symbol = "N•dm/ft"
```
## NewtonCentimetrePerFoot <!-- NOUN -->
- Display name: newton centimetre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30.479999999999997
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre per foot
[SI] is the value in SI
a = Foot/Centi, i.e., 30.479999999999997
and
Foot = 12.0 * Inch
Centi = 0.01
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
NewtonCentimetrePerFoot:NewtonCentimetrePerFoot_1
NewtonCentimetrePerFoot_1.ConversionFactorB = "30.479999999999997"
NewtonCentimetrePerFoot_1.Symbol = "N•cm/ft"
```
## NewtonMillimetrePerFoot <!-- NOUN -->
- Display name: newton millimetre per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 304.79999999999995
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre per foot
[SI] is the value in SI
a = Foot/Milli, i.e., 304.79999999999995
and
Foot = 12.0 * Inch
Milli = 0.001
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
NewtonMillimetrePerFoot:NewtonMillimetrePerFoot_1
NewtonMillimetrePerFoot_1.ConversionFactorB = "304.79999999999995"
NewtonMillimetrePerFoot_1.Symbol = "N•mm/ft"
```
## InchPoundPerFoot <!-- NOUN -->
- Display name: inch pound per foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.697707317196526
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound per foot
[SI] is the value in SI
a = Foot/(Inch*PoundForce), i.e., 2.697707317196526
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPoundPerFoot:InchPoundPerFoot_1
InchPoundPerFoot_1.ConversionFactorB = "2.697707317196526"
InchPoundPerFoot_1.Symbol = "in•lbf/ft"
```
## NewtonMetrePerInch <!-- NOUN -->
- Display name: Newton metre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0254
- Description: 
[v] = a * [SI]
where
[v] is the value in Newton metre per inch
[SI] is the value in SI
a = Inch/Unit, i.e., 0.0254
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Unit = 1.0

- Examples: 
``` dwis
NewtonMetrePerInch:NewtonMetrePerInch_1
NewtonMetrePerInch_1.ConversionFactorB = "0.0254"
NewtonMetrePerInch_1.Symbol = "N•m/in"
```
## DecanewtonMetrePerInch <!-- NOUN -->
- Display name: decanewton metre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0025399999999999997
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre per inch
[SI] is the value in SI
a = Inch/Deca, i.e., 0.0025399999999999997
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Deca = 10.0

- Examples: 
``` dwis
DecanewtonMetrePerInch:DecanewtonMetrePerInch_1
DecanewtonMetrePerInch_1.ConversionFactorB = "0.0025399999999999997"
DecanewtonMetrePerInch_1.Symbol = "daN•m/in"
```
## KilogramForceMetrePerInch <!-- NOUN -->
- Display name: kilogram force metre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0025900791809639378
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre per inch
[SI] is the value in SI
a = Inch/KilogramForce, i.e., 0.0025900791809639378
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetrePerInch:KilogramForceMetrePerInch_1
KilogramForceMetrePerInch_1.ConversionFactorB = "0.0025900791809639378"
KilogramForceMetrePerInch_1.Symbol = "kgf•m/in"
```
## KilonewtonMetrePerInch <!-- NOUN -->
- Display name: kilonewton metre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.5399999999999997E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre per inch
[SI] is the value in SI
a = Inch/Kilo, i.e., 2.5399999999999997E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonMetrePerInch:KilonewtonMetrePerInch_1
KilonewtonMetrePerInch_1.ConversionFactorB = "2.5399999999999997E-05"
KilonewtonMetrePerInch_1.Symbol = "kN•m/in"
```
## FootPoundPerInch <!-- NOUN -->
- Display name: foot pound per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.018734078591642542
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound per inch
[SI] is the value in SI
a = Inch/(Foot*PoundForce), i.e., 0.018734078591642542
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
FootPoundPerInch:FootPoundPerInch_1
FootPoundPerInch_1.ConversionFactorB = "0.018734078591642542"
FootPoundPerInch_1.Symbol = "ft•lbf/in"
```
## KilofootPoundPerInch <!-- NOUN -->
- Display name: kilofoot pound per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.8734078591642546E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound per inch
[SI] is the value in SI
a = Inch/(Kilo*Foot*PoundForce), i.e., 1.8734078591642546E-05
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Kilo = 1000.0
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilofootPoundPerInch:KilofootPoundPerInch_1
KilofootPoundPerInch_1.ConversionFactorB = "1.8734078591642546E-05"
KilofootPoundPerInch_1.Symbol = "kft•lbf/in"
```
## NewtonDecimetrePerInch <!-- NOUN -->
- Display name: newton decimetre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.25399999999999995
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre per inch
[SI] is the value in SI
a = Inch/Deci, i.e., 0.25399999999999995
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Deci = 0.1

- Examples: 
``` dwis
NewtonDecimetrePerInch:NewtonDecimetrePerInch_1
NewtonDecimetrePerInch_1.ConversionFactorB = "0.25399999999999995"
NewtonDecimetrePerInch_1.Symbol = "N•dm/in"
```
## NewtonCentimetrePerInch <!-- NOUN -->
- Display name: newton centimetre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.54
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre per inch
[SI] is the value in SI
a = Inch/Centi, i.e., 2.54
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Centi = 0.01

- Examples: 
``` dwis
NewtonCentimetrePerInch:NewtonCentimetrePerInch_1
NewtonCentimetrePerInch_1.ConversionFactorB = "2.54"
NewtonCentimetrePerInch_1.Symbol = "N•cm/in"
```
## NewtonMillimetrePerInch <!-- NOUN -->
- Display name: newton millimetre per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 25.4
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre per inch
[SI] is the value in SI
a = Inch/Milli, i.e., 25.4
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Milli = 0.001

- Examples: 
``` dwis
NewtonMillimetrePerInch:NewtonMillimetrePerInch_1
NewtonMillimetrePerInch_1.ConversionFactorB = "25.4"
NewtonMillimetrePerInch_1.Symbol = "N•mm/in"
```
## InchPoundPerInch <!-- NOUN -->
- Display name: inch pound per inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2248089430997105
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound per inch
[SI] is the value in SI
a = Inch/(Inch*PoundForce), i.e., 0.2248089430997105
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPoundPerInch:InchPoundPerInch_1
InchPoundPerInch_1.ConversionFactorB = "0.2248089430997105"
InchPoundPerInch_1.Symbol = "in•lbf/in"
```
## NewtonMetre <!-- NOUN -->
- Display name: newton metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
NewtonMetre:NewtonMetre_1
NewtonMetre_1.Symbol = "N•m"
```
## DecanewtonMetre <!-- NOUN -->
- Display name: decanewton metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in decanewton metre
[SI] is the value in SI
a = 1.0/(Deca), i.e., 0.1
and
Deca = 10.0

- Examples: 
``` dwis
DecanewtonMetre:DecanewtonMetre_1
DecanewtonMetre_1.ConversionFactorB = "0.1"
DecanewtonMetre_1.Symbol = "daN•m"
```
## KilogramForceMetre <!-- NOUN -->
- Display name: kilogram force metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.10197162129779283
- Description: 
[v] = a * [SI]
where
[v] is the value in kilogram force metre
[SI] is the value in SI
a = 1.0/ KilogramForce, i.e., 0.10197162129779283
and
KilogramForce = 1.0 * G reference: https://en.wikipedia.org/wiki/Kilogram-force
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilogramForceMetre:KilogramForceMetre_1
KilogramForceMetre_1.ConversionFactorB = "0.10197162129779283"
KilogramForceMetre_1.Symbol = "kgf•m"
```
## KilonewtonMetre <!-- NOUN -->
- Display name: kilonewton metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilonewton metre
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
KilonewtonMetre:KilonewtonMetre_1
KilonewtonMetre_1.ConversionFactorB = "0.001"
KilonewtonMetre_1.Symbol = "kN•m"
```
## FootPound <!-- NOUN -->
- Display name: foot pound
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.7375621492772655
- Description: 
[v] = a * [SI]
where
[v] is the value in foot pound
[SI] is the value in SI
a = 1.0/(Foot*PoundForce), i.e., 0.7375621492772655
and
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
FootPound:FootPound_1
FootPound_1.ConversionFactorB = "0.7375621492772655"
FootPound_1.Symbol = "ft•lbf"
```
## KilofootPound <!-- NOUN -->
- Display name: kilofoot pound
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0007375621492772656
- Description: 
[v] = a * [SI]
where
[v] is the value in kilofoot pound
[SI] is the value in SI
a = 1.0/(Kilo*Foot*PoundForce), i.e., 0.0007375621492772656
and
Kilo = 1000.0
Foot = 12.0 * Inch
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
KilofootPound:KilofootPound_1
KilofootPound_1.ConversionFactorB = "0.0007375621492772656"
KilofootPound_1.Symbol = "kft•lbf"
```
## NewtonDecimetre <!-- NOUN -->
- Display name: newton decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in newton decimetre
[SI] is the value in SI
a = 1.0/Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
NewtonDecimetre:NewtonDecimetre_1
NewtonDecimetre_1.ConversionFactorB = "10"
NewtonDecimetre_1.Symbol = "N•dm"
```
## NewtonCentimetre <!-- NOUN -->
- Display name: newton centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in newton centimetre
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
NewtonCentimetre:NewtonCentimetre_1
NewtonCentimetre_1.ConversionFactorB = "100"
NewtonCentimetre_1.Symbol = "N•cm"
```
## NewtonMillimetre <!-- NOUN -->
- Display name: newton millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in newton millimetre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
NewtonMillimetre:NewtonMillimetre_1
NewtonMillimetre_1.ConversionFactorB = "1000"
NewtonMillimetre_1.Symbol = "N•mm"
```
## InchPound <!-- NOUN -->
- Display name: inch pound
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 8.850745791327185
- Description: 
[v] = a * [SI]
where
[v] is the value in inch pound
[SI] is the value in SI
a = 1.0/(PoundForce*Inch), i.e., 8.850745791327185
and
PoundForce = Pound * G reference: https://en.wikipedia.org/wiki/Pound_(force)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)
G = 9.80665 reference: https://en.wikipedia.org/wiki/Gravity_of_Earth

- Examples: 
``` dwis
InchPound:InchPound_1
InchPound_1.ConversionFactorB = "8.850745791327185"
InchPound_1.Symbol = "in•lbf"
```
## MetrePerSecond <!-- NOUN -->
- Display name: metre per second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
MetrePerSecond:MetrePerSecond_1
MetrePerSecond_1.Symbol = "m/s"
```
## MetrePerMinute <!-- NOUN -->
- Display name: metre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in metre per minute
[SI] is the value in SI
a = Minute/Unit, i.e., 60
and
Minute = 60.0
Unit = 1.0

- Examples: 
``` dwis
MetrePerMinute:MetrePerMinute_1
MetrePerMinute_1.ConversionFactorB = "60"
MetrePerMinute_1.Symbol = "m/min"
```
## CentimetrePerSecond <!-- NOUN -->
- Display name: centimetre per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per second
[SI] is the value in SI
a = Unit/Centi, i.e., 100
and
Unit = 1.0
Centi = 0.01

- Examples: 
``` dwis
CentimetrePerSecond:CentimetrePerSecond_1
CentimetrePerSecond_1.ConversionFactorB = "100"
CentimetrePerSecond_1.Symbol = "cm/s"
```
## MetrePerHour <!-- NOUN -->
- Display name: metre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in metre per hour
[SI] is the value in SI
a = Hour/Unit, i.e., 3600
and
Hour = 60.0 * Minute
Unit = 1.0
Minute = 60.0

- Examples: 
``` dwis
MetrePerHour:MetrePerHour_1
MetrePerHour_1.ConversionFactorB = "3600"
MetrePerHour_1.Symbol = "m/h"
```
## MetrePerDay <!-- NOUN -->
- Display name: metre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400
- Description: 
[v] = a * [SI]
where
[v] is the value in metre per day
[SI] is the value in SI
a = Day/Unit, i.e., 86400
and
Day = 24.0 * Hour
Unit = 1.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MetrePerDay:MetrePerDay_1
MetrePerDay_1.ConversionFactorB = "86400"
MetrePerDay_1.Symbol = "m/d"
```
## FootPerHour <!-- NOUN -->
- Display name: foot per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 11811.023622047245
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per hour
[SI] is the value in SI
a = Hour/Foot, i.e., 11811.023622047245
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerHour:FootPerHour_1
FootPerHour_1.ConversionFactorB = "11811.023622047245"
FootPerHour_1.Symbol = "ft/h"
```
## FootPerDay <!-- NOUN -->
- Display name: foot per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 283464.5669291339
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per day
[SI] is the value in SI
a = Day/Foot, i.e., 283464.5669291339
and
Day = 24.0 * Hour
Foot = 12.0 * Inch
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
FootPerDay:FootPerDay_1
FootPerDay_1.ConversionFactorB = "283464.5669291339"
FootPerDay_1.Symbol = "ft/d"
```
## FootPerMinute <!-- NOUN -->
- Display name: foot per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 196.85039370078744
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per minute
[SI] is the value in SI
a = Minute/Foot, i.e., 196.85039370078744
and
Minute = 60.0
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerMinute:FootPerMinute_1
FootPerMinute_1.ConversionFactorB = "196.85039370078744"
FootPerMinute_1.Symbol = "ft/m"
```
## FootPerSecond <!-- NOUN -->
- Display name: foot per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.280839895013124
- Description: 
[v] = a * [SI]
where
[v] is the value in foot per second
[SI] is the value in SI
a = Unit/Foot, i.e., 3.280839895013124
and
Unit = 1.0
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
FootPerSecond:FootPerSecond_1
FootPerSecond_1.ConversionFactorB = "3.280839895013124"
FootPerSecond_1.Symbol = "ft/s"
```
## InchPerSecond <!-- NOUN -->
- Display name: inch per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 39.37007874015748
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per second
[SI] is the value in SI
a = Unit/Inch, i.e., 39.37007874015748
and
Unit = 1.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
InchPerSecond:InchPerSecond_1
InchPerSecond_1.ConversionFactorB = "39.37007874015748"
InchPerSecond_1.Symbol = "in/s"
```
## MilePerHour <!-- NOUN -->
- Display name: mile per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.2369362920544025
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per hour
[SI] is the value in SI
a = Hour/Mile, i.e., 2.2369362920544025
and
Hour = 60.0 * Minute
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Minute = 60.0
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerHour:MilePerHour_1
MilePerHour_1.ConversionFactorB = "2.2369362920544025"
MilePerHour_1.Symbol = "mph"
```
## KilometrePerHour <!-- NOUN -->
- Display name: kilometre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.6
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per hour
[SI] is the value in SI
a = Hour/Kilo, i.e., 3.6
and
Hour = 60.0 * Minute
Kilo = 1000.0
Minute = 60.0

- Examples: 
``` dwis
KilometrePerHour:KilometrePerHour_1
KilometrePerHour_1.ConversionFactorB = "3.6"
KilometrePerHour_1.Symbol = "km/h"
```
## KilometrePerMinute <!-- NOUN -->
- Display name: kilometre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per minute
[SI] is the value in SI
a = Minute/Kilo, i.e., 0.06
and
Minute = 60.0
Kilo = 1000.0

- Examples: 
``` dwis
KilometrePerMinute:KilometrePerMinute_1
KilometrePerMinute_1.ConversionFactorB = "0.06"
KilometrePerMinute_1.Symbol = "km/min"
```
## KilometrePerSecond <!-- NOUN -->
- Display name: kilometre per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per second
[SI] is the value in SI
a = Unit/Kilo, i.e., 0.001
and
Unit = 1.0
Kilo = 1000.0

- Examples: 
``` dwis
KilometrePerSecond:KilometrePerSecond_1
KilometrePerSecond_1.ConversionFactorB = "0.001"
KilometrePerSecond_1.Symbol = "km/s"
```
## KilometrePerDay <!-- NOUN -->
- Display name: kilometre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86.4
- Description: 
[v] = a * [SI]
where
[v] is the value in kilometre per day
[SI] is the value in SI
a = Day/Kilo, i.e., 86.4
and
Day = 24.0 * Hour
Kilo = 1000.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
KilometrePerDay:KilometrePerDay_1
KilometrePerDay_1.ConversionFactorB = "86.4"
KilometrePerDay_1.Symbol = "km/d"
```
## MilePerMinute <!-- NOUN -->
- Display name: mile per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.03728227153424004
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per minute
[SI] is the value in SI
a = Minute/Mile, i.e., 0.03728227153424004
and
Minute = 60.0
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerMinute:MilePerMinute_1
MilePerMinute_1.ConversionFactorB = "0.03728227153424004"
MilePerMinute_1.Symbol = "mi/min"
```
## MilePerSecond <!-- NOUN -->
- Display name: mile per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.000621371192237334
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per second
[SI] is the value in SI
a = Unit/Mile, i.e., 0.000621371192237334
and
Unit = 1.0
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerSecond:MilePerSecond_1
MilePerSecond_1.ConversionFactorB = "0.000621371192237334"
MilePerSecond_1.Symbol = "mi/s"
```
## MilePerDay <!-- NOUN -->
- Display name: mile per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 53.68647100930566
- Description: 
[v] = a * [SI]
where
[v] is the value in mile per day
[SI] is the value in SI
a = Day/Mile, i.e., 53.68647100930566
and
Day = 24.0 * Hour
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Hour = 60.0 * Minute
Yard = 3.0 * Foot
Minute = 60.0
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MilePerDay:MilePerDay_1
MilePerDay_1.ConversionFactorB = "53.68647100930566"
MilePerDay_1.Symbol = "mi/d"
```
## InchPerMinute <!-- NOUN -->
- Display name: inch per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2362.2047244094488
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per minute
[SI] is the value in SI
a = Minute/Inch, i.e., 2362.2047244094488
and
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
InchPerMinute:InchPerMinute_1
InchPerMinute_1.ConversionFactorB = "2362.2047244094488"
InchPerMinute_1.Symbol = "in/min"
```
## InchPerHour <!-- NOUN -->
- Display name: inch per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 141732.28346456692
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per hour
[SI] is the value in SI
a = Hour/Inch, i.e., 141732.28346456692
and
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
InchPerHour:InchPerHour_1
InchPerHour_1.ConversionFactorB = "141732.28346456692"
InchPerHour_1.Symbol = "in/h"
```
## InchPerDay <!-- NOUN -->
- Display name: inch per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3401574.8031496066
- Description: 
[v] = a * [SI]
where
[v] is the value in inch per day
[SI] is the value in SI
a = Day/Inch, i.e., 3401574.8031496066
and
Day = 24.0 * Hour
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
InchPerDay:InchPerDay_1
InchPerDay_1.ConversionFactorB = "3401574.8031496066"
InchPerDay_1.Symbol = "in/d"
```
## CentimetrePerMinute <!-- NOUN -->
- Display name: centimetre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6000
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per minute
[SI] is the value in SI
a = Minute/Centi, i.e., 6000
and
Minute = 60.0
Centi = 0.01

- Examples: 
``` dwis
CentimetrePerMinute:CentimetrePerMinute_1
CentimetrePerMinute_1.ConversionFactorB = "6000"
CentimetrePerMinute_1.Symbol = "cm/min"
```
## CentimetrePerHour <!-- NOUN -->
- Display name: centimetre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 360000
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per hour
[SI] is the value in SI
a = Hour/Centi, i.e., 360000
and
Hour = 60.0 * Minute
Centi = 0.01
Minute = 60.0

- Examples: 
``` dwis
CentimetrePerHour:CentimetrePerHour_1
CentimetrePerHour_1.ConversionFactorB = "360000"
CentimetrePerHour_1.Symbol = "cm/h"
```
## CentimetrePerDay <!-- NOUN -->
- Display name: centimetre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 8640000
- Description: 
[v] = a * [SI]
where
[v] is the value in centimetre per day
[SI] is the value in SI
a = Day/Centi, i.e., 8640000
and
Day = 24.0 * Hour
Centi = 0.01
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
CentimetrePerDay:CentimetrePerDay_1
CentimetrePerDay_1.ConversionFactorB = "8640000"
CentimetrePerDay_1.Symbol = "cm/d"
```
## MillimetrePerSecond <!-- NOUN -->
- Display name: millimetre per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre per second
[SI] is the value in SI
a = Unit/Milli, i.e., 1000
and
Unit = 1.0
Milli = 0.001

- Examples: 
``` dwis
MillimetrePerSecond:MillimetrePerSecond_1
MillimetrePerSecond_1.ConversionFactorB = "1000"
MillimetrePerSecond_1.Symbol = "mm/s"
```
## MillimetrePerMinute <!-- NOUN -->
- Display name: millimetre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre per minute
[SI] is the value in SI
a = Minute/Milli, i.e., 60000
and
Minute = 60.0
Milli = 0.001

- Examples: 
``` dwis
MillimetrePerMinute:MillimetrePerMinute_1
MillimetrePerMinute_1.ConversionFactorB = "60000"
MillimetrePerMinute_1.Symbol = "mm/min"
```
## MillimetrePerHour <!-- NOUN -->
- Display name: millimetre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre per hour
[SI] is the value in SI
a = Hour/Milli, i.e., 3600000
and
Hour = 60.0 * Minute
Milli = 0.001
Minute = 60.0

- Examples: 
``` dwis
MillimetrePerHour:MillimetrePerHour_1
MillimetrePerHour_1.ConversionFactorB = "3600000"
MillimetrePerHour_1.Symbol = "mm/h"
```
## MillimetrePerDay <!-- NOUN -->
- Display name: millimetre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400000
- Description: 
[v] = a * [SI]
where
[v] is the value in millimetre per day
[SI] is the value in SI
a = Day/Milli, i.e., 86400000
and
Day = 24.0 * Hour
Milli = 0.001
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MillimetrePerDay:MillimetrePerDay_1
MillimetrePerDay_1.ConversionFactorB = "86400000"
MillimetrePerDay_1.Symbol = "mm/d"
```
## DecimetrePerSecond <!-- NOUN -->
- Display name: decimetre per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre per second
[SI] is the value in SI
a = Unit/Deci, i.e., 10
and
Unit = 1.0
Deci = 0.1

- Examples: 
``` dwis
DecimetrePerSecond:DecimetrePerSecond_1
DecimetrePerSecond_1.ConversionFactorB = "10"
DecimetrePerSecond_1.Symbol = "dm/s"
```
## DecimetrePerMinute <!-- NOUN -->
- Display name: decimetre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 600
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre per minute
[SI] is the value in SI
a = Minute/Deci, i.e., 600
and
Minute = 60.0
Deci = 0.1

- Examples: 
``` dwis
DecimetrePerMinute:DecimetrePerMinute_1
DecimetrePerMinute_1.ConversionFactorB = "600"
DecimetrePerMinute_1.Symbol = "dm/min"
```
## DecimetrePerHour <!-- NOUN -->
- Display name: decimetre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 36000
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre per hour
[SI] is the value in SI
a = Hour/Deci, i.e., 36000
and
Hour = 60.0 * Minute
Deci = 0.1
Minute = 60.0

- Examples: 
``` dwis
DecimetrePerHour:DecimetrePerHour_1
DecimetrePerHour_1.ConversionFactorB = "36000"
DecimetrePerHour_1.Symbol = "dm/h"
```
## DecimetrePerDay <!-- NOUN -->
- Display name: decimetre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 864000
- Description: 
[v] = a * [SI]
where
[v] is the value in decimetre per day
[SI] is the value in SI
a = Day/Deci, i.e., 864000
and
Day = 24.0 * Hour
Deci = 0.1
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
DecimetrePerDay:DecimetrePerDay_1
DecimetrePerDay_1.ConversionFactorB = "864000"
DecimetrePerDay_1.Symbol = "dm/d"
```
## FurlongPerFortnight <!-- NOUN -->
- Display name: furlong per fortnight
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6012.884753042234
- Description: 
[v] = a * [SI]
where
[v] is the value in furlong per fortnight
[SI] is the value in SI
a = Fortnight/Furlong, i.e., 6012.884753042234
and
Fortnight = 14.0 * Day
Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong
Day = 24.0 * Hour
Foot = 12.0 * Inch
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
FurlongPerFortnight:FurlongPerFortnight_1
FurlongPerFortnight_1.ConversionFactorB = "6012.884753042234"
FurlongPerFortnight_1.Symbol = "furlong/14d"
```
## CubicMetre <!-- NOUN -->
- Display name: cubic metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
CubicMetre:CubicMetre_1
CubicMetre_1.Symbol = "m³"
```
## Litre <!-- NOUN -->
- Display name: litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Litre:Litre_1
Litre_1.ConversionFactorB = "1000"
Litre_1.Symbol = "l"
```
## Decilitre <!-- NOUN -->
- Display name: decilitre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in decilitre
[SI] is the value in SI
a = 1.0/(Deci*Milli), i.e., 10000
and
Deci = 0.1
Milli = 0.001

- Examples: 
``` dwis
Decilitre:Decilitre_1
Decilitre_1.ConversionFactorB = "10000"
Decilitre_1.Symbol = "dl"
```
## Centilitre <!-- NOUN -->
- Display name: centilitre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 99999.99999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in centilitre
[SI] is the value in SI
a = 1.0/(Centi*Milli), i.e., 99999.99999999999
and
Centi = 0.01
Milli = 0.001

- Examples: 
``` dwis
Centilitre:Centilitre_1
Centilitre_1.ConversionFactorB = "99999.99999999999"
Centilitre_1.Symbol = "cl"
```
## Millilitre <!-- NOUN -->
- Display name: millilitre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in millilitre
[SI] is the value in SI
a = 1.0/(Milli*Milli), i.e., 1000000
and
Milli = 0.001

- Examples: 
``` dwis
Millilitre:Millilitre_1
Millilitre_1.ConversionFactorB = "1000000"
Millilitre_1.Symbol = "ml"
```
## UsGallon <!-- NOUN -->
- Display name: US gallon
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 264.17205235814845
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon
[SI] is the value in SI
a = 1.0/GallonUS, i.e., 264.17205235814845
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UsGallon:UsGallon_1
UsGallon_1.ConversionFactorB = "264.17205235814845"
UsGallon_1.Symbol = "US Gal."
```
## UkGallon <!-- NOUN -->
- Display name: UK gallon
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 219.96924829908778
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon
[SI] is the value in SI
a = 1.0/GallonUK, i.e., 219.96924829908778
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
UkGallon:UkGallon_1
UkGallon_1.ConversionFactorB = "219.96924829908778"
UkGallon_1.Symbol = "UK Gal."
```
## Barrel <!-- NOUN -->
- Display name: barrel
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.289810770432106
- Description: 
[v] = a * [SI]
where
[v] is the value in barrel
[SI] is the value in SI
a = 1.0/Barrel, i.e., 6.289810770432106
and
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
Barrel:Barrel_1
Barrel_1.ConversionFactorB = "6.289810770432106"
Barrel_1.Symbol = "bbl"
```
## MillionCubicMetre <!-- NOUN -->
- Display name: million cubic metre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in million cubic metre
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
MillionCubicMetre:MillionCubicMetre_1
MillionCubicMetre_1.ConversionFactorB = "1E-06"
MillionCubicMetre_1.Symbol = "Mm³"
```
## MillionLitre <!-- NOUN -->
- Display name: million litre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in million litre
[SI] is the value in SI
a = 1.0/(Mega*Milli), i.e., 0.001
and
Mega = 1e6
Milli = 0.001

- Examples: 
``` dwis
MillionLitre:MillionLitre_1
MillionLitre_1.ConversionFactorB = "0.001"
MillionLitre_1.Symbol = "Ml"
```
## MillionUkGallon <!-- NOUN -->
- Display name: million UK gallon
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002199692482990878
- Description: 
[v] = a * [SI]
where
[v] is the value in million UK gallon
[SI] is the value in SI
a = 1.0/(Mega*GallonUK), i.e., 0.0002199692482990878
and
Mega = 1e6
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
MillionUkGallon:MillionUkGallon_1
MillionUkGallon_1.ConversionFactorB = "0.0002199692482990878"
MillionUkGallon_1.Symbol = "M UK Gal."
```
## MillionBarrel <!-- NOUN -->
- Display name: million barrel
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.289810770432106E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in million barrel
[SI] is the value in SI
a = 1.0/(Mega*Barrel), i.e., 6.289810770432106E-06
and
Mega = 1e6
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MillionBarrel:MillionBarrel_1
MillionBarrel_1.ConversionFactorB = "6.289810770432106E-06"
MillionBarrel_1.Symbol = "Mbbl"
```
## ThousandStandardCubicFoot <!-- NOUN -->
- Display name: thousand standard cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0353146667214886
- Description: 
[v] = a * [SI]
where
[v] is the value in thousand standard cubic foot
[SI] is the value in SI
a = 1.0/(Kilo*Foot*Foot*Foot), i.e., 0.0353146667214886
and
Kilo = 1000.0
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ThousandStandardCubicFoot:ThousandStandardCubicFoot_1
ThousandStandardCubicFoot_1.ConversionFactorB = "0.0353146667214886"
ThousandStandardCubicFoot_1.Symbol = "Mscf"
```
## MillionStandardCubicFoot <!-- NOUN -->
- Display name: million standard cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.531466672148861E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in million standard cubic foot
[SI] is the value in SI
a = 1.0/(Mega*Foot*Foot*Foot), i.e., 3.531466672148861E-05
and
Mega = 1e6
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MillionStandardCubicFoot:MillionStandardCubicFoot_1
MillionStandardCubicFoot_1.ConversionFactorB = "3.531466672148861E-05"
MillionStandardCubicFoot_1.Symbol = "MMscf"
```
## CubicFoot <!-- NOUN -->
- Display name: cubic foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 35.3146667214886
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic foot
[SI] is the value in SI
a = 1.0/(Foot*Foot*Foot), i.e., 35.3146667214886
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CubicFoot:CubicFoot_1
CubicFoot_1.ConversionFactorB = "35.3146667214886"
CubicFoot_1.Symbol = "ft³"
```
## CubicInch <!-- NOUN -->
- Display name: cubic inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 61023.74409473229
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic inch
[SI] is the value in SI
a = 1.0/(Inch*Inch*Inch), i.e., 61023.74409473229
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CubicInch:CubicInch_1
CubicInch_1.ConversionFactorB = "61023.74409473229"
CubicInch_1.Symbol = "in³"
```
## MillionUsGallon <!-- NOUN -->
- Display name: million US gallon
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00026417205235814843
- Description: 
[v] = a * [SI]
where
[v] is the value in million US gallon
[SI] is the value in SI
a = 1.0/(Mega*GallonUS), i.e., 0.00026417205235814843
and
Mega = 1e6
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
MillionUsGallon:MillionUsGallon_1
MillionUsGallon_1.ConversionFactorB = "0.00026417205235814843"
MillionUsGallon_1.Symbol = "M US Gal."
```
## CubicMetrePerSecondSquared <!-- NOUN -->
- Display name: cubic metre per second squared
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
CubicMetrePerSecondSquared:CubicMetrePerSecondSquared_1
CubicMetrePerSecondSquared_1.Symbol = "m³/s²"
```
## LitrePerMinuteSquared <!-- NOUN -->
- Display name: litre per minute squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per minute squared
[SI] is the value in SI
a = Minute*Minute/Milli, i.e., 3600000
and
Minute = 60.0
Milli = 0.001

- Examples: 
``` dwis
LitrePerMinuteSquared:LitrePerMinuteSquared_1
LitrePerMinuteSquared_1.ConversionFactorB = "3600000"
LitrePerMinuteSquared_1.Symbol = "L/min²"
```
## LitrePerMinutePerSecond <!-- NOUN -->
- Display name: litre per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per minute per second
[SI] is the value in SI
a = Minute/Milli, i.e., 60000
and
Minute = 60.0
Milli = 0.001

- Examples: 
``` dwis
LitrePerMinutePerSecond:LitrePerMinutePerSecond_1
LitrePerMinutePerSecond_1.ConversionFactorB = "60000"
LitrePerMinutePerSecond_1.Symbol = "L/min/s"
```
## LitrePerSecondSquared <!-- NOUN -->
- Display name: litre per second squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per second squared
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
LitrePerSecondSquared:LitrePerSecondSquared_1
LitrePerSecondSquared_1.ConversionFactorB = "1000"
LitrePerSecondSquared_1.Symbol = "L/s²"
```
## UkGallonPerMinuteSquared <!-- NOUN -->
- Display name: UK gallon per minute squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 791889.293876716
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per minute squared
[SI] is the value in SI
a = Minute*Minute/GallonUK, i.e., 791889.293876716
and
Minute = 60.0
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
UkGallonPerMinuteSquared:UkGallonPerMinuteSquared_1
UkGallonPerMinuteSquared_1.ConversionFactorB = "791889.293876716"
UkGallonPerMinuteSquared_1.Symbol = "UKGal/min²"
```
## UkGallonPerMinutePerSecond <!-- NOUN -->
- Display name: UK gallon per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 13198.154897945267
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per minute per second
[SI] is the value in SI
a = Minute*Unit/GallonUK, i.e., 13198.154897945267
and
Minute = 60.0
Unit = 1.0
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
UkGallonPerMinutePerSecond:UkGallonPerMinutePerSecond_1
UkGallonPerMinutePerSecond_1.ConversionFactorB = "13198.154897945267"
UkGallonPerMinutePerSecond_1.Symbol = "UKGal/min/s"
```
## UsGallonPerMinuteSquared <!-- NOUN -->
- Display name: US gallon per minute squared
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 951019.3884893344
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per minute squared
[SI] is the value in SI
a = Minute*Minute/GallonUS, i.e., 951019.3884893344
and
Minute = 60.0
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UsGallonPerMinuteSquared:UsGallonPerMinuteSquared_1
UsGallonPerMinuteSquared_1.ConversionFactorB = "951019.3884893344"
UsGallonPerMinuteSquared_1.Symbol = "USGal/min²"
```
## UsGallonPerMinutePerSecond <!-- NOUN -->
- Display name: US gallon per minute per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 15850.323141488907
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per minute per second
[SI] is the value in SI
a = Minute*Unit/GallonUS, i.e., 15850.323141488907
and
Minute = 60.0
Unit = 1.0
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UsGallonPerMinutePerSecond:UsGallonPerMinutePerSecond_1
UsGallonPerMinutePerSecond_1.ConversionFactorB = "15850.323141488907"
UsGallonPerMinutePerSecond_1.Symbol = "USGal/min/s"
```
## CubicMetrePerSecond <!-- NOUN -->
- Display name: cubic metre per second
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
CubicMetrePerSecond:CubicMetrePerSecond_1
CubicMetrePerSecond_1.Symbol = "m³/s"
```
## LitrePerSecond <!-- NOUN -->
- Display name: litre per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per second
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
LitrePerSecond:LitrePerSecond_1
LitrePerSecond_1.ConversionFactorB = "1000"
LitrePerSecond_1.Symbol = "L/s"
```
## CubicFootPerSecond <!-- NOUN -->
- Display name: cubic foot per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 35.3146667214886
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic foot per second
[SI] is the value in SI
a = 1.0/(Foot*Foot*Foot), i.e., 35.3146667214886
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CubicFootPerSecond:CubicFootPerSecond_1
CubicFootPerSecond_1.ConversionFactorB = "35.3146667214886"
CubicFootPerSecond_1.Symbol = "ft³/s"
```
## UkGallonPerSecond <!-- NOUN -->
- Display name: UK gallon per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 219.96924829908778
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per second
[SI] is the value in SI
a = 1.0/GallonUK, i.e., 219.96924829908778
and
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
UkGallonPerSecond:UkGallonPerSecond_1
UkGallonPerSecond_1.ConversionFactorB = "219.96924829908778"
UkGallonPerSecond_1.Symbol = "gpsUK"
```
## UsGallonPerSecond <!-- NOUN -->
- Display name: US gallon per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 264.17205235814845
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per second
[SI] is the value in SI
a = 1.0/GallonUS, i.e., 264.17205235814845
and
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UsGallonPerSecond:UsGallonPerSecond_1
UsGallonPerSecond_1.ConversionFactorB = "264.17205235814845"
UsGallonPerSecond_1.Symbol = "gpsUS"
```
## BarrelPerSecond <!-- NOUN -->
- Display name: barrel per second
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.289810770432106
- Description: 
[v] = a * [SI]
where
[v] is the value in barrel per second
[SI] is the value in SI
a = 1.0/Barrel, i.e., 6.289810770432106
and
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BarrelPerSecond:BarrelPerSecond_1
BarrelPerSecond_1.ConversionFactorB = "6.289810770432106"
BarrelPerSecond_1.Symbol = "bbl/s"
```
## CubicMetrePerMinute <!-- NOUN -->
- Display name: cubic metre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic metre per minute
[SI] is the value in SI
a = Minute / Unit, i.e., 60
and
Minute = 60.0
Unit = 1.0

- Examples: 
``` dwis
CubicMetrePerMinute:CubicMetrePerMinute_1
CubicMetrePerMinute_1.ConversionFactorB = "60"
CubicMetrePerMinute_1.Symbol = "m³/min"
```
## LitrePerMinute <!-- NOUN -->
- Display name: litre per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 60000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per minute
[SI] is the value in SI
a = Minute / Milli, i.e., 60000
and
Minute = 60.0
Milli = 0.001

- Examples: 
``` dwis
LitrePerMinute:LitrePerMinute_1
LitrePerMinute_1.ConversionFactorB = "60000"
LitrePerMinute_1.Symbol = "L/min"
```
## CubicFootPerMinute <!-- NOUN -->
- Display name: cubic foot per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2118.880003289316
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic foot per minute
[SI] is the value in SI
a = Minute / (Foot*Foot*Foot), i.e., 2118.880003289316
and
Minute = 60.0
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CubicFootPerMinute:CubicFootPerMinute_1
CubicFootPerMinute_1.ConversionFactorB = "2118.880003289316"
CubicFootPerMinute_1.Symbol = "ft³/min"
```
## UkGallonPerMinute <!-- NOUN -->
- Display name: UK gallon per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 13198.154897945267
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per minute
[SI] is the value in SI
a = Minute / GallonUK, i.e., 13198.154897945267
and
Minute = 60.0
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon

- Examples: 
``` dwis
UkGallonPerMinute:UkGallonPerMinute_1
UkGallonPerMinute_1.ConversionFactorB = "13198.154897945267"
UkGallonPerMinute_1.Symbol = "gpmUK"
```
## UsGallonPerMinute <!-- NOUN -->
- Display name: US gallon per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 15850.323141488907
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per minute
[SI] is the value in SI
a = Minute / GallonUS, i.e., 15850.323141488907
and
Minute = 60.0
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UsGallonPerMinute:UsGallonPerMinute_1
UsGallonPerMinute_1.ConversionFactorB = "15850.323141488907"
UsGallonPerMinute_1.Symbol = "gpmUS"
```
## BarrelPerMinute <!-- NOUN -->
- Display name: barrel per minute
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 377.3886462259263
- Description: 
[v] = a * [SI]
where
[v] is the value in barrel per minute
[SI] is the value in SI
a = Minute /Barrel, i.e., 377.3886462259263
and
Minute = 60.0
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BarrelPerMinute:BarrelPerMinute_1
BarrelPerMinute_1.ConversionFactorB = "377.3886462259263"
BarrelPerMinute_1.Symbol = "bbl/m"
```
## CubicMetrePerHour <!-- NOUN -->
- Display name: cubic metre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic metre per hour
[SI] is the value in SI
a = Hour/ Unit, i.e., 3600
and
Hour = 60.0 * Minute
Unit = 1.0
Minute = 60.0

- Examples: 
``` dwis
CubicMetrePerHour:CubicMetrePerHour_1
CubicMetrePerHour_1.ConversionFactorB = "3600"
CubicMetrePerHour_1.Symbol = "m³/h"
```
## LitrePerHour <!-- NOUN -->
- Display name: litre per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3600000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per hour
[SI] is the value in SI
a = Hour/ Milli, i.e., 3600000
and
Hour = 60.0 * Minute
Milli = 0.001
Minute = 60.0

- Examples: 
``` dwis
LitrePerHour:LitrePerHour_1
LitrePerHour_1.ConversionFactorB = "3600000"
LitrePerHour_1.Symbol = "L/h"
```
## CubicFootPerHour <!-- NOUN -->
- Display name: cubic foot per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 127132.80019735897
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic foot per hour
[SI] is the value in SI
a = Hour / (Foot*Foot*Foot), i.e., 127132.80019735897
and
Hour = 60.0 * Minute
Foot = 12.0 * Inch
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
CubicFootPerHour:CubicFootPerHour_1
CubicFootPerHour_1.ConversionFactorB = "127132.80019735897"
CubicFootPerHour_1.Symbol = "ft³/h"
```
## UkGallonPerHour <!-- NOUN -->
- Display name: UK gallon per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 791889.293876716
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per hour
[SI] is the value in SI
a = Hour/ GallonUK, i.e., 791889.293876716
and
Hour = 60.0 * Minute
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Minute = 60.0

- Examples: 
``` dwis
UkGallonPerHour:UkGallonPerHour_1
UkGallonPerHour_1.ConversionFactorB = "791889.293876716"
UkGallonPerHour_1.Symbol = "gphUK"
```
## UsGallonPerHour <!-- NOUN -->
- Display name: US gallon per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 951019.3884893344
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per hour
[SI] is the value in SI
a = Hour/ GallonUS, i.e., 951019.3884893344
and
Hour = 60.0 * Minute
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
UsGallonPerHour:UsGallonPerHour_1
UsGallonPerHour_1.ConversionFactorB = "951019.3884893344"
UsGallonPerHour_1.Symbol = "gphUS"
```
## BarrelPerHour <!-- NOUN -->
- Display name: barrel per hour
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 22643.31877355558
- Description: 
[v] = a * [SI]
where
[v] is the value in barrel per hour
[SI] is the value in SI
a = Hour/ Barrel, i.e., 22643.31877355558
and
Hour = 60.0 * Minute
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
Minute = 60.0
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BarrelPerHour:BarrelPerHour_1
BarrelPerHour_1.ConversionFactorB = "22643.31877355558"
BarrelPerHour_1.Symbol = "bbl/h"
```
## CubicMetrePerDay <!-- NOUN -->
- Display name: cubic metre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic metre per day
[SI] is the value in SI
a = Day / Unit, i.e., 86400
and
Day = 24.0 * Hour
Unit = 1.0
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
CubicMetrePerDay:CubicMetrePerDay_1
CubicMetrePerDay_1.ConversionFactorB = "86400"
CubicMetrePerDay_1.Symbol = "m³/d"
```
## MillionCubicMetrePerDay <!-- NOUN -->
- Display name: million cubic metre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0864
- Description: 
[v] = a * [SI]
where
[v] is the value in million cubic metre per day
[SI] is the value in SI
a = Day / Mega, i.e., 0.0864
and
Day = 24.0 * Hour
Mega = 1e6
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MillionCubicMetrePerDay:MillionCubicMetrePerDay_1
MillionCubicMetrePerDay_1.ConversionFactorB = "0.0864"
MillionCubicMetrePerDay_1.Symbol = "Mm³/d"
```
## UkGallonPerDay <!-- NOUN -->
- Display name: UK gallon per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 19005343.053041186
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per day
[SI] is the value in SI
a = Day / GallonUK, i.e., 19005343.053041186
and
Day = 24.0 * Hour
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
UkGallonPerDay:UkGallonPerDay_1
UkGallonPerDay_1.ConversionFactorB = "19005343.053041186"
UkGallonPerDay_1.Symbol = "gpdUK"
```
## UsGallonPerDay <!-- NOUN -->
- Display name: US gallon per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 22824465.323744025
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per day
[SI] is the value in SI
a = Day / GallonUS, i.e., 22824465.323744025
and
Day = 24.0 * Hour
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
UsGallonPerDay:UsGallonPerDay_1
UsGallonPerDay_1.ConversionFactorB = "22824465.323744025"
UsGallonPerDay_1.Symbol = "gpdUS"
```
## MillionUkGallonPerDay <!-- NOUN -->
- Display name: million UK gallon per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 19.005343053041184
- Description: 
[v] = a * [SI]
where
[v] is the value in million UK gallon per day
[SI] is the value in SI
a = Day / (Mega*GallonUK), i.e., 19.005343053041184
and
Day = 24.0 * Hour
Mega = 1e6
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MillionUkGallonPerDay:MillionUkGallonPerDay_1
MillionUkGallonPerDay_1.ConversionFactorB = "19.005343053041184"
MillionUkGallonPerDay_1.Symbol = "MillionUKGallonPerDay"
```
## MillionUsGallonPerDay <!-- NOUN -->
- Display name: million US gallon per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 22.824465323744025
- Description: 
[v] = a * [SI]
where
[v] is the value in million US gallon per day
[SI] is the value in SI
a = Day / (Mega*GallonUS), i.e., 22.824465323744025
and
Day = 24.0 * Hour
Mega = 1e6
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
MillionUsGallonPerDay:MillionUsGallonPerDay_1
MillionUsGallonPerDay_1.ConversionFactorB = "22.824465323744025"
MillionUsGallonPerDay_1.Symbol = "MillionUSGallonPerDay"
```
## LitrePerDay <!-- NOUN -->
- Display name: litre per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86400000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per day
[SI] is the value in SI
a = Day / Milli, i.e., 86400000
and
Day = 24.0 * Hour
Milli = 0.001
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
LitrePerDay:LitrePerDay_1
LitrePerDay_1.ConversionFactorB = "86400000"
LitrePerDay_1.Symbol = "L/d"
```
## MillionLiterPerDay <!-- NOUN -->
- Display name: million liter per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 86.4
- Description: 
[v] = a * [SI]
where
[v] is the value in million liter per day
[SI] is the value in SI
a = Day / (Mega*Milli), i.e., 86.4
and
Day = 24.0 * Hour
Mega = 1e6
Milli = 0.001
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
MillionLiterPerDay:MillionLiterPerDay_1
MillionLiterPerDay_1.ConversionFactorB = "86.4"
MillionLiterPerDay_1.Symbol = "MillionLiterPerDay"
```
## CubicFootPerDay <!-- NOUN -->
- Display name: cubic foot per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3051187.204736615
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic foot per day
[SI] is the value in SI
a = Day / (Foot*Foot*Foot), i.e., 3051187.204736615
and
Day = 24.0 * Hour
Foot = 12.0 * Inch
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
CubicFootPerDay:CubicFootPerDay_1
CubicFootPerDay_1.ConversionFactorB = "3051187.204736615"
CubicFootPerDay_1.Symbol = "ft³/d"
```
## ThousandStandardCubicFootPerDay <!-- NOUN -->
- Display name: thousand standard cubic foot per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3051.187204736615
- Description: 
[v] = a * [SI]
where
[v] is the value in thousand standard cubic foot per day
[SI] is the value in SI
a = Day / (1000.0*Foot*Foot*Foot), i.e., 3051.187204736615
and
Day = 24.0 * Hour
Foot = 12.0 * Inch
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
ThousandStandardCubicFootPerDay:ThousandStandardCubicFootPerDay_1
ThousandStandardCubicFootPerDay_1.ConversionFactorB = "3051.187204736615"
ThousandStandardCubicFootPerDay_1.Symbol = "Mscf/d"
```
## MillionStandardCubicFootPerDay <!-- NOUN -->
- Display name: million standard cubic foot per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 3.0511872047366158
- Description: 
[v] = a * [SI]
where
[v] is the value in million standard cubic foot per day
[SI] is the value in SI
a = Day / (Mega*Foot*Foot*Foot), i.e., 3.0511872047366158
and
Day = 24.0 * Hour
Mega = 1e6
Foot = 12.0 * Inch
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
MillionStandardCubicFootPerDay:MillionStandardCubicFootPerDay_1
MillionStandardCubicFootPerDay_1.ConversionFactorB = "3.0511872047366158"
MillionStandardCubicFootPerDay_1.Symbol = "MMscf/d"
```
## BarrelPerDay <!-- NOUN -->
- Display name: barrel per day
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 543439.6505653339
- Description: 
[v] = a * [SI]
where
[v] is the value in barrel per day
[SI] is the value in SI
a = Day / Barrel, i.e., 543439.6505653339
and
Day = 24.0 * Hour
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
Hour = 60.0 * Minute
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Minute = 60.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
BarrelPerDay:BarrelPerDay_1
BarrelPerDay_1.ConversionFactorB = "543439.6505653339"
BarrelPerDay_1.Symbol = "bbl/d"
```
## CubicMetrePerYear <!-- NOUN -->
- Display name: cubic metre per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 31557600
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic metre per year
[SI] is the value in SI
a = YearJulian/Unit, i.e., 31557600
and
YearJulian = 365.25 * Day
Unit = 1.0
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
CubicMetrePerYear:CubicMetrePerYear_1
CubicMetrePerYear_1.ConversionFactorB = "31557600"
CubicMetrePerYear_1.Symbol = "m³/year"
```
## LitrePerYear <!-- NOUN -->
- Display name: litre per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 31557600000
- Description: 
[v] = a * [SI]
where
[v] is the value in litre per year
[SI] is the value in SI
a = YearJulian/Milli, i.e., 31557600000
and
YearJulian = 365.25 * Day
Milli = 0.001
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
LitrePerYear:LitrePerYear_1
LitrePerYear_1.ConversionFactorB = "31557600000"
LitrePerYear_1.Symbol = "L/year"
```
## CubicFootPerYear <!-- NOUN -->
- Display name: cubic foot per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1114446126.5300486
- Description: 
[v] = a * [SI]
where
[v] is the value in cubic foot per year
[SI] is the value in SI
a = YearJulian / (Foot*Foot*Foot), i.e., 1114446126.5300486
and
YearJulian = 365.25 * Day
Foot = 12.0 * Inch
Day = 24.0 * Hour
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
CubicFootPerYear:CubicFootPerYear_1
CubicFootPerYear_1.ConversionFactorB = "1114446126.5300486"
CubicFootPerYear_1.Symbol = "ft³/year"
```
## UkGallonPerYear <!-- NOUN -->
- Display name: UK gallon per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6941701550.123293
- Description: 
[v] = a * [SI]
where
[v] is the value in UK gallon per year
[SI] is the value in SI
a = YearJulian /GallonUK, i.e., 6941701550.123293
and
YearJulian = 365.25 * Day
GallonUK = 4.54609e-3 reference: https://en.wikipedia.org/wiki/Gallon
Day = 24.0 * Hour
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
UkGallonPerYear:UkGallonPerYear_1
UkGallonPerYear_1.ConversionFactorB = "6941701550.123293"
UkGallonPerYear_1.Symbol = "gpyUK"
```
## UsGallonPerYear <!-- NOUN -->
- Display name: US gallon per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 8336635959.497505
- Description: 
[v] = a * [SI]
where
[v] is the value in US gallon per year
[SI] is the value in SI
a = YearJulian /GallonUS, i.e., 8336635959.497505
and
YearJulian = 365.25 * Day
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Day = 24.0 * Hour
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Hour = 60.0 * Minute
Minute = 60.0

- Examples: 
``` dwis
UsGallonPerYear:UsGallonPerYear_1
UsGallonPerYear_1.ConversionFactorB = "8336635959.497505"
UsGallonPerYear_1.Symbol = "gpyUS"
```
## BarrelPerYear <!-- NOUN -->
- Display name: barrel per year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 198491332.36898822
- Description: 
[v] = a * [SI]
where
[v] is the value in barrel per year
[SI] is the value in SI
a = YearJulian /Barrel, i.e., 198491332.36898822
and
YearJulian = 365.25 * Day
Barrel = 42.0 * GallonUS reference: https://en.wikipedia.org/wiki/Barrel_(unit)
Day = 24.0 * Hour
GallonUS = 231.0 * Inch * Inch * Inch reference: https://en.wikipedia.org/wiki/Gallon
Hour = 60.0 * Minute
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
Minute = 60.0

- Examples: 
``` dwis
BarrelPerYear:BarrelPerYear_1
BarrelPerYear_1.ConversionFactorB = "198491332.36898822"
BarrelPerYear_1.Symbol = "bbl/year"
```
## ReciprocalMetre <!-- NOUN -->
- Display name: reciprocal metre
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
ReciprocalMetre:ReciprocalMetre_1
ReciprocalMetre_1.Symbol = "1/m"
```
## ReciprocalDecimetre <!-- NOUN -->
- Display name: reciprocal decimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal decimetre
[SI] is the value in SI
a = Deci, i.e., 0.1
and
Deci = 0.1

- Examples: 
``` dwis
ReciprocalDecimetre:ReciprocalDecimetre_1
ReciprocalDecimetre_1.ConversionFactorB = "0.1"
ReciprocalDecimetre_1.Symbol = "1/dm"
```
## ReciprocalCentimetre <!-- NOUN -->
- Display name: reciprocal centimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.01
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal centimetre
[SI] is the value in SI
a = Centi, i.e., 0.01
and
Centi = 0.01

- Examples: 
``` dwis
ReciprocalCentimetre:ReciprocalCentimetre_1
ReciprocalCentimetre_1.ConversionFactorB = "0.01"
ReciprocalCentimetre_1.Symbol = "1/cm"
```
## ReciprocalMillimetre <!-- NOUN -->
- Display name: reciprocal millimetre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal millimetre
[SI] is the value in SI
a = Milli, i.e., 0.001
and
Milli = 0.001

- Examples: 
``` dwis
ReciprocalMillimetre:ReciprocalMillimetre_1
ReciprocalMillimetre_1.ConversionFactorB = "0.001"
ReciprocalMillimetre_1.Symbol = "1/mm"
```
## ReciprocalMicrometre <!-- NOUN -->
- Display name: reciprocal micrometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal micrometre
[SI] is the value in SI
a = Micro, i.e., 1E-06
and
Micro = 1e-6

- Examples: 
``` dwis
ReciprocalMicrometre:ReciprocalMicrometre_1
ReciprocalMicrometre_1.ConversionFactorB = "1E-06"
ReciprocalMicrometre_1.Symbol = "1/µm"
```
## ReciprocalNanometre <!-- NOUN -->
- Display name: reciprocal nanometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal nanometre
[SI] is the value in SI
a = Nano, i.e., 1E-09
and
Nano = 1e-9

- Examples: 
``` dwis
ReciprocalNanometre:ReciprocalNanometre_1
ReciprocalNanometre_1.ConversionFactorB = "1E-09"
ReciprocalNanometre_1.Symbol = "1/nm"
```
## ReciprocalAangstroem <!-- NOUN -->
- Display name: reciprocal ångstrøm
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-10
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal ångstrøm
[SI] is the value in SI
a = Angstrom, i.e., 1E-10
and
Angstrom = 1e-10

- Examples: 
``` dwis
ReciprocalAangstroem:ReciprocalAangstroem_1
ReciprocalAangstroem_1.ConversionFactorB = "1E-10"
ReciprocalAangstroem_1.Symbol = "1/Å"
```
## ReciprocalPicometre <!-- NOUN -->
- Display name: reciprocal picometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal picometre
[SI] is the value in SI
a = Pico, i.e., 1E-12
and
Pico = 1e-12

- Examples: 
``` dwis
ReciprocalPicometre:ReciprocalPicometre_1
ReciprocalPicometre_1.ConversionFactorB = "1E-12"
ReciprocalPicometre_1.Symbol = "1/pm"
```
## ReciprocalDecametre <!-- NOUN -->
- Display name: reciprocal decametre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal decametre
[SI] is the value in SI
a = Deca, i.e., 10
and
Deca = 10.0

- Examples: 
``` dwis
ReciprocalDecametre:ReciprocalDecametre_1
ReciprocalDecametre_1.ConversionFactorB = "10"
ReciprocalDecametre_1.Symbol = "1/dam"
```
## ReciprocalHectometre <!-- NOUN -->
- Display name: reciprocal hectometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal hectometre
[SI] is the value in SI
a = Hecto, i.e., 100
and
Hecto = 100.0

- Examples: 
``` dwis
ReciprocalHectometre:ReciprocalHectometre_1
ReciprocalHectometre_1.ConversionFactorB = "100"
ReciprocalHectometre_1.Symbol = "1/hm"
```
## ReciprocalKilometre <!-- NOUN -->
- Display name: reciprocal kilometre
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal kilometre
[SI] is the value in SI
a = Kilo, i.e., 1000
and
Kilo = 1000.0

- Examples: 
``` dwis
ReciprocalKilometre:ReciprocalKilometre_1
ReciprocalKilometre_1.ConversionFactorB = "1000"
ReciprocalKilometre_1.Symbol = "1/km"
```
## ReciprocalAstronomicalUnit <!-- NOUN -->
- Display name: reciprocal astronomical unit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 149597870700
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal astronomical unit
[SI] is the value in SI
a = AstronomicalUnit, i.e., 149597870700
and
AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf

- Examples: 
``` dwis
ReciprocalAstronomicalUnit:ReciprocalAstronomicalUnit_1
ReciprocalAstronomicalUnit_1.ConversionFactorB = "149597870700"
ReciprocalAstronomicalUnit_1.Symbol = "1/au"
```
## ReciprocalLightYear <!-- NOUN -->
- Display name: reciprocal light year
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9460730472580800
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal light year
[SI] is the value in SI
a = LightYear, i.e., 9460730472580800
and
LightYear = 9460730472580800.0 reference: https://www.iau.org/public/themes/measuring/

- Examples: 
``` dwis
ReciprocalLightYear:ReciprocalLightYear_1
ReciprocalLightYear_1.ConversionFactorB = "9460730472580800"
ReciprocalLightYear_1.Symbol = "1/ly"
```
## ReciprocalParsec <!-- NOUN -->
- Display name: reciprocal parsec
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 30856775814913670
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal parsec
[SI] is the value in SI
a = Parsec, i.e., 30856775814913670
and
Parsec = (60.0*60.0*180.0 / System.Math.PI) * AstronomicalUnit reference: https://imagine.gsfc.nasa.gov/features/cosmic/milkyway_info.html
AstronomicalUnit = 149597870700.0 reference: https://www.iau.org/static/resolutions/IAU2012_English.pdf

- Examples: 
``` dwis
ReciprocalParsec:ReciprocalParsec_1
ReciprocalParsec_1.ConversionFactorB = "30856775814913670"
ReciprocalParsec_1.Symbol = "1/pc"
```
## ReciprocalFoot <!-- NOUN -->
- Display name: reciprocal foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.30479999999999996
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal foot
[SI] is the value in SI
a = Foot, i.e., 0.30479999999999996
and
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalFoot:ReciprocalFoot_1
ReciprocalFoot_1.ConversionFactorB = "0.30479999999999996"
ReciprocalFoot_1.Symbol = "1/ft"
```
## ReciprocalUsSurveyFoot <!-- NOUN -->
- Display name: reciprocal US survey foot
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.3048006096012192
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal US survey foot
[SI] is the value in SI
a = USSurveyFoot, i.e., 0.3048006096012192
and
USSurveyFoot = 1200.0 / 3937.0 reference: https://www.nist.gov/pml/us-surveyfoot

- Examples: 
``` dwis
ReciprocalUsSurveyFoot:ReciprocalUsSurveyFoot_1
ReciprocalUsSurveyFoot_1.ConversionFactorB = "0.3048006096012192"
ReciprocalUsSurveyFoot_1.Symbol = "1/ft"
```
## ReciprocalInch <!-- NOUN -->
- Display name: reciprocal inch
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0254
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal inch
[SI] is the value in SI
a = Inch, i.e., 0.0254
and
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalInch:ReciprocalInch_1
ReciprocalInch_1.ConversionFactorB = "0.0254"
ReciprocalInch_1.Symbol = "1/in"
```
## ReciprocalYard <!-- NOUN -->
- Display name: reciprocal yard
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.9143999999999999
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal yard
[SI] is the value in SI
a = Yard, i.e., 0.9143999999999999
and
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalYard:ReciprocalYard_1
ReciprocalYard_1.ConversionFactorB = "0.9143999999999999"
ReciprocalYard_1.Symbol = "1/yd"
```
## ReciprocalFathom <!-- NOUN -->
- Display name: reciprocal fathom
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.8287999999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal fathom
[SI] is the value in SI
a = Fathom, i.e., 1.8287999999999998
and
Fathom = 6.0 * Foot reference: https://www.britannica.com/science/fathom
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalFathom:ReciprocalFathom_1
ReciprocalFathom_1.ConversionFactorB = "1.8287999999999998"
ReciprocalFathom_1.Symbol = "1/fathom"
```
## ReciprocalSurveyorsChain <!-- NOUN -->
- Display name: reciprocal surveyors chain
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 20.116799999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal surveyors chain
[SI] is the value in SI
a = SurveyorChain, i.e., 20.116799999999998
and
SurveyorChain = 22.0 * Yard reference: https://www.britannica.com/technology/surveyors-chain
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalSurveyorsChain:ReciprocalSurveyorsChain_1
ReciprocalSurveyorsChain_1.ConversionFactorB = "20.116799999999998"
ReciprocalSurveyorsChain_1.Symbol = "1/chain"
```
## ReciprocalMile <!-- NOUN -->
- Display name: reciprocal mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1609.3439999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal mile
[SI] is the value in SI
a = Mile, i.e., 1609.3439999999998
and
Mile = 1760.0 * Yard reference: https://dictionary.cambridge.org/dictionary/english/mile
Yard = 3.0 * Foot
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalMile:ReciprocalMile_1
ReciprocalMile_1.ConversionFactorB = "1609.3439999999998"
ReciprocalMile_1.Symbol = "1/mi"
```
## ReciprocalInternationalNauticalMile <!-- NOUN -->
- Display name: reciprocal international nautical mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1852
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal international nautical mile
[SI] is the value in SI
a = InternationalNauticalMile, i.e., 1852
and
InternationalNauticalMile = 1852.0 reference: https://www.merriam-webster.com/dictionary/nautical%20mile

- Examples: 
``` dwis
ReciprocalInternationalNauticalMile:ReciprocalInternationalNauticalMile_1
ReciprocalInternationalNauticalMile_1.ConversionFactorB = "1852"
ReciprocalInternationalNauticalMile_1.Symbol = "1/nmi"
```
## ReciprocalUkNauticalMile <!-- NOUN -->
- Display name: reciprocal UK nautical mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1853.1839999999997
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal UK nautical mile
[SI] is the value in SI
a = UKNauticalMile, i.e., 1853.1839999999997
and
UKNauticalMile = 6080 * Foot reference: https://www.rmg.co.uk/stories/topics/nautical-mile
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalUkNauticalMile:ReciprocalUkNauticalMile_1
ReciprocalUkNauticalMile_1.ConversionFactorB = "1853.1839999999997"
ReciprocalUkNauticalMile_1.Symbol = "1/(UK nmi)"
```
## ReciprocalScandinavianMile <!-- NOUN -->
- Display name: reciprocal scandinavian mile
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal scandinavian mile
[SI] is the value in SI
a = ScandinavianMile, i.e., 10000
and
ScandinavianMile = 10000.0

- Examples: 
``` dwis
ReciprocalScandinavianMile:ReciprocalScandinavianMile_1
ReciprocalScandinavianMile_1.ConversionFactorB = "10000"
ReciprocalScandinavianMile_1.Symbol = "1/mil"
```
## ReciprocalInchPer32 <!-- NOUN -->
- Display name: reciprocal inch per 32
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.00079375
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal inch per 32
[SI] is the value in SI
a = InchPer32, i.e., 0.00079375
and
InchPer32 = Inch / 32.0
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalInchPer32:ReciprocalInchPer32_1
ReciprocalInchPer32_1.ConversionFactorB = "0.00079375"
ReciprocalInchPer32_1.Symbol = "1/in/32"
```
## ReciprocalMil <!-- NOUN -->
- Display name: reciprocal mil
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.54E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal mil
[SI] is the value in SI
a = Mil, i.e., 2.54E-05
and
Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalMil:ReciprocalMil_1
ReciprocalMil_1.ConversionFactorB = "2.54E-05"
ReciprocalMil_1.Symbol = "1/mil"
```
## ReciprocalThou <!-- NOUN -->
- Display name: reciprocal thou
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.54E-05
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal thou
[SI] is the value in SI
a = Thou, i.e., 2.54E-05
and
Thou = Mil
Mil = 0.001 * Inch reference: https://en.wikipedia.org/wiki/Thousandth_of_an_inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalThou:ReciprocalThou_1
ReciprocalThou_1.ConversionFactorB = "2.54E-05"
ReciprocalThou_1.Symbol = "1/thou"
```
## ReciprocalHand <!-- NOUN -->
- Display name: reciprocal hand
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1016
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal hand
[SI] is the value in SI
a = Hand, i.e., 0.1016
and
Hand = 4.0 * Inch reference: https://en.wikipedia.org/wiki/Hand_(unit)
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalHand:ReciprocalHand_1
ReciprocalHand_1.ConversionFactorB = "0.1016"
ReciprocalHand_1.Symbol = "1/hand"
```
## ReciprocalFurlong <!-- NOUN -->
- Display name: reciprocal furlong
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 201.16799999999998
- Description: 
[v] = a * [SI]
where
[v] is the value in reciprocal furlong
[SI] is the value in SI
a = Furlong, i.e., 201.16799999999998
and
Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length

- Examples: 
``` dwis
ReciprocalFurlong:ReciprocalFurlong_1
ReciprocalFurlong_1.ConversionFactorB = "201.16799999999998"
ReciprocalFurlong_1.Symbol = "1/furlong"
```
## Kilogram <!-- NOUN -->
- Display name: kilogram
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Kilogram:Kilogram_1
Kilogram_1.Symbol = "kg"
```
## Hectogram <!-- NOUN -->
- Display name: hectogram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10
- Description: 
[v] = a * [SI]
where
[v] is the value in hectogram
[SI] is the value in SI
a = 1.0/Deci, i.e., 10
and
Deci = 0.1

- Examples: 
``` dwis
Hectogram:Hectogram_1
Hectogram_1.ConversionFactorB = "10"
Hectogram_1.Symbol = "hg"
```
## Decagram <!-- NOUN -->
- Display name: decagram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 100
- Description: 
[v] = a * [SI]
where
[v] is the value in decagram
[SI] is the value in SI
a = 1.0/Centi, i.e., 100
and
Centi = 0.01

- Examples: 
``` dwis
Decagram:Decagram_1
Decagram_1.ConversionFactorB = "100"
Decagram_1.Symbol = "dag"
```
## Gram <!-- NOUN -->
- Display name: gram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000
- Description: 
[v] = a * [SI]
where
[v] is the value in gram
[SI] is the value in SI
a = 1.0/Milli, i.e., 1000
and
Milli = 0.001

- Examples: 
``` dwis
Gram:Gram_1
Gram_1.ConversionFactorB = "1000"
Gram_1.Symbol = "g"
```
## Centigram <!-- NOUN -->
- Display name: centigram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 10000
- Description: 
[v] = a * [SI]
where
[v] is the value in centigram
[SI] is the value in SI
a = 1.0/(0.1*Milli), i.e., 10000
and
Milli = 0.001

- Examples: 
``` dwis
Centigram:Centigram_1
Centigram_1.ConversionFactorB = "10000"
Centigram_1.Symbol = "cg"
```
## Milligram <!-- NOUN -->
- Display name: milligram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000
- Description: 
[v] = a * [SI]
where
[v] is the value in milligram
[SI] is the value in SI
a = 1.0/Micro, i.e., 1000000
and
Micro = 1e-6

- Examples: 
``` dwis
Milligram:Milligram_1
Milligram_1.ConversionFactorB = "1000000"
Milligram_1.Symbol = "mg"
```
## Microgram <!-- NOUN -->
- Display name: microgram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 999999999.9999999
- Description: 
[v] = a * [SI]
where
[v] is the value in microgram
[SI] is the value in SI
a = 1.0/Nano, i.e., 999999999.9999999
and
Nano = 1e-9

- Examples: 
``` dwis
Microgram:Microgram_1
Microgram_1.ConversionFactorB = "999999999.9999999"
Microgram_1.Symbol = "µg"
```
## Nanogram <!-- NOUN -->
- Display name: nanogram
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1000000000000
- Description: 
[v] = a * [SI]
where
[v] is the value in nanogram
[SI] is the value in SI
a = 1.0/Pico, i.e., 1000000000000
and
Pico = 1e-12

- Examples: 
``` dwis
Nanogram:Nanogram_1
Nanogram_1.ConversionFactorB = "1000000000000"
Nanogram_1.Symbol = "ng"
```
## AtomMassUnit <!-- NOUN -->
- Display name: atom mass unit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 6.022140762081123E+26
- Description: 
[v] = a * [SI]
where
[v] is the value in atom mass unit
[SI] is the value in SI
a = 1.0/AtomicMass, i.e., 6.022140762081123E+26
and
AtomicMass = 1.66053906660e-27 reference: https://en.wikipedia.org/wiki/Atomic_mass

- Examples: 
``` dwis
AtomMassUnit:AtomMassUnit_1
AtomMassUnit_1.ConversionFactorB = "6.022140762081123E+26"
AtomMassUnit_1.Symbol = "u"
```
## TonneMetric <!-- NOUN -->
- Display name: tonne metric
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in tonne metric
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
TonneMetric:TonneMetric_1
TonneMetric_1.ConversionFactorB = "0.001"
TonneMetric_1.Symbol = "t"
```
## Kilotonne <!-- NOUN -->
- Display name: kilotonne
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in kilotonne
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Kilotonne:Kilotonne_1
Kilotonne_1.ConversionFactorB = "1E-06"
Kilotonne_1.Symbol = "kt"
```
## Megatonne <!-- NOUN -->
- Display name: megatonne
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in megatonne
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Megatonne:Megatonne_1
Megatonne_1.ConversionFactorB = "1E-09"
Megatonne_1.Symbol = "Mt"
```
## Gigatonne <!-- NOUN -->
- Display name: gigatonne
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-12
- Description: 
[v] = a * [SI]
where
[v] is the value in gigatonne
[SI] is the value in SI
a = 1.0/Tera, i.e., 1E-12
and
Tera = 1e12

- Examples: 
``` dwis
Gigatonne:Gigatonne_1
Gigatonne_1.ConversionFactorB = "1E-12"
Gigatonne_1.Symbol = "Gt"
```
## Pound <!-- NOUN -->
- Display name: pound
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 2.2046226218487757
- Description: 
[v] = a * [SI]
where
[v] is the value in pound
[SI] is the value in SI
a = 1.0/Pound, i.e., 2.2046226218487757
and
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
Pound:Pound_1
Pound_1.ConversionFactorB = "2.2046226218487757"
Pound_1.Symbol = "lb"
```
## Kilopound <!-- NOUN -->
- Display name: kilopound
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.002204622621848776
- Description: 
[v] = a * [SI]
where
[v] is the value in kilopound
[SI] is the value in SI
a = 1.0/(Kilo * Pound), i.e., 0.002204622621848776
and
Kilo = 1000.0
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
Kilopound:Kilopound_1
Kilopound_1.ConversionFactorB = "0.002204622621848776"
Kilopound_1.Symbol = "klb"
```
## Ounce <!-- NOUN -->
- Display name: ounce
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 35.27396194958041
- Description: 
[v] = a * [SI]
where
[v] is the value in ounce
[SI] is the value in SI
a = 1.0/Ounce, i.e., 35.27396194958041
and
Ounce = (1.0 / 16.0) * Pound reference: https://en.wikipedia.org/wiki/Ounce
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
Ounce:Ounce_1
Ounce_1.ConversionFactorB = "35.27396194958041"
Ounce_1.Symbol = "oz"
```
## Stone <!-- NOUN -->
- Display name: stone
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.1574730444177697
- Description: 
[v] = a * [SI]
where
[v] is the value in stone
[SI] is the value in SI
a = 1.0/ Stone, i.e., 0.1574730444177697
and
Stone = 14.0 * Pound reference: https://simple.wikipedia.org/wiki/Stone_(unit)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
Stone:Stone_1
Stone_1.ConversionFactorB = "0.1574730444177697"
Stone_1.Symbol = "st"
```
## TonUk <!-- NOUN -->
- Display name: ton UK
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0009842065276110606
- Description: 
[v] = a * [SI]
where
[v] is the value in ton UK
[SI] is the value in SI
a = 1.0 / TonUK, i.e., 0.0009842065276110606
and
TonUK = 2240.0 * Pound reference: https://en.wikipedia.org/wiki/Ton
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
TonUk:TonUk_1
TonUk_1.ConversionFactorB = "0.0009842065276110606"
TonUk_1.Symbol = "LT"
```
## TonUs <!-- NOUN -->
- Display name: ton US
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001102311310924388
- Description: 
[v] = a * [SI]
where
[v] is the value in ton US
[SI] is the value in SI
a = 1.0/ TonUS, i.e., 0.001102311310924388
and
TonUS = 2000.0 * Pound reference: https://en.wikipedia.org/wiki/Ton
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
TonUs:TonUs_1
TonUs_1.ConversionFactorB = "0.001102311310924388"
TonUs_1.Symbol = "ST"
```
## SolarMass <!-- NOUN -->
- Display name: solar mass
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 5.0291176051105175E-31
- Description: 
[v] = a * [SI]
where
[v] is the value in solar mass
[SI] is the value in SI
a = 1.0/SolarMass, i.e., 5.0291176051105175E-31
and
SolarMass = 332946.0487 * EarthMass reference: https://en.wikipedia.org/wiki/Earth_mass
EarthMass = 5.9722e24 reference: https://en.wikipedia.org/wiki/Earth_mass

- Examples: 
``` dwis
SolarMass:SolarMass_1
SolarMass_1.ConversionFactorB = "5.0291176051105175E-31"
SolarMass_1.Symbol = "M☉"
```
## EarthMass <!-- NOUN -->
- Display name: earth mass
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1.6744248350691536E-25
- Description: 
[v] = a * [SI]
where
[v] is the value in earth mass
[SI] is the value in SI
a = 1.0/EarthMass, i.e., 1.6744248350691536E-25
and
EarthMass = 5.9722e24 reference: https://en.wikipedia.org/wiki/Earth_mass

- Examples: 
``` dwis
EarthMass:EarthMass_1
EarthMass_1.ConversionFactorB = "1.6744248350691536E-25"
EarthMass_1.Symbol = "M🜨"
```
## Grain <!-- NOUN -->
- Display name: grain
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 15432.358352941428
- Description: 
[v] = a * [SI]
where
[v] is the value in grain
[SI] is the value in SI
a = 1.0/Grain, i.e., 15432.358352941428
and
Grain = (1.0 / 7000.0) * Pound reference: https://en.wikipedia.org/wiki/Grain_(unit)
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
Grain:Grain_1
Grain_1.ConversionFactorB = "15432.358352941428"
Grain_1.Symbol = "gr"
```
## HundredWeights <!-- NOUN -->
- Display name: hundred weights
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.022046226218487758
- Description: 
[v] = a * [SI]
where
[v] is the value in hundred weights
[SI] is the value in SI
a = 1.0/(100.0*Pound), i.e., 0.022046226218487758
and
Pound = 0.45359237 reference: https://en.wikipedia.org/wiki/Pound_(mass)

- Examples: 
``` dwis
HundredWeights:HundredWeights_1
HundredWeights_1.ConversionFactorB = "0.022046226218487758"
HundredWeights_1.Symbol = "cwt"
```
## Joule <!-- NOUN -->
- Display name: joule
- Parent class: Unit
- Specialization: 
- Description: 
No conversion necessary as the unit choice is SI

- Examples: 
``` dwis
Joule:Joule_1
Joule_1.Symbol = "J"
```
## Kilojoule <!-- NOUN -->
- Display name: kilojoule
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.001
- Description: 
[v] = a * [SI]
where
[v] is the value in kilojoule
[SI] is the value in SI
a = 1.0/Kilo, i.e., 0.001
and
Kilo = 1000.0

- Examples: 
``` dwis
Kilojoule:Kilojoule_1
Kilojoule_1.ConversionFactorB = "0.001"
Kilojoule_1.Symbol = "kJ"
```
## Megajoule <!-- NOUN -->
- Display name: megajoule
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-06
- Description: 
[v] = a * [SI]
where
[v] is the value in megajoule
[SI] is the value in SI
a = 1.0/Mega, i.e., 1E-06
and
Mega = 1e6

- Examples: 
``` dwis
Megajoule:Megajoule_1
Megajoule_1.ConversionFactorB = "1E-06"
Megajoule_1.Symbol = "MJ"
```
## Gigajoule <!-- NOUN -->
- Display name: gigajoule
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 1E-09
- Description: 
[v] = a * [SI]
where
[v] is the value in gigajoule
[SI] is the value in SI
a = 1.0/Giga, i.e., 1E-09
and
Giga = 1e9

- Examples: 
``` dwis
Gigajoule:Gigajoule_1
Gigajoule_1.ConversionFactorB = "1E-09"
Gigajoule_1.Symbol = "GJ"
```
## Calorie <!-- NOUN -->
- Display name: calorie
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.2390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in calorie
[SI] is the value in SI
a = 1.0/Calorie, i.e., 0.2390057361376673
and
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
Calorie:Calorie_1
Calorie_1.ConversionFactorB = "0.2390057361376673"
Calorie_1.Symbol = "cal"
```
## Kilocalorie <!-- NOUN -->
- Display name: kilocalorie
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0002390057361376673
- Description: 
[v] = a * [SI]
where
[v] is the value in kilocalorie
[SI] is the value in SI
a = 1.0/(Kilo * Calorie), i.e., 0.0002390057361376673
and
Kilo = 1000.0
Calorie = 4.184 reference: https://en.wikipedia.org/wiki/Calorie

- Examples: 
``` dwis
Kilocalorie:Kilocalorie_1
Kilocalorie_1.ConversionFactorB = "0.0002390057361376673"
Kilocalorie_1.Symbol = "Cal"
```
## BritishThermalUnit <!-- NOUN -->
- Display name: british thermal unit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 0.0009484516526770049
- Description: 
[v] = a * [SI]
where
[v] is the value in british thermal unit
[SI] is the value in SI
a = 1.0/BTU, i.e., 0.0009484516526770049
and
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
BritishThermalUnit:BritishThermalUnit_1
BritishThermalUnit_1.ConversionFactorB = "0.0009484516526770049"
BritishThermalUnit_1.Symbol = "BTU"
```
## KiloBritishThermalUnit <!-- NOUN -->
- Display name: kilo british thermal unit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.484516526770048E-07
- Description: 
[v] = a * [SI]
where
[v] is the value in kilo british thermal unit
[SI] is the value in SI
a = 1.0/(Kilo * BTU), i.e., 9.484516526770048E-07
and
Kilo = 1000.0
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
KiloBritishThermalUnit:KiloBritishThermalUnit_1
KiloBritishThermalUnit_1.ConversionFactorB = "9.484516526770048E-07"
KiloBritishThermalUnit_1.Symbol = "kBTU"
```
## MegaBritishThermalUnit <!-- NOUN -->
- Display name: mega british thermal unit
- Parent class: Unit
- Specialization: 
  - ConversionFactorB = 9.48451652677005E-10
- Description: 
[v] = a * [SI]
where
[v] is the value in mega british thermal unit
[SI] is the value in SI
a = 1.0/(Mega * BTU), i.e., 9.48451652677005E-10
and
Mega = 1e6
BTU = 1054.35 reference: https://en.wikipedia.org/wiki/British_thermal_unit

- Examples: 
``` dwis
MegaBritishThermalUnit:MegaBritishThermalUnit_1
MegaBritishThermalUnit_1.ConversionFactorB = "9.48451652677005E-10"
MegaBritishThermalUnit_1.Symbol = "MMBTU"
```
