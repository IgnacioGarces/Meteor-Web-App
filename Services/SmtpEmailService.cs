using MailKit.Net.Smtp;
using MailKit.Security;
using MeteorWebApp.Models;
using MimeKit;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

namespace MeteorWebApp.Services;

public class SmtpEmailService : IEmailService
{
    public async Task SendAsync(ContactFormModel model)
    {
        var fromEmail = model;

        var message = new MimeMessage();

        message.From.Add(
            new MailboxAddress("Meteor Web App", "contacto@meteor-craftwork.com")
        );

        message.To.Add(
            new MailboxAddress("Meteor Web App", "contacto@meteor-craftwork.com")
        );

        message.ReplyTo.Add(
            new MailboxAddress(model.Nombre, model.Email)
        );

        message.Subject = $"Contacto web: {model.Nombre}";

        message.Body = new TextPart("plain")
        {
            Text = fromEmail.Mensaje
        };

        using var client = new SmtpClient();

        await client.ConnectAsync(
            "smtp.gmail.com",
            587,
            SecureSocketOptions.StartTls
        );

        await client.AuthenticateAsync(
            "contacto@meteor-craftwork.com",
            "xvad oovt adbc tokp"
        );

        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }
}