using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

var appsettings = builder.Configuration.GetSection("AppSettings");

Console.WriteLine($"Environment: {appsettings["EnvironmentName"]}");
Console.WriteLine($"Greeting: {appsettings["Greeting"]}");
Console.WriteLine($"Password: {appsettings["Password"]}");

public sealed class Appsettings
{
    public string Password { get; set; } = string.Empty;
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
}
