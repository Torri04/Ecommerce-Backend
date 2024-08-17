using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Model;

namespace ASP.NET_API.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<List<ShoppingCart>> GetAllAsync(string userId);
        Task<ShoppingCart?> GetByIdAsync(Guid shoppingCartId);
        Task<ShoppingCart?> PostAsync(ShoppingCart shoppingCart);
        Task<ShoppingCart?> PutAsync(Guid id, PutShoppingCartDto putShoppingCartDto);
        Task<ShoppingCart?> DeleteAsync(Guid id);
    }
}