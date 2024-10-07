using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWIS.StandardSet.UQ
{
    public static class QuantitiesExport
    {
        private static string CorrectName(string original)
        {
            string correctedName = original.Replace("/", "Per");
            correctedName = correctedName.Replace("\"", "");
            return correctedName;
        }
        private static string GetValidName(string originalName)
        {
            if (string.IsNullOrEmpty(originalName)) { return originalName; }
            string validName = originalName.Replace(" ", "").Replace("/", "Per").Replace("\"", "");
            string first = validName.Substring(0, 1).ToLower();
            return Correct(first + validName.Substring(1));
        }


        private static string Correct(string symbol)
        {
            string corrected = symbol.Replace("²", "square")
                    .Replace("µ", "mu")
                    .Replace("°", "deg")
                    .Replace("³", "cubic")
                    .Replace("•", ".")
                    .Replace("Ω", "omega")
                    .Replace("å", "aa")
                    .Replace("Å", "AA")
                    .Replace("ø", "oe")
                    .Replace("☉", "solarMass")
                    .Replace("🜨", "earthMass")
                    .Replace("é", "e")
                    .Replace("‰", "perThousands")
                    .Replace("√", "sqrt ");
            if (corrected.Any(c => !char.IsLetterOrDigit(c)))
            {
                throw new Exception("symbol still contains special characters");
            }
            return corrected;
        }


        public static DWISInstance? Export(string vocabularyFolder)
        {
            if (VocabularyParsing.FromFolder(vocabularyFolder, out DWISVocabulary vocabulary))
            {
                DWISInstance quantities = new DWISInstance("Quantities", vocabulary);
                quantities.Population = new SimplePopulation();
                quantities.Sentences = new SimpleSentenceCollection();
                quantities.ClassAssertions = new SimpleClassAssertionCollection();

                if (vocabulary.GetNoun(Nouns.Quantity, out Noun quantityNoun) 
                    && vocabulary.GetNoun(Nouns.Unit, out Noun unitNoun)
                    && vocabulary.GetVerb(Verbs.HasSIUnit, out Verb hasSIUnitVerb)
                    && vocabulary.GetVerb(Verbs.IsUnitForQuantity, out Verb isUnitForQuantityVerb)
                    )
                {
                    foreach (var quantity in BasePhysicalQuantity.AvailableBasePhysicalQuantities)
                    {
                        TypedIndividual quantityIndividual = new TypedIndividual(GetValidName(quantity.Name), quantityNoun, vocabulary);
                        quantities.Population.Add(quantityIndividual);

                        IndividualAttribute att;

                        if (quantityIndividual.GetAttribute(Attributes.Quantity_I, out att))
                        {
                            att.AttributeValue = quantity.ElectricCurrentDimension.ToString();
                        }
                        if (quantityIndividual.GetAttribute(Attributes.Quantity_J, out att))
                        {
                            att.AttributeValue = quantity.LuminousIntensityDimension.ToString();
                        }
                        if (quantityIndividual.GetAttribute(Attributes.Quantity_L, out att))
                        {
                            att.AttributeValue = quantity.LengthDimension.ToString();
                        }
                        if (quantityIndividual.GetAttribute(Attributes.Quantity_M, out att))
                        {
                            att.AttributeValue = quantity.MassDimension.ToString();
                        }
                        if (quantityIndividual.GetAttribute(Attributes.Quantity_N, out att))
                        {
                            att.AttributeValue = quantity.AmountSubstanceDimension.ToString();
                        }
                        if (quantityIndividual.GetAttribute(Attributes.Quantity_T, out att))
                        {
                            att.AttributeValue = quantity.TimeDimension.ToString();
                        }
                        if (quantityIndividual.GetAttribute(Attributes.Quantity_ThT, out att))
                        {
                            att.AttributeValue = quantity.TemperatureDimension.ToString();
                        }

                        

                        if (quantity.UnitChoices != null)
                        {
                            foreach (var unit in quantity.UnitChoices)
                            {
                                TypedIndividual unitIndividual = new TypedIndividual(GetValidName(unit.UnitName), unitNoun, vocabulary);

                                if (unitIndividual.Name == "arcsecond")
                                {
                                    unit.UnitLabel = "arcsec";                                   
                                }


                                if (unitIndividual.GetAttribute(Attributes.Unit_ConversionFactorA, out att))
                                {
                                    att.AttributeValue = unit.ConversionBiasFromSI.ToString();
                                }
                                if (unitIndividual.GetAttribute(Attributes.Unit_ConversionFactorB, out att))
                                {
                                    att.AttributeValue = unit.ConversionFactorFromSI.ToString();
                                }
                                if (unitIndividual.GetAttribute(Attributes.Unit_Symbol, out att))
                                {
                                    att.AttributeValue = GetValidName(unit.UnitLabel.ToString());
                                }
                                quantities.Population.Add(unitIndividual);

                                if (unit.UnitName == quantity.SIUnitName)
                                {
                                    quantities.Sentences.Add(new Sentence(quantityIndividual,hasSIUnitVerb, unitIndividual));
                                }
                                quantities.Sentences.Add(new Sentence(unitIndividual, isUnitForQuantityVerb, quantityIndividual));
                            }
                        }
                    }
                }

                return quantities;
            }
            return null;
        }
    }
}
