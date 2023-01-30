namespace WebApplicationVisitor.Models
{
    class Client
    {
        private List<IShape> _shapes = new List<IShape>();
        private AreaVisitor _visitor = new AreaVisitor();

        public Client()
        {
            _shapes.Add(new Circle(2));
            _shapes.Add(new Rectangle(3, 4));
            _shapes.Add(new Circle(5));
        }

        public void Run()
        {
            foreach (var shape in _shapes)
            {
                shape.Accept(_visitor);
            }
            Console.WriteLine("Total area: " + _visitor.TotalArea);
        }
    }
}
