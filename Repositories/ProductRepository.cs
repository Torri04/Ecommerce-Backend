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
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext _context;
        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllAsync(ProductQuery query)
        {
            var products = _context.Products.Include(p => p.ProductCategory).AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.ProductName))
            {
                products = products.Where(p => p.ProductName.Contains(query.ProductName));
            }
            if (query.Price.HasValue)
                products = products.Where(p => p.Price == query.Price);

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("ProductName", StringComparison.OrdinalIgnoreCase))
                {
                    products = query.IsDescending ? products.OrderByDescending(p => p.ProductName) : products.OrderBy(p => p.ProductName);
                }
            }
            if (query.PageSize.HasValue && query.PageNumber.HasValue)
            {
                var skipNumber = (query.PageNumber - 1) * query.PageSize;
                products = products.Skip(skipNumber.Value).Take(query.PageSize.Value);
            }

            return await products.ToListAsync();
        }
        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _context.Products.Include(p => p.ProductCategory).FirstOrDefaultAsync(p => p.ProductID == id);
        }
        public async Task<Product> PostAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<Product?> PutAsync(Guid id, PutProductDto putProductDto)
        {
            var existingProduct = await _context.Products.Include(p => p.ProductCategory).FirstOrDefaultAsync(p => p.ProductID == id);

            if (existingProduct == null)
                return null;
            else
            {
                _context.Entry(existingProduct).CurrentValues.SetValues(putProductDto);
                await _context.SaveChangesAsync();
                return existingProduct;
            }
        }
        public async Task<Product?> DeleteAsync(Guid id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == id);

            if (product == null)
                return null;
            else
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return product;
            }
        }
    }
}