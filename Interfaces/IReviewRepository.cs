using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Model;

namespace ASP.NET_API.Interfaces
{
    public interface IReviewRepository
    {
        Task<List<Review>?> GetByIdAsync(Guid productId);
        Task<Review?> PostAsync(Review reviewBefore);
        Task<Review?> PutAsync(Guid productId, string userId, PutReviewDto putReviewDto);
        Task<Review?> DeleteAsync(Guid productId, string userId);
    }
}