- Description: actual organizations and companies that generate, manage, transmit, standardize, or process drilling and well-construction data.

# NOUNS

## DrillingDataEcosystemOrganization <!-- NOUN -->
- Display name: Drilling Data Ecosystem Organization
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: An organization that generates, owns, processes, transmits, standardizes, analyzes, visualizes, or consumes drilling and well-construction data.
- Examples:
```dwis drillingDataProvider
DynamicDrillingSignal:drillingDataSignal
DrillingDataEcosystemOrganization:provider
drillingDataSignal IsProvidedBy provider
```

## IntegratedOilfieldServiceCompany <!-- NOUN -->
- Display name: Integrated Oilfield Service Company
- Parent class: ServiceCompany
- Attributes:
- Specialization:
- Description: A broad oilfield service company that may provide drilling services, directional drilling, MWD/LWD, real-time operations, drilling optimization, drilling automation, software, and data infrastructure.
- Examples:
```dwis integratedOFS
IntegratedOilfieldServiceCompany:ofsCompany
DrillingDataPoint:drillingData
drillingData IsProvidedBy ofsCompany
```

## DrillingAnalyticsAutomationCompany <!-- NOUN -->
- Display name: Drilling Analytics and Automation Company
- Parent class: DataAnalysisServiceCompany
- Attributes:
- Specialization:
- Description: A company that provides drilling analytics, AI, automation, advisory, dysfunction detection, ROP optimization, risk prediction, or real-time decision-support services.
- Examples:
```dwis drillingAnalytics
DrillingAnalyticsAutomationCompany:analyticsProvider
DrillingControlAdvice:drillingAdvice
drillingAdvice IsProvidedBy analyticsProvider
```

## RealTimeDrillingDataInfrastructureCompany <!-- NOUN -->
- Display name: Real-Time Drilling Data Infrastructure Company
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: A company that provides drilling-data acquisition, aggregation, transmission, WITS/WITSML services, visualization, storage, remote collaboration, or operational data delivery.
- Examples:
```dwis realTimeDataInfrastructure
RealTimeDrillingDataInfrastructureCompany:dataInfrastructureProvider
DynamicDrillingSignal:standpipePressure
standpipePressure IsProvidedBy dataInfrastructureProvider
```

## WellPlanningReportingSoftwareCompany <!-- NOUN -->
- Display name: Well Planning and Reporting Software Company
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: A company that provides well planning, drilling engineering workflows, drilling reports, daily operations reporting, lessons learned, or well lifecycle data-management software.
- Examples:
```dwis planningReporting
WellPlanningReportingSoftwareCompany:planningProvider
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy planningProvider
```

## DownholeMeasurementDynamicsCompany <!-- NOUN -->
- Display name: Downhole Measurement and Dynamics Company
- Parent class: InstrumentationCompany
- Attributes:
- Specialization:
- Description: A company that generates or interprets downhole drilling data such as MWD/LWD, survey, pressure, vibration, drilling dynamics, BHA behavior, stick-slip, torque/drag, and drilling dysfunction measurements.
- Examples:
```dwis downholeMeasurement
DownholeMeasurementDynamicsCompany:downholeProvider
DynamicDrillingSignal:downholePressure
downholePressure IsProvidedBy downholeProvider
```

## RigEquipmentOEM <!-- NOUN -->
- Display name: Rig Equipment OEM
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: An original equipment manufacturer or equipment supplier whose rig equipment, controls, automation, or pipe-handling systems generate or consume drilling operational data.
- Examples:
```dwis rigEquipmentOEM
RigEquipmentOEM:equipmentProvider
DynamicDrillingSignal:topDriveTorque
topDriveTorque IsProvidedBy equipmentProvider
```

## RigControlSystemProvider <!-- NOUN -->
- Display name: Rig Control System Provider
- Parent class: RigEquipmentOEM
- Attributes:
- Specialization:
- Description: A rig equipment or automation provider that supplies control systems, drilling automation, rig sequencing, advisory control interfaces, or equipment-generated drilling data.
- Examples:
```dwis rigControl
RigControlSystemProvider:controlSystemProvider
DWISADCSInterface:adcsInterface
adcsInterface IsProvidedBy controlSystemProvider
```

## MudLoggingCompany <!-- NOUN -->
- Display name: Mud Logging Company
- Parent class: LoggingServiceCompany
- Attributes:
- Specialization:
- Description: A company that provides mud logging, surface logging, gas logging, wellsite geology, and structured wellsite drilling data.
- Examples:
```dwis mudLogging
MudLoggingCompany:mudLogger
StratigraphyDescription:stratigraphy
stratigraphy IsProvidedBy mudLogger
```

