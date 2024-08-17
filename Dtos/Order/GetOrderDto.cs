using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos
{
    public class GetOrderDto
    {
        public Guid OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
        public int TotalAmount { get; set; }
        public GetAppUserDto? User { get; set; }
        public List<GetOrderItemDto>? OrderItems { get; set; }
    }
}

