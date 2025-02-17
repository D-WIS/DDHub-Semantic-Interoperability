using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Quantities
{
public enum Enum
{
AccelerationQuantity = 1785917581,
AmountSubstanceQuantity = 1058015452,
AngleGradientPerLengthQuantity = 474352181,
AngleMagneticFluxDensityQuantity = -98124002,
AngularAccelerationQuantity = -429449536,
AngularVelocityQuantity = 1285606434,
AreaQuantity = 628453991,
CompressibilityQuantity = 311768320,
ConsistencyIndexRheologyQuantity = 640610017,
CurvatureQuantity = 1279063454,
MassDensityGradientPerLengthQuantity = -1284397059,
MassDensityGradientPerTemperatureQuantity = 2075802989,
MassDensityQuantity = 594589521,
MassDensityRateOfChangeQuantity = -897400138,
DimensionlessQuantity = 949032596,
DynamicViscosityQuantity = 910294635,
ElectricCapacitanceQuantity = 1220504432,
ElectricCurrentQuantity = 1080374374,
ElectricTensionQuantity = 1087117009,
ElongationGradientPerLengthQuantity = -1567354124,
EnergyDensityQuantity = 419027290,
ForceGradientPerLengthQuantity = -1962111174,
ForceQuantity = -186930563,
FrequencyQuantity = -1582157666,
FrequencyRateOfChangeQuantity = -132206373,
HeatTransferCoefficientQuantity = 1915779927,
ImageScaleQuantity = 951298383,
InterfacialTensionQuantity = -179777442,
LengthQuantity = -846571985,
LuminousIntensityQuantity = -811699166,
MagneticFluxDensityQuantity = 1167333456,
MagneticFluxQuantity = -1509522922,
MassGradientPerLengthQuantity = -961832798,
MassRateQuantity = -115835604,
MaterialStrengthQuantity = -2135835513,
PorousMediumPermeabilityQuantity = 814051329,
PlaneAngleQuantity = 672739755,
PowerQuantity = 1949169143,
PressureGradientPerLengthQuantity = -520588979,
PressureLossConstantQuantity = 1703467937,
PressureQuantity = -1623584971,
ProportionQuantity = 1010353032,
RandomWalkQuantity = 51829274,
RelativeTemperatureQuantity = -395464486,
ElectricResistivityQuantity = 1162943540,
SolidAngleQuantity = 469657549,
IsobaricSpecificHeatCapacityQuantity = 2087315235,
IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity = -1660434615,
StressQuantity = -2122857602,
TemperatureGradientPerLengthQuantity = -909799180,
TemperatureQuantity = 2011063965,
ThermalConductivityQuantity = 1239958494,
ThermalConductivityGradientPerTemperatureQuantity = -1863396939,
TimeQuantity = -721408668,
TorqueGradientPerLengthQuantity = 76578139,
TorqueQuantity = -1828859099,
VelocityQuantity = -1336528588,
VolumeQuantity = -93684311,
VolumetricFlowRateOfChangeQuantity = -1858233662,
VolumetricFlowRateQuantity = 626899634,
WaveNumberQuantity = 595834865,
MassQuantity = 414341634,
EnergyQuantity = 45941998,
ForceRateOfChangeQuantity = -423112729,
PressureRateOfChangeQuantity = -1604066017,
TorqueRateOfChangeQuantity = 1500297629,
DiameterSmallQuantity = 1619501143,
DimensionLessStandardQuantity = 1555274464,
EarthMagneticFluxDensityQuantity = 786956663,
ElasticModulusQuantity = 404569679,
LengthSmallQuantity = 1541273008,
RotationalFrequencyQuantity = -1952301142,
GravitationalLoadQuantity = 315580805,
HydraulicConductivityQuantity = -1034488325,
VolumeLargeQuantity = -910475463,
RotationalFrequencyRateOfChangeQuantity = -909116764,
TensionQuantity = -126999138,
ProportionStandardQuantity = 1600808206,
LengthStandardQuantity = -389717619,
FluidShearRateQuantity = -1256668736,
FluidShearStressQuantity = 1343797926,
TorqueSmallQuantity = 121938401,
RotationalFrequencySmallQuantity = -412572033,
ProportionSmallQuantity = -107359025,
PorosityQuantity = -144754455,
StrokeFrequencyQuantity = -1488972343,
ShockRateQuantity = 327011439,
AccelerationDrillingQuantity = 1295123981,
AngleGradientPerLengthDrillingQuantity = -1105509014,
AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity = 1708579635,
AngularAccelerationDrillingQuantity = 818511399,
AngularVelocityDrillingQuantity = -1548295094,
AngularVelocitySurveyInstrumentDrillingQuantity = 231927927,
AreaDrillingQuantity = -567147630,
AxialVelocityDrillingQuantity = -1787705898,
BlockVelocityDrillingQuantity = 1221468538,
CableDiameterDrillingQuantity = 781192873,
CapillaryPressureDrillingQuantity = 1603009870,
CompressibilityDrillingQuantity = 332058556,
CurvatureDrillingQuantity = -1558899878,
DepthDrillingQuantity = -509195381,
DiameterPipeDrillingQuantity = -1799324024,
DiameterPoreDrillingQuantity = 976000205,
DrillStemMaterialStrengthDrillingQuantity = -1147382428,
DrillStringMagneticFluxDrillingQuantity = -467509793,
DurationDrillingQuantity = 1059990144,
DynamicViscosityDrillingQuantity = 793799950,
ElongationGradientPerLengthDrillingQuantity = -1735460986,
EnergyDensityDrillingQuantity = -1616761885,
MassDensityRateOfChangeDrillingQuantity = -259066578,
MassDensityGradientPerTemperatureDrillingQuantity = 720670926,
MassDensityGradientPerLengthDrillingQuantity = -943026993,
MassDensityDrillingQuantity = -394561308,
FluidVelocityDrillingQuantity = 1727005046,
ForceGradientPerLengthDrillingQuantity = -1396924413,
ForceDrillingQuantity = 1982315815,
HeatTransferCoefficientDrillingQuantity = -1882033069,
HydraulicConductivityDrillingQuantity = -2048361649,
InterfacialTensionDrillingQuantity = 1915992587,
MassGradientPerLengthDrillingQuantity = 61920528,
MassDrillingQuantity = 179545582,
MassRateDrillingQuantity = -1017782939,
PlaneAngleDrillingQuantity = 627694155,
PowerDrillingQuantity = -461089090,
PressureGradientPerLengthDrillingQuantity = -817948750,
PressureLossConstantDrillingQuantity = 673097862,
PressureDrillingQuantity = -1704756403,
RandomWalkDrillingQuantity = 50929921,
RotationalFrequencyRateOfChangeDrillingQuantity = -126515000,
IsobaricSpecificHeatCapacityDrillingQuantity = 1666776338,
IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity = -1065121419,
StickDurationDrillingQuantity = 152349791,
ReciprocalLengthSurveyInstrumentDrillingQuantity = -1015014380,
TemperatureGradientPerLengthDrillingQuantity = -1570562050,
TemperatureDrillingQuantity = -982536274,
TensionDrillingQuantity = -1739763626,
ThermalConductivityDrillingQuantity = 1193721273,
TorqueDrillingQuantity = 1193840352,
VolumeDrillingQuantity = -1581713503,
VolumetricFlowRateOfChangeDrillingQuantity = -2146391641,
VolumetricFlowrateDrillingQuantity = 128109980,
FormationResistivityDrillingQuantity = -1578540402,
FormationStrengthDrillingQuantity = 1058407766,
GammaRayIndexDrillingQuantity = -1721254755,
GasShowDrillingQuantity = 1474553959,
GasVolumetricFlowRateDrillingQuantity = 709172751,
HeightDrillingQuantity = 229076742,
HookLoadDrillingQuantity = -845028955,
NozzleDiameterDrillingQuantity = 1992210604,
SurfacePoreDrillingQuantity = 1474957934,
PositionDrillingQuantity = -1103436609,
RateOfPenetrationDrillingQuantity = 1807586160,
WeightOnBitDrillingQuantity = -2129951627,
ThermalConductivityGradientPerTemperatureDrillingQuantity = -1335303588,
TorqueGradientPerLengthDrillingQuantity = 559715794,
PorousMediumPermeabilityDrillingQuantity = 1029374945,
ForceRateOfChangeDrillingQuantity = -64409230,
PressureRateOfChangeDrillingQuantity = 1439614846,
TorqueRateOfChangeDrillingQuantity = -1699229419
}
public static string AccelerationQuantity = "AccelerationQuantity";
public static string AmountSubstanceQuantity = "AmountSubstanceQuantity";
public static string AngleGradientPerLengthQuantity = "AngleGradientPerLengthQuantity";
public static string AngleMagneticFluxDensityQuantity = "AngleMagneticFluxDensityQuantity";
public static string AngularAccelerationQuantity = "AngularAccelerationQuantity";
public static string AngularVelocityQuantity = "AngularVelocityQuantity";
public static string AreaQuantity = "AreaQuantity";
public static string CompressibilityQuantity = "CompressibilityQuantity";
public static string ConsistencyIndexRheologyQuantity = "ConsistencyIndexRheologyQuantity";
public static string CurvatureQuantity = "CurvatureQuantity";
public static string MassDensityGradientPerLengthQuantity = "MassDensityGradientPerLengthQuantity";
public static string MassDensityGradientPerTemperatureQuantity = "MassDensityGradientPerTemperatureQuantity";
public static string MassDensityQuantity = "MassDensityQuantity";
public static string MassDensityRateOfChangeQuantity = "MassDensityRateOfChangeQuantity";
public static string DimensionlessQuantity = "DimensionlessQuantity";
public static string DynamicViscosityQuantity = "DynamicViscosityQuantity";
public static string ElectricCapacitanceQuantity = "ElectricCapacitanceQuantity";
public static string ElectricCurrentQuantity = "ElectricCurrentQuantity";
public static string ElectricTensionQuantity = "ElectricTensionQuantity";
public static string ElongationGradientPerLengthQuantity = "ElongationGradientPerLengthQuantity";
public static string EnergyDensityQuantity = "EnergyDensityQuantity";
public static string ForceGradientPerLengthQuantity = "ForceGradientPerLengthQuantity";
public static string ForceQuantity = "ForceQuantity";
public static string FrequencyQuantity = "FrequencyQuantity";
public static string FrequencyRateOfChangeQuantity = "FrequencyRateOfChangeQuantity";
public static string HeatTransferCoefficientQuantity = "HeatTransferCoefficientQuantity";
public static string ImageScaleQuantity = "ImageScaleQuantity";
public static string InterfacialTensionQuantity = "InterfacialTensionQuantity";
public static string LengthQuantity = "LengthQuantity";
public static string LuminousIntensityQuantity = "LuminousIntensityQuantity";
public static string MagneticFluxDensityQuantity = "MagneticFluxDensityQuantity";
public static string MagneticFluxQuantity = "MagneticFluxQuantity";
public static string MassGradientPerLengthQuantity = "MassGradientPerLengthQuantity";
public static string MassRateQuantity = "MassRateQuantity";
public static string MaterialStrengthQuantity = "MaterialStrengthQuantity";
public static string PorousMediumPermeabilityQuantity = "PorousMediumPermeabilityQuantity";
public static string PlaneAngleQuantity = "PlaneAngleQuantity";
public static string PowerQuantity = "PowerQuantity";
public static string PressureGradientPerLengthQuantity = "PressureGradientPerLengthQuantity";
public static string PressureLossConstantQuantity = "PressureLossConstantQuantity";
public static string PressureQuantity = "PressureQuantity";
public static string ProportionQuantity = "ProportionQuantity";
public static string RandomWalkQuantity = "RandomWalkQuantity";
public static string RelativeTemperatureQuantity = "RelativeTemperatureQuantity";
public static string ElectricResistivityQuantity = "ElectricResistivityQuantity";
public static string SolidAngleQuantity = "SolidAngleQuantity";
public static string IsobaricSpecificHeatCapacityQuantity = "IsobaricSpecificHeatCapacityQuantity";
public static string IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity = "IsobaricSpecificHeatCapacityGradientPerTemperatureQuantity";
public static string StressQuantity = "StressQuantity";
public static string TemperatureGradientPerLengthQuantity = "TemperatureGradientPerLengthQuantity";
public static string TemperatureQuantity = "TemperatureQuantity";
public static string ThermalConductivityQuantity = "ThermalConductivityQuantity";
public static string ThermalConductivityGradientPerTemperatureQuantity = "ThermalConductivityGradientPerTemperatureQuantity";
public static string TimeQuantity = "TimeQuantity";
public static string TorqueGradientPerLengthQuantity = "TorqueGradientPerLengthQuantity";
public static string TorqueQuantity = "TorqueQuantity";
public static string VelocityQuantity = "VelocityQuantity";
public static string VolumeQuantity = "VolumeQuantity";
public static string VolumetricFlowRateOfChangeQuantity = "VolumetricFlowRateOfChangeQuantity";
public static string VolumetricFlowRateQuantity = "VolumetricFlowRateQuantity";
public static string WaveNumberQuantity = "WaveNumberQuantity";
public static string MassQuantity = "MassQuantity";
public static string EnergyQuantity = "EnergyQuantity";
public static string ForceRateOfChangeQuantity = "ForceRateOfChangeQuantity";
public static string PressureRateOfChangeQuantity = "PressureRateOfChangeQuantity";
public static string TorqueRateOfChangeQuantity = "TorqueRateOfChangeQuantity";
public static string DiameterSmallQuantity = "DiameterSmallQuantity";
public static string DimensionLessStandardQuantity = "DimensionLessStandardQuantity";
public static string EarthMagneticFluxDensityQuantity = "EarthMagneticFluxDensityQuantity";
public static string ElasticModulusQuantity = "ElasticModulusQuantity";
public static string LengthSmallQuantity = "LengthSmallQuantity";
public static string RotationalFrequencyQuantity = "RotationalFrequencyQuantity";
public static string GravitationalLoadQuantity = "GravitationalLoadQuantity";
public static string HydraulicConductivityQuantity = "HydraulicConductivityQuantity";
public static string VolumeLargeQuantity = "VolumeLargeQuantity";
public static string RotationalFrequencyRateOfChangeQuantity = "RotationalFrequencyRateOfChangeQuantity";
public static string TensionQuantity = "TensionQuantity";
public static string ProportionStandardQuantity = "ProportionStandardQuantity";
public static string LengthStandardQuantity = "LengthStandardQuantity";
public static string FluidShearRateQuantity = "FluidShearRateQuantity";
public static string FluidShearStressQuantity = "FluidShearStressQuantity";
public static string TorqueSmallQuantity = "TorqueSmallQuantity";
public static string RotationalFrequencySmallQuantity = "RotationalFrequencySmallQuantity";
public static string ProportionSmallQuantity = "ProportionSmallQuantity";
public static string PorosityQuantity = "PorosityQuantity";
public static string StrokeFrequencyQuantity = "StrokeFrequencyQuantity";
public static string ShockRateQuantity = "ShockRateQuantity";
public static string AccelerationDrillingQuantity = "AccelerationDrillingQuantity";
public static string AngleGradientPerLengthDrillingQuantity = "AngleGradientPerLengthDrillingQuantity";
public static string AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity = "AngleMagneticFluxDensitySurveyInstrumentDrillingQuantity";
public static string AngularAccelerationDrillingQuantity = "AngularAccelerationDrillingQuantity";
public static string AngularVelocityDrillingQuantity = "AngularVelocityDrillingQuantity";
public static string AngularVelocitySurveyInstrumentDrillingQuantity = "AngularVelocitySurveyInstrumentDrillingQuantity";
public static string AreaDrillingQuantity = "AreaDrillingQuantity";
public static string AxialVelocityDrillingQuantity = "AxialVelocityDrillingQuantity";
public static string BlockVelocityDrillingQuantity = "BlockVelocityDrillingQuantity";
public static string CableDiameterDrillingQuantity = "CableDiameterDrillingQuantity";
public static string CapillaryPressureDrillingQuantity = "CapillaryPressureDrillingQuantity";
public static string CompressibilityDrillingQuantity = "CompressibilityDrillingQuantity";
public static string CurvatureDrillingQuantity = "CurvatureDrillingQuantity";
public static string DepthDrillingQuantity = "DepthDrillingQuantity";
public static string DiameterPipeDrillingQuantity = "DiameterPipeDrillingQuantity";
public static string DiameterPoreDrillingQuantity = "DiameterPoreDrillingQuantity";
public static string DrillStemMaterialStrengthDrillingQuantity = "DrillStemMaterialStrengthDrillingQuantity";
public static string DrillStringMagneticFluxDrillingQuantity = "DrillStringMagneticFluxDrillingQuantity";
public static string DurationDrillingQuantity = "DurationDrillingQuantity";
public static string DynamicViscosityDrillingQuantity = "DynamicViscosityDrillingQuantity";
public static string ElongationGradientPerLengthDrillingQuantity = "ElongationGradientPerLengthDrillingQuantity";
public static string EnergyDensityDrillingQuantity = "EnergyDensityDrillingQuantity";
public static string MassDensityRateOfChangeDrillingQuantity = "MassDensityRateOfChangeDrillingQuantity";
public static string MassDensityGradientPerTemperatureDrillingQuantity = "MassDensityGradientPerTemperatureDrillingQuantity";
public static string MassDensityGradientPerLengthDrillingQuantity = "MassDensityGradientPerLengthDrillingQuantity";
public static string MassDensityDrillingQuantity = "MassDensityDrillingQuantity";
public static string FluidVelocityDrillingQuantity = "FluidVelocityDrillingQuantity";
public static string ForceGradientPerLengthDrillingQuantity = "ForceGradientPerLengthDrillingQuantity";
public static string ForceDrillingQuantity = "ForceDrillingQuantity";
public static string HeatTransferCoefficientDrillingQuantity = "HeatTransferCoefficientDrillingQuantity";
public static string HydraulicConductivityDrillingQuantity = "HydraulicConductivityDrillingQuantity";
public static string InterfacialTensionDrillingQuantity = "InterfacialTensionDrillingQuantity";
public static string MassGradientPerLengthDrillingQuantity = "MassGradientPerLengthDrillingQuantity";
public static string MassDrillingQuantity = "MassDrillingQuantity";
public static string MassRateDrillingQuantity = "MassRateDrillingQuantity";
public static string PlaneAngleDrillingQuantity = "PlaneAngleDrillingQuantity";
public static string PowerDrillingQuantity = "PowerDrillingQuantity";
public static string PressureGradientPerLengthDrillingQuantity = "PressureGradientPerLengthDrillingQuantity";
public static string PressureLossConstantDrillingQuantity = "PressureLossConstantDrillingQuantity";
public static string PressureDrillingQuantity = "PressureDrillingQuantity";
public static string RandomWalkDrillingQuantity = "RandomWalkDrillingQuantity";
public static string RotationalFrequencyRateOfChangeDrillingQuantity = "RotationalFrequencyRateOfChangeDrillingQuantity";
public static string IsobaricSpecificHeatCapacityDrillingQuantity = "IsobaricSpecificHeatCapacityDrillingQuantity";
public static string IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity = "IsobaricSpecificHeatCapacityGradientPerTemperatureDrillingQuantity";
public static string StickDurationDrillingQuantity = "StickDurationDrillingQuantity";
public static string ReciprocalLengthSurveyInstrumentDrillingQuantity = "ReciprocalLengthSurveyInstrumentDrillingQuantity";
public static string TemperatureGradientPerLengthDrillingQuantity = "TemperatureGradientPerLengthDrillingQuantity";
public static string TemperatureDrillingQuantity = "TemperatureDrillingQuantity";
public static string TensionDrillingQuantity = "TensionDrillingQuantity";
public static string ThermalConductivityDrillingQuantity = "ThermalConductivityDrillingQuantity";
public static string TorqueDrillingQuantity = "TorqueDrillingQuantity";
public static string VolumeDrillingQuantity = "VolumeDrillingQuantity";
public static string VolumetricFlowRateOfChangeDrillingQuantity = "VolumetricFlowRateOfChangeDrillingQuantity";
public static string VolumetricFlowrateDrillingQuantity = "VolumetricFlowrateDrillingQuantity";
public static string FormationResistivityDrillingQuantity = "FormationResistivityDrillingQuantity";
public static string FormationStrengthDrillingQuantity = "FormationStrengthDrillingQuantity";
public static string GammaRayIndexDrillingQuantity = "GammaRayIndexDrillingQuantity";
public static string GasShowDrillingQuantity = "GasShowDrillingQuantity";
public static string GasVolumetricFlowRateDrillingQuantity = "GasVolumetricFlowRateDrillingQuantity";
public static string HeightDrillingQuantity = "HeightDrillingQuantity";
public static string HookLoadDrillingQuantity = "HookLoadDrillingQuantity";
public static string NozzleDiameterDrillingQuantity = "NozzleDiameterDrillingQuantity";
public static string SurfacePoreDrillingQuantity = "SurfacePoreDrillingQuantity";
public static string PositionDrillingQuantity = "PositionDrillingQuantity";
public static string RateOfPenetrationDrillingQuantity = "RateOfPenetrationDrillingQuantity";
public static string WeightOnBitDrillingQuantity = "WeightOnBitDrillingQuantity";
public static string ThermalConductivityGradientPerTemperatureDrillingQuantity = "ThermalConductivityGradientPerTemperatureDrillingQuantity";
public static string TorqueGradientPerLengthDrillingQuantity = "TorqueGradientPerLengthDrillingQuantity";
public static string PorousMediumPermeabilityDrillingQuantity = "PorousMediumPermeabilityDrillingQuantity";
public static string ForceRateOfChangeDrillingQuantity = "ForceRateOfChangeDrillingQuantity";
public static string PressureRateOfChangeDrillingQuantity = "PressureRateOfChangeDrillingQuantity";
public static string TorqueRateOfChangeDrillingQuantity = "TorqueRateOfChangeDrillingQuantity";
}
}
