﻿namespace Example
{
    partial class Form09
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
            tbKetQua = new TextBox();
            tbSoY = new TextBox();
            tbSoX = new TextBox();
            btThoat = new Button();
            btNhan = new Button();
            btCong = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btLuu = new Button();
            SuspendLayout();
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(191, 141);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(547, 169);
            tbKetQua.TabIndex = 17;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(191, 102);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(547, 23);
            tbSoY.TabIndex = 16;
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(191, 62);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(547, 23);
            tbSoX.TabIndex = 15;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(652, 340);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 14;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(461, 340);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 13;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(359, 340);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 12;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 149);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Ket Qua";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 105);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 10;
            label2.Text = "So Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 70);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "So X";
            // 
            // btLuu
            // 
            btLuu.Location = new Point(105, 340);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(75, 23);
            btLuu.TabIndex = 18;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btLuu);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbKetQua;
        private TextBox tbSoY;
        private TextBox tbSoX;
        private Button btThoat;
        private Button btNhan;
        private Button btCong;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btLuu;
    }
}