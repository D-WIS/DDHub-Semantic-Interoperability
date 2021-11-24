# Mechanical circuit
## Authors: 
- Author 1
- Author 2

## Modifications
- 31.05.2021: creation


## Vocabulary

### Nodes

#### Abstract nodes
- Mechanical Element

#### Concrete nodes

- Crown blocks
- Drill-line
- Travelling blocks
- Hook
- Top-drive pins
- Top-drive
- Elevator
- Saver-sub
- Dolly
- Dolly rail
- Rig
- Dead-line
- Dead-line anchor
- Active line
- Draw-work drum
- Draw-work gear box
- Draw-work motor
- BHA
- Bit


### Relations
- IsMechanicallyConnectedTo : there is a direct mechanical dependency between the two elements. The tension and/or torque of one element is affected by the other. At the most generic level, this relation is bi-directional (symmetric). 
- IsPartOfMechanicalElement: represents an inclusion relation. The object is  made of several sub-components, and the subject is one of those components. This relation implies inclusion, and not only non-empty intersection. 


## Comments

One may want to achieve multi-resolution description of the mechanical circuit (hence the IsPartOfMechanicalElement relation). For example:
- one downhole signal may be specified to be located within the BHA, while another is stated to be at the MWD. It is important there to understand that the second one is also within the BHA.