using Microsoft.EntityFrameworkCore;
using MiniMoviesApp.Data.Models;

namespace MiniMoviesApp.Data.Db;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Title = "Active", Description = "An action-packed adventure", Rate = 10 },
            new Movie { Id = 2, Title = "Silent Night", Description = "A quiet, reflective film", Rate = 3 },
            new Movie { Id = 3, Title = "Moonlight", Description = "A dramatic story of self-discovery", Rate = 4 },
            new Movie { Id = 4, Title = "Sunrise", Description = "A heartwarming tale of new beginnings", Rate = 8 },
            new Movie { Id = 5, Title = "Eclipse", Description = "A thrilling mystery with unexpected twists", Rate = 4 },
            new Movie { Id = 6, Title = "Nebula", Description = "A science fiction journey through space", Rate = 5 },
            new Movie { Id = 7, Title = "Harmony", Description = "A musical drama that captivates the soul", Rate = 7 },
            new Movie { Id = 8, Title = "Dusk", Description = "A suspenseful story set in the twilight hours", Rate = 9 },
            new Movie { Id = 9, Title = "Journey", Description = "An epic adventure across continents", Rate = 5 },
            new Movie { Id = 10, Title = "Reflections", Description = "A thoughtful exploration of human nature", Rate = 4 }
        );
    }
}