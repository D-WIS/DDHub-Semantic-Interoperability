using System;
using System.Collections.Generic;
using System.Text;

namespace DWISVocabularyDevelopment
{
    public class DWISVocabulary : Vocabulary
    {
        public IList<DefinitionSetHeader> DefinitionSetHeaders { get; set; } = new List<DefinitionSetHeader>();
    }
}
