namespace Example
{
    partial class DSGV
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
            btnThemmoi = new Button();
            btnTimkiem = new Button();
            txtTukhoa = new TextBox();
            label1 = new Label();
            dgvDSGV = new DataGridView();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).BeginInit();
            SuspendLayout();
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(595, 31);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(75, 23);
            btnThemmoi.TabIndex = 8;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.Location = new Point(492, 31);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(75, 23);
            btnTimkiem.TabIndex = 7;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTukhoa
            // 
            txtTukhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTukhoa.Location = new Point(322, 32);
            txtTukhoa.Name = "txtTukhoa";
            txtTukhoa.Size = new Size(164, 23);
            txtTukhoa.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(226, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Từ khoá";
            // 
            // dgvDSGV
            // 
            dgvDSGV.AllowUserToAddRows = false;
            dgvDSGV.AllowUserToDeleteRows = false;
            dgvDSGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSGV.Location = new Point(0, 92);
            dgvDSGV.MultiSelect = false;
            dgvDSGV.Name = "dgvDSGV";
            dgvDSGV.ReadOnly = true;
            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSGV.Size = new Size(800, 358);
            dgvDSGV.TabIndex = 9;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(697, 31);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // DSGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(dgvDSGV);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTukhoa);
            Controls.Add(label1);
            Name = "DSGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách giáo viên";
            Load += DSGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemmoi;
        private Button btnTimkiem;
        private TextBox txtTukhoa;
        private Label label1;
        private DataGridView dgvDSGV;
        private Button btnSua;
    }
}