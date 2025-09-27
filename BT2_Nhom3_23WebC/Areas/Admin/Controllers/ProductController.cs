using Microsoft.AspNetCore.Mvc;

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
    }
}
