using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using TourCompany;
using TourCompany.Data;
using TourCompany.Interface;
using TourCompany.Services;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("PontosTuristicos"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ITourCompanyService, TourCompanyService>();
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjgyODYxQDMyMzAyZTMyMmUzMFpPSGEyMkttdnhBWWhnS1lWTDZNRU9TU09GWmJqdWdySkMwenRCbGpHUU09");
await builder.Build().RunAsync();
