using BT2_Nhom3_23WebC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT2_Nhom3_23WebC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }
    }
}
