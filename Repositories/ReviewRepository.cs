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
    public class ReviewRepository : IReviewRepository
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Review>?> GetByIdAsync(Guid productId)
        {
            return await _context.Reviews.Include(x => x.User).Where(x => x.ProductID == productId).ToListAsync();
        }

        public async Task<Review?> PostAsync(Review reviewBefore)
        {
            await _context.AddAsync(reviewBefore);
            await _context.SaveChangesAsync();

            var reviewAfter = await _context.Reviews.Include(x => x.User).FirstOrDefaultAsync(x => x.ProductID == reviewBefore.ProductID && x.UserID == reviewBefore.UserID);

            return reviewAfter;
        }

        public async Task<Review?> PutAsync(Guid productId, string userId, PutReviewDto putReviewDto)
        {
            var review = await _context.Reviews.SingleOrDefaultAsync(x => x.ProductID == productId && x.UserID == userId);

            if (review == null)
                return null;

            _mapper.Map(putReviewDto, review);
            await _context.SaveChangesAsync();

            var reviewAfter = await _context.Reviews.Include(x => x.User).SingleOrDefaultAsync(x => x.ProductID == productId && x.UserID == userId);

            return reviewAfter;
        }

        public async Task<Review?> DeleteAsync(Guid productId, string userId)
        {
            var review = await _context.Reviews.SingleOrDefaultAsync(x => x.ProductID == productId && x.UserID == userId);

            if (review == null)
                return null;

            _context.Remove(review);
            await _context.SaveChangesAsync();

            return review;
        }

    }
}