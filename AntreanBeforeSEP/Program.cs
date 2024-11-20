using Microsoft.Extensions.Configuration;
using Serilog;

internal class Program
{
    private static readonly string[] AppType = ["MG", "JK", "JS", "WS", "AO"];
    private static readonly HashSet<string> ServiceUnitIds = ["D1.3.A03", "D2.1.A01", "D2.1.A03", "D2.1.A08"];
    private static readonly HashSet<int> TaskIds = [1, 2, 3, 4, 5];
    private static int Minutes = 60;
    private static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
    }
}