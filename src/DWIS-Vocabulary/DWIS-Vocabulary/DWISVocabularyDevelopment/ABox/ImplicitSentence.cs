using System.Collections.Generic;
using System.Linq;

namespace DWIS.Vocabulary.Development
{
    public class ImplicitSentence
    {
        public string Subject { get; internal set; }
        public string Verb { get; internal set; }
        public string Object { get; internal set; }

        private ImplicitSentence() { }
        public ImplicitSentence(Individual subject, Verb verb, Noun sentenceObject)
        {
            Subject = subject.Name;
            Verb = verb.Name;
            Object = sentenceObject.Name;
        }

        public ImplicitSentence(string subject, string verb, string sentenceObject, DWISVocabulary vocabulary, IEnumerable<Individual> population) :
            this(population.First(n => n.Name == subject), vocabulary.Verbs.Find(v => v.Name == verb),vocabulary.Nouns.Find(v => v.Name == sentenceObject))
        { }
    }


}
