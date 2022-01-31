using System;
using System.Collections.Generic;
using System.Text;

namespace DWISVocabularyDevelopment
{
    public class DefinitionSet : Vocabulary
    {
        public DefinitionSetHeader DefinitionSetHeader { get; set; } = new DefinitionSetHeader();
        public string Name
        {
            get { return DefinitionSetHeader.Name; }
            set { DefinitionSetHeader.Name = value; }
        }
        public string SetDescription
        {
            get { return DefinitionSetHeader.SetDescription; }
            set { DefinitionSetHeader.SetDescription = value; }
        }
    }

    public class DefinitionSetHeader
    {
        public string Name { get; set; }
        public string SetDescription { get; set; }
    }
}
