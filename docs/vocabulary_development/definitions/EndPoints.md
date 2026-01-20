- Description: Describes external endpoints where drilling data is sourced or delivered, and how signals map to those endpoints.

# NOUNS
## DataEndPoint <!-- NOUN -->
- Display name: DataEndPoint
- Parent class: DWISNoun
- Attributes:
  - EndPointDescription
    - Type: string
    - Description: 
- Specialization:
- Description: A generic external endpoint for reading or writing drilling data.
- Examples:
```dwis dataEndpointExample
DataEndPoint:surfaceLogEndpoint
surfaceLogEndpoint.EndPointDescription = "Surface logging service endpoint"
```
This example declares a generic data endpoint for surface logging.
## WitsMLTimeBasedLogEndPoint <!-- NOUN -->
- Display name: WitsMLTimeBasedLogEndPoint
- Parent class: DataEndPoint
- Attributes:
  - WellUID
    - Type: string
    - Description: 
  - WellName
    - Type: string
    - Description: 
  - WellboreUID
    - Type: string
    - Description: 
  - WellboreName
    - Type: string
    - Description: 
  - LogUID
    - Type: string
    - Description: 
  - LogName
    - Type: string
    - Description: 
  - Mnemonic
    - Type: string
    - Description: 
- Specialization:
- Description: Represents a WITSML time-based log endpoint identifying a specific well, wellbore, log, and mnemonic.
- Examples:
```dwis witsmlEndpoint
WitsMLTimeBasedLogEndPoint:witsmlLog
witsmlLog.WellUID = "well-123"
witsmlLog.WellName = "Well A"
witsmlLog.WellboreUID = "wellbore-1"
witsmlLog.WellboreName = "Well A Main"
witsmlLog.LogUID = "log-789"
witsmlLog.LogName = "SurfaceLog"
witsmlLog.Mnemonic = "SPPA"
```
This example defines a WITSML time-based log endpoint for standpipe pressure.

## EndPointMapping <!-- NOUN -->
- Display name: EndPointMapping
- Parent class: DWISNoun
- Attributes:
  - FixedIndices
    - Type: int[]
    - Description: 
  - ValuesIndices
    - Type: int[]
    - Description: 
  - MeasurementIndex
    - Type: int
    - Description: 
- Specialization:
- Description: Describes how a signal’s fields map to indices within an external endpoint payload.
- Examples:
```dwis endpointMapping
EndPointMapping:standpipeMapping
standpipeMapping.FixedIndices = "[0,1]"
standpipeMapping.ValuesIndices = "[2]"
standpipeMapping.MeasurementIndex = "2"
```
This example maps standpipe pressure values to positions in an endpoint payload.


# VERBS

## HasEndPoint <!-- VERB -->
- Display name: HasEndPoint
- Parent verb: DWISVerb
- Subject class: DrillingSignal
- Object class: DataEndPoint
- Description: Associates a drilling signal with an external endpoint that provides or receives it.
- Examples: 
```dwis endpointAssociation
DrillingSignal:standpipePressureSignal
WitsMLTimeBasedLogEndPoint:witsmlLog
standpipePressureSignal HasEndPoint witsmlLog
```
This example links the standpipe pressure signal to its WITSML endpoint.

