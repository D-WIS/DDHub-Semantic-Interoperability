using DWIS.Vocabulary.Development.App.Client;
using DWIS.Vocabulary.Development.App.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddSingleton<IGitHubManager, GitHubManager>();
builder.Services.AddSingleton<IDiagramManager,DiagramManager>();
await builder.Build().RunAsync();
