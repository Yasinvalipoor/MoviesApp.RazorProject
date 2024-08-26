using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniMoviesApp.Data.Db;
using MiniMoviesApp.Data.Models;
using MiniMoviesApp.Services;

namespace MiniMoviesApp.Pages.en._Movie;

public class AddMovieModel : PageModel
{
    private readonly IServiceMovie _service;

    public AddMovieModel(IServiceMovie service)
    {
        _service = service;
    }

    [BindProperty]
    public Movie Movie { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid is false)
        {
            return Page();
        }
        var movie = new Movie()
        {
            Title = Movie.Title,
            Description = Movie.Description,
            Rate = Movie.Rate,

        };
        _service.AddMovie(movie);
        return Redirect("Movies");  
    }
}
