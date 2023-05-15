using Microsoft.EntityFrameworkCore;
using MyShop.Data.Models;

namespace MyShop.Data {
    public class MyShopContext : DbContext {
        public MyShopContext() {
        }

        DbSet<Product> Products { get; set; }
    }
}
