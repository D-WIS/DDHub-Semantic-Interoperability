﻿
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quantities export");
string folder = "C:\\Users\\beda\\source\\repos\\D-WIS\\DDHub-Semantic-Interoperability\\docs\\vocabulary_development\\definitions";
if (VocabularyParsing.FromFolder(folder, out DWISVocabulary vocabulary))
{
    var instance = DWIS.StandardSet.UQ.QuantitiesExport.Export(folder);
    //DWIS.Vocabulary.Utils.MDWriting.ToMDFile(instance, )
    foreach (var individual in instance.Population)
    {
        Console.WriteLine($"{individual.Name} : {individual.TypeName}");
        if (individual.Attributes != null)
        {
            foreach (var att in individual.Attributes)
            {
                Console.WriteLine($"\t{att.AttributeName} = {att.AttributeValue}");
            }
        }
    }
    DWIS.Vocabulary.Utils.MDWriting.ToMDFile(instance, @"C:/temp/uq.md", vocabulary, useLinks:false, addGraph:false);
    string allText = System.IO.File.ReadAllText(@"C:/temp/uq.md").Replace("- ", "");
    System.IO.File.WriteAllText(@"C:/temp/uq2.md", allText);
    Console.WriteLine("Exported instance");
}
Console.ReadLine(); 
