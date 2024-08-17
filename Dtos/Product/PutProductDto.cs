using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class PutProductDto
{
    [MinLength(5, ErrorMessage = "{0} must be {1} characters")]
    [MaxLength(280, ErrorMessage = "{0} can not be over {1} characters")]
    public string ProductName { get; set; } = string.Empty;

    [MaxLength(280, ErrorMessage = "{0} can not be over {1} characters")]
    public string? Description { get; set; }

    [Range(0, 100000000, ErrorMessage = "{0} must be between {1} and {2}")]
    public int Price { get; set; }

    [Range(0, 100000, ErrorMessage = "{0} must be between {1} and {2}")]
    public int StockQuantity { get; set; }

    public IFormFile? ProductImage { get; set; }

    public Guid CategoryID { get; set; }
}