using System.ComponentModel.DataAnnotations;
using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos;

public class PostOrderDto
{
    [Required(ErrorMessage = "{0} is required")]
    [MinLength(1, ErrorMessage = "Order must contain at least one item")]
    public List<PostOrderItemDto>? OrderItems { get; set; }
}