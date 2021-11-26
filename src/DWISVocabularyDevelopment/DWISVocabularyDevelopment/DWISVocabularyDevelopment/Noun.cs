using System;

namespace DWISVocabularyDevelopment
{
    public class Noun
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentNounName { get; set; }
        public NounAttribute[] NounAttributes { get; set; }
        public SpecializedNounAttribute[] SpecializedNounAttributes { get; set; }
        public string Description { get; set; }
        public string Examples { get; set; }
        public string DefinitionSetName { get; set; }

        public string ToMDSnippet()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            return obj != null && obj is Noun && ((Noun)obj).Name == Name;
        }
    }
}
