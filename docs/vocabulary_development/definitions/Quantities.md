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
## BitTorqueQuantity <!-- NOUN -->
- Display name: BitTorqueQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## BlockAccelerationQuantity <!-- NOUN -->
- Display name: BlockAccelerationQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## BlockPositionQuantity <!-- NOUN -->
- Display name: BlockPositionQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## BlockVelocityQuantity <!-- NOUN -->
- Display name: BlockVelocityQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## DepthQuantity <!-- NOUN -->
- Display name: DepthQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## DownholePressureQuantity <!-- NOUN -->
- Display name: DownholePressureQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## EMWQuantity <!-- NOUN -->
- Display name: EMWQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## FlowRateQuantity <!-- NOUN -->
- Display name: FlowRateQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## FluidDensityInQuantity <!-- NOUN -->
- Display name: FluidDensityInQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## FluidTemperatureInQuantity <!-- NOUN -->
- Display name: FluidTemperatureInQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## FormationPorosityQuantity <!-- NOUN -->
- Display name: FormationPorosityQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## HookloadQuantity <!-- NOUN -->
- Display name: HookloadQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## PumpRateQuantity <!-- NOUN -->
- Display name: PumpRateQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## Resistivity <!-- NOUN -->
- Display name: Resistivity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## RockDensityQuantity <!-- NOUN -->
- Display name: RockDensityQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## SPPQuantity <!-- NOUN -->
- Display name: SPPQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## SurfaceRPMQuantity <!-- NOUN -->
- Display name: SurfaceRPMQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## SurfaceTorqueQuantity <!-- NOUN -->
- Display name: SurfaceTorqueQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## TopOfStringForceQuantity <!-- NOUN -->
- Display name: TopOfStringForceQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## TVDQuantity <!-- NOUN -->
- Display name: TVDQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## WOBQuantity <!-- NOUN -->
- Display name: WOBQuantity
- Parent class: MeasurableQuantity
- Attributes:
- Specialization:
- Description: 
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
    - Type: int
    - Description: Length exponent. 
SI Unit: meter (m)
  - M
    - Type: int
    - Description: Mass exponent. 
SI Unit: Kilogram (kg)
  - T
    - Type: int
    - Description: Time exponent.
SI Unit: Second (s)
  - I
    - Type: int
    - Description: Electric current exponent. 
SI Unit: Ampere (A)
  - ThT
    - Type: int
    - Description: Thermodynamic temperature exponent.
SI Unit: Kelvin (K)
  - N
    - Type: int
    - Description: Amount of substance exponent.
SI Unit: Mole (N)
  - J
    - Type: int
    - Description: Luminous intensity exponent. 
SI Unit: Candela (cd)
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
- Description: 
- Examples:
## AccelerationQuantity <!-- NOUN -->
- Display name: AccelerationQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 1
  - T = -2
  - Name = Acceleration quantity
- Description: 
- Examples:
## AreaQuantity <!-- NOUN -->
- Display name: AreaQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 2
- Description: 
- Examples:
## ElectricResistivityQuantity <!-- NOUN -->
- Display name: ElectricResistivityQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 3
  - M = 1
  - T = -3
  - I = -2
- Description: 
- Examples:
## ForceQuantity <!-- NOUN -->
- Display name: ForceQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 1
  - M = 1
  - T = -2
- Description: 
- Examples:
## FrequencyQuantity <!-- NOUN -->
- Display name: FrequencyQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - T = -1
- Description: 
- Examples:
## LengthQuantity <!-- NOUN -->
- Display name: LengthQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 1
- Description: 
- Examples:
## MassDensityQuantity <!-- NOUN -->
- Display name: MassDensityQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 3
  - M = 1
- Description: 
- Examples:
## MassQuantity <!-- NOUN -->
- Display name: MassQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - M = 1
- Description: 
- Examples:
## MassRate <!-- NOUN -->
- Display name: MassRate
- Parent class: Quantity
- Attributes:
- Specialization:
  - M = 1
  - T = -1
- Description: 
- Examples:
## PowerQuantity <!-- NOUN -->
- Display name: PowerQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 2
  - M = 1
  - T = -3
- Description: 
- Examples:
## PressureQuantity <!-- NOUN -->
- Display name: PressureQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = -1
  - M = 1
  - T = 2
- Description: 
- Examples:
## ProportionQuantity <!-- NOUN -->
- Display name: ProportionQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
- Description: 
- Examples:
## TemperatureQuantity <!-- NOUN -->
- Display name: TemperatureQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - ThT = 1
- Description: 
- Examples:
## TorqueQuantity <!-- NOUN -->
- Display name: TorqueQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 2
  - M = 1
  - T = -2
- Description: 
- Examples:
## VelocityQuantity <!-- NOUN -->
- Display name: VelocityQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 1
  - T = -1
- Description: 
- Examples:
## VolumeQuantity <!-- NOUN -->
- Display name: VolumeQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 3
- Description: 
- Examples:
## VolumetricRateQuantity <!-- NOUN -->
- Display name: VolumetricRateQuantity
- Parent class: Quantity
- Attributes:
- Specialization:
  - L = 3
  - T = -1
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
- Subject class: DWISNoun
- Object class: Quantity
- Description: 
- Examples: 
## IsOfMeasurableQuantity <!-- VERB -->
- Display name: IsOfMeasurableQuantity
- Parent verb: DWISVerb
- Subject class: DWISNoun
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
