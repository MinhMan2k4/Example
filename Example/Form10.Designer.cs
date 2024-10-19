namespace Example
{
    partial class Form10
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btEquals = new Button();
            btMul = new Button();
            btPlus = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(181, 92);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(297, 38);
            tbDisplay.TabIndex = 0;
            // 
            // bt0
            // 
            bt0.Location = new Point(181, 148);
            bt0.Name = "bt0";
            bt0.Size = new Size(60, 48);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(259, 148);
            bt1.Name = "bt1";
            bt1.Size = new Size(60, 48);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(344, 148);
            bt2.Name = "bt2";
            bt2.Size = new Size(60, 48);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(418, 148);
            bt3.Name = "bt3";
            bt3.Size = new Size(60, 48);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // btEquals
            // 
            btEquals.Location = new Point(418, 216);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(60, 48);
            btEquals.TabIndex = 8;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // btMul
            // 
            btMul.Location = new Point(259, 216);
            btMul.Name = "btMul";
            btMul.Size = new Size(60, 48);
            btMul.TabIndex = 6;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += btMul_Click_1;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(181, 216);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(60, 48);
            btPlus.TabIndex = 5;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // button1
            // 
            button1.Location = new Point(344, 216);
            button1.Name = "button1";
            button1.Size = new Size(60, 48);
            button1.TabIndex = 9;
            button1.Text = ".";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btEquals);
            Controls.Add(btMul);
            Controls.Add(btPlus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btEquals;
        private Button btMul;
        private Button btPlus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
    }
}