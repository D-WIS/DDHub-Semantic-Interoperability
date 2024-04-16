# Sub-Surface Hydraulic Circuit
- DrillingBit:DrillingBit_0
- Pipe:Pipe_0
- Pipe:Pipe_1
- HydraulicJunction:HydraulicJunction_0
- TopDrive:TopDrive_0
- DrillingBit_0 IsHydraulicConnectedTo Pipe_0
- Pipe_1 IsHydraulicConnectedTo DrillingBit_0
- Pipe_1 IsHydraulicConnectedTo HydraulicJunction_0
- TopDrive_0 IsHydraulicConnectedTo Pipe_1
- HydraulicJunction_0 IsHydraulicConnectedTo Pipe_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	DrillingBit_0([DrillingBit_0]) --> DrillingBit[[DrillingBit]]:::typeClass
	Pipe_0([Pipe_0]) --> Pipe[[Pipe]]:::typeClass
	Pipe_1([Pipe_1]) --> Pipe[[Pipe]]:::typeClass
	HydraulicJunction_0([HydraulicJunction_0]) --> HydraulicJunction[[HydraulicJunction]]:::typeClass
	TopDrive_0([TopDrive_0]) --> TopDrive[[TopDrive]]:::typeClass
	 DrillingBit_0 -- IsHydraulicConnectedTo --> Pipe_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> DrillingBit_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> HydraulicJunction_0 
	 TopDrive_0 -- IsHydraulicConnectedTo --> Pipe_1 
	 HydraulicJunction_0 -- IsHydraulicConnectedTo --> Pipe_0 
```
