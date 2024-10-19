namespace Example
{
    partial class Form08
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
            label3 = new Label();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 81);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "So X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 116);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "So Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 160);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Ket Qua";
            // 
            // btCong
            // 
            btCong.Location = new Point(80, 215);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 3;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(182, 215);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 4;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(373, 215);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(159, 73);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(289, 23);
            tbSoX.TabIndex = 6;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(159, 113);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(289, 23);
            tbSoY.TabIndex = 7;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(159, 152);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(289, 23);
            tbKetQua.TabIndex = 8;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
    }
}