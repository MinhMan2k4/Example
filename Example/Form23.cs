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
    public partial class Form23 : Form
    {
        PictureBox pb = new PictureBox();

        int x = 0;

        int y = 0;
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Bộ lọc tệp hình ảnh

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(100, 100);
                pb.Location = new Point(x, y);
                this.Controls.Add(pb);

                // Gán tệp hình ảnh được chọn vào PictureBox
                pb.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;

            pb.Location = new Point(x, y);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            x += 50;

            pb.Location = new Point(x, y);
        }
    }
}
