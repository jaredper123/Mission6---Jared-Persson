using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class MovieAppContext : DbContext
    {
        //Constructor
        public MovieAppContext (DbContextOptions<MovieAppContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    movieID = 1,
                    Title = "Kung Fu Panda 2",
                    Category = "Family",
                    Year = 2011,
                    Director = "Jennifer Yuh Nelson",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Charlie",
                    Notes = "A favorite!",

                },
                new Movie
                {
                    movieID = 2,
                    Title = "Spirited",
                    Category = "Comedy",
                    Year = 2022,
                    Director = "Sean Anders",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Hugh",
                    Notes = "Very Clever",

                },
                new Movie
                {
                    movieID = 3,
                    Title = "The Martian",
                    Category = "Action/Adventure",
                    Year = 2015,
                    Director = "Ridley Scott",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Sarah",
                    Notes = "very involved",

                }
            );
        }
    }
}
