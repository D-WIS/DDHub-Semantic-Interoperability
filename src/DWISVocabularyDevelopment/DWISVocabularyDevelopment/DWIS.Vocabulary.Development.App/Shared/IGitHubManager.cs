using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public interface IGitHubManager
    {
        string GetUser();
        Task<bool> ManageCredentials(string apiKey);
        bool CredentialsOK();
        Task<bool> BranchOK();
        Task<List<EditableUseCase>?> GetUseCases();
        void RegisterChanges(string filePath);
        bool CommitChanges(string filePath);
        bool CommitAllChanges();
        string GetBranchName();
        Task<List<string>> GetUserBranch();
        List<EditableUseCase>? GetEditedUseCases();
    }


    public class EditableUseCase
    {
        public DWISInstance StoredInstance { get; set; }
        public DWISInstance EditedInstance { get; set; }
        public string Path { get; set; }
        public bool Edited { get; set; }
        public EditableUseCase(string fileContents, string path)
        {
            Path = path;

            if (fileContents.Contains("```"))
            {
                int idx = fileContents.IndexOf("```");
                fileContents = fileContents.Remove(idx, fileContents.Length - idx);
            }
            //fileContents = fileContents.Replace("- ", string.Empty);


            DWIS.Vocabulary.Utils.VocabularyParsing.FromMDFileContents(
                fileContents.Split("\n", StringSplitOptions.RemoveEmptyEntries), 
                path, 
                DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary, 
                out DWISInstance inst);
            StoredInstance = inst;
            EditedInstance = new DWISInstance(StoredInstance);
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
        public bool CommitAllChanges()
        {
            throw new NotImplementedException();
        }

        public bool CommitChanges(string filePath)
        {
            throw new NotImplementedException();
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
                        var contents = await _gitHubClient.Repository.Content.GetAllContents(_repoID, file.Path);
                        if (contents != null && contents.Count == 1)
                        {
                            string text = contents[0].Content;
                            _useCases.Add(new EditableUseCase(text, file.Path));
                        }
                    }
                }
                catch (Exception e)
                {
                    int i = 0;
                }
                return _useCases;
            }
        }

        public string GetUser()
        {
            return _userName;
        }

        public async Task<List<string>> GetUserBranch()
        {
            var branches = await _gitHubClient.Repository.Branch.GetAll(_repoID);
            return branches.Where(b => b.Name == GetBranchName()).Select(b => b.Name).ToList();
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
            _gitHubClient.Credentials = new Credentials(apiKey);
            var r = await _gitHubClient.User.Current();
            _userLogin = r.Login;
            _userName = r.Name;

            var allRepos = await _gitHubClient.Repository.GetAllForCurrent();
            var vocabularyRepo = allRepos.FirstOrDefault(r => r.Name == RepositoryName);
            _repoID = vocabularyRepo.Id;
            return CredentialsOK();
        }

        public void RegisterChanges(string filePath)
        {
            throw new NotImplementedException();
        }

        public List<EditableUseCase>? GetEditedUseCases()
        {
            if (_useCases != null)
            {
                return _useCases.Where(u => u.Edited).ToList();
            }
            else return null;
        }
    }
}
