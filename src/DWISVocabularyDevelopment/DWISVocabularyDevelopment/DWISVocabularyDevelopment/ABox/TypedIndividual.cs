using System.Linq;

namespace DWIS.Vocabulary.Development
{
    public class TypedIndividual : Individual
    {
        public string TypeName { get; set; }
        protected TypedIndividual() : base() { }

        public TypedIndividual(string name, string typeName, DWISVocabulary vocabulary) : this(name, vocabulary.Nouns.Find(n => n.Name == typeName))
        {
        }

        public TypedIndividual(string name, Noun noun) : base(name)
        {
            TypeName = noun.Name;
            if (noun.NounAttributes != null)
            {
                Attributes = noun.NounAttributes.Select(na => new IndividualAttribute(na)).ToArray();
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
