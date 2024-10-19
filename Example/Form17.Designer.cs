namespace Example
{
    partial class Form17
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
            label1 = new Label();
            label2 = new Label();
            btSelect = new Button();
            btDeselect = new Button();
            btSelectAll = new Button();
            btDeselectAll = new Button();
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bài hát ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 35);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 1;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // btSelect
            // 
            btSelect.Location = new Point(347, 67);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(56, 47);
            btSelect.TabIndex = 4;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(347, 135);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(56, 47);
            btDeselect.TabIndex = 5;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            // 
            // btSelectAll
            // 
            btSelectAll.Location = new Point(347, 200);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(56, 47);
            btSelectAll.TabIndex = 6;
            btSelectAll.Text = ">>";
            btSelectAll.UseVisualStyleBackColor = true;
            btSelectAll.Click += btSelectAll_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.Location = new Point(347, 268);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(56, 47);
            btDeselectAll.TabIndex = 7;
            btDeselectAll.Text = "<<";
            btDeselectAll.UseVisualStyleBackColor = true;
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.ItemHeight = 15;
            lbSong.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi Mắt Pleiku", "Em Muốn Sống Bên Anh Trọn Đời", "H'Zen Lên Rẫy", "Còn Thương Nhau Thì Về Buôn Mê Thuột", "Ly Cà Phê Ban Mê", "Đi tìm lời ru mặt trời" });
            lbSong.Location = new Point(93, 67);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(229, 304);
            lbSong.TabIndex = 8;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.ItemHeight = 15;
            lbFavorite.Location = new Point(435, 67);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(229, 304);
            lbFavorite.TabIndex = 9;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Controls.Add(btDeselectAll);
            Controls.Add(btSelectAll);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form17";
            Text = "Form17";
            Load += Form17_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btSelect;
        private Button btDeselect;
        private Button btSelectAll;
        private Button btDeselectAll;
        private ListBox lbSong;
        private ListBox lbFavorite;
    }
}