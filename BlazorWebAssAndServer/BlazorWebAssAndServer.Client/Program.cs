using BlazorWebAssAndServer.Client;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddScoped(http=> new HttpClient 
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddSyncfusionBlazor();
SyncfusionLicenseProvider.RegisterLicense("MzIxNzg2N0AzMjM1MmUzMDJlMzBqOWpHZ0tBNGRjbkFycmZESjBLVEVUOGMyemF6SmJ0NTc3by9aeGRpQktVPQ==");

await builder.Build().RunAsync();


