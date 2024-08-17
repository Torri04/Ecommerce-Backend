using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class GetUserTokenDto
{
    public string Token { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
}