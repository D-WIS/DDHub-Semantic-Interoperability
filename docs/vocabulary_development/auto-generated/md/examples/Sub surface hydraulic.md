# Sub surface hydraulic
- DrillPipesAnnular:DrillPipesAnnular_0
- BellNipple:BellNipple_0
- BHAAnnular:BHAAnnular_0
- Bit:Bit_0
- OpenHole:OpenHole_0
- BHAInner:BHAInner_0
- DrillPipesInner:DrillPipesInner_0
- UnderReamer:UnderReamer_0
- TopDrive:TopDrive_0
- DrillPipesAnnular_0 IsHydraulicConnectedTo BellNipple_0
- BHAAnnular_0 IsHydraulicConnectedTo DrillPipesAnnular_0
- Bit_0 IsHydraulicConnectedTo BHAAnnular_0
- Bit_0 IsHydraulicConnectedTo OpenHole_0
- BHAInner_0 IsHydraulicConnectedTo Bit_0
- DrillPipesInner_0 IsHydraulicConnectedTo UnderReamer_0
- TopDrive_0 IsHydraulicConnectedTo DrillPipesInner_0
- UnderReamer_0 IsHydraulicConnectedTo DrillPipesAnnular_0
- UnderReamer_0 IsHydraulicConnectedTo BHAInner_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	DrillPipesAnnular_0([DrillPipesAnnular_0]) --> DrillPipesAnnular[[DrillPipesAnnular]]:::typeClass
	BellNipple_0([BellNipple_0]) --> BellNipple[[BellNipple]]:::typeClass
	BHAAnnular_0([BHAAnnular_0]) --> BHAAnnular[[BHAAnnular]]:::typeClass
	Bit_0([Bit_0]) --> Bit[[Bit]]:::typeClass
	OpenHole_0([OpenHole_0]) --> OpenHole[[OpenHole]]:::typeClass
	BHAInner_0([BHAInner_0]) --> BHAInner[[BHAInner]]:::typeClass
	DrillPipesInner_0([DrillPipesInner_0]) --> DrillPipesInner[[DrillPipesInner]]:::typeClass
	UnderReamer_0([UnderReamer_0]) --> UnderReamer[[UnderReamer]]:::typeClass
	TopDrive_0([TopDrive_0]) --> TopDrive[[TopDrive]]:::typeClass
	 DrillPipesAnnular_0 -- IsHydraulicConnectedTo --> BellNipple_0 
	 BHAAnnular_0 -- IsHydraulicConnectedTo --> DrillPipesAnnular_0 
	 Bit_0 -- IsHydraulicConnectedTo --> BHAAnnular_0 
	 Bit_0 -- IsHydraulicConnectedTo --> OpenHole_0 
	 BHAInner_0 -- IsHydraulicConnectedTo --> Bit_0 
	 DrillPipesInner_0 -- IsHydraulicConnectedTo --> UnderReamer_0 
	 TopDrive_0 -- IsHydraulicConnectedTo --> DrillPipesInner_0 
	 UnderReamer_0 -- IsHydraulicConnectedTo --> DrillPipesAnnular_0 
	 UnderReamer_0 -- IsHydraulicConnectedTo --> BHAInner_0 
```
