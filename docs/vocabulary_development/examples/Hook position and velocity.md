# Hook position and velocity
- HookPosition:HookPosition_0
- Derivation:Derivation_0
- HookVelocity:HookVelocity_0
- TopDriveHook:TopDriveHook_0
- BlockPositionQuantity:BlockPositionQuantity_0
- BlockVelocityQuantity:BlockVelocityQuantity_0
- Transformation:Transformation_0
- TopSideTelemetry:TopSideTelemetry_0
- DataFlowNode:DataFlowNode_0
- HookPosition_0 IsDerivationInput Derivation_0
- HookVelocity_0 IsDerivedFrom Derivation_0
- HookPosition_0 IsMechanicallyLocatedAt TopDriveHook_0
- HookVelocity_0 IsMechanicallyLocatedAt TopDriveHook_0
- HookPosition_0 IsOfMeasurableQuantity BlockPositionQuantity_0
- HookVelocity_0 IsOfMeasurableQuantity BlockVelocityQuantity_0
- Transformation_0 IsTransformationOutput HookPosition_0
- HookPosition_0 IsTransmittedBy TopSideTelemetry_0
- HookVelocity_0 IsTransmittedBy TopSideTelemetry_0
- HookPosition_0 IsProvidedBy DataFlowNode_0
- HookVelocity_0 IsProvidedBy DataFlowNode_0
```mermaid
flowchart TD
	HookPosition_0([HookPosition_0]) --> HookPosition[[HookPosition]]
	Derivation_0([Derivation_0]) --> Derivation[[Derivation]]
	HookVelocity_0([HookVelocity_0]) --> HookVelocity[[HookVelocity]]
	TopDriveHook_0([TopDriveHook_0]) --> TopDriveHook[[TopDriveHook]]
	BlockPositionQuantity_0([BlockPositionQuantity_0]) --> BlockPositionQuantity[[BlockPositionQuantity]]
	BlockVelocityQuantity_0([BlockVelocityQuantity_0]) --> BlockVelocityQuantity[[BlockVelocityQuantity]]
	Transformation_0([Transformation_0]) --> Transformation[[Transformation]]
	TopSideTelemetry_0([TopSideTelemetry_0]) --> TopSideTelemetry[[TopSideTelemetry]]
	DataFlowNode_0([DataFlowNode_0]) --> DataFlowNode[[DataFlowNode]]
	 HookPosition_0 -- IsDerivationInput --> Derivation_0 
	 HookVelocity_0 -- IsDerivedFrom --> Derivation_0 
	 HookPosition_0 -- IsMechanicallyLocatedAt --> TopDriveHook_0 
	 HookVelocity_0 -- IsMechanicallyLocatedAt --> TopDriveHook_0 
	 HookPosition_0 -- IsOfMeasurableQuantity --> BlockPositionQuantity_0 
	 HookVelocity_0 -- IsOfMeasurableQuantity --> BlockVelocityQuantity_0 
	 Transformation_0 -- IsTransformationOutput --> HookPosition_0 
	 HookPosition_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 HookVelocity_0 -- IsTransmittedBy --> TopSideTelemetry_0 
	 HookPosition_0 -- IsProvidedBy --> DataFlowNode_0 
	 HookVelocity_0 -- IsProvidedBy --> DataFlowNode_0 
```
