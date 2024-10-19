namespace Example
{
    partial class Form23
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
            btLeft = new Button();
            btFile = new Button();
            btRight = new Button();
            SuspendLayout();
            // 
            // btLeft
            // 
            btLeft.Location = new Point(89, 188);
            btLeft.Name = "btLeft";
            btLeft.Size = new Size(42, 33);
            btLeft.TabIndex = 0;
            btLeft.Text = "<-";
            btLeft.UseVisualStyleBackColor = true;
            btLeft.Click += btLeft_Click;
            // 
            // btFile
            // 
            btFile.Location = new Point(202, 198);
            btFile.Name = "btFile";
            btFile.Size = new Size(75, 23);
            btFile.TabIndex = 1;
            btFile.Text = "File....";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // btRight
            // 
            btRight.Location = new Point(137, 188);
            btRight.Name = "btRight";
            btRight.Size = new Size(43, 33);
            btRight.TabIndex = 2;
            btRight.Text = "->";
            btRight.UseVisualStyleBackColor = true;
            btRight.Click += btRight_Click;
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRight);
            Controls.Add(btFile);
            Controls.Add(btLeft);
            Name = "Form23";
            Text = "Form23";
            Load += Form23_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btLeft;
        private Button btFile;
        private Button btRight;
    }
}