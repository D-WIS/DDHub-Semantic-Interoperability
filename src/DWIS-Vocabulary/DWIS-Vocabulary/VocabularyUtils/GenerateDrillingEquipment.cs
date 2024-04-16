using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using OfficeOpenXml;
using System.Xml.Serialization;
using System.Net.NetworkInformation;

namespace DWIS.Vocabulary.Utils
{
    public static class GenerateDrillingEquipment
    {
        public static bool FromFolder(string folder)
        {
            if (!string.IsNullOrEmpty(folder))
            {
                bool success = false;
                string src = folder + Path.DirectorySeparatorChar + "DrillingEquipment.xlsx";
                if (File.Exists(src))
                {
                    List<List<string>> list = new List<List<string>>();
                    using (ExcelPackage package = new ExcelPackage(new FileInfo(src)))
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        if (package != null && package.Workbook != null && package.Workbook.Worksheets != null && package.Workbook.Worksheets.Count > 0)
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                            if (worksheet != null && worksheet.Dimension != null)
                            {
                                int rowCount = worksheet.Dimension.Rows;
                                int colCount = worksheet.Dimension.Columns;
                                if (rowCount > 2 && colCount >= 9)
                                {
                                    for (int i = 2; i < rowCount; i++)
                                    {
                                        List<string> names = new List<string>() { "DWISNoun" };
                                        for (int j = 2; j < colCount; j++)
                                        {
                                            if (worksheet.Cells[i, j] == null || worksheet.Cells[i, j].Value == null || (worksheet.Cells[i, j].Value is string && string.IsNullOrEmpty(worksheet.Cells[i, j].Value as string)))
                                            {
                                                break;
                                            }
                                            else if (worksheet.Cells[i, j] != null && worksheet.Cells[i, j].Value != null && worksheet.Cells[i, j].Value is string)
                                            {
                                                names.Add(worksheet.Cells[i, j].Value as string);
                                            }
                                        }
                                        list.Add(names);
                                    }
                                }
                            }
                        }
                    }
                    if (list != null && list.Count > 0)
                    {
                        List<Tuple<string, string, string>> data = new List<Tuple<string, string, string>>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] != null && list[i].Count > 0)
                            {
                                data.Add(new Tuple<string, string, string>(NormalizeNoun(list[i].Last<string>()), list[i].Last<string>(), NormalizeNoun(list[i][list[i].Count - 2])));
                            }
                        }
                        bool duplicate = false;
                        bool unsolved = false;
                        do
                        {
                            duplicate = false;
                            for (int i = 0; i < data.Count; i++)
                            {
                                if (data[i] != null && !string.IsNullOrEmpty(data[i].Item1))
                                {
                                    string name = data[i].Item1;
                                    for (int j = i + 1; j < data.Count; j++)
                                    {
                                        if (data[j] != null && !string.IsNullOrEmpty(data[j].Item1))
                                        {
                                            if (name == data[j].Item1)
                                            {
                                                duplicate = true;
                                                string name1 = string.Empty;
                                                string name2 = string.Empty;
                                                for (int k1 = list[i].Count - 1, k2 = list[j].Count - 1; k1 >= 0 && k2 >= 0; k1--, k2--)
                                                {
                                                    name1 = NormalizeNoun(list[i][k1] + " " + name1);
                                                    name2 = NormalizeNoun(list[j][k2] + " " + name2);
                                                    if (name1 != name2)
                                                    {
                                                        data[i] = new Tuple<string, string, string>(name1, data[i].Item2, data[i].Item3);
                                                        data[j] = new Tuple<string, string, string>(name2, data[j].Item2, data[j].Item3);
                                                        break;
                                                    }
                                                }
                                                if (name1 == name2)
                                                {
                                                    unsolved = true;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } while (duplicate && !unsolved);

                        if (!unsolved)
                        {
                            List<Tuple<string, string, string>> addendum = new List<Tuple<string, string, string>>()
                            {
                                new Tuple<string, string, string>("MudStandpipeManifold", "Mud Standpipe Manifold", "MudSystem"),
                                new Tuple<string, string, string>("ThreeWayValve", "Three Way Valve", "MudSystem")
                            };
                            foreach (var entry in  addendum)
                            {
                                bool found = false;
                                foreach (var dat in data)
                                {
                                    if (dat != null && dat.Item1 == entry.Item1)
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                                if (!found)
                                {
                                    data.Add(entry);
                                }
                            }
                            using (StreamWriter writer = new StreamWriter(folder + Path.DirectorySeparatorChar + "DrillingEquipment.md"))
                            {
                                writer.WriteLine("- Description: in this category fall all the standard equipment encountered on a drilling rig. Note that the goal of the vocabulary is not to provide a detailed description of the rig. Therefore we only consider nouns that can help providing a signal context.");
                                writer.WriteLine();
                                writer.WriteLine("# NOUNS");

                                foreach (var dat in data)
                                {
                                    if (dat != null && !string.IsNullOrEmpty(dat.Item1) && !string.IsNullOrEmpty(dat.Item2) && !string.IsNullOrEmpty(dat.Item3))
                                    {
                                        writer.WriteLine("## " + dat.Item1 + " <!-- NOUN -->");
                                        writer.WriteLine("- Display name: " + dat.Item2);
                                        writer.WriteLine("- Parent class: " + dat.Item3);
                                        writer.WriteLine("- Description:");
                                        writer.WriteLine("- Examples:");
                                    }
                                }
                                writer.WriteLine();
                                writer.WriteLine("# VERBS");
                                writer.WriteLine("## IsSubPartOf <!-- VERB -->");
                                writer.WriteLine("- Display name: IsSubPartOf");
                                writer.WriteLine("- Parent verb: DWISVerb");
                                writer.WriteLine("- Subject class: DrillingEquipment");
                                writer.WriteLine("- Object class: DrillingEquipment");
                                writer.WriteLine("- Description:");
                                writer.WriteLine("- Examples:");
                                success = true;
                            }
                        }
                    }
                }
                return success;
            }
            else
            {
                return false;
            }
        }

        private static string NormalizeNoun(string noun)
        {
            if (!string.IsNullOrEmpty(noun))
            {
                if (noun == "Telemetry")
                {
                    return "EquipmentTelemetry";
                }
                else if (noun == "DWISNoun")
                {
                    return "DWISNoun";
                }
                else
                {
                    string[] tokens = noun.Split(' ', '\t');
                    if (tokens != null && tokens.Length > 0)
                    {
                        string normalizedNoun = string.Empty;
                        foreach (string token in tokens)
                        {
                            if (!string.IsNullOrEmpty(token))
                            {
                                string str = token;
                                str = str.Replace("&", "And");
                                str = str.Replace("-", "");
                                StringBuilder builder = new StringBuilder();
                                foreach (char c in str)
                                {
                                    if (char.IsLetter(c) || c == '_' || char.IsDigit(c))
                                    {
                                        builder.Append(c);
                                    }
                                }
                                str = builder.ToString();
                                if (!string.IsNullOrEmpty(str))
                                {
                                    str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
                                    normalizedNoun += str;
                                }
                                else
                                {

                                }
                            }
                        }
                        return normalizedNoun;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
