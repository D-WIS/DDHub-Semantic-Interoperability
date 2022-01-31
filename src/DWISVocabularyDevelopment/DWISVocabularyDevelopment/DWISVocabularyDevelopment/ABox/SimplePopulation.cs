using System.Collections.Generic;
using System.Collections;

namespace DWISVocabularyDevelopment
{
    public class SimplePopulation : IPopulation
    {
        private List<TypedIndividual> _individuals = new List<TypedIndividual>();

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

        public IList<(string, IList<TypedIndividual>)> GetIndividualsPerType()
        {
            var result = new List<(string, IList<TypedIndividual>)>();

            foreach (var i in _individuals)
            {
                var item = result.Find(it => it.Item1 == i.TypeName);
                if (item == default((string, IList<TypedIndividual>)))
                {
                    item = (i.TypeName, new List<TypedIndividual>());
                    result.Add(item);
                }
                item.Item2.Add(i);
            }        

            return result;
        }

    }
}
