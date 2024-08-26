using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniMoviesApp.Data.Models;
using MiniMoviesApp.Services;

namespace MiniMoviesApp.Pages.en._Movie;

public class MovieModel : PageModel
{
    public Movie? movie { get; set; }
    private readonly IServiceMovie _service;

    public MovieModel(IServiceMovie service)
    {
        _service = service;
    }

    public void OnGet(string title)
    {
        movie = _service.GetMovieByName(title);
    }
}
