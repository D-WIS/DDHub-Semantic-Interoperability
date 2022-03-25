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


        public static void WriteSchema(Development.Vocabulary vocabulary, string nounsFileName, string verbsFileName)
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

        private static string GetSchema(Development.Verb verb)
        {
            return $"\tpublic static string {verb.Name} = \"{verb.Name}\";";
        }
    }
}
