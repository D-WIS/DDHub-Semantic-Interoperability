using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using DWIS.Vocabulary.Development;
using System.Collections.Generic;
using System.Linq;

namespace DWIS.Vocabulary.Controls
{
    public class IndividualNode : NodeModel
    {
        public bool Expandable { get; set; } = true;
        public TypedIndividual Individual { get; set; }
        public DWISInstance Instance { get; set; }
        public IndividualNode(TypedIndividual individual,DWISInstance instance, Point position = null, bool expandable = true) : base(id: individual.Name, position)//,  shape:  IndividualNodeShapeDefiner)
        {
            Individual = individual;
            Instance = instance;
            Expandable = expandable;
        }

        public IEnumerable<string> GetAttributes()
        {
            if (Individual != null && Individual.Attributes != null)
            {
                return Individual.Attributes.Select(att => att.AttributeName.ToString() + ": " + (!string.IsNullOrEmpty(att.AttributeValue) ?   att.AttributeValue.ToString() : ""));
            }
            return new List<string>();
        }

        public IEnumerable<Sentence> GetSentences()
        {             
            return Instance.Sentences.Where(s => s.Object == Individual.Name || s.Subject == Individual.Name);
        }

        public IEnumerable<string> GetClasses()
        {
            var c = Instance.ClassAssertions.Where(ca => ca.Subject == Individual.Name).Select(ca => ca.Class);
            return c.Append(Instance.Population.First(p => p.Name == Individual.Name).TypeName);            
        }

        public static IShape IndividualNodeShapeDefiner(NodeModel node)
        {
            var halfWidth = node.Size!.Width / 2;
            var halfHeight = node.Size!.Height / 2;
            var centerX = node.Position.X + halfWidth;
            var centerY = node.Position.Y + node.Size.Height / 2;
            var e = new Blazor.Diagrams.Core.Geometry.Rectangle(node.Position.X - halfWidth, node.Position.Y -halfHeight, node.Position.X + halfWidth, node.Position.Y + halfHeight);
            return e;
        }
    }
}
