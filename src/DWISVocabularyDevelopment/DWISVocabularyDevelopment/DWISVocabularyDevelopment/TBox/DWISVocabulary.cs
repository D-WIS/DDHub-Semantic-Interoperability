using System;
using System.Collections.Generic;
using System.Text;

namespace DWIS.Vocabulary.Development
{
    public class DWISVocabulary : Vocabulary, IEquatable<DWISVocabulary>
    {
        public IList<DefinitionSetHeader> DefinitionSetHeaders { get; set; } = new List<DefinitionSetHeader>();

        public static string ToJsonString(DWISVocabulary vocabulary)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(vocabulary);
        }
        public static void ToJsonFile(string fileName, DWISVocabulary vocabulary)
        {
            System.IO.File.WriteAllText(fileName, ToJsonString(vocabulary));
        }

        public static DWISVocabulary FromJsonString(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DWISVocabulary>(json);
        }

        public static DWISVocabulary FromJsonFile(string fileName)
        {
            return FromJsonString(System.IO.File.ReadAllText(fileName));
        }

        public bool Equals(DWISVocabulary other)
        {
            return base.Equals((Vocabulary)other);
        }
    }
}
