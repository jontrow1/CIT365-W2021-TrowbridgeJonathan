using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Joseph Smith: The Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2005-12-17"),
                        Genre = "Bibliography",
                        Price = 7.99M,
                        Rating = "PG",
                        ImagePath = "~/images/JS_Prophet.jpg"
                    },

                    new Movie
                    {
                        Title = "Legacy: A Mormon Jounrey",
                        ReleaseDate = DateTime.Parse("1993-4-3"),
                        Genre = "Historical Fiction",
                        Price = 2.99M,
                        Rating = "PG",
                        ImagePath = "~/images/Legacy.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "~/images/MeetTheMormons.jpg"
                    },

                    new Movie
                    {
                        Title = "Mr. Krueger's Christmas",
                        ReleaseDate = DateTime.Parse("1980-12-21"),
                        Genre = "Christmas",
                        Price = 3.99M,
                        Rating = "PG",
                        ImagePath = "~/images/Krueger_Poster.jpg"
                    },

                    new Movie
                    {
                        Title = "Passage to Zarahemla",
                        ReleaseDate = DateTime.Parse("2007-10-15"),
                        Genre = "Fantasy",
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "~/images/Passage.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-1-30"),
                        Genre = "Romantic Comedy",
                        Price = 3.99M,
                        Rating = "PG",
                        ImagePath = "~/images/SinglesWard.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}