using System.ComponentModel.DataAnnotations;
using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos;

public class PutReviewDto
{
    [Required(ErrorMessage = "{0} is required")]
    [MinLength(5, ErrorMessage = "{0} must be {1} characters")]
    [MaxLength(280, ErrorMessage = "{0} can not be over {1} characters")]
    public string ReviewText { get; set; } = string.Empty;

    [Required(ErrorMessage = "{0} is required")]
    [Range(1, 5, ErrorMessage = "{0} must be between {1} and {2}")]
    public int Rating { get; set; }
}