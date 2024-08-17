using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class PostForgotPasswordDto
{
    [Required]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}
