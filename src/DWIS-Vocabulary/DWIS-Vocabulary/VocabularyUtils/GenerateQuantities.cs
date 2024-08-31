using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWIS.Vocabulary.Development;
using Newtonsoft.Json.Linq;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace DWIS.Vocabulary.Utils
{
    public static class GenerateQuantities
    {
        public static bool FromFolder(string folder)
        {
            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                List<BasePhysicalQuantity> quantities = BasePhysicalQuantity.AvailableBasePhysicalQuantities;
                List<BasePhysicalQuantity> drillingQuantities = PhysicalQuantity.AvailablePhysicalQuantities;
                if (quantities != null || drillingQuantities != null)
                {
                    using (StreamWriter writer = new StreamWriter(folder + Path.DirectorySeparatorChar + "QuantityTypes.md"))
                    {
                        writer.WriteLine("-Description: standard quantity types. These are sub-classes of `Quantity`, for which their physical dimension is defined.");
                        writer.WriteLine();
                        writer.WriteLine("# NOUNS");
                        if (quantities != null)
                        {
                            foreach (BasePhysicalQuantity quant in quantities)
                            {
                                if (quant != null && quant.MeaningfulPrecisionInSI == null && !string.IsNullOrEmpty(quant.Name))
                                {
                                    ProcessQuantity(writer, quant);
                                }
                            }
                        }
                        if (drillingQuantities != null)
                        {
                            foreach (BasePhysicalQuantity quant in drillingQuantities)
                            {
                                if (quant != null && quant.MeaningfulPrecisionInSI == null && !string.IsNullOrEmpty(quant.Name))
                                {
                                    ProcessQuantity(writer, quant);
                                }
                            }
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(folder + Path.DirectorySeparatorChar + "MeasurableQuantityTypes.md"))
                {
                    writer.WriteLine("-Description: standard measurable quantity types. A measurable quantity type is a sub-class of `MeasurableQuantity` for which a `MeaningfulPrecision` is defined.");
                    writer.WriteLine();
                    writer.WriteLine("# NOUNS");
                    if (quantities != null)
                    {
                        foreach (BasePhysicalQuantity quant in quantities)
                        {
                            if (quant != null && quant.MeaningfulPrecisionInSI != null && !string.IsNullOrEmpty(quant.Name))
                            {
                                ProcessMeasurableQuantity(writer, quant);
                            }
                        }
                    }
                    if (drillingQuantities != null)
                    {
                        foreach (BasePhysicalQuantity quant in drillingQuantities)
                        {
                            if (quant != null && quant.MeaningfulPrecisionInSI != null && !string.IsNullOrEmpty(quant.Name))
                            {
                                ProcessMeasurableQuantity(writer, quant);
                            }
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(folder + Path.DirectorySeparatorChar + "UnitTypes.md"))
                {
                    writer.WriteLine("-Description: standard measurable quantity types. A measurable quantity type is a sub-class of `MeasurableQuantity` for which a `MeaningfulPrecision` is defined.");
                    writer.WriteLine();
                    writer.WriteLine("# NOUNS");
                    List<string> alreadyProcessed = new List<string>();
                    if (quantities != null)
                    {
                        foreach (BasePhysicalQuantity quant in quantities)
                        {
                            if (quant != null && quant.UnitChoices != null)
                            {
                                foreach (UnitChoice choice in quant.UnitChoices)
                                {
                                    if (!alreadyProcessed.Contains(choice.GetVariableName()))
                                    {
                                        ProcessUnit(writer, choice, alreadyProcessed);
                                    }
                                }
                            }
                        }
                    }
                    if (drillingQuantities != null)
                    {
                        foreach (BasePhysicalQuantity quant in drillingQuantities)
                        {
                            if (quant != null && quant.UnitChoices != null)
                            {
                                foreach (UnitChoice choice in quant.UnitChoices)
                                {
                                    if (!alreadyProcessed.Contains(choice.GetVariableName()))
                                    {
                                        ProcessUnit(writer, choice, alreadyProcessed);
                                    }
                                }
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void ProcessQuantity(StreamWriter writer, BasePhysicalQuantity quant)
        {
            if (writer != null && quant != null && !string.IsNullOrEmpty(quant.Name) && !string.IsNullOrEmpty(quant.GetType().Name))
            {
                writer.WriteLine("## " + quant.GetType().Name + " <!-- NOUN -->");
                writer.WriteLine("- Display name: " + quant.Name);
                writer.WriteLine("- Parent class: Quantity");
                writer.WriteLine("- Specialization: ");
                if (quant.LengthDimension != 0)
                {
                    writer.WriteLine("  - L = " + quant.LengthDimension);
                }
                if (quant.MassDimension != 0)
                {
                    writer.WriteLine("  - M = " + quant.MassDimension);
                }
                if (quant.TimeDimension != 0)
                {
                    writer.WriteLine("  - T = " + quant.TimeDimension);
                }
                if (quant.TemperatureDimension != 0)
                {
                    writer.WriteLine("  - ThT = " + quant.TemperatureDimension);
                }
                if (quant.AmountSubstanceDimension != 0)
                {
                    writer.WriteLine("  - N = " + quant.AmountSubstanceDimension);
                }
                if (quant.ElectricCurrentDimension != 0)
                {
                    writer.WriteLine("  - I = " + quant.ElectricCurrentDimension);
                }
                if (quant.LuminousIntensityDimension != 0)
                {
                    writer.WriteLine("  - J = " + quant.LuminousIntensityDimension);
                }
                if (quant.PlaneAngleDimension != 0)
                {
                    writer.WriteLine("  - Theta = " + quant.PlaneAngleDimension);
                }
                if (quant.SolidAngleDimension != 0)
                {
                    writer.WriteLine("  - Omega = " + quant.SolidAngleDimension);
                }
                writer.WriteLine("- Description: ");
                if (!string.IsNullOrEmpty(quant.DescriptionMD))
                {
                    string[] desc = quant.DescriptionMD.Split(Environment.NewLine);
                    if (desc.Length > 1 && string.IsNullOrEmpty(desc[0]))
                    {
                        string[] desc2 = new string[desc.Length - 2];
                        desc.CopyTo(desc2, 1);
                        desc = desc2;
                    }
                    foreach (string d in desc)
                    {
                        writer.WriteLine(d);
                    }
                }
                writer.WriteLine("- Examples: ");
                if (quant.SemanticExample != null && quant.SemanticExample.Count > 0)
                {
                    writer.WriteLine("``` dwis");
                    foreach (var fact in quant.SemanticExample)
                    {
                        if (fact != null && !string.IsNullOrEmpty(fact.Subject) && !string.IsNullOrEmpty(fact.Verb) && !string.IsNullOrEmpty(fact.Object))
                        {
                            if (fact.Verb.Equals("BelongsToClass"))
                            {
                                writer.WriteLine(fact.Object + ":" + fact.Subject);
                            }
                            else
                            {
                                writer.WriteLine(fact.Subject + " " + fact.Verb + " " + fact.Object);
                            }
                        }
                    }
                    writer.WriteLine("```");
                }
            }
        }

        private static void ProcessMeasurableQuantity(StreamWriter writer, BasePhysicalQuantity quant)
        {
            if (writer != null && quant != null && !string.IsNullOrEmpty(quant.Name) && quant.MeaningfulPrecisionInSI != null && !string.IsNullOrEmpty(quant.GetType().Name))
            {
                writer.WriteLine("## " + quant.GetType().Name + " <!-- NOUN -->");
                writer.WriteLine("- Display name: " + quant.Name);
                writer.WriteLine("- Parent class: MeasurableQuantity");
                writer.WriteLine("- Specialization: ");
                writer.WriteLine("  - MeaningfulPrecision = " + quant.MeaningfulPrecisionInSI.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                writer.WriteLine("- Description: ");
                if (!string.IsNullOrEmpty(quant.DescriptionMD))
                {
                    string[] desc = quant.DescriptionMD.Split(Environment.NewLine);
                    if (desc.Length > 1 && string.IsNullOrEmpty(desc[0]))
                    {
                        string[] desc2 = new string[desc.Length - 2];
                        desc.CopyTo(desc2, 1);
                        desc = desc2;
                    }
                    foreach (string d in desc)
                    {
                        writer.WriteLine(d); 
                    }
                }
                writer.WriteLine("- Examples: ");
                if (quant.SemanticExample != null && quant.SemanticExample.Count > 0)
                {
                    writer.WriteLine("``` dwis");
                    foreach (var fact in quant.SemanticExample)
                    {
                        if (fact != null && !string.IsNullOrEmpty(fact.Subject) && !string.IsNullOrEmpty(fact.Verb) && !string.IsNullOrEmpty(fact.Object))
                        {
                            if (fact.Verb.Equals("BelongsToClass"))
                            {
                                writer.WriteLine(fact.Object + ":" + fact.Subject);
                            }
                            else
                            {
                                writer.WriteLine(fact.Subject + " " + fact.Verb + " " + fact.Object);
                            }
                        }
                    }
                    writer.WriteLine("```");
                }
            }
        }

        private static void ProcessUnit(StreamWriter writer, UnitChoice choice, List<string> alreadyProcessed)
        {
            if (writer != null && choice != null && !string.IsNullOrEmpty(choice.UnitName) && !string.IsNullOrEmpty(choice.GetVariableName()))
            {
                string var = choice.GetVariableName();
                writer.WriteLine("## " + var + " <!-- NOUN -->");
                writer.WriteLine("- Display name: " + choice.UnitName);
                writer.WriteLine("- Parent class: Unit");
                writer.WriteLine("- Specialization: ");
                if (choice.ConversionBiasFromSI != 0)
                {
                    writer.WriteLine("  - ConversionFactorA = " + choice.ConversionBiasFromSI.ToString(System.Globalization.CultureInfo.InvariantCulture));
                }
                if (choice.ConversionFactorFromSI != 1)
                {
                    writer.WriteLine("  - ConversionFactorB = " + choice.ConversionFactorFromSI.ToString(System.Globalization.CultureInfo.InvariantCulture));
                }
                writer.WriteLine("- Description: ");
                if (!string.IsNullOrEmpty(choice.ConversionDescription))
                {
                    string[] desc = choice.ConversionDescription.Split(Environment.NewLine);
                    if (desc.Length > 1 && string.IsNullOrEmpty(desc[0]))
                    {
                        string[] desc2 = new string[desc.Length - 2];
                        desc.CopyTo(desc2, 1);
                        desc = desc2;
                    }
                    foreach (string d in desc)
                    {
                        writer.WriteLine(d);
                    }
                }
                writer.WriteLine("- Examples: ");
                if (choice != null && !string.IsNullOrEmpty(choice.GetVariableName()))
                {
                    writer.WriteLine("``` dwis");
                    writer.WriteLine(var + ":" + var + "_1");
                    if (choice.ConversionBiasFromSI != 0)
                    {
                        writer.WriteLine(var + "_1" + ".ConversionFactorA" + " = " + "\"" + choice.ConversionBiasFromSI.ToString(System.Globalization.CultureInfo.InvariantCulture) + "\"");
                    }
                    if (choice.ConversionFactorFromSI != 1)
                    {
                        writer.WriteLine(var + "_1" + ".ConversionFactorB" + " = " + "\"" + choice.ConversionFactorFromSI.ToString(System.Globalization.CultureInfo.InvariantCulture) + "\"");
                    }
                    if (!string.IsNullOrEmpty(choice.UnitLabel))
                    {
                        writer.WriteLine(var + "_1" + ".Symbol" + " = " + "\"" + choice.UnitLabel + "\"");
                    }
                    writer.WriteLine("```");
                }
                alreadyProcessed.Add(var);
            }
        }
    }
}
