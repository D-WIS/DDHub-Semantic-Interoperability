# Sub-Surface Hydraulic Circuit
- DrillingBit:Bit_0
- Pipe:Pipe_0
- Pipe:Pipe_1
- HydraulicJunction:HydraulicJunction_0
- TopDrive:TopDrive_0
- Bit_0 IsHydraulicConnectedTo Pipe_0
- Pipe_1 IsHydraulicConnectedTo Bit_0
- Pipe_1 IsHydraulicConnectedTo HydraulicJunction_0
- TopDrive_0 IsHydraulicConnectedTo Pipe_1
- HydraulicJunction_0 IsHydraulicConnectedTo Pipe_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	Bit_0([Bit_0]) --> DrillingBit[[DrillingBit]]:::typeClass
	Pipe_0([Pipe_0]) --> Pipe[[Pipe]]:::typeClass
	Pipe_1([Pipe_1]) --> Pipe[[Pipe]]:::typeClass
	HydraulicJunction_0([HydraulicJunction_0]) --> HydraulicJunction[[HydraulicJunction]]:::typeClass
	TopDrive_0([TopDrive_0]) --> TopDrive[[TopDrive]]:::typeClass
	 Bit_0 -- IsHydraulicConnectedTo --> Pipe_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> Bit_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> HydraulicJunction_0 
	 TopDrive_0 -- IsHydraulicConnectedTo --> Pipe_1 
	 HydraulicJunction_0 -- IsHydraulicConnectedTo --> Pipe_0 
```
