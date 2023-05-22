using Microsoft.AspNetCore.Mvc;
using MyShop.Data;
using MyShop.Data.Models;

namespace MyShop.Components {
    public class ProductListViewComponent : ViewComponent {
        private readonly IProductRepository _repo;

        public ProductListViewComponent(IProductRepository repo) {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public IViewComponentResult Invoke() {
            List<Product> items = _repo.GetAll();
            return View(items);
        }
    }
}
