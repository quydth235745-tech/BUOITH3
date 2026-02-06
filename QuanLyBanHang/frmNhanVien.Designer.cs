namespace QuanLyBanHang
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HovaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            txtDiaChi = new TextBox();
            cboQuyenHan = new ComboBox();
            label6 = new Label();
            txtTenDangNhap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label2 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(2, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1183, 422);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HovaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1177, 396);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 37.883194F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HovaTen
            // 
            HovaTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HovaTen.DataPropertyName = "HovaTen";
            HovaTen.FillWeight = 89.83957F;
            HovaTen.HeaderText = "Họ và Tên";
            HovaTen.MinimumWidth = 6;
            HovaTen.Name = "HovaTen";
            HovaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 118.069305F;
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 118.069305F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.FillWeight = 118.069305F;
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.FillWeight = 118.069305F;
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 245);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 12F);
            txtMatKhau.Location = new Point(569, 103);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(243, 34);
            txtMatKhau.TabIndex = 22;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 12F);
            txtDiaChi.Location = new Point(142, 158);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(243, 34);
            txtDiaChi.TabIndex = 21;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(569, 168);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(243, 28);
            cboQuyenHan.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(405, 170);
            label6.Name = "label6";
            label6.Size = new Size(126, 22);
            label6.TabIndex = 19;
            label6.Text = "Quyền hạn (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 12F);
            txtTenDangNhap.Location = new Point(569, 43);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(243, 34);
            txtTenDangNhap.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(405, 52);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 17;
            label5.Text = "Tên đăng nhập (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(405, 106);
            label4.Name = "label4";
            label4.Size = new Size(116, 22);
            label4.TabIndex = 15;
            label4.Text = "Mật khẩu (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(11, 167);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 13;
            label3.Text = "Địa chỉ :";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Times New Roman", 12F);
            txtDienThoai.Location = new Point(142, 103);
            txtDienThoai.Multiline = true;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(243, 34);
            txtDienThoai.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(11, 106);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 11;
            label2.Text = "Điện thoại :";
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Times New Roman", 12F);
            btnXuat.Location = new Point(1072, 172);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(93, 32);
            btnXuat.TabIndex = 10;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 12F);
            btnNhap.Location = new Point(1072, 107);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(93, 32);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F);
            btnTimKiem.Location = new Point(1072, 41);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 32);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F);
            btnThoat.Location = new Point(953, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(93, 32);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 12F);
            btnHuyBo.Location = new Point(953, 107);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(93, 32);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 12F);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(953, 41);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(93, 32);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(837, 171);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 32);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(837, 106);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 32);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.Location = new Point(837, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 32);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Times New Roman", 12F);
            txtHoVaTen.Location = new Point(142, 43);
            txtHoVaTen.Multiline = true;
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(243, 34);
            txtHoVaTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(127, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên (*):";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 668);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label label1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private TextBox textBox5;
        private Label label6;
        private TextBox txtTenDangNhap;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label2;
        private ComboBox cboQuyenHan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HovaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtDiaChi;
    }
}