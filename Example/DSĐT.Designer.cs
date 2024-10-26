namespace Example
{
    partial class DSĐT
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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThem = new Button();
            cbbMonHoc = new ComboBox();
            dgvDiemThi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(323, 82);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ khoá";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Môn học";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(381, 75);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(216, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(603, 75);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(684, 74);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(93, 74);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(138, 23);
            cbbMonHoc.TabIndex = 5;
            // 
            // dgvDiemThi
            // 
            dgvDiemThi.AllowUserToAddRows = false;
            dgvDiemThi.AllowUserToDeleteRows = false;
            dgvDiemThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiemThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemThi.Location = new Point(12, 120);
            dgvDiemThi.Name = "dgvDiemThi";
            dgvDiemThi.ReadOnly = true;
            dgvDiemThi.Size = new Size(776, 318);
            dgvDiemThi.TabIndex = 6;
            // 
            // DSĐT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDiemThi);
            Controls.Add(cbbMonHoc);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DSĐT";
            Text = "DSĐT";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThem;
        private ComboBox cbbMonHoc;
        private DataGridView dgvDiemThi;
    }
}