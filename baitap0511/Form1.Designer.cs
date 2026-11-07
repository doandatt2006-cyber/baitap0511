namespace baitap0511
{
    partial class Form1
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

        private void InitializeComponent()
        {
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThemSP = new Button();
            btnSuaSP = new Button();
            btnXoaSP = new Button();
            dgvSanPham = new DataGridView();
            lblGioHang = new Label();
            dgvGioHang = new DataGridView();
            btnThanhToan = new Button();
            lblMaSP = new Label();
            txtMaSP = new TextBox();
            lblTenSP = new Label();
            txtTenSP = new TextBox();
            lblGia = new Label();
            txtGia = new TextBox();
            btnTaoMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 20);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(280, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 25);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(20, 60);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(70, 25);
            btnThemSP.TabIndex = 2;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // btnSuaSP
            // 
            btnSuaSP.Location = new Point(100, 60);
            btnSuaSP.Name = "btnSuaSP";
            btnSuaSP.Size = new Size(70, 25);
            btnSuaSP.TabIndex = 3;
            btnSuaSP.Text = "Sửa";
            btnSuaSP.UseVisualStyleBackColor = true;
            btnSuaSP.Click += btnSuaSP_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(180, 60);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(70, 25);
            btnXoaSP.TabIndex = 4;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(20, 160);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(450, 360);
            dgvSanPham.TabIndex = 12;
            // 
            // lblGioHang
            // 
            lblGioHang.AutoSize = true;
            lblGioHang.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblGioHang.Location = new Point(500, 60);
            lblGioHang.Name = "lblGioHang";
            lblGioHang.Size = new Size(268, 24);
            lblGioHang.TabIndex = 13;
            lblGioHang.Text = "GIỎ HÀNG && THANH TOÁN";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Location = new Point(500, 100);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(570, 350);
            dgvGioHang.TabIndex = 14;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.DodgerBlue;
            btnThanhToan.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(500, 470);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(450, 50);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "LẬP HÓA ĐƠN (Thanh toán)";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(20, 100);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(53, 20);
            lblMaSP.TabIndex = 5;
            lblMaSP.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(79, 100);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(60, 27);
            txtMaSP.TabIndex = 6;
            txtMaSP.TextChanged += txtMaSP_TextChanged;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(135, 100);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(55, 20);
            lblTenSP.TabIndex = 7;
            lblTenSP.Text = "Tên SP:";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(189, 96);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(120, 27);
            txtTenSP.TabIndex = 8;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(315, 100);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(34, 20);
            lblGia.TabIndex = 9;
            lblGia.Text = "Giá:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(355, 100);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(125, 27);
            txtGia.TabIndex = 10;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Location = new Point(20, 129);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(450, 25);
            btnTaoMoi.TabIndex = 11;
            btnTaoMoi.Text = "Tạo sản phẩm mới vào danh sách";
            btnTaoMoi.UseVisualStyleBackColor = true;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1121, 561);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThemSP);
            Controls.Add(btnSuaSP);
            Controls.Add(btnXoaSP);
            Controls.Add(lblMaSP);
            Controls.Add(txtMaSP);
            Controls.Add(lblTenSP);
            Controls.Add(txtTenSP);
            Controls.Add(lblGia);
            Controls.Add(txtGia);
            Controls.Add(btnTaoMoi);
            Controls.Add(dgvSanPham);
            Controls.Add(lblGioHang);
            Controls.Add(dgvGioHang);
            Controls.Add(btnThanhToan);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Bán hàng - Siêu thị Mini";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnThanhToan;
    }
}