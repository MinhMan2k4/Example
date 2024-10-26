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
    public partial class DangkyMonHoc : Form
    {
        public DangkyMonHoc(string masv)
        {
            InitializeComponent();
        }
        private string masv;

        private void DangkyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên học phần";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số TC";
            dgvDSLH.Columns["giaovien"].HeaderText = "Giáo Viên";

        }
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDKy", lstPara);
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index > 0)
            {
                MessageBox.Show("Tên môn học được chọn: " + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString());
            }    
        }
    }
}
