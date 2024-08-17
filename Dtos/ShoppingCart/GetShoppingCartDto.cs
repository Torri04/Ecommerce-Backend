using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos
{
    public class GetShoppingCartDto
    {
        public Guid ShoppingCartID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TotalAmount { get; set; }
        public GetAppUserDto? User { get; set; }
        public List<GetCartItemDto>? CartItems { get; set; }
    }
}
