using WebRazorPages.Models;

namespace WebRazorPages.Services
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>();
        public ProductService()
        {
            if (!products.Any())
            {
                LoadProducts();
            }
        }
        public void LoadProducts()
        {
            products = new List<Product>()
            {
                new Product(){Id = 1, Name="Iphone 7 Plus", Description="Dien thoai cua Apple", Price=700},
                new Product(){Id = 2, Name="Samsung Galaxy", Description="Dien thoai cua SamSung", Price=550},
                new Product(){Id = 3, Name="Sony Xperis", Description="Dien thoai cua Sony", Price=300},
            };
        }

        public List<Product> GetProducts() {return products;}

        // 2. Tìm kiếm theo Tên hoặc Mã (Sử dụng LINQ)
        public List<Product> Search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword)) return products;
            return products.Where(p =>
                p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.Id.ToString() == keyword
            ).ToList();
        }

        // 3. Tìm một sản phẩm cụ thể theo Id
        public Product GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

        // 4. Cập nhật sản phẩm
        public void Update(Product updatedProduct)
        {
            var index = products.FindIndex(p => p.Id == updatedProduct.Id);
            if (index != -1)
            {
                products[index] = updatedProduct;
            }
        }

        // 5. Xóa sản phẩm
        public void Delete(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        // 6. Thêm mới
        public void Add(Product product)
        {
            product.Id = products.Any() ? products.Max(p => p.Id) + 1 : 1;
            products.Add(product);
        }
    }
}
