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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;

        private void QLSV_Load(object sender, EventArgs e)
        {
            var fn = new DangNhap();
            fn.ShowDialog();
            if (!fn.DangNhapThanhCong)
            {
                // Đóng form chính nếu đăng nhập thất bại
                this.Close();
                return;
            }
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                chamDiemToolStripMenuItem.Visible = false;
                dangKyToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    dangKyToolStripMenuItem.Visible = false;
                }
                else
                {
                    chamDiemToolStripMenuItem.Visible = false;
                }
            }

; Welcome f = new Welcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSV f = new DSSV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSMH f = new DSMH();
            AddForm(f);
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSGV f = new DSGV();
            AddForm(f);
        }


        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSLH f = new DSLH();
            AddForm(f);
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DsMHĐK(taikhoan);
            AddForm(f);
        }
    }
}
