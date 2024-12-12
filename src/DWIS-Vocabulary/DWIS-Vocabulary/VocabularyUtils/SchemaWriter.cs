using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DWIS.Vocabulary.Development;
using Microsoft.CodeAnalysis.CSharp;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace DWIS.Vocabulary.Utils
{
    public static  class SchemaWriter
    {
        public static IEnumerable<string> GetNouns(Development.Vocabulary vocabulary)
        {
            return vocabulary.Nouns.Select(n => GetSchema(n));
        }

        public static IList<string> GetAttributes(Development.Vocabulary vocabulary)
        {
            return vocabulary.Nouns.Aggregate<Noun, List<string>>(new List<string>(), (l, n) =>
            {
                var atts = GetAttributesSchema(n, vocabulary);
                if (atts != null)
                {
                    l.AddRange(GetAttributesSchema(n, vocabulary));
                }
                return l; 
            });
        }

        public static void WriteUnitsAndQuantitiesSchema(Development.Vocabulary vocabulary, DWISInstance instance, string unitsFileName, string quantitiesFileName)
        {
            if (vocabulary.GetNoun("Unit", out Noun unitNoun) && vocabulary.GetNoun("Quantity", out Noun quantityNoun))
            {
                List<string> written = new List<string>();
                StringBuilder builder = new StringBuilder();

                builder.AppendLine("using System;");
                builder.AppendLine("namespace DWIS.Vocabulary.Schemas.UQ");
                builder.AppendLine("{");
                builder.AppendLine("public static class Units");
                builder.AppendLine("{");

                var units = instance.Population.Where(i => i.TypeName == unitNoun.Name);
                foreach (var unit in units)
                {
                    string s = CorrectString(unit.Name);
                    if (!written.Contains(s))
                    {
                        string line = $"\tpublic static string {s} = \"{s}\";";
                        builder.AppendLine(line);
                        written.Add(s);
                    }
                }

                builder.AppendLine("}");
                builder.AppendLine("}");

                System.IO.File.WriteAllText(unitsFileName, builder.ToString());

                builder = new StringBuilder();

                builder.AppendLine("using System;");
                builder.AppendLine("namespace DWIS.Vocabulary.Schemas.UQ");
                builder.AppendLine("{");
                builder.AppendLine("public static class Quantities");
                builder.AppendLine("{");

                var quantities = instance.Population.Where(i => i.TypeName == quantityNoun.Name);
                foreach (var quantity in quantities)
                {
                    string s = CorrectString(quantity.Name);
                    if (!written.Contains(s))
                    {
                        string line = $"\tpublic static string {s} = \"{s}\";";
                    builder.AppendLine(line);
                        written.Add(s);
                    }
                }

                builder.AppendLine("}");
                builder.AppendLine("}");

                System.IO.File.WriteAllText(quantitiesFileName, builder.ToString());
            } 
        }

        private static string CorrectString(string input)
        {
            return input.Replace("'", "").Replace(" ", "");
        }
        
        public static void WriteSchema(Development.Vocabulary vocabulary, string nounsFileName, string verbsFileName, string attributesFileName)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("namespace DWIS.Vocabulary.Schemas");
            builder.AppendLine("{");
            builder.AppendLine("public static class Nouns");
            builder.AppendLine("{");
            builder.AppendLine("public enum Enum");
            builder.AppendLine("{");
            foreach (Noun noun in vocabulary.Nouns)
            {
                int hash = noun.Name.GetHashCode();
                if (noun != vocabulary.Nouns.Last())
                {
                    builder.AppendLine(noun.Name + " = " + hash.ToString() +  ",");
                }
                else
                {
                    builder.AppendLine(noun.Name + " = " + hash.ToString());
                }
            }
            builder.AppendLine("}");
            foreach (string line in GetNouns(vocabulary))
            {
                builder.AppendLine(line);
            }
            builder.AppendLine("}");
            builder.AppendLine("}");

            System.IO.File.WriteAllText(nounsFileName, builder.ToString());

            builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("namespace DWIS.Vocabulary.Schemas");
            builder.AppendLine("{");
            builder.AppendLine("public static class Attributes");
            builder.AppendLine("{");
            List<string> attributes = new List<string>(); 
            if (vocabulary != null && vocabulary.Nouns != null)
            {
                foreach (Noun noun in vocabulary.Nouns)
                {
                    if (noun != null && !string.IsNullOrEmpty(noun.Name) && noun.NounAttributes != null && noun.NounAttributes.Length > 0)
                    {
                        foreach (NounAttribute attribute in noun.NounAttributes)
                        {
                            if (attribute != null && !string.IsNullOrEmpty(attribute.Name))
                            {
                                string attributeName = noun.Name + "_" + attribute.Name;
                                if (!attributes.Contains(attributeName))
                                {
                                    attributes.Add(attributeName);
                                }
                            }
                        }
                    }
                }
            }
            if (attributes.Count > 0)
            {
                builder.AppendLine("public enum Enum");
                builder.AppendLine("{");
                foreach (string attribute in attributes)
                {
                    int hash = attribute.GetHashCode();
                    if (attribute != attributes.Last())
                    {
                        builder.AppendLine(attribute + " = " + hash.ToString() + ",");
                    }
                    else
                    {
                        builder.AppendLine(attribute + " = " + hash.ToString());
                    }
                }
                builder.AppendLine("}");
            }
            foreach (string line in GetAttributes(vocabulary))
            {
                builder.AppendLine(line);
            }
            builder.AppendLine("}");
            builder.AppendLine("}");

            System.IO.File.WriteAllText(attributesFileName, builder.ToString());

            builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("namespace DWIS.Vocabulary.Schemas");
            builder.AppendLine("{");
            builder.AppendLine("public static class Verbs");
            builder.AppendLine("{");
            builder.AppendLine("public enum Enum");
            builder.AppendLine("{");
            foreach (Verb verb in vocabulary.Verbs)
            {
                int hash = verb.Name.GetHashCode();
                if (verb != vocabulary.Verbs.Last())
                {
                    builder.AppendLine(verb.Name + " = " + hash.ToString() + ",");
                }
                else
                {
                    builder.AppendLine(verb.Name + " = " + hash.ToString());
                }
            }
            builder.AppendLine("}");

            foreach (string line in GetVerbs(vocabulary))
            {
                builder.AppendLine(line);
            }
            builder.AppendLine("}");
            builder.AppendLine("}");

            System.IO.File.WriteAllText(verbsFileName, builder.ToString());
        }

        public static void WriteQuantitiesAndUnits(string quantitiesFileName, string unitsFileName)
        {
            List<string> quantities = new List<string>();
            List<string> units = new List<string>();
            if (BasePhysicalQuantity.AvailableBasePhysicalQuantities != null)
            {
                foreach (BasePhysicalQuantity quantity in BasePhysicalQuantity.AvailableBasePhysicalQuantities)
                {
                    if (quantity != null && !string.IsNullOrEmpty(quantity.GetType()?.Name))
                    {
                        string name = quantity.GetType()!.Name;
                        if (!quantities.Contains(name))
                        {
                            quantities.Add(name);
                            if (quantity.UnitChoices != null)
                            {
                                foreach (UnitChoice choice in quantity.UnitChoices)
                                {
                                    if (choice != null)
                                    {
                                        string unitName = choice.GetVariableName();
                                        if (!string.IsNullOrEmpty(unitName) && !units.Contains(unitName))
                                        {
                                            units.Add(unitName);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (PhysicalQuantity.AvailablePhysicalQuantities != null)
            {
                foreach (BasePhysicalQuantity quantity in PhysicalQuantity.AvailablePhysicalQuantities)
                {
                    if (quantity != null && !string.IsNullOrEmpty(quantity.GetType()?.Name))
                    {
                        string name = quantity.GetType()!.Name;
                        if (!quantities.Contains(name))
                        {
                            quantities.Add(name);
                            if (quantity.UnitChoices != null)
                            {
                                foreach (UnitChoice choice in quantity.UnitChoices)
                                {
                                    if (choice != null)
                                    {
                                        string unitName = choice.GetVariableName();
                                        if (!string.IsNullOrEmpty(unitName) && !units.Contains(unitName))
                                        {
                                            units.Add(unitName);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (quantities.Count > 0)
            {
                StringBuilder builder = new StringBuilder();

                builder.AppendLine("using System;");
                builder.AppendLine("namespace DWIS.Vocabulary.Schemas");
                builder.AppendLine("{");
                builder.AppendLine("public static class Quantities");
                builder.AppendLine("{");
                builder.AppendLine("public enum Enum");
                builder.AppendLine("{");
                foreach (string quantity in quantities)
                {
                    int hash = quantity.GetHashCode();
                    if (quantity != quantities.Last())
                    {
                        builder.AppendLine(quantity + " = " + hash.ToString() + ",");
                    }
                    else
                    {
                        builder.AppendLine(quantity + " = " + hash.ToString());
                    }
                }
                builder.AppendLine("}");
                foreach (string quantity in quantities)
                {
                    builder.AppendLine("public static string " + quantity + " = \"" + quantity + "\";");
                }
                builder.AppendLine("}");
                builder.AppendLine("}");

                System.IO.File.WriteAllText(quantitiesFileName, builder.ToString());
            }
            if (units.Count > 0)
            {
                StringBuilder builder = new StringBuilder();

                builder.AppendLine("using System;");
                builder.AppendLine("namespace DWIS.Vocabulary.Schemas");
                builder.AppendLine("{");
                builder.AppendLine("public static class Units");
                builder.AppendLine("{");
                builder.AppendLine("public enum Enum");
                builder.AppendLine("{");
                foreach (string unit in units)
                {
                    int hash = unit.GetHashCode();
                    if (unit != units.Last())
                    {
                        builder.AppendLine(unit + " = " + hash.ToString() + ",");
                    }
                    else
                    {
                        builder.AppendLine(unit + " = " + hash.ToString());
                    }
                }
                builder.AppendLine("}");
                foreach (string unit in units)
                {
                    builder.AppendLine("public static string " + unit + " = \"" + unit + "\";");
                }
                builder.AppendLine("}");
                builder.AppendLine("}");

                System.IO.File.WriteAllText(unitsFileName, builder.ToString());
            }
        }

        public static IEnumerable<string> GetVerbs(Development.Vocabulary vocabulary)
        {
            return vocabulary.Verbs.Select(n => GetSchema(n));
        }

        private static string GetSchema(Development.Noun noun)
        {
            return $"\tpublic static string {noun.Name} = \"{noun.Name}\";";
        }

        private static IList<string> GetAttributesSchema(Noun noun, Development.Vocabulary vocabulary)
        {
            if (noun.NounAttributes != null)
            {
                var parent = vocabulary.Nouns.Find(n => n.Name == noun.ParentNounName);
                List<string> result = new List<string>();
                foreach (var att in noun.NounAttributes)
                {
                    bool proceed = true;
                    if (parent != null && parent.NounAttributes != null && parent.NounAttributes.FirstOrDefault(na => na.Name == att.Name) != null)
                    {
                        proceed = false;
                    }

                    if (proceed)
                    {
                        result.Add($"\tpublic static string {noun.Name}_{att.Name} = \"{att.Name}\";");
                        result.Add($"\tpublic static string {noun.Name}_{att.Name}_Type = \"{att.Type}\";");
                    }
                }
                return result;
            }
            return null;
        }

        private static string GetSchema(Development.Verb verb)
        {
            return $"\tpublic static string {verb.Name} = \"{verb.Name}\";";
        }
    }
}
