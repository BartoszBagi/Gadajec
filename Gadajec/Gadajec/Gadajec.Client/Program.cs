using Blazored.LocalStorage;
using Gadajec.Client;
using Gadajec.Client.Brokers.API;
using Gadajec.Client.Service.Authentication;
using GadajecBlazor.Providers;
using Majorsoft.Blazor.Components.Notifications;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IApiBroker, ApiBroker>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();


builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p =>
                p.GetRequiredService<ApiAuthenticationStateProvider>());

builder.Services.AddNotifications();
//builder.Services.AddLocalization();

await builder.Build().RunAsync();
