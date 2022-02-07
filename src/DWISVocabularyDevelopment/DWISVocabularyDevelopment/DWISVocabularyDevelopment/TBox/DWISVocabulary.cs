using System;
using System.Collections.Generic;
using System.Text;

namespace DWIS.Vocabulary.Development
{
    public class DWISVocabulary : Vocabulary
    {
        public IList<DefinitionSetHeader> DefinitionSetHeaders { get; set; } = new List<DefinitionSetHeader>();
    }
}
