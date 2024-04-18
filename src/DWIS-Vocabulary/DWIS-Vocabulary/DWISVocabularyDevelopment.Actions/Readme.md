# Action in Github to Manage the Vocabulary Definitions

This program is used as an action in github to manage the vocabulary definitions.

## Automatic Generation of Drilling Equipments
The `DrillingEquipment` list of nouns is automatically generated from an `Excel` spreadsheet: `DrillingEquipment.xlsx`.
The `DrillingEquipment` spreadsheet is maintained by the workstream `Contextual Data`.

If some nouns are renamed, it is necessary to adjust the examples that are stored in this repos. This is done by
running the program found in `Test-misc` and called `DWIS.RenameNounsInExamples`.

## Automatic Generation of Quantities
The `Quantities` list of nouns is automatically generated from the `OSDC.UnitConversion.Conversion` nuget maintained 
on the github of the SPE Open Source Drilling Community.

The automatic generation ensures that special characters are transcribed to plain ASCII codes to avoid creating problems
with OPC-UA. OPC-UA is used by the Drilling Data Hub (DDHub) for the exchange of real-time signals.

