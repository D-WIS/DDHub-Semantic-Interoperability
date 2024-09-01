using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using DWIS.Vocabulary.Development;
using OSDC.DotnetLibraries.General.Common;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace DWIS.Vocabulary.Utils
{
    public static class MDWriting
    {
        public static void UnitsAndQuantitiesToMDFile(string path)
        {
            StringBuilder semanticBuilder = new StringBuilder();
            semanticBuilder.AppendLine("# Quantities");
            List<BasePhysicalQuantity> basePhysicalQuantities = BasePhysicalQuantity.AvailableBasePhysicalQuantities;
            UnitsAndQuantitiesToMDFile(semanticBuilder, basePhysicalQuantities);
            List<BasePhysicalQuantity> physicalQuantities = PhysicalQuantity.AvailablePhysicalQuantities;
            UnitsAndQuantitiesToMDFile(semanticBuilder, physicalQuantities);
            System.IO.File.WriteAllText(path, semanticBuilder.ToString());
        }
        private static void UnitsAndQuantitiesToMDFile(StringBuilder semanticBuilder, List<BasePhysicalQuantity> quantities)
        {
            if (quantities != null)
            {
                foreach (BasePhysicalQuantity quantity in quantities)
                {
                    if (quantity != null)
                    {
                        string quantityName = quantity.GetType().Name;
                        if (!string.IsNullOrEmpty(quantityName))
                        {
                            semanticBuilder.AppendLine("- Quantity:" + quantityName);
                            semanticBuilder.AppendLine("- " + quantityName + ".L = " + quantity.LengthDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".M = " + quantity.MassDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".T = " + quantity.TimeDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".I = " + quantity.ElectricCurrentDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".ThT = " + quantity.TemperatureDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".N = " + quantity.AmountSubstanceDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".J = " + quantity.LuminousIntensityDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".Theta = " + quantity.PlaneAngleDimension.ToString(CultureInfo.InvariantCulture));
                            semanticBuilder.AppendLine("- " + quantityName + ".Omega = " + quantity.SolidAngleDimension.ToString(CultureInfo.InvariantCulture));
                            if (quantity.UnitChoices != null)
                            {
                                foreach (var unitChoice in quantity.UnitChoices)
                                {
                                    if (unitChoice != null)
                                    {
                                        string unitName = unitChoice.GetVariableName();
                                        if (!string.IsNullOrEmpty(unitName))
                                        {
                                            semanticBuilder.AppendLine("- Unit:" + unitName);
                                            semanticBuilder.AppendLine("- " + unitName + ".ConversionFactorA = " + unitChoice.ConversionBiasFromSI.ToString(CultureInfo.InvariantCulture));
                                            semanticBuilder.AppendLine("- " + unitName + ".ConversionFactorB = " + unitChoice.ConversionFactorFromSI.ToString(CultureInfo.InvariantCulture));
                                            string unitLabel = GetValidName(unitChoice.UnitLabel);
                                            if (!string.IsNullOrEmpty(unitLabel))
                                            {
                                                semanticBuilder.AppendLine("- " + unitName + ".Symbol = " + unitLabel);
                                            }
                                            semanticBuilder.AppendLine("- " + unitName + " IsUnitForQuantity " + quantityName);
                                            if (unitChoice.IsSI)
                                            {
                                                semanticBuilder.AppendLine("- " + quantityName + " HasSIUnit " + unitName);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private static string GetValidName(string originalName)
        {
            if (string.IsNullOrEmpty(originalName)) { return originalName; }
            string validName = originalName.Replace(" ", "").Replace("/", "Per").Replace("\"", "");
            if (string.IsNullOrEmpty (validName)) { return validName; }
            string first = validName.Substring(0, 1).ToLower();
            return Correct(first + validName.Substring(1));
        }


        private static string Correct(string symbol)
        {
            string corrected = symbol.Replace("²", "square")
                    .Replace("µ", "mu")
                    .Replace("°", "deg")
                    .Replace("³", "cubic")
                    .Replace("•", ".")
                    .Replace("Ω", "omega")
                    .Replace("å", "aa")
                    .Replace("Å", "AA")
                    .Replace("ø", "oe")
                    .Replace("☉", "solarMass")
                    .Replace("🜨", "earthMass")
                    .Replace("é", "e")
                    .Replace("‰", "perThousands")
                    .Replace("√", "sqrt ");
            //if (corrected.Any(c => !char.IsLetterOrDigit(c)))
            //{
            //    throw new Exception("symbol still contains special characters");
            //}
            return corrected;
        }
        public static void NounToMD(StringBuilder nounBuilder, Noun noun, bool singleFile = true,DWIS.Vocabulary.Development.Vocabulary vocabulary = null)
        {
            nounBuilder.AppendLine("## " + noun.Name + " <!-- NOUN -->");
            if (!string.IsNullOrEmpty(noun.DisplayName))
            {
                nounBuilder.AppendLine("- Display name: " + noun.DisplayName);
            }
            if (!string.IsNullOrEmpty(noun.ParentNounName))
            {
                nounBuilder.AppendLine("- Parent class: [" + noun.ParentNounName + "]" + GetLink(noun.ParentNounName, singleFile, vocabulary));
            }
            if (noun.NounAttributes != null && noun.NounAttributes.Length > 0)
            {
                nounBuilder.AppendLine("- Attributes:");
                foreach (var att in noun.NounAttributes)
                {
                    nounBuilder.AppendLine("  - " + att.Name);
                    if (!string.IsNullOrEmpty(att.Type))
                    {
                        nounBuilder.AppendLine("    - Type: " + att.Type);
                    }
                    if (att.Description != null && att.Description.Length > 0)
                    {
                        nounBuilder.AppendLine("    - Description: " + att.Description[0]);
                        for (int i = 1; i < att.Description.Length; i++)
                        {
                            nounBuilder.AppendLine("    " + att.Description[i]);
                        }
                    }
                }
            }
            if (noun.SpecializedNounAttributes != null && noun.SpecializedNounAttributes.Length > 0)
            {
                nounBuilder.AppendLine("- Specialization:");
                foreach (var att in noun.SpecializedNounAttributes)
                {
                    nounBuilder.AppendLine("  - " + att.AttributeName + " = " + att.SpecializedValue);
                }
            }
            if (noun.Description != null && noun.Description.Length > 0)
            {
                nounBuilder.AppendLine("- Description: ");
                foreach (string desc in noun.Description)
                {
                    nounBuilder.AppendLine(desc);
                }
            }
            if (!string.IsNullOrEmpty(noun.DefinitionSetName))
            {
                nounBuilder.AppendLine("- Definition set: " + noun.DefinitionSetName);
            }
            if (noun.IsDeprecated)
            {
                nounBuilder.AppendLine("- Obsolete: true");
                if (noun.WillBeRemovedBy > DateTime.MinValue)
                {
                    nounBuilder.AppendLine("- Will be removed by: " + noun.WillBeRemovedBy.ToShortDateString());
                }
                if (!string.IsNullOrEmpty(noun.ReplacedBy))
                {
                    nounBuilder.AppendLine("- Replaced by: " + noun.ReplacedBy);
                }
            }
            if (noun.Examples != null && noun.Examples.Length > 0)
            {
                List<string> examples = PostProcessExample(noun.Examples, vocabulary);
                foreach (var line in examples)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        nounBuilder.AppendLine(line);
                    }
                }
            }
        }

        private static List<string> PostProcessExample(string[] inputLines, Development.Vocabulary vocabulary)
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
                if (l.Contains("```") && (l.Contains("dwis") || l.Contains("DWIS")))
                {
                    lines.Add(l);
                    skip = true;
                    insideADDHubBlock = true;
                    int pos = l.LastIndexOf("dwis");
                    if (pos < 0)
                    {
                        pos = l.LastIndexOf("DWIS");
                    }
                    if (pos >= 0)
                    {
                        string rest = null;
                        if (pos + 5 < l.Length)
                        {
                            rest = l.Substring(pos + 5);
                            if (!string.IsNullOrEmpty(rest))
                            {
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
                        }
                    }
                    ddhub = new List<Tuple<string, string, string>>();
                }
                else if (l.Contains("```") && insideADDHubBlock)
                {
                    lines.Add(l);
                    skip = true;
                    insideADDHubBlock = false;
                    GenerateMermaid(ddhub, lines, vocabulary);
                    if (queryArguments != null && queryArguments.Count > 0)
                    {
                        GenerateSparQL(ddhub, queryArguments, lines, vocabulary);
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
                                    ddhub.Add(new Tuple<string, string, string>(tokens[1].Trim(), "BelongsToClass", tokens[0].Trim()));
                                }
                            }
                            else
                            {
                                string[] tokens = l.Split(' ', '\t');
                                if (tokens != null && tokens.Length >= 3 && !string.IsNullOrEmpty(tokens[0]) && !string.IsNullOrEmpty(tokens[1]) && !string.IsNullOrEmpty(tokens[2]))
                                {
                                    string subject = tokens[2].Trim();
                                    if (tokens.Length > 3)
                                    {
                                        for (int i = 3; i < tokens.Length; i++)
                                        {
                                            subject += " " + tokens[i].Trim();
                                        }
                                    }
                                    ddhub.Add(new Tuple<string, string, string>(tokens[0].Trim(), tokens[1].Trim(), subject));
                                }
                            }
                        }
                    }
                }
                if (!skip)
                {
                    lines.Add(l);
                }
            }
            return lines;
        }

        private static void GenerateMermaid(List<Tuple<string, string, string>> facts, List<string> outputs, Development.Vocabulary vocabulary)
        {
            outputs.Add("An example semantic graph looks like as follow:");
            outputs.Add("```mermaid");
            outputs.Add("graph LR");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int count = 0;
            Tuple<string, string, string> f = new Tuple<string, string, string>(null, null, null);
            foreach (var fact in facts)
            {
                if (fact != null && !string.IsNullOrEmpty(fact.Item1) && !string.IsNullOrEmpty(fact.Item2) && !string.IsNullOrEmpty(fact.Item3))
                { 
                    f = new Tuple<string, string, string>(fact.Item1, fact.Item2, fact.Item3);
                    if (fact.Item1.Contains('.') && fact.Item2 == "=")
                    {
                        // this is an assignment to an attribute
                        string[] tokens = f.Item1.Split('.');
                        if (tokens != null && tokens.Length == 2)
                        {
                            string subj = tokens[0];
                            string verb = tokens[1];
                            string o = f.Item3;
                            f = new Tuple<string, string, string>(subj, verb, o);
                        }
                    }               
                    if (!dict.ContainsKey(f.Item1))
                    {
                        string val = "N" + count.ToString("0000");
                        dict.Add(f.Item1, val);
                        count++;
                    }
                    if (!dict.ContainsKey(f.Item3))
                    {
                        string val = "N" + count.ToString("0000");
                        dict.Add(f.Item3, val);
                        count++;
                    }
                    string str = "\t";
                    str += dict[f.Item1] + "[" + f.Item1 + "] ";
                    str += "-->|" + f.Item2 + "| ";
                    bool isVerb = false;
                    if (vocabulary != null && vocabulary.Verbs != null)
                    {
                        foreach (Verb v in vocabulary.Verbs)
                        {
                            if (v != null && v.Name == f.Item2)
                            {
                                isVerb = true;
                                break;
                            }
                        }
                    }
                    string obj = f.Item3;
                    if (obj == "\"\"\"")
                    {
                        obj = "\"''\"";
                    }
                    if (int.TryParse(obj, out int ival) || double.TryParse(obj, NumberStyles.Any, CultureInfo.InvariantCulture, out double dval))
                    {
                        obj = "\"" + obj + "\"";
                    }
                    if (f.Item2 == "BelongsToClass")
                    {
                        str += dict[f.Item3] + "(" + obj + ") ";
                    }
                    else if (isVerb)
                    {
                        str += dict[f.Item3] + "[" + obj + "] ";
                    }
                    else
                    {
                        str += dict[f.Item3] + "((" + obj + ")) ";
                    }
                    outputs.Add(str);
                }
            }
            outputs.Add("```");

        }

        private static void GenerateSparQL(List<Tuple<string, string, string>> facts, List<string> queryArguments, List<string> outputs, Development.Vocabulary vocabulary)
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
            List<string> filters = new List<string>();
            int attrCount = 0;
            outputs.Add("WHERE {");
            foreach (var fact in facts)
            {
                if (fact != null)
                {
                    bool isVerb = false;
                    if (vocabulary != null && vocabulary.Verbs != null)
                    {
                        foreach (Verb v in vocabulary.Verbs)
                        {
                            if (v != null && v.Name == fact.Item2)
                            {
                                isVerb = true;
                                break;
                            }
                        }
                    }
                    string str = null;
                    if (fact.Item2 == "BelongsToClass")
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " rdf:type " + "ddhub:" + fact.Item3 + " .";
                    }
                    else if (fact.Item2 == "IsOfMeasureableQuantity")
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " ddhub:IsOfMeasurableQuantity " + "quantity:" + fact.Item3 + " .";
                    }
                    else if (isVerb)
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " ddhub:" + fact.Item2 + " " + ProcessSparQLVariable(fact.Item3) + " .";
                    }
                    else
                    {
                        str = "\t" + ProcessSparQLVariable(fact.Item1) + " ddhub:" + fact.Item2 + " " + "?Attribute" + attrCount.ToString("000") + " .";
                        filters.Add("\t" + "?Attribute" + attrCount.ToString("000") + " = " + fact.Item3);
                        attrCount++;
                    }
                    if (str != null)
                    {
                        outputs.Add(str);
                    }
                }
            }
            if (filters != null && filters.Count > 0)
            {
                outputs.Add("  FILTER (");
                first = true;
                foreach (string f in filters)
                {
                    if (first)
                    {
                        outputs.Add(f);
                        first = false;
                    }
                    else
                    {
                        outputs.Add("\t&& " + f);
                    }
                }
                outputs.Add("  )");
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

        private static string GetLink(string name, bool singleFile = true, Development.Vocabulary vocabulary = null, string route = "./")
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
            if (!string.IsNullOrEmpty(verb.DisplayName))
            {
                verbBuilder.AppendLine("- Display name: " + verb.DisplayName);
            }
            if (!string.IsNullOrEmpty(verb.ParentVerbName))
            {
                verbBuilder.AppendLine("- Parent verb: [" + verb.ParentVerbName + "]" + GetLink(verb.ParentVerbName, singleFile, vocabulary));
            }
            if (!string.IsNullOrEmpty(verb.DomainNounName))
            {
                verbBuilder.AppendLine("- Subject class: [" + verb.DomainNounName + "]" + GetLink(verb.DomainNounName, singleFile, vocabulary));
            }
            if (!string.IsNullOrEmpty(verb.RangeNounName))
            {
                verbBuilder.AppendLine("- Object class: [" + verb.RangeNounName + "]" + GetLink(verb.RangeNounName, singleFile, vocabulary));
            }
            if (verb.MinCardinality >= 0)
            {
                verbBuilder.AppendLine("- Min cardinality: " + verb.MinCardinality);
            }
            if (verb.MaxCardinality >= 0)
            {
                verbBuilder.AppendLine("- Max cardinality: " + verb.MaxCardinality);
            }
            if (!string.IsNullOrEmpty(verb.DefinitionSetName))
            {
                verbBuilder.AppendLine("- Definition set: " + verb.DefinitionSetName);
            }
            if (verb.Description != null && verb.Description.Length > 0) 
            {
                verbBuilder.AppendLine("- Description: ");
                foreach (string desc in verb.Description)
                {
                    verbBuilder.AppendLine(desc);
                }
            }
            if (verb.IsDeprecated)
            {
                verbBuilder.AppendLine("- Obsolete: true");
                if (verb.WillBeRemovedBy > DateTime.MinValue)
                {
                    verbBuilder.AppendLine("- Will be removed by: " + verb.WillBeRemovedBy.ToShortDateString());
                }
                if (!string.IsNullOrEmpty(verb.ReplacedBy))
                {
                    verbBuilder.AppendLine("- Replaced by: " + verb.ReplacedBy);
                }
            }
            if (verb.Examples != null && verb.Examples.Length > 0)
            {
                List<string> examples = PostProcessExample(verb.Examples, vocabulary);
                foreach (var line in examples)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        verbBuilder.AppendLine(line);
                    }
                }
            }
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
            if (header.SetDescription != null && header.SetDescription.Length > 0) 
            {
                builder.AppendLine("- Description: ");
                foreach (var desc in header.SetDescription)
                {
                    builder.AppendLine(desc);
                }
            }
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
            GenerateNounClassDiagram(builder, definitionSet.Nouns);
            foreach (var n in definitionSet.Nouns)
            {
                NounToMD(builder, n, singleFile: false, vocabulary: vocabulary);
            }
            builder.AppendLine("# Verbs");
            GenerateVerbClassDiagram(builder, definitionSet.Verbs);
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

        private static void GenerateNounClassDiagram(StringBuilder builder, List<Noun> nouns)
        {
            if (nouns != null && nouns.Count > 0 && nouns[0] != null && !string.IsNullOrEmpty(nouns[0].Name) && !string.IsNullOrEmpty(nouns[0].ParentNounName))
            {
                builder.AppendLine("## Class Inheritance for Nouns");
                builder.AppendLine("Here is a class inheritance diagram for the nouns contained in this definition set.");
                builder.AppendLine("```mermaid");
                builder.AppendLine("classDiagram");
                foreach (var n in nouns)
                {
                    if (n != null && !string.IsNullOrEmpty(n.Name) && !string.IsNullOrEmpty(n.ParentNounName))
                    {
                        builder.AppendLine(n.ParentNounName + " <|-- " + n.Name);
                    }
                }
                builder.AppendLine("```");
            }
        }
        private static void GenerateVerbClassDiagram(StringBuilder builder, List<Verb> verbs)
        {
            if (verbs != null && verbs.Count > 0 && verbs[0] != null && !string.IsNullOrEmpty(verbs[0].Name) && !string.IsNullOrEmpty(verbs[0].ParentVerbName))
            {
                builder.AppendLine("## Class Inheritance for Verbs");
                builder.AppendLine("Here is a class inheritance diagram for the verbs contained in this definition set.");
                builder.AppendLine("```mermaid");
                builder.AppendLine("classDiagram");
                foreach (var v in verbs)
                {
                    if (v != null && !string.IsNullOrEmpty(v.Name) && !string.IsNullOrEmpty(v.ParentVerbName))
                    {
                        builder.AppendLine(v.ParentVerbName + " <|-- " + v.Name);
                    }
                }
                builder.AppendLine("```");
                builder.AppendLine("## Relations");
                builder.AppendLine("Here is a graph representing the relations that can be made with the verbs defined in this definition set.");
                builder.AppendLine("```mermaid");
                builder.AppendLine("erDiagram");
                foreach (var v in verbs)
                {
                    if (v != null && !string.IsNullOrEmpty(v.Name) && !string.IsNullOrEmpty(v.DomainNounName) && !string.IsNullOrEmpty(v.RangeNounName))
                    {
                        builder.AppendLine(v.DomainNounName + " ||--o{ " + v.RangeNounName + " : " + v.Name);
                    }
                }
                builder.AppendLine("```");
            }
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
