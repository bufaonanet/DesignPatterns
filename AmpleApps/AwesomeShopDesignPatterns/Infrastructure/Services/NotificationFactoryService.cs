using AwesomeShopDesignPatterns.Models;
using AwesomeShopDesignPatterns.Models.Enums;
using Microsoft.Extensions.Options;
using SendGrid;

namespace AwesomeShopDesignPatterns.Infrastructure.Services;

public class NotificationFactoryService : INotificationFactoryService
{
    private readonly ISendGridClient _sendGridClient;
    private readonly EmailSettings _emailSettings;

    public NotificationFactoryService(ISendGridClient sendGridClient, 
        IOptions<EmailSettings> emailSettings)
    {
        _sendGridClient = sendGridClient;
        _emailSettings = emailSettings.Value;
    }

    public INotificationService GetService(NotificationType type)
    {
        if (type == NotificationType.Email)
            return new EmailServices(_sendGridClient, _emailSettings);

        return new SmsService();
    }
}