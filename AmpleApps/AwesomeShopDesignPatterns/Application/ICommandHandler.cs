namespace AwesomeShopDesignPatterns.Application;

public interface ICommandHandler<Command,Return> where Command: ICommand
{
    Return Hanlder(Command command);    
}