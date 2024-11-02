namespace Example
{
    partial class DSMH
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
            dgvDSMH = new DataGridView();
            btnThemmoi = new Button();
            btnTimkiem = new Button();
            txtTukhoa = new TextBox();
            label1 = new Label();
            btnSua = new Button();
            btnXoaMH = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMH
            // 
            dgvDSMH.AllowUserToAddRows = false;
            dgvDSMH.AllowUserToDeleteRows = false;
            dgvDSMH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMH.Location = new Point(0, 94);
            dgvDSMH.MultiSelect = false;
            dgvDSMH.Name = "dgvDSMH";
            dgvDSMH.ReadOnly = true;
            dgvDSMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMH.Size = new Size(800, 356);
            dgvDSMH.TabIndex = 0;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(513, 27);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(75, 23);
            btnThemmoi.TabIndex = 12;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.Location = new Point(408, 27);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(75, 23);
            btnTimkiem.TabIndex = 11;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTukhoa
            // 
            txtTukhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTukhoa.Location = new Point(238, 28);
            txtTukhoa.Name = "txtTukhoa";
            txtTukhoa.Size = new Size(164, 23);
            txtTukhoa.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(144, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 9;
            label1.Text = "Từ khoá";
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(616, 27);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoaMH
            // 
            btnXoaMH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaMH.Location = new Point(713, 27);
            btnXoaMH.Name = "btnXoaMH";
            btnXoaMH.Size = new Size(75, 23);
            btnXoaMH.TabIndex = 14;
            btnXoaMH.Text = "Xoá";
            btnXoaMH.UseVisualStyleBackColor = true;
            btnXoaMH.Click += btnXoaMH_Click;
            // 
            // DSMH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoaMH);
            Controls.Add(btnSua);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTukhoa);
            Controls.Add(label1);
            Controls.Add(dgvDSMH);
            Name = "DSMH";
            Text = "Danh sách môn học";
            Load += DSMH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMH;
        private Button btnThemmoi;
        private Button btnTimkiem;
        private TextBox txtTukhoa;
        private Label label1;
        private Button btnSua;
        private Button btnXoaMH;
    }
}