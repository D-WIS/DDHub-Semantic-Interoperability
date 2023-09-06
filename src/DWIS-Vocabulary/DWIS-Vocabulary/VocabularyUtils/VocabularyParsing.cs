using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using DWIS.Vocabulary.Development;

namespace DWIS.Vocabulary.Utils
{
    public static class VocabularyParsing
    {

        public static string VERB_TAG = "<!-- VERB -->";
        public static string NOUN_TAG = "<!-- NOUN -->";

        public static string VERB_KEYWORD = "VERB";
        public static string NOUN_KEYWORD = "NOUN";
        public static string NOUNATTRIBUTE_KEYWORD = "NOUN-ATTRIBUTE";
        public static string SPECIALIZED_NOUNATTRIBUTE_KEYWORK = "SPECIALIZED-NOUN-ATTRIBUTE";
        public static string PARENT_KEYWORD = "PARENT";
        public static string TYPE_KEYWORD = "TYPE";
        public static string VALUE_KEYWORK = "VALUE";
        public static string COMMENT_TAG = "#";

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
                    if (noun.Name == "DWISNoun")
                    {
                        noun.ParentNounName = "";
                    }
                    else if (noun.Name != "DWISNoun" && string.IsNullOrEmpty(noun.ParentNounName))
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

                    if (verb.Name == "DWISVerb")
                    {
                        verb.ParentVerbName = "";
                    }
                    else if (verb.Name != "DWISVerb" && string.IsNullOrEmpty(verb.ParentVerbName))
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

