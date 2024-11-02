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
    public partial class DSSV : Form
    {
        public DSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";

        private void DSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();

            // Đặt màu nền cho form
            this.BackColor = Color.FromArgb(230, 255, 240);

            // Cài đặt DataGridView
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(80, 160, 155);
            dgvSinhVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSinhVien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvSinhVien.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSinhVien.BackgroundColor = Color.White;

            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tùy chỉnh font chữ cho DataGridView
            dgvSinhVien.Font = new Font("Arial", 10);
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Tùy chỉnh các nút
            btnThemmoi.BackColor = Color.FromArgb(80, 160, 155);
            btnThemmoi.ForeColor = Color.White;
            btnThemmoi.FlatStyle = FlatStyle.Flat;
            btnThemmoi.FlatAppearance.BorderSize = 0;
            btnThemmoi.Width = 100;
            btnThemmoi.Height = 35;
            btnThemmoi.Font = new Font("Arial", 10, FontStyle.Bold);

            btnTimkiem.BackColor = Color.FromArgb(80, 160, 155);
            btnTimkiem.ForeColor = Color.White;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.Width = 100;
            btnTimkiem.Height = 35;
            btnTimkiem.Font = new Font("Arial", 10, FontStyle.Bold);

            btnSuaSV.BackColor = Color.FromArgb(80, 160, 155);
            btnSuaSV.ForeColor = Color.White;
            btnSuaSV.FlatStyle = FlatStyle.Flat;
            btnSuaSV.FlatAppearance.BorderSize = 0;
            btnSuaSV.Width = 100;
            btnSuaSV.Height = 35;
            btnSuaSV.Font = new Font("Arial", 10, FontStyle.Bold);

            btnXoaSV.BackColor = Color.FromArgb(255, 80, 80);
            btnXoaSV.ForeColor = Color.White;
            btnXoaSV.FlatStyle = FlatStyle.Flat;
            btnXoaSV.FlatAppearance.BorderSize = 0;
            btnXoaSV.Width = 100;
            btnXoaSV.Height = 35;
            btnXoaSV.Font = new Font("Arial", 10, FontStyle.Bold);

            // Đặt placeholder cho TextBox tìm kiếm
            txtTukhoa.Font = new Font("Arial", 10);
            txtTukhoa.PlaceholderText = "Nhập từ khóa...";
        }


        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);

            //đặt tên cột
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new SinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng thừa
            LoadDSSV(); // Gọi lại hàm LoadDSSV để tải lại dữ liệu theo từ khóa mới
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                var msv = dgvSinhVien.CurrentRow.Cells["masinhvien"].Value.ToString();
                new SinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                var msv = dgvSinhVien.CurrentRow.Cells["masinhvien"].Value.ToString();

                // Xác nhận xóa
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>
                    {
                        new CustomParameter() { key = "@masinhvien", value = msv }
                    };

                    // Xóa sinh viên từ database
                    var result = new Database().ExeCute("DeleteSinhVien", lstPara);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công.");
                        LoadDSSV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
            }
        }

    }
}
