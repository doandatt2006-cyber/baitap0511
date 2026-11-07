using System;
using System.Data;
using baitap0511.DAL;

namespace baitap0511.BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL sanPhamDAL;

        public SanPhamBUS()
        {
            sanPhamDAL = new SanPhamDAL();
        }

        public DataTable LayDanhSachSanPham()
        {
            return sanPhamDAL.GetDanhSachSanPham();
        }

        public DataTable TimKiemSanPham(string tuKhoa)
        {
            return sanPhamDAL.TimKiemSanPham(tuKhoa);
        }

        // Hàm gọi xuống DAL để thêm sản phẩm
        public bool ThemSanPhamMoi(string ma, string ten, decimal gia)
        {
            return sanPhamDAL.ThemSanPham(ma, ten, gia);
        }
    }
}