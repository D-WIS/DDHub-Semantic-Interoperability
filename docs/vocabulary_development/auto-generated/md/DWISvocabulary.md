# Definition sets
## ADCS<!-- DEFINITION SET HEADER -->
- Description: this category refers to the various functions an ADCS implements. It is to be used for the ADCS capability description.
## DataDependencies<!-- DEFINITION SET HEADER -->
- Description: this part covers the physical dependencies between signals.
## DataFlow<!-- DEFINITION SET HEADER -->
- Description: this category refers to the data processing. It should probably be renamed accordingly. It should define and organize the different types of processing encountered during drilling operations. A Thursday session was devoted to those items. Note that in the current version, control flow is also included: a controller is seen as a special type of processing unit, that generates commands based on measurements and set-points. This can of course be modified if deemed necessary. Note also that transmission is included there as well. A telemetry system is seen as a processing unit that only duplicates a signal, and a delay is associated to the duplication process. While this is a useful way of looking at telemetry, it is probably not intuitive enough.
## DataProviders<!-- DEFINITION SET HEADER -->
- Description: description of the different actors involved in the well construction process
## DataTransmission<!-- DEFINITION SET HEADER -->
- Description: this category contains all nouns and verbs used to describe the rig's telemetry, for each signal. Downhole telemetry has focus.
## DataValidity<!-- DEFINITION SET HEADER -->
- Description: this category contains all the nouns and verbs used to described the validity of signals. Some signals are for example only valid while off-slips, downhole signals transmitted via mud-pulse telemetry require circulation.
## DrillingDataSemantics<!-- DEFINITION SET HEADER -->
- Description: this is the part associated to the signal's description themselves. Dimensionality, data type are the main items to be described.
## DrillingEquipment<!-- DEFINITION SET HEADER -->
- Description: in this category fall all the standard equipment encountered on a drilling rig. Note that the goal of the vocabulary is not to provide a detailed description of the rig. Therefore we only consider nouns that can help providing a signal context.
## DWISSemantics<!-- DEFINITION SET HEADER -->
- Description: definitions of the base noun and verb. All verbs and nouns in the DWIS vocabulary are children of those.
## EndPoints<!-- DEFINITION SET HEADER -->
- Description: this is the part associated to the description of external end-points.
## Hydraulics<!-- DEFINITION SET HEADER -->
- Description: this part refers to the hydraulic circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.
## MechanicalModel<!-- DEFINITION SET HEADER -->
- Description: specialized vocabulary for the modelling of the drilling mechanics. Covers in particular the so-called torque and drag models
## Mechanics<!-- DEFINITION SET HEADER -->
- Description: this part refers to the mechanical circuit, and should only contain the "abstract" or conceptual part of the vocabulary. Additional nouns coming from the drilling equipment category will be used when constructing the semantic graphs.
## Model<!-- DEFINITION SET HEADER -->
- Description: high level and generic vocabulary for mathematical models of the drilling process
## PhysicalLocation<!-- DEFINITION SET HEADER -->
- Description: this category contains the vocabulary necessary to specify the location of various items on a rig. Coordinate systems are the main element here.
## Quantities<!-- DEFINITION SET HEADER -->
- Description: quantities and units
## TimeManagement<!-- DEFINITION SET HEADER -->
- Description: this category referes mostly to the description of the various clocks that can be encoutered on a rig, and their synchronization status with respect to each other.
## Uncertainty<!-- DEFINITION SET HEADER -->
- Description: this category contains the nouns and verbs required to describe the various types of uncertainty attached to drilling signals. Uncertainties can be related to sensor characteristics, calculations, model calibration, data assimilation.
# Nouns
## ActivableFunction <!-- NOUN -->
- Display name: Activable Function
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## RunnableFunction <!-- NOUN -->
- Display name: Runnable Function
- Parent class: [ActivableFunction](#ActivableFunction)
- Attributes:
  - MainFunction
    - Type: string
    - Description: 
  - AuxiliaryFunction
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ProtectionFunction <!-- NOUN -->
- Display name: Protection Function
- Parent class: [ActivableFunction](#ActivableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## FDIRFunction <!-- NOUN -->
- Display name: FDIR Function
- Parent class: [ProtectionFunction](#ProtectionFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## SOEFunction <!-- NOUN -->
- Display name: SOE Function
- Parent class: [ProtectionFunction](#ProtectionFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ControllerFunction <!-- NOUN -->
- Display name: Controller Function
- Parent class: [RunnableFunction](#RunnableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## ProcedureFunction <!-- NOUN -->
- Display name: Procedure Function
- Parent class: [RunnableFunction](#RunnableFunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: ADCS
## DataFlowNode <!-- NOUN -->
- Display name: DataFlowNode
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Plan <!-- NOUN -->
- Display name: Plan
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## OperationalPlan <!-- NOUN -->
- Display name: OperationalPlan
- Parent class: [Plan](#Plan)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## DrillingProgram <!-- NOUN -->
- Display name: DrillingProgram
- Parent class: [Plan](#Plan)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## RigActionPlan <!-- NOUN -->
- Display name: RigActionPlan
- Parent class: [Plan](#Plan)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ComputedState <!-- NOUN -->
- Display name: ComputedState
- Parent class: [ComputationUnit](#ComputationUnit)
- Attributes:
- Specialization:
- Description: A state represents the current configuation of a system.
- Examples:
- Definition set: DataFlow
## ProceduralState <!-- NOUN -->
- Display name: ComputedProceduralState
- Parent class: [ComputedState](#ComputedState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ProcessState <!-- NOUN -->
- Display name: ComputedProcessState
- Parent class: [ComputedState](#ComputedState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## PhysicalState <!-- NOUN -->
- Display name: ComputedPhysicalState
- Parent class: [ComputedState](#ComputedState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ComputationUnit <!-- NOUN -->
- Display name: ComputationUnit
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: Denotes a complex computation unit, typically based on advanced numerical modeling
- Examples:
- Definition set: DataFlow
## Advisor <!-- NOUN -->
- Display name: Advisor
- Parent class: [ComputationUnit](#ComputationUnit)
- Attributes:
  - AdviceType
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Simulator <!-- NOUN -->
- Display name: Simulator
- Parent class: [ComputationUnit](#ComputationUnit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Controller <!-- NOUN -->
- Display name: Controller
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ControlSystem <!-- NOUN -->
- Display name: ControlSystem
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## DrawWorksControlSystem <!-- NOUN -->
- Display name: DrawWorksControlSystem
- Parent class: [ControlSystem](#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MudPumpsControlSystem <!-- NOUN -->
- Display name: MudPumpsControlSystem
- Parent class: [ControlSystem](#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TopDriveControlSystem <!-- NOUN -->
- Display name: TopDriveControlSystem
- Parent class: [ControlSystem](#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## BOPControlSystem <!-- NOUN -->
- Display name: BOPControlSystem
- Parent class: [ControlSystem](#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## RigChokeControlSystem <!-- NOUN -->
- Display name: RigChokeControlSystem
- Parent class: [ControlSystem](#ControlSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MeasurementDevice <!-- NOUN -->
- Display name: MeasurementDevice
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: Denotes a physical sensor
- Examples:
- Definition set: DataFlow
## Transformation <!-- NOUN -->
- Display name: Transformation
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: Represents a transformation applied to some signals that produces other signals
- Examples:
- Definition set: DataFlow
## DirectTransformation <!-- NOUN -->
- Display name: DirectTransformation
- Parent class: [Transformation](#Transformation)
- Attributes:
- Specialization:
- Description: Direct transformations are performed using only the current value of their inputs, time is not involved
- Examples:
- Definition set: DataFlow
## Aggregation <!-- NOUN -->
- Display name: Aggregation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ForceFromLoadPinsTransformation <!-- NOUN -->
- Display name: ForceFromLoadPinsTransformation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## ForceToLoadTransformation <!-- NOUN -->
- Display name: ForceToLoadTransformation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MeasuredDepthToTrueVerticalDepthTransformation <!-- NOUN -->
- Display name: MeasuredDepthToTrueVerticalDepthTransformation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MeasuredDepthTranslation <!-- NOUN -->
- Display name: MeasuredDepthTranslation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## PressureToEquivalentDensityTransformation <!-- NOUN -->
- Display name: PressureToEquivalentDensityTransformation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## PressureToForceTransformation <!-- NOUN -->
- Display name: PressureToForceTransformation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TorqueToForceTransformation <!-- NOUN -->
- Display name: TorqueToForceTransformation
- Parent class: [DirectTransformation](#DirectTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## SignalProcessingUnit <!-- NOUN -->
- Display name: SignalProcessingUnit
- Parent class: [Transformation](#Transformation)
- Attributes:
- Specialization:
- Description: Represent any signal processing applied prior to the distribution of the considered signal. Signal processing refers to e.g. noise removal, filtering,..
- Examples:
- Definition set: DataFlow
## Filter <!-- NOUN -->
- Display name: Filter
- Parent class: [SignalProcessingUnit](#SignalProcessingUnit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## BandPassFilter <!-- NOUN -->
- Display name: BandPassFilter
- Parent class: [Filter](#Filter)
- Attributes:
  - MinFrequency
    - Type: double
    - Description: 
  - MaxFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## HighPassFilter <!-- NOUN -->
- Display name: HighPassFilter
- Parent class: [Filter](#Filter)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## LowPassFilter <!-- NOUN -->
- Display name: LowPassFilter
- Parent class: [Filter](#Filter)
- Attributes:
  - CutOffFrequency
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## MovingAverage <!-- NOUN -->
- Display name: MovingAverage
- Parent class: [Filter](#Filter)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## NumberOfSampleMovingAverage <!-- NOUN -->
- Display name: NumberOfSampleMovingAverage
- Parent class: [MovingAverage](#MovingAverage)
- Attributes:
  - NumberOfSamples
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TimeWindowMovingAverage <!-- NOUN -->
- Display name: TimeWindowMovingAverage
- Parent class: [MovingAverage](#MovingAverage)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TimeBasedTransformation <!-- NOUN -->
- Display name: TimeBasedTransformation
- Parent class: [Transformation](#Transformation)
- Attributes:
- Specialization:
- Description: Transformations that apply only to time series: time derivations, time integration, averaging...
- Examples:
- Definition set: DataFlow
## Buffering <!-- NOUN -->
- Display name: Buffering
- Parent class: [TimeBasedTransformation](#TimeBasedTransformation)
- Attributes:
  - BufferingInterval
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Derivation <!-- NOUN -->
- Display name: Derivation
- Parent class: [TimeBasedTransformation](#TimeBasedTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Integration <!-- NOUN -->
- Display name: Integration
- Parent class: [TimeBasedTransformation](#TimeBasedTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## RangeExtraction <!-- NOUN -->
- Display name: RangeExtraction
- Parent class: [TimeBasedTransformation](#TimeBasedTransformation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## NumberOfItemsRangeExtraction <!-- NOUN -->
- Display name: NumberOfItemsRangeExtraction
- Parent class: [RangeExtraction](#RangeExtraction)
- Attributes:
  - NumberOfItems
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TimeWindowRangeExtraction <!-- NOUN -->
- Display name: TimeWindowRangeExtraction
- Parent class: [RangeExtraction](#RangeExtraction)
- Attributes:
  - TimeWindow
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## Resampling <!-- NOUN -->
- Display name: Resampling
- Parent class: [TimeBasedTransformation](#TimeBasedTransformation)
- Attributes:
  - ResamplingRate
    - Type: double
    - Description: 
  - ResamplingDelay
    - Type: double
    - Description: 
  - Validity
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## TransmissionLine <!-- NOUN -->
- Display name: TransmissionLine
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## UserInterface <!-- NOUN -->
- Display name: UserInterface
- Parent class: [DataFlowNode](#DataFlowNode)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataFlow
## DataProvider <!-- NOUN -->
- Display name: DataProvider
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A data provider is any sources for data
- Examples:
- Definition set: DataProviders
## OperatingCompany <!-- NOUN -->
- Display name: OperatingCompany
- Parent class: [DataProvider](#DataProvider)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: An operating company is an entity that holds the rights to explore, develop, and produce hydrocarbon resources from a particular oil or gas field or lease
- Examples:
- Definition set: DataProviders
## ServiceCompany <!-- NOUN -->
- Display name: ServiceCompany
- Parent class: [DataProvider](#DataProvider)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A service company is an entity that provides services during the well construction.
- Examples:
- Definition set: DataProviders
## DirectionalServiceCompany <!-- NOUN -->
- Display name: DirectionalServiceCompany
- Parent class: [ServiceCompany](#ServiceCompany)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A directional service company is an entity that provides services for downhole directional drilling and downhole measurements.
- Examples:
- Definition set: DataProviders
## DrillingFluidProvider <!-- NOUN -->
- Display name: DrillingFluidProvider
- Parent class: [ServiceCompany](#ServiceCompany)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A drilling fluid provider is a company that provides and maintains the drilling fluids during well construction.
- Examples:
- Definition set: DataProviders
## LoggingServiceCompany <!-- NOUN -->
- Display name: LoggingServiceCompany
- Parent class: [ServiceCompany](#ServiceCompany)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A logging service company is an entity that gathers measured information during well construction.
- Examples:
- Definition set: DataProviders
## CementingServiceCompany <!-- NOUN -->
- Display name: CementingServiceCompany
- Parent class: [ServiceCompany](#ServiceCompany)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataProviders
## DataAnalysisServiceCompany <!-- NOUN -->
- Display name: DataAnalysisServiceCompany
- Parent class: [ServiceCompany](#ServiceCompany)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A data analysis service company is an entity that analyses measured data and provide new information from these measurements.
- Examples:
- Definition set: DataProviders
## DrillingContractor <!-- NOUN -->
- Display name: DrillingContractor
- Parent class: [DataProvider](#DataProvider)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: DataProviders
## DWISInternalService <!-- NOUN -->
- Display name: DWISInternalService
- Parent class: [DataProvider](#DataProvider)
- Attributes:
  - ProviderName
    - Type: string
    - Description: 
- Specialization:
- Description: A DWIS internal service is an internal component of the DWIS infrastructure that generates information that can be used by any systems connected to the DWIS infrastructure.
- Examples:
- Definition set: DataProviders
## Telemetry <!-- NOUN -->
- Display name: Telemetry
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - NumberOfRepeaters
    - Type: int
    - Description: 
  - DistanceBetweenRepeaters
    - Type: double
    - Description: 
  - AverageDelayByRepeater
    - Type: double
    - Description: 
- Specialization:
- Description: Technology used for transferring the data from its main origin.
- Examples:
- Definition set: DataTransmission
## DownHoleTelemetry <!-- NOUN -->
- Display name: DownHoleTelemetry
- Parent class: [Telemetry](#Telemetry)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataTransmission
## MudPulseTelemetry <!-- NOUN -->
- Display name: MudPulseTelemetry
- Parent class: [DownHoleTelemetry](#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via pressure pulses sent trough the drilling fluid.
- Examples:
- Definition set: DataTransmission
## ElectromagneticTelemetry <!-- NOUN -->
- Display name: ElectromagneticTelemetry
- Parent class: [DownHoleTelemetry](#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electromagnetic waves sent trough the drilling formation.
- Examples:
- Definition set: DataTransmission
## WiredPipeTelemetry <!-- NOUN -->
- Display name: WiredPipeTelemetry
- Parent class: [DownHoleTelemetry](#DownHoleTelemetry)
- Attributes:
- Specialization:
- Description: A method that allows transfer of downhole data to the surface via electrical connections through the drill string.
- Examples:
- Definition set: DataTransmission
## TopSideTelemetry <!-- NOUN -->
- Display name: TopSideTelemetry
- Parent class: [Telemetry](#Telemetry)
- Attributes:
- Specialization:
- Description: Method that allows transfer of data from surface systems.
- Examples:
- Definition set: DataTransmission
## ValidityCondition <!-- NOUN -->
- Display name: ValidityCondition
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## ConnectedCondition <!-- NOUN -->
- Display name: ConnectedCondition
- Parent class: [ValidityCondition](#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## EQ <!-- NOUN -->
- Display name: EQ
- Parent class: [ValidityCondition](#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## GT <!-- NOUN -->
- Display name: GT
- Parent class: [ValidityCondition](#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## LT <!-- NOUN -->
- Display name: LT
- Parent class: [ValidityCondition](#ValidityCondition)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DataValidity
## DrillingDataPoint <!-- NOUN -->
- Display name: DrillingDataPoint
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - IsValid
    - Type: bool
    - Description: 
- Specialization:
- Description: Main type of DDHub data. Represents a drilling signal.
- Examples:
- Definition set: DrillingDataSemantics
## ActiveVolume <!-- NOUN -->
- Display name: ActiveVolume
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BitDepth <!-- NOUN -->
- Display name: BitDepth
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: Curvilinear abscissa of the bottom of the bit, in the reference frame centered in the wellbore.
- Examples:
- Definition set: DrillingDataSemantics
## DensityIn <!-- NOUN -->
- Display name: DensityIn
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DensityOut <!-- NOUN -->
- Display name: DensityOut
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeECD <!-- NOUN -->
- Display name: DownholeECD
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholePressure <!-- NOUN -->
- Display name: DownholePressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeRPM <!-- NOUN -->
- Display name: DownholeRPM
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeTemperature <!-- NOUN -->
- Display name: DownholeTemperature
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DownholeTorque <!-- NOUN -->
- Display name: DownholeTorque
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FlowRateIn <!-- NOUN -->
- Display name: FlowRateIn
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FlowRateOut <!-- NOUN -->
- Display name: FlowRateOut
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HoleDepth <!-- NOUN -->
- Display name: HoleDepth
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookLoad <!-- NOUN -->
- Display name: HookLoad
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookPosition <!-- NOUN -->
- Display name: HookPosition
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## HookVelocity <!-- NOUN -->
- Display name: HookVelocity
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PumpRate <!-- NOUN -->
- Display name: PumpRate
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ROP <!-- NOUN -->
- Display name: ROP
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SPP <!-- NOUN -->
- Display name: SPP
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SurfaceRPM <!-- NOUN -->
- Display name: SurfaceRPM
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SurfaceTorque <!-- NOUN -->
- Display name: SurfaceTorque
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TemperatureIn <!-- NOUN -->
- Display name: TemperatureIn
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TemperatureOut <!-- NOUN -->
- Display name: TemperatureOut
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## TopOfStringPosition <!-- NOUN -->
- Display name: TopOfStringPosition
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## WOB <!-- NOUN -->
- Display name: WOB
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PorePressure <!-- NOUN -->
- Display name: PorePressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## PorePressureGradient <!-- NOUN -->
- Display name: PorePressureGradient
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FracturingPressure <!-- NOUN -->
- Display name: FracturingPressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## FracturingPressureGradient <!-- NOUN -->
- Display name: FracturingPressureGradient
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## CollapsePressure <!-- NOUN -->
- Display name: CollapsePressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## CollapsePressureGradient <!-- NOUN -->
- Display name: CollapsePressureGradient
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ShearRate <!-- NOUN -->
- Display name: Shear rate
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ShearStress <!-- NOUN -->
- Display name: Shear stress
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MinimumHorizontalStress <!-- NOUN -->
- Display name: MinimumHorizontalStress
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MinimumHorizontalStressGradient <!-- NOUN -->
- Display name: MinimumHorizontalStressGradient
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## OverburdenPressure <!-- NOUN -->
- Display name: OverburdenPressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## OverburdenPressureGradient <!-- NOUN -->
- Display name: OverburdenPressureGradient
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BOPOpening <!-- NOUN -->
- Display name: BOPOpening
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BOPPressure <!-- NOUN -->
- Display name: BOPPressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDChokeOpening <!-- NOUN -->
- Display name: MPDChokeOpening
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDChokePressure <!-- NOUN -->
- Display name: MPDChokePressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDPumpRate <!-- NOUN -->
- Display name: MPDPumpRate
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MPDPumpFlowRate <!-- NOUN -->
- Display name: MPDPumpFlowRate
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## GasFlowRate <!-- NOUN -->
- Display name: GasFlowRate
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## BackPressurePumpPressure <!-- NOUN -->
- Display name: BackPressurePumpPressure
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## SetPoint <!-- NOUN -->
- Display name: Set-point
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Command <!-- NOUN -->
- Display name: Command
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Recommendation <!-- NOUN -->
- Display name: Recommendation
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## RecommendedTarget <!-- NOUN -->
- Display name: RecommendedTarget
- Parent class: [Recommendation](#Recommendation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## RecommendedMinimum <!-- NOUN -->
- Display name: RecommendedMinimum
- Parent class: [Recommendation](#Recommendation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## RecommendedMaximum <!-- NOUN -->
- Display name: RecommendedMaximum
- Parent class: [Recommendation](#Recommendation)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Advice <!-- NOUN -->
- Display name: Advice
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## AdvisedTarget <!-- NOUN -->
- Display name: AdvisedTarget
- Parent class: [Advice](#Advice)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## AdvisedMinimum <!-- NOUN -->
- Display name: AdvisedMinimum
- Parent class: [Advice](#Advice)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## AdvisedMaximum <!-- NOUN -->
- Display name: AdvisedMaximum
- Parent class: [Advice](#Advice)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Limit <!-- NOUN -->
- Display name: Limit
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MinimumLimit <!-- NOUN -->
- Display name: Minimum Limit
- Parent class: [Limit](#Limit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## MaximumLimit <!-- NOUN -->
- Display name: Maximum Limit
- Parent class: [Limit](#Limit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## Measurement <!-- NOUN -->
- Display name: Measurement
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: The noun Measurement represents individuals that are measured by some instrument and which value can be compared with another measurement.
- Examples:
- Definition set: DrillingDataSemantics
## DerivedMeasurement <!-- NOUN -->
- Display name: DerivedMeasurement
- Parent class: [Measurement](#Measurement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## CorrectedMeasurement <!-- NOUN -->
- Display name: CorrectedMeasurement
- Parent class: [Measurement](#Measurement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## ComputedData <!-- NOUN -->
- Display name: ComputedData
- Parent class: [DrillingDataPoint](#DrillingDataPoint)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DrillingSignal <!-- NOUN -->
- Display name: DrillingSignal
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - Value
    - Type: object
    - Description: 
- Specialization:
- Description: Data structure used to store the streaming drilling data.
- Examples:
- Definition set: DrillingDataSemantics
## DynamicDrillingSignal <!-- NOUN -->
- Display name: DynamicDrillingSignal
- Parent class: [DrillingSignal](#DrillingSignal)
- Attributes:
  - TimeStampAtSource
    - Type: DateTime
    - Description: this is a UTC date-time value corresponding to the time at which the value has been taken.
  - TimeStampAcquisition
    - Type: DateTime
    - Description: this is a UTC date-time value at which the value has been acquired by the data acquisition system.
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingDataSemantics
## DrillingEquipment <!-- NOUN -->
- Display name: DrillingEquipment
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Pit <!-- NOUN -->
- Display name: Pit
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ActivePit <!-- NOUN -->
- Display name: ActivePit
- Parent class: [Pit](#Pit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ReservePit <!-- NOUN -->
- Display name: ReservePit
- Parent class: [Pit](#Pit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## SlugPit <!-- NOUN -->
- Display name: SlugPit
- Parent class: [Pit](#Pit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TripTank <!-- NOUN -->
- Display name: TripTank
- Parent class: [Pit](#Pit)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## AnnulusTerminator <!-- NOUN -->
- Display name: AnnulusTerminator
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## BellNipple <!-- NOUN -->
- Display name: BellNipple
- Parent class: [AnnulusTerminator](#AnnulusTerminator)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Diverter <!-- NOUN -->
- Display name: Diverter
- Parent class: [AnnulusTerminator](#AnnulusTerminator)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## FlowLine <!-- NOUN -->
- Display name: FlowLine
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## BlowOutPreventerStack <!-- NOUN -->
- Display name: BlowOutPreventerStack
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## AnnularPreventer <!-- NOUN -->
- Display name: AnnularPreventer
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## BOPRam <!-- NOUN -->
- Display name: BOPRam
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## BOPShearRam <!-- NOUN -->
- Display name: BOPShearRam
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Bit <!-- NOUN -->
- Display name: Bit
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Dolly <!-- NOUN -->
- Display name: Dolly
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DollyRail <!-- NOUN -->
- Display name: DollyRail
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DrillLine <!-- NOUN -->
- Display name: DrillLine
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ActiveLine <!-- NOUN -->
- Display name: ActiveLine
- Parent class: [DrillLine](#DrillLine)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DeadLine <!-- NOUN -->
- Display name: DeadLine
- Parent class: [DrillLine](#DrillLine)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## SupportLine <!-- NOUN -->
- Display name: SupportLine
- Parent class: [DrillLine](#DrillLine)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DrillLineFastener <!-- NOUN -->
- Display name: DrillLineFastener
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DeadLineAnchor <!-- NOUN -->
- Display name: DeadLineAnchor
- Parent class: [DrillLineFastener](#DrillLineFastener)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DrawWorks <!-- NOUN -->
- Display name: DrawWorks
- Parent class: [HoistingSystem](#HoistingSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## RackAndPinionHoistingSystem <!-- NOUN -->
- Display name: RackAndPinionHoistingSystem
- Parent class: [HoistingSystem](#HoistingSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## RamHoistingSystem <!-- NOUN -->
- Display name: RamHoistingSystem
- Parent class: [HoistingSystem](#HoistingSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DrillStem <!-- NOUN -->
- Display name: DrillStem
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DrillString <!-- NOUN -->
- Display name: DrillString
- Parent class: [DrillStem](#DrillStem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## CasingString <!-- NOUN -->
- Display name: CasingString
- Parent class: [DrillStem](#DrillStem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Liner <!-- NOUN -->
- Display name: Liner
- Parent class: [DrillStem](#DrillStem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TubingString <!-- NOUN -->
- Display name: TubingString
- Parent class: [DrillStem](#DrillStem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ScreenString <!-- NOUN -->
- Display name: ScreenString
- Parent class: [DrillStem](#DrillStem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## CoiledTubing <!-- NOUN -->
- Display name: CoiledTubing
- Parent class: [DrillStem](#DrillStem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Elevator <!-- NOUN -->
- Display name: Elevator
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## GateValve <!-- NOUN -->
- Display name: GateValve
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## MechanicalBlock <!-- NOUN -->
- Display name: MechanicalBlock
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## CrownBlock <!-- NOUN -->
- Display name: CrownBlock
- Parent class: [MechanicalBlock](#MechanicalBlock)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TravellingBlock <!-- NOUN -->
- Display name: TravellingBlock
- Parent class: [MechanicalBlock](#MechanicalBlock)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Pump <!-- NOUN -->
- Display name: Pump
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## CementPump <!-- NOUN -->
- Display name: CementPump
- Parent class: [Pump](#Pump)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## MudPump <!-- NOUN -->
- Display name: MudPump
- Parent class: [Pump](#Pump)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## BoosterPump <!-- NOUN -->
- Display name: BoosterPump
- Parent class: [Pump](#Pump)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## BackPressurePump <!-- NOUN -->
- Display name: BackPressurePump
- Parent class: [Pump](#Pump)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ShaleShakers <!-- NOUN -->
- Display name: ShaleShakers
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Slips <!-- NOUN -->
- Display name: Slips
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## StandPipe <!-- NOUN -->
- Display name: StandPipe
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ThreeWayManifold <!-- NOUN -->
- Display name: ThreeWayManifold
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ThreeWayValve <!-- NOUN -->
- Display name: ThreeWayValve
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## ThreeWayValveInternalValve <!-- NOUN -->
- Display name: ThreeWayValveInternalValve
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## StringRotationSystem <!-- NOUN -->
- Display name: StringRotationSystem
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## RotaryTable <!-- NOUN -->
- Display name: RotaryTable
- Parent class: [StringRotationSystem](#StringRotationSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Kelly <!-- NOUN -->
- Display name: Kelly
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TopDrive <!-- NOUN -->
- Display name: TopDrive
- Parent class: [StringRotationSystem](#StringRotationSystem)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TopDriveBody <!-- NOUN -->
- Display name: TopDriveBody
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TopDriveHook <!-- NOUN -->
- Display name: TopDriveHook
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## TopDriveShaft <!-- NOUN -->
- Display name: TopDriveShaft
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## UnderReamer <!-- NOUN -->
- Display name: UnderReamer
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## HoistingSystem <!-- NOUN -->
- Display name: HoistingSystem
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Rig <!-- NOUN -->
- Display name: Rig
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Sea <!-- NOUN -->
- Display name: Sea
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## Ground <!-- NOUN -->
- Display name: Ground
- Parent class: [DrillingEquipment](#DrillingEquipment)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: DrillingEquipment
## DWISNoun <!-- NOUN -->
- Display name: DWIS noun
- Parent class: [](#)
- Attributes:
- Specialization:
- Description: Nouns refer to the nature of a node in the graph. Implicitely a noun refers to a "is a" relation between the instance node and the noun.
- Examples:
- Definition set: DWISSemantics
## DataEndPoint <!-- NOUN -->
- Display name: DataEndPoint
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - EndPointDescription
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: EndPoints
## WitsMLTimeBasedLogEndPoint <!-- NOUN -->
- Display name: WitsMLTimeBasedLogEndPoint
- Parent class: [DataEndPoint](#DataEndPoint)
- Attributes:
  - WellUID
    - Type: string
    - Description: 
  - WellName
    - Type: string
    - Description: 
  - WellboreUID
    - Type: string
    - Description: 
  - WellboreName
    - Type: string
    - Description: 
  - LogUID
    - Type: string
    - Description: 
  - LogName
    - Type: string
    - Description: 
  - Mnemonic
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: EndPoints
## EndPointMapping <!-- NOUN -->
- Display name: EndPointMapping
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - FixedIndices
    - Type: int[]
    - Description: 
  - ValuesIndices
    - Type: int[]
    - Description: 
  - MeasurementIndex
    - Type: int
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: EndPoints
## HydraulicElementState <!-- NOUN -->
- Display name: HydraulicElementState
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicConnectedState <!-- NOUN -->
- Display name: HydraulicConnectedState
- Parent class: [HydraulicElementState](#HydraulicElementState)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicLogicalElement <!-- NOUN -->
- Display name: HydraulicLogicalElement
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicBranch <!-- NOUN -->
- Display name: HydraulicBranch
- Parent class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## Annular <!-- NOUN -->
- Display name: Annular
- Parent class: [HydraulicBranch](#HydraulicBranch)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## BHAAnnular <!-- NOUN -->
- Display name: BHAAnnular
- Parent class: [Annular](#Annular)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DrillPipesAnnular <!-- NOUN -->
- Display name: DrillPipesAnnular
- Parent class: [Annular](#Annular)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## OpenChannel <!-- NOUN -->
- Display name: OpenChannel
- Parent class: [HydraulicBranch](#HydraulicBranch)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## RectangularChannel <!-- NOUN -->
- Display name: RectangularChannel
- Parent class: [OpenChannel](#OpenChannel)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## SemiCircularChannel <!-- NOUN -->
- Display name: SemiCircularChannel
- Parent class: [OpenChannel](#OpenChannel)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## Pipe <!-- NOUN -->
- Display name: Pipe
- Parent class: [HydraulicBranch](#HydraulicBranch)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## BHAInner <!-- NOUN -->
- Display name: BHAInner
- Parent class: [Pipe](#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DrillPipesInner <!-- NOUN -->
- Display name: DrillPipesInner
- Parent class: [Pipe](#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## OpenHole <!-- NOUN -->
- Display name: OpenHole
- Parent class: [Pipe](#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## ReturnFlowLine <!-- NOUN -->
- Display name: ReturnFlowLine
- Parent class: [Pipe](#Pipe)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicJunction <!-- NOUN -->
- Display name: HydraulicJunction
- Parent class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Attributes:
  - LeftToRight
    - Type: bool
    - Description: Indicates whether the fluid can flow from the left branch to the right branch though the junction
  - RightToLeft
    - Type: bool
    - Description: Indicates whether the fluid can flow from the right branch to the left branch though the junction
- Specialization:
  - LeftToRight = true
  - RightToLeft = true
- Description: 
- Examples:
- Definition set: Hydraulics
## MudMixing <!-- NOUN -->
- Display name: MudMixing
- Parent class: [HydraulicJunction](#HydraulicJunction)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## HydraulicNetwork <!-- NOUN -->
- Display name: HydraulicNetwork
- Parent class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DownholeHydraulicNetwork <!-- NOUN -->
- Display name: DownholeHydraulicNetwork
- Parent class: [HydraulicNetwork](#HydraulicNetwork)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## TopsideHydraulicNetwork <!-- NOUN -->
- Display name: TopsideHydraulicNetwork
- Parent class: [HydraulicNetwork](#HydraulicNetwork)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Hydraulics
## DrillStemMechanicalModel <!-- NOUN -->
- Display name: Drill-stem mechanical model
- Parent class: [MathematicalModel](#MathematicalModel)
- Attributes:
- Specialization:
- Description: A mechanical model for a drill-stem. Another name for drill-stem mechanical models is a torque and drag model.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffnessType <!-- NOUN -->
- Display name: Mechanical stiffness type
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: A description of how the drill-stem stiffness is modelled.
- Examples:
- Definition set: MechanicalModel
## MechanicalSoftModel <!-- NOUN -->
- Display name: Mechanical soft model
- Parent class: [MechanicalStiffnessType](#MechanicalStiffnessType)
- Attributes:
- Specialization:
- Description: An infinitively soft model assumes that the drill-stem deforms without any resistance when compressive loads are applied.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffModel <!-- NOUN -->
- Display name: Mechanical stiff model
- Parent class: [MechanicalStiffnessType](#MechanicalStiffnessType)
- Attributes:
- Specialization:
- Description: A stiff mechanical model considers that the drill-stem can deform laterally when put in compression.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffModelAssumedContacts <!-- NOUN -->
- Display name: Mechanical stiff model with assumed contacts
- Parent class: [MechanicalStiffModel](#MechanicalStiffModel)
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model presuposes the position of the contact points.
- Examples:
- Definition set: MechanicalModel
## MechanicalStiffModelEstimatedContacts <!-- NOUN -->
- Display name: Mechanical stiff model with estimated contacts
- Parent class: [MechanicalStiffModel](#MechanicalStiffModel)
- Attributes:
- Specialization:
- Description: Such a stiff mechanical model estimates the position of the contact points.
- Examples:
- Definition set: MechanicalModel
## TangencyLength <!-- NOUN -->
- Display name: Tangency length
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: the position along the drill-string, counted from the bit, from which we can consider that the pipes direction is tangential with the borehole direction.
- Examples:
- Definition set: MechanicalModel
## MechanicalElementState <!-- NOUN -->
- Display name: MechanicalElementState
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - Value
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyClosedState <!-- NOUN -->
- Display name: MechanicallyClosedState
- Parent class: [MechanicalElementState](#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicallyConnectedState <!-- NOUN -->
- Display name: MechanicallyConnectedState
- Parent class: [MechanicalElementState](#MechanicalElementState)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MechanicalLogicalElement <!-- NOUN -->
- Display name: MechanicalLogicalElement
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Mechanics
## MathematicalModel <!-- NOUN -->
- Display name: Mathematical model
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: A model for which the state variables do not change with time.
- Examples:
- Definition set: Model
## SteadyStateModel <!-- NOUN -->
- Display name: Steady state model
- Parent class: [MathematicalModel](#MathematicalModel)
- Attributes:
- Specialization:
- Description: A model for which the state variables do not change with time.
- Examples:
- Definition set: Model
## TransientModel <!-- NOUN -->
- Display name: Transient model
- Parent class: [MathematicalModel](#MathematicalModel)
- Attributes:
- Specialization:
- Description: A model for which the state variables changes with time.
- Examples:
- Definition set: Model
## ModelledDegreeOfFreedom <!-- NOUN -->
- Display name: Modelled degree of freedom
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: In physics and chemistry, a degree of freedom is an independent physical parameter in the formal description of the state of a physical system. A model may account for some or all of the degrees of freedom of the physical system.
- Examples:
- Definition set: Model
## AxialModelling <!-- NOUN -->
- Display name: Axial modelling
- Parent class: [ModelledDegreeOfFreedom](#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the axial movement of some parts of the physical system.
- Examples:
- Definition set: Model
## RotationalModelling <!-- NOUN -->
- Display name: Rotational modelling
- Parent class: [ModelledDegreeOfFreedom](#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the rotational movement of some parts of the physical system.
- Examples:
- Definition set: Model
## LateralModelling <!-- NOUN -->
- Display name: Lateral modelling
- Parent class: [ModelledDegreeOfFreedom](#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the lateral movement of some parts of the physical system.
- Examples:
- Definition set: Model
## RadialModelling <!-- NOUN -->
- Display name: Radial modelling
- Parent class: [LateralModelling](#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the radial movement of some parts of the physical system.
- Examples:
- Definition set: Model
## AngularLateralModelling <!-- NOUN -->
- Display name: Angular lateral modelling
- Parent class: [LateralModelling](#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the angular lateral movement of some parts of the physical system.
- Examples:
- Definition set: Model
## TangentialModelling <!-- NOUN -->
- Display name: Tangential modelling
- Parent class: [LateralModelling](#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of tangential direction of some parts of the physical system.
- Examples:
- Definition set: Model
## VerticalOndulationModelling <!-- NOUN -->
- Display name: Vertical ondulation modelling
- Parent class: [TangentialModelling](#TangentialModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of inclination of some parts of the physical system.
- Examples:
- Definition set: Model
## HorizontalOndulationModelling <!-- NOUN -->
- Display name: Horizontal ondulation modelling
- Parent class: [TangentialModelling](#TangentialModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of azimuth of some parts of the physical system.
- Examples:
- Definition set: Model
## ModellingDimensions <!-- NOUN -->
- Display name: Modelling dimensions
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: The number of dimensions that are accounted by the model
- Examples:
- Definition set: Model
## OneDModelling <!-- NOUN -->
- Display name: 1D modelling
- Parent class: [ModellingDimensions](#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for one dimension
- Examples:
- Definition set: Model
## TwoDModelling <!-- NOUN -->
- Display name: 2D modelling
- Parent class: [ModellingDimensions](#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for two dimensions
- Examples:
- Definition set: Model
## ThreeDModelling <!-- NOUN -->
- Display name: 3D modelling
- Parent class: [ModellingDimensions](#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for three dimensions
- Examples:
- Definition set: Model
## ModellingDiscretization <!-- NOUN -->
- Display name: Modelling discretization
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: A characteristic of the discretization made by the model.
- Examples:
- Definition set: Model
## BoundaryDiscretization <!-- NOUN -->
- Display name: Boundary discretization
- Parent class: [ModellingDiscretization](#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model only considers the bounds of the physical system and does not apply any intermediate discretization.
- Examples:
- Definition set: Model
## StrainWaveBasedDiscretization <!-- NOUN -->
- Display name: Strain-wave based discretization
- Parent class: [ModellingDiscretization](#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model can properly estimate values at the level of strain wave propagation.
- Examples:
- Definition set: Model
## MassTransferBasedDiscretization <!-- NOUN -->
- Display name: Elasticity based discretization
- Parent class: [ModellingDiscretization](#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model can properly estimate values at the level of mass transfer propagation.
- Examples:
- Definition set: Model
## Location <!-- NOUN -->
- Display name: Location
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: Physical location for a signal. Refers to: 1) a reference frame (via the HasReferenceFrame relation), that works as a system of coordinates 2) an origin (of type Location) via the HasReferenceFrameOrigin relation.
- Examples:
- Definition set: PhysicalLocation
## BitReferenceLocation <!-- NOUN -->
- Display name: BitReferenceLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## TopOfStringReferenceLocation <!-- NOUN -->
- Display name: TopOfStringReferenceLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## CasingShoeLocation <!-- NOUN -->
- Display name: CasingShoeLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## DrillFloorReferenceLocation <!-- NOUN -->
- Display name: DrillFloorReferenceLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## HoleBottomLocation <!-- NOUN -->
- Display name: HoleBottomLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## LWDLocation <!-- NOUN -->
- Display name: LWDLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## ReferenceLocation <!-- NOUN -->
- Display name: ReferenceLocation
- Parent class: [Location](#Location)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## ReferenceFrame <!-- NOUN -->
- Display name: ReferenceFrame
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: Represents a system of coordinates
- Examples:
- Definition set: PhysicalLocation
## DepthAndAngleFrame <!-- NOUN -->
- Display name: DepthAndAngleFrame
- Parent class: [ReferenceFrame](#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## FourDimensionalReferenceFrame <!-- NOUN -->
- Display name: FourDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## CurviLinearFrenetSerretReferenceFrame <!-- NOUN -->
- Display name: CurviLinearFrenetSerretReferenceFrame
- Parent class: [FourDimensionalReferenceFrame](#FourDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## OneDimensionalReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#ReferenceFrame)
- Attributes:
  - PostiveUpward
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## OneDimensionalCartesianReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCartesianReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](#OneDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## VerticalDepthFrame <!-- NOUN -->
- Display name: VerticalDepthFrame
- Parent class: [OneDimensionalCartesianReferenceFrame](#OneDimensionalCartesianReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## VerticalElevationReferenceFrame <!-- NOUN -->
- Display name: Vertical Elevation Reference Frame
- Parent class: [OneDimensionalCartesianReferenceFrame](#OneDimensionalCartesianReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## OneDimensionalCurviLinearReferenceFrame <!-- NOUN -->
- Display name: OneDimensionalCurviLinearReferenceFrame
- Parent class: [OneDimensionalReferenceFrame](#OneDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## DrillStringCenterLineFrame <!-- NOUN -->
- Display name: DrillStringCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
  - PositiveUpward
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## OpenHoleCenterLineFrame <!-- NOUN -->
- Display name: OpenHoleCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## WellboreCenterLineFrame <!-- NOUN -->
- Display name: WellboreCenterLineFrame
- Parent class: [OneDimensionalCurviLinearReferenceFrame](#OneDimensionalCurviLinearReferenceFrame)
- Attributes:
  - PositiveUpward
    - Type: bool
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## ThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: ThreeDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## CartesianThreeDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianThreeDimensionalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#ThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## FrenetSerretReferenceFrame <!-- NOUN -->
- Display name: FrenetSerretReferenceFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](#CartesianThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## NorthEastTVDFrame <!-- NOUN -->
- Display name: NorthEastTVDFrame
- Parent class: [CartesianThreeDimensionalReferenceFrame](#CartesianThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## CylindricalReferenceFrame <!-- NOUN -->
- Display name: CylindricalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#ThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## SphericalReferenceFrame <!-- NOUN -->
- Display name: SphericalReferenceFrame
- Parent class: [ThreeDimensionalReferenceFrame](#ThreeDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## TwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: TwoDimensionalReferenceFrame
- Parent class: [ReferenceFrame](#ReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## CartesianTwoDimensionalReferenceFrame <!-- NOUN -->
- Display name: CartesianTwoDimensionalReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](#TwoDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## NorthEastFrame <!-- NOUN -->
- Display name: NorthEastFrame
- Parent class: [CartesianTwoDimensionalReferenceFrame](#CartesianTwoDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## PolarReferenceFrame <!-- NOUN -->
- Display name: PolarReferenceFrame
- Parent class: [TwoDimensionalReferenceFrame](#TwoDimensionalReferenceFrame)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: PhysicalLocation
## MeasurableQuantity <!-- NOUN -->
- Display name: MeasurableQuantity
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - MeaningfulPrecision
    - Type: double
    - Description: 
- Specialization:
- Description: Represents a quantity that allows meaningful comparisons.
- Examples:
- Definition set: Quantities
## BitTorqueQuantity <!-- NOUN -->
- Display name: BitTorqueQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## BlockAccelerationQuantity <!-- NOUN -->
- Display name: BlockAccelerationQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## BlockPositionQuantity <!-- NOUN -->
- Display name: BlockPositionQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## BlockVelocityQuantity <!-- NOUN -->
- Display name: BlockVelocityQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## DepthQuantity <!-- NOUN -->
- Display name: DepthQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## DownholePressureQuantity <!-- NOUN -->
- Display name: DownholePressureQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## EMWQuantity <!-- NOUN -->
- Display name: EMWQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## FlowRateQuantity <!-- NOUN -->
- Display name: FlowRateQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## FluidDensityInQuantity <!-- NOUN -->
- Display name: FluidDensityInQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## FluidTemperatureInQuantity <!-- NOUN -->
- Display name: FluidTemperatureInQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## FormationPorosityQuantity <!-- NOUN -->
- Display name: FormationPorosityQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## HookloadQuantity <!-- NOUN -->
- Display name: HookloadQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## PumpRateQuantity <!-- NOUN -->
- Display name: PumpRateQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## Resistivity <!-- NOUN -->
- Display name: Resistivity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## RockDensityQuantity <!-- NOUN -->
- Display name: RockDensityQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## SPPQuantity <!-- NOUN -->
- Display name: SPPQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## SurfaceRPMQuantity <!-- NOUN -->
- Display name: SurfaceRPMQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## SurfaceTorqueQuantity <!-- NOUN -->
- Display name: SurfaceTorqueQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## TopOfStringForceQuantity <!-- NOUN -->
- Display name: TopOfStringForceQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## TVDQuantity <!-- NOUN -->
- Display name: TVDQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## WOBQuantity <!-- NOUN -->
- Display name: WOBQuantity
- Parent class: [MeasurableQuantity](#MeasurableQuantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## MeasurableQuantityUnitAssociation <!-- NOUN -->
- Display name: MeasurableQuantityUnitAssociation
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## Quantity <!-- NOUN -->
- Display name: Quantity
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - L
    - Type: int
    - Description: Length exponent.
  - M
    - Type: int
    - Description: Mass exponent.
  - T
    - Type: int
    - Description: Time exponent.
  - I
    - Type: int
    - Description: Electric current exponent.
  - ThT
    - Type: int
    - Description: Thermodynamic temperature exponent.
  - N
    - Type: int
    - Description: Amount of substance exponent.
  - J
    - Type: int
    - Description: Luminous intensity exponent.
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
- Definition set: Quantities
## AccelerationQuantity <!-- NOUN -->
- Display name: AccelerationQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 1
  - T = -2
  - Name = Acceleration quantity
- Description: 
- Examples:
- Definition set: Quantities
## AreaQuantity <!-- NOUN -->
- Display name: AreaQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 2
- Description: 
- Examples:
- Definition set: Quantities
## ElectricResistivityQuantity <!-- NOUN -->
- Display name: ElectricResistivityQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 3
  - M = 1
  - T = -3
  - I = -2
- Description: 
- Examples:
- Definition set: Quantities
## ForceQuantity <!-- NOUN -->
- Display name: ForceQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 1
  - M = 1
  - T = -2
- Description: 
- Examples:
- Definition set: Quantities
## FrequencyQuantity <!-- NOUN -->
- Display name: FrequencyQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - T = -1
- Description: 
- Examples:
- Definition set: Quantities
## LengthQuantity <!-- NOUN -->
- Display name: LengthQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 1
- Description: 
- Examples:
- Definition set: Quantities
## MassDensityQuantity <!-- NOUN -->
- Display name: MassDensityQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 3
  - M = 1
- Description: 
- Examples:
- Definition set: Quantities
## MassQuantity <!-- NOUN -->
- Display name: MassQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - M = 1
- Description: 
- Examples:
- Definition set: Quantities
## MassRate <!-- NOUN -->
- Display name: MassRate
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - M = 1
  - T = -1
- Description: 
- Examples:
- Definition set: Quantities
## PowerQuantity <!-- NOUN -->
- Display name: PowerQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 2
  - M = 1
  - T = -3
- Description: 
- Examples:
- Definition set: Quantities
## PressureQuantity <!-- NOUN -->
- Display name: PressureQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = -1
  - M = 1
  - T = 2
- Description: 
- Examples:
- Definition set: Quantities
## ProportionQuantity <!-- NOUN -->
- Display name: ProportionQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## TemperatureQuantity <!-- NOUN -->
- Display name: TemperatureQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - ThT = 1
- Description: 
- Examples:
- Definition set: Quantities
## TorqueQuantity <!-- NOUN -->
- Display name: TorqueQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 2
  - M = 1
  - T = -2
- Description: 
- Examples:
- Definition set: Quantities
## VelocityQuantity <!-- NOUN -->
- Display name: VelocityQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 1
  - T = -1
- Description: 
- Examples:
- Definition set: Quantities
## VolumeQuantity <!-- NOUN -->
- Display name: VolumeQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 3
- Description: 
- Examples:
- Definition set: Quantities
## VolumetricRateQuantity <!-- NOUN -->
- Display name: VolumetricRateQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 3
  - T = -1
- Description: 
- Examples:
- Definition set: Quantities
## VolumetricFlowateRateOfChangeQuantity <!-- NOUN -->
- Display name: VolumetricFlowateRateOfChangeQuantity
- Parent class: [Quantity](#Quantity)
- Attributes:
- Specialization:
  - L = 3
  - T = -2
- Description: 
- Examples:
- Definition set: Quantities
## Unit <!-- NOUN -->
- Display name: Unit
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - Symbol
    - Type: string
    - Description: 
  - ConversionFactorA
    - Type: double
    - Description: Unit conversion from SI unit is performed as:
  - ConversionFactorB
    - Type: double
    - Description: Unit conversion from SI unit is performed as:
- Specialization:
- Description: 
- Examples:
- Definition set: Quantities
## UnitSystem <!-- NOUN -->
- Display name: UnitSystem
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: A set of associations between measurable quantities and units
- Examples:
- Definition set: Quantities
## Clock <!-- NOUN -->
- Display name: Clock
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - LeapSeconds
    - Type: int
    - Description: 
  - Stratum
    - Type: int
    - Description: 
  - NetworkSynchronizationLatencyAverage
    - Type: double
    - Description: 
  - NetworkSynchronizationLatencyStandardDeviation
    - Type: double
    - Description: 
  - Resolution
    - Type: double
    - Description: 
  - MaximumFluctuations
    - Type: double
    - Description: 
- Specialization:
- Description: Represents a clock
- Examples:
- Definition set: TimeManagement
## SynchronizationGroup <!-- NOUN -->
- Display name: SynchronizationGroup
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
  - SynchronizationDelay
    - Type: double
    - Description: 
  - SamplingRate
    - Type: double
    - Description: 
- Specialization:
- Description: 
- Examples:
- Definition set: TimeManagement
## SignalUncertainty <!-- NOUN -->
- Display name: SignalUncertainty
- Parent class: [DWISNoun](#DWISNoun)
- Attributes:
- Specialization:
- Description: Represent the uncertainty associated to a signal.
- Examples:
- Definition set: Uncertainty
## GaussianUncertainty <!-- NOUN -->
- Display name: GaussianUncertainty
- Parent class: [SignalUncertainty](#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## GenericUncertainty <!-- NOUN -->
- Display name: GenericUncertainty
- Parent class: [SignalUncertainty](#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## MinMaxUncertainty <!-- NOUN -->
- Display name: MinMaxUncertainty
- Parent class: [SignalUncertainty](#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## RelativeUncertainty <!-- NOUN -->
- Display name: RelativeUncertainty
- Parent class: [SignalUncertainty](#SignalUncertainty)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Uncertainty
## SensorUncertainty <!-- NOUN -->
- Display name: SensorUncertainty
- Parent class: [SignalUncertainty](#SignalUncertainty)
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
- Definition set: Uncertainty
# Verbs
## IsEnablingSignalFor <!-- VERB -->
- Display name: IsEnablingSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [ActivableFunction](#ActivableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsActivatedSignalFor <!-- VERB -->
- Display name: IsActivatedSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [ActivableFunction](#ActivableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsAllowEnablementSignalFor <!-- VERB -->
- Display name: IsAllowEnablementSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [ActivableFunction](#ActivableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsIdlingSignalFor <!-- VERB -->
- Display name: IsIdlingSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [RunnableFunction](#RunnableFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsUserControllableExtraMarginSignalFor <!-- VERB -->
- Display name: IsUserControllableExtraMarginSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [FDIRFunction](#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsUsedDefinedExtraMarginSignalFor <!-- VERB -->
- Display name: IsUsedDefinedExtraMarginSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [FDIRFunction](#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsArmedSignalFor <!-- VERB -->
- Display name: IsArmedSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [FDIRFunction](#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsTriggeredSignalFor <!-- VERB -->
- Display name: IsTriggeredSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [FDIRFunction](#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsIdlingAfterTriggeredSignalFor <!-- VERB -->
- Display name: IsIdlingAfterTriggeredSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [FDIRFunction](#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsImpactDescriptionSignalFor <!-- VERB -->
- Display name: IsImpactDescriptionSignalFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [FDIRFunction](#FDIRFunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: ADCS
## IsDependentOn <!-- VERB -->
- Display name: IsDependentOn
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataDependencies
## HasPressureReference <!-- VERB -->
- Display name: HasPressureReference
- Parent verb: [IsDependentOn](#IsDependentOn)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataDependencies
## HasTemperatureReference <!-- VERB -->
- Display name: HasTemperatureReference
- Parent verb: [IsDependentOn](#IsDependentOn)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataDependencies
## HasElevationReference <!-- VERB -->
- Display name: HasElevationReference
- Parent verb: [IsDependentOn](#IsDependentOn)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Location](#Location)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataDependencies
## Controls <!-- VERB -->
- Display name: Controls
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## HasFunction <!-- VERB -->
- Display name: HasFunction
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DataFlowNode](#DataFlowNode)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsCommandFor <!-- VERB -->
- Display name: IsCommandFor
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsComputationInput <!-- VERB -->
- Display name: Is Computation Input
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ComputationUnit](#ComputationUnit)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsLimitFor <!-- VERB -->
- Display name: Is Limit For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsMinimumLimitFor <!-- VERB -->
- Display name: Is Minimum Limit For
- Parent verb: [IsLimitFor](#IsLimitFor)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsMaximumLimitFor <!-- VERB -->
- Display name: Is Maximum Limit For
- Parent verb: [IsLimitFor](#IsLimitFor)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointFor <!-- VERB -->
- Display name: Is Set-Point For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Controller](#Controller)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Recommendation For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ControlSystem](#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointAdviceFor <!-- VERB -->
- Display name: Is Set-Point Advice For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ControlSystem](#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMinimumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Minimum Recommendation For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ControlSystem](#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMinimumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Minimum Advice For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ControlSystem](#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMaximumRecommendationFor <!-- VERB -->
- Display name: Is Set-Point Maximum Recommendation For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ControlSystem](#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsSetPointMaximumAdviceFor <!-- VERB -->
- Display name: Is Set-Point Maximum Advice For
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ControlSystem](#ControlSystem)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransformationInput <!-- VERB -->
- Display name: IsTransformationInput
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Transformation](#Transformation)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsBufferingInput <!-- VERB -->
- Display name: IsBufferingInput
- Parent verb: [IsTransformationInput](#IsTransformationInput)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Buffering](#Buffering)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsDerivationInput <!-- VERB -->
- Display name: IsDerivationInput
- Parent verb: [IsTransformationInput](#IsTransformationInput)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsResamplingInput <!-- VERB -->
- Display name: IsResamplingInput
- Parent verb: [IsTransformationInput](#IsTransformationInput)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Resampling](#Resampling)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransmissionInput <!-- VERB -->
- Display name: IsTransmissionInput
- Parent verb: [HasFunction](#HasFunction)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [TransmissionLine](#TransmissionLine)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsGeneratedBy <!-- VERB -->
- Display name: IsGeneratedBy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DataFlowNode](#DataFlowNode)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsComputedBy <!-- VERB -->
- Display name: IsComputedBy
- Parent verb: [IsGeneratedBy](#IsGeneratedBy)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsMeasuredBy <!-- VERB -->
- Display name: IsMeasuredBy
- Parent verb: [IsGeneratedBy](#IsGeneratedBy)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsRecordedFrom <!-- VERB -->
- Display name: IsRecordedFrom
- Parent verb: [IsGeneratedBy](#IsGeneratedBy)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransformationOutput <!-- VERB -->
- Display name: IsTransformationOutput
- Parent verb: [IsGeneratedBy](#IsGeneratedBy)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DataFlowNode](#DataFlowNode)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsBufferingOutput <!-- VERB -->
- Display name: IsBufferingOutput
- Parent verb: [IsTransformationOutput](#IsTransformationOutput)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Buffering](#Buffering)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsDerivedFrom <!-- VERB -->
- Display name: IsDerivedFrom
- Parent verb: [IsTransformationOutput](#IsTransformationOutput)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsIntegratedFrom <!-- VERB -->
- Display name: IsIntegratedFrom
- Parent verb: [IsTransformationOutput](#IsTransformationOutput)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsResampledBy <!-- VERB -->
- Display name: IsResampledBy
- Parent verb: [IsTransformationOutput](#IsTransformationOutput)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Resampling](#Resampling)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsTransmissionOutput <!-- VERB -->
- Display name: IsTransmissionOutput
- Parent verb: [IsGeneratedBy](#IsGeneratedBy)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [TransmissionLine](#TransmissionLine)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsProcessedBy <!-- VERB -->
- Display name: IsProcessedBy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataFlow
## IsProvidedBy <!-- VERB -->
- Display name: IsProvidedBy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DataProvider](#DataProvider)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataProviders
## IsTransmittedBy <!-- VERB -->
- Display name: IsTransmittedBy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Telemetry](#Telemetry)
- Min cardinality: -1
- Max cardinality: -1
- Description: Expresses that a signal is transmitted by some given telemetry system
- Examples: EMS DWOB is transmitted by WiredPipeTelemetry
- Definition set: DataTransmission
## IsConditionedBy <!-- VERB -->
- Display name: IsConditionedBy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ValidityCondition](#ValidityCondition)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataValidity
## IsConditionInput <!-- VERB -->
- Display name: IsConditionInput
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ValidityCondition](#ValidityCondition)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataValidity
## IsConditionLeft <!-- VERB -->
- Display name: IsConditionLeft
- Parent verb: [IsConditionInput](#IsConditionInput)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataValidity
## IsConditionRight <!-- VERB -->
- Display name: IsConditionRight
- Parent verb: [IsConditionInput](#IsConditionInput)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataValidity
## IsValidBy <!-- VERB -->
- Display name: IsValidBy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DataValidity
## HasDomain <!-- VERB -->
- Display name: HasDomain
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasTimeIntervalDomain <!-- VERB -->
- Display name: HasTimeIntervalDomain
- Parent verb: [HasDomain](#HasDomain)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasValue <!-- VERB -->
- Display name: HasValue
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingSignal](#DrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasDynamicValue <!-- VERB -->
- Display name: HasDynamicValue
- Parent verb: [HasValue](#HasValue)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DynamicDrillingSignal](#DynamicDrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## HasStaticValue <!-- VERB -->
- Display name: HasStaticValue
- Parent verb: [HasValue](#HasValue)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingSignal](#DrillingSignal)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingDataSemantics
## IsSubPartOf <!-- VERB -->
- Display name: IsSubPartOf
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingEquipment](#DrillingEquipment)
- Object class: [DrillingEquipment](#DrillingEquipment)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DrillingEquipment
## DWISVerb <!-- VERB -->
- Display name: DWIS verb
- Parent verb: [](#)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## HasType <!-- VERB -->
- Display name: Has Type
- Parent verb: [BelongsToClass](#BelongsToClass)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## BelongsToClass <!-- VERB -->
- Display name: Belongs To Class
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: DWISSemantics
## HasEndPoint <!-- VERB -->
- Display name: HasEndPoint
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingSignal](#DrillingSignal)
- Object class: [DataEndPoint](#DataEndPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: EndPoints
## EndsHydraulicBranchDecomposition <!-- VERB -->
- Display name: EndsHydraulicBranchDecomposition
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicBranch](#HydraulicBranch)
- Object class: [HydraulicBranch](#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsAHydraulicRepresentationFor <!-- VERB -->
- Display name: IsAHydraulicRepresentationFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Object class: [DrillingEquipment](#DrillingEquipment)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasBranchComponent <!-- VERB -->
- Display name: HasBranchComponent
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicNetwork](#HydraulicNetwork)
- Object class: [HydraulicBranch](#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasBranchCoordinateSystem <!-- VERB -->
- Display name: HasBranchCoordinateSystem
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicBranch](#HydraulicBranch)
- Object class: [ReferenceFrame](#ReferenceFrame)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasHydraulicState <!-- VERB -->
- Display name: HasHydraulicState
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicJunction](#HydraulicJunction)
- Object class: [HydraulicElementState](#HydraulicElementState)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasHydraulicStateValueFrom <!-- VERB -->
- Display name: HasHydraulicStateValueFrom
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasLeftBranchCoordinates <!-- VERB -->
- Display name: HasLeftBranchCoordinates
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicJunction](#HydraulicJunction)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasRightBranchCoordinates <!-- VERB -->
- Display name: HasRightBranchCoordinates
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicJunction](#HydraulicJunction)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicallyLocatedAt <!-- VERB -->
- Display name: IsHydraulicallyLocatedAt
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsEquivalentCirculationDensityAt <!-- VERB -->
- Display name: IsEquivalentCirculationDensityAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsFluidDensityAt <!-- VERB -->
- Display name: IsFluidDensityAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsFluidTemperatureAt <!-- VERB -->
- Display name: IsFluidTemperatureAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsFluidVelocityAt <!-- VERB -->
- Display name: IsFluidVelocityAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicEstimationAt <!-- VERB -->
- Display name: IsHydraulicEstimationAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicMaximumAllowedRateOfChangeAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedRateOfChangeAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicMaximumAllowedValueAt <!-- VERB -->
- Display name: IsHydraulicMaximumAllowedValueAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicMeasurementAt <!-- VERB -->
- Display name: IsHydraulicMeasurementAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsMassFlowRateAt <!-- VERB -->
- Display name: IsMassFlowRateAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsPressureAt <!-- VERB -->
- Display name: IsPressureAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsPressureGradientAt <!-- VERB -->
- Display name: IsPressureGradientAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsVolumetricFlowRateAt <!-- VERB -->
- Display name: IsVolumetricFlowRateAt
- Parent verb: [IsHydraulicallyLocatedAt](#IsHydraulicallyLocatedAt)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsHydraulicConnectedTo <!-- VERB -->
- Display name: IsHydraulicConnectedTo
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Object class: [HydraulicLogicalElement](#HydraulicLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasEndJunction <!-- VERB -->
- Display name: HasEndJunction
- Parent verb: [IsHydraulicConnectedTo](#IsHydraulicConnectedTo)
- Subject class: [HydraulicBranch](#HydraulicBranch)
- Object class: [HydraulicJunction](#HydraulicJunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasLeftBranch <!-- VERB -->
- Display name: HasLeftBranch
- Parent verb: [IsHydraulicConnectedTo](#IsHydraulicConnectedTo)
- Subject class: [HydraulicJunction](#HydraulicJunction)
- Object class: [HydraulicBranch](#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasRightBranch <!-- VERB -->
- Display name: HasRightBranch
- Parent verb: [IsHydraulicConnectedTo](#IsHydraulicConnectedTo)
- Subject class: [HydraulicJunction](#HydraulicJunction)
- Object class: [HydraulicBranch](#HydraulicBranch)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## HasStartJunction <!-- VERB -->
- Display name: HasStartJunction
- Parent verb: [IsHydraulicConnectedTo](#IsHydraulicConnectedTo)
- Subject class: [HydraulicBranch](#HydraulicBranch)
- Object class: [HydraulicJunction](#HydraulicJunction)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## StartsHydraulicBranchDecomposition <!-- VERB -->
- Display name: StartsHydraulicBranchDecomposition
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Hydraulics
## IsOfMechanicalStiffnessType <!-- VERB -->
- Display name: Is of mechanical stiffness type
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillStemMechanicalModel](#DrillStemMechanicalModel)
- Object class: [MechanicalStiffnessType](#MechanicalStiffnessType)
- Min cardinality: -1
- Max cardinality: -1
- Description: A relation to describe how the drill-stem mechanical model manage stiffness.
- Examples: 
- Definition set: MechanicalModel
## IsAMechanicalRepresentationFor <!-- VERB -->
- Display name: IsAMechanicalRepresentationFor
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MechanicalLogicalElement](#MechanicalLogicalElement)
- Object class: [DrillingEquipment](#DrillingEquipment)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## HasMechanicalState <!-- VERB -->
- Display name: HasMechanicalState
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MechanicalLogicalElement](#MechanicalLogicalElement)
- Object class: [MechanicalElementState](#MechanicalElementState)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## HasMechanicalStateValueFrom <!-- VERB -->
- Display name: HasMechanicalStateValueFrom
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MechanicalElementState](#MechanicalElementState)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## IsMechanicallyConnectedTo <!-- VERB -->
- Display name: IsMechanicallyConnectTo
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MechanicalLogicalElement](#MechanicalLogicalElement)
- Object class: [MechanicalLogicalElement](#MechanicalLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## IsMechanicallyLocatedAt <!-- VERB -->
- Display name: IsMechanicallyLocatedAt
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [MechanicalLogicalElement](#MechanicalLogicalElement)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Mechanics
## HasCoordinates <!-- VERB -->
- Display name: HasCoordinates
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [Location](#Location)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: PhysicalLocation
## HasReferenceFrame <!-- VERB -->
- Display name: HasReferenceFrame
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [ReferenceFrame](#ReferenceFrame)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: PhysicalLocation
## HasReferenceFrameOrigin <!-- VERB -->
- Display name: HasReferenceFrameOrigin
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [ReferenceFrame](#ReferenceFrame)
- Object class: [Location](#Location)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: PhysicalLocation
## IsPhysicallyLocatedAt <!-- VERB -->
- Display name: IsPhysicallyLocatedAt
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Location](#Location)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: PhysicalLocation
## AssociatesMeasurableQuantity <!-- VERB -->
- Display name: AssociatesMeasurableQuantity
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MeasurableQuantityUnitAssociation](#MeasurableQuantityUnitAssociation)
- Object class: [MeasurableQuantity](#MeasurableQuantity)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## AssociatesUnit <!-- VERB -->
- Display name: AssociatesUnit
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MeasurableQuantityUnitAssociation](#MeasurableQuantityUnitAssociation)
- Object class: [Unit](#Unit)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## HasUnitAssociation <!-- VERB -->
- Display name: HasUnitAssociation
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [UnitSystem](#UnitSystem)
- Object class: [MeasurableQuantityUnitAssociation](#MeasurableQuantityUnitAssociation)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## IsObservableFrom <!-- VERB -->
- Display name: IsObservableFrom
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## IsOfBaseQuantity <!-- VERB -->
- Display name: IsOfBaseQuantity
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [MeasurableQuantity](#MeasurableQuantity)
- Object class: [Quantity](#Quantity)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## IsOfMeasurableQuantity <!-- VERB -->
- Display name: IsOfMeasurableQuantity
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingSignal](#DrillingSignal)
- Object class: [MeasurableQuantity](#MeasurableQuantity)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## IsUnitForQuantity <!-- VERB -->
- Display name: IsUnitForQuantity
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [Unit](#Unit)
- Object class: [Quantity](#Quantity)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## HasSIUnit <!-- VERB -->
- Display name: HasSIUnit
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [Quantity](#Quantity)
- Object class: [Unit](#Unit)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## HasUnitOfMeasure <!-- VERB -->
- Display name: HasUnitOfMeasure
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingSignal](#DrillingSignal)
- Object class: [Unit](#Unit)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Quantities
## BelongsToSynchronizationGroup <!-- VERB -->
- Display name: BelongsToSynchronizationGroup
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [Resampling](#Resampling)
- Object class: [SynchronizationGroup](#SynchronizationGroup)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasAcquisitionClock <!-- VERB -->
- Display name: HasAcquisitionClock
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Clock](#Clock)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasSourceClock <!-- VERB -->
- Display name: HasSourceClock
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [Clock](#Clock)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasTransmissionDelay <!-- VERB -->
- Display name: HasTransmissionDelay
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## IsSynchronizationGroupInput <!-- VERB -->
- Display name: IsSynchronizationGroupInput
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [SynchronizationGroup](#SynchronizationGroup)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## IsSynchronizationGroupOutput <!-- VERB -->
- Display name: IsSynchronizationGroupOutput
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [SynchronizationGroup](#SynchronizationGroup)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: TimeManagement
## HasUncertainty <!-- VERB -->
- Display name: HasUncertainty
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DrillingDataPoint](#DrillingDataPoint)
- Object class: [SignalUncertainty](#SignalUncertainty)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyAccuracy <!-- VERB -->
- Display name: HasUncertaintyAccuracy
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [SensorUncertainty](#SensorUncertainty)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMax <!-- VERB -->
- Display name: HasUncertaintyMax
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMean <!-- VERB -->
- Display name: HasUncertaintyMean
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyMin <!-- VERB -->
- Display name: HasUncertaintyMin
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyPrecision <!-- VERB -->
- Display name: HasUncertaintyPrecision
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [SensorUncertainty](#SensorUncertainty)
- Object class: [DrillingDataPoint](#DrillingDataPoint)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyRelativeValue <!-- VERB -->
- Display name: HasUncertaintyRelativeValue
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
## HasUncertaintyStandardDeviation <!-- VERB -->
- Display name: HasUncertaintyStandardDeviation
- Parent verb: [DWISVerb](#DWISVerb)
- Subject class: [DWISNoun](#DWISNoun)
- Object class: [DWISNoun](#DWISNoun)
- Min cardinality: -1
- Max cardinality: -1
- Description: 
- Examples: 
- Definition set: Uncertainty
