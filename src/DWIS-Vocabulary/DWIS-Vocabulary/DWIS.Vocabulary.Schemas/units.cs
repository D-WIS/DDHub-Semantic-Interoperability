using System;
namespace DWIS.Vocabulary.Schemas
{
public static class Units
{
public enum Enum
{
MetrePerSecondSquared,
FootPerSecondSquared,
CentimetrePerSecondSquared,
CentimetrePerHourPerSecond,
CentimetrePerMinutePerSecond,
FootPerHourPerSecond,
FootPerMinutePerSecond,
Galileo,
GravityStandard,
InchPerHourPerSecond,
InchPerMinutePerSecond,
InchPerSecondSquared,
KnotPerSecond,
MetrePerSecondPerMillisecond,
MilePerHourPerSecond,
MilePerMinutePerSecond,
MilePerSecondSquared,
KilometrePerSecondSquared,
KilometrePerHourPerSecond,
KilometrePerMinutePerSecond,
Mole,
Decimole,
Centimole,
Millimole,
Micromole,
Nanomole,
Picomole,
Kilomole,
RadianPerMetre,
DegreePerMetre,
DegreePerCentimetre,
DegreePerFoot,
DegreePerInch,
DegreePerDecimetre,
DegreePerMillimetre,
RadianPerMillimetre,
RadianPerCentimetre,
RadianPerDecimetre,
RadianPerFoot,
RadianPerInch,
RadianTesla,
RadianGauss,
RadianMilligauss,
RadianMillitesla,
RadianMicrotesla,
RadianNanotesla,
RadianMaxwellPerSquareCentimetre,
RadianWeberPerSquareMetre,
DegreeTesla,
DegreeGauss,
DegreeMilligauss,
DegreeMillitesla,
DegreeMicrotesla,
DegreeNanotesla,
DegreeMaxwellPerSquareCentimetre,
DegreeWeberPerSquareMetre,
RadianPerSecondSquared,
DegreePerSecondSquared,
RadianPerDayPerSecond,
RadianPerHourPerSecond,
RadianPerMinutePerSecond,
DegreePerDayPerSecond,
DegreePerHourPerSecond,
DegreePerMinutePerSecond,
RadianPerSecondPerMinute,
DegreePerSecondPerMinute,
RadianPerDayPerMinute,
RadianPerHourPerMinute,
RadianPerMinuteSquared,
DegreePerDayPerMinute,
DegreePerHourPerMinute,
DegreePerMinuteSquared,
RadianPerSecondPerHour,
DegreePerSecondPerHour,
RadianPerDayPerHour,
RadianPerHourSquared,
RadianPerMinutePerHour,
DegreePerDayPerHour,
DegreePerHourSquared,
DegreePerMinutePerHour,
RadianPerSecondPerDay,
DegreePerSecondPerDay,
RadianPerDaySquared,
RadianPerHourPerDay,
RadianPerMinutePerDay,
DegreePerDaySquared,
DegreePerHourPerDay,
DegreePerMinutePerDay,
RadianPerSecond,
DegreePerSecond,
RadianPerDay,
RadianPerHour,
RadianPerMinute,
DegreePerDay,
DegreePerHour,
DegreePerMinute,
SquareMetre,
SquareKilometre,
Hectare,
SquareDecametre,
SquareDecimetre,
SquareCentimetre,
SquareMillimetre,
SquareMicrometre,
SquareFoot,
SquareInch,
SquareYard,
Acre,
SquareMile,
InversePascal,
InverseBar,
InversePoundPerSquareInch,
InverseAtmosphere,
PascalSecond,
MicropascalSecond,
Centipoise,
Micropoise,
PoundSecondPer100SquareFoot,
DyneSecondPerSquareCentimetre,
DegreePer10m,
DegreePer30m,
DegreePer30ft,
DegreePer100ft,
DegreePerDecimeter,
DegreePerCentimeter,
DegreePerMillimeter,
DegreePerMicrometer,
DegreePerNanometer,
DegreePerDecameter,
DegreePerHectometer,
DegreePerKilometer,
RadianPerDecimeter,
RadianPerCentimeter,
RadianPerMillimeter,
RadianPerMicrometer,
RadianPerNanometer,
RadianPerDecameter,
RadianPerHectometer,
RadianPerKilometer,
DegreePerYard,
DegreePerMile,
RadianPerYard,
RadianPerMile,
KilogramPerCubicMetrePerMetre,
SpecificGravityPerMetre,
SpecificGravityPer10Metre,
SpecificGravityPer30Metre,
SpecificGravityPer100Metre,
GramPerCubicCentimetrePer100Metre,
PoundPerGallonUkPerFoot,
PoundPerGallonUkPer30Foot,
PoundPerGallonUkPer100Foot,
PoundPerGallonUsPerFoot,
PoundPerGallonUsPer30Foot,
PoundPerGallonUsPer100Foot,
KilogramPerCubicMetrePer10Metre,
KilogramPerCubicMetrePer30Metre,
KilogramPerCubicMetrePer100Metre,
GramPerCubicCentimetrePerMetre,
GramPerCubicCentimetrePer10Metre,
GramPerCubicCentimetrePer30Metre,
PoundPerCubicFootPerFoot,
PoundPerCubicFootPer30Foot,
PoundPerCubicFootPer100Foot,
PoundPerCubicInchPerFoot,
PoundPerCubicInchPer30Foot,
PoundPerCubicInchPer100Foot,
PoundPerCubicYardPerFoot,
PoundPerCubicYardPer30Foot,
PoundPerCubicYardPer100Foot,
KilogramPerCubicMetrePerKelvin,
SpecificGravityPerCelsius,
GramPerCubicCentimetrePerCelsius,
PoundPerGallonUkPerCelsius,
PoundPerGallonUsPerFahrenheit,
PoundPerGallonUkPerFahrenheit,
PoundPerGallonUsPerCelsius,
PoundPerCubicFootPerCelsius,
PoundPerCubicFootPerFahrenheit,
PoundPerCubicInchPerCelsius,
PoundPerCubicInchPerFahrenheit,
PoundPerCubicYardPerCelsius,
PoundPerCubicYeardPerFahrenheit,
KilogramPerCubicMetre,
GramPerCubicMetre,
SpecificGravity,
GramPerCubicCentimetre,
PoundPerGallonUk,
PoundPerGallonUs,
PoundPerCubicFoot,
PoundPerCubicInch,
PoundPerCubicYard,
KilogramPerCubicMetrePerSecond,
SpecificGravityPerSecond,
SpecificGravityPerMinute,
SpecificGravityPerHour,
GramPerCubicCentimetrePerSecond,
GramPerCubicCentimetrePerMinute,
GramPerCubicCentimetrePerHour,
PoundPerGallonUkPerSecond,
PoundPerGallonUkPerMinute,
PoundPerGallonUkPerHour,
PoundPerGallonUsPerSecond,
PoundPerGallonUsPerMinute,
PoundPerGallonUsPerHour,
Dimensionless,
MillipascalSecond,
Poise,
Millipoise,
PoundSecondPerSquareFoot,
PoundSecondPerSquareInch,
Farad,
CoulombPerVolt,
Millifarad,
Microfarad,
Nanofarad,
Picofarad,
Ampere,
CoulombPerSecond,
SiemensVolt,
VoltPerOhm,
WattPerVolt,
WeberPerHenry,
Deciampere,
Centiampere,
Milliampere,
Microampere,
Nanoampere,
Picoampere,
Biot,
Abampere,
Kiloampere,
Megaampere,
Gigaampere,
Teraampere,
Statampere,
Volt,
Millivolt,
Centivolt,
Microvolt,
Nanovolt,
Picovolt,
Kilovolt,
Megavolt,
Gigavolt,
MetrePerMetre,
DecimetrePerMetre,
CentimetrePerMetre,
MillimetrePerMetre,
MicrometrePerMetre,
MetrePerKilometre,
DecimetrePerKilometre,
CentimetrePerKilometre,
MillimetrePerKilometre,
MicrometrePerKilometre,
InchPerFoot,
InchPerYard,
InchPerMile,
FootPerFoot,
FootPerYard,
FootPerMile,
YardPerFoot,
YardPerYard,
YardPerMile,
JoulePerCubicMetre,
JoulePerLitre,
KilojoulePerCubicMetre,
KilojoulePerLitre,
MegajoulePerCubicMetre,
MegajoulePerLitre,
GigajoulePerCubicMetre,
GigajoulePerLitre,
CaloriePerCubicMetre,
CaloriePerLitre,
KilocaloriePerCubicMetre,
KilocaloriePerLitre,
JoulePerCubicFoot,
KilojoulePerCubicFoot,
MegajoulePerCubicFoot,
GigajoulePerCubicFoot,
CaloriePerCubicFoot,
KilocaloriePerCubicFoot,
JoulePerCubicInch,
KilojoulePerCubicInch,
MegajoulePerCubicInch,
GigajoulePerCubicInch,
CaloriePerCubicInch,
KilocaloriePerCubicInch,
JoulePerGallonUk,
KilojoulePerGallonUk,
MegajoulePerGallonUk,
GigajoulePerGallonUk,
CaloriePerGallonUk,
KilocaloriePerGallonUk,
JoulePerGallonUs,
KilojoulePerGallonUs,
MegajoulePerGallonUs,
GigajoulePerGallonUs,
CaloriePerGallonUs,
KilocaloriePerGallonUs,
BritishThermalUnitPerCubicMetre,
BritishThermalUnitPerLitre,
BritishThermalUnitPerCubicFoot,
BritishThermalUnitPerCubicInch,
BritishThermalUnitPerGallonUk,
BritishThermalUnitPerGallonUs,
KiloBritishThermalUnitPerCubicMetre,
KiloBritishThermalUnitPerLitre,
KiloBritishThermalUnitPerCubicFoot,
KiloBritishThermalUnitPerCubicInch,
KiloBritishThermalUnitPerGallonUk,
KiloBritishThermalUnitPerGallonUs,
NewtonPerMetre,
NewtonPer30Metre,
NewtonPer10Metre,
NewtonPerDecimetre,
NewtonPerCentimetre,
NewtonPerMillimetre,
DecanewtonPerMetre,
DecanewtonPer30Metre,
DecanewtonPer10Metre,
DecanewtonPerDecimetre,
DecanewtonPerCentimetre,
DecanewtonPerMillimetre,
KilonewtonPerMetre,
KilonewtonPer30Metre,
KilonewtonPer10Metre,
KilonewtonPerDecimetre,
KilonewtonPerCentimetre,
KilonewtonPerMillimetre,
PoundPerFoot,
PoundPerInch,
KilopoundPerFoot,
KilopoundPerInch,
PoundPer30Foot,
PoundPer100Foot,
KilopoundPer30Foot,
KilopoundPer100Foot,
Newton,
Decanewton,
Kilonewton,
Kilodecanewton,
KilogramForce,
PoundForce,
KilopoundForce,
Hertz,
ReciprocalSecond,
Kilohertz,
Megahertz,
Gigahertz,
Terahertz,
Rpm,
Spm,
RotationPerSecond,
StrokePerSecond,
StrokePerHour,
RotationPerHour,
ShockPerSecond,
ShockPerMinute,
ShockPerHour,
HertzPerSecond,
KiloHertzPerSecond,
MegaHertzPerSecond,
GigaHertzPerSecond,
HertzPerMinute,
KiloHertzPerMinute,
MegaHertzPerMinute,
GigaHertzPerMinute,
HertzPerHour,
KiloHertzPerHour,
MegaHertzPerHour,
GigaHertzPerHour,
HertzPerDay,
KiloHertzPerDay,
MegaHertzPerDay,
GigaHertzPerDay,
HertzPerYear,
KiloHertzPerYear,
MegaHertzPerYear,
GigaHertzPerYear,
RpmPerSecond,
SpmPerSecond,
WattPerSquareMetrePerKelvin,
BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit,
DotPerMetre,
DotPerInch,
DotPerMillimetre,
DotPerMicrometre,
MillinewtonPerMetre,
DynePerCentimetre,
PoundPerSecondSquared,
Metre,
Decimetre,
Centimetre,
Millimetre,
Micrometre,
Nanometre,
Aangstroem,
Picometre,
Decametre,
Hectometre,
Kilometre,
AstronomicalUnit,
LightYear,
Parsec,
Foot,
UsSurveyFoot,
Inch,
Yard,
Fathom,
SurveyorSChain,
Mile,
InternationalNauticalMile,
UkNauticalMile,
ScandinavianMile,
InchPer32,
Mil,
Thou,
Hand,
Furlong,
Candela,
LumenPerSteradian,
Millicandela,
Kilocandela,
Hefnerkerze,
InternationalCandle,
DecimalCandle,
BerlinerLichteinheit,
DvwgCandle,
Violle,
Carcel,
Tesla,
Gauss,
Milligauss,
Millitesla,
Microtesla,
Nanotesla,
MaxwellPerSquareCentimetre,
WeberPerSquareMetre,
Weber,
Milliweber,
Microweber,
VoltSecond,
UnitPole,
Megaline,
Kiloline,
Line,
Maxwell,
TeslaSquareMetre,
TeslaSquareCentimetre,
GaussSquareCentimetre,
MagneticFluxQuantum,
KilogramPerMetre,
GramPerMetre,
KilogramPerSecond,
KilogramPerMinute,
KilogramPerHour,
KilogramPerYear,
PoundPerSecond,
PoundPerMinute,
PoundPerHour,
PoundPerYear,
Pascal,
Megapascal,
Gigapascal,
Psi,
PoundPer100SquareFoot,
MegapoundPerSquareInch,
Darcy,
Millidarcy,
Microdarcy,
Nanodarcy,
Radian,
Milliradian,
Degree,
Grad,
Gon,
Circle,
Revolution,
Quadrant,
Sextant,
Octant,
ArcMinute,
ArcSecond,
Watt,
Decawatt,
Hectowatt,
Kilowatt,
Megawatt,
Gigawatt,
Terawatt,
Petawatt,
Exawatt,
Deciwatt,
Centiwatt,
Milliwatt,
Microwatt,
Nanowatt,
Picowatt,
Femtowatt,
Attowatt,
PascalPerMetre,
BarPerMetre,
PsiPerMetre,
PsiPerFoot,
PressureLossConstantSi,
PressureLossConstantMetric,
PressureLossConstantUk,
PressureLossConstantUs,
Kilopascal,
Bar,
Millibar,
Microbar,
PoundPerSquareInch,
KilopoundPerSquareInch,
StandardAtmosphere,
PoundPerSquareFoot,
NewtonPerSquareMetre,
NewtonPerSquareCentimetre,
NewtonPerSquareMillimetre,
KilonewtonPerSquareMetre,
Torr,
CentimetreMercuryAtZeroDegreeCelsius,
MillimetreMercuryAtZeroDegreeCelsius,
InchMercuryAt32DegreeFahrenheit,
InchMercuryAt60DegreeFahrenheit,
CentimetreWaterAt4DegreeCelsius,
MillimetreWaterAt4DegreeCelsius,
InchWaterAt4DegreeCelsius,
FootWaterAt4DegreeCelsius,
DynePerSquareCentimetre,
Proportion,
Percent,
PerThousand,
PartPerMillion,
RadianPerSquareRootSecond,
RadianPerSquareRootMinute,
RadianPerSquareRootHour,
RadianPerSquareRootDay,
DegreePerSquareRootSecond,
DegreePerSquareRootMinute,
DegreePerSquareRootHour,
DegreePerSquareRootDay,
Kelvin,
RelativeCelsius,
Rankine,
OhmMetre,
KiloOhmMetre,
MegaOhmMetre,
GigaOhmMetre,
Steradian,
Spat,
DegreeSquared,
JoulePerKilogramKelvin,
JoulePerGramKelvin,
JoulePerGramDegreeCelsius,
CaloriePerGramDegreeCelsius,
BritishThermalUnitPerPoundDegreeFahrenheit,
KilocaloriePerGramDegreeCelsius,
JoulePerKilogramSquaredKelvin,
JoulePerGramSquaredKelvin,
JoulePerGramDegreeSquaredCelsius,
CaloriePerGramDegreeSquaredCelsius,
BritishThermalUnitPerPoundSquaredDegreeFahrenheit,
KelvinPerMetre,
CelsiusPerMetre,
CelsiusPer10Metre,
CelsiusPer30Metre,
CelsiusPer100Metre,
CelsiusPerFoot,
CelsiusPer30Foot,
CelsiusPer100Foot,
FahrenheitPerFoot,
FahrenheitPer30Foot,
FahrenheitPer100Foot,
Celsius,
Fahrenheit,
Réaumur,
WattPerMetreKelvin,
CaloriePerMetreSecondDegreeCelsius,
CaloriePerCentimetreSecondDegreeCelsius,
BritishThermalUnitPerHourFootDegreeFahrenheit,
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit,
WattPerMetreKelvinPerKelvin,
CaloriePerMetreSecondDegreeCelsiusSquared,
CaloriePerCentimetreSecondDegreeCelsiusSquared,
BritishThermalUnitPerHourFootDegreeFahrenheitSquared,
BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared,
Second,
Millisecond,
Microsecond,
Shake,
Nanosecond,
Picosecond,
Minute,
Hour,
Day,
Week,
Fortnight,
MonthCommon,
MonthSideral,
MonthSynodic,
QuarterCommon,
YearCommon,
YearAverageGregorian,
YearJulian,
YearLeap,
YearTropical,
Decade,
Century,
Millenia,
MillionYear,
NewtonMetrePerMetre,
DecanewtonMetrePerMetre,
KilogramForceMetrePerMetre,
KilonewtonMetrePerMetre,
FootPoundPerMetre,
KilofootPoundPerMetre,
NewtonDecimetrePerMetre,
NewtonCentimetrePerMetre,
NewtonMillimetrePerMetre,
InchPoundPerMetre,
NewtonMetrePerDecimetre,
DecanewtonMetrePerDecimetre,
KilogramForceMetrePerDecimetre,
KilonewtonMetrePerDecimetre,
FootPoundPerDecimetre,
KilofootPoundPerDecimetre,
NewtonDecimetrePerDecimetre,
NewtonCentimetrePerDecimetre,
NewtonMillimetrePerDecimetre,
InchPoundPerDecimetre,
NewtonMetrePerCentimetre,
DecanewtonMetrePerCentimetre,
KilogramForceMetrePerCentimetre,
KilonewtonMetrePerCentimetre,
FootPoundPerCentimetre,
KilofootPoundPerCentimetre,
NewtonDecimetrePerCentimetre,
NewtonCentimetrePerCentimetre,
NewtonMillimetrePerCentimetre,
InchPoundPerCentimetre,
NewtonMetrePerMillimetre,
DecanewtonMetrePerMillimetre,
KilogramForceMetrePerMillimetre,
KilonewtonMetrePerMillimetre,
FootPoundPerMillimetre,
KilofootPoundPerMillimetre,
NewtonDecimetrePerMillimetre,
NewtonCentimetrePerMillimetre,
NewtonMillimetrePerMillimetre,
InchPoundPerMillimetre,
NewtonMetrePerFoot,
DecanewtonMetrePerFoot,
KilogramForceMetrePerFoot,
KilonewtonMetrePerFoot,
FootPoundPerFoot,
KilofootPoundPerFoot,
NewtonDecimetrePerFoot,
NewtonCentimetrePerFoot,
NewtonMillimetrePerFoot,
InchPoundPerFoot,
NewtonMetrePerInch,
DecanewtonMetrePerInch,
KilogramForceMetrePerInch,
KilonewtonMetrePerInch,
FootPoundPerInch,
KilofootPoundPerInch,
NewtonDecimetrePerInch,
NewtonCentimetrePerInch,
NewtonMillimetrePerInch,
InchPoundPerInch,
NewtonMetre,
DecanewtonMetre,
KilogramForceMetre,
KilonewtonMetre,
FootPound,
KilofootPound,
NewtonDecimetre,
NewtonCentimetre,
NewtonMillimetre,
InchPound,
MetrePerSecond,
MetrePerMinute,
CentimetrePerSecond,
MetrePerHour,
MetrePerDay,
FootPerHour,
FootPerDay,
FootPerMinute,
FootPerSecond,
InchPerSecond,
MilePerHour,
KilometrePerHour,
KilometrePerMinute,
KilometrePerSecond,
KilometrePerDay,
MilePerMinute,
MilePerSecond,
MilePerDay,
InchPerMinute,
InchPerHour,
InchPerDay,
CentimetrePerMinute,
CentimetrePerHour,
CentimetrePerDay,
MillimetrePerSecond,
MillimetrePerMinute,
MillimetrePerHour,
MillimetrePerDay,
DecimetrePerSecond,
DecimetrePerMinute,
DecimetrePerHour,
DecimetrePerDay,
FurlongPerFortnight,
CubicMetre,
Litre,
Decilitre,
Centilitre,
Millilitre,
UsGallon,
UkGallon,
Barrel,
MillionCubicMetre,
MillionLitre,
MillionUkGallon,
MillionBarrel,
ThousandStandardCubicFoot,
MillionStandardCubicFoot,
CubicFoot,
CubicInch,
MillionUsGallon,
CubicMetrePerSecondSquared,
LitrePerMinuteSquared,
LitrePerMinutePerSecond,
LitrePerSecondSquared,
UkGallonPerMinuteSquared,
UkGallonPerMinutePerSecond,
UsGallonPerMinuteSquared,
UsGallonPerMinutePerSecond,
CubicMetrePerSecond,
LitrePerSecond,
CubicFootPerSecond,
UkGallonPerSecond,
UsGallonPerSecond,
BarrelPerSecond,
CubicMetrePerMinute,
LitrePerMinute,
CubicFootPerMinute,
UkGallonPerMinute,
UsGallonPerMinute,
BarrelPerMinute,
CubicMetrePerHour,
LitrePerHour,
CubicFootPerHour,
UkGallonPerHour,
UsGallonPerHour,
BarrelPerHour,
CubicMetrePerDay,
MillionCubicMetrePerDay,
UkGallonPerDay,
UsGallonPerDay,
MillionUkGallonPerDay,
MillionUsGallonPerDay,
LitrePerDay,
MillionLiterPerDay,
CubicFootPerDay,
ThousandStandardCubicFootPerDay,
MillionStandardCubicFootPerDay,
BarrelPerDay,
CubicMetrePerYear,
LitrePerYear,
CubicFootPerYear,
UkGallonPerYear,
UsGallonPerYear,
BarrelPerYear,
ReciprocalMetre,
ReciprocalDecimetre,
ReciprocalCentimetre,
ReciprocalMillimetre,
ReciprocalMicrometre,
ReciprocalNanometre,
ReciprocalAangstroem,
ReciprocalPicometre,
ReciprocalDecametre,
ReciprocalHectometre,
ReciprocalKilometre,
ReciprocalAstronomicalUnit,
ReciprocalLightYear,
ReciprocalParsec,
ReciprocalFoot,
ReciprocalUsSurveyFoot,
ReciprocalInch,
ReciprocalYard,
ReciprocalFathom,
ReciprocalSurveyorsChain,
ReciprocalMile,
ReciprocalInternationalNauticalMile,
ReciprocalUkNauticalMile,
ReciprocalScandinavianMile,
ReciprocalInchPer32,
ReciprocalMil,
ReciprocalThou,
ReciprocalHand,
ReciprocalFurlong,
Kilogram,
Hectogram,
Decagram,
Gram,
Centigram,
Milligram,
Microgram,
Nanogram,
AtomMassUnit,
TonneMetric,
Kilotonne,
Megatonne,
Gigatonne,
Pound,
Kilopound,
Ounce,
Stone,
TonUk,
TonUs,
SolarMass,
EarthMass,
Grain,
HundredWeights,
Joule,
Kilojoule,
Megajoule,
Gigajoule,
Calorie,
Kilocalorie,
BritishThermalUnit,
KiloBritishThermalUnit,
MegaBritishThermalUnit
}
public static string MetrePerSecondSquared = "MetrePerSecondSquared";
public static string FootPerSecondSquared = "FootPerSecondSquared";
public static string CentimetrePerSecondSquared = "CentimetrePerSecondSquared";
public static string CentimetrePerHourPerSecond = "CentimetrePerHourPerSecond";
public static string CentimetrePerMinutePerSecond = "CentimetrePerMinutePerSecond";
public static string FootPerHourPerSecond = "FootPerHourPerSecond";
public static string FootPerMinutePerSecond = "FootPerMinutePerSecond";
public static string Galileo = "Galileo";
public static string GravityStandard = "GravityStandard";
public static string InchPerHourPerSecond = "InchPerHourPerSecond";
public static string InchPerMinutePerSecond = "InchPerMinutePerSecond";
public static string InchPerSecondSquared = "InchPerSecondSquared";
public static string KnotPerSecond = "KnotPerSecond";
public static string MetrePerSecondPerMillisecond = "MetrePerSecondPerMillisecond";
public static string MilePerHourPerSecond = "MilePerHourPerSecond";
public static string MilePerMinutePerSecond = "MilePerMinutePerSecond";
public static string MilePerSecondSquared = "MilePerSecondSquared";
public static string KilometrePerSecondSquared = "KilometrePerSecondSquared";
public static string KilometrePerHourPerSecond = "KilometrePerHourPerSecond";
public static string KilometrePerMinutePerSecond = "KilometrePerMinutePerSecond";
public static string Mole = "Mole";
public static string Decimole = "Decimole";
public static string Centimole = "Centimole";
public static string Millimole = "Millimole";
public static string Micromole = "Micromole";
public static string Nanomole = "Nanomole";
public static string Picomole = "Picomole";
public static string Kilomole = "Kilomole";
public static string RadianPerMetre = "RadianPerMetre";
public static string DegreePerMetre = "DegreePerMetre";
public static string DegreePerCentimetre = "DegreePerCentimetre";
public static string DegreePerFoot = "DegreePerFoot";
public static string DegreePerInch = "DegreePerInch";
public static string DegreePerDecimetre = "DegreePerDecimetre";
public static string DegreePerMillimetre = "DegreePerMillimetre";
public static string RadianPerMillimetre = "RadianPerMillimetre";
public static string RadianPerCentimetre = "RadianPerCentimetre";
public static string RadianPerDecimetre = "RadianPerDecimetre";
public static string RadianPerFoot = "RadianPerFoot";
public static string RadianPerInch = "RadianPerInch";
public static string RadianTesla = "RadianTesla";
public static string RadianGauss = "RadianGauss";
public static string RadianMilligauss = "RadianMilligauss";
public static string RadianMillitesla = "RadianMillitesla";
public static string RadianMicrotesla = "RadianMicrotesla";
public static string RadianNanotesla = "RadianNanotesla";
public static string RadianMaxwellPerSquareCentimetre = "RadianMaxwellPerSquareCentimetre";
public static string RadianWeberPerSquareMetre = "RadianWeberPerSquareMetre";
public static string DegreeTesla = "DegreeTesla";
public static string DegreeGauss = "DegreeGauss";
public static string DegreeMilligauss = "DegreeMilligauss";
public static string DegreeMillitesla = "DegreeMillitesla";
public static string DegreeMicrotesla = "DegreeMicrotesla";
public static string DegreeNanotesla = "DegreeNanotesla";
public static string DegreeMaxwellPerSquareCentimetre = "DegreeMaxwellPerSquareCentimetre";
public static string DegreeWeberPerSquareMetre = "DegreeWeberPerSquareMetre";
public static string RadianPerSecondSquared = "RadianPerSecondSquared";
public static string DegreePerSecondSquared = "DegreePerSecondSquared";
public static string RadianPerDayPerSecond = "RadianPerDayPerSecond";
public static string RadianPerHourPerSecond = "RadianPerHourPerSecond";
public static string RadianPerMinutePerSecond = "RadianPerMinutePerSecond";
public static string DegreePerDayPerSecond = "DegreePerDayPerSecond";
public static string DegreePerHourPerSecond = "DegreePerHourPerSecond";
public static string DegreePerMinutePerSecond = "DegreePerMinutePerSecond";
public static string RadianPerSecondPerMinute = "RadianPerSecondPerMinute";
public static string DegreePerSecondPerMinute = "DegreePerSecondPerMinute";
public static string RadianPerDayPerMinute = "RadianPerDayPerMinute";
public static string RadianPerHourPerMinute = "RadianPerHourPerMinute";
public static string RadianPerMinuteSquared = "RadianPerMinuteSquared";
public static string DegreePerDayPerMinute = "DegreePerDayPerMinute";
public static string DegreePerHourPerMinute = "DegreePerHourPerMinute";
public static string DegreePerMinuteSquared = "DegreePerMinuteSquared";
public static string RadianPerSecondPerHour = "RadianPerSecondPerHour";
public static string DegreePerSecondPerHour = "DegreePerSecondPerHour";
public static string RadianPerDayPerHour = "RadianPerDayPerHour";
public static string RadianPerHourSquared = "RadianPerHourSquared";
public static string RadianPerMinutePerHour = "RadianPerMinutePerHour";
public static string DegreePerDayPerHour = "DegreePerDayPerHour";
public static string DegreePerHourSquared = "DegreePerHourSquared";
public static string DegreePerMinutePerHour = "DegreePerMinutePerHour";
public static string RadianPerSecondPerDay = "RadianPerSecondPerDay";
public static string DegreePerSecondPerDay = "DegreePerSecondPerDay";
public static string RadianPerDaySquared = "RadianPerDaySquared";
public static string RadianPerHourPerDay = "RadianPerHourPerDay";
public static string RadianPerMinutePerDay = "RadianPerMinutePerDay";
public static string DegreePerDaySquared = "DegreePerDaySquared";
public static string DegreePerHourPerDay = "DegreePerHourPerDay";
public static string DegreePerMinutePerDay = "DegreePerMinutePerDay";
public static string RadianPerSecond = "RadianPerSecond";
public static string DegreePerSecond = "DegreePerSecond";
public static string RadianPerDay = "RadianPerDay";
public static string RadianPerHour = "RadianPerHour";
public static string RadianPerMinute = "RadianPerMinute";
public static string DegreePerDay = "DegreePerDay";
public static string DegreePerHour = "DegreePerHour";
public static string DegreePerMinute = "DegreePerMinute";
public static string SquareMetre = "SquareMetre";
public static string SquareKilometre = "SquareKilometre";
public static string Hectare = "Hectare";
public static string SquareDecametre = "SquareDecametre";
public static string SquareDecimetre = "SquareDecimetre";
public static string SquareCentimetre = "SquareCentimetre";
public static string SquareMillimetre = "SquareMillimetre";
public static string SquareMicrometre = "SquareMicrometre";
public static string SquareFoot = "SquareFoot";
public static string SquareInch = "SquareInch";
public static string SquareYard = "SquareYard";
public static string Acre = "Acre";
public static string SquareMile = "SquareMile";
public static string InversePascal = "InversePascal";
public static string InverseBar = "InverseBar";
public static string InversePoundPerSquareInch = "InversePoundPerSquareInch";
public static string InverseAtmosphere = "InverseAtmosphere";
public static string PascalSecond = "PascalSecond";
public static string MicropascalSecond = "MicropascalSecond";
public static string Centipoise = "Centipoise";
public static string Micropoise = "Micropoise";
public static string PoundSecondPer100SquareFoot = "PoundSecondPer100SquareFoot";
public static string DyneSecondPerSquareCentimetre = "DyneSecondPerSquareCentimetre";
public static string DegreePer10m = "DegreePer10m";
public static string DegreePer30m = "DegreePer30m";
public static string DegreePer30ft = "DegreePer30ft";
public static string DegreePer100ft = "DegreePer100ft";
public static string DegreePerDecimeter = "DegreePerDecimeter";
public static string DegreePerCentimeter = "DegreePerCentimeter";
public static string DegreePerMillimeter = "DegreePerMillimeter";
public static string DegreePerMicrometer = "DegreePerMicrometer";
public static string DegreePerNanometer = "DegreePerNanometer";
public static string DegreePerDecameter = "DegreePerDecameter";
public static string DegreePerHectometer = "DegreePerHectometer";
public static string DegreePerKilometer = "DegreePerKilometer";
public static string RadianPerDecimeter = "RadianPerDecimeter";
public static string RadianPerCentimeter = "RadianPerCentimeter";
public static string RadianPerMillimeter = "RadianPerMillimeter";
public static string RadianPerMicrometer = "RadianPerMicrometer";
public static string RadianPerNanometer = "RadianPerNanometer";
public static string RadianPerDecameter = "RadianPerDecameter";
public static string RadianPerHectometer = "RadianPerHectometer";
public static string RadianPerKilometer = "RadianPerKilometer";
public static string DegreePerYard = "DegreePerYard";
public static string DegreePerMile = "DegreePerMile";
public static string RadianPerYard = "RadianPerYard";
public static string RadianPerMile = "RadianPerMile";
public static string KilogramPerCubicMetrePerMetre = "KilogramPerCubicMetrePerMetre";
public static string SpecificGravityPerMetre = "SpecificGravityPerMetre";
public static string SpecificGravityPer10Metre = "SpecificGravityPer10Metre";
public static string SpecificGravityPer30Metre = "SpecificGravityPer30Metre";
public static string SpecificGravityPer100Metre = "SpecificGravityPer100Metre";
public static string GramPerCubicCentimetrePer100Metre = "GramPerCubicCentimetrePer100Metre";
public static string PoundPerGallonUkPerFoot = "PoundPerGallonUkPerFoot";
public static string PoundPerGallonUkPer30Foot = "PoundPerGallonUkPer30Foot";
public static string PoundPerGallonUkPer100Foot = "PoundPerGallonUkPer100Foot";
public static string PoundPerGallonUsPerFoot = "PoundPerGallonUsPerFoot";
public static string PoundPerGallonUsPer30Foot = "PoundPerGallonUsPer30Foot";
public static string PoundPerGallonUsPer100Foot = "PoundPerGallonUsPer100Foot";
public static string KilogramPerCubicMetrePer10Metre = "KilogramPerCubicMetrePer10Metre";
public static string KilogramPerCubicMetrePer30Metre = "KilogramPerCubicMetrePer30Metre";
public static string KilogramPerCubicMetrePer100Metre = "KilogramPerCubicMetrePer100Metre";
public static string GramPerCubicCentimetrePerMetre = "GramPerCubicCentimetrePerMetre";
public static string GramPerCubicCentimetrePer10Metre = "GramPerCubicCentimetrePer10Metre";
public static string GramPerCubicCentimetrePer30Metre = "GramPerCubicCentimetrePer30Metre";
public static string PoundPerCubicFootPerFoot = "PoundPerCubicFootPerFoot";
public static string PoundPerCubicFootPer30Foot = "PoundPerCubicFootPer30Foot";
public static string PoundPerCubicFootPer100Foot = "PoundPerCubicFootPer100Foot";
public static string PoundPerCubicInchPerFoot = "PoundPerCubicInchPerFoot";
public static string PoundPerCubicInchPer30Foot = "PoundPerCubicInchPer30Foot";
public static string PoundPerCubicInchPer100Foot = "PoundPerCubicInchPer100Foot";
public static string PoundPerCubicYardPerFoot = "PoundPerCubicYardPerFoot";
public static string PoundPerCubicYardPer30Foot = "PoundPerCubicYardPer30Foot";
public static string PoundPerCubicYardPer100Foot = "PoundPerCubicYardPer100Foot";
public static string KilogramPerCubicMetrePerKelvin = "KilogramPerCubicMetrePerKelvin";
public static string SpecificGravityPerCelsius = "SpecificGravityPerCelsius";
public static string GramPerCubicCentimetrePerCelsius = "GramPerCubicCentimetrePerCelsius";
public static string PoundPerGallonUkPerCelsius = "PoundPerGallonUkPerCelsius";
public static string PoundPerGallonUsPerFahrenheit = "PoundPerGallonUsPerFahrenheit";
public static string PoundPerGallonUkPerFahrenheit = "PoundPerGallonUkPerFahrenheit";
public static string PoundPerGallonUsPerCelsius = "PoundPerGallonUsPerCelsius";
public static string PoundPerCubicFootPerCelsius = "PoundPerCubicFootPerCelsius";
public static string PoundPerCubicFootPerFahrenheit = "PoundPerCubicFootPerFahrenheit";
public static string PoundPerCubicInchPerCelsius = "PoundPerCubicInchPerCelsius";
public static string PoundPerCubicInchPerFahrenheit = "PoundPerCubicInchPerFahrenheit";
public static string PoundPerCubicYardPerCelsius = "PoundPerCubicYardPerCelsius";
public static string PoundPerCubicYeardPerFahrenheit = "PoundPerCubicYeardPerFahrenheit";
public static string KilogramPerCubicMetre = "KilogramPerCubicMetre";
public static string GramPerCubicMetre = "GramPerCubicMetre";
public static string SpecificGravity = "SpecificGravity";
public static string GramPerCubicCentimetre = "GramPerCubicCentimetre";
public static string PoundPerGallonUk = "PoundPerGallonUk";
public static string PoundPerGallonUs = "PoundPerGallonUs";
public static string PoundPerCubicFoot = "PoundPerCubicFoot";
public static string PoundPerCubicInch = "PoundPerCubicInch";
public static string PoundPerCubicYard = "PoundPerCubicYard";
public static string KilogramPerCubicMetrePerSecond = "KilogramPerCubicMetrePerSecond";
public static string SpecificGravityPerSecond = "SpecificGravityPerSecond";
public static string SpecificGravityPerMinute = "SpecificGravityPerMinute";
public static string SpecificGravityPerHour = "SpecificGravityPerHour";
public static string GramPerCubicCentimetrePerSecond = "GramPerCubicCentimetrePerSecond";
public static string GramPerCubicCentimetrePerMinute = "GramPerCubicCentimetrePerMinute";
public static string GramPerCubicCentimetrePerHour = "GramPerCubicCentimetrePerHour";
public static string PoundPerGallonUkPerSecond = "PoundPerGallonUkPerSecond";
public static string PoundPerGallonUkPerMinute = "PoundPerGallonUkPerMinute";
public static string PoundPerGallonUkPerHour = "PoundPerGallonUkPerHour";
public static string PoundPerGallonUsPerSecond = "PoundPerGallonUsPerSecond";
public static string PoundPerGallonUsPerMinute = "PoundPerGallonUsPerMinute";
public static string PoundPerGallonUsPerHour = "PoundPerGallonUsPerHour";
public static string Dimensionless = "Dimensionless";
public static string MillipascalSecond = "MillipascalSecond";
public static string Poise = "Poise";
public static string Millipoise = "Millipoise";
public static string PoundSecondPerSquareFoot = "PoundSecondPerSquareFoot";
public static string PoundSecondPerSquareInch = "PoundSecondPerSquareInch";
public static string Farad = "Farad";
public static string CoulombPerVolt = "CoulombPerVolt";
public static string Millifarad = "Millifarad";
public static string Microfarad = "Microfarad";
public static string Nanofarad = "Nanofarad";
public static string Picofarad = "Picofarad";
public static string Ampere = "Ampere";
public static string CoulombPerSecond = "CoulombPerSecond";
public static string SiemensVolt = "SiemensVolt";
public static string VoltPerOhm = "VoltPerOhm";
public static string WattPerVolt = "WattPerVolt";
public static string WeberPerHenry = "WeberPerHenry";
public static string Deciampere = "Deciampere";
public static string Centiampere = "Centiampere";
public static string Milliampere = "Milliampere";
public static string Microampere = "Microampere";
public static string Nanoampere = "Nanoampere";
public static string Picoampere = "Picoampere";
public static string Biot = "Biot";
public static string Abampere = "Abampere";
public static string Kiloampere = "Kiloampere";
public static string Megaampere = "Megaampere";
public static string Gigaampere = "Gigaampere";
public static string Teraampere = "Teraampere";
public static string Statampere = "Statampere";
public static string Volt = "Volt";
public static string Millivolt = "Millivolt";
public static string Centivolt = "Centivolt";
public static string Microvolt = "Microvolt";
public static string Nanovolt = "Nanovolt";
public static string Picovolt = "Picovolt";
public static string Kilovolt = "Kilovolt";
public static string Megavolt = "Megavolt";
public static string Gigavolt = "Gigavolt";
public static string MetrePerMetre = "MetrePerMetre";
public static string DecimetrePerMetre = "DecimetrePerMetre";
public static string CentimetrePerMetre = "CentimetrePerMetre";
public static string MillimetrePerMetre = "MillimetrePerMetre";
public static string MicrometrePerMetre = "MicrometrePerMetre";
public static string MetrePerKilometre = "MetrePerKilometre";
public static string DecimetrePerKilometre = "DecimetrePerKilometre";
public static string CentimetrePerKilometre = "CentimetrePerKilometre";
public static string MillimetrePerKilometre = "MillimetrePerKilometre";
public static string MicrometrePerKilometre = "MicrometrePerKilometre";
public static string InchPerFoot = "InchPerFoot";
public static string InchPerYard = "InchPerYard";
public static string InchPerMile = "InchPerMile";
public static string FootPerFoot = "FootPerFoot";
public static string FootPerYard = "FootPerYard";
public static string FootPerMile = "FootPerMile";
public static string YardPerFoot = "YardPerFoot";
public static string YardPerYard = "YardPerYard";
public static string YardPerMile = "YardPerMile";
public static string JoulePerCubicMetre = "JoulePerCubicMetre";
public static string JoulePerLitre = "JoulePerLitre";
public static string KilojoulePerCubicMetre = "KilojoulePerCubicMetre";
public static string KilojoulePerLitre = "KilojoulePerLitre";
public static string MegajoulePerCubicMetre = "MegajoulePerCubicMetre";
public static string MegajoulePerLitre = "MegajoulePerLitre";
public static string GigajoulePerCubicMetre = "GigajoulePerCubicMetre";
public static string GigajoulePerLitre = "GigajoulePerLitre";
public static string CaloriePerCubicMetre = "CaloriePerCubicMetre";
public static string CaloriePerLitre = "CaloriePerLitre";
public static string KilocaloriePerCubicMetre = "KilocaloriePerCubicMetre";
public static string KilocaloriePerLitre = "KilocaloriePerLitre";
public static string JoulePerCubicFoot = "JoulePerCubicFoot";
public static string KilojoulePerCubicFoot = "KilojoulePerCubicFoot";
public static string MegajoulePerCubicFoot = "MegajoulePerCubicFoot";
public static string GigajoulePerCubicFoot = "GigajoulePerCubicFoot";
public static string CaloriePerCubicFoot = "CaloriePerCubicFoot";
public static string KilocaloriePerCubicFoot = "KilocaloriePerCubicFoot";
public static string JoulePerCubicInch = "JoulePerCubicInch";
public static string KilojoulePerCubicInch = "KilojoulePerCubicInch";
public static string MegajoulePerCubicInch = "MegajoulePerCubicInch";
public static string GigajoulePerCubicInch = "GigajoulePerCubicInch";
public static string CaloriePerCubicInch = "CaloriePerCubicInch";
public static string KilocaloriePerCubicInch = "KilocaloriePerCubicInch";
public static string JoulePerGallonUk = "JoulePerGallonUk";
public static string KilojoulePerGallonUk = "KilojoulePerGallonUk";
public static string MegajoulePerGallonUk = "MegajoulePerGallonUk";
public static string GigajoulePerGallonUk = "GigajoulePerGallonUk";
public static string CaloriePerGallonUk = "CaloriePerGallonUk";
public static string KilocaloriePerGallonUk = "KilocaloriePerGallonUk";
public static string JoulePerGallonUs = "JoulePerGallonUs";
public static string KilojoulePerGallonUs = "KilojoulePerGallonUs";
public static string MegajoulePerGallonUs = "MegajoulePerGallonUs";
public static string GigajoulePerGallonUs = "GigajoulePerGallonUs";
public static string CaloriePerGallonUs = "CaloriePerGallonUs";
public static string KilocaloriePerGallonUs = "KilocaloriePerGallonUs";
public static string BritishThermalUnitPerCubicMetre = "BritishThermalUnitPerCubicMetre";
public static string BritishThermalUnitPerLitre = "BritishThermalUnitPerLitre";
public static string BritishThermalUnitPerCubicFoot = "BritishThermalUnitPerCubicFoot";
public static string BritishThermalUnitPerCubicInch = "BritishThermalUnitPerCubicInch";
public static string BritishThermalUnitPerGallonUk = "BritishThermalUnitPerGallonUk";
public static string BritishThermalUnitPerGallonUs = "BritishThermalUnitPerGallonUs";
public static string KiloBritishThermalUnitPerCubicMetre = "KiloBritishThermalUnitPerCubicMetre";
public static string KiloBritishThermalUnitPerLitre = "KiloBritishThermalUnitPerLitre";
public static string KiloBritishThermalUnitPerCubicFoot = "KiloBritishThermalUnitPerCubicFoot";
public static string KiloBritishThermalUnitPerCubicInch = "KiloBritishThermalUnitPerCubicInch";
public static string KiloBritishThermalUnitPerGallonUk = "KiloBritishThermalUnitPerGallonUk";
public static string KiloBritishThermalUnitPerGallonUs = "KiloBritishThermalUnitPerGallonUs";
public static string NewtonPerMetre = "NewtonPerMetre";
public static string NewtonPer30Metre = "NewtonPer30Metre";
public static string NewtonPer10Metre = "NewtonPer10Metre";
public static string NewtonPerDecimetre = "NewtonPerDecimetre";
public static string NewtonPerCentimetre = "NewtonPerCentimetre";
public static string NewtonPerMillimetre = "NewtonPerMillimetre";
public static string DecanewtonPerMetre = "DecanewtonPerMetre";
public static string DecanewtonPer30Metre = "DecanewtonPer30Metre";
public static string DecanewtonPer10Metre = "DecanewtonPer10Metre";
public static string DecanewtonPerDecimetre = "DecanewtonPerDecimetre";
public static string DecanewtonPerCentimetre = "DecanewtonPerCentimetre";
public static string DecanewtonPerMillimetre = "DecanewtonPerMillimetre";
public static string KilonewtonPerMetre = "KilonewtonPerMetre";
public static string KilonewtonPer30Metre = "KilonewtonPer30Metre";
public static string KilonewtonPer10Metre = "KilonewtonPer10Metre";
public static string KilonewtonPerDecimetre = "KilonewtonPerDecimetre";
public static string KilonewtonPerCentimetre = "KilonewtonPerCentimetre";
public static string KilonewtonPerMillimetre = "KilonewtonPerMillimetre";
public static string PoundPerFoot = "PoundPerFoot";
public static string PoundPerInch = "PoundPerInch";
public static string KilopoundPerFoot = "KilopoundPerFoot";
public static string KilopoundPerInch = "KilopoundPerInch";
public static string PoundPer30Foot = "PoundPer30Foot";
public static string PoundPer100Foot = "PoundPer100Foot";
public static string KilopoundPer30Foot = "KilopoundPer30Foot";
public static string KilopoundPer100Foot = "KilopoundPer100Foot";
public static string Newton = "Newton";
public static string Decanewton = "Decanewton";
public static string Kilonewton = "Kilonewton";
public static string Kilodecanewton = "Kilodecanewton";
public static string KilogramForce = "KilogramForce";
public static string PoundForce = "PoundForce";
public static string KilopoundForce = "KilopoundForce";
public static string Hertz = "Hertz";
public static string ReciprocalSecond = "ReciprocalSecond";
public static string Kilohertz = "Kilohertz";
public static string Megahertz = "Megahertz";
public static string Gigahertz = "Gigahertz";
public static string Terahertz = "Terahertz";
public static string Rpm = "Rpm";
public static string Spm = "Spm";
public static string RotationPerSecond = "RotationPerSecond";
public static string StrokePerSecond = "StrokePerSecond";
public static string StrokePerHour = "StrokePerHour";
public static string RotationPerHour = "RotationPerHour";
public static string ShockPerSecond = "ShockPerSecond";
public static string ShockPerMinute = "ShockPerMinute";
public static string ShockPerHour = "ShockPerHour";
public static string HertzPerSecond = "HertzPerSecond";
public static string KiloHertzPerSecond = "KiloHertzPerSecond";
public static string MegaHertzPerSecond = "MegaHertzPerSecond";
public static string GigaHertzPerSecond = "GigaHertzPerSecond";
public static string HertzPerMinute = "HertzPerMinute";
public static string KiloHertzPerMinute = "KiloHertzPerMinute";
public static string MegaHertzPerMinute = "MegaHertzPerMinute";
public static string GigaHertzPerMinute = "GigaHertzPerMinute";
public static string HertzPerHour = "HertzPerHour";
public static string KiloHertzPerHour = "KiloHertzPerHour";
public static string MegaHertzPerHour = "MegaHertzPerHour";
public static string GigaHertzPerHour = "GigaHertzPerHour";
public static string HertzPerDay = "HertzPerDay";
public static string KiloHertzPerDay = "KiloHertzPerDay";
public static string MegaHertzPerDay = "MegaHertzPerDay";
public static string GigaHertzPerDay = "GigaHertzPerDay";
public static string HertzPerYear = "HertzPerYear";
public static string KiloHertzPerYear = "KiloHertzPerYear";
public static string MegaHertzPerYear = "MegaHertzPerYear";
public static string GigaHertzPerYear = "GigaHertzPerYear";
public static string RpmPerSecond = "RpmPerSecond";
public static string SpmPerSecond = "SpmPerSecond";
public static string WattPerSquareMetrePerKelvin = "WattPerSquareMetrePerKelvin";
public static string BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit = "BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit";
public static string DotPerMetre = "DotPerMetre";
public static string DotPerInch = "DotPerInch";
public static string DotPerMillimetre = "DotPerMillimetre";
public static string DotPerMicrometre = "DotPerMicrometre";
public static string MillinewtonPerMetre = "MillinewtonPerMetre";
public static string DynePerCentimetre = "DynePerCentimetre";
public static string PoundPerSecondSquared = "PoundPerSecondSquared";
public static string Metre = "Metre";
public static string Decimetre = "Decimetre";
public static string Centimetre = "Centimetre";
public static string Millimetre = "Millimetre";
public static string Micrometre = "Micrometre";
public static string Nanometre = "Nanometre";
public static string Aangstroem = "Aangstroem";
public static string Picometre = "Picometre";
public static string Decametre = "Decametre";
public static string Hectometre = "Hectometre";
public static string Kilometre = "Kilometre";
public static string AstronomicalUnit = "AstronomicalUnit";
public static string LightYear = "LightYear";
public static string Parsec = "Parsec";
public static string Foot = "Foot";
public static string UsSurveyFoot = "UsSurveyFoot";
public static string Inch = "Inch";
public static string Yard = "Yard";
public static string Fathom = "Fathom";
public static string SurveyorSChain = "SurveyorSChain";
public static string Mile = "Mile";
public static string InternationalNauticalMile = "InternationalNauticalMile";
public static string UkNauticalMile = "UkNauticalMile";
public static string ScandinavianMile = "ScandinavianMile";
public static string InchPer32 = "InchPer32";
public static string Mil = "Mil";
public static string Thou = "Thou";
public static string Hand = "Hand";
public static string Furlong = "Furlong";
public static string Candela = "Candela";
public static string LumenPerSteradian = "LumenPerSteradian";
public static string Millicandela = "Millicandela";
public static string Kilocandela = "Kilocandela";
public static string Hefnerkerze = "Hefnerkerze";
public static string InternationalCandle = "InternationalCandle";
public static string DecimalCandle = "DecimalCandle";
public static string BerlinerLichteinheit = "BerlinerLichteinheit";
public static string DvwgCandle = "DvwgCandle";
public static string Violle = "Violle";
public static string Carcel = "Carcel";
public static string Tesla = "Tesla";
public static string Gauss = "Gauss";
public static string Milligauss = "Milligauss";
public static string Millitesla = "Millitesla";
public static string Microtesla = "Microtesla";
public static string Nanotesla = "Nanotesla";
public static string MaxwellPerSquareCentimetre = "MaxwellPerSquareCentimetre";
public static string WeberPerSquareMetre = "WeberPerSquareMetre";
public static string Weber = "Weber";
public static string Milliweber = "Milliweber";
public static string Microweber = "Microweber";
public static string VoltSecond = "VoltSecond";
public static string UnitPole = "UnitPole";
public static string Megaline = "Megaline";
public static string Kiloline = "Kiloline";
public static string Line = "Line";
public static string Maxwell = "Maxwell";
public static string TeslaSquareMetre = "TeslaSquareMetre";
public static string TeslaSquareCentimetre = "TeslaSquareCentimetre";
public static string GaussSquareCentimetre = "GaussSquareCentimetre";
public static string MagneticFluxQuantum = "MagneticFluxQuantum";
public static string KilogramPerMetre = "KilogramPerMetre";
public static string GramPerMetre = "GramPerMetre";
public static string KilogramPerSecond = "KilogramPerSecond";
public static string KilogramPerMinute = "KilogramPerMinute";
public static string KilogramPerHour = "KilogramPerHour";
public static string KilogramPerYear = "KilogramPerYear";
public static string PoundPerSecond = "PoundPerSecond";
public static string PoundPerMinute = "PoundPerMinute";
public static string PoundPerHour = "PoundPerHour";
public static string PoundPerYear = "PoundPerYear";
public static string Pascal = "Pascal";
public static string Megapascal = "Megapascal";
public static string Gigapascal = "Gigapascal";
public static string Psi = "Psi";
public static string PoundPer100SquareFoot = "PoundPer100SquareFoot";
public static string MegapoundPerSquareInch = "MegapoundPerSquareInch";
public static string Darcy = "Darcy";
public static string Millidarcy = "Millidarcy";
public static string Microdarcy = "Microdarcy";
public static string Nanodarcy = "Nanodarcy";
public static string Radian = "Radian";
public static string Milliradian = "Milliradian";
public static string Degree = "Degree";
public static string Grad = "Grad";
public static string Gon = "Gon";
public static string Circle = "Circle";
public static string Revolution = "Revolution";
public static string Quadrant = "Quadrant";
public static string Sextant = "Sextant";
public static string Octant = "Octant";
public static string ArcMinute = "ArcMinute";
public static string ArcSecond = "ArcSecond";
public static string Watt = "Watt";
public static string Decawatt = "Decawatt";
public static string Hectowatt = "Hectowatt";
public static string Kilowatt = "Kilowatt";
public static string Megawatt = "Megawatt";
public static string Gigawatt = "Gigawatt";
public static string Terawatt = "Terawatt";
public static string Petawatt = "Petawatt";
public static string Exawatt = "Exawatt";
public static string Deciwatt = "Deciwatt";
public static string Centiwatt = "Centiwatt";
public static string Milliwatt = "Milliwatt";
public static string Microwatt = "Microwatt";
public static string Nanowatt = "Nanowatt";
public static string Picowatt = "Picowatt";
public static string Femtowatt = "Femtowatt";
public static string Attowatt = "Attowatt";
public static string PascalPerMetre = "PascalPerMetre";
public static string BarPerMetre = "BarPerMetre";
public static string PsiPerMetre = "PsiPerMetre";
public static string PsiPerFoot = "PsiPerFoot";
public static string PressureLossConstantSi = "PressureLossConstantSi";
public static string PressureLossConstantMetric = "PressureLossConstantMetric";
public static string PressureLossConstantUk = "PressureLossConstantUk";
public static string PressureLossConstantUs = "PressureLossConstantUs";
public static string Kilopascal = "Kilopascal";
public static string Bar = "Bar";
public static string Millibar = "Millibar";
public static string Microbar = "Microbar";
public static string PoundPerSquareInch = "PoundPerSquareInch";
public static string KilopoundPerSquareInch = "KilopoundPerSquareInch";
public static string StandardAtmosphere = "StandardAtmosphere";
public static string PoundPerSquareFoot = "PoundPerSquareFoot";
public static string NewtonPerSquareMetre = "NewtonPerSquareMetre";
public static string NewtonPerSquareCentimetre = "NewtonPerSquareCentimetre";
public static string NewtonPerSquareMillimetre = "NewtonPerSquareMillimetre";
public static string KilonewtonPerSquareMetre = "KilonewtonPerSquareMetre";
public static string Torr = "Torr";
public static string CentimetreMercuryAtZeroDegreeCelsius = "CentimetreMercuryAtZeroDegreeCelsius";
public static string MillimetreMercuryAtZeroDegreeCelsius = "MillimetreMercuryAtZeroDegreeCelsius";
public static string InchMercuryAt32DegreeFahrenheit = "InchMercuryAt32DegreeFahrenheit";
public static string InchMercuryAt60DegreeFahrenheit = "InchMercuryAt60DegreeFahrenheit";
public static string CentimetreWaterAt4DegreeCelsius = "CentimetreWaterAt4DegreeCelsius";
public static string MillimetreWaterAt4DegreeCelsius = "MillimetreWaterAt4DegreeCelsius";
public static string InchWaterAt4DegreeCelsius = "InchWaterAt4DegreeCelsius";
public static string FootWaterAt4DegreeCelsius = "FootWaterAt4DegreeCelsius";
public static string DynePerSquareCentimetre = "DynePerSquareCentimetre";
public static string Proportion = "Proportion";
public static string Percent = "Percent";
public static string PerThousand = "PerThousand";
public static string PartPerMillion = "PartPerMillion";
public static string RadianPerSquareRootSecond = "RadianPerSquareRootSecond";
public static string RadianPerSquareRootMinute = "RadianPerSquareRootMinute";
public static string RadianPerSquareRootHour = "RadianPerSquareRootHour";
public static string RadianPerSquareRootDay = "RadianPerSquareRootDay";
public static string DegreePerSquareRootSecond = "DegreePerSquareRootSecond";
public static string DegreePerSquareRootMinute = "DegreePerSquareRootMinute";
public static string DegreePerSquareRootHour = "DegreePerSquareRootHour";
public static string DegreePerSquareRootDay = "DegreePerSquareRootDay";
public static string Kelvin = "Kelvin";
public static string RelativeCelsius = "RelativeCelsius";
public static string Rankine = "Rankine";
public static string OhmMetre = "OhmMetre";
public static string KiloOhmMetre = "KiloOhmMetre";
public static string MegaOhmMetre = "MegaOhmMetre";
public static string GigaOhmMetre = "GigaOhmMetre";
public static string Steradian = "Steradian";
public static string Spat = "Spat";
public static string DegreeSquared = "DegreeSquared";
public static string JoulePerKilogramKelvin = "JoulePerKilogramKelvin";
public static string JoulePerGramKelvin = "JoulePerGramKelvin";
public static string JoulePerGramDegreeCelsius = "JoulePerGramDegreeCelsius";
public static string CaloriePerGramDegreeCelsius = "CaloriePerGramDegreeCelsius";
public static string BritishThermalUnitPerPoundDegreeFahrenheit = "BritishThermalUnitPerPoundDegreeFahrenheit";
public static string KilocaloriePerGramDegreeCelsius = "KilocaloriePerGramDegreeCelsius";
public static string JoulePerKilogramSquaredKelvin = "JoulePerKilogramSquaredKelvin";
public static string JoulePerGramSquaredKelvin = "JoulePerGramSquaredKelvin";
public static string JoulePerGramDegreeSquaredCelsius = "JoulePerGramDegreeSquaredCelsius";
public static string CaloriePerGramDegreeSquaredCelsius = "CaloriePerGramDegreeSquaredCelsius";
public static string BritishThermalUnitPerPoundSquaredDegreeFahrenheit = "BritishThermalUnitPerPoundSquaredDegreeFahrenheit";
public static string KelvinPerMetre = "KelvinPerMetre";
public static string CelsiusPerMetre = "CelsiusPerMetre";
public static string CelsiusPer10Metre = "CelsiusPer10Metre";
public static string CelsiusPer30Metre = "CelsiusPer30Metre";
public static string CelsiusPer100Metre = "CelsiusPer100Metre";
public static string CelsiusPerFoot = "CelsiusPerFoot";
public static string CelsiusPer30Foot = "CelsiusPer30Foot";
public static string CelsiusPer100Foot = "CelsiusPer100Foot";
public static string FahrenheitPerFoot = "FahrenheitPerFoot";
public static string FahrenheitPer30Foot = "FahrenheitPer30Foot";
public static string FahrenheitPer100Foot = "FahrenheitPer100Foot";
public static string Celsius = "Celsius";
public static string Fahrenheit = "Fahrenheit";
public static string Réaumur = "Réaumur";
public static string WattPerMetreKelvin = "WattPerMetreKelvin";
public static string CaloriePerMetreSecondDegreeCelsius = "CaloriePerMetreSecondDegreeCelsius";
public static string CaloriePerCentimetreSecondDegreeCelsius = "CaloriePerCentimetreSecondDegreeCelsius";
public static string BritishThermalUnitPerHourFootDegreeFahrenheit = "BritishThermalUnitPerHourFootDegreeFahrenheit";
public static string BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit = "BritishThermalUnitInchPerHourSquareFootDegreeFahrenheit";
public static string WattPerMetreKelvinPerKelvin = "WattPerMetreKelvinPerKelvin";
public static string CaloriePerMetreSecondDegreeCelsiusSquared = "CaloriePerMetreSecondDegreeCelsiusSquared";
public static string CaloriePerCentimetreSecondDegreeCelsiusSquared = "CaloriePerCentimetreSecondDegreeCelsiusSquared";
public static string BritishThermalUnitPerHourFootDegreeFahrenheitSquared = "BritishThermalUnitPerHourFootDegreeFahrenheitSquared";
public static string BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared = "BritishThermalUnitInchPerHourSquareFootDegreeFahrenheitSquared";
public static string Second = "Second";
public static string Millisecond = "Millisecond";
public static string Microsecond = "Microsecond";
public static string Shake = "Shake";
public static string Nanosecond = "Nanosecond";
public static string Picosecond = "Picosecond";
public static string Minute = "Minute";
public static string Hour = "Hour";
public static string Day = "Day";
public static string Week = "Week";
public static string Fortnight = "Fortnight";
public static string MonthCommon = "MonthCommon";
public static string MonthSideral = "MonthSideral";
public static string MonthSynodic = "MonthSynodic";
public static string QuarterCommon = "QuarterCommon";
public static string YearCommon = "YearCommon";
public static string YearAverageGregorian = "YearAverageGregorian";
public static string YearJulian = "YearJulian";
public static string YearLeap = "YearLeap";
public static string YearTropical = "YearTropical";
public static string Decade = "Decade";
public static string Century = "Century";
public static string Millenia = "Millenia";
public static string MillionYear = "MillionYear";
public static string NewtonMetrePerMetre = "NewtonMetrePerMetre";
public static string DecanewtonMetrePerMetre = "DecanewtonMetrePerMetre";
public static string KilogramForceMetrePerMetre = "KilogramForceMetrePerMetre";
public static string KilonewtonMetrePerMetre = "KilonewtonMetrePerMetre";
public static string FootPoundPerMetre = "FootPoundPerMetre";
public static string KilofootPoundPerMetre = "KilofootPoundPerMetre";
public static string NewtonDecimetrePerMetre = "NewtonDecimetrePerMetre";
public static string NewtonCentimetrePerMetre = "NewtonCentimetrePerMetre";
public static string NewtonMillimetrePerMetre = "NewtonMillimetrePerMetre";
public static string InchPoundPerMetre = "InchPoundPerMetre";
public static string NewtonMetrePerDecimetre = "NewtonMetrePerDecimetre";
public static string DecanewtonMetrePerDecimetre = "DecanewtonMetrePerDecimetre";
public static string KilogramForceMetrePerDecimetre = "KilogramForceMetrePerDecimetre";
public static string KilonewtonMetrePerDecimetre = "KilonewtonMetrePerDecimetre";
public static string FootPoundPerDecimetre = "FootPoundPerDecimetre";
public static string KilofootPoundPerDecimetre = "KilofootPoundPerDecimetre";
public static string NewtonDecimetrePerDecimetre = "NewtonDecimetrePerDecimetre";
public static string NewtonCentimetrePerDecimetre = "NewtonCentimetrePerDecimetre";
public static string NewtonMillimetrePerDecimetre = "NewtonMillimetrePerDecimetre";
public static string InchPoundPerDecimetre = "InchPoundPerDecimetre";
public static string NewtonMetrePerCentimetre = "NewtonMetrePerCentimetre";
public static string DecanewtonMetrePerCentimetre = "DecanewtonMetrePerCentimetre";
public static string KilogramForceMetrePerCentimetre = "KilogramForceMetrePerCentimetre";
public static string KilonewtonMetrePerCentimetre = "KilonewtonMetrePerCentimetre";
public static string FootPoundPerCentimetre = "FootPoundPerCentimetre";
public static string KilofootPoundPerCentimetre = "KilofootPoundPerCentimetre";
public static string NewtonDecimetrePerCentimetre = "NewtonDecimetrePerCentimetre";
public static string NewtonCentimetrePerCentimetre = "NewtonCentimetrePerCentimetre";
public static string NewtonMillimetrePerCentimetre = "NewtonMillimetrePerCentimetre";
public static string InchPoundPerCentimetre = "InchPoundPerCentimetre";
public static string NewtonMetrePerMillimetre = "NewtonMetrePerMillimetre";
public static string DecanewtonMetrePerMillimetre = "DecanewtonMetrePerMillimetre";
public static string KilogramForceMetrePerMillimetre = "KilogramForceMetrePerMillimetre";
public static string KilonewtonMetrePerMillimetre = "KilonewtonMetrePerMillimetre";
public static string FootPoundPerMillimetre = "FootPoundPerMillimetre";
public static string KilofootPoundPerMillimetre = "KilofootPoundPerMillimetre";
public static string NewtonDecimetrePerMillimetre = "NewtonDecimetrePerMillimetre";
public static string NewtonCentimetrePerMillimetre = "NewtonCentimetrePerMillimetre";
public static string NewtonMillimetrePerMillimetre = "NewtonMillimetrePerMillimetre";
public static string InchPoundPerMillimetre = "InchPoundPerMillimetre";
public static string NewtonMetrePerFoot = "NewtonMetrePerFoot";
public static string DecanewtonMetrePerFoot = "DecanewtonMetrePerFoot";
public static string KilogramForceMetrePerFoot = "KilogramForceMetrePerFoot";
public static string KilonewtonMetrePerFoot = "KilonewtonMetrePerFoot";
public static string FootPoundPerFoot = "FootPoundPerFoot";
public static string KilofootPoundPerFoot = "KilofootPoundPerFoot";
public static string NewtonDecimetrePerFoot = "NewtonDecimetrePerFoot";
public static string NewtonCentimetrePerFoot = "NewtonCentimetrePerFoot";
public static string NewtonMillimetrePerFoot = "NewtonMillimetrePerFoot";
public static string InchPoundPerFoot = "InchPoundPerFoot";
public static string NewtonMetrePerInch = "NewtonMetrePerInch";
public static string DecanewtonMetrePerInch = "DecanewtonMetrePerInch";
public static string KilogramForceMetrePerInch = "KilogramForceMetrePerInch";
public static string KilonewtonMetrePerInch = "KilonewtonMetrePerInch";
public static string FootPoundPerInch = "FootPoundPerInch";
public static string KilofootPoundPerInch = "KilofootPoundPerInch";
public static string NewtonDecimetrePerInch = "NewtonDecimetrePerInch";
public static string NewtonCentimetrePerInch = "NewtonCentimetrePerInch";
public static string NewtonMillimetrePerInch = "NewtonMillimetrePerInch";
public static string InchPoundPerInch = "InchPoundPerInch";
public static string NewtonMetre = "NewtonMetre";
public static string DecanewtonMetre = "DecanewtonMetre";
public static string KilogramForceMetre = "KilogramForceMetre";
public static string KilonewtonMetre = "KilonewtonMetre";
public static string FootPound = "FootPound";
public static string KilofootPound = "KilofootPound";
public static string NewtonDecimetre = "NewtonDecimetre";
public static string NewtonCentimetre = "NewtonCentimetre";
public static string NewtonMillimetre = "NewtonMillimetre";
public static string InchPound = "InchPound";
public static string MetrePerSecond = "MetrePerSecond";
public static string MetrePerMinute = "MetrePerMinute";
public static string CentimetrePerSecond = "CentimetrePerSecond";
public static string MetrePerHour = "MetrePerHour";
public static string MetrePerDay = "MetrePerDay";
public static string FootPerHour = "FootPerHour";
public static string FootPerDay = "FootPerDay";
public static string FootPerMinute = "FootPerMinute";
public static string FootPerSecond = "FootPerSecond";
public static string InchPerSecond = "InchPerSecond";
public static string MilePerHour = "MilePerHour";
public static string KilometrePerHour = "KilometrePerHour";
public static string KilometrePerMinute = "KilometrePerMinute";
public static string KilometrePerSecond = "KilometrePerSecond";
public static string KilometrePerDay = "KilometrePerDay";
public static string MilePerMinute = "MilePerMinute";
public static string MilePerSecond = "MilePerSecond";
public static string MilePerDay = "MilePerDay";
public static string InchPerMinute = "InchPerMinute";
public static string InchPerHour = "InchPerHour";
public static string InchPerDay = "InchPerDay";
public static string CentimetrePerMinute = "CentimetrePerMinute";
public static string CentimetrePerHour = "CentimetrePerHour";
public static string CentimetrePerDay = "CentimetrePerDay";
public static string MillimetrePerSecond = "MillimetrePerSecond";
public static string MillimetrePerMinute = "MillimetrePerMinute";
public static string MillimetrePerHour = "MillimetrePerHour";
public static string MillimetrePerDay = "MillimetrePerDay";
public static string DecimetrePerSecond = "DecimetrePerSecond";
public static string DecimetrePerMinute = "DecimetrePerMinute";
public static string DecimetrePerHour = "DecimetrePerHour";
public static string DecimetrePerDay = "DecimetrePerDay";
public static string FurlongPerFortnight = "FurlongPerFortnight";
public static string CubicMetre = "CubicMetre";
public static string Litre = "Litre";
public static string Decilitre = "Decilitre";
public static string Centilitre = "Centilitre";
public static string Millilitre = "Millilitre";
public static string UsGallon = "UsGallon";
public static string UkGallon = "UkGallon";
public static string Barrel = "Barrel";
public static string MillionCubicMetre = "MillionCubicMetre";
public static string MillionLitre = "MillionLitre";
public static string MillionUkGallon = "MillionUkGallon";
public static string MillionBarrel = "MillionBarrel";
public static string ThousandStandardCubicFoot = "ThousandStandardCubicFoot";
public static string MillionStandardCubicFoot = "MillionStandardCubicFoot";
public static string CubicFoot = "CubicFoot";
public static string CubicInch = "CubicInch";
public static string MillionUsGallon = "MillionUsGallon";
public static string CubicMetrePerSecondSquared = "CubicMetrePerSecondSquared";
public static string LitrePerMinuteSquared = "LitrePerMinuteSquared";
public static string LitrePerMinutePerSecond = "LitrePerMinutePerSecond";
public static string LitrePerSecondSquared = "LitrePerSecondSquared";
public static string UkGallonPerMinuteSquared = "UkGallonPerMinuteSquared";
public static string UkGallonPerMinutePerSecond = "UkGallonPerMinutePerSecond";
public static string UsGallonPerMinuteSquared = "UsGallonPerMinuteSquared";
public static string UsGallonPerMinutePerSecond = "UsGallonPerMinutePerSecond";
public static string CubicMetrePerSecond = "CubicMetrePerSecond";
public static string LitrePerSecond = "LitrePerSecond";
public static string CubicFootPerSecond = "CubicFootPerSecond";
public static string UkGallonPerSecond = "UkGallonPerSecond";
public static string UsGallonPerSecond = "UsGallonPerSecond";
public static string BarrelPerSecond = "BarrelPerSecond";
public static string CubicMetrePerMinute = "CubicMetrePerMinute";
public static string LitrePerMinute = "LitrePerMinute";
public static string CubicFootPerMinute = "CubicFootPerMinute";
public static string UkGallonPerMinute = "UkGallonPerMinute";
public static string UsGallonPerMinute = "UsGallonPerMinute";
public static string BarrelPerMinute = "BarrelPerMinute";
public static string CubicMetrePerHour = "CubicMetrePerHour";
public static string LitrePerHour = "LitrePerHour";
public static string CubicFootPerHour = "CubicFootPerHour";
public static string UkGallonPerHour = "UkGallonPerHour";
public static string UsGallonPerHour = "UsGallonPerHour";
public static string BarrelPerHour = "BarrelPerHour";
public static string CubicMetrePerDay = "CubicMetrePerDay";
public static string MillionCubicMetrePerDay = "MillionCubicMetrePerDay";
public static string UkGallonPerDay = "UkGallonPerDay";
public static string UsGallonPerDay = "UsGallonPerDay";
public static string MillionUkGallonPerDay = "MillionUkGallonPerDay";
public static string MillionUsGallonPerDay = "MillionUsGallonPerDay";
public static string LitrePerDay = "LitrePerDay";
public static string MillionLiterPerDay = "MillionLiterPerDay";
public static string CubicFootPerDay = "CubicFootPerDay";
public static string ThousandStandardCubicFootPerDay = "ThousandStandardCubicFootPerDay";
public static string MillionStandardCubicFootPerDay = "MillionStandardCubicFootPerDay";
public static string BarrelPerDay = "BarrelPerDay";
public static string CubicMetrePerYear = "CubicMetrePerYear";
public static string LitrePerYear = "LitrePerYear";
public static string CubicFootPerYear = "CubicFootPerYear";
public static string UkGallonPerYear = "UkGallonPerYear";
public static string UsGallonPerYear = "UsGallonPerYear";
public static string BarrelPerYear = "BarrelPerYear";
public static string ReciprocalMetre = "ReciprocalMetre";
public static string ReciprocalDecimetre = "ReciprocalDecimetre";
public static string ReciprocalCentimetre = "ReciprocalCentimetre";
public static string ReciprocalMillimetre = "ReciprocalMillimetre";
public static string ReciprocalMicrometre = "ReciprocalMicrometre";
public static string ReciprocalNanometre = "ReciprocalNanometre";
public static string ReciprocalAangstroem = "ReciprocalAangstroem";
public static string ReciprocalPicometre = "ReciprocalPicometre";
public static string ReciprocalDecametre = "ReciprocalDecametre";
public static string ReciprocalHectometre = "ReciprocalHectometre";
public static string ReciprocalKilometre = "ReciprocalKilometre";
public static string ReciprocalAstronomicalUnit = "ReciprocalAstronomicalUnit";
public static string ReciprocalLightYear = "ReciprocalLightYear";
public static string ReciprocalParsec = "ReciprocalParsec";
public static string ReciprocalFoot = "ReciprocalFoot";
public static string ReciprocalUsSurveyFoot = "ReciprocalUsSurveyFoot";
public static string ReciprocalInch = "ReciprocalInch";
public static string ReciprocalYard = "ReciprocalYard";
public static string ReciprocalFathom = "ReciprocalFathom";
public static string ReciprocalSurveyorsChain = "ReciprocalSurveyorsChain";
public static string ReciprocalMile = "ReciprocalMile";
public static string ReciprocalInternationalNauticalMile = "ReciprocalInternationalNauticalMile";
public static string ReciprocalUkNauticalMile = "ReciprocalUkNauticalMile";
public static string ReciprocalScandinavianMile = "ReciprocalScandinavianMile";
public static string ReciprocalInchPer32 = "ReciprocalInchPer32";
public static string ReciprocalMil = "ReciprocalMil";
public static string ReciprocalThou = "ReciprocalThou";
public static string ReciprocalHand = "ReciprocalHand";
public static string ReciprocalFurlong = "ReciprocalFurlong";
public static string Kilogram = "Kilogram";
public static string Hectogram = "Hectogram";
public static string Decagram = "Decagram";
public static string Gram = "Gram";
public static string Centigram = "Centigram";
public static string Milligram = "Milligram";
public static string Microgram = "Microgram";
public static string Nanogram = "Nanogram";
public static string AtomMassUnit = "AtomMassUnit";
public static string TonneMetric = "TonneMetric";
public static string Kilotonne = "Kilotonne";
public static string Megatonne = "Megatonne";
public static string Gigatonne = "Gigatonne";
public static string Pound = "Pound";
public static string Kilopound = "Kilopound";
public static string Ounce = "Ounce";
public static string Stone = "Stone";
public static string TonUk = "TonUk";
public static string TonUs = "TonUs";
public static string SolarMass = "SolarMass";
public static string EarthMass = "EarthMass";
public static string Grain = "Grain";
public static string HundredWeights = "HundredWeights";
public static string Joule = "Joule";
public static string Kilojoule = "Kilojoule";
public static string Megajoule = "Megajoule";
public static string Gigajoule = "Gigajoule";
public static string Calorie = "Calorie";
public static string Kilocalorie = "Kilocalorie";
public static string BritishThermalUnit = "BritishThermalUnit";
public static string KiloBritishThermalUnit = "KiloBritishThermalUnit";
public static string MegaBritishThermalUnit = "MegaBritishThermalUnit";
}
}
