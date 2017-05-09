using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BecketLee.Data;

namespace BecketLee.Migrations
{
    [DbContext(typeof(BecketLeeContext))]
    [Migration("20170509215212_Events")]
    partial class Events
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BecketLee.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EventHtml");

                    b.Property<int>("EventType");

                    b.Property<string>("Title");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BecketLee.Models.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EventTypeDescription");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes");
                });

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
