using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DWIS.Vocabulary.Development;

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

        public static void WriteSchema(Development.Vocabulary vocabulary, string nounsFileName, string verbsFileName, string attributesFileName)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("namespace DWIS.Vocabulary.Schemas");
            builder.AppendLine("{");
            builder.AppendLine("public static class Nouns");
            builder.AppendLine("{");
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
            foreach (string line in GetVerbs(vocabulary))
            {
                builder.AppendLine(line);
            }
            builder.AppendLine("}");
            builder.AppendLine("}");

            System.IO.File.WriteAllText(verbsFileName, builder.ToString());
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