## CloudEnergyDataPlatformProvider <!-- NOUN -->
- Display name: Cloud Energy Data Platform Provider
- Parent class: DataProvider
- Attributes:
- Specialization:
- Description: A cloud or industrial data-platform provider that supports energy data lakes, edge/IoT, historians, contextualization, analytics, AI/ML, or operational data infrastructure used with drilling data.
- Examples:
```dwis cloudEnergyPlatform
CloudEnergyDataPlatformProvider:cloudProvider
DrillingDataPoint:storedDrillingData
storedDrillingData IsProvidedTo cloudProvider
```

## EnergyDataStandardsOrganization <!-- NOUN -->
- Display name: Energy Data Standards Organization
- Parent class: DrillingDataEcosystemOrganization
- Attributes:
- Specialization:
- Description: An organization or consortium that defines standards, interoperability specifications, data models, or industry practices relevant to drilling and well data.
- Examples:
```dwis standardsOrganization
EnergyDataStandardsOrganization:standardsBody
DrillingDataPoint:standardizedData
standardizedData IsProvidedTo standardsBody
```

## DrillingIndustryOrganization <!-- NOUN -->
- Display name: Drilling Industry Organization
- Parent class: EnergyDataStandardsOrganization
- Attributes:
- Specialization:
- Description: An industry association, technical community, or standards group focused on drilling contractors, drilling automation, well construction, interoperability, reporting, or operational practices.
- Examples:
```dwis drillingIndustryOrganization
DrillingIndustryOrganization:industryBody
DrillingDataPoint:reportedData
reportedData IsProvidedTo industryBody
```

## SLB <!-- NOUN -->
- Display name: SLB
- Parent class: IntegratedOilfieldServiceCompany
- Attributes:
- Specialization:
- Description: An integrated oilfield service company active in real-time drilling data services, drilling optimization, MWD/LWD, drilling engineering workflows, and digital well-construction platforms such as Delfi.
- Examples:
```dwis slbProvider
SLB:slb
DrillingDataPoint:drillingData
drillingData IsProvidedBy slb
```

## Halliburton <!-- NOUN -->
- Display name: Halliburton
- Parent class: IntegratedOilfieldServiceCompany
- Attributes:
- Specialization:
- Description: An integrated oilfield service company active in drilling data, Landmark/iEnergy, DecisionSpace, LOGIX automation, Sperry Drilling, MWD/LWD, drilling optimization, and real-time operations.
- Examples:
```dwis halliburtonProvider
Halliburton:halliburton
DrillingDataPoint:drillingData
drillingData IsProvidedBy halliburton
```

## BakerHughes <!-- NOUN -->
- Display name: Baker Hughes
- Parent class: IntegratedOilfieldServiceCompany
- Attributes:
- Specialization:
- Description: An integrated oilfield service company active in real-time drilling optimization, well planning, MWD/LWD, drilling engineering software, downhole data, and surface drilling-data workflows.
- Examples:
```dwis bakerHughesProvider
BakerHughes:bakerHughes
DrillingDataPoint:drillingData
drillingData IsProvidedBy bakerHughes
```

## Weatherford <!-- NOUN -->
- Display name: Weatherford
- Parent class: IntegratedOilfieldServiceCompany
- Attributes:
- Specialization:
- Description: An oilfield service company active in drilling analytics, managed pressure drilling data, MWD/LWD, real-time drilling optimization, drilling dynamics, and wellbore placement data.
- Examples:
```dwis weatherfordProvider
Weatherford:weatherford
DrillingDataPoint:drillingData
drillingData IsProvidedBy weatherford
```

## NOV <!-- NOUN -->
- Display name: NOV
- Parent class: IntegratedOilfieldServiceCompany
- Attributes:
- Specialization:
- Description: A drilling equipment, automation, and data company active in NOVOS, Max drilling automation, rig equipment integration, IntelliServ wired drill pipe, and rig-control data workflows.
- Examples:
```dwis novosProvider
NOV:nov
DWISADCSInterface:adcsInterface
adcsInterface IsProvidedBy nov
```

## HMH <!-- NOUN -->
- Display name: HMH
- Parent class: RigControlSystemProvider
- Attributes:
- Specialization:
- Description: A rig equipment, control-system, and drilling automation company active in DEAL, CADS, drillersAssist, DrillView, DrillPerform, digital services, and equipment-generated drilling data.
- Examples:
```dwis hmhProvider
HMH:hmh
DynamicDrillingSignal:equipmentSignal
equipmentSignal IsProvidedBy hmh
```

## Sekal <!-- NOUN -->
- Display name: Sekal
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A drilling automation and advisory company active in DrillScene, DrillTronics, real-time diagnostics, drilling automation, and drilling advisory workflows.
- Examples:
```dwis sekalProvider
Sekal:sekal
DrillingControlAdvice:drillingAdvice
drillingAdvice IsProvidedBy sekal
```

