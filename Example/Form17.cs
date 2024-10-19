using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();

            btSelect.Click += new EventHandler(btSelect_Click);
            btDeselect.Click += new EventHandler(btDeselect_Click);
            btSelectAll.Click += new EventHandler(btSelectAll_Click);
            btDeselectAll.Click += new EventHandler(btDeselectAll_Click);
            lbSong.MouseDoubleClick += new MouseEventHandler(lbSong_MouseDoubleClick);
            lbFavorite.MouseDoubleClick += new MouseEventHandler(lbFavorite_MouseDoubleClick);
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            // Chuyển bài hát từ lbSong sang lbFavorite khi nhấn nút Select
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }

        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            // Chuyển bài hát từ lbFavorite về lbSong khi nhấn nút Deselect
            if (lbFavorite.SelectedItem != null)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Chuyển tất cả bài hát từ lbSong sang lbFavorite
            while (lbSong.Items.Count > 0)
            {
                string song = lbSong.Items[0].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(0);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            // Chuyển tất cả bài hát từ lbFavorite về lbSong
            while (lbFavorite.Items.Count > 0)
            {
                string song = lbFavorite.Items[0].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(0);
            }
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Xử lý khi nhấp đúp để chuyển bài hát từ lbSong sang lbFavorite
            int index = lbSong.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Xử lý khi nhấp đúp để chuyển bài hát từ lbFavorite về lại lbSong
            int index = lbFavorite.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}
