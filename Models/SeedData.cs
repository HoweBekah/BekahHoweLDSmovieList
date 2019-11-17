using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>());
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 7.99M,
                    IMDBID = "tt0341540"
                },

                new Movie
                {
                    Title = "Saints and Soldiers",
                    ReleaseDate = DateTime.Parse("2003-3-25"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 8.99M,
                    IMDBID = "tt0373283"
                },

                new Movie
                {
                    Title = "Sons of Provo",
                    ReleaseDate = DateTime.Parse("2004-10-30"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M,
                    IMDBID = "tt0396223"
                },

                new Movie
                {
                    Title = "Midway to Heaven",
                    ReleaseDate = DateTime.Parse("2011-2-4"),
                    Genre = "Romance",
                    Rating = "PG",
                    Price = 3.99M,
                    IMDBID = "tt1762308"
                }
            ) ; 
            context.SaveChanges();
        }
    }
}