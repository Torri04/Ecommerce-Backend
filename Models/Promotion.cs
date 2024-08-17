using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("Promotion")]
public class Promotion
{
    [Key]
    public Guid PromotionID { get; set; } = Guid.NewGuid();
    public string PromotionName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int DiscountAmount { get; set; }
    public int MinOrderAmountRequired { get; set; }
    public int MaxDiscount { get; set; }
    public DateTime CreatedDay { get; set; } = DateTime.Now;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; } = false;
}
