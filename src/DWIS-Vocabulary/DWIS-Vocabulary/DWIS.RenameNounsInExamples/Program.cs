// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string examplePath = "C:\\DWIS\\DDHub-Semantic-Interoperability\\docs\\vocabulary_development\\examples";
string[] examples = Directory.GetFiles(examplePath, "*.md");
List<Tuple<string, string>> renameList = new List<Tuple<string, string>>()
{
    new Tuple<string, string>("StandPipe", "MudStandpipe"),
    new Tuple<string, string>("TopDriveShaft", "Quill"),
    new Tuple<string, string>("GateValve", "GenericEquipmentGatevalve"),
    new Tuple<string, string>("ActivePit", "ActiveDrillingSystem"),
    new Tuple<string, string>("Bit", "DrillingBit"),
    new Tuple<string, string>("UnderReamer", "Underreamers"),
    new Tuple<string, string>("Elevator", "DrillPipeElevator"),
    new Tuple<string, string>("Slips", "RotarySlips"),
    new Tuple<string, string>("DrawWorks", "Drawworks"),
    new Tuple<string, string>("TopDriveBody", "MainframeAssembly"),
    new Tuple<string, string>("TopDriveHook", "Hook"),
};
if (examples != null)
{
    foreach (string example in examples)
    {
        using (StreamReader reader = new StreamReader(example))
        {
            using (StreamWriter writer = new StreamWriter(example + ".new"))
            {
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        if (line.Contains(':'))
                        {
                            string[] strings = line.Split(':');
                            if (strings != null && strings.Length > 0)
                            {
                                foreach (var tuple in renameList)
                                {
                                    if (!string.IsNullOrEmpty(tuple.Item1) &&
                                        ("- " + tuple.Item1) == strings[0]) 
                                    {
                                        strings[0] = "- " + tuple.Item2;
                                        line = strings[0];
                                        for (int i = 1; i < strings.Length; i++)
                                        {
                                            line += ":" + strings[i];
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        else if (line.Contains("BelongsToClass"))
                        {
                            string[] strings = line.Split(' ', '\t');
                            if (strings != null && strings.Length > 0)
                            {
                                int pos = 0;
                                foreach (string str in strings)
                                {
                                    if ( str == "BelongsToClass") 
                                    {
                                        pos++;
                                        break;
                                    }
                                    pos++;
                                }
                                if (pos < strings.Length)
                                {
                                    foreach (var tuple in renameList)
                                    {
                                        if (!string.IsNullOrEmpty(tuple.Item1) &&
                                            tuple.Item1 == strings[pos])
                                        {
                                            strings[pos] = tuple.Item2;
                                            line = string.Empty;
                                            bool isFirst = true;
                                            for (int i = 1; i < strings.Length; i++)
                                            {
                                                if (isFirst)
                                                {
                                                    isFirst = false;
                                                }
                                                else
                                                {
                                                    line += " ";
                                                }
                                                line += strings[i];
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        writer.WriteLine(line);
                    }
                }
            }
        }
        File.Delete(example);
        File.Move(example + ".new", example);
    }
}
