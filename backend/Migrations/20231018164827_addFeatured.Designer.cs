﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using buyC.Data;

#nullable disable

namespace buyC.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231018164827_addFeatured")]
    partial class addFeatured
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("buyC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("buyC.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ShoeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShoeId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("buyC.Models.Shoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1443),
                            Description = "A comfortable and durable running shoe.",
                            Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Air_Jordan_Legacy_312_a46xsf.webp",
                            IsFeatured = true,
                            Name = "Air Jordan Legacy 312",
                            Price = 2799.9499999999998
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1445),
                            Description = "A stylish and comfortable casual shoe.",
                            Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jumpman_MVP_vjjeul.webp",
                            IsFeatured = true,
                            Name = "Air Jordan Legacy 312",
                            Price = 3526.23
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1447),
                            Description = "A stylish and comfortable casual shoe.",
                            Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jordan_Post_c5bsey.webp",
                            IsFeatured = true,
                            Name = "Air Jordan Legacy 312",
                            Price = 2300.3600000000001
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1449),
                            Description = "A stylish and comfortable casual shoe.",
                            Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/X_PLRBOOST_SHOES_e5z4m3.avif",
                            IsFeatured = false,
                            Name = "X_PLRBOOST SHOES",
                            Price = 3499.0
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1451),
                            Description = "A stylish and comfortable casual shoe.",
                            Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/RACER_TR23_SHOES_jpfphb.avif",
                            IsFeatured = false,
                            Name = "RACER TR23 SHOES",
                            Price = 1699.0
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1453),
                            Description = "A stylish and comfortable casual shoe.",
                            Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/DURAMO_SL_SHOES_erzcaq.avif",
                            IsFeatured = false,
                            Name = "DURAMO SL SHOES",
                            Price = 1299.0
                        });
                });

            modelBuilder.Entity("buyC.Models.Review", b =>
                {
                    b.HasOne("buyC.Models.Shoe", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ShoeId");
                });

            modelBuilder.Entity("buyC.Models.Shoe", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
