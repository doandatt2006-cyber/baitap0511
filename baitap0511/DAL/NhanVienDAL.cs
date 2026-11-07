using System;
using System.Data;
using System.Data.SqlClient;
using baitap0511.DTO;

namespace baitap0511.DAL
{
    public class NhanVienDAL
    {
        private string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=HRMDB;Integrated Security=True";

        public DataTable GetNhanVien(string tuKhoa = "")
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, 
                                        nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                                 FROM NhanVien nv 
                                 INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                                 WHERE (@TuKhoa = '' OR nv.HoTen LIKE '%' + @TuKhoa + '%' 
                                        OR pb.TenPB LIKE '%' + @TuKhoa + '%' 
                                        OR nv.CCCD LIKE '%' + @TuKhoa + '%')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetPhongBan()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                string query = "SELECT MaPB, TenPB FROM PhongBan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }

        public bool ThemNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                string query = @"INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong)
                                 VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                    cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                    cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                    cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SuaNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                string query = @"UPDATE NhanVien 
                                 SET HoTen = @HoTen, NgaySinh = @NgaySinh, CCCD = @CCCD, 
                                     MaPB = @MaPB, LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong
                                 WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                    cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                    cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                    cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool XoaNhanVien(int maNV)
        {
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetBangChamCong(string thangNam, out SqlDataAdapter adapter)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();

            string initQuery = @"INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT)
                                 SELECT MaNV, @ThangNam, 0, 0 
                                 FROM NhanVien nv 
                                 WHERE NOT EXISTS (
                                     SELECT 1 FROM BangChamCong bcc 
                                     WHERE bcc.MaNV = nv.MaNV AND bcc.ThangNam = @ThangNam
                                 )";
            using (SqlCommand cmdInit = new SqlCommand(initQuery, conn))
            {
                cmdInit.Parameters.AddWithValue("@ThangNam", thangNam);
                cmdInit.ExecuteNonQuery();
            }

            string selectQuery = @"SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT 
                                   FROM BangChamCong 
                                   WHERE ThangNam = @ThangNam";

            adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangNam);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();

            adapter.Fill(dt);
            return dt;
        }

        public void LuuBangChamCong(SqlDataAdapter adapter, DataTable dt)
        {
            if (adapter != null && dt != null)
            {
                adapter.Update(dt);
            }
        }

        public bool ChotLuongThang(string thangNam)
        {
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string deleteOld = "DELETE FROM BangLuong WHERE ThangNam = @ThangNam";
                    using (SqlCommand cmdDelete = new SqlCommand(deleteOld, conn, transaction))
                    {
                        cmdDelete.Parameters.AddWithValue("@ThangNam", thangNam);
                        cmdDelete.ExecuteNonQuery();
                    }

                    string insertSalary = @"
                        INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh)
                        SELECT nv.MaNV, bcc.ThangNam,
                               ROUND(((nv.LuongCoBan * nv.HeSoLuong / 22.0) * bcc.SoNgayCong) + (bcc.SoGioOT * 50000.0), 0)
                        FROM BangChamCong bcc
                        INNER JOIN NhanVien nv ON bcc.MaNV = nv.MaNV
                        WHERE bcc.ThangNam = @ThangNam";

                    using (SqlCommand cmdInsert = new SqlCommand(insertSalary, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@ThangNam", thangNam);
                        cmdInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DataTable GetBangLuong(string thangNam)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                string query = @"SELECT bl.MaLuong, bl.MaNV, nv.HoTen, pb.TenPB, 
                                        bl.ThangNam, bcc.SoNgayCong, bcc.SoGioOT, bl.ThucLinh
                                 FROM BangLuong bl
                                 INNER JOIN NhanVien nv ON bl.MaNV = nv.MaNV
                                 INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                                 LEFT JOIN BangChamCong bcc ON bl.MaNV = bcc.MaNV AND bl.ThangNam = bcc.ThangNam
                                 WHERE bl.ThangNam = @ThangNam";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) da.Fill(dt);
                }
            }
            return dt;
        }
    }
}