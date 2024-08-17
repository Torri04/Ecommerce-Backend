using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("Review")]
public class Review
{
    public Guid ProductID { get; set; }

    [ForeignKey("ProductID")]
    public Product? Product { get; set; }

    public string UserID { get; set; } = string.Empty;

    [ForeignKey("UserID")]
    public AppUser? User { get; set; }

    public string ReviewText { get; set; } = string.Empty;

    public int Rating { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
