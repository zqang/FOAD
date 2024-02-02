
namespace FOAD.Domain.Common;
public abstract class BaseEvent : IBaseEvent
{
    public BaseEvent()
    {
        this.OccurredOn = DateTime.Now;
    }

    public DateTime OccurredOn { get; }
}
