﻿namespace DWIS.Vocabulary.Development
{
    public class DefinitionSetHeader
    {
        public string Name { get; set; }
        public string SetDescription { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
