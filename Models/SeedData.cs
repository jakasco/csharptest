using ConnectingThings.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ConnectingThings.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ConnectingThingsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ConnectingThingsContext>>()))
            {
                // Look for any movies.
                if (context.Authorization.Any())
                {
                    return;   // DB has been seeded
                }

                context.Authorization.AddRange(
                    new Authorization
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Username = "Romantic Comedy",
                        Password = "asdsds",
                        Email = "ads"
                    },

                    new Authorization
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Username = "Comedy",
                        Password = "asdsds",
                        Email = "ads"
                    },

                    new Authorization
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Username = "Comedy",
                        Password = "asdsds",
                        Email = "ads"
                    },

                    new Authorization
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Username = "Western",
                        Password = "asdsds",
                        Email = "ads"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
