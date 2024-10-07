- Description: This category defines the vocabulary to describe contextual data.

# NOUNS
## ContextualData <!-- NOUN -->
- Display name: Contextual Data
- Parent class: JSonDataType
- Attributes:
- Specialization:
- Description: Contextual data are structured objects stored in a JSon string.
- Examples:
## Plan <!-- NOUN -->
- Display name: Plan
- Parent class: ContextualData
- Attributes:
- Specialization: A plan is a description of the actions that shall be undertaken to reach an objective
- Description: 
- Examples:
## OperationalPlan <!-- NOUN -->
- Display name: Operational Plan
- Parent class: Plan
- Attributes:
- Specialization: An operational plan is the day-to-day list of activities that shall be performed to contruct a well.
- Description: 
- Examples:
``` dwis operationalPlan_0
DynamicDrillingSignal:operationalPlan_0
OperationalPlan:OperationalPlan_1
OperationalPlan_1 HasDynamicValue operationalPlan_0
OperatingCompany:operatingCompany_1
OperationalPlan_1 IsProvidedBy operatingCompany_1
```
## DrillingProgram <!-- NOUN -->
- Display name: Drilling Program
- Parent class: Plan
- Attributes:
- Specialization: A drilling program is a set of procedures that are necessary to construct a well.
- Description: 
- Examples:
``` dwis drillingProgram_0
DynamicDrillingSignal:drillingProgram_0
DrillingProgram:drillingProgram_1
drillingProgram_1 HasDynamicValue drillingProgram_0
OperatingCompany:operatingCompany_1
drillingProgram_1 IsProvidedBy operatingCompany_1
```
## RigActionPlan <!-- NOUN -->
- Display name: Rig Action Plan
- Parent class: Plan
- Attributes:
- Specialization: A rig action plan is a set of steps and rules that shall be conducted to fulfil a particulat activity when constructing a well.
- Description: 
- Examples:
``` dwis rigActionPlan_0
DynamicDrillingSignal:rigActionPlan_0
RigActionPlan:rigActionPlan_1
rigActionPlan_1 HasDynamicValue rigActionPlan_0
OperatingCompany:operatingCompany_1
rigActionPlan_1 IsProvidedBy operatingCompany_1
DWISScheduler:scheduler_1
rigActionPlan_1 IsProvidedTo scheduler_1
```
## ConfigurationData <!-- NOUN -->
- Display name: Configuration Data
- Parent class: ContextualData
- Attributes:
- Specialization: Configuration data is used to configure a computation unit.
- Description: 
- Examples:
``` dwis configurationData_0
DynamicDrillingSignal:configurationData_0
ConfigurationData:configurationData_1
configurationData_1 HasDynamicValue configurationData_0
OperatingCompany:operatingCompany_1
configurationData_1 IsProvidedBy operatingCompany_1
DWISDrillingProcessStateInterpreter:microStateInterpreter_1
configurationData_1 IsProvidedTo microStateInterpreter_1
configurationData_1 IsLimitFor microStateInterpreter_1
```
## WellBoreData <!-- NOUN -->
- Display name: Wellbore Data
- Parent class: ContextualData
- Attributes:
- Specialization: Wellbore data is used to describe specific elements of a wellbore.
- Description: 
- Examples:
``` dwis wellBoreData_0
DynamicDrillingSignal:wellBoreData_0
WellBoreData:wellBoreData_1
wellBoreData_1 HasDynamicValue wellBoreData_0
OperatingCompany:operatingCompany_1
wellBoreData_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
wellBoreData_1 IsProvidedTo contextualDataBuilder_1
```
## TrajectoryDescription <!-- NOUN -->
- Display name: Trajectory Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: A trajectory contains information about the position of the wellbore.
- Examples:
``` dwis trajectoryDescription_0
DynamicDrillingSignal:trajectoryDescription_0
TrajectoryDescription:trajectoryDescription_1
trajectoryDescription_1 HasDynamicValue trajectoryDescription_0
DirectionalServiceCompany:directionalServiceCompany_1
trajectoryDescription_1 IsProvidedBy directionalServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
trajectoryDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
trajectoryDescription_1 IsCharacterizedBy current_1
Extrapolated: extrapolated_1
trajectoryDescription_1 IsCharacterizedBy extrapolated_1
Measured:measured_1
trajectoryDescription_1 IsCharacterizedBy measured_1
```
## FluidDescription <!-- NOUN -->
- Display name: Fluid Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: Drilling fluid contains information about the density, rheological behavior, thermo-physical and chemical characteristics of a fluid
used during a drilling operation.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
FluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
DrillingFluidProvider:drillingFluidProvider_1
fluidDescription_1 IsProvidedBy drillingFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
fluidDescription_1 IsCharacterizedBy current_1
```
## DrillingFluidDescription <!-- NOUN -->
- Display name: Drilling Fluid Description
- Parent class: FluidDescription
- Attributes:
- Specialization: 
- Description: A drilling fluid is a fluid that is used well 
used during a drilling operation.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
DrillingFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
DrillingFluidProvider:drillingFluidProvider_1
fluidDescription_1 IsProvidedBy drillingFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
fluidDescription_1 IsCharacterizedBy current_1
Measured:measured_1
fluidDescription_1 IsCharacterizedBy measured_1
```
## CementFluidDescription <!-- NOUN -->
- Display name: Cement Fluid Description
- Parent class: FluidDescription
- Attributes:
- Specialization: 
- Description: Cement fluid contains information about the density, rheological behavior and chemical characteristics of fluids
used during a cementing operation, e.g., cement slurry but also spacer.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
CementFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
CementingServiceCompany:cementFluidProvider_1
fluidDescription_1 IsProvidedBy cementFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Measured:measured_1
fluidDescription_1 IsCharacterizedBy measured_1
```
## CompletionFluidDescription <!-- NOUN -->
- Display name: Completion Fluid Description
- Parent class: FluidDescription
- Attributes:
- Specialization: 
- Description: Completion fluid contains information about the density, rheological behavior and chemical characteristics of a 
fluid used during a completion operation.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
CompletionFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
CompletionServiceCompany:completionFluidProvider_1
fluidDescription_1 IsProvidedBy completionFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
fluidDescription_1 IsCharacterizedBy current_1
```
## WellboreArchitectureDescription <!-- NOUN -->
- Display name: Wellbore Architecture Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: The wellbore architecture provides information about the casings and liners in place as well as the current 
open hole configuration. Also the surface architecture, i.e., everything above the wellhead, is also described, e.g., BOP, high 
pressure riser, low pressure riser, expansion joint,...
- Examples:
``` dwis wellBoreArchitectureDescription_0
DynamicDrillingSignal:wellBoreArchitectureDescription_0
WellboreArchitectureDescription:wellBoreArchitectureDescription_1
wellBoreArchitectureDescription_1 HasDynamicValue wellBoreArchitectureDescription_0
OperatingCompany:operatingCompany_1
wellBoreArchitectureDescription_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
wellBoreArchitectureDescription_1 IsProvidedTo contextualDataBuilder_1
Planned:planned_1
wellBoreArchitectureDescription_1 IsCharacterizedBy planned_1
```
## DrillStemDescription <!-- NOUN -->
- Display name: Drill-stem Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: A dill-stem is a generic term for all strings that are run in a borehole. The drill-stem describes the geometrical
and mechanical characteristics of such a string. 
- Examples:
## DrillStringDescription <!-- NOUN -->
- Display name: Drill-string Description
- Parent class: DrillStemDescription
- Attributes:
- Specialization: 
- Description: A drill-string is a drill-stem that is used during a drilling operation. It is composed of drill-pipes, drill-collars,
BHA elements and is terminated either by a bit, a bull-nose, or other special elements such as fishing equipment, etc.
- Examples:
``` dwis drillStringDescription_0
DynamicDrillingSignal:drillStringDescription_0
DrillStringDescription:drillStringDescription_1
drillStringDescription_1 HasDynamicValue drillStringDescription_0
DrillingContractor:drillingContractor_1
drillStringDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
drillStringDescription_1 IsProvidedTo contextualDataBuilder_1
Planned:planned_1
drillStringDescription_1 IsCharacterizedBy planned_1
```
## CasingStringDescription <!-- NOUN -->
- Display name: Casing-string Description
- Parent class: DrillStemDescription
- Attributes:
- Specialization: 
- Description: A casing string is a drill-stem that is used to complete a section. It is composed of casing joints and a shoe track.
- Examples:
``` dwis casingStringDescription_0
DynamicDrillingSignal:casingStringDescription_0
CasingStringDescription:casingStringDescription_1
casingStringDescription_1 HasDynamicValue casingStringDescription_0
DrillingContractor:drillingContractor_1
casingStringDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
casingStringDescription_1 IsProvidedTo contextualDataBuilder_1
Planned:planned_1
casingStringDescription_1 IsCharacterizedBy planned_1
```
## LinerStringDescription <!-- NOUN -->
- Display name: Liner-string Description
- Parent class: DrillStemDescription
- Attributes:
- Specialization: 
- Description: A liner string is a drill-stem that is used to complete a section. It is composed of casing joints, possibly a shoe track
a liner hanger and drill-pipes.
- Examples:
``` dwis linerStringDescription_0
DynamicDrillingSignal:linerStringDescription_0
LinerStringDescription:linerStringDescription_1
linerStringDescription_1 HasDynamicValue linerStringDescription_0
DrillingContractor:drillingContractor_1
linerStringDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
linerStringDescription_1 IsProvidedTo contextualDataBuilder_1
Planned:planned_1
linerStringDescription_1 IsCharacterizedBy planned_1
```
## ProductionStringDescription <!-- NOUN -->
- Display name: Production-string Description
- Parent class: DrillStemDescription
- Attributes:
- Specialization: 
- Description: A production string is a drill-stem that is used to complete a wellbore. It is composed of tubings, expansion joints, 
packers, etc.
- Examples:
``` dwis productionStringDescription_0
DynamicDrillingSignal:productionStringDescription_0
ProductionStringDescription:productionStringDescription_1
productionStringDescription_1 HasDynamicValue productionStringDescription_0
CompletionServiceCompany:completionServiceCompany_1
productionStringDescription_1 IsProvidedBy completionServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
productionStringDescription_1 IsProvidedTo contextualDataBuilder_1
Planned:planned_1
productionStringDescription_1 IsCharacterizedBy planned_1
```
## GeoPressuresDescription <!-- NOUN -->
- Display name: Geo-pressures Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: The geo-pressure data structure describes the pore pressure, collapse pressure, min horizontal stress, fracturing pressure
along the wellbore.
- Examples:
``` dwis geoPressuresDescription_0
DynamicDrillingSignal:geoPressuresDescription_0
GeoPressuresDescription:geoPressuresDescription_1
geoPressuresDescription_1 HasDynamicValue geoPressuresDescription_0
OperatingCompany:operatingCompany_1
geoPressuresDescription_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
geoPressuresDescription_1 IsProvidedTo contextualDataBuilder_1
Prognosed:prognosed_1
geoPressuresDescription_1 IsCharacterizedBy prognosed_1
```
## GeoThermalDescription <!-- NOUN -->
- Display name: Geo-thermal Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: The geothermal data structure describes the temperature and thermophysical properties of the formation encountered
along the wellbore.
- Examples:
``` dwis geoThermalDescription_0
DynamicDrillingSignal:geoThermalDescription_0
GeoThermalDescription:geoThermalDescription_1
geoThermalDescription_1 HasDynamicValue geoThermalDescription_0
OperatingCompany:operatingCompany_1
geoThermalDescription_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
geoThermalDescription_1 IsProvidedTo contextualDataBuilder_1
Prognosed:prognosed_1
geoThermalDescription_1 IsCharacterizedBy prognosed_1
```
## FormationStrengthDescription <!-- NOUN -->
- Display name: Formation strengths Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: The formation strength data structure describes the formation strength and internal friction angle of the formation
encountered along the wellbore.
- Examples:
``` dwis formationStrengthDescription_0
DynamicDrillingSignal:formationStrengthDescription_0
FormationStrengthDescription:formationStrengthDescription_1
formationStrengthDescription_1 HasDynamicValue formationStrengthDescription_0
OperatingCompany:operatingCompany_1
formationStrengthDescription_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
formationStrengthDescription_1 IsProvidedTo contextualDataBuilder_1
Prognosed:prognosed_1
formationStrengthDescription_1 IsCharacterizedBy prognosed_1
```
## StratigraphyDescription <!-- NOUN -->
- Display name: Stratigraphy Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: The stratigraphy data structure describes the type of rock, the porosity, permeability and fluid saturations
of the formation layers that are encountered along the wellbore.
- Examples:
``` dwis stratigraphyDescription_0
DynamicDrillingSignal:stratigraphyDescription_0
StratigraphyDescription:stratigraphyDescription_1
stratigraphyDescription_1 HasDynamicValue stratigraphyDescription_0
LoggingServiceCompany:logginServiceCompany_1
stratigraphyDescription_1 IsProvidedBy logginServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
stratigraphyDescription_1 IsProvidedTo contextualDataBuilder_1
Measured:measured_1
stratigraphyDescription_1 IsCharacterizedBy measured_1
```
## RigDescription <!-- NOUN -->
- Display name: Rig Description
- Parent class: WellBoreData
- Attributes:
- Specialization: 
- Description: The rig data structure describes the characteristics of the drilling equipment and any additional equipment
associated with non-standard drilling methods, e.g., back-pressure MPD, dual-gradient,...
- Examples:
``` dwis rigDescription_0
DynamicDrillingSignal:rigDescription_0
RigDescription:rigDescription_1
rigDescription_1 HasDynamicValue rigDescription_0
DrillingContractor:drillingContractor_1
rigDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
rigDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
rigDescription_1 IsCharacterizedBy current_1
```
## WellBoreDataCharateristic <!-- NOUN -->
- Display name: Wellbore Data Charateristic
- Parent class: DWISNoun
- Attributes:
- Specialization: 
- Description: This Noun is used to characterize a piece of wellbore data.
- Examples:
## Planned <!-- NOUN -->
- Display name: Planned
- Parent class: WellBoreDataCharateristic
- Attributes:
- Specialization: 
- Description: Planned characterizes that the wellbore data is described in its planned stage. This applies to wellbore data
that is intended to be constructed.
- Examples:
``` dwis productionStringDescription_0
DynamicDrillingSignal:productionStringDescription_0
ProductionStringDescription:productionStringDescription_1
productionStringDescription_1 HasDynamicValue productionStringDescription_0
CompletionServiceCompany:completionServiceCompany_1
productionStringDescription_1 IsProvidedBy completionServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
productionStringDescription_1 IsProvidedTo contextualDataBuilder_1
Planned:planned_1
productionStringDescription_1 IsCharacterizedBy planned_1
```
## Prognosed <!-- NOUN -->
- Display name: Prognosed
- Parent class: WellBoreDataCharateristic
- Attributes:
- Specialization: 
- Description: Prognosed characterizes that the wellbore data is described in its prognosed stage. This applies to wellbore
data that exists from before but that may be associated with uncertainty like the geology.
- Examples:
``` dwis stratigraphyDescription_0
DynamicDrillingSignal:stratigraphyDescription_0
StratigraphyDescription:stratigraphyDescription_1
stratigraphyDescription_1 HasDynamicValue stratigraphyDescription_0
OperatingCompany:operatingCompany_1
stratigraphyDescription_1 IsProvidedBy operatingCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
stratigraphyDescription_1 IsProvidedTo contextualDataBuilder_1
Prognosed:prognosed_1
stratigraphyDescription_1 IsCharacterizedBy prognosed_1
```
## Measured <!-- NOUN -->
- Display name: Measured
- Parent class: WellBoreDataCharateristic
- Attributes:
- Specialization: 
- Description: Measured characterizes that the wellbore data has been measured or observed.
- Examples:
``` dwis fluidDescription_0
DynamicDrillingSignal:fluidDescription_0
CementFluidDescription:fluidDescription_1
fluidDescription_1 HasDynamicValue fluidDescription_0
CementingServiceCompany:cementFluidProvider_1
fluidDescription_1 IsProvidedBy cementFluidProvider_1
DWISContextualDataBuilder:contextualDataBuilder_1
fluidDescription_1 IsProvidedTo contextualDataBuilder_1
Measured:measured_1
fluidDescription_1 IsCharacterizedBy measured_1
```
## Current <!-- NOUN -->
- Display name: Current
- Parent class: WellBoreDataCharateristic
- Attributes:
- Specialization: 
- Description: Current characterizes that the wellbore data is the currently selected one as the official one.
- Examples:
``` dwis rigDescription_0
DynamicDrillingSignal:rigDescription_0
RigDescription:rigDescription_1
rigDescription_1 HasDynamicValue rigDescription_0
DrillingContractor:drillingContractor_1
rigDescription_1 IsProvidedBy drillingContractor_1
DWISContextualDataBuilder:contextualDataBuilder_1
rigDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
rigDescription_1 IsCharacterizedBy current_1
```
## Extrapolated <!-- NOUN -->
- Display name: Extrapolated
- Parent class: WellBoreDataCharateristic
- Attributes:
- Specialization: 
- Description: Extrapolated characterizes that the wellbore data is being partially measured/observed and also extended to
positions that have not been measured/observed yet.
- Examples:
``` dwis trajectoryDescription_0
DynamicDrillingSignal:trajectoryDescription_0
TrajectoryDescription:trajectoryDescription_1
trajectoryDescription_1 HasDynamicValue trajectoryDescription_0
DirectionalServiceCompany:directionalServiceCompany_1
trajectoryDescription_1 IsProvidedBy directionalServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
trajectoryDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
trajectoryDescription_1 IsCharacterizedBy current_1
Extrapolated: extrapolated_1
trajectoryDescription_1 IsCharacterizedBy extrapolated_1
Measured:measured_1
trajectoryDescription_1 IsCharacterizedBy measured_1
```
# VERBS
## IsCharacterizedBy <!-- VERB -->
- Display name: Is Characterized By
- Parent verb: DWISVerb
- Subject class: WellBoreData
- Object class: WellBoreDataCharateristic
- Description: this Verb is used to state some characteristics of a well bore data.
- Examples: 
``` dwis trajectoryDescription_0
DynamicDrillingSignal:trajectoryDescription_0
TrajectoryDescription:trajectoryDescription_1
trajectoryDescription_1 HasDynamicValue trajectoryDescription_0
DirectionalServiceCompany:directionalServiceCompany_1
trajectoryDescription_1 IsProvidedBy directionalServiceCompany_1
DWISContextualDataBuilder:contextualDataBuilder_1
trajectoryDescription_1 IsProvidedTo contextualDataBuilder_1
Current:current_1
trajectoryDescription_1 IsCharacterizedBy current_1
Extrapolated: extrapolated_1
trajectoryDescription_1 IsCharacterizedBy extrapolated_1
Measured:measured_1
trajectoryDescription_1 IsCharacterizedBy measured_1
```
