# Use cases
Below is a list of relevant use-cases for the D-WIS project. 

## Accelerometer data
### Application side: 
data consumer
### Description: 
An application wants to access accelerometer data in real-time if possible at multiple locations along the drill-string/BHA.
The acceleration measurements shall be triaxial and unprocessed.
The measurement sampling rate shall be greater than 120Hz and the precision of the acceleration shall be better than 0.05g. However, measurements can arrive grouped but there shall be a time continuity.
Possible arrangements of sensors are: multiple triaxial accelerometers, e.g. 3 at 120deg from each others, or a single accelerometer and a measurement of rotational speed. In the single accelerometer configuration, the accelerometer can be either centered or eccentric.


## Flow-rate for gain/loss
### Application side:
data consumer
### Description:
An application wants to access information about the flow-rate out of the well for automatic gain/loss detection.
It can utilize the active pit volume or the trip-tank volume if it is lined up
It can utilize readings from a flow-paddle
Or it can utilize a volumetric flow-rate. However, it needs to be able to distinguish between a volumetric flow-rate that is estimated, for instance by conversion of the flow-paddle readings, from a volumetric flow-rate that is actually measured, like by combining a mass flow-rate and mass density measurement


## Survey stations for mico-tortuousity
### Application side:
data consumer
### Description
An application analyzes micro-tortuousity while drilling.
It needs access to survey stations whenever they are taken and continous inclination and azimuth readings. To correlate the bit depth of continuous readings, it needs to know if these information are transmitted by mud pulse or by high speed telemetry.


## Depths calculations
### Application side:
data producer
### Description:
An application produces an estimated bit and bottom hole depth. The estimation accounts for the elasticity of the drill-string, effect of pressure and circulation, residual heave movement on a floater, elasticity of the drill-line with a draw-works, temperature expansion of tubulars. It wants the provided information to be interpreted correctly by third parties, so that they don't apply redundant corrections. '


## Mechanical calculations
### Application side:
data producer
### Description:
An application produces estimations all along the drill-string of tension/compression, torque and bending moment as well as axial, torsional and lateral positions of contact points (typically the tool-joints for drill-pipes and HWDP). The generated information is available at 100Hz.


## SPP validity
### Application side:
data consumer
### Description
I am monitoring the SPP to react to abnormal situations. 
A directional drilling company uses flow-rate modulation to communicate with the RSS. The flow-rate perturbation are not reported.  It results in SPP variations that cannot be associated to traditional excitements: pump-rate, block movement, rotation. 
I need to know something outside the reach of the analysis is happening in order to deactivate the system. 
Also has to do with gain/loss, and several other areas. 


## Hookload sensor calibration
### Application side:
data consumer
### Description:
I monitor and analyze the hookload. During the course of the operations, the drilling crew decided to re-calibrate the hookload sensor. As a result, a shift of 15 tons suddenly takes place. I need help. 


## Pit activity and set-up
### Application side:
data consumer
### Description:
I have developed an advanced and accurate gain/loss detection based on volume analysis.
I trigger false alarms each time the crew is transferring into the active pit. How do I know this is happening?
I get confused analyzing the main pit volume, while the flow is directly returning to the trip tank. How do I know which pit is aligned? How do I know that the path between the well and the pit is different?

## Flow-rate in for FDIR
### Application side:
data consumer
### Description:
I develop an application that controls/analyzes the pump-rate at low flow-rates (pipe filling, gel breaking). I need to know how the flow-rate is measured to adjust some thresholds on SPP analysis. If a stroke counter is used, then I need to account for possible SPP without recorded flow. I need to account for flow-rate uncertainty. 


## Surveying precision
### Application side:
data consumer
### Description:
I need to account for trajectory uncertainty. In order to reconstruct the ellipsoid of uncertainty for each survey station, I need as precise as possible information about the instrument performance characteristic. 


## FDIR data
### Application side:
data producer
### Description
An application produces operational limits as a combination of Flowrate, RPM, Density and Hook Load. 
Another application triggers alarms when the current drilling parameters are outside the operational limits.  


## KPI analysis
### Application side:
data consumer
### Description
An application wants to access all the measurements that are provided by a given data-provider, sort them by their physical quantities, and estimate their sampling rate and latency (also for bulk data). Eventually determine their validity as well.


## Use case
### Application side
### Description

## Use case
### Application side
### Description

## Use case
### Application side
### Description
