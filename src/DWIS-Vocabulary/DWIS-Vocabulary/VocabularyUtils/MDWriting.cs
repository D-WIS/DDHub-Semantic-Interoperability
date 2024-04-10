using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
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
            List<string> examples = PostProcessExample(noun.Examples);
            foreach (var line in examples)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    nounBuilder.AppendLine(line);
                }
            }
            nounBuilder.AppendLine("- Definition set: " + noun.DefinitionSetName);
        }

        private static List<string> PostProcessExample(string[] inputLines)
        {
            List<string> lines = new List<string>
            {
                "- Examples:"
            };
            List<Tuple<string, string, string>> ddhub = null;
            bool insideADDHubBlock = false;
            List<string> queryArguments = null;
            foreach (string l in inputLines)
            {
                bool skip = false;
                if (l.Contains("```") && (l.Contains("ddhub") || l.Contains("DDHUB") || l.Contains("DDHub")))
                {
                    insideADDHubBlock = true;
                    skip = true;
                    int pos = l.LastIndexOf("ddhub");
                    if (pos < 0)
                    {
                        pos = l.LastIndexOf("DDHUB");
                    }
                    if (pos < 0)
                    {
                        pos = l.LastIndexOf("DDHub");
                    }
                    if (pos >= 0)
                    {
                        string rest = l.Substring(pos + 5);
                        string[] tokens = rest.Split(' ', '\t');
                        if (tokens != null)
                        {
                            queryArguments = new List<string>();
                            foreach (string s in tokens)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    queryArguments.Add(s);
                                }
                            }
                        }
                    }
                    ddhub = new List<Tuple<string, string, string>>();
                }
                else if (l.Contains("```") && insideADDHubBlock)
                {
                    skip = true;
                    insideADDHubBlock = false;
                    GenerateMermaid(ddhub, lines);
                    if (queryArguments != null && queryArguments.Count > 0)
                    {
                        GenerateSparQL(ddhub, queryArguments, lines);
                    }
                    ddhub = null;
                    queryArguments = null;
                }
                if (insideADDHubBlock)
                {
                    if (!skip)
                    {
                        if (!string.IsNullOrEmpty(l))
                        {
                            if (l.Contains(':'))
                            {
                                string[] tokens = l.Split(':', ' ', '\t');
                                if (tokens != null && tokens.Length >= 2 && !string.IsNullOrEmpty(tokens[0]) && !string.IsNullOrEmpty(tokens[1]))
                                {
                                    ddhub.Add(new Tuple<string, string, string>(tokens[1].Trim(), "BelongsTo", tokens[0].Trim()));
                                }
                            }
                            else
                            {
                                string[] tokens = l.Split(' ', '\t');
                                if (tokens != null && tokens.Length >= 3 && !string.IsNullOrEmpty(tokens[0]) && !string.IsNullOrEmpty(tokens[1]) && !string.IsNullOrEmpty(tokens[2]))
                                {
                                    ddhub.Add(new Tuple<string, string, string>(tokens[0].Trim(), tokens[1].Trim(), tokens[2].Trim()));
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (!skip)
                    {
                        lines.Add(l);
                    }
                }
            }
            return lines;
        }

        private static void GenerateMermaid(List<Tuple<string, string, string>> facts, List<string> outputs)
        {
            outputs.Add("An example semantic graph looks like as follow:");
            outputs.Add("```mermaid");
            outputs.Add("graph LR");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int count = 0;
            foreach (var fact in facts)
            {
                if (fact != null && !string.IsNullOrEmpty(fact.Item1) && !string.IsNullOrEmpty(fact.Item2) && !string.IsNullOrEmpty(fact.Item3))
                {
                    if (!dict.ContainsKey(fact.Item1))
                    {
                        string val = "N" + count.ToString("0000");
                        dict.Add(fact.Item1, val);
                        count++;
                    }
                    if (!dict.ContainsKey(fact.Item3))
                    {
                        string val = "N" + count.ToString("0000");
                        dict.Add(fact.Item3, val);
                        count++;
                    }
                    string str = "\t";
                    str += dict[fact.Item1] + "[" + fact.Item1 + "] ";
                    str += "-->|" + fact.Item2 + "| ";
                    str += dict[fact.Item3] + "[" + fact.Item3 + "] ";
                    outputs.Add(str);
                }
            }
            outputs.Add("```");

        }

        private static void GenerateSparQL(List<Tuple<string, string, string>> facts, List<string> queryArguments, List<string> outputs)
        {
            outputs.Add("An example SparQL query looks like this:");
            outputs.Add("```sparql");
            outputs.Add("PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>");
            outputs.Add("PREFIX ddhub: <http://ddhub.no/>");
            outputs.Add("PREFIX quantity: <http://ddhub.no/UnitAndQuantity>");
            outputs.Add("");
            string select = "SELECT ";
            bool first = true;
            foreach (string arg in queryArguments)
            {
                if (!first)
                {
                    select += ", ";
                }
                first = false;
                select += ProcessSparQLVariable(arg);
            }
            outputs.Add(select);
            outputs.Add("WHERE {");
            foreach (var fact in facts)
            {
                if (fact != null)
                {
                    string str = null;
                    if (fact.Item2 == "BelongsTo")
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " rdf:type " + "ddhub:" + fact.Item3 + " .";
                    }
                    else if (fact.Item2 == "IsOfMeasureableQuantity")
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " ddhub:IsOfMeasurableQuantity " + "quantity:" + fact.Item3 + " .";
                    }
                    else
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " ddhub:" + fact.Item2 + " " + ProcessSparQLVariable(fact.Item3) + " .";
                    }
                    outputs.Add(str);
                }
            }
            outputs.Add("}");
            outputs.Add("```");
        }

        private static string ProcessSparQLVariable(string var)
        {
            if (!string.IsNullOrEmpty(var) && !var.StartsWith('?'))
            {
                return "?" + var;
            }
            else
            {
                return var;
            }
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
            List<string> examples = PostProcessExample(verb.Examples);
            foreach (var line in examples)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    verbBuilder.AppendLine(line);
                }
            }
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
