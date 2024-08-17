using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        public OrderRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Order>> GetAllAsync(string? userId = null)
        {
            return await _context.Orders
                        .Include(x => x.User)
                        .Include(x => x.OrderItems)
                            .ThenInclude(x => x.Product)
                        .Where(x => string.IsNullOrEmpty(userId) || x.UserID == userId)
                        .ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(Guid id)
        {
            return await _context.Orders
                        .Include(x => x.User)
                        .Include(x => x.OrderItems)
                            .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.ProductCategory)
                        .FirstOrDefaultAsync(x => x.OrderID == id);
        }

        public async Task<Order?> PostAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            order = await GetByIdAsync(order.OrderID);
            return order;
        }

        public async Task<Order?> PutOrderItemsAsync(Guid id, PutOrderDto putOrderDto)
        {
            var existingOrder = await GetByIdAsync(id);

            if (existingOrder == null)
                return null;
            else
            {
                _mapper.Map(putOrderDto, existingOrder);

                await _context.SaveChangesAsync();

                existingOrder = await GetByIdAsync(id);

                return existingOrder;
            }
        }

        public async Task<Order?> PutOrderStatusAsync(Guid id, string status)
        {
            var order = await GetByIdAsync(id);

            if (order == null)
                return null;

            order.OrderStatus = status;
            await _context.SaveChangesAsync();

            order = await GetByIdAsync(id);
            return order;
        }
    }
}