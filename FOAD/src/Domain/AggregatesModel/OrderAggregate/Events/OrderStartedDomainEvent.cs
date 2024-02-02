
namespace FOAD.Domain.Events;

/// <summary>
/// Event used when an order is created
/// </summary>
public class OrderStartedDomainEvent(
Order order,
string UserId,
string UserName,
int CardTypeId,
string CardNumber,
string CardSecurityNumber,
string CardHolderName,
DateTime CardExpiration) : BaseEvent
{
    public Order Order { get; } = order;
    public string UserId { get; } = UserId;
    public string UserName { get; } = UserName;
    public int CardTypeId { get; } = CardTypeId;
    public string CardNumber { get; } = CardNumber;
    public string CardSecurityNumber { get; } = CardSecurityNumber;
    public string CardHolderName { get; } = CardHolderName;
    public DateTime CardExpiration { get; } = CardExpiration;
    
}
