using System.Collections.Generic;
using System.Linq;
using System.Text;
using DWIS.Vocabulary.Development;

namespace DWIS.Vocabulary.Utils
{
    public static class VocabularyParsing
    {

        public static string VERB_TAG = "<!-- VERB -->";
        public static string NOUN_TAG = "<!-- NOUN -->";

        private static List<string[]> SplitSnippet(string[] snippet, string indent)
        {
            List<string[]> result = new List<string[]>();
            List<string> current = new List<string>();
            for (int i = 0; i < snippet.Length; i++)
            {
                if (!string.IsNullOrEmpty(snippet[i]))
                {
                    if (snippet[i].StartsWith(indent))
                    {
                        if (current.Count > 0)
                        {
                            result.Add(current.ToArray());
                            current.Clear();
                        }
                    }
                    current.Add(snippet[i]);
                }
            }
            if (current.Count > 0)
            {
                result.Add(current.ToArray());
            }
            return result;
        }

        private static List<string[]> SplitSnippet(string[] snippet, char indent = '-')
        {
            List<string[]> result = new List<string[]>();
            List<string> current = new List<string>();
            for (int i = 0; i < snippet.Length; i++)
            {
                if (!string.IsNullOrEmpty(snippet[i]))
                {
                    if (snippet[i][0] == indent)
                    {
                        if (current.Count > 0)
                        {
                            result.Add(current.ToArray());
                            current.Clear();
                        }
                    }
                    current.Add(snippet[i]);
                }
            }
            if (current.Count > 0)
            {
                result.Add(current.ToArray());
            }
            return result;
        }

