using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_API.Model;

public class AppUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string? Address { get; set; }
    public DateTime? BirthDate { get; set; }
    public RefreshToken? RefreshToken { get; set; }
    public List<Order>? Orders { get; set; }
    public List<ShoppingCart>? ShoppingCarts { get; set; }
    public WishList? WishList { get; set; }
    public List<Review>? Reviews { get; set; }
}