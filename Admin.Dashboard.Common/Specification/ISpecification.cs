using Admin.Dashboard.Common.Domain;

namespace Admin.Dashboard.Common.Specification
{
    public interface ISpecification<TEntity> where TEntity : IAggregateRoot
    {
    }
}