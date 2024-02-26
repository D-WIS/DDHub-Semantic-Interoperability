// See https://aka.ms/new-console-template for more information
using DWIS.Vocabulary.Development.Actions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

Console.WriteLine("Hello, World!");
var builder = Host.CreateDefaultBuilder();

builder.ConfigureLogging(fs => fs.AddConsole());

var  l = builder.Build().Services.GetService<ILogger<VocabularyActioner>>();

string rootFolder = @"C:\git\DDHub-Semantic-Interoperability\";

ActionsConfig actionsConfig = new ActionsConfig();
actionsConfig.SourceFolder =rootFolder + @"docs\vocabulary_development\definitions";
actionsConfig.DestinationFolder = rootFolder + "docs\\vocabulary_development\\auto-generated";
actionsConfig.PackageOutputFolder = @"C:\Temp";
actionsConfig.SchemaFolder = rootFolder + "src\\DWIS-Vocabulary\\DWIS-Vocabulary\\DWIS.Vocabulary.Schemas";
actionsConfig.ExamplesSourceFolder = rootFolder + "docs\\vocabulary_development\\examples";

VocabularyActioner actioner = new VocabularyActioner(actionsConfig, l);
actioner.PerformActions();

var voc = DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary;

var uq = DWIS.Vocabulary.Standard.StandardSetProvider.UnitsAndQuantities;
DWIS.Vocabulary.Utils.SchemaWriter.WriteUnitsAndQuantitiesSchema(voc, uq, @"C:/temp/units.cs", @"C:/temp/quantities.cs");

//DWIS.Vocabulary.Schemas.UQ.Units.bar


Console.ReadLine();