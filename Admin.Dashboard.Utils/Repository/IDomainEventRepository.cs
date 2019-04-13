using System.Collections.Generic;
using Admin.Dashboard.Utils.Domain;

namespace Admin.Dashboard.Utils.Repository
{
    public interface IDomainEventRepository
    {
        void Add<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent;
        IEnumerable<DomainEvent> FindAll();
    }
}