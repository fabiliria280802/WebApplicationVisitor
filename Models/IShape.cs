namespace WebApplicationVisitor.Models
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
