using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public interface IUseCasesManager
    {

    }

    public class DWISUseCase
    {
        public string FilePath { get; set; }
        public DWISInstance Instance { get; set; }

        public string GetName()
        {
            return FilePath.Split('/').Last().Replace(".md", string.Empty);
        }
    }
}
