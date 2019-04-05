using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BecketLee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception exception)
                {
                    var x = exception.ToString();
                }
            }

            host.Run();
        }

        public static IWebHost CreateWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                //.ConfigureLogging((hostingContext, logging) =>
                //{
                //    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                //    logging.AddConsole();
                //    logging.AddDebug();
                //})
                .Build();
    }
}
