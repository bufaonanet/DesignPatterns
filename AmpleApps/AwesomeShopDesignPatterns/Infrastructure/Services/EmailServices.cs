using AwesomeShopDesignPatterns.Models;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace AwesomeShopDesignPatterns.Infrastructure.Services;

public class EmailServices : INotificationService
{
    private readonly ISendGridClient _sendGridClient;
    private readonly EmailSettings _emailSettings;

    public string ToEmail => _emailSettings.ToEmail;

    public EmailServices(
        ISendGridClient sendGridClient, 
        EmailSettings emailSettings)
    {
        _sendGridClient = sendGridClient;
        _emailSettings = emailSettings;
    }

    public async Task<bool> SendAsync(string destination, string content)
    {
        var msg = new SendGridMessage();
        msg.SetFrom(ToEmail, "Bufão");
        msg.AddTo(destination);
        msg.SetSubject("You have a new message.");
        msg.AddContent(MimeType.Html, content);

        var response = await _sendGridClient.SendEmailAsync(msg);
        if (response.IsSuccessStatusCode)
        {
            // O e-mail foi enviado com sucesso
            return true;
        }
        else
        {
            // O envio do e-mail falhou
            var errorResponse = await response.DeserializeResponseBodyAsync(response.Body);
            var errorMessage = errorResponse["errors"].ToString();

            // Faça o tratamento adequado do erro, como log, notificação, etc.
            // ...

            return false;
        }

        //var message = new SendGridMessage
        //{
        //    From = new EmailAddress(destination, "bufaonanet"),
        //    Subject = "You have a new message.",
        //    PlainTextContent = $"Here is your new message: {content}",            
        //};

        //message.AddTo(destination, destination);

        //await _sendGridClient.SendEmailAsync(message);
    }
}