using Microsoft.Extensions.Configuration;
using System;

namespace Lezione.Configuration
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // build a config object, using env vars or/and JSON provider
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            Settings settings = config.GetRequiredSection("settings").Get<Settings>();

            Console.WriteLine(settings.name);

        }
    }

    public class Settings
    {
        public string name { get; set; }
    }
}
