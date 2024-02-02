namespace FOAD.Domain.Events;

public class OrderShippedDomainEvent : BaseEvent
{
    public Order Order { get; }

    public OrderShippedDomainEvent(Order order)
    {
        Order = order;
    }
}
