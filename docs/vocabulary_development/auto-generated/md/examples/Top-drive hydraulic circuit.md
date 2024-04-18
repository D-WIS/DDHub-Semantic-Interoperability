# Top-drive hydraulic circuit
- MudStandpipe:StandPipe_0
- Quill:TopDriveShaft_0
- TopDrive:TopDrive_0
- StandPipe_0 IsHydraulicConnectedTo TopDriveShaft_0
- TopDriveShaft_0 IsHydraulicConnectedTo TopDrive_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	StandPipe_0([StandPipe_0]) --> MudStandpipe[[MudStandpipe]]:::typeClass
	TopDriveShaft_0([TopDriveShaft_0]) --> Quill[[Quill]]:::typeClass
	TopDrive_0([TopDrive_0]) --> TopDrive[[TopDrive]]:::typeClass
	 StandPipe_0 -- IsHydraulicConnectedTo --> TopDriveShaft_0 
	 TopDriveShaft_0 -- IsHydraulicConnectedTo --> TopDrive_0 
```
