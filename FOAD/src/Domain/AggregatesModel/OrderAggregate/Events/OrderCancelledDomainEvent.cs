namespace FOAD.Domain.Events;

public class OrderCancelledDomainEvent : BaseEvent
{
    public Order Order { get; }

    public OrderCancelledDomainEvent(Order order)
    {
        Order = order;
    }
}

