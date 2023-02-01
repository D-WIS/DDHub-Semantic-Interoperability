using System.Collections.Generic;
using System.Linq;

namespace DWIS.Vocabulary.Development
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

    public class ClassAssertion
    {
        public string Subject { get; internal set; }
        public string Verb { get; internal set; }
        public string Class { get; internal set; }
        private ClassAssertion() { }
        public ClassAssertion(Individual subject, Verb verb, Noun assertedClass)
        {
            Subject = subject.Name;
            Verb = verb.Name;
            Class = assertedClass.Name;
        }

        public ClassAssertion(string subject, string verb, string assertedClass, DWISVocabulary vocabulary, IEnumerable<Individual> population) :
            this(population.First(n => n.Name == subject), vocabulary.Verbs.Find(v => v.Name == verb), vocabulary.Nouns.First(n => n.Name == assertedClass))
        { }
    }


}
