using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("WishListItem")]
public class WishListItem
{
    public Guid WishListID { get; set; }

    public Guid ProductID { get; set; }

    [ForeignKey("WishListID")]
    public WishList? WishList { get; set; }

    [ForeignKey("ProductID")]
    public Product? Product { get; set; }
}
