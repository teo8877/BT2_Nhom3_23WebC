using BT2_Nhom3_23WebC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT2_Nhom3_23WebC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<ProductModel>
            {
            new ProductModel { Name = "Ut eu feugiat", ImageUrl = "/images/product/01.jpg", Alt = "floral set 1", Price = 240 },
            new ProductModel { Name = "Donec Est Nisi", ImageUrl = "/images/product/02.jpg", Alt = "flowers 2", Price = 160 },

            
            new ProductModel { Name = "Tristique Vitae", ImageUrl = "/images/product/03.jpg", Alt = "flowers 3", Price = 180 },
             new ProductModel {Name = "Hendrerit Eu", ImageUrl="/images/product/04.jpg", Alt = "flowers 3",Price= 320 },


            new ProductModel { Name = "Hendrerit Eu", ImageUrl = "/images/product/04.jpg", Alt = "flowers 4", Price = 320, NoMarginRight = true },
       
            };
            return View(products);
            
        }
    }
}
