using System;
using DWISVocabularyDevelopment;
using VocabularyUtils;
using System.Collections.Generic;
namespace VocabularyParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = 
            //    @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\DataFlow.md";


           var ont =  DWISVocabulary.OWL.OntologyGeneration.GenerateOntology(@"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\auto-generated\rdf\DWISVocabulary");



            string folderName = @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\";


            VocabularyParsing.FromFolder(folderName, out DWISVocabularyDevelopment.DWISVocabulary vocabulary);


            vocabulary.CheckForDuplicates(out ICollection<Noun> duplicatedNouns, out ICollection<Verb> duplicatedVerbs);

            vocabulary.ToTrees(out Tree<Noun> nounTree, out Tree<Verb> verbTree);

            int nounTreeCount = nounTree.Count();

            int verbTreeCount = verbTree.Count();

           // VocabularyParsing.FromMDFile(fileName, out DefinitionSet definitionSet);

            string[] lines = PrettyPrinting.PrettyPrint(vocabulary);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }


            MDWriting.ToMDFile(vocabulary, @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\auto-generated\md\DWISvocabulary.md");
            MDWriting.ToMDFiles(vocabulary, @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\auto-generated\md\definition-files");
            Console.Read();
        }
    }
}
