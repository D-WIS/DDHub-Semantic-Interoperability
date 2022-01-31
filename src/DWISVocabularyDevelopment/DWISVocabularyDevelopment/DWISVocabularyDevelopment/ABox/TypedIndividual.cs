﻿using System.Linq;

namespace DWISVocabularyDevelopment
{
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
}
