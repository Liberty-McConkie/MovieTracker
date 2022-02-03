using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTracker.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //blank for now
        }

        public DbSet<MovieResponse> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Fantasy" },
                new Category { CategoryID = 5, CategoryName = "Horror" },
                new Category { CategoryID = 6, CategoryName = "Mystery" },
                new Category { CategoryID = 7, CategoryName = "Romance" },
                new Category { CategoryID = 8, CategoryName = "Thriller" },
                new Category { CategoryID = 9, CategoryName = "Western" }
            );
            mb.Entity<MovieResponse>().HasData(
                 new MovieResponse
                 {
                     MovieId= 1,
                     CategoryId= 1,
                     Title= "Men in Black",
                     Year= 1997,
                     Director= "Barry Sonnenfeld",
                     Rating= "PG-13",
                     Edited= false,
                     LentTo= "Liberty",
                     Notes= "Funny and Entertaining"
                 },

                 new MovieResponse
                 {
                     MovieId= 2,
                     CategoryId = 8, 
                     Title = "Inception",
                     Year = 2010,
                     Director= "Christopher Nolan",
                     Rating = "PG-13",
                     Edited = false,
                     LentTo = "Bryant",
                     Notes = "Intense and Exciting"
                 },

                 new MovieResponse
                 {
                     MovieId= 3,
                     CategoryId = 3,
                     Title = "Pride & Prejudice",
                     Year = 2005,
                     Director= "Joe Wright",
                     Rating = "PG",
                     Edited = false,
                     LentTo = "Kennedy",
                     Notes = "Captivating"
                 }
             );
        }
    }
}
