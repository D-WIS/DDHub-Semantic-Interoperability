# Hookload
## Authors: 
- Author 1
- Author 2

## Modifications
- 31.05.2021: creation

## Signal definition
From [Schlumberger Oilfield Glossary](https://glossary.oilfield.slb.com/en/terms/h/hook_load)

> The total force pulling down on the hook. This total force includes the weight of the drillstring in air, the drill collars and any ancillary equipment, reduced by any force that tends to reduce that weight. Some forces that might reduce the weight include friction along the wellbore wall (especially in deviated wells) and, importantly, buoyant forces on the drillstring caused by its immersion in drilling fluid. If the BOPs are closed, any pressure in the wellbore acting on the cross-sectional area of the drillstring in the BOPs will also exert an upward force.


## Quantity
- The hookload is a force ($M L T^{-2}$)
- It is however often represented as a mass
- SI unit is kg.
- Common units are
  - t

## Data representation

The hookload is a scalar. 

## Information

### Sensor type 1
- Sensor type: 
- Accuracy / uncertainty: 
  - accuracy of the signal varies greatly
  - It is influenced by (depends on the type of signal) 
    -  shieve friction
    -  stick/slip in the hoisting system
    -  block weight
    -  mud hose weight
- Physical locations: 
  - Dead-line anchor
  - Dead-line
  - Saver-sub
  - Top-drive pins
  - Crown blocks 
- Logical location: depends on the presence of correction or not
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
  - The original signal is synchronous
- Dependencies:
- Processing: 
  - Corrections:
    - Addition / removal of empty block weight (often static value)  
- Comments

## Relevant Vocabulary

## Use-cases

## Comments