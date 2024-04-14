using System;

namespace DWIS.Vocabulary.Development
{
    public class Verb : IEquatable<Verb>, IComparable<Verb>
    {
        public string Name { get; set; } = null;
        public string DisplayName { get; set; } = null;
        public string ParentVerbName { get; set; } = null;
        public string DomainNounName { get; set; } = null;
        public string RangeNounName { get; set; } = null;
        public int MinCardinality { get; set; } = -1;
        public int MaxCardinality { get; set; } = -1;
        public string[] Description { get; set; } = null;
        public string[] Examples { get; set; } = null;
        public string DefinitionSetName { get; set; } = null;
        public bool IsDeprecated { get; set; } = false;
        public DateTime WillBeRemovedBy { get; set; } = DateTime.MinValue;
        public string WillBeRemovedFromVersion { get; set; } = null;
        public string ReplacedBy { get; set; } = null;

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
            IsDeprecated = other.IsDeprecated;
            WillBeRemovedBy = other.WillBeRemovedBy;
            WillBeRemovedFromVersion = other.WillBeRemovedFromVersion;
            ReplacedBy = other.ReplacedBy;
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
                 && MaxCardinality == other.MaxCardinality
                 && IsDeprecated == other.IsDeprecated
                 && WillBeRemovedBy == other.WillBeRemovedBy
                 && WillBeRemovedFromVersion == other.WillBeRemovedFromVersion
                 && ReplacedBy == other.ReplacedBy;
        }

        public int CompareTo(Verb other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}
