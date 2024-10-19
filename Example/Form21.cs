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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        List<Employee> lst;
        private void Form21_Load(object sender, EventArgs e)
        {
            lst = GetData();

            foreach (Employee em in lst)

            {

                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age);

            }
        }
        public List<Employee> GetData()
        {

            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();

            em.Id = "53418";

            em.Name = "Trần Tiến";

            em.Age = 20;

            lst.Add(em);

            em = new Employee();

            em.Id = "53416";

            em.Name = "Nguyễn Cường";

            em.Age = 25;

            lst.Add(em);

            em = new Employee();

            em.Id = "53417";

            em.Name = "Nguyễn Hào";

            em.Age = 23;

            lst.Add(em);

            return lst;

        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee
            {
                Id = tbId.Text,
                Name = tbName.Text,
                Age = int.Parse(tbAge.Text),  // Chuyển chuỗi thành số nguyên
                Gender = ckGender.Checked
            };

            lst.Add(em);

            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender ? "Nam" : "Nữ");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;

            lst.RemoveAt(idx);

            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();

            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();

            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
