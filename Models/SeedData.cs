using Microsoft.EntityFrameworkCore;
using VHSVibesLair.Data;

namespace VHSVibesLair.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new VHSVibesLairContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<VHSVibesLairContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null VHSVibesLairContext");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R",
                    Plot = "Harry and Sally have known each other for years, and are very good friends, but they fear sex would ruin the friendship."
                },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "G",
                    Plot= "A squad of supernatural investigators are Earth's only defense against an evil ghost wizard and his minions."
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "G",
                    Plot = "The discovery of a massive river of ectoplasm and a resurgence of spectral activity allows the staff of Ghostbusters to revive the business."
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG",
                    Plot = "A small-town sheriff in the American West enlists the help of a disabled man, a drunk, and a young gunfighter in his efforts to hold in jail the brother of the local bad guy"
                }
            );
            context.SaveChanges();
        }
    }
}