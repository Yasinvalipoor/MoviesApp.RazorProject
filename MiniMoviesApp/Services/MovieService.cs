using MiniMoviesApp.Data.Db;
using MiniMoviesApp.Data.Models;

namespace MiniMoviesApp.Services;
public class MovieService : IServiceMovie
{
    private readonly MovieContext _context;

    public MovieService(MovieContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }
    public void AddMovie(Movie movie)
    {
        _context.movies.Add(movie);
        _context.SaveChanges();
    }

    public List<Movie> GetAllMovies() => _context.movies.ToList();
    

    public Movie? GetMovieById(int id) =>_context.movies.FirstOrDefault(x => x.Id == id);
    

    public Movie? GetMovieByName(string name) => _context.movies.FirstOrDefault(x => x.Title == name);
    
}
