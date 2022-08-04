using System;
using System.Collections.Generic;
using System.Linq;

namespace DWIS.Vocabulary.Development
{
    public class Vocabulary : IEquatable<Vocabulary>
    {
        public List<Noun> Nouns { get; set; } = new List<Noun>();
        public List<Verb> Verbs { get; set; } = new List<Verb>();

        public void Add(Vocabulary other)
        {
            Nouns = Nouns.Union(other.Nouns).ToList();
            Verbs = Verbs.Union(other.Verbs).ToList();
        }
        public void Add(Noun noun)
        {
            if (!Contains(noun))
            {
                Nouns.Add(noun);
            }
        }
        public void Add(Verb verb)
        {
            if (!Contains(verb))
            {
                Verbs.Add(verb);
            }
        }
        public bool Contains(Noun noun)
        {
            return Nouns.Contains(noun);
        }
        public bool Contains(Verb verb)
        {
            return Verbs.Contains(verb);
        }

        public bool GetNoun(string nounName, out Noun noun)
        {
            noun = Nouns.FirstOrDefault(n => n.Name == nounName);
            return noun != null;
        }

        public bool GetVerb(string verbName, out Verb verb)
        {
            verb = Verbs.FirstOrDefault(v => v.Name == verbName);
            return verb != null;
        }

        public bool CheckForDuplicates(out ICollection<Noun> duplicatedNouns,out ICollection<Verb> duplicatedVerbs)
        {
            duplicatedNouns = new List<Noun>();
            duplicatedVerbs = new List<Verb>();
            bool ok = true;
            foreach (Noun n in Nouns)
            {
                var all = Nouns.FindAll(noun => noun.Name == n.Name);
                if (all.Count > 1)
                {
                    ok = false;
                    duplicatedNouns.Add(n);
                }
            }
            foreach (Verb v in Verbs)
            {
                var all = Verbs.FindAll(verb => verb.Name == v.Name);
                if (all.Count > 1)
                {
                    ok = false;
                    duplicatedVerbs.Add(v);
                }
            }
            return ok;
        }



        public void ToTrees(out Tree<Noun> nounTree, out Tree<Verb> verbTree)
        {
            nounTree = new Tree<Noun>();
            foreach (Noun n in Nouns)
            {
                if (nounTree.GetOrDefault(n) == null)
                {
                    Tree<Noun> local = new Tree<Noun>(n);
                    AddToTree(local, nounTree, Nouns, n1 => Nouns.Find(n2 => n2.Name == n1.ParentNounName));
                }
            }
            verbTree = new Tree<Verb>();
            foreach (Verb v in Verbs)
            {
                if (verbTree.GetOrDefault(v) == null)
                {
                    Tree<Verb> local = new Tree<Verb>(v);
                    AddToTree(local, verbTree, Verbs, n1 => Verbs.Find(n2 => n2.Name == n1.ParentVerbName));
                }
            }
        }

        private static void AddToTree<T>(Tree<T> nodeItem, Tree<T> tree, List<T> allItems, Func<T, T> getParent)
        {
            Tree<T> toAttach = nodeItem;
            Tree<T> treeNode = null;
            while (treeNode == null)
            {
                T parent = getParent(toAttach.RootItem);
                if (parent == null)
                {
                    tree.RootItem = toAttach.RootItem;
                    tree.Children = toAttach.Children;
                    treeNode = tree;
                }
                else
                {
                    treeNode = tree.GetOrDefault(parent);
                    if (treeNode != null)
                    {
                        toAttach.AttachToParent(treeNode);
                        toAttach = treeNode;
                    }
                    else
                    {
                        Tree<T> newTree = new Tree<T>(parent);
                        toAttach.AttachToParent(newTree);
                        toAttach = newTree;
                    }
                }
            }     
        }

        public bool Equals(Vocabulary other)
        {
            if(other == null) return false;
            if(this == other) return true;
            if (Nouns == null && other.Nouns != null) return false;
            if (Verbs == null && other.Verbs != null) return false;
            if (Nouns != null)
            {
                if (Nouns.Count != other.Nouns.Count) return false;
                Nouns.Sort();
                other.Nouns.Sort();
                for (int i = 0; i < Nouns.Count; i++)
                {
                    if (!Nouns[i].Equals(other.Nouns[i]))
                    {
                        return false; 
                    }
                }
            }

            if (Verbs != null)
            {
                if (Verbs.Count != other.Verbs.Count) return false;
                Verbs.Sort();
                other.Verbs.Sort();
                for (int i = 0; i < Verbs.Count; i++)
                {
                    if (!Verbs[i].Equals(other.Verbs[i]))
                    {
                        return false; 
                    }
                }
            }

            return true;

        }
    }
}
