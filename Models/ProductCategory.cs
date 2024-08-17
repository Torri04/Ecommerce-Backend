using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("ProductCategory")]
public class ProductCategory
{
    [Key]
    public Guid ProductCategoryID { get; set; } = Guid.NewGuid();

    public string CategoryName { get; set; } = string.Empty;

    public string? CategoryShortDescription { get; set; }

    public List<Product>? Products { get; set; }
}