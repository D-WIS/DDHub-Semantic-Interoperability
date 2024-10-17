- Description: high level and generic vocabulary for mathematical models of the drilling process

# NOUNS
## ModelType <!-- NOUN -->
- Display name: ModelType
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: 
- Examples:
## DeterministicModel <!-- NOUN -->
- Display name: DeterministicModel
- Parent class: ModelType
- Attributes:
- Specialization: 
- Description: 
- Examples:
## StochasticModel <!-- NOUN -->
- Display name: StochasticModel
- Parent class: ModelType
- Attributes:
- Specialization: 
- Description: 
- Examples:
## TemporalBehaviorModel <!-- NOUN -->
- Display name: Temporal Behavior Model
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model as a function of its temporal behavior.
- Examples:
## SteadyStateModel <!-- NOUN -->
- Display name: Steady state model
- Parent class: TemporalBehaviorModel
- Attributes:
- Specialization: 
- Description: A model for which the state variables do not change with time.
- Examples:
## TransientModel <!-- NOUN -->
- Display name: Transient model
- Parent class: TemporalBehaviorModel
- Attributes:
- Specialization: 
- Description: A model for which the state variables changes with time.
- Examples:
## ModelingApproach <!-- NOUN -->
- Display name: Modeling Approach
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the modeling direction of a model.
- Examples:
## ForwardModel <!-- NOUN -->
- Display name: Forward Model
- Parent class: ModelingApproach
- Attributes:
- Specialization: 
- Description: For a forward model, the inputs are used to predict outputs.
- Examples:
## InversionModel <!-- NOUN -->
- Display name: Inversion Model
- Parent class: ModelingApproach
- Attributes:
- Specialization: 
- Description: For an inversion model, the outputs are used to infer inputs or parameters.
- Examples:
## HybridAnalysisModel <!-- NOUN -->
- Display name: Hybrid Analysis Model
- Parent class: ModelingApproach
- Attributes:
- Specialization: 
- Description: A hybrid analysis model may combine forward and inverse steps in an iterative approach.
- Examples:
## ModelingParadigm <!-- NOUN -->
- Display name: Modeling Paradigm
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the relationship of the model to data or physical laws.
- Examples:
## EmpiricalModel <!-- NOUN -->
- Display name: Empirical Model
- Parent class: ModelingParadigm
- Attributes:
- Specialization: 
- Description: A model that heavily rely on data without using explicitly physical laws.
- Examples:
## MechanisticModel <!-- NOUN -->
- Display name: Mechanistic Model
- Parent class: ModelingParadigm
- Attributes:
- Specialization: 
- Description: A model that is based on first principles or physical laws.
- Examples:
## PhysicsInformedDataDrivenModel <!-- NOUN -->
- Display name: Physics Informed Data Driven Model
- Parent class: ModelingParadigm
- Attributes:
- Specialization: 
- Description: A hybrid model that uses both physical laws and data.
- Examples:
## MathematicalFormulation <!-- NOUN -->
- Display name: Mathematical Formulation
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the mathematical formulation used by a model.
- Examples:
## AlgebraicModel <!-- NOUN -->
- Display name: Algebraic Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses algebraic equations.
- Examples:
## OrdinaryDifferentialEquationModel <!-- NOUN -->
- Display name: Ordinary Differential Equation Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses ordinary differential equations.
- Examples:
## PartialDifferentialEquationModel <!-- NOUN -->
- Display name: Partial Differential Equation Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses partial differential equations.
- Examples:
## IntegralModel <!-- NOUN -->
- Display name: Integral Model
- Parent class: MathematicalFormulation
- Attributes:
- Specialization: 
- Description: A model that uses integral equations.
- Examples:
## ModelingObjective <!-- NOUN -->
- Display name: Modeling Objective
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of the objective/purpose of a model.
- Examples:
## PredictiveModel <!-- NOUN -->
- Display name: Predictive Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that aims to forecast future behavior based on current data or conditions.
- Examples:
## DescriptiveModel <!-- NOUN -->
- Display name: Descriptive Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that seeks to explain or describe a system's behavior or underlying mechanisms.
- Examples:
## CalibrationModel <!-- NOUN -->
- Display name: Calibration Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that focuses on adjusting parameters to improve alignment with observed data.
- Examples:
## ControlModel <!-- NOUN -->
- Display name: Control Model
- Parent class: ModelingObjective
- Attributes:
- Specialization: 
- Description: A model that regulate or steer a system's behavior toward a desired outcome through inputs.
- Examples:
## ModelScope <!-- NOUN -->
- Display name: Model Scope
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model with regards to its range of applicability.
- Examples:
## GeneralModel <!-- NOUN -->
- Display name: General Model
- Parent class: ModelScope
- Attributes:
- Specialization: 
- Description: A model with a broad range of application across various systems or phenomena.
- Examples:
## SpecializedModel <!-- NOUN -->
- Display name: Specialized Model
- Parent class: ModelScope
- Attributes:
- Specialization: 
- Description: A model that is tailored to specific systems, scenarios or conditions.
- Examples:
## ModelTransparency <!-- NOUN -->
- Display name: Model Transparency
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model with regards to its transparency or interpretability.
- Examples:
## BlackBoxModel <!-- NOUN -->
- Display name: Black Box Model
- Parent class: ModelTransparency
- Attributes:
- Specialization: 
- Description: The internal workings of the model are unknown or not interpretable, focusing only on the input-output relationship.
- Examples:
## GrayBoxModel <!-- NOUN -->
- Display name: Gray Box Model
- Parent class: ModelTransparency
- Attributes:
- Specialization: 
- Description: The model combines both data-drive and mechanistic models offering a partial transparency.
- Examples:
## WhiteBoxModel <!-- NOUN -->
- Display name: White Box Model
- Parent class: ModelTransparency
- Attributes:
- Specialization: 
- Description: The model is fully transparent and interpretable, with all internal mechanisms and assumptions clearly defined.
- Examples:
## DataIntegrationStrategy <!-- NOUN -->
- Display name: Data Integration Strategy
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: A classification of a model with regards to its strategy for integrating data.
- Examples:
## DataLevelIntegationModel <!-- NOUN -->
- Display name: Data Level Integation Model
- Parent class: DataIntegrationStrategy
- Attributes:
- Specialization: 
- Description: A model that integrates data at a low-level like direct merging, using data transforms or filtering.
- Examples:
## FeatureLevelIntegationModel <!-- NOUN -->
- Display name: Data Level Integation Model
- Parent class: DataIntegrationStrategy
- Attributes:
- Specialization: 
- Description: A model that integrates data at a medium-level like using feature extraction and merging, reducing dimensionality, 
weighting features, or correlating features.
- Examples:
## DecisionLevelIntegationModel <!-- NOUN -->
- Display name: Data Level Integation Model
- Parent class: DataIntegrationStrategy
- Attributes:
- Specialization: 
- Description: A model that integrates data at a high-level like using majority voting, ensemble methods, Bayesian decision fusion, 
Dempster-Shafer theory.
- Examples:
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
