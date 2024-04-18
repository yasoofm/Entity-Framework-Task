﻿// <auto-generated />
using Entity_FrameWork.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity_FrameWork.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20240418102507_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Entity_FrameWork.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "first",
                            Url = "https://hi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "second",
                            Url = "https://hi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "third",
                            Url = "https://hi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}