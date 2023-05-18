using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Data;
using MyShop.Data.Models;

namespace MyShop.Pages.Products {
    public class ShowAllProductsModel : PageModel {
        private readonly IProductRepository _repo;

        public ShowAllProductsModel(IProductRepository repo)        {
            _repo = repo;            
        }

        public List<Product> Products { get; set; }

        public void OnGet() {
            Products = _repo.GetAll();
        }
    }
}
