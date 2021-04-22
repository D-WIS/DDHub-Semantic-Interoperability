# Mud density
## Authors: 
 - Eric Cayeux
 - Fred Florence
 - Dimitrios P
 - Benoît Daireaux

 ## Modifications
  - 15.04.2021: creation

  ## Signal definition

  ## Quantity
  The fluid density quantity is M L-3.

  SI unit is kg/m3.

  Common units are
   - sg

   ## Information

   ### Mud report density
   - Sensor type: mud balance
   - Accuracy / uncertainty: 50 kg/m3
   - Physical location: main pit
   - Refresh-rate: 
     - North-sea: 6h
     - GOM: 6h
     - US Landrig: 12h
   - Dependencies: sample temperature different from pit temperature. Reported temperature can be another one. Slightly higher than atmosperic to get rid of air bubbles

    ### Coriolis
   - Sensor type: Coriolis flow-meter
   - Pysical location: before charge pump, does not tolerate high pressures
   - Refresh rate: ca 1Hz
   - Validity conditions: Gas presence
   - Processing: temperature corrections
