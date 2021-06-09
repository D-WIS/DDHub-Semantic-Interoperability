using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net;
using Topshelf;

namespace WebApi
{
    public static class Program
    {
        public static int Main(string[] _)
        {
            var configuration = new ConfigurationBuilder().Build();

            return (int)HostFactory.Run(host =>
            {
                host.RunAsLocalSystem();
                host.StartAutomatically();
                host.SetDisplayName("DDHub Demo server");

                host.Service<WebApiService>(service =>
                {
                    service.WhenStarted(x => x.Start());
                    service.WhenStopped(x => x.Stop());
                    service.ConstructUsing(__ => new WebApiService(configuration));
                });
            });
        }

        private class WebApiService
        {
            public WebApiService(IConfiguration configuration)
            {
                Host = ConfigureHost(configuration);
                Console.WriteLine("Printing host:\r\n\t" + Host);

                Console.WriteLine(Host.ServerFeatures);                
                Console.WriteLine(Host.Services);


            }

            private static IWebHost ConfigureHost(IConfiguration configuration)
            {
                return new WebHostBuilder()
                    .UseKestrel(options => options.Listen(IPAddress.Any, 8888))
                    .UseConfiguration(configuration)
                    .UseStartup<Startup>()
                    .Build();
            }

            public IWebHost Host { get; }

            public void Start()
            {
                Host.Start();
            }

            public void Stop()
            {
                Host.Services.GetRequiredService<IApplicationLifetime>().StopApplication();
            }
        }
    }
}
