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
                new Product { MaSP = "SP01", TenSP = "Ut eu feugiat", DonGia = 240, DonGiaKhuyenMai = 220, HinhAnh = "images/product/01.jpg", MoTa = "floral set 1", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP02", TenSP = "Donec Est Nisi", DonGia = 160, DonGiaKhuyenMai = 150, HinhAnh = "images/product/02.jpg", MoTa = "flowers 2", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP03", TenSP = "Tristique Vitae", DonGia = 140, DonGiaKhuyenMai = 130, HinhAnh = "images/product/03.jpg", MoTa = "floral 3", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP04", TenSP = "Hendrerit Eu", DonGia = 320, DonGiaKhuyenMai = 300, HinhAnh = "images/product/04.jpg", MoTa = "flowers 4", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP05", TenSP = "Tincidunt Nisi", DonGia = 150, DonGiaKhuyenMai = 140, HinhAnh = "images/product/05.jpg", MoTa = "floral set 5", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP06", TenSP = "Curabitur et turpis", DonGia = 110, DonGiaKhuyenMai = 100, HinhAnh = "images/product/07.jpg", MoTa = "flowers 7", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP07", TenSP = "Mauris consectetur", DonGia = 130, DonGiaKhuyenMai = 120, HinhAnh = "images/product/06.jpg", MoTa = "flower set 6", LoaiSP = "Hoa Tươi" },
    new Product { MaSP = "SP08", TenSP = "Proin volutpat", DonGia = 170, DonGiaKhuyenMai = 160, HinhAnh = "images/product/08.jpg", MoTa = "floral 8", LoaiSP = "Hoa Tươi" }

                // Thêm sản phẩm khác nếu muốn
            };
      
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
