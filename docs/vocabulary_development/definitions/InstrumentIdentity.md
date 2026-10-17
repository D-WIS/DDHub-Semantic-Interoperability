- Description: Product-model identity, physical instrument instances and manufacturer relationships. Equipment taxonomy remains in DrillingEquipment; sensor ownership is in DataFlow.

# NOUNS
## InstrumentModel <!-- NOUN -->
- Display name: InstrumentModel
- Parent class: DWISNoun
- Attributes:
  - ModelIdentifier
    - Type: string
    - Description: Stable manufacturer-qualified product/model identifier, governed by the model catalog.
  - ModelName
    - Type: string
    - Description: Human-readable product/model name.
- Specialization:
- Description: A manufacturer-defined instrument product or model, independent of individual physical units. Model variants with materially different specifications use distinct model nodes. Model identifiers are catalog data, not vocabulary class names.
- Examples:
```dwis InstrumentModelExample
InstrumentModel:baseStarModel
baseStarModel.ModelIdentifier = "Halliburton/BaseStar"
baseStarModel.ModelName = "BaseStar"
```

## InstrumentInstance <!-- NOUN -->
- Display name: InstrumentInstance
- Parent class: Equipment
- Attributes:
  - SerialNumber
    - Type: string
    - Description: Optional manufacturer-assigned serial number of this physical unit.
  - AssetIdentifier
    - Type: string
    - Description: Optional externally managed asset identifier; its issuing authority is supplied by the deployment catalog.
- Specialization:
- Description: An identifiable physical instrument assembly. Its graph URI is the primary identity; optional serial numbers and asset identifiers are not globally unique by themselves. An instance may also be classified using an appropriate existing equipment class, such as InstrumentedSub.
- Examples:
```dwis InstrumentInstanceExample
InstrumentInstance:baseStarUnit
baseStarUnit BelongsToClass InstrumentedSub
InstrumentModel:baseStarModel
baseStarUnit IsOfInstrumentModel baseStarModel
```

# VERBS
## IsOfInstrumentModel <!-- VERB -->
- Display name: IsOfInstrumentModel
- Parent verb: DWISVerb
- Subject class: InstrumentInstance
- Object class: InstrumentModel
- Description: Associates a physical instrument with its manufacturer-defined model. Assign one model at the chosen assembly granularity; replace an assignment explicitly when correcting catalog data.
- Examples:
```dwis IsOfInstrumentModelExample
InstrumentInstance:baseStarUnit
InstrumentModel:baseStarModel
baseStarUnit IsOfInstrumentModel baseStarModel
```

## HasManufacturer <!-- VERB -->
- Display name: HasManufacturer
- Parent verb: DWISVerb
- Subject class: InstrumentModel
- Object class: DrillingDataEcosystemOrganization
- Description: Identifies the manufacturer of an instrument model. This is distinct from IsProvidedBy, which identifies the provider of data; a data aggregator need not be the manufacturer.
- Examples:
```dwis HasManufacturerExample
InstrumentModel:baseStarModel
Halliburton:halliburton
halliburton BelongsToClass DrillingDataEcosystemOrganization
baseStarModel HasManufacturer halliburton
```
