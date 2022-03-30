namespace Nominas.Domain.Base
{
    public abstract class Entity
    {
        private List<Event> _events;
        public IReadOnlyList<Event> Events => _events.AsReadOnly();

        protected void AddEvent(Event @event)
        {
            _events.Add(@event);
        }

        protected void RemoveEvent(Event @event)
        {
            _events.Remove(@event);
        }
    }

    public abstract class Entity<TKey> : Entity
    {
        public TKey Id { get; set; }
    }
}
