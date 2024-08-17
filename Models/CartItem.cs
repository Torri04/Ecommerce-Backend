using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("CartItems")]
public class CartItem
{
    public Guid ShoppingCartID { get; set; }

    [ForeignKey("ShoppingCartID")]
    public ShoppingCart? ShoppingCart { get; set; }

    public Guid ProductID { get; set; }

    [ForeignKey("ProductID")]
    public Product? Product { get; set; }

    public int Quantity { get; set; }

    public int UnitPrice { get; set; }

    public int TotalPrice
    {
        get
        {
            return UnitPrice * Quantity;
        }
        set { }
    }
}
