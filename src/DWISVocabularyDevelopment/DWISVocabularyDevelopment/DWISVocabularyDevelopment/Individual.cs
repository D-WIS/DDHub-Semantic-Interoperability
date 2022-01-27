using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

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

    public interface IPopulation: ICollection<TypedIndividual>
    {
        TypedIndividual GetIndividual(string name);
    }

    public class SimplePopulation : IPopulation
    {
        private List<TypedIndividual> _individuals;

        public int Count => ((ICollection<TypedIndividual>)_individuals).Count;

        public bool IsReadOnly => ((ICollection<TypedIndividual>)_individuals).IsReadOnly;

        public void Add(TypedIndividual item)
        {
            ((ICollection<TypedIndividual>)_individuals).Add(item);
        }

        public void Clear()
        {
            ((ICollection<TypedIndividual>)_individuals).Clear();
        }

        public bool Contains(TypedIndividual item)
        {
            return ((ICollection<TypedIndividual>)_individuals).Contains(item);
        }

        public void CopyTo(TypedIndividual[] array, int arrayIndex)
        {
            ((ICollection<TypedIndividual>)_individuals).CopyTo(array, arrayIndex);
        }

        public IEnumerator<TypedIndividual> GetEnumerator()
        {
            return ((IEnumerable<TypedIndividual>)_individuals).GetEnumerator();
        }

        public TypedIndividual GetIndividual(string name)
        {
            return _individuals.Find(i => i.Name == name);
        }

        public bool Remove(TypedIndividual item)
        {
            return ((ICollection<TypedIndividual>)_individuals).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_individuals).GetEnumerator();
        }
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
