// See https://aka.ms/new-console-template for more information
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
    new Tuple<string, string>("FlowRateQuantity", "DrillingVolumetricFlowrateQuantity"),
    new Tuple<string, string>("PumpRateQuantity", "RotationFrequencyQuantity"),
    new Tuple<string, string>("BitTorqueQuantity", "DrillingTorqueQuantity"),
    new Tuple<string, string>("BlockAccelerationQuantity", "DrillingAccelerationQuantity"),
    new Tuple<string, string>("BlockPositionQuantity", "PositionQuantity"),
    new Tuple<string, string>("EMWQuantity", "DrillingDensityQuantity"),
    new Tuple<string, string>("MassDensityQuantity", "DrillingDensityQuantity"),
    new Tuple<string, string>("VolumetricRateQuantity", "DrillingVolumetricFlowrateQuantity"),
    new Tuple<string, string>("FluidDensityInQuantity", "DrillingDensityQuantity"),
    new Tuple<string, string>("FluidTemperatureInQuantity", "DrillingTemperatureQuantity"),
    new Tuple<string, string>("HookloadQuantity", "HookLoadQuantity"),
    new Tuple<string, string>("SPPQuantity", "DrillingPressureQuantity"),
    new Tuple<string, string>("SurfaceRPMQuantity", "RotationFrequencyQuantity"),
    new Tuple<string, string>("SurfaceTorqueQuantity", "DrillingTorqueQuantity"),
    new Tuple<string, string>("TopOfStringForceQuantity", "DrillingForceQuantity"),
    new Tuple<string, string>("TVDQuantity", "DepthQuantity"),
    new Tuple<string, string>("WOBQuantity", "WeightOnBitQuantity"),
    new Tuple<string, string>("Resistivity", "FormationResistivityQuantity"),
    new Tuple<string, string>("ElectricResistivityQuantity", "FormationResistivityQuantity"),
    new Tuple<string, string>("RockDensityQuantity", "DrillingDensityQuantity"),
    new Tuple<string, string>("FormationPorosityQuantity", "PorosityQuantity"),
    new Tuple<string, string>("DownholePressureQuantity", "DrillingPressureQuantity"),

    new Tuple<string, string>("DrillingVolumetricFlowrateQuantity", "VolumetricFlowrateDrillingQuantity"),
    new Tuple<string, string>("RotationFrequencyQuantity", "RotationalFrequencyQuantity"),
    new Tuple<string, string>("DrillingTorqueQuantity", "TorqueDrillingQuantity"),
    new Tuple<string, string>("DrillingAccelerationQuantity", "AccelerationDrillingQuantity"),
    new Tuple<string, string>("PositionQuantity", "PositionDrillingQuantity"),
    new Tuple<string, string>("DrillingDensityQuantity", "MassDensityDrilling"),
    new Tuple<string, string>("DrillingTemperatureQuantity", "TemperatureDrillingQuantity"),
    new Tuple<string, string>("HookLoadQuantity", "HookLoadDrillingQuantity"),
    new Tuple<string, string>("DrillingPressureQuantity", "PressureDrillingQuantity"),
    new Tuple<string, string>("DrillingForceQuantity", "ForceDrillingQuantity"),
    new Tuple<string, string>("DepthQuantity", "DepthDrillingQuantity"),
    new Tuple<string, string>("WeightOnBitQuantity", "WeightOnBitDrillingQuantity"),
    new Tuple<string, string>("FormationResistivityQuantity", "FormationResistivityDrillingQuantity"),
    new Tuple<string, string>("BlockVelocityQuantity", "BlockVelocityDrillingQuantity"),
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
