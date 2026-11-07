namespace baitap0511
{
    partial class frmNhanSu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabNhanSu = new TabPage();
            grpThongTin = new GroupBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblPhongBan = new Label();
            cboPhongBan = new ComboBox();
            lblLuongCB = new Label();
            txtLuongCoBan = new TextBox();
            lblHeSoLuong = new Label();
            txtHeSoLuong = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvNhanVien = new DataGridView();
            tabChamCong = new TabPage();
            lblThangNam = new Label();
            txtThangNam = new TextBox();
            btnTaiChamCong = new Button();
            dgvChamCong = new DataGridView();
            btnLuuChamCong = new Button();
            btnChotLuong = new Button();
            tabControl.SuspendLayout();
            tabNhanSu.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNhanSu);
            tabControl.Controls.Add(tabChamCong);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(984, 561);
            tabControl.TabIndex = 0;
            // 
            // tabNhanSu
            // 
            tabNhanSu.Controls.Add(grpThongTin);
            tabNhanSu.Controls.Add(btnThem);
            tabNhanSu.Controls.Add(btnSua);
            tabNhanSu.Controls.Add(btnXoa);
            tabNhanSu.Controls.Add(txtTimKiem);
            tabNhanSu.Controls.Add(btnTimKiem);
            tabNhanSu.Controls.Add(dgvNhanVien);
            tabNhanSu.Location = new Point(4, 29);
            tabNhanSu.Name = "tabNhanSu";
            tabNhanSu.Size = new Size(976, 528);
            tabNhanSu.TabIndex = 0;
            tabNhanSu.Text = "Quản lý Hồ sơ Nhân sự";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblCCCD);
            grpThongTin.Controls.Add(txtCCCD);
            grpThongTin.Controls.Add(lblPhongBan);
            grpThongTin.Controls.Add(cboPhongBan);
            grpThongTin.Controls.Add(lblLuongCB);
            grpThongTin.Controls.Add(txtLuongCoBan);
            grpThongTin.Controls.Add(lblHeSoLuong);
            grpThongTin.Controls.Add(txtHeSoLuong);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Location = new Point(12, 10);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(727, 150);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin nhân viên";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(15, 25);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(59, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(80, 22);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(220, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblCCCD
            // 
            lblCCCD.Location = new Point(15, 65);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(59, 23);
            lblCCCD.TabIndex = 2;
            lblCCCD.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(80, 62);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(220, 27);
            txtCCCD.TabIndex = 3;
            // 
            // lblPhongBan
            // 
            lblPhongBan.Location = new Point(15, 105);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(59, 23);
            lblPhongBan.TabIndex = 4;
            lblPhongBan.Text = "Phòng:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongBan.Location = new Point(80, 106);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(220, 28);
            cboPhongBan.TabIndex = 5;
            // 
            // lblLuongCB
            // 
            lblLuongCB.Location = new Point(369, 65);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(100, 23);
            lblLuongCB.TabIndex = 6;
            lblLuongCB.Text = "Lương CB:";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(485, 62);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(220, 27);
            txtLuongCoBan.TabIndex = 7;
            // 
            // lblHeSoLuong
            // 
            lblHeSoLuong.Location = new Point(369, 106);
            lblHeSoLuong.Name = "lblHeSoLuong";
            lblHeSoLuong.Size = new Size(68, 23);
            lblHeSoLuong.TabIndex = 8;
            lblHeSoLuong.Text = "Hệ số:";
            // 
            // txtHeSoLuong
            // 
            txtHeSoLuong.Location = new Point(485, 102);
            txtHeSoLuong.Name = "txtHeSoLuong";
            txtHeSoLuong.Size = new Size(220, 27);
            txtHeSoLuong.TabIndex = 9;
            txtHeSoLuong.Text = "1.0";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(369, 27);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(485, 22);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(220, 27);
            dtpNgaySinh.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(745, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 30);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(745, 62);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 30);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(745, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 30);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(12, 175);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 27);
            txtTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(336, 175);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 25);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.Location = new Point(12, 210);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(950, 310);
            dgvNhanVien.TabIndex = 6;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // tabChamCong
            // 
            tabChamCong.Controls.Add(lblThangNam);
            tabChamCong.Controls.Add(txtThangNam);
            tabChamCong.Controls.Add(btnTaiChamCong);
            tabChamCong.Controls.Add(dgvChamCong);
            tabChamCong.Controls.Add(btnLuuChamCong);
            tabChamCong.Controls.Add(btnChotLuong);
            tabChamCong.Location = new Point(4, 29);
            tabChamCong.Name = "tabChamCong";
            tabChamCong.Size = new Size(976, 528);
            tabChamCong.TabIndex = 1;
            tabChamCong.Text = "Chấm công & Tính lương";
            // 
            // lblThangNam
            // 
            lblThangNam.AutoSize = true;
            lblThangNam.Location = new Point(15, 20);
            lblThangNam.Name = "lblThangNam";
            lblThangNam.Size = new Size(165, 20);
            lblThangNam.TabIndex = 0;
            lblThangNam.Text = "Tháng/Năm (MM/yyyy):";
            // 
            // txtThangNam
            // 
            txtThangNam.Location = new Point(210, 18);
            txtThangNam.Name = "txtThangNam";
            txtThangNam.Size = new Size(120, 27);
            txtThangNam.TabIndex = 1;
            txtThangNam.Text = "11/2026";
            // 
            // btnTaiChamCong
            // 
            btnTaiChamCong.Location = new Point(401, 15);
            btnTaiChamCong.Name = "btnTaiChamCong";
            btnTaiChamCong.Size = new Size(130, 25);
            btnTaiChamCong.TabIndex = 2;
            btnTaiChamCong.Text = "Xem bảng chấm công";
            btnTaiChamCong.Click += btnTaiChamCong_Click;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ColumnHeadersHeight = 29;
            dgvChamCong.Location = new Point(15, 55);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(945, 410);
            dgvChamCong.TabIndex = 3;
            // 
            // btnLuuChamCong
            // 
            btnLuuChamCong.Location = new Point(15, 475);
            btnLuuChamCong.Name = "btnLuuChamCong";
            btnLuuChamCong.Size = new Size(180, 35);
            btnLuuChamCong.TabIndex = 4;
            btnLuuChamCong.Text = "Lưu chấm công (Update)";
            btnLuuChamCong.Click += btnLuuChamCong_Click;
            // 
            // btnChotLuong
            // 
            btnChotLuong.Location = new Point(210, 475);
            btnChotLuong.Name = "btnChotLuong";
            btnChotLuong.Size = new Size(180, 35);
            btnChotLuong.TabIndex = 5;
            btnChotLuong.Text = "Chốt lương tháng (Transaction)";
            btnChotLuong.Click += btnChotLuong_Click;
            // 
            // frmNhanSu
            // 
            ClientSize = new Size(984, 561);
            Controls.Add(tabControl);
            Name = "frmNhanSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nhân sự & Tính lương - HRM";
            Load += frmNhanSu_Load;
            tabControl.ResumeLayout(false);
            tabNhanSu.ResumeLayout(false);
            tabNhanSu.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tabChamCong.ResumeLayout(false);
            tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNhanSu;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblHoTen, lblCCCD, lblPhongBan, lblNgaySinh, lblLuongCB, lblHeSoLuong;
        private System.Windows.Forms.TextBox txtHoTen, txtCCCD, txtLuongCoBan, txtHeSoLuong, txtTimKiem;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnTimKiem;

        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.TextBox txtThangNam;
        private System.Windows.Forms.Button btnTaiChamCong, btnLuuChamCong, btnChotLuong;
        private System.Windows.Forms.DataGridView dgvChamCong;
    }
}