## Exebenus <!-- NOUN -->
- Display name: Exebenus
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A predictive drilling AI company active in stuck-pipe prediction, ROP optimization, vibration and dysfunction detection, and real-time drilling recommendations.
- Examples:
```dwis exebenusProvider
Exebenus:exebenus
DrillingControlAdvice:drillingAdvice
drillingAdvice IsProvidedBy exebenus
```

## Corva <!-- NOUN -->
- Display name: Corva
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A cloud drilling analytics platform company active in real-time drilling applications, drilling optimization, and operational analytics.
- Examples:
```dwis corvaProvider
Corva:corva
DrillingControlAdvice:drillingAdvice
drillingAdvice IsProvidedBy corva
```

## TDEGroup <!-- NOUN -->
- Display name: TDE Group
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A drilling analytics company active in rig-state detection, performance analytics, benchmarking, and automated reporting.
- Examples:
```dwis tdeProvider
TDEGroup:tdeGroup
DrillingDataPoint:performanceData
performanceData IsProvidedBy tdeGroup
```

## PrimeDrillingIDP <!-- NOUN -->
- Display name: Prime Drilling IDP
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A drilling-data analytics and drilling-performance platform provider active in real-time drilling-data analysis and performance workflows.
- Examples:
```dwis idpProvider
PrimeDrillingIDP:idp
DrillingDataPoint:performanceData
performanceData IsProvidedBy idp
```

## Nabors <!-- NOUN -->
- Display name: Nabors
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: A drilling contractor and rig-data platform provider active in RigCLOUD, SmartROS, drilling automation, edge/cloud rig data, and performance analytics.
- Examples:
```dwis naborsProvider
Nabors:nabors
RigDescription:rigDescription
rigDescription IsProvidedBy nabors
```

## HelmerichPayne <!-- NOUN -->
- Display name: Helmerich & Payne
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: A drilling contractor active in FlexRig, rig automation, performance optimization, well planning, and digital drilling workflows.
- Examples:
```dwis hpProvider
HelmerichPayne:helmerichPayne
RigDescription:rigDescription
rigDescription IsProvidedBy helmerichPayne
```

## Drill2Frac <!-- NOUN -->
- Display name: Drill2Frac
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A drilling analytics company active in drilling-data-derived dysfunction detection and completion or fracture-treatment optimization.
- Examples:
```dwis drill2FracProvider
Drill2Frac:drill2Frac
DrillingDataPoint:drillingData
drillingData IsProvidedBy drill2Frac
```

## Rogii <!-- NOUN -->
- Display name: Rogii
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: A geosteering and well-placement software company active in real-time geosteering data workflows.
- Examples:
```dwis rogiiProvider
Rogii:rogii
TrajectoryDescription:trajectoryDescription
trajectoryDescription IsProvidedBy rogii
```

## Petrolink <!-- NOUN -->
- Display name: Petrolink
- Parent class: RealTimeDrillingDataInfrastructureCompany
- Attributes:
- Specialization:
- Description: A real-time drilling-data infrastructure company active in WITSML, PetroVue, rig-to-office data transmission, data aggregation, and remote visualization.
- Examples:
```dwis petrolinkProvider
Petrolink:petrolink
DynamicDrillingSignal:realTimeSignal
realTimeSignal IsProvidedBy petrolink
```

## KongsbergDigital <!-- NOUN -->
- Display name: Kongsberg Digital
- Parent class: RealTimeDrillingDataInfrastructureCompany
- Attributes:
- Specialization:
- Description: A digital technology company active in SiteCom, real-time operations, drilling and well data aggregation, visualization, and remote collaboration workflows.
- Examples:
```dwis kongsbergDigitalProvider
KongsbergDigital:kongsbergDigital
DynamicDrillingSignal:realTimeSignal
realTimeSignal IsProvidedBy kongsbergDigital
```

## Pason <!-- NOUN -->
- Display name: Pason
- Parent class: RealTimeDrillingDataInfrastructureCompany
- Attributes:
- Specialization:
- Description: A rigsite drilling-data acquisition company active in electronic drilling recorders, DataLink, DataHub, DataMart, WITSML delivery, and rigsite operational data.
- Examples:
```dwis pasonProvider
Pason:pason
DynamicDrillingSignal:rigSignal
rigSignal IsProvidedBy pason
```

## IndependentDataServices <!-- NOUN -->
- Display name: Independent Data Services
- Parent class: RealTimeDrillingDataInfrastructureCompany
- Attributes:
- Specialization:
- Description: A drilling-data and reporting company active in DataNet, daily drilling reports, WITSML workflows, automated reporting, and operations data capture.
- Examples:
```dwis idsProvider
IndependentDataServices:ids
RigActionPlan:dailyReport
dailyReport IsProvidedBy ids
```

