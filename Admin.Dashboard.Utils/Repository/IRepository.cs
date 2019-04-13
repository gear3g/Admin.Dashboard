using System;
using System.Collections.Generic;
using Admin.Dashboard.Utils.Domain;
using Admin.Dashboard.Utils.Specification;

namespace Admin.Dashboard.Utils.Repository
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
