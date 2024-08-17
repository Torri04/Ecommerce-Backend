using System.ComponentModel.DataAnnotations;
using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos
{
    public class PostShoppingCartDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [MinLength(1, ErrorMessage = "ShoppingCart must contain at least one item")]
        public List<PostCartItemDto>? CartItems { get; set; }
    }
}
