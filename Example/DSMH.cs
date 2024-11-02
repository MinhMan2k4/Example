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
    public partial class DSMH : Form
    {
        public DSMH()
        {
            InitializeComponent();
            CustomizeComponents();
        }

        private string tukhoa = "";
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new MonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void CustomizeComponents()
        {
            // Đặt màu nền cho form
            this.BackColor = Color.FromArgb(240, 250, 255);

            // Cài đặt DataGridView
            dgvDSMH.BorderStyle = BorderStyle.None;
            dgvDSMH.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 250);
            dgvDSMH.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDSMH.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dgvDSMH.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDSMH.BackgroundColor = Color.White;

            dgvDSMH.EnableHeadersVisualStyles = false;
            dgvDSMH.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDSMH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 116, 204);
            dgvDSMH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Tùy chỉnh font chữ cho DataGridView
            dgvDSMH.Font = new Font("Arial", 10);
            dgvDSMH.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Tùy chỉnh các nút
            CustomizeButton(btnThemmoi, "Thêm mới");
            CustomizeButton(btnTimkiem, "Tìm kiếm");
            CustomizeButton(btnSua, "Sửa");

            btnXoaMH.BackColor = Color.FromArgb(255, 80, 80);
            btnXoaMH.ForeColor = Color.White;
            btnXoaMH.FlatStyle = FlatStyle.Flat;
            btnXoaMH.FlatAppearance.BorderSize = 0;
            btnXoaMH.Width = 100;
            btnXoaMH.Height = 35;
            btnXoaMH.Font = new Font("Arial", 10, FontStyle.Bold);

            // Đặt placeholder cho TextBox tìm kiếm
            txtTukhoa.Font = new Font("Arial", 10);
            txtTukhoa.PlaceholderText = "Nhập từ khóa...";
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
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void DSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["mamonhoc"].HeaderText = "Mã MH";
            dgvDSMH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["sotinchi"].HeaderText = "Số tín chỉ";

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSMH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSMH.CurrentRow != null)
            {
                var mmh = dgvDSMH.CurrentRow.Cells["mamonhoc"].Value.ToString();
                new LopHoc(mmh).ShowDialog();
                LoadDSMH();
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (dgvDSMH.CurrentRow != null)
            {
                var msv = dgvDSMH.CurrentRow.Cells["mamonhoc"].Value.ToString();

                // Xác nhận xóa
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>
                    {
                        new CustomParameter() { key = "@mamonhoc", value = msv }
                    };

                    // Xóa sinh viên từ database
                    var result = new Database().ExeCute("DeleteMonHoc", lstPara);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa môn học thành công.");
                        LoadDSMH();
                    }
                    else
                    {
                        MessageBox.Show("Xóa môn học thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.");
            }
        }
    }
}
