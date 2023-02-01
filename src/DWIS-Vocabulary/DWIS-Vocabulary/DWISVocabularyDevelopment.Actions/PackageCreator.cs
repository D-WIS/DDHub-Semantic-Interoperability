using System.Diagnostics;

namespace DWIS.Vocabulary.Development.Actions
{
    public class PackageCreator
    {
        private string FindProjectFolder ( string projectName,System.IO.DirectoryInfo currentDirectory = null)
        {
            if (currentDirectory == null)
            {
                currentDirectory = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            }

            var files = currentDirectory.GetFiles("*" + projectName + ".csproj", System.IO.SearchOption.AllDirectories);
            if (files != null && files.Length==1)
            {
                return files[0].DirectoryName;
            }
            else
            {
                return  currentDirectory.Parent !=null ?  FindProjectFolder(projectName, currentDirectory.Parent) : null;
            }
        }


        public bool PackAndCopyProject(PackageInfo packageInfo)
        {
            if (packageInfo.OutPutFolder != null )
            {
                string arguments = $"pack --no-build --output {packageInfo.OutPutFolder} -p:PackageVersion=1.0.{packageInfo.Version}";

                string folder = FindProjectFolder(packageInfo.ProjectName);
                if (!string.IsNullOrEmpty(folder))
                {
                    var process = new Process
                    {
                        StartInfo =
                    {
                        FileName = "dotnet",
                        Arguments = arguments,
                        UseShellExecute = false,
                        WorkingDirectory = folder
                    }
                    };
                    process.Start();
                    return true;
                }
            }
            return false;
        }
    }

}