## Geolog <!-- NOUN -->
- Display name: Geolog
- Parent class: MudLoggingCompany
- Attributes:
- Specialization:
- Description: A mud logging and surface logging company active in GeoWITSML, wellsite data aggregation, geology data, and drilling operational data.
- Examples:
```dwis geologProvider
Geolog:geolog
StratigraphyDescription:stratigraphy
stratigraphy IsProvidedBy geolog
```

## GeoDataLogging <!-- NOUN -->
- Display name: Geo-data Logging
- Parent class: MudLoggingCompany
- Attributes:
- Specialization:
- Description: A surface data acquisition and drilling monitoring company active in rig data acquisition and WITS, WITSML, OPC, and Modbus integration.
- Examples:
```dwis geoDataLoggingProvider
GeoDataLogging:geoDataLogging
DynamicDrillingSignal:surfaceSignal
surfaceSignal IsProvidedBy geoDataLogging
```

## Peloton <!-- NOUN -->
- Display name: Peloton
- Parent class: WellPlanningReportingSoftwareCompany
- Attributes:
- Specialization:
- Description: A well operations data-management software company active in WellView, SiteView, well lifecycle data, drilling reports, and operations reporting.
- Examples:
```dwis pelotonProvider
Peloton:peloton
RigActionPlan:drillingReport
drillingReport IsProvidedBy peloton
```

## QuorumSoftware <!-- NOUN -->
- Display name: Quorum Software
- Parent class: WellPlanningReportingSoftwareCompany
- Attributes:
- Specialization:
- Description: A software company active in upstream operations data, reporting, well operations, planning data management, and production data workflows.
- Examples:
```dwis quorumProvider
QuorumSoftware:quorum
RigActionPlan:operationsReport
operationsReport IsProvidedBy quorum
```

## Cognite <!-- NOUN -->
- Display name: Cognite
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: An industrial data platform company active in data contextualization and integration of drilling, rig, and operational data into broader industrial data platforms.
- Examples:
```dwis cogniteProvider
Cognite:cognite
DrillingDataPoint:contextualizedData
contextualizedData IsProvidedTo cognite
```

## AVEVA <!-- NOUN -->
- Display name: AVEVA
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: An industrial software and operational data infrastructure company active in time-series historian, industrial information management, and operational data systems including OSIsoft PI technology.
- Examples:
```dwis avevaProvider
AVEVA:aveva
DrillingDataPoint:historianData
historianData IsProvidedTo aveva
```

## AspenTech <!-- NOUN -->
- Display name: AspenTech
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: An industrial software company active in industrial analytics and operational data platforms relevant to drilling and upstream operational data.
- Examples:
```dwis aspenTechProvider
AspenTech:aspenTech
DrillingDataPoint:operationsData
operationsData IsProvidedTo aspenTech
```

## Emerson <!-- NOUN -->
- Display name: Emerson
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: An industrial automation company active in control systems, historians, instrumentation, and operational data infrastructure relevant to drilling and rig data.
- Examples:
```dwis emersonProvider
Emerson:emerson
DynamicDrillingSignal:operationsSignal
operationsSignal IsProvidedBy emerson
```

## Honeywell <!-- NOUN -->
- Display name: Honeywell
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: An industrial automation and control company active in control systems, historians, and operational data infrastructure relevant to drilling and rig operations.
- Examples:
```dwis honeywellProvider
Honeywell:honeywell
DynamicDrillingSignal:operationsSignal
operationsSignal IsProvidedBy honeywell
```

## Siemens <!-- NOUN -->
- Display name: Siemens
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: An industrial automation and digital infrastructure company active in controls, edge systems, industrial data infrastructure, and automation relevant to rig operations.
- Examples:
```dwis siemensProvider
Siemens:siemens
DynamicDrillingSignal:operationsSignal
operationsSignal IsProvidedBy siemens
```

## ProWellPlan <!-- NOUN -->
- Display name: Pro Well Plan
- Parent class: WellPlanningReportingSoftwareCompany
- Attributes:
- Specialization:
- Description: A well planning and drilling/completions operations software company that structures spreadsheet and fragmented well data into data-driven workflows and automation.
- Examples:
```dwis proWellPlanProvider
ProWellPlan:proWellPlan
RigActionPlan:wellPlan
wellPlan IsProvidedBy proWellPlan
```

## WellID <!-- NOUN -->
- Display name: Well ID
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A downhole measurement company active in high-frequency downhole pressure and drilling-dynamics measurements, drilling intelligence, borehole stability, dysfunction detection, and bit/drillstring insight.
- Examples:
```dwis wellIDProvider
WellID:wellID
DynamicDrillingSignal:downholeDynamics
downholeDynamics IsProvidedBy wellID
```

