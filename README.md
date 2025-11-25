![DDHub](./docs/img/ddhubLogo.png)

# DDHub Semantic Interoperability
Work Package 1 (DSID): ontology, vocabulary, and examples for DDHub semantic interoperability across drilling data.

## Contents
- `model/` - DDHub ontology in multiple serializations (XML, Turtle, JSON, Manchester, RTF) with generated HTML docs (`model/html/documentation`).
- `examples/` - OWL examples for common signals and circuits (flow-rate, hookload, torque, ECD, hydraulic/mechanical circuits, LWD, HIL demo, manifests).
- `docs/` - narrative docs for the semantic model, use cases, drilling signal descriptions, architecture draft, and vocabulary development notes.
- `src/DWIS-Vocabulary/` - .NET solution `DWIS.Vocabulary.sln` containing vocabulary/schema tooling, instance editors, standard sets, controls, utilities, tests, and local NuGet packages for offline builds.

## Quick start
- Explore the model: open `model/DDHub_xml.owl` (or Turtle/JSON) in your OWL tool of choice; HTML docs live at `model/html/documentation/index-en.html`.
- See example patterns: browse `examples/` for OWL instances of signals and circuits.
- Build vocabulary tools: `dotnet build src/DWIS-Vocabulary/DWIS-Vocabulary.sln` (use `LocalPackages/` if offline).
- Read background: `docs/DDHub_semantic_model.md`, `docs/use_cases/Use_cases.md`, `docs/drilling_signals/home.md`, `docs/architecture/DDHub_architecture.md`.