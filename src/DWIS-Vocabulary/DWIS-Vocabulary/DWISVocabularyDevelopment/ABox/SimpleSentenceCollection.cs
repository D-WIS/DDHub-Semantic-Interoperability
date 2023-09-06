using System.Collections;
using System.Collections.Generic;

namespace DWIS.Vocabulary.Development
{
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

}
