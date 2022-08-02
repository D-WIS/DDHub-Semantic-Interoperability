using System;
using DWIS.Vocabulary.Development;
using DWIS.Vocabulary.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Vocabulary.Parse.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = 
            //    @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\DataFlow.md";

            string folderName = @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\";


            VocabularyParsing.FromFolder(folderName, out DWIS.Vocabulary.Development.DWISVocabulary vocabulary);

            var files = System.IO.Directory.GetFiles(@"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\examples").Where(f => f.EndsWith(".md"));

            //string file = @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\examples\DWIS-SPP0 - Copy.md";

            //if (VocabularyParsing.FromMDFile(file, vocabulary, out DWISInstance instance))
            //{ 
            
            //}
                    //string exportFileName = _paths.ExamplesFilesFolderPath + System.IO.Path.DirectorySeparatorChar + System.IO.Path.GetFileNameWithoutExtension(file) + ".md";






            DWIS.Vocabulary.OWL.OntologyGeneration.ExportOntology(@"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\auto-generated\rdf\DWISVocabulary", vocabulary);

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
