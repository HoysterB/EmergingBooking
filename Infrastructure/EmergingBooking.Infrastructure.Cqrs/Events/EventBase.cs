namespace EmergingBooking.Infrastructure.Cqrs.Events;

public class EventBase : IEvent
{
    public Guid EventId => Guid.NewGuid();
    public string EventName { get; }
    public string Version { get; }
    public DateTime OccurredAt { get; }

    public EventBase(string eventName, string version)
    {
        EventName = eventName;
        Version = version;
        OccurredAt = DateTime.UtcNow;
    }
}