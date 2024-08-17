namespace ASP.NET_API.Dtos;

public class GetProductDto
{
    public Guid ProductID { get; set; }

    public string ProductName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Price { get; set; }

    public int StockQuantity { get; set; }

    public DateTime CreatedDate { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    public GetProductCategoryDto? ProductCategory { get; set; }
}