namespace WebApplicationVisitor.Models
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
