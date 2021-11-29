﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using DWISVocabularyDevelopment;

namespace VocabularyUtils
{
    public static class VocabularyParsing
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

        public static bool FromMDSnippet(string[] allSnippetLines,out Noun noun)
        {
            noun = null;
            if (allSnippetLines != null && allSnippetLines.Length > 0)
            {
                noun = new Noun();
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

                    if (noun.Name!= "DWISNoun" && string.IsNullOrEmpty(noun.ParentNounName))
                    {
                        noun.ParentNounName = "DWISNoun";
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
                        SpecializedNounAttribute specializedNounAttribute = new SpecializedNounAttribute() {  AttributeName = attributeName, SpecializedValue = attributeValue};

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




        public static bool FromMDSnippet(string[] allSnippetLines,out Verb verb)
        {
            verb = null;
            if (allSnippetLines != null && allSnippetLines.Length > 0)
            {
                verb = new Verb();
                string header = allSnippetLines[0];
                if (header.StartsWith("##") && header.EndsWith("<!-- VERB -->"))
                {
                    header = header.Remove(header.Length - "< !--VERB-- >".Length).Remove(0, "##".Length).Trim().TrimEnd();

                    verb.Name = header;

                    string[] tail = allSnippetLines.Skip(1).ToArray();
                    List<string[]> snippetItems = SplitSnippet(tail);

                    foreach (string[] snippetItem in snippetItems)
                    {
                        UpdateFromSnippetItem(snippetItem, verb);
                    }

                    if (verb.Name!= "DWISVerb" && string.IsNullOrEmpty(verb.ParentVerbName))
                    {
                        verb.ParentVerbName = "DWISVerb";
                    }
                    if (string.IsNullOrEmpty(verb.DomainNounName))
                    {
                        verb.DomainNounName = "DWISNoun";
                    }
                    if (string.IsNullOrEmpty(verb.RangeNounName))
                    {
                        verb.RangeNounName = "DWISNoun";
                    }
                    return true;
                }
            }
            return false;
        }

        public static bool FromMDLines(string[] allLines, out DefinitionSet definitionSet)
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

        public static void PostProcess(DefinitionSet definitionSet)
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

        public static bool FromMDFile(string fileName, out DefinitionSet definitionSet)
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
            var files = System.IO.Directory.GetFiles(folderName);
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


    }
}
