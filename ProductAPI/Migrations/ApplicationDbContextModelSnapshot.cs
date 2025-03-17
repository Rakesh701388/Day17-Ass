﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Data;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Product 1",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Product 2",
                            Price = 20m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Product 3",
                            Price = 30m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Product 4",
                            Price = 40m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Product 5",
                            Price = 50m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Product 6",
                            Price = 60m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Product 7",
                            Price = 70m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Product 8",
                            Price = 80m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Product 9",
                            Price = 90m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Product 10",
                            Price = 100m
                        },
                        new
                        {
                            Id = 11,
                            Name = "Product 11",
                            Price = 110m
                        },
                        new
                        {
                            Id = 12,
                            Name = "Product 12",
                            Price = 120m
                        },
                        new
                        {
                            Id = 13,
                            Name = "Product 13",
                            Price = 130m
                        },
                        new
                        {
                            Id = 14,
                            Name = "Product 14",
                            Price = 140m
                        },
                        new
                        {
                            Id = 15,
                            Name = "Product 15",
                            Price = 150m
                        },
                        new
                        {
                            Id = 16,
                            Name = "Product 16",
                            Price = 160m
                        },
                        new
                        {
                            Id = 17,
                            Name = "Product 17",
                            Price = 170m
                        },
                        new
                        {
                            Id = 18,
                            Name = "Product 18",
                            Price = 180m
                        },
                        new
                        {
                            Id = 19,
                            Name = "Product 19",
                            Price = 190m
                        },
                        new
                        {
                            Id = 20,
                            Name = "Product 20",
                            Price = 200m
                        },
                        new
                        {
                            Id = 21,
                            Name = "Product 21",
                            Price = 210m
                        },
                        new
                        {
                            Id = 22,
                            Name = "Product 22",
                            Price = 220m
                        },
                        new
                        {
                            Id = 23,
                            Name = "Product 23",
                            Price = 230m
                        },
                        new
                        {
                            Id = 24,
                            Name = "Product 24",
                            Price = 240m
                        },
                        new
                        {
                            Id = 25,
                            Name = "Product 25",
                            Price = 250m
                        },
                        new
                        {
                            Id = 26,
                            Name = "Product 26",
                            Price = 260m
                        },
                        new
                        {
                            Id = 27,
                            Name = "Product 27",
                            Price = 270m
                        },
                        new
                        {
                            Id = 28,
                            Name = "Product 28",
                            Price = 280m
                        },
                        new
                        {
                            Id = 29,
                            Name = "Product 29",
                            Price = 290m
                        },
                        new
                        {
                            Id = 30,
                            Name = "Product 30",
                            Price = 300m
                        },
                        new
                        {
                            Id = 31,
                            Name = "Product 31",
                            Price = 310m
                        },
                        new
                        {
                            Id = 32,
                            Name = "Product 32",
                            Price = 320m
                        },
                        new
                        {
                            Id = 33,
                            Name = "Product 33",
                            Price = 330m
                        },
                        new
                        {
                            Id = 34,
                            Name = "Product 34",
                            Price = 340m
                        },
                        new
                        {
                            Id = 35,
                            Name = "Product 35",
                            Price = 350m
                        },
                        new
                        {
                            Id = 36,
                            Name = "Product 36",
                            Price = 360m
                        },
                        new
                        {
                            Id = 37,
                            Name = "Product 37",
                            Price = 370m
                        },
                        new
                        {
                            Id = 38,
                            Name = "Product 38",
                            Price = 380m
                        },
                        new
                        {
                            Id = 39,
                            Name = "Product 39",
                            Price = 390m
                        },
                        new
                        {
                            Id = 40,
                            Name = "Product 40",
                            Price = 400m
                        },
                        new
                        {
                            Id = 41,
                            Name = "Product 41",
                            Price = 410m
                        },
                        new
                        {
                            Id = 42,
                            Name = "Product 42",
                            Price = 420m
                        },
                        new
                        {
                            Id = 43,
                            Name = "Product 43",
                            Price = 430m
                        },
                        new
                        {
                            Id = 44,
                            Name = "Product 44",
                            Price = 440m
                        },
                        new
                        {
                            Id = 45,
                            Name = "Product 45",
                            Price = 450m
                        },
                        new
                        {
                            Id = 46,
                            Name = "Product 46",
                            Price = 460m
                        },
                        new
                        {
                            Id = 47,
                            Name = "Product 47",
                            Price = 470m
                        },
                        new
                        {
                            Id = 48,
                            Name = "Product 48",
                            Price = 480m
                        },
                        new
                        {
                            Id = 49,
                            Name = "Product 49",
                            Price = 490m
                        },
                        new
                        {
                            Id = 50,
                            Name = "Product 50",
                            Price = 500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
