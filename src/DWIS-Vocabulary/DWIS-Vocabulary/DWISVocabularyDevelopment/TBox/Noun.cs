using System;
using System.Linq;
using System.Security.Principal;

namespace DWIS.Vocabulary.Development
{
    public class Noun : IEquatable<Noun>, IComparable<Noun>
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentNounName { get; set; }
        public NounAttribute[] NounAttributes { get; set; }
        public SpecializedNounAttribute[] SpecializedNounAttributes { get; set; }
        public string[] Description { get; set; }
        public string[] Examples { get; set; }
        public string DefinitionSetName { get; set; }
        public bool IsDeprecated { get; set; } = false;
        public DateTime WillBeRemovedBy { get; set; } = DateTime.MinValue;
        public string WillBeRemovedFromVersion { get; set; } = null;
        public string ReplacedBy { get; set; } = null;

        public Noun()
        { }

        public Noun(Noun other)
        {
            Name = other.Name;
            DisplayName = other.DisplayName;
            ParentNounName = other.ParentNounName;
            NounAttributes =other.NounAttributes != null ? other.NounAttributes.Select(na => new NounAttribute(na)).ToArray() : null;
            SpecializedNounAttributes = other.SpecializedNounAttributes != null ? other.SpecializedNounAttributes.Select(na => new SpecializedNounAttribute(na)).ToArray() : null;
            Description = other.Description;
            Examples = other.Examples;
            DefinitionSetName = other.DefinitionSetName;
            IsDeprecated = other.IsDeprecated;
            WillBeRemovedBy = other.WillBeRemovedBy;
            WillBeRemovedFromVersion = other.WillBeRemovedFromVersion;
            ReplacedBy = other.ReplacedBy;
        }


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
            return Equals(obj as Noun);
        }

        public bool Equals(Noun other)
        {
            if (other == null) return false;
            if (Name != other.Name) return false;
            if(DisplayName != other.DisplayName) return false;
            if(ParentNounName != other.ParentNounName) return false;
            if ((Description == null || Description.Length == 0) && (other.Description != null && other.Description.Length > 0)) return false;
            if ((Description != null && Description.Length > 0) && (other.Description == null || other.Description.Length == 0)) return false;
            if (Description != null && other.Description != null)
            {
                if (Description.Length != other.Description.Length) return false;
                for (int i = 0; i < Description.Length; i++)
                {
                    if (Description[i] != other.Description[i]) return false;
                }
            }
            //if(DefinitionSetName != other.DefinitionSetName) return false;

            if (NounAttributes == null && other.NounAttributes != null) return false;
            if (other.NounAttributes == null && NounAttributes != null) return false;
            if (NounAttributes != null)
            {
                if (NounAttributes.Length != other.NounAttributes.Length) return false;
                for (int i = 0; i < NounAttributes.Length; i++)
                {
                    bool contained = false; 
                    for (int j = 0; j  < other.NounAttributes.Length; j++)
                    {
                        if (NounAttributes[i].Equals(other.NounAttributes[j]))
                        {
                            contained = true;
                            break;
                        }
                    }
                    if (!contained) return false;
                }
            }

            if (SpecializedNounAttributes == null && other.SpecializedNounAttributes != null) return false;
            if (other.SpecializedNounAttributes == null && SpecializedNounAttributes != null) return false;
            if (SpecializedNounAttributes != null)
            {
                if (SpecializedNounAttributes.Length != other.SpecializedNounAttributes.Length) return false;
                for (int i = 0; i < SpecializedNounAttributes.Length; i++)
                {
                    if (!other.SpecializedNounAttributes.Contains(SpecializedNounAttributes[i])) return false;
                }
            }
            if (IsDeprecated != other.IsDeprecated) return false;
            if (WillBeRemovedBy != other.WillBeRemovedBy) return false;
            if (WillBeRemovedFromVersion != other.WillBeRemovedFromVersion) return false;
            if (ReplacedBy != other.ReplacedBy) return false;

            return true;
        }

        public int CompareTo(Noun other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}
