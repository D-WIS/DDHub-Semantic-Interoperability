# Mud rheology
## Authors: 
- Eric Cayeux
- Fred Florence
- Benoît Daireaux

## Modifications
- 22.04.2021: creation
- 29.04.2021: edition

## Signal definition
From [Schlumberger Oilfield Glossary](https://www.glossary.oilfield.slb.com/en/terms/r/rheology), the definition of rheology for drilling fluids

>The science and study of the deformation and flow of matter. The term is also used to indicate the properties of a given fluid, as in mud rheology. Rheology is an extremely important property of drilling muds, drill-in fluids, workover and completion fluids, cements and specialty fluids and pills. Mud rheology is measured on a continual basis while drilling and adjusted with additives or dilution to meet the needs of the operation. In water-base fluids, water quality plays an important role in how additives perform. Temperature affects behavior and interactions of the water, clay, polymers and solids in a mud. Downhole pressure must be taken into account in evaluating the rheology of oil muds.

From [Schlumberger Oilfield Glossary](https://www.glossary.oilfield.slb.com/en/terms/r/rheological_property), the definition of rheological properties for drilling fluids

>One of several flow characteristics of a material, such as a drilling fluid, completion fluid, workover fluid or cement. Shear-stress measurements made at a minimum of two shear rates are needed to define the properties of these oilfield fluids. Three parameters are sometimes used to better define fluid behavior. "Rheological properties" most often refers to the Bingham plastic fluid parameters, PV (plastic viscosity) and YP (yield point), as measured by the direct-indicating rheometer. The power-law fluid model parameters, exponent (n) and consistency (k), apply to polymer muds, although the three-parameter Herschel-Bulkley model is a better fit to polymer muds. Brookfield viscometers measure flow properties at low shear rates to determine suspension and transport of cuttings in high-angle holes.


## Quantity
The rheology is often represented by a series of measurements that associate a shear stress to a shear rate. 
- Shear stress is a pressure, in Pascal
- Shear rate is expressed in reciprocal seconds (1/s). 

Alternative representations refer to parameters of rheological models:
- Bingham plastic: plastic viscosity and yield point
- Power law: exponent and consistency
- Herschel-Bulkley: yield stress, consistency index and exponent. 

## Data representation
Given that mud rheology can be expressed in several ways, one can find many representations. 
- Rheometer measurements. 
The most standard way is to report rheometer readings: shear stresses for different shear rates. 
Typical shear rates are: 
- 3, 6, 100, 200, 300, 600


## Information

### Mud report rheology
- Sensor type: Fann35 rheometer
- Accuracy / uncertainty: 
- Physical location: 
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies:
- Processing: 
- Comments

### Intelligent Mud Systems
- Sensor type: diffential pressure sensors
  -  2 pipes, vertical and horizontal. 
  -  Horizontal pipe: Several flow-rates -> several pressures, estimation of HB parameters
  -  Vertical pipe: deduce density from pressure difference and vertical pressure losses
- Accuracy / uncertainty: 
  - Density
  - Rheology  
- Physical location: 
  - Standard from the pit
  - Can measure mud out properties  
- Logical location:
- Validity: during transient changes (changes in properties) HB fitting can look strange
- Maintenance / calibration: after reset results unaccurate
- Refresh-rate: 
  - initial measurement 30 minutes
  - subsequent measurements: continuous, but still 30 minutes to cover flow-rate range
- Dependencies:
  - temperature: pit temperature
  - pressure: low
- Processing: 
  - Coriolis -> flow-rate, density
  - pressure drop
  - enough points: HB 
  - Reconstruct Fann35 data
  - Extrapolates at 50C
- Comments: 
  - provide only equivalent Fann35 measurements (3,6,*10,20*,30,60,100,200,300,600).
  - One tag per equivalent shear stress
  - They also report the temperature
  - provides extrapolated Fann35 readings at 50C. 

### Baker tool (find another name)
- Sensor type: differential pressure, at least horizontal pipe. 
- Accuracy / uncertainty: 
- Physical location: 
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies:
- Processing: 
- Comments

### Baralogix
- Sensor type: 
  - Couette type. 
  - Anton Paar rheometer.  
  - Rotate the bob and measure torque on bob (not exactly Fann35 functioning). Air bearings are used for the bob. 
- Accuracy / uncertainty: 
  - torque measurements: very precise...
- Physical location: 
  - Small ca 2x2x2ft 
  - Easy to place anywhere...
  - Example: close to charge pump 
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies: 
  - mud is temperature controlled, 50C. 120 F. 
  - Any speed can be used (no predefined shear rates). 
- Processing: 
  - Measures torque 
  - Conversions rpm -> rate and torque stress assume constant conversion factors, only valid for newtonian fluids... 
- Comments: 
  - provided by Halliburton, here is a [link](https://www.halliburton.com/en/products/baralogix)
  - Need to wash the cup between each measure. 
  - Provide by default the standard Fann35
  - Can provide HB, BP and Power law parameters. 

### MI-Swacco
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

### NOV
- Sensor type: 
  - Couette rheometer
  - TT100
- Accuracy / uncertainty: 
- Physical location: 
- Logical location:
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies:
- Processing: 
- Comments

## Relevant Vocabulary

## Use-cases

## Comments
