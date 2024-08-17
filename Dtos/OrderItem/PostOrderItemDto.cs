using System.ComponentModel.DataAnnotations;
using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos;

public class PostOrderItemDto
{
    [Required(ErrorMessage = "{0} is required")]
    [Range(1, 100, ErrorMessage = "{0} must be between {1} and {2}")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    public Guid ProductID { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Range(0, 100000000, ErrorMessage = "{0} must be between {1} and {2}")]
    public int UnitPrice { get; set; }
}