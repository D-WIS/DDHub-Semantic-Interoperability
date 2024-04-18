# Hydraulic circuit
- ActiveDrillingSystem:ActivePit_0
- ThreeWayValve:ThreeWayValve_0
- GenericEquipmentGatevalve:GateValve_0
- GenericEquipmentGatevalve:GateValve_1
- GenericEquipmentGatevalve:GateValve_2
- ThreeWayManifold:ThreeWayManifold_0
- ThreeWayManifold:ThreeWayManifold_1
- ThreeWayManifold:ThreeWayManifold_2
- CementPump:CementPump_0
- MudPump:MudPump_0
- MudPump:MudPump_1
- ThreeWayValve:ThreeWayValve_1
- ThreeWayValve:ThreeWayValve_2
- ThreeWayValve:ThreeWayValve_3
- ThreeWayManifold:ThreeWayManifold_3
- MudStandpipe:StandPipe_0
- MudMixing:MudMixing_0
- ActivePit_0 IsHydraulicConnectedTo ThreeWayValve_0
- ThreeWayValve_0 IsHydraulicConnectedTo GateValve_0
- ThreeWayValve_0 IsHydraulicConnectedTo GateValve_1
- ThreeWayValve_0 IsHydraulicConnectedTo GateValve_2
- GateValve_0 IsHydraulicConnectedTo ThreeWayManifold_0
- GateValve_1 IsHydraulicConnectedTo ThreeWayManifold_1
- GateValve_2 IsHydraulicConnectedTo ThreeWayManifold_2
- ThreeWayManifold_0 IsHydraulicConnectedTo CementPump_0
- ThreeWayManifold_1 IsHydraulicConnectedTo MudPump_0
- ThreeWayManifold_2 IsHydraulicConnectedTo MudPump_1
- CementPump_0 IsHydraulicConnectedTo ThreeWayValve_1
- MudPump_0 IsHydraulicConnectedTo ThreeWayValve_2
- MudPump_1 IsHydraulicConnectedTo ThreeWayValve_3
- ThreeWayValve_1 IsHydraulicConnectedTo ThreeWayManifold_3
- ThreeWayValve_2 IsHydraulicConnectedTo ThreeWayManifold_3
- ThreeWayValve_3 IsHydraulicConnectedTo ThreeWayManifold_3
- ThreeWayManifold_3 IsHydraulicConnectedTo StandPipe_0
- MudMixing_0 IsHydraulicConnectedTo ActivePit_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	ActivePit_0([ActivePit_0]) --> ActiveDrillingSystem[[ActiveDrillingSystem]]:::typeClass
	ThreeWayValve_0([ThreeWayValve_0]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	GateValve_0([GateValve_0]) --> GenericEquipmentGatevalve[[GenericEquipmentGatevalve]]:::typeClass
	GateValve_1([GateValve_1]) --> GenericEquipmentGatevalve[[GenericEquipmentGatevalve]]:::typeClass
	GateValve_2([GateValve_2]) --> GenericEquipmentGatevalve[[GenericEquipmentGatevalve]]:::typeClass
	ThreeWayManifold_0([ThreeWayManifold_0]) --> ThreeWayManifold[[ThreeWayManifold]]:::typeClass
	ThreeWayManifold_1([ThreeWayManifold_1]) --> ThreeWayManifold[[ThreeWayManifold]]:::typeClass
	ThreeWayManifold_2([ThreeWayManifold_2]) --> ThreeWayManifold[[ThreeWayManifold]]:::typeClass
	CementPump_0([CementPump_0]) --> CementPump[[CementPump]]:::typeClass
	MudPump_0([MudPump_0]) --> MudPump[[MudPump]]:::typeClass
	MudPump_1([MudPump_1]) --> MudPump[[MudPump]]:::typeClass
	ThreeWayValve_1([ThreeWayValve_1]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	ThreeWayValve_2([ThreeWayValve_2]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	ThreeWayValve_3([ThreeWayValve_3]) --> ThreeWayValve[[ThreeWayValve]]:::typeClass
	ThreeWayManifold_3([ThreeWayManifold_3]) --> ThreeWayManifold[[ThreeWayManifold]]:::typeClass
	StandPipe_0([StandPipe_0]) --> MudStandpipe[[MudStandpipe]]:::typeClass
	MudMixing_0([MudMixing_0]) --> MudMixing[[MudMixing]]:::typeClass
	 ActivePit_0 -- IsHydraulicConnectedTo --> ThreeWayValve_0 
	 ThreeWayValve_0 -- IsHydraulicConnectedTo --> GateValve_0 
	 ThreeWayValve_0 -- IsHydraulicConnectedTo --> GateValve_1 
	 ThreeWayValve_0 -- IsHydraulicConnectedTo --> GateValve_2 
	 GateValve_0 -- IsHydraulicConnectedTo --> ThreeWayManifold_0 
	 GateValve_1 -- IsHydraulicConnectedTo --> ThreeWayManifold_1 
	 GateValve_2 -- IsHydraulicConnectedTo --> ThreeWayManifold_2 
	 ThreeWayManifold_0 -- IsHydraulicConnectedTo --> CementPump_0 
	 ThreeWayManifold_1 -- IsHydraulicConnectedTo --> MudPump_0 
	 ThreeWayManifold_2 -- IsHydraulicConnectedTo --> MudPump_1 
	 CementPump_0 -- IsHydraulicConnectedTo --> ThreeWayValve_1 
	 MudPump_0 -- IsHydraulicConnectedTo --> ThreeWayValve_2 
	 MudPump_1 -- IsHydraulicConnectedTo --> ThreeWayValve_3 
	 ThreeWayValve_1 -- IsHydraulicConnectedTo --> ThreeWayManifold_3 
	 ThreeWayValve_2 -- IsHydraulicConnectedTo --> ThreeWayManifold_3 
	 ThreeWayValve_3 -- IsHydraulicConnectedTo --> ThreeWayManifold_3 
	 ThreeWayManifold_3 -- IsHydraulicConnectedTo --> StandPipe_0 
	 MudMixing_0 -- IsHydraulicConnectedTo --> ActivePit_0 
```
