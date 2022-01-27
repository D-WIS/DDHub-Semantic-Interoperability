using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DWISVocabularyDevelopment
{
    public class Individual
    {
        public string Name { get; private set; }
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

    public class TypedIndividual : Individual
    {
        public string TypeName { get; set; }
        protected TypedIndividual() : base() { }

        public TypedIndividual(string name, string typeName, DWISVocabulary vocabulary) : this(name, vocabulary.Nouns.Find(n => n.Name == typeName))
        {
        }

        public TypedIndividual(string name, Noun noun) : base(name)
        {
            TypeName = noun.Name;
            if (noun.NounAttributes != null)
            {
                Attributes = noun.NounAttributes.Select(na => new IndividualAttribute(na)).ToArray();
            }
        }

        public IndividualAttribute[] Attributes { get; private set; }
    }

    public class IndividualAttribute
    {
        public IndividualAttribute(string attributeName)
        {
            AttributeName = attributeName;
        }
        public IndividualAttribute(NounAttribute nounAttribute) : this(nounAttribute.Name)
        {
        }
        public string AttributeName { get; private set; }
        public string AttributeValue { get; set; }
    }

    public class Sentence
    {
        public string Subject { get; private set; }
        public string Verb { get; private set; }
        public string Object { get; private set; }
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

    public interface IPopulation: IEnumerable<TypedIndividual>
    {
        TypedIndividual GetIndividual(string name);
    }

    public class DWISInstance
    {
        public string Name { get;private set; }
        public DWISVocabulary Vocabulary { get;private set; }
        public IPopulation Population{ get; set; }
        public IEnumerable<Sentence> Sentences { get; private set; }

        private DWISInstance() { }
        public DWISInstance(string name, DWISVocabulary vocabulary)
        {
            Name = name;
            Vocabulary = vocabulary;
        }
    }
}
