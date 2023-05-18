using MyShop.Data.Models;

namespace MyShop.Data {
    public interface IProductRepository {
        public void Add(Product product);
        public Product GetById(int id);
        public List<Product> GetAll();
        public void Update(Product product);
        public void Delete(int id);
        
    }
}
