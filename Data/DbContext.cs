using ASP.NET_API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Data;

public class MyDbContext : IdentityDbContext<AppUser>
{
    public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        });

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLoggerFactory(loggerFactory);
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        FakeData.Faking(modelBuilder);

        List<IdentityRole> roles = new List<IdentityRole>() {
            new IdentityRole {Name = "Admin", NormalizedName = "ADMIN"},
            new IdentityRole {Name ="User", NormalizedName = "USER"}
        };
        modelBuilder.Entity<IdentityRole>(entity => entity.HasData(roles));

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();

            if (tableName.StartsWith("AspNet"))
            {
                entityType.SetTableName(tableName.Replace("AspNet", ""));
            }
        }
        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(x => new { x.OrderID, x.ProductID });
        });
        modelBuilder.Entity<CartItem>(entity => entity.HasKey(x => new { x.ProductID, x.ShoppingCartID }));

        modelBuilder.Entity<WishListItem>(entity => entity.HasKey(x => new { x.ProductID, x.WishListID }));

        modelBuilder.Entity<Review>(entity => entity.HasKey(x => new { x.ProductID, x.UserID }));
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<WishList> WishLists { get; set; }
    public DbSet<WishListItem> WishListItems { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
}