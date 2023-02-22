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
        public DbSet<Category> categories { get; set; }
        //instantiating each part of the tables with the necessary data
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName="Action/Adventure"},
                new Category { CategoryID=2, CategoryName = "Comedy" },
                new Category { CategoryID=3, CategoryName = "Drama" },
                new Category { CategoryID=4, CategoryName = "Family" },
                new Category { CategoryID=5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID=6, CategoryName = "Miscellaneous" },
                new Category { CategoryID=7, CategoryName = "TV" },
                new Category { CategoryID=8, CategoryName = "VHS" }
            );
            mb.Entity<Movie>().HasData(
                //These are all the seeds that we pass in to make it have some things already in the database.
                new Movie
                {
                    movieID = 1,
                    Title = "Kung Fu Panda 2",
                    CategoryID = 4,
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
                    CategoryID = 2,
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
                    CategoryID = 1,
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
