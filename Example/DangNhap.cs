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
