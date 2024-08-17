using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class PostSignInDto
{
    [Required]
    public string UserName { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; } = string.Empty;
}