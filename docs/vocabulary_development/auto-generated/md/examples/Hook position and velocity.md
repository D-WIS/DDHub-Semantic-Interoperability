# Hook position and velocity
- HookPosition:HookPosition_0
- Derivation:Derivation_0
- HookVelocity:HookVelocity_0
- Hook:TopDriveHook_0
- Transformation:Transformation_0
- TopSideTelemetry:TopSideTelemetry_0
- DataFlowNode:DataFlowNode_0
- HookPosition_0 IsDerivationInput Derivation_0
- HookVelocity_0 IsDerivedFrom Derivation_0
- HookPosition_0 IsMechanicallyLocatedAt TopDriveHook_0
- HookVelocity_0 IsMechanicallyLocatedAt TopDriveHook_0
- Transformation_0 IsTransformationOutput HookPosition_0
- HookPosition_0 IsTransmittedBy TopSideTelemetry_0
- HookVelocity_0 IsTransmittedBy TopSideTelemetry_0
- HookPosition_0 IsProvidedBy DataFlowNode_0
- HookVelocity_0 IsProvidedBy DataFlowNode_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	HookPosition_0([HookPosition_0]) --> HookPosition[[HookPosition]]:::typeClass
	Derivation_0([Derivation_0]) --> Derivation[[Derivation]]:::typeClass
	HookVelocity_0([HookVelocity_0]) --> HookVelocity[[HookVelocity]]:::typeClass
	TopDriveHook_0([TopDriveHook_0]) --> Hook[[Hook]]:::typeClass
	Transformation_0([Transformation_0]) --> Transformation[[Transformation]]:::typeClass
	TopSideTelemetry_0([TopSideTelemetry_0]) --> TopSideTelemetry[[TopSideTelemetry]]:::typeClass
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode[[DataFlowNode]]:::typeClass
	 HookPosition_0 -- IsDerivationInput --> Derivation_0 
	 HookVelocity_0 -- IsDerivedFrom --> Derivation_0 
	 HookPosition_0 -- IsMechanicallyLocatedAt --> TopDriveHook_0 
	 HookVelocity_0 -- IsMechanicallyLocatedAt --> TopDriveHook_0 
	 Transformation_0 -- IsTransformationOutput --> HookPosition_0 
	 HookPosition_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 HookVelocity_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 HookPosition_0 -- IsProvidedBy --> DataFlowNode_0 
	 HookVelocity_0 -- IsProvidedBy --> DataFlowNode_0 
```
