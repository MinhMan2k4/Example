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
    public partial class Form08 : Form
    {
        public Form08()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = "Caculator";
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);

            int y = int.Parse(tbSoY.Text);

            int kq = x + y;

            tbKetQua.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);

            int y = int.Parse(tbSoY.Text);

            int kq = x * y;

            tbKetQua.Text = kq.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
