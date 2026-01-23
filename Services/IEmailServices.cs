using MeteorWebApp.Models;

namespace MeteorWebApp.Services;

public interface IEmailService
{
    Task SendAsync(ContactFormModel model);
}