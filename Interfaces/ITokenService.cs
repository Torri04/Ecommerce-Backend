using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Model;

namespace ASP.NET_API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user, string role);
        Task<RefreshToken?> CreateRefreshTokenAsync(AppUser user);
        Task<RefreshToken?> UpdateRefreshTokenAsync(AppUser user);
        Task<bool> IsRefreshTokenExpiriedAsync(AppUser user);
        Task<bool> IsRefreshTokenExistAsync(AppUser user);
        Task<RefreshToken?> GetRefreshTokenAsync(AppUser user);
    }
}