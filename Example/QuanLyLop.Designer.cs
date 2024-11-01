namespace Example
{
    partial class QuanLyLop
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
            dgvQLLop = new DataGridView();
            btnTraCuu = new Button();
            txtTuKhoa = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQLLop).BeginInit();
            SuspendLayout();
            // 
            // dgvQLLop
            // 
            dgvQLLop.AllowUserToAddRows = false;
            dgvQLLop.AllowUserToDeleteRows = false;
            dgvQLLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQLLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLLop.Location = new Point(12, 67);
            dgvQLLop.Name = "dgvQLLop";
            dgvQLLop.ReadOnly = true;
            dgvQLLop.Size = new Size(776, 368);
            dgvQLLop.TabIndex = 7;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTraCuu.Location = new Point(688, 20);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(75, 23);
            btnTraCuu.TabIndex = 6;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(487, 16);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(166, 23);
            txtTuKhoa.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(425, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm";
            // 
            // QuanLyLop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvQLLop);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "QuanLyLop";
            Text = "QuanLyLop";
            Load += QuanLyLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQLLop;
        private Button btnTraCuu;
        private TextBox txtTuKhoa;
        private Label label1;
    }
}