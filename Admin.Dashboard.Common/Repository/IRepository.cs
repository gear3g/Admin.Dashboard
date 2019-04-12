using System;
using System.Collections.Generic;
using Admin.Dashboard.Common.Domain;
using Admin.Dashboard.Common.Specification;

namespace Admin.Dashboard.Common.Repository
{
    public interface IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity FindById(Guid Id);

        TEntity FindOne(ISpecification<TEntity> spec);

        IEnumerable<TEntity> Find(ISpecification<TEntity> spec);

        void Add(TEntity entity);

        void Remove(TEntity entity);
    }
}
