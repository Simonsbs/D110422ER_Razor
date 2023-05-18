using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Data;
using MyShop.Data.Models;

namespace MyShop.Pages.Products {
    public class EditProductModel : PageModel {
        private readonly IProductRepository _repo;
        private readonly IWebHostEnvironment _host;

        public EditProductModel(IProductRepository repo, IWebHostEnvironment host) {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
            _host = host ?? throw new ArgumentNullException(nameof(host));
        }

        [BindProperty]
        public Product EditProduct {
            get; set;
        }

        [FromRoute]
        public int Id {
            get; set;
        }

        public void OnGet() {
            EditProduct = _repo.GetById(Id);
        }

        public IActionResult OnPostDelete() {
            _repo.Delete(Id);

            return RedirectToPage("ShowAllProducts");
        }
        
        public async Task<IActionResult> OnPostEdit() {
            if (!ModelState.IsValid) {
                return Page();
            }

            if (EditProduct.Image != null) {
                EditProduct.ImagePath = EditProduct.Image.FileName;

                //if (NewProduct.Image.Length > 10000) {

                //}

                var localPath = Path.Combine(
                    _host.ContentRootPath,
                    "wwwroot\\images\\uploads",
                    EditProduct.ImagePath);

                using (var fileStream = new FileStream(localPath, FileMode.Create)) {
                    await EditProduct.Image.CopyToAsync(fileStream);
                }
            }

            EditProduct.ID = Id;
            _repo.Update(EditProduct);

            return RedirectToPage("ShowAllProducts");
        }
    }
}
