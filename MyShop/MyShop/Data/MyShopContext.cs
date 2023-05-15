using Microsoft.EntityFrameworkCore;
using MyShop.Data.Models;

namespace MyShop.Data {
    public class MyShopContext : DbContext {
        public MyShopContext(DbContextOptions options) : base(options) {
        }

        DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>().HasData(
                new Product {
                    ID = 1,
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 10.0,
                    Category = "Cat1"
                },
                new Product {
                    ID = 2,
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 20.0,
                    Category = "Cat2"
                }
            );
        }
    }
}
