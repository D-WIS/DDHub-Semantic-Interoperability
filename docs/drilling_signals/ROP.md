# ROP
## Authors: 
- Author 1
- Author 2

## Modifications
- 31.05.2021: creation

## Signal definition
From [Schlumberger Oilfield dictionary](https://glossary.oilfield.slb.com/en/terms/r/rate_of_penetration):

> The speed at which the drill bit can break the rock under it and thus deepen the wellbore. This speed is usually reported in units of feet per hour or meters per hour.

## Quantity
- The ROP is a velocity $L T^{-1}$
- SI unit is m/s.
- Common units are
  - m/h
  - ft/h

## Data representation

The ROP is a scalar. 

## Information

Computation of the ROP is complex. 
It is in essence nothing more than the time derivative of the hole depth:
- either the *instantaneous* derivative
- either the *average* derivative. Note that the average is taken using a depth based window, only containing data points where the system is actually drilling. The semantic of the average ROP can be difficult to express. 
 
 The hole depth, in turn, is also the result of an advanced computation:
 - at time $t$, the hole depth $h_t$ is the maximum of the hole depth $h_{t-1}$ and of the bit depth $d_t$. 
 - it therefore depends on an initial hole depth $h_0$. 
 - the bit depth can be computed assuming an infinitely stiff (no length modification based on tension, torque or temperature effects) that nevertheless perfectly follows the centerline of the wellbore. With those assumptions, the bit location is the result of a translation of the top of the drill-string along the well path by an amount corresponding to the total length of the string
 - the top of the string $s_t$ is:
   -  the hook position $h_t$ if the hook is connected to the string
   -  the previous value $s_{t-1}$ else. 
   -  the connection status can be deduced from the hookload
-  the total string length $l_t$ is equal to:
   - its previous value $l_{t-1}$ if the hook is connected and was connected at time $t-1$ or if the hook is disconnected
   - its previous value $l_{t-1}$ plus a length difference $\Delta l$ corresponding to the amount of pipe added or removed during a connection. This occurs when the hook is connected at time $t$ but was not connected at time $t-1$
    - the length difference $\Delta l$ is the difference in hook positions at time:
      - when the connection status switches from true to false
      - when the connection status switches from false to true. 

As a result, the following signals are used in the determination of the ROP
- hole depth
- initial hole depth
- bit depth
- initial drill string length
- hook position
- connection status:
  - hookload
  - empty block weight

### Instantaneous ROP
- Sensor type: N/A (ROP is never measured)
- Accuracy / uncertainty: 
- Physical location: 
- Logical location: at the hole bottom
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies: 
- Processing: 
- Comments

### Average ROP
- Sensor type: N/A (ROP is never measured)
- Accuracy / uncertainty: 
- Physical location: 
- Logical location: at the hole bottom
- Validity:
- Maintenance / calibration:
- Refresh-rate: 
- Dependencies: 
- Processing: 
- Comments

## Relevant Vocabulary

## Use-cases

## Comments