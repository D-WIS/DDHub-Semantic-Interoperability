using System;
using System.Collections.Generic;
using System.Text;
using DWISVocabularyDevelopment;

namespace VocabularyUtils
{
    public static class MDWriting
    {
        public static void NounToMD(StringBuilder nounBuilder, Noun noun)
        {
            nounBuilder.AppendLine("## " + noun.Name + " <!-- NOUN -->");
            nounBuilder.AppendLine("- Display name: " + noun.Name);
            nounBuilder.AppendLine("- Parent class: [" + noun.ParentNounName + "](#" + noun.ParentNounName + ")");
            nounBuilder.AppendLine("- Attributes:");
            if (noun.NounAttributes != null)
            {
                foreach (var att in noun.NounAttributes)
                {
                    nounBuilder.AppendLine("  - " + att.Name);
                    nounBuilder.AppendLine("    - Type: " + att.Type);
                    nounBuilder.AppendLine("    - Description: " + att.Description);
                }
            }
            nounBuilder.AppendLine("- Specialization:");
            if (noun.SpecializedNounAttributes != null)
            {
                foreach (var att in noun.SpecializedNounAttributes)
                {
                    nounBuilder.AppendLine("  - " + att.AttributeName + " = " + att.SpecializedValue);
                }
            }
            nounBuilder.AppendLine("- Description: " + noun.Description);
            nounBuilder.AppendLine("- Examples:" + noun.Examples);
            nounBuilder.AppendLine("- Definition set: " + noun.DefinitionSetName);
        }

        public static void VerbToMD(StringBuilder verbBuilder, Verb verb)
        {
            verbBuilder.AppendLine("## " + verb.Name + " <!-- VERB -->");
            verbBuilder.AppendLine("- Display name: " + verb.Name);
            verbBuilder.AppendLine("- Subject class: [" + verb.DomainNounName + "]");//(./" + GetDetailedFileName(((DDHubRelationClass)dDHubClass).Domain, folderName) + ")");
            verbBuilder.AppendLine("- Object class: [" + verb.RangeNounName + "]");//(./" + GetDetailedFileName(((DDHubRelationClass)dDHubClass).Range, folderName) + ")");
            verbBuilder.AppendLine("- Min cardinality: " + verb.MinCardinality);
            verbBuilder.AppendLine("- Max cardinality: " + verb.MaxCardinality);
            verbBuilder.AppendLine("- Description: " + verb.Description);
            verbBuilder.AppendLine("- Examples: " + verb.Examples);
            verbBuilder.AppendLine("- Definition set: " + verb.DefinitionSetName);
        }

        public static void DefinitionSetHeaderToMD(StringBuilder builder, DefinitionSetHeader header)
        {
            builder.AppendLine("## " + header.Name + "<!-- DEFINITION SET HEADER -->");
            builder.AppendLine("- Description: " + header.SetDescription);
        }

        public static void ToMDFile(DWISVocabulary vocabulary, string fileName)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("# Definition sets");

            foreach (var h in vocabulary.DefinitionSetHeaders)
            {
                DefinitionSetHeaderToMD(builder, h);
            }

            builder.AppendLine("# Nouns");


            foreach (var n in vocabulary.Nouns)
            {
                NounToMD(builder, n);
            }

            builder.AppendLine("# Verbs");


            foreach (var v in vocabulary.Verbs)
            {
                VerbToMD(builder, v);
            }
            System.IO.File.WriteAllText(fileName, builder.ToString());
        }
    }
}
