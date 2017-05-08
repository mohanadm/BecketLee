﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BecketLee.Data;

namespace BecketLee.Migrations
{
    [DbContext(typeof(BecketLeeContext))]
    [Migration("20170508164602_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BecketLee.Models.PartnerBiography", b =>
                {
                    b.Property<int>("PartnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BiographyHtml");

                    b.Property<string>("FileName");

                    b.Property<string>("FileUrl");

                    b.Property<string>("PartnerName");

                    b.HasKey("PartnerId");

                    b.ToTable("PartnerBiographies");
                });
        }
    }
}
