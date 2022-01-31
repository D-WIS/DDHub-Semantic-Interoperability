namespace DWISVocabularyDevelopment
{
    public class IndividualAttribute
    {
        public IndividualAttribute(string attributeName)
        {
            AttributeName = attributeName;
        }
        public IndividualAttribute(NounAttribute nounAttribute) : this(nounAttribute.Name)
        {
        }
        public string AttributeName { get; private set; }
        public string AttributeValue { get; set; }
    }
}
