﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20231221192825_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.TravelDestination", b =>
                {
                    b.Property<int>("TravelDestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfReviews")
                        .HasColumnType("int");

                    b.Property<int>("OverallRating")
                        .HasColumnType("int");

                    b.Property<string>("Reviews")
                        .HasColumnType("longtext");

                    b.HasKey("TravelDestinationId");

                    b.ToTable("TravelDestinations");

                    b.HasData(
                        new
                        {
                            TravelDestinationId = 1,
                            City = "Dublin",
                            Country = "Ireland",
                            NumberOfReviews = 234,
                            OverallRating = 10,
                            Reviews = "Beautiful and friendly! Will visit again."
                        },
                        new
                        {
                            TravelDestinationId = 2,
                            City = "St Louis",
                            Country = "United States",
                            NumberOfReviews = 43,
                            OverallRating = 4,
                            Reviews = "Historic and walkable but very dirty."
                        },
                        new
                        {
                            TravelDestinationId = 3,
                            City = "Cairo",
                            Country = "Egypt",
                            NumberOfReviews = 435,
                            OverallRating = 7,
                            Reviews = "Great attractions and history. Crowded and smoggy."
                        },
                        new
                        {
                            TravelDestinationId = 4,
                            City = "Puerto Vallarta",
                            Country = "Mexico",
                            NumberOfReviews = 128,
                            OverallRating = 9,
                            Reviews = "Beautiful, relaxing and warm."
                        },
                        new
                        {
                            TravelDestinationId = 5,
                            City = "Shanghai",
                            Country = "China",
                            NumberOfReviews = 879,
                            OverallRating = 10,
                            Reviews = "Diverse, lots of entertainment, great food."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
