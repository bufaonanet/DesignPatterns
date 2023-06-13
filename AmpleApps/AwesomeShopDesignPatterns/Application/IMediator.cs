using AwesomeShopDesignPatterns.Application.NotifyUser;

namespace AwesomeShopDesignPatterns.Application;

public interface IMediator
{
    Task Send(ICommand command);
}

public class Mediator : IMediator
{
    private readonly ICommandHandler<NotifyUserCommand, Task> _notifyUserCommandHandler;

    public Mediator(ICommandHandler<NotifyUserCommand, Task> notifyUserCommandHandler)
    {
        _notifyUserCommandHandler = notifyUserCommandHandler;
    }

    public async Task Send(ICommand command)
    {
        if (command is NotifyUserCommand)
        {
            await _notifyUserCommandHandler.Hanlder((NotifyUserCommand)command);
            return;
        }

        throw new NotImplementedException();
    }
}