## Tomax <!-- NOUN -->
- Display name: Tomax
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A drilling dynamics and downhole regulation company active in anti stick-slip technology, bit loading stabilization, and stick-slip mitigation.
- Examples:
```dwis tomaxProvider
Tomax:tomax
DrillingControlAdvice:stickSlipAdvice
stickSlipAdvice IsProvidedBy tomax
```

## APSTechnology <!-- NOUN -->
- Display name: APS Technology
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A downhole technology company active in MWD/LWD technology, drilling dynamics, and downhole data.
- Examples:
```dwis apsProvider
APSTechnology:apsTechnology
DynamicDrillingSignal:downholeSignal
downholeSignal IsProvidedBy apsTechnology
```

## ScientificDrilling <!-- NOUN -->
- Display name: Scientific Drilling
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A directional drilling and measurement company active in MWD, survey, wellbore placement, and directional drilling data.
- Examples:
```dwis scientificDrillingProvider
ScientificDrilling:scientificDrilling
TrajectoryDescription:surveyData
surveyData IsProvidedBy scientificDrilling
```

## Gyrodata <!-- NOUN -->
- Display name: Gyrodata
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A gyro survey and wellbore positioning company active in survey data and wellbore placement data.
- Examples:
```dwis gyrodataProvider
Gyrodata:gyrodata
TrajectoryDescription:surveyData
surveyData IsProvidedBy gyrodata
```

## PhoenixTechnologyServices <!-- NOUN -->
- Display name: Phoenix Technology Services
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A directional drilling and MWD company active in drilling performance data and wellbore placement data.
- Examples:
```dwis phoenixProvider
PhoenixTechnologyServices:phoenixTechnologyServices
TrajectoryDescription:surveyData
surveyData IsProvidedBy phoenixTechnologyServices
```

## CathedralEnergyServices <!-- NOUN -->
- Display name: Cathedral Energy Services
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A directional drilling and MWD company active in drilling optimization data and wellbore placement workflows.
- Examples:
```dwis cathedralProvider
CathedralEnergyServices:cathedralEnergyServices
TrajectoryDescription:surveyData
surveyData IsProvidedBy cathedralEnergyServices
```

## EnteqTechnologies <!-- NOUN -->
- Display name: Enteq Technologies
- Parent class: DownholeMeasurementDynamicsCompany
- Attributes:
- Specialization:
- Description: A downhole technology company active in MWD/LWD technology and downhole drilling data.
- Examples:
```dwis enteqProvider
EnteqTechnologies:enteq
DynamicDrillingSignal:downholeSignal
downholeSignal IsProvidedBy enteq
```

## Canrig <!-- NOUN -->
- Display name: Canrig
- Parent class: RigControlSystemProvider
- Attributes:
- Specialization:
- Description: A rig equipment and automation company associated with Nabors, active in top drives, rig equipment, automation, and control-system data.
- Examples:
```dwis canrigProvider
Canrig:canrig
DynamicDrillingSignal:topDriveSignal
topDriveSignal IsProvidedBy canrig
```

## Huisman <!-- NOUN -->
- Display name: Huisman
- Parent class: RigEquipmentOEM
- Attributes:
- Specialization:
- Description: A rig equipment and automated drilling systems provider active in equipment data and rig automation.
- Examples:
```dwis huismanProvider
Huisman:huisman
DynamicDrillingSignal:equipmentSignal
equipmentSignal IsProvidedBy huisman
```

## Drillmec <!-- NOUN -->
- Display name: Drillmec
- Parent class: RigEquipmentOEM
- Attributes:
- Specialization:
- Description: A rig equipment and drilling automation provider active in equipment data and drilling control workflows.
- Examples:
```dwis drillmecProvider
Drillmec:drillmec
DynamicDrillingSignal:equipmentSignal
equipmentSignal IsProvidedBy drillmec
```

## SLBCameron <!-- NOUN -->
- Display name: SLB Cameron
- Parent class: RigEquipmentOEM
- Attributes:
- Specialization:
- Description: A pressure control and drilling equipment business associated with SLB, active in equipment data and pressure-control workflows.
- Examples:
```dwis slbCameronProvider
SLBCameron:slbCameron
DynamicDrillingSignal:equipmentSignal
equipmentSignal IsProvidedBy slbCameron
```

## AkerSolutions <!-- NOUN -->
- Display name: Aker Solutions
- Parent class: RigEquipmentOEM
- Attributes:
- Specialization:
- Description: An engineering and equipment company relevant to drilling equipment and control-system lineage, including MHWirth legacy technologies now associated with HMH.
- Examples:
```dwis akerSolutionsProvider
AkerSolutions:akerSolutions
DynamicDrillingSignal:equipmentSignal
equipmentSignal IsProvidedBy akerSolutions
```

