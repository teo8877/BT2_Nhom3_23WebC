using BT2_Nhom3_23WebC.Models;
namespace BT2_Nhom3_23WebC.Models
{
    public class ProductService
    {
        private List<Product> _products = new List<Product>();
        public bool ProductsLoaded { get; private set; } = false;//dữ liệu sản phẩm chỉ được nạp một lần duy nhất trong vòng đời ứng dụng 

        public void SetProducts(List<Product> products)//nhận dữ liệu sản phẩm từ middleware
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
