namespace AwesomeShopDesignPatterns.Infrastructure.Services;

public interface INotificationService
{
    Task<bool> SendAsync(string destination, string content);
}