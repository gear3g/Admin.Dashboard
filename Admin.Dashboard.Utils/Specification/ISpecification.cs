using Admin.Dashboard.Utils.Domain;

namespace Admin.Dashboard.Utils.Specification
{
    public interface ISpecification<TEntity> where TEntity : IAggregateRoot
    {
    }
}