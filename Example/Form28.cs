using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Form28 : Form
    {
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();
      

        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmChicken = new System.Windows.Forms.Timer();

        int xBasket = 300;
        int yBasket = 550;
        int xDeltaBasket = 30;

        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5;

        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 3;

        int score = 0; // Biến lưu trữ điểm

        public Form28()
        {
            InitializeComponent();
            this.KeyPreview = true; // Đảm bảo form nhận sự kiện phím trước các control khác
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            // Thiết lập cho trứng
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            // Thiết lập cho con gà
            tmChicken.Interval = 10;
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            // Thiết lập giỏ
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(70, 70);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            pbBasket.Visible = true;
            this.Controls.Add(pbBasket);

            // Kiểm tra và tải hình ảnh cho giỏ
            try
            {
                pbBasket.Image = new Bitmap(@"D:\TruongMinhMan\Example\Example\Images\basket.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }

            // Thiết lập trứng
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);
            pbEgg.Image = Image.FromFile(@"D:\TruongMinhMan\Example\Example\Images\egg_gold.jpg");

            // Thiết lập con gà
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);
            pbChicken.Image = Image.FromFile(@"D:\TruongMinhMan\Example\Example\Images\chicken.jpg");

            // Thiết lập điểm số
            lblScore.Text = "Score: 0";
            lblScore.Font = new Font("Arial", 16, FontStyle.Bold);
            lblScore.Location = new Point(10, 10); // Đặt vị trí ở góc trên bên trái
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.ForeColor = Color.Black;
            this.Controls.Add(lblScore);  // Thêm Label vào Form
        }

        // Xử lý sự kiện khi trứng di chuyển
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            // Nếu trứng chạm đáy hoặc đỉnh thì bị vỡ
            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                pbEgg.Image = Image.FromFile(@"D:\TruongMinhMan\Example\Example\Images\egg_gold_broken.jpg");
                yDeltaEgg = -yDeltaEgg;  // Đảo ngược hướng rơi của trứng
                UpdateScore(-1); // Trừ điểm khi trứng rơi xuống đáy
            }

            // Kiểm tra va chạm giữa trứng và giỏ
            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (!unionRect.IsEmpty) // Nếu có va chạm với giỏ
            {
                yEgg = 10; // Đặt lại vị trí trứng về trên cùng
                xEgg = pbChicken.Location.X; // Đặt trục X của trứng theo vị trí con gà
                pbEgg.Image = Image.FromFile(@"D:\TruongMinhMan\Example\Example\Images\egg_gold.jpg"); // Reset hình trứng về bình thường
                UpdateScore(1); // Cộng điểm khi bắt được trứng
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        // Xử lý sự kiện khi con gà di chuyển
        void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;

            // Nếu con gà chạm vào biên bên trái hoặc phải thì đổi hướng
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken = -xDeltaChicken;
            }

            pbChicken.Location = new Point(xChicken, yChicken);
        }

        // Xử lý phím điều hướng
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right && xBasket < this.ClientSize.Width - pbBasket.Width)
            {
                xBasket += xDeltaBasket;  // Di chuyển giỏ sang phải
                pbBasket.Location = new Point(xBasket, yBasket);
                return true;
            }

            if (keyData == Keys.Left && xBasket > 0)
            {
                xBasket -= xDeltaBasket;  // Di chuyển giỏ sang trái
                pbBasket.Location = new Point(xBasket, yBasket);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Hàm cập nhật điểm số
        private void UpdateScore(int points)
        {
            score += points;
            if (score < 0)
            {
                score = 0; // Đảm bảo điểm không âm
            }
            lblScore.Text = "Score: " + score;
        }
    }
}
