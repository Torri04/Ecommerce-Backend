using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos
{
    public class GetWishListDto
    {
        public Guid WishListID { get; set; } = Guid.NewGuid();
        public string UserID { get; set; } = string.Empty;
        public List<GetWishListItemDto>? WishListItems { get; set; }
    }
}