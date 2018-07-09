using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BecketLee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost( args );

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    SeedData.Initialize( services );
                }
                catch (Exception exception)
                {
                    var x = exception.ToString();
                }
            }

            host.Run();
        }

        private static IWebHost BuildWebHost( string[] args ) =>
            WebHost.CreateDefaultBuilder( args )
                .UseStartup<Startup>()
                .Build();

    }
}
