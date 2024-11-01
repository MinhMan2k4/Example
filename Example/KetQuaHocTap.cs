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
    public partial class KetQuaHocTap : Form
    {
        public KetQuaHocTap(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        private string msv;

        private void KetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học ";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên học phần ";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần học ";
            dgvKQHT.Columns["giaovien"].HeaderText = "Giáo viên ";
            dgvKQHT.Columns["diemlan1"].HeaderText = "Điểm lần 1 ";
            dgvKQHT.Columns["diemlan2"].HeaderText = "Điểm lần 2 ";

        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", lstPara);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadKQHT();
        }
    }

}
