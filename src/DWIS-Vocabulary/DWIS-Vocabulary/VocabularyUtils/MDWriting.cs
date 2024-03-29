﻿using System;
using System.Collections.Generic;
using System.Text;
using DWIS.Vocabulary.Development;

namespace DWIS.Vocabulary.Utils
{
    public static class MDWriting
    {
        public static void NounToMD(StringBuilder nounBuilder, Noun noun, bool singleFile = true,DWIS.Vocabulary.Development.Vocabulary vocabulary = null)
        {
            nounBuilder.AppendLine("## " + noun.Name + " <!-- NOUN -->");
            nounBuilder.AppendLine("- Display name: " + noun.DisplayName);
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

        private static string GetLink(string name, bool singleFile = true, DWIS.Vocabulary.Development.Vocabulary vocabulary = null, string route = "./")
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
                return "("+route + definitionSet + ".md#" + name + ")";
            }
        }


        public static void VerbToMD(StringBuilder verbBuilder, Verb verb, bool singleFile = true, DWIS.Vocabulary.Development.Vocabulary vocabulary = null)
        {
            verbBuilder.AppendLine("## " + verb.Name + " <!-- VERB -->");
            verbBuilder.AppendLine("- Display name: " + verb.DisplayName);
            verbBuilder.AppendLine("- Parent verb: [" + verb.ParentVerbName + "]" + GetLink(verb.ParentVerbName, singleFile, vocabulary));// 
            verbBuilder.AppendLine("- Subject class: [" + verb.DomainNounName + "]" + GetLink(verb.DomainNounName, singleFile, vocabulary));// 
            verbBuilder.AppendLine("- Object class: [" + verb.RangeNounName + "]" + GetLink(verb.RangeNounName, singleFile, vocabulary));// 
            verbBuilder.AppendLine("- Min cardinality: " + verb.MinCardinality);
            verbBuilder.AppendLine("- Max cardinality: " + verb.MaxCardinality);
            verbBuilder.AppendLine("- Description: " + verb.Description);
            verbBuilder.AppendLine("- Examples: " + verb.Examples);
            verbBuilder.AppendLine("- Definition set: " + verb.DefinitionSetName);
        }

        public static void IndividualToMD(StringBuilder builder, TypedIndividual individual, DWIS.Vocabulary.Development.Vocabulary vocabulary, bool useLinks = false)
        {
            if (useLinks)
            {
                builder.AppendLine("- " + GetLink(individual.TypeName, vocabulary: vocabulary, route: "../") + ":" + individual.Name);
            }
            else
            {
                builder.AppendLine("- " + individual.TypeName+ ":" + individual.Name);
            }
            if (individual.Attributes != null)
            {
                foreach (var att in individual.Attributes)
                {
                    if (att != null && !string.IsNullOrEmpty(att.AttributeValue))
                    {
                        builder.AppendLine("- " + individual.Name + "." + att.AttributeName + " = " + att.AttributeValue);
                    }
                }
            }
        }

        public static void ClassAssertionToMD(StringBuilder builder, ClassAssertion sentence, DWIS.Vocabulary.Development.Vocabulary vocabulary, bool useLinks = false)
        {
            if (useLinks)
            {
                builder.AppendLine("- " + sentence.Subject + " " + GetLink(sentence.Verb, vocabulary: vocabulary, route: "../") + " " + sentence.Class);
            }
            else
            {
                builder.AppendLine("- " + sentence.Subject + " " + sentence.Verb + " " + sentence.Class);
            }
        }


        public static void SentenceToMD(StringBuilder builder, Sentence sentence, DWIS.Vocabulary.Development.Vocabulary vocabulary, bool useLinks = false)
        {
            if (useLinks)
            {
                builder.AppendLine("- " + sentence.Subject + " " + GetLink(sentence.Verb, vocabulary: vocabulary, route: "../") + " " + sentence.Object);
            }
            else
            {
                builder.AppendLine("- " + sentence.Subject + " " +sentence.Verb + " " + sentence.Object);
            }
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

        public static void ToCSVFile(DWISVocabulary vocabulary, string fileName)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("\"name\", \"description\", \"submitter\"");
            foreach (Noun n in vocabulary.Nouns)
            {
                NounToCSV(builder, n);
            }
            foreach (Verb v in vocabulary.Verbs)
            {
                VerbToCSV(builder, v);
            }
            System.IO.File.WriteAllText(fileName, builder.ToString());
        }

