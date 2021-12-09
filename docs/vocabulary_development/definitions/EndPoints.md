- Description: this is the part associated to the description of external end-points. 

# NOUNS
## DataEndPoint <!-- NOUN -->
- Display name: DataEndPoint
- Parent class: DWISNoun
- Attributes:
  - EndPointDescription
    - Type: string
    - Description: 
- Specialization:
- Description: 
- Examples:
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
- Description: 
- Examples:

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
- Description: 
- Examples:


# VERBS

## HasEndPoint <!-- VERB -->
- Display name: HasEndPoint
- Parent verb: DWISVerb
- Subject class: DrillingSignal
- Object class: DataEndPoint
- Description: 
- Examples: 

