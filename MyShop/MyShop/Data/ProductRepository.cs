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
            throw new NotImplementedException();
        }

        public Product GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Product product) {
            throw new NotImplementedException();
        }
    }
}
