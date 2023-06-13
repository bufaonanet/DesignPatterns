namespace AwesomeShopDesignPatterns.Infrastructure.Services;

public class SmsService : INotificationService
{
    public Task<bool> SendAsync(string destination, string content)
    {
        Console.WriteLine($"SMS was sent to {destination}, with content: {content}.");

        return Task.FromResult(true);
    }
}
