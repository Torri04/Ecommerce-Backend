using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("Order")]
public class Order
{
    [Key]
    public Guid OrderID { get; set; } = Guid.NewGuid();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string OrderStatus { get; set; } = "Pending";
    public int TotalAmount
    {
        get
        {
            return OrderItems?.Sum(item => item.TotalPrice) ?? 0;
        }
        set { }
    }

    public string UserID { get; set; } = string.Empty;

    [ForeignKey("UserID")]
    public AppUser? User { get; set; }

    public List<OrderItem>? OrderItems { get; set; }
}