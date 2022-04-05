# Sub-Surface Hydraulic Circuit
- Bit:Bit_0
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
	Bit_0([Bit_0]) --> Bit:::typeClass[[Bit]]
	Pipe_0([Pipe_0]) --> Pipe:::typeClass[[Pipe]]
	Pipe_1([Pipe_1]) --> Pipe:::typeClass[[Pipe]]
	HydraulicJunction_0([HydraulicJunction_0]) --> HydraulicJunction:::typeClass[[HydraulicJunction]]
	TopDrive_0([TopDrive_0]) --> TopDrive:::typeClass[[TopDrive]]
	 Bit_0 -- IsHydraulicConnectedTo --> Pipe_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> Bit_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> HydraulicJunction_0 
	 TopDrive_0 -- IsHydraulicConnectedTo --> Pipe_1 
	 HydraulicJunction_0 -- IsHydraulicConnectedTo --> Pipe_0 
```
