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
    public partial class DsMHĐK : Form
    {
        public DsMHĐK(string masv)
        {
            this.masv = masv;
            InitializeComponent();
            this.masv = masv;
        }
        private string masv;
        private void DsMHĐK_Load(object sender, EventArgs e)
        {
            LoadMonDKy();
        }
        private void LoadMonDKy()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHHDky.DataSource = new Database().SelectData("monDaDKy", lst);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new DangkyMonHoc(null).ShowDialog();
            LoadMonDKy();
        }
    }
}
