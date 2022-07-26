
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quantities export");
string folder = "C:\\Users\\beda\\source\\repos\\D-WIS\\DDHub-Semantic-Interoperability\\docs\\vocabulary_development\\definitions";

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
Console.ReadLine(); 
