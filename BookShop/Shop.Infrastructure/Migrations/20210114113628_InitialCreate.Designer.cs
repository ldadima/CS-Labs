﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Shop.Infrastructure.EntityFramework;

namespace Shop.Infrastructure.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20210114113628_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BookShop.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateDelivery")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<long>("ShopId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Book","public");
                });

            modelBuilder.Entity("BookShop.ShopLibrary", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ShopLibrary","public");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Balance = 100000.0,
                            Capacity = 500
                        });
                });

            modelBuilder.Entity("BookShop.Book", b =>
                {
                    b.HasOne("BookShop.ShopLibrary", "ShopLibrary")
                        .WithMany("Books")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}