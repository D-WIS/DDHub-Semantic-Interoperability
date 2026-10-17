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


## Regeneration and automated checks

See the root README for local path configuration and the explicit
`VocabularyParseTest` verification command. The generator uses invariant culture,
returns a nonzero exit code on failure, and does not wait for keyboard input when
standard input is redirected. In GitHub Actions the generator does not pack or
increment package versions internally; the existing Build and pack step owns that.

## NuGet Trusted Publishing

The workflow authenticates with `NuGet/login@v1`, using `${{ secrets.NUGET_USER }}` and
job permission `id-token: write`. The push step consumes the short-lived login output
through an environment variable. The previous `NUGET_SECRET_API` secret is no longer
referenced. The NuGet.org trust policy must match the repository, workflow filename
and any configured environment. Actual token exchange is verified only on GitHub.
