using Microsoft.EntityFrameworkCore;
using MiniMoviesApp.Data.Models;

namespace MiniMoviesApp.Data.Db;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }

    public DbSet<Movie> movies { get; set; }
}
