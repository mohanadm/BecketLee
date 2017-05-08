using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BecketLee.Data;

namespace BecketLee.Migrations
{
    [DbContext(typeof(BecketLeeContext))]
    partial class BecketLeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
