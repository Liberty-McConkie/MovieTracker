﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTracker.Models;

namespace MovieTracker.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieTracker.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Western"
                        });
                });

            modelBuilder.Entity("MovieTracker.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Barry Sonnenfeld",
                            Edited = false,
                            LentTo = "Liberty",
                            Notes = "Funny and Entertaining",
                            Rating = "PG-13",
                            Title = "Men in Black",
                            Year = (ushort)1997
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 8,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "Bryant",
                            Notes = "Intense and Exciting",
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = (ushort)2010
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Joe Wright",
                            Edited = false,
                            LentTo = "Kennedy",
                            Notes = "Captivating",
                            Rating = "PG",
                            Title = "Pride & Prejudice",
                            Year = (ushort)2005
                        });
                });

            modelBuilder.Entity("MovieTracker.Models.MovieResponse", b =>
                {
                    b.HasOne("MovieTracker.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
