using System;

namespace DWIS.Vocabulary.Development
{
    public class NounAttribute : IEquatable<NounAttribute>
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string[] Description { get; set; }

        public NounAttribute() { }
        public NounAttribute(NounAttribute other)
        { 
        Type = other.Type;
            Name = other.Name;  
            DisplayName = other.DisplayName;
            Description = other.Description;
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as NounAttribute);
        }

        public bool Equals(NounAttribute other)
        {
            if ((other == null)) return false;
            if (Type != other.Type) return false;
            if (Name != other.Name) return false;
            if (DisplayName != other.DisplayName) return false;
            if ((Description == null || Description.Length == 0) && other.Description != null && other.Description.Length > 0) return false;
            if (Description != null && Description.Length > 0 && (other.Description == null || other.Description.Length == 0)) return false;
            if (Description != null && other.Description != null)
            {
                if (Description.Length != other.Description.Length) return false;
                for (int i = 0; i < Description.Length; i++)
                {
                    if (Description[i] != other.Description[i]) return false;
                }
            }
            return true;
        }
    }
}
