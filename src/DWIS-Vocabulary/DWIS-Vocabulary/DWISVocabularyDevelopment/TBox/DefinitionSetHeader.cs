namespace DWIS.Vocabulary.Development
{
    public class DefinitionSetHeader
    {
        public string Name { get; set; } = null;
        public string[] SetDescription { get; set; } = null;

        public override string ToString()
        {
            return Name;
        }
    }
}
