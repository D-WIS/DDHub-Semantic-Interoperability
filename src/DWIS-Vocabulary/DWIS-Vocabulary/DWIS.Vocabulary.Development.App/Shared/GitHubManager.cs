using DWIS.Vocabulary.Utils;
using Microsoft.Extensions.Logging;
using Octokit;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public class GitHubManager : IGitHubManager
    {
        public static readonly string RepositoryName = "DDHub-Semantic-Interoperability";
        public static readonly string UseCasesFolderPath = "docs/vocabulary_development/examples";
        public static readonly string VocabularyFolderPath = "docs/vocabulary_development/definitions";
        public static readonly string ApplicationName = "DWIS-Vocabulary-Edition";
        private GitHubClient _gitHubClient=new GitHubClient(new ProductHeaderValue(ApplicationName));
        public static readonly string BranchSuffix = "-voc-dev";
        private string _userName;
        private string _userLogin;
        private long _repoID;
        private List<EditableUseCase>? _useCases = null;
        private Tree<EditableNoun>? _nouns = null;
        private Tree<EditableVerb>? _verbs = null;
        private ILogger<GitHubManager>? _logger;
        private DWISVocabulary _vocabulary = new DWISVocabulary();

        public GitHubManager(ILogger<GitHubManager>? logger)
        {
            _logger = logger;
            _userName = string.Empty;
            _userLogin = string.Empty;
            _repoID = 0;
        }

        public async Task<bool> CommitAllUseCaseChanges()
        {
            bool ok = true;
            var edited = GetSessionEditedUseCases();
            if (edited != null)
            {
                foreach (var e in edited)
                {
                    ok &= await CommitChanges(e);
                }
                return ok;
            }
            else return false;
        }

        public async Task<bool> CommitAllVocabularyChanges()
        {
            var editedNouns = GetSessionEditedNouns();
            var editedVerbs = GetSessionEditedVerbs();
            var definitionSets = editedNouns?.Select(n => n.DefinitionSetName).ToList();
            if (definitionSets == null) { definitionSets = new List<string>(); }
            var df2 = editedVerbs?.Select(v => v.DefinitionSetName).ToList();
           
            definitionSets.AddRange(df2 ?? Enumerable.Empty<string>());
            bool ok = true;
            foreach (string ds in definitionSets.Distinct())
            {
                ok &= await CommitChanges(ds);
            }
            return ok;
        }


        public async Task<bool> CommitChanges(string definitionSetName)
        {
            var definitionSets= MDWriting.ToDefinitionSets(_vocabulary);

            var definitionSet = definitionSets.FirstOrDefault(df => df.Name == definitionSetName);
            if (definitionSet != null)
            {
                string path = string.Empty;
                string sha = string.Empty;

                if (definitionSet.Nouns != null && definitionSet.Nouns.Count > 0 && definitionSet.Nouns[0] is EditableNoun)
                {
                    path = ((EditableNoun)definitionSet.Nouns[0]).Path;
                    sha = ((EditableNoun)definitionSet.Nouns[0]).SHA;
                }
                else if (definitionSet.Verbs != null && definitionSet.Verbs.Count > 0 && definitionSet.Verbs[0] is EditableVerb)
                {
                    path = ((EditableVerb)definitionSet.Verbs[0]).Path;
                    sha = ((EditableVerb)definitionSet.Verbs[0]).SHA;

                }

                if (!string.IsNullOrEmpty(sha) && !string.IsNullOrEmpty(path))
                {
                    DefinitionSet editedDefinitionSet = new DefinitionSet();
                    editedDefinitionSet.Name = definitionSetName;
                    editedDefinitionSet.DefinitionSetHeader = definitionSet.DefinitionSetHeader;
                    editedDefinitionSet.SetDescription = definitionSet.SetDescription;
                    editedDefinitionSet.Verbs = definitionSet.Verbs.Select(v => ((EditableVerb)v).EditedVerb).ToList();
                    editedDefinitionSet.Nouns = definitionSet.Nouns.Select(v => ((EditableNoun)v).EditedNoun).ToList();
                    string contents = MDWriting.ToMDString(editedDefinitionSet, _vocabulary);
                    UpdateFileRequest updateFileRequest = new UpdateFileRequest("Edit of definition set", contents, sha, GetBranchName());
                    try
                    {
                        var res = await _gitHubClient.Repository.Content.UpdateFile(_repoID, path, updateFileRequest);
                        return res != null;
                    }
                    catch (Exception e)
                    {
                        _logger?.LogError(e, "Exception on commit");
                        return false;
                    }
                }
                _logger?.LogError("Could not retrieve SHA or path for definition set.");
                return false;
            }
            else
            {
                _logger?.LogError("Could not retrieve original definition set.");
                return false;
            }
        }

        public async Task<bool> CommitChanges(EditableUseCase useCase)
        {
            if (!string.IsNullOrEmpty(useCase.Path) && !string.IsNullOrEmpty(useCase.SHA) && useCase.StoredInstance != null)
            {
                string contents = useCase.GetEditedCode();
                UpdateFileRequest updateFileRequest = new UpdateFileRequest("Edit of use case", contents, useCase.SHA, GetBranchName());
                try
                {
                    var res = await _gitHubClient.Repository.Content.UpdateFile(_repoID, useCase.Path, updateFileRequest);
                    return res != null;
                }
                catch (Exception e)
                {
                    _logger?.LogError(e, "Exception on commit");
                    return false;
                }
            }
            else
            {
                string contents = useCase.GetEditedCode();
                string message = "Creating use case " + useCase.EditedInstance.Name;
                string path = useCase.EditedInstance.Name.Replace(" ", "-");
                path = UseCasesFolderPath + "/" + path + ".md";
                CreateFileRequest createFileRequest = new CreateFileRequest(message, contents, GetBranchName());
                try
                {
                    var res = await _gitHubClient.Repository.Content.CreateFile(_repoID, path, createFileRequest);
                    return res != null;
                }
                catch (Exception e)
                {
                    _logger?.LogError(e, "Exception on commit");
                    return false;
                }
            }
        }

        public bool CredentialsOK()
        {
            return _gitHubClient.User != null && _repoID>0;
        }

        public string GetBranchName()
        {
            return _userLogin + BranchSuffix;
        }

        public async Task<List<EditableUseCase>?> GetUseCases()
        {
            if (_useCases != null) { return _useCases; }
            else
            {
                _useCases = new List<EditableUseCase>();
                try
                { 
                    var files = await _gitHubClient.Repository.Content.GetAllContents(_repoID, UseCasesFolderPath);
                    foreach (var file in files)
                    {
                        var contents = await _gitHubClient.Repository.Content.GetAllContentsByRef(_repoID, file.Path, GetBranchName());
                        if (contents != null && contents.Count == 1)
                        {
                            string text = contents[0].Content; 
                            _useCases.Add(new EditableUseCase(text, file.Path, contents[0].Sha));
                        }
                    }
                    return _useCases;
                }
                catch (Exception e)
                {
                    _logger?.LogError(e, "Exception on use cases retrieval.");
                    return null;
                }
            }
        }

        public async Task<(Tree<EditableNoun>? nouns, Tree<EditableVerb>? verbs)> GetNounsAndVerbs()
        {
            if (_nouns != null && _verbs!=null) { return (_nouns, _verbs); }
            else
            {
                _nouns = new Tree<EditableNoun>();
                _verbs = new Tree<EditableVerb>();
                _vocabulary = new DWISVocabulary();
                try
                {
                    var files = await _gitHubClient.Repository.Content.GetAllContents(_repoID, VocabularyFolderPath);
                    List<string> filesContents = new List<string>();
                    foreach (var file in files)
                    {
                        var contents = await _gitHubClient.Repository.Content.GetAllContentsByRef(_repoID, file.Path, GetBranchName());
                        if (contents != null && contents.Count == 1)
                        {                            
                            string text = contents[0].Content;
                            string[] allLines = text.Split('\r', '\n');
                            DWIS.Vocabulary.Utils.VocabularyParsing.FromMDFileContents(allLines, file.Path, out var definitionSet);

                            for (int i = 0; i < definitionSet.Nouns.Count; i++)
                            {
                                definitionSet.Nouns[i] = new EditableNoun(definitionSet.Nouns[i], file.Path, contents[0].Sha);
                            }
                            for (int i = 0; i < definitionSet.Verbs.Count; i++)
                            {
                                definitionSet.Verbs[i] = new EditableVerb(definitionSet.Verbs[i], file.Path, contents[0].Sha);
                            }
                            _vocabulary.Add(definitionSet);
                            _vocabulary.DefinitionSetHeaders.Add(definitionSet.DefinitionSetHeader);
                        }
                    }


                    _vocabulary.ToTrees(out var baseNounTree, out var baseVerbTree);

                    _nouns = CopyTree<EditableNoun, Noun>(baseNounTree);
                    _verbs = CopyTree<EditableVerb, Verb>(baseVerbTree);
                    return (_nouns, _verbs);
                }
                catch (Exception e)
                {
                    _logger?.LogError(e, "Exception on use cases retrieval.");
                    return (null, null);
                }
            }
        }

        private Tree<T> CopyTree<T, T2>(Tree<T2> baseTree) where T:T2
        {
            Tree<T> tree = new Tree<T>((T)baseTree.RootItem);
            if (baseTree.Children != null && baseTree.Children.Count > 0)
            {
                tree.Children = new List<Tree<T>>();
                foreach (var c in baseTree.Children)
                {
                    tree.Children.Add(CopyTree<T, T2>(c));
                }
            }
            return tree;
        }
        public bool AddUseCase(string useCaseName)
        {
            _useCases?.Add(
                new EditableUseCase(
                    new DWISInstance(useCaseName, DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary),
                    "",
                    false,
                    string.Empty
                    )
                );
            return true;
        }

        public string GetUserName()
        {
            return _userName;
        }

        public async Task<List<string>> GetUserBranch()
        {
            try
            {
                var branches = await _gitHubClient.Repository.Branch.GetAll(_repoID);                
                
                return branches.Where(b => b.Name == GetBranchName()).Select(b => b.Name).ToList();
            }
            catch (Exception e)
            {
                _logger?.LogError(e, "Exception on branch retrieval.");
                return null;
            }
        }

        public async Task<bool> BranchOK()
        {
            if (CredentialsOK())
            {
                var l = await GetUserBranch();
                return l != null && l.Count > 0;
            }
            else return false;
        }

        public async Task<bool> ManageCredentials(string apiKey)
        {
            try
            {
                _gitHubClient.Credentials = new Credentials(apiKey);
                var r = await _gitHubClient.User.Current();
                _userLogin = r.Login;
                _userName = r.Name;

                var allRepos = await _gitHubClient.Repository.GetAllForCurrent();
                var vocabularyRepo = allRepos.FirstOrDefault(r => r.Name == RepositoryName);
                _repoID = vocabularyRepo.Id;
                return CredentialsOK();
            }
            catch (Exception e)
            {
                _logger?.LogError(e, "Exception on credential management.");
                return false;
            }
        }

        public void RegisterChanges(string filePath)
        {
            throw new NotImplementedException();
        }

        public List<EditableUseCase>? GetSessionEditedUseCases()
        {
            if (_useCases != null)
            {
                return _useCases.Where(u => u.Edited).ToList();
            }
            else return null;
        }


        public List<EditableNoun>? GetSessionEditedNouns()
        {
            return _nouns?.ToList().Where(n => n.Edited).ToList();
        }

        public List<EditableVerb>? GetSessionEditedVerbs()
        {
            return _verbs?.ToList().Where(n => n.Edited).ToList();
        }
        public string GetUserLogin()
        {
            return _userLogin;
        }

        public async Task<bool> SyncChanges()
        {
            try
            {
                var t = await _gitHubClient.Repository.Merging.Create(_repoID, new NewMerge(GetBranchName(), "main"));
                string prTitle = "Use case edition [" + _userName + "] [" + GetBranchName() + "]";
                var pr = await _gitHubClient.PullRequest.Create(_repoID, new NewPullRequest(prTitle, GetBranchName(), "main"));
                return true;
            }
            catch (Exception e)
            {
                _logger?.LogError(e, "Exception during synchronization.");
                return false;
            }
        }
    }
}
