using Microsoft.EntityFrameworkCore;
using MyShop.Data.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyShop.Data {
    public class MyShopContext : DbContext {
        public MyShopContext(DbContextOptions options) : base(options) {
        }

        DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            // TODO: Simon: fix path!!!
            //string data = File.ReadAllText("Data/SeedData.json");
            //JsonSerializer.Deserialize<Product>(data);

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
