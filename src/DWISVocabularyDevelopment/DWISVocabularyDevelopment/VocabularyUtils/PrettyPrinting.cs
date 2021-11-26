using System;
using System.Collections.Generic;
using DWISVocabularyDevelopment;

namespace VocabularyUtils
{
    public static class PrettyPrinting
    {
        public static string[] PrettyPrint(Noun noun)
        {
            List<string> lines = new List<string>();
            lines.Add(noun.Name);
            lines.Add("- Display name: " + noun.DisplayName);
            lines.Add("- Parent noun: " + noun.ParentNounName);
            lines.Add("- Attributes: ");
            if (noun.NounAttributes != null)
            {
                foreach (var att in noun.NounAttributes)
                {
                    lines.Add("  - Name: " + att.Name);
                    lines.Add("   - Display name: " + att.DisplayName);
                    lines.Add("   - Type: " + att.Type);
                    lines.Add("   - Description: " + att.Description);
                }
            }
            lines.Add("- Specialized attributes: ");
            if (noun.SpecializedNounAttributes != null)
            {
                foreach (var att in noun.SpecializedNounAttributes)
                {
                    lines.Add("  - Name: " + att.AttributeName);
                    lines.Add("   - Value: " + att.SpecializedValue);
                }
            }
            lines.Add("- Description: " + noun.Description);
            lines.Add("- Examples: " + noun.Examples);

            return lines.ToArray();
        }
        public static string[] PrettyPrint(Verb verb)
        {
            List<string> lines = new List<string>();
            lines.Add(verb.Name);
            lines.Add("- Display name: " + verb.DisplayName);
            lines.Add("- Parent noun: " + verb.ParentVerbName);
            lines.Add("- Domain noun: " + verb.DomainNounName);
            lines.Add("- Range noun: " + verb.RangeNounName);
            lines.Add("- Min cardinality: " + verb.MinCardinality);
            lines.Add("- Max cardinality: " + verb.MaxCardinality);
            lines.Add("- Description: " + verb.Description);
            lines.Add("- Examples: " + verb.Examples);

            return lines.ToArray();
        }

        public static string[] PrettyPrint(DefinitionSet definitionSet)
        {
            List<string> allLines = new List<string>();
            allLines.AddRange(PrettyPrint(definitionSet.DefinitionSetHeader));

            foreach (Noun n in definitionSet.Nouns)
            {
                string[] lines = PrettyPrinting.PrettyPrint(n);
                allLines.AddRange(lines);
            }
            foreach (Verb n in definitionSet.Verbs)
            {
                string[] lines = PrettyPrinting.PrettyPrint(n);
                allLines.AddRange(lines);
            }
            return allLines.ToArray();
        }

        public static string[] PrettyPrint(DWISVocabulary vocabulary)
        {
            List<string> allLines = new List<string>();

            allLines.Add("# Definition sets");

            foreach (var h in vocabulary.DefinitionSetHeaders)
            {
                allLines.AddRange(PrettyPrint(h));
            }

            allLines.Add("# Nouns");


            foreach (Noun n in vocabulary.Nouns)
            {
                string[] lines = PrettyPrinting.PrettyPrint(n);
                allLines.AddRange(lines);
            }

            allLines.Add("# Verbs");

            foreach (Verb n in vocabulary.Verbs)
            {
                string[] lines = PrettyPrinting.PrettyPrint(n);
                allLines.AddRange(lines);
            }
            return allLines.ToArray();
        }

        private static string[] PrettyPrint(DefinitionSetHeader definitionSetHeader)
        {
            List<string> allLines = new List<string>();
            allLines.Add(definitionSetHeader.Name);
            allLines.Add("- Description: " + definitionSetHeader.SetDescription);
            return allLines.ToArray();
        }

    }
}
