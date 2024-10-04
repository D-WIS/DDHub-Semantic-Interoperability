using System.Collections.Generic;
using System.Linq;

namespace DWIS.Vocabulary.Development
{
    public class TypedIndividual : Individual
    {
        public string TypeName { get; set; }
        protected TypedIndividual() : base() { }

        public TypedIndividual(string name, string typeName, DWISVocabulary vocabulary) : this(name, vocabulary.Nouns.Find(n => n.Name == typeName) ,vocabulary)
        {
        }

        public TypedIndividual(string name, Noun noun, DWISVocabulary vocabulary) : base(name)
        {
            TypeName = noun.Name;

            var attributes = noun.GetAllAttributes(vocabulary);       

            if (attributes.Any())
            {
                Attributes = attributes.Select(na => new IndividualAttribute(na)).ToArray();
            }
        }

        public IndividualAttribute[] Attributes { get; private set; }

        public bool GetAttribute(string attributeName, out IndividualAttribute attribute)
        {
            if (Attributes == null) { attribute = null; return false; }
            else
            {
                attribute = Attributes.FirstOrDefault(a => a.AttributeName == attributeName);
                return attribute != null;
            }
        }
    }
}
