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
            if (other == null) return false;
            if (Name != other.Name) return false;
            if (DisplayName != other.DisplayName) return false;
            if (ParentVerbName != other.ParentVerbName) return false;
            if (DomainNounName != other.DomainNounName) return false;
            if (RangeNounName != other.RangeNounName) return false;
            if (DefinitionSetName  != other.DefinitionSetName) return false;
            if (MinCardinality != other.MinCardinality) return false;
            if (MaxCardinality != other.MinCardinality) return false;
            if (IsDeprecated != other.IsDeprecated) return false;
            if (WillBeRemovedBy != other.WillBeRemovedBy) return false;
            if (WillBeRemovedFromVersion != other.WillBeRemovedFromVersion) return false;
            if (ReplacedBy != other.ReplacedBy) return false;
            if ((Description == null || Description.Length == 0) && other.Description != null && other.Description.Length > 0) return false;
            if (Description != null && Description.Length > 0 && (other.Description == null || other.Description.Length == 0)) return false;
            if (Description != null && other.Description != null)
            {
                if (Description.Length != other.Description.Length) return false;
                for (int i = 0; i < Description.Length; i++)
                {
                    if (!Description[i].Equals(other.Description[i])) return false;
                }
            }
            if (Examples != null && other.Examples != null)
            {
                if (Examples.Length > other.Examples.Length) return false;
                for (int i = 0; i < Examples.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < other.Examples.Length; j++)
                    {
                        if (Examples[i].Equals(other.Examples[j]))
                        { 
                            found = true;
                            break;
                        }
                    }
                    if (!found) return false;
                }
            }
            return true;
        }

        public int CompareTo(Verb other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}
