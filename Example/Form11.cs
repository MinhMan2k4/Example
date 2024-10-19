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
    public partial class Form11 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public Form11()
        {
            InitializeComponent();

            // Register all button click events
            bt0.Click += new EventHandler(Button_Click);
            bt1.Click += new EventHandler(Button_Click);
            bt2.Click += new EventHandler(Button_Click);
            bt3.Click += new EventHandler(Button_Click);
            bt4.Click += new EventHandler(Button_Click);
            bt5.Click += new EventHandler(Button_Click);
            bt6.Click += new EventHandler(Button_Click);
            bt7.Click += new EventHandler(Button_Click);
            bt8.Click += new EventHandler(Button_Click);
            bt9.Click += new EventHandler(Button_Click);

            // Register operators
            btPlus.Click += new EventHandler(Button_Click);
            btMinus.Click += new EventHandler(Button_Click);
            btMul.Click += new EventHandler(Button_Click);
            btInto.Click += new EventHandler(Button_Click);
            btEquals.Click += new EventHandler(Button_Click);
            btDot.Click += new EventHandler(Button_Click);

            // Register memory buttons
            button1.Click += new EventHandler(Button_Click); // MC
            button2.Click += new EventHandler(Button_Click); // MR
            button3.Click += new EventHandler(Button_Click); // MS
            button4.Click += new EventHandler(Button_Click); // M+
            button5.Click += new EventHandler(Button_Click); // M-

            // Register special function buttons
            button6.Click += new EventHandler(Button_Click); // √
            button7.Click += new EventHandler(Button_Click); // ±
            button8.Click += new EventHandler(Button_Click); // C
            button9.Click += new EventHandler(Button_Click); // CE
            button10.Click += new EventHandler(Button_Click); // Backspace (←)
            button11.Click += new EventHandler(Button_Click); // %

            button16.Click += new EventHandler(Button_Click); // 1/x
        }


        private void Form11_Load(object sender, EventArgs e)
        {
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // Handle digit and decimal point input
            if (char.IsDigit(bt.Text, 0) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            // Handle basic arithmetic operators
            else if (bt.Text == "+" || bt.Text == "-" || bt.Text == "*" || bt.Text == "/")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            // Handle equals button click
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+":
                        txtDisplay.Text = (workingMemory + secondValue).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (workingMemory - secondValue).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (workingMemory * secondValue).ToString();
                        break;
                    case "/":
                        txtDisplay.Text = (secondValue != 0) ? (workingMemory / secondValue).ToString() : "Error";
                        break;
                }
            }
            else if (bt.Text == "+/-")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal != 0)
                {
                    currVal = 1 / currVal;
                    txtDisplay.Text = currVal.ToString();
                }
                else
                {
                    txtDisplay.Text = "Error";
                }
            }

            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                }
            }

            else if (bt.Text == "MC")
            {
                memory = 0;
            }

            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }

            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }

            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(txtDisplay.Text);
            }

            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(txtDisplay.Text);
            }

            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }

            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }
        }
    }
}

