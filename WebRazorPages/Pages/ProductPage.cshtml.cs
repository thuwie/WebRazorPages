using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorPages.Models;
using WebRazorPages.Services;

namespace WebRazorPages.Pages
{
    public class ProductPageModel : PageModel
    {
        public List<Product> products { get; set; }
        public Product product { get; set; }
        ProductService _productService;
        public ProductPageModel(ProductService productService)
        {
            products = productService.GetProducts();
            _productService = productService;
        }
        public void OnGet([FromQuery]int? id)
        {
            products = _productService.GetProducts();
            if (id != null)
            {
                ViewData["Title"] = $"Thong tin san pham (ID = {id.Value})";
                product = _productService.GetProductById(id.Value);
            }
            else
            {
                ViewData["Title"] = $"Danh sach san pham";
            }
        }
        public IActionResult OnGetLastProduct()
        {
            ViewData["Title"] = $"San pham cuoi";
            product = _productService.GetProducts().LastOrDefault();
            if (product!=null)
            {
                return Page();
            }
            return NotFound();
        }
        public IActionResult OnGetRemoveAll()
        {
            products.Clear();
            return RedirectToPage("ProductPage");
        }
        public IActionResult OnGetLoadAll()
        {
            _productService.LoadProducts();
            return RedirectToPage("ProductPage");
        }
    }
}
