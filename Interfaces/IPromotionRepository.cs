using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Model;

namespace ASP.NET_API.Interfaces
{
    public interface IPromotionRepository
    {
        Task<List<Promotion>?> GetAllAsync();
        Task<Promotion?> GetByIdAsync(Guid id);
        Task<Promotion?> PostAsync(Promotion promotion);
        Task<Promotion?> PutAsync(Guid id, PutPromotionDto putPromotionDto);
        Task<Promotion?> DeleteAsync(Guid id);
    }
}