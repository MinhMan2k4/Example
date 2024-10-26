namespace Example
{
    partial class LopHoc
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
            label1 = new Label();
            cbbMonHoc = new ComboBox();
            cbbGiaoVien = new ComboBox();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Môn học";
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(100, 26);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(298, 23);
            cbbMonHoc.TabIndex = 1;
            // 
            // cbbGiaoVien
            // 
            cbbGiaoVien.FormattingEnabled = true;
            cbbGiaoVien.Location = new Point(100, 66);
            cbbGiaoVien.Name = "cbbGiaoVien";
            cbbGiaoVien.Size = new Size(298, 23);
            cbbGiaoVien.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 74);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Giáo viên";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(131, 110);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(247, 110);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // LopHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 167);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cbbGiaoVien);
            Controls.Add(label2);
            Controls.Add(cbbMonHoc);
            Controls.Add(label1);
            Name = "LopHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LopHoc";
            Load += LopHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbMonHoc;
        private ComboBox cbbGiaoVien;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
    }
}