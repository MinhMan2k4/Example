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
    public partial class Form10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
        }

        // Event handlers for buttons
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            try
            {
                workingMemory = decimal.Parse(tbDisplay.Text);
                opr = btPlus.Text;
                tbDisplay.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            try
            {
                decimal secondValue = decimal.Parse(tbDisplay.Text);

                if (opr == "+")
                    tbDisplay.Text = (workingMemory + secondValue).ToString();
                else if (opr == "*")
                    tbDisplay.Text = (workingMemory * secondValue).ToString();
                else
                    MessageBox.Show("Unknown operator");

                opr = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
        }

        private void btMul_Click_1(object sender, EventArgs e)
        {
            try
            {
                workingMemory = decimal.Parse(tbDisplay.Text);
                opr = btMul.Text;
                tbDisplay.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += button1.Text;

        }
    }
}
