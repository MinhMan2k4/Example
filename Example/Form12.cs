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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;

            tbDisplay.Text = "Bạn đã chọn khoa thứ:" + index.ToString(); 
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();

            tbDisplay.Text = "Bạn la sinh viên khoa:" + item; 
        }
    }
}


