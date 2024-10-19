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
    public partial class Form26 : Form
    {
        PictureBox pbEgg = new PictureBox();

        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300;

        int yEgg = 0;

        int xDelta = 3;

        int yDelta = 3;
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 10;

            tmEgg.Tick += tmEgg_Tick;

            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;

            pbEgg.Size = new Size(100, 100);

            pbEgg.Location = new Point(xEgg, yEgg);

            pbEgg.BackColor = Color.Transparent;

            this.Controls.Add(pbEgg);

            string imagePath = @"D:\TruongMinhMan\Example\Example\Images\egg_gold.jpg";  // Thay thế bằng đường dẫn tuyệt đối tới hình ảnh
            if (System.IO.File.Exists(imagePath))
            {
                pbEgg.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("File không tồn tại: " + imagePath);
            }
        }
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDelta;

            // Kiểm tra nếu trứng chạm đáy của form
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                string imagePath = @"D:\TruongMinhMan\Example\Example\Images\egg_gold_broken.jpg";  // Thay thế bằng đường dẫn tuyệt đối tới hình ảnh
                if (System.IO.File.Exists(imagePath))
                {
                    pbEgg.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("File không tồn tại: " + imagePath);
                }
                yDelta = -yDelta;  // Đảo ngược hướng di chuyển nếu chạm vào biên
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

    }
}
