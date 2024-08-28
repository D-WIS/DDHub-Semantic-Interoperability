- Description: quantities and units

# NOUNS
## MeasurableQuantity <!-- NOUN -->
- Display name: MeasurableQuantity
- Parent class: DWISNoun
- Attributes:
  - MeaningfulPrecision
    - Type: double
    - Description: 
- Specialization:
- Description: Represents a quantity that allows meaningful comparisons. 
Are related by a Quantity via the "IsObservableFrom" relation. 
Context dependent: for example, Fluid density and Equivalent Circulating Density are represented as two different "Measurable quantities", although they both refer to the same base SI quantities. 
- Examples:
## MeasurableQuantityUnitAssociation <!-- NOUN -->
- Display name: MeasurableQuantityUnitAssociation
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: 
- Examples:
## Quantity <!-- NOUN -->
- Display name: Quantity
- Parent class: DWISNoun
- Attributes:
  - L
    - Type: double
    - Description: Length exponent. 
SI Unit: meter (m)
  - M
    - Type: double
    - Description: Mass exponent. 
SI Unit: Kilogram (kg)
  - T
    - Type: double
    - Description: Time exponent.
SI Unit: Second (s)
  - I
    - Type: double
    - Description: Electric current exponent. 
SI Unit: Ampere (A)
  - ThT
    - Type: double
    - Description: Thermodynamic temperature exponent.
SI Unit: Kelvin (K)
  - N
    - Type: double
    - Description: Amount of substance exponent.
SI Unit: Mole (N)
  - J
    - Type: double
    - Description: Luminous intensity exponent. 
SI Unit: Candela (cd)
  - Theta
    - Type: double
    - Description: plane angle exponent.
SI Unit: radian (rad)
  - Omega
    - Type: double
    - Description: solid angle exponent.
SI Unit: steradian (sr)
  - SIUnit
    - Type: string
    - Description: 
- Specialization:
  - L = 0
  - T = 0
  - M = 0
  - I = 0
  - ThT = 0
  - N = 0
  - J = 0
  - Theta = 0
  - Omega = 0
- Description: 
- Examples:
## Unit <!-- NOUN -->
- Display name: Unit
- Parent class: DWISNoun
- Attributes:
  - Symbol
    - Type: string
    - Description: 
  - ConversionFactorA
    - Type: double
    - Description: Unit conversion from SI unit is performed as:
ConvertedValue = ConversionFactorA + SIValue * ConversionFactorB
  - ConversionFactorB
    - Type: double
    - Description: Unit conversion from SI unit is performed as:
ConvertedValue = ConversionFactorA + SIValue * ConversionFactorB
- Specialization:
- Description: 
- Examples:
## UnitSystem <!-- NOUN -->
- Display name: UnitSystem
- Parent class: DWISNoun
- Attributes:
- Specialization:
- Description: A set of associations between measurable quantities and units
- Examples:


# VERBS
## AssociatesMeasurableQuantity <!-- VERB -->
- Display name: AssociatesMeasurableQuantity
- Parent verb: DWISVerb
- Subject class: MeasurableQuantityUnitAssociation
- Object class: MeasurableQuantity
- Description: 
- Examples: 
## AssociatesUnit <!-- VERB -->
- Display name: AssociatesUnit
- Parent verb: DWISVerb
- Subject class: MeasurableQuantityUnitAssociation
- Object class: Unit
- Description: 
- Examples: 
## HasUnitAssociation <!-- VERB -->
- Display name: HasUnitAssociation
- Parent verb: DWISVerb
- Subject class: UnitSystem
- Object class: MeasurableQuantityUnitAssociation
- Description: 
- Examples: 
## IsObservableFrom <!-- VERB -->
- Display name: IsObservableFrom
- Parent verb: DWISVerb
- Subject class: DWISNoun
- Object class: DWISNoun
- Description: 
- Examples: 
## IsOfBaseQuantity <!-- VERB -->
- Display name: IsOfBaseQuantity
- Parent verb: DWISVerb
- Subject class: MeasurableQuantity
- Object class: Quantity
- Description: 
- Examples: 
## IsOfMeasurableQuantity <!-- VERB -->
- Display name: IsOfMeasurableQuantity
- Parent verb: DWISVerb
- Subject class: DrillingSignal
- Object class: MeasurableQuantity
- Description: 
- Examples: 
## IsUnitForQuantity <!-- VERB -->
- Display name: IsUnitForQuantity
- Parent verb: DWISVerb
- Subject class: Unit
- Object class: Quantity
- Description: 
- Examples: 
## HasSIUnit <!-- VERB -->
- Display name: HasSIUnit
- Parent verb: DWISVerb
- Subject class: Quantity
- Object class: Unit
- Description: 
- Examples: 
## HasUnitOfMeasure <!-- VERB -->
- Display name: HasUnitOfMeasure
- Parent verb: DWISVerb
- Subject class: DrillingSignal
- Object class: Unit
- Description: 
- Examples: 
