using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniMoviesApp.Data.Models;

namespace MiniMoviesApp.Pages.en._Movie
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var value = $"{Movie.Title}-{Movie.Rate}-{Movie.Description}";
            if (ModelState.IsValid is false)
            {
                return Page();
            }
            return Redirect("Movies");
        }
    }
}
