using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using ASP.NET_API.Model;

namespace ASP.NET_API.Dtos;

public class PostRefreshTokenDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Token { get; set; } = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
    public DateTime ExpiriedDate { get; set; } = DateTime.UtcNow.AddDays(7);
    public string UserId { get; set; } = string.Empty;
    public PostRefreshTokenDto(string userId)
    {
        UserId = userId;
    }
}
