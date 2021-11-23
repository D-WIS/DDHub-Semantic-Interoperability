using System;
using System.Collections;

namespace DWISVocabularyDevelopment
{
    public class Noun
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentNounName { get; set; }
        public Attribute[] Attributes { get; set; }
        public string Description { get; set; }
        public string Examples { get; set; }
        public string DefinitionFileNameWithoutExtension { get; set; }

        public string ToMDSnippet()
        {
            return string.Empty;
        }

        public bool FromMDSnippet()
        {
            return false;
        }
    
    
    }

    public class Attribute
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class SpecializedAttribute
    {
        public string AttributeName { get; set; }
        public string SpecializedValue { get; set; }
    }
}
