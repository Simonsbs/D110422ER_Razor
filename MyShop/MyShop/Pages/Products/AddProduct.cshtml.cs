using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Data.Models;

namespace MyShop.Pages.Products {
    public class IndexModel : PageModel {
        
        [BindProperty]
        public Product NewProduct { get; set; }

        public void OnGet() {
        }

        public IActionResult OnPost() { 
            if (!ModelState.IsValid) {
                return Page();
            }

            // TODO: Add to DB

            return RedirectToPage("ShowAllProducts");
        }
    }
}
