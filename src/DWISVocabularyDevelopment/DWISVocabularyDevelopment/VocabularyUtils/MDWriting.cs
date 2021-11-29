using System;
using System.Collections.Generic;
using System.Text;
using DWISVocabularyDevelopment;

namespace VocabularyUtils
{
    public static class MDWriting
    {
        public static void NounToMD(StringBuilder nounBuilder, Noun noun, bool singleFile = true, Vocabulary vocabulary = null)
        {
            nounBuilder.AppendLine("## " + noun.Name + " <!-- NOUN -->");
            nounBuilder.AppendLine("- Display name: " + noun.Name);
            nounBuilder.AppendLine("- Parent class: [" + noun.ParentNounName + "]" + GetLink(noun.ParentNounName, singleFile, vocabulary));//    (#" + noun.ParentNounName + ")");
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

        private static string GetLink(string name, bool singleFile = true, Vocabulary vocabulary = null)
        {
            if (singleFile)
            {
                return "(#" + name + ")";
            }
            else
            {
                string definitionSet = string.Empty;
                var noun = vocabulary.Nouns.Find(n => n.Name == name);
                if (noun != null)
                {
                    definitionSet = noun.DefinitionSetName;
                }
                else 
                {
                    var verb = vocabulary.Verbs.Find(v => v.Name == name);
                    if (verb != null)
                    {
                        definitionSet = verb.DefinitionSetName;
                    }
                }
                return "(#./" + definitionSet + ".md#" + name + ")";
            }
        }


        public static void VerbToMD(StringBuilder verbBuilder, Verb verb, bool singleFile = true, Vocabulary vocabulary = null)
        {
            verbBuilder.AppendLine("## " + verb.Name + " <!-- VERB -->");
            verbBuilder.AppendLine("- Display name: " + verb.Name);
            verbBuilder.AppendLine("- Parent verb: [" + verb.ParentVerbName + "]" + GetLink(verb.ParentVerbName, singleFile, vocabulary));// 
            verbBuilder.AppendLine("- Subject class: [" + verb.DomainNounName + "]" + GetLink(verb.DomainNounName, singleFile, vocabulary));// 
            verbBuilder.AppendLine("- Object class: [" + verb.RangeNounName + "]" + GetLink(verb.RangeNounName, singleFile, vocabulary));// 
            verbBuilder.AppendLine("- Min cardinality: " + verb.MinCardinality);
            verbBuilder.AppendLine("- Max cardinality: " + verb.MaxCardinality);
            verbBuilder.AppendLine("- Description: " + verb.Description);
            verbBuilder.AppendLine("- Examples: " + verb.Examples);
            verbBuilder.AppendLine("- Definition set: " + verb.DefinitionSetName);
        }

        public static void DefinitionSetHeaderToMD(StringBuilder builder, DefinitionSetHeader header, bool singleFile = true)
        {
            if (singleFile)
            {
                builder.AppendLine("## " + header.Name + "<!-- DEFINITION SET HEADER -->");
            }
            else
            {
                builder.AppendLine("# " + header.Name + "<!-- DEFINITION SET HEADER -->");
            }
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


        public static void ToMDFiles(DWISVocabulary vocabulary, string folderName)
        {
            List<DefinitionSet> definitionSets = new List<DefinitionSet>();
            foreach (var h in vocabulary.DefinitionSetHeaders)
            {
                definitionSets.Add(new DefinitionSet() { DefinitionSetHeader = h });
            }

            foreach (Noun n in vocabulary.Nouns)
            {
                DefinitionSet definitionSet = definitionSets.Find(d => d.Name == n.DefinitionSetName);
                if (definitionSet != null)
                {
                    definitionSet.Add(n);
                }
            }
            foreach (Verb v in vocabulary.Verbs)
            {
                DefinitionSet definitionSet = definitionSets.Find(d => d.Name == v.DefinitionSetName);
                if (definitionSet != null)
                {
                    definitionSet.Add(v);
                }
            }

            foreach (DefinitionSet set in definitionSets)
            {
                ToMDFile(set, folderName, vocabulary);
            }

        }


        public static void ToMDFile(DefinitionSet definitionSet, string folderName, Vocabulary vocabulary)
        {
            StringBuilder builder = new StringBuilder();
            DefinitionSetHeaderToMD(builder, definitionSet.DefinitionSetHeader, singleFile:false);           

            builder.AppendLine("# Nouns");


            foreach (var n in definitionSet.Nouns)
            {
                NounToMD(builder, n,singleFile:false, vocabulary:vocabulary );
            }

            builder.AppendLine("# Verbs");


            foreach (var v in definitionSet.Verbs)
            {
                VerbToMD(builder, v, singleFile: false, vocabulary: vocabulary);
            }

            System.IO.File.WriteAllText(folderName + System.IO.Path.DirectorySeparatorChar + definitionSet.Name + ".md", builder.ToString());

        }
    }
}
