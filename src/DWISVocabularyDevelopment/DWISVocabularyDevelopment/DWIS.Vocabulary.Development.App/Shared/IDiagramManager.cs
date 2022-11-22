using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWIS.Vocabulary.Development.App.Shared
{
    public interface IDiagramManager
    {
        bool Manage(string inputCode, out string diagramCode);
    }

    public class DiagramManager : IDiagramManager
    {
        public bool Manage(string inputCode, out string diagramCode)
        {
            DWISInstance Instance = new("My graph", DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary);
            Instance.Population = new SimplePopulation();
            Instance.Sentences = new SimpleSentenceCollection();
            Instance.ClassAssertions = new SimpleClassAssertionCollection();
            if (DWIS.Vocabulary.Utils.VocabularyParsing.FromLines(
                inputCode.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(l => l.Trim()).ToArray(),
                DWIS.Vocabulary.Standard.VocabularyProvider.Vocabulary, 
                Instance, 
                false)
                && Instance != null)
            {
                diagramCode = GetDiagramCode(Instance);
                return true;
            }
            diagramCode = "";
            return false;
        }

        private string GetDiagramCode(DWIS.Vocabulary.Development.DWISInstance instance)
        {

            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            stringBuilder.Append("flowchart LR\n");// +
            stringBuilder.AppendLine("\t classDef typeClass fill:#f96;");
            stringBuilder.AppendLine("\t classDef classClass fill:#9dd0ff;");
            stringBuilder.AppendLine("\t classDef attributeClass fill:#1e9c95");

            var types = instance.Population.Select(i => i.TypeName).Distinct();
            var classes = instance.ClassAssertions.Select(i => i.Class).Distinct();

            foreach (var t in types)
            {
                stringBuilder.AppendLine($"{t}[[{t}]]:::typeClass");
            }

            foreach (var c in classes)
            {
                stringBuilder.AppendLine($"{c}[[{c}]]:::classClass");
            }

            foreach (var n in instance.Population)
            {
                stringBuilder.AppendLine($"{n.Name} -- is a --o {n.TypeName}");
                if (n.Attributes != null)
                {
                    foreach (var att in n.Attributes)
                    {
                        if (!string.IsNullOrEmpty(att.AttributeValue))
                        {
                            stringBuilder.AppendLine($"{n.Name} -- {att.AttributeName} --x {n.Name + att.AttributeName}([{att.AttributeValue}]):::attributeClass");
                        }
                    }
                }
            }

            foreach (var n in instance.ClassAssertions)
            {
                stringBuilder.AppendLine($"{n.Subject} --> {n.Class}");
            }

            foreach (var s in instance.Sentences)
            {
                stringBuilder.AppendLine($"{s.Subject} -- {s.Verb} --> {s.Object}");
            }
            return stringBuilder.ToString();
        }


    }
}