## Drillform <!-- NOUN -->
- Display name: Drillform
- Parent class: RigEquipmentOEM
- Attributes:
- Specialization:
- Description: A provider of automated drilling tools and pipe-handling equipment, relevant to rig automation and equipment-generated data.
- Examples:
```dwis drillformProvider
Drillform:drillform
DynamicDrillingSignal:equipmentSignal
equipmentSignal IsProvidedBy drillform
```

## PattersonUTI <!-- NOUN -->
- Display name: Patterson-UTI
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: A drilling contractor active in rig operations, directional drilling, and drilling performance data.
- Examples:
```dwis pattersonUTIProvider
PattersonUTI:pattersonUTI
RigDescription:rigDescription
rigDescription IsProvidedBy pattersonUTI
```

## Transocean <!-- NOUN -->
- Display name: Transocean
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor active in offshore drilling data, rig automation, and performance monitoring.
- Examples:
```dwis transoceanProvider
Transocean:transocean
RigDescription:rigDescription
rigDescription IsProvidedBy transocean
```

## Seadrill <!-- NOUN -->
- Display name: Seadrill
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor active in offshore rig data, digital operations, and performance monitoring.
- Examples:
```dwis seadrillProvider
Seadrill:seadrill
RigDescription:rigDescription
rigDescription IsProvidedBy seadrill
```

## OdfjellDrilling <!-- NOUN -->
- Display name: Odfjell Drilling
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor active in offshore drilling, digitalized operations, and performance monitoring.
- Examples:
```dwis odfjellProvider
OdfjellDrilling:odfjellDrilling
RigDescription:rigDescription
rigDescription IsProvidedBy odfjellDrilling
```

## Valaris <!-- NOUN -->
- Display name: Valaris
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor active in offshore rig data and performance systems.
- Examples:
```dwis valarisProvider
Valaris:valaris
RigDescription:rigDescription
rigDescription IsProvidedBy valaris
```

## Noble <!-- NOUN -->
- Display name: Noble
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor active in rig data, automation, performance systems, and offshore drilling workflows.
- Examples:
```dwis nobleProvider
Noble:noble
RigDescription:rigDescription
rigDescription IsProvidedBy noble
```

## KCADeutag <!-- NOUN -->
- Display name: KCA Deutag
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: A land and offshore drilling contractor active in digital rig performance and monitoring.
- Examples:
```dwis kcaDeutagProvider
KCADeutag:kcaDeutag
RigDescription:rigDescription
rigDescription IsProvidedBy kcaDeutag
```

## Saipem <!-- NOUN -->
- Display name: Saipem
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor and engineering company active in offshore drilling data and digital operations.
- Examples:
```dwis saipemProvider
Saipem:saipem
RigDescription:rigDescription
rigDescription IsProvidedBy saipem
```

## COSL <!-- NOUN -->
- Display name: COSL
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: An offshore drilling contractor active in offshore rig data and operational data workflows.
- Examples:
```dwis coslProvider
COSL:cosl
RigDescription:rigDescription
rigDescription IsProvidedBy cosl
```

## MaerskDrilling <!-- NOUN -->
- Display name: Maersk Drilling
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: A legacy offshore drilling contractor organization relevant to offshore rig digitalization and performance data, now associated with Noble through merger history.
- Examples:
```dwis maerskDrillingProvider
MaerskDrilling:maerskDrilling
RigDescription:rigDescription
rigDescription IsProvidedBy maerskDrilling
```

## Exlog <!-- NOUN -->
- Display name: Exlog
- Parent class: MudLoggingCompany
- Attributes:
- Specialization:
- Description: A mud logging and wellsite geology company active in wellsite drilling data, gas logging, lithology, and drilling parameters.
- Examples:
```dwis exlogProvider
Exlog:exlog
StratigraphyDescription:stratigraphy
stratigraphy IsProvidedBy exlog
```

## NationalRegionalMudLoggingCompany <!-- NOUN -->
- Display name: National or Regional Mud Logging Company
- Parent class: MudLoggingCompany
- Attributes:
- Specialization:
- Description: A local or regional mud logging company that captures wellsite data, gas logs, lithology, and drilling parameters.
- Examples:
```dwis regionalMudLoggingProvider
NationalRegionalMudLoggingCompany:regionalMudLogger
StratigraphyDescription:stratigraphy
stratigraphy IsProvidedBy regionalMudLogger
```

