using Newtonsoft.Json;
using Serilog;

namespace AwesomeShopDesignPatterns.Application.NotifyUser;

public class NotifyUserCommandHandlerDecorator : ICommandHandler<NotifyUserCommand, Task>
{
    private readonly NotifyUserCommandHandler _handler;

    public NotifyUserCommandHandlerDecorator(NotifyUserCommandHandler handler)
    {
        _handler = handler;
    }

    public async Task Hanlder(NotifyUserCommand command)
    {
        Log.Information($"Command {command.GetType().Name} was handled with data {JsonConvert.SerializeObject(command)} ");
        await _handler.Hanlder(command);
    }
}

