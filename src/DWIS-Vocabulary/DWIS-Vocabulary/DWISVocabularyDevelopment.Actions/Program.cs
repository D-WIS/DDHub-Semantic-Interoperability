using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DWIS.Vocabulary.Development.Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DWIS Vocabulary development: vocabulary actions");

            using IHost host = CreateHostBuilder(args).Build();

            var s = host.Services.GetRequiredService<VocabularyActioner>();
            if (s.PerformActions())
            {
                Console.WriteLine("Perform actions succeeded.");
            }
            else
            {
                Console.WriteLine("Perform actions returned false.");
            }
            Console.WriteLine("Press any key to exit...");

            Console.ReadLine();
        }




        static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
          .ConfigureAppConfiguration((hostingContext, configuration) =>
          {
              configuration.Sources.Clear();
              configuration
                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
          })
          .ConfigureLogging(logging =>
          {
              logging
                  .ClearProviders()
                  .AddConsole().SetMinimumLevel(LogLevel.Trace);
          })
          .ConfigureServices((hostContext, services) =>
          {
              // hostContext
              ActionsConfig options = new ActionsConfig();
              hostContext.Configuration.GetSection(nameof(ActionsConfig))
                               .Bind(options);



              services
                  .AddSingleton<ActionsConfig>(options)
                  .AddSingleton<VocabularyActioner>();
          });
    }

}
