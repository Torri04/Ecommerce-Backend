using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("Product")]
public class Product
{
    [Key]
    public Guid ProductID { get; set; } = Guid.NewGuid();

    public string ProductName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Price { get; set; }

    public int StockQuantity { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public string ImageUrl { get; set; } = string.Empty;

    public Guid CategoryID { get; set; }

    [ForeignKey("CategoryID")]
    public ProductCategory? ProductCategory { get; set; }

    public List<OrderItem>? OrderItems { get; set; }
    public List<CartItem>? CartItems { get; set; }
    public List<WishListItem>? WishListItems { get; set; }
    public List<Review>? Reviews { get; set; }

}