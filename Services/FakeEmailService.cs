using MeteorWebApp.Models;

namespace MeteorWebApp.Services;

public class FakeEmailService : IEmailService
{
    public Task SendAsync(ContactFormModel model)
    {
        Console.WriteLine("=== CONTACT FORM ===");
        Console.WriteLine($"Nombre: {model.Nombre}");
        Console.WriteLine($"Email: {model.Email}");
        Console.WriteLine($"Mensaje: {model.Mensaje}");
        Console.WriteLine("====================");

        return Task.CompletedTask;
    }
}


// contacto@meteor-craftwork.com