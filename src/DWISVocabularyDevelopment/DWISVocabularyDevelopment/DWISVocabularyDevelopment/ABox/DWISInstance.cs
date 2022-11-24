using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DWIS.Vocabulary.Development
{
    public class DWISInstance
    {
        public string Name { get;private set; }
        [JsonIgnore]
        public DWISVocabulary Vocabulary { get;private set; }
        public IPopulation Population{ get; set; }
        public ISentenceCollection Sentences { get; set; }
        public IClassAssertionCollection ClassAssertions { get; set; }
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

        public static void ToJsonFile(DWISInstance instance, string fileName)
        {
            System.IO.File.WriteAllText(fileName, Newtonsoft.Json.JsonConvert.SerializeObject(instance, Formatting.Indented));
        }

        public static DWISInstance FromJsonFile(string fileName)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DWISInstance>(System.IO.File.ReadAllText(fileName));
        }
        public static DWISInstance FromJsonString(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DWISInstance>(json);
        }

        public DWISInstance(DWISInstance other)
        {
            Name = other.Name;
            Population = new SimplePopulation();
            Sentences = new SimpleSentenceCollection();
            ClassAssertions = new SimpleClassAssertionCollection();

            foreach (var i in other.Population) 
            {
                Population.Add(i);
            }
            foreach (var s in other.Sentences)
            {
                Sentences.Add(s);
            }
            foreach (var ca in other.ClassAssertions)
            {
                ClassAssertions.Add(ca);
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
    public interface IClassAssertionCollection : ICollection<ClassAssertion>
    { }

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
