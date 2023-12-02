﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManagementApi.Models;

#nullable disable

namespace ProjectManagementApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ProjectManagementApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 2,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 3,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 4,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 5,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 6,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 7,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 8,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 9,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 10,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 11,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 12,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 13,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 14,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 15,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 16,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 17,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 18,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 19,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 20,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 21,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 22,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 23,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 24,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        },
                        new
                        {
                            Id = 25,
                            Description = "dette er en beskrivelse",
                            Name = "test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
