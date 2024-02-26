using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using DWIS.Vocabulary.Utils;

namespace DWIS.Vocabulary.Development.Actions
{
    public class VocabularyActioner
    {
        private ILogger _logger;
        private ActionPaths _paths;
        private DWISVocabulary _vocabulary;
        private List<PackageInfo> _packageInfos = new List<PackageInfo>();

        public VocabularyActioner(ActionsConfig conf, ILogger<VocabularyActioner> logger)
        {
            _logger = logger;

            _paths = new ActionPaths(conf.SourceFolder, conf.DestinationFolder, conf.SchemaFolder, conf.ExamplesSourceFolder, conf.StandardResourceFolder);

            if (!string.IsNullOrEmpty(conf.ProjectsToPack))
            {
                int version = conf.PackVersion;
                if (conf.IncrementVersion)
                {
                    version++;
                    var filePath = System.IO.Path.Combine(AppContext.BaseDirectory, "appSettings.json");
                    string json = System.IO.File.ReadAllText(filePath);
                    var jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ActionsConfig>(json);
                    jsonObj.PackVersion = version;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    System.IO.File.WriteAllText(filePath, output);
                }


                var projects = conf.ProjectsToPack.Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach (string project in projects)
                {
                    PackageInfo packageInfo = new PackageInfo() { ProjectName = project, Version = version , OutPutFolder = conf.PackageOutputFolder};
                    _packageInfos.Add(packageInfo);
                }
            }
        }
        public bool PerformActions()
        {
            return PreChecks() && Export() && PostChecks();// && Pack();
        }

        private bool PreChecks()
        {
            bool ok = true;
            this.
                LoadSourceVocabulary(ok, out bool loadOK).
                CheckForTagCount(loadOK, out bool tagCountOK).
                CheckForDuplicates(tagCountOK, out bool duplicatesOK).
                CheckForTreeCount(duplicatesOK, out var nounTree, out var verbTree, out bool treeCountOK);

            _logger.LogInformation($"Load ok: {loadOK}");
            _logger.LogInformation($"Tag count ok:  { tagCountOK}");
            _logger.LogInformation($"Duplicates ok:  { duplicatesOK}");
            _logger.LogInformation($"Tree count ok:  {treeCountOK}");
            return duplicatesOK;
        }

        private bool PostChecks()
        {
            bool postCheckOK = true;
            VocabularyParsing.FromFolder(_paths.DefinitionFilesFolderPath, out var folderDictionary);
            var jsonVocabulary =  DWISVocabulary.FromJsonFile(_paths.SingleJsonFilePath);
            postCheckOK &= jsonVocabulary.Equals(folderDictionary);

            _logger.LogInformation($"Json file ok: {postCheckOK}");
            return postCheckOK;
        }

        private bool Export()
        {
            _logger.LogInformation($"Export md single file to {_paths.SingleMDFilePath}");
            MDWriting.ToMDFile(_vocabulary, _paths.SingleMDFilePath);

            _logger.LogInformation($"Export md individual files to folder {_paths.DefinitionFilesFolderPath}");
            MDWriting.ToMDFiles(_vocabulary, _paths.DefinitionFilesFolderPath);

            DWISVocabulary.ToJsonFile(_paths.SingleJsonFilePath, _vocabulary);
            DWISVocabulary.ToJsonFile(_paths.StandardJsonFilePath, _vocabulary);

           //MDWriting.ToCSVFile(_vocabulary, _paths.CSVFilePath);


            _logger.LogInformation($"Export ontology to {_paths.OntologyFilePath}");
            OWL.OntologyGeneration.ExportOntology(_paths.OntologyFilePath, _vocabulary);

            _logger.LogInformation($"Export schemas files to {_paths.NounsSchemaPath} and { _paths.VerbsSchemaPath}");
            SchemaWriter.WriteSchema(_vocabulary, _paths.NounsSchemaPath, _paths.VerbsSchemaPath, _paths.AttributesSchemaPath);

            _logger.LogInformation($"Export example files to {_paths.ExamplesFilesFolderPath}");
            ParseExamples();         

            return true;
        }

        private bool Pack()
        {
            foreach (var pi in _packageInfos)
            {
                new PackageCreator().PackAndCopyProject(pi);   
            }
            return true;
        }

        private VocabularyActioner LoadSourceVocabulary(bool previousOK, out bool ok)
        {
            ok = previousOK && VocabularyParsing.FromFolder(_paths.VocabularySourceFolder, out _vocabulary);
            return this;
        }

