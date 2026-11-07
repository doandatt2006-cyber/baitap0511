using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap0511.BUS;
using baitap0511.DTO;

namespace baitap0511
{
    public partial class frmNhanSu : Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private int selectedMaNV = -1;

        private SqlDataAdapter adapterChamCong;
        private DataTable dtChamCong;

        public frmNhanSu()
        {
            InitializeComponent();
        }

        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            LoadPhongBan();
            LoadDanhSach();
        }

        private void LoadPhongBan()
        {
            cboPhongBan.DataSource = nhanVienBUS.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";
        }

        private void LoadDanhSach(string tuKhoa = "")
        {
            dgvNhanVien.DataSource = nhanVienBUS.LayDanhSachNhanVien(tuKhoa);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                selectedMaNV = Convert.ToInt32(row.Cells["MaNV"].Value);
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboPhongBan.SelectedValue = Convert.ToInt32(row.Cells["MaPB"].Value);
                txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value?.ToString();
                txtHeSoLuong.Text = row.Cells["HeSoLuong"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    MaPB = Convert.ToInt32(cboPhongBan.SelectedValue),
                    LuongCoBan = Convert.ToDecimal(txtLuongCoBan.Text.Trim()),
                    HeSoLuong = float.Parse(txtHeSoLuong.Text.Trim())
                };

                if (nhanVienBUS.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    LoadDanhSach();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo");
                return;
            }

            try
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = selectedMaNV,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    MaPB = Convert.ToInt32(cboPhongBan.SelectedValue),
                    LuongCoBan = Convert.ToDecimal(txtLuongCoBan.Text.Trim()),
                    HeSoLuong = float.Parse(txtHeSoLuong.Text.Trim())
                };

                if (nhanVienBUS.SuaNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
                    LoadDanhSach();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhanVienBUS.XoaNhanVien(selectedMaNV))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadDanhSach();
                    ClearInput();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSach(txtTimKiem.Text.Trim());
        }

        private void ClearInput()
        {
            selectedMaNV = -1;
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtLuongCoBan.Clear();
            txtHeSoLuong.Text = "1.0";
        }

        private void btnTaiChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                string thangNam = txtThangNam.Text.Trim();
                dtChamCong = nhanVienBUS.LayBangChamCong(thangNam, out adapterChamCong);
                dgvChamCong.DataSource = dtChamCong;

                foreach (DataGridViewColumn col in dgvChamCong.Columns)
                {
                    if (col.Name != "SoNgayCong" && col.Name != "SoGioOT")
                    {
                        col.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chấm công: " + ex.Message, "Lỗi");
            }
        }

        private void btnLuuChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtChamCong != null && adapterChamCong != null)
                {
                    nhanVienBUS.LuuBangChamCong(adapterChamCong, dtChamCong);
                    MessageBox.Show("Đã lưu bảng chấm công thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu chấm công: " + ex.Message, "Lỗi");
            }
        }

        private void btnChotLuong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNam.Text.Trim();
            if (MessageBox.Show($"Bạn có chắc muốn chốt lương cho tháng {thangNam}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (nhanVienBUS.ChotLuongThang(thangNam))
                    {
                        MessageBox.Show($"Chốt lương tháng {thangNam} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Hiển thị trực tiếp bảng lương lên lưới
                        dgvChamCong.DataSource = nhanVienBUS.LayBangLuong(thangNam);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chốt lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}