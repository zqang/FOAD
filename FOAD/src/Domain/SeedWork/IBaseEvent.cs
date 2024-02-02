using MediatR;
namespace FOAD.Domain.SeedWork
{
    public interface IBaseEvent : INotification
    {
        DateTime OccurredOn { get; }
    }
}
