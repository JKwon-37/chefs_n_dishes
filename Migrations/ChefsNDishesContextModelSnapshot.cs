﻿// <auto-generated />
using System;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChefsNDishes.Migrations
{
    [DbContext(typeof(ChefsNDishesContext))]
    partial class ChefsNDishesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ChefId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("ChefId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tastiness")
                        .HasColumnType("int");

                    b.HasKey("DishId");

                    b.HasIndex("ChefId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Dish", b =>
                {
                    b.HasOne("Chef", "ChefsName")
                        .WithMany("DishesCreated")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChefsName");
                });

            modelBuilder.Entity("Chef", b =>
                {
                    b.Navigation("DishesCreated");
                });
#pragma warning restore 612, 618
        }
    }
}
