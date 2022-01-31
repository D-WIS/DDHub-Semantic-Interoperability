using System.Collections;
using System.Collections.Generic;

namespace DWISVocabularyDevelopment
{
    public class DWISInstance
    {
        public string Name { get;private set; }
        public DWISVocabulary Vocabulary { get;private set; }
        public IPopulation Population{ get; set; }
        public ISentenceCollection Sentences { get; set; }

        private DWISInstance() { }
        public DWISInstance(string name, DWISVocabulary vocabulary)
        {
            Name = name;
            Vocabulary = vocabulary;
        }


        public void CorrectNames()
        {
            var itemsPerTypes = ((SimplePopulation)Population).GetIndividualsPerType();


            foreach (var item in itemsPerTypes)
            {
                for (int i = 0; i < item.Item2.Count; i++)
                {
                    string newName = item.Item1 + "_" + i;

                    foreach (Sentence s in Sentences)
                    {
                        if (s.Subject == item.Item2[i].Name)
                        {
                            s.Subject = newName;
                        }
                        if (s.Object == item.Item2[i].Name)
                        {
                            s.Object = newName;
                        }
                    }
                    item.Item2[i].Name = newName;
                }
            }

        }



    }

    public class SimpleSentenceCollection : ISentenceCollection
    {
        private List<Sentence> _sentences = new List<Sentence>();

        public int Count => ((ICollection<Sentence>)_sentences).Count;

        public bool IsReadOnly => ((ICollection<Sentence>)_sentences).IsReadOnly;

        public void Add(Sentence item)
        {
            ((ICollection<Sentence>)_sentences).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Sentence>)_sentences).Clear();
        }

        public bool Contains(Sentence item)
        {
            return ((ICollection<Sentence>)_sentences).Contains(item);
        }

        public void CopyTo(Sentence[] array, int arrayIndex)
        {
            ((ICollection<Sentence>)_sentences).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Sentence> GetEnumerator()
        {
            return ((IEnumerable<Sentence>)_sentences).GetEnumerator();
        }

        public bool Remove(Sentence item)
        {
            return ((ICollection<Sentence>)_sentences).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_sentences).GetEnumerator();
        }
    }

    public interface ISentenceCollection : ICollection<Sentence>
    { }

}
