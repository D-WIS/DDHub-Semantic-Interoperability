# Hydraulic circuit
- ActiveDrillingSystem:ActiveDrillingSystem_0
- ThreeWayValve:ThreeWayValve_0
- GateValve:GateValve_0
- GateValve:GateValve_1
- GateValve:GateValve_2
- MudStandpipeManifold:MudStandpipeManifold_0
- MudStandpipeManifold:MudStandpipeManifold_1
- MudStandpipeManifold:MudStandpipeManifold_2
- CementPump:CementPump_0
- Pumps:Pumps_0
- Pumps:Pumps_1
- ThreeWayValve:ThreeWayValve_1
- ThreeWayValve:ThreeWayValve_2
- ThreeWayValve:ThreeWayValve_3
- MudStandpipeManifold:MudStandpipeManifold_3
- Standpipe:Standpipe_0
- MudMixing:MudMixing_0
- ActiveDrillingSystem_0 IsHydraulicConnectedTo ThreeWayValve_0
- ThreeWayValve_0 IsHydraulicConnectedTo GateValve_0
- ThreeWayValve_0 IsHydraulicConnectedTo GateValve_1
- ThreeWayValve_0 IsHydraulicConnectedTo GateValve_2
- GateValve_0 IsHydraulicConnectedTo MudStandpipeManifold_0
- GateValve_1 IsHydraulicConnectedTo MudStandpipeManifold_1
- GateValve_2 IsHydraulicConnectedTo MudStandpipeManifold_2
- MudStandpipeManifold_0 IsHydraulicConnectedTo CementPump_0
- MudStandpipeManifold_1 IsHydraulicConnectedTo Pumps_0
- MudStandpipeManifold_2 IsHydraulicConnectedTo Pumps_1
- CementPump_0 IsHydraulicConnectedTo ThreeWayValve_1
- Pumps_0 IsHydraulicConnectedTo ThreeWayValve_2
- Pumps_1 IsHydraulicConnectedTo ThreeWayValve_3
- ThreeWayValve_1 IsHydraulicConnectedTo MudStandpipeManifold_3
- ThreeWayValve_2 IsHydraulicConnectedTo MudStandpipeManifold_3
- ThreeWayValve_3 IsHydraulicConnectedTo MudStandpipeManifold_3
- MudStandpipeManifold_3 IsHydraulicConnectedTo Standpipe_0
- MudMixing_0 IsHydraulicConnectedTo ActiveDrillingSystem_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	ActiveDrillingSystem_0([ActiveDrillingSystem_0]) --> ActiveDrillingSystem[[ActiveDrillingSystem]]:::typeClass
	ThreeWayValve_0([ThreeWayValve_0]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	GateValve_0([GateValve_0]) --> GateValve[[GateValve]]:::typeClass
	GateValve_1([GateValve_1]) --> GateValve[[GateValve]]:::typeClass
	GateValve_2([GateValve_2]) --> GateValve[[GateValve]]:::typeClass
	MudStandpipeManifold_0([MudStandpipeManifold_0]) --> MudStandpipeManifold[[MudStandpipeManifold]]:::typeClass
	MudStandpipeManifold_1([MudStandpipeManifold_1]) --> MudStandpipeManifold[[MudStandpipeManifold]]:::typeClass
	MudStandpipeManifold_2([MudStandpipeManifold_2]) --> MudStandpipeManifold[[MudStandpipeManifold]]:::typeClass
	CementPump_0([CementPump_0]) --> CementPump[[CementPump]]:::typeClass
	Pumps_0([Pumps_0]) --> Pumps[[Pumps]]:::typeClass
	Pumps_1([Pumps_1]) --> Pumps[[Pumps]]:::typeClass
	ThreeWayValve_1([ThreeWayValve_1]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	ThreeWayValve_2([ThreeWayValve_2]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	ThreeWayValve_3([ThreeWayValve_3]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	MudStandpipeManifold_3([MudStandpipeManifold_3]) --> MudStandpipeManifold[[MudStandpipeManifold]]:::typeClass
	Standpipe_0([Standpipe_0]) --> Standpipe[[Standpipe]]:::typeClass
	MudMixing_0([MudMixing_0]) --> MudMixing[[MudMixing]]:::typeClass
	 ActiveDrillingSystem_0 -- IsHydraulicConnectedTo --> ThreeWayValve_0 
	 ThreeWayValve_0 -- IsHydraulicConnectedTo --> GateValve_0 
	 ThreeWayValve_0 -- IsHydraulicConnectedTo --> GateValve_1 
	 ThreeWayValve_0 -- IsHydraulicConnectedTo --> GateValve_2 
	 GateValve_0 -- IsHydraulicConnectedTo --> MudStandpipeManifold_0 
	 GateValve_1 -- IsHydraulicConnectedTo --> MudStandpipeManifold_1 
	 GateValve_2 -- IsHydraulicConnectedTo --> MudStandpipeManifold_2 
	 MudStandpipeManifold_0 -- IsHydraulicConnectedTo --> CementPump_0 
	 MudStandpipeManifold_1 -- IsHydraulicConnectedTo --> Pumps_0 
	 MudStandpipeManifold_2 -- IsHydraulicConnectedTo --> Pumps_1 
	 CementPump_0 -- IsHydraulicConnectedTo --> ThreeWayValve_1 
	 Pumps_0 -- IsHydraulicConnectedTo --> ThreeWayValve_2 
	 Pumps_1 -- IsHydraulicConnectedTo --> ThreeWayValve_3 
	 ThreeWayValve_1 -- IsHydraulicConnectedTo --> MudStandpipeManifold_3 
	 ThreeWayValve_2 -- IsHydraulicConnectedTo --> MudStandpipeManifold_3 
	 ThreeWayValve_3 -- IsHydraulicConnectedTo --> MudStandpipeManifold_3 
	 MudStandpipeManifold_3 -- IsHydraulicConnectedTo --> Standpipe_0 
	 MudMixing_0 -- IsHydraulicConnectedTo --> ActiveDrillingSystem_0 
```
