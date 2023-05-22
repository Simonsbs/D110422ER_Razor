using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Data;
using MyShop.Data.Models;

namespace MyShop.Pages.Products {
    public class AddProductModel : PageModel {
        private readonly IProductRepository _repo;
        private readonly IWebHostEnvironment _host;

        public AddProductModel(IProductRepository repo, IWebHostEnvironment host) {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
            _host = host ?? throw new ArgumentNullException(nameof(host));
        }

        [BindProperty]
        public Product NewProduct { get; set; }

        public void OnGet() {
        }

        public async Task<IActionResult> OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            if (NewProduct.Image != null) {
                NewProduct.ImagePath = NewProduct.Image.FileName;

                //if (NewProduct.Image.Length > 10000) {
                    
                //}

                var localPath = Path.Combine(
                    _host.ContentRootPath, 
                    "wwwroot\\images\\uploads", 
                    NewProduct.ImagePath);

                using (var fileStream = new FileStream(localPath, FileMode.Create)) {
                    await NewProduct.Image.CopyToAsync(fileStream);
                }
            }

            _repo.Add(NewProduct);

            return RedirectToPage("ShowAllProducts");
        }
    }
}