        private static void NounToCSV(StringBuilder builder, Noun n)
        {
            string description = "\"";
            description += "Nature: Noun\r\n";
            description += "Display name: " + n.DisplayName + "\r\n";
            description += "Parent noun: " + n.ParentNounName + "\r\n";
            description += "Description: " + n.Description;
            description += "\"";

            builder.AppendLine($"\"{n.Name}\", \"{n.Description}\"");
        }

        private static void VerbToCSV(StringBuilder builder, Verb n)
        {
            string description = "\"";
            description += "Nature: Verb\r\n";
            description += "Display name: " + n.DisplayName + "\r\n";
            description += "Parent noun: " + n.ParentVerbName + "\r\n";
            description += "Description: " + n.Description;
            description += "\"";

            builder.AppendLine($"\"{n.Name}\", \"{n.Description}\"");
        }

        public static void ToMDFiles(DWISVocabulary vocabulary, string folderName)
        {
            List<DefinitionSet> definitionSets = ToDefinitionSets(vocabulary);

            foreach (DefinitionSet set in definitionSets)
            {
                ToMDFile(set, folderName, vocabulary);
            }
        }

        public static List<DefinitionSet> ToDefinitionSets(DWISVocabulary vocabulary)
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
            return definitionSets;
        }

        public static string ToMDString(DefinitionSet definitionSet, DWIS.Vocabulary.Development.Vocabulary vocabulary)
        {
            StringBuilder builder = new StringBuilder();
            DefinitionSetHeaderToMD(builder, definitionSet.DefinitionSetHeader, singleFile: false);

            builder.AppendLine("# Nouns");


            foreach (var n in definitionSet.Nouns)
            {
                NounToMD(builder, n, singleFile: false, vocabulary: vocabulary);
            }

            builder.AppendLine("# Verbs");


            foreach (var v in definitionSet.Verbs)
            {
                VerbToMD(builder, v, singleFile: false, vocabulary: vocabulary);
            }
            return builder.ToString();
        }

        public static void ToMDFile(DefinitionSet definitionSet, string folderName, DWIS.Vocabulary.Development.Vocabulary vocabulary)
        {
          string mdContents = ToMDString(definitionSet, vocabulary);

            System.IO.File.WriteAllText(folderName + System.IO.Path.DirectorySeparatorChar + definitionSet.Name + ".md", mdContents);

        }

        public static void ToMDFile(DWISInstance instance, string fileName, DWIS.Vocabulary.Development.Vocabulary vocabulary, bool addGraph = false, bool useLinks = true)
        {            

            System.IO.File.WriteAllText(fileName, ToString(instance,  vocabulary, addGraph, useLinks));

        }

        public static string ToString(DWISInstance instance,  DWIS.Vocabulary.Development.Vocabulary vocabulary, bool addGraph = false, bool useLinks = true)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("# " + instance.Name);
            foreach (var i in instance.Population)
            {
                IndividualToMD(builder, i, vocabulary, useLinks);
            }


            foreach (var v in instance.ClassAssertions)
            {
                ClassAssertionToMD(builder, v, vocabulary, useLinks);
            }

            foreach (var v in instance.Sentences)
            {
                SentenceToMD(builder, v, vocabulary, useLinks);
            }

            if (addGraph)
            {
                ToMDMermaidGraph(instance, builder);
            }
            return builder.ToString();
        }
        public static void ToMDMermaidGraph(DWISInstance instance, StringBuilder builder)
        {
            string name;
            if (string.IsNullOrEmpty(instance.Name))
            {
                name = "example";
            }
            else
            {
                name = instance.Name;
            }
            builder.AppendLine("```mermaid");
            builder.AppendLine("flowchart TD");
            builder.AppendLine("\t classDef typeClass fill:#f96;");
            builder.AppendLine("\t classDef classClass fill:#9dd0ff;");
            foreach (var i in instance.Population)
            {
                builder.AppendLine($"\t{i.Name}([{i.Name}]) --> {i.TypeName}[[{i.TypeName}]]:::typeClass"  );               
            }
            foreach (var i in instance.Sentences)
            {
                builder.AppendLine($"\t {i.Subject} -- {i.Verb} --> {i.Object} ");
            }

            foreach (var i in instance.ClassAssertions)
            {
                builder.AppendLine($"\t {i.Subject} -- {i.Verb} --> {i.Class}(({i.Class})):::classClass");
            }

            builder.AppendLine("```");
        }
    }
}
