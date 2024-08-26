using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniMoviesApp.Data.Db;
using MiniMoviesApp.Data.Models;
using MiniMoviesApp.Services;

namespace MiniMoviesApp.Pages.en._Movie;

public class MoviesModel : PageModel
{
    public List<Movie> movie { get; set; }
    private readonly IServiceMovie _service;

    public MoviesModel(IServiceMovie service)
    {
        _service = service;
    }

    public void OnGet()
    {
        movie = _service.GetAllMovies();
    }
}


