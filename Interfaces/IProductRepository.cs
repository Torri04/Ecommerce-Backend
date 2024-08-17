using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Model;

namespace ASP.NET_API.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(ProductQuery Query);
        Task<Product?> GetByIdAsync(Guid id);
        Task<Product> PostAsync(Product product);
        Task<Product?> PutAsync(Guid id, PutProductDto putProductDto);
        Task<Product?> DeleteAsync(Guid id);
    }
}