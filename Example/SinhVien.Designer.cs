namespace Example
{
    partial class SinhVien
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
            txtHo = new TextBox();
            txtTendem = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            mtbNgaysinh = new MaskedTextBox();
            label5 = new Label();
            rbtNam = new RadioButton();
            rbtNu = new RadioButton();
            txtQuequan = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDienthoai = new TextBox();
            label8 = new Label();
            btnLuu = new Button();
            button2 = new Button();
            txtDiachi = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(202, 33);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(219, 23);
            txtHo.TabIndex = 1;
            // 
            // txtTendem
            // 
            txtTendem.Location = new Point(202, 76);
            txtTendem.Name = "txtTendem";
            txtTendem.Size = new Size(219, 23);
            txtTendem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên đệm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(202, 115);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(219, 23);
            txtTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 123);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 162);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Ngày sinh";
            // 
            // mtbNgaysinh
            // 
            mtbNgaysinh.Location = new Point(202, 154);
            mtbNgaysinh.Mask = "00/00/0000";
            mtbNgaysinh.Name = "mtbNgaysinh";
            mtbNgaysinh.Size = new Size(112, 23);
            mtbNgaysinh.TabIndex = 7;
            mtbNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 193);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Giới tính";
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Location = new Point(202, 189);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(51, 19);
            rbtNam.TabIndex = 9;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(327, 189);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(41, 19);
            rbtNu.TabIndex = 10;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtQuequan
            // 
            txtQuequan.Location = new Point(202, 214);
            txtQuequan.Name = "txtQuequan";
            txtQuequan.Size = new Size(219, 23);
            txtQuequan.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 222);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 11;
            label6.Text = "Quê quán";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 280);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(202, 303);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(219, 23);
            txtDienthoai.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 311);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 15;
            label8.Text = "Điện thoại";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(202, 347);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 17;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // button2
            // 
            button2.Location = new Point(346, 347);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Huỷ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(202, 243);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(219, 23);
            txtDiachi.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 251);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 19;
            label9.Text = "Địa chỉ";
            // 
            // SinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 396);
            Controls.Add(txtDiachi);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(btnLuu);
            Controls.Add(txtDienthoai);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtQuequan);
            Controls.Add(label6);
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
            Name = "SinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SinhVien";
            Load += SinhVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHo;
        private TextBox txtTendem;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtbNgaysinh;
        private Label label5;
        private RadioButton rbtNam;
        private RadioButton rbtNu;
        private TextBox txtQuequan;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDienthoai;
        private Label label8;
        private Button btnLuu;
        private Button button2;
        private TextBox txtDiachi;
        private Label label9;
    }
}