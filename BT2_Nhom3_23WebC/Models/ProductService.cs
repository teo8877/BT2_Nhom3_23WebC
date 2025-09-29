using BT2_Nhom3_23WebC.Models;
namespace BT2_Nhom3_23WebC.Models
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { MaSP = "SP01", TenSP = "Hoa Hồng", DonGia = 100, DonGiaKhuyenMai = 90, HinhAnh = "rose.jpg", MoTa = "Hoa hồng đỏ", LoaiSP = "Hoa Tươi" },
                new Product { MaSP = "SP02", TenSP = "Hoa Lan", DonGia = 120, DonGiaKhuyenMai = 110, HinhAnh = "orchid.jpg", MoTa = "Hoa lan trắng", LoaiSP = "Hoa Tươi" }
                // Thêm sản phẩm khác nếu muốn
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
