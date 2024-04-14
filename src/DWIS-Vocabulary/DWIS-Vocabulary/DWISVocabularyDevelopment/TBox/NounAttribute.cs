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
            return other!=null && Type == other.Type && Name == other.Name && Description == other.Description && DisplayName == other.DisplayName;
        }
    }
}
