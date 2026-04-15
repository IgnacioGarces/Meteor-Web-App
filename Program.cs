using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Meteor_Web_App;
using Meteor_Web_App.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// 1. Configuración de los componentes raíz
// Busca el <div id="app"></div> en tu index.html para renderizar la app
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// 2. Registro de servicios obligatorios
// HttpClient permite que tus componentes hagan peticiones web si lo necesitan
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// 3. Registro de tus servicios personalizados
// En Blazor WASM, AddScoped y AddSingleton funcionan igual (viven mientras la pestaña esté abierta)
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ArticleService>();

// Nota: No registramos IEmailService ni MailKit porque no funcionan en el navegador (lado cliente).
// Para el formulario de contacto, usaremos la llamada directa a Formspree desde el componente .razor.

await builder.Build().RunAsync();