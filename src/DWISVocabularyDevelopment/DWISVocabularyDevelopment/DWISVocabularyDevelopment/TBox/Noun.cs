using System;
using System.Linq;

namespace DWIS.Vocabulary.Development
{
    public class Noun : IEquatable<Noun>, IComparable<Noun>
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
            return Equals(obj as Noun);
        }

        public bool Equals(Noun other)
        {
            if (other == null) return false;
            if (Name != other.Name) return false;
            if(DisplayName != other.DisplayName) return false;
            if(ParentNounName != other.ParentNounName) return false;
            if(Description != other.Description) return false;
            //if(DefinitionSetName != other.DefinitionSetName) return false;

            if (NounAttributes == null && other.NounAttributes != null) return false;
            if (other.NounAttributes == null && NounAttributes != null) return false;
            if (NounAttributes != null)
            {
                if (NounAttributes.Length != other.NounAttributes.Length) return false;
                for (int i = 0; i < NounAttributes.Length; i++)
                {
                    if (!other.NounAttributes.Contains(NounAttributes[i])) return false;
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


            return true;
        }

        public int CompareTo(Noun other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}
