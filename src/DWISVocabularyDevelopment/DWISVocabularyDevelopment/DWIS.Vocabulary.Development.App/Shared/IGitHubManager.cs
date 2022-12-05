using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Task<(Tree<EditableNoun>? nouns, Tree<EditableVerb>? verbs)> GetNounsAndVerbs();
        
        bool AddUseCase(string useCaseName);
    }
}