        private VocabularyActioner CheckForTagCount(bool previousOK, out bool ok)
        {
            VocabularyParsing.CountTags(_paths.VocabularySourceFolder, out int nounTagsCount, out int verbsTagsCount);
            ok = previousOK && nounTagsCount == _vocabulary.Nouns.Count && verbsTagsCount == _vocabulary.Verbs.Count;

            if (previousOK && !ok)
            {
                if (nounTagsCount != _vocabulary.Nouns.Count)
                {
                    _logger.Log(LogLevel.Error, $"Nouns tags {nounTagsCount} vs {_vocabulary.Nouns.Count})");

                    VocabularyParsing.GetTags(_paths.VocabularySourceFolder, out var nounTags, out var verbsTags);

                    int disctinct = nounTags.Distinct().Count();
                    if (disctinct < nounTags.Count())
                    {
                        _logger.Log(LogLevel.Error, "Duplicates in tags");
                        var sorted = nounTags.ToList();
                        sorted.Sort();
                        List<string> duplicates = new List<string>();
                        for (int i = 0; i < sorted.Count - 1; i++)
                        {
                            if (sorted[i] == sorted[i + 1])
                            {
                                _logger.Log(LogLevel.Error, $"Noun {sorted[i]} is duplicated");
                                duplicates.Add(sorted[i]);
                            }
                        }
                    }

                    var ex = nounTags.Except(_vocabulary.Nouns.Select(n => n.Name));
                    //var intersect = nounTags.Intersect(_vocabulary.Nouns.Select(n => n.Name));
                    if (ex.Count() > 0)
                    {
                        foreach (var item in ex)
                        {
                            _logger.Log(LogLevel.Error, $"Noun {item} present in the noun tag list but not in vocabulary");
                        }
                    }
                    else
                    {
                        ex = _vocabulary.Nouns.Select(n => n.Name).Except(nounTags);
                        foreach (var item in ex)
                        {
                            _logger.Log(LogLevel.Error, $"Noun {item} present in the noun tag list but not in vocabulary");
                        }
                    }
                }
                if (verbsTagsCount != _vocabulary.Verbs.Count)
                {
                    _logger.Log(LogLevel.Error, $"Verbs tags {verbsTagsCount} vs {_vocabulary.Verbs.Count})");

                    VocabularyParsing.GetTags(_paths.VocabularySourceFolder, out var nounTags, out var verbsTags);

                    int disctinct = verbsTags.Distinct().Count();
                    if (disctinct < verbsTags.Count())
                    {
                        _logger.Log(LogLevel.Error, "Duplicates in tags");
                        var sorted = verbsTags.ToList();
                        sorted.Sort();
                        List<string> duplicates = new List<string>();
                        for (int i = 0; i < sorted.Count - 1; i++)
                        {
                            if (sorted[i] == sorted[i + 1])
                            {
                                _logger.Log(LogLevel.Error, $"Verb {sorted[i]} is duplicated");
                                duplicates.Add(sorted[i]);
                            }
                        }
                    }

                    var ex = verbsTags.Except(_vocabulary.Verbs.Select(n => n.Name));
                    //var intersect = nounTags.Intersect(_vocabulary.Nouns.Select(n => n.Name));
                    if (ex.Count() > 0)
                    {
                        foreach (var item in ex)
                        {
                            _logger.Log(LogLevel.Error, $"Verb {item} present in the verb tag list but not in vocabulary");
                        }
                    }
                    else
                    {
                        ex = _vocabulary.Verbs.Select(n => n.Name).Except(nounTags);
                        foreach (var item in ex)
                        {
                            _logger.Log(LogLevel.Error, $"Verb {item} present in the verb tag list but not in vocabulary");
                        }
                    }


                }
            }

            return this;
        }

        private VocabularyActioner CheckForDuplicates(bool previousOK, out bool ok)
        {
            ok = previousOK && _vocabulary.CheckForDuplicates(out var duplicatedNouns, out var duplicatedVerbs);
            return this;
        }

        private VocabularyActioner CheckForTreeCount(bool previousOK, out Tree<Noun> nounTree, out Tree<Verb> verbTree, out bool ok)
        {
            _vocabulary.ToTrees(out nounTree, out verbTree);
            ok = previousOK && nounTree.Count() == _vocabulary.Nouns.Count && verbTree.Count() == _vocabulary.Verbs.Count;

            if (previousOK && !ok)
            {
                _logger.Log(LogLevel.Error, $"Nouns tree items: {nounTree.Count()} vs {_vocabulary.Nouns.Count})");
                _logger.Log(LogLevel.Error, $"Verbs tree items: {verbTree.Count()} vs {_vocabulary.Verbs.Count})");
            }

            return this;
        }

        private VocabularyActioner ParseExamples()
        {
            var files = System.IO.Directory.GetFiles(_paths.ExamplesSourceFolder).Where(f => f.EndsWith(".md"));
            foreach (var file in files)
            {
                if (VocabularyParsing.FromMDFile(file, _vocabulary, out DWISInstance instance))
                {
                    string exportFileName = _paths.ExamplesFilesFolderPath + System.IO.Path.DirectorySeparatorChar + System.IO.Path.GetFileNameWithoutExtension(file) + ".md";

                    MDWriting.ToMDFile(instance, exportFileName, _vocabulary, true, false);
                }
            }
            return this;
        }
    }

}
