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
        List<Product> products = null;
        public ProductBox(ProductService productService)
        {
            products = productService.GetProducts();
        }
        public IViewComponentResult Invoke()
        {
            return View<List<Product>>(products);
        }
    }
}
