using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MeteorWebApp.Models;

namespace MeteorWebApp.Services;

public class SmtpEmailService : IEmailService
{
    public async Task SendAsync(ContactFormModel model)
    {
        var fromEmail = "contacto@meteor-craftwork.com";

        var message = new MimeMessage();

        message.From.Add(
            new MailboxAddress("Meteor Web", fromEmail)
        );

        message.To.Add(
            new MailboxAddress("Meteor", fromEmail)
        );

        message.ReplyTo.Add(
            new MailboxAddress(model.Nombre, model.Email)
        );

        message.Subject = $"Contacto web - {model.Nombre}";

        message.Body = new TextPart("plain")
        {
            Text =
$"""
Nombre: {model.Nombre}
Email: {model.Email}

Mensaje:
{model.Mensaje}
"""
        };

        using var client = new SmtpClient();

        await client.ConnectAsync(
            "smtp.gmail.com",
            587,
            SecureSocketOptions.StartTls
        );

        await client.AuthenticateAsync(
            fromEmail,
            "TU_APP_PASSWORD_DE_GMAIL"
        );

        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }
}