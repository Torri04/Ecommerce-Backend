using ASP.NET_API.Dtos;
using ASP.NET_API.Model;
using Azure.Storage.Queues.Models;

namespace ASP.NET_API.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync(string? userId = null);
        Task<Order?> GetByIdAsync(Guid id);
        Task<Order?> PostAsync(Order order);
        Task<Order?> PutOrderItemsAsync(Guid id, PutOrderDto putOrderDto);
        Task<Order?> PutOrderStatusAsync(Guid id, string status);
    }
}
