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
	DrillPipesAnnular_0([DrillPipesAnnular_0]) --> DrillPipesAnnular:::classDef[[DrillPipesAnnular]]
	BellNipple_0([BellNipple_0]) --> BellNipple:::classDef[[BellNipple]]
	BHAAnnular_0([BHAAnnular_0]) --> BHAAnnular:::classDef[[BHAAnnular]]
	Bit_0([Bit_0]) --> Bit:::classDef[[Bit]]
	OpenHole_0([OpenHole_0]) --> OpenHole:::classDef[[OpenHole]]
	BHAInner_0([BHAInner_0]) --> BHAInner:::classDef[[BHAInner]]
	DrillPipesInner_0([DrillPipesInner_0]) --> DrillPipesInner:::classDef[[DrillPipesInner]]
	UnderReamer_0([UnderReamer_0]) --> UnderReamer:::classDef[[UnderReamer]]
	TopDrive_0([TopDrive_0]) --> TopDrive:::classDef[[TopDrive]]
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