        public static bool FromMDFileContents(string[] allLines,string fileName, out DefinitionSet definitionSet)
        {
         

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

        public static bool FromFiles(string[] files, out DWISVocabulary vocabulary)
        {
            vocabulary = null;
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



        public static bool ManageLine(string line, DWISVocabulary vocabulary, DWISInstance instance,List<NounAttribute> attributes, List<SpecializedNounAttribute> specializedAttributes,out bool quit, bool fromMD = true)
        {
            quit = false;
            if (!string.IsNullOrEmpty(line))
            {
                quit = line.Contains("mermaid");
                if(quit) { return false; }

                if (line.Trim().StartsWith(COMMENT_TAG)) { return false; }


                if (!fromMD || line.StartsWith("- "))
                {
                    line = fromMD ? line.Remove(0, "- ".Length) : line;

                    if (line.Contains(':'))//declaration of individual or semantic term
                    {
                        var elements = line.Split(':');
                        if (elements != null && elements.Length == 2)
                        {
                            if (elements[0].Trim().ToLower() == NOUN_KEYWORD.ToLower())
                            {
                                Noun newNoun = new Noun() { Name = elements[1].Trim() };
                                instance.InstanceVocabulary.Add(newNoun);
                                return true;
                            }
                            else if (elements[0].Trim().ToLower() == VERB_KEYWORD.ToLower())
                            {
                                Verb newVerb = new Verb() { Name = elements[1].Trim() };
                                instance.InstanceVocabulary.Add(newVerb);
                                return true;
                            }
                            else if (elements[0].Trim().ToLower() == NOUNATTRIBUTE_KEYWORD.ToLower())
                            {
                                NounAttribute newNounAttribute = new NounAttribute() { Name = elements[1].Trim() };
                                attributes.Add(newNounAttribute);
                                return true;
                            }
                            else if (elements[0].Trim().ToLower() == SPECIALIZED_NOUNATTRIBUTE_KEYWORK.ToLower())
                            {
                                SpecializedNounAttribute newNounAttribute = new SpecializedNounAttribute() { AttributeName = elements[1].Trim() };
                                specializedAttributes.Add(newNounAttribute);
                                return true;
                            }
                            else
                            {
                                string nounName = elements[0].Trim();
                                if (vocabulary.GetNoun(nounName, out Noun noun))
                                {
                                    string name = elements[1].Trim();
                                    instance.Population.Add(new TypedIndividual(name, noun));
                                    return true;
                                }
                                else if (instance.InstanceVocabulary.GetNoun(nounName, out noun))
                                {
                                    string name = elements[1].Trim();
                                    instance.Population.Add(new TypedIndividual(name, noun));
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else return false;
                    }
                    else if (line.Contains('='))//individual attribute, or attribute
                    {
                        var elements = line.Split('=');
                        if (elements != null && elements.Length == 2)
                        {
                            string attributeValue = elements[1].Trim();
                            if (elements[0].Contains('.'))
                            {
                                var leftElements = elements[0].Split('.');
                                if (leftElements != null && leftElements.Length == 2)
                                {
                                    string attributeSubject = leftElements[0].Trim();
                                    string attributeName = leftElements[1].Trim();
                                    var individual = instance.Population.FirstOrDefault(id => id.Name == attributeSubject);
                                    if (individual != null)//standard case
                                    {
                                        var attribute = individual.Attributes.FirstOrDefault(at => at.AttributeName.ToLower() == attributeName.ToLower());
                                        if (attribute != null)
                                        {
                                            attribute.AttributeValue = attributeValue;
                                            return true;
                                        }
                                        else return false;
                                    }
                                    else if (instance.InstanceVocabulary.GetNoun(attributeSubject, out var noun)) //standard case with local vocabulary
                                    {
                                        if (attributeName.ToLower() == PARENT_KEYWORD.ToLower())
                                        {
                                            noun.ParentNounName = attributeValue;
                                            return true;
                                        }
                                        else return false;
                                    }
                                    else
                                    {
                                        //check if we're working with an attribute
                                        var attribute = attributes.FirstOrDefault(att => att.Name.ToLower() == attributeSubject.ToLower());
                                        if (attribute != null)
                                        {
                                            if (attributeName.ToLower() == NOUN_KEYWORD.ToLower() && instance.InstanceVocabulary.GetNoun(attributeValue, out noun))//set the attribute to the noun
                                            {
                                                var atts = noun.NounAttributes.ToList();
                                                atts.Add(attribute);
                                                noun.NounAttributes = atts.ToArray();
                                                return true;
                                            }
                                            else if (attributeName.ToLower() == TYPE_KEYWORD)//data type of the attribute
                                            {
                                                attribute.Type = attributeValue;
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            //check if we're working with a specialized attribute
                                            var specializedAttribute = specializedAttributes.FirstOrDefault(att => att.AttributeName.ToLower() == attributeSubject.ToLower());
                                            if (specializedAttribute != null)
                                            {
                                                if (attributeName.ToLower() == VALUE_KEYWORK.ToLower())//set the specialized attribute value
                                                {
                                                    specializedAttribute.SpecializedValue = attributeValue;
                                                    return true;
                                                }
                                                else if (attributeName.ToLower() == NOUN_KEYWORD.ToLower() && instance.InstanceVocabulary.GetNoun(attributeValue, out noun))//set the attribute to the noun
                                                {
                                                    var atts = noun.SpecializedNounAttributes.ToList();
                                                    atts.Add(specializedAttribute);
                                                    noun.SpecializedNounAttributes = atts.ToArray();
                                                    return true;
                                                }
                                                else return false;
                                            }
                                            else if (instance.InstanceVocabulary.GetNoun(attributeSubject, out noun))//check if we're working with a noun
                                            {
                                                if (attributeName.ToLower() == PARENT_KEYWORD.ToLower())
                                                {
                                                    noun.ParentNounName = attributeValue;
                                                    return true;
                                                }
                                                else return false;
                                            }
                                            else if (instance.InstanceVocabulary.GetVerb(attributeSubject, out Verb verb))//check if we're working with a verb
                                            {
                                                if (attributeName.ToLower() == PARENT_KEYWORD.ToLower())
                                                {
                                                    verb.ParentVerbName = attributeValue;
                                                    return true;
                                                }
                                                else return false;
                                            }
                                            else return false;
                                        }
                                    }
                                }
                                else return false;
                            }
                            else return false;
                        }
                        else return false;
                    }
                    else //a priori, a triplet
                    {
                        var elements = line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                        if (elements != null && elements.Length == 3)
                        {
                            var s = elements[0].Trim();
                            var o = elements[2].Trim();
                            var v = elements[1].Trim();
                            var verb = vocabulary.Verbs.Find(ve => ve.Name == v);
                            var subject = instance.Population.FirstOrDefault(i => i.Name == s);

                            if (verb != null && subject != null)
                            {
                                if (verb.Name == "BelongsToClass")
                                {
                                    if (instance.Vocabulary.GetNoun(o, out Noun theClass) || instance.InstanceVocabulary.GetNoun(o, out theClass))
                                    {
                                        instance.ClassAssertions.Add(new ClassAssertion(subject, verb, theClass));
                                        return true;
                                    }
                                    else return false;
                                }
                                else
                                {
                                    var sentenceObjecT = instance.Population.FirstOrDefault(i => i.Name == o);
                                    if (sentenceObjecT != null)
                                    {
                                        instance.Sentences.Add(new Sentence(subject, verb, sentenceObjecT));
                                        return true;
                                    }
                                    else
                                    {
                                        if (instance.Vocabulary.GetNoun(o, out Noun nounObject) || instance.InstanceVocabulary.GetNoun(o, out nounObject))
                                        {
                                            instance.ImplicitSentences.Add(new ImplicitSentence(subject, verb, nounObject));
                                            return true;
                                        }
                                        else return false;
                                    }
                                }
                            }
                            else
                                return false;
                        }
                        else
                            return false;
                    }




                    //if (line.Contains('.'))//attribute
                    //{
                    //    int idx = line.IndexOf('.');
                    //    if (idx > 0)
                    //    {
                    //        var instName = line.Substring(0, idx);
                    //        var res = instance.Population.FirstOrDefault(t => t.Name == instName.Trim());
                    //        if (res != null)
                    //        {
                    //            found = true;
                    //            var rest = line.Substring(idx + 1, line.Length - idx - 1);
                    //            if (rest.Contains('='))
                    //            {
                    //                string propertyName = rest.Split('=')[0].Trim();
                    //                var p = res.Attributes.FirstOrDefault(a => a.AttributeName == propertyName);
                    //                if (p != null)
                    //                {
                    //                    p.AttributeValue = rest.Split('=')[1].Trim();
                    //                    return true;
                    //                }
                    //            }
                    //        }
                    //    }
                    //    return false;
                    //}
                    //if (!found)
                    //{
                    //    if (line.Contains(':'))//individual declaration
                    //    {
                    //        var els = line.Split(':');
                    //        if (els.Length == 2)
                    //        {
                    //            var t = els[0].Trim();
                    //            var noun = vocabulary.Nouns.Find(no => no.Name == t);
                    //            if (noun != null)
                    //            {
                    //                var n = els[1].Trim();
                    //                instance.Population.Add(new TypedIndividual(n, noun));
                    //                return true;
                    //            }
                    //        }
                    //        return false;
                    //    }
                    //    else//sentence, either class assertion, standard or implicit sentence. 
                    //    {
                    //        var els = line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                    //        if (els.Length == 3)
                    //        {
                    //            var s = els[0].Trim();
                    //            var o = els[2].Trim();
                    //            var v = els[1].Trim();
                    //            var verb = vocabulary.Verbs.Find(ve => ve.Name == v);
                    //            var subject = instance.Population.FirstOrDefault(i => i.Name == s);

                    //            if (verb != null && subject != null)
                    //            {
                    //                if (verb.Name == "BelongsToClass")
                    //                {
                    //                    var sentenceObjecT = vocabulary.Nouns.FirstOrDefault(i => i.Name == o);
                    //                    if (sentenceObjecT != null)
                    //                    {
                    //                        instance.ClassAssertions.Add(new ClassAssertion(subject, verb, sentenceObjecT));
                    //                        return true;
                    //                    }
                    //                }
                    //                else
                    //                {
                    //                    var sentenceObjecT = instance.Population.FirstOrDefault(i => i.Name == o);
                    //                    if (sentenceObjecT != null)
                    //                    {
                    //                        instance.Sentences.Add(new Sentence(subject, verb, sentenceObjecT));
                    //                        return true;
                    //                    }
                    //                    else
                    //                    {
                    //                        var nounObject = vocabulary.Nouns.FirstOrDefault(i => i.Name == o);
                    //                        if (nounObject != null)
                    //                        {
                    //                            instance.ImplicitSentences.Add(new ImplicitSentence(subject, verb, nounObject));
                    //                            return true;
                    //                        }
                    //                    }
                    //                }
                    //            }
                    //        }
                    //        return false;
                    //    }
                    //}
                    //return false;
                }
                else return false;
            }
            else return false;
        }
        public static bool FromLines(string[] allLines, DWISVocabulary vocabulary, DWISInstance instance, bool fromMD = true)
        {
            if (allLines != null && allLines.Length > 0)
            {
                bool quit = false;
                List<NounAttribute> nounAttributes = new List<NounAttribute>();
                List<SpecializedNounAttribute> specializedNounAttributes = new List<SpecializedNounAttribute>();    
                foreach (string line in allLines)
                {
                    ManageLine(line, vocabulary, instance, nounAttributes, specializedNounAttributes, out quit, fromMD);
                    if (quit) { return true; }
                }
                return true;
            }
            else return false;



                if (allLines != null && allLines.Length > 0)
            {
                foreach (string line in allLines)
                {
                    if (line.Contains("mermaid"))
                    {
                        return true;
                    }
                    else if (!fromMD || line.StartsWith("- "))
                    {
                        var l = fromMD ? line.Remove(0, "- ".Length) : line;

                        bool found = false;

                        if (l.Contains('.'))
                        {
                            int idx = l.IndexOf('.');
                            if (idx > 0)
                            {
                                var instName = l.Substring(0, idx);
                                var res = instance.Population.FirstOrDefault(t => t.Name == instName.Trim());
                                if (res != null)
                                {
                                    found = true;
                                    var rest = l.Substring(idx + 1, l.Length - idx - 1);
                                    if (rest.Contains('='))
                                    {
                                        string propertyName = rest.Split('=')[0].Trim();
                                        var p = res.Attributes.FirstOrDefault(a => a.AttributeName == propertyName);
                                        if (p != null)
                                        {
                                            p.AttributeValue = rest.Split('=')[1].Trim();
                                        }
                                    }
                                }
                            }
                        }
                        if (!found)
                        {
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
                                var els = l.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                                if (els.Length == 3)
                                {
                                    var s = els[0].Trim();
                                    var o = els[2].Trim();
                                    var v = els[1].Trim();
                                    var verb = vocabulary.Verbs.Find(ve => ve.Name == v);
                                    var subject = instance.Population.FirstOrDefault(i => i.Name == s);

                                    if (verb != null && subject != null)
                                    {
                                        if (verb.Name == "BelongsToClass")
                                        {
                                            var sentenceObjecT = vocabulary.Nouns.FirstOrDefault(i => i.Name == o);
                                            if (sentenceObjecT != null)
                                            {
                                                instance.ClassAssertions.Add(new ClassAssertion(subject, verb, sentenceObjecT));
                                            }
                                        }
                                        else
                                        {
                                            var sentenceObjecT = instance.Population.FirstOrDefault(i => i.Name == o);
                                            if (sentenceObjecT != null)
                                            {
                                                instance.Sentences.Add(new Sentence(subject, verb, sentenceObjecT));
                                            }
                                            else
                                            {
                                                var nounObject = vocabulary.Nouns.FirstOrDefault(i => i.Name == o);
                                                if (nounObject != null)
                                                {
                                                    instance.ImplicitSentences.Add(new ImplicitSentence(subject, verb, nounObject));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public static bool FromMDFile(string fileName, DWISVocabulary vocabulary, out DWISInstance instance)
        {
            instance = new DWISInstance(System.IO.Path.GetFileNameWithoutExtension(fileName), vocabulary);
            instance.Population = new SimplePopulation();
            instance.Sentences = new SimpleSentenceCollection();
            instance.ClassAssertions = new SimpleClassAssertionCollection();
            instance.ImplicitSentences = new SimpleImplicitSentenceCollection();
            string[] allLines = System.IO.File.ReadAllLines(fileName);

            return FromLines(allLines, vocabulary, instance);
        }

        public static bool FromMDFileContents(string[] fileLines,string instanceName, DWISVocabulary vocabulary, out DWISInstance instance)
        {
            instance = new DWISInstance(instanceName, vocabulary);
            instance.Population = new SimplePopulation();
            instance.Sentences = new SimpleSentenceCollection();
            instance.ClassAssertions = new SimpleClassAssertionCollection();
            instance.ImplicitSentences = new SimpleImplicitSentenceCollection();

            //string[] allLines = System.IO.File.ReadAllLines(fileName);

            return FromLines(fileLines, vocabulary, instance);
        }

        private static IEnumerable<string> GetTagLines(string[] files, string tag)
        {
            var sub = files.Select(f => System.IO.File.ReadAllLines(f).Where(l => l.Contains(tag)).ToList()).ToList();
            return sub.SelectMany(x => x).ToList();
        }
    }
}
