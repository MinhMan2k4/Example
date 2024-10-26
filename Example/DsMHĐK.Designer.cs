namespace Example
{
    partial class DsMHĐK
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
            dgvDSMHHDky = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnDangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMHHDky).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMHHDky
            // 
            dgvDSMHHDky.AllowUserToAddRows = false;
            dgvDSMHHDky.AllowUserToDeleteRows = false;
            dgvDSMHHDky.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSMHHDky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMHHDky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMHHDky.Location = new Point(12, 70);
            dgvDSMHHDky.MultiSelect = false;
            dgvDSMHHDky.Name = "dgvDSMHHDky";
            dgvDSMHHDky.ReadOnly = true;
            dgvDSMHHDky.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMHHDky.Size = new Size(776, 368);
            dgvDSMHHDky.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(294, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Từ khoá";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(363, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(191, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(576, 24);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            btnDangKy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDangKy.Location = new Point(657, 24);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(131, 23);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký mới";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // DsMHĐK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvDSMHHDky);
            Name = "DsMHĐK";
            Text = "Danh sách môn học đã đăng ký";
            Load += DsMHĐK_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMHHDky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMHHDky;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnDangKy;
    }
}