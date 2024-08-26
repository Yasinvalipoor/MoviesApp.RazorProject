using MiniMoviesApp.Data.Models;

namespace MiniMoviesApp.Services;

public interface IServiceMovie
{
    public List<Movie> GetAllMovies();
    public Movie? GetMovieByName(string name);
    public Movie? GetMovieById(int id);
    public void AddMovie(Movie movie);
}
