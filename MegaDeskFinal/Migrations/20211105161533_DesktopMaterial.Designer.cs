﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskFinal.Migrations
{
    [DbContext(typeof(MegaDeskFinalContext))]
    [Migration("20211105161533_DesktopMaterial")]
    partial class DesktopMaterial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("RazorPagesMovie.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Depth")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeskId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfDrawers")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Width")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.DeskQuote", b =>
                {
                    b.Property<int>("DeskQuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DeskID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("QuoteAmount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("RushDays")
                        .HasColumnType("INTEGER");

                    b.Property<int>("shipping")
                        .HasColumnType("INTEGER");

                    b.HasKey("DeskQuoteId");

                    b.HasIndex("DeskID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.DeskQuote", b =>
                {
                    b.HasOne("RazorPagesMovie.Models.Desk", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskID");

                    b.Navigation("Desk");
                });
#pragma warning restore 612, 618
        }
    }
}
