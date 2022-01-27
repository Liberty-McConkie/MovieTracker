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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                 new MovieResponse
                 {
                     MovieId= 1,
                     Category= "Action/Adventure/Comedy",
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
                     Category = "Action/Adventure", 
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
                     Category = "Drama/Romance",
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
