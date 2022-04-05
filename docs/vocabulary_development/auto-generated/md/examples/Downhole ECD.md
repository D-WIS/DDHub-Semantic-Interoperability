# Downhole ECD
- DownholePressureQuantity:DownholePressureQuantity_0
- PressureQuantity:PressureQuantity_0
- DownholeECD:DownholeECD_0
- EMWQuantity:EMWQuantity_0
- DownholePressure:DownholePressure_0
- DrillingDataPoint:DrillingDataPoint_0
- TVDQuantity:TVDQuantity_0
- DrillingDataPoint:DrillingDataPoint_1
- AccelerationQuantity:AccelerationQuantity_0
- DrillingDataPoint:DrillingDataPoint_2
- DrillingDataPoint:DrillingDataPoint_3
- LengthQuantity:LengthQuantity_0
- DrillingDataPoint:DrillingDataPoint_4
- DepthQuantity:DepthQuantity_0
- BitDepth:BitDepth_0
- DirectTransformation:DirectTransformation_0
- DirectTransformation:DirectTransformation_1
- DirectTransformation:DirectTransformation_2
- BHAAnnular:BHAAnnular_0
- FlowRateIn:FlowRateIn_0
- GT:GT_0
- DrillingDataPoint:DrillingDataPoint_5
- HydraulicConnectedState:HydraulicConnectedState_0
- DrillingDataPoint:DrillingDataPoint_6
- TopDriveShaft:TopDriveShaft_0
- ConnectedCondition:ConnectedCondition_0
- DownholePressureQuantity_0 IsObservableFrom PressureQuantity_0
- DownholeECD_0 IsOfMeasurableQuantity EMWQuantity_0
- DownholePressure_0 IsOfMeasurableQuantity DownholePressureQuantity_0
- DrillingDataPoint_0 IsOfMeasurableQuantity TVDQuantity_0
- DrillingDataPoint_1 IsOfBaseQuantity AccelerationQuantity_0
- DrillingDataPoint_2 IsOfBaseQuantity PressureQuantity_0
- DrillingDataPoint_3 IsOfBaseQuantity LengthQuantity_0
- DrillingDataPoint_4 IsOfMeasurableQuantity DepthQuantity_0
- BitDepth_0 IsOfMeasurableQuantity DepthQuantity_0
- BitDepth_0 IsTransformationInput DirectTransformation_0
- DrillingDataPoint_3 IsTransformationInput DirectTransformation_0
- DirectTransformation_0 IsTransformationOutput DrillingDataPoint_4
- DrillingDataPoint_4 IsTransformationInput DirectTransformation_1
- DirectTransformation_1 IsTransformationOutput DrillingDataPoint_0
- DrillingDataPoint_2 IsTransformationInput DirectTransformation_2
- DrillingDataPoint_1 IsTransformationInput DirectTransformation_2
- DrillingDataPoint_0 IsTransformationInput DirectTransformation_2
- DownholePressure_0 IsTransformationInput DirectTransformation_2
- DirectTransformation_2 IsTransformationOutput DownholeECD_0
- DownholePressure_0 IsHydraulicallyLocatedAt BHAAnnular_0
- DownholeECD_0 IsHydraulicallyLocatedAt BHAAnnular_0
- FlowRateIn_0 IsConditionLeft GT_0
- DrillingDataPoint_5 IsConditionRight GT_0
- DownholePressure_0 IsConditionedBy GT_0
- HydraulicConnectedState_0 HasHydraulicStateValueFrom DrillingDataPoint_6
- TopDriveShaft_0 HasHydraulicState HydraulicConnectedState_0
- DownholePressure_0 IsConditionedBy ConnectedCondition_0
- HydraulicConnectedState_0 IsConditionInput ConnectedCondition_0
- DownholePressure_0 IsValidBy DrillingDataPoint_6
```mermaid
flowchart TD
	 classDef typeClass fill:#f96;
	DownholePressureQuantity_0([DownholePressureQuantity_0]) --> DownholePressureQuantity:::typeClass[[DownholePressureQuantity]]
	PressureQuantity_0([PressureQuantity_0]) --> PressureQuantity:::typeClass[[PressureQuantity]]
	DownholeECD_0([DownholeECD_0]) --> DownholeECD:::typeClass[[DownholeECD]]
	EMWQuantity_0([EMWQuantity_0]) --> EMWQuantity:::typeClass[[EMWQuantity]]
	DownholePressure_0([DownholePressure_0]) --> DownholePressure:::typeClass[[DownholePressure]]
	DrillingDataPoint_0([DrillingDataPoint_0]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	TVDQuantity_0([TVDQuantity_0]) --> TVDQuantity:::typeClass[[TVDQuantity]]
	DrillingDataPoint_1([DrillingDataPoint_1]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	AccelerationQuantity_0([AccelerationQuantity_0]) --> AccelerationQuantity:::typeClass[[AccelerationQuantity]]
	DrillingDataPoint_2([DrillingDataPoint_2]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DrillingDataPoint_3([DrillingDataPoint_3]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	LengthQuantity_0([LengthQuantity_0]) --> LengthQuantity:::typeClass[[LengthQuantity]]
	DrillingDataPoint_4([DrillingDataPoint_4]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	DepthQuantity_0([DepthQuantity_0]) --> DepthQuantity:::typeClass[[DepthQuantity]]
	BitDepth_0([BitDepth_0]) --> BitDepth:::typeClass[[BitDepth]]
	DirectTransformation_0([DirectTransformation_0]) --> DirectTransformation:::typeClass[[DirectTransformation]]
	DirectTransformation_1([DirectTransformation_1]) --> DirectTransformation:::typeClass[[DirectTransformation]]
	DirectTransformation_2([DirectTransformation_2]) --> DirectTransformation:::typeClass[[DirectTransformation]]
	BHAAnnular_0([BHAAnnular_0]) --> BHAAnnular:::typeClass[[BHAAnnular]]
	FlowRateIn_0([FlowRateIn_0]) --> FlowRateIn:::typeClass[[FlowRateIn]]
	GT_0([GT_0]) --> GT:::typeClass[[GT]]
	DrillingDataPoint_5([DrillingDataPoint_5]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	HydraulicConnectedState_0([HydraulicConnectedState_0]) --> HydraulicConnectedState:::typeClass[[HydraulicConnectedState]]
	DrillingDataPoint_6([DrillingDataPoint_6]) --> DrillingDataPoint:::typeClass[[DrillingDataPoint]]
	TopDriveShaft_0([TopDriveShaft_0]) --> TopDriveShaft:::typeClass[[TopDriveShaft]]
	ConnectedCondition_0([ConnectedCondition_0]) --> ConnectedCondition:::typeClass[[ConnectedCondition]]
	 DownholePressureQuantity_0 -- IsObservableFrom --> PressureQuantity_0 
	 DownholeECD_0 -- IsOfMeasurableQuantity --> EMWQuantity_0 
	 DownholePressure_0 -- IsOfMeasurableQuantity --> DownholePressureQuantity_0 
	 DrillingDataPoint_0 -- IsOfMeasurableQuantity --> TVDQuantity_0 
	 DrillingDataPoint_1 -- IsOfBaseQuantity --> AccelerationQuantity_0 
	 DrillingDataPoint_2 -- IsOfBaseQuantity --> PressureQuantity_0 
	 DrillingDataPoint_3 -- IsOfBaseQuantity --> LengthQuantity_0 
	 DrillingDataPoint_4 -- IsOfMeasurableQuantity --> DepthQuantity_0 
	 BitDepth_0 -- IsOfMeasurableQuantity --> DepthQuantity_0 
	 BitDepth_0 -- IsTransformationInput --> DirectTransformation_0 
	 DrillingDataPoint_3 -- IsTransformationInput --> DirectTransformation_0 
	 DirectTransformation_0 -- IsTransformationOutput --> DrillingDataPoint_4 
	 DrillingDataPoint_4 -- IsTransformationInput --> DirectTransformation_1 
	 DirectTransformation_1 -- IsTransformationOutput --> DrillingDataPoint_0 
	 DrillingDataPoint_2 -- IsTransformationInput --> DirectTransformation_2 
	 DrillingDataPoint_1 -- IsTransformationInput --> DirectTransformation_2 
	 DrillingDataPoint_0 -- IsTransformationInput --> DirectTransformation_2 
	 DownholePressure_0 -- IsTransformationInput --> DirectTransformation_2 
	 DirectTransformation_2 -- IsTransformationOutput --> DownholeECD_0 
	 DownholePressure_0 -- IsHydraulicallyLocatedAt --> BHAAnnular_0 
	 DownholeECD_0 -- IsHydraulicallyLocatedAt --> BHAAnnular_0 
	 FlowRateIn_0 -- IsConditionLeft --> GT_0 
	 DrillingDataPoint_5 -- IsConditionRight --> GT_0 
	 DownholePressure_0 -- IsConditionedBy --> GT_0 
	 HydraulicConnectedState_0 -- HasHydraulicStateValueFrom --> DrillingDataPoint_6 
	 TopDriveShaft_0 -- HasHydraulicState --> HydraulicConnectedState_0 
	 DownholePressure_0 -- IsConditionedBy --> ConnectedCondition_0 
	 HydraulicConnectedState_0 -- IsConditionInput --> ConnectedCondition_0 
	 DownholePressure_0 -- IsValidBy --> DrillingDataPoint_6 
```
