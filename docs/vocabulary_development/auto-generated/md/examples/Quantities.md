# Quantities
- TorqueDrillingQuantity:BitTorqueQuantity_0
- TorqueQuantity:TorqueQuantity_0
- AccelerationDrillingQuantity:BlockAccelerationQuantity_0
- AccelerationQuantity:AccelerationQuantity_0
- PositionDrillingQuantity:BlockPositionQuantity_0
- LengthQuantity:LengthQuantity_0
- BlockVelocityDrillingQuantity:BlockVelocityQuantity_0
- VelocityQuantity:VelocityQuantity_0
- DepthDrillingQuantity:DepthQuantity_0
- VolumetricFlowrateDrillingQuantity:FlowRateQuantity_0
- VolumetricFlowrateDrillingQuantity:VolumetricRateQuantity_0
- TemperatureDrillingQuantity:FluidTemperatureInQuantity_0
- TemperatureQuantity:TemperatureQuantity_0
- HookLoadDrillingQuantity:HookloadQuantity_0
- MassQuantity:MassQuantity_0
- RotationalFrequencyQuantity:PumpRateQuantity_0
- FrequencyQuantity:FrequencyQuantity_0
- PressureDrillingQuantity:SPPQuantity_0
- PressureQuantity:PressureQuantity_0
- RotationalFrequencyQuantity:SurfaceRPMQuantity_0
- TorqueDrillingQuantity:SurfaceTorqueQuantity_0
- ForceDrillingQuantity:TopOfStringForceQuantity_0
- ForceQuantity:ForceQuantity_0
- DepthDrillingQuantity:TVDQuantity_0
- WeightOnBitDrillingQuantity:WOBQuantity_0
- FormationResistivityDrillingQuantity:Resistivity_0
- FormationResistivityDrillingQuantity:ElectricResistivityQuantity_0
- PorosityQuantity:FormationPorosityQuantity_0
- ProportionQuantity:ProportionQuantity_0
- BitTorqueQuantity_0 IsObservableFrom TorqueQuantity_0
- BlockAccelerationQuantity_0 IsObservableFrom AccelerationQuantity_0
- BlockPositionQuantity_0 IsObservableFrom LengthQuantity_0
- BlockVelocityQuantity_0 IsObservableFrom VelocityQuantity_0
- DepthQuantity_0 IsObservableFrom LengthQuantity_0
- FlowRateQuantity_0 IsObservableFrom VolumetricRateQuantity_0
- FluidTemperatureInQuantity_0 IsObservableFrom TemperatureQuantity_0
- HookloadQuantity_0 IsObservableFrom MassQuantity_0
- PumpRateQuantity_0 IsObservableFrom FrequencyQuantity_0
- SPPQuantity_0 IsObservableFrom PressureQuantity_0
- SurfaceRPMQuantity_0 IsObservableFrom FrequencyQuantity_0
- SurfaceTorqueQuantity_0 IsObservableFrom TorqueQuantity_0
- TopOfStringForceQuantity_0 IsObservableFrom ForceQuantity_0
- TVDQuantity_0 IsObservableFrom LengthQuantity_0
- WOBQuantity_0 IsObservableFrom MassQuantity_0
- Resistivity_0 IsObservableFrom ElectricResistivityQuantity_0
- FormationPorosityQuantity_0 IsObservableFrom ProportionQuantity_0
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	 classDef classClass fill:#9dd0ff;
	BitTorqueQuantity_0([BitTorqueQuantity_0]) --> TorqueDrillingQuantity[[TorqueDrillingQuantity]]:::typeClass
	TorqueQuantity_0([TorqueQuantity_0]) --> TorqueQuantity[[TorqueQuantity]]:::typeClass
	BlockAccelerationQuantity_0([BlockAccelerationQuantity_0]) --> AccelerationDrillingQuantity[[AccelerationDrillingQuantity]]:::typeClass
	AccelerationQuantity_0([AccelerationQuantity_0]) --> AccelerationQuantity[[AccelerationQuantity]]:::typeClass
	BlockPositionQuantity_0([BlockPositionQuantity_0]) --> PositionDrillingQuantity[[PositionDrillingQuantity]]:::typeClass
	LengthQuantity_0([LengthQuantity_0]) --> LengthQuantity[[LengthQuantity]]:::typeClass
	BlockVelocityQuantity_0([BlockVelocityQuantity_0]) --> BlockVelocityDrillingQuantity[[BlockVelocityDrillingQuantity]]:::typeClass
	VelocityQuantity_0([VelocityQuantity_0]) --> VelocityQuantity[[VelocityQuantity]]:::typeClass
	DepthQuantity_0([DepthQuantity_0]) --> DepthDrillingQuantity[[DepthDrillingQuantity]]:::typeClass
	FlowRateQuantity_0([FlowRateQuantity_0]) --> VolumetricFlowrateDrillingQuantity[[VolumetricFlowrateDrillingQuantity]]:::typeClass
	VolumetricRateQuantity_0([VolumetricRateQuantity_0]) --> VolumetricFlowrateDrillingQuantity[[VolumetricFlowrateDrillingQuantity]]:::typeClass
	FluidTemperatureInQuantity_0([FluidTemperatureInQuantity_0]) --> TemperatureDrillingQuantity[[TemperatureDrillingQuantity]]:::typeClass
	TemperatureQuantity_0([TemperatureQuantity_0]) --> TemperatureQuantity[[TemperatureQuantity]]:::typeClass
	HookloadQuantity_0([HookloadQuantity_0]) --> HookLoadDrillingQuantity[[HookLoadDrillingQuantity]]:::typeClass
	MassQuantity_0([MassQuantity_0]) --> MassQuantity[[MassQuantity]]:::typeClass
	PumpRateQuantity_0([PumpRateQuantity_0]) --> RotationalFrequencyQuantity[[RotationalFrequencyQuantity]]:::typeClass
	FrequencyQuantity_0([FrequencyQuantity_0]) --> FrequencyQuantity[[FrequencyQuantity]]:::typeClass
	SPPQuantity_0([SPPQuantity_0]) --> PressureDrillingQuantity[[PressureDrillingQuantity]]:::typeClass
	PressureQuantity_0([PressureQuantity_0]) --> PressureQuantity[[PressureQuantity]]:::typeClass
	SurfaceRPMQuantity_0([SurfaceRPMQuantity_0]) --> RotationalFrequencyQuantity[[RotationalFrequencyQuantity]]:::typeClass
	SurfaceTorqueQuantity_0([SurfaceTorqueQuantity_0]) --> TorqueDrillingQuantity[[TorqueDrillingQuantity]]:::typeClass
	TopOfStringForceQuantity_0([TopOfStringForceQuantity_0]) --> ForceDrillingQuantity[[ForceDrillingQuantity]]:::typeClass
	ForceQuantity_0([ForceQuantity_0]) --> ForceQuantity[[ForceQuantity]]:::typeClass
	TVDQuantity_0([TVDQuantity_0]) --> DepthDrillingQuantity[[DepthDrillingQuantity]]:::typeClass
	WOBQuantity_0([WOBQuantity_0]) --> WeightOnBitDrillingQuantity[[WeightOnBitDrillingQuantity]]:::typeClass
	Resistivity_0([Resistivity_0]) --> FormationResistivityDrillingQuantity[[FormationResistivityDrillingQuantity]]:::typeClass
	ElectricResistivityQuantity_0([ElectricResistivityQuantity_0]) --> FormationResistivityDrillingQuantity[[FormationResistivityDrillingQuantity]]:::typeClass
	FormationPorosityQuantity_0([FormationPorosityQuantity_0]) --> PorosityQuantity[[PorosityQuantity]]:::typeClass
	ProportionQuantity_0([ProportionQuantity_0]) --> ProportionQuantity[[ProportionQuantity]]:::typeClass
	 BitTorqueQuantity_0 -- IsObservableFrom --> TorqueQuantity_0 
	 BlockAccelerationQuantity_0 -- IsObservableFrom --> AccelerationQuantity_0 
	 BlockPositionQuantity_0 -- IsObservableFrom --> LengthQuantity_0 
	 BlockVelocityQuantity_0 -- IsObservableFrom --> VelocityQuantity_0 
	 DepthQuantity_0 -- IsObservableFrom --> LengthQuantity_0 
	 FlowRateQuantity_0 -- IsObservableFrom --> VolumetricRateQuantity_0 
	 FluidTemperatureInQuantity_0 -- IsObservableFrom --> TemperatureQuantity_0 
	 HookloadQuantity_0 -- IsObservableFrom --> MassQuantity_0 
	 PumpRateQuantity_0 -- IsObservableFrom --> FrequencyQuantity_0 
	 SPPQuantity_0 -- IsObservableFrom --> PressureQuantity_0 
	 SurfaceRPMQuantity_0 -- IsObservableFrom --> FrequencyQuantity_0 
	 SurfaceTorqueQuantity_0 -- IsObservableFrom --> TorqueQuantity_0 
	 TopOfStringForceQuantity_0 -- IsObservableFrom --> ForceQuantity_0 
	 TVDQuantity_0 -- IsObservableFrom --> LengthQuantity_0 
	 WOBQuantity_0 -- IsObservableFrom --> MassQuantity_0 
	 Resistivity_0 -- IsObservableFrom --> ElectricResistivityQuantity_0 
	 FormationPorosityQuantity_0 -- IsObservableFrom --> ProportionQuantity_0 
```
