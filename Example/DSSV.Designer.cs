namespace Example
{
    partial class DSSV
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
            dgvSinhVien = new DataGridView();
            label1 = new Label();
            txtTukhoa = new TextBox();
            btnTimkiem = new Button();
            btnThemmoi = new Button();
            btnSuaSV = new Button();
            btnXoaSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(0, 84);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(800, 366);
            dgvSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(102, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Từ khoá";
            // 
            // txtTukhoa
            // 
            txtTukhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTukhoa.Location = new Point(188, 23);
            txtTukhoa.Name = "txtTukhoa";
            txtTukhoa.Size = new Size(164, 23);
            txtTukhoa.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.Location = new Point(358, 22);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(75, 23);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(468, 22);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(75, 23);
            btnThemmoi.TabIndex = 4;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // btnSuaSV
            // 
            btnSuaSV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSuaSV.Location = new Point(576, 22);
            btnSuaSV.Name = "btnSuaSV";
            btnSuaSV.Size = new Size(75, 23);
            btnSuaSV.TabIndex = 5;
            btnSuaSV.Text = "Sửa";
            btnSuaSV.UseVisualStyleBackColor = true;
            btnSuaSV.Click += btnSuaSV_Click;
            // 
            // btnXoaSV
            // 
            btnXoaSV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaSV.Location = new Point(692, 22);
            btnXoaSV.Name = "btnXoaSV";
            btnXoaSV.Size = new Size(75, 23);
            btnXoaSV.TabIndex = 6;
            btnXoaSV.Text = "Xoá";
            btnXoaSV.UseVisualStyleBackColor = true;
            btnXoaSV.Click += btnXoaSV_Click;
            // 
            // DSSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoaSV);
            Controls.Add(btnSuaSV);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTukhoa);
            Controls.Add(label1);
            Controls.Add(dgvSinhVien);
            Name = "DSSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách sinh viên";
            Load += DSSV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Label label1;
        private TextBox txtTukhoa;
        private Button btnTimkiem;
        private Button btnThemmoi;
        private Button btnSuaSV;
        private Button btnXoaSV;
    }
}