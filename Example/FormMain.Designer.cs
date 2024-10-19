namespace Example
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            txtSoDT = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtMaHS = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            dgvHocSinh = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 18);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Quản lý học sinh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaHS);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 129);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học sinh";
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(418, 65);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(195, 25);
            txtSoDT.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(418, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 25);
            txtEmail.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(115, 70);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(186, 25);
            txtHoTen.TabIndex = 5;
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(115, 24);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(186, 25);
            txtMaHS.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 73);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 3;
            label5.Text = "Số ĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 27);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 78);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 34);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 0;
            label2.Text = "MSHS";
            // 
            // btThem
            // 
            btThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.Location = new Point(71, 207);
            btThem.Name = "btThem";
            btThem.Size = new Size(75, 23);
            btThem.TabIndex = 2;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSua.Location = new Point(191, 207);
            btSua.Name = "btSua";
            btSua.Size = new Size(75, 23);
            btSua.TabIndex = 3;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(300, 207);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(75, 23);
            btXoa.TabIndex = 4;
            btXoa.Text = "Xoá";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(410, 207);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(525, 207);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(117, 246);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.Size = new Size(441, 150);
            dgvHocSinh.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 408);
            Controls.Add(dgvHocSinh);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSoDT;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtMaHS;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Button btnReset;
        private Button btnThoat;
        private DataGridView dgvHocSinh;
    }
}