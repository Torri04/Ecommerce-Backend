using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace ASP.NET_API.Dtos;

public class PutRefreshTokenDto
{
    public string Token { get; set; } = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
    public DateTime ExpiriedDate { get; set; } = DateTime.UtcNow.AddDays(7);
}