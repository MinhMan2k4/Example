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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        List<Employee> empList;

        BindingSource bs = new BindingSource();

        public List<Employee> GetData()
        {
            List<Employee> empList = new List<Employee>();

            // Thêm một số nhân viên mẫu (có thể bỏ qua hoặc giữ lại)
            empList.Add(new Employee { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
            empList.Add(new Employee { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });
            empList.Add(new Employee { Id = "53417", Name = "Nguyễn Hào", Age = 23, Gender = true });

            return empList;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            empList = GetData();

            bs.DataSource = empList;

            dgvEmployee.DataSource = bs;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();

            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text);
            em.Gender = ckGender.Checked;

            empList.Add(em);   // Thêm vào danh sách

            bs.ResetBindings(false);  // Cập nhật BindingSource
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;

            bs.RemoveAt(idx);

            empList.RemoveAt(idx);
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();

            tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();

            tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
        }
    }
}
