using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;


var builder = Host.CreateApplicationBuilder(args);
builder.Configuration.AddUserSecrets<Program>();


var appsettings = builder.Configuration.GetSection("AppSettings");

Console.WriteLine($"Greeting: {appsettings["Greeting"]}");
Console.WriteLine($"Password: {appsettings["Password"]}");
Console.WriteLine($"MaxNumber: {appsettings["MaxNumber"]}");


 var p = new Person();
 p.FirstName = "John Doe";
 p.Age = 30;
 p.ID = 12345;
 p.DateOfBirth = new DateOnly(2008, 1, 1);

Console.WriteLine($"Date of Birth: {p.DateOfBirth}");
Console.WriteLine($"Person Name: {p.FirstName}, Age: {p.Age}, ID: {p.ID}");
Console.WriteLine($"Environment Name: {appsettings["EnvironmentName"]}");

public sealed class Appsettings
{
    public string Password { get; set; } = string.Empty;

    public string EnvironmentName { get; set; } = string.Empty;

    public string Greeting { get; set; } = string.Empty;

    public int MaxNumber {get ; set; } 
}
