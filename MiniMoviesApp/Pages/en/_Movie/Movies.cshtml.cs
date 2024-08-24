using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniMoviesApp.Data.Models;

namespace MiniMoviesApp.Pages.en._Movie;

public class MoviesModel : PageModel
{
    public List<Movie>? _movies {  get; set; }

    public void OnGet()
    {
        _movies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "First Movie",
                Rate = 5,
                Description = "Description 1"
            },
            new Movie()
            {
                Id = 2,
                Title = "Second Movie",
                Rate = 6,
                Description = "Description 2"
            },
            new Movie()
            {
                Id = 3,
                Title = "Third Movie",
                Rate = 7,
                Description = "Description 3"
            },
            new Movie()
            {
                Id = 4,
                Title = "Forth Movie",
                Rate = 8,
                Description = "Description 4"
            },
            new Movie()
            {
                Id = 5,
                Title = "fifth Movie",
                Rate = 9,
                Description = "Description 5"
            }
        };
    }
}


