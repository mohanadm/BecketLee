using System.Threading.Tasks;
using AutoMapper;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.Services;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

namespace BecketLee
{
    public class Startup
    {
        private readonly IConfigurationRoot _config;
        private readonly IHostingEnvironment _environment;

        public Startup( IHostingEnvironment env )
        {
            _environment = env;
            _config = new ConfigRoot(_environment);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);
            services.AddLogging();
            services.AddDbContext<BecketLeeContext>();

            ConfigureDependencyInjection(services);

            services.AddMvc( config =>
                {
                    if( _environment.IsProduction() )
                    {
                        config.Filters.Add( new RequireHttpsAttribute() );
                    }
                })
                .AddJsonOptions( config =>
                    config.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

            ConfigureIdentityService(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            ILoggerFactory loggerFactory, 
            BecketLeeSeedData seeder )
        {

            if (_environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                loggerFactory.AddConsole(LogLevel.Information);
            }
            else
            {
                loggerFactory.AddConsole( LogLevel.Error );
            }
            
            
            //app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseIdentity();
                        

            Mapper.Initialize( config =>
            {
                config.CreateMap<Event, EventViewModel>().ReverseMap();
                config.CreateMap<PartnerBiography, PartnerViewModel>().ReverseMap();
            } );

            app.UseMvc( config =>
            {
                config.MapRoute( 
                    name: "Default", 
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index"} 
                    );
            });

            seeder.EnsureSeedData().Wait();
        }


        private static void ConfigureIdentityService( IServiceCollection services )
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>( config =>
                {
                    config.User.RequireUniqueEmail = true;
                    config.Password.RequiredLength = 8;
                    config.Password.RequireLowercase = true;
                    config.Password.RequireUppercase = true;
                    config.Password.RequireNonAlphanumeric = true;
                    config.Cookies.ApplicationCookie.LoginPath = "/Auth/Login";
                    config.Cookies.ApplicationCookie.Events = new CookieAuthenticationEvents
                    {
                        OnRedirectToLogin = async ctx =>
                        {
                            if( ctx.Request.Path.StartsWithSegments( "/api" ) &&
                                ctx.Response.StatusCode == 200 )
                            {
                                ctx.Response.StatusCode = 401;
                            }
                            else
                            {
                                ctx.Response.Redirect( ctx.RedirectUri );
                            }
                            await Task.Yield();
                        }
                    };
                } )
                .AddEntityFrameworkStores<BecketLeeContext>()
                .AddDefaultTokenProviders();

        }

        private void ConfigureDependencyInjection( IServiceCollection services )
        {
            services.AddTransient<BecketLeeSeedData>();

            //if (_environment.IsDevelopment())
            //    services.AddTransient<IEmailService, EmailServiceFake>();
            //else
                services.AddTransient<IEmailService, EmailService>();

            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IEventRepository, EventRepository>();


        }
    }
}
