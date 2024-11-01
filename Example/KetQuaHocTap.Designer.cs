namespace Example
{
    partial class KetQuaHocTap
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
            txtTuKhoa = new TextBox();
            btnTraCuu = new Button();
            dgvKQHT = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(425, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(487, 31);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(166, 23);
            txtTuKhoa.TabIndex = 1;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTraCuu.Location = new Point(688, 35);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(75, 23);
            btnTraCuu.TabIndex = 2;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // dgvKQHT
            // 
            dgvKQHT.AllowUserToAddRows = false;
            dgvKQHT.AllowUserToDeleteRows = false;
            dgvKQHT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKQHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKQHT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKQHT.Location = new Point(12, 82);
            dgvKQHT.Name = "dgvKQHT";
            dgvKQHT.ReadOnly = true;
            dgvKQHT.Size = new Size(776, 368);
            dgvKQHT.TabIndex = 3;
            // 
            // KetQuaHocTap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKQHT);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "KetQuaHocTap";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết quả học tập";
            Load += KetQuaHocTap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnTraCuu;
        private DataGridView dgvKQHT;
    }
}