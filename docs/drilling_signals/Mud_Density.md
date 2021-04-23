# Mud density
## Authors: 
- Eric Cayeux
- Fred Florence
- Dimitrios Pirovolou
- Benoît Daireaux

## Modifications
- 15.04.2021: creation

## Signal definition
From [Schlumberger Oilfield Glossary](https://www.glossary.oilfield.slb.com/en/terms/m/mud_density)

> The mass per unit volume of a drilling fluid, synonymous with mud weight. Weight is reported in lbm/gal (also known as ppg), kg/m3 or g/cm3 (also called specific gravity or SG), lb/ft3 or in hydrostatic gradient, lb/in2/ft (psi/ft) or pptf (psi/1000 ft). Mud weight controls hydrostatic pressure in a wellbore and prevents unwanted flow into the well. The weight of the mud also prevents collapse of casing and the openhole. Excessive mud weight can cause lost circulation by propagating, and then filling, fractures in the rock. Mud weight (density) test procedures using a mud balance have been standardized and published by the API.
 
### Formal definition
- mud density is a property of the **drilling fluid**
- mud density is measured between the active pit and the drillstring inlet

## Quantity
- The fluid density quantity is M L-3.
- SI unit is kg/m3.
- Common units are
  - sg

## Data representation
Mud density is a scalar and therefore represented as such. 
If dependency to pressure and/or temperature were represented, tabular versions would exist but it is never available. 
## Information

### Mud report density
- Sensor type: mud balance 
- Accuracy / uncertainty: 50 kg/m3
- Physical location: main pit
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
  - North-sea: 6h
  - GOM: 6h
  - US Landrig: 12h
- Dependencies: sample temperature different from pit temperature. Reported temperature can be another one. Slightly higher than atmosperic to get rid of air bubbles
- Processing
- Comments

### Coriolis
- Sensor type: coriolis flow-meter 
- Accuracy / uncertainty: 50 kg/m3
- Physical location: before charge pump, does not tolerate high pressures
- Logical location:
- Validity: Gas presence
- Maintenance / calibration:
- Refresh-rate: approx. 1Hz 
- Dependencies: sample temperature different from pit temperature. Reported temperature can be another one. Slightly higher than atmosperic to get rid of air bubbles
- Processing: temperature corrections
- Comments

### Differential pressure 
- Sensor type: differential pressure sensors
  - Vertical pipes
  - Coil
- Accuracy / uncertainty: 
- Physical location: active pit
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies: the measurement depends on the flow-rate
- Processing: Flow-rate corrections
- Comments

### Buoyancy measurements
- Sensor type: 
- Accuracy / uncertainty: 
- Physical location: 
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies:
- Processing: 
- Comments

### Pipe total weight
- Sensor type: weight sensor. pipe + mud
- Accuracy / uncertainty: 
- Physical location: flow-line
- Logical location:
- Validity:
- Maintenance / calibration: cuttings accumulation
- Refresh-rate: 
- Dependencies:
- Processing: 
- Comments

### Gamma ray
- Sensor type: gamma ray sensor 
- Accuracy / uncertainty: 
- Physical location: stand-pipe
- Logical location:
- Validity:
- Maintenance / calibration: manual calibration, usually not reported
- Refresh-rate: 
- Dependencies:
- Processing: 
- Comments

### Vibrating tube
- Sensor type: vibrating tube
- Accuracy / uncertainty: 0.01 kg/m3
- Physical location: 
- Logical location:
- Validity:
- Maintenance / calibration: mud coating on tube. Cleaning of tubes
- Refresh-rate: 
- Dependencies:
- Processing: temperature corrections
- Comments
