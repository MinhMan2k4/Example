using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Example
{
    public partial class FormMain : Form
    {
        // Khai báo danh sách học sinh
        List<HocSinh> dsHocSinh = new List<HocSinh>();

        public FormMain()
        {
            InitializeComponent();

            // Đảm bảo DataGridView tự động tạo các cột dựa trên thuộc tính của đối tượng
            dgvHocSinh.AutoGenerateColumns = true;

            // Liên kết sự kiện cho các nút
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);

            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
        }

        // Sự kiện khi nhấn vào hàng trong DataGridView
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được chọn không phải là hàng tiêu đề
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];

                // Đưa dữ liệu lên các TextBox
                txtMaHS.Text = row.Cells["MaHS"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSoDT.Text = row.Cells["SoDT"].Value.ToString();
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression để kiểm tra định dạng email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void ClearTextBoxes()
        {
            txtEmail.Text = "";
            txtMaHS.Text = "";
            txtSoDT.Text = "";
            txtHoTen.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //if (!IsValidEmail(txtEmail.Text))
            //{
            //    MessageBox.Show("Email không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;  
            //}
            HocSinh hs = new HocSinh
            {
                MaHS = txtMaHS.Text,
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
                SoDT = txtSoDT.Text
            };
            dsHocSinh.Add(hs);
            HienThiDanhSach();
            ClearTextBoxes();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //if (!IsValidEmail(txtEmail.Text))
            //{
            //    MessageBox.Show("Email không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return; 
            //}
            bool found = false;
            foreach (HocSinh hs in dsHocSinh)
            {
                if (hs.MaHS == txtMaHS.Text)
                {
                    hs.HoTen = txtHoTen.Text;
                    hs.Email = txtEmail.Text;
                    hs.SoDT = txtSoDT.Text;
                    found = true;  
                    break;
                }
            }

            if (found)
            {
                HienThiDanhSach(); 
                ClearTextBoxes();    
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh với mã này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {  
                dsHocSinh.RemoveAll(hs => hs.MaHS == txtMaHS.Text);
            HienThiDanhSach();
            ClearTextBoxes();
            }
        }

        private void HienThiDanhSach()
        {
            dgvHocSinh.DataSource = null;
            dgvHocSinh.DataSource = dsHocSinh;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }

    public class HocSinh
    {
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
    }
}
