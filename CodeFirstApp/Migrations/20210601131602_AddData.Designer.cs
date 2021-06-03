﻿// <auto-generated />
using CodeFirstApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210601131602_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApp.Models.BranchModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Riyadh",
                            Area = "Al-rayan",
                            Name = "branch01"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Riyadh",
                            Area = "Al-rayan",
                            Name = "branch02"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Riyadh",
                            Area = "Al-rayan",
                            Name = "branch03"
                        },
                        new
                        {
                            ID = 4,
                            Address = "Riyadh",
                            Area = "Al-rayan",
                            Name = "branch04"
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.CustomerModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CodeFirstApp.Models.ProductModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
