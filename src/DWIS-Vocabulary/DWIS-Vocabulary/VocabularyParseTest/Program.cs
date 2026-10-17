using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DWIS.Vocabulary.Development;
using DWIS.Vocabulary.Schemas;
using DWIS.Vocabulary.Utils;

namespace Vocabulary.Parse.Test;

internal static class Program
{
    private static void Main(string[] args)
    {
        string root = args.Length == 1 ? Path.GetFullPath(args[0]) : FindRepository();
        string docs = Path.Combine(root, "docs", "vocabulary_development");
        Require(VocabularyParsing.FromFolder(Path.Combine(docs, "definitions"), out var source), "Source parsing");
        var generated = DWISVocabulary.FromJsonFile(Path.Combine(docs, "auto-generated", "json", "DWISVocabulary.json"));
        var resource = DWISVocabulary.FromJsonFile(Path.Combine(root, "src", "DWIS-Vocabulary", "DWIS-Vocabulary", "DWIS.Vocabulary.Standard", "Properties", "DWISVocabulary.json"));
        Require(source.Equals(generated) && source.Equals(resource), "Source/generated/resource agreement");
        Require(source.Nouns.Select(n => n.Name).Distinct().Count() == source.Nouns.Count, "Unique nouns");
        Require(source.Verbs.Select(v => v.Name).Distinct().Count() == source.Verbs.Count, "Unique verbs");
        Require(source.Nouns.All(n => Enum.IsDefined(typeof(Nouns.Enum), n.Name)), "Generated noun enums");
        Require(source.Verbs.All(v => Enum.IsDefined(typeof(Verbs.Enum), v.Name)), "Generated verb enums");
        foreach (string name in new[] { "InstrumentModel", "InstrumentInstance", "MeasurementPrinciple", "UltrasonicPulseEchoMeasurementPrinciple", "ElectromagneticPulseEchoMeasurementPrinciple", "Rig", "ForceSensor", "LoadPinSensor", "DeadLineTensionSensor", "SensorFusionTransformation", "DollyRetraction", "DollyFullyExtended", "DollyFullyRetracted", "RackAndPinionHydraulicDrive", "RackAndPinionElectricDrive", "HoistingCylinder", "HoistingCylinderCapChamber", "HoistingCylinderRodChamber", "InstrumentedSub" })
            Require(source.Nouns.Count(n => n.Name == name) == 1, "Noun " + name);
        foreach (string name in new[] { "IsOfInstrumentModel", "HasManufacturer", "IsSensorOf", "SupportsTelemetry", "UsesMeasurementPrinciple", "IsDescriptionOf" })
            Require(source.Verbs.Count(v => v.Name == name) == 1, "Verb " + name);
        foreach (string name in new[] { "FlowMeasurementPrinciple", "AcousticMeasurementPrinciple", "ElectromagneticMeasurementPrinciple" })
            Require(source.Nouns.Single(n => n.Name == name).ParentNounName == "MeasurementPrinciple", "Principle parent " + name);
        Require(source.Verbs.Single(v => v.Name == "UsesMeasurementPrinciple").RangeNounName == "MeasurementPrinciple", "Principle range");
        Require(Attributes.InstrumentModel_ModelIdentifier == "ModelIdentifier" && Attributes.InstrumentModel_ModelIdentifier_Type == "string", "Model identifier schema");
        Require(Attributes.InstrumentModel_ModelName == "ModelName" && Attributes.InstrumentModel_ModelName_Type == "string", "Model name schema");
        Require(Attributes.InstrumentInstance_SerialNumber == "SerialNumber" && Attributes.InstrumentInstance_SerialNumber_Type == "string", "Serial number schema");
        Require(Attributes.InstrumentInstance_AssetIdentifier == "AssetIdentifier" && Attributes.InstrumentInstance_AssetIdentifier_Type == "string", "Asset identifier schema");
        string text = File.ReadAllText(Path.Combine(docs, "examples-new", "DownholeInstrumentIdentityAndTelemetry.md"));
        var blocks = Regex.Matches(text, @"```dwis[^\r\n]*\r?\n([\s\S]*?)```");
        Require(blocks.Count == 4, "Four semantic example blocks");
        // The legacy Markdown instance reader skips fenced blocks. Parse their bodies explicitly.
        Require(VocabularyParsing.FromMDFileContents(new[] { "example" }, "DownholeInstruments", source, out DWISInstance instance), "Example initialization");
        foreach (Match block in blocks)
            Require(VocabularyParsing.FromLines(block.Groups[1].Value.Split('\n'), source, instance, false), "Example block parsing");
        Require(instance.Sentences.Count(s => s.Verb == "IsOfInstrumentModel") == 6, "Six instrument models");
        Require(instance.Sentences.Count(s => s.Verb == "SupportsTelemetry") == 7, "Seven deployed telemetry capabilities");
        Require(instance.Sentences.Count(s => s.Verb == "UsesMeasurementPrinciple") == 3, "Three imaging principles");
        Require(instance.Sentences.Any(s => s.Subject == "baseStarAnnularPressureWired" && s.Verb == "IsTransmittedBy" && s.Object == "wiredPipePath"), "BaseStar wired path");
        Require(instance.Sentences.Any(s => s.Subject == "baseStarAnnularPressureMudPulse" && s.Verb == "IsTransmittedBy" && s.Object == "baseStarMWDMudPulsePath"), "BaseStar mud-pulse path");
        Console.WriteLine($"PASS: {source.Nouns.Count} nouns, {source.Verbs.Count} verbs, generated JSON/resources/enums/attributes and all six-tool example blocks.");
    }

    private static void Require(bool condition, string check)
    {
        if (!condition) throw new InvalidOperationException("Verification failed: " + check);
    }

    private static string FindRepository()
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory != null; directory = directory.Parent)
            if (Directory.Exists(Path.Combine(directory.FullName, "docs", "vocabulary_development"))) return directory.FullName;
        throw new DirectoryNotFoundException("Pass the vocabulary repository path as the only argument.");
    }
}
