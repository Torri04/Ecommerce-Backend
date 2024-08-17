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
    public class WishListRepository : IWishListRepository
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        public WishListRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WishList?> GetByIdAsync(string userId)
        {
            return await _context.WishLists.Include(x => x.WishListItems)
                                                .ThenInclude(x => x.Product)
                                                .ThenInclude(x => x.ProductCategory)
                                            .FirstOrDefaultAsync(x => x.UserID == userId);
        }

        public async Task<WishList?> PostAsync(string userId, List<Guid> productIDs)
        {
            var wishListId = await _context.WishLists.Where(x => x.UserID == userId).Select(x => x.WishListID).FirstOrDefaultAsync();

            var wishListItem = productIDs.Select(x => new WishListItem { WishListID = wishListId, ProductID = x });

            await _context.AddRangeAsync(wishListItem);
            await _context.SaveChangesAsync();

            var wishList = await GetByIdAsync(userId);
            return wishList;
        }

        public async Task<WishList?> DeleteAsync(string userId, List<Guid> productIds)
        {
            var wishList = await _context.WishLists
                .Include(w => w.WishListItems)
                .FirstOrDefaultAsync(w => w.UserID == userId);

            if (wishList == null)
                return null;

            var wishListItems = wishList.WishListItems
                .Where(item => productIds.Contains(item.ProductID))
                .ToList();

            if (wishListItems.Any())
            {
                _context.WishListItems.RemoveRange(wishListItems);
                await _context.SaveChangesAsync();
            }

            return wishList;
        }
    }
}