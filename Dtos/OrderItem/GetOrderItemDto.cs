using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos;

public class GetOrderItemDto
{
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
    public int TotalPrice { get; set; }
    public GetProductDto? Product { get; set; }
}