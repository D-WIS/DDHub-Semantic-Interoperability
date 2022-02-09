using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DWIS.Vocabulary.Development;
using DWIS.Vocabulary.Utils;
using OWL = DWIS.Vocabulary.OWL;

namespace DWIS.Vocabulary.Development.Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DWIS Vocabulary development: vocabulary actions");

            using IHost host = CreateHostBuilder(args).Build();
          
            var s = host.Services.GetRequiredService<VocabularyActioner>();
            if (s.PerformActions())
            {
                Console.WriteLine("Perform actions succeeded.");
            }
            else
            {
                Console.WriteLine("Perform actions returned false.");
            }
            Console.WriteLine("Press any key to exit...");

            Console.ReadLine();
        }




        static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
          .ConfigureAppConfiguration((hostingContext, configuration) =>
          {
              configuration.Sources.Clear(); 
              configuration
                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
          })
          .ConfigureLogging(logging =>
          { 
              logging
                  .ClearProviders()
                  .AddConsole().SetMinimumLevel(LogLevel.Trace);
          })
          .ConfigureServices((hostContext, services) =>
          {
             // hostContext
              ActionsConfig options = new ActionsConfig();
              hostContext.Configuration.GetSection(nameof(ActionsConfig))
                               .Bind(options);



              services
                  .AddSingleton<ActionsConfig>(options)
                  .AddSingleton<VocabularyActioner>();
          });
    }

    public class VocabularyActioner 
    {
        private ILogger _logger;
        private ActionPaths _paths;
        private DWISVocabulary _vocabulary;
        public VocabularyActioner(ActionsConfig conf, ILogger<VocabularyActioner> logger)
        {
            _logger = logger;
            
            _paths = new ActionPaths(conf.SourceFolder, conf.DestinationFolder);
        
        }
        public bool PerformActions()
        {
            return Checks() && Export();
        }

        private bool Checks()
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

        private bool Export()
        {
            _logger.LogInformation($"Export md single file to {_paths.SingleMDFilePath}");
            MDWriting.ToMDFile(_vocabulary, _paths.SingleMDFilePath);
            _logger.LogInformation($"Export md individual files to folder {_paths.DefinitionFilesFolderPath}");
            MDWriting.ToMDFiles(_vocabulary, _paths.DefinitionFilesFolderPath);
            _logger.LogInformation($"Export ontology to {_paths.OntologyFilePath}");
            OWL.OntologyGeneration.GenerateOntology(_paths.OntologyFilePath, _vocabulary);

            return true;
        }

        private VocabularyActioner LoadSourceVocabulary(bool previousOK, out bool ok)
        {
            ok =previousOK && VocabularyParsing.FromFolder(_paths.SourceFolder, out _vocabulary);
            return this;
        }

        private VocabularyActioner CheckForTagCount(bool previousOK, out bool ok)
        {
            VocabularyParsing.CountTags(_paths.SourceFolder, out int nounTagsCount, out int verbsTagsCount);
            ok = previousOK && nounTagsCount == _vocabulary.Nouns.Count && verbsTagsCount == _vocabulary.Verbs.Count;

            if (previousOK && !ok)
            {
                if (nounTagsCount != _vocabulary.Nouns.Count)
                {
                    _logger.Log(LogLevel.Error, $"Nouns tags {nounTagsCount} vs {_vocabulary.Nouns.Count})");




                    VocabularyParsing.GetTags(_paths.SourceFolder, out var nounTags, out var verbsTags);

                    int disctinct = nounTags.Distinct().Count();
                    if (disctinct < nounTags.Count())
                    {
                        _logger.Log(LogLevel.Error, "Duplicates in tags");
                        var sorted = nounTags.ToList();
                        sorted.Sort();
                        List<string> duplicates = new List<string>();
                        for (int i = 0; i < sorted.Count-1; i++)
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
            _vocabulary.ToTrees(out  nounTree, out  verbTree);
            ok = previousOK && nounTree.Count() == _vocabulary.Nouns.Count && verbTree.Count() == _vocabulary.Verbs.Count;

            if (previousOK && !ok)
            {
                _logger.Log(LogLevel.Error, $"Nouns tree items: {nounTree.Count()} vs {_vocabulary.Nouns.Count})");
                _logger.Log(LogLevel.Error, $"Verbs tree items: {verbTree.Count()} vs {_vocabulary.Verbs.Count})");
            }

            return this;
        }

    }


    public class ActionsConfig
    {
        public string SourceFolder { get;  set; }
        public string DestinationFolder { get; set; }
    }

    public class ActionPaths
    {
        public string SourceFolder { get;private set; }

        public static string SingleFileName { get; set; } = "DWISVocabulary";
        public static string DefinitionFilesFolderName { get; set; } = "definition-files";
        public static string RDFFolderName { get; set; } = "rdf";
        public static string MDFolderName { get; set; } = "md";

        public string MDFolderPath { get; private set; }
        public string SingleMDFilePath { get;private  set; }
        public string DefinitionFilesFolderPath { get;private set; }

        public string RDFFolderPath { get; private set; }
        public string OntologyFilePath { get; private set; }

        public ActionPaths(string sourceFolder, string destinationFolder)
        {
            char sep = System.IO.Path.DirectorySeparatorChar;
            string mdExtension = ".md";

            SourceFolder = sourceFolder;

            MDFolderPath = destinationFolder + sep + MDFolderName;
            SingleMDFilePath = MDFolderPath + sep + SingleFileName + mdExtension;
            DefinitionFilesFolderPath = MDFolderPath + sep + DefinitionFilesFolderName;

            RDFFolderPath = destinationFolder + sep + RDFFolderName;
            OntologyFilePath = RDFFolderPath + sep + SingleFileName;
        }

    }

}
