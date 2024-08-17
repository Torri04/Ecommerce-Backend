using ASP.NET_API.Data;
using ASP.NET_API.Dtos;
using ASP.NET_API.Interfaces;
using ASP.NET_API.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly MyDbContext _context;


        public ProductCategoryRepository(MyDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductCategory>> GetAllAsync()
        {
            return await _context.ProductCategories.ToListAsync();
        }
        public async Task<ProductCategory?> GetByIdAsync(Guid id)
        {
            return await _context.ProductCategories.FirstOrDefaultAsync(p => p.ProductCategoryID == id);
        }
        public async Task<ProductCategory?> PostAsync(ProductCategory productCategory)
        {
            await _context.ProductCategories.AddAsync(productCategory);
            await _context.SaveChangesAsync();
            return productCategory;
        }
        public async Task<ProductCategory?> PutAsync(Guid id, PutProductCategoryDto putProductCategoryDto)
        {
            var productCategory = await _context.ProductCategories.FirstOrDefaultAsync(p => p.ProductCategoryID == id);

            if (productCategory == null)
                return null;
            else
            {
                _context.Entry(productCategory).CurrentValues.SetValues(putProductCategoryDto);
                await _context.SaveChangesAsync();
                return productCategory;
            }
        }
        public async Task<ProductCategory?> DeleteAsync(Guid id)
        {
            var productCategory = _context.ProductCategories.FirstOrDefault(p => p.ProductCategoryID == id);

            if (productCategory == null)
            {
                return null;
            }
            else
            {
                _context.ProductCategories.Remove(productCategory);
                await _context.SaveChangesAsync();

                return productCategory;
            }
        }

        public async Task<bool> CheckExistAsync(Guid id)
        {
            return await _context.ProductCategories.AnyAsync(p => p.ProductCategoryID == id);
        }
    }
}
