using System.Text;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public class EditableNoun
    { 
    public Noun StoredNoun { get; set; }
        public Noun EditedNoun { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; }
        public string SHA { get; set; }
        public string GetEditedCode()
        {
            StringBuilder stringBuilder = new StringBuilder();
            DWIS.Vocabulary.Utils.MDWriting.NounToMD(stringBuilder, EditedNoun);
            return stringBuilder.ToString();
        }

    }

    public class EditableVerb
    {
        public Verb StoredVerb { get; set; }
        public Verb EditedVerb { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; }
        public string SHA { get; set; }
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

            DWIS.Vocabulary.Utils.VocabularyParsing.FromMDFileContents(
                fileContents.Split("\n", StringSplitOptions.RemoveEmptyEntries), 
                path, 
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