## Equinor <!-- NOUN -->
- Display name: Equinor
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in automated drilling, real-time operations, drilling data, and the Norwegian Continental Shelf digital drilling ecosystem.
- Examples:
```dwis equinorProvider
Equinor:equinor
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy equinor
```

## AkerBP <!-- NOUN -->
- Display name: Aker BP
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in digitalized drilling operations, automation, drilling data, and vendor-integrated workflows.
- Examples:
```dwis akerBPProvider
AkerBP:akerBP
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy akerBP
```

## TotalEnergies <!-- NOUN -->
- Display name: TotalEnergies
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in real-time monitoring, drilling assistance, SmartRoom-style operations, and drilling data workflows.
- Examples:
```dwis totalEnergiesProvider
TotalEnergies:totalEnergies
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy totalEnergies
```

## BP <!-- NOUN -->
- Display name: BP
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in real-time drilling decision support, digital wells, AI, and operational analytics.
- Examples:
```dwis bpProvider
BP:bp
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy bp
```

## Shell <!-- NOUN -->
- Display name: Shell
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in digital wells, remote operations, drilling data integration, and operational analytics.
- Examples:
```dwis shellProvider
Shell:shell
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy shell
```

## ExxonMobil <!-- NOUN -->
- Display name: ExxonMobil
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in automated well placement, closed-loop drilling, real-time optimization, and digital drilling workflows.
- Examples:
```dwis exxonMobilProvider
ExxonMobil:exxonMobil
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy exxonMobil
```

## Chevron <!-- NOUN -->
- Display name: Chevron
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in edge analytics, digital drilling, remote operations, and AI workflows.
- Examples:
```dwis chevronProvider
Chevron:chevron
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy chevron
```

## ADNOC <!-- NOUN -->
- Display name: ADNOC
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in AI-based ROP optimization, drilling automation, digital drilling programs, and operator-side drilling data workflows.
- Examples:
```dwis adnocProvider
ADNOC:adnoc
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy adnoc
```

## ADNOCDrilling <!-- NOUN -->
- Display name: ADNOC Drilling
- Parent class: DrillingContractor
- Attributes:
- Specialization:
- Description: A drilling contractor associated with ADNOC, active in drilling operations, automation, rig data, and digital drilling workflows.
- Examples:
```dwis adnocDrillingProvider
ADNOCDrilling:adnocDrilling
RigDescription:rigDescription
rigDescription IsProvidedBy adnocDrilling
```

## AIQ <!-- NOUN -->
- Display name: AIQ
- Parent class: DrillingAnalyticsAutomationCompany
- Attributes:
- Specialization:
- Description: An AI and analytics company associated with ADNOC digital workflows, relevant to AI-based drilling optimization and digital oilfield data.
- Examples:
```dwis aiqProvider
AIQ:aiq
DrillingControlAdvice:drillingAdvice
drillingAdvice IsProvidedBy aiq
```

## SaudiAramco <!-- NOUN -->
- Display name: Saudi Aramco
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in drilling automation, real-time operations, AI, and digital oilfield programs.
- Examples:
```dwis saudiAramcoProvider
SaudiAramco:saudiAramco
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy saudiAramco
```

## Petrobras <!-- NOUN -->
- Display name: Petrobras
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in offshore drilling data, pre-salt operations, digital drilling, and real-time support.
- Examples:
```dwis petrobrasProvider
Petrobras:petrobras
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy petrobras
```

## ConocoPhillips <!-- NOUN -->
- Display name: ConocoPhillips
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in unconventional drilling optimization and real-time operations.
- Examples:
```dwis conocophillipsProvider
ConocoPhillips:conocoPhillips
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy conocoPhillips
```

## Eni <!-- NOUN -->
- Display name: Eni
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in digital upstream, drilling optimization, and operational analytics.
- Examples:
```dwis eniProvider
Eni:eni
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy eni
```

## Repsol <!-- NOUN -->
- Display name: Repsol
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in digital upstream and drilling or well analytics.
- Examples:
```dwis repsolProvider
Repsol:repsol
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy repsol
```

## OMV <!-- NOUN -->
- Display name: OMV
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in digital well operations and real-time drilling workflows.
- Examples:
```dwis omvProvider
OMV:omv
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy omv
```

## Petronas <!-- NOUN -->
- Display name: Petronas
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in real-time operations, drilling analytics, and digital oilfield workflows.
- Examples:
```dwis petronasProvider
Petronas:petronas
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy petronas
```

## QatarEnergy <!-- NOUN -->
- Display name: QatarEnergy
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in large-scale drilling operations and vendor-integrated data workflows.
- Examples:
```dwis qatarEnergyProvider
QatarEnergy:qatarEnergy
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy qatarEnergy
```

