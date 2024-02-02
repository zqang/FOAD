namespace FOAD.Application.Common.Commands.Identified;
// CommandMappingService.cs
public class CommandMappingExtension
{
    public (string idProperty, string commandId) MapCommandToIds<T>(T command)
    {
        string idProperty = string.Empty;
        string commandId = string.Empty;

        switch (command)
        {
            case CreateOrderCommand createOrderCommand:
                idProperty = nameof(createOrderCommand.UserId);
                commandId = createOrderCommand.UserId!;
                break;

            case CancelOrderCommand cancelOrderCommand:
                idProperty = nameof(cancelOrderCommand.OrderNumber);
                commandId = $"{cancelOrderCommand.OrderNumber}";
                break;

            default:
                idProperty = "Id?";
                commandId = "n/a";
                break;
        }

        return (idProperty, commandId);
    }
}

