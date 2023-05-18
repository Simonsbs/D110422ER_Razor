using Microsoft.EntityFrameworkCore;
using MyShop.Data.Models;

namespace MyShop.Data {
    public class ProductRepository : IProductRepository {
        private readonly MyShopContext _context;

        public ProductRepository(MyShopContext context) {
            _context = context;
        }

        public void Add(Product product) {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Product product) {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() {
            return _context.Products.ToList();
        }

        public Product GetById(int id) {
            return _context.Products.FirstOrDefault(p => p.ID == id);
        }

        public void Update(Product product) {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
