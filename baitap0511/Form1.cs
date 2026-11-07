using System;
using System.Data;
using System.Windows.Forms;
using baitap0511.BUS;

namespace baitap0511
{
    public partial class Form1 : Form
    {
        // Khởi tạo sẵn biến BUS để không bị lỗi null
        private SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private DataTable dtGioHang;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachSanPham();
                KhoiTaoGioHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            if (sanPhamBUS != null)
            {
                dgvSanPham.DataSource = sanPhamBUS.LayDanhSachSanPham();
            }
        }

        private void KhoiTaoGioHang()
        {
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaSP", typeof(string));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal));

            dgvGioHang.DataSource = dtGioHang;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (sanPhamBUS != null)
            {
                dgvSanPham.DataSource = sanPhamBUS.TimKiemSanPham(tuKhoa);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                string maSP = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
                string tenSP = dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
                decimal gia = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["Gia"].Value);

                bool daCo = false;
                foreach (DataRow row in dtGioHang.Rows)
                {
                    if (row["MaSP"].ToString() == maSP)
                    {
                        row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + 1;
                        row["ThanhTien"] = Convert.ToInt32(row["SoLuong"]) * gia;
                        daCo = true;
                        break;
                    }
                }

                if (!daCo)
                {
                    dtGioHang.Rows.Add(maSP, tenSP, 1, gia, gia);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm bên bảng danh sách!", "Thông báo");
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null && dgvGioHang.CurrentRow.Index < dtGioHang.Rows.Count)
            {
                int index = dgvGioHang.CurrentRow.Index;
                DataRow row = dtGioHang.Rows[index];

                int soLuongMoi = Convert.ToInt32(row["SoLuong"]) + 1;
                decimal gia = Convert.ToDecimal(row["DonGia"]);

                row["SoLuong"] = soLuongMoi;
                row["ThanhTien"] = soLuongMoi * gia;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng để sửa!", "Thông báo");
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null && dgvGioHang.CurrentRow.Index < dtGioHang.Rows.Count)
            {
                dtGioHang.Rows.RemoveAt(dgvGioHang.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng để xóa!", "Thông báo");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }

            MessageBox.Show($"Thanh toán thành công!\nTổng tiền hóa đơn: {tongTien:N0} VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtGioHang.Rows.Clear();
        }

        // Xử lý sự kiện nút Tạo Mới (nhập từ TextBox)
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text.Trim();
            string ten = txtTenSP.Text.Trim();
            decimal gia = 0;

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã và Tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                MessageBox.Show("Giá tiền phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool thanhCong = sanPhamBUS.ThemSanPhamMoi(ma, ten, gia);
            if (thanhCong)
            {
                MessageBox.Show("Đã thêm sản phẩm thành công vào danh mục!", "Thông báo");
                LoadDanhSachSanPham();

                txtMaSP.Clear();
                txtTenSP.Clear();
                txtGia.Clear();
            }
            else
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại, vui lòng nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}