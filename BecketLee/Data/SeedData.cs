using System;
using BecketLee.Data;
using BecketLee.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace BecketLee
{
    public static class SeedData
    {
        public static void Initialize( IServiceProvider services )
        {
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
            var context = services.GetRequiredService<BecketLeeDbContext>();

            var seeder = new BecketLeeSeedData( context, userManager, roleManager );
            seeder.EnsureSeedData().Wait();
        }
    }
}