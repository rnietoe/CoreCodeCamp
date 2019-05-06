﻿// <auto-generated />
using System;
using CoreCodeCamp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCodeCamp.Migrations
{
    [DbContext(typeof(CampContext))]
    [Migration("20190506140714_intialcreate")]
    partial class intialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.Property<int>("CampId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("Length");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Moniker");

                    b.Property<string>("Name");

                    b.HasKey("CampId");

                    b.HasIndex("LocationId");

                    b.ToTable("Camps");

                    b.HasData(
                        new
                        {
                            CampId = 1,
                            EventDate = new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Length = 1,
                            LocationId = 1,
                            Moniker = "ATL2018",
                            Name = "Atlanta Code Camp"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Address3");

                    b.Property<string>("CityTown");

                    b.Property<string>("Country");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StateProvince");

                    b.Property<string>("VenueName");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address1 = "123 Main Street",
                            CityTown = "Atlanta",
                            Country = "USA",
                            PostalCode = "12345",
                            StateProvince = "GA",
                            VenueName = "Atlanta Convention Center"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogUrl");

                    b.Property<string>("Company");

                    b.Property<string>("CompanyUrl");

                    b.Property<string>("FirstName");

                    b.Property<string>("GitHub");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Twitter");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");

                    b.HasData(
                        new
                        {
                            SpeakerId = 1,
                            BlogUrl = "http://wildermuth.com",
                            Company = "Wilder Minds LLC",
                            CompanyUrl = "http://wilderminds.com",
                            FirstName = "Shawn",
                            GitHub = "shawnwildermuth",
                            LastName = "Wildermuth",
                            Twitter = "shawnwildermuth"
                        },
                        new
                        {
                            SpeakerId = 2,
                            BlogUrl = "http://shawnandresa.com",
                            Company = "Wilder Minds LLC",
                            CompanyUrl = "http://wilderminds.com",
                            FirstName = "Resa",
                            GitHub = "resawildermuth",
                            LastName = "Wildermuth",
                            Twitter = "resawildermuth"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Talk", b =>
                {
                    b.Property<int>("TalkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract");

                    b.Property<int?>("CampId");

                    b.Property<int>("Level");

                    b.Property<int?>("SpeakerId");

                    b.Property<string>("Title");

                    b.HasKey("TalkId");

                    b.HasIndex("CampId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talks");

                    b.HasData(
                        new
                        {
                            TalkId = 1,
                            Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
                            CampId = 1,
                            Level = 100,
                            SpeakerId = 1,
                            Title = "Entity Framework From Scratch"
                        },
                        new
                        {
                            TalkId = 2,
                            Abstract = "Thinking of good sample data examples is tiring.",
                            CampId = 1,
                            Level = 200,
                            SpeakerId = 2,
                            Title = "Writing Sample Data Made Easy"
                        });
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Camp", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("CoreCodeCamp.Data.Talk", b =>
                {
                    b.HasOne("CoreCodeCamp.Data.Camp", "Camp")
                        .WithMany("Talks")
                        .HasForeignKey("CampId");

                    b.HasOne("CoreCodeCamp.Data.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerId");
                });
#pragma warning restore 612, 618
        }
    }
}
