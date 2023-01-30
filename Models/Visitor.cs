using Microsoft.AspNetCore.Rewrite;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace WebApplicationVisitor.Models
{
    public class Visitor : IVisitor
    {
        public class AreaVisitor
        {
            public double TotalArea { get; set; }

            public void VisitCircle(Circle circle)
            {
                TotalArea += Math.PI * Math.Pow(circle.Radius, 2);
            }

            public void VisitRectangle(Rectangle rectangle)
            {
                TotalArea += rectangle.Height * rectangle.Width;
            }
        }

        public class PerimeterVisitor
        {
            public double TotalPerimeter { get; set; }

            public void VisitCircle(Circle circle)
            {
                TotalPerimeter += 2 * Math.PI * circle.Radius;
            }

            public void VisitRectangle(Rectangle rectangle)
            {
                TotalPerimeter += 2 * (rectangle.Height + rectangle.Width);
            }
        }
    }
}
