# Surface mechanical circuit
- ActiveLine:ActiveLine_0
- Drawworks:Drawworks_0
- CrownBlock:CrownBlock_0
- DeadLine:DeadLine_0
- SupportLine:SupportLine_0
- Drawworks:Drawworks_1
- Dolly:Dolly_0
- DollyRail:DollyRail_0
- Elevator:Elevator_0
- DrillString:DrillString_0
- TravellingBlock:TravellingBlock_0
- MainframeAssembly:MainframeAssembly_0
- Quill:Quill_0
- LoadNut:LoadNut_0
- ActiveLine_0 IsMechanicallyConnectTo Drawworks_0
- CrownBlock_0 IsMechanicallyConnectTo ActiveLine_0
- CrownBlock_0 IsMechanicallyConnectTo DeadLine_0
- CrownBlock_0 IsMechanicallyConnectTo SupportLine_0
- DeadLine_0 IsMechanicallyConnectTo Drawworks_1
- Dolly_0 IsMechanicallyConnectTo DollyRail_0
- Elevator_0 IsMechanicallyConnectTo DrillString_0
- SupportLine_0 IsMechanicallyConnectTo TravellingBlock_0
- MainframeAssembly_0 IsMechanicallyConnectTo Dolly_0
- MainframeAssembly_0 IsMechanicallyConnectTo Elevator_0
- MainframeAssembly_0 IsMechanicallyConnectTo Quill_0
- LoadNut_0 IsMechanicallyConnectTo MainframeAssembly_0
- Quill_0 IsMechanicallyConnectTo DrillString_0
- TravellingBlock_0 IsMechanicallyConnectTo LoadNut_0
```mermaid
flowchart TD
	ActiveLine_0([ActiveLine_0]) --> ActiveLine[[ActiveLine]]
	Drawworks_0([Drawworks_0]) --> Drawworks[[Drawworks]]
	CrownBlock_0([CrownBlock_0]) --> CrownBlock[[CrownBlock]]
	DeadLine_0([DeadLine_0]) --> DeadLine[[DeadLine]]
	SupportLine_0([SupportLine_0]) --> SupportLine[[SupportLine]]
	Drawworks_1([Drawworks_1]) --> Drawworks[[Drawworks]]
	Dolly_0([Dolly_0]) --> Dolly[[Dolly]]
	DollyRail_0([DollyRail_0]) --> DollyRail[[DollyRail]]
	Elevator_0([Elevator_0]) --> Elevator[[Elevator]]
	DrillString_0([DrillString_0]) --> DrillString[[DrillString]]
	TravellingBlock_0([TravellingBlock_0]) --> TravellingBlock[[TravellingBlock]]
	MainframeAssembly_0([MainframeAssembly_0]) --> MainframeAssembly[[MainframeAssembly]]
	Quill_0([Quill_0]) --> Quill[[Quill]]
	LoadNut_0([LoadNut_0]) --> LoadNut[[LoadNut]]
	 ActiveLine_0 -- IsMechanicallyConnectTo --> Drawworks_0 
	 CrownBlock_0 -- IsMechanicallyConnectTo --> ActiveLine_0 
	 CrownBlock_0 -- IsMechanicallyConnectTo --> DeadLine_0 
	 CrownBlock_0 -- IsMechanicallyConnectTo --> SupportLine_0 
	 DeadLine_0 -- IsMechanicallyConnectTo --> Drawworks_1 
	 Dolly_0 -- IsMechanicallyConnectTo --> DollyRail_0 
	 Elevator_0 -- IsMechanicallyConnectTo --> DrillString_0 
	 SupportLine_0 -- IsMechanicallyConnectTo --> TravellingBlock_0 
	 MainframeAssembly_0 -- IsMechanicallyConnectTo --> Dolly_0 
	 MainframeAssembly_0 -- IsMechanicallyConnectTo --> Elevator_0 
	 MainframeAssembly_0 -- IsMechanicallyConnectTo --> Quill_0 
	 LoadNut_0 -- IsMechanicallyConnectTo --> MainframeAssembly_0 
	 Quill_0 -- IsMechanicallyConnectTo --> DrillString_0 
	 TravellingBlock_0 -- IsMechanicallyConnectTo --> LoadNut_0 
```
