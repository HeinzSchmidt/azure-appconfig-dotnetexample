using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

class Program
{
	static void Main(string[] args)
	{
		var builder = new ConfigurationBuilder();
		builder.AddAzureAppConfiguration(Environment.GetEnvironmentVariable("ConnectionString"));

		var config = builder.Build();
		Console.WriteLine(config["TestApp:Settings:Message"] ?? "30.03.24");
		Console.WriteLine("Works.");
	}
}
