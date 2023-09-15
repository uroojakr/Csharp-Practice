﻿// <auto-generated />
using System;
using EMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.Data.Migrations
{
    [DbContext(typeof(EMSDbContext))]
    [Migration("20230913081610_SecondCreate")]
    partial class SecondCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EMS.Data.Models.Events", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            Date = new DateTime(2023, 9, 28, 13, 16, 9, 937, DateTimeKind.Local).AddTicks(8905),
                            Description = "cooking show for beginners",
                            Location = "ISB",
                            OrganizerId = 1,
                            Title = "Cooking Show"
                        },
                        new
                        {
                            EventId = 2,
                            Date = new DateTime(2023, 9, 13, 13, 16, 9, 937, DateTimeKind.Local).AddTicks(8934),
                            Description = "Kids Support Event",
                            Location = "Karachi",
                            OrganizerId = 2,
                            Title = "Sports Event"
                        });
                });

            modelBuilder.Entity("EMS.Data.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.HasIndex("VendorId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Comment = "Good event!",
                            EventId = 1,
                            Rating = 4,
                            UserId = 1
                        },
                        new
                        {
                            ReviewId = 2,
                            Comment = "Awesome event!",
                            EventId = 2,
                            Rating = 5,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EMS.Data.Models.Ticket", b =>
                {
                    b.Property<int>("TickerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TickerId"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TickerId");

                    b.HasIndex("EventId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TickerId = 1,
                            EventId = 1,
                            UserId = 1
                        },
                        new
                        {
                            TickerId = 2,
                            EventId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EMS.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("UserType")
                        .HasColumnType("tinyint");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "urooj.akram@mail.com",
                            Password = "339fd",
                            UserName = "Urooj Akram",
                            UserType = (byte)1
                        },
                        new
                        {
                            UserId = 2,
                            Email = "sanakhalid@mail.com",
                            Password = "4he9ju",
                            UserName = "Sana Khalid",
                            UserType = (byte)0
                        });
                });

            modelBuilder.Entity("EMS.Data.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"));

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            VendorId = 1,
                            ContactInformation = "532-3333",
                            Description = "Providing all the facilites for sports",
                            Name = "Sports Crew"
                        },
                        new
                        {
                            VendorId = 2,
                            ContactInformation = "339-22844",
                            Description = "Photography essentials for the events by professional cameraman",
                            Name = "Photography"
                        });
                });

            modelBuilder.Entity("EMS.Data.Models.VendorEvent", b =>
                {
                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("VendorId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("VendorEvents");

                    b.HasData(
                        new
                        {
                            VendorId = 1,
                            EventId = 1
                        },
                        new
                        {
                            VendorId = 2,
                            EventId = 2
                        });
                });

            modelBuilder.Entity("EMS.Data.Models.Events", b =>
                {
                    b.HasOne("EMS.Data.Models.User", "Organizer")
                        .WithMany("OrganizedEvents")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("EMS.Data.Models.Review", b =>
                {
                    b.HasOne("EMS.Data.Models.Events", "Event")
                        .WithMany("Reviews")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMS.Data.Models.User", null)
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMS.Data.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");

                    b.Navigation("Event");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("EMS.Data.Models.Ticket", b =>
                {
                    b.HasOne("EMS.Data.Models.Events", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EMS.Data.Models.VendorEvent", b =>
                {
                    b.HasOne("EMS.Data.Models.Events", "Event")
                        .WithMany("VendorEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMS.Data.Models.Vendor", "Vendor")
                        .WithMany("VendorEvents")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("EMS.Data.Models.Events", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Tickets");

                    b.Navigation("VendorEvents");
                });

            modelBuilder.Entity("EMS.Data.Models.User", b =>
                {
                    b.Navigation("OrganizedEvents");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("EMS.Data.Models.Vendor", b =>
                {
                    b.Navigation("VendorEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
