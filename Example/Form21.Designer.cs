namespace Example
{
    partial class Form21
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
            button3 = new Button();
            btDelete = new Button();
            btAddNew = new Button();
            ckGender = new CheckBox();
            tbAge = new TextBox();
            tbName = new TextBox();
            tbId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvEmployee = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(369, 386);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(277, 386);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 20;
            btDelete.Text = "Xoá";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(183, 386);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(75, 23);
            btAddNew.TabIndex = 19;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(91, 332);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(52, 19);
            ckGender.TabIndex = 18;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(107, 265);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 23);
            tbAge.TabIndex = 17;
            // 
            // tbName
            // 
            tbName.Location = new Point(107, 223);
            tbName.Name = "tbName";
            tbName.Size = new Size(165, 23);
            tbName.TabIndex = 16;
            // 
            // tbId
            // 
            tbId.Location = new Point(107, 183);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 273);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Tuổi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 231);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 13;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 191);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 12;
            label1.Text = "Mã";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Age, Gender });
            dgvEmployee.Location = new Point(25, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(447, 150);
            dgvEmployee.TabIndex = 11;
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
            // Form21
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
            //Name = "Form21";
            Text = "Form21";
            Load += Form21_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button btDelete;
        private Button btAddNew;
        private CheckBox ckGender;
        private TextBox tbAge;
        private TextBox tbName;
        private TextBox tbId;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
    }
}