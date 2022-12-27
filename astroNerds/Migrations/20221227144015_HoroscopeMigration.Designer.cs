﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using astroNerds.Models.Data;

#nullable disable

namespace astroNerds.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221227144015_HoroscopeMigration")]
    partial class HoroscopeMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("astroNerds.Models.HResult", b =>
                {
                    b.Property<int>("HoroscopeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HoroscopeID"));

                    b.Property<string>("HoroscopeText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HoroscopeType")
                        .HasColumnType("int");

                    b.Property<int>("ZodiacSign")
                        .HasColumnType("int");

                    b.HasKey("HoroscopeID");

                    b.ToTable("HResults");
                });

            modelBuilder.Entity("astroNerds.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("astroNerds.Models.Zodiac", b =>
                {
                    b.Property<int>("ZodiacSign")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateTo")
                        .HasColumnType("datetime2");

                    b.HasKey("ZodiacSign");

                    b.ToTable("Zodiac");
                });
#pragma warning restore 612, 618
        }
    }
}
