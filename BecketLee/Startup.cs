using AutoMapper;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.Services;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace BecketLee
{
    public class Startup
    {
        private readonly IHostingEnvironment _environment;
        private readonly IConfigurationRoot _config;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            _environment = env;
           _config = new ConfigRoot(_environment);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
                options.HttpOnly = HttpOnlyPolicy.None;
                options.Secure = _environment.IsDevelopment()
                    ? CookieSecurePolicy.None
                    : CookieSecurePolicy.Always;
                //options.CheckConsentNeeded = context => true;
            });
            services.AddAuthentication( CookieAuthenticationDefaults.AuthenticationScheme )
                .AddCookie( options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = _environment.IsDevelopment()
                        ? CookieSecurePolicy.None
                        : CookieSecurePolicy.Always;
                    options.Cookie.SameSite = SameSiteMode.Lax;
                } );

            services.AddDbContext<BecketLeeContext>();

            ConfigureIdentityService(services);

            services.ConfigureApplicationCookie( options =>
            {
                options.Cookie.Name = "BecketLee.Authorization";
                options.LoginPath = new PathString( "/Auth/Login" ); 
                options.LogoutPath = new PathString("/Auth/Logout");

                options.Events = new CookieAuthenticationEvents
                {
                    // API controller redirection...
                    OnRedirectToLogin = async ctx =>
                    {
                        if (ctx.Request.Path.StartsWithSegments("/api") &&
                            ctx.Response.StatusCode == 200)
                        {
                            ctx.Response.StatusCode = 401;
                        }
                        else
                        {
                            ctx.Response.Redirect(ctx.RedirectUri);
                        }
                        await Task.Yield();
                    }
                };
            } );

            ConfigureDependencyInjection(services);

            services.AddMvc(config =>
                {
                    config.Filters.Add( new RequireHttpsAttribute() );
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions( config =>
                    config.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            Mapper.Initialize( config =>
            {
                config.CreateMap<Event, EventViewModel>().ReverseMap();
                config.CreateMap<PartnerBiography, PartnerViewModel>().ReverseMap();
            } );


            var options = new RewriteOptions()
                .AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 63423);
            app.UseRewriter(options);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
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
                } )
                .AddEntityFrameworkStores<BecketLeeContext>()
                .AddDefaultTokenProviders();
        }

        private void ConfigureDependencyInjection( IServiceCollection services )
        {
            services.AddTransient<BecketLeeSeedData>();

            if (_environment.IsDevelopment())
                services.AddTransient<IEmailService, EmailServiceFake>();
            else
                services.AddTransient<IEmailService, EmailService>();

            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}
