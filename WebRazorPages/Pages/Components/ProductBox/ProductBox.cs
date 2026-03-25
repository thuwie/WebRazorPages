using Microsoft.AspNetCore.Mvc;
using WebRazorPages.Models;
using WebRazorPages.Services;

namespace WebRazorPages.Pages.Components.ProductBox
{
    public class ProductBox:ViewComponent
    {
        //List<Product> products = new List<Product>()
        //{
        //    new Product(){Name="Iphone 7 Plus", Description="Dien thoai cua Apple", Price=700},
        //    new Product(){Name="Samsung Galaxy", Description="Dien thoai cua SamSung", Price=550},
        //    new Product(){Name="Sony Xperis", Description="Dien thoai cua Sony", Price=300},
        //};
        private readonly ProductService _productService;
        public ProductBox(ProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke(string searchTerm = "")
        {
            // Gọi hàm Search đã viết trong Service
            var filteredProducts = _productService.Search(searchTerm);

            // Trình diễn dữ liệu ra View (Default.cshtml)
            return View(filteredProducts);
        }
    }
}
