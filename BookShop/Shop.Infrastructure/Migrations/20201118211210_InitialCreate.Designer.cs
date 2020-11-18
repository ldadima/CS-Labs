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
    [DbContext(typeof(BooksContext))]
    [Migration("20201118211210_InitialCreate")]
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

                    b.Property<string>("BookGenre")
                        .HasColumnType("text");

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateDelivery")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Book","public");
                });
#pragma warning restore 612, 618
        }
    }
}
