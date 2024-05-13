﻿// <auto-generated />
using System;
using CareOnSpot.DBConncetion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CareOnSpot.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240509055812_RenameTable")]
    partial class RenameTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CareOnSpot.Models.BloodDonation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BloodTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DonorName")
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<DateTime>("LastDonationDate")
                        .HasMaxLength(85)
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("location")
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.HasKey("Id");

                    b.HasIndex("BloodTypeId");

                    b.ToTable("BloodDonations");
                });

            modelBuilder.Entity("CareOnSpot.Models.BloodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BloodGroup")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("BloodTypes");
                });

            modelBuilder.Entity("CareOnSpot.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Designation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("VisitFee")
                        .HasMaxLength(50)
                        .HasColumnType("float");

                    b.Property<string>("experience")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("specialty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("CareOnSpot.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("CareOnSpot.Models.MedicalShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasMaxLength(50)
                        .HasColumnType("float");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("MedicalShop");
                });

            modelBuilder.Entity("CareOnSpot.Models.Specialitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Consult dermatologists for skin, hair, and nail conditions.",
                            Title = "Dermatology"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Consult dermatologists for skin, hair, and nail conditions.",
                            Title = "Ophthalmology"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Consult dermatologists for skin, hair, and nail conditions.",
                            Title = "Pediatrics"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7373), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Consult dermatologists for skin, hair, and nail conditions.",
                            Title = "Cardiology"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Consult dermatologists for skin, hair, and nail conditions.",
                            Title = "Psychiatry"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7377), new TimeSpan(0, 6, 0, 0, 0)),
                            Description = "Consult dermatologists for skin, hair, and nail conditions.",
                            Title = "Orthopedics"
                        });
                });

            modelBuilder.Entity("CareOnSpot.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UserName")
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<string>("UserType")
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CareOnSpot.Models.BloodDonation", b =>
                {
                    b.HasOne("CareOnSpot.Models.BloodType", "BloodType")
                        .WithMany("BloodDonations")
                        .HasForeignKey("BloodTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BloodType");
                });

            modelBuilder.Entity("CareOnSpot.Models.Doctor", b =>
                {
                    b.HasOne("CareOnSpot.Models.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("CareOnSpot.Models.BloodType", b =>
                {
                    b.Navigation("BloodDonations");
                });

            modelBuilder.Entity("CareOnSpot.Models.Hospital", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
