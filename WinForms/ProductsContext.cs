using Microsoft.EntityFrameworkCore;

namespace WinForms;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Beverages" },
            new Category { CategoryId = 2, Name = "Snacks" },
            new Category { CategoryId = 3, Name = "Fruits" },
            new Category { CategoryId = 4, Name = "Vegetables" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Coffee" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Tea" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Orange Juice" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Soda" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Water" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Milk" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Smoothie" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Lemonade" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Beer" },
            new Product { ProductId = 10, CategoryId = 1, Name = "Wine" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Chips" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Cookies" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Crackers" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Popcorn" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Nuts" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Candy" },
            new Product { ProductId = 17, CategoryId = 2, Name = "Pretzels" },
            new Product { ProductId = 18, CategoryId = 2, Name = "Granola Bars" },
            new Product { ProductId = 19, CategoryId = 2, Name = "Trail Mix" },
            new Product { ProductId = 20, CategoryId = 2, Name = "Jerky" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Apple" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Banana" },
            new Product { ProductId = 23, CategoryId = 3, Name = "Strawberry" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Carrot" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Broccoli" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Spinach" },
            new Product { ProductId = 27, CategoryId = 4, Name = "Potato" },
            new Product { ProductId = 28, CategoryId = 4, Name = "Tomato" },
            new Product { ProductId = 29, CategoryId = 4, Name = "Onion" },
            new Product { ProductId = 30, CategoryId = 4, Name = "Garlic" },
            new Product { ProductId = 31, CategoryId = 4, Name = "Pepper" },
            new Product { ProductId = 32, CategoryId = 4, Name = "Lettuce" },
            new Product { ProductId = 33, CategoryId = 4, Name = "Cucumber" });
    }
}
