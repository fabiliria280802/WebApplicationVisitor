namespace WebApplicationVisitor.Models
{
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