## WoodsideEnergy <!-- NOUN -->
- Display name: Woodside Energy
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in offshore digital drilling, remote operations, and operational data platforms.
- Examples:
```dwis woodsideProvider
WoodsideEnergy:woodsideEnergy
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy woodsideEnergy
```

## HarbourEnergy <!-- NOUN -->
- Display name: Harbour Energy
- Parent class: OperatingCompany
- Attributes:
- Specialization:
- Description: An operating company active in operator-side drilling and well data workflows and performance workflows.
- Examples:
```dwis harbourEnergyProvider
HarbourEnergy:harbourEnergy
RigActionPlan:rigActionPlan
rigActionPlan IsProvidedBy harbourEnergy
```

## Energistics <!-- NOUN -->
- Display name: Energistics
- Parent class: EnergyDataStandardsOrganization
- Attributes:
- Specialization:
- Description: An energy data standards organization associated with WITSML, PRODML, and RESQML standards.
- Examples:
```dwis energisticsProvider
Energistics:energistics
DrillingDataPoint:witsmlData
witsmlData IsProvidedTo energistics
```

## OSDUForum <!-- NOUN -->
- Display name: OSDU Forum
- Parent class: EnergyDataStandardsOrganization
- Attributes:
- Specialization:
- Description: An Open Group forum defining subsurface and energy data platform standards relevant to drilling and well data reuse.
- Examples:
```dwis osduProvider
OSDUForum:osduForum
DrillingDataPoint:energyData
energyData IsProvidedTo osduForum
```

## OpenGroup <!-- NOUN -->
- Display name: Open Group
- Parent class: EnergyDataStandardsOrganization
- Attributes:
- Specialization:
- Description: A standards organization associated with open technology standards and the OSDU Forum for energy data platforms.
- Examples:
```dwis openGroupProvider
OpenGroup:openGroup
DrillingDataPoint:energyData
energyData IsProvidedTo openGroup
```

## MicrosoftAzure <!-- NOUN -->
- Display name: Microsoft Azure
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: A cloud platform provider relevant to energy data workflows, Microsoft Energy Data Services, data lakes, edge/IoT, analytics, and AI/ML.
- Examples:
```dwis azureProvider
MicrosoftAzure:azure
DrillingDataPoint:cloudData
cloudData IsProvidedTo azure
```

## AWS <!-- NOUN -->
- Display name: AWS
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: A cloud platform provider relevant to energy data lakes, edge/IoT, cloud analytics, AI/ML, and drilling data infrastructure.
- Examples:
```dwis awsProvider
AWS:aws
DrillingDataPoint:cloudData
cloudData IsProvidedTo aws
```

## GoogleCloud <!-- NOUN -->
- Display name: Google Cloud
- Parent class: CloudEnergyDataPlatformProvider
- Attributes:
- Specialization:
- Description: A cloud platform provider relevant to cloud analytics, AI/ML, data platforms, and energy data workflows.
- Examples:
```dwis googleCloudProvider
GoogleCloud:googleCloud
DrillingDataPoint:cloudData
cloudData IsProvidedTo googleCloud
```

## OPCFoundation <!-- NOUN -->
- Display name: OPC Foundation
- Parent class: EnergyDataStandardsOrganization
- Attributes:
- Specialization:
- Description: A standards organization responsible for OPC UA industrial interoperability, relevant for rig equipment, automation, and operational drilling data.
- Examples:
```dwis opcFoundationProvider
OPCFoundation:opcFoundation
DrillingDataPoint:opcUAData
opcUAData IsProvidedTo opcFoundation
```

## DWIS <!-- NOUN -->
- Display name: D-WIS
- Parent class: DrillingIndustryOrganization
- Attributes:
- Specialization:
- Description: A drilling and wells interoperability initiative focused on semantic data models and digital interoperability for drilling and well construction.
- Examples:
```dwis dwisOrganization
DWIS:dwisOrganization
DrillingDataPoint:semanticData
semanticData IsProvidedTo dwisOrganization
```

## IADC <!-- NOUN -->
- Display name: IADC
- Parent class: DrillingIndustryOrganization
- Attributes:
- Specialization:
- Description: A drilling contractor industry organization relevant to drilling contractor standards, reporting, and operational frameworks.
- Examples:
```dwis iadcProvider
IADC:iadc
RigDescription:rigReport
rigReport IsProvidedTo iadc
```

## SPEDSATS <!-- NOUN -->
- Display name: SPE DSATS
- Parent class: DrillingIndustryOrganization
- Attributes:
- Specialization:
- Description: A SPE drilling systems advancement technical community relevant to drilling automation, data, controls, and interoperability discussions.
- Examples:
```dwis speDsatsProvider
SPEDSATS:speDsats
DrillingDataPoint:automationData
automationData IsProvidedTo speDsats
```
