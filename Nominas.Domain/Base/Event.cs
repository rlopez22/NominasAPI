using MediatR;

namespace Nominas.Domain.Base
{
    public abstract class Event : INotification
    {
        public Event()
        {
            EventId = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        public virtual Guid EventId { get; init; }
        public virtual DateTime CreatedOn { get; init; }
    }
}
