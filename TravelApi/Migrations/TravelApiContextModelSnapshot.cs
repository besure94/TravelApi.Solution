﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Author = "Danny",
                            City = "Dublin",
                            Country = "Ireland",
                            Message = "Beautiful and friendly! Will visit again.",
                            Rating = 10
                        },
                        new
                        {
                            ReviewId = 2,
                            Author = "Jim",
                            City = "St Louis",
                            Country = "United States",
                            Message = "Historic and walkable but very dirty.",
                            Rating = 4
                        },
                        new
                        {
                            ReviewId = 3,
                            Author = "Renton",
                            City = "Cairo",
                            Country = "Egypt",
                            Message = "Great attractions and history. Crowded and smoggy.",
                            Rating = 8
                        },
                        new
                        {
                            ReviewId = 4,
                            Author = "Benjamin",
                            City = "Puerto Vallarta",
                            Country = "Mexico",
                            Message = "Beautiful, relaxing and warm.",
                            Rating = 9
                        },
                        new
                        {
                            ReviewId = 5,
                            Author = "Henry",
                            City = "Shanghai",
                            Country = "China",
                            Message = "Diverse, lots of entertainment, great food.",
                            Rating = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
