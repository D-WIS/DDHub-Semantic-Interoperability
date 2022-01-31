using System.Collections.Generic;
using System.Linq;

namespace DWISVocabularyDevelopment
{
    public class Sentence
    {
        public string Subject { get; internal set; }
        public string Verb { get; internal set; }
        public string Object { get; internal set; }
        private Sentence() { }
        public Sentence(Individual subject, Verb verb, Individual sentenceObject)
        {
            Subject = subject.Name;
            Verb = verb.Name;
            Object = sentenceObject.Name;
        }

        public Sentence(string subject, string verb, string sentenceObject, DWISVocabulary vocabulary, IEnumerable<Individual> population) :
            this(population.First(n => n.Name == subject), vocabulary.Verbs.Find(v => v.Name == verb), population.First(n => n.Name == sentenceObject))
        { }
    }
}
