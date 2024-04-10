# Model<!-- DEFINITION SET HEADER -->
- Description: high level and generic vocabulary for mathematical models of the drilling process
# Nouns
## ModelType <!-- NOUN -->
- Display name: ModelType
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Model
## DeterministicModel <!-- NOUN -->
- Display name: DeterministicModel
- Parent class: [ModelType](./Model.md#ModelType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Model
## StochasticModel <!-- NOUN -->
- Display name: StochasticModel
- Parent class: [ModelType](./Model.md#ModelType)
- Attributes:
- Specialization:
- Description: 
- Examples:
- Definition set: Model
## MathematicalModel <!-- NOUN -->
- Display name: Mathematical model
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: A model for which the state variables do not change with time.
- Examples:
- Definition set: Model
## SteadyStateModel <!-- NOUN -->
- Display name: Steady state model
- Parent class: [MathematicalModel](./Model.md#MathematicalModel)
- Attributes:
- Specialization:
- Description: A model for which the state variables do not change with time.
- Examples:
- Definition set: Model
## TransientModel <!-- NOUN -->
- Display name: Transient model
- Parent class: [MathematicalModel](./Model.md#MathematicalModel)
- Attributes:
- Specialization:
- Description: A model for which the state variables changes with time.
- Examples:
- Definition set: Model
## ModelledDegreeOfFreedom <!-- NOUN -->
- Display name: Modelled degree of freedom
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: In physics and chemistry, a degree of freedom is an independent physical parameter in the formal description of the state of a physical system. A model may account for some or all of the degrees of freedom of the physical system.
- Examples:
Axial, rotational...
- Definition set: Model
## AxialModelling <!-- NOUN -->
- Display name: Axial modelling
- Parent class: [ModelledDegreeOfFreedom](./Model.md#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the axial movement of some parts of the physical system.
- Examples:
A hydraulic model accounts for the axial velocity of fluid inside a pipe or an annulus. A torque and drag model accounts for the axial displacement of a drill-stem.
- Definition set: Model
## RotationalModelling <!-- NOUN -->
- Display name: Rotational modelling
- Parent class: [ModelledDegreeOfFreedom](./Model.md#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the rotational movement of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of pipe rotation on the fluid velocity in an annulus. A torque and drag model accounts for the rotational movement of a drill-stem.
- Definition set: Model
## LateralModelling <!-- NOUN -->
- Display name: Lateral modelling
- Parent class: [ModelledDegreeOfFreedom](./Model.md#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the lateral movement of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of the lateral pipe displacement on the fluid velocity in an annulus. A torque and drag model accounts for the lateral  movement of a drill-stem.
- Definition set: Model
## RadialModelling <!-- NOUN -->
- Display name: Radial modelling
- Parent class: [LateralModelling](./Model.md#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the radial movement of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of the radial pipe displacement on the fluid velocity in an annulus. A torque and drag model accounts for the radial  movement of a drill-stem.
- Definition set: Model
## AngularLateralModelling <!-- NOUN -->
- Display name: Angular lateral modelling
- Parent class: [LateralModelling](./Model.md#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the angular lateral movement of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of the pipe wobbling on the fluid velocity in an annulus. A torque and drag model accounts for the wobbling of a drill-stem.
- Definition set: Model
## TangentialModelling <!-- NOUN -->
- Display name: Tangential modelling
- Parent class: [LateralModelling](./Model.md#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of tangential direction of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of the pipe ondulation on the fluid velocity in an annulus. A torque and drag model accounts for the ondulation of a drill-stem.
- Definition set: Model
## VerticalOndulationModelling <!-- NOUN -->
- Display name: Vertical ondulation modelling
- Parent class: [TangentialModelling](./Model.md#TangentialModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of inclination of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of the pipe vertical ondulation on the fluid velocity in an annulus. A torque and drag model accounts for the vertical ondulation of a drill-stem.
- Definition set: Model
## HorizontalOndulationModelling <!-- NOUN -->
- Display name: Horizontal ondulation modelling
- Parent class: [TangentialModelling](./Model.md#TangentialModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of azimuth of some parts of the physical system.
- Examples:
A hydraulic model accounts for the effect of the pipe horizontal ondulation on the fluid velocity in an annulus. A torque and drag model accounts for the horizontal ondulation of a drill-stem.
- Definition set: Model
## ModellingDimensions <!-- NOUN -->
- Display name: Modelling dimensions
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: The number of dimensions that are accounted by the model
- Examples:
- Definition set: Model
## OneDModelling <!-- NOUN -->
- Display name: 1D modelling
- Parent class: [ModellingDimensions](./Model.md#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for one dimension
- Examples:
A hydraulic model only considers the axial direction for the flow in a pipe and in an annulus.
- Definition set: Model
## TwoDModelling <!-- NOUN -->
- Display name: 2D modelling
- Parent class: [ModellingDimensions](./Model.md#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for two dimensions
- Examples:
A hydraulic calculation considers the fluid velocity field in a cross-section but does not consider the axial direction. A heat transfer model considers the radial and axial heat transfer but assumes complete angular symmetry.
- Definition set: Model
## ThreeDModelling <!-- NOUN -->
- Display name: 3D modelling
- Parent class: [ModellingDimensions](./Model.md#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for three dimensions
- Examples:
A hydraulic calculation considers the fluid velocity field in a cross-section and in the axial direction. A heat transfer model considers the radial, angular and axial heat transfer.
- Definition set: Model
## ModellingDiscretization <!-- NOUN -->
- Display name: Modelling discretization
- Parent class: [DWISNoun](./DWISSemantics.md#DWISNoun)
- Attributes:
- Specialization:
- Description: A characteristic of the discretization made by the model.
- Examples:
- Definition set: Model
## BoundaryDiscretization <!-- NOUN -->
- Display name: Boundary discretization
- Parent class: [ModellingDiscretization](./Model.md#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model only considers the bounds of the physical system and does not apply any intermediate discretization.
- Examples:
The Kaasa model (https://doi.org/10.2118/143097-PA) is an example of hydraulic model that only accounts for the boundaries and does not utilize any intermediate discretization.
- Definition set: Model
## StrainWaveBasedDiscretization <!-- NOUN -->
- Display name: Strain-wave based discretization
- Parent class: [ModellingDiscretization](./Model.md#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model can properly estimate values at the level of strain wave propagation.
- Examples:
A transient mechanical model that is compatible with modelling acoustic waves in the drill-string.
- Definition set: Model
## MassTransferBasedDiscretization <!-- NOUN -->
- Display name: Elasticity based discretization
- Parent class: [ModellingDiscretization](./Model.md#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model can properly estimate values at the level of mass transfer propagation.
- Examples:
A transient mechanical model that is compatible with modelling axial, rotationa and lateral drill-string displacement. A transient hydraulic model that is compatible with modelling fluid mass transfer inside the string and the annulus.
- Definition set: Model
# Verbs
