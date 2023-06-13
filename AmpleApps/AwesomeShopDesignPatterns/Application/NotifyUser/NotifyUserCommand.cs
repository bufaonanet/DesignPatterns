using AwesomeShopDesignPatterns.Models.Enums;

namespace AwesomeShopDesignPatterns.Application.NotifyUser;

public class NotifyUserCommand : ICommand
{
    public string Destination { get; set; }
    public string Content { get; set; }
    public NotificationType Type { get; set; }
}