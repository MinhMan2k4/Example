namespace Example
{
    partial class MonHoc
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
            label2 = new Label();
            txtTenMH = new TextBox();
            txtSoTC = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 37);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 37);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Số tín chỉ";
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(136, 29);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(291, 23);
            txtTenMH.TabIndex = 2;
            // 
            // txtSoTC
            // 
            txtSoTC.Location = new Point(495, 30);
            txtSoTC.Name = "txtSoTC";
            txtSoTC.Size = new Size(75, 23);
            txtSoTC.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(587, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(686, 29);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // MonHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 104);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtSoTC);
            Controls.Add(txtTenMH);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonHoc";
            Load += MonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenMH;
        private TextBox txtSoTC;
        private Button btnLuu;
        private Button btnHuy;
    }
}