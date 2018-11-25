﻿// <auto-generated />
using System;
using Gambit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gambit.Migrations
{
    [DbContext(typeof(MiStartupContext))]
    [Migration("20181125025734_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gambit.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Gambit.Models.Mi", b =>
                {
                    b.Property<string>("RegisterNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Name");

                    b.HasKey("RegisterNumber");

                    b.ToTable("Mi");
                });

            modelBuilder.Entity("Gambit.Models.MiStartup", b =>
                {
                    b.Property<string>("RegisterNumber");

                    b.Property<string>("Tva");

                    b.Property<decimal>("AmountInvest");

                    b.HasKey("RegisterNumber", "Tva");

                    b.HasIndex("Tva");

                    b.ToTable("MiStartup");
                });

            modelBuilder.Entity("Gambit.Models.Startup", b =>
                {
                    b.Property<string>("Tva")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<int>("CollectedFund");

                    b.Property<DateTime>("DeadLine");

                    b.Property<string>("Description");

                    b.Property<string>("FounderName");

                    b.Property<int>("Risk");

                    b.Property<string>("StartupName");

                    b.Property<int>("TargetGoal");

                    b.Property<string>("UrlImage");

                    b.HasKey("Tva");

                    b.HasIndex("CategoryID");

                    b.ToTable("Startup");
                });

            modelBuilder.Entity("Gambit.Models.MiStartup", b =>
                {
                    b.HasOne("Gambit.Models.Mi", "Mi")
                        .WithMany("MiStartups")
                        .HasForeignKey("RegisterNumber")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gambit.Models.Startup", "Startup")
                        .WithMany("MiStartups")
                        .HasForeignKey("Tva")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gambit.Models.Startup", b =>
                {
                    b.HasOne("Gambit.Models.Category", "Category")
                        .WithMany("Startups")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
