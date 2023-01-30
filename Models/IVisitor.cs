using System.Security.Cryptography;

namespace WebApplicationVisitor.Models
{
    public interface IVisitor
    {
        void Visit(Rectangle rectangle);
        void Visit(Circle circle);
    }
}
