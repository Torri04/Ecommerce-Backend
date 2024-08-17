using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("WishList")]
public class WishList
{
    [Key]
    public Guid WishListID { get; set; } = Guid.NewGuid();

    public string UserID { get; set; } = string.Empty;

    [ForeignKey("UserID")]
    public AppUser? User { get; set; }

    public List<WishListItem>? WishListItems { get; set; }
}
