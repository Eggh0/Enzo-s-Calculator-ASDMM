using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Assesment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label3.Text = "Total: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;

                label3.Text = "Difference: " + c.ToString();

            }

            if (radioButton4.Checked)
            {
                c = a * b;
                label3.Text = "Product: " + c.ToString();

            }

            if (radioButton3.Checked)
            {
                c = a / b;
                label3.Text = "Mean:  " + c.ToString();
            }
            if (radioButton6.Checked)
            {
                c = a % b;
                label3.Text = "Mod: " + c.ToString();
            }


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = " ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}