using System;
using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ASP.NET_API.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public ShoppingCartRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ShoppingCart>> GetAllAsync(string userId)
        {
            return await _context.ShoppingCarts
                        .Include(x => x.User)
                        .Include(x => x.CartItems)
                            .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.ProductCategory)
                        .Where(x => x.UserID == userId)
                        .ToListAsync();
        }

        public async Task<ShoppingCart?> GetByIdAsync(Guid shoppingCartId)
        {
            return await _context.ShoppingCarts
                        .Include(x => x.User)
                        .Include(x => x.CartItems)
                            .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.ProductCategory)
                        .FirstOrDefaultAsync(x => x.ShoppingCartID == shoppingCartId);
        }
        public async Task<ShoppingCart?> PostAsync(ShoppingCart shoppingCart)
        {
            await _context.AddAsync(shoppingCart);
            await _context.SaveChangesAsync();

            shoppingCart = await GetByIdAsync(shoppingCart.ShoppingCartID);
            return shoppingCart;
        }

        public async Task<ShoppingCart?> PutAsync(Guid id, PutShoppingCartDto putShoppingCartDto)
        {
            var shoppingCart = await GetByIdAsync(id);

            if (shoppingCart == null)
                return null;

            _mapper.Map(putShoppingCartDto, shoppingCart);
            await _context.SaveChangesAsync();

            shoppingCart = await GetByIdAsync(id);

            return shoppingCart;
        }
        public async Task<ShoppingCart?> DeleteAsync(Guid id)
        {
            var shoppingCart = await GetByIdAsync(id);

            if (shoppingCart == null)
            {
                return null;
            }

            _context.ShoppingCarts.Remove(shoppingCart);
            await _context.SaveChangesAsync();

            return shoppingCart;
        }
    }
}