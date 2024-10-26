namespace Example
{
    partial class GiaoVien
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
            txtDiachi = new TextBox();
            label9 = new Label();
            button2 = new Button();
            btnLuu = new Button();
            txtDienthoai = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            rbtNu = new RadioButton();
            rbtNam = new RadioButton();
            label5 = new Label();
            mtbNgaysinh = new MaskedTextBox();
            label4 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            txtTendem = new TextBox();
            label2 = new Label();
            txtHo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(212, 216);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(219, 23);
            txtDiachi.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 224);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 40;
            label9.Text = "Địa chỉ";
            // 
            // button2
            // 
            button2.Location = new Point(356, 320);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 39;
            button2.Text = "Huỷ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(212, 320);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 38;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(212, 276);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(219, 23);
            txtDienthoai.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 284);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 36;
            label8.Text = "Điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(212, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 253);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 34;
            label7.Text = "Email";
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(337, 191);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(41, 19);
            rbtNu.TabIndex = 31;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Location = new Point(212, 191);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(51, 19);
            rbtNam.TabIndex = 30;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 195);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 29;
            label5.Text = "Giới tính";
            // 
            // mtbNgaysinh
            // 
            mtbNgaysinh.Location = new Point(212, 156);
            mtbNgaysinh.Mask = "00/00/0000";
            mtbNgaysinh.Name = "mtbNgaysinh";
            mtbNgaysinh.Size = new Size(112, 23);
            mtbNgaysinh.TabIndex = 28;
            mtbNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 164);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 27;
            label4.Text = "Ngày sinh";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(212, 117);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(219, 23);
            txtTen.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 125);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 25;
            label3.Text = "Tên";
            // 
            // txtTendem
            // 
            txtTendem.Location = new Point(212, 78);
            txtTendem.Name = "txtTendem";
            txtTendem.Size = new Size(219, 23);
            txtTendem.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 86);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 23;
            label2.Text = "Tên đệm";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(212, 35);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(219, 23);
            txtHo.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 43);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 21;
            label1.Text = "Họ";
            // 
            // GiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 388);
            Controls.Add(txtDiachi);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(btnLuu);
            Controls.Add(txtDienthoai);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(rbtNu);
            Controls.Add(rbtNam);
            Controls.Add(label5);
            Controls.Add(mtbNgaysinh);
            Controls.Add(label4);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(txtTendem);
            Controls.Add(label2);
            Controls.Add(txtHo);
            Controls.Add(label1);
            Name = "GiaoVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GiaoVien";
            Load += GiaoVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiachi;
        private Label label9;
        private Button button2;
        private Button btnLuu;
        private TextBox txtDienthoai;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private RadioButton rbtNu;
        private RadioButton rbtNam;
        private Label label5;
        private MaskedTextBox mtbNgaysinh;
        private Label label4;
        private TextBox txtTen;
        private Label label3;
        private TextBox txtTendem;
        private Label label2;
        private TextBox txtHo;
        private Label label1;
    }
}