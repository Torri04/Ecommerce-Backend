namespace ASP.NET_API.Dtos;

public class GetProductCategoryDto
{
    public Guid ProductCategoryID { get; set; }

    public string CategoryName { get; set; } = string.Empty;

    public string? CategoryShortDescription { get; set; }
}