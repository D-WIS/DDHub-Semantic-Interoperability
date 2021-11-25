using System;
using DWISVocabularyDevelopment;

namespace VocabularyParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = 
                @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\docs\vocabulary_development\definitions\DataFlow.md";

            string[] allLines = System.IO.File.ReadAllLines(fileName);
            NounParsing.ExtractSnippets(allLines, out System.Collections.Generic.List<string[]> allSnippets);

            System.Collections.Generic.List<Noun> nouns = new System.Collections.Generic.List<Noun>();

            foreach (var snippet in allSnippets)
            {
                Noun noun = new Noun();
                if (NounParsing.FromMDSnippet(snippet, noun))
                {
                    nouns.Add(noun);
                    noun.DefinitionFileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fileName);
                }
            }
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
