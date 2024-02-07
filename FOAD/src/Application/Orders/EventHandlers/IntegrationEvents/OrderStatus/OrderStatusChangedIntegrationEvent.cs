namespace FOAD.Application.Orders.EventHandlers.IntegrationEvents.OrderStatus;

public record OrderStatusChangedIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }
    public string OrderStatus { get; }
    public string BuyerName { get; }
    public string BuyerIdentityGuid { get; }
    public IEnumerable<OrderStockItem> OrderStockItems { get; }

    public OrderStatusChangedIntegrationEvent
        (int orderId, string orderStatus, string buyerName, string buyerIdentityGuid, 
        IEnumerable<OrderStockItem> orderStockItems)
    {
        OrderId = orderId;
        OrderStatus = orderStatus;
        BuyerName = buyerName;
        BuyerIdentityGuid = buyerIdentityGuid;
        OrderStockItems = orderStockItems;
    }
}
