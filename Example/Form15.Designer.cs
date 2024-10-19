namespace Example
{
    partial class Form15
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
            dtpDate = new DateTimePicker();
            btOK = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(278, 69);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(219, 23);
            dtpDate.TabIndex = 0;
            // 
            // btOK
            // 
            btOK.Location = new Point(387, 108);
            btOK.Name = "btOK";
            btOK.Size = new Size(91, 32);
            btOK.TabIndex = 1;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 77);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Date";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btOK);
            Controls.Add(dtpDate);
            Name = "Form15";
            Text = "Form15";
            Load += Form15_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btOK;
        private Label label1;
    }
}