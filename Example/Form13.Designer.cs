namespace Example
{
    partial class Form13
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
            button2 = new Button();
            btOK = new Button();
            tbDisplay = new TextBox();
            cb_Faculty = new ComboBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(325, 274);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            btOK.Location = new Point(422, 274);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 6;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(256, 107);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(241, 145);
            tbDisplay.TabIndex = 5;
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngoại ngữ", "Quản trị kinh doanh", "Cơ khí", "Điện", "Cơ khí động học" });
            cb_Faculty.Location = new Point(254, 66);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(243, 23);
            cb_Faculty.TabIndex = 4;
            cb_Faculty.SelectedIndexChanged += cb_Faculty_SelectedIndexChanged;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btOK);
            Controls.Add(tbDisplay);
            Controls.Add(cb_Faculty);
            Name = "Form13";
            Text = "Form13";
            Load += Form13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btOK;
        private TextBox tbDisplay;
        private ComboBox cb_Faculty;
    }
}