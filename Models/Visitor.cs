using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace WebApplicationVisitor.Models
{
    public class Visitor : IVisitor
    {
        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Area of Rectangle: " + rectangle.Width * rectangle.Height);
        }

        public void VisitCircle(Circle circle)
        {
            Console.WriteLine("Area of Circle: " + Math.PI * circle.Radius * circle.Radius);
        }
    }
}
