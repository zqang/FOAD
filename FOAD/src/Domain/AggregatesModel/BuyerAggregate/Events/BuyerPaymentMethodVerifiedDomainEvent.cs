using FOAD.Domain.AggregatesModel.BuyerAggregate;

namespace FOAD.Domain.Events;

public class BuyerAndPaymentMethodVerifiedDomainEvent
    : BaseEvent
{
    public Buyer Buyer { get; private set; }
    public PaymentMethod Payment { get; private set; }
    public int OrderId { get; private set; }

    public BuyerAndPaymentMethodVerifiedDomainEvent(Buyer buyer, PaymentMethod payment, int orderId)
    {
        Buyer = buyer;
        Payment = payment;
        OrderId = orderId;
    }
}
