namespace DWIS.Vocabulary.Development.Actions
{
    public class ActionsConfig
    {
        public string SourceFolder { get; set; }
        public string DestinationFolder { get; set; }
        public string SchemaFolder { get; set; }
        public string ExamplesSourceFolder { get; set; }
        public string StandardResourceFolder { get; set; }

        public string ProjectsToPack { get; set; }
        public int PackVersion { get; set; }
        public string PackageOutputFolder { get; set; }
        public bool IncrementVersion { get; set; }
    }

}
