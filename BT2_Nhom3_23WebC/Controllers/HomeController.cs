using System.Diagnostics;
using BT2_Nhom3_23WebC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT2_Nhom3_23WebC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { Name = "Ut eu feugiat", ImageUrl = "images/product/01.jpg", Alt = "floral set 1", Price = 240 },
            new Product { Name = "Donec Est Nisi", ImageUrl = "images/product/02.jpg", Alt = "flowers 2", Price = 160 },
            new Product { Name = "Tristique Vitae", ImageUrl = "images/product/03.jpg", Alt = "floral 3", Price = 140 },
            new Product { Name = "Hendrerit Eu", ImageUrl = "images/product/04.jpg", Alt = "flowers 4", Price = 320, NoMarginRight = true },
            new Product { Name = "Tincidunt Nisi", ImageUrl = "images/product/05.jpg", Alt = "floral set 5", Price = 150 },
            new Product { Name = "Curabitur et turpis", ImageUrl = "images/product/07.jpg", Alt = "flowers 7", Price = 110 },
            new Product { Name = "Mauris consectetur", ImageUrl = "images/product/06.jpg", Alt = "flower set 6", Price = 130 },
            new Product { Name = "Proin volutpat", ImageUrl = "images/product/08.jpg", Alt = "floral 8", Price = 170, NoMarginRight = true }
        };
            return View(products);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        } public IActionResult Contact()
        {
            return View();
        }public IActionResult FAQs()
        {
            return View();
        }public IActionResult ProductDetail()
        {
            return View();
        }public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
