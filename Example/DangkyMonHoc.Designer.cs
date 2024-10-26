namespace Example
{
    partial class DangkyMonHoc
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
            dgvDSLH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLH
            // 
            dgvDSLH.AllowUserToAddRows = false;
            dgvDSLH.AllowUserToDeleteRows = false;
            dgvDSLH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLH.Location = new Point(12, 12);
            dgvDSLH.Name = "dgvDSLH";
            dgvDSLH.ReadOnly = true;
            dgvDSLH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLH.Size = new Size(776, 426);
            dgvDSLH.TabIndex = 0;
            dgvDSLH.CellDoubleClick += dgvDSLH_CellDoubleClick;
            // 
            // DangkyMonHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDSLH);
            Name = "DangkyMonHoc";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách lớp học";
            Load += DangkyMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSLH;
    }
}