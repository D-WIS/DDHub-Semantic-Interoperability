namespace DWIS.Vocabulary.Development.Actions
{
    public class ActionPaths
    {
        public string VocabularySourceFolder { get; private set; }
        public string ExamplesSourceFolder { get; private set; }
        public static string SingleFileName { get; set; } = "DWISVocabulary";
        public static string DefinitionFilesFolderName { get; set; } = "definition-files";
        public static string ExamplesFilesFolderName { get; set; } = "examples";

        public static string RDFFolderName { get; set; } = "rdf";
        public static string MDFolderName { get; set; } = "md";
        public static string JsonFolderName { get; set; } = "json";
        public static string CSVFolderName { get; set; } = "csv";

        public string NounsSchemaPath { get; set; }
        public string VerbsSchemaPath { get; set; }


        public string MDFolderPath { get; private set; }
        public string SingleMDFilePath { get; private set; }
        public string SingleJsonFilePath { get; private set; }
        public string StandardJsonFilePath { get; private set; }
        public string DefinitionFilesFolderPath { get; private set; }
        public string ExamplesFilesFolderPath { get; private set; }
        public string RDFFolderPath { get; private set; }
        public string OntologyFilePath { get; private set; }
        public string AttributesSchemaPath { get; private set; }
        public string CSVFilePath { get; private set; }

        public ActionPaths(string sourceFolder, string destinationFolder, string schemasFolder, string examplesSourceFolder, string standardResourceFolder)
        {
            char sep = System.IO.Path.DirectorySeparatorChar;
            string mdExtension = ".md";
            string jsonExtension = ".json";
            string csvExtension = ".csv";

            VocabularySourceFolder = sourceFolder;
            ExamplesSourceFolder = examplesSourceFolder;

            MDFolderPath = destinationFolder + sep + MDFolderName;
            SingleMDFilePath = MDFolderPath + sep + SingleFileName + mdExtension;
            DefinitionFilesFolderPath = MDFolderPath + sep + DefinitionFilesFolderName;

            ExamplesFilesFolderPath = MDFolderPath + sep + ExamplesFilesFolderName;

            RDFFolderPath = destinationFolder + sep + RDFFolderName;
            OntologyFilePath = RDFFolderPath + sep + SingleFileName;

            SingleJsonFilePath = destinationFolder + sep + JsonFolderName + sep + SingleFileName + jsonExtension;
            StandardJsonFilePath = standardResourceFolder + sep + SingleFileName + jsonExtension;

            CSVFilePath = destinationFolder + sep + CSVFolderName + sep + SingleFileName + csvExtension;


            NounsSchemaPath = schemasFolder + sep + "Nouns.cs";
            VerbsSchemaPath = schemasFolder + sep + "Verbs.cs";
            AttributesSchemaPath = schemasFolder + sep + "Attributes.cs";
        }

    }

}
