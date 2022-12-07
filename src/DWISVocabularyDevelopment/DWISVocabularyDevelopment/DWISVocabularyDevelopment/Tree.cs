using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DWIS.Vocabulary.Development
{
    public class Tree<T>
    {
        public T RootItem { get; set; }
        public ICollection<Tree<T>> Children { get; set; } = new List<Tree<T>>();


        public Tree()
        { 
        
        }

        public Tree(T rootItem)
        {
            RootItem = rootItem;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public void AttachToParent(Tree<T> parent)
        {
            parent.Children.Add(this);
        }

        public Tree<T> GetOrDefault(T item)
        {
            if (RootItem == null)
            {
                return null;
            }
            else if (RootItem.Equals(item))
            {
                return this;
            }
            else
            {
                foreach (var child in Children)
                {
                    var res = child.GetOrDefault(item);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }


        public int Count()
        {
            return 1 + Children.Sum(c => c.Count());        
        }

        public List<T> ToList()
        {
            List<T> list = new List<T>();
            ToList(list);
            return list;
        }

        private void ToList(List<T> list)
        {
            list.Add(RootItem);
            if (Children != null) 
            {
                foreach (var child in Children)
                { 
                child.ToList(list);
                }
            }
        }

        public override string ToString()
        {
            return RootItem.ToString();
        }
    }
}
