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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop(string mgv)
        {
            InitializeComponent();
            this.mgv = mgv;
        }
        private string mgv;
        private void LoadDSLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvQLLop.DataSource = new Database().SelectData("tracuulop", lstPara);
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            dgvQLLop.Columns["malophoc"].HeaderText = "Mã lớp học ";
            dgvQLLop.Columns["mamonhoc"].HeaderText = "Mã môn học ";
            dgvQLLop.Columns["tenmonhoc"].HeaderText = "Tên môn học ";
            dgvQLLop.Columns["sotinchi"].HeaderText = "Số tín chỉ ";
            dgvQLLop.Columns["siso"].HeaderText = "Sĩ số lớp ";


        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }
    }
}
