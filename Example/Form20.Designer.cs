namespace Example
{
    partial class Form20
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
            dgvEmployee = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Age, Gender });
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(447, 150);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Mã nhân viên";
            Id.Name = "Id";
            // 
            // Name
            // 
            Name.HeaderText = "Tên nhân viên";
            Name.Name = "Name";
            // 
            // Age
            // 
            Age.HeaderText = "Tuổi";
            Age.Name = "Age";
            // 
            // Gender
            // 
            Gender.HeaderText = "Giới tính (Nam)";
            Gender.Name = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 191);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 231);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 273);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(94, 183);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(94, 223);
            tbName.Name = "tbName";
            tbName.Size = new Size(165, 23);
            tbName.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(94, 265);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 23);
            tbAge.TabIndex = 6;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(78, 332);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(52, 19);
            ckGender.TabIndex = 7;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(170, 386);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(75, 23);
            btAddNew.TabIndex = 8;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(264, 386);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 9;
            btDelete.Text = "Xoá";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // button3
            // 
            button3.Location = new Point(356, 386);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            //Name = "Form20";
            Text = "Form20";
            Load += Form20_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btDelete;
        private Button button3;
    }
}