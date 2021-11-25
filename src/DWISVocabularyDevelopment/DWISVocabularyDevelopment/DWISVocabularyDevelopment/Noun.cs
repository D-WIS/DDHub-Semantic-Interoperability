using System;
using System.Collections.Generic;
using System.Linq;

namespace DWISVocabularyDevelopment
{
    public class Noun
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentNounName { get; set; }
        public NounAttribute[] NounAttributes { get; set; }
        public SpecializedNounAttribute[] SpecializedNounAttributes { get; set; }
        public string Description { get; set; }
        public string Examples { get; set; }
        public string DefinitionFileNameWithoutExtension { get; set; }

        public string ToMDSnippet()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            return obj != null && obj is Noun && ((Noun)obj).Name == Name;
        }
    }

    public static class NounParsing
    {
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

        public static bool FromMDSnippet(string[] allSnippetLines, Noun noun)
        {
            if (allSnippetLines != null && allSnippetLines.Length > 0)
            {
                string header = allSnippetLines[0];
                if (header.StartsWith("##") && header.EndsWith("<!-- NOUN -->"))
                {
                    header = header.Remove(header.Length - "< !--NOUN-- >".Length).Remove(0, "##".Length).Trim().TrimEnd();

                    noun.Name = header;

                    string[] tail = allSnippetLines.Skip(1).ToArray();
                    List<string[]> snippetItems = SplitSnippet(tail);

                    foreach (string[] snippetItem in snippetItems)
                    {
                        UpdateFromSnippetItem(snippetItem, noun);
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
                noun.ParentNounName = header.Split('[', ']')[1];
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
            return false;
        }

        public static void ExtractSnippets(string[] fileLines, out List<string[]> allSnippets)
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
        }

    }

    public class NounAttribute
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }

    public class SpecializedNounAttribute
    {
        public string AttributeName { get; set; }
        public string SpecializedValue { get; set; }
    }

    public class Verb
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ParentVerbName { get; set; }
        public string DomainNounName { get; set; }
        public string RangeNounName { get; set; }
        public int MinCardinality { get; set; } = -1;
        public int MaxCardinality { get; set; } = -1;
    }

    public class Vocabulary
    {
        public IList<Noun> Nouns { get; set; }
        public IList<Verb> Verbs { get; set; }

        public void Add(Vocabulary other)
        {
            Nouns = Nouns.Union(other.Nouns).ToList();
            Verbs = Verbs.Union(other.Verbs).ToList();
        }
        public void Add(Noun noun)
        {
            if (!Contains(noun))
            {
                Nouns.Add(noun);
            }
        }
        public void Add(Verb verb)
        {
            if (!Contains(verb))
            {
                Verbs.Add(verb);
            }
        }
        public bool Contains(Noun noun)
        {
            return Nouns.Contains(noun);
        }
        public bool Contains(Verb verb)
        {
            return Verbs.Contains(verb);
        }

    }
}
