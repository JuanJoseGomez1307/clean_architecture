using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;
using NorthWindEntities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependecyInjection;


HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddConsoleWriter();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azucar Refinada");