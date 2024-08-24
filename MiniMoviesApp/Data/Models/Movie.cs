using System.ComponentModel.DataAnnotations;

namespace MiniMoviesApp.Data.Models;

public class Movie
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; } = string.Empty;
    
    [Range(1, 10, ErrorMessage = "Rate must be between 1 and 10.")]
    public int Rate { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; } = string.Empty;
}
