namespace Example
{
    partial class Form12
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
            cb_Faculty = new ComboBox();
            tbDisplay = new TextBox();
            btOK = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngoại ngữ", "Quản trị kinh doanh", "Cơ khí", "Điện", "Cơ khí động học" });
            cb_Faculty.Location = new Point(223, 63);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(243, 23);
            cb_Faculty.TabIndex = 0;
            cb_Faculty.SelectedIndexChanged += cb_Faculty_SelectedIndexChanged;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(225, 104);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(241, 145);
            tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new Point(391, 271);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 2;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 271);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btOK);
            Controls.Add(tbDisplay);
            Controls.Add(cb_Faculty);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button btOK;
        private Button button2;
    }
}