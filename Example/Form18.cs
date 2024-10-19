using System;
using System.Collections;
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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            lbSong.DataSource = lst;

            lbSong.DisplayMember = "Name";
        }
        public ArrayList GetData()
        {

            ArrayList lst = new ArrayList();

            Song s = new Song();

            s.Id = 53418;

            s.Name = "Giấc mơ cha pi"; s.Author = "Trần Tiến";

            lst.Add(s);

            s = new Song();

            s.Id = 52616;

            s.Name = "Đôi mắt pleiku";

            s.Author = "Nguyễn Cường";

            lst.Add(s);

            s = new Song();

            s.Id = 51172;

            s.Name = "Em muốn sống bên anh chọn đời";

            s.Author = "Nguyễn Cường";

            lst.Add(s);

            return lst;

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbSong.SelectedItem;

            string id = song.Id.ToString();

            string name = song.Name;

            string author = song.Author;

            lbFavorite.Items.Add(id + " - " + name + " - " + author);
            //lbSong.Items.Remove(song);
        }

        //private void btDeselect_Click(object sender, EventArgs e)
        //{
        //    if (lbFavorite.SelectedItem != null)
        //    {
        //        Song song = (Song)lbFavorite.SelectedItem;

        //        // Xóa bài hát khỏi lbFavorite nhưng không xóa khỏi dữ liệu gốc
        //        lbFavorite.Items.Remove(song); // Chỉ xóa khỏi danh sách yêu thích, không xóa bài hát
        //    }
        //}
    }
}
