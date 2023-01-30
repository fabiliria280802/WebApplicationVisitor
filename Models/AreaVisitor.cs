namespace WebApplicationVisitor.Models
{
    public class AreaVisitor : IVisitor
    {
        public double TotalArea { get; set; }

        public void Visit(Circle circle)
        {
            TotalArea += Math.PI * Math.Pow(circle.Radius, 2);
        }

        public void Visit(Rectangle rectangle)
        {
            TotalArea += rectangle.Width * rectangle.Height;
        }
    }
}
