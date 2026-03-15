using WebRazorPages.Models;

namespace WebRazorPages.Services
{
    public class ProductService
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Name="Iphone 7 Plus", Description="Dien thoai cua Apple", Price=700},
            new Product(){Name="Samsung Galaxy", Description="Dien thoai cua SamSung", Price=550},
            new Product(){Name="Sony Xperis", Description="Dien thoai cua Sony", Price=300},
        };
        public List<Product> GetProducts() {return products;}
    }
}
