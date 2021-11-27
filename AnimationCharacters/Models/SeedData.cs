using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AnimationCharacters.Data;
using System;
using System.Linq;

namespace AnimationCharacters.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AnimationCharactersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AnimationCharactersContext>>()))
            {
                // Look for any Characters.
                if (context.Character.Any())
                {
                    return;   // DB has been seeded
                }

                context.Character.AddRange(
                    new Character
                    {
                        TitleMovie = "Moana",
                        ReleaseDate = DateTime.Parse("2017-1-5"),
                        NameCharacter = "Moana",
                        CategoryCharacter = "Protagonist",
                        Scenery = "Oceania"
                    },

                    new Character
                    {
                        TitleMovie = "Moana",
                        ReleaseDate = DateTime.Parse("2017-1-5"),
                        NameCharacter = "Maui",
                        CategoryCharacter = "Supporting",
                        Scenery = "Oceania"
                    },

                    new Character
                    {
                        TitleMovie = "Spirited away",
                        ReleaseDate = DateTime.Parse("2003-7-18"),
                        NameCharacter = "Chihiro",
                        CategoryCharacter = "Protagonist",
                        Scenery = "Japan"
                    },

                    new Character
                    {
                        TitleMovie = "Spider-Man: Into the spider-verse",
                        ReleaseDate = DateTime.Parse("2017-1-10"),
                        NameCharacter = "Miles Morales",
                        CategoryCharacter = "Protagonist",
                        Scenery = "New York"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}