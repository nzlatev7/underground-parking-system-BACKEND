﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingSpaces;

#nullable disable

namespace ParkingSpaces.Migrations
{
    [DbContext(typeof(ParkingSpacesDbContext))]
    [Migration("20240321121804_addingAvatarPhotoToUserModel")]
    partial class addingAvatarPhotoToUserModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ParkingSpaces.Models.DB.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParkSpaceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParkSpaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ParkingSpaces.Models.DB.ParkSpace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParkSpaces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "A2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "A3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "A5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "A6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "A7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "A8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "A9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "B1"
                        },
                        new
                        {
                            Id = 11,
                            Name = "B2"
                        },
                        new
                        {
                            Id = 12,
                            Name = "B3"
                        },
                        new
                        {
                            Id = 13,
                            Name = "B4"
                        },
                        new
                        {
                            Id = 14,
                            Name = "B5"
                        },
                        new
                        {
                            Id = 15,
                            Name = "B6"
                        },
                        new
                        {
                            Id = 16,
                            Name = "B7"
                        },
                        new
                        {
                            Id = 17,
                            Name = "disabled"
                        });
                });

            modelBuilder.Entity("ParkingSpaces.Models.DB.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Avatar")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ParkingSpaces.Models.DB.Booking", b =>
                {
                    b.HasOne("ParkingSpaces.Models.DB.ParkSpace", "ParkSpace")
                        .WithMany("Bookings")
                        .HasForeignKey("ParkSpaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingSpaces.Models.DB.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParkSpace");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ParkingSpaces.Models.DB.ParkSpace", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ParkingSpaces.Models.DB.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
