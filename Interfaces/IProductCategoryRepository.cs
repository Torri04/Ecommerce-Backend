using ASP.NET_API.Dtos;
using ASP.NET_API.Model;

namespace ASP.NET_API.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<List<ProductCategory>> GetAllAsync();
        Task<ProductCategory?> GetByIdAsync(Guid id);
        Task<ProductCategory?> PostAsync(ProductCategory productCategory);
        Task<ProductCategory?> PutAsync(Guid id, PutProductCategoryDto putProductCategoryDto);
        Task<ProductCategory?> DeleteAsync(Guid id);
        Task<bool> CheckExistAsync(Guid id);
    }
}