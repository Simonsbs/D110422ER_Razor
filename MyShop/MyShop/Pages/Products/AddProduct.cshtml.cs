using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Data;
using MyShop.Data.Models;

namespace MyShop.Pages.Products {
    public class AddProductModel : PageModel {
        private readonly MyShopContext _context;

        public AddProductModel(MyShopContext context) {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [BindProperty]
        public Product NewProduct { get; set; }

        public void OnGet() {
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Products.Add(NewProduct);
            _context.SaveChanges();

            return RedirectToPage("ShowAllProducts");
        }
    }
}
