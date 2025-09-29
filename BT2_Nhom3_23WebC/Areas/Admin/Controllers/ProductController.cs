using Microsoft.AspNetCore.Mvc;
using BT2_Nhom3_23WebC.Models;
using System.Text.Json;

namespace BT2_Nhom3_23WebC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Admin Product Page";
            return View();
        }

        [Area("Admin")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult Add(Product product)
        {
            // Đường dẫn tới db.json
            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "db.json");
            ProductDb db;
            // Đọc dữ liệu cũ
            using (var stream = new FileStream(dbPath, FileMode.Open, FileAccess.Read))
            {
                db = JsonSerializer.Deserialize<ProductDb>(stream) ?? new ProductDb { products = new List<Product>() };
            }
            // Thêm sản phẩm mới
            db.products.Add(product);
            // Ghi lại vào file
            using (var stream = new FileStream(dbPath, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(stream, db, new JsonSerializerOptions { WriteIndented = true });
            }
            // Chuyển về trang danh sách
            return RedirectToAction("Index");
        }
    }

    public class ProductDb
    {
        public List<Product> products { get; set; } = new List<Product>();
    }
}
