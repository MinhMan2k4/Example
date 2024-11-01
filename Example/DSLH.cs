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
    public partial class DSLH : Form
    {
        public DSLH()
        {
            InitializeComponent();
            CustomizeComponents();
        }
        private string tukhoa = "";
        private void DSLH_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }

        private void CustomizeComponents()
        {
            // Đặt màu nền cho form
            this.BackColor = Color.FromArgb(230, 255, 240);

            // Cài đặt DataGridView
            dgvLopHoc.BorderStyle = BorderStyle.None;
            dgvLopHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 255, 240);
            dgvLopHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLopHoc.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvLopHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvLopHoc.BackgroundColor = Color.White;

            dgvLopHoc.EnableHeadersVisualStyles = false;
            dgvLopHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvLopHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tùy chỉnh font chữ cho DataGridView
            dgvLopHoc.Font = new Font("Arial", 10);
            dgvLopHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Tùy chỉnh các nút
            CustomizeButton(btnThem, "Thêm mới");
            CustomizeButton(btnTimKiem, "Tìm kiếm");
            CustomizeButton(btnSua, "Sửa");

            // Đặt placeholder cho TextBox tìm kiếm
            txtTimKiem.Font = new Font("Arial", 10);
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
        }

        private void CustomizeButton(Button button, string text)
        {
            button.Text = text;
            button.BackColor = Color.FromArgb(80, 160, 155);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Width = 100;
            button.Height = 35;
            button.Font = new Font("Arial", 10, FontStyle.Bold);
        }
        private void loadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);

            dgvLopHoc.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns["gv"].HeaderText = "Giáo viên";
            dgvLopHoc.Columns["tenmonhoc"].HeaderText = "Tên môn học";



        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSLH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new LopHoc(null).ShowDialog();
            loadDSLH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow != null)
            {
                var mlh = dgvLopHoc.CurrentRow.Cells["malophoc"].Value.ToString();
                new LopHoc(mlh).ShowDialog();
                loadDSLH();
            }
        }
    }
}
