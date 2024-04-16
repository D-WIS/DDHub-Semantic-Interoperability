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
	DrillingBit_0([DrillingBit_0]) --> DrillingBit[[DrillingBit]]
	Pipe_0([Pipe_0]) --> Pipe[[Pipe]]
	Pipe_1([Pipe_1]) --> Pipe[[Pipe]]
	HydraulicJunction_0([HydraulicJunction_0]) --> HydraulicJunction[[HydraulicJunction]]
	TopDrive_0([TopDrive_0]) --> TopDrive[[TopDrive]]
	 DrillingBit_0 -- IsHydraulicConnectedTo --> Pipe_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> DrillingBit_0 
	 Pipe_1 -- IsHydraulicConnectedTo --> HydraulicJunction_0 
	 TopDrive_0 -- IsHydraulicConnectedTo --> Pipe_1 
	 HydraulicJunction_0 -- IsHydraulicConnectedTo --> Pipe_0 
```
