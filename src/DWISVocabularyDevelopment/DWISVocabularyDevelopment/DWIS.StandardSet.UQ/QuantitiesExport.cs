using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWIS.StandardSet.UQ
{
    public static class QuantitiesExport
    {
        public static DWISInstance Export(string vocabularyFolder)
        {
            if (Vocabulary.Utils.VocabularyParsing.FromFolder(vocabularyFolder, out DWISVocabulary vocabulary))
            {
                DWISInstance quantities = new DWISInstance("Quantities", vocabulary);
                quantities.Population = new SimplePopulation();
                quantities.Sentences = new SimpleSentenceCollection();

                Noun quantityNoun = vocabulary.Nouns.Find(n => n.Name == Nouns.Quantity);

                foreach (var quantity in PhysicalQuantity.AvailableQuantities)
                {
                    TypedIndividual individual = new TypedIndividual(quantity.Name, quantityNoun);
                    quantities.Population.Add(individual);

                    List<Attribute> attributes = new List<Attribute>();
                    var att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_I);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.ElectricCurrentDimension.ToString();
                    }
                    att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_J);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.LuminousIntensityDimension.ToString();
                    }
                    att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_L);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.LengthDimension.ToString();
                    }
                    att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_M);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.MassDimension.ToString();
                    }
                    att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_N);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.AmountSubstanceDimension.ToString();
                    }
                    att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_T);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.TimeDimension.ToString();
                    }
                    att = individual.Attributes.FirstOrDefault(a => a.AttributeName == Attributes.Quantity_ThT);
                    if (att != null)
                    {
                        att.AttributeValue = quantity.TemperatureDimension.ToString();
                    }
                }

                return quantities;
            }
            return null;
        }
    }
}
