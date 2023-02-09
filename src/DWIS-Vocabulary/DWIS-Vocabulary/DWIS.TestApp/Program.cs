// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var voc = DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary;

var uq = DWIS.Vocabulary.Standard.StandardSetProvider.UnitsAndQuantities;
DWIS.Vocabulary.Utils.SchemaWriter.WriteUnitsAndQuantitiesSchema(voc, uq, @"C:/temp/units.cs", @"C:/temp/quantities.cs");

Console.ReadLine();