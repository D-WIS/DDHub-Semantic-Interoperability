using System;

namespace DWIS.Vocabulary.Development
{
    public class SpecializedNounAttribute : IEquatable<SpecializedNounAttribute>
    {
        public string AttributeName { get; set; }
        public string SpecializedValue { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SpecializedNounAttribute);
        }

        public bool Equals(SpecializedNounAttribute other)
        {
           return other!=null && AttributeName == other.AttributeName && SpecializedValue == other.SpecializedValue;   
        }
    }
}
