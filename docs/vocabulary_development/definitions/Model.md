- Description: high level and generic vocabulary for mathematical models of the drilling process

# NOUNS
## ModelType <!-- NOUN -->
- Display name: ModelType
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: Generic classification of a mathematical model for the drilling process.
- Examples:
```dwis modelTypeExample
ModelType:modelType
DrillStemMechanicalModel:torqueDragModel
torqueDragModel BelongsToClass modelType
```
This example assigns a model type to a torque and drag model.
## DeterministicModel <!-- NOUN -->
- Display name: DeterministicModel
- Parent class: ModelType
- Attributes:
- Specialization: 
- Description: A model whose outputs are fully determined by inputs and parameters without randomness.
- Examples:
```dwis deterministicModel
DeterministicModel:detModel
DrillStemMechanicalModel:torqueDragModel
torqueDragModel BelongsToClass detModel
```
This example marks a torque and drag model as deterministic.
## StochasticModel <!-- NOUN -->
- Display name: StochasticModel
- Parent class: ModelType
- Attributes:
- Specialization: 
- Description: A model that incorporates randomness or probabilistic components.
- Examples:
```dwis stochasticModel
StochasticModel:stochModel
ModelType:modelType
stochModel BelongsToClass ModelType
```
This example defines a stochastic model classification.
## TemporalBehaviorModel <!-- NOUN -->
- Display name: Temporal Behavior Model
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model as a function of its temporal behavior.
- Examples:
```dwis temporalBehavior
TemporalBehaviorModel:temporalBehavior
ModelType:modelType
temporalBehavior BelongsToClass TemporalBehaviorModel
```
This example declares a temporal behavior classification.
## SteadyStateModel <!-- NOUN -->
- Display name: Steady state model
- Parent class: TemporalBehaviorModel
- Attributes:
- Specialization: 
- Description: A model for which the state variables do not change with time.
- Examples:
```dwis steadyStateModel
SteadyStateModel:steadyModel
DrillStemMechanicalModel:torqueDragModel
torqueDragModel BelongsToClass steadyModel
```
This example tags a torque and drag model as steady-state.
## TransientModel <!-- NOUN -->
- Display name: Transient model
- Parent class: TemporalBehaviorModel
- Attributes:
- Specialization: 
- Description: A model for which the state variables changes with time.
- Examples:
```dwis transientModel
TransientModel:transientModel
HydraulicNetwork:downholeNetwork
transientModel BelongsToClass TransientModel
```
This example declares a transient hydraulic model.
## ModelingApproach <!-- NOUN -->
- Display name: Modeling Approach
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the modeling direction of a model.
- Examples:
```dwis modellingApproach
ModelingApproach:approach
ModelType:modelType
approach BelongsToClass ModelingApproach
```
This example introduces a modeling approach classification.
## ForwardModel <!-- NOUN -->
- Display name: Forward Model
- Parent class: ModelingApproach
- Attributes:
- Specialization: 
- Description: For a forward model, the inputs are used to predict outputs.
- Examples:
```dwis forwardModel
ForwardModel:forwardModel
DeterministicModel:detModel
forwardModel BelongsToClass DeterministicModel
```
This example defines a forward deterministic model.
## InversionModel <!-- NOUN -->
- Display name: Inversion Model
- Parent class: ModelingApproach
- Attributes:
- Specialization: 
- Description: For an inversion model, the outputs are used to infer inputs or parameters.
- Examples:
```dwis inversionModel
InversionModel:inverseModel
StochasticModel:stochModel
inverseModel BelongsToClass StochasticModel
```
This example defines an inversion model classification.
## HybridAnalysisModel <!-- NOUN -->
- Display name: Hybrid Analysis Model
- Parent class: ModelingApproach
- Attributes:
- Specialization: 
- Description: A hybrid analysis model may combine forward and inverse steps in an iterative approach.
- Examples:
```dwis hybridModel
HybridAnalysisModel:hybridModel
ModelType:modelType
hybridModel BelongsToClass ModelType
```
This example represents a hybrid analysis model.
## ModelingParadigm <!-- NOUN -->
- Display name: Modeling Paradigm
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the relationship of the model to data or physical laws.
- Examples:
```dwis paradigm
ModelingParadigm:paradigm
ModelType:modelType
paradigm BelongsToClass ModelingParadigm
```
This example introduces a modeling paradigm classification.
## EmpiricalModel <!-- NOUN -->
- Display name: Empirical Model
- Parent class: ModelingParadigm
- Attributes:
- Specialization: 
- Description: A model that heavily rely on data without using explicitly physical laws.
- Examples:
```dwis empiricalModel
EmpiricalModel:empiricalModel
ModelType:modelType
empiricalModel BelongsToClass ModelType
```
This example defines an empirical model class.
## MechanisticModel <!-- NOUN -->
- Display name: Mechanistic Model
- Parent class: ModelingParadigm
- Attributes:
- Specialization: 
- Description: A model that is based on first principles or physical laws.
- Examples:
```dwis mechanisticModel
MechanisticModel:mechanisticModel
ModelType:modelType
mechanisticModel BelongsToClass ModelType
```
This example defines a mechanistic model class.
## PhysicsInformedDataDrivenModel <!-- NOUN -->
- Display name: Physics Informed Data Driven Model
- Parent class: ModelingParadigm
- Attributes:
- Specialization: 
- Description: A hybrid model that uses both physical laws and data.
- Examples:
```dwis pidddModel
PhysicsInformedDataDrivenModel:pidddModel
ModelType:modelType
pidddModel BelongsToClass ModelType
```
This example defines a physics-informed data-driven model.
## MathematicalFormulation <!-- NOUN -->
- Display name: Mathematical Formulation
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the mathematical formulation used by a model.
- Examples:
```dwis formulation
MathematicalFormulation:formulation
ModelType:modelType
formulation BelongsToClass MathematicalFormulation
```
This example introduces a mathematical formulation classification.
## AlgebraicModel <!-- NOUN -->
- Display name: Algebraic Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses algebraic equations.
- Examples:
```dwis algebraicModel
AlgebraicModel:algebraicModel
ModelType:modelType
algebraicModel BelongsToClass ModelType
```
This example defines an algebraic model class.
## OrdinaryDifferentialEquationModel <!-- NOUN -->
- Display name: Ordinary Differential Equation Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses ordinary differential equations.
- Examples:
```dwis odeModel
OrdinaryDifferentialEquationModel:odeModel
ModelType:modelType
odeModel BelongsToClass ModelType
```
This example defines an ODE-based model.
## PartialDifferentialEquationModel <!-- NOUN -->
- Display name: Partial Differential Equation Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses partial differential equations.
- Examples:
```dwis pdeModel
PartialDifferentialEquationModel:pdeModel
ModelType:modelType
pdeModel BelongsToClass ModelType
```
This example defines a PDE-based model.
## IntegralModel <!-- NOUN -->
- Display name: Integral Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses integral equations.
- Examples:
```dwis integralModel
IntegralModel:integralModel
ModelType:modelType
integralModel BelongsToClass ModelType
```
This example defines an integral equation model.
## ModelingObjective <!-- NOUN -->
- Display name: Modeling Objective
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the objective/purpose of a model.
- Examples:
```dwis modellingObjective
ModelingObjective:objective
ModelType:modelType
objective BelongsToClass ModelingObjective
```
This example introduces a modeling objective classification.
## PredictiveModel <!-- NOUN -->
- Display name: Predictive Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that aims to forecast future behavior based on current data or conditions.
- Examples:
```dwis predictiveModel
PredictiveModel:predictiveModel
ModelType:modelType
predictiveModel BelongsToClass ModelType
```
This example defines a predictive model class.
## DescriptiveModel <!-- NOUN -->
- Display name: Descriptive Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that seeks to explain or describe a system's behavior or underlying mechanisms.
- Examples:
```dwis descriptiveModel
DescriptiveModel:descriptiveModel
ModelType:modelType
descriptiveModel BelongsToClass ModelType
```
This example defines a descriptive model class.
## CalibrationModel <!-- NOUN -->
- Display name: Calibration Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that focuses on adjusting parameters to improve alignment with observed data.
- Examples:
```dwis calibrationModel
CalibrationModel:calibrationModel
ModelType:modelType
calibrationModel BelongsToClass ModelType
```
This example defines a calibration model class.
## ControlModel <!-- NOUN -->
- Display name: Control Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that regulate or steer a system's behavior toward a desired outcome through inputs.
- Examples:
```dwis controlModel
ControlModel:controlModel
ModelType:modelType
controlModel BelongsToClass ModelType
```
This example defines a control model class.
## ModelScope <!-- NOUN -->
- Display name: Model Scope
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model with regards to its range of applicability.
- Examples:
```dwis modelScope
ModelScope:modelScope
ModelType:modelType
modelScope BelongsToClass ModelScope
```
This example introduces a model scope classification.
## GeneralModel <!-- NOUN -->
- Display name: General Model
- Parent class: ModelScope
- Attributes:
- Specialization: 
- Description: A model with a broad range of application across various systems or phenomena.
- Examples:
```dwis generalModel
GeneralModel:generalModel
ModelType:modelType
generalModel BelongsToClass ModelType
```
This example defines a general model class.
## SpecializedModel <!-- NOUN -->
- Display name: Specialized Model
- Parent class: ModelScope
- Attributes:
- Specialization: 
- Description: A model that is tailored to specific systems, scenarios or conditions.
- Examples:
```dwis specializedModel
SpecializedModel:specializedModel
ModelType:modelType
specializedModel BelongsToClass ModelType
```
This example defines a specialized model class.
## ModelTransparency <!-- NOUN -->
- Display name: Model Transparency
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model with regards to its transparency or interpretability.
- Examples:
```dwis transparency
ModelTransparency:transparency
ModelType:modelType
transparency BelongsToClass ModelTransparency
```
This example introduces model transparency classification.
## BlackBoxModel <!-- NOUN -->
- Display name: Black Box Model
- Parent class: ModelTransparency
- Attributes:
- Specialization: 
- Description: The internal workings of the model are unknown or not interpretable, focusing only on the input-output relationship.
- Examples:
```dwis blackBox
BlackBoxModel:blackBoxModel
ModelType:modelType
blackBoxModel BelongsToClass ModelType
```
This example defines a black-box model class.
## GrayBoxModel <!-- NOUN -->
- Display name: Gray Box Model
- Parent class: ModelTransparency
- Attributes:
- Specialization: 
- Description: The model combines both data-drive and mechanistic models offering a partial transparency.
- Examples:
```dwis grayBox
GrayBoxModel:grayBoxModel
ModelType:modelType
grayBoxModel BelongsToClass ModelType
```
This example defines a gray-box model class.
## WhiteBoxModel <!-- NOUN -->
- Display name: White Box Model
- Parent class: ModelTransparency
- Attributes:
- Specialization: 
- Description: The model is fully transparent and interpretable, with all internal mechanisms and assumptions clearly defined.
- Examples:
```dwis whiteBox
WhiteBoxModel:whiteBoxModel
ModelType:modelType
whiteBoxModel BelongsToClass ModelType
```
This example defines a white-box model class.
## DataIntegrationStrategy <!-- NOUN -->
- Display name: Data Integration Strategy
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model with regards to its strategy for integrating data.
- Examples:
```dwis integrationStrategy
DataIntegrationStrategy:integrationStrategy
ModelType:modelType
integrationStrategy BelongsToClass DataIntegrationStrategy
```
This example introduces a data integration strategy classification.
## DataLevelIntegationModel <!-- NOUN -->
- Display name: Data Level Integation Model
- Parent class: DataIntegrationStrategy
- Attributes:
- Specialization: 
- Description: A model that integrates data at a low-level like direct merging, using data transforms or filtering.
- Examples:
```dwis dataLevelIntegration
DataLevelIntegationModel:dataLevelIntegration
ModelType:modelType
dataLevelIntegration BelongsToClass ModelType
```
This example defines a data-level integration model.
## FeatureLevelIntegationModel <!-- NOUN -->
- Display name: Data Level Integation Model
- Parent class: DataIntegrationStrategy
- Attributes:
- Specialization: 
- Description: A model that integrates data at a medium-level like using feature extraction and merging, reducing dimensionality, 
weighting features, or correlating features.
- Examples:
```dwis featureLevelIntegration
FeatureLevelIntegationModel:featureLevelIntegration
ModelType:modelType
featureLevelIntegration BelongsToClass ModelType
```
This example defines a feature-level integration model.
## DecisionLevelIntegationModel <!-- NOUN -->
- Display name: Data Level Integation Model
- Parent class: DataIntegrationStrategy
- Attributes:
- Specialization: 
- Description: A model that integrates data at a high-level like using majority voting, ensemble methods, Bayesian decision fusion, 
Dempster-Shafer theory.
- Examples:
```dwis decisionLevelIntegration
DecisionLevelIntegationModel:decisionLevelIntegration
ModelType:modelType
decisionLevelIntegration BelongsToClass ModelType
```
This example defines a decision-level integration model.
## ModelledDegreeOfFreedom <!-- NOUN -->
- Display name: Modelled degree of freedom
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: In physics and chemistry, a degree of freedom is an independent physical parameter in the formal description of the state of a physical system. A model may account for some or all of the degrees of freedom of the physical system.
- Examples:Axial, rotational...
## AxialModelling <!-- NOUN -->
- Display name: Axial modelling
- Parent class: ModelledDegreeOfFreedom
- Attributes:
- Specialization: 
- Description: The model accounts for the axial movement of some parts of the physical system.
- Examples:A hydraulic model accounts for the axial velocity of fluid inside a pipe or an annulus. A torque and drag model accounts for the axial displacement of a drill-stem.
## RotationalModelling <!-- NOUN -->
- Display name: Rotational modelling
- Parent class: ModelledDegreeOfFreedom
- Attributes:
- Specialization: 
- Description: The model accounts for the rotational movement of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of pipe rotation on the fluid velocity in an annulus. A torque and drag model accounts for the rotational movement of a drill-stem.
## LateralModelling <!-- NOUN -->
- Display name: Lateral modelling
- Parent class: ModelledDegreeOfFreedom
- Attributes:
- Specialization: 
- Description: The model accounts for the lateral movement of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of the lateral pipe displacement on the fluid velocity in an annulus. A torque and drag model accounts for the lateral  movement of a drill-stem.
## RadialModelling <!-- NOUN -->
- Display name: Radial modelling
- Parent class: LateralModelling
- Attributes:
- Specialization: 
- Description: The model accounts for the radial movement of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of the radial pipe displacement on the fluid velocity in an annulus. A torque and drag model accounts for the radial  movement of a drill-stem.
## AngularLateralModelling <!-- NOUN -->
- Display name: Angular lateral modelling
- Parent class: LateralModelling
- Attributes:
- Specialization: 
- Description: The model accounts for the angular lateral movement of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of the pipe wobbling on the fluid velocity in an annulus. A torque and drag model accounts for the wobbling of a drill-stem.
## TangentialModelling <!-- NOUN -->
- Display name: Tangential modelling
- Parent class: LateralModelling
- Attributes:
- Specialization: 
- Description: The model accounts for the change of tangential direction of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of the pipe ondulation on the fluid velocity in an annulus. A torque and drag model accounts for the ondulation of a drill-stem.
## VerticalOndulationModelling <!-- NOUN -->
- Display name: Vertical ondulation modelling
- Parent class: TangentialModelling
- Attributes:
- Specialization: 
- Description: The model accounts for the change of inclination of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of the pipe vertical ondulation on the fluid velocity in an annulus. A torque and drag model accounts for the vertical ondulation of a drill-stem.
## HorizontalOndulationModelling <!-- NOUN -->
- Display name: Horizontal ondulation modelling
- Parent class: TangentialModelling
- Attributes:
- Specialization: 
- Description: The model accounts for the change of azimuth of some parts of the physical system.
- Examples:A hydraulic model accounts for the effect of the pipe horizontal ondulation on the fluid velocity in an annulus. A torque and drag model accounts for the horizontal ondulation of a drill-stem.
## ModellingDimensions <!-- NOUN -->
- Display name: Modelling dimensions
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: The number of dimensions that are accounted by the model 
- Examples:
```dwis modellingDimensions
DrillingDataPoint:modellingDimensions
modellingDimensions BelongsToClass ModellingDimensions
```
This example links a drilling data point to the ModellingDimensions definition.
## OneDModelling <!-- NOUN -->
- Display name: 1D modelling
- Parent class: ModellingDimensions
- Attributes:
- Specialization: 
- Description: The model only accounts for one dimension 
- Examples: A hydraulic model only considers the axial direction for the flow in a pipe and in an annulus.
## TwoDModelling <!-- NOUN -->
- Display name: 2D modelling
- Parent class: ModellingDimensions
- Attributes:
- Specialization: 
- Description: The model only accounts for two dimensions
- Examples: A hydraulic calculation considers the fluid velocity field in a cross-section but does not consider the axial direction. A heat transfer model considers the radial and axial heat transfer but assumes complete angular symmetry.
## ThreeDModelling <!-- NOUN -->
- Display name: 3D modelling
- Parent class: ModellingDimensions
- Attributes:
- Specialization: 
- Description: The model only accounts for three dimensions
- Examples: A hydraulic calculation considers the fluid velocity field in a cross-section and in the axial direction. A heat transfer model considers the radial, angular and axial heat transfer.
## ModellingDiscretization <!-- NOUN -->
- Display name: Modelling discretization
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A characteristic of the discretization made by the model. 
- Examples:
```dwis modellingDiscretization
DrillingDataPoint:modellingDiscretization
modellingDiscretization BelongsToClass ModellingDiscretization
```
This example links a drilling data point to the ModellingDiscretization definition.
## BoundaryDiscretization <!-- NOUN -->
- Display name: Boundary discretization
- Parent class: ModellingDiscretization
- Attributes:
- Specialization: 
- Description: A model only considers the bounds of the physical system and does not apply any intermediate discretization. 
- Examples: The Kaasa model (https://doi.org/10.2118/143097-PA) is an example of hydraulic model that only accounts for the boundaries and does not utilize any intermediate discretization.
## StrainWaveBasedDiscretization <!-- NOUN -->
- Display name: Strain-wave based discretization
- Parent class: ModellingDiscretization
- Attributes:
- Specialization: 
- Description: A model can properly estimate values at the level of strain wave propagation. 
- Examples: A transient mechanical model that is compatible with modelling acoustic waves in the drill-string.
## MassTransferBasedDiscretization <!-- NOUN -->
- Display name: Elasticity based discretization
- Parent class: ModellingDiscretization
- Attributes:
- Specialization: 
- Description: A model can properly estimate values at the level of mass transfer propagation. 
- Examples: A transient mechanical model that is compatible with modelling axial, rotationa and lateral drill-string displacement. A transient hydraulic model that is compatible with modelling fluid mass transfer inside the string and the annulus.


# VERBS