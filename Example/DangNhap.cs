using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk;
        private void DangNhap_Load(object sender, EventArgs e)
        {
            // Đặt màu nền của form
            this.BackColor = Color.FromArgb(240, 248, 255);

            // Căn chỉnh và đặt font cho tiêu đề
            Label lblTitle = new Label
            {
                Text = "Đăng Nhập",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 120, 215),
                AutoSize = true,
                Location = new Point((this.Width / 2) - 50, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblTitle);

            // Đặt font cho các textbox và button
            txtTenDangNhap.Font = new Font("Arial", 12);
            txtMatKhau.Font = new Font("Arial", 12);
            cbbLoaiTaiKhoan.Font = new Font("Arial", 12);
            btnDangNhap.Font = new Font("Arial", 12, FontStyle.Bold);
            btnThoat.Font = new Font("Arial", 12, FontStyle.Bold);

            // Đặt màu nền và bo tròn cho nút đăng nhập
            btnDangNhap.BackColor = Color.FromArgb(0, 120, 215);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.Width = 100;
            btnDangNhap.Height = 35;
            btnDangNhap.Location = new Point((this.Width / 2) - 110, 200);

            // Đặt màu nền và bo tròn cho nút thoát
            btnThoat.BackColor = Color.Gray;
            btnThoat.ForeColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Width = 100;
            btnThoat.Height = 35;
            btnThoat.Location = new Point((this.Width / 2) + 10, 200);

            // Đặt màu viền cho textbox
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            cbbLoaiTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public bool DangNhapThanhCong { get; private set; } = false;


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc
            if (cbbLoaiTaiKhoan.SelectedIndex  < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            } 
            if(string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Tài khoản không được bỏ trống");
                txtTenDangNhap.Select();
                return;
            }    
            if(string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhạp mật khẩu", "Mật khẩu không được bỏ trống");
            }
            #endregion
            tendangnhap = txtTenDangNhap.Text;
             loaitk = "";
            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";

                    break;
                case "Sinh viên":
                    loaitk = "sv";

                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                 new CustomParameter()
                {
                    key = "@taikhoan",
                    value =txtTenDangNhap.Text
                }, 
                new CustomParameter()
                {
                    key = "@matkhau",
                    value =txtMatKhau.Text
                },

            };
            var rs = new Database().SelectData("dangnhap", lst);
            if(rs.Rows.Count > 0) 
            {
                MessageBox.Show("Đăng nhập thành công");
                DangNhapThanhCong = true;  // Đánh dấu đăng nhập thành công
                this.Close();  // Đóng form đăng nhập
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu","Tài khoản hoặc mật khẩu không hợp lệ");
            }


        }
    }
}
