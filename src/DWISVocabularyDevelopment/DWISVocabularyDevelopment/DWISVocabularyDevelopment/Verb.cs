namespace DWISVocabularyDevelopment
{
    public class Verb
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentVerbName { get; set; }
        public string DomainNounName { get; set; }
        public string RangeNounName { get; set; }
        public int MinCardinality { get; set; } = -1;
        public int MaxCardinality { get; set; } = -1;
        public string Description { get;  set; }
        public string Examples { get; set; }
        public string DefinitionSetName { get; set; }

        public override string ToString()
        {
            return Name;
        }


        public override bool Equals(object obj)
        {
            return obj != null && obj is Verb && ((Verb)obj).Name == Name;
        }

    }
}
