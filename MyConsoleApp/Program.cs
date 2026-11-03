using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

var appsettings = builder.Configuration.GetSection("AppSettings");

Console.WriteLine($"Environment: {appsettings.GetValue<string>("EnvironmentName")}");
Console.WriteLine($"Greeting: {appsettings.GetValue<string>("Greeting")}");

public sealed class Appsettings
{
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
}