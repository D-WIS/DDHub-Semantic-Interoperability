using System;
using System.Text;

namespace DWISVocabularyDevelopment
{
    public class Individual
    {
        public string Name { get; internal set; }
        protected Individual() { }

        protected Individual(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Individual && ((Individual)obj).Name == Name;
        }
    }
}
