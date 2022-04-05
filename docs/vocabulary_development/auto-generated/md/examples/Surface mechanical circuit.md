# Surface mechanical circuit
- ActiveLine:ActiveLine_0
- DrawWorks:DrawWorks_0
- CrownBlock:CrownBlock_0
- DeadLine:DeadLine_0
- SupportLine:SupportLine_0
- DrawWorks:DrawWorks_1
- Dolly:Dolly_0
- DollyRail:DollyRail_0
- Elevator:Elevator_0
- DrillString:DrillString_0
- TravellingBlock:TravellingBlock_0
- TopDriveBody:TopDriveBody_0
- TopDriveShaft:TopDriveShaft_0
- TopDriveHook:TopDriveHook_0
- ActiveLine_0 IsMechanicallyConnectTo DrawWorks_0
- CrownBlock_0 IsMechanicallyConnectTo ActiveLine_0
- CrownBlock_0 IsMechanicallyConnectTo DeadLine_0
- CrownBlock_0 IsMechanicallyConnectTo SupportLine_0
- DeadLine_0 IsMechanicallyConnectTo DrawWorks_1
- Dolly_0 IsMechanicallyConnectTo DollyRail_0
- Elevator_0 IsMechanicallyConnectTo DrillString_0
- SupportLine_0 IsMechanicallyConnectTo TravellingBlock_0
- TopDriveBody_0 IsMechanicallyConnectTo Dolly_0
- TopDriveBody_0 IsMechanicallyConnectTo Elevator_0
- TopDriveBody_0 IsMechanicallyConnectTo TopDriveShaft_0
- TopDriveHook_0 IsMechanicallyConnectTo TopDriveBody_0
- TopDriveShaft_0 IsMechanicallyConnectTo DrillString_0
- TravellingBlock_0 IsMechanicallyConnectTo TopDriveHook_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	ActiveLine_0([ActiveLine_0]) --> ActiveLine:::classDef[[ActiveLine]]
	DrawWorks_0([DrawWorks_0]) --> DrawWorks:::classDef[[DrawWorks]]
	CrownBlock_0([CrownBlock_0]) --> CrownBlock:::classDef[[CrownBlock]]
	DeadLine_0([DeadLine_0]) --> DeadLine:::classDef[[DeadLine]]
	SupportLine_0([SupportLine_0]) --> SupportLine:::classDef[[SupportLine]]
	DrawWorks_1([DrawWorks_1]) --> DrawWorks:::classDef[[DrawWorks]]
	Dolly_0([Dolly_0]) --> Dolly:::classDef[[Dolly]]
	DollyRail_0([DollyRail_0]) --> DollyRail:::classDef[[DollyRail]]
	Elevator_0([Elevator_0]) --> Elevator:::classDef[[Elevator]]
	DrillString_0([DrillString_0]) --> DrillString:::classDef[[DrillString]]
	TravellingBlock_0([TravellingBlock_0]) --> TravellingBlock:::classDef[[TravellingBlock]]
	TopDriveBody_0([TopDriveBody_0]) --> TopDriveBody:::classDef[[TopDriveBody]]
	TopDriveShaft_0([TopDriveShaft_0]) --> TopDriveShaft:::classDef[[TopDriveShaft]]
	TopDriveHook_0([TopDriveHook_0]) --> TopDriveHook:::classDef[[TopDriveHook]]
	 ActiveLine_0 -- IsMechanicallyConnectTo --> DrawWorks_0 
	 CrownBlock_0 -- IsMechanicallyConnectTo --> ActiveLine_0 
	 CrownBlock_0 -- IsMechanicallyConnectTo --> DeadLine_0 
	 CrownBlock_0 -- IsMechanicallyConnectTo --> SupportLine_0 
	 DeadLine_0 -- IsMechanicallyConnectTo --> DrawWorks_1 
	 Dolly_0 -- IsMechanicallyConnectTo --> DollyRail_0 
	 Elevator_0 -- IsMechanicallyConnectTo --> DrillString_0 
	 SupportLine_0 -- IsMechanicallyConnectTo --> TravellingBlock_0 
	 TopDriveBody_0 -- IsMechanicallyConnectTo --> Dolly_0 
	 TopDriveBody_0 -- IsMechanicallyConnectTo --> Elevator_0 
	 TopDriveBody_0 -- IsMechanicallyConnectTo --> TopDriveShaft_0 
	 TopDriveHook_0 -- IsMechanicallyConnectTo --> TopDriveBody_0 
	 TopDriveShaft_0 -- IsMechanicallyConnectTo --> DrillString_0 
	 TravellingBlock_0 -- IsMechanicallyConnectTo --> TopDriveHook_0 
```
