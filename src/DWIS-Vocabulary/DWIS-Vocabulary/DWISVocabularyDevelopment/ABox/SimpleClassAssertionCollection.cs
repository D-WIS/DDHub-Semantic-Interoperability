using System.Collections;
using System.Collections.Generic;

namespace DWIS.Vocabulary.Development
{
    public class SimpleClassAssertionCollection : IClassAssertionCollection
    {
        private List<ClassAssertion> _assertions = new List<ClassAssertion>();

        public int Count => ((ICollection<ClassAssertion>)_assertions).Count;

        public bool IsReadOnly => ((ICollection<ClassAssertion>)_assertions).IsReadOnly;

        public void Add(ClassAssertion item)
        {
            ((ICollection<ClassAssertion>)_assertions).Add(item);
        }

        public void Clear()
        {
            ((ICollection<ClassAssertion>)_assertions).Clear();
        }

        public bool Contains(ClassAssertion item)
        {
            return ((ICollection<ClassAssertion>)_assertions).Contains(item);
        }

        public void CopyTo(ClassAssertion[] array, int arrayIndex)
        {
            ((ICollection<ClassAssertion>)_assertions).CopyTo(array, arrayIndex);
        }

        public IEnumerator<ClassAssertion> GetEnumerator()
        {
            return ((IEnumerable<ClassAssertion>)_assertions).GetEnumerator();
        }

        public bool Remove(ClassAssertion item)
        {
            return ((ICollection<ClassAssertion>)_assertions).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_assertions).GetEnumerator();
        }
    }

}
