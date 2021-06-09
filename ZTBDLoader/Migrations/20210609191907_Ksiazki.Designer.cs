﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZTBDLoader;

namespace ZTBDLoader.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210609191907_Ksiazki")]
    partial class Ksiazki
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZTBDLoader.model.Checkouts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BibNumber")
                        .HasColumnType("int");

                    b.Property<string>("CallNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckoutDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Collection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ItemBarcode")
                        .HasColumnType("bigint");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("ZTBDLoader.model.CollectionInventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BibNum")
                        .HasColumnType("int");

                    b.Property<string>("FloatingItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemCollection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<string>("ItemLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subjects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CollectionInventory");
                });

            modelBuilder.Entity("ZTBDLoader.model.DataDictionary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormatGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormatSubgroup")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DataDictionary");
                });
#pragma warning restore 612, 618
        }
    }
}