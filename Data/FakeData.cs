using ASP.NET_API.Model;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Data;

public static class FakeData
{
    public static Faker<Product> ProductFaker = new Faker<Product>();
    public static List<Product>? Products { get; set; }

    public static Faker<ProductCategory> ProductCategoryFaker = new Faker<ProductCategory>();
    public static List<ProductCategory>? ProductCategories { get; set; }

    public static Faker<Order> OrderFaker = new Faker<Order>();
    public static List<Order>? Orders { get; set; }

    public static void Faking(ModelBuilder modelBuilder)
    {
        //Faking Product Category
        ProductCategories = ProductCategoryFaker.StrictMode(false).UseSeed(1122)
        .RuleFor(x => x.ProductCategoryID, r => Guid.NewGuid())
        .RuleFor(x => x.CategoryName, r => r.Lorem.Sentence(1))
        .RuleFor(x => x.CategoryShortDescription, r => r.Lorem.Paragraph(3))
        .Generate(10);
        modelBuilder.Entity<ProductCategory>().HasData(ProductCategories);

        //Faking Product
        Products = ProductFaker.StrictMode(false).UseSeed(2233)
            .RuleFor(x => x.ProductID, r => Guid.NewGuid())
            .RuleFor(x => x.ProductName, r => r.Lorem.Sentence(1))
            .RuleFor(x => x.Description, r => r.Lorem.Paragraph(3))
            .RuleFor(x => x.Price, r => r.Random.Number(0, 100000000))
            .RuleFor(x => x.StockQuantity, r => r.Random.Number(0, 5000))
            .RuleFor(x => x.CreatedDate, r => DateTime.Now)
            .RuleFor(x => x.CategoryID, r => r.PickRandom(ProductCategories).ProductCategoryID)
            .Generate(30);
        modelBuilder.Entity<Product>().HasData(Products);
    }
}

