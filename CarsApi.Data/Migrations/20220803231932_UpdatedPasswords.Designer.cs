﻿// <auto-generated />
using CarsApi.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarsApi.Data.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20220803231932_UpdatedPasswords")]
    partial class UpdatedPasswords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarsApi.Data.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Make = "Ford",
                            Model = "Bronco"
                        },
                        new
                        {
                            Id = 2,
                            Make = "Chevrolet",
                            Model = "Silverado"
                        },
                        new
                        {
                            Id = 3,
                            Make = "Toyota",
                            Model = "RAV4"
                        },
                        new
                        {
                            Id = 4,
                            Make = "Honda",
                            Model = "Pilot"
                        },
                        new
                        {
                            Id = 5,
                            Make = "Mercedez",
                            Model = "Benz"
                        });
                });

            modelBuilder.Entity("CarsApi.Data.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Smith",
                            Password = "! capital of california is Sacramento #",
                            UserName = "jsmith@cars.com"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Bob Andrews",
                            Password = "? california is in the pst time zone /",
                            UserName = "bandrews@cars.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
