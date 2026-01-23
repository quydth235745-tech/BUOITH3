using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHang.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Lấy danh sách hãng sản xuất từ CSDL
            var listHang = context.HangSanXuat.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listHang;

            // Đổ dữ liệu vào DataGridView
            dataGridView.DataSource = bindingSource;

            // Tùy chỉnh cột để giống hình mẫu (ID nhỏ, Tên hãng rộng)
            if (dataGridView.Columns["ID"] != null)
            {
                dataGridView.Columns["ID"].Width = 60;
                dataGridView.Columns["ID"].HeaderText = "ID";
            }
            if (dataGridView.Columns["TenHang"] != null)
            {
                dataGridView.Columns["TenHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["TenHang"].HeaderText = "Tên hãng sản xuất";
            }

            // Binding dữ liệu từ bảng lên TextBox
            txtTenHang.DataBindings.Clear();
            txtTenHang.DataBindings.Add("Text", bindingSource, "TenHang", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHang.Clear();
            txtTenHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);
            // Lấy ID của dòng đang chọn
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hãng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                var hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                    context.SaveChanges();
                    frmHangSanXuat_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (xuLyThem)
            {
                // Thêm mới
                HangSanXuat hsx = new HangSanXuat();
                hsx.TenHangSanXuat = txtTenHang.Text;
                context.HangSanXuat.Add(hsx);
            }
            else
            {
                // Sửa dữ liệu
                var hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    hsx.TenHangSanXuat = txtTenHang.Text;
                    context.HangSanXuat.Update(hsx);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
            frmHangSanXuat_Load(sender, e); // Load lại bảng
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
