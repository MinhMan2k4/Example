namespace Example
{
    partial class QLSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            sinhVienToolStripMenuItem = new ToolStripMenuItem();
            monHocToolStripMenuItem = new ToolStripMenuItem();
            giaoVienToolStripMenuItem = new ToolStripMenuItem();
            lopHocToolStripMenuItem = new ToolStripMenuItem();
            chucNangToolStripMenuItem = new ToolStripMenuItem();
            dangKyToolStripMenuItem = new ToolStripMenuItem();
            traCuuDiemToolStripMenuItem = new ToolStripMenuItem();
            quanLyLopToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quanLyToolStripMenuItem, chucNangToolStripMenuItem, quanLyLopToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(945, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thoatToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(145, 22);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(145, 22);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhVienToolStripMenuItem, monHocToolStripMenuItem, giaoVienToolStripMenuItem, lopHocToolStripMenuItem });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(60, 20);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            sinhVienToolStripMenuItem.Size = new Size(123, 22);
            sinhVienToolStripMenuItem.Text = "Sinh viên";
            sinhVienToolStripMenuItem.Click += sinhVienToolStripMenuItem_Click;
            // 
            // monHocToolStripMenuItem
            // 
            monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            monHocToolStripMenuItem.Size = new Size(123, 22);
            monHocToolStripMenuItem.Text = "Môn học";
            monHocToolStripMenuItem.Click += monHocToolStripMenuItem_Click;
            // 
            // giaoVienToolStripMenuItem
            // 
            giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            giaoVienToolStripMenuItem.Size = new Size(123, 22);
            giaoVienToolStripMenuItem.Text = "Giáo viên";
            giaoVienToolStripMenuItem.Click += giaoVienToolStripMenuItem_Click;
            // 
            // lopHocToolStripMenuItem
            // 
            lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            lopHocToolStripMenuItem.Size = new Size(123, 22);
            lopHocToolStripMenuItem.Text = "Lớp hoc";
            lopHocToolStripMenuItem.Click += lopHocToolStripMenuItem_Click;
            // 
            // chucNangToolStripMenuItem
            // 
            chucNangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangKyToolStripMenuItem, traCuuDiemToolStripMenuItem });
            chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            chucNangToolStripMenuItem.Size = new Size(77, 20);
            chucNangToolStripMenuItem.Text = "Chức năng";
            chucNangToolStripMenuItem.Click += dangKyToolStripMenuItem_Click;
            // 
            // dangKyToolStripMenuItem
            // 
            dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            dangKyToolStripMenuItem.Size = new Size(168, 22);
            dangKyToolStripMenuItem.Text = "Đăng ký môn học";
            dangKyToolStripMenuItem.Click += dangKyToolStripMenuItem_Click;
            // 
            // traCuuDiemToolStripMenuItem
            // 
            traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            traCuuDiemToolStripMenuItem.Size = new Size(168, 22);
            traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            traCuuDiemToolStripMenuItem.Click += traCuuDiemToolStripMenuItem_Click;
            // 
            // quanLyLopToolStripMenuItem
            // 
            quanLyLopToolStripMenuItem.Name = "quanLyLopToolStripMenuItem";
            quanLyLopToolStripMenuItem.Size = new Size(80, 20);
            quanLyLopToolStripMenuItem.Text = "Quản lý lớp";
            quanLyLopToolStripMenuItem.Click += quanLyLopToolStripMenuItem_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 24);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(945, 432);
            pnlContent.TabIndex = 1;
            // 
            // QLSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 456);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QLSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLSV";
            Load += QLSV_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem sinhVienToolStripMenuItem;
        private ToolStripMenuItem monHocToolStripMenuItem;
        private ToolStripMenuItem giaoVienToolStripMenuItem;
        private ToolStripMenuItem lopHocToolStripMenuItem;
        private ToolStripMenuItem chucNangToolStripMenuItem;
        private Panel pnlContent;
        private ToolStripMenuItem quanLyLopToolStripMenuItem;
        private ToolStripMenuItem dangKyToolStripMenuItem;
        private ToolStripMenuItem traCuuDiemToolStripMenuItem;
    }
}