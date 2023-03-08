global using GEBRequestSystem4.Client.Services.BussinesAreaServices;
global using GEBRequestSystem4.Shared;
using GEBRequestSystem4.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IBussinesAreaService, BussinesAreaService>();

await builder.Build().RunAsync();
