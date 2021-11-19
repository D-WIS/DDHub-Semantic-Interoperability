# Open Questions

## Mechanical Model
* Author: Espen Solbu
* Date: Nov 19 - 2021
* Reference to: [MechanicalSoftModel](./definitions/MechanicalModel.md#MechanicalSoftModel)

The models [MechanicalSoftModel](./definitions/MechanicalModel.md#MechanicalSoftModel) and [MechanicalStiffModel](./definitions/MechanicalModel.md#MechanicalStiffModel) are currently children of [MechanicalStiffnessType](./definitions/MechanicalModel.md#MechanicalStiffnessType-) with a dangling reference IsOfMechanicalStiffnessType to these stiffnesstypes from a nonexisting MechanicalModel Noun.

This seems to be invalid according to the 'is_a' rule, and i would think it more logical to subclass these from a MechanicalModel again subclassing Model, but it may be my understanding is lacking. 

![Mechanical Model](./img/Mechanical_Model.png)

Proposal:
![Mechanical Model Proposal](./img/Mechanical_Model_proposal.png)

### Questions

* Is the definition file itself a parent Noun? Aka the "MechanicalModel.md" does that in itself define a MechanicalModel Noun? Or should the MechanicalModel be explicitly defined? if so, in Model.md or in MechanicalModel.md?
* Similarly, should Model be explicitly described? or is this implicit from the Model.md file? Or is the Model noun not needed?
* Is the modelling of MechanicalSoftModel and MechanicalStiffModel as subclass of MechanicalStiffnessType intentional



