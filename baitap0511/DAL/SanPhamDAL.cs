using System;
using System.Data;

namespace baitap0511.DAL
{
    public class SanPhamDAL
    {
        // Dùng biến static để lưu dữ liệu tạm trên bộ nhớ, tránh bị reset khi tải lại bảng
        private static DataTable dtSanPham;

        public SanPhamDAL()
        {
            if (dtSanPham == null)
            {
                dtSanPham = new DataTable();
                dtSanPham.Columns.Add("MaSP", typeof(string));
                dtSanPham.Columns.Add("TenSP", typeof(string));
                dtSanPham.Columns.Add("Gia", typeof(decimal));

                dtSanPham.Rows.Add("SP01", "Sữa tươi Vinamilk", 32000);
                dtSanPham.Rows.Add("SP02", "Bánh mì Sandwich", 25000);
                dtSanPham.Rows.Add("SP03", "Nước Aquafina", 10000);
            }
        }

        public DataTable GetDanhSachSanPham()
        {
            return dtSanPham;
        }

        public DataTable TimKiemSanPham(string tuKhoa)
        {
            if (string.IsNullOrEmpty(tuKhoa))
                return dtSanPham;

            DataTable dtKetQua = dtSanPham.Clone();
            foreach (DataRow row in dtSanPham.Rows)
            {
                if (row["TenSP"].ToString().ToLower().Contains(tuKhoa.ToLower()) ||
                    row["MaSP"].ToString().ToLower().Contains(tuKhoa.ToLower()))
                {
                    dtKetQua.ImportRow(row);
                }
            }
            return dtKetQua;
        }

        // Hàm xử lý logic Thêm sản phẩm mới vào danh sách
        public bool ThemSanPham(string ma, string ten, decimal gia)
        {
            // Kiểm tra xem mã SP đã tồn tại chưa
            foreach (DataRow row in dtSanPham.Rows)
            {
                if (row["MaSP"].ToString().ToUpper() == ma.ToUpper())
                    return false; // Bị trùng mã
            }

            dtSanPham.Rows.Add(ma, ten, gia);
            return true;
        }
    }
}