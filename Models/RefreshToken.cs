using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_API.Model;

[Table("RefreshToken")]
public class RefreshToken
{
    [Key]
    public Guid Id { get; set; }
    public string Token { get; set; } = string.Empty;
    public DateTime ExpiriedDate { get; set; }
    public string UserId { get; set; } = string.Empty;

    [ForeignKey("UserId")]
    public AppUser? UserName { get; set; }
}
