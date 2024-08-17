using ASP.NET_API.Dtos;
using ASP.NET_API.Model;
using Azure.Storage.Queues.Models;

namespace ASP.NET_API.Interfaces
{
    public interface IWishListRepository
    {
        Task<WishList?> GetByIdAsync(string userId);
        Task<WishList?> PostAsync(string userId, List<Guid> productIDs);
        Task<WishList?> DeleteAsync(string userId, List<Guid> productIds);
    }
}