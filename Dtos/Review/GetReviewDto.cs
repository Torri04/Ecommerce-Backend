using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos;

public class GetReviewDto
{
    public Guid ProductID { get; set; }
    public GetAppUserDto? User { get; set; }
    public string ReviewText { get; set; } = string.Empty;
    public int Rating { get; set; }
    public DateTime CreatedDate { get; set; }
}