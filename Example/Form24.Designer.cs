namespace Example
{
    partial class Form24
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
            components = new System.ComponentModel.Container();
            btStart = new Button();
            btStop = new Button();
            tmStopwatch = new System.Windows.Forms.Timer(components);
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.Location = new Point(228, 175);
            btStart.Name = "btStart";
            btStart.Size = new Size(75, 23);
            btStart.TabIndex = 0;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(319, 175);
            btStop.Name = "btStop";
            btStop.Size = new Size(75, 23);
            btStop.TabIndex = 1;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // tmStopwatch
            // 
            tmStopwatch.Tick += tmStopwatch_Tick;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(250, 115);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(34, 15);
            lblDisplay.TabIndex = 2;
            lblDisplay.Text = "00:00";
            // 
            // Form24
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDisplay);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Name = "Form24";
            Text = "Form24";
            Load += Form24_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btStart;
        private Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;
        private Label lblDisplay;
    }
}