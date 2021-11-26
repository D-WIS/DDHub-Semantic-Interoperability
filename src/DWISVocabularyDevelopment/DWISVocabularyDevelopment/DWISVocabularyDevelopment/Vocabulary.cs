using System.Collections.Generic;
using System.Linq;

namespace DWISVocabularyDevelopment
{
    public class Vocabulary
    {
        public IList<Noun> Nouns { get; set; } = new List<Noun>();
        public IList<Verb> Verbs { get; set; } = new List<Verb>();

        public void Add(Vocabulary other)
        {
            Nouns = Nouns.Union(other.Nouns).ToList();
            Verbs = Verbs.Union(other.Verbs).ToList();
        }
        public void Add(Noun noun)
        {
            if (!Contains(noun))
            {
                Nouns.Add(noun);
            }
        }
        public void Add(Verb verb)
        {
            if (!Contains(verb))
            {
                Verbs.Add(verb);
            }
        }
        public bool Contains(Noun noun)
        {
            return Nouns.Contains(noun);
        }
        public bool Contains(Verb verb)
        {
            return Verbs.Contains(verb);
        }

    }
}
