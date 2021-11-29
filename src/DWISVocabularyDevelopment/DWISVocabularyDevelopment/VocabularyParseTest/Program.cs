using System;
using DWISVocabularyDevelopment;
using VocabularyUtils;
namespace VocabularyParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = 
            //    @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\DataFlow.md";


            string folderName = @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\";


            VocabularyParsing.FromFolder(folderName, out DWISVocabulary vocabulary);


           // VocabularyParsing.FromMDFile(fileName, out DefinitionSet definitionSet);

            string[] lines = PrettyPrinting.PrettyPrint(vocabulary);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }


            MDWriting.ToMDFile(vocabulary, @"C:\temp\voc.md");
            MDWriting.ToMDFiles(vocabulary, @"C:\Temp\individualSets");
            Console.Read();
        }
    }
}
