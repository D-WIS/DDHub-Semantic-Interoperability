﻿using Newtonsoft.Json;

namespace DWIS.Vocabulary.Development
{
    public class DWISInstance
    {
        public string Name { get; private set; }
        [JsonIgnore]
        public DWISVocabulary Vocabulary { get; private set; }
        public IPopulation Population { get; set; }
        public ISentenceCollection Sentences { get; set; }
        public IClassAssertionCollection ClassAssertions { get; set; }
        public IImplicitSentenceCollection ImplicitSentences { get; set; }
        public Vocabulary InstanceVocabulary { get; set; } = new Vocabulary();
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
            ImplicitSentences = new SimpleImplicitSentenceCollection();

            if (other.Population != null)
            {
                foreach (var i in other.Population)
                {
                    Population.Add(i);
                }
            }
            if (other.Sentences != null)
            {
                foreach (var s in other.Sentences)
                {
                    Sentences.Add(s);
                }
            }
            if (other.ClassAssertions != null)
            {
                foreach (var ca in other.ClassAssertions)
                {
                    ClassAssertions.Add(ca);
                }
            }
            if (other.ImplicitSentences != null)
            {
                foreach (var ca in other.ImplicitSentences)
                {
                    ImplicitSentences.Add(ca);
                }
            }
        }
    }

}
