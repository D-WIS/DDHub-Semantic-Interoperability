using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using DWIS.Vocabulary.Development;

namespace DWIS.Vocabulary.Controls
{
    public class NounNode : NodeModel
    {
        public bool IsType { get; set; }
        public Noun Noun { get; set; }
        public NounNode(Noun noun, Point position = null, bool isType = false) : base(id: noun.Name, position)//, shape: NounNodeShapeDefiner)//  (n) => Blazor.Diagrams.Core.Geometry.Shapes.Circle(n))
        {
            Noun = noun;
            IsType = isType;
        }


        public static IShape NounNodeShapeDefiner(NodeModel node)
        {
            var halfWidth = node.Size!.Width / 2;
            var centerX = node.Position.X + halfWidth;
            var centerY = node.Position.Y + node.Size.Height / 2;
            var e= new Blazor.Diagrams.Core.Geometry.Ellipse(centerX, centerY, halfWidth, halfWidth);
            return e;
        }
    }
}
