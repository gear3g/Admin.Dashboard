using System.Collections.Generic;
using Admin.Dashboard.Common.Domain;

namespace Admin.Dashboard.Common.Repository
{
    public interface IDomainEventRepository
    {
        void Add<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent;
        IEnumerable<DomainEvent> FindAll();
    }
}