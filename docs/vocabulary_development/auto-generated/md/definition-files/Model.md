# Model<!-- DEFINITION SET HEADER -->
- Description: high level and generic vocabulary for mathematical models of the drilling process
# Nouns
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
- Definition set: Model
## AxialModelling <!-- NOUN -->
- Display name: Axial modelling
- Parent class: [ModelledDegreeOfFreedom](./Model.md#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the axial movement of some parts of the physical system.
- Examples:
- Definition set: Model
## RotationalModelling <!-- NOUN -->
- Display name: Rotational modelling
- Parent class: [ModelledDegreeOfFreedom](./Model.md#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the rotational movement of some parts of the physical system.
- Examples:
- Definition set: Model
## LateralModelling <!-- NOUN -->
- Display name: Lateral modelling
- Parent class: [ModelledDegreeOfFreedom](./Model.md#ModelledDegreeOfFreedom)
- Attributes:
- Specialization:
- Description: The model accounts for the lateral movement of some parts of the physical system.
- Examples:
- Definition set: Model
## RadialModelling <!-- NOUN -->
- Display name: Radial modelling
- Parent class: [LateralModelling](./Model.md#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the radial movement of some parts of the physical system.
- Examples:
- Definition set: Model
## AngularLateralModelling <!-- NOUN -->
- Display name: Angular lateral modelling
- Parent class: [LateralModelling](./Model.md#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the angular lateral movement of some parts of the physical system.
- Examples:
- Definition set: Model
## TangentialModelling <!-- NOUN -->
- Display name: Tangential modelling
- Parent class: [LateralModelling](./Model.md#LateralModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of tangential direction of some parts of the physical system.
- Examples:
- Definition set: Model
## VerticalOndulationModelling <!-- NOUN -->
- Display name: Vertical ondulation modelling
- Parent class: [TangentialModelling](./Model.md#TangentialModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of inclination of some parts of the physical system.
- Examples:
- Definition set: Model
## HorizontalOndulationModelling <!-- NOUN -->
- Display name: Horizontal ondulation modelling
- Parent class: [TangentialModelling](./Model.md#TangentialModelling)
- Attributes:
- Specialization:
- Description: The model accounts for the change of azimuth of some parts of the physical system.
- Examples:
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
- Definition set: Model
## TwoDModelling <!-- NOUN -->
- Display name: 2D modelling
- Parent class: [ModellingDimensions](./Model.md#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for two dimensions
- Examples:
- Definition set: Model
## ThreeDModelling <!-- NOUN -->
- Display name: 3D modelling
- Parent class: [ModellingDimensions](./Model.md#ModellingDimensions)
- Attributes:
- Specialization:
- Description: The model only accounts for three dimensions
- Examples:
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
- Definition set: Model
## StrainWaveBasedDiscretization <!-- NOUN -->
- Display name: Strain-wave based discretization
- Parent class: [ModellingDiscretization](./Model.md#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model can properly estimate values at the level of strain wave propagation.
- Examples:
- Definition set: Model
## MassTransferBasedDiscretization <!-- NOUN -->
- Display name: Elasticity based discretization
- Parent class: [ModellingDiscretization](./Model.md#ModellingDiscretization)
- Attributes:
- Specialization:
- Description: A model can properly estimate values at the level of mass transfer propagation.
- Examples:
- Definition set: Model
# Verbs
