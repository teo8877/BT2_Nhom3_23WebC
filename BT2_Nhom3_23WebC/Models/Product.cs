namespace BT2_Nhom3_23WebC.Models
{
    public class Product
    {
        //public string MaSP { get; set; }
        //public string TenSP { get; set; }
        //public decimal DonGia { get; set; }
        //public decimal DonGiaKhuyenMai { get; set; }
        //public string HinhAnh { get; set; }
        //public string MoTa { get; set; }
        //public string LoaiSP { get; set; }

        // Mã sản phẩm - kiểu string vì thường chứa cả chữ và số (VD: SP001)
        public string MaSP { get; set; } = string.Empty;

        // Tên sản phẩm
        public string TenSP { get; set; } = string.Empty;

        // Đơn giá gốc - dùng decimal cho số tiền
        public decimal DonGia { get; set; }

        // Giá sau khuyến mãi - cũng dùng decimal
        public decimal DonGiaKhuyenMai { get; set; }

        // Đường dẫn ảnh sản phẩm
        public string HinhAnh { get; set; } = string.Empty;

        // Mô tả sản phẩm
        public string MoTa { get; set; } = string.Empty;

        // Loại sản phẩm
        public string LoaiSP { get; set; } = string.Empty;
    }
}
