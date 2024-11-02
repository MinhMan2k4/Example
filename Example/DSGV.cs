using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class DSGV : Form
    {
        public DSGV()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);

            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ tên giáo viên";
            dgvDSGV.Columns["gt"].HeaderText = "Giới tính";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa chỉ";


        }

        private void DSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();

            // Đặt màu nền cho form
            this.BackColor = Color.FromArgb(230, 255, 240);

            // Cài đặt DataGridView
            dgvDSGV.BorderStyle = BorderStyle.None;
            dgvDSGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(80, 160, 155);
            dgvDSGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDSGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvDSGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDSGV.BackgroundColor = Color.White;

            dgvDSGV.EnableHeadersVisualStyles = false;
            dgvDSGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDSGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvDSGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tùy chỉnh font chữ cho DataGridView
            dgvDSGV.Font = new Font("Arial", 10);
            dgvDSGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

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

            btnSua.BackColor = Color.FromArgb(80, 160, 155);
            btnSua.ForeColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.Width = 100;
            btnSua.Height = 35;
            btnSua.Font = new Font("Arial", 10, FontStyle.Bold);

            btnXoaGV.BackColor = Color.FromArgb(255, 80, 80);
            btnXoaGV.ForeColor = Color.White;
            btnXoaGV.FlatStyle = FlatStyle.Flat;
            btnXoaGV.FlatAppearance.BorderSize = 0;
            btnXoaGV.Width = 100;
            btnXoaGV.Height = 35;
            btnXoaGV.Font = new Font("Arial", 10, FontStyle.Bold);

            // Đặt placeholder cho TextBox tìm kiếm
            txtTukhoa.Font = new Font("Arial", 10);
            txtTukhoa.PlaceholderText = "Nhập từ khóa...";
        }


        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new GiaoVien(null).ShowDialog();
            loadDSGV();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSGV.CurrentRow != null)
            {
                var mgv = dgvDSGV.CurrentRow.Cells["magiaovien"].Value.ToString();
                new GiaoVien(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (dgvDSGV.CurrentRow != null)
            {
                var msv = dgvDSGV.CurrentRow.Cells["magiaovien"].Value.ToString();

                // Xác nhận xóa
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa giáo viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>
                    {
                        new CustomParameter() { key = "@magiaovien", value = msv }
                    };

                    // Xóa sinh viên từ database
                    var result = new Database().ExeCute("DeleteGiaoVien", lstPara);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa giáo viên thành công.");
                        loadDSGV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa giáo viên thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa.");
            }
        }
    }
}
