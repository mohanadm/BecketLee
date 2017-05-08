using BecketLee.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BecketLee
{
    public class Startup
    {
        private IConfigurationRoot _config;
        private IHostingEnvironment _environment;
        public Startup( IHostingEnvironment env )
        {
            _environment = env;
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(_environment.ContentRootPath)
                .AddJsonFile( "config.json" )
                .AddEnvironmentVariables();

            _config = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IService>(IService, Service) // creates new each call
            //services.AddScoped<IService>(IService, Service) // creates one within scope for reuse

            services.AddSingleton(_config);

            services.AddDbContext<BecketLeeContext>();
            services.AddTransient<BecketLeeSeedData>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory, 
            BecketLeeSeedData seeder )
        {
            loggerFactory.AddConsole();            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc( config =>
            {
                config.MapRoute( 
                    name: "Default", 
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index"} 
                    );
            });

            seeder.EnsurePartnerData().Wait();
        }
    }
}
