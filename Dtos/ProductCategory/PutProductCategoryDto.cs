using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class PutProductCategoryDto
{
    [Required(ErrorMessage = "{0} is required")]
    [MinLength(5, ErrorMessage = "{0} must be {1} characters")]
    [MaxLength(280, ErrorMessage = "{0} can not be over {1} characters")]
    public string CategoryName { get; set; } = string.Empty;

    [MaxLength(280, ErrorMessage = "{0} can not be over {1} characters")]
    public string? CategoryShortDescription { get; set; }
}