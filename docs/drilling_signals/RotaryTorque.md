# Rotary torque
## Authors: 
- Author 1
- Author 2

## Modifications
- 15.04.2021: creation

## Signal definition

## Quantity
- The torque quantity is $M\ L^2\ S^{-2}$.
- SI unit is $kg\ m\ s^{-2}$.
- Common units are
  - mN in metric system

## Data representation
Top-drive torque is a scalar value and is therefore represented as such. 

## Information
The reported torque is as a rule the sum of the following effects:
- torque applied to the drillstring
- torque required to overcome inertia of the device
- torque required to overcome internal friction of the device
- torque associated to externally applied forces. 

For downhole monitoring purposes, mainly the first contribution is of interest. 


### AC Electric top-drive
- Sensor type: 
  - the signal is derived from the current consumed by the electric driving system (typically a vfd).
  - The current is measured by hall effect sensors. 
  - It is assumed that torque is proportional to this current. 
  - Two main equations can be used for the torque
    - $\tau = I \dot{\omega}$ where $I$ is the moment of inertia
    - $\tau = \vec{r}   \times \vec {F}$
  - Possible forms:
    - continuous 4mA - 20mA: calibration of end-points and linear interpolation thereafter
    - discrete (calculation by drive based on pre-set parameters)
- Accuracy / uncertainty: 
- Physical location: 
- Logical location:
  - To pumping system:
    - Wash-pipe -> Kelly Hose -> Stand-pipe -> Pump manifold -> Mud pumps
  - To drillstring
    - Quill -> Pipe -> BHA -> Bit
  - To hoisting system:
    - Hook -> Travelling block -> Fast line -> Drawworks
  - To rig structure: 
    - Top-drive frame -> track -> derrick
    - travelling block -> deadline -> dealine anchor
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies: several factors can affect the measure
  - gearbox intrinsic properties: moment of intertia. Moment of intertia should be measured across a range of operation RPMs and RPM differentials
  - gearbox extrinsic properties:
    - wear
    - gear mesh
    - oil viscosisty and lubricity
    - gearbox temperature (changes mesh and oil properties)
  - fluid passthrough properties:
    - pressure, rate, density can cause itnernal components to buckle or experience forces
  - block height: can affect the orientationof the pipe axis to the quill from buckling or eccentric rotation
  - block weight: will affect buckling
  - temperatures:
    - drive system
    - motor internal temperature
- Processing: the following data flow are possible:
  - AC motor -> AC input -> AC Transmission Line -> Variable Frequency Drive (VFD) -> DCS
  - VFD -> PLC -> 4-20mA output -> ADC -> Preprocessing -> Aggregation
  - VFD -> PLC -> COMS -> Aggregation
  - VFD -> Various -> DCS -> COMS -> Aggregation
- Comments: 
  - the considered top-drive is an AC electric top drive. The considerations here may not be applicable fo rDC, Hydraulic, 4-Quadrant drive types. 
  - measured moment of intertia vary significantly (up to 50%) from CAD model
  - Signal to noise ratios low
  - resistance of primary power cable not constant, can add "ghost" loads to torque calculations
  - torque often less accurate at low RPM
  - fluids are non-newtonians (drilling and gear): RPM and temperature should be required for torque calculations. 

## Relevant Vocabulary

## Use-cases

## Comments