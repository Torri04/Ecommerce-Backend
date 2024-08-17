using System;
using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Helpers;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Repositories
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly IMapper _mapper;
        private readonly MyDbContext _context;

        public PromotionRepository(MyDbContext contex, IMapper mapper)
        {
            _context = contex;
            _mapper = mapper;
        }
        public async Task<List<Promotion>?> GetAllAsync()
        {
            return await _context.Promotions.ToListAsync();
        }
        public async Task<Promotion?> GetByIdAsync(Guid id)
        {
            return await _context.Promotions.FirstOrDefaultAsync(x => x.PromotionID == id);
        }
        public async Task<Promotion?> PostAsync(Promotion promotion)
        {
            await _context.Promotions.AddAsync(promotion);
            await _context.SaveChangesAsync();

            var promotionAfter = await GetByIdAsync(promotion.PromotionID);
            return promotionAfter;
        }
        public async Task<Promotion?> PutAsync(Guid id, PutPromotionDto putPromotionDto)
        {
            var promotion = await GetByIdAsync(id);

            if (promotion == null)
                return null;

            _mapper.Map(putPromotionDto, promotion);
            await _context.SaveChangesAsync();

            var promotionAfter = await GetByIdAsync(promotion.PromotionID);
            return promotionAfter;
        }
        public async Task<Promotion?> DeleteAsync(Guid id)
        {
            var promotion = await GetByIdAsync(id);

            if (promotion == null)
                return null;

            _context.Remove(promotion);
            await _context.SaveChangesAsync();

            return promotion;
        }
    }
}