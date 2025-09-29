using BT2_Nhom3_23WebC.Models;
namespace BT2_Nhom3_23WebC.Models
{
    public class ProductService
    {
        private List<Product> _products = new List<Product>();
        public bool ProductsLoaded { get; private set; } = false;

        public void SetProducts(List<Product> products)
        {
            _products = products;
            ProductsLoaded = true;
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
