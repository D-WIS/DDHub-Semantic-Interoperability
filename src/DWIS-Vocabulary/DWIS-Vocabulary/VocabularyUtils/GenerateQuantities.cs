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
                List<PhysicalQuantity> quantities = PhysicalQuantity.AvailableQuantities;
                List<PhysicalQuantity> drillingQuantities = DrillingPhysicalQuantity.AvailableQuantities;
                if (quantities != null || drillingQuantities != null)
                {
                    using (StreamWriter writer = new StreamWriter(folder + Path.DirectorySeparatorChar + "QuantityTypes.md"))
                    {
                        writer.WriteLine("-Description: standard quantity types. These are sub-classes of `Quantity`, for which their physical dimension is defined.");
                        writer.WriteLine();
                        writer.WriteLine("# NOUNS");
                        if (quantities != null)
                        {
                            foreach (PhysicalQuantity quant in quantities)
                            {
                                if (quant != null && quant.MeaningfulPrecisionInSI == null && !string.IsNullOrEmpty(quant.Name))
                                {
                                    ProcessQuantity(writer, quant);
                                }
                            }
                        }
                        if (drillingQuantities != null)
                        {
                            foreach (PhysicalQuantity quant in drillingQuantities)
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
                        foreach (PhysicalQuantity quant in quantities)
                        {
                            if (quant != null && quant.MeaningfulPrecisionInSI != null && !string.IsNullOrEmpty(quant.Name))
                            {
                                ProcessMeasurableQuantity(writer, quant);
                            }
                        }
                    }
                    if (drillingQuantities != null)
                    {
                        foreach (PhysicalQuantity quant in drillingQuantities)
                        {
                            if (quant != null && quant.MeaningfulPrecisionInSI != null && !string.IsNullOrEmpty(quant.Name))
                            {
                                ProcessMeasurableQuantity(writer, quant);
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
        private static void ProcessQuantity(StreamWriter writer, PhysicalQuantity quant)
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
                writer.WriteLine("- Description: ");
                writer.WriteLine("- Examples: ");
            }
        }

        private static void ProcessMeasurableQuantity(StreamWriter writer, PhysicalQuantity quant)
        {
            if (writer != null && quant != null && !string.IsNullOrEmpty(quant.Name) && quant.MeaningfulPrecisionInSI != null && !string.IsNullOrEmpty(quant.GetType().Name))
            {
                writer.WriteLine("## " + quant.GetType().Name + " <!-- NOUN -->");
                writer.WriteLine("- Display name: " + quant.Name);
                writer.WriteLine("- Parent class: MeasurableQuantity");
                writer.WriteLine("- Specialization: ");
                writer.WriteLine("  - MeaningfulPrecision = " + quant.MeaningfulPrecisionInSI.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
                writer.WriteLine("- Description: ");
                writer.WriteLine("- Examples: ");
            }
        }
    }
}
