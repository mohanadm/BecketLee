using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BecketLee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = CreateWebHost( args );

                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    try
                    {
                        //SeedData.Initialize( services );
                    }
                    catch (Exception exception)
                    {
                        var x = exception.ToString();
                    }
                }

                host.Run();
            }
            catch (Exception exception)
            {
                using (var sw = File.CreateText( @"C:\temp\startupError.Txt" ))
                {
                    sw.Write( exception.ToString() );
                }
                Console.WriteLine( exception.ToString() );
            }
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
