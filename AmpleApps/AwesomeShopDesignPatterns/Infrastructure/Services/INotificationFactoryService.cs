using AwesomeShopDesignPatterns.Models.Enums;

namespace AwesomeShopDesignPatterns.Infrastructure.Services;

public interface INotificationFactoryService
{
    INotificationService GetService(NotificationType type);
}
