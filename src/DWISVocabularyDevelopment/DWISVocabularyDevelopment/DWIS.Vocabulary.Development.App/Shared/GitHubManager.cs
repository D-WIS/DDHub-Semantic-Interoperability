using Microsoft.Extensions.Logging;
using Octokit;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public class GitHubManager : IGitHubManager
    {
        public static readonly string RepositoryName = "DDHub-Semantic-Interoperability";
        public static readonly string UseCasesFolderPath = "docs/vocabulary_development/examples";
        public static readonly string ApplicationName = "DWIS-Vocabulary-Edition";
        private GitHubClient _gitHubClient=new GitHubClient(new ProductHeaderValue(ApplicationName));
        public static readonly string BranchSuffix = "-voc-dev";
        private string _userName;
        private string _userLogin;
        private long _repoID;
        private List<EditableUseCase>? _useCases = null;
        private List<EditableNoun>? _nouns = null;
        private List<EditableVerb>? _verbs = null;
        private ILogger<GitHubManager>? _logger;

        public GitHubManager(ILogger<GitHubManager>? logger)
        {
            _logger = logger;
        }

        public async Task<bool> CommitAllChanges()
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

        public async Task<bool> CommitChanges(EditableUseCase useCase)
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
                        var contents = await _gitHubClient.Repository.Content.GetAllContentsByRef(_repoID, file.Path, "main");
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

        public async Task<(List<EditableNoun>? nouns, List<EditableVerb>? verbs)> GetNounsAndVerbs()
        {
            if (_nouns != null && _verbs!=null) { return (_nouns, _verbs); }
            else
            {
                _nouns = new List<EditableNoun>();
                _verbs = new List<EditableVerb>();
                try
                {
                    var files = await _gitHubClient.Repository.Content.GetAllContents(_repoID, UseCasesFolderPath);
                    List<string> filesContents = new List<string>();
                    foreach (var file in files)
                    {
                        var contents = await _gitHubClient.Repository.Content.GetAllContentsByRef(_repoID, file.Path, "main");
                        if (contents != null && contents.Count == 1)
                        {
                            
                            string text = contents[0].Content;
                            string[] allLines = text.Split('\r', '\n');
                            DWIS.Vocabulary.Utils.VocabularyParsing.FromMDFileContents(allLines, file.Path, out var definitionSet);

                            foreach (var n in definitionSet.Nouns)
                            {
                                EditableNoun editableNoun = new EditableNoun() { Path = file.Path, SHA = contents[0].Sha, StoredNoun = n, EditedNoun = new Noun() };//to fix
                                _nouns.Add(editableNoun);   
                            }
                            foreach (var v in definitionSet.Verbs)
                            {
                                EditableVerb editableVerb = new EditableVerb() { Path = file.Path, SHA = contents[0].Sha, StoredVerb = v, EditedVerb = new Verb() };//to fix
                                _verbs.Add(editableVerb);
                            }

                        }
                    }
                    return (_nouns, _verbs); ;
                }
                catch (Exception e)
                {
                    _logger?.LogError(e, "Exception on use cases retrieval.");
                    return (null, null);
                }
            }
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
