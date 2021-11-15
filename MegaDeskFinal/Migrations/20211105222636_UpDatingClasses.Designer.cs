﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MegaDeskFinal.Data;

namespace MegaDeskFinal.Migrations
{
    [DbContext(typeof(MegaDeskFinalContext))]
    [Migration("20211105222636_UpDatingClasses")]
    partial class UpDatingClasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("MegaDeskFinal.Models.Desk", b =>
                {
                    b.Property<int>("DeskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Depth")
                        .HasColumnType("TEXT");

                    b.Property<int>("DesktopMaterialId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfDrawers")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Width")
                        .HasColumnType("TEXT");

                    b.HasKey("DeskId");

                    b.HasIndex("DesktopMaterialId");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDeskFinal.Models.DeskQuote", b =>
                {
                    b.Property<int>("DeskQuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeskId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShippingTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DeskQuoteId");

                    b.HasIndex("DeskId");

                    b.HasIndex("ShippingTypeId");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegaDeskFinal.Models.DesktopMaterial", b =>
                {
                    b.Property<int>("DesktopMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DeskMaterialPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("DesktopMaterialName")
                        .HasColumnType("TEXT");

                    b.HasKey("DesktopMaterialId");

                    b.ToTable("DesktopMaterial");
                });

            modelBuilder.Entity("MegaDeskFinal.Models.ShippingType", b =>
                {
                    b.Property<int>("ShippingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceGreaterTwoThousand")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceLessOneThousand")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceThousandToTwoThousand")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingTypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("ShippingTypeId");

                    b.ToTable("ShippingType");
                });

            modelBuilder.Entity("MegaDeskFinal.Models.Desk", b =>
                {
                    b.HasOne("MegaDeskFinal.Models.DesktopMaterial", "DesktopMaterial")
                        .WithMany()
                        .HasForeignKey("DesktopMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DesktopMaterial");
                });

            modelBuilder.Entity("MegaDeskFinal.Models.DeskQuote", b =>
                {
                    b.HasOne("MegaDeskFinal.Models.Desk", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MegaDeskFinal.Models.ShippingType", "ShippingType")
                        .WithMany()
                        .HasForeignKey("ShippingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desk");

                    b.Navigation("ShippingType");
                });
#pragma warning restore 612, 618
        }
    }
}
