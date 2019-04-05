﻿using BecketLee.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BecketLee.Data
{
    public class BecketLeeContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private IConfigurationRoot _config;

        public BecketLeeContext(IConfigurationRoot config, DbContextOptions options)
            :base(options)
        {
            _config = config;
        }

        public DbSet<PartnerBiography> PartnerBiographies { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring( optionsBuilder );
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:BecketLeeConnection"] );
        }
    }
}
