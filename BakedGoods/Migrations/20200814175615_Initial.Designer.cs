﻿// <auto-generated />
using BakedGoods.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakedGoods.Migrations
{
    [DbContext(typeof(BakedGoodsContext))]
    [Migration("20200814175615_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BakedGoods.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("BakedGoods.Models.Pastry", b =>
                {
                    b.Property<int>("PastryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PastryId");

                    b.ToTable("Pastries");
                });

            modelBuilder.Entity("BakedGoods.Models.PastryFlavor", b =>
                {
                    b.Property<int>("PastryFlavorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FlavorId");

                    b.Property<int>("PastryId");

                    b.HasKey("PastryFlavorId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("PastryId");

                    b.ToTable("PastryFlavor");
                });

            modelBuilder.Entity("BakedGoods.Models.PastryFlavor", b =>
                {
                    b.HasOne("BakedGoods.Models.Flavor", "Flavor")
                        .WithMany("Pastries")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BakedGoods.Models.Pastry", "Pastry")
                        .WithMany("Flavors")
                        .HasForeignKey("PastryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
