using System.Collections;
using System.Collections.Generic;

namespace DWIS.Vocabulary.Development
{
    public class SimpleImplicitSentenceCollection : IImplicitSentenceCollection
    {
        private List<ImplicitSentence> _implicitSentences = new List<ImplicitSentence>();

        public int Count => _implicitSentences.Count;

        public bool IsReadOnly => ((ICollection<ImplicitSentence>)_implicitSentences).IsReadOnly;

        public void Add(ImplicitSentence item)
        {
            _implicitSentences.Add(item);
        }

        public void Clear()
        {
            _implicitSentences.Clear();
        }

        public bool Contains(ImplicitSentence item)
        {
            return _implicitSentences.Contains(item);
        }

        public void CopyTo(ImplicitSentence[] array, int arrayIndex)
        {
           _implicitSentences.CopyTo(array, arrayIndex); 
        }

        public IEnumerator<ImplicitSentence> GetEnumerator()
        {
            return _implicitSentences.GetEnumerator();
        }

        public bool Remove(ImplicitSentence item)
        {
            return _implicitSentences.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _implicitSentences.GetEnumerator();
        }
    }

}
