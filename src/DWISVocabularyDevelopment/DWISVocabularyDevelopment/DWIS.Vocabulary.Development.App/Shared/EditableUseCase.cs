using System.Text;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public class EditableNoun : Noun
    { 
        public Noun EditedNoun { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; } = false;
        public string SHA { get; set; }

        public EditableNoun(Noun baseNoun, string path, string sha) : base(baseNoun)
        {
            EditedNoun = new Noun(baseNoun);
            Path = path;
            SHA = sha;
        }


        public string GetEditedCode()
        {
            StringBuilder stringBuilder = new StringBuilder();
            DWIS.Vocabulary.Utils.MDWriting.NounToMD(stringBuilder, EditedNoun);
            return stringBuilder.ToString();
        }

    }

    public class EditableVerb : Verb
    {
        public Verb EditedVerb { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; } = false;
        public string SHA { get; set; }

        public EditableVerb(Verb baseVerb, string path, string sha) : base(baseVerb)
        {
            EditedVerb = new Verb(baseVerb);
            Path = path;
            SHA = sha;
        }


        public string GetEditedCode()
        {
            StringBuilder stringBuilder = new StringBuilder();
            DWIS.Vocabulary.Utils.MDWriting.VerbToMD(stringBuilder, EditedVerb);
            return stringBuilder.ToString();
        }
    }

    public class EditableUseCase
    {
        public DWISInstance StoredInstance { get; set; }
        public DWISInstance EditedInstance { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; }
        public string SHA { get; set; }

        public EditableUseCase ( DWISInstance editedInstance, string path, bool edited, string sHA)
        {
            EditedInstance = editedInstance;
            Path = path;
            Edited = edited;
            SHA = sHA;
        }   

        public EditableUseCase(string fileContents, string path, string sha)
        {
            Path = path;
            SHA = sha;
            if (fileContents.Contains("```"))
            {
                int idx = fileContents.IndexOf("```");
                fileContents = fileContents.Remove(idx, fileContents.Length - idx);
            }

            string instanceName = path;
            int idx2 = instanceName.LastIndexOf('/');
            if (idx2 >= 0 && idx2 < instanceName.Length - 1)
            {
                instanceName = instanceName.Substring(idx2 + 1);
            }
            if (instanceName.EndsWith(".md")) 
            {
                idx2 = instanceName.LastIndexOf('.');
                instanceName = instanceName.Substring(0, idx2);
            }

            DWIS.Vocabulary.Utils.VocabularyParsing.FromMDFileContents(
                fileContents.Split("\n", StringSplitOptions.RemoveEmptyEntries), 
                instanceName, 
                DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary, 
                out DWISInstance inst);
            StoredInstance = inst;
            EditedInstance = new DWISInstance(StoredInstance);
        }

        public string GetEditedCode()
        {
            return DWIS.Vocabulary.Utils.MDWriting.ToString(EditedInstance, DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary, false, false);
        }
    }
}
