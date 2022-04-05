# Sub surface circuit
- TopDrive:TopDrive_0
- Pipe:Pipe_0
- Pipe:Pipe_1
- HydraulicJunction:HydraulicJunction_0
- TopDrive_0 IsHydraulicConnectedTo Pipe_0
- Pipe_0 IsHydraulicConnectedTo Pipe_1
- Pipe_0 IsHydraulicConnectedTo HydraulicJunction_0
- HydraulicJunction_0 IsHydraulicConnectedTo Pipe_1
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	TopDrive_0([TopDrive_0]) --> TopDrive[[TopDrive]]:::typeClass
	Pipe_0([Pipe_0]) --> Pipe[[Pipe]]:::typeClass
	Pipe_1([Pipe_1]) --> Pipe[[Pipe]]:::typeClass
	HydraulicJunction_0([HydraulicJunction_0]) --> HydraulicJunction[[HydraulicJunction]]:::typeClass
	 TopDrive_0 -- IsHydraulicConnectedTo --> Pipe_0 
	 Pipe_0 -- IsHydraulicConnectedTo --> Pipe_1 
	 Pipe_0 -- IsHydraulicConnectedTo --> HydraulicJunction_0 
	 HydraulicJunction_0 -- IsHydraulicConnectedTo --> Pipe_1 
```
