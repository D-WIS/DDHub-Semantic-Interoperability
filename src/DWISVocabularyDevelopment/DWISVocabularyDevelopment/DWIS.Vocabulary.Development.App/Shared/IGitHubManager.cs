using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Octokit;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public interface IGitHubManager
    {
        string GetUserName();
        string GetUserLogin();
        Task<bool> ManageCredentials(string apiKey);
        bool CredentialsOK();
        Task<bool> BranchOK();
        Task<List<EditableUseCase>?> GetUseCases();
        void RegisterChanges(string filePath);
        Task<bool> CommitChanges(EditableUseCase useCase);
        Task<bool> CommitAllChanges();
        Task<bool> SyncChanges();
        string GetBranchName();
        Task<List<string>> GetUserBranch();
        List<EditableUseCase>? GetSessionEditedUseCases();
    }


    public class EditableUseCase
    {
        public DWISInstance StoredInstance { get; set; }
        public DWISInstance EditedInstance { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; }
        public string SHA { get; set; }
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
