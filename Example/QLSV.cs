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
            CustomizeComponents();
        }
        private string taikhoan;
        private string loaitk;

        private void CustomizeComponents()
        {
            // Đặt màu nền cho form chính
            this.BackColor = Color.FromArgb(240, 250, 255);

            // Tùy chỉnh menu strip
            menuStrip1.BackColor = Color.FromArgb(64, 116, 204);
            menuStrip1.ForeColor = Color.White;

            // Tùy chỉnh các item trong menu strip
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.FromArgb(64, 116, 204);
                item.ForeColor = Color.White;
            }

            // Tùy chỉnh panel chứa nội dung
            pnlContent.BackColor = Color.White;
            pnlContent.BorderStyle = BorderStyle.FixedSingle;

            // Tùy chỉnh tiêu đề form
            this.Text = "Quản Lý Sinh Viên";
            this.Font = new Font("Arial", 12);
        }

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
                quanLyLopToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    chucNangToolStripMenuItem.Visible = false;
                }
                else
                {
                    quanLyLopToolStripMenuItem.Visible = false;
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

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new KetQuaHocTap(taikhoan);
            AddForm(f);

        }

        private void quanLyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QuanLyLop(taikhoan);
            AddForm(f);
        }
    }
}