        private static bool FromMDSnippet(string[] allSnippetLines, out Noun noun)
        {
            noun = null;
            if (allSnippetLines != null && allSnippetLines.Length > 0)
            {
                noun = new Noun();
                string header = allSnippetLines[0];
                if (header.StartsWith("##") && header.EndsWith(NOUN_TAG))
                {
                    header = header.Remove(header.Length - NOUN_TAG.Length).Remove(0, "##".Length).Trim().TrimEnd();

                    noun.Name = header;

                    string[] tail = allSnippetLines.Skip(1).ToArray();
                    List<string[]> snippetItems = SplitSnippet(tail);

                    foreach (string[] snippetItem in snippetItems)
                    {
                        UpdateFromSnippetItem(snippetItem, noun);
                    }

                    if (noun.Name != "DWISNoun" && string.IsNullOrEmpty(noun.ParentNounName))
                    {
                        noun.ParentNounName = "DWISNoun";
                    }
                    else if (noun.ParentNounName.Contains("["))//it is a link...
                    {
                        noun.ParentNounName = noun.ParentNounName.Split(new char[] { '[', ']' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    }

                    return true;
                }
            }
            return false;
        }

        private static bool UpdateFromSnippetItem(string[] snippetItem, Noun noun)
        {
            string header = snippetItem[0];
            if (header.StartsWith("- Display name:"))
            {
                noun.DisplayName = header.Remove(0, "- Display name: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Parent class:"))
            {
                noun.ParentNounName = header.Remove(0, "- Parent class: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Description:"))
            {
                noun.Description = header.Remove(0, "- Description: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("Examples:"))
            {
                noun.Examples = header.Remove(0, "- Examples: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Attributes:"))
            {
                var attributes = SplitSnippet(snippetItem.Skip(1).ToArray(), "  -");
                foreach (var att in attributes)
                {
                    string attributeName = string.Empty;
                    string description = string.Empty;
                    string dataType = string.Empty;
                    foreach (string l in att)
                    {
                        if (l.StartsWith("  - "))
                        {
                            attributeName = l.Remove(0, "  - ".Length).Trim().TrimEnd();
                        }
                        else if (l.StartsWith("    - Description:"))
                        {
                            description = l.Remove(0, "    - Description:".Length).Trim().TrimEnd();
                        }
                        else if (l.StartsWith("    - Type:"))
                        {
                            dataType = l.Remove(0, "    - Type:".Length).Trim().TrimEnd();
                        }
                    }
                    if (!string.IsNullOrEmpty(attributeName) && !string.IsNullOrEmpty(dataType))
                    {
                        NounAttribute nounAttribute = new NounAttribute() { Name = attributeName, Type = dataType, Description = description };

                        if (noun.NounAttributes == null)
                        {
                            noun.NounAttributes = new NounAttribute[1] { nounAttribute };
                        }
                        else
                        {
                            var temp = noun.NounAttributes.ToList();
                            temp.Add(nounAttribute);
                            noun.NounAttributes = temp.ToArray();
                        }
                    }
                }
            }
            else if (header.StartsWith("- Specialization:"))
            {
                var attributesSpecialization = SplitSnippet(snippetItem.Skip(1).ToArray(), "  -");
                foreach (var att in attributesSpecialization)
                {
                    string attributeName = string.Empty;
                    string attributeValue = string.Empty;
                    foreach (string l in att)
                    {
                        if (l.StartsWith("  - "))
                        {
                            string[] elems = l.Remove(0, "  - ".Length).Trim().TrimEnd().Split('=');
                            attributeName = elems[0].Trim().TrimEnd();
                            attributeValue = elems[1].Trim().TrimEnd();
                        }
                    }
                    if (!string.IsNullOrEmpty(attributeName) && !string.IsNullOrEmpty(attributeValue))
                    {
                        SpecializedNounAttribute specializedNounAttribute = new SpecializedNounAttribute() { AttributeName = attributeName, SpecializedValue = attributeValue };

                        if (noun.SpecializedNounAttributes == null)
                        {
                            noun.SpecializedNounAttributes = new SpecializedNounAttribute[1] { specializedNounAttribute };
                        }
                        else
                        {
                            var temp = noun.SpecializedNounAttributes.ToList();
                            temp.Add(specializedNounAttribute);
                            noun.SpecializedNounAttributes = temp.ToArray();
                        }
                    }
                }
            }
            return false;
        }
        private static bool UpdateFromSnippetItem(string[] snippetItem, Verb verb)
        {
            string header = snippetItem[0];
            if (header.StartsWith("- Display name:"))
            {
                verb.DisplayName = header.Remove(0, "- Display name: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Parent verb:"))
            {
                verb.ParentVerbName = header.Remove(0, "- Parent verb: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Description:"))
            {
                verb.Description = header.Remove(0, "- Description: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Examples:"))
            {
                verb.Examples = header.Remove(0, "- Examples: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Subject class:"))
            {
                verb.DomainNounName = header.Remove(0, "- Subject class: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Object class:"))
            {
                verb.RangeNounName = header.Remove(0, "- Object class: ".Length).Trim().TrimEnd();
            }
            else if (header.StartsWith("- Min cardinality:"))
            {
                string card = header.Remove(0, "- Min cardinality: ".Length).Trim().TrimEnd();
                if (int.TryParse(card, out int temp))
                {
                    verb.MinCardinality = temp;
                }
            }
            else if (header.StartsWith("- Max cardinality:"))
            {
                string card = header.Remove(0, "- Max cardinality: ".Length).Trim().TrimEnd();
                if (int.TryParse(card, out int temp))
                {
                    verb.MaxCardinality = temp;
                }
            }
            return true;
        }

        private static void ExtractSnippets(string[] fileLines, out List<string[]> allSnippets)
        {
            allSnippets = new List<string[]>();
            List<string> current = new List<string>();
            bool ignore = false;
            for (int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i].StartsWith("##"))
                {
                    allSnippets.Add(current.ToArray());
                    current.Clear();
                    ignore = false;
                }
                else if (fileLines[i].StartsWith("#"))
                {
                    ignore = true;
                }
                if (!ignore)
                {
                    current.Add(fileLines[i]);
                }
            }
            if (current.Count > 0)
            {
                allSnippets.Add(current.ToArray());
            }
        }



        private static bool FromMDSnippet(string[] allSnippetLines, out Verb verb)
        {
            verb = null;
            if (allSnippetLines != null && allSnippetLines.Length > 0)
            {
                verb = new Verb();
                string header = allSnippetLines[0];
                if (header.StartsWith("##") && header.EndsWith(VERB_TAG))
                {
                    header = header.Remove(header.Length - VERB_TAG.Length).Remove(0, "##".Length).Trim().TrimEnd();

                    verb.Name = header;

                    string[] tail = allSnippetLines.Skip(1).ToArray();
                    List<string[]> snippetItems = SplitSnippet(tail);

                    foreach (string[] snippetItem in snippetItems)
                    {
                        UpdateFromSnippetItem(snippetItem, verb);
                    }

                    if (verb.Name != "DWISVerb" && string.IsNullOrEmpty(verb.ParentVerbName))
                    {
                        verb.ParentVerbName = "DWISVerb";
                    }
                    else if (verb.ParentVerbName.Contains("["))//it is a link...
                    {
                        verb.ParentVerbName = verb.ParentVerbName.Split(new char[] { '[', ']' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    }
                    if (string.IsNullOrEmpty(verb.DomainNounName))
                    {
                        verb.DomainNounName = "DWISNoun";
                    }
                    else if (verb.DomainNounName.Contains("["))//it is a link...
                    {
                        verb.DomainNounName = verb.DomainNounName.Split(new char[] { '[', ']' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    }
                    if (string.IsNullOrEmpty(verb.RangeNounName))
                    {
                        verb.RangeNounName = "DWISNoun";
                    }
                    else if (verb.RangeNounName.Contains("["))//it is a link...
                    {
                        verb.RangeNounName = verb.RangeNounName.Split(new char[] { '[', ']' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    }
                    return true;
                }
            }
            return false;
        }

        private static bool FromMDLines(string[] allLines, out DefinitionSet definitionSet)
        {
            definitionSet = null;
            ExtractSnippets(allLines, out System.Collections.Generic.List<string[]> allSnippets);

            if (allSnippets != null && allSnippets.Count > 0)
            {
                definitionSet = new DefinitionSet();
                foreach (var snippet in allSnippets)
                {
                    if (snippet != null && snippet.Length > 0 && snippet[0].StartsWith("- Name: "))
                    {
                        definitionSet.Name = snippet[0].Remove(0, "- Name: ".Length).Trim().TrimEnd();

                    }
                    else if (snippet != null && snippet.Length > 0 && snippet[0].StartsWith("- Description: "))
                    {
                        definitionSet.SetDescription = snippet[0].Remove(0, "- Description: ".Length).Trim().TrimEnd();
                    }
                    if (VocabularyParsing.FromMDSnippet(snippet, out Noun noun))
                    {
                        definitionSet.Add(noun);
                    }
                    else if (VocabularyParsing.FromMDSnippet(snippet, out Verb verb))
                    {
                        definitionSet.Add(verb);
                    }
                }

                //post processing
                PostProcess(definitionSet);

                return true;
            }
            return false;
        }

        private static void PostProcess(DefinitionSet definitionSet)
        {
            foreach (var n in definitionSet.Nouns)
            {
                n.DefinitionSetName = definitionSet.Name;
            }
            foreach (var v in definitionSet.Verbs)
            {
                v.DefinitionSetName = definitionSet.Name;
            }
        }

        private static bool FromMDFile(string fileName, out DefinitionSet definitionSet)
        {
            definitionSet = null;
            string[] allLines = System.IO.File.ReadAllLines(fileName);

            if (FromMDLines(allLines, out definitionSet))
            {
                string definitionSetName = System.IO.Path.GetFileNameWithoutExtension(fileName);
                definitionSet.Name = definitionSetName;
                PostProcess(definitionSet);
                return true;
            }

            return false;
        }

        public static bool FromFolder(string folderName, out DWISVocabulary vocabulary)
        {
            vocabulary = null;
            var files = System.IO.Directory.GetFiles(folderName).Where(f => f.EndsWith(".md")).ToArray();
            if (files != null && files.Length > 0)
            {
                vocabulary = new DWISVocabulary();
                foreach (string file in files)
                {
                    if (FromMDFile(file, out DefinitionSet definitionSet))
                    {
                        vocabulary.Add(definitionSet);
                        vocabulary.DefinitionSetHeaders.Add(definitionSet.DefinitionSetHeader);
                    }
                }
                return true;
            }
            return false;
        }

        public static void CountTags(string folderName, out int nounTagsCount, out int verbTagsCount)
        {
            var files = System.IO.Directory.GetFiles(folderName).Where(f => f.EndsWith(".md")).ToArray();

            var nounTags = GetTagLines(files, NOUN_TAG);
            var verbsTags = GetTagLines(files, VERB_TAG);

            nounTagsCount = files.Sum(f => System.IO.File.ReadAllLines(f).Count(l => l.Contains(NOUN_TAG)));
            verbTagsCount = files.Sum(f => System.IO.File.ReadAllLines(f).Count(l => l.Contains(VERB_TAG)));
        }

        public static void GetTags(string folderName, out IEnumerable<string> nounTags, out IEnumerable<string> verbsTags)
        {
            var files = System.IO.Directory.GetFiles(folderName).Where(f => f.EndsWith(".md")).ToArray();

            nounTags = GetTagLines(files, NOUN_TAG).Select(t => t.Replace(NOUN_TAG, "").Replace("##", "").Trim());
            verbsTags = GetTagLines(files, VERB_TAG).Select(t => t.Replace(NOUN_TAG, "").Replace("##", "").Trim());

        }


        public static bool FromMDFile(string fileName, DWISVocabulary vocabulary, out DWISInstance instance)
        {
            instance = null;
            string[] allLines = System.IO.File.ReadAllLines(fileName);
            if (allLines != null && allLines.Length > 0)
            {
                instance = new DWISInstance(System.IO.Path.GetFileNameWithoutExtension(fileName), vocabulary);
                instance.Population = new SimplePopulation();
                instance.Sentences = new SimpleSentenceCollection();
                foreach (string line in allLines)
                {
                    if (line.Contains("mermaid"))
                    {
                        return true;
                    }
                    else if (line.StartsWith("- "))
                    {
                        var l = line.Remove(0, "- ".Length);
                        if (l.Contains(':'))
                        {
                            var els = l.Split(':');
                            if (els.Length == 2)
                            {
                                var t = els[0].Trim();
                                var noun = vocabulary.Nouns.Find(no => no.Name == t);
                                if (noun != null)
                                {
                                    var n = els[1].Trim();
                                    instance.Population.Add(new TypedIndividual(n, noun));
                                }
                            }
                        }
                        else
                        {
                            var els = l.Split(' ');
                            if (els.Length == 3)
                            {
                                var s = els[0].Trim();
                                var o = els[2].Trim();
                                var v = els[1].Trim();
                                var verb = vocabulary.Verbs.Find(ve => ve.Name == v);
                                var subject = instance.Population.FirstOrDefault(i => i.Name == s);
                                var sentenceObjecT = instance.Population.FirstOrDefault(i => i.Name == o);
                                if (verb != null && subject!=null && sentenceObjecT!=null)
                                {
                                    instance.Sentences.Add(new Sentence(subject, verb, sentenceObjecT));
                                }
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }


        private static IEnumerable<string> GetTagLines(string[] files, string tag)
        {
            var sub = files.Select(f => System.IO.File.ReadAllLines(f).Where(l => l.Contains(tag)).ToList()).ToList();
            return sub.SelectMany(x => x).ToList();
        }
    }
}
