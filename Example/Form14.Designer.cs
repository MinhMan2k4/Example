namespace Example
{
    partial class Form14
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
            tbName = new TextBox();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            tbResult = new TextBox();
            button1 = new Button();
            btRun = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(79, 41);
            tbName.Name = "tbName";
            tbName.Size = new Size(289, 23);
            tbName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(79, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(163, 41);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(41, 19);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            //rbFemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(27, 41);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            ckDiscount.AutoSize = true;
            ckDiscount.Location = new Point(79, 215);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(73, 19);
            ckDiscount.TabIndex = 2;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.UseVisualStyleBackColor = true;
            ckDiscount.CheckedChanged += ckDiscount_CheckedChanged;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(183, 211);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(185, 23);
            tbDiscount.TabIndex = 3;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(79, 250);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(289, 121);
            tbResult.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(293, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btRun
            // 
            btRun.Location = new Point(183, 393);
            btRun.Name = "btRun";
            btRun.Size = new Size(75, 23);
            btRun.TabIndex = 6;
            btRun.Text = "Tính tiền";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRun);
            Controls.Add(button1);
            Controls.Add(tbResult);
            Controls.Add(tbDiscount);
            Controls.Add(ckDiscount);
            Controls.Add(groupBox1);
            Controls.Add(tbName);
            Name = "Form14";
            Text = "Form14";
            Load += Form14_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private CheckBox ckDiscount;
        private TextBox tbDiscount;
        private TextBox tbResult;
        private Button button1;
        private Button btRun;
    }
}