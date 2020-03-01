using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySkills.Data;


namespace MySkills.Models
{
    public static class SeedData
    {
        public static void Initailize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                if (context.Movie.Any()) return;

                context.Movie.AddRange(
                    new Movie
                    {
                        Title="When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre="Romantic Comedy",
                        BoxOffice=7.99M,
                        Rating="R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        BoxOffice = 8.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        BoxOffice = 9.99M,
                        Rating = "R"
                    },
                     new Movie
                     {
                         Title = "Rio Bravo",
                         ReleaseDate = DateTime.Parse("1959-4-15"),
                         Genre = "Western",
                         BoxOffice = 3.99M,
                         Rating = "R"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
