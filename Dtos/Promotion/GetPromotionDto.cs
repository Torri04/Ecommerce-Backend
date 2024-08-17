namespace ASP.NET_API.Dtos;

public class GetPromotionDto
{
    public Guid PromotionID { get; set; }
    public string PromotionName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int DiscountAmount { get; set; }
    public int MinOrderAmountRequired { get; set; }
    public int MaxDiscount { get; set; }
    public DateTime CreatedDay { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
}