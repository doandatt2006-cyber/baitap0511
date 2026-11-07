using System.Data;
using System.Data.SqlClient;
using baitap0511.DAL;
using baitap0511.DTO;

namespace baitap0511.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public DataTable LayDanhSachNhanVien(string tuKhoa = "")
        {
            return nhanVienDAL.GetNhanVien(tuKhoa);
        }

        public DataTable LayDanhSachPhongBan()
        {
            return nhanVienDAL.GetPhongBan();
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            return nhanVienDAL.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(NhanVienDTO nv)
        {
            return nhanVienDAL.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(int maNV)
        {
            return nhanVienDAL.XoaNhanVien(maNV);
        }

        public DataTable LayBangChamCong(string thangNam, out SqlDataAdapter adapter)
        {
            return nhanVienDAL.GetBangChamCong(thangNam, out adapter);
        }

        public void LuuBangChamCong(SqlDataAdapter adapter, DataTable dt)
        {
            nhanVienDAL.LuuBangChamCong(adapter, dt);
        }

        public bool ChotLuongThang(string thangNam)
        {
            return nhanVienDAL.ChotLuongThang(thangNam);
        }

        public DataTable LayBangLuong(string thangNam)
        {
            return nhanVienDAL.GetBangLuong(thangNam);
        }
    }
}