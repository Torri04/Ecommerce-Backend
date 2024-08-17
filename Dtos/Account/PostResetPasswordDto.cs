using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Dtos;

public class PostResetPasswordDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Token { get; set; } = string.Empty;

    [Required]
    [MinLength(5, ErrorMessage = "{0} must be {1} characters")]
    [MaxLength(30, ErrorMessage = "{0} can not be over {1} characters")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
