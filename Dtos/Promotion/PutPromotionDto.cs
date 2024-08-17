using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class PutPromotionDto
{
    [Required(ErrorMessage = "{0} is required")]
    [MinLength(5, ErrorMessage = "{0} must be {1} characters")]
    [MaxLength(50, ErrorMessage = "{0} can not be over {1} characters")]
    public string PromotionName { get; set; } = string.Empty;

    [MaxLength(280, ErrorMessage = "{0} can not be over {1} characters")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Range(0, 100, ErrorMessage = "{0} must be between {1} and {2}")]
    public int DiscountAmount { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Range(0, 100000000, ErrorMessage = "{0} must be between {1} and {2}")]
    public int MinOrderAmountRequired { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Range(0, 100000000, ErrorMessage = "{0} must be between {1} and {2}")]
    public int MaxDiscount { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [DateGreaterThan("StartDate")]
    public DateTime EndDate { get; set; }
}