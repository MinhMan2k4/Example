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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            cb_Faculty.DataSource = lst;

            cb_Faculty.DisplayMember = "Name";
        }

        public ArrayList GetData()
        {
            ArrayList faculties = new ArrayList();  

            Faculty f = new Faculty();

            
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            faculties.Add(f);  

            
            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            faculties.Add(f);

           
            f = new Faculty();
            f.Id = "K03";  
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            faculties.Add(f);

            return faculties;  
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";

            string id = cb_Faculty.SelectedValue.ToString();

            tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id; 
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";

            string name = cb_Faculty.SelectedValue.ToString();

            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }
    }
}
