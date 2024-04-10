using System;

namespace DWIS.Vocabulary.Development
{
    public class Verb : IEquatable<Verb>, IComparable<Verb>
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentVerbName { get; set; }
        public string DomainNounName { get; set; }
        public string RangeNounName { get; set; }
        public int MinCardinality { get; set; } = -1;
        public int MaxCardinality { get; set; } = -1;
        public string Description { get;  set; }
        public string[] Examples { get; set; }
        public string DefinitionSetName { get; set; }

        public Verb() { }

        public Verb(Verb other)
        { 
        Name = other.Name;
            DisplayName = other.DisplayName;
            ParentVerbName = other.ParentVerbName;
            DomainNounName = other.DomainNounName;
            RangeNounName = other.RangeNounName;
            Description = other.Description;
            Examples = other.Examples;
            DefinitionSetName = other.DefinitionSetName;
            MinCardinality = other.MinCardinality;
            MaxCardinality = other.MaxCardinality;
        }



        public override string ToString()
        {
            return Name;
        }


        public override bool Equals(object obj)
        {
            return obj != null && obj is Verb && ((Verb)obj).Name == Name;
        }

        public bool Equals(Verb other)
        {
           return other != null 
                && Name == other.Name 
                && DisplayName == other.DisplayName 
                && ParentVerbName == other.ParentVerbName 
                && DomainNounName == other.DomainNounName
                && RangeNounName == other.RangeNounName
                && Description == other.Description
                && Examples == other.Examples
                && DefinitionSetName == other.DefinitionSetName
                && MinCardinality == other.MinCardinality
                && MaxCardinality == other.MaxCardinality;
        }

        public int CompareTo(Verb other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}
