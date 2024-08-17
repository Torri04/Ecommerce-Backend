using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;
public class OrderItem
{
    public Guid OrderID { get; set; }
    public Guid ProductID { get; set; }

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

    [ForeignKey("OrderID")]
    public Order? Order { get; set; }

    [ForeignKey("ProductID")]
    public Product? Product { get; set; }
}
