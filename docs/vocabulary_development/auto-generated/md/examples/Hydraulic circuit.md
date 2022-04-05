# Hydraulic circuit
- ActivePit:ActivePit_0
- ThreeWayValve:ThreeWayValve_0
- GateValve:GateValve_0
- GateValve:GateValve_1
- GateValve:GateValve_2
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
- StandPipe:StandPipe_0
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
	ActivePit_0([ActivePit_0]) --> ActivePit:::typeClass[[ActivePit]]
	ThreeWayValve_0([ThreeWayValve_0]) --> ThreeWayValve:::typeClass[[ThreeWayValve]]
	GateValve_0([GateValve_0]) --> GateValve:::typeClass[[GateValve]]
	GateValve_1([GateValve_1]) --> GateValve:::typeClass[[GateValve]]
	GateValve_2([GateValve_2]) --> GateValve:::typeClass[[GateValve]]
	ThreeWayManifold_0([ThreeWayManifold_0]) --> ThreeWayManifold:::typeClass[[ThreeWayManifold]]
	ThreeWayManifold_1([ThreeWayManifold_1]) --> ThreeWayManifold:::typeClass[[ThreeWayManifold]]
	ThreeWayManifold_2([ThreeWayManifold_2]) --> ThreeWayManifold:::typeClass[[ThreeWayManifold]]
	CementPump_0([CementPump_0]) --> CementPump:::typeClass[[CementPump]]
	MudPump_0([MudPump_0]) --> MudPump:::typeClass[[MudPump]]
	MudPump_1([MudPump_1]) --> MudPump:::typeClass[[MudPump]]
	ThreeWayValve_1([ThreeWayValve_1]) --> ThreeWayValve:::typeClass[[ThreeWayValve]]
	ThreeWayValve_2([ThreeWayValve_2]) --> ThreeWayValve:::typeClass[[ThreeWayValve]]
	ThreeWayValve_3([ThreeWayValve_3]) --> ThreeWayValve:::typeClass[[ThreeWayValve]]
	ThreeWayManifold_3([ThreeWayManifold_3]) --> ThreeWayManifold:::typeClass[[ThreeWayManifold]]
	StandPipe_0([StandPipe_0]) --> StandPipe:::typeClass[[StandPipe]]
	MudMixing_0([MudMixing_0]) --> MudMixing:::typeClass[[MudMixing]]
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
