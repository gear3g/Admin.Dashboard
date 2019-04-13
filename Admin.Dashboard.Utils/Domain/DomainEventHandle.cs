using Admin.Dashboard.Utils.Logging;
using Admin.Dashboard.Utils.Repository;

namespace Admin.Dashboard.Utils.Domain
{
    public class DomainEventHandle<TDomainEvent> : Handles<TDomainEvent>
        where TDomainEvent : DomainEvent
    {
        private IDomainEventRepository _domainEventRepository;
        private IRequestCorrelationIdentifier _requestCorrelationIdentifier;

        public DomainEventHandle(IDomainEventRepository domainEventRepository,
            IRequestCorrelationIdentifier requestCorrelationIdentifier)
        {
            _domainEventRepository = domainEventRepository;
            _requestCorrelationIdentifier = requestCorrelationIdentifier;
        }
        public void Handle(TDomainEvent @event)
        {
            @event.Flatten();
            @event.CorrelationID = this._requestCorrelationIdentifier.CorrelationID;

            _domainEventRepository.Add(@event);
        }
    }

}