using System.Text.Json;
using BT2_Nhom3_23WebC.Models;

namespace BT2_Nhom3_23WebC.Middleware
{
    public class ProductDbMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _dbPath;

        public ProductDbMiddleware(RequestDelegate next, string dbPath)
        {
            _next = next;
            _dbPath = dbPath;
        }

        public async Task InvokeAsync(HttpContext context, ProductService productService)
        {
            if (!productService.ProductsLoaded)
            {
                using var stream = new FileStream(_dbPath, FileMode.Open, FileAccess.Read);
                var db = await JsonSerializer.DeserializeAsync<ProductDb>(stream);
                if (db?.products != null)
                {
                    productService.SetProducts(db.products);
                }
            }
            await _next(context);
        }
    }

    public class ProductDb
    {
        public List<Product> products { get; set; }
    }
}
