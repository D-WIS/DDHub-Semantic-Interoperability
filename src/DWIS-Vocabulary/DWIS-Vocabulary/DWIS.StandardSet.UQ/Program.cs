
// See https://aka.ms/new-console-template for more information

var ontology = DWIS.Vocabulary.Standard.OntologyProvider.DWISOntology;// DWIS.Vocabulary.OWL.OntologyGeneration.GetOntology(vocabulary);
DWISVocabulary vocabulary = DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary;
string uqFolder = @"C:\temp\uq";

string mdFileName = uqFolder + System.IO.Path.DirectorySeparatorChar + "uq.md";

MDWriting.UnitsAndQuantitiesToMDFile(mdFileName);

VocabularyParsing.FromMDFile(mdFileName, vocabulary, out var uqInstance);

var uqOntology = DWIS.Vocabulary.OWL.OntologyGeneration.AddInstance(ontology, vocabulary, uqInstance);

string ontologyFileName = uqFolder + System.IO.Path.DirectorySeparatorChar + "uq";

DWIS.Vocabulary.OWL.OntologyGeneration.WriteOntology(uqOntology, ontologyFileName, true);

Console.ReadLine();


Console.WriteLine("Quantities export");
string folder = "C:\\Users\\beda\\source\\repos\\D-WIS\\DDHub-Semantic-Interoperability\\docs\\vocabulary_development\\definitions";



DWISInstance uaq = DWIS.Vocabulary.Standard.StandardSetProvider.GetUnitsAndQuantities();


if (vocabulary!=null)
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

    ontology = DWIS.Vocabulary.OWL.OntologyGeneration.AddInstance(ontology, vocabulary, instance);

    DWIS.Vocabulary.OWL.OntologyGeneration.WriteOntology(ontology, @"C://temp/uq");


    DWIS.Vocabulary.Utils.MDWriting.ToMDFile(instance, @"C:/temp/uq.md", vocabulary, useLinks:false, addGraph:false);
    string allText = System.IO.File.ReadAllText(@"C:/temp/uq.md").Replace("- ", "");
    System.IO.File.WriteAllText(@"C:/temp/uq2.md", allText);

    DWIS.Vocabulary.Development.DWISInstance.ToJsonFile(instance, @"C:/temp/UnitsAndQuantities.json");



    Console.WriteLine("Exported instance");
}
Console.ReadLine(); 
