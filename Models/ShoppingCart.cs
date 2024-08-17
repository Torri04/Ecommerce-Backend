using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("ShoppingCart")]
public class ShoppingCart
{
    [Key]
    public Guid ShoppingCartID { get; set; } = Guid.NewGuid();

    public string UserID { get; set; } = string.Empty;

    public int TotalAmount
    {
        get
        {
            return CartItems?.Sum(item => item.TotalPrice) ?? 0;
        }
        set { }
    }

    [ForeignKey("UserID")]
    public AppUser? User { get; set; }

    public List<CartItem>? CartItems { